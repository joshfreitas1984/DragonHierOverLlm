// ============================================================
// Type  : ForceSpeResearchUIController
// Token : 0x2000291
// ============================================================

public class ForceSpeResearchUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001491
    public GameObject forceSpeResearchUI;

    // Token: 0x4001492
    public List<GameObject> materialIcon;

    // Token: 0x4001493
    public List<GameObject> materialClearButton;

    // Token: 0x4001494
    public int researchType;

    // Token: 0x4001495
    public bool needRefresh;

    // Token: 0x4001496
    public static readonly List<string> SpeResearchTopic;

    // Token: 0x4001497
    private static readonly List<List<int>> SpeResearchMaterialType;

    // Token: 0x4001498
    public static readonly List<string> SpeResearchSureButtonText;

    // Token: 0x4001499
    private static readonly List<string> SpeResearchQuestionText;

    // Token: 0x400149A
    private static readonly List<List<string>> SpeResearchTypeText;

    // Token: 0x400149B
    private static readonly List<string> SpeResearchTargetSkillText;

    // Token: 0x400149C
    public static readonly List<HeroSpeAddDataType> SpeResearchTargetSkillType;

    // Token: 0x400149D
    private static ForceSpeResearchUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014DC
    // RVA   : 0x783370   Offset: 0x782770   Length: 0x58
    public static ForceSpeResearchUIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181dc8360 + 184) + 56);
    }

    // Token : 0x60014DD
    // RVA   : 0x780560   Offset: 0x77F960   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181dc8360 + 184) + 56);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60014DE
    // RVA   : 0x782D30   Offset: 0x782130   Length: 0x3D
    private void Update()
    {
        bool cVar1;
        if (this.forceSpeResearchUI == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar1 = GameObject.get_activeSelf(this.forceSpeResearchUI,0);
        if ((cVar1) && (this.needRefresh)) {
          ForceSpeResearchUIController.RefreshUI(this,0);
          return;
        }
    }

    // Token : 0x60014DF
    // RVA   : 0x780B90   Offset: 0x77FF90   Length: 0x3F
    public void HideForceSpeResearchUI()
    {
        ForceSpeResearchUIController.ClearResearchMaterial(this,0,0);
        ForceSpeResearchUIController.ClearResearchMaterial(this,1);
        if (this.forceSpeResearchUI != null) {
          GameObject.SetActive(this.forceSpeResearchUI,0,0);
          return;
        }
    }

    // Token : 0x60014E0
    // RVA   : 0x782470   Offset: 0x781870   Length: 0x5C8
    public void ShowForceSpeResearchUI()
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[2];
        local_res18[0] = 0;
        if (this.forceSpeResearchUI != null) {
          GameObject.SetActive(this.forceSpeResearchUI,1,0);
          if (this.forceSpeResearchUI != null) {
            lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0);
            if (lVar3 != null) {
              lVar3 = Transform.Find(lVar3,"Title",0);
              if (lVar3 != null) {
                uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                lVar3 = ForceSpeResearchUIController.SpeResearchTopic;
                uVar1 = ForceSpeResearchUIController.SpeResearchType(0);
                if (lVar3 != null) {
                  if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar6 = lVar3[uVar1];
                  LTLocalization.SetText(uVar4,uVar6,0);
                  if (this.forceSpeResearchUI != null) {
                    lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0);
                    if (lVar3 != null) {
                      lVar3 = Transform.Find(lVar3,"Question",0);
                      if (lVar3 != null) {
                        lVar5 = Component.GetComponent(lVar3,DAT_181d95560);
                        lVar3 = ForceSpeResearchUIController.SpeResearchQuestionText;
                        uVar1 = ForceSpeResearchUIController.SpeResearchType(0);
                        if (lVar3 != null) {
                          if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          if (lVar5 != null) {
                            *(uint64 *)(lVar5 + 24) =
                                 *(uint64 *)
                                  (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar1 * 8);
                            il2cpp_internal();
                            local_res8[0] = 0;
                            do {
                              if (this.forceSpeResearchUI == null) throw; // [null/range check failed]
                              lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0);
                              uVar4 = Int32.ToString(local_res8,0);
                              uVar4 = String.Concat("Material",uVar4,0);
                              if (lVar3 == null) throw; // [null/range check failed]
                              lVar3 = Transform.Find(lVar3,uVar4,0);
                              if (lVar3 == null) throw; // [null/range check failed]
                              lVar3 = Transform.Find(lVar3,"Label",0);
                              if (lVar3 == null) throw; // [null/range check failed]
                              uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                              lVar3 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x538);
                              lVar5 = ForceSpeResearchUIController.SpeResearchMaterialType;
                              uVar2 = ForceSpeResearchUIController.SpeResearchType(0);
                              if (lVar5 == null) throw; // [null/range check failed]
                              lVar5 = FUN_180002f80(lVar5,uVar2,DAT_181d789a8);
                              if (lVar5 == null) throw; // [null/range check failed]
                              uVar2 = FUN_1800d6760(lVar5,local_res8[0],DAT_181d8fa18);
                              if (lVar3 == null) throw; // [null/range check failed]
                              uVar6 = FUN_180002f80(lVar3,uVar2);
                              String.Format("{0}\n（消耗）",uVar6);
                              LTLocalization.SetText(uVar4);
                              local_res8[0] = local_res8[0] + 1;
                            } while (local_res8[0] < 2);
                            while (this.forceSpeResearchUI != null) {
                              lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0);
                              if (lVar3 == null) break;
                              lVar3 = Transform.Find(lVar3,"SubTypeChooseGrid",0);
                              uVar4 = Int32.ToString(local_res18,0);
                              if (lVar3 == null) break;
                              lVar3 = Transform.Find(lVar3,uVar4,0);
                              if (lVar3 == null) break;
                              lVar3 = Transform.Find(lVar3,"Background",0);
                              if (lVar3 == null) break;
                              lVar3 = Component.GetComponent(lVar3,DAT_181d95560);
                              lVar5 = ForceSpeResearchUIController.SpeResearchTypeText;
                              uVar2 = ForceSpeResearchUIController.SpeResearchType(0);
                              if (lVar5 == null) break;
                              lVar5 = FUN_180002f80(lVar5,uVar2,DAT_181d793a8);
                              if (lVar5 == null) break;
                              uVar4 = FUN_180002f80(lVar5,local_res18[0]);
                              if (lVar3 == null) break;
                              *(uint64 *)(lVar3 + 24) = uVar4;
                              local_res18[0] = local_res18[0] + 1;
                              if (2 < local_res18[0]) {
                                ForceSpeResearchUIController.RefreshUI(this,0);
                                plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
                                plVar8 = (int64 *)0;
                                if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf348)) {
                                  plVar8 = plVar7;
                                }
                                NGUITools.PlaySound(plVar8,0);
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

    // Token : 0x60014E1
    // RVA   : 0x782A40   Offset: 0x781E40   Length: 0xD2
    public static int SpeResearchType()
    {
        bool cVar1;
        long lVar2;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            cVar1 = HeroData.HaveForceFunction(lVar2,17);
            return !cVar1;
          }
        }
    }

    // Token : 0x60014E2
    // RVA   : 0x780AF0   Offset: 0x77FEF0   Length: 0x98
    public static HeroSpeAddDataType GetSpeResearchTargetSkillType()
    {
        long lVar1;
        uint uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dc8360 + 184) + 48);
        uVar2 = ForceSpeResearchUIController.SpeResearchType(0);
        if (lVar1 != null) {
          if (*(uint32 *)(lVar1 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar1[uVar2];
        }
    }

    // Token : 0x60014E3
    // RVA   : 0x780F10   Offset: 0x780310   Length: 0x11CD
    public void RefreshUI()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        uint uVar8;
        long lVar9;
        float fVar10;
        uint uVar11;
        float[] local_res8 = new float[2];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint[] local_48 = new uint[8];
        uVar2 = 0;
        local_res20[0] = 0;
        this.needRefresh = 0;
        if ((((this.forceSpeResearchUI != null) &&
             (lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0)) != null) &&
            (lVar3 = Transform.Find(lVar3,"ExpBarBack",0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"ExpText",0)) != null) {
          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
          if (((GameController._instance != null) &&
              (lVar3 = GameController._instance.worldData) != null) &&
             (lVar3 = lVar3.forceSpeResearchData) != null) {
            local_res8[0] = lVar3._items * 100.0;
            uVar5 = Single.ToString(local_res8,"f0",0);
            uVar5 = String.Concat(uVar5,"%",0);
            LTLocalization.SetText(uVar4,uVar5,0);
            if (((this.forceSpeResearchUI != null) &&
                (lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0)) != null) &&
               ((lVar3 = Transform.Find(lVar3,"ExpBarBack",0), lVar3 != null &&
                (lVar3 = Transform.Find(lVar3,"ExpBar",0)) != null))) {
              lVar3 = Component.GetComponent(lVar3,DAT_181d94460);
              if ((((GameController._instance != null) &&
                   (lVar6 = GameController._instance.worldData) != null) &&
                  (lVar6 = lVar6.forceSpeResearchData) != null) && (lVar3 != null)) {
                Image.set_fillAmount(lVar3,lVar6._items,0);
                if (((GameController._instance != null) &&
                    (lVar3 = GameController._instance.worldData) != null) &&
                   (lVar3 = lVar3.forceSpeResearchData) != null) {
                  lVar6 = this.forceSpeResearchUI;
                  if (0 < lVar3.Areas) {
                    if ((((lVar6 != null) && (lVar3 = GameObject.get_transform(lVar6,0)) != null) &&
                        (lVar3 = Transform.Find(lVar3,"SubTypeChooseGrid",0)) != null) &&
                       (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
                      GameObject.SetActive(lVar3,0,0);
                      if (((this.forceSpeResearchUI != null) &&
                          (lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0)) != null
                          ) && ((lVar3 = Transform.Find(lVar3,"RateInfo",0), lVar3 != null &&
                                (lVar3 = Component.get_gameObject(lVar3,0)) != null))) {
                        GameObject.SetActive(lVar3,0,0);
                        if (((this.forceSpeResearchUI != null) &&
                            (lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0),
                            lVar3 != null)) && (lVar3 = Transform.Find(lVar3,"ResearchSpeAdd",0)) != null)
                        {
                          uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                          plVar7 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
                          if ((((GameController._instance != null) &&
                               (lVar3 = GameController._instance.worldData,
                               lVar3 != null)) && (lVar3 = WorldData.Player(lVar3,0)) != null) &&
                             ((lVar3 = HeroData.GetForce(lVar3,0,0), lVar3 != null &&
                              (lVar3 = ForceData.GetForceName(lVar3,1,0), plVar7 != (int64 *)0)))) {
                            if ((lVar3 != null) &&
                               (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar7 + 64)),
                               lVar6 == null)) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            if ((int)plVar7[3] == 0) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            plVar7[4] = lVar3;
                            il2cpp_internal(plVar7 + 4,lVar3);
                            if (((GameController._instance != null) &&
                                (lVar3 = GameController._instance.worldData,
                                lVar3 != null)) && (lVar3 = lVar3.forceSpeResearchData) != null) {
                              local_res8[0] = lVar3.villageAreaID * 100.0;
                              lVar3 = Single.ToString(local_res8,"f0",0);
                              if ((lVar3 != null) &&
                                 (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar7 + 64)),
                                 lVar6 == null)) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              if (*(uint32 *)(plVar7 + 3) < 2) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar7[5] = lVar3;
                              il2cpp_internal(plVar7 + 5,lVar3);
                              lVar3 = ForceSpeResearchUIController.SpeResearchTargetSkillText;
                              uVar2 = ForceSpeResearchUIController.SpeResearchType(0);
                              if (lVar3 != null) {
                                if (lVar3.Count <= uVar2) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                lVar3 = *(int64 *)
                                         (lVar3._items + 32 + (int64)(int)uVar2 * 8);
                                if ((lVar3 != null) &&
                                   (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar7 + 64)),
                                   lVar6 == null)) {
                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar4,0);
                                }
                                if (*(uint32 *)(plVar7 + 3) < 3) {
                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar4,0);
                                }
                                plVar7[6] = lVar3;
                                il2cpp_internal(plVar7 + 6,lVar3);
                                if ((((GameController._instance != null) &&
                                     (lVar3 = GameController._instance.worldData,
                                     lVar3 != null)) && (lVar3 = lVar3.forceSpeResearchData) != null)
                                   && (lVar3 = lVar3.forceAreaID) != null) {
                                  lVar3 = HeroSpeAddData.GetDescribe(lVar3,1,1,1,0,0);
                                  if ((lVar3 != null) &&
                                     (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar7 + 64)),
                                     lVar6 == null)) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar4,0);
                                  }
                                  if (*(uint32 *)(plVar7 + 3) < 4) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar4,0);
                                  }
                                  plVar7[7] = lVar3;
                                  il2cpp_internal(plVar7 + 7,lVar3);
                                  uVar5 = String.Format("{0}武学威力+{1}%\n{2}武学加成：\n{3}",plVar7,0);
                                  LTLocalization.SetText(uVar4,uVar5,0);
                                  if ((((this.forceSpeResearchUI != null) &&
                                       (lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0)
                                       , lVar3 != null)) &&
                                      (lVar3 = Transform.Find(lVar3,"StartResearchButton",0)) != null) &&
                                     (lVar3 = Component.GetComponent(lVar3,DAT_181d93760)) != null) {
                                    Selectable.set_interactable(lVar3,0,0);
                                    if (((this.forceSpeResearchUI != null) &&
                                        (lVar3 = GameObject.get_transform
                                                           (this.forceSpeResearchUI,0), lVar3 != null))
                                       && ((lVar3 = Transform.Find(lVar3,"StartResearchButton",0), lVar3 != null &&
                                           (lVar3 = Transform.Find(lVar3,"Label",0)) != null)))
                                    {
                                      uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                                      if (((GameController._instance != null) &&
                                          (lVar3 = *(int64 *)
                                                    (GameController._instance + 32),
                                          lVar3 != null)) &&
                                         (lVar3 = lVar3.forceSpeResearchData) != null) {
                                        local_48[0] = lVar3.Areas;
                                        uVar5 = il2cpp_value_box(DAT_181d80418,local_48);
                                        uVar5 = String.Format("持续{0}日",uVar5,0);
                                        LTLocalization.SetText(uVar4,uVar5,0);
                                        lVar3 = this.materialIcon;
                                        local_res18[0] = 0;
                                        if (lVar3 != null) {
                                          while( true ) {
                                            uVar2 = local_res18[0];
                                            if (lVar3.Count <= (int)local_res18[0]) {
                                              return;
                                            }
                                            if (lVar3 == null) break;
                                            if (lVar3.Count <= local_res18[0]) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            uVar4 = *(uint64 *)
                                                     (lVar3._items + 32 +
                                                     (int64)(int)uVar2 * 8);
                                            cVar1 = Object.op_Equality(uVar4,0,0);
                                            uVar2 = local_res18[0];
                                            if (cVar1) {
                                              lVar3 = FUN_18046c0a0(0);
                                              if ((((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                                                  (lVar3 = *(int64 *)
                                                            (lVar3.villageAreaID + 0x1f8),
                                                  lVar3 == null)) ||
                                                 (lVar3 = lVar3.Count) == null) break;
                                              uVar4 = FUN_180002f80(lVar3,local_res18[0],DAT_181d90f18);
                                              ForceSpeResearchUIController.CreateResearchMaterialItemIcon
                                                        (this,uVar2,uVar4,0);
                                            }
                                            if (this.forceSpeResearchUI == null) break;
                                            lVar3 = GameObject.get_transform
                                                              (this.forceSpeResearchUI,0);
                                            uVar4 = Int32.ToString(local_res18,0);
                                            String.Concat("ClearMaterialButton",uVar4);
                                            if (((lVar3 == null) ||
                                                (lVar3 = Transform.Find(lVar3)) == null) ||
                                               (lVar3 = Component.get_gameObject(lVar3)) == null)
                                            break;
                                            GameObject.SetActive();
                                            lVar3 = this.materialIcon;
                                            local_res18[0] = local_res18[0] + 1;
                                            if (lVar3 == null) break;
                                          }
                                        }
                                        goto LAB_180782052;
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
                  if (((lVar6 != null) && (lVar3 = GameObject.get_transform(lVar6,0)) != null) &&
                     ((lVar3 = Transform.Find(lVar3,"SubTypeChooseGrid",0), lVar3 != null &&
                      (lVar3 = Component.get_gameObject(lVar3,0)) != null))) {
                    GameObject.SetActive(lVar3,1,0);
                    if ((((this.forceSpeResearchUI != null) &&
                         (lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0)) != null)
                        && (lVar3 = Transform.Find(lVar3,"RateInfo",0)) != null) &&
                       (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
                      GameObject.SetActive(lVar3,1,0);
                      if (((this.forceSpeResearchUI != null) &&
                          (lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0)) != null
                          ) && (lVar3 = Transform.Find(lVar3,"ResearchSpeAdd",0)) != null) {
                        uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                        LTLocalization.SetText(uVar4,"",0);
                        if (((this.forceSpeResearchUI != null) &&
                            (lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0),
                            lVar3 != null)) && (lVar3 = Transform.Find(lVar3,"StartResearchButton",0)) != null)
                        {
                          lVar3 = Component.GetComponent(lVar3,DAT_181d93760);
                          lVar6 = this.materialIcon;
                          if (lVar6 != null) {
                            lVar9 = 32;
                            uVar8 = uVar2;
                            do {
                              if (lVar6.Count <= (int)uVar8) {
                                uVar4 = 1;
        LAB_1807815c1:
                                if (lVar3 != null) {
                                  Selectable.set_interactable(lVar3,uVar4,0);
                                  if (((this.forceSpeResearchUI != null) &&
                                      (lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0),
                                      lVar3 != null)) &&
                                     ((lVar3 = Transform.Find(lVar3,"StartResearchButton",0), lVar3 != null &&
                                      (lVar3 = Transform.Find(lVar3,"Label",0)) != null))) {
                                    uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                                    lVar3 = ForceSpeResearchUIController.SpeResearchSureButtonText;
                                    uVar8 = ForceSpeResearchUIController.SpeResearchType(0);
                                    if (lVar3 != null) {
                                      if (lVar3.Count <= uVar8) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      LTLocalization.SetText
                                                (uVar4,*(uint64 *)
                                                        (lVar3._items + 32 +
                                                        (int64)(int)uVar8 * 8),0);
                                      if ((((this.forceSpeResearchUI != null) &&
                                           (lVar3 = GameObject.get_transform
                                                              (this.forceSpeResearchUI,0),
                                           lVar3 != null)) &&
                                          (lVar3 = Transform.Find(lVar3,"RateInfo",0)) != null) &&
                                         (lVar3 = Transform.Find(lVar3,"Rate",0)) != null) {
                                        uVar4 = Component.GetComponent(lVar3,DAT_181d96160);
                                        local_res8[0] =
                                             (float)ForceSpeResearchUIController.ResearchScore
                                                              (this,1,0);
                                        uVar5 = Single.ToString(local_res8,"f0",0);
                                        fVar10 = (float)ForceSpeResearchUIController.ResearchScore
                                                                  (this,1,0);
                                        uVar11 = Mathf.Max(0x3f800000,fVar10 * 0.01,0);
                                        fVar10 = (float)Mathf.Log(uVar11,0x40000000,0);
                                        uVar5 = GlobalData.GenerateRareLvColorText(uVar5,(int)fVar10,0);
                                        LTLocalization.SetText(uVar4,uVar5,0);
                                        lVar3 = this.materialIcon;
                                        if (lVar3 != null) goto LAB_1807817b3;
                                      }
                                    }
                                  }
                                }
                                break;
                              }
                              if (lVar6 == null) break;
                              if (lVar6.Count <= uVar8) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              uVar4 = *(uint64 *)(lVar9 + lVar6._items);
                              cVar1 = Object.op_Equality(uVar4,0,0);
                              if (cVar1) {
                                uVar4 = 0;
                                goto LAB_1807815c1;
                              }
                              lVar6 = this.materialIcon;
                              uVar8 = uVar8 + 1;
                              lVar9 = lVar9 + 8;
                            } while (lVar6 != null);
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
        LAB_180782052:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1807817b3:
        if (lVar3.Count <= (int)uVar2) {
          return;
        }
        if (this.forceSpeResearchUI == null) goto LAB_180782052;
        lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0);
        uVar4 = Int32.ToString(local_res20,0);
        uVar4 = String.Concat("ClearMaterialButton",uVar4,0);
        if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4)) == null) goto LAB_180782052;
        lVar6 = Component.get_gameObject(lVar3,0);
        lVar3 = this.materialIcon;
        lVar9 = (int64)(int)local_res20[0];
        if (lVar3 == null) goto LAB_180782052;
        if (lVar3.Count <= local_res20[0]) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar4 = *(uint64 *)(lVar3._items + 32 + lVar9 * 8);
        Object.op_Inequality(uVar4,0);
        if (lVar6 == null) goto LAB_180782052;
        GameObject.SetActive(lVar6);
        lVar3 = this.materialIcon;
        uVar2 = local_res20[0] + 1;
        local_res20[0] = uVar2;
        if (lVar3 == null) goto LAB_180782052;
        goto LAB_1807817b3;
    }

    // Token : 0x60014E4
    // RVA   : 0x7805D0   Offset: 0x77F9D0   Length: 0xE5
    public bool CanResearch()
    {
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        lVar2 = this.materialIcon;
        uVar5 = 0;
        if (lVar2 != null) {
          lVar4 = 32;
          do {
            if (lVar2.Count <= (int)uVar5) {
              return CONCAT71((int7)((uint64)lVar2 >> 8),1);
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar1 = *(uint64 *)(lVar4 + lVar2._items);
            uVar3 = Object.op_Equality(uVar1,0,0);
            if ((char)uVar3) {
              return uVar3 & 0xffffffffffffff00;
            }
            lVar2 = this.materialIcon;
            uVar5 = uVar5 + 1;
            lVar4 = lVar4 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x60014E5
    // RVA   : 0x7821D0   Offset: 0x7815D0   Length: 0x1A7
    public float ResearchScore(bool useResearchRate)
    {
        int iVar1;
        long lVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        lVar2 = this.materialIcon;
        if (lVar2 != null) {
          if (lVar2.Count == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar3 = (float)ForceSpeResearchUIController.GetMaterialValue
                                   (this,*(uint64 *)(lVar2._items + 32),0);
          lVar2 = this.materialIcon;
          if (lVar2 != null) {
            if (lVar2.Count < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar4 = (float)ForceSpeResearchUIController.GetMaterialValue
                                     (this,*(uint64 *)(lVar2._items + 40),0);
            iVar1 = this.researchType;
            fVar5 = 1.0;
            if (useResearchRate) {
              if (((GameController._instance == null) ||
                  (lVar2 = GameController._instance.worldData) == null) ||
                 (lVar2 = lVar2.forceSpeResearchData) == null) throw; // [null/range check failed]
              fVar5 = (float)Mathf.Max(lVar2._items,0x3c23d70a,0);
            }
            return (fVar3 + 100.0 + fVar4) * ((float)iVar1 * 0.1 + 1.0) * fVar5;
          }
        }
    }

    // Token : 0x60014E6
    // RVA   : 0x782190   Offset: 0x781590   Length: 0x3B
    public float ResearchScoreLv(bool useResearchRate)
    {
        float fVar1;
        uint uVar2;
        fVar1 = (float)ForceSpeResearchUIController.ResearchScore(this,useResearchRate,0);
        uVar2 = Mathf.Max(0x3f800000,fVar1 * 0.01,0);
        Mathf.Log(uVar2,0x40000000,0);
    }

    // Token : 0x60014E7
    // RVA   : 0x780A50   Offset: 0x77FE50   Length: 0x9E
    public float GetMaterialValue(GameObject targetMaterial)
    {
        bool cVar1;
        long lVar2;
        cVar1 = Object.op_Equality(targetMaterial,0,0);
        if (cVar1) {
          return;
        }
        if (targetMaterial != null) {
          lVar2 = GameObject.GetComponent(targetMaterial,DAT_181d720a0);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) {
            return;
          }
        }
    }

    // Token : 0x60014E8
    // RVA   : 0x7807F0   Offset: 0x77FBF0   Length: 0x25D
    public void CreateResearchMaterialItemIcon(int id, ItemData targetItemData)
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
        void ForceSpeResearchUIController.CreateResearchMaterialItemIcon
                     (int64 this,uint32 id,uint64 targetItemData)
        {
        uint64 uVar1;
        uint32 uVar2;
        int64 lVar3;
        uint64 uVar4;
        int64 lVar5;
        uint32 local_res10 [2];
        local_res10[0] = id;
        uVar2 = local_res10[0];
        lVar5 = this.materialIcon;
        if (this.forceSpeResearchUI != null) {
          lVar3 = GameObject.get_transform(this.forceSpeResearchUI,0);
          uVar4 = Int32.ToString(local_res10,0);
          uVar4 = String.Concat("Material",uVar4,0);
          if (lVar3 != null) {
            lVar3 = Transform.Find(lVar3,uVar4,0);
            if (lVar3 != null) {
              uVar4 = Component.get_gameObject(lVar3,0);
              if (*pStatics != 0) {
                uVar1 = *(uint64 *)(*pStatics + 160);
                uVar4 = GlobalData.AddChild(uVar4,uVar1,0);
                if (lVar5 != null) {
                  FUN_181829cd0(lVar5,uVar2,uVar4,DAT_181d89a18);
                  lVar5 = this.materialIcon;
                  lVar3 = (int64)(int)local_res10[0];
                  if (lVar5 != null) {
                    if (lVar5.Count <= local_res10[0]) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar5 = *(int64 *)(lVar5._items + 32 + lVar3 * 8);
                    if (lVar5 != null) {
                      lVar5 = GameObject.GetComponent(lVar5,DAT_181d720a0);
                      if (lVar5 != null) {
                        *(uint64 *)(lVar5 + 32) = targetItemData;
                        lVar5 = this.materialIcon;
                        lVar3 = (int64)(int)local_res10[0];
                        if (lVar5 != null) {
                          if (lVar5.Count <= local_res10[0]) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar5 = *(int64 *)(lVar5._items + 32 + lVar3 * 8);
                          if (lVar5 != null) {
                            lVar5 = GameObject.GetComponent(lVar5,DAT_181d720a0);
                            if (lVar5 != null) {
                              *(uint32 *)(lVar5 + 40) = 1;
                              lVar5 = this.materialIcon;
                              lVar3 = (int64)(int)local_res10[0];
                              if (lVar5 != null) {
                                if (lVar5.Count <= local_res10[0]) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                lVar5 = *(int64 *)(lVar5._items + 32 + lVar3 * 8);
                                if (lVar5 != null) {
                                  lVar5 = GameObject.GetComponent(lVar5,DAT_181d720a0);
                                  if (lVar5 != null) {
                                    ItemIconController.AutoSetName(lVar5,1,0);
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

    // Token : 0x60014E9
    // RVA   : 0x780BD0   Offset: 0x77FFD0   Length: 0x33D
    public void MaterialButtonClicked(int id)
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        uint[] local_res8 = new uint[2];
        uint[] local_res10 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_38;
        uint local_34;
        uint[] local_30 = new uint[2];
        local_res10[0] = id;
        uVar4 = local_res10[0];
        lVar1 = this.materialIcon;
        if (lVar1 != null) {
          if (lVar1.Count <= local_res10[0]) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar6 = lVar1._items[uVar4];
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (cVar3) {
            return;
          }
          lVar1 = **(int64 **)(DAT_181db7518 + 184);
          lVar5 = il2cpp_internal(DAT_181d94e50);
          FUN_18132faf0(lVar5,DAT_181d95788);
          local_res8[0] = 0;
          uVar6 = il2cpp_value_box(DAT_181d80418,local_res8);
          if (lVar5 != null) {
            FUN_18181e0a0(lVar5,uVar6,DAT_181d95888);
            local_res20[0] = 5;
            uVar6 = il2cpp_value_box(DAT_181d80418,local_res20);
            FUN_18181e0a0(lVar5,uVar6,DAT_181d95888);
            local_38 = 0xffffffff;
            uVar6 = il2cpp_value_box(DAT_181d80418,&local_38);
            FUN_18181e0a0(lVar5,uVar6,DAT_181d95888);
            local_34 = 0xffffffff;
            uVar6 = il2cpp_value_box(DAT_181d80418,&local_34);
            FUN_18181e0a0(lVar5,uVar6,DAT_181d95888);
            lVar2 = *(int64 *)(*(int64 *)(DAT_181dc8360 + 184) + 8);
            uVar4 = ForceSpeResearchUIController.SpeResearchType(0);
            if (lVar2 != null) {
              if (*(uint32 *)(lVar2 + 24) <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar4];
              lVar8 = (int64)(int)local_res10[0];
              if (lVar2 != null) {
                if (*(uint32 *)(lVar2 + 24) <= local_res10[0]) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_30[0] = *(uint32 *)(*(int64 *)(lVar2 + 16) + 32 + lVar8 * 4);
                uVar6 = il2cpp_value_box(DAT_181d80418,local_30);
                FUN_18181e0a0(lVar5,uVar6,DAT_181d95888);
                uVar6 = Component.get_gameObject(this,0);
                uVar7 = Int32.ToString(local_res10,0);
                if (lVar1 != null) {
                  ChooseController.ShowChoosePanel(lVar1,1,lVar5,uVar6,"ResearchMaterialChoosen",uVar7,0,0,0,0);
                  return;
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x60014EA
    // RVA   : 0x7820E0   Offset: 0x7814E0   Length: 0xA9
    public void ResearchMaterialChoosen(string id)
    {
        var pStatics = *(int64*)(DAT_181db7518 + 184);
        uint uVar1;
        long lVar2;
        uVar1 = Int32.Parse(id,0);
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 72)) != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181d720a0);
          if (lVar2 != null) {
            ForceSpeResearchUIController.CreateResearchMaterialItemIcon
                      (this,uVar1,*(uint64 *)(lVar2 + 32),0);
            this.needRefresh = 1;
            return;
          }
        }
    }

    // Token : 0x60014EB
    // RVA   : 0x7806C0   Offset: 0x77FAC0   Length: 0x123
    public void ClearResearchMaterial(int id)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        lVar2 = this.materialIcon;
        if (lVar2 != null) {
          if (lVar2.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = (int64)(int)id * 8 + 32;
          uVar3 = *(uint64 *)(lVar1 + lVar2._items);
          cVar4 = Object.op_Inequality(uVar3,0,0);
          if (!cVar4) {
            return;
          }
          lVar2 = this.materialIcon;
          if (lVar2 != null) {
            if (lVar2.Count <= id) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar3 = *(uint64 *)(lVar1 + lVar2._items);
            Object.Destroy(uVar3,0);
            if (this.materialIcon != null) {
              FUN_181829cd0(this.materialIcon,id,0,DAT_181d89a18);
              this.needRefresh = 1;
              return;
            }
          }
        }
    }

    // Token : 0x60014EC
    // RVA   : 0x782380   Offset: 0x781780   Length: 0xEC
    public void ResearchTypeButtonClicked(GameObject buttonClicked)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        if (buttonClicked != null) {
          lVar2 = GameObject.GetComponent(buttonClicked,DAT_181d743b0);
          if (lVar2 != null) {
            if (*(char *)(lVar2 + 0x118) != false) {
              uVar3 = Object.get_name(buttonClicked,0);
              uVar1 = Int32.Parse(uVar3,0);
              this.researchType = uVar1;
              this.needRefresh = 1;
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
            }
            return;
          }
        }
    }

    // Token : 0x60014ED
    // RVA   : 0x782B20   Offset: 0x781F20   Length: 0x206
    public void StartResearchButtonClicked()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        int iVar4;
        ulong uVar6;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181db5de8 + 184) + 8);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181dc8360 + 184) + 16);
        uVar3 = ForceSpeResearchUIController.SpeResearchType(0);
        if (lVar2 != null) {
          if (*(uint32 *)(lVar2 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar1 != null) {
            WorkingUIController.StartWorking
                      (lVar1,*(uint64 *)
                              (*(int64 *)(lVar2 + 16) + 32 + (int64)(int)uVar3 * 8),
                       this.researchType + 1,0,0,"FinishForceSpeResearch",0,0);
            iVar4 = ForceSpeResearchUIController.SpeResearchType(0);
            uVar6 = "Sound/SoundEffect/SpeEffect/冰气";
            if (iVar4 == 0) {
              uVar6 = "Sound/SoundEffect/CraftMed";
            }
            plVar5 = (int64 *)Resources.Load(uVar6,0);
            plVar7 = (int64 *)0;
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf348)) {
              plVar7 = plVar5;
            }
            NGUITools.PlaySound(plVar7,0);
            return;
          }
        }
    }

    // Token : 0x60014EE
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60014EF
    // RVA   : 0x782D70   Offset: 0x782170   Length: 0x5F7
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181dc8360 + 184);
        long lVar1;
        long lVar2;
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"火药",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"玄冰",DAT_181da3d58);
          plVar3 = pStatics;
          *plVar3 = lVar1;
          il2cpp_internal(plVar3,lVar1);
          lVar1 = il2cpp_internal(DAT_181d90160);
          FUN_18132faf0(lVar1,DAT_181d787a8);
          lVar2 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar2,DAT_181d8f098);
          if (lVar2 != null) {
            FUN_18182a0b0(lVar2,0,DAT_181d8f218);
            FUN_18182a0b0(lVar2,2,DAT_181d8f218);
            if (lVar1 != null) {
              FUN_18181e0a0(lVar1,lVar2,DAT_181d78828);
              lVar2 = il2cpp_internal(DAT_181d93cd0);
              FUN_18132faf0(lVar2,DAT_181d8f098);
              if (lVar2 != null) {
                FUN_18182a0b0(lVar2,1,DAT_181d8f218);
                FUN_18182a0b0(lVar2,3,DAT_181d8f218);
                FUN_18181e0a0(lVar1,lVar2,DAT_181d78828);
                ForceSpeResearchUIController.SpeResearchMaterialType = lVar1;
                lVar1 = il2cpp_internal(DAT_181d97750);
                FUN_18132faf0(lVar1,DAT_181da3bd8);
                if (lVar1 != null) {
                  FUN_18181e0a0(lVar1,"配置火药",DAT_181da3d58);
                  FUN_18181e0a0(lVar1,"凝结玄冰",DAT_181da3d58);
                  ForceSpeResearchUIController.SpeResearchSureButtonText = lVar1;
                  lVar1 = il2cpp_internal(DAT_181d97750);
                  FUN_18132faf0(lVar1,DAT_181da3bd8);
                  if (lVar1 != null) {
                    FUN_18181e0a0(lVar1,"♦配置火药需要消耗木材，药引和生命。所用材料品级越高，最终效果越强。\n♦火药会提升霹雳堂武学威力和所有灼烧武学效果，持续30日。\n♦每次配置都会提升熟练度，熟练度会很大程度上影响最终效果。",DAT_181da3d58);
                    FUN_18181e0a0(lVar1,"♦凝结玄冰需要消耗矿料，食材和内力。所用材料品级越高，最终效果越强。\n♦玄冰会提升天山派武学威力和所有冰寒武学效果，持续30日。\n♦每次凝结都会提升熟练度，熟练度会很大程度上影响最终效果。",DAT_181da3d58);
                    ForceSpeResearchUIController.SpeResearchQuestionText = lVar1;
                    lVar1 = il2cpp_internal(DAT_181d903e0);
                    FUN_18132faf0(lVar1,DAT_181d79228);
                    lVar2 = il2cpp_internal(DAT_181d97750);
                    FUN_18132faf0(lVar2,DAT_181da3bd8);
                    if (lVar2 != null) {
                      FUN_18181e0a0(lVar2,"耗时1天\n生命-25%",DAT_181da3d58);
                      FUN_18181e0a0(lVar2,"耗时2天\n生命-50%\n效率+10%",DAT_181da3d58);
                      FUN_18181e0a0(lVar2,"耗时3天\n生命-75%\n效率+20%",DAT_181da3d58);
                      if (lVar1 != null) {
                        FUN_18181e0a0(lVar1,lVar2,DAT_181d792a8);
                        lVar2 = il2cpp_internal(DAT_181d97750);
                        FUN_18132faf0(lVar2,DAT_181da3bd8);
                        if (lVar2 != null) {
                          FUN_18181e0a0(lVar2,"耗时1天\n内力-25%",DAT_181da3d58);
                          FUN_18181e0a0(lVar2,"耗时2天\n内力-50%\n效率+10%",DAT_181da3d58);
                          FUN_18181e0a0(lVar2,"耗时3天\n内力-75%\n效率+20%",DAT_181da3d58);
                          FUN_18181e0a0(lVar1,lVar2,DAT_181d792a8);
                          ForceSpeResearchUIController.SpeResearchTypeText = lVar1;
                          lVar1 = il2cpp_internal(DAT_181d97750);
                          FUN_18132faf0(lVar1,DAT_181da3bd8);
                          if (lVar1 != null) {
                            FUN_18181e0a0(lVar1,"灼烧",DAT_181da3d58);
                            FUN_18181e0a0(lVar1,"冰寒",DAT_181da3d58);
                            ForceSpeResearchUIController.SpeResearchTargetSkillText = lVar1;
                            lVar1 = il2cpp_internal(DAT_181d93450);
                            FUN_18132faf0(lVar1,DAT_181d8c098);
                            if (lVar1 != null) {
                              FUN_18182a0b0(lVar1,87,DAT_181d8c118);
                              FUN_18182a0b0(lVar1,94,DAT_181d8c118);
                              ForceSpeResearchUIController.SpeResearchTargetSkillType = lVar1;
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
