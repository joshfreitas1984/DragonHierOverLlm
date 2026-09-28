// ============================================================
// Type  : ChooseController
// Token : 0x20001BB
// ============================================================

public class ChooseController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C01
    public GameObject choosePanel;

    // Token: 0x4000C02
    public GameObject itemList;

    // Token: 0x4000C03
    public GameObject heroList;

    // Token: 0x4000C04
    public GameObject targetGrid;

    // Token: 0x4000C05
    public GameObject chooseRoot;

    // Token: 0x4000C06
    public ChooseType chooseType;

    // Token: 0x4000C07
    public GameObject chooseResult;

    // Token: 0x4000C08
    public GameObject sendResultFucTarget;

    // Token: 0x4000C09
    public string sendResultFuc;

    // Token: 0x4000C0A
    public string sendResultParam;

    // Token: 0x4000C0B
    public string cancelFuc;

    // Token: 0x4000C0C
    private GameObject newObj;

    // Token: 0x4000C0D
    private HeroData targetHero;

    // Token: 0x4000C0E
    private static ChooseController _instance;

    // Token: 0x4000C0F
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E85
    // RVA   : 0x99EC40   Offset: 0x99E040   Length: 0x36
    public static ChooseController get_Instance()
    {
        return **(uint64 **)(DAT_181db7518 + 184);
    }

    // Token : 0x6000E86
    // RVA   : 0x9962D0   Offset: 0x9956D0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181db7518 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000E87
    // RVA   : 0x996D20   Offset: 0x996120   Length: 0x3F6
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
          plVar3 = (int64 *)Component.GetComponent(lVar1,DAT_181d96160);
          lVar1 = FUN_18046c100(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 56) == 0)) break;
          lVar1 = FUN_180002f80(*(int64 *)(lVar1 + 56),local_res8[0],DAT_181d9e108);
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
          plVar3 = (int64 *)Component.GetComponent(lVar1,DAT_181d96160);
          lVar1 = FUN_18046c100(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 56) == 0)) break;
          lVar1 = FUN_180002f80(*(int64 *)(lVar1 + 56),local_res8[0],DAT_181d9e108);
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
          plVar3 = (int64 *)Component.GetComponent(lVar1,DAT_181d96160);
          lVar1 = FUN_18046c100(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 56) == 0)) break;
          lVar1 = FUN_180002f80(*(int64 *)(lVar1 + 56),local_res8[0],DAT_181d9e108);
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

    // Token : 0x6000E88
    // RVA   : 0x998330   Offset: 0x997730   Length: 0x15A
    public void ShowChoosePanel(ChooseType _chooseType, List<HeroData> param, GameObject _sendResultFucTarget, string _sendResultFuc, string _sendResultParam, ChooseFilterType _filterType, string _cancelFuc)
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        int *piVar13;
        uint64 uVar14;
        int64 lVar15;
        int64 *plVar16;
        float fVar17;
        int64 local_res8;
        int local_138;
        int local_134;
        int local_130;
        int local_12c;
        uint32 local_128 [2];
        uint64 *local_120;
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
        plVar16 = (int64 *)0;
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
        plVar12 = plVar16;
        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf348)) {
          plVar12 = plVar6;
        }
        NGUITools.PlaySound(plVar12,0);
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
                  uVar10 = TweenSettingsExtensions.SetEase(uVar10,2,DAT_181dc0f80);
                  TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181dc1db0);
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
                        uVar10 = TweenSettingsExtensions.SetEase(uVar10,2,DAT_181dc0f80);
                        TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181dc1db0);
                        if ((this.choosePanel != null) &&
                           ((lVar7 = GameObject.get_transform(this.choosePanel,0),
                            lVar7 != null && (lVar7 = Transform.Find(lVar7,"BlackBackground",0)) != null)))
                        {
                          plVar6 = (int64 *)Component.GetComponent(lVar7,DAT_181d94460);
                          puVar11 = (uint32 *)FUN_180d98fe0(local_88,0);
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
                              uVar10 = Component.GetComponent(lVar7,DAT_181d94460);
                              uVar10 = DOTweenModuleUI.DOFade(uVar10);
                              TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181dc1c20);
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
                                          lVar7 = FUN_18046c0a0(0);
                                          if ((lVar7 != null) &&
                                             (lVar7 = lVar7.summonControlable, param != null)) {
                                            if (*(int *)(param + 24) == 0) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            plVar6 = *(int64 **)(*(int64 *)(param + 16) + 32);
                                            if ((lVar7 != null) && (plVar6 != (int64 *)0)) {
                                              if (*(int64 *)(*plVar6 + 64) !=
                                                  *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                FUN_1800d6070(plVar6,DAT_181d80418);
                                              }
                                              puVar11 = (uint32 *)il2cpp_object_unbox();
                                              uVar10 = WorldData.GetHero(lVar7,*puVar11,0);
                                              this.targetHero = uVar10;
                                              plVar6 = plVar16;
                                              plVar12 = plVar16;
                                              if (1 < (int)*(uint32 *)(param + 24)) {
                                                if (*(uint32 *)(param + 24) < 2) {
                                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                }
                                                if (*(int64 *)(*(int64 *)(param + 16) + 40) !=
                                                    0) {
                                                  if (*(uint32 *)(param + 24) < 2) {
                                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                  }
                                                  plVar12 = *(int64 **)
                                                             (*(int64 *)(param + 16) + 40);
                                                  if (plVar12 != (int64 *)0) {
                                                    lVar7 = (**(code **)(*plVar12 + 0x168))
                                                                      (plVar12,*(uint64 *)
                                                                                (*plVar12 + 0x170));
                                                    lVar8 = FUN_1800d60b0(DAT_181da1040,1);
                                                    if (lVar8 != null) {
                                                      if (*(int *)(lVar8 + 24) == 0) {
                                                        uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                        FUN_1800d65f0(uVar10,0);
                                                      }
                                                      *(uint16 *)(lVar8 + 32) = 47;
                                                      if (lVar7 != null) {
                                                        uVar10 = String.Split(lVar7,lVar8,0);
                                                        plVar12 = (int64 *)
                                                                  il2cpp_internal(DAT_181d97750);
                                                        FUN_181827480(plVar12,uVar10,DAT_181da3c58);
                                                        goto LAB_18099c314;
                                                      }
                                                    }
                                                  }
                                                  throw; // [null/range check failed]
                                                }
                                              }
        LAB_18099c314:
                                              do {
                                                while( true ) {
                                                  iVar4 = (int)plVar6;
                                                  local_134 = iVar4;
                                                  lVar7 = *(int64 *)
                                                           (pStatics_3d40 + 0x4f8);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  plVar6 = plVar16;
                                                  if (lVar7.summonLv <= iVar4) goto LAB_18099c689;
                                                  if (2 < *(int *)(param + 24)) break;
        LAB_18099c3fa:
                                                  if (3 < *(int *)(param + 24)) {
                                                    plVar6 = (int64 *)
                                                             FUN_180002f80(param,3,DAT_181d95e88);
                                                    if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar6 + 64) !=
                                                        *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1800d6070(plVar6,DAT_181d80418);
                                                    }
                                                    piVar13 = (int *)il2cpp_object_unbox();
                                                    iVar4 = local_134;
                                                    if (*piVar13 != -1) {
                                                      plVar6 = (int64 *)
                                                               FUN_180002f80(param,3,DAT_181d95e88);
                                                      if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                      if (*(int64 *)(*plVar6 + 64) !=
                                                          *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                        FUN_1800d6070(plVar6,DAT_181d80418);
                                                      }
                                                      piVar13 = (int *)il2cpp_object_unbox();
                                                      if (*piVar13 < iVar4) goto LAB_18099c493;
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
                                                                           (lVar7,DAT_181d962e0),
                                                        lVar7 == null)) throw; // [null/range check failed]
                                                  Selectable.set_interactable(lVar7);
                                                  plVar6 = (int64 *)(uint64)(local_134 + 1);
                                                }
                                                plVar6 = (int64 *)
                                                         FUN_180002f80(param,2,DAT_181d95e88);
                                                if (plVar6 == (int64 *)0) break;
                                                if (*(int64 *)(*plVar6 + 64) !=
                                                    *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1800d6070(plVar6,DAT_181d80418);
                                                }
                                                piVar13 = (int *)il2cpp_object_unbox();
                                                iVar4 = local_134;
                                                if (*piVar13 == -1) goto LAB_18099c3fa;
                                                plVar6 = (int64 *)
                                                         FUN_180002f80(param,2,DAT_181d95e88);
                                                if (plVar6 == (int64 *)0) break;
                                                if (*(int64 *)(*plVar6 + 64) !=
                                                    *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1800d6070(plVar6,DAT_181d80418);
                                                }
                                                piVar13 = (int *)il2cpp_object_unbox();
                                                if (*piVar13 <= iVar4) goto LAB_18099c3fa;
        LAB_18099c493:
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
                                                                         (lVar7,DAT_181d962e0), lVar7 == null
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
                                                plVar6 = (int64 *)(uint64)(local_134 + 1);
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
                                          lVar7 = FUN_18046c0a0(0);
                                          if ((lVar7 != null) &&
                                             (lVar7 = lVar7.summonControlable, param != null)) {
                                            if (*(int *)(param + 24) == 0) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            plVar6 = *(int64 **)(*(int64 *)(param + 16) + 32);
                                            if ((lVar7 != null) && (plVar6 != (int64 *)0)) {
                                              if (*(int64 *)(*plVar6 + 64) !=
                                                  *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                FUN_1800d6070(plVar6,DAT_181d80418);
                                              }
                                              puVar11 = (uint32 *)il2cpp_object_unbox();
                                              lVar7 = WorldData.GetHero(lVar7,*puVar11,0);
                                              this.targetHero = lVar7;
                                              if (*(int *)(param + 24) == 0) {
                                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                              }
                                              plVar12 = *(int64 **)
                                                         (*(int64 *)(param + 16) + 32);
                                              if (plVar12 != (int64 *)0) {
                                                if (*(int64 *)(*plVar12 + 64) !=
                                                    *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1800d6070(plVar12,DAT_181d80418);
                                                }
                                                puVar11 = (uint32 *)il2cpp_object_unbox();
                                                local_128[0] = *puVar11;
                                                switch(local_128[0]) {
                                                case 0xffffff97:
                                                  local_120 = *(uint64 **)
                                                               (*(int64 *)(DAT_181d72d50 + 184) + 24
                                                               );
                                                  break;
                                                case 0xffffff98:
                                                  lVar7 = FUN_18046c0a0(0);
                                                  if ((lVar7 == null) || (lVar7.summonControlable == null))
                                                  throw; // [null/range check failed]
                                                  local_120 = *(uint64 **)
                                                               (lVar7.summonControlable + 0x218);
                                                  break;
                                                case 0xffffff99:
                                                  lVar7 = FUN_18046c400(0);
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
                                                  lVar7 = FUN_18046c0a0(0);
                                                  if (((lVar7 == null) || (lVar7.summonControlable == null))
                                                     || (lVar7 = *(int64 *)
                                                                  (lVar7.summonControlable + 0x1b0),
                                                        lVar7 == null)) throw; // [null/range check failed]
                                                  local_120 = lVar7.summonLv;
                                                  break;
                                                case 0xffffff9b:
                                                  lVar7 = FUN_18046bca0(0);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  if (lVar7.summonLv == null) {
                                                    lVar7 = FUN_18046c400(0);
                                                    if ((lVar7 == null) ||
                                                       (lVar7.hp == null))
                                                    throw; // [null/range check failed]
                                                    local_120 = *(uint64 **)
                                                                 (lVar7.hp + 40);
                                                  }
                                                  else {
                                                    lVar7 = FUN_18046bca0(0);
                                                    if ((lVar7 == null) || (lVar7.summonLv == null)
                                                       ) throw; // [null/range check failed]
                                                    local_120 = *(uint64 **)
                                                                 (lVar7.summonLv + 40);
                                                  }
                                                  break;
                                                case 0xffffff9c:
                                                  lVar7 = FUN_18046c400(0);
                                                  if ((lVar7 == null) || (lVar7.forceJobCD == null))
                                                  throw; // [null/range check failed]
                                                  local_120 = *(uint64 **)
                                                               (lVar7.forceJobCD + 128);
                                                  break;
                                                case 0xffffff9d:
                                                  lVar7 = FUN_18046c400(0);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  local_120 = lVar7.changeSkinCd;
                                                  break;
                                                default:
                                                  if (*plVar6 == 0) throw; // [null/range check failed]
                                                  local_120 = *(uint64 **)(*plVar6 + 0x220);
                                                }
                                                local_res8 = 0;
                                                plVar6 = plVar16;
                                                if ((*(int *)(param + 24) < 2) ||
                                                   (lVar7 = FUN_180002f80(param,1,DAT_181d95e88),
                                                   lVar7 == null)) {
        LAB_18099951e:
                                                  do {
                                                    while( true ) {
                                                      iVar4 = (int)plVar6;
                                                      local_138 = iVar4;
                                                      lVar7 = *(int64 *)
                                                               (pStatics_3d40 +
                                                               0x4f0);
                                                      if (lVar7 == null) throw; // [null/range check failed]
                                                      plVar6 = plVar16;
                                                      if (lVar7.summonLv <= iVar4)
                                                      goto LAB_180999899;
                                                      if (2 < *(int *)(param + 24)) break;
        LAB_18099960a:
                                                      if (3 < *(int *)(param + 24)) {
                                                        plVar6 = (int64 *)
                                                                 FUN_180002f80(param,3,DAT_181d95e88);
                                                        if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                        if (*(int64 *)(*plVar6 + 64) !=
                                                            *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                          FUN_1800d6070(plVar6,DAT_181d80418);
                                                        }
                                                        piVar13 = (int *)il2cpp_object_unbox();
                                                        iVar4 = local_138;
                                                        if (*piVar13 != -1) {
                                                          plVar6 = (int64 *)
                                                                   FUN_180002f80(param,3,DAT_181d95e88);
                                                          if (plVar6 == (int64 *)0)
                                                          throw; // [null/range check failed]
                                                          if (*(int64 *)(*plVar6 + 64) !=
                                                              *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                            FUN_1800d6070(plVar6,DAT_181d80418);
                                                          }
                                                          piVar13 = (int *)il2cpp_object_unbox();
                                                          if (*piVar13 < iVar4) goto LAB_1809996a3;
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
                                                                            (lVar7,DAT_181d962e0),
                                                         lVar7 == null)) throw; // [null/range check failed]
                                                      Selectable.set_interactable(lVar7);
                                                      plVar6 = (int64 *)(uint64)(local_138 + 1);
                                                    }
                                                    plVar6 = (int64 *)
                                                             FUN_180002f80(param,2,DAT_181d95e88);
                                                    if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar6 + 64) !=
                                                        *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1800d6070(plVar6,DAT_181d80418);
                                                    }
                                                    piVar13 = (int *)il2cpp_object_unbox();
                                                    iVar4 = local_138;
                                                    if (*piVar13 == -1) goto LAB_18099960a;
                                                    plVar6 = (int64 *)
                                                             FUN_180002f80(param,2,DAT_181d95e88);
                                                    if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar6 + 64) !=
                                                        *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1800d6070(plVar6,DAT_181d80418);
                                                    }
                                                    piVar13 = (int *)il2cpp_object_unbox();
                                                    if (*piVar13 <= iVar4) goto LAB_18099960a;
        LAB_1809996a3:
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
                                                                                 (lVar7,DAT_181d962e0),
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
                                                plVar12 = (int64 *)
                                                          FUN_180002f80(param,1,DAT_181d95e88);
                                                if (plVar12 != (int64 *)0) {
                                                  lVar7 = (**(code **)(*plVar12 + 0x168))
                                                                    (plVar12,*(uint64 *)
                                                                              (*plVar12 + 0x170));
                                                  lVar8 = FUN_1800d60b0(DAT_181da1040,1);
                                                  if (lVar8 != null) {
                                                    if (*(int *)(lVar8 + 24) == 0) {
                                                      uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1800d65f0(uVar10,0);
                                                    }
                                                    *(uint16 *)(lVar8 + 32) = 47;
                                                    if (lVar7 != null) {
                                                      uVar10 = String.Split(lVar7,lVar8,0);
                                                      local_res8 = il2cpp_internal(DAT_181d97750);
                                                      FUN_181827480(local_res8,uVar10,DAT_181da3c58);
                                                      goto LAB_18099951e;
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
                                  local_120 = puVar9;
                                  il2cpp_internal(puVar9,uVar10);
                                  if (this.itemList != null) {
                                    GameObject.SetActive(this.itemList,0,0);
                                    if ((this.heroList != null) &&
                                       (GameObject.SetActive(this.heroList,1,0),
                                       plVar6 = plVar16, param != null)) {
        LAB_180998cc0:
                                      do {
                                        uVar5 = (uint32)plVar6;
                                        if ((int)*(uint32 *)(param + 24) <= (int)uVar5)
                                        goto LAB_18099bf9f;
                                        if (*(uint32 *)(param + 24) <= uVar5) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        plVar6 = *(int64 **)
                                                  (*(int64 *)(param + 16) + 32 +
                                                  (int64)(int)uVar5 * 8);
                                        plVar12 = plVar16;
                                        if (plVar6 != (int64 *)0) {
                                          if ((*(byte *)(*plVar6 + 300) < *(byte *)(DAT_181d75eb8 + 300))
                                             || (bVar1 = true,
                                                *(int64 *)
                                                 (*(int64 *)(*plVar6 + 200) + -8 +
                                                 (uint64)*(byte *)(DAT_181d75eb8 + 300) * 8) !=
                                                DAT_181d75eb8)) {
                                            bVar1 = false;
                                          }
                                          if (bVar1) {
                                            plVar12 = plVar6;
                                          }
                                          if (plVar12 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                                            FUN_1800d6070(plVar6);
                                          }
                                        }
                                        if (_filterType == 9) {
                                          lVar7 = FUN_18046c0a0(0);
                                          if ((lVar7 == null) || (lVar7.summonControlable == null)) break;
                                          plVar6 = (int64 *)WorldData.Player();
                                          if (plVar12 == plVar6) goto LAB_180998f46;
                                          if (((plVar12 == (int64 *)0) || (plVar12[97] == 0)) ||
                                             (lVar7 = *(int64 *)(plVar12[97] + 16)) == null)
                                          break;
                                          iVar4 = FUN_1800d6760(lVar7,16,DAT_181d8fa18);
                                          if (iVar4 < 1) {
                                            plVar6 = (int64 *)(uint64)(uVar5 + 1);
                                            goto LAB_180998cc0;
                                          }
        LAB_180998e61:
                                          uVar10 = *puVar9;
                                          lVar7 = FUN_18046c1a0(0);
                                          if (lVar7 == null) break;
                                          uVar14 = lVar7.forceJobType;
                                          uVar10 = GlobalData.AddChild(uVar10,uVar14,0);
                                          this.newObj = uVar10;
                                          if ((this.newObj == null) ||
                                             (lVar7 = GameObject.GetComponent
                                                                (this.newObj,
                                                                 DAT_181d71b50), lVar7 == null)) break;
                                          lVar7.summonControlable = plVar12;
                                          if ((this.newObj == null) ||
                                             (((lVar7 = GameObject.GetComponent
                                                                  (this.newObj,
                                                                   DAT_181d71b50), lVar7 == null ||
                                               (lVar7.summonLv = 3,
                                               this.newObj == null)) ||
                                              (lVar7 = GameObject.GetComponent()) == null))) break;
                                          HeroIconController.AutoSetName(lVar7);
                                          puVar9 = local_120;
                                        }
                                        else {
                                          if (_filterType != 10) goto LAB_180998e61;
                                          lVar7 = FUN_18046c0a0(0);
                                          if ((lVar7 == null) || (lVar7.summonControlable == null)) break;
                                          plVar6 = (int64 *)WorldData.Player();
                                          if (plVar12 != plVar6) {
                                            if (((plVar12 == (int64 *)0) || (plVar12[97] == 0)) ||
                                               (lVar7 = *(int64 *)(plVar12[97] + 16)) == null)
                                            break;
                                            iVar4 = FUN_1800d6760(lVar7,17,DAT_181d8fa18);
                                            if (0 < iVar4) goto LAB_180998e61;
                                          }
                                        }
        LAB_180998f46:
                                        plVar6 = (int64 *)(uint64)(uVar5 + 1);
                                      } while( true );
                                    }
                                  }
                                }
                              }
                              else {
        LAB_18099bf9f:
                                uVar10 = this.targetGrid;
                                GlobalData.SortChild(uVar10,0);
                                if (this.targetGrid != null) {
                                  uVar10 = GameObject.GetComponent
                                                     (this.targetGrid,DAT_181d72bc8);
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
        LAB_18099c689:
        iVar4 = (int)plVar6;
        local_12c = iVar4;
        lVar7 = *(int64 *)(pStatics_3d40 + 0x4a0);
        if (lVar7 == null) throw; // [null/range check failed]
        if (iVar4 < lVar7.summonLv) {
          if (plVar12 == (int64 *)0) {
        LAB_18099c84d:
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181d962e0)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7);
            plVar6 = (int64 *)(uint64)(local_12c + 1);
          }
          else {
            uVar10 = Int32.ToString(&local_12c,0);
            cVar2 = FUN_18181e400(plVar12,uVar10);
            if (cVar2) goto LAB_18099c84d;
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181d962e0)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7,0);
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7)) == null) throw; // [null/range check failed]
            Toggle.set_isOn(lVar7);
            plVar6 = (int64 *)(uint64)(local_12c + 1);
          }
          goto LAB_18099c689;
        }
        lVar7 = this.targetHero;
        if (lVar7 != null) goto LAB_18099c920;
        throw; // [null/range check failed]
        LAB_18099c920:
        if (lVar7.kungfuSkills == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar16;
        if (*(int *)(lVar7.kungfuSkills + 24) <= (int)uVar5) goto LAB_18099bf9f;
        if ((lVar7 = lVar7?.kungfuSkills) == null) throw; // [null/range check failed]
        if (lVar7.summonLv <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = lVar7.isSummon[uVar5];
        if (plVar12 != (int64 *)0) {
          if (lVar7 != null) {
            local_128[0] = KungfuSkillLvData.Type(lVar7,0);
            uVar10 = Int32.ToString(local_128,0);
            cVar2 = FUN_18181e400(plVar12,uVar10,DAT_181da3e58);
            if (cVar2) goto LAB_18099c9ad;
            goto LAB_18099d731;
          }
          throw; // [null/range check failed]
        }
        LAB_18099c9ad:
        if (2 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if ((lVar7 == null) || (lVar8 = KungfuSkillLvData.DataBase(lVar7,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            plVar6 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099d731;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if ((lVar7 == null) || (lVar8 = KungfuSkillLvData.DataBase(lVar7,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            plVar6 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (*piVar13 < iVar4) goto LAB_18099d731;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonID;
            plVar6 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099d731;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonID;
            plVar6 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (*piVar13 < iVar4) goto LAB_18099d731;
          }
        }
        if (_filterType == 1) {
          if (lVar7 == null) throw; // [null/range check failed]
          cVar2 = KungfuSkillLvData.SkillMeetObstacleLv(lVar7,0);
          if ((!cVar2) || (cVar2 = KungfuSkillLvData.CanUpgrade(lVar7,0), !cVar2))
          goto LAB_18099d731;
        switchD_18099cd15_caseD_14:
          uVar10 = this.targetGrid;
          lVar7 = FUN_18046c1a0(0);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar14 = lVar7.thisYearContribution;
          uVar10 = GlobalData.AddChild(uVar10,uVar14,0);
          this.newObj = uVar10;
          if (this.newObj == null) throw; // [null/range check failed]
          lVar7 = GameObject.GetComponent(this.newObj,DAT_181d73800);
          if (((this.targetHero == null) ||
              (lVar8 = this.targetHero.kungfuSkills) == null) ||
             (uVar10 = FUN_180002f80(lVar8,plVar16), lVar7 == null)) throw; // [null/range check failed]
          lVar7.summonControlable = uVar10;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181d73800)) == null)
          throw; // [null/range check failed]
          lVar7.summonSourceHero = 4;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181d73800)) == null)
          throw; // [null/range check failed]
          lVar7.summonLv = uVar5;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181d73800)) == null)
          throw; // [null/range check failed]
          SkillIconController.AutoSetName(lVar7,0,0,0);
        }
        else {
          if (_filterType == 12) {
        switchD_18099cd15_caseD_17:
            lVar8 = FUN_18046c0a0(0);
            if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar7 == null)) || (lVar8 == null))
            throw; // [null/range check failed]
            lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
            if (lVar7 == null) goto switchD_18099cd15_caseD_14;
            goto LAB_18099d731;
          }
          switch(_filterType) {
          case 18:
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 112) != 0) {
              lVar8 = FUN_18046c400(0);
              if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
              if (lVar8 != null) {
                lVar8 = FUN_18046c0a0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
                if (lVar8 != null) {
                  lVar8 = FUN_18046c400(0);
                  if (((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) ||
                     (lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),
                                                  lVar7.isSummon,0), lVar8 == null))
                  throw; // [null/range check failed]
                  iVar4 = *(int *)(lVar8 + 20);
                  lVar8 = FUN_18046c0a0(0);
                  if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                     ((lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar8 == null ||
                      (lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0)) == null)))
                  throw; // [null/range check failed]
                  if (iVar4 <= *(int *)(lVar8 + 20)) {
                    lVar8 = FUN_18046c400(0);
                    if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 112)) == null)
                    throw; // [null/range check failed]
        LAB_18099cf02:
                    lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
                    if (lVar7 == null) throw; // [null/range check failed]
                    if (lVar7.summonID < 10) goto switchD_18099cd15_caseD_14;
                  }
                }
              }
            }
            break;
          case 19:
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 112) != 0) {
              lVar8 = FUN_18046c400(0);
              if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
              if (lVar8 != null) {
                lVar8 = FUN_18046c0a0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
                if (lVar8 != null) {
                  lVar8 = FUN_18046c400(0);
                  if (((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) ||
                     (lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),
                                                  lVar7.isSummon,0), lVar8 == null))
                  throw; // [null/range check failed]
                  iVar4 = *(int *)(lVar8 + 20);
                  lVar8 = FUN_18046c0a0(0);
                  if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                     ((lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar8 == null ||
                      (lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0)) == null)))
                  throw; // [null/range check failed]
                  if (*(int *)(lVar8 + 20) <= iVar4) {
                    lVar8 = FUN_18046c0a0(0);
                    if (((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) &&
                       (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) != null)
                    goto LAB_18099cf02;
                    throw; // [null/range check failed]
                  }
                }
              }
            }
            break;
          default:
            goto switchD_18099cd15_caseD_14;
          case 22:
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 112) == 0) break;
            lVar8 = FUN_18046c400(0);
            if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
            if (lVar8 != null) break;
            lVar8 = KungfuSkillLvData.DataBase(lVar7,0);
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            lVar8 = FUN_18046c400(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar8 + 112) + 184) < iVar4) break;
            lVar8 = FUN_18046c0a0(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
            lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0);
            lVar15 = FUN_18046c400(0);
            if (((lVar15 == null) || (*(int64 *)(lVar15 + 112) == 0)) || (lVar8 == null))
            throw; // [null/range check failed]
            cVar2 = HeroData.HaveBrother(lVar8,*(uint32 *)(*(int64 *)(lVar15 + 112) + 88));
            if (!cVar2) {
              lVar8 = FUN_18046c0a0(0);
              if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
              lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0);
              lVar15 = FUN_18046c400(0);
              if (((lVar15 == null) || (*(int64 *)(lVar15 + 112) == 0)) || (lVar8 == null))
              throw; // [null/range check failed]
              cVar2 = HeroData.HavePrelover(lVar8,*(uint32 *)(*(int64 *)(lVar15 + 112) + 88));
              if (cVar2) goto switchD_18099cd15_caseD_14;
              lVar8 = FUN_18046c0a0(0);
              if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                 (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
              throw; // [null/range check failed]
              iVar4 = *(int *)(lVar8 + 0x328);
              lVar8 = FUN_18046c400(0);
              if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
              if (iVar4 != *(int *)(*(int64 *)(lVar8 + 112) + 88)) {
                lVar7 = KungfuSkillLvData.DataBase(lVar7,0);
                if (lVar7 == null) throw; // [null/range check failed]
                if (4 < lVar7.manageAiHour) break;
              }
            }
            goto switchD_18099cd15_caseD_14;
          case 23:
            goto switchD_18099cd15_caseD_17;
          case 26:
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 112) != 0) {
              lVar8 = FUN_18046c400(0);
              if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
              if (lVar8 == null) {
                lVar7 = KungfuSkillLvData.DataBase(lVar7,0);
                if (lVar7 == null) throw; // [null/range check failed]
                iVar4 = lVar7.manageAiHour;
                lVar7 = FUN_18046c400(0);
                if ((lVar7 == null) || (lVar7.heroFamilyName == null)) throw; // [null/range check failed]
                if (iVar4 <= *(int *)(lVar7.heroFamilyName + 184))
                goto switchD_18099cd15_caseD_14;
              }
            }
            break;
          case 28:
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 112) != 0) {
              lVar8 = FUN_18046c400(0);
              if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
              if (lVar8 != null) {
                lVar8 = FUN_18046c0a0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
                if (lVar7 != null) goto switchD_18099cd15_caseD_14;
              }
            }
          }
        }
        LAB_18099d731:
        lVar7 = this.targetHero;
        plVar16 = (int64 *)(uint64)(uVar5 + 1);
        if (lVar7 == null) throw; // [null/range check failed]
        goto LAB_18099c920;
        LAB_180999b30:
        plVar12 = &this.targetHero;
        lVar7 = local_120[5];
        if (lVar7 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (lVar7.summonLv <= (int)uVar5) {
          if (_filterType == 14) {
            lVar7 = FUN_18046c0a0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage, plVar6 = plVar16) != null) goto LAB_18099ba50;
          }
          else if (_filterType == 8) {
            lVar7 = FUN_18046c0a0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_18099b930;
          }
          else if (_filterType == 6) {
            lVar7 = FUN_18046c0a0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_18099b850;
          }
          else if (_filterType == 25) {
            lVar7 = FUN_18046c0a0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_18099b440;
          }
          else {
            if (_filterType != 27) goto LAB_18099bf9f;
            lVar7 = FUN_18046c0a0(0);
            if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
               ((lVar7 = WorldData.Player(lVar7.summonControlable,0), lVar7 != null &&
                (lVar7 = lVar7.selfStorage, plVar6 = plVar16) != null)))
            goto LAB_18099ace0;
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
            cVar2 = FUN_18181e400(local_res8,uVar10);
            if (cVar2) goto LAB_180999b9a;
            goto LAB_18099ac3b;
          }
          throw; // [null/range check failed]
        }
        LAB_180999b9a:
        if (2 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7 + 60);
            plVar6 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099ac3b;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7 + 60);
            plVar6 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (*piVar13 < iVar4) goto LAB_18099ac3b;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonLv;
            plVar6 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 != *piVar13) goto LAB_18099ac3b;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.dailyAIManaged;
            plVar6 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099ac3b;
          }
        }
        if (6 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,6,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 == -1) goto LAB_180999ec2;
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == null) {
            if (lVar7.hide != null) {
              iVar4 = *(int *)(lVar7.hide + 20);
              plVar6 = (int64 *)FUN_180002f80(param,6,DAT_181d95e88);
              if (plVar6 != (int64 *)0) {
                if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar6,DAT_181d80418);
                }
                piVar13 = (int *)il2cpp_object_unbox();
                if (iVar4 == *piVar13) goto LAB_180999ec2;
                goto LAB_18099ac3b;
              }
            }
            throw; // [null/range check failed]
          }
          goto LAB_18099ac3b;
        }
        LAB_180999ec2:
        switch(_filterType) {
        case 2:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID - 1U < 2) goto switchD_180999ee7_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_180999b30;
        case 3:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv < 2)) {
        LAB_180999f31:
            lVar8 = FUN_18046bde0();
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 48) != lVar7) {
              lVar8 = FUN_18046bde0();
              if (lVar8 == null) throw; // [null/range check failed]
              if (*(int64 *)(lVar8 + 64) != lVar7) goto switchD_180999ee7_caseD_9;
              plVar6 = (int64 *)(uint64)(uVar5 + 1);
              goto LAB_180999b30;
            }
          }
          break;
        case 4:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv == 2)) goto LAB_180999f31;
          break;
        case 5:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv == 3)) goto LAB_180999f31;
          break;
        case 6:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 3) && (lVar7.heroAIData < 5)) {
            if (this.targetHero == null) throw; // [null/range check failed]
            lVar8 = HeroData.FindSameBook(this.targetHero,lVar7);
            if (lVar8 != null) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          break;
        case 7:
          lVar8 = FUN_18046c0a0(0);
          if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
             (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) throw; // [null/range check failed]
          fVar17 = (float)HeroData.GetIdentifyKnowledge(lVar8,0);
          lVar8 = FUN_18046bca0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          iVar4 = 0;
          if (*(int64 *)(lVar8 + 24) != 0) {
            lVar8 = FUN_18046bca0(0);
            uVar3 = FUN_18171e540(this.sendResultParam,"true");
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = BuildingUIController.GetBuildingExtraKnowledge(lVar8,uVar3);
          }
          if ((lVar7 == null) || (lVar8 = lVar7.heroNickName) == null) throw; // [null/range check failed]
          if (*(char *)(lVar8 + 16) == false) {
            if (*(float *)(lVar8 + 20) <= (float)iVar4 + fVar17) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          break;
        case 8:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if ((lVar7.heroFamilyName == null) || (this.targetHero == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(this.targetHero,*(uint32 *)(lVar7.heroFamilyName + 16));
            if ((lVar8 == null) || (*(int *)(lVar8 + 20) < 10)) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          break;
        default:
          goto switchD_180999ee7_caseD_9;
        case 11:
          if (lVar7 == null) throw; // [null/range check failed]
          cVar2 = ItemData.Equiped(lVar7,0);
          if (!cVar2) goto switchD_180999ee7_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_180999b30;
        case 13:
          lVar8 = FUN_18046c400(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_18046c400(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            cVar2 = HeroData.HaveHobby(*(int64 *)(lVar8 + 112),lVar7);
            if (cVar2) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          goto switchD_180999ee7_caseD_9;
        case 14:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if (lVar7.heroFamilyName == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7.heroFamilyName + 16);
            lVar8 = FUN_18046bc40();
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
            if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          break;
        case 15:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID != 5) || (lVar7.summonLv != 4)) break;
          lVar8 = FUN_18046bda0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 56);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_18046bda0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 56) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 56),DAT_181d720a0)) == null)
            throw; // [null/range check failed]
            if (lVar7 == *(int64 *)(lVar8 + 32)) break;
          }
          lVar8 = FUN_18046bda0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 72);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_18046bda0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 72) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 72),DAT_181d720a0)) == null)
            throw; // [null/range check failed]
            if (lVar7 == *(int64 *)(lVar8 + 32)) break;
          }
          lVar8 = FUN_18046bda0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 88);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_18046bda0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 88) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 88),DAT_181d720a0)) == null)
            throw; // [null/range check failed]
            if (lVar7 != *(int64 *)(lVar8 + 32)) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          goto switchD_180999ee7_caseD_9;
        case 16:
          if (((lVar7 == null) || (lVar7.hide == null)) ||
             (lVar8 = *(int64 *)(lVar7.hide + 64)) == null) throw; // [null/range check failed]
          if (0.0 < *(float *)(lVar8 + 16)) {
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
        switchD_180999ee7_caseD_9:
          uVar10 = this.targetGrid;
          lVar8 = FUN_18046c1a0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar14 = *(uint64 *)(lVar8 + 160);
          uVar10 = GlobalData.AddChild(uVar10,uVar14);
          this.newObj = uVar10;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181d720a0)) == null)
          throw; // [null/range check failed]
          *(int64 *)(lVar8 + 32) = lVar7;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181d720a0)) == null)
          throw; // [null/range check failed]
          *(uint32 *)(lVar8 + 40) = 3;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181d720a0)) == null)
          throw; // [null/range check failed]
          ItemIconController.AutoSetName(lVar8,1);
          if ((_cancelFuc != null) && (cVar2 = HeroData.HaveHobby(_cancelFuc,lVar7), cVar2)) {
            uVar10 = this.newObj;
            lVar7 = FUN_18046c680(0);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar14 = TextureController.LoadAtlasSprite(lVar7,"UIAtlas","友善度",0);
            local_118 = 0x420c0000;
            uStack_114 = 0x420c0000;
            uStack_110 = 0;
            local_f8 = 0;
            uStack_f0 = 0;
            FUN_181308660(&local_f8,&local_118,DAT_181dba8c0);
            local_108 = local_f8;
            uStack_100 = uStack_f0;
            local_d8 = 0;
            uStack_d0 = 0;
            lVar7 = GlobalData.AddImage(uVar10,"HobbyIcon",uVar14,&local_108,&local_d8,0);
            if (lVar7 == null) throw; // [null/range check failed]
            plVar6 = (int64 *)GameObject.GetComponent(lVar7,DAT_181d71e80);
            uVar10 = 0;
            local_e8 = 0;
            uStack_e0 = 0;
            Color.ctor(&local_e8);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            lVar8 = *plVar6;
            local_108 = local_e8;
            uStack_100 = uStack_e0;
            (**(code **)(lVar8 + 0x2a8))(plVar6,&local_108,*(uint64 *)(lVar8 + 0x2b0),lVar8,uVar10);
            plVar6 = (int64 *)GameObject.GetComponent(lVar7,DAT_181d71e80);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar6 + 0x408))(plVar6,*(uint64 *)(*plVar6 + 0x410));
            lVar8 = GameObject.AddComponent(lVar7,DAT_181dc5d30);
            if (lVar8 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar8 + 24) = "对方喜好\n赠送好感加倍";
            lVar7 = GameObject.GetComponent(lVar7,DAT_181d73448);
            if (lVar7 == null) throw; // [null/range check failed]
            lVar7.summonSourceHero = 1;
          }
          break;
        case 17:
          if (lVar7 == null) throw; // [null/range check failed]
          if (0.0 < *(float *)(lVar7 + 76)) {
            cVar2 = ItemData.DetectPoisonNum(lVar7,0);
            if (cVar2) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          break;
        case 20:
          lVar8 = FUN_180990820();
          if (lVar8 == null) throw; // [null/range check failed]
          plVar6 = plVar16;
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
                lVar8 = FUN_180990820(0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar8 + 32) + 24) <= (int)plVar6)
                goto switchD_180999ee7_caseD_9;
                lVar8 = FUN_180990820(0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                uVar10 = FUN_180002f80(*(int64 *)(lVar8 + 32),plVar6);
                cVar2 = Object.op_Inequality(uVar10,0);
                if (cVar2) {
                  lVar8 = FUN_180990820(0);
                  if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                      (lVar8 = FUN_180002f80(*(int64 *)(lVar8 + 32),plVar6)) == null) ||
                     (lVar8 = GameObject.GetComponent(lVar8,DAT_181d720a0)) == null)
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
            lVar8 = FUN_18046c0a0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) throw; // [null/range check failed]
            plVar6 = plVar16;
            if (iVar4 != *(int *)(lVar8 + 132)) {
              while( true ) {
                lVar8 = FUN_18046c0a0(0);
                if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                    (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 0x218)) == null) ||
                   (lVar8 = *(int64 *)(lVar8 + 40)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar8 + 24) <= (int)plVar6) goto switchD_180999ee7_caseD_9;
                lVar8 = FUN_18046c0a0(0);
                if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                    ((lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 0x218), lVar8 == null ||
                     (((lVar8 = *(int64 *)(lVar8 + 40), lVar8 == null ||
                       (lVar8 = FUN_180002f80(lVar8,plVar6)) == null) ||
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
          lVar8 = FUN_18046c400();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) == 0) {
            fVar17 = 0.0;
          }
          else {
            lVar8 = FUN_18046c400(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            fVar17 = (float)HeroData.GetIdentifyKnowledge(*(int64 *)(lVar8 + 112),0);
          }
          if ((lVar7 == null) || (lVar8 = lVar7.heroNickName) == null) throw; // [null/range check failed]
          if (*(char *)(lVar8 + 16) != false) break;
          if (*(float *)(lVar8 + 20) <= fVar17) goto switchD_180999ee7_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_180999b30;
        case 27:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if ((lVar7.heroFamilyName == null) ||
               (lVar8 = BookData.DataBase(lVar7.heroFamilyName,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            lVar8 = FUN_18046c400();
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
              lVar8 = FUN_18046c400(0);
              if (lVar8 == null) throw; // [null/range check failed]
              if ((lVar7.heroFamilyName == null) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),
                                          *(uint32 *)(lVar7.heroFamilyName + 16));
              if (lVar8 == null) goto switchD_180999ee7_caseD_9;
            }
          }
        }
        LAB_18099ac3b:
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_180999b30;
        LAB_18099ba50:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) {
          lVar7 = FUN_18046c0a0(0);
          if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
             (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) {
            lVar7 = HeroData.GetForce(lVar7,0,0);
            if (lVar7 == null) goto LAB_18099bf9f;
            lVar7 = FUN_18046c0a0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 != null &&
                (lVar7 = lVar7.heroForceLv, plVar6 = plVar16) != null))) goto LAB_18099bc20;
          }
          throw; // [null/range check failed]
        }
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
             (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
          lVar8 = FUN_18046bc40();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
          if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
            if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
            uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
            ChooseController.CreateChooseItem(this,uVar10,"仓库",0);
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099ba50;
        LAB_18099bc20:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        plVar12 = plVar16;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_18099bd20;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
             (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
          lVar8 = FUN_18046bc40();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
          if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
            if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
            uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
            ChooseController.CreateChooseItem(this,uVar10,"藏经阁",0);
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099bc20;
        LAB_18099bd20:
        if ((((*pStatics_2cc8 == 0) ||
             (lVar7 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
            (lVar7 = WorldData.Player(lVar7,0)) == null) ||
           ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 == null || (lVar7.heroAIData == null))))
        throw; // [null/range check failed]
        if (*(int *)(lVar7.heroAIData + 24) <= (int)plVar12) goto LAB_18099bf9f;
        lVar7 = FUN_18046c0a0(0);
        if (lVar7 == null) throw; // [null/range check failed]
        lVar7 = lVar7.summonControlable;
        lVar8 = FUN_18046c0a0(0);
        if ((((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
              (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) ||
             ((lVar8 = HeroData.GetForce(lVar8,0,0), lVar8 == null || (*(int64 *)(lVar8 + 64) == 0))))
            || (FUN_1800d6760(*(int64 *)(lVar8 + 64),plVar12), lVar7 == null)) ||
           (lVar7 = WorldData.GetForce(lVar7)) == null) throw; // [null/range check failed]
        lVar7 = lVar7.heroForceLv;
        plVar6 = plVar16;
        while( true ) {
          if ((lVar7 == null) || (lVar7.summonSourceHero == null)) throw; // [null/range check failed]
          if (*(int *)(lVar7.summonSourceHero + 24) <= (int)plVar6) break;
          lVar8 = FUN_180002f80();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 3) {
            if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
               (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
            lVar8 = FUN_18046bc40(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
            if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
              ChooseController.CreateChooseItem(this,uVar10,"附庸藏经阁",0);
            }
          }
          plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
        }
        plVar12 = (int64 *)(uint64)((int)plVar12 + 1);
        goto LAB_18099bd20;
        LAB_18099b930:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar16;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_18099bf9f;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if ((*(int64 *)(lVar8 + 112) == 0) || (*plVar12 == 0)) throw; // [null/range check failed]
          lVar15 = HeroData.FindSkill(*plVar12,*(uint32 *)(*(int64 *)(lVar8 + 112) + 16),0);
          if (lVar15 != null) {
            if (((*(int64 *)(lVar8 + 112) == 0) || (*plVar12 == 0)) ||
               (lVar15 = HeroData.FindSkill(*plVar12,*(uint32 *)(*(int64 *)(lVar8 + 112) + 16),
                                             0), lVar15 == null)) throw; // [null/range check failed]
            if (9 >= *(int *)(lVar15 + 20))
            {
              }
              ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
              }
            }
        plVar16 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099b930;
        LAB_18099b850:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar16;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_18099bf9f;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if ((*(int *)(lVar8 + 20) == 3) && (*(int *)(lVar8 + 64) < 5)) {
          if (*plVar12 == 0) throw; // [null/range check failed]
          lVar15 = HeroData.FindSameBook(*plVar12,lVar8,0);
          if (lVar15 != null) {
            ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
          }
        }
        plVar16 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099b850;
        LAB_18099b440:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar16;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_18099bf9f;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (local_res8 != 0) {
          if (lVar8 != null) {
            local_128[0] = *(uint32 *)(lVar8 + 20);
            uVar10 = Int32.ToString(local_128,0);
            cVar2 = FUN_18181e400(local_res8,uVar10,DAT_181da3e58);
            if (cVar2) goto LAB_18099b4aa;
            goto LAB_18099b7e3;
          }
          throw; // [null/range check failed]
        }
        LAB_18099b4aa:
        if (2 < *(int *)(param + 24)) {
          plVar16 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
          if (plVar16 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar16,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 60);
            plVar16 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
            if (plVar16 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar16,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099b7e3;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar16 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
          if (plVar16 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar16,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 60);
            plVar16 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
            if (plVar16 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar16,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (*piVar13 < iVar4) goto LAB_18099b7e3;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar16 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
          if (plVar16 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar16,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 24);
            plVar16 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
            if (plVar16 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar16,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 != *piVar13) goto LAB_18099b7e3;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar16 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
          if (plVar16 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar16,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 56);
            plVar16 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
            if (plVar16 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar16,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099b7e3;
          }
        }
        if (*(int *)(param + 24) < 7) {
        LAB_18099b7ca:
          ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
        }
        else {
          plVar16 = (int64 *)FUN_180002f80(param,6,DAT_181d95e88);
          if (plVar16 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar16,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 == -1) goto LAB_18099b7ca;
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 0) {
            if (*(int64 *)(lVar8 + 96) == 0) throw; // [null/range check failed]
            iVar4 = *(int *)(*(int64 *)(lVar8 + 96) + 20);
            plVar16 = (int64 *)FUN_180002f80(param,6,DAT_181d95e88);
            if (plVar16 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070();
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 == *piVar13) goto LAB_18099b7ca;
          }
        }
        LAB_18099b7e3:
        plVar16 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099b440;
        LAB_18099ace0:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) {
          lVar7 = FUN_18046c0a0(0);
          if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
             (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) {
            lVar7 = HeroData.GetForce(lVar7,0,0);
            if (lVar7 == null) goto LAB_18099bf9f;
            lVar7 = FUN_18046c0a0(0);
            if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
               ((lVar7 = WorldData.Player(lVar7.summonControlable,0), lVar7 != null &&
                ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 != null &&
                 (lVar7 = lVar7.heroForceLv, plVar6 = plVar16) != null)))))
            goto LAB_18099af40;
          }
          throw; // [null/range check failed]
        }
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
             ((*(int64 *)(lVar8 + 112) == 0 || (lVar8 = BookData.DataBase()) == null)))
          throw; // [null/range check failed]
          iVar4 = *(int *)(lVar8 + 52);
          lVar8 = FUN_18046c400();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            lVar8 = *(int64 *)(lVar8 + 112);
            if ((((lVar7.summonSourceHero == null) ||
                 (lVar15 = FUN_180002f80(lVar7.summonSourceHero,plVar6)) == null) ||
                (*(int64 *)(lVar15 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill();
            if (lVar8 == null) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
              ChooseController.CreateChooseItem(this,uVar10,"仓库",0);
            }
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099ace0;
        LAB_18099af40:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        plVar12 = plVar16;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_18099b0d0;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
             ((*(int64 *)(lVar8 + 112) == 0 || (lVar8 = BookData.DataBase()) == null)))
          throw; // [null/range check failed]
          iVar4 = *(int *)(lVar8 + 52);
          lVar8 = FUN_18046c400();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            lVar8 = *(int64 *)(lVar8 + 112);
            if ((((lVar7.summonSourceHero == null) ||
                 (lVar15 = FUN_180002f80(lVar7.summonSourceHero,plVar6)) == null) ||
                (*(int64 *)(lVar15 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill();
            if (lVar8 == null) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
              ChooseController.CreateChooseItem(this,uVar10,"藏经阁",0);
            }
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099af40;
        LAB_18099b0d0:
        if ((((*pStatics_2cc8 == 0) ||
             (lVar7 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
            (lVar7 = WorldData.Player(lVar7,0)) == null) ||
           ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 == null || (lVar7.heroAIData == null))))
        throw; // [null/range check failed]
        if (*(int *)(lVar7.heroAIData + 24) <= (int)plVar12) goto LAB_18099bf9f;
        lVar7 = FUN_18046c0a0(0);
        if (lVar7 == null) throw; // [null/range check failed]
        lVar7 = lVar7.summonControlable;
        lVar8 = FUN_18046c0a0(0);
        if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
            (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) ||
           (((lVar8 = HeroData.GetForce(lVar8,0,0), lVar8 == null || (*(int64 *)(lVar8 + 64) == 0)) ||
            ((FUN_1800d6760(*(int64 *)(lVar8 + 64),plVar12), lVar7 == null ||
             (lVar7 = WorldData.GetForce(lVar7)) == null))))) throw; // [null/range check failed]
        lVar7 = lVar7.heroForceLv;
        plVar6 = plVar16;
        while( true ) {
          if ((lVar7 == null) || (lVar7.summonSourceHero == null)) throw; // [null/range check failed]
          if (*(int *)(lVar7.summonSourceHero + 24) <= (int)plVar6) break;
          lVar8 = FUN_180002f80();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 3) {
            if ((((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
                (*(int64 *)(lVar8 + 112) == 0)) || (lVar8 = BookData.DataBase()) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            lVar8 = FUN_18046c400(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
              lVar8 = FUN_18046c400(0);
              if (lVar8 == null) throw; // [null/range check failed]
              lVar8 = *(int64 *)(lVar8 + 112);
              if ((((lVar7.summonSourceHero == null) ||
                   (lVar15 = FUN_180002f80(lVar7.summonSourceHero,plVar6)) == null) ||
                  (*(int64 *)(lVar15 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(lVar8);
              if (lVar8 == null) {
                if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
                uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
                ChooseController.CreateChooseItem(this,uVar10,"附庸藏经阁",0);
              }
            }
          }
          plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
        }
        plVar12 = (int64 *)(uint64)((int)plVar12 + 1);
        goto LAB_18099b0d0;
        LAB_180999899:
        iVar4 = (int)plVar6;
        local_130 = iVar4;
        lVar7 = *(int64 *)(pStatics_3d40 + 0x4d0);
        if (lVar7 == null) throw; // [null/range check failed]
        if (iVar4 < lVar7.summonLv) {
          if (local_res8 == 0) {
        LAB_180999a5d:
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"ItemFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"ItemTypeFlitter");
            uVar10 = Int32.ToString(&local_130,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181d962e0)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7);
            plVar6 = (int64 *)(uint64)(local_130 + 1);
          }
          else {
            uVar10 = Int32.ToString(&local_130,0);
            cVar2 = FUN_18181e400(local_res8,uVar10);
            if (cVar2) goto LAB_180999a5d;
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"ItemFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"ItemTypeFlitter");
            uVar10 = Int32.ToString(&local_130,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181d962e0)) == null) throw; // [null/range check failed]
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
          goto LAB_180999899;
        }
        plVar6 = plVar16;
        if (local_120 != (uint64 *)0) goto LAB_180999b30;
    }

    // Token : 0x6000E89
    // RVA   : 0x998490   Offset: 0x997890   Length: 0x1174
    public void ShowChoosePanel(ChooseType _chooseType, List<object> param, GameObject _sendResultFucTarget, string _sendResultFuc, string _sendResultParam, ChooseFilterType _filterType, HeroData targetFavorHero, string _cancelFuc)
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        int *piVar13;
        uint64 uVar14;
        int64 lVar15;
        int64 *plVar16;
        float fVar17;
        int64 local_res8;
        int local_138;
        int local_134;
        int local_130;
        int local_12c;
        uint32 local_128 [2];
        uint64 *local_120;
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
        plVar16 = (int64 *)0;
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
        plVar12 = plVar16;
        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf348)) {
          plVar12 = plVar6;
        }
        NGUITools.PlaySound(plVar12,0);
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
                  uVar10 = TweenSettingsExtensions.SetEase(uVar10,2,DAT_181dc0f80);
                  TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181dc1db0);
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
                        uVar10 = TweenSettingsExtensions.SetEase(uVar10,2,DAT_181dc0f80);
                        TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181dc1db0);
                        if ((this.choosePanel != null) &&
                           ((lVar7 = GameObject.get_transform(this.choosePanel,0),
                            lVar7 != null && (lVar7 = Transform.Find(lVar7,"BlackBackground",0)) != null)))
                        {
                          plVar6 = (int64 *)Component.GetComponent(lVar7,DAT_181d94460);
                          puVar11 = (uint32 *)FUN_180d98fe0(local_88,0);
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
                              uVar10 = Component.GetComponent(lVar7,DAT_181d94460);
                              uVar10 = DOTweenModuleUI.DOFade(uVar10);
                              TweenSettingsExtensions.SetUpdate(uVar10,1,DAT_181dc1c20);
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
                                          lVar7 = FUN_18046c0a0(0);
                                          if ((lVar7 != null) &&
                                             (lVar7 = lVar7.summonControlable, param != null)) {
                                            if (*(int *)(param + 24) == 0) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            plVar6 = *(int64 **)(*(int64 *)(param + 16) + 32);
                                            if ((lVar7 != null) && (plVar6 != (int64 *)0)) {
                                              if (*(int64 *)(*plVar6 + 64) !=
                                                  *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                FUN_1800d6070(plVar6,DAT_181d80418);
                                              }
                                              puVar11 = (uint32 *)il2cpp_object_unbox();
                                              uVar10 = WorldData.GetHero(lVar7,*puVar11,0);
                                              this.targetHero = uVar10;
                                              plVar6 = plVar16;
                                              plVar12 = plVar16;
                                              if (1 < (int)*(uint32 *)(param + 24)) {
                                                if (*(uint32 *)(param + 24) < 2) {
                                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                }
                                                if (*(int64 *)(*(int64 *)(param + 16) + 40) !=
                                                    0) {
                                                  if (*(uint32 *)(param + 24) < 2) {
                                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                  }
                                                  plVar12 = *(int64 **)
                                                             (*(int64 *)(param + 16) + 40);
                                                  if (plVar12 != (int64 *)0) {
                                                    lVar7 = (**(code **)(*plVar12 + 0x168))
                                                                      (plVar12,*(uint64 *)
                                                                                (*plVar12 + 0x170));
                                                    lVar8 = FUN_1800d60b0(DAT_181da1040,1);
                                                    if (lVar8 != null) {
                                                      if (*(int *)(lVar8 + 24) == 0) {
                                                        uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                        FUN_1800d65f0(uVar10,0);
                                                      }
                                                      *(uint16 *)(lVar8 + 32) = 47;
                                                      if (lVar7 != null) {
                                                        uVar10 = String.Split(lVar7,lVar8,0);
                                                        plVar12 = (int64 *)
                                                                  il2cpp_internal(DAT_181d97750);
                                                        FUN_181827480(plVar12,uVar10,DAT_181da3c58);
                                                        goto LAB_18099c314;
                                                      }
                                                    }
                                                  }
                                                  throw; // [null/range check failed]
                                                }
                                              }
        LAB_18099c314:
                                              do {
                                                while( true ) {
                                                  iVar4 = (int)plVar6;
                                                  local_134 = iVar4;
                                                  lVar7 = *(int64 *)
                                                           (pStatics_3d40 + 0x4f8);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  plVar6 = plVar16;
                                                  if (lVar7.summonLv <= iVar4) goto LAB_18099c689;
                                                  if (2 < *(int *)(param + 24)) break;
        LAB_18099c3fa:
                                                  if (3 < *(int *)(param + 24)) {
                                                    plVar6 = (int64 *)
                                                             FUN_180002f80(param,3,DAT_181d95e88);
                                                    if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar6 + 64) !=
                                                        *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1800d6070(plVar6,DAT_181d80418);
                                                    }
                                                    piVar13 = (int *)il2cpp_object_unbox();
                                                    iVar4 = local_134;
                                                    if (*piVar13 != -1) {
                                                      plVar6 = (int64 *)
                                                               FUN_180002f80(param,3,DAT_181d95e88);
                                                      if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                      if (*(int64 *)(*plVar6 + 64) !=
                                                          *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                        FUN_1800d6070(plVar6,DAT_181d80418);
                                                      }
                                                      piVar13 = (int *)il2cpp_object_unbox();
                                                      if (*piVar13 < iVar4) goto LAB_18099c493;
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
                                                                           (lVar7,DAT_181d962e0),
                                                        lVar7 == null)) throw; // [null/range check failed]
                                                  Selectable.set_interactable(lVar7);
                                                  plVar6 = (int64 *)(uint64)(local_134 + 1);
                                                }
                                                plVar6 = (int64 *)
                                                         FUN_180002f80(param,2,DAT_181d95e88);
                                                if (plVar6 == (int64 *)0) break;
                                                if (*(int64 *)(*plVar6 + 64) !=
                                                    *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1800d6070(plVar6,DAT_181d80418);
                                                }
                                                piVar13 = (int *)il2cpp_object_unbox();
                                                iVar4 = local_134;
                                                if (*piVar13 == -1) goto LAB_18099c3fa;
                                                plVar6 = (int64 *)
                                                         FUN_180002f80(param,2,DAT_181d95e88);
                                                if (plVar6 == (int64 *)0) break;
                                                if (*(int64 *)(*plVar6 + 64) !=
                                                    *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1800d6070(plVar6,DAT_181d80418);
                                                }
                                                piVar13 = (int *)il2cpp_object_unbox();
                                                if (*piVar13 <= iVar4) goto LAB_18099c3fa;
        LAB_18099c493:
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
                                                                         (lVar7,DAT_181d962e0), lVar7 == null
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
                                                plVar6 = (int64 *)(uint64)(local_134 + 1);
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
                                          lVar7 = FUN_18046c0a0(0);
                                          if ((lVar7 != null) &&
                                             (lVar7 = lVar7.summonControlable, param != null)) {
                                            if (*(int *)(param + 24) == 0) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            plVar6 = *(int64 **)(*(int64 *)(param + 16) + 32);
                                            if ((lVar7 != null) && (plVar6 != (int64 *)0)) {
                                              if (*(int64 *)(*plVar6 + 64) !=
                                                  *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                FUN_1800d6070(plVar6,DAT_181d80418);
                                              }
                                              puVar11 = (uint32 *)il2cpp_object_unbox();
                                              lVar7 = WorldData.GetHero(lVar7,*puVar11,0);
                                              this.targetHero = lVar7;
                                              if (*(int *)(param + 24) == 0) {
                                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                              }
                                              plVar12 = *(int64 **)
                                                         (*(int64 *)(param + 16) + 32);
                                              if (plVar12 != (int64 *)0) {
                                                if (*(int64 *)(*plVar12 + 64) !=
                                                    *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                  FUN_1800d6070(plVar12,DAT_181d80418);
                                                }
                                                puVar11 = (uint32 *)il2cpp_object_unbox();
                                                local_128[0] = *puVar11;
                                                switch(local_128[0]) {
                                                case 0xffffff97:
                                                  local_120 = *(uint64 **)
                                                               (*(int64 *)(DAT_181d72d50 + 184) + 24
                                                               );
                                                  break;
                                                case 0xffffff98:
                                                  lVar7 = FUN_18046c0a0(0);
                                                  if ((lVar7 == null) || (lVar7.summonControlable == null))
                                                  throw; // [null/range check failed]
                                                  local_120 = *(uint64 **)
                                                               (lVar7.summonControlable + 0x218);
                                                  break;
                                                case 0xffffff99:
                                                  lVar7 = FUN_18046c400(0);
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
                                                  lVar7 = FUN_18046c0a0(0);
                                                  if (((lVar7 == null) || (lVar7.summonControlable == null))
                                                     || (lVar7 = *(int64 *)
                                                                  (lVar7.summonControlable + 0x1b0),
                                                        lVar7 == null)) throw; // [null/range check failed]
                                                  local_120 = lVar7.summonLv;
                                                  break;
                                                case 0xffffff9b:
                                                  lVar7 = FUN_18046bca0(0);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  if (lVar7.summonLv == null) {
                                                    lVar7 = FUN_18046c400(0);
                                                    if ((lVar7 == null) ||
                                                       (lVar7.hp == null))
                                                    throw; // [null/range check failed]
                                                    local_120 = *(uint64 **)
                                                                 (lVar7.hp + 40);
                                                  }
                                                  else {
                                                    lVar7 = FUN_18046bca0(0);
                                                    if ((lVar7 == null) || (lVar7.summonLv == null)
                                                       ) throw; // [null/range check failed]
                                                    local_120 = *(uint64 **)
                                                                 (lVar7.summonLv + 40);
                                                  }
                                                  break;
                                                case 0xffffff9c:
                                                  lVar7 = FUN_18046c400(0);
                                                  if ((lVar7 == null) || (lVar7.forceJobCD == null))
                                                  throw; // [null/range check failed]
                                                  local_120 = *(uint64 **)
                                                               (lVar7.forceJobCD + 128);
                                                  break;
                                                case 0xffffff9d:
                                                  lVar7 = FUN_18046c400(0);
                                                  if (lVar7 == null) throw; // [null/range check failed]
                                                  local_120 = lVar7.changeSkinCd;
                                                  break;
                                                default:
                                                  if (*plVar6 == 0) throw; // [null/range check failed]
                                                  local_120 = *(uint64 **)(*plVar6 + 0x220);
                                                }
                                                local_res8 = 0;
                                                plVar6 = plVar16;
                                                if ((*(int *)(param + 24) < 2) ||
                                                   (lVar7 = FUN_180002f80(param,1,DAT_181d95e88),
                                                   lVar7 == null)) {
        LAB_18099951e:
                                                  do {
                                                    while( true ) {
                                                      iVar4 = (int)plVar6;
                                                      local_138 = iVar4;
                                                      lVar7 = *(int64 *)
                                                               (pStatics_3d40 +
                                                               0x4f0);
                                                      if (lVar7 == null) throw; // [null/range check failed]
                                                      plVar6 = plVar16;
                                                      if (lVar7.summonLv <= iVar4)
                                                      goto LAB_180999899;
                                                      if (2 < *(int *)(param + 24)) break;
        LAB_18099960a:
                                                      if (3 < *(int *)(param + 24)) {
                                                        plVar6 = (int64 *)
                                                                 FUN_180002f80(param,3,DAT_181d95e88);
                                                        if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                        if (*(int64 *)(*plVar6 + 64) !=
                                                            *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                          FUN_1800d6070(plVar6,DAT_181d80418);
                                                        }
                                                        piVar13 = (int *)il2cpp_object_unbox();
                                                        iVar4 = local_138;
                                                        if (*piVar13 != -1) {
                                                          plVar6 = (int64 *)
                                                                   FUN_180002f80(param,3,DAT_181d95e88);
                                                          if (plVar6 == (int64 *)0)
                                                          throw; // [null/range check failed]
                                                          if (*(int64 *)(*plVar6 + 64) !=
                                                              *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                            FUN_1800d6070(plVar6,DAT_181d80418);
                                                          }
                                                          piVar13 = (int *)il2cpp_object_unbox();
                                                          if (*piVar13 < iVar4) goto LAB_1809996a3;
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
                                                                            (lVar7,DAT_181d962e0),
                                                         lVar7 == null)) throw; // [null/range check failed]
                                                      Selectable.set_interactable(lVar7);
                                                      plVar6 = (int64 *)(uint64)(local_138 + 1);
                                                    }
                                                    plVar6 = (int64 *)
                                                             FUN_180002f80(param,2,DAT_181d95e88);
                                                    if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar6 + 64) !=
                                                        *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1800d6070(plVar6,DAT_181d80418);
                                                    }
                                                    piVar13 = (int *)il2cpp_object_unbox();
                                                    iVar4 = local_138;
                                                    if (*piVar13 == -1) goto LAB_18099960a;
                                                    plVar6 = (int64 *)
                                                             FUN_180002f80(param,2,DAT_181d95e88);
                                                    if (plVar6 == (int64 *)0) throw; // [null/range check failed]
                                                    if (*(int64 *)(*plVar6 + 64) !=
                                                        *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                                                      FUN_1800d6070(plVar6,DAT_181d80418);
                                                    }
                                                    piVar13 = (int *)il2cpp_object_unbox();
                                                    if (*piVar13 <= iVar4) goto LAB_18099960a;
        LAB_1809996a3:
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
                                                                                 (lVar7,DAT_181d962e0),
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
                                                plVar12 = (int64 *)
                                                          FUN_180002f80(param,1,DAT_181d95e88);
                                                if (plVar12 != (int64 *)0) {
                                                  lVar7 = (**(code **)(*plVar12 + 0x168))
                                                                    (plVar12,*(uint64 *)
                                                                              (*plVar12 + 0x170));
                                                  lVar8 = FUN_1800d60b0(DAT_181da1040,1);
                                                  if (lVar8 != null) {
                                                    if (*(int *)(lVar8 + 24) == 0) {
                                                      uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1800d65f0(uVar10,0);
                                                    }
                                                    *(uint16 *)(lVar8 + 32) = 47;
                                                    if (lVar7 != null) {
                                                      uVar10 = String.Split(lVar7,lVar8,0);
                                                      local_res8 = il2cpp_internal(DAT_181d97750);
                                                      FUN_181827480(local_res8,uVar10,DAT_181da3c58);
                                                      goto LAB_18099951e;
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
                                  local_120 = puVar9;
                                  il2cpp_internal(puVar9,uVar10);
                                  if (this.itemList != null) {
                                    GameObject.SetActive(this.itemList,0,0);
                                    if ((this.heroList != null) &&
                                       (GameObject.SetActive(this.heroList,1,0),
                                       plVar6 = plVar16, param != null)) {
        LAB_180998cc0:
                                      do {
                                        uVar5 = (uint32)plVar6;
                                        if ((int)*(uint32 *)(param + 24) <= (int)uVar5)
                                        goto LAB_18099bf9f;
                                        if (*(uint32 *)(param + 24) <= uVar5) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        plVar6 = *(int64 **)
                                                  (*(int64 *)(param + 16) + 32 +
                                                  (int64)(int)uVar5 * 8);
                                        plVar12 = plVar16;
                                        if (plVar6 != (int64 *)0) {
                                          if ((*(byte *)(*plVar6 + 300) < *(byte *)(DAT_181d75eb8 + 300))
                                             || (bVar1 = true,
                                                *(int64 *)
                                                 (*(int64 *)(*plVar6 + 200) + -8 +
                                                 (uint64)*(byte *)(DAT_181d75eb8 + 300) * 8) !=
                                                DAT_181d75eb8)) {
                                            bVar1 = false;
                                          }
                                          if (bVar1) {
                                            plVar12 = plVar6;
                                          }
                                          if (plVar12 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                                            FUN_1800d6070(plVar6);
                                          }
                                        }
                                        if (_filterType == 9) {
                                          lVar7 = FUN_18046c0a0(0);
                                          if ((lVar7 == null) || (lVar7.summonControlable == null)) break;
                                          plVar6 = (int64 *)WorldData.Player();
                                          if (plVar12 == plVar6) goto LAB_180998f46;
                                          if (((plVar12 == (int64 *)0) || (plVar12[97] == 0)) ||
                                             (lVar7 = *(int64 *)(plVar12[97] + 16)) == null)
                                          break;
                                          iVar4 = FUN_1800d6760(lVar7,16,DAT_181d8fa18);
                                          if (iVar4 < 1) {
                                            plVar6 = (int64 *)(uint64)(uVar5 + 1);
                                            goto LAB_180998cc0;
                                          }
        LAB_180998e61:
                                          uVar10 = *puVar9;
                                          lVar7 = FUN_18046c1a0(0);
                                          if (lVar7 == null) break;
                                          uVar14 = lVar7.forceJobType;
                                          uVar10 = GlobalData.AddChild(uVar10,uVar14,0);
                                          this.newObj = uVar10;
                                          if ((this.newObj == null) ||
                                             (lVar7 = GameObject.GetComponent
                                                                (this.newObj,
                                                                 DAT_181d71b50), lVar7 == null)) break;
                                          lVar7.summonControlable = plVar12;
                                          if ((this.newObj == null) ||
                                             (((lVar7 = GameObject.GetComponent
                                                                  (this.newObj,
                                                                   DAT_181d71b50), lVar7 == null ||
                                               (lVar7.summonLv = 3,
                                               this.newObj == null)) ||
                                              (lVar7 = GameObject.GetComponent()) == null))) break;
                                          HeroIconController.AutoSetName(lVar7);
                                          puVar9 = local_120;
                                        }
                                        else {
                                          if (_filterType != 10) goto LAB_180998e61;
                                          lVar7 = FUN_18046c0a0(0);
                                          if ((lVar7 == null) || (lVar7.summonControlable == null)) break;
                                          plVar6 = (int64 *)WorldData.Player();
                                          if (plVar12 != plVar6) {
                                            if (((plVar12 == (int64 *)0) || (plVar12[97] == 0)) ||
                                               (lVar7 = *(int64 *)(plVar12[97] + 16)) == null)
                                            break;
                                            iVar4 = FUN_1800d6760(lVar7,17,DAT_181d8fa18);
                                            if (0 < iVar4) goto LAB_180998e61;
                                          }
                                        }
        LAB_180998f46:
                                        plVar6 = (int64 *)(uint64)(uVar5 + 1);
                                      } while( true );
                                    }
                                  }
                                }
                              }
                              else {
        LAB_18099bf9f:
                                uVar10 = this.targetGrid;
                                GlobalData.SortChild(uVar10,0);
                                if (this.targetGrid != null) {
                                  uVar10 = GameObject.GetComponent
                                                     (this.targetGrid,DAT_181d72bc8);
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
        LAB_18099c689:
        iVar4 = (int)plVar6;
        local_12c = iVar4;
        lVar7 = *(int64 *)(pStatics_3d40 + 0x4a0);
        if (lVar7 == null) throw; // [null/range check failed]
        if (iVar4 < lVar7.summonLv) {
          if (plVar12 == (int64 *)0) {
        LAB_18099c84d:
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181d962e0)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7);
            plVar6 = (int64 *)(uint64)(local_12c + 1);
          }
          else {
            uVar10 = Int32.ToString(&local_12c,0);
            cVar2 = FUN_18181e400(plVar12,uVar10);
            if (cVar2) goto LAB_18099c84d;
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181d962e0)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7,0);
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"SkillFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"SkillTypeFlitter");
            uVar10 = Int32.ToString(&local_12c,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7)) == null) throw; // [null/range check failed]
            Toggle.set_isOn(lVar7);
            plVar6 = (int64 *)(uint64)(local_12c + 1);
          }
          goto LAB_18099c689;
        }
        lVar7 = this.targetHero;
        if (lVar7 != null) goto LAB_18099c920;
        throw; // [null/range check failed]
        LAB_18099c920:
        if (lVar7.kungfuSkills == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar16;
        if (*(int *)(lVar7.kungfuSkills + 24) <= (int)uVar5) goto LAB_18099bf9f;
        if ((lVar7 = lVar7?.kungfuSkills) == null) throw; // [null/range check failed]
        if (lVar7.summonLv <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = lVar7.isSummon[uVar5];
        if (plVar12 != (int64 *)0) {
          if (lVar7 != null) {
            local_128[0] = KungfuSkillLvData.Type(lVar7,0);
            uVar10 = Int32.ToString(local_128,0);
            cVar2 = FUN_18181e400(plVar12,uVar10,DAT_181da3e58);
            if (cVar2) goto LAB_18099c9ad;
            goto LAB_18099d731;
          }
          throw; // [null/range check failed]
        }
        LAB_18099c9ad:
        if (2 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if ((lVar7 == null) || (lVar8 = KungfuSkillLvData.DataBase(lVar7,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            plVar6 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099d731;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if ((lVar7 == null) || (lVar8 = KungfuSkillLvData.DataBase(lVar7,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            plVar6 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (*piVar13 < iVar4) goto LAB_18099d731;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonID;
            plVar6 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099d731;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonID;
            plVar6 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (*piVar13 < iVar4) goto LAB_18099d731;
          }
        }
        if (_filterType == 1) {
          if (lVar7 == null) throw; // [null/range check failed]
          cVar2 = KungfuSkillLvData.SkillMeetObstacleLv(lVar7,0);
          if ((!cVar2) || (cVar2 = KungfuSkillLvData.CanUpgrade(lVar7,0), !cVar2))
          goto LAB_18099d731;
        switchD_18099cd15_caseD_14:
          uVar10 = this.targetGrid;
          lVar7 = FUN_18046c1a0(0);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar14 = lVar7.thisYearContribution;
          uVar10 = GlobalData.AddChild(uVar10,uVar14,0);
          this.newObj = uVar10;
          if (this.newObj == null) throw; // [null/range check failed]
          lVar7 = GameObject.GetComponent(this.newObj,DAT_181d73800);
          if (((this.targetHero == null) ||
              (lVar8 = this.targetHero.kungfuSkills) == null) ||
             (uVar10 = FUN_180002f80(lVar8,plVar16), lVar7 == null)) throw; // [null/range check failed]
          lVar7.summonControlable = uVar10;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181d73800)) == null)
          throw; // [null/range check failed]
          lVar7.summonSourceHero = 4;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181d73800)) == null)
          throw; // [null/range check failed]
          lVar7.summonLv = uVar5;
          if ((this.newObj == null) ||
             (lVar7 = GameObject.GetComponent(this.newObj,DAT_181d73800)) == null)
          throw; // [null/range check failed]
          SkillIconController.AutoSetName(lVar7,0,0,0);
        }
        else {
          if (_filterType == 12) {
        switchD_18099cd15_caseD_17:
            lVar8 = FUN_18046c0a0(0);
            if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar7 == null)) || (lVar8 == null))
            throw; // [null/range check failed]
            lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
            if (lVar7 == null) goto switchD_18099cd15_caseD_14;
            goto LAB_18099d731;
          }
          switch(_filterType) {
          case 18:
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 112) != 0) {
              lVar8 = FUN_18046c400(0);
              if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
              if (lVar8 != null) {
                lVar8 = FUN_18046c0a0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
                if (lVar8 != null) {
                  lVar8 = FUN_18046c400(0);
                  if (((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) ||
                     (lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),
                                                  lVar7.isSummon,0), lVar8 == null))
                  throw; // [null/range check failed]
                  iVar4 = *(int *)(lVar8 + 20);
                  lVar8 = FUN_18046c0a0(0);
                  if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                     ((lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar8 == null ||
                      (lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0)) == null)))
                  throw; // [null/range check failed]
                  if (iVar4 <= *(int *)(lVar8 + 20)) {
                    lVar8 = FUN_18046c400(0);
                    if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 112)) == null)
                    throw; // [null/range check failed]
        LAB_18099cf02:
                    lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
                    if (lVar7 == null) throw; // [null/range check failed]
                    if (lVar7.summonID < 10) goto switchD_18099cd15_caseD_14;
                  }
                }
              }
            }
            break;
          case 19:
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 112) != 0) {
              lVar8 = FUN_18046c400(0);
              if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
              if (lVar8 != null) {
                lVar8 = FUN_18046c0a0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
                if (lVar8 != null) {
                  lVar8 = FUN_18046c400(0);
                  if (((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) ||
                     (lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),
                                                  lVar7.isSummon,0), lVar8 == null))
                  throw; // [null/range check failed]
                  iVar4 = *(int *)(lVar8 + 20);
                  lVar8 = FUN_18046c0a0(0);
                  if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                     ((lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0), lVar8 == null ||
                      (lVar8 = HeroData.FindSkill(lVar8,lVar7.isSummon,0)) == null)))
                  throw; // [null/range check failed]
                  if (*(int *)(lVar8 + 20) <= iVar4) {
                    lVar8 = FUN_18046c0a0(0);
                    if (((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) &&
                       (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) != null)
                    goto LAB_18099cf02;
                    throw; // [null/range check failed]
                  }
                }
              }
            }
            break;
          default:
            goto switchD_18099cd15_caseD_14;
          case 22:
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 112) == 0) break;
            lVar8 = FUN_18046c400(0);
            if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
            if (lVar8 != null) break;
            lVar8 = KungfuSkillLvData.DataBase(lVar7,0);
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            lVar8 = FUN_18046c400(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar8 + 112) + 184) < iVar4) break;
            lVar8 = FUN_18046c0a0(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
            lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0);
            lVar15 = FUN_18046c400(0);
            if (((lVar15 == null) || (*(int64 *)(lVar15 + 112) == 0)) || (lVar8 == null))
            throw; // [null/range check failed]
            cVar2 = HeroData.HaveBrother(lVar8,*(uint32 *)(*(int64 *)(lVar15 + 112) + 88));
            if (!cVar2) {
              lVar8 = FUN_18046c0a0(0);
              if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
              lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0);
              lVar15 = FUN_18046c400(0);
              if (((lVar15 == null) || (*(int64 *)(lVar15 + 112) == 0)) || (lVar8 == null))
              throw; // [null/range check failed]
              cVar2 = HeroData.HavePrelover(lVar8,*(uint32 *)(*(int64 *)(lVar15 + 112) + 88));
              if (cVar2) goto switchD_18099cd15_caseD_14;
              lVar8 = FUN_18046c0a0(0);
              if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                 (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
              throw; // [null/range check failed]
              iVar4 = *(int *)(lVar8 + 0x328);
              lVar8 = FUN_18046c400(0);
              if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
              if (iVar4 != *(int *)(*(int64 *)(lVar8 + 112) + 88)) {
                lVar7 = KungfuSkillLvData.DataBase(lVar7,0);
                if (lVar7 == null) throw; // [null/range check failed]
                if (4 < lVar7.manageAiHour) break;
              }
            }
            goto switchD_18099cd15_caseD_14;
          case 23:
            goto switchD_18099cd15_caseD_17;
          case 26:
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 112) != 0) {
              lVar8 = FUN_18046c400(0);
              if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
              if (lVar8 == null) {
                lVar7 = KungfuSkillLvData.DataBase(lVar7,0);
                if (lVar7 == null) throw; // [null/range check failed]
                iVar4 = lVar7.manageAiHour;
                lVar7 = FUN_18046c400(0);
                if ((lVar7 == null) || (lVar7.heroFamilyName == null)) throw; // [null/range check failed]
                if (iVar4 <= *(int *)(lVar7.heroFamilyName + 184))
                goto switchD_18099cd15_caseD_14;
              }
            }
            break;
          case 28:
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 112) != 0) {
              lVar8 = FUN_18046c400(0);
              if (((lVar8 == null) || (lVar7 == null)) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),lVar7.isSummon,0);
              if (lVar8 != null) {
                lVar8 = FUN_18046c0a0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
                throw; // [null/range check failed]
                lVar7 = HeroData.FindSkill(lVar8,lVar7.isSummon,0);
                if (lVar7 != null) goto switchD_18099cd15_caseD_14;
              }
            }
          }
        }
        LAB_18099d731:
        lVar7 = this.targetHero;
        plVar16 = (int64 *)(uint64)(uVar5 + 1);
        if (lVar7 == null) throw; // [null/range check failed]
        goto LAB_18099c920;
        LAB_180999b30:
        plVar12 = &this.targetHero;
        lVar7 = local_120[5];
        if (lVar7 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (lVar7.summonLv <= (int)uVar5) {
          if (_filterType == 14) {
            lVar7 = FUN_18046c0a0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage, plVar6 = plVar16) != null) goto LAB_18099ba50;
          }
          else if (_filterType == 8) {
            lVar7 = FUN_18046c0a0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_18099b930;
          }
          else if (_filterType == 6) {
            lVar7 = FUN_18046c0a0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_18099b850;
          }
          else if (_filterType == 25) {
            lVar7 = FUN_18046c0a0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               (lVar7 = lVar7.selfStorage) != null) goto LAB_18099b440;
          }
          else {
            if (_filterType != 27) goto LAB_18099bf9f;
            lVar7 = FUN_18046c0a0(0);
            if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
               ((lVar7 = WorldData.Player(lVar7.summonControlable,0), lVar7 != null &&
                (lVar7 = lVar7.selfStorage, plVar6 = plVar16) != null)))
            goto LAB_18099ace0;
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
            cVar2 = FUN_18181e400(local_res8,uVar10);
            if (cVar2) goto LAB_180999b9a;
            goto LAB_18099ac3b;
          }
          throw; // [null/range check failed]
        }
        LAB_180999b9a:
        if (2 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7 + 60);
            plVar6 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099ac3b;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7 + 60);
            plVar6 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (*piVar13 < iVar4) goto LAB_18099ac3b;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonLv;
            plVar6 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 != *piVar13) goto LAB_18099ac3b;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar7 == null) throw; // [null/range check failed]
            iVar4 = lVar7.dailyAIManaged;
            plVar6 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar6,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099ac3b;
          }
        }
        if (6 < *(int *)(param + 24)) {
          plVar6 = (int64 *)FUN_180002f80(param,6,DAT_181d95e88);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar6,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 == -1) goto LAB_180999ec2;
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == null) {
            if (lVar7.hide != null) {
              iVar4 = *(int *)(lVar7.hide + 20);
              plVar6 = (int64 *)FUN_180002f80(param,6,DAT_181d95e88);
              if (plVar6 != (int64 *)0) {
                if (*(int64 *)(*plVar6 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar6,DAT_181d80418);
                }
                piVar13 = (int *)il2cpp_object_unbox();
                if (iVar4 == *piVar13) goto LAB_180999ec2;
                goto LAB_18099ac3b;
              }
            }
            throw; // [null/range check failed]
          }
          goto LAB_18099ac3b;
        }
        LAB_180999ec2:
        switch(_filterType) {
        case 2:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID - 1U < 2) goto switchD_180999ee7_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_180999b30;
        case 3:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv < 2)) {
        LAB_180999f31:
            lVar8 = FUN_18046bde0();
            if (lVar8 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar8 + 48) != lVar7) {
              lVar8 = FUN_18046bde0();
              if (lVar8 == null) throw; // [null/range check failed]
              if (*(int64 *)(lVar8 + 64) != lVar7) goto switchD_180999ee7_caseD_9;
              plVar6 = (int64 *)(uint64)(uVar5 + 1);
              goto LAB_180999b30;
            }
          }
          break;
        case 4:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv == 2)) goto LAB_180999f31;
          break;
        case 5:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 5) && (lVar7.summonLv == 3)) goto LAB_180999f31;
          break;
        case 6:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID == 3) && (lVar7.heroAIData < 5)) {
            if (this.targetHero == null) throw; // [null/range check failed]
            lVar8 = HeroData.FindSameBook(this.targetHero,lVar7);
            if (lVar8 != null) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          break;
        case 7:
          lVar8 = FUN_18046c0a0(0);
          if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
             (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) throw; // [null/range check failed]
          fVar17 = (float)HeroData.GetIdentifyKnowledge(lVar8,0);
          lVar8 = FUN_18046bca0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          iVar4 = 0;
          if (*(int64 *)(lVar8 + 24) != 0) {
            lVar8 = FUN_18046bca0(0);
            uVar3 = FUN_18171e540(this.sendResultParam,"true");
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = BuildingUIController.GetBuildingExtraKnowledge(lVar8,uVar3);
          }
          if ((lVar7 == null) || (lVar8 = lVar7.heroNickName) == null) throw; // [null/range check failed]
          if (*(char *)(lVar8 + 16) == false) {
            if (*(float *)(lVar8 + 20) <= (float)iVar4 + fVar17) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          break;
        case 8:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if ((lVar7.heroFamilyName == null) || (this.targetHero == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill(this.targetHero,*(uint32 *)(lVar7.heroFamilyName + 16));
            if ((lVar8 == null) || (*(int *)(lVar8 + 20) < 10)) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          break;
        default:
          goto switchD_180999ee7_caseD_9;
        case 11:
          if (lVar7 == null) throw; // [null/range check failed]
          cVar2 = ItemData.Equiped(lVar7,0);
          if (!cVar2) goto switchD_180999ee7_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_180999b30;
        case 13:
          lVar8 = FUN_18046c400(0);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) != 0) {
            lVar8 = FUN_18046c400(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            cVar2 = HeroData.HaveHobby(*(int64 *)(lVar8 + 112),lVar7);
            if (cVar2) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          goto switchD_180999ee7_caseD_9;
        case 14:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if (lVar7.heroFamilyName == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar7.heroFamilyName + 16);
            lVar8 = FUN_18046bc40();
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
            if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          break;
        case 15:
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.summonID != 5) || (lVar7.summonLv != 4)) break;
          lVar8 = FUN_18046bda0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 56);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_18046bda0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 56) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 56),DAT_181d720a0)) == null)
            throw; // [null/range check failed]
            if (lVar7 == *(int64 *)(lVar8 + 32)) break;
          }
          lVar8 = FUN_18046bda0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 72);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_18046bda0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 72) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 72),DAT_181d720a0)) == null)
            throw; // [null/range check failed]
            if (lVar7 == *(int64 *)(lVar8 + 32)) break;
          }
          lVar8 = FUN_18046bda0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar10 = *(uint64 *)(lVar8 + 88);
          cVar2 = Object.op_Inequality(uVar10,0);
          if (cVar2) {
            lVar8 = FUN_18046bda0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 88) == 0)) ||
               (lVar8 = GameObject.GetComponent(*(int64 *)(lVar8 + 88),DAT_181d720a0)) == null)
            throw; // [null/range check failed]
            if (lVar7 != *(int64 *)(lVar8 + 32)) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          goto switchD_180999ee7_caseD_9;
        case 16:
          if (((lVar7 == null) || (lVar7.hide == null)) ||
             (lVar8 = *(int64 *)(lVar7.hide + 64)) == null) throw; // [null/range check failed]
          if (0.0 < *(float *)(lVar8 + 16)) {
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
        switchD_180999ee7_caseD_9:
          uVar10 = this.targetGrid;
          lVar8 = FUN_18046c1a0(0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar14 = *(uint64 *)(lVar8 + 160);
          uVar10 = GlobalData.AddChild(uVar10,uVar14);
          this.newObj = uVar10;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181d720a0)) == null)
          throw; // [null/range check failed]
          *(int64 *)(lVar8 + 32) = lVar7;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181d720a0)) == null)
          throw; // [null/range check failed]
          *(uint32 *)(lVar8 + 40) = 3;
          if ((this.newObj == null) ||
             (lVar8 = GameObject.GetComponent(this.newObj,DAT_181d720a0)) == null)
          throw; // [null/range check failed]
          ItemIconController.AutoSetName(lVar8,1);
          if ((targetFavorHero != null) && (cVar2 = HeroData.HaveHobby(targetFavorHero,lVar7), cVar2)) {
            uVar10 = this.newObj;
            lVar7 = FUN_18046c680(0);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar14 = TextureController.LoadAtlasSprite(lVar7,"UIAtlas","友善度",0);
            local_118 = 0x420c0000;
            uStack_114 = 0x420c0000;
            uStack_110 = 0;
            local_f8 = 0;
            uStack_f0 = 0;
            FUN_181308660(&local_f8,&local_118,DAT_181dba8c0);
            local_108 = local_f8;
            uStack_100 = uStack_f0;
            local_d8 = 0;
            uStack_d0 = 0;
            lVar7 = GlobalData.AddImage(uVar10,"HobbyIcon",uVar14,&local_108,&local_d8,0);
            if (lVar7 == null) throw; // [null/range check failed]
            plVar6 = (int64 *)GameObject.GetComponent(lVar7,DAT_181d71e80);
            uVar10 = 0;
            local_e8 = 0;
            uStack_e0 = 0;
            Color.ctor(&local_e8);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            lVar8 = *plVar6;
            local_108 = local_e8;
            uStack_100 = uStack_e0;
            (**(code **)(lVar8 + 0x2a8))(plVar6,&local_108,*(uint64 *)(lVar8 + 0x2b0),lVar8,uVar10);
            plVar6 = (int64 *)GameObject.GetComponent(lVar7,DAT_181d71e80);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar6 + 0x408))(plVar6,*(uint64 *)(*plVar6 + 0x410));
            lVar8 = GameObject.AddComponent(lVar7,DAT_181dc5d30);
            if (lVar8 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar8 + 24) = "对方喜好\n赠送好感加倍";
            lVar7 = GameObject.GetComponent(lVar7,DAT_181d73448);
            if (lVar7 == null) throw; // [null/range check failed]
            lVar7.summonSourceHero = 1;
          }
          break;
        case 17:
          if (lVar7 == null) throw; // [null/range check failed]
          if (0.0 < *(float *)(lVar7 + 76)) {
            cVar2 = ItemData.DetectPoisonNum(lVar7,0);
            if (cVar2) goto switchD_180999ee7_caseD_9;
            plVar6 = (int64 *)(uint64)(uVar5 + 1);
            goto LAB_180999b30;
          }
          break;
        case 20:
          lVar8 = FUN_180990820();
          if (lVar8 == null) throw; // [null/range check failed]
          plVar6 = plVar16;
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
                lVar8 = FUN_180990820(0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar8 + 32) + 24) <= (int)plVar6)
                goto switchD_180999ee7_caseD_9;
                lVar8 = FUN_180990820(0);
                if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                uVar10 = FUN_180002f80(*(int64 *)(lVar8 + 32),plVar6);
                cVar2 = Object.op_Inequality(uVar10,0);
                if (cVar2) {
                  lVar8 = FUN_180990820(0);
                  if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                      (lVar8 = FUN_180002f80(*(int64 *)(lVar8 + 32),plVar6)) == null) ||
                     (lVar8 = GameObject.GetComponent(lVar8,DAT_181d720a0)) == null)
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
            lVar8 = FUN_18046c0a0(0);
            if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
               (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) throw; // [null/range check failed]
            plVar6 = plVar16;
            if (iVar4 != *(int *)(lVar8 + 132)) {
              while( true ) {
                lVar8 = FUN_18046c0a0(0);
                if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                    (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 0x218)) == null) ||
                   (lVar8 = *(int64 *)(lVar8 + 40)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar8 + 24) <= (int)plVar6) goto switchD_180999ee7_caseD_9;
                lVar8 = FUN_18046c0a0(0);
                if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                    ((lVar8 = *(int64 *)(*(int64 *)(lVar8 + 32) + 0x218), lVar8 == null ||
                     (((lVar8 = *(int64 *)(lVar8 + 40), lVar8 == null ||
                       (lVar8 = FUN_180002f80(lVar8,plVar6)) == null) ||
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
          lVar8 = FUN_18046c400();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar8 + 112) == 0) {
            fVar17 = 0.0;
          }
          else {
            lVar8 = FUN_18046c400(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            fVar17 = (float)HeroData.GetIdentifyKnowledge(*(int64 *)(lVar8 + 112),0);
          }
          if ((lVar7 == null) || (lVar8 = lVar7.heroNickName) == null) throw; // [null/range check failed]
          if (*(char *)(lVar8 + 16) != false) break;
          if (*(float *)(lVar8 + 20) <= fVar17) goto switchD_180999ee7_caseD_9;
          plVar6 = (int64 *)(uint64)(uVar5 + 1);
          goto LAB_180999b30;
        case 27:
          if (lVar7 == null) throw; // [null/range check failed]
          if (lVar7.summonID == 3) {
            if ((lVar7.heroFamilyName == null) ||
               (lVar8 = BookData.DataBase(lVar7.heroFamilyName,0)) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            lVar8 = FUN_18046c400();
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
              lVar8 = FUN_18046c400(0);
              if (lVar8 == null) throw; // [null/range check failed]
              if ((lVar7.heroFamilyName == null) || (*(int64 *)(lVar8 + 112) == 0))
              throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(*(int64 *)(lVar8 + 112),
                                          *(uint32 *)(lVar7.heroFamilyName + 16));
              if (lVar8 == null) goto switchD_180999ee7_caseD_9;
            }
          }
        }
        LAB_18099ac3b:
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_180999b30;
        LAB_18099ba50:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) {
          lVar7 = FUN_18046c0a0(0);
          if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
             (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) {
            lVar7 = HeroData.GetForce(lVar7,0,0);
            if (lVar7 == null) goto LAB_18099bf9f;
            lVar7 = FUN_18046c0a0(0);
            if ((((lVar7 != null) && (lVar7.summonControlable != null)) &&
                (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) &&
               ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 != null &&
                (lVar7 = lVar7.heroForceLv, plVar6 = plVar16) != null))) goto LAB_18099bc20;
          }
          throw; // [null/range check failed]
        }
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
             (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
          lVar8 = FUN_18046bc40();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
          if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
            if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
            uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
            ChooseController.CreateChooseItem(this,uVar10,"仓库",0);
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099ba50;
        LAB_18099bc20:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        plVar12 = plVar16;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_18099bd20;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
             (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
          lVar8 = FUN_18046bc40();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
          if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
            if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
            uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
            ChooseController.CreateChooseItem(this,uVar10,"藏经阁",0);
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099bc20;
        LAB_18099bd20:
        if ((((*pStatics_2cc8 == 0) ||
             (lVar7 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
            (lVar7 = WorldData.Player(lVar7,0)) == null) ||
           ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 == null || (lVar7.heroAIData == null))))
        throw; // [null/range check failed]
        if (*(int *)(lVar7.heroAIData + 24) <= (int)plVar12) goto LAB_18099bf9f;
        lVar7 = FUN_18046c0a0(0);
        if (lVar7 == null) throw; // [null/range check failed]
        lVar7 = lVar7.summonControlable;
        lVar8 = FUN_18046c0a0(0);
        if ((((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
              (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) ||
             ((lVar8 = HeroData.GetForce(lVar8,0,0), lVar8 == null || (*(int64 *)(lVar8 + 64) == 0))))
            || (FUN_1800d6760(*(int64 *)(lVar8 + 64),plVar12), lVar7 == null)) ||
           (lVar7 = WorldData.GetForce(lVar7)) == null) throw; // [null/range check failed]
        lVar7 = lVar7.heroForceLv;
        plVar6 = plVar16;
        while( true ) {
          if ((lVar7 == null) || (lVar7.summonSourceHero == null)) throw; // [null/range check failed]
          if (*(int *)(lVar7.summonSourceHero + 24) <= (int)plVar6) break;
          lVar8 = FUN_180002f80();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 3) {
            if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
               (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            iVar4 = *(int *)(*(int64 *)(lVar8 + 112) + 16);
            lVar8 = FUN_18046bc40(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
            if (iVar4 == *(int *)(*(int64 *)(lVar8 + 24) + 16)) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
              ChooseController.CreateChooseItem(this,uVar10,"附庸藏经阁",0);
            }
          }
          plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
        }
        plVar12 = (int64 *)(uint64)((int)plVar12 + 1);
        goto LAB_18099bd20;
        LAB_18099b930:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar16;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_18099bf9f;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if ((*(int64 *)(lVar8 + 112) == 0) || (*plVar12 == 0)) throw; // [null/range check failed]
          lVar15 = HeroData.FindSkill(*plVar12,*(uint32 *)(*(int64 *)(lVar8 + 112) + 16),0);
          if (lVar15 != null) {
            if (((*(int64 *)(lVar8 + 112) == 0) || (*plVar12 == 0)) ||
               (lVar15 = HeroData.FindSkill(*plVar12,*(uint32 *)(*(int64 *)(lVar8 + 112) + 16),
                                             0), lVar15 == null)) throw; // [null/range check failed]
            if (9 >= *(int *)(lVar15 + 20))
            {
              }
              ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
              }
            }
        plVar16 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099b930;
        LAB_18099b850:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar16;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_18099bf9f;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if ((*(int *)(lVar8 + 20) == 3) && (*(int *)(lVar8 + 64) < 5)) {
          if (*plVar12 == 0) throw; // [null/range check failed]
          lVar15 = HeroData.FindSameBook(*plVar12,lVar8,0);
          if (lVar15 != null) {
            ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
          }
        }
        plVar16 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099b850;
        LAB_18099b440:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar16;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_18099bf9f;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (local_res8 != 0) {
          if (lVar8 != null) {
            local_128[0] = *(uint32 *)(lVar8 + 20);
            uVar10 = Int32.ToString(local_128,0);
            cVar2 = FUN_18181e400(local_res8,uVar10,DAT_181da3e58);
            if (cVar2) goto LAB_18099b4aa;
            goto LAB_18099b7e3;
          }
          throw; // [null/range check failed]
        }
        LAB_18099b4aa:
        if (2 < *(int *)(param + 24)) {
          plVar16 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
          if (plVar16 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar16,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 60);
            plVar16 = (int64 *)FUN_180002f80(param,2,DAT_181d95e88);
            if (plVar16 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar16,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099b7e3;
          }
        }
        if (3 < *(int *)(param + 24)) {
          plVar16 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
          if (plVar16 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar16,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 60);
            plVar16 = (int64 *)FUN_180002f80(param,3,DAT_181d95e88);
            if (plVar16 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar16,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (*piVar13 < iVar4) goto LAB_18099b7e3;
          }
        }
        if (4 < *(int *)(param + 24)) {
          plVar16 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
          if (plVar16 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar16,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 24);
            plVar16 = (int64 *)FUN_180002f80(param,4,DAT_181d95e88);
            if (plVar16 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar16,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 != *piVar13) goto LAB_18099b7e3;
          }
        }
        if (5 < *(int *)(param + 24)) {
          plVar16 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
          if (plVar16 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar16,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 != -1) {
            if (lVar8 == null) throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 56);
            plVar16 = (int64 *)FUN_180002f80(param,5,DAT_181d95e88);
            if (plVar16 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar16,DAT_181d80418);
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 < *piVar13) goto LAB_18099b7e3;
          }
        }
        if (*(int *)(param + 24) < 7) {
        LAB_18099b7ca:
          ChooseController.CreateChooseItem(this,lVar8,"仓库",0);
        }
        else {
          plVar16 = (int64 *)FUN_180002f80(param,6,DAT_181d95e88);
          if (plVar16 == (int64 *)0) throw; // [null/range check failed]
          if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar16,DAT_181d80418);
          }
          piVar13 = (int *)il2cpp_object_unbox();
          if (*piVar13 == -1) goto LAB_18099b7ca;
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 0) {
            if (*(int64 *)(lVar8 + 96) == 0) throw; // [null/range check failed]
            iVar4 = *(int *)(*(int64 *)(lVar8 + 96) + 20);
            plVar16 = (int64 *)FUN_180002f80(param,6,DAT_181d95e88);
            if (plVar16 == (int64 *)0) throw; // [null/range check failed]
            if (*(int64 *)(*plVar16 + 64) != *(int64 *)(DAT_181d80418 + 64)) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070();
            }
            piVar13 = (int *)il2cpp_object_unbox();
            if (iVar4 == *piVar13) goto LAB_18099b7ca;
          }
        }
        LAB_18099b7e3:
        plVar16 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099b440;
        LAB_18099ace0:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) {
          lVar7 = FUN_18046c0a0(0);
          if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
             (lVar7 = WorldData.Player(lVar7.summonControlable,0)) != null) {
            lVar7 = HeroData.GetForce(lVar7,0,0);
            if (lVar7 == null) goto LAB_18099bf9f;
            lVar7 = FUN_18046c0a0(0);
            if (((lVar7 != null) && (lVar7.summonControlable != null)) &&
               ((lVar7 = WorldData.Player(lVar7.summonControlable,0), lVar7 != null &&
                ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 != null &&
                 (lVar7 = lVar7.heroForceLv, plVar6 = plVar16) != null)))))
            goto LAB_18099af40;
          }
          throw; // [null/range check failed]
        }
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
             ((*(int64 *)(lVar8 + 112) == 0 || (lVar8 = BookData.DataBase()) == null)))
          throw; // [null/range check failed]
          iVar4 = *(int *)(lVar8 + 52);
          lVar8 = FUN_18046c400();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            lVar8 = *(int64 *)(lVar8 + 112);
            if ((((lVar7.summonSourceHero == null) ||
                 (lVar15 = FUN_180002f80(lVar7.summonSourceHero,plVar6)) == null) ||
                (*(int64 *)(lVar15 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill();
            if (lVar8 == null) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
              ChooseController.CreateChooseItem(this,uVar10,"仓库",0);
            }
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099ace0;
        LAB_18099af40:
        lVar8 = lVar7.summonSourceHero;
        if (lVar8 == null) throw; // [null/range check failed]
        uVar5 = (uint32)plVar6;
        plVar12 = plVar16;
        if (*(int *)(lVar8 + 24) <= (int)uVar5) goto LAB_18099b0d0;
        if (*(uint32 *)(lVar8 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar8 = lVar8[uVar5];
        if (lVar8 == null) throw; // [null/range check failed]
        if (*(int *)(lVar8 + 20) == 3) {
          if (((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
             ((*(int64 *)(lVar8 + 112) == 0 || (lVar8 = BookData.DataBase()) == null)))
          throw; // [null/range check failed]
          iVar4 = *(int *)(lVar8 + 52);
          lVar8 = FUN_18046c400();
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
          if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
            lVar8 = FUN_18046c400(0);
            if (lVar8 == null) throw; // [null/range check failed]
            lVar8 = *(int64 *)(lVar8 + 112);
            if ((((lVar7.summonSourceHero == null) ||
                 (lVar15 = FUN_180002f80(lVar7.summonSourceHero,plVar6)) == null) ||
                (*(int64 *)(lVar15 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
            lVar8 = HeroData.FindSkill();
            if (lVar8 == null) {
              if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
              uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
              ChooseController.CreateChooseItem(this,uVar10,"藏经阁",0);
            }
          }
        }
        plVar6 = (int64 *)(uint64)(uVar5 + 1);
        goto LAB_18099af40;
        LAB_18099b0d0:
        if ((((*pStatics_2cc8 == 0) ||
             (lVar7 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
            (lVar7 = WorldData.Player(lVar7,0)) == null) ||
           ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 == null || (lVar7.heroAIData == null))))
        throw; // [null/range check failed]
        if (*(int *)(lVar7.heroAIData + 24) <= (int)plVar12) goto LAB_18099bf9f;
        lVar7 = FUN_18046c0a0(0);
        if (lVar7 == null) throw; // [null/range check failed]
        lVar7 = lVar7.summonControlable;
        lVar8 = FUN_18046c0a0(0);
        if ((((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
            (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null) ||
           (((lVar8 = HeroData.GetForce(lVar8,0,0), lVar8 == null || (*(int64 *)(lVar8 + 64) == 0)) ||
            ((FUN_1800d6760(*(int64 *)(lVar8 + 64),plVar12), lVar7 == null ||
             (lVar7 = WorldData.GetForce(lVar7)) == null))))) throw; // [null/range check failed]
        lVar7 = lVar7.heroForceLv;
        plVar6 = plVar16;
        while( true ) {
          if ((lVar7 == null) || (lVar7.summonSourceHero == null)) throw; // [null/range check failed]
          if (*(int *)(lVar7.summonSourceHero + 24) <= (int)plVar6) break;
          lVar8 = FUN_180002f80();
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 20) == 3) {
            if ((((lVar7.summonSourceHero == null) || (lVar8 = FUN_180002f80()) == null) ||
                (*(int64 *)(lVar8 + 112) == 0)) || (lVar8 = BookData.DataBase()) == null)
            throw; // [null/range check failed]
            iVar4 = *(int *)(lVar8 + 52);
            lVar8 = FUN_18046c400(0);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 112) == 0)) throw; // [null/range check failed]
            if (iVar4 <= *(int *)(*(int64 *)(lVar8 + 112) + 184)) {
              lVar8 = FUN_18046c400(0);
              if (lVar8 == null) throw; // [null/range check failed]
              lVar8 = *(int64 *)(lVar8 + 112);
              if ((((lVar7.summonSourceHero == null) ||
                   (lVar15 = FUN_180002f80(lVar7.summonSourceHero,plVar6)) == null) ||
                  (*(int64 *)(lVar15 + 112) == 0)) || (lVar8 == null)) throw; // [null/range check failed]
              lVar8 = HeroData.FindSkill(lVar8);
              if (lVar8 == null) {
                if (lVar7.summonSourceHero == null) throw; // [null/range check failed]
                uVar10 = FUN_180002f80(lVar7.summonSourceHero,plVar6,DAT_181d90f18);
                ChooseController.CreateChooseItem(this,uVar10,"附庸藏经阁",0);
              }
            }
          }
          plVar6 = (int64 *)(uint64)((int)plVar6 + 1);
        }
        plVar12 = (int64 *)(uint64)((int)plVar12 + 1);
        goto LAB_18099b0d0;
        LAB_180999899:
        iVar4 = (int)plVar6;
        local_130 = iVar4;
        lVar7 = *(int64 *)(pStatics_3d40 + 0x4d0);
        if (lVar7 == null) throw; // [null/range check failed]
        if (iVar4 < lVar7.summonLv) {
          if (local_res8 == 0) {
        LAB_180999a5d:
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"ItemFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"ItemTypeFlitter");
            uVar10 = Int32.ToString(&local_130,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181d962e0)) == null) throw; // [null/range check failed]
            Selectable.set_interactable(lVar7);
            plVar6 = (int64 *)(uint64)(local_130 + 1);
          }
          else {
            uVar10 = Int32.ToString(&local_130,0);
            cVar2 = FUN_18181e400(local_res8,uVar10);
            if (cVar2) goto LAB_180999a5d;
            if (((this.itemList == null) ||
                (lVar7 = GameObject.get_transform(this.itemList,0)) == null) ||
               (lVar7 = Transform.Find(lVar7,"ItemFlitter")) == null) throw; // [null/range check failed]
            lVar7 = Transform.Find(lVar7,"ItemTypeFlitter");
            uVar10 = Int32.ToString(&local_130,0);
            if (((lVar7 == null) || (lVar7 = Transform.Find(lVar7,uVar10)) == null) ||
               (lVar7 = Component.GetComponent(lVar7,DAT_181d962e0)) == null) throw; // [null/range check failed]
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
          goto LAB_180999899;
        }
        plVar6 = plVar16;
        if (local_120 != (uint64 *)0) goto LAB_180999b30;
    }

    // Token : 0x6000E8A
    // RVA   : 0x996460   Offset: 0x995860   Length: 0x2A7
    public void CreateChooseItem(ItemData targetItem, string fromStorage)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
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
             (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d720a0)) != null)
          {
            *(uint64 *)(lVar3 + 32) = targetItem;
            if ((this.newObj != null) &&
               (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d720a0)) != null
               ) {
              *(uint32 *)(lVar3 + 40) = 3;
              if ((this.newObj != null) &&
                 (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d720a0),
                 lVar3 != null)) {
                ItemIconController.AutoSetName(lVar3,1,0);
                if ((this.newObj != null) &&
                   (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d720a0),
                   lVar3 != null)) {
                  *(int64 *)(lVar3 + 56) = fromStorage;
                  if (fromStorage != null) {
                    cVar1 = FUN_18171e540(fromStorage,"仓库",0);
                    if (!cVar1) {
                      cVar1 = FUN_18171e540(fromStorage,"藏经阁",0);
                      if (!cVar1) {
                        cVar1 = FUN_18171e540(fromStorage,"附庸藏经阁",0);
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

    // Token : 0x6000E8B
    // RVA   : 0x996320   Offset: 0x995720   Length: 0x138
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
            FUN_180daa820(lVar2,uVar1,0);
            if ((this.sendResultParam == null) ||
               (cVar3 = FUN_18171e540(this.sendResultParam,"",0), cVar3)) {
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

    // Token : 0x6000E8C
    // RVA   : 0x99EB80   Offset: 0x99DF80   Length: 0xBF
    public void UnshowChoosePanel()
    {
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
        plVar2 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
          plVar2 = plVar1;
        }
        NGUITools.PlaySound(plVar2,0);
        if (this.cancelFuc != null) {
          if (this.sendResultFucTarget == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          GameObject.SendMessage(this.sendResultFucTarget,this.cancelFuc,0);
        }
        ChooseController.HideChoosePanel(this,0);
    }

    // Token : 0x6000E8D
    // RVA   : 0x996710   Offset: 0x995B10   Length: 0x60F
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
          uVar1 = TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1db0);
          uVar5 = new OnTooltipCB(this,DAT_181d908f0,0);
          TweenSettingsExtensions.OnComplete(uVar1,uVar5,DAT_181dc01d0);
          if ((this.choosePanel != null) &&
             ((lVar4 = GameObject.get_transform(this.choosePanel,0), lVar4 != null &&
              (lVar4 = Transform.Find(lVar4,"BlackBackground",0)) != null))) {
            uVar1 = Component.GetComponent(lVar4,DAT_181d94460);
            uVar1 = DOTweenModuleUI.DOFade(uVar1,0,0x3dcccccd,0);
            TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1c20);
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
                       (lVar4 = Component.GetComponent(lVar4,DAT_181d962e0)) == null)
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
                       (lVar4 = Component.GetComponent(lVar4,DAT_181d962e0)) == null)
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
                       (lVar4 = Component.GetComponent(lVar4,DAT_181d962e0)) == null)
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

    // Token : 0x6000E8E
    // RVA   : 0x99D990   Offset: 0x99CD90   Length: 0x7A3
    public void TypeFlitterAllChanged(bool allOn)
    {
        int iVar1;
        long lVar3;
        plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
        plVar5 = (int64 *)0;
        plVar4 = plVar5;
        if ((plVar2 != (int64 *)0) && (plVar4 = (int64 *)0, *plVar2 == DAT_181daf348)) {
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
                       (lVar3 = Component.GetComponent(lVar3,DAT_181d962e0)) == null))))) break;
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
                     (lVar3 = Component.GetComponent(lVar3,DAT_181d962e0)) == null) break;
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
                     (lVar3 = Component.GetComponent(lVar3,DAT_181d962e0)) == null) break;
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

    // Token : 0x6000E8F
    // RVA   : 0x997120   Offset: 0x996520   Length: 0x7A3
    public void LvFlitterAllChanged(bool allOn)
    {
        int iVar1;
        long lVar3;
        plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
        plVar5 = (int64 *)0;
        plVar4 = plVar5;
        if ((plVar2 != (int64 *)0) && (plVar4 = (int64 *)0, *plVar2 == DAT_181daf348)) {
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
                       (lVar3 = Component.GetComponent(lVar3,DAT_181d962e0)) == null))))) break;
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
                     (lVar3 = Component.GetComponent(lVar3,DAT_181d962e0)) == null) break;
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
                     (lVar3 = Component.GetComponent(lVar3,DAT_181d962e0)) == null) break;
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

    // Token : 0x6000E90
    // RVA   : 0x99E140   Offset: 0x99D540   Length: 0xA30
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
        if ((plVar5 != (int64 *)0) && (plVar9 = (int64 *)0, *plVar5 == DAT_181daf348)) {
          plVar9 = plVar5;
        }
        NGUITools.PlaySound(plVar9,0);
        if ((flitter != null) && (lVar6 = GameObject.GetComponent(flitter,DAT_181d743b0)) != null) {
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
                        (lVar8 = Component.GetComponent(lVar8,DAT_181d95ae0)) == null) ||
                       ((*(int64 *)(lVar8 + 32) == 0 ||
                        (lVar8 = KungfuSkillLvData.DataBase(*(int64 *)(lVar8 + 32),0)) == null))
                       ) || (uVar7 = Int32.ToString(lVar8 + 52,0), lVar6 == null)) ||
                     ((lVar6 = Transform.Find(lVar6,uVar7,0), lVar6 == null ||
                      (lVar6 = Component.GetComponent(lVar6,DAT_181d962e0)) == null)))))))
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
        LAB_18099e6cc:
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
                       (((lVar8 = Component.GetComponent(lVar8,DAT_181d945e0), lVar8 != null &&
                         ((*(int64 *)(lVar8 + 32) != 0 &&
                          (uVar7 = Int32.ToString(*(int64 *)(lVar8 + 32) + 60,0), lVar6 != null))))
                        && (lVar6 = Transform.Find(lVar6,uVar7,0)) != null))))) &&
                     (lVar6 = Component.GetComponent(lVar6,DAT_181d962e0)) != null) {
                    bVar11 = *(byte *)(lVar6 + 0x118);
                    if (((((this.itemList != null) &&
                          (lVar6 = GameObject.get_transform(this.itemList,0)) != null
                          ) && (lVar6 = Transform.Find(lVar6,"Viewport",0)) != null) &&
                        ((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 != null &&
                         (lVar6 = Transform.GetChild(lVar6,plVar10)) != null))) &&
                       ((lVar6 = Component.GetComponent(lVar6), lVar6 != null &&
                        (*(int64 *)(lVar6 + 32) != 0)))) {
                      iVar4 = *(int *)(*(int64 *)(lVar6 + 32) + 20);
                      goto LAB_18099e6cc;
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
                     (lVar8 = Component.GetComponent(lVar8,DAT_181d940e0)) == null) ||
                    ((*(int64 *)(lVar8 + 32) == 0 ||
                     (uVar7 = Int32.ToString(*(int64 *)(lVar8 + 32) + 184,0), lVar6 == null)))))))) ||
                 ((lVar6 = Transform.Find(lVar6,uVar7,0), lVar6 == null ||
                  (lVar6 = Component.GetComponent(lVar6,DAT_181d962e0)) == null))) break;
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

    // Token : 0x6000E91
    // RVA   : 0x9978D0   Offset: 0x996CD0   Length: 0xA51
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
        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
          plVar9 = plVar5;
        }
        NGUITools.PlaySound(plVar9,0);
        if ((flitter != null) && (lVar6 = GameObject.GetComponent(flitter,DAT_181d743b0)) != null) {
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
                      (lVar8 = Component.GetComponent(lVar8,DAT_181d95ae0)) == null) ||
                     (*(int64 *)(lVar8 + 32) == 0)))))) throw; // [null/range check failed]
                local_res10[0] = KungfuSkillLvData.Type(*(int64 *)(lVar8 + 32),0);
                uVar7 = Int32.ToString(local_res10,0);
                if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,uVar7,0)) == null) ||
                   (lVar6 = Component.GetComponent(lVar6,DAT_181d962e0)) == null) throw; // [null/range check failed]
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
        LAB_180997e81:
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
                      ((lVar8 = Component.GetComponent(lVar8,DAT_181d945e0), lVar8 != null &&
                       (*(int64 *)(lVar8 + 32) != 0)))))) {
                    local_res10[0] = *(uint32 *)(*(int64 *)(lVar8 + 32) + 20);
                    uVar7 = Int32.ToString(local_res10,0);
                    if (((lVar6 != null) && (lVar6 = Transform.Find(lVar6,uVar7,0)) != null) &&
                       (lVar6 = Component.GetComponent(lVar6,DAT_181d962e0)) != null) {
                      bVar10 = *(byte *)(lVar6 + 0x118);
                      if ((((((this.itemList != null) &&
                             (lVar6 = GameObject.get_transform(this.itemList,0),
                             lVar6 != null)) && (lVar6 = Transform.Find(lVar6,"Viewport",0)) != null)
                           && ((lVar6 = Transform.Find(lVar6,"Content",0), lVar6 != null &&
                               (lVar6 = Transform.GetChild(lVar6,plVar11)) != null))) &&
                          (lVar6 = Component.GetComponent(lVar6)) != null) &&
                         (*(int64 *)(lVar6 + 32) != 0)) {
                        iVar4 = *(int *)(*(int64 *)(lVar6 + 32) + 60);
                        goto LAB_180997e81;
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
                    (lVar8 = Component.GetComponent(lVar8,DAT_181d940e0)) == null) ||
                   (*(int64 *)(lVar8 + 32) == 0)))))) break;
              uVar7 = "1";
              if (*(char *)(*(int64 *)(lVar8 + 32) + 92) != false) {
                uVar7 = "0";
              }
              if (((lVar6 == null) || (lVar6 = Transform.Find(lVar6,uVar7,0)) == null) ||
                 (lVar6 = Component.GetComponent(lVar6,DAT_181d962e0)) == null) break;
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

    // Token : 0x6000E92
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000E93
    // RVA   : 0x78D070   Offset: 0x78C470   Length: 0x20
    private void <HideChoosePanel>b__24_0()
    {
        if (this.choosePanel != null) {
          GameObject.SetActive(this.choosePanel,0,0);
          return;
        }
    }

}
