// ============================================================
// Type  : StartMenuController
// Token : 0x200036B
// ============================================================

public class StartMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B1F
    public GameObject canvas;

    // Token: 0x4001B20
    public GameObject simpleTextPrefab;

    // Token: 0x4001B21
    public GameObject startMenu;

    // Token: 0x4001B22
    public GameObject backMountain;

    // Token: 0x4001B23
    public GameObject faceSetting;

    // Token: 0x4001B24
    public GameObject heroSkeleton;

    // Token: 0x4001B25
    public InputField heroFamilyName;

    // Token: 0x4001B26
    public InputField heroGivenName;

    // Token: 0x4001B27
    public Text evilText;

    // Token: 0x4001B28
    public Text chaosText;

    // Token: 0x4001B29
    public Dropdown natureDropDown;

    // Token: 0x4001B2A
    public Dropdown clothDropDown;

    // Token: 0x4001B2B
    public GameObject attriRoot;

    // Token: 0x4001B2C
    public int leftAttriPoint;

    // Token: 0x4001B2D
    public int leftFightSkillPoint;

    // Token: 0x4001B2E
    public int leftLivingSkillPoint;

    // Token: 0x4001B2F
    public bool needRefreshPlayerAttri;

    // Token: 0x4001B30
    public List<AttriPresetData> attriPresetDatas;

    // Token: 0x4001B31
    public GameObject AttriPresetList;

    // Token: 0x4001B32
    public GameObject AttriPresetButtonPrefab;

    // Token: 0x4001B33
    public GameObject tagRoot;

    // Token: 0x4001B34
    public GameObject selfTagGrid;

    // Token: 0x4001B35
    public List<GameObject> allTagGrid;

    // Token: 0x4001B36
    public GameObject startChooseTagPrefab;

    // Token: 0x4001B37
    public GameObject difficultRoot;

    // Token: 0x4001B38
    public GameObject customDifficultyRoot;

    // Token: 0x4001B39
    public GameObject showTagSmoke;

    // Token: 0x4001B3A
    public GameObject showTagSpark;

    // Token: 0x4001B3B
    public GameObject showTagImpact;

    // Token: 0x4001B3C
    public GameObject showTagFlash;

    // Token: 0x4001B3D
    private int tryClothSkinLv;

    // Token: 0x4001B3E
    private GameObject newObj;

    // Token: 0x4001B3F
    private static StartMenuController _instance;

    // Token: 0x4001B40
    private bool inited;

    // Token: 0x4001B41
    private static readonly List<string> canStartChooseTagCategory;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002142
    // RVA   : 0xC7C7B0   Offset: 0xC7AFB0   Length: 0x57
    public static StartMenuController get_Instance()
    {
        return **(uint64 **)(DAT_181d815f0 + 184);
    }

    // Token : 0x6002143
    // RVA   : 0xC71420   Offset: 0xC6FC20   Length: 0xD8
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d815f0 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181d815f0 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x6002144
    // RVA   : 0xC7A920   Offset: 0xC79120   Length: 0x17D5
    private void Start()
    {
        var pStatics_1570 = *(int64*)(DAT_181d81570 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar11;
        ulong uVar12;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_48;
        uint local_44;
        int local_40;
        uint32 local_3c;
        uVar12 = 0;
        local_res20[0] = 0;
        local_48 = 0;
        local_44 = 0;
        local_40 = 0;
        local_3c = 0;
        if (**(int **)(DAT_181d4ef00 + 184) == 1) {
          cVar1 = RailManager.get_Initialized(0);
          if (!cVar1) {
            Debug.LogError("Rail sdk is not initialized!",0);
          }
          else {
            lVar3 = RailCallBackHelper.get_Instance(0);
            uVar5 = new OnTooltipCB(this,DAT_181d88ae8,0);
            if (lVar3 == null) throw; // [null/range check failed]
            RailCallBackHelper.RegisterCallback(lVar3,0x1f45,uVar5,0);
          }
        }
        lVar3 = this.attriPresetDatas;
        local_res18[0] = 0;
        uVar6 = uVar12;
        if (lVar3 != null) {
          while( true ) {
            uVar11 = uVar12;
            if (lVar3.Count <= (int)uVar6) goto LAB_180c7af80;
            uVar5 = this.AttriPresetList;
            uVar8 = this.AttriPresetButtonPrefab;
            lVar3 = GlobalData.AddChild(uVar5,uVar8,0);
            this.newObj = lVar3;
            if (((*plVar10 == 0) || (lVar3 = GameObject.get_transform(*plVar10,0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"Image",0)) == null) break;
            lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
            if (((this.attriPresetDatas == null) ||
                (lVar4 = FUN_180002f80(this.attriPresetDatas,local_res18[0],DAT_181d562c0),
                lVar4 == null)) || (lVar3 == null)) break;
            Image.set_sprite(lVar3,*(uint64 *)(lVar4 + 16),0);
            if (((*plVar10 == 0) || (lVar3 = GameObject.get_transform(*plVar10,0)) == null) ||
               (lVar3 = Transform.Find(lVar3,"Text",0)) == null) break;
            uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
            if ((this.attriPresetDatas == null) ||
               (lVar3 = FUN_180002f80(this.attriPresetDatas,local_res18[0],DAT_181d562c0),
               lVar3 == null)) break;
            LTLocalization.SetText(uVar5,lVar3.Count,0);
            if (*plVar10 == 0) break;
            lVar3 = GameObject.GetComponent(*plVar10,DAT_181da12b0);
            if (((this.attriPresetDatas == null) ||
                (lVar4 = FUN_180002f80(this.attriPresetDatas,local_res18[0],DAT_181d562c0),
                lVar4 == null)) || (lVar3 == null)) break;
            lVar3.Count = *(uint64 *)(lVar4 + 32);
            if ((this.attriPresetDatas == null) ||
               (lVar3 = FUN_180002f80(this.attriPresetDatas,local_res18[0])) == null) break;
            if (*(char *)(lVar3 + 40) != false) {
              if (((*plVar10 == 0) || (lVar3 = GameObject.get_transform(*plVar10,0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"Recommend"), lVar3 == null ||
                  (lVar3 = Component.get_gameObject(lVar3,0)) == null))) break;
              GameObject.SetActive(lVar3,1);
            }
            lVar3 = *plVar10;
            uVar5 = Int32.ToString(local_res18,0);
            if (lVar3 == null) break;
            Object.set_name(lVar3,uVar5);
            lVar3 = this.attriPresetDatas;
            local_res18[0] = local_res18[0] + 1;
            uVar6 = (uint64)local_res18[0];
            if (lVar3 == null) break;
          }
        }
        throw; // [null/range check failed]
        LAB_180c7af80:
        if (((*pStatics_1570 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_1570 + 24)) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 0x128)) == null) throw; // [null/range check failed]
        uVar6 = uVar12;
        if (lVar3.Count <= (int)uVar11) goto LAB_180c7b150;
        if ((this.attriRoot == null) ||
           (lVar3 = GameObject.get_transform(this.attriRoot,0)) == null)
        throw; // [null/range check failed]
        lVar3 = Transform.Find(lVar3,"Attri",0);
        uVar5 = Int32.ToString(local_res20,0);
        if ((lVar3 == null) ||
           ((lVar3 = Transform.Find(lVar3,uVar5,0), lVar3 == null ||
            (lVar3 = Transform.Find(lVar3,"Icon",0)) == null))) throw; // [null/range check failed]
        lVar3 = Component.GetComponent(lVar3,DAT_181d6ccc0);
        lVar4 = *(int64 *)(pStatics_ef00 + 0x490);
        if (lVar4 == null) throw; // [null/range check failed]
        uVar5 = FUN_180002f80(lVar4,local_res20[0],DAT_181d7c9c0);
        lVar4 = FUN_18046c100(0);
        if ((((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) ||
            (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),local_res20[0],DAT_181d64878)) == null)
           || (uVar5 = String.Format("<b>{0}</b>\n{1}",uVar5,*(uint64 *)(lVar4 + 24),0), lVar3 == null))
        throw; // [null/range check failed]
        lVar3.Count = uVar5;
        local_res20[0] = local_res20[0] + 1;
        uVar11 = (uint64)local_res20[0];
        goto LAB_180c7af80;
        LAB_180c7b150:
        if (((*pStatics_1570 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_1570 + 24)) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 0x140)) == null) throw; // [null/range check failed]
        uVar11 = uVar12;
        if (lVar3.Count <= (int)uVar6) goto LAB_180c7b320;
        if ((this.attriRoot == null) ||
           (lVar3 = GameObject.get_transform(this.attriRoot,0)) == null)
        throw; // [null/range check failed]
        lVar3 = Transform.Find(lVar3,"FightSkill",0);
        uVar5 = Int32.ToString(&local_48,0);
        if ((lVar3 == null) ||
           ((lVar3 = Transform.Find(lVar3,uVar5,0), lVar3 == null ||
            (lVar3 = Transform.Find(lVar3,"Icon",0)) == null))) throw; // [null/range check failed]
        lVar3 = Component.GetComponent(lVar3,DAT_181d6ccc0);
        lVar4 = *(int64 *)(pStatics_ef00 + 0x498);
        if (lVar4 == null) throw; // [null/range check failed]
        uVar5 = FUN_180002f80(lVar4,local_48,DAT_181d7c9c0);
        lVar4 = FUN_18046c100(0);
        if ((((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) ||
            (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),local_48 + 6,DAT_181d64878)) == null)
           || (uVar5 = String.Format("<b>{0}</b>\n{1}",uVar5,*(uint64 *)(lVar4 + 24),0), lVar3 == null))
        throw; // [null/range check failed]
        lVar3.Count = uVar5;
        local_48 = local_48 + 1;
        uVar6 = (uint64)local_48;
        goto LAB_180c7b150;
        LAB_180c7b320:
        if (((*pStatics_1570 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_1570 + 24)) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 0x158)) == null) throw; // [null/range check failed]
        if (lVar3.Count <= (int)uVar11) {
          StartMenuController.SetAttriPreset(this,0,0);
          StartMenuController.RandomPlayerBaseAttri(this,0);
          StartMenuController.RandomPlayerBaseFightSkill(this,0);
          StartMenuController.RandomPlayerBaseLivingSkill(this,0);
          if ((*pStatics_1570 != 0) &&
             (lVar3 = *(int64 *)(*pStatics_1570 + 24)) != null) {
            *(uint32 *)(lVar3 + 0x1d0) = 0x42480000;
            if ((*pStatics_1570 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_1570 + 24)) != null) {
              *(uint32 *)(lVar3 + 0x1d4) = 0x42480000;
              this.needRefreshPlayerAttri = 1;
              StartMenuController.RefreshEvilChaosSlider(this,0);
              lVar3 = this.natureDropDown;
              if (lVar3 != null) {
                Dropdown.AddOptions(lVar3,*(uint64 *)(pStatics_ef00 + 0x5a0),0)
                ;
                if (*(int *)(pStatics_ef00 + 8) != 1) {
                  lVar3 = il2cpp_internal(DAT_181d72a30);
                  FUN_180f58a90(lVar3,DAT_181d7c250);
                  uVar6 = uVar12;
                  goto LAB_180c7b650;
                }
                if ((this.clothDropDown != null) &&
                   (lVar3 = Component.get_gameObject(this.clothDropDown,0)) != null) {
                  GameObject.SetActive(lVar3,0,0);
                  if ((((this.clothDropDown != null) &&
                       ((lVar3 = Component.get_transform(this.clothDropDown,0), lVar3 != null &&
                        (lVar3 = FUN_180da0f00(lVar3,0)) != null))) &&
                      (lVar3 = Transform.Find(lVar3,"ClothTitle",0)) != null) &&
                     (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
                    GameObject.SetActive(lVar3,0,0);
                    if ((((this.clothDropDown != null) &&
                         (lVar3 = Component.get_transform(this.clothDropDown,0)) != null)
                        && (lVar3 = FUN_180da0f00(lVar3,0)) != null) &&
                       ((lVar3 = Transform.Find(lVar3,"ToggleLv",0), lVar3 != null &&
                        (lVar3 = Component.get_gameObject(lVar3,0)) != null))) {
                      GameObject.SetActive(lVar3,0,0);
                      local_40 = 1;
                      goto LAB_180c7bb10;
                    }
                  }
                }
              }
            }
          }
          throw; // [null/range check failed]
        }
        if ((this.attriRoot == null) ||
           (lVar3 = GameObject.get_transform(this.attriRoot,0)) == null)
        throw; // [null/range check failed]
        lVar3 = Transform.Find(lVar3,"LivingSkill",0);
        uVar5 = Int32.ToString(&local_44,0);
        if ((lVar3 == null) ||
           ((lVar3 = Transform.Find(lVar3,uVar5,0), lVar3 == null ||
            (lVar3 = Transform.Find(lVar3,"Icon",0)) == null))) throw; // [null/range check failed]
        lVar3 = Component.GetComponent(lVar3,DAT_181d6ccc0);
        lVar4 = *(int64 *)(pStatics_ef00 + 0x4a8);
        if (lVar4 == null) throw; // [null/range check failed]
        uVar5 = FUN_180002f80(lVar4,local_44,DAT_181d7c9c0);
        lVar4 = FUN_18046c100(0);
        if ((((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) ||
            (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),local_44 + 24,DAT_181d64878)) == null
            ) || (uVar5 = String.Format("<b>{0}</b>\n{1}",uVar5,*(uint64 *)(lVar4 + 24),0), lVar3 == null)
           ) throw; // [null/range check failed]
        lVar3.Count = uVar5;
        local_44 = local_44 + 1;
        uVar11 = (uint64)local_44;
        goto LAB_180c7b320;
        LAB_180c7b650:
        lVar4 = *(int64 *)(pStatics_e010 + 32);
        if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 0x1a8)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar4 + 24) <= (int)uVar6) {
          if (this.clothDropDown != null) {
            Dropdown.AddOptions(this.clothDropDown,lVar3,0);
            goto LAB_180c7bc0b;
          }
          throw; // [null/range check failed]
        }
        lVar4 = FUN_18046c100(0);
        if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x1a8) == 0)) ||
           (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x1a8),uVar6,DAT_181d7b5d8)) == null)
        throw; // [null/range check failed]
        uVar5 = *(uint64 *)(lVar4 + 24);
        lVar4 = FUN_18046c100(0);
        if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x1a8) == 0)) ||
           (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x1a8),uVar6,DAT_181d7b5d8)) == null)
        throw; // [null/range check failed]
        uVar8 = "";
        if (-1 < *(int *)(lVar4 + 40)) {
          lVar4 = *(int64 *)(pStatics_ef00 + 64);
          lVar7 = *(int64 *)(pStatics_e010 + 32);
          if ((((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 0x1a8)) == null) ||
              (lVar7 = FUN_180002f80(lVar7,uVar6,DAT_181d7b5d8)) == null) || (lVar4 == null))
          throw; // [null/range check failed]
          uVar8 = FUN_180002f80(lVar4,*(uint32 *)(lVar7 + 40),DAT_181d7c9c0);
          lVar4 = *(int64 *)(pStatics_e010 + 8);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = *(int64 *)(lVar4 + 16);
          lVar7 = FUN_18046c100(0);
          if (((lVar7 == null) || (*(int64 *)(lVar7 + 0x1a8) == 0)) ||
             (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 0x1a8),uVar6,DAT_181d7b5d8)) == null)
          throw; // [null/range check failed]
          uVar9 = Int32.ToString(lVar7 + 40,0);
          uVar9 = String.Concat("DLC",uVar9,0);
          if (lVar4 == null) throw; // [null/range check failed]
          iVar2 = PlayerPrefDictionary.GetInt(lVar4,uVar9,0);
          uVar9 = "green";
          if (iVar2 < 1) {
            uVar9 = "red";
          }
          uVar8 = String.Format("<color={1}>[{0}]</color>",uVar8,uVar9,0);
        }
        lVar4 = FUN_18046c100(0);
        if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x1a8) == 0)) ||
           (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 0x1a8),uVar6,DAT_181d7b5d8)) == null)
        throw; // [null/range check failed]
        cVar1 = FUN_1816fd990(*(uint64 *)(lVar4 + 24),"袈裟",0);
        uVar11 = uVar12;
        if (cVar1) {
          uVar11 = "(仅男性)";
        }
        uVar5 = String.Concat(uVar5,uVar8,uVar11);
        uVar5 = LTLocalization.GetText(uVar5,0,1);
        if (lVar3 == null) throw; // [null/range check failed]
        FUN_181827900(lVar3,uVar5);
        uVar6 = (uint64)((int)uVar6 + 1);
        goto LAB_180c7b650;
        while( true ) {
          lVar3 = GameObject.get_transform(*(int64 *)(this + 200),0);
          uVar5 = Int32.ToString(&local_40,0);
          if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar5,0)) == null) ||
             (lVar3 = Component.GetComponent(lVar3,DAT_181d6da40)) == null) throw; // [null/range check failed]
          Selectable.set_interactable(lVar3,0);
          if (*(int64 *)(this + 200) == 0) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(*(int64 *)(this + 200),0);
          uVar5 = Int32.ToString(&local_40,0);
          if ((((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar5,0)) == null) ||
              (lVar3 = Transform.Find(lVar3,"Lock",0)) == null) ||
             (lVar3 = Component.get_gameObject(lVar3,0)) == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar3);
          local_40 = local_40 + 1;
          if (5 < local_40) break;
        LAB_180c7bb10:
          if (*(int64 *)(this + 200) == 0) throw; // [null/range check failed]
        }
        LAB_180c7bc0b:
        lVar3 = *(int64 *)(pStatics_e010 + 32);
        if (lVar3 != null) {
          GameDataController.CheckAllAch(lVar3,0);
          lVar3 = *(int64 *)(pStatics_e010 + 32);
          if (lVar3 != null) {
            GameDataController.SavePlayerprefData(lVar3,0);
            StartMenuController.RefreshDifficultyTotalLv(this,0);
            while( true ) {
              uVar5 = DAT_181d91c58;
              uVar5 = Type.GetTypeFromHandle(uVar5,0);
              lVar3 = Enum.GetNames(uVar5,0);
              if (lVar3 == null) throw; // [null/range check failed]
              if (lVar3.Count <= (int)uVar12) break;
              if ((this.customDifficultyRoot == null) ||
                 (lVar3 = GameObject.get_transform(this.customDifficultyRoot,0)) == null)
              throw; // [null/range check failed]
              lVar3 = Transform.Find(lVar3,"Grid",0);
              uVar5 = Int32.ToString(&local_3c,0);
              if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar5,0)) == null)
              throw; // [null/range check failed]
              Component.get_gameObject(lVar3,0);
              StartMenuController.RefreshDifficultySliderText(this);
              local_3c = local_3c + 1;
              uVar12 = (uint64)local_3c;
            }
            cVar1 = GlobalData.IsCheckVersion(1,0);
            if (!cVar1) {
              if (*(char *)(pStatics_ef00 + 4) == false) {
                return;
              }
            }
            if ((((this.startMenu != null) &&
                 (lVar3 = GameObject.get_transform(this.startMenu,0)) != null) &&
                (lVar3 = Transform.Find(lVar3,"StartMenuRoot",0)) != null) &&
               (((lVar3 = Transform.Find(lVar3,"BirthRoot",0), lVar3 != null &&
                 (lVar3 = Transform.Find(lVar3,"0",0)) != null) &&
                ((lVar3 = Transform.Find(lVar3,"6",0), lVar3 != null &&
                 ((lVar3 = Transform.Find(lVar3,"Label",0), lVar3 != null &&
                  (plVar10 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0),
                  plVar10 != (int64 *)0)))))))) {
              (**(code **)(*plVar10 + 0x5e8))(plVar10,"贩夫走卒",*(uint64 *)(*plVar10 + 0x5f0));
              if (((this.startMenu != null) &&
                  (((lVar3 = GameObject.get_transform(this.startMenu,0), lVar3 != null &&
                    (lVar3 = Transform.Find(lVar3,"StartMenuRoot",0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"BirthRoot",0)) != null))) &&
                 (((lVar3 = Transform.Find(lVar3,"0",0), lVar3 != null &&
                   (lVar3 = Transform.Find(lVar3,"7",0)) != null) &&
                  ((lVar3 = Transform.Find(lVar3,"Label",0), lVar3 != null &&
                   (plVar10 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0),
                   plVar10 != (int64 *)0)))))) {
                (**(code **)(*plVar10 + 0x5e8))(plVar10,"情报探子",*(uint64 *)(*plVar10 + 0x5f0));
                if ((((this.startMenu != null) &&
                     (lVar3 = GameObject.get_transform(this.startMenu,0)) != null) &&
                    (lVar3 = Transform.Find(lVar3,"StartMenuRoot",0)) != null) &&
                   ((((lVar3 = Transform.Find(lVar3,"BirthRoot",0), lVar3 != null &&
                      (lVar3 = Transform.Find(lVar3,"0",0)) != null) &&
                     (lVar3 = Transform.Find(lVar3,"8",0)) != null) &&
                    ((lVar3 = Transform.Find(lVar3,"Label",0), lVar3 != null &&
                     (plVar10 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0),
                     plVar10 != (int64 *)0)))))) {
                  (**(code **)(*plVar10 + 0x5e8))(plVar10,"奇门术士",*(uint64 *)(*plVar10 + 0x5f0))
                  ;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002145
    // RVA   : 0xC7C5D0   Offset: 0xC7ADD0   Length: 0x11
    private void Update()
    {
        void FUN_180c7c5d0(int64 this)
        {
        if (this.needRefreshPlayerAttri) {
          StartMenuController.RefreshPlayerAttri(this,0);
          return;
        }
    }

    // Token : 0x6002146
    // RVA   : 0xC799E0   Offset: 0xC781E0   Length: 0x4F7
    public void ShowStartMenu()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar6;
        int iVar7;
        int[] local_res8 = new int[2];
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        if (this.startMenu != null) {
          GameObject.SetActive(this.startMenu,1,0);
          if (((this.startMenu != null) &&
              (lVar2 = GameObject.get_transform(this.startMenu,0)) != null) &&
             (lVar2 = Transform.Find(lVar2,"BlackBackground",0)) != null) {
            plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
            if (((this.startMenu != null) &&
                (lVar2 = GameObject.get_transform(this.startMenu,0)) != null) &&
               ((lVar2 = Transform.Find(lVar2,"BlackBackground",0), lVar2 != null &&
                (plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40),
                plVar4 != (int64 *)0)))) {
              puVar5 = (uint64 *)
                       (**(code **)(*plVar4 + 0x298))(&local_38,plVar4,*(uint64 *)(*plVar4 + 0x2a0));
              local_38 = *puVar5;
              uStack_30 = puVar5[1];
              puVar5 = (uint64 *)GlobalData.SetColorAlpha(local_28,&local_38,0,0);
              if (plVar3 != (int64 *)0) {
                local_38 = *puVar5;
                uStack_30 = puVar5[1];
                (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_38,*(uint64 *)(*plVar3 + 0x2b0));
                if (((this.startMenu != null) &&
                    (lVar2 = GameObject.get_transform(this.startMenu,0)) != null) &&
                   (lVar2 = Transform.Find(lVar2,"BlackBackground",0)) != null) {
                  uVar6 = Component.GetComponent(lVar2,DAT_181d6bc40);
                  uVar6 = DOTweenModuleUI.DOFade(uVar6,0x3f000000,0x3e800000,0);
                  TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181d98958);
                  if (((this.startMenu != null) &&
                      (lVar2 = GameObject.get_transform(this.startMenu,0)) != null) &&
                     (lVar2 = Transform.Find(lVar2,"StartMenuRoot",0)) != null) {
                    local_38 = 0x3f80000000000000;
                    uStack_30 = CONCAT44(uStack_30._4_4_,0x3f800000);
                    Transform.set_localScale(lVar2,&local_38,0);
                    if ((this.startMenu != null) &&
                       (lVar2 = GameObject.get_transform(this.startMenu,0)) != null) {
                      uVar6 = Transform.Find(lVar2,"StartMenuRoot",0);
                      uVar6 = ShortcutExtensions.DOScale(uVar6,0x3f800000,0x3e800000,0);
                      TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181d98af0);
                      this.needRefreshPlayerAttri = 1;
                      if (this.inited) {
                        return;
                      }
                      this.inited = 1;
                      if (this.clothDropDown != null) {
                        Dropdown.set_value(this.clothDropDown,9);
                        StartMenuController.ResetFaceSetting(this,0);
                        StartMenuController.ResetPlayerSkeleton(this,0);
                        StartMenuController.ResetPlayerTag(this,0);
                        iVar7 = -1;
                        while( true ) {
                          local_res8[0] = iVar7;
                          lVar2 = *(int64 *)(pStatics + 192);
                          if (lVar2 == null) break;
                          if (*(int *)(lVar2 + 24) <= iVar7) {
                            return;
                          }
                          if ((((this.startMenu == null) ||
                               (lVar2 = GameObject.get_transform(this.startMenu,0),
                               lVar2 == null)) ||
                              (lVar2 = Transform.Find(lVar2,"StartMenuRoot",0)) == null) ||
                             (lVar2 = Transform.Find(lVar2,"SettingRoot",0)) == null) break;
                          lVar2 = Transform.Find(lVar2,"Difficult",0);
                          uVar6 = Int32.ToString(local_res8,0);
                          if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar6,0)) == null) ||
                             (lVar2 = Transform.Find(lVar2,"Background",0)) == null) break;
                          lVar2 = Component.GetComponent(lVar2,DAT_181d6ccc0);
                          lVar1 = *(int64 *)(pStatics + 200);
                          if ((lVar1 == null) || (uVar6 = FUN_180002f80(lVar1,local_res8[0] + 1), lVar2 == null)
                             ) break;
                          *(uint64 *)(lVar2 + 24) = uVar6;
                          iVar7 = local_res8[0] + 1;
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

    // Token : 0x6002147
    // RVA   : 0xC7C3A0   Offset: 0xC7ABA0   Length: 0x221
    public void UnshowStartMenu()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint local_18;
        uint local_14;
        uint local_10;
        if (this.startMenu != null) {
          lVar1 = GameObject.get_transform(this.startMenu,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"BlackBackground",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98958);
              if (this.startMenu != null) {
                lVar1 = GameObject.get_transform(this.startMenu,0);
                if (lVar1 != null) {
                  uVar2 = Transform.Find(lVar1,"StartMenuRoot",0);
                  local_18 = 0;
                  local_14 = 0x3f800000;
                  local_10 = 0x3f800000;
                  uVar2 = ShortcutExtensions.DOScale(uVar2,&local_18,0x3e4ccccd,0);
                  uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98af0);
                  uVar3 = new OnTooltipCB(this,DAT_181d88a68,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96ee8);
                  plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
                  plVar5 = (int64 *)0;
                  if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                    plVar5 = plVar4;
                  }
                  NGUITools.PlaySound(plVar5,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002148
    // RVA   : 0xC7C100   Offset: 0xC7A900   Length: 0x12A
    public void TabButtonValueChanged(GameObject targetTab)
    {
        ulong uVar1;
        int iVar2;
        long lVar3;
        if ((targetTab != null) && (lVar3 = GameObject.GetComponent(targetTab,DAT_181da2130)) != null) {
          if (*(char *)(lVar3 + 0x118) == false) {
            return;
          }
          uVar1 = Object.get_name(targetTab,0);
          iVar2 = Int32.Parse(uVar1,0);
          if (this.backMountain != null) {
            uVar1 = GameObject.get_transform(this.backMountain,0);
            ShortcutExtensions.DOScale(uVar1,(float)iVar2 * 0.2 + 0.9,0x3f000000,0);
            if (this.backMountain != null) {
              uVar1 = GameObject.GetComponent(this.backMountain,DAT_181d9fe50);
              DOTweenModuleUI.DOFade(uVar1,((float)iVar2 * 30.0 + 30.0) / 255.0,0x3f000000,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002149
    // RVA   : 0xC71D90   Offset: 0xC70590   Length: 0xC8
    public void ChangeBackMountainState(int id)
    {
        ulong uVar1;
        if (this.backMountain != null) {
          uVar1 = GameObject.get_transform(this.backMountain,0);
          ShortcutExtensions.DOScale(uVar1,(float)id * 0.2 + 0.9,0x3f000000,0);
          if (this.backMountain != null) {
            uVar1 = GameObject.GetComponent(this.backMountain,DAT_181d9fe50);
            DOTweenModuleUI.DOFade(uVar1,((float)id * 30.0 + 30.0) / 255.0,0x3f000000,0);
            return;
          }
        }
    }

    // Token : 0x600214A
    // RVA   : 0xC78A40   Offset: 0xC77240   Length: 0x504
    public void ResetPlayerTag()
    {
        var pStatics_1570 = *(int64*)(DAT_181d81570 + 184);
        var pStatics_15f0 = *(int64*)(DAT_181d815f0 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        ulong local_70;
        ulong uStack_68;
        long local_60;
        ulong local_58;
        ulong uStack_50;
        long local_48;
        if (*pStatics_1570 != 0) {
          lVar5 = *(int64 *)(*pStatics_1570 + 24);

          if ((lVar8 = *(int64 *)(pStatics_e010 + 8)?._items) != null) {
            iVar3 = PlayerPrefDictionary.GetInt(lVar8,"AchTagPoint",0);
            if (lVar5 != null) {
              *(float *)(lVar5 + 0x364) = (float)(iVar3 + 20);
              if (((*pStatics_1570 != 0) &&
                  (lVar5 = *(int64 *)(*pStatics_1570 + 24)) != null) &&
                 (lVar5 = *(int64 *)(lVar5 + 0x368)) != null) {
                FUN_180f56130(lVar5,DAT_181d64df8);
                lVar5 = *(int64 *)(pStatics_e010 + 32);
                if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 0x198)) != null) {
                  lVar5 = FUN_1808acf30(lVar5,DAT_181d94d28);
                  if (lVar5 != null) {
                    ValueCollection.GetEnumerator(&local_58,lVar5,DAT_181d56b68);
                    local_70 = local_58;
                    uStack_68 = uStack_50;
                    local_60 = local_48;
                    while( true ) {
                      do {
                        cVar2 = FUN_1811d7520(&local_70,DAT_181d72438);
                        lVar5 = local_60;
                        if (!cVar2) {
                          ZhSegment.Initialize(&local_70,DAT_181d723b8);
                          StartMenuController.RefreshTagMenu(this,0);
                          return;
                        }
                        lVar8 = *(int64 *)(pStatics_15f0 + 8);
                        if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        cVar2 = FUN_1818279a0(lVar8,*(uint64 *)(lVar5 + 80),DAT_181d7c4d0);
                      } while (!cVar2);
                      lVar8 = this.allTagGrid;
                      lVar1 = *(int64 *)(pStatics_15f0 + 8);
                      if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      uVar4 = FUN_1817ff280(lVar1,*(uint64 *)(lVar5 + 80),DAT_181d7c648);
                      if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      uVar6 = FUN_180002f80(lVar8,uVar4,DAT_181d62178);
                      uVar7 = this.startChooseTagPrefab;
                      uVar7 = GlobalData.AddChild(uVar6,uVar7,0);
                      this.newObj = uVar7;
                      if (this.newObj == null) break;
                      lVar8 = GameObject.GetComponent(this.newObj,DAT_181d9fcb8);
                      uVar4 = *(uint32 *)(lVar5 + 16);
                      uVar7 = new HeroTagData(uVar4,0xbf800000,0,0);
                      if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      *(uint64 *)(lVar8 + 32) = uVar7;
                      if (this.newObj == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar5 = GameObject.GetComponent(this.newObj,DAT_181d9fcb8);
                      if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      *(uint32 *)(lVar5 + 24) = 2;
                    }
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600214B
    // RVA   : 0xC77080   Offset: 0xC75880   Length: 0xB27
    public void RefreshTagMenu()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        bool cVar3;
        byte uVar4;
        int iVar5;
        int iVar6;
        int iVar7;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        long lVar11;
        long lVar12;
        long lVar13;
        int iVar15;
        int iVar16;
        int[] local_res18 = new int[2];
        uint[] local_res20 = new uint[2];
        ulong local_68;
        uint local_60;
        byte[] local_58 = new byte[16];
        byte[] local_48 = new byte[16];
        local_res18[0] = 0;
        if (*pStatics != 0) {
          lVar13 = *(int64 *)(*pStatics + 24);
          if (this.tagRoot != null) {
            lVar8 = GameObject.get_transform(this.tagRoot,0);
            if (lVar8 != null) {
              lVar8 = Transform.Find(lVar8,"TagPointNum",0);
              if (lVar8 != null) {
                uVar9 = Component.GetComponent(lVar8,DAT_181d6d8c0);
                if (lVar13 != null) {
                  uVar10 = Single.ToString(lVar13 + 0x364,"0.##",0);
                  uVar10 = String.Concat("天赋点 ",uVar10,0);
                  LTLocalization.SetText(uVar9,uVar10,0);
                  if (this.tagRoot != null) {
                    lVar8 = GameObject.get_transform(this.tagRoot,0);
                    if (lVar8 != null) {
                      lVar8 = Transform.Find(lVar8,"TagNum",0);
                      if (lVar8 != null) {
                        uVar9 = Component.GetComponent(lVar8,DAT_181d6d8c0);
                        if (*(int64 *)(lVar13 + 0x368) != 0) {
                          local_res20[0] = *(uint32 *)(*(int64 *)(lVar13 + 0x368) + 24);
                          uVar10 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                          uVar10 = String.Format("初始上限 {0}/5",uVar10,0);
                          LTLocalization.SetText(uVar9,uVar10,0);
                          uVar9 = this.selfTagGrid;
                          GlobalData.DeleteAllChild(uVar9,0);
                          iVar15 = 0;
                          while (*(int64 *)(lVar13 + 0x368) != 0) {
                            if (*(int *)(*(int64 *)(lVar13 + 0x368) + 24) <= iVar15) {
                              iVar15 = 0;
                              goto LAB_180c774a0;
                            }
                            uVar9 = this.selfTagGrid;
                            uVar10 = this.startChooseTagPrefab;
                            uVar9 = GlobalData.AddChild(uVar9,uVar10,0);
                            this.newObj = uVar9;
                            if (this.newObj == null) break;
                            lVar8 = GameObject.GetComponent(this.newObj,DAT_181d9fcb8)
                            ;
                            if (*(int64 *)(lVar13 + 0x368) == 0) break;
                            uVar9 = FUN_180002f80(*(int64 *)(lVar13 + 0x368),iVar15);
                            if (lVar8 == null) break;
                            *(uint64 *)(lVar8 + 32) = uVar9;
                            if (this.newObj == null) break;
                            lVar8 = GameObject.GetComponent();
                            if (lVar8 == null) break;
                            iVar15 = iVar15 + 1;
                            *(uint32 *)(lVar8 + 24) = 3;
                          }
        LAB_180c77ba2:
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
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180c774a0:
        lVar8 = *(int64 *)(*(int64 *)(DAT_181d815f0 + 184) + 8);
        if (lVar8 == null) goto LAB_180c77ba2;
        if (*(int *)(lVar8 + 24) <= iVar15) {
          iVar15 = 1;
          goto LAB_180c77870;
        }
        iVar16 = 0;
        while( true ) {
          if (this.allTagGrid == null) goto LAB_180c77ba2;
          lVar8 = FUN_180002f80();
          if (lVar8 == null) goto LAB_180c77ba2;
          lVar8 = GameObject.get_transform(lVar8);
          if (lVar8 == null) goto LAB_180c77ba2;
          iVar5 = Transform.get_childCount(lVar8);
          if (iVar5 <= iVar16) break;
          if (this.allTagGrid == null) goto LAB_180c77ba2;
          lVar8 = FUN_180002f80(this.allTagGrid,iVar15,DAT_181d62178);
          if (lVar8 == null) goto LAB_180c77ba2;
          lVar8 = GameObject.get_transform(lVar8,0);
          if (lVar8 == null) goto LAB_180c77ba2;
          lVar8 = Transform.GetChild(lVar8,iVar16,0);
          if (lVar8 == null) goto LAB_180c77ba2;
          lVar11 = Component.GetComponent(lVar8,DAT_181d6b940);
          if ((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) goto LAB_180c77ba2;
          cVar3 = HeroTagData.StartChooseAble(*(int64 *)(lVar11 + 32),0);
          if (!cVar3) {
        LAB_180c77822:
            uVar4 = 0;
          }
          else {
            iVar5 = HeroData.GetHeroPermanentTagNum(lVar13,0);
            if (iVar5 < 5) {
        LAB_180c77613:
              iVar5 = 0;
              do {
                lVar12 = *(int64 *)(lVar13 + 0x368);
                if (lVar12 == null) goto LAB_180c77ba2;
                lVar1 = *(int64 *)(lVar11 + 32);
                if (*(int *)(lVar12 + 24) <= iVar5) {
                  if (lVar1 == null) goto LAB_180c77ba2;
                  uVar9 = HeroTagData.DataBase(lVar1,0);
                  uVar4 = StartMenuController.CheckMeetCondition(this,lVar13,uVar9,0);
                  goto LAB_180c77824;
                }
                if (lVar1 == null) goto LAB_180c77ba2;
                iVar6 = *(int *)(lVar1 + 16);
                lVar12 = FUN_180002f80(lVar12,iVar5,DAT_181d64f78);
                if (lVar12 == null) goto LAB_180c77ba2;
                if (iVar6 == *(int *)(lVar12 + 16)) goto LAB_180c77822;
                if (*(int64 *)(lVar11 + 32) == 0) goto LAB_180c77ba2;
                lVar12 = HeroTagData.DataBase(*(int64 *)(lVar11 + 32),0);
                if (lVar12 == null) goto LAB_180c77ba2;
                cVar3 = String.op_Inequality(*(uint64 *)(lVar12 + 40),"",0);
                if (cVar3) {
                  if (*(int64 *)(lVar13 + 0x368) == 0) goto LAB_180c77ba2;
                  lVar12 = FUN_180002f80(*(int64 *)(lVar13 + 0x368),iVar5,DAT_181d64f78);
                  if (lVar12 == null) goto LAB_180c77ba2;
                  lVar12 = HeroTagData.DataBase(lVar12,0);
                  if (lVar12 == null) goto LAB_180c77ba2;
                  uVar9 = *(uint64 *)(lVar12 + 48);
                  if (*(int64 *)(lVar11 + 32) == 0) goto LAB_180c77ba2;
                  lVar12 = HeroTagData.DataBase(*(int64 *)(lVar11 + 32),0);
                  if (lVar12 == null) goto LAB_180c77ba2;
                  cVar3 = FUN_1816fd990(uVar9,*(uint64 *)(lVar12 + 40),0);
                  if (cVar3) goto LAB_180c77822;
                  if (*(int64 *)(lVar13 + 0x368) == 0) goto LAB_180c77ba2;
                  lVar12 = FUN_180002f80(*(int64 *)(lVar13 + 0x368),iVar5,DAT_181d64f78);
                  if (lVar12 == null) goto LAB_180c77ba2;
                  lVar12 = HeroTagData.DataBase(lVar12,0);
                  if (lVar12 == null) goto LAB_180c77ba2;
                  uVar9 = *(uint64 *)(lVar12 + 40);
                  if (*(int64 *)(lVar11 + 32) == 0) goto LAB_180c77ba2;
                  lVar12 = HeroTagData.DataBase(*(int64 *)(lVar11 + 32),0);
                  if (lVar12 == null) goto LAB_180c77ba2;
                  cVar3 = FUN_1816fd990(uVar9,*(uint64 *)(lVar12 + 40),0);
                  if (cVar3) {
                    if (*(int64 *)(lVar13 + 0x368) == 0) goto LAB_180c77ba2;
                    lVar12 = FUN_180002f80(*(int64 *)(lVar13 + 0x368),iVar5,DAT_181d64f78);
                    if (lVar12 == null) goto LAB_180c77ba2;
                    lVar12 = HeroTagData.DataBase(lVar12,0);
                    if (lVar12 == null) goto LAB_180c77ba2;
                    iVar6 = Mathf.Abs(*(uint32 *)(lVar12 + 32));
                    if (*(int64 *)(lVar11 + 32) == 0) goto LAB_180c77ba2;
                    lVar12 = HeroTagData.DataBase(*(int64 *)(lVar11 + 32),0);
                    if (lVar12 == null) goto LAB_180c77ba2;
                    iVar7 = Mathf.Abs(*(uint32 *)(lVar12 + 32));
                    if (iVar7 <= iVar6) goto LAB_180c77822;
                  }
                }
                iVar5 = iVar5 + 1;
              } while( true );
            }
            if (*(int64 *)(lVar11 + 32) == 0) goto LAB_180c77ba2;
            lVar12 = HeroTagData.DataBase(*(int64 *)(lVar11 + 32),0);
            if ((lVar12 == null) || (*(int64 *)(lVar12 + 72) == 0)) goto LAB_180c77ba2;
            iVar5 = *(int *)(*(int64 *)(lVar12 + 72) + 24);
            uVar4 = 0 < iVar5;
            if (0 < iVar5) goto LAB_180c77613;
          }
        LAB_180c77824:
          lVar8 = Component.GetComponent(lVar8,DAT_181d6af40);
          if (lVar8 == null) goto LAB_180c77ba2;
          Selectable.set_interactable(lVar8,uVar4,0);
          HeroTagIconController.RefreshInfo(lVar11,0);
          iVar16 = iVar16 + 1;
        }
        iVar15 = iVar15 + 1;
        goto LAB_180c774a0;
        LAB_180c77870:
        lVar13 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if (lVar13 == null) goto LAB_180c77ba2;
        lVar13 = *(int64 *)(lVar13 + 16);
        local_res18[0] = iVar15 + 27;
        uVar9 = Int32.ToString(local_res18,0);
        uVar9 = String.Concat("AchFinished",uVar9,0);
        if (lVar13 == null) goto LAB_180c77ba2;
        uVar9 = PlayerPrefDictionary.GetString(lVar13,uVar9,0);
        cVar3 = FUN_1816fd990(uVar9,"true",0);
        if (this.tagRoot == null) goto LAB_180c77ba2;
        lVar13 = GameObject.get_transform(this.tagRoot,0);
        if (lVar13 == null) goto LAB_180c77ba2;
        lVar13 = Transform.Find(lVar13,"EndingTag",0);
        local_res18[0] = iVar15;
        uVar9 = Int32.ToString(local_res18,0);
        if (lVar13 == null) goto LAB_180c77ba2;
        lVar13 = Transform.Find(lVar13,uVar9,0);
        if (lVar13 == null) goto LAB_180c77ba2;
        lVar13 = Transform.Find(lVar13,"Lock",0);
        if (!cVar3) {
          puVar14 = (uint64 *)Vector3.get_one(local_48,0);
        }
        else {
          puVar14 = (uint64 *)Vector3.get_zero(local_58);
        }
        if (lVar13 == null) goto LAB_180c77ba2;
        local_68 = *puVar14;
        local_60 = *(uint32 *)(puVar14 + 1);
        Transform.set_localScale(lVar13,&local_68,0);
        if (this.tagRoot == null) goto LAB_180c77ba2;
        lVar13 = GameObject.get_transform(this.tagRoot,0);
        if (lVar13 == null) goto LAB_180c77ba2;
        lVar13 = Transform.Find(lVar13,"EndingTag",0);
        local_res18[0] = iVar15;
        uVar9 = Int32.ToString(local_res18,0);
        if (lVar13 == null) goto LAB_180c77ba2;
        lVar13 = Transform.Find(lVar13,uVar9,0);
        if (lVar13 == null) goto LAB_180c77ba2;
        lVar13 = Component.GetComponent(lVar13,DAT_181d6da40);
        if (lVar13 == null) goto LAB_180c77ba2;
        Selectable.set_interactable(lVar13,cVar3,0);
        if (this.tagRoot == null) goto LAB_180c77ba2;
        lVar13 = GameObject.get_transform(this.tagRoot,0);
        if (lVar13 == null) goto LAB_180c77ba2;
        lVar13 = Transform.Find(lVar13,"EndingTag",0);
        local_res18[0] = iVar15;
        uVar9 = Int32.ToString(local_res18,0);
        if (lVar13 == null) goto LAB_180c77ba2;
        lVar13 = Transform.Find(lVar13,uVar9,0);
        if (lVar13 == null) goto LAB_180c77ba2;
        lVar13 = Transform.Find(lVar13,"Background",0);
        if (lVar13 == null) goto LAB_180c77ba2;
        lVar13 = Component.GetComponent(lVar13,DAT_181d6ccc0);
        lVar8 = FUN_18046c100(0);
        if ((lVar8 == null) || (*(int64 *)(lVar8 + 0x198) == 0)) goto LAB_180c77ba2;
        lVar8 = FUN_1817cc780(*(int64 *)(lVar8 + 0x198),iVar15 + 0x17a);
        if (lVar8 == null) goto LAB_180c77ba2;
        uVar9 = HeroTagDataBase.GetDescribe(lVar8,0);
        if (lVar13 == null) goto LAB_180c77ba2;
        *(uint64 *)(lVar13 + 24) = uVar9;
        bVar2 = 10 < iVar15;
        iVar15 = iVar15 + 1;
        if (bVar2) {
          return;
        }
        goto LAB_180c77870;
    }

    // Token : 0x600214C
    // RVA   : 0xC7A0C0   Offset: 0xC788C0   Length: 0x4CB
    public void StartChooseTagClicked(int tagID)
    {
        var pStatics_1570 = *(int64*)(DAT_181d81570 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        float fVar1;
        long lVar2;
        long lVar4;
        float fVar6;
        if (((*pStatics_1570 != 0) &&
            (lVar2 = *(int64 *)(*pStatics_1570 + 24)) != null) &&
           (lVar2 = *(int64 *)(lVar2 + 0x368)) != null) {
          if (4 < *(int *)(lVar2 + 24)) {
            lVar2 = *(int64 *)(pStatics_e010 + 32);
            if ((((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 0x198)) == null) ||
                (lVar2 = FUN_1817cc780(lVar2,tagID,DAT_181d94ca0)) == null) ||
               (*(int64 *)(lVar2 + 72) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar2 + 72) + 24) < 1) goto LAB_180c7a374;
          }
          if ((*pStatics_1570 != 0) &&
             (lVar2 = *(int64 *)(*pStatics_1570 + 24)) != null) {
            fVar1 = *(float *)(lVar2 + 0x364);
            lVar2 = *(int64 *)(pStatics_e010 + 32);
            if (((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 0x198)) != null) &&
               (lVar2 = FUN_1817cc780(lVar2,tagID,DAT_181d94ca0)) != null) {
              fVar6 = (float)HeroTagDataBase.GetCostValue(lVar2,1,0);
              if (fVar1 - fVar6 < 0.0) {
        LAB_180c7a374:
                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar5 = (int64 *)0;
                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                  plVar5 = plVar3;
                }
                NGUITools.PlaySound(plVar5,0);
                return;
              }
              plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Success",0);
              plVar5 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                plVar5 = plVar3;
              }
              NGUITools.PlaySound(plVar5,0x3f000000,0);
              if ((*pStatics_1570 != 0) &&
                 (lVar2 = *(int64 *)(*pStatics_1570 + 24)) != null) {
                HeroData.UnderstandTag(lVar2,tagID,0,0);
                if ((*pStatics_1570 != 0) &&
                   (lVar2 = *(int64 *)(*pStatics_1570 + 24)) != null) {
                  fVar1 = *(float *)(lVar2 + 0x364);
                  lVar4 = *(int64 *)(pStatics_e010 + 32);
                  if (((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 0x198)) != null) &&
                     (lVar4 = FUN_1817cc780(lVar4,tagID,DAT_181d94ca0)) != null) {
                    fVar6 = (float)HeroTagDataBase.GetCostValue(lVar4,1,0);
                    *(float *)(lVar2 + 0x364) = fVar1 - fVar6;
                    StartMenuController.RefreshTagMenu(this,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600214D
    // RVA   : 0xC7A590   Offset: 0xC78D90   Length: 0x38E
    public void StartUnchooseTagClicked(int tagID)
    {
        var pStatics_1570 = *(int64*)(DAT_181d81570 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        float fVar1;
        long lVar2;
        long lVar4;
        float fVar6;
        if ((*pStatics_1570 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_1570 + 24)) != null) {
          fVar1 = *(float *)(lVar2 + 0x364);
          lVar2 = *(int64 *)(pStatics_e010 + 32);
          if (((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 0x198)) != null) &&
             (lVar2 = FUN_1817cc780(lVar2,tagID,DAT_181d94ca0)) != null) {
            fVar6 = (float)HeroTagDataBase.GetCostValue(lVar2,1,0);
            if (fVar6 + fVar1 < 0.0) {
              plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar5 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                plVar5 = plVar3;
              }
              NGUITools.PlaySound(plVar5,0);
              return;
            }
            plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Fail",0);
            plVar5 = (int64 *)0;
            if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
              plVar5 = plVar3;
            }
            NGUITools.PlaySound(plVar5,0x3f000000,0);
            if ((*pStatics_1570 != 0) &&
               (lVar2 = *(int64 *)(*pStatics_1570 + 24)) != null) {
              HeroData.DisUnderstandTag(lVar2,tagID,0);
              if ((*pStatics_1570 != 0) &&
                 (lVar2 = *(int64 *)(*pStatics_1570 + 24)) != null) {
                fVar1 = *(float *)(lVar2 + 0x364);
                lVar4 = *(int64 *)(pStatics_e010 + 32);
                if (((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 0x198)) != null) &&
                   (lVar4 = FUN_1817cc780(lVar4,tagID,DAT_181d94ca0)) != null) {
                  fVar6 = (float)HeroTagDataBase.GetCostValue(lVar4,1,0);
                  *(float *)(lVar2 + 0x364) = fVar6 + fVar1;
                  StartMenuController.RefreshTagMenu(this,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600214E
    // RVA   : 0xC71E60   Offset: 0xC70660   Length: 0x1CD
    public bool CheckMeetCondition(HeroData checkHero, HeroTagDataBase targetTag)
    {
        uint64 StartMenuController.CheckMeetCondition
                          (uint64 this,int64 checkHero,int64 targetTag)
        {
        char cVar1;
        uint64 uVar2;
        int64 lVar3;
        uint32 uVar4;
        int64 lVar5;
        uint32 uVar6;
        int64 lVar7;
        float extraout_XMM0_Da;
        if ((targetTag != null) && (uVar2 = HeroTagDataBase.GetCostValue(targetTag,1,0), checkHero != null)) {
          if (*(float *)(checkHero + 0x364) <= extraout_XMM0_Da &&
              extraout_XMM0_Da != *(float *)(checkHero + 0x364)) {
        LAB_180c72024:
            return uVar2 & 0xffffffffffffff00;
          }
          uVar4 = 0;
          lVar7 = 32;
          while (lVar5 = *(int64 *)(targetTag + 64)) != null {
            uVar6 = *(uint32 *)(lVar5 + 24);
            if ((int)uVar6 <= (int)uVar4) {
              return CONCAT71((uint7)(uint3)(uVar6 >> 8),1);
            }
            if (uVar6 <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar7 + *(int64 *)(lVar5 + 16));
            if (lVar5 == null) break;
            cVar1 = String.Contains(lVar5,"天赋:",0);
            if (cVar1) {
              uVar2 = String.Replace(lVar5,"天赋:","",0);
              uVar6 = 0;
              lVar5 = 32;
              while( true ) {
                lVar3 = *(int64 *)(checkHero + 0x368);
                if (lVar3 == null) throw; // [null/range check failed]
                if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar6) goto LAB_180c72024;
                if (*(uint32 *)(lVar3 + 24) <= uVar6) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = *(int64 *)(lVar5 + *(int64 *)(lVar3 + 16));
                if ((lVar3 == null) || (lVar3 = HeroTagData.DataBase(lVar3,0)) == null)
                throw; // [null/range check failed]
                uVar2 = FUN_1816fd990();
                if ((char)uVar2) break;
                uVar6 = uVar6 + 1;
                lVar5 = lVar5 + 8;
              }
            }
            uVar4 = uVar4 + 1;
            lVar7 = lVar7 + 8;
          }
        }
    }

    // Token : 0x600214F
    // RVA   : 0xC72030   Offset: 0xC70830   Length: 0x126
    public bool CheckMeetOneCondition(HeroData checkHero, string requirement)
    {
        uint64
        StartMenuController.CheckMeetOneCondition(uint64 this,int64 checkHero,int64 requirement)
        {
        char cVar1;
        uint64 uVar2;
        int64 lVar3;
        uint32 uVar4;
        int64 lVar5;
        if (requirement != null) {
          cVar1 = String.Contains(requirement,"天赋:",0);
          if (!cVar1) {
            return true;
          }
          uVar2 = String.Replace(requirement,"天赋:","",0);
          uVar4 = 0;
          if (checkHero != null) {
            lVar5 = 32;
            while (lVar3 = *(int64 *)(checkHero + 0x368)) != null {
              if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar4) {
                return false;
              }
              if (*(uint32 *)(lVar3 + 24) <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar5 + *(int64 *)(lVar3 + 16));
              if ((lVar3 == null) || (lVar3 = HeroTagData.DataBase(lVar3,0)) == null) break;
              cVar1 = FUN_1816fd990(*(uint64 *)(lVar3 + 24),uVar2,0);
              if (cVar1) {
                return true;
              }
              uVar4 = uVar4 + 1;
              lVar5 = lVar5 + 8;
            }
          }
        }
    }

    // Token : 0x6002150
    // RVA   : 0xC75080   Offset: 0xC73880   Length: 0x31B
    public void RandomFaceButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        int iVar5;
        int[] local_res18 = new int[4];
        if ((*pStatics != 0) &&
           (lVar3 = *(int64 *)(*pStatics + 24)) != null) {
          HeroData.RandomFaceData(lVar3,0,0);
          iVar5 = 0;
          while( true ) {
            local_res18[0] = iVar5;
            if ((((*pStatics == 0) ||
                 (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
                (lVar3 = *(int64 *)(lVar3 + 224)) == null) ||
               (lVar3 = *(int64 *)(lVar3 + 16)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar3 + 24) <= iVar5) break;
            lVar3 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x1d8);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar2 = FUN_180002f80(lVar3,local_res18[0]);
            cVar1 = String.op_Inequality(uVar2,"发后");
            if (cVar1) {
              if (this.faceSetting == null) throw; // [null/range check failed]
              lVar3 = GameObject.get_transform(this.faceSetting,0);
              uVar2 = Int32.ToString(local_res18,0);
              if (lVar3 == null) throw; // [null/range check failed]
              lVar3 = Transform.Find(lVar3,uVar2,0);
              if (lVar3 == null) throw; // [null/range check failed]
              plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d2c0);
              lVar3 = FUN_18077c280(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 24) == 0)) ||
                  (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 24) + 224)) == null) ||
                 (lVar3 = *(int64 *)(lVar3 + 16)) == null) throw; // [null/range check failed]
              FUN_1800d6750(lVar3,local_res18[0],DAT_181d68270);
              if (plVar4 == (int64 *)0) throw; // [null/range check failed]
              (**(code **)(*plVar4 + 0x428))(plVar4);
            }
            iVar5 = local_res18[0] + 1;
          }
          if (this.faceSetting != null) {
            lVar3 = GameObject.get_transform(this.faceSetting,0);
            if (lVar3 != null) {
              lVar3 = Transform.Find(lVar3,"SkinColor",0);
              if (lVar3 != null) {
                plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d2c0);
                lVar3 = *pStatics;
                if (((lVar3 != null) && (*(int64 *)(lVar3 + 24) != 0)) && (plVar4 != (int64 *)0)) {
                  (**(code **)(*plVar4 + 0x428))
                            (plVar4,pStatics,*(uint64 *)(*plVar4 + 0x430))
                  ;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002151
    // RVA   : 0xC77BB0   Offset: 0xC763B0   Length: 0xA0E
    public void ResetFaceSetting()
    {
        var pStatics_1570 = *(int64*)(DAT_181d81570 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        int iVar6;
        int[] local_res18 = new int[4];
        iVar6 = 0;
        while( true ) {
          local_res18[0] = iVar6;
          if ((((*pStatics_1570 == 0) ||
               (lVar3 = *(int64 *)(*pStatics_1570 + 24)) == null) ||
              (lVar3 = *(int64 *)(lVar3 + 224)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 16)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar3 + 24) <= iVar6) break;
          lVar3 = *(int64 *)(pStatics_ef00 + 0x1d8);
          if (lVar3 == null) throw; // [null/range check failed]
          uVar2 = FUN_180002f80(lVar3,local_res18[0]);
          cVar1 = String.op_Inequality(uVar2,"发后");
          if (cVar1) {
            lVar3 = FUN_18077c280(0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 24) == 0)) throw; // [null/range check failed]
            if (*(char *)(*(int64 *)(lVar3 + 24) + 128) == false) {
        LAB_180c77f63:
              lVar3 = *(int64 *)(pStatics_ef00 + 0x1d8);
              if (lVar3 == null) throw; // [null/range check failed]
              uVar2 = FUN_180002f80(lVar3,local_res18[0],DAT_181d7c9c0);
              cVar1 = FUN_1816fd990(uVar2,"胡",0);
              if (cVar1) {
                if (this.faceSetting == null) throw; // [null/range check failed]
                lVar3 = GameObject.get_transform(this.faceSetting,0);
                uVar2 = Int32.ToString(local_res18,0);
                if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null)
                throw; // [null/range check failed]
                lVar3 = Component.get_gameObject(lVar3,0);
                if (lVar3 == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar3,1,0);
                if ((this.faceSetting == null) ||
                   (lVar3 = GameObject.get_transform(this.faceSetting,0)) == null)
                throw; // [null/range check failed]
                lVar3 = FUN_180da0f00(lVar3,0);
                uVar2 = Int32.ToString(local_res18,0);
                uVar2 = String.Concat("Left",uVar2,0);
                if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null)
                throw; // [null/range check failed]
                lVar3 = Component.get_gameObject(lVar3,0);
                if (lVar3 == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar3,1,0);
                if ((this.faceSetting == null) ||
                   (lVar3 = GameObject.get_transform(this.faceSetting,0)) == null)
                throw; // [null/range check failed]
                lVar3 = FUN_180da0f00(lVar3,0);
                uVar2 = Int32.ToString(local_res18,0);
                uVar2 = String.Concat("Right",uVar2,0);
                if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null)
                throw; // [null/range check failed]
                lVar3 = Component.get_gameObject(lVar3,0);
                if (lVar3 == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar3,1,0);
              }
              if (this.faceSetting == null) throw; // [null/range check failed]
              lVar3 = GameObject.get_transform(this.faceSetting,0);
              uVar2 = Int32.ToString(local_res18,0);
              if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null)
              throw; // [null/range check failed]
              lVar3 = Component.GetComponent(lVar3,DAT_181d6d2c0);
              lVar4 = FUN_18077c280(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) throw; // [null/range check failed]
              if (*(char *)(*(int64 *)(lVar4 + 24) + 128) == false) {
                lVar4 = FUN_18046c100(0);
                if (lVar4 == null) throw; // [null/range check failed]
                lVar4 = *(int64 *)(lVar4 + 0x158);
              }
              else {
                lVar4 = FUN_18046c100(0);
                if (lVar4 == null) throw; // [null/range check failed]
                lVar4 = *(int64 *)(lVar4 + 0x160);
              }
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 16) == 0)) ||
                 (FUN_1800d6750(*(int64 *)(lVar4 + 16),local_res18[0],DAT_181d68270), lVar3 == null))
              throw; // [null/range check failed]
              Slider.set_maxValue(lVar3);
              lVar3 = *(int64 *)(pStatics_ef00 + 0x1d8);
              if (lVar3 == null) throw; // [null/range check failed]
              uVar2 = FUN_180002f80(lVar3,local_res18[0],DAT_181d7c9c0);
              cVar1 = FUN_1816fd990(uVar2,"胡",0);
              if (!cVar1) {
                lVar3 = *(int64 *)(pStatics_ef00 + 0x1d8);
                if (lVar3 == null) throw; // [null/range check failed]
                uVar2 = FUN_180002f80(lVar3,local_res18[0],DAT_181d7c9c0);
                cVar1 = FUN_1816fd990(uVar2,"发",0);
                if (!cVar1) {
                  lVar3 = *(int64 *)(pStatics_ef00 + 0x1d8);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar2 = FUN_180002f80(lVar3,local_res18[0],DAT_181d7c9c0);
                  cVar1 = FUN_1816fd990(uVar2,"杂",0);
                  if (!cVar1) goto LAB_180c783fe;
                }
              }
              if (this.faceSetting == null) throw; // [null/range check failed]
              lVar3 = GameObject.get_transform(this.faceSetting,0);
              uVar2 = Int32.ToString(local_res18,0);
              if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null) ||
                 (lVar3 = Component.GetComponent(lVar3,DAT_181d6d2c0)) == null) throw; // [null/range check failed]
              Slider.set_minValue(lVar3);
            }
            else {
              lVar3 = *(int64 *)(pStatics_ef00 + 0x1d8);
              if (lVar3 == null) throw; // [null/range check failed]
              uVar2 = FUN_180002f80(lVar3,local_res18[0],DAT_181d7c9c0);
              cVar1 = FUN_1816fd990(uVar2,"胡",0);
              if (!cVar1) goto LAB_180c77f63;
              if (this.faceSetting == null) throw; // [null/range check failed]
              lVar3 = GameObject.get_transform(this.faceSetting,0);
              uVar2 = Int32.ToString(local_res18,0);
              if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null) ||
                 (lVar3 = Component.get_gameObject(lVar3,0)) == null) throw; // [null/range check failed]
              GameObject.SetActive(lVar3,0,0);
              if ((this.faceSetting == null) ||
                 (lVar3 = GameObject.get_transform(this.faceSetting,0)) == null)
              throw; // [null/range check failed]
              lVar3 = FUN_180da0f00(lVar3,0);
              uVar2 = Int32.ToString(local_res18,0);
              uVar2 = String.Concat("Left",uVar2,0);
              if ((lVar3 == null) ||
                 ((lVar3 = Transform.Find(lVar3,uVar2,0), lVar3 == null ||
                  (lVar3 = Component.get_gameObject(lVar3,0)) == null))) throw; // [null/range check failed]
              GameObject.SetActive(lVar3,0,0);
              if ((this.faceSetting == null) ||
                 (lVar3 = GameObject.get_transform(this.faceSetting,0)) == null)
              throw; // [null/range check failed]
              lVar3 = FUN_180da0f00(lVar3,0);
              uVar2 = Int32.ToString(local_res18,0);
              uVar2 = String.Concat("Right",uVar2,0);
              if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null) ||
                 (lVar3 = Component.get_gameObject(lVar3,0)) == null) throw; // [null/range check failed]
              GameObject.SetActive(lVar3,0,0);
            }
        LAB_180c783fe:
            if (this.faceSetting == null) throw; // [null/range check failed]
            lVar3 = GameObject.get_transform(this.faceSetting,0);
            uVar2 = Int32.ToString(local_res18,0);
            if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar2,0)) == null) throw; // [null/range check failed]
            plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d2c0);
            lVar3 = *(int64 *)(pStatics_ef00 + 0x1d8);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar2 = FUN_180002f80(lVar3,local_res18[0],DAT_181d7c9c0);
            cVar1 = FUN_1816fd990(uVar2,"胡",0);
            if (!cVar1) {
              lVar3 = *(int64 *)(pStatics_ef00 + 0x1d8);
              if (lVar3 == null) throw; // [null/range check failed]
              uVar2 = FUN_180002f80(lVar3,local_res18[0],DAT_181d7c9c0);
              FUN_1816fd990(uVar2,"杂",0);
            }
            if (plVar5 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar5 + 0x428))(plVar5);
          }
          iVar6 = local_res18[0] + 1;
        }
        if (((this.faceSetting != null) &&
            (lVar3 = GameObject.get_transform(this.faceSetting,0)) != null) &&
           ((lVar3 = Transform.Find(lVar3,"SkinColor",0), lVar3 != null &&
            (plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d2c0), plVar5 != (int64 *)0)
            ))) {
          lVar3 = *plVar5;
          (**(code **)(lVar3 + 0x428))(plVar5,lVar3,*(uint64 *)(lVar3 + 0x430));
          return;
        }
    }

    // Token : 0x6002152
    // RVA   : 0xC78950   Offset: 0xC77150   Length: 0xE0
    public void ResetPlayerSkeleton()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        ulong uVar2;
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 24)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 224)) != null) {
          HeroFaceData.Reset(lVar1,0);
          if (*pStatics != 0) {
            lVar1 = *(int64 *)(*pStatics + 24);
            if (this.heroSkeleton != null) {
              uVar2 = GameObject.get_transform(this.heroSkeleton,0);
              if (lVar1 != null) {
                HeroData.SetSkeletonGraphic(lVar1,uVar2,0xffffff9d,this.tryClothSkinLv,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002153
    // RVA   : 0xC72C50   Offset: 0xC71450   Length: 0x62F
    public void FaceSliderButtonClicked(GameObject target)
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        int iVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar7;
        float fVar8;
        int[] local_res10 = new int[4];
        uint[] local_res20 = new uint[2];
        if ((target == null) || (lVar4 = Object.get_name(target,0)) == null) goto LAB_180c73274;
        cVar3 = String.Contains(lVar4,"Left",0);
        if (!cVar3) {
          lVar4 = Object.get_name(target,0);
          if (lVar4 == null) goto LAB_180c73274;
          uVar5 = String.Replace(lVar4,"Right","",0);
          local_res10[0] = Int32.Parse(uVar5,0);
          if (this.faceSetting == null) goto LAB_180c73274;
          lVar4 = GameObject.get_transform(this.faceSetting,0);
          uVar5 = Int32.ToString(local_res10,0);
          if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
             (plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181d6d2c0), plVar6 == (int64 *)0
             )) goto LAB_180c73274;
          fVar8 = (float)(**(code **)(*plVar6 + 0x418))(plVar6,*(uint64 *)(*plVar6 + 0x420));
          (**(code **)(*plVar6 + 0x428))(plVar6,fVar8 + 1.0,*(uint64 *)(*plVar6 + 0x430));
        }
        else {
          lVar4 = Object.get_name(target,0);
          if (lVar4 == null) goto LAB_180c73274;
          uVar5 = String.Replace(lVar4,"Left","",0);
          local_res10[0] = Int32.Parse(uVar5,0);
          if (this.faceSetting == null) goto LAB_180c73274;
          lVar4 = GameObject.get_transform(this.faceSetting,0);
          uVar5 = Int32.ToString(local_res10,0);
          if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
             (plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181d6d2c0), plVar6 == (int64 *)0
             )) goto LAB_180c73274;
          fVar8 = (float)(**(code **)(*plVar6 + 0x418))(plVar6,*(uint64 *)(*plVar6 + 0x420));
          (**(code **)(*plVar6 + 0x428))(plVar6,fVar8 - 1.0,*(uint64 *)(*plVar6 + 0x430));
        }
        if (this.faceSetting != null) {
          lVar4 = GameObject.get_transform(this.faceSetting,0);
          uVar5 = Int32.ToString(local_res10,0);
          if (((lVar4 != null) && (lVar4 = Transform.Find(lVar4,uVar5,0)) != null) &&
             (lVar4 = Transform.Find(lVar4,"Id",0)) != null) {
            uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            local_res20[0] = (**(code **)(*plVar6 + 0x418))(plVar6,*(uint64 *)(*plVar6 + 0x420));
            uVar7 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
            uVar7 = String.Format("({0})",uVar7,0);
            LTLocalization.SetText(uVar5,uVar7,0);
            iVar2 = local_res10[0];
            if (((*pStatics != 0) &&
                (lVar4 = *(int64 *)(*pStatics + 24)) != null) &&
               (lVar4 = *(int64 *)(lVar4 + 224)) != null) {
              lVar4 = *(int64 *)(lVar4 + 16);
              fVar8 = (float)(**(code **)(*plVar6 + 0x418))(plVar6,*(uint64 *)(*plVar6 + 0x420));
              if (lVar4 != null) {
                FUN_18181e970(lVar4,iVar2,(int)fVar8,DAT_181d68370);
                if (*pStatics != 0) {
                  lVar4 = *(int64 *)(*pStatics + 24);
                  if (*pStatics != 0) {
                    lVar1 = *(int64 *)(*pStatics + 24);
                    if (((this.heroSkeleton != null) &&
                        (uVar5 = GameObject.get_transform(this.heroSkeleton,0), lVar1 != null))
                       && (uVar5 = HeroData.GetSkeletonGraphic(lVar1,uVar5,0), lVar4 != null)) {
                      HeroData.SetSkeletonGraphicFaceSlot(lVar4,uVar5,local_res10[0],0xffffff9d,0);
                      if (local_res10[0] != 3) {
                        return;
                      }
                      if (((*pStatics != 0) &&
                          (lVar4 = *(int64 *)(*pStatics + 24), lVar4 != null
                          )) && (lVar4 = *(int64 *)(lVar4 + 224)) != null) {
                        lVar4 = *(int64 *)(lVar4 + 16);
                        if ((((*pStatics != 0) &&
                             (lVar1 = *(int64 *)(*pStatics + 24),
                             lVar1 != null)) && (lVar1 = *(int64 *)(lVar1 + 224)) != null) &&
                           (lVar1 = *(int64 *)(lVar1 + 16)) != null) {
                          if (*(uint32 *)(lVar1 + 24) < 4) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          if (lVar4 != null) {
                            FUN_18181e970(lVar4,6,*(uint32 *)(*(int64 *)(lVar1 + 16) + 44),
                                          DAT_181d68370);
                            if (*pStatics != 0) {
                              lVar4 = *(int64 *)(*pStatics + 24);
                              if (*pStatics != 0) {
                                lVar1 = *(int64 *)(*pStatics + 24);
                                if (((this.heroSkeleton != null) &&
                                    (uVar5 = GameObject.get_transform(this.heroSkeleton,0),
                                    lVar1 != null)) &&
                                   (uVar5 = HeroData.GetSkeletonGraphic(lVar1,uVar5,0), lVar4 != null)) {
                                  HeroData.SetSkeletonGraphicFaceSlot(lVar4,uVar5,6,0xffffff9d,0);
                                  return;
                                }
                              }
                            }
                          }
                        }
                      }
        LAB_180c73274:
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

    // Token : 0x6002154
    // RVA   : 0xC73280   Offset: 0xC71A80   Length: 0x758
    public void FaceSliderChanged(GameObject target)
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar7;
        float fVar8;
        uint uVar9;
        uint[] local_res10 = new uint[4];
        uint[] local_res20 = new uint[2];
        local_res10[0] = 0;
        if (target == null) throw; // [null/range check failed]
        uVar4 = Object.get_name(target,0);
        cVar2 = FUN_1816fd990(uVar4,"SkinColor",0);
        if (!cVar2) {
          uVar4 = Object.get_name();
          iVar3 = Int32.Parse(uVar4,0);
          lVar5 = GameObject.get_transform(target,0);
          if (lVar5 == null) {
        LAB_180c739d3:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = Transform.Find(lVar5,"Id",0);
          if (lVar5 == null) goto LAB_180c739d3;
          uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          plVar6 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
          if (plVar6 == (int64 *)0) goto LAB_180c739d3;
          local_res20[0] = (**(code **)(*plVar6 + 0x418))(plVar6,*(uint64 *)(*plVar6 + 0x420));
          uVar7 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
          uVar7 = String.Format("({0})",uVar7,0);
          LTLocalization.SetText(uVar4,uVar7,0);
          if (((*pStatics == 0) ||
              (lVar5 = *(int64 *)(*pStatics + 24)) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 224)) == null) goto LAB_180c739d3;
          lVar5 = *(int64 *)(lVar5 + 16);
          plVar6 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
          if (plVar6 == (int64 *)0) goto LAB_180c739d3;
          fVar8 = (float)(**(code **)(*plVar6 + 0x418))(plVar6,*(uint64 *)(*plVar6 + 0x420));
          if (lVar5 == null) goto LAB_180c739d3;
          FUN_18181e970(lVar5,iVar3,(int)fVar8,DAT_181d68370);
          if (*pStatics == 0) goto LAB_180c739d3;
          lVar5 = *(int64 *)(*pStatics + 24);
          if (*pStatics == 0) goto LAB_180c739d3;
          lVar1 = *(int64 *)(*pStatics + 24);
          if (this.heroSkeleton == null) goto LAB_180c739d3;
          uVar4 = GameObject.get_transform(this.heroSkeleton,0);
          if (lVar1 == null) goto LAB_180c739d3;
          uVar4 = HeroData.GetSkeletonGraphic(lVar1,uVar4,0);
          if (lVar5 == null) goto LAB_180c739d3;
          HeroData.SetSkeletonGraphicFaceSlot(lVar5,uVar4,iVar3,0xffffff9d,0);
          if (iVar3 == 3) {
            if (((*pStatics == 0) ||
                (lVar5 = *(int64 *)(*pStatics + 24)) == null) ||
               (lVar5 = *(int64 *)(lVar5 + 224)) == null) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5 + 16);
            if (((*pStatics == 0) ||
                (lVar1 = *(int64 *)(*pStatics + 24)) == null) ||
               ((lVar1 = *(int64 *)(lVar1 + 224), lVar1 == null ||
                (lVar1 = *(int64 *)(lVar1 + 16)) == null))) throw; // [null/range check failed]
            if (*(uint32 *)(lVar1 + 24) < 4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar5 == null) throw; // [null/range check failed]
            FUN_18181e970(lVar5,6,*(uint32 *)(*(int64 *)(lVar1 + 16) + 44),DAT_181d68370);
            if (*pStatics == 0) throw; // [null/range check failed]
            lVar5 = *(int64 *)(*pStatics + 24);
            if (*pStatics == 0) throw; // [null/range check failed]
            lVar1 = *(int64 *)(*pStatics + 24);
            if (this.heroSkeleton == null) throw; // [null/range check failed]
            uVar4 = GameObject.get_transform(this.heroSkeleton,0);
            if (lVar1 == null) throw; // [null/range check failed]
            uVar4 = HeroData.GetSkeletonGraphic(lVar1,uVar4,0);
            if (lVar5 == null) throw; // [null/range check failed]
            HeroData.SetSkeletonGraphicFaceSlot(lVar5,uVar4,6,0xffffff9d,0);
          }
        }
        else {
          lVar5 = GameObject.get_transform(target,0);
          if (lVar5 == null) throw; // [null/range check failed]
          lVar5 = Transform.Find(lVar5,"Id",0);
          if (lVar5 == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          plVar6 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          local_res10[0] = (**(code **)(*plVar6 + 0x418))(plVar6,*(uint64 *)(*plVar6 + 0x420));
          uVar7 = Single.ToString(local_res10,"0.##",0);
          uVar7 = String.Format("({0})",uVar7,0);
          LTLocalization.SetText(uVar4,uVar7,0);
          if (*pStatics == 0) throw; // [null/range check failed]
          lVar5 = *(int64 *)(*pStatics + 24);
          plVar6 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          uVar9 = (**(code **)(*plVar6 + 0x418))(plVar6,*(uint64 *)(*plVar6 + 0x420));
          if (lVar5 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar5 + 232) = uVar9;
          if (*pStatics == 0) throw; // [null/range check failed]
          lVar5 = *(int64 *)(*pStatics + 24);
          if (*pStatics == 0) throw; // [null/range check failed]
          lVar1 = *(int64 *)(*pStatics + 24);
          if (this.heroSkeleton == null) throw; // [null/range check failed]
          uVar4 = GameObject.get_transform(this.heroSkeleton,0);
          if (lVar1 == null) throw; // [null/range check failed]
          uVar4 = HeroData.GetSkeletonGraphic(lVar1,uVar4,0);
          if (lVar5 == null) throw; // [null/range check failed]
          HeroData.SetSkeletonGraphicSkinColor(lVar5,uVar4,0);
        }
        lVar5 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar5 != null) {
          uVar4 = *(uint64 *)(lVar5 + 0x1f0);
          NGUITools.PlaySound(uVar4,0x3e4ccccd,0);
          return;
        }
    }

    // Token : 0x6002155
    // RVA   : 0xC74480   Offset: 0xC72C80   Length: 0x254
    public void OutFaceCodeButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        if (this.faceSetting != null) {
          lVar2 = GameObject.get_transform(this.faceSetting,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"FaceCode",0);
            if (lVar2 != null) {
              lVar2 = Component.GetComponent(lVar2,DAT_181d6bcc0);
              if ((*pStatics != 0) &&
                 (lVar1 = *(int64 *)(*pStatics + 24)) != null) {
                uVar3 = HeroData.GenerateFaceCode(lVar1,0);
                if (lVar2 != null) {
                  InputField.set_text(lVar2,uVar3,0);
                  if (this.faceSetting != null) {
                    lVar2 = GameObject.get_transform(this.faceSetting,0);
                    if (lVar2 != null) {
                      uVar3 = Transform.Find(lVar2,"FaceCode",0);
                      DOTween.Complete(uVar3,0,0);
                      if (this.faceSetting != null) {
                        lVar2 = GameObject.get_transform(this.faceSetting,0);
                        if (lVar2 != null) {
                          uVar3 = Transform.Find(lVar2,"FaceCode",0);
                          uVar3 = ShortcutExtensions.DOScale(uVar3,0x3f8ccccd,0x3dcccccd,0);
                          TweenSettingsExtensions.SetLoops(uVar3,2,1,DAT_181d98060);
                          StartMenuController.ShowTextOnMouse(this,"导出成功！",0);
                          plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/PencilWriting",0);
                          plVar5 = (int64 *)0;
                          if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                            plVar5 = plVar4;
                          }
                          NGUITools.PlaySound(plVar5,0);
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

    // Token : 0x6002156
    // RVA   : 0xC73CD0   Offset: 0xC724D0   Length: 0x615
    public void LoadFaceCodeButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        bool cVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        uint[] local_res8 = new uint[2];
        int[] local_res18 = new int[4];
        plVar7 = (int64 *)0;
        local_res18[0] = 0;
        if ((((this.faceSetting == null) ||
             (lVar3 = GameObject.get_transform(this.faceSetting,0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"FaceCode",0)) == null) ||
           (lVar3 = Component.GetComponent(lVar3,DAT_181d6bcc0)) == null) throw; // [null/range check failed]
        lVar3 = *(int64 *)(lVar3 + 0x170);
        cVar2 = false;
        lVar4 = FUN_1800d60b0(DAT_181d7c118,1);
        if (lVar4 == null) throw; // [null/range check failed]
        if (*(int *)(lVar4 + 24) == 0) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        *(uint16 *)(lVar4 + 32) = 47;
        if ((lVar3 == null) || (lVar4 = String.Split(lVar3,lVar4,0)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar4 + 24) == 0) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        cVar1 = Int32.TryParse(*(uint64 *)(lVar4 + 32),local_res18,0);
        if (!cVar1) {
        LAB_180c73fe9:
          StartMenuController.ShowTextOnMouse(this,"代码错误！",0);
          uVar5 = "WrongClick";
        }
        else {
          if (((this.startMenu == null) ||
              (lVar4 = GameObject.get_transform(this.startMenu,0)) == null) ||
             ((lVar4 = Transform.Find(lVar4,"StartMenuRoot",0), lVar4 == null ||
              (lVar4 = Transform.Find(lVar4,"BaseRoot",0)) == null))) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"SexTab",0);
          uVar5 = "Female";
          if (local_res18[0] == 0) {
            uVar5 = "Male";
          }
          if (((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar5,0)) == null) ||
             (lVar4 = Component.GetComponent(lVar4,DAT_181d6da40)) == null) throw; // [null/range check failed]
          Toggle.set_isOn(lVar4,1,0);
          if ((*pStatics == 0) ||
             (lVar4 = *(int64 *)(*pStatics + 24)) == null)
          throw; // [null/range check failed]
          cVar2 = HeroData.LoadFaceCode(lVar4,lVar3,0);
          if (!cVar2) goto LAB_180c73fe9;
          StartMenuController.ShowTextOnMouse(this,"导入成功！",0);
          uVar5 = "NoticeLittle";
        }
        uVar5 = String.Concat("Sound/SoundEffect/",uVar5,0);
        plVar6 = (int64 *)Resources.Load(uVar5,0);
        plVar8 = plVar7;
        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
          plVar8 = plVar6;
        }
        NGUITools.PlaySound(plVar8,0);
        if (!cVar2) {
          return;
        }
        local_res8[0] = 0;
        while( true ) {
          if ((((*pStatics == 0) ||
               (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
              (lVar3 = *(int64 *)(lVar3 + 224)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 16)) == null) throw; // [null/range check failed]
          lVar4 = this.faceSetting;
          if (*(int *)(lVar3 + 24) <= (int)plVar7) break;
          if (lVar4 == null) throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(lVar4,0);
          uVar5 = Int32.ToString(local_res8,0);
          if (lVar3 == null) throw; // [null/range check failed]
          uVar5 = Transform.Find(lVar3,uVar5,0);
          cVar2 = Object.op_Inequality(uVar5);
          if (cVar2) {
            if (this.faceSetting == null) throw; // [null/range check failed]
            lVar3 = GameObject.get_transform(this.faceSetting,0);
            uVar5 = Int32.ToString(local_res8,0);
            if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar5,0)) == null) throw; // [null/range check failed]
            plVar7 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d2c0);
            lVar3 = FUN_18077c280(0);
            if (((lVar3 == null) ||
                (((*(int64 *)(lVar3 + 24) == 0 ||
                  (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 24) + 224)) == null) ||
                 (lVar3 = *(int64 *)(lVar3 + 16)) == null))) ||
               (FUN_1800d6750(lVar3,local_res8[0],DAT_181d68270), plVar7 == (int64 *)0))
            throw; // [null/range check failed]
            (**(code **)(*plVar7 + 0x428))(plVar7);
          }
          local_res8[0] = local_res8[0] + 1;
          plVar7 = (int64 *)(uint64)local_res8[0];
        }
        if (((lVar4 != null) && (lVar3 = GameObject.get_transform(lVar4,0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"SkinColor",0)) != null) {
          plVar7 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d2c0);
          lVar3 = *pStatics;
          if (((lVar3 != null) && (*(int64 *)(lVar3 + 24) != 0)) && (plVar7 != (int64 *)0)) {
            (**(code **)(*plVar7 + 0x428))
                      (plVar7,pStatics,*(uint64 *)(*plVar7 + 0x430));
            return;
          }
        }
    }

    // Token : 0x6002157
    // RVA   : 0xC79920   Offset: 0xC78120   Length: 0xBB
    public void SexButtonClicked(GameObject buttonClicked)
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        byte uVar2;
        ulong uVar3;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 24), buttonClicked != null)) {
          uVar3 = Object.get_name(buttonClicked,0);
          uVar2 = FUN_1816fd990(uVar3,"Female",0);
          if (lVar1 != null) {
            *(uint8 *)(lVar1 + 128) = uVar2;
            StartMenuController.ResetFaceSetting(this,0);
            StartMenuController.ResetPlayerSkeleton(this,0);
            return;
          }
        }
    }

    // Token : 0x6002158
    // RVA   : 0xC753A0   Offset: 0xC73BA0   Length: 0x20A
    public void RandomNameButtonClicked()
    {
        var pStatics_1570 = *(int64*)(DAT_181d81570 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        lVar1 = *(int64 *)(pStatics_e010 + 32);
        if (lVar1 != null) {
          uVar3 = GameDataController.GenerateRandomHeroFamilyName(lVar1,0);
          lVar1 = this.heroFamilyName;
          uVar4 = LTLocalization.GetText(uVar3,0,1,0);
          if (lVar1 != null) {
            InputField.set_text(lVar1,uVar4,0);
            lVar1 = this.heroGivenName;
            lVar5 = *(int64 *)(pStatics_e010 + 32);
            if (((*pStatics_1570 != 0) &&
                (lVar2 = *(int64 *)(*pStatics_1570 + 24)) != null) &&
               (lVar5 != null)) {
              lVar5 = GameDataController.GenerateRandomHeroName
                                (lVar5,*(uint8 *)(lVar2 + 128),uVar3,1,0);
              if (lVar5 != null) {
                uVar3 = String.Replace(lVar5,uVar3,"",0);
                uVar3 = LTLocalization.GetText(uVar3,0,1,0);
                if (lVar1 != null) {
                  InputField.set_text(lVar1,uVar3,0);
                  StartMenuController.ResetPlayerName(this,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002159
    // RVA   : 0xC78690   Offset: 0xC76E90   Length: 0x2BE
    public void ResetPlayerName()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        ushort uVar6;
        ushort uVar7;
        if ((this.heroFamilyName != null) && (this.heroGivenName != null)) {
          uVar2 = String.Concat(*(uint64 *)(this.heroFamilyName + 0x170),
                                 *(uint64 *)(this.heroGivenName + 0x170),0);
          if (**(int **)(DAT_181d4ef00 + 184) == 1) {
            lVar3 = new c.DisplayClass9_0(0);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 16) = uVar2;
              *(uint8 *)(lVar3 + 24) = *(uint8 *)(*(int64 *)(DAT_181d4ef00 + 184) + 128);
              plVar4 = (int64 *)rail_api.RailFactory(0);
              if (plVar4 != (int64 *)0) {
                lVar1 = *plVar4;
                uVar7 = 0;
                if (*(uint16 *)(lVar1 + 0x12a) != 0) {
                  uVar6 = uVar7;
                  do {
                    if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar6 * 16) ==
                        DAT_181d56638) {
                      puVar5 = (uint64 *)
                               ((int64)
                                *(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar6 * 16) * 16
                                + 0x248 + lVar1);
                      goto LAB_180c7884e;
                    }
                    uVar6 = uVar6 + 1;
                  } while (uVar6 < *(uint16 *)(lVar1 + 0x12a));
                }
                puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d56638,17);
        LAB_180c7884e:
                plVar4 = (int64 *)(*(code *)*puVar5)(plVar4,puVar5[1]);
                uVar2 = "";
                if (plVar4 != (int64 *)0) {
                  lVar1 = *plVar4;
                  if (*(uint16 *)(lVar1 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar7 * 16) ==
                          DAT_181d57ca8) {
                        puVar5 = (uint64 *)
                                 ((int64)
                                  *(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar7 * 16) *
                                  16 + 0x1f8 + lVar1);
                        goto LAB_180c788b7;
                      }
                      uVar7 = uVar7 + 1;
                    } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
                  }
                  puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d57ca8,12);
        LAB_180c788b7:
                          // WARNING: Could not recover jumptable at 0x000180c788d8. Too many branches
                          // WARNING: Treating indirect jump as call
                  (*(code *)*puVar5)(plVar4,lVar3,uVar2,puVar5[1]);
                  return;
                }
              }
            }
          }
          else {
            lVar3 = CISFilterWordsSDK.get_Instance(0);
            if (lVar3 != null) {
              uVar2 = CISFilterWordsSDK.FilterReplaceWithChar(lVar3,uVar2,42,0);
              StartMenuController.SetFliteredPlayerName(this,uVar2,0);
              return;
            }
          }
        }
    }

    // Token : 0x600215A
    // RVA   : 0xC743E0   Offset: 0xC72BE0   Length: 0x9A
    public void OnResetPlayerNameFliterResult(RAILEventID id, EventBase data)
    {
        void StartMenuController.OnResetPlayerNameFliterResult
                     (uint64 this,int id,int64 *data)
        {
        if (data != (int64 *)0) {
          if (((int)data[2] == 0) && (id == 0x1f45)) {
            StartMenuController.SetFliteredPlayerName(this,data[8],0);
          }
          return;
        }
    }

    // Token : 0x600215B
    // RVA   : 0xC79780   Offset: 0xC77F80   Length: 0x197
    public void SetFliteredPlayerName(string fliteredTotalName)
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        uint uVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = this.heroFamilyName;
        if (((lVar3 != null) && (*(int64 *)(lVar3 + 0x170) != 0)) && (fliteredTotalName != null)) {
          uVar2 = *(uint32 *)(*(int64 *)(lVar3 + 0x170) + 16);
          uVar4 = String.Substring(fliteredTotalName,0,uVar2,0);
          uVar4 = LTLocalization.GetText(uVar4,0,1,0);
          InputField.set_text(lVar3,uVar4,0);
          lVar3 = this.heroGivenName;
          uVar4 = String.Substring(fliteredTotalName,uVar2,0);
          uVar4 = LTLocalization.GetText(uVar4,0,1,0);
          if (lVar3 != null) {
            InputField.set_text(lVar3,uVar4,0);
            if ((*pStatics != 0) && (this.heroFamilyName != null)) {
              lVar3 = *(int64 *)(*pStatics + 24);
              if (lVar3 != null) {
                *(uint64 *)(lVar3 + 112) = *(uint64 *)(this.heroFamilyName + 0x170);
                if (*pStatics != 0) {
                  lVar3 = *(int64 *)(*pStatics + 24);
                  if ((this.heroFamilyName != null) && (this.heroGivenName != null)) {
                    uVar4 = String.Concat(*(uint64 *)(this.heroFamilyName + 0x170),
                                           *(uint64 *)(this.heroGivenName + 0x170),0);
                    if (lVar3 != null) {
                      puVar1 = (uint64 *)(lVar3 + 104);
                      *puVar1 = uVar4;
                      il2cpp_internal(puVar1,uVar4);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600215C
    // RVA   : 0xC79EE0   Offset: 0xC786E0   Length: 0x1DA
    public GameObject ShowTextOnMouse(string text)
    {
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        uVar3 = this.canvas;
        uVar1 = this.simpleTextPrefab;
        lVar2 = GlobalData.AddChild(uVar3,uVar1,0);
        if (lVar2 != null) {
          uVar3 = GameObject.GetComponent(lVar2,DAT_181da1eb0);
          LTLocalization.SetText(uVar3,text,0);
          lVar4 = GameObject.get_transform(lVar2,0);
          lVar5 = Camera.get_main(0);
          puVar6 = (uint64 *)Input.get_mousePosition(local_18,0);
          if (lVar5 != null) {
            local_20 = *(uint32 *)(puVar6 + 1);
            local_28 = *puVar6;
            puVar6 = (uint64 *)Camera.ScreenToWorldPoint(local_18,lVar5,&local_28,0);
            if (lVar4 != null) {
              local_28 = *puVar6;
              local_20 = *(uint32 *)(puVar6 + 1);
              Transform.set_position(lVar4,&local_28,0);
              lVar4 = GameObject.GetComponent(lVar2,DAT_181d9e228);
              if (lVar4 != null) {
                *(uint8 *)(lVar4 + 24) = 0;
                lVar4 = GameObject.get_transform(lVar2,0);
                puVar6 = (uint64 *)Vector3.get_zero(local_18,0);
                if (lVar4 != null) {
                  local_20 = *(uint32 *)(puVar6 + 1);
                  local_28 = *puVar6;
                  Transform.set_localScale(lVar4,&local_28,0);
                  uVar3 = GameObject.get_transform(lVar2,0);
                  uVar3 = ShortcutExtensions.DOScale(uVar3,0x3f800000,0x3e800000,0);
                  TweenSettingsExtensions.SetEase(uVar3,27,DAT_181d97ca8);
                  return lVar2;
                }
              }
            }
          }
        }
    }

    // Token : 0x600215D
    // RVA   : 0xC73CA0   Offset: 0xC724A0   Length: 0x21
    public int GetPointPlusCost(int nowPoint)
    {
        int FUN_180c73ca0(uint64 this,int nowPoint)
        {
        if (89 < nowPoint) {
          return 999999;
        }
        if (nowPoint < 80) {
          return (69 < nowPoint) + 1;
        }
        return 3;
    }

    // Token : 0x600215E
    // RVA   : 0xC748B0   Offset: 0xC730B0   Length: 0x7CB
    public void PlusMinus(string type, int id, bool plus)
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        bool cVar1;
        int iVar2;
        int iVar3;
        long lVar4;
        float fVar5;
        uint uVar6;
        if (type == null) goto LAB_180c74cb6;
        cVar1 = FUN_1816fd990(type,"Attri",0);
        if (!plus) {
          if (!cVar1) {
            cVar1 = FUN_1816fd990(type,"FightSkill",0);
            if (!cVar1) {
              cVar1 = FUN_1816fd990(type,"LivingSkill",0);
              if (!cVar1) goto LAB_180c74cb6;
              lVar4 = FUN_18077c280(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x160)) == null)
              goto LAB_180c75076;
              uVar6 = FUN_1800d6780(lVar4,id,DAT_181d796d8);
              iVar2 = Mathf.RoundToInt(uVar6,0);
              if (iVar2 < 31) goto LAB_180c74cb6;
              iVar2 = this.leftLivingSkillPoint;
              lVar4 = FUN_18077c280(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x160)) == null)
              goto LAB_180c75076;
              fVar5 = (float)FUN_1800d6780(lVar4,id,DAT_181d796d8);
              iVar3 = Mathf.RoundToInt(fVar5 - 1.0,0);
              if (iVar3 < 90) {
                if (iVar3 < 80) {
                  iVar3 = (69 < iVar3) + 1;
                }
                else {
                  iVar3 = 3;
                }
              }
              else {
                iVar3 = 999999;
              }
              this.leftLivingSkillPoint = iVar3 + iVar2;
              lVar4 = FUN_18077c280(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) goto LAB_180c75076;
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x160);
            }
            else {
              lVar4 = FUN_18077c280(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x148)) == null)
              goto LAB_180c75076;
              uVar6 = FUN_1800d6780(lVar4,id,DAT_181d796d8);
              iVar2 = Mathf.RoundToInt(uVar6,0);
              if (iVar2 < 31) goto LAB_180c74cb6;
              iVar2 = this.leftFightSkillPoint;
              lVar4 = FUN_18077c280(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x148)) == null)
              goto LAB_180c75076;
              fVar5 = (float)FUN_1800d6780(lVar4,id,DAT_181d796d8);
              iVar3 = Mathf.RoundToInt(fVar5 - 1.0,0);
              if (iVar3 < 90) {
                if (iVar3 < 80) {
                  iVar3 = (69 < iVar3) + 1;
                }
                else {
                  iVar3 = 3;
                }
              }
              else {
                iVar3 = 999999;
              }
              this.leftFightSkillPoint = iVar3 + iVar2;
              lVar4 = FUN_18077c280(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) goto LAB_180c75076;
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x148);
            }
          }
          else {
            if (((*pStatics == 0) ||
                (lVar4 = *(int64 *)(*pStatics + 24)) == null) ||
               (lVar4 = *(int64 *)(lVar4 + 0x130)) == null) goto LAB_180c75076;
            if (*(uint32 *)(lVar4 + 24) <= id) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            iVar2 = Mathf.RoundToInt(*(uint32 *)
                                       (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)id * 4),0
                                     );
            if (iVar2 < 31) goto LAB_180c74cb6;
            iVar2 = this.leftAttriPoint;
            lVar4 = FUN_18077c280(0);
            if (((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) ||
               (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x130)) == null)
            goto LAB_180c75076;
            fVar5 = (float)FUN_1800d6780(lVar4,id,DAT_181d796d8);
            iVar3 = Mathf.RoundToInt(fVar5 - 1.0,0);
            if (iVar3 < 90) {
              if (iVar3 < 80) {
                iVar3 = (69 < iVar3) + 1;
              }
              else {
                iVar3 = 3;
              }
            }
            else {
              iVar3 = 999999;
            }
            this.leftAttriPoint = iVar3 + iVar2;
            lVar4 = FUN_18077c280(0);
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) goto LAB_180c75076;
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x130);
          }
          if (lVar4 == null) {
        LAB_180c75076:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar5 = (float)FUN_1800d6780(lVar4,id,DAT_181d796d8);
          fVar5 = fVar5 - 1.0;
        }
        else {
          if (!cVar1) {
            cVar1 = FUN_1816fd990(type,"FightSkill",0);
            if (!cVar1) {
              cVar1 = FUN_1816fd990(type,"LivingSkill",0);
              if (!cVar1) goto LAB_180c74cb6;
              iVar2 = this.leftLivingSkillPoint;
              lVar4 = FUN_18077c280(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x160)) == null)
              goto LAB_180c75076;
              uVar6 = FUN_1800d6780(lVar4,id,DAT_181d796d8);
              iVar3 = Mathf.RoundToInt(uVar6,0);
              if (iVar3 < 90) {
                if (iVar3 < 80) {
                  iVar3 = (69 < iVar3) + 1;
                }
                else {
                  iVar3 = 3;
                }
              }
              else {
                iVar3 = 999999;
              }
              if (iVar2 < iVar3) goto LAB_180c74cb6;
              iVar2 = this.leftLivingSkillPoint;
              lVar4 = FUN_18077c280(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x160)) == null)
              goto LAB_180c75076;
              uVar6 = FUN_1800d6780(lVar4,id,DAT_181d796d8);
              iVar3 = Mathf.RoundToInt(uVar6,0);
              if (iVar3 < 90) {
                if (iVar3 < 80) {
                  iVar3 = (69 < iVar3) + 1;
                }
                else {
                  iVar3 = 3;
                }
              }
              else {
                iVar3 = 999999;
              }
              this.leftLivingSkillPoint = iVar2 - iVar3;
              lVar4 = FUN_18077c280(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) goto LAB_180c75076;
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x160);
            }
            else {
              iVar2 = this.leftFightSkillPoint;
              lVar4 = FUN_18077c280(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x148)) == null)
              goto LAB_180c75076;
              uVar6 = FUN_1800d6780(lVar4,id,DAT_181d796d8);
              iVar3 = Mathf.RoundToInt(uVar6,0);
              if (iVar3 < 90) {
                if (iVar3 < 80) {
                  iVar3 = (69 < iVar3) + 1;
                }
                else {
                  iVar3 = 3;
                }
              }
              else {
                iVar3 = 999999;
              }
              if (iVar2 < iVar3) goto LAB_180c74cb6;
              iVar2 = this.leftFightSkillPoint;
              lVar4 = FUN_18077c280(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x148)) == null)
              goto LAB_180c75076;
              uVar6 = FUN_1800d6780(lVar4,id,DAT_181d796d8);
              iVar3 = Mathf.RoundToInt(uVar6,0);
              if (iVar3 < 90) {
                if (iVar3 < 80) {
                  iVar3 = (69 < iVar3) + 1;
                }
                else {
                  iVar3 = 3;
                }
              }
              else {
                iVar3 = 999999;
              }
              this.leftFightSkillPoint = iVar2 - iVar3;
              lVar4 = FUN_18077c280(0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) goto LAB_180c75076;
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x148);
            }
          }
          else {
            iVar2 = this.leftAttriPoint;
            if (((*pStatics == 0) ||
                (lVar4 = *(int64 *)(*pStatics + 24)) == null) ||
               (lVar4 = *(int64 *)(lVar4 + 0x130)) == null) goto LAB_180c75076;
            if (*(uint32 *)(lVar4 + 24) <= id) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            iVar3 = Mathf.RoundToInt(*(uint32 *)
                                       (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)id * 4),0
                                     );
            if (iVar3 < 90) {
              if (iVar3 < 80) {
                iVar3 = (69 < iVar3) + 1;
              }
              else {
                iVar3 = 3;
              }
            }
            else {
              iVar3 = 999999;
            }
            if (iVar2 < iVar3) goto LAB_180c74cb6;
            iVar2 = this.leftAttriPoint;
            lVar4 = FUN_18077c280(0);
            if (((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) ||
               (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x130)) == null)
            goto LAB_180c75076;
            uVar6 = FUN_1800d6780(lVar4,id,DAT_181d796d8);
            iVar3 = Mathf.RoundToInt(uVar6,0);
            if (iVar3 < 90) {
              if (iVar3 < 80) {
                iVar3 = (69 < iVar3) + 1;
              }
              else {
                iVar3 = 3;
              }
            }
            else {
              iVar3 = 999999;
            }
            this.leftAttriPoint = iVar2 - iVar3;
            lVar4 = FUN_18077c280(0);
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) goto LAB_180c75076;
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 0x130);
          }
          if (lVar4 == null) goto LAB_180c75076;
          fVar5 = (float)FUN_1800d6780(lVar4,id,DAT_181d796d8);
          fVar5 = fVar5 + 1.0;
        }
        FUN_181814d10(lVar4,id,fVar5,DAT_181d79758);
        LAB_180c74cb6:
        this.needRefreshPlayerAttri = 1;
    }

    // Token : 0x600215F
    // RVA   : 0xC746E0   Offset: 0xC72EE0   Length: 0x1C7
    public void PlusMinusButtonClicked(GameObject buttonClicked)
    {
        bool cVar1;
        byte uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        int iVar9;
        uint uVar10;
        cVar1 = FUN_1804625f0(0x130,0);
        iVar9 = 1;
        if (cVar1) {
          iVar9 = 5;
        }
        plVar8 = (int64 *)0;
        plVar7 = plVar8;
        while (buttonClicked != null) {
          lVar4 = GameObject.get_transform(buttonClicked,0);
          if (lVar4 == null) break;
          lVar4 = FUN_180da0f00(lVar4,0);
          if (lVar4 == null) break;
          lVar4 = FUN_180da0f00(lVar4,0);
          if (lVar4 == null) break;
          uVar5 = Object.get_name(lVar4,0);
          lVar4 = GameObject.get_transform(buttonClicked,0);
          if (lVar4 == null) break;
          lVar4 = FUN_180da0f00(lVar4,0);
          if (lVar4 == null) break;
          uVar6 = Object.get_name(lVar4,0);
          uVar3 = Int32.Parse(uVar6,0);
          uVar6 = Object.get_name(buttonClicked,0);
          uVar2 = FUN_1816fd990(uVar6,"Plus",0);
          StartMenuController.PlusMinus(this,uVar5,uVar3,uVar2,0);
          uVar10 = (int)plVar7 + 1;
          plVar7 = (int64 *)(uint64)uVar10;
          if (iVar9 <= (int)uVar10) {
            plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
            if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
              plVar8 = plVar7;
            }
            NGUITools.PlaySound(plVar8,0x3f000000,0);
            return;
          }
        }
    }

    // Token : 0x6002160
    // RVA   : 0xC76850   Offset: 0xC75050   Length: 0x82C
    public void RefreshPlayerAttri()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        uint uVar6;
        uint uVar7;
        long lVar8;
        uint[] local_res8 = new uint[4];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uVar7 = 0;
        local_res18[0] = 0;
        local_res20[0] = 0;
        this.needRefreshPlayerAttri = 0;
        if ((((this.attriRoot != null) &&
             (lVar3 = GameObject.get_transform(this.attriRoot,0)) != null) &&
            (lVar3 = Transform.Find(lVar3,"AttriTitle",0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"Text",0)) != null) {
          uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
          uVar5 = Int32.ToString(this + 128,0);
          uVar5 = String.Concat("属性潜力 ",uVar5,0);
          LTLocalization.SetText(uVar4,uVar5,0);
          if (((this.attriRoot != null) &&
              (lVar3 = GameObject.get_transform(this.attriRoot,0)) != null) &&
             ((lVar3 = Transform.Find(lVar3,"FightSkillTitle",0), lVar3 != null &&
              (lVar3 = Transform.Find(lVar3,"Text",0)) != null))) {
            uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
            uVar5 = Int32.ToString(this + 132,0);
            uVar5 = String.Concat("武学潜力 ",uVar5,0);
            LTLocalization.SetText(uVar4,uVar5,0);
            if (((this.attriRoot != null) &&
                (lVar3 = GameObject.get_transform(this.attriRoot,0)) != null) &&
               ((lVar3 = Transform.Find(lVar3,"LivingSkillTitle",0), lVar3 != null &&
                (lVar3 = Transform.Find(lVar3,"Text",0)) != null))) {
              uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
              uVar5 = Int32.ToString(this + 136,0);
              uVar5 = String.Concat("技艺潜力 ",uVar5,0);
              LTLocalization.SetText(uVar4,uVar5,0);
              local_res8[0] = 0;
              while( true ) {
                uVar2 = local_res8[0];
                if (((*pStatics == 0) ||
                    (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
                   (lVar3 = *(int64 *)(lVar3 + 0x128)) == null) break;
                uVar6 = uVar7;
                if (*(int *)(lVar3 + 24) <= (int)uVar2) goto LAB_180c76cc3;
                if ((this.attriRoot == null) ||
                   (lVar3 = GameObject.get_transform(this.attriRoot,0)) == null)
                break;
                lVar3 = Transform.Find(lVar3,"Attri",0);
                uVar4 = Int32.ToString(local_res8,0);
                if (lVar3 == null) break;
                uVar4 = Transform.Find(lVar3,uVar4,0);
                if ((*pStatics == 0) ||
                   (lVar3 = *(int64 *)(*pStatics + 24)) == null)
                break;
                lVar3 = *(int64 *)(lVar3 + 0x128);
                lVar8 = (int64)(int)local_res8[0];
                if (lVar3 == null) break;
                if (*(uint32 *)(lVar3 + 24) <= local_res8[0]) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar1 = *(uint32 *)(*(int64 *)(lVar3 + 16) + 32 + lVar8 * 4);
                if ((*pStatics == 0) ||
                   (lVar3 = *(int64 *)(*pStatics + 24)) == null)
                break;
                lVar3 = *(int64 *)(lVar3 + 0x130);
                lVar8 = (int64)(int)local_res8[0];
                if (lVar3 == null) break;
                if (*(uint32 *)(lVar3 + 24) <= local_res8[0]) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                StartMenuController.SetAttriDetail
                          (this,uVar4,uVar1,
                           *(uint32 *)(*(int64 *)(lVar3 + 16) + 32 + lVar8 * 4),0);
                local_res8[0] = local_res8[0] + 1;
              }
            }
          }
        }
        LAB_180c77077:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180c76cc3:
        if (((*pStatics == 0) ||
            (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 0x140)) == null) goto LAB_180c77077;
        if (*(int *)(lVar3 + 24) <= (int)uVar6) goto LAB_180c76e95;
        if ((this.attriRoot == null) ||
           (lVar3 = GameObject.get_transform(this.attriRoot,0)) == null)
        goto LAB_180c77077;
        lVar3 = Transform.Find(lVar3,"FightSkill",0);
        uVar4 = Int32.ToString(local_res18,0);
        if (lVar3 == null) goto LAB_180c77077;
        uVar4 = Transform.Find(lVar3,uVar4,0);
        if ((*pStatics == 0) ||
           (lVar3 = *(int64 *)(*pStatics + 24)) == null)
        goto LAB_180c77077;
        lVar3 = *(int64 *)(lVar3 + 0x140);
        lVar8 = (int64)(int)local_res18[0];
        if (lVar3 == null) goto LAB_180c77077;
        if (*(uint32 *)(lVar3 + 24) <= local_res18[0]) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar1 = *(uint32 *)(*(int64 *)(lVar3 + 16) + 32 + lVar8 * 4);
        if ((*pStatics == 0) ||
           (lVar3 = *(int64 *)(*pStatics + 24)) == null)
        goto LAB_180c77077;
        lVar3 = *(int64 *)(lVar3 + 0x148);
        lVar8 = (int64)(int)local_res18[0];
        if (lVar3 == null) goto LAB_180c77077;
        if (*(uint32 *)(lVar3 + 24) <= local_res18[0]) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        StartMenuController.SetAttriDetail
                  (this,uVar4,uVar1,*(uint32 *)(*(int64 *)(lVar3 + 16) + 32 + lVar8 * 4),0);
        local_res18[0] = local_res18[0] + 1;
        uVar6 = local_res18[0];
        goto LAB_180c76cc3;
        LAB_180c76e95:
        if (((*pStatics == 0) ||
            (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 0x158)) == null) goto LAB_180c77077;
        if (*(int *)(lVar3 + 24) <= (int)uVar7) {
          return;
        }
        if ((this.attriRoot == null) ||
           (lVar3 = GameObject.get_transform(this.attriRoot,0)) == null)
        goto LAB_180c77077;
        lVar3 = Transform.Find(lVar3,"LivingSkill",0);
        uVar4 = Int32.ToString(local_res20,0);
        if (lVar3 == null) goto LAB_180c77077;
        uVar4 = Transform.Find(lVar3,uVar4,0);
        if ((*pStatics == 0) ||
           (lVar3 = *(int64 *)(*pStatics + 24)) == null)
        goto LAB_180c77077;
        lVar3 = *(int64 *)(lVar3 + 0x158);
        lVar8 = (int64)(int)local_res20[0];
        if (lVar3 == null) goto LAB_180c77077;
        if (*(uint32 *)(lVar3 + 24) <= local_res20[0]) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar1 = *(uint32 *)(*(int64 *)(lVar3 + 16) + 32 + lVar8 * 4);
        if ((*pStatics == 0) ||
           (lVar3 = *(int64 *)(*pStatics + 24)) == null)
        goto LAB_180c77077;
        lVar3 = *(int64 *)(lVar3 + 0x160);
        lVar8 = (int64)(int)local_res20[0];
        if (lVar3 == null) goto LAB_180c77077;
        if (*(uint32 *)(lVar3 + 24) <= local_res20[0]) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        StartMenuController.SetAttriDetail
                  (this,uVar4,uVar1,*(uint32 *)(*(int64 *)(lVar3 + 16) + 32 + lVar8 * 4),0);
        uVar7 = local_res20[0] + 1;
        local_res20[0] = uVar7;
        goto LAB_180c76e95;
    }

    // Token : 0x6002161
    // RVA   : 0xC78F50   Offset: 0xC77750   Length: 0x36B
    public void SetAttriDetail(Transform parent, float baseNum, float maxNum)
    {
        void StartMenuController.SetAttriDetail
                     (uint64 this,int64 parent,uint32 baseNum,float maxNum)
        {
        int64 lVar1;
        int64 lVar2;
        uint32 extraout_var;
        uint32 extraout_var_00;
        uint64 uVar3;
        uint64 uVar4;
        uint64 uVar5;
        float fVar6;
        uint32 local_res18 [2];
        float local_res20 [2];
        local_res18[0] = baseNum;
        local_res20[0] = maxNum;
        if ((parent != null) && (lVar1 = Transform.Find(parent,"BarBack",0)) != null) {
          lVar1 = Component.GetComponent(lVar1,DAT_181d6c740);
          fVar6 = (float)FUN_1810a8ba0();
          lVar2 = Transform.Find(parent,"BarBack",0);
          if ((lVar2 != null) && (lVar2 = Component.GetComponent(lVar2,DAT_181d6c740)) != null) {
            RectTransform.get_sizeDelta(lVar2,0);
            if (lVar1 != null) {
              RectTransform.set_sizeDelta(lVar1,CONCAT44(extraout_var,fVar6 * 1.5),0);
              lVar1 = Transform.Find(parent,"Bar",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d6c740);
                if ((((float)*(int *)(*(int64 *)(DAT_181d4ef00 + 184) + 248) < local_res20[0]) &&
                    ((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0)) &&
                   (*(int *)(DAT_181d4ef00 + 224) == 0)) {
                  il2cpp_runtime_class_init(DAT_181d4ef00);
                }
                fVar6 = (float)FUN_1810a8ba0();
                lVar2 = Transform.Find(parent,"Bar",0);
                if ((lVar2 != null) && (lVar2 = Component.GetComponent(lVar2,DAT_181d6c740)) != null) {
                  RectTransform.get_sizeDelta(lVar2,0);
                  if (lVar1 != null) {
                    RectTransform.set_sizeDelta(lVar1,CONCAT44(extraout_var_00,fVar6 * 1.5),0);
                    lVar1 = Transform.Find(parent,"Num",0);
                    if (lVar1 != null) {
                      uVar3 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                      uVar4 = Single.ToString(local_res18,"f0",0);
                      uVar5 = Single.ToString(local_res20,"f0",0);
                      uVar4 = String.Concat(uVar4,"/",uVar5,0);
                      LTLocalization.SetText(uVar3,uVar4,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002162
    // RVA   : 0xC755B0   Offset: 0xC73DB0   Length: 0x378
    public void RandomPlayerBaseAttri()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        uint uVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        iVar5 = 0;
        iVar4 = 0;
        while( true ) {
          if (((*pStatics == 0) ||
              (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 0x128)) == null) break;
          if (*(int *)(lVar3 + 24) <= iVar4) {
            iVar4 = 30;
            lVar3 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar3,DAT_181d678f8);
            goto LAB_180c75740;
          }
          if (((*pStatics == 0) ||
              (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 0x128)) == null) break;
          FUN_181814d10(lVar3,iVar4,0,DAT_181d79758);
          iVar4 = iVar4 + 1;
        }
        LAB_180c75923:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180c75740:
        if (((*pStatics == 0) ||
            (lVar1 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar1 = *(int64 *)(lVar1 + 0x128)) == null) goto LAB_180c75923;
        if (*(int *)(lVar1 + 24) <= iVar5) goto LAB_180c757d0;
        if (lVar3 == null) goto LAB_180c75923;
        FUN_181814fa0(lVar3,iVar5);
        iVar5 = iVar5 + 1;
        goto LAB_180c75740;
        LAB_180c757d0:
        iVar4 = iVar4 + -1;
        if (lVar3 == null) goto LAB_180c75923;
        uVar2 = FUN_180d8cf10(0,*(uint32 *)(lVar3 + 24),0);
        if (*(uint32 *)(lVar3 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar2 = lVar3[uVar2];
        if (((*pStatics == 0) ||
            (lVar1 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar1 = *(int64 *)(lVar1 + 0x128)) == null) goto LAB_180c75923;
        if (*(uint32 *)(lVar1 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        FUN_181814d10(lVar1,uVar2,
                      lVar1[uVar2] + 1.0,
                      DAT_181d79758);
        if (((*pStatics == 0) ||
            (lVar1 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar1 = *(int64 *)(lVar1 + 0x128)) == null) goto LAB_180c75923;
        if (*(uint32 *)(lVar1 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        if (10.0 <= lVar1[uVar2]) {
          FUN_181801c10(lVar3,uVar2);
        }
        if (iVar4 < 1) {
          this.needRefreshPlayerAttri = 1;
          return;
        }
        goto LAB_180c757d0;
    }

    // Token : 0x6002163
    // RVA   : 0xC75930   Offset: 0xC74130   Length: 0x378
    public void RandomPlayerBaseFightSkill()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        uint uVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        iVar5 = 0;
        iVar4 = 0;
        while( true ) {
          if (((*pStatics == 0) ||
              (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 0x140)) == null) break;
          if (*(int *)(lVar3 + 24) <= iVar4) {
            iVar4 = 45;
            lVar3 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar3,DAT_181d678f8);
            goto LAB_180c75ac0;
          }
          if (((*pStatics == 0) ||
              (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 0x140)) == null) break;
          FUN_181814d10(lVar3,iVar4,0,DAT_181d79758);
          iVar4 = iVar4 + 1;
        }
        LAB_180c75ca3:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180c75ac0:
        if (((*pStatics == 0) ||
            (lVar1 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar1 = *(int64 *)(lVar1 + 0x140)) == null) goto LAB_180c75ca3;
        if (*(int *)(lVar1 + 24) <= iVar5) goto LAB_180c75b50;
        if (lVar3 == null) goto LAB_180c75ca3;
        FUN_181814fa0(lVar3,iVar5);
        iVar5 = iVar5 + 1;
        goto LAB_180c75ac0;
        LAB_180c75b50:
        iVar4 = iVar4 + -1;
        if (lVar3 == null) goto LAB_180c75ca3;
        uVar2 = FUN_180d8cf10(0,*(uint32 *)(lVar3 + 24),0);
        if (*(uint32 *)(lVar3 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar2 = lVar3[uVar2];
        if (((*pStatics == 0) ||
            (lVar1 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar1 = *(int64 *)(lVar1 + 0x140)) == null) goto LAB_180c75ca3;
        if (*(uint32 *)(lVar1 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        FUN_181814d10(lVar1,uVar2,
                      lVar1[uVar2] + 1.0,
                      DAT_181d79758);
        if (((*pStatics == 0) ||
            (lVar1 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar1 = *(int64 *)(lVar1 + 0x140)) == null) goto LAB_180c75ca3;
        if (*(uint32 *)(lVar1 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        if (10.0 <= lVar1[uVar2]) {
          FUN_181801c10(lVar3,uVar2);
        }
        if (iVar4 < 1) {
          this.needRefreshPlayerAttri = 1;
          return;
        }
        goto LAB_180c75b50;
    }

    // Token : 0x6002164
    // RVA   : 0xC75CB0   Offset: 0xC744B0   Length: 0x378
    public void RandomPlayerBaseLivingSkill()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        uint uVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        iVar5 = 0;
        iVar4 = 0;
        while( true ) {
          if (((*pStatics == 0) ||
              (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 0x158)) == null) break;
          if (*(int *)(lVar3 + 24) <= iVar4) {
            iVar4 = 45;
            lVar3 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar3,DAT_181d678f8);
            goto LAB_180c75e40;
          }
          if (((*pStatics == 0) ||
              (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 0x158)) == null) break;
          FUN_181814d10(lVar3,iVar4,0,DAT_181d79758);
          iVar4 = iVar4 + 1;
        }
        LAB_180c76023:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180c75e40:
        if (((*pStatics == 0) ||
            (lVar1 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar1 = *(int64 *)(lVar1 + 0x158)) == null) goto LAB_180c76023;
        if (*(int *)(lVar1 + 24) <= iVar5) goto LAB_180c75ed0;
        if (lVar3 == null) goto LAB_180c76023;
        FUN_181814fa0(lVar3,iVar5);
        iVar5 = iVar5 + 1;
        goto LAB_180c75e40;
        LAB_180c75ed0:
        iVar4 = iVar4 + -1;
        if (lVar3 == null) goto LAB_180c76023;
        uVar2 = FUN_180d8cf10(0,*(uint32 *)(lVar3 + 24),0);
        if (*(uint32 *)(lVar3 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar2 = lVar3[uVar2];
        if (((*pStatics == 0) ||
            (lVar1 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar1 = *(int64 *)(lVar1 + 0x158)) == null) goto LAB_180c76023;
        if (*(uint32 *)(lVar1 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        FUN_181814d10(lVar1,uVar2,
                      lVar1[uVar2] + 1.0,
                      DAT_181d79758);
        if (((*pStatics == 0) ||
            (lVar1 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar1 = *(int64 *)(lVar1 + 0x158)) == null) goto LAB_180c76023;
        if (*(uint32 *)(lVar1 + 24) <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        if (10.0 <= lVar1[uVar2]) {
          FUN_181801c10(lVar3,uVar2);
        }
        if (iVar4 < 1) {
          this.needRefreshPlayerAttri = 1;
          return;
        }
        goto LAB_180c75ed0;
    }

    // Token : 0x6002165
    // RVA   : 0xC785C0   Offset: 0xC76DC0   Length: 0xCD
    public void ResetPlayerAttri()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        StartMenuController.SetAttriPreset(this,0,0);
        StartMenuController.RandomPlayerBaseAttri(this,0);
        StartMenuController.RandomPlayerBaseFightSkill(this,0);
        StartMenuController.RandomPlayerBaseLivingSkill(this,0);
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 24)) != null) {
          *(uint32 *)(lVar1 + 0x1d0) = 0x42480000;
          if ((*pStatics != 0) &&
             (lVar1 = *(int64 *)(*pStatics + 24)) != null) {
            *(uint32 *)(lVar1 + 0x1d4) = 0x42480000;
            this.needRefreshPlayerAttri = 1;
            return;
          }
        }
    }

    // Token : 0x6002166
    // RVA   : 0xC792C0   Offset: 0xC77AC0   Length: 0x4BC
    public void SetAttriPreset(int presetID)
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        uint uVar6;
        long local_res8;
        lVar5 = (int64)(int)presetID;
        lVar3 = this.attriPresetDatas;
        if (lVar3 != null) {
          if (lVar3.Count <= presetID) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = *(int64 *)(lVar3._items + 32 + lVar5 * 8);
          if (lVar3 != null) {
            lVar1 = this.attriPresetDatas;
            this.leftAttriPoint = *(uint32 *)(lVar3 + 44);
            if (lVar1 != null) {
              if (lVar1.Count <= presetID) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar1._items + 32 + lVar5 * 8);
              if (lVar3 != null) {
                lVar1 = this.attriPresetDatas;
                this.leftFightSkillPoint = *(uint32 *)(lVar3 + 48);
                if (lVar1 != null) {
                  if (lVar1.Count <= presetID) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar3 = *(int64 *)(lVar1._items + 32 + lVar5 * 8);
                  if (lVar3 != null) {
                    uVar6 = 0;
                    local_res8 = 32;
                    uVar4 = 0;
                    this.leftLivingSkillPoint = *(uint32 *)(lVar3 + 52);
                    lVar3 = 32;
                    while( true ) {
                      if (((*pStatics == 0) ||
                          (lVar1 = *(int64 *)(*pStatics + 24), lVar1 == null
                          )) || (lVar1 = *(int64 *)(lVar1 + 0x128)) == null) break;
                      if (lVar1.Count <= (int)uVar4) {
                        uVar4 = 0;
                        lVar3 = 32;
                        goto LAB_180c79512;
                      }
                      if ((*pStatics == 0) ||
                         (lVar1 = *(int64 *)(*pStatics + 24)) == null
                         ) break;
                      lVar2 = this.attriPresetDatas;
                      lVar1 = *(int64 *)(lVar1 + 0x130);
                      if (lVar2 == null) break;
                      if (lVar2.Count <= presetID) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar2 = *(int64 *)(lVar2._items + 32 + lVar5 * 8);
                      if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 56)) == null) break;
                      if (lVar2.Count <= uVar4) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      if (lVar1 == null) break;
                      FUN_181814d10(lVar1,uVar4,*(uint32 *)(lVar2._items + lVar3),
                                    DAT_181d79758);
                      uVar4 = uVar4 + 1;
                      lVar3 = lVar3 + 4;
                    }
                  }
                }
              }
            }
          }
        }
        LAB_180c79777:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180c79512:
        if (((*pStatics == 0) ||
            (lVar1 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar1 = *(int64 *)(lVar1 + 0x140)) == null) goto LAB_180c79777;
        if (lVar1.Count <= (int)uVar4) goto LAB_180c79630;
        if ((*pStatics == 0) ||
           (lVar1 = *(int64 *)(*pStatics + 24)) == null)
        goto LAB_180c79777;
        lVar2 = this.attriPresetDatas;
        lVar1 = *(int64 *)(lVar1 + 0x148);
        if (lVar2 == null) goto LAB_180c79777;
        if (lVar2.Count <= presetID) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar2 = *(int64 *)(lVar2._items + 32 + lVar5 * 8);
        if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 64)) == null) goto LAB_180c79777;
        if (lVar2.Count <= uVar4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (lVar1 == null) goto LAB_180c79777;
        FUN_181814d10(lVar1,uVar4,*(uint32 *)(lVar2._items + lVar3),DAT_181d79758);
        uVar4 = uVar4 + 1;
        lVar3 = lVar3 + 4;
        goto LAB_180c79512;
        LAB_180c79630:
        if (((*pStatics == 0) ||
            (lVar3 = *(int64 *)(*pStatics + 24)) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 0x158)) == null) goto LAB_180c79777;
        if (lVar3.Count <= (int)uVar6) {
          this.needRefreshPlayerAttri = 1;
          return;
        }
        if ((*pStatics == 0) ||
           (lVar3 = *(int64 *)(*pStatics + 24)) == null)
        goto LAB_180c79777;
        lVar1 = this.attriPresetDatas;
        lVar3 = *(int64 *)(lVar3 + 0x160);
        if (lVar1 == null) goto LAB_180c79777;
        if (lVar1.Count <= presetID) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar1 = *(int64 *)(lVar1._items + 32 + lVar5 * 8);
        if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 72)) == null) goto LAB_180c79777;
        if (lVar1.Count <= uVar6) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (lVar3 == null) goto LAB_180c79777;
        FUN_181814d10(lVar3,uVar6,*(uint32 *)(lVar1._items + local_res8),DAT_181d79758)
        ;
        uVar6 = uVar6 + 1;
        local_res8 = local_res8 + 4;
        goto LAB_180c79630;
    }

    // Token : 0x6002167
    // RVA   : 0xC729F0   Offset: 0xC711F0   Length: 0x253
    public void EvilChaosSliderChanged(GameObject target)
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        float fVar5;
        if (target == null) throw; // [null/range check failed]
        uVar3 = Object.get_name(target,0);
        cVar2 = FUN_1816fd990(uVar3,"Evil",0);
        if (!cVar2) {
          if (*pStatics == 0) throw; // [null/range check failed]
          lVar1 = *(int64 *)(*pStatics + 24);
          plVar4 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          fVar5 = (float)(**(code **)(*plVar4 + 0x418))(plVar4,*(uint64 *)(*plVar4 + 0x420));
          if (lVar1 == null) throw; // [null/range check failed]
          *(float *)(lVar1 + 0x1d4) = fVar5 * 100.0;
        }
        else {
          if (*pStatics == 0) throw; // [null/range check failed]
          lVar1 = *(int64 *)(*pStatics + 24);
          plVar4 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          fVar5 = (float)(**(code **)(*plVar4 + 0x418))(plVar4,*(uint64 *)(*plVar4 + 0x420));
          if (lVar1 == null) throw; // [null/range check failed]
          *(float *)(lVar1 + 0x1d0) = fVar5 * 100.0;
        }
        StartMenuController.RefreshEvilChaosSlider(this,0);
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar1 != null) {
          uVar3 = *(uint64 *)(lVar1 + 0x1f0);
          NGUITools.PlaySound(uVar3,0x3e4ccccd,0);
          return;
        }
    }

    // Token : 0x6002168
    // RVA   : 0xC765F0   Offset: 0xC74DF0   Length: 0x25B
    public void RefreshEvilChaosSlider()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        uint uVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        uVar2 = this.evilText;
        if ((*pStatics != 0) &&
           (lVar3 = *(int64 *)(*pStatics + 24)) != null) {
          uVar1 = *(uint32 *)(lVar3 + 0x1d0);
          uVar4 = GlobalData.GetEvilText(uVar1,0);
          if ((*pStatics != 0) &&
             (lVar3 = *(int64 *)(*pStatics + 24)) != null) {
            local_res8[0] = Mathf.FloorToInt(*(uint32 *)(lVar3 + 0x1d0),0);
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            uVar5 = String.Format("({0})",uVar5,0);
            uVar4 = String.Concat(uVar4,uVar5,0);
            LTLocalization.SetText(uVar2,uVar4,0);
            uVar2 = this.chaosText;
            if ((*pStatics != 0) &&
               (lVar3 = *(int64 *)(*pStatics + 24)) != null) {
              uVar4 = GlobalData.GetChaosText(*(uint32 *)(lVar3 + 0x1d4),0);
              if ((*pStatics != 0) &&
                 (lVar3 = *(int64 *)(*pStatics + 24)) != null) {
                local_res18[0] = Mathf.FloorToInt(*(uint32 *)(lVar3 + 0x1d4),0);
                uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                uVar5 = String.Format("({0})",uVar5,0);
                uVar4 = String.Concat(uVar4,uVar5,0);
                LTLocalization.SetText(uVar2,uVar4,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002169
    // RVA   : 0xC723B0   Offset: 0xC70BB0   Length: 0x176
    public void CustomDifficultySliderChanged(GameObject target)
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        uint uVar2;
        ulong uVar3;
        float fVar6;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 64), target != null)) {
          uVar3 = Object.get_name(target,0);
          uVar2 = Int32.Parse(uVar3,0);
          plVar4 = (int64 *)GameObject.GetComponent(target,DAT_181da1730);
          if (plVar4 != (int64 *)0) {
            fVar6 = (float)(**(code **)(*plVar4 + 0x418))(plVar4,*(uint64 *)(*plVar4 + 0x420));
            if (lVar1 != null) {
              CustomDifficultyData.SetDifficultyLv(lVar1,uVar2,(int)fVar6,0);
              StartMenuController.RefreshDifficultyTotalLv(this,0);
              StartMenuController.RefreshDifficultySliderText(this,target,0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
              return;
            }
          }
        }
    }

    // Token : 0x600216A
    // RVA   : 0xC762A0   Offset: 0xC74AA0   Length: 0x34D
    public void RefreshDifficultyTotalLv()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar5;
        ulong uVar6;
        uint[] local_res8 = new uint[2];
        if (((this.customDifficultyRoot != null) &&
            (lVar3 = GameObject.get_transform(this.customDifficultyRoot,0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"DifficultyTotalLv",0)) != null) {
          plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
          if (((*pStatics != 0) &&
              (lVar3 = *(int64 *)(*pStatics + 64)) != null) &&
             (uVar5 = CustomDifficultyData.GetTotalDifficultyLvDescribe(lVar3,0),
             plVar4 != (int64 *)0)) {
            (**(code **)(*plVar4 + 0x5e8))(plVar4,uVar5,*(uint64 *)(*plVar4 + 0x5f0));
            if (((this.customDifficultyRoot != null) &&
                (lVar3 = GameObject.get_transform(this.customDifficultyRoot,0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"Achievement",0)) != null) {
              plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
              if ((*pStatics != 0) &&
                 (lVar3 = *(int64 *)(*pStatics + 64)) != null) {
                cVar1 = CustomDifficultyData.CanUnlockAchievement(lVar3,0);
                uVar5 = "[不可获取成就]";
                if (cVar1) {
                  uVar5 = "[可获取成就]";
                }
                if (plVar4 != (int64 *)0) {
                  (**(code **)(*plVar4 + 0x5e8))(plVar4,uVar5,*(uint64 *)(*plVar4 + 0x5f0));
                  if ((*pStatics != 0) &&
                     (lVar3 = *(int64 *)(*pStatics + 64)) != null) {
                    iVar2 = CustomDifficultyData.GetExtraMaxTagNum(lVar3,0);
                    if (iVar2 == 0) {
                      return;
                    }
                    if ((((this.customDifficultyRoot != null) &&
                         (lVar3 = GameObject.get_transform(this.customDifficultyRoot,0)) != null)
                        && (lVar3 = Transform.Find(lVar3,"Achievement",0)) != null) &&
                       (plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0),
                       plVar4 != (int64 *)0)) {
                      uVar5 = (**(code **)(*plVar4 + 0x5d8))(plVar4,*(uint64 *)(*plVar4 + 0x5e0));
                      if ((*pStatics != 0) &&
                         (lVar3 = *(int64 *)(*pStatics + 64)) != null
                         ) {
                        local_res8[0] = CustomDifficultyData.GetExtraMaxTagNum(lVar3,0);
                        uVar6 = Int32.ToString(local_res8,"+0;-0;0",0);
                        uVar6 = String.Format("\n[天赋数上限{0}]",uVar6,0);
                        uVar5 = String.Concat(uVar5,uVar6,0);
                        (**(code **)(*plVar4 + 0x5e8))(plVar4,uVar5,*(uint64 *)(*plVar4 + 0x5f0));
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

    // Token : 0x600216B
    // RVA   : 0xC76030   Offset: 0xC74830   Length: 0x268
    public void RefreshDifficultySliderText(GameObject target)
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        long lVar2;
        uint uVar3;
        int iVar4;
        long lVar5;
        ulong uVar7;
        if (((target != null) && (lVar5 = GameObject.get_transform(target,0)) != null) &&
           (lVar5 = Transform.Find(lVar5,"Text",0)) != null) {
          plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d6d8c0);
          if (*pStatics != 0) {
            lVar5 = *(int64 *)(*pStatics + 64);
            uVar7 = Object.get_name(target,0);
            uVar3 = Int32.Parse(uVar7,0);
            if ((lVar5 != null) &&
               (uVar7 = CustomDifficultyData.GetDescribe(lVar5,uVar3,0), plVar6 != (int64 *)0)) {
              (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar7,*(uint64 *)(*plVar6 + 0x5f0));
              uVar7 = Object.get_name(target,0);
              iVar4 = Int32.Parse(uVar7,0);
              if (iVar4 != 9) {
                return;
              }
              lVar5 = GameObject.get_transform(target,0);
              if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Text",0)) != null) {
                lVar5 = Component.GetComponent(lVar5,DAT_181d6ccc0);
                lVar1 = *(int64 *)(*(int64 *)(DAT_181d96518 + 184) + 24);
                if (*pStatics != 0) {
                  lVar2 = *(int64 *)(*pStatics + 64);
                  uVar7 = Object.get_name(target,0);
                  uVar3 = Int32.Parse(uVar7,0);
                  if ((lVar2 != null) &&
                     (iVar4 = CustomDifficultyData.GetDifficultyLv(lVar2,uVar3,0), lVar1 != null)) {
                    if (*(uint32 *)(lVar1 + 24) <= iVar4 + 3U) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (lVar5 != null) {
                      *(uint64 *)(lVar5 + 24) =
                           *(uint64 *)
                            (*(int64 *)(lVar1 + 16) + 32 + (int64)(int)(iVar4 + 3U) * 8);
                      il2cpp_internal();
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600216C
    // RVA   : 0xC742F0   Offset: 0xC72AF0   Length: 0xE2
    public void NatureDropDownValueChange()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        long lVar1;
        if (((*pStatics != 0) && (this.natureDropDown != null)) &&
           (lVar1 = *(int64 *)(*pStatics + 24)) != null) {
          *(uint32 *)(lVar1 + 0x1d8) = *(uint32 *)(this.natureDropDown + 0x120);
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
          plVar3 = (int64 *)0;
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
            plVar3 = plVar2;
          }
          NGUITools.PlaySound(plVar3,0);
          return;
        }
    }

    // Token : 0x600216D
    // RVA   : 0xC72160   Offset: 0xC70960   Length: 0x247
    public void ClothDropDownValueChange()
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        if (*pStatics != 0) {
          lVar2 = *(int64 *)(*pStatics + 24);
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
          if (((lVar3 != null) && (this.clothDropDown != null)) &&
             (lVar3 = *(int64 *)(lVar3 + 0x1a8)) != null) {
            uVar1 = *(uint32 *)(this.clothDropDown + 0x120);
            if (*(uint32 *)(lVar3 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = lVar3[uVar1];
            if ((lVar3 != null) && (lVar2 != null)) {
              *(uint32 *)(lVar2 + 240) = *(uint32 *)(lVar3 + 16);
              if (*pStatics != 0) {
                lVar2 = *(int64 *)(*pStatics + 24);
                if (this.heroSkeleton != null) {
                  uVar4 = GameObject.get_transform(this.heroSkeleton,0);
                  if (lVar2 != null) {
                    HeroData.SetSkeletonGraphic(lVar2,uVar4,0xffffff9d,this.tryClothSkinLv,0)
                    ;
                    plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Bag",0);
                    plVar6 = (int64 *)0;
                    if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                      plVar6 = plVar5;
                    }
                    NGUITools.PlaySound(plVar6,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600216E
    // RVA   : 0xC7C230   Offset: 0xC7AA30   Length: 0x16D
    public void ToggleLvValueChange(GameObject obj)
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        if ((obj != null) && (lVar2 = GameObject.GetComponent(obj,DAT_181da2130)) != null) {
          if (*(char *)(lVar2 + 0x118) == false) {
            return;
          }
          uVar3 = Object.get_name(obj,0);
          uVar1 = Int32.Parse(uVar3,0);
          this.tryClothSkinLv = uVar1;
          if (*pStatics != 0) {
            lVar2 = *(int64 *)(*pStatics + 24);
            if ((this.heroSkeleton != null) &&
               (uVar3 = GameObject.get_transform(this.heroSkeleton,0), lVar2 != null)) {
              HeroData.SetSkeletonGraphic(lVar2,uVar3,0xffffff9d,this.tryClothSkinLv,0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Bag",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
              return;
            }
          }
        }
    }

    // Token : 0x600216F
    // RVA   : 0xC72790   Offset: 0xC70F90   Length: 0x252
    public void EndingTagClicked(GameObject buttonClicked)
    {
        uint uVar1;
        long lVar2;
        ulong uVar5;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (buttonClicked != null) {
          lVar2 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if (lVar2 != null) {
            if (*(char *)(lVar2 + 0x118) != false) {
              lVar2 = **(int64 **)(DAT_181d81570 + 184);
              uVar5 = Object.get_name(buttonClicked,0);
              uVar1 = Int32.Parse(uVar5,0);
              if (lVar2 != null) {
                *(uint32 *)(lVar2 + 48) = uVar1;
                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Success",0);
                plVar6 = (int64 *)0;
                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                  plVar6 = plVar3;
                }
                NGUITools.PlaySound(plVar6,0);
                lVar2 = GameObject.get_transform(buttonClicked,0);
                if (lVar2 != null) {
                  lVar2 = Transform.Find(lVar2,"Label",0);
                  if (lVar2 != null) {
                    plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0);
                    local_28 = 0;
                    uStack_20 = 0;
                    Color.ctor(&local_28,0x3f800000,0x3f41c1c2,0x3e6ceced,0);
                    if (plVar3 != (int64 *)0) {
                      local_18 = (uint32)local_28;
                      uStack_14 = local_28._4_4_;
                      uStack_10 = (uint32)uStack_20;
                      uStack_c = uStack_20._4_4_;
                      (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
                      return;
                    }
                  }
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar2 = GameObject.get_transform(buttonClicked,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"Label",0);
              if (lVar2 != null) {
                plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0);
                puVar4 = (uint64 *)FUN_181098a50(&local_18,0);
                if (plVar3 != (int64 *)0) {
                  local_28 = *puVar4;
                  uStack_20 = puVar4[1];
                  (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_28,*(uint64 *)(*plVar3 + 0x2b0));
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002170
    // RVA   : 0xC71500   Offset: 0xC6FD00   Length: 0x882
    public void BirthSettingClicked(GameObject buttonClicked)
    {
        var pStatics = *(int64*)(DAT_181d81570 + 184);
        bool cVar1;
        int iVar2;
        uint uVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        long lVar10;
        ulong in_stack_ffffffffffffff98;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong uStack_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uVar3 = (uint32)((uint64)in_stack_ffffffffffffff98 >> 32);
        if (buttonClicked == null) goto LAB_180c71d6b;
        lVar5 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
        if (lVar5 == null) goto LAB_180c71d6b;
        if (*(char *)(lVar5 + 0x118) == false) {
          lVar5 = GameObject.get_transform(buttonClicked,0);
          if (lVar5 == null) goto LAB_180c71d6b;
          lVar5 = FUN_180da0f00(lVar5,0);
          if (lVar5 == null) goto LAB_180c71d6b;
          uVar6 = Object.get_name(lVar5,0);
          iVar2 = Int32.Parse(uVar6,0);
          if (iVar2 != 0) {
            lVar5 = GameObject.get_transform(buttonClicked,0);
            if (lVar5 == null) goto LAB_180c71d6b;
            lVar5 = Transform.Find(lVar5,"Label",0);
            if (lVar5 == null) goto LAB_180c71d6b;
            plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d6d8c0);
            puVar8 = (uint64 *)FUN_181098a50(&local_38,0);
            if (plVar7 == (int64 *)0) goto LAB_180c71d6b;
            local_48 = *puVar8;
            uStack_40 = puVar8[1];
            puVar8 = &local_48;
            goto LAB_180c71d2c;
          }
          lVar5 = GameObject.get_transform(buttonClicked,0);
          if (lVar5 == null) {
        LAB_180c71d77:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = Transform.Find(lVar5,"Background",0);
          if (lVar5 == null) goto LAB_180c71d77;
          plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40);
          uVar6 = CONCAT44(uVar3,0x3f19999a);
          local_58 = 0;
          uStack_50 = 0;
          FUN_1809981e0(&local_58,0x3f000000,0x3f000000,0x3f000000,uVar6,0);
          uVar3 = (uint32)((uint64)uVar6 >> 32);
          if (plVar7 == (int64 *)0) goto LAB_180c71d77;
          local_38 = (uint32)local_58;
          uStack_34 = local_58._4_4_;
          uStack_30 = (uint32)uStack_50;
          uStack_2c = uStack_50._4_4_;
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_38,*(uint64 *)(*plVar7 + 0x2b0));
          lVar5 = GameObject.get_transform(buttonClicked,0);
          if (lVar5 == null) goto LAB_180c71d77;
          lVar5 = Transform.Find(lVar5,"Image",0);
          if (lVar5 == null) goto LAB_180c71d77;
          plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40);
          uVar6 = CONCAT44(uVar3,0x3f19999a);
          local_48 = 0;
          uStack_40 = 0;
          FUN_1809981e0(&local_48,0x3f800000,0x3f800000,0x3f800000,uVar6,0);
          uVar3 = (uint32)((uint64)uVar6 >> 32);
          if (plVar7 == (int64 *)0) goto LAB_180c71d77;
          local_38 = (uint32)local_48;
          uStack_34 = local_48._4_4_;
          uStack_30 = (uint32)uStack_40;
          uStack_2c = uStack_40._4_4_;
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_38,*(uint64 *)(*plVar7 + 0x2b0));
          lVar5 = GameObject.get_transform(buttonClicked,0);
          if (lVar5 == null) goto LAB_180c71d77;
          uVar6 = Transform.Find(lVar5,"Cloth",0);
          cVar1 = Object.op_Inequality(uVar6,0,0);
          if (cVar1) {
            lVar5 = GameObject.get_transform(buttonClicked,0);
            if (lVar5 == null) {
        LAB_180c71d71:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar5 = Transform.Find(lVar5,"Cloth",0);
            if (lVar5 == null) goto LAB_180c71d71;
            plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40);
            local_48 = 0;
            uStack_40 = 0;
            FUN_1809981e0(&local_48,0x3f000000,0x3f000000,0x3f000000,CONCAT44(uVar3,0x3f000000),0);
            if (plVar7 == (int64 *)0) goto LAB_180c71d71;
            local_38 = (uint32)local_48;
            uStack_34 = local_48._4_4_;
            uStack_30 = (uint32)uStack_40;
            uStack_2c = uStack_40._4_4_;
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_38,*(uint64 *)(*plVar7 + 0x2b0));
          }
          lVar5 = GameObject.get_transform(buttonClicked,0);
          if (lVar5 == null) goto LAB_180c71d6b;
          lVar5 = Transform.Find(lVar5,"Label",0);
          if (lVar5 == null) goto LAB_180c71d6b;
          plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d6d8c0);
          puVar9 = (uint32 *)FUN_1810988d0(&local_38,0);
        LAB_180c71d1c:
          if (plVar7 == (int64 *)0) {
        LAB_180c71d6b:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_38 = *puVar9;
          uStack_34 = puVar9[1];
          uStack_30 = puVar9[2];
          uStack_2c = puVar9[3];
        }
        else {
          if (*pStatics == 0) goto LAB_180c71d6b;
          lVar5 = *(int64 *)(*pStatics + 32);
          lVar10 = GameObject.get_transform(buttonClicked,0);
          if (lVar10 == null) goto LAB_180c71d6b;
          lVar10 = FUN_180da0f00(lVar10,0);
          if (lVar10 == null) goto LAB_180c71d6b;
          uVar6 = Object.get_name(lVar10,0);
          uVar3 = Int32.Parse(uVar6,0);
          uVar6 = Object.get_name(buttonClicked,0);
          uVar4 = Int32.Parse(uVar6,0);
          if (lVar5 == null) goto LAB_180c71d6b;
          FUN_18181e970(lVar5,uVar3,uVar4,DAT_181d68370);
          lVar5 = GameObject.get_transform(buttonClicked,0);
          if (lVar5 == null) goto LAB_180c71d6b;
          lVar5 = FUN_180da0f00(lVar5,0);
          if (lVar5 == null) goto LAB_180c71d6b;
          uVar6 = Object.get_name(lVar5,0);
          iVar2 = Int32.Parse(uVar6,0);
          uVar6 = "WoodButton";
          if (iVar2 != 0) {
            uVar6 = "TabButton";
          }
          uVar6 = String.Concat("Sound/SoundEffect/Button/",uVar6,0);
          plVar7 = (int64 *)Resources.Load(uVar6,0);
          plVar11 = (int64 *)0;
          if ((plVar7 != (int64 *)0) && (plVar11 = (int64 *)0, *plVar7 == DAT_181d8a228)) {
            plVar11 = plVar7;
          }
          NGUITools.PlaySound(plVar11,0);
          lVar5 = GameObject.get_transform(buttonClicked,0);
          if (lVar5 == null) goto LAB_180c71d6b;
          lVar5 = FUN_180da0f00(lVar5,0);
          if (lVar5 == null) goto LAB_180c71d6b;
          uVar6 = Object.get_name(lVar5,0);
          iVar2 = Int32.Parse(uVar6,0);
          if (iVar2 == 0) {
            lVar5 = GameObject.get_transform(buttonClicked,0);
            if (lVar5 == null) goto LAB_180c71d6b;
            lVar5 = Transform.Find(lVar5,"Background",0);
            if (lVar5 == null) goto LAB_180c71d6b;
            plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40);
            puVar9 = (uint32 *)FUN_181098a50(&local_38,0);
            if (plVar7 == (int64 *)0) goto LAB_180c71d6b;
            local_38 = *puVar9;
            uStack_34 = puVar9[1];
            uStack_30 = puVar9[2];
            uStack_2c = puVar9[3];
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_38,*(uint64 *)(*plVar7 + 0x2b0));
            lVar5 = GameObject.get_transform(buttonClicked,0);
            if (lVar5 == null) goto LAB_180c71d6b;
            lVar5 = Transform.Find(lVar5,"Image",0);
            if (lVar5 == null) goto LAB_180c71d6b;
            plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40);
            puVar9 = (uint32 *)FUN_181098a50(&local_38,0);
            if (plVar7 == (int64 *)0) goto LAB_180c71d6b;
            local_38 = *puVar9;
            uStack_34 = puVar9[1];
            uStack_30 = puVar9[2];
            uStack_2c = puVar9[3];
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_38,*(uint64 *)(*plVar7 + 0x2b0));
            lVar5 = GameObject.get_transform(buttonClicked,0);
            if (lVar5 == null) goto LAB_180c71d6b;
            uVar6 = Transform.Find(lVar5,"Cloth",0);
            cVar1 = Object.op_Inequality(uVar6,0,0);
            if (cVar1) {
              lVar5 = GameObject.get_transform(buttonClicked,0);
              if (lVar5 == null) goto LAB_180c71d6b;
              lVar5 = Transform.Find(lVar5,"Cloth",0);
              if (lVar5 == null) goto LAB_180c71d6b;
              plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d6bc40);
              puVar9 = (uint32 *)FUN_1810988d0(&local_38,0);
              if (plVar7 == (int64 *)0) goto LAB_180c71d6b;
              local_38 = *puVar9;
              uStack_34 = puVar9[1];
              uStack_30 = puVar9[2];
              uStack_2c = puVar9[3];
              (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_38,*(uint64 *)(*plVar7 + 0x2b0));
            }
            lVar5 = GameObject.get_transform(buttonClicked,0);
            if (lVar5 == null) goto LAB_180c71d6b;
            lVar5 = Transform.Find(lVar5,"Label",0);
            if (lVar5 == null) goto LAB_180c71d6b;
            plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d6d8c0);
            puVar9 = (uint32 *)Color.get_black(&local_38,0);
            goto LAB_180c71d1c;
          }
          lVar5 = GameObject.get_transform(buttonClicked,0);
          if (lVar5 == null) {
        LAB_180c71d7d:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = Transform.Find(lVar5,"Label",0);
          if (lVar5 == null) goto LAB_180c71d7d;
          plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d6d8c0);
          local_48 = 0;
          uStack_40 = 0;
          Color.ctor(&local_48,0x3f800000,0x3f41c1c2,0x3e6ceced,0);
          if (plVar7 == (int64 *)0) goto LAB_180c71d7d;
          local_38 = (uint32)local_48;
          uStack_34 = local_48._4_4_;
          uStack_30 = (uint32)uStack_40;
          uStack_2c = uStack_40._4_4_;
        }
        puVar8 = (uint64 *)&local_38;
        LAB_180c71d2c:
        (**(code **)(*plVar7 + 0x2a8))(plVar7,puVar8,*(uint64 *)(*plVar7 + 0x2b0));
    }

    // Token : 0x6002171
    // RVA   : 0xC72530   Offset: 0xC70D30   Length: 0x252
    public void DifficultyButtonClicked(GameObject buttonClicked)
    {
        uint uVar1;
        long lVar2;
        ulong uVar5;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (buttonClicked != null) {
          lVar2 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if (lVar2 != null) {
            if (*(char *)(lVar2 + 0x118) != false) {
              lVar2 = **(int64 **)(DAT_181d81570 + 184);
              uVar5 = Object.get_name(buttonClicked,0);
              uVar1 = Int32.Parse(uVar5,0);
              if (lVar2 != null) {
                *(uint32 *)(lVar2 + 40) = uVar1;
                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
                plVar6 = (int64 *)0;
                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
                  plVar6 = plVar3;
                }
                NGUITools.PlaySound(plVar6,0);
                lVar2 = GameObject.get_transform(buttonClicked,0);
                if (lVar2 != null) {
                  lVar2 = Transform.Find(lVar2,"Label",0);
                  if (lVar2 != null) {
                    plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0);
                    local_28 = 0;
                    uStack_20 = 0;
                    Color.ctor(&local_28,0x3f800000,0x3f41c1c2,0x3e6ceced,0);
                    if (plVar3 != (int64 *)0) {
                      local_18 = (uint32)local_28;
                      uStack_14 = local_28._4_4_;
                      uStack_10 = (uint32)uStack_20;
                      uStack_c = uStack_20._4_4_;
                      (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
                      return;
                    }
                  }
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar2 = GameObject.get_transform(buttonClicked,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"Label",0);
              if (lVar2 != null) {
                plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0);
                puVar4 = (uint64 *)FUN_181098a50(&local_18,0);
                if (plVar3 != (int64 *)0) {
                  local_28 = *puVar4;
                  uStack_20 = puVar4[1];
                  (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_28,*(uint64 *)(*plVar3 + 0x2b0));
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002172
    // RVA   : 0xC739E0   Offset: 0xC721E0   Length: 0x2B3
    public void GameModeButtonClicked(GameObject buttonClicked)
    {
        var pStatics_1570 = *(int64*)(DAT_181d81570 + 184);
        var pStatics_34f0 = *(int64*)(DAT_181d834f0 + 184);
        uint uVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (buttonClicked != null) {
          lVar3 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if (lVar3 != null) {
            if (*(char *)(lVar3 + 0x118) != false) {
              lVar3 = *pStatics_1570;
              uVar4 = Object.get_name(buttonClicked,0);
              uVar1 = Int32.Parse(uVar4,0);
              if (lVar3 == null) throw; // [null/range check failed]
              *(uint32 *)(lVar3 + 44) = uVar1;
              plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/WoodButton",0);
              plVar7 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                plVar7 = plVar5;
              }
              NGUITools.PlaySound(plVar7,0);
              if (*pStatics_1570 == 0) throw; // [null/range check failed]
              if (*(int *)(*pStatics_1570 + 44) == 1) {
                lVar3 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
                if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 16)) == null) throw; // [null/range check failed]
                iVar2 = PlayerPrefDictionary.GetInt(lVar3,"NewGameTime",0);
                if (iVar2 < 1) {
                  if (*pStatics_34f0 == 0) throw; // [null/range check failed]
                  SureMenu.CallSureMenu(*pStatics_34f0,"剧情模式有更完整的教程引导，初次游玩建议选择剧情模式以获得最佳体验。",0,0,0,0,0);
                }
              }
            }
            lVar3 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
            if (lVar3 != null) {
              plVar5 = *(int64 **)(lVar3 + 216);
              lVar3 = GameObject.GetComponent(buttonClicked);
              if (lVar3 != null) {
                if (*(char *)(lVar3 + 0x118) == false) {
                  puVar6 = (uint32 *)FUN_1810988d0(&local_18);
                }
                else {
                  puVar6 = (uint32 *)FUN_181098a50();
                }
                local_18 = *puVar6;
                uStack_14 = puVar6[1];
                uStack_10 = puVar6[2];
                uStack_c = puVar6[3];
                if (plVar5 != (int64 *)0) {
                  (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_18,*(uint64 *)(*plVar5 + 0x2b0));
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002173
    // RVA   : 0xC7C780   Offset: 0xC7AF80   Length: 0x2F
    public void /*ctor*/()
    {
        void FUN_180c7c780(int64 this)
        {
        this.leftAttriPoint = 60;
        this.leftFightSkillPoint = 90;
        this.leftLivingSkillPoint = 90;
        this.tryClothSkinLv = 5;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6002174
    // RVA   : 0xC7C5F0   Offset: 0xC7ADF0   Length: 0x186
    private static void /*cctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"武学",DAT_181d7c3d0);
          FUN_181827900(lVar1,"高级",DAT_181d7c3d0);
          FUN_181827900(lVar1,"技艺",DAT_181d7c3d0);
          FUN_181827900(lVar1,"天生",DAT_181d7c3d0);
          FUN_181827900(lVar1,"志向",DAT_181d7c3d0);
          FUN_181827900(lVar1,"喜好",DAT_181d7c3d0);
          FUN_181827900(lVar1,"战法",DAT_181d7c3d0);
          plVar2 = (int64 *)(*(int64 *)(DAT_181d815f0 + 184) + 8);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

    // Token : 0x6002175
    // RVA   : 0xA2D8E0   Offset: 0xA2C0E0   Length: 0x20
    private void <UnshowStartMenu>b__40_0()
    {
        if (this.startMenu != null) {
          GameObject.SetActive(this.startMenu,0,0);
          return;
        }
    }

}
