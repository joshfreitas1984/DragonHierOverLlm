// ============================================================
// Type  : AreaBuildController
// Token : 0x2000141
// ============================================================

public class AreaBuildController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40007BD
    public GameObject buildModeButton;

    // Token: 0x40007BE
    public GameObject buildChoiceButtonPrefab;

    // Token: 0x40007BF
    public GameObject buildNewButtonPrefab;

    // Token: 0x40007C0
    public bool buildMode;

    // Token: 0x40007C1
    public bool buildModeMovingBuilding;

    // Token: 0x40007C2
    public GameObject buildTargetObj;

    // Token: 0x40007C3
    public GameObject buildTargetIcon;

    // Token: 0x40007C4
    public GameObject buildChoiceGrid;

    // Token: 0x40007C5
    public GameObject buildNewPanel;

    // Token: 0x40007C6
    public GameObject buildMoveIcon;

    // Token: 0x40007C7
    private static string BuildModeButtonDescribe;

    // Token: 0x40007C8
    public static List<string> AreaObstacleName;

    // Token: 0x40007C9
    private GameObject newObj;

    // Token: 0x40007CA
    private static AreaBuildController _instance;

    // Token: 0x40007CB
    public static int UpgradeBuildNeedForceLv;

    // Token: 0x40007CC
    public static int NewBuildNeedForceLv;

    // Token: 0x40007CD
    public static int DestroyBuildNeedForceLv;

    // Token: 0x40007CE
    public static int MoveBuildNeedForceLv;

    // Token: 0x40007CF
    public static int UpgradeRoadNeedForceLv;

    // Token: 0x40007D0
    public static int MaxSpeBuildingNum;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A36
    // RVA   : 0xA25970   Offset: 0xA24D70   Length: 0x58
    public static AreaBuildController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181dac458 + 184) + 16);
    }

    // Token : 0x6000A37
    // RVA   : 0xA1F270   Offset: 0xA1E670   Length: 0x11E
    private void Awake()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = AreaBuildController._instance;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          Object.Destroy(uVar2,0);
          return;
        }
        AreaBuildController._instance = this;
    }

    // Token : 0x6000A38
    // RVA   : 0xA24BA0   Offset: 0xA23FA0   Length: 0xBB5
    private void Update()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar6;
        ulong local_28;
        uint local_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar3 = *(int64 *)(*(int64 *)(DAT_181dac758 + 184) + 56);
        if (lVar3 == null) goto LAB_180a25750;
        if (*(int64 *)(lVar3 + 88) == 0) {
          return;
        }
        cVar1 = GameController.MeetCondition("我",0,0);
        lVar3 = this.buildModeButton;
        if (!cVar1) {
          if (lVar3 == null) goto LAB_180a25750;
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (cVar1) {
            if (this.buildModeButton == null) goto LAB_180a25750;
            GameObject.SetActive(this.buildModeButton,0,0);
          }
        }
        else {
          if (lVar3 == null) goto LAB_180a25750;
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (!cVar1) {
            if (this.buildModeButton == null) goto LAB_180a25750;
            GameObject.SetActive(this.buildModeButton,1,0);
          }
          cVar1 = GameController.MeetCondition("亲传弟子",0,0);
          lVar3 = this.buildModeButton;
          if (!cVar1) {
            if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181dc7c00)) == null)
            goto LAB_180a25750;
            Selectable.set_interactable(lVar3,0,0);
            if (this.buildModeButton == null) goto LAB_180a25750;
            lVar3 = GameObject.GetComponent(this.buildModeButton,DAT_181d73448);
            lVar6 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x3d8);
            if (lVar6 == null) goto LAB_180a25750;
            if (*(uint32 *)(lVar6 + 24) < 4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = GlobalData.GenerateRareLvColorText
                              (*(uint64 *)(*(int64 *)(lVar6 + 16) + 56),3);
            uVar2 = String.Format("<b>建造模式</b>(需要 {0})\n",uVar2,0);
            uVar2 = String.Concat(uVar2,**(uint64 **)(DAT_181dac458 + 184),0);
          }
          else {
            if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181dc7c00)) == null)
            goto LAB_180a25750;
            Selectable.set_interactable(lVar3,1,0);
            if (this.buildModeButton == null) goto LAB_180a25750;
            lVar3 = GameObject.GetComponent(this.buildModeButton,DAT_181d73448);
            uVar2 = String.Concat("<b>建造模式</b>\n",**(uint64 **)(DAT_181dac458 + 184),0);
          }
          if (lVar3 == null) goto LAB_180a25750;
          *(uint64 *)(lVar3 + 24) = uVar2;
        }
        uVar2 = this.buildTargetObj;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        lVar3 = this.buildTargetIcon;
        if (!cVar1) {
          if (lVar3 == null) goto LAB_180a25750;
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (cVar1) {
            if (this.buildTargetIcon == null) goto LAB_180a25750;
            GameObject.SetActive(this.buildTargetIcon,0,0);
          }
        }
        else {
          if (lVar3 == null) goto LAB_180a25750;
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (!cVar1) {
            if (this.buildTargetIcon == null) goto LAB_180a25750;
            GameObject.SetActive(this.buildTargetIcon,1,0);
          }
          if (this.buildTargetIcon == null) goto LAB_180a25750;
          lVar3 = GameObject.get_transform(this.buildTargetIcon,0);
          if (((this.buildTargetObj == null) ||
              (lVar6 = GameObject.get_transform(this.buildTargetObj,0)) == null) ||
             (puVar7 = (uint64 *)Transform.get_position(&local_18,lVar6,0), lVar3 == null))
          goto LAB_180a25750;
          local_28 = *puVar7;
          local_20 = *(uint32 *)(puVar7 + 1);
          Transform.set_position(lVar3,&local_28,0);
          if (this.buildChoiceGrid == null) goto LAB_180a25750;
          cVar1 = GameObject.get_activeSelf(this.buildChoiceGrid,0);
          if (cVar1) {
            if (this.buildChoiceGrid == null) goto LAB_180a25750;
            lVar3 = GameObject.get_transform(this.buildChoiceGrid,0);
            if (((this.buildTargetObj == null) ||
                (lVar6 = GameObject.get_transform(this.buildTargetObj,0)) == null) ||
               (puVar7 = (uint64 *)Transform.get_position(&local_18,lVar6,0), lVar3 == null))
            goto LAB_180a25750;
            local_28 = *puVar7;
            local_20 = *(uint32 *)(puVar7 + 1);
            Transform.set_position(lVar3,&local_28,0);
          }
          if (this.buildNewPanel == null) goto LAB_180a25750;
          cVar1 = GameObject.get_activeSelf(this.buildNewPanel,0);
          if (cVar1) {
            if (this.buildNewPanel == null) goto LAB_180a25750;
            lVar3 = GameObject.get_transform(this.buildNewPanel,0);
            if (((this.buildTargetObj == null) ||
                (lVar6 = GameObject.get_transform(this.buildTargetObj,0)) == null) ||
               (puVar7 = (uint64 *)Transform.get_position(&local_18,lVar6,0), lVar3 == null))
            goto LAB_180a25750;
            local_28 = *puVar7;
            local_20 = *(uint32 *)(puVar7 + 1);
            Transform.set_position(lVar3,&local_28,0);
          }
        }
        if (!this.buildModeMovingBuilding) {
        LAB_180a2569a:
          if (this.buildMoveIcon == null) {
        LAB_180a25750:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = GameObject.get_activeSelf(this.buildMoveIcon,0);
          if (!cVar1) goto LAB_180a256c9;
          lVar3 = this.buildMoveIcon;
          if (lVar3 == null) goto LAB_180a25750;
          uVar2 = 0;
        }
        else {
          uVar2 = MouseController.get_hoveredObject(0);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (!cVar1) goto LAB_180a2569a;
          lVar3 = MouseController.get_hoveredObject(0);
          if (lVar3 == null) goto LAB_180a25750;
          uVar2 = GameObject.GetComponent(lVar3,DAT_181dc7270);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (!cVar1) {
            lVar3 = MouseController.get_hoveredObject(0);
            if (lVar3 == null) goto LAB_180a25750;
            uVar2 = GameObject.GetComponent(lVar3,DAT_181dc7050);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (!cVar1) goto LAB_180a2569a;
            lVar3 = MouseController.get_hoveredObject(0);
            if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181dc7050)) == null) ||
               (*(int64 *)(lVar3 + 24) == 0)) goto LAB_180a25750;
            if (*(int *)(*(int64 *)(lVar3 + 24) + 16) == -1) {
        LAB_180a254e1:
              if (this.buildMoveIcon == null) goto LAB_180a25750;
              plVar4 = (int64 *)GameObject.GetComponent(this.buildMoveIcon,DAT_181d71e80);
              puVar5 = (uint32 *)Color.get_red(&local_18,0);
            }
            else {
              lVar3 = MouseController.get_hoveredObject(0);
              if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181dc7050)) == null) ||
                 ((*(int64 *)(lVar3 + 24) == 0 ||
                  (lVar3 = AreaBuildingData.DataBase(*(int64 *)(lVar3 + 24),0)) == null)))
              goto LAB_180a25750;
              if (*(char *)(lVar3 + 53) != false) goto LAB_180a254e1;
              lVar3 = MouseController.get_hoveredObject(0);
              if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181dc7050)) == null) ||
                 (*(int64 *)(lVar3 + 24) == 0)) goto LAB_180a25750;
              if (0 < *(int *)(*(int64 *)(lVar3 + 24) + 24)) goto LAB_180a254e1;
              lVar3 = MouseController.get_hoveredObject(0);
              if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181dc7050)) == null) ||
                 (*(int64 *)(lVar3 + 24) == 0)) goto LAB_180a25750;
              if (0 < *(int *)(*(int64 *)(lVar3 + 24) + 32)) goto LAB_180a254e1;
              lVar3 = MouseController.get_hoveredObject(0);
              if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181dc7050)) == null) ||
                 (*(int64 *)(lVar3 + 24) == 0)) goto LAB_180a25750;
              if (0 < *(int *)(*(int64 *)(lVar3 + 24) + 28)) goto LAB_180a254e1;
              if (this.buildMoveIcon == null) goto LAB_180a25750;
              plVar4 = (int64 *)GameObject.GetComponent(this.buildMoveIcon,DAT_181d71e80);
              puVar5 = (uint32 *)Color.get_yellow(&local_18,0);
            }
            if (plVar4 == (int64 *)0) goto LAB_180a25750;
            local_18 = *puVar5;
            uStack_14 = puVar5[1];
            uStack_10 = puVar5[2];
            uStack_c = puVar5[3];
            (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
          }
          else {
            if (this.buildMoveIcon == null) goto LAB_180a25750;
            plVar4 = (int64 *)GameObject.GetComponent(this.buildMoveIcon,DAT_181d71e80);
            lVar3 = MouseController.get_hoveredObject(0);
            if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3)) == null) ||
               (*(int64 *)(lVar3 + 24) == 0)) goto LAB_180a25750;
            if (*(int *)(*(int64 *)(lVar3 + 24) + 48) == 0) {
              puVar5 = (uint32 *)Color.get_green();
            }
            else {
              puVar5 = (uint32 *)Color.get_red(&local_18);
            }
            if (plVar4 == (int64 *)0) goto LAB_180a25750;
            local_18 = *puVar5;
            uStack_14 = puVar5[1];
            uStack_10 = puVar5[2];
            uStack_c = puVar5[3];
            (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_18,*(uint64 *)(*plVar4 + 0x2b0));
          }
          if (this.buildMoveIcon == null) goto LAB_180a25750;
          lVar3 = GameObject.get_transform(this.buildMoveIcon,0);
          lVar6 = MouseController.get_hoveredObject(0);
          if (((lVar6 == null) || (lVar6 = GameObject.get_transform(lVar6,0)) == null) ||
             (puVar7 = (uint64 *)Transform.get_position(&local_18,lVar6,0), lVar3 == null))
          goto LAB_180a25750;
          local_28 = *puVar7;
          local_20 = *(uint32 *)(puVar7 + 1);
          Transform.set_position(lVar3,&local_28,0);
          if (this.buildMoveIcon == null) goto LAB_180a25750;
          cVar1 = GameObject.get_activeSelf(this.buildMoveIcon,0);
          if (cVar1) goto LAB_180a256c9;
          lVar3 = this.buildMoveIcon;
          if (lVar3 == null) goto LAB_180a25750;
          uVar2 = 1;
        }
        GameObject.SetActive(lVar3,uVar2,0);
        LAB_180a256c9:
        cVar1 = Input.GetMouseButtonUp(1);
        if (cVar1) {
          if (!this.buildModeMovingBuilding) {
            if (this.buildMode) {
              uVar2 = this.buildTargetObj;
              cVar1 = Object.op_Inequality(uVar2,0,0);
              if (!cVar1) {
                AreaBuildController.ChangeBuildMode(this,0,0);
              }
              else {
                AreaBuildController.CloseBuildMenu(this,0);
              }
            }
          }
          else {
            AreaBuildController.SetBuildModeMovingBuilding(this,0,0);
          }
        }
    }

    // Token : 0x6000A39
    // RVA   : 0xA21E90   Offset: 0xA21290   Length: 0x10D
    public void SetBuildModeMovingBuilding(bool moving)
    {
        var pStatics = *(int64*)(DAT_181dbb428 + 184);
        ulong uVar2;
        bool cVar4;
        this.buildModeMovingBuilding = moving;
        cVar4 = moving;
        if (!DAT_181e9d6de) {
          il2cpp_runtime_class_init(&DAT_181dbb428);
          DAT_181e9d6de = true;
          cVar4 = this.buildModeMovingBuilding;
        }
        if (*pStatics != 0) {
          uVar2 = 4;
          if (!cVar4) {
            uVar2 = 2;
          }
          CursorManager.ChangeCursorType(*pStatics,uVar2,0);
          if (!moving) {
            this.buildTargetObj = 0;
            plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
            plVar3 = (int64 *)0;
            if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
              plVar3 = plVar1;
            }
            NGUITools.PlaySound(plVar3,0);
          }
          return;
        }
    }

    // Token : 0x6000A3A
    // RVA   : 0xA1FFC0   Offset: 0xA1F3C0   Length: 0xF
    public void BuildModeButtonClicked()
    {
        void FUN_180a1ffc0(int64 this)
        {
        AreaBuildController.ChangeBuildMode(this,!this.buildMode,0);
    }

    // Token : 0x6000A3B
    // RVA   : 0xA20A30   Offset: 0xA1FE30   Length: 0xA
    public void EndBuildMode()
    {
        void FUN_180a20a30(uint64 this)
        {
        AreaBuildController.ChangeBuildMode(this,0,0);
    }

    // Token : 0x6000A3C
    // RVA   : 0xA20510   Offset: 0xA1F910   Length: 0x3F1
    public void ChangeBuildMode(bool _buildMode)
    {
        var pStatics_b428 = *(int64*)(DAT_181dbb428 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar5;
        long lVar6;
        uint uVar8;
        long lVar9;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        this.buildMode = _buildMode;
        if (this.buildModeButton != null) {
          plVar3 = (int64 *)GameObject.GetComponent();
          if (!this.buildMode) {
            puVar4 = (uint32 *)FUN_1810d3570(&local_28);
          }
          else {
            puVar4 = (uint32 *)Color.get_green();
          }
          if (plVar3 != (int64 *)0) {
            local_28 = *puVar4;
            uStack_24 = puVar4[1];
            uStack_20 = puVar4[2];
            uStack_1c = puVar4[3];
            (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_28,*(uint64 *)(*plVar3 + 0x2b0));
            if (!this.buildMode) {
              AreaBuildController.CloseBuildMenu(this,0);
            }
            if (*pStatics_b428 != 0) {
              CursorManager.ChangeCursorType
                        (*pStatics_b428,-(this.buildMode) & 2,0)
              ;
              lVar1 = PlotController.SpringFestivelRewardLvTalkText;
              if (lVar1 != null) {
                AreaController.SetBuildModeUI(lVar1,this.buildMode,0);
                lVar1 = PlotController.SpringFestivelRewardLvTalkText;
                if (lVar1 != null) {
                  lVar6 = *(int64 *)(lVar1 + 160);
                  plVar3 = (int64 *)0;
                  if (lVar6 != null) {
                    lVar9 = 32;
                    plVar7 = plVar3;
                    while( true ) {
                      uVar8 = (uint32)plVar7;
                      if (*(int *)(lVar6 + 24) <= (int)uVar8) {
                        uVar5 = "Button/CraftButton";
                        if (!this.buildMode) {
                          uVar5 = "Woosh";
                        }
                        uVar5 = String.Concat("Sound/SoundEffect/",uVar5,0);
                        plVar7 = (int64 *)Resources.Load(uVar5,0);
                        if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf348)) {
                          plVar3 = plVar7;
                        }
                        NGUITools.PlaySound(plVar3,0);
                        return;
                      }
                      if (lVar6 == null) break;
                      if (*(uint32 *)(lVar6 + 24) <= uVar8) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar6 = *(int64 *)(lVar9 + *(int64 *)(lVar6 + 16));
                      if (lVar6 == null) break;
                      uVar5 = GameObject.GetComponent(lVar6,DAT_181dc7270);
                      cVar2 = Object.op_Inequality(uVar5,0);
                      if (cVar2) {
                        if (((*(int64 *)(lVar1 + 160) == 0) ||
                            (lVar6 = FUN_180002f80(*(int64 *)(lVar1 + 160),plVar7)) == null) ||
                           (lVar6 = GameObject.GetComponent(lVar6,DAT_181dc7270)) == null) break;
                        AreaUnitController.RefreshUnitColor(lVar6,0);
                      }
                      lVar6 = *(int64 *)(lVar1 + 160);
                      plVar7 = (int64 *)(uint64)(uVar8 + 1);
                      lVar9 = lVar9 + 8;
                      if (lVar6 == null) break;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000A3D
    // RVA   : 0xA20910   Offset: 0xA1FD10   Length: 0x119
    public void CloseBuildMenu()
    {
        var pStatics = *(int64*)(DAT_181dbb428 + 184);
        this.buildTargetObj = 0;
        this.buildModeMovingBuilding = 0;
        if (this.buildChoiceGrid != null) {
          GameObject.SetActive(this.buildChoiceGrid,0,0);
          if (this.buildNewPanel != null) {
            GameObject.SetActive(this.buildNewPanel,0,0);
            if (*pStatics != 0) {
              CursorManager.ChangeCursorType(*pStatics,2);
              plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
              plVar2 = (int64 *)0;
              if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
                plVar2 = plVar1;
              }
              NGUITools.PlaySound(plVar2,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000A3E
    // RVA   : 0xA20A40   Offset: 0xA1FE40   Length: 0xAE5
    public void GenerateBuildNewButton(int targetBuildingID)
    {
        var pStatics_c458 = *(int64*)(DAT_181dac458 + 184);
        int iVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        bool cVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        long lVar9;
        ulong uVar12;
        float fVar13;
        ulong local_58;
        ulong local_48;
        float local_40;
        byte[] local_28 = new byte[32];
        if ((((this.buildNewPanel != null) &&
             (lVar6 = GameObject.get_transform(this.buildNewPanel,0)) != null) &&
            (lVar6 = Transform.Find(lVar6,"Viewport",0)) != null) &&
           (lVar6 = Transform.Find(lVar6,"Content",0)) != null) {
          uVar7 = Component.get_gameObject(lVar6,0);
          uVar8 = this.buildNewButtonPrefab;
          uVar8 = GlobalData.AddChild(uVar7,uVar8,0);
          this.newObj = uVar8;
          if (((this.newObj != null) &&
              (lVar6 = GameObject.get_transform(this.newObj,0)) != null) &&
             (lVar6 = Transform.Find(lVar6,"Text",0)) != null) {
            uVar8 = Component.GetComponent(lVar6,DAT_181d96160);

            if (((lVar6 = GameController.lockObj?.missionFinished) != null) &&
               (lVar6 = FUN_1817d9e10(lVar6,targetBuildingID,DAT_181db7bd8)) != null) {
              uVar7 = lVar6.cityAreaID;
              LTLocalization.SetText(uVar8,uVar7,0);
              if ((this.newObj != null) &&
                 (lVar6 = GameObject.GetComponent(this.newObj,DAT_181dc7a68),
                 lVar6 != null)) {
                lVar6.cityAreaID = targetBuildingID;
                if (this.newObj != null) {
                  lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448);
                  lVar9 = GameController.lockObj;
                  if ((lVar9 != null) && (lVar9 = *(int64 *)(lVar9 + 224)) != null) {
                    lVar9 = FUN_1817d9e10(lVar9,targetBuildingID,DAT_181db7bd8);
                    lVar3 = *(int64 *)(*(int64 *)(DAT_181dac758 + 184) + 56);
                    if ((lVar3 != null) && (lVar9 != null)) {
                      uVar8 = AreaBuildingDataBase.GetBuildingText
                                        (lVar9,0,1,1,0x3f800000,1,*(uint64 *)(lVar3 + 88),0);
                      if (lVar6 != null) {
                        lVar6.cityAreaID = uVar8;
                        if ((GameController._instance != null) &&
                           (lVar6 = GameController._instance.worldData,
                           lVar6 != null)) {
                          lVar6 = WorldData.GetHeroForce(lVar6,0,0);
                          lVar9 = GameController.lockObj;
                          if (((lVar9 != null) && (lVar9 = *(int64 *)(lVar9 + 224)) != null) &&
                             (lVar9 = FUN_1817d9e10(lVar9,targetBuildingID,DAT_181db7bd8)) != null) {
                            uVar8 = *(uint64 *)(lVar9 + 80);
                            uVar8 = GlobalData.ListMulti(uVar8,0x3f800000,0);
                            if (lVar6 != null) {
                              cVar5 = ForceData.HaveResource(lVar6,uVar8,0);
                              if (!cVar5) {
                                if ((this.newObj == null) ||
                                   (lVar6 = GameObject.GetComponent
                                                      (this.newObj,DAT_181dc7c00),
                                   lVar6 == null)) throw; // [null/range check failed]
                                Selectable.set_interactable(lVar6,0,0);
                              }
                              if (((GameController._instance != null) &&
                                  (lVar6 = GameController._instance.worldData,
                                  lVar6 != null)) && (lVar6 = WorldData.Player(lVar6,0)) != null) {
                                iVar1 = lVar6.forceMeetingStarted;
                                if (iVar1 < AreaBuildController.NewBuildNeedForceLv) {
                                  if ((this.newObj == null) ||
                                     (lVar6 = GameObject.GetComponent
                                                        (this.newObj,DAT_181dc7c00),
                                     lVar6 == null)) throw; // [null/range check failed]
                                  Selectable.set_interactable(lVar6,0,0);
                                  if (this.newObj == null) throw; // [null/range check failed]
                                  lVar6 = GameObject.GetComponent
                                                    (this.newObj,DAT_181d73448);
                                  lVar9 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x3d8);
                                  uVar2 = AreaBuildController.NewBuildNeedForceLv;
                                  if (lVar9 == null) throw; // [null/range check failed]
                                  if (*(uint32 *)(lVar9 + 24) <= uVar2) {
                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                  }
                                  uVar8 = GlobalData.GenerateRareLvColorText
                                                    (*(uint64 *)
                                                      (*(int64 *)(lVar9 + 16) + 32 +
                                                      (int64)(int)uVar2 * 8),
                                                     *(uint32 *)
                                                      (pStatics_c458 + 28),0);
                                  uVar8 = String.Format("需要 {0}\n\n",uVar8,0);
                                  if (((this.newObj == null) ||
                                      (lVar9 = GameObject.GetComponent
                                                         (this.newObj,DAT_181d73448),
                                      lVar9 == null)) ||
                                     (uVar8 = String.Concat(uVar8,*(uint64 *)(lVar9 + 24),0),
                                     lVar6 == null)) throw; // [null/range check failed]
                                  lVar6.cityAreaID = uVar8;
                                }
                                uVar8 = this.newObj;

                                if (((lVar6 = GameController.lockObj?.missionFinished) != null) &&
                                   (lVar6 = FUN_1817d9e10(lVar6,targetBuildingID,DAT_181db7bd8)) != null) {
                                  uVar7 = String.Concat("Skeleton/Building/",lVar6.villageAreaID,
                                                         "/skeleton_SkeletonData",0);
                                  puVar10 = (uint64 *)Vector3.get_one(local_28,0);
                                  local_48 = *puVar10;
                                  local_40 = *(float *)(puVar10 + 1);
                                  fVar13 = local_40 * 0.5;
                                  local_58 = CONCAT44((float)((uint64)local_48 >> 32) * 0.5,
                                                      (float)local_48 * 0.5);

                                  if (((lVar6 = GameController.lockObj?.missionFinished) != null)
                                     && (lVar6 = FUN_1817d9e10(lVar6,targetBuildingID,DAT_181db7bd8),
                                        uVar4 = "idle", lVar6 != null)) {
                                    uVar12 = "0";
                                    if (lVar6.Areas == 6) {
                                      uVar12 = 0;
                                    }
                                    local_48 = local_58;
                                    local_40 = fVar13;
                                    plVar11 = (int64 *)
                                              GlobalData.GenerateSkeletonGraphic
                                                        (uVar8,uVar7,&local_48,uVar4,1,uVar12,0);
                                    if ((plVar11 != (int64 *)0) &&
                                       (lVar6 = Component.get_transform(plVar11,0)) != null) {
                                      Transform.SetSiblingIndex(lVar6,0,0);
                          // WARNING: Could not recover jumptable at 0x000180a21519. Too many branches
                          // WARNING: Treating indirect jump as call
                                      (**(code **)(*plVar11 + 0x2c8))
                                                (plVar11,0,*(uint64 *)(*plVar11 + 0x2d0));
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

    // Token : 0x6000A3F
    // RVA   : 0xA21530   Offset: 0xA20930   Length: 0x14D
    public int GetMaxSpeBuildingNum()
    {
        long lVar1;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          if (4 < lVar1.gameDifficulty) {
            return '\a';
          }
          if ((GameController._instance != null) &&
             (lVar1 = GameController._instance.worldData) != null) {
            return (2 < lVar1.gameDifficulty) + '\x05';
          }
        }
    }

    // Token : 0x6000A40
    // RVA   : 0xA21FA0   Offset: 0xA213A0   Length: 0x2A57
    public void SetBuildTarget(GameObject target)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        var pStatics_b428 = *(int64*)(DAT_181dbb428 + 184);
        var pStatics_c458 = *(int64*)(DAT_181dac458 + 184);
        bool cVar1;
        byte uVar2;
        uint uVar3;
        int iVar4;
        int iVar5;
        long lVar6;
        ulong uVar7;
        long lVar9;
        ulong uVar10;
        ulong uVar11;
        int[] local_res8 = new int[2];
        uint[] local_res10 = new uint[2];
        this.buildTargetObj = target;
        if (this.buildChoiceGrid == null) goto LAB_180a249da;
        GameObject.SetActive(this.buildChoiceGrid,0,0);
        uVar7 = this.buildChoiceGrid;
        GlobalData.DeleteAllChild(uVar7,0);
        if (this.buildNewPanel == null) goto LAB_180a249da;
        GameObject.SetActive(this.buildNewPanel,0,0);
        if ((((this.buildNewPanel == null) ||
             (lVar6 = GameObject.get_transform(this.buildNewPanel,0)) == null) ||
            (lVar6 = Transform.Find(lVar6,"Viewport",0)) == null) ||
           (lVar6 = Transform.Find(lVar6,"Content",0)) == null) goto LAB_180a249da;
        uVar7 = Component.get_gameObject(lVar6,0);
        GlobalData.DeleteAllChild(uVar7,0);
        if ((*pStatics_b428 == 0) ||
           (CursorManager.ChangeCursorType(*pStatics_b428,2), target == null))
        goto LAB_180a249da;
        uVar7 = GameObject.GetComponent(target,DAT_181dc7270);
        cVar1 = Object.op_Inequality(uVar7,0,0);
        if (cVar1) {
          lVar6 = GameObject.GetComponent(target,DAT_181dc7270);
          if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249da;
          if (*(int *)(lVar6.cityAreaID + 48) == 0) {
            plVar8 = (int64 *)Resources.Load("Sound/SoundEffect/Button/WoodButton",0);
            plVar14 = (int64 *)0;
            plVar12 = plVar14;
            if ((plVar8 != (int64 *)0) && (plVar12 = (int64 *)0, *plVar8 == DAT_181daf348)) {
              plVar12 = plVar8;
            }
            NGUITools.PlaySound(plVar12,0);
            if (*pStatics_b428 != 0) {
              CursorManager.ChangeCursorType(*pStatics_b428,3);
              AreaBuildController.ShowBuildNewPanel(this,1,0);
              plVar8 = plVar14;
              while( true ) {

                if ((lVar6 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32)?.PlotEventLog) == null) goto LAB_180a249da;
                if (lVar6.cityAreaID < 6) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = *(int64 *)(lVar6.chapter + 72);
                if (lVar6 == null) goto LAB_180a249da;
                if (lVar6.cityAreaID <= (int)plVar8) break;
                lVar6 = FUN_18046c100(0);
                if (lVar6 == null) goto LAB_180a249da;
                lVar6 = lVar6.missionFinished;
                lVar9 = FUN_18046c100(0);
                if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 232)) == null) goto LAB_180a249da;
                if (*(uint32 *)(lVar9 + 24) < 6) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 72);
                if (((lVar9 == null) || (uVar3 = FUN_1800d6760(lVar9,plVar8,DAT_181d8fa18), lVar6 == null)) ||
                   (lVar6 = FUN_1817d9e10(lVar6,uVar3,DAT_181db7bd8)) == null) goto LAB_180a249da;
                if (lVar6.WorldEventDatasSaveRecord == null) {
        LAB_180a226fd:

                  if ((lVar6 = FUN_18046c100(0)?.PlotEventLog) == null)
                  goto LAB_180a249da;
                  if (lVar6.cityAreaID < 6) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar6 = *(int64 *)(lVar6.chapter + 72);
                  if (lVar6 == null) goto LAB_180a249da;
                  uVar3 = FUN_1800d6760(lVar6,plVar8);
                  AreaBuildController.GenerateBuildNewButton(this,uVar3);
                }
                else {
                  lVar6 = FUN_18046c100(0);
                  if (lVar6 == null) goto LAB_180a249da;
                  lVar6 = lVar6.missionFinished;
                  lVar9 = FUN_18046c100(0);
                  if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 232)) == null)
                  goto LAB_180a249da;
                  if (*(uint32 *)(lVar9 + 24) < 6) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 72);
                  if (((lVar9 == null) || (uVar3 = FUN_1800d6760(lVar9,plVar8,DAT_181d8fa18), lVar6 == null)) ||
                     (lVar6 = FUN_1817d9e10(lVar6,uVar3,DAT_181db7bd8)) == null) goto LAB_180a249da;
                  if (lVar6.WorldEventDatasSaveRecord == 1) {
                    lVar6 = FUN_18046bac0(0);
                    if ((lVar6 == null) || (lVar6.TempHeros == null)) goto LAB_180a249da;
                    if (*(int *)(lVar6.TempHeros + 72) != 2) goto LAB_180a226fd;
                  }
                  lVar6 = FUN_18046c100(0);
                  if (lVar6 == null) goto LAB_180a249da;
                  lVar6 = lVar6.missionFinished;
                  lVar9 = FUN_18046c100(0);
                  if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 232)) == null)
                  goto LAB_180a249da;
                  if (*(uint32 *)(lVar9 + 24) < 6) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 72);
                  if (((lVar9 == null) || (uVar3 = FUN_1800d6760(lVar9,plVar8,DAT_181d8fa18), lVar6 == null)) ||
                     (lVar6 = FUN_1817d9e10(lVar6,uVar3)) == null) goto LAB_180a249da;
                  if (lVar6.WorldEventDatasSaveRecord == 2) {
                    lVar6 = FUN_18046bac0(0);
                    if ((lVar6 == null) || (lVar6.TempHeros == null)) goto LAB_180a249da;
                    if (*(int *)(lVar6.TempHeros + 72) == 2) goto LAB_180a226fd;
                  }
                }
                plVar8 = (int64 *)(uint64)((int)plVar8 + 1);
              }
              lVar6 = FUN_18046bac0(0);
              if ((lVar6 != null) && (lVar6.TempHeros != null)) {
                iVar4 = *(int *)(lVar6.TempHeros + 16);
                lVar6 = FUN_18046c0a0(0);
                if ((((lVar6 != null) && (lVar6.villageAreaID != null)) &&
                    (lVar6 = WorldData.Player(lVar6.villageAreaID,0)) != null) &&
                   (lVar6 = HeroData.GetForce(lVar6,0,0)) != null) {
                  lVar9 = this.buildNewPanel;
                  if (iVar4 == lVar6.Inns) {
                    if (((lVar9 != null) && (lVar6 = GameObject.get_transform(lVar9,0)) != null) &&
                       ((lVar6 = Transform.Find(lVar6,"SpeBuildNumBack",0), lVar6 != null &&
                        (lVar6 = Component.get_gameObject(lVar6,0)) != null))) {
                      GameObject.SetActive(lVar6,1,0);
                      if (((this.buildNewPanel != null) &&
                          (lVar6 = GameObject.get_transform(this.buildNewPanel,0)) != null
                          ) && ((lVar6 = Transform.Find(lVar6,"SpeBuildNumBack",0), lVar6 != null &&
                                (lVar6 = Transform.Find(lVar6,"Text",0)) != null))) {
                        plVar8 = (int64 *)Component.GetComponent(lVar6,DAT_181d96160);
                        lVar6 = FUN_18046bac0(0);
                        if ((lVar6 != null) && (lVar6.TempHeros != null)) {
                          local_res8[0] = AreaData.GetSpeBuildingNum(lVar6.TempHeros,0);
                          uVar7 = il2cpp_value_box(DAT_181d80418,local_res8);
                          local_res10[0] = AreaBuildController.GetMaxSpeBuildingNum(this,0);
                          uVar10 = il2cpp_value_box(DAT_181d80418,local_res10);
                          uVar7 = String.Format("特殊建筑{0}/{1}",uVar7,uVar10,0);
                          uVar7 = LTLocalization.GetText(uVar7,0,1,0);
                          if (plVar8 != (int64 *)0) {
                            (**(code **)(*plVar8 + 0x5e8))(plVar8,uVar7,*(uint64 *)(*plVar8 + 0x5f0));
                            lVar6 = FUN_18046bac0(0);
                            if ((lVar6 != null) && (lVar6.TempHeros != null)) {
                              iVar4 = AreaData.GetSpeBuildingNum(lVar6.TempHeros,0);
                              iVar5 = AreaBuildController.GetMaxSpeBuildingNum(this,0);
                              if (iVar5 <= iVar4) {
                                return;
                              }
                              goto LAB_180a22a50;
                            }
                          }
                        }
                      }
                    }
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if ((((lVar9 != null) && (lVar6 = GameObject.get_transform(lVar9,0)) != null) &&
                      (lVar6 = Transform.Find(lVar6,"SpeBuildNumBack",0)) != null) &&
                     (lVar6 = Component.get_gameObject(lVar6,0)) != null) {
                    GameObject.SetActive(lVar6,0,0);
                    return;
                  }
                }
              }
            }
            goto LAB_180a249da;
          }
        }
        uVar7 = GameObject.GetComponent(target,DAT_181dc7270);
        cVar1 = Object.op_Inequality(uVar7,0,0);
        if (!cVar1) {
        LAB_180a23471:
          uVar7 = GameObject.GetComponent(target,DAT_181dc7050);
          cVar1 = Object.op_Inequality(uVar7,0,0);
          if (!cVar1) {
            return;
          }
          plVar8 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
          plVar12 = (int64 *)0;
          if ((plVar8 != (int64 *)0) && (plVar12 = (int64 *)0, *plVar8 == DAT_181daf348)) {
            plVar12 = plVar8;
          }
          NGUITools.PlaySound(plVar12,0);
          lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
          if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249da;
          if (*(int *)(lVar6.cityAreaID + 16) == -1) {
            lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
            if ((lVar6 == null) || (lVar6.cityAreaID == null)) {
        LAB_180a249da:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (0 < *(int *)(lVar6.cityAreaID + 32)) {
              return;
            }
            AreaBuildController.ShowBuildChoiceGrid(this,1,0);
            uVar7 = this.buildChoiceGrid;
            uVar10 = this.buildChoiceButtonPrefab;
            uVar7 = GlobalData.AddChild(uVar7,uVar10,0);
            this.newObj = uVar7;
            if (((this.newObj == null) ||
                (lVar6 = GameObject.get_transform(this.newObj,0)) == null) ||
               (lVar6 = Transform.Find(lVar6,"Text",0)) == null) goto LAB_180a249da;
            uVar7 = Component.GetComponent(lVar6,DAT_181d96160);
            LTLocalization.SetText(uVar7,"拆除",0);
            lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
            if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249da;
            iVar4 = *(int *)(lVar6.cityAreaID + 20);
            lVar6 = FUN_18046bac0(0);
            if (((lVar6 == null) || (lVar6.TempHeros == null)) ||
               (lVar6 = AreaData.GetCenterBuilding(lVar6.TempHeros,0)) == null)
            goto LAB_180a249da;
            if (*(int *)(lVar6 + 20) < iVar4) {
              if ((this.newObj == null) ||
                 (lVar6 = GameObject.GetComponent(this.newObj,DAT_181dc7c00),
                 lVar6 == null)) {
        LAB_180a249f2:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              Selectable.set_interactable(lVar6,0,0);
              if (this.newObj == null) goto LAB_180a249f2;
              lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448);
              uVar7 = *(uint64 *)(pStatics_3d40 + 0x2d0);
              lVar9 = PlotController.SpringFestivelRewardLvTalkText;
              if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 88)) == null) ||
                  (lVar9 = AreaData.GetCenterBuilding(lVar9,0)) == null) ||
                 (lVar9 = AreaBuildingData.DataBase(lVar9,0)) == null) goto LAB_180a249f2;
              uVar7 = String.Concat(uVar7,*(uint64 *)(lVar9 + 24),0);
              lVar9 = GameObject.GetComponent(target,DAT_181dc7050);
              if ((lVar9 == null) || (*(int64 *)(lVar9 + 24) == 0)) goto LAB_180a249f2;
              local_res8[0] = *(int *)(*(int64 *)(lVar9 + 24) + 20);
              uVar10 = il2cpp_value_box(DAT_181d80418,local_res8);
              uVar7 = String.Format("需要\n{0} {1}级</color>\n\n",uVar7,uVar10,0);
              if (lVar6 == null) goto LAB_180a249f2;
              lVar6.cityAreaID = uVar7;
            }
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 == null) || (lVar6.villageAreaID == null)) ||
               (lVar6 = WorldData.Player(lVar6.villageAreaID,0)) == null) goto LAB_180a249da;
            iVar4 = lVar6.forceMeetingStarted;
            if (iVar4 < AreaBuildController.DestroyBuildNeedForceLv) {
              if ((this.newObj == null) ||
                 (lVar6 = GameObject.GetComponent(this.newObj,DAT_181dc7c00),
                 lVar6 == null)) goto LAB_180a249da;
              Selectable.set_interactable(lVar6,0,0);
              if (this.newObj == null) goto LAB_180a249da;
              lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448);
              lVar9 = *(int64 *)(pStatics_3d40 + 0x3d8);
              if (lVar9 == null) goto LAB_180a249da;
              uVar7 = FUN_180002f80(lVar9,AreaBuildController.DestroyBuildNeedForceLv,
                                    DAT_181da4358);
              uVar7 = GlobalData.GenerateRareLvColorText
                                (uVar7,AreaBuildController.DestroyBuildNeedForceLv,0);
              uVar7 = String.Format("需要 {0}\n\n",uVar7,0);
              if (((this.newObj == null) ||
                  (lVar9 = GameObject.GetComponent(this.newObj,DAT_181d73448),
                  lVar9 == null)) ||
                 (uVar7 = String.Concat(uVar7,*(uint64 *)(lVar9 + 24),0), lVar6 == null))
              goto LAB_180a249da;
              lVar6.cityAreaID = uVar7;
            }
            lVar6 = FUN_18046c0a0(0);
            if ((lVar6 == null) || (lVar6.villageAreaID == null)) goto LAB_180a249da;
            lVar6 = WorldData.GetHeroForce(lVar6.villageAreaID,0,0);
            lVar9 = GameObject.GetComponent(target,DAT_181dc7050);
            if ((lVar9 == null) ||
               ((*(int64 *)(lVar9 + 24) == 0 ||
                (uVar7 = AreaBuildingData.GetObstacleRemoveCostResource(), lVar6 == null))))
            goto LAB_180a249da;
            cVar1 = ForceData.HaveResource(lVar6,uVar7,0);
            if (!cVar1) {
              if ((this.newObj == null) ||
                 (lVar6 = GameObject.GetComponent(this.newObj,DAT_181dc7c00),
                 lVar6 == null)) goto LAB_180a249da;
              Selectable.set_interactable(lVar6,0,0);
            }
            if ((this.newObj == null) ||
               (lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448)) == null
               ) goto LAB_180a249da;
            puVar13 = (uint64 *)(lVar6 + 24);
            uVar7 = *puVar13;
            lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
            if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249da;
            uVar10 = AreaBuildingData.GetDestroyCostText(lVar6.cityAreaID,0);
            lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
            if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249da;
            uVar11 = AreaBuildingData.GetObstacleRemoveCostResource();
            uVar11 = GlobalData.GetResourceDescribe(uVar11,0);
            uVar7 = String.Concat(uVar7,uVar10,"\n",uVar11,0);
            *puVar13 = uVar7;
          }
          else {
            lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
            if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249da;
            if (*(int *)(lVar6.cityAreaID + 24) < 1) {
              lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
              if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249da;
              if (*(int *)(lVar6.cityAreaID + 28) < 1) {
                lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
                if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249da;
                if (*(int *)(lVar6.cityAreaID + 32) < 1) {
                  lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
                  if (((lVar6 == null) || (lVar6.cityAreaID == null)) ||
                     (lVar6 = AreaBuildingData.DataBase(lVar6.cityAreaID,0)) == null)
                  goto LAB_180a249da;
                  if (*(char *)(lVar6 + 52) == false) {
                    uVar7 = this.buildChoiceGrid;
                    uVar10 = this.buildChoiceButtonPrefab;
                    uVar7 = GlobalData.AddChild(uVar7,uVar10,0);
                    this.newObj = uVar7;
                    if (((this.newObj == null) ||
                        (lVar6 = GameObject.get_transform(this.newObj,0)) == null)
                       || (lVar6 = Transform.Find(lVar6,"Text",0)) == null)
                    goto LAB_180a249da;
                    uVar7 = Component.GetComponent(lVar6,DAT_181d96160);
                    LTLocalization.SetText(uVar7,"拆除",0);
                    if (this.newObj == null) goto LAB_180a249da;
                    lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448);
                    lVar9 = GameObject.GetComponent(target,DAT_181dc7050);
                    if (((lVar9 == null) || (*(int64 *)(lVar9 + 24) == 0)) ||
                       (uVar7 = AreaBuildingData.GetDestroyCostText(*(int64 *)(lVar9 + 24),0),
                       lVar6 == null)) goto LAB_180a249da;
                    lVar6.cityAreaID = uVar7;
                    lVar6 = FUN_18046c0a0(0);
                    if (((lVar6 == null) || (lVar6.villageAreaID == null)) ||
                       (lVar6 = WorldData.Player(lVar6.villageAreaID,0)) == null)
                    goto LAB_180a249da;
                    iVar4 = lVar6.forceMeetingStarted;
                    if (iVar4 < AreaBuildController.DestroyBuildNeedForceLv) {
                      if ((this.newObj == null) ||
                         (lVar6 = GameObject.GetComponent(this.newObj,DAT_181dc7c00),
                         lVar6 == null)) goto LAB_180a249da;
                      Selectable.set_interactable(lVar6,0,0);
                      if (this.newObj == null) goto LAB_180a249da;
                      lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448);
                      lVar9 = *(int64 *)(pStatics_3d40 + 0x3d8);
                      if (lVar9 == null) goto LAB_180a249da;
                      uVar7 = FUN_180002f80(lVar9,*(uint32 *)
                                                   (pStatics_c458 + 32),
                                            DAT_181da4358);
                      uVar7 = GlobalData.GenerateRareLvColorText
                                        (uVar7,AreaBuildController.DestroyBuildNeedForceLv
                                         ,0);
                      uVar7 = String.Format("需要 {0}\n\n",uVar7,0);
                      if (((this.newObj == null) ||
                          (lVar9 = GameObject.GetComponent(this.newObj,DAT_181d73448),
                          lVar9 == null)) ||
                         (uVar7 = String.Concat(uVar7,*(uint64 *)(lVar9 + 24),0), lVar6 == null))
                      goto LAB_180a249da;
                      lVar6.cityAreaID = uVar7;
                    }
                  }
                  lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
                  if (((lVar6 == null) || (lVar6.cityAreaID == null)) ||
                     (lVar6 = AreaBuildingData.DataBase(lVar6.cityAreaID,0)) == null)
                  goto LAB_180a249da;
                  if (*(char *)(lVar6 + 53) == false) {
                    uVar7 = this.buildChoiceGrid;
                    uVar10 = this.buildChoiceButtonPrefab;
                    uVar7 = GlobalData.AddChild(uVar7,uVar10,0);
                    this.newObj = uVar7;
                    if (((this.newObj == null) ||
                        (lVar6 = GameObject.get_transform(this.newObj,0)) == null)
                       || (lVar6 = Transform.Find(lVar6,"Text",0)) == null)
                    goto LAB_180a249da;
                    uVar7 = Component.GetComponent(lVar6,DAT_181d96160);
                    LTLocalization.SetText(uVar7,"迁移",0);
                    if (this.newObj == null) goto LAB_180a249da;
                    lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448);
                    lVar9 = GameObject.GetComponent(target,DAT_181dc7050);
                    if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 24)) == null)
                    goto LAB_180a249da;
                    local_res8[0] = AreaBuildingData.GetMoveTime(lVar9,0);
                    uVar7 = il2cpp_value_box(DAT_181d80418,local_res8);
                    uVar7 = String.Format("消耗 ({0}天)",uVar7,0);
                    if (lVar6 == null) goto LAB_180a249da;
                    lVar6.cityAreaID = uVar7;
                    lVar6 = FUN_18046c0a0(0);
                    if (((lVar6 == null) || (lVar6.villageAreaID == null)) ||
                       (lVar6 = WorldData.Player(lVar6.villageAreaID,0)) == null)
                    goto LAB_180a249da;
                    iVar4 = lVar6.forceMeetingStarted;
                    if (iVar4 < AreaBuildController.MoveBuildNeedForceLv) {
                      if ((this.newObj == null) ||
                         (lVar6 = GameObject.GetComponent(this.newObj,DAT_181dc7c00),
                         lVar6 == null)) goto LAB_180a249da;
                      Selectable.set_interactable(lVar6,0,0);
                      if (this.newObj == null) goto LAB_180a249da;
                      lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448);
                      lVar9 = *(int64 *)(pStatics_3d40 + 0x3d8);
                      if (lVar9 == null) goto LAB_180a249da;
                      uVar7 = FUN_180002f80(lVar9,*(uint32 *)
                                                   (pStatics_c458 + 36),
                                            DAT_181da4358);
                      uVar7 = GlobalData.GenerateRareLvColorText
                                        (uVar7,AreaBuildController.MoveBuildNeedForceLv
                                         ,0);
                      uVar7 = String.Format("需要 {0}\n\n",uVar7,0);
                      if (((this.newObj == null) ||
                          (lVar9 = GameObject.GetComponent(this.newObj,DAT_181d73448),
                          lVar9 == null)) ||
                         (uVar7 = String.Concat(uVar7,*(uint64 *)(lVar9 + 24),0), lVar6 == null))
                      goto LAB_180a249da;
                      lVar6.cityAreaID = uVar7;
                    }
                  }
                  lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
                  if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249ec;
                  if (*(int *)(lVar6.cityAreaID + 20) < 10) {
                    lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
                    if (((lVar6 == null) || (lVar6.cityAreaID == null)) ||
                       (lVar6 = AreaBuildingData.DataBase(lVar6.cityAreaID,0)) == null)
                    goto LAB_180a249ec;
                    cVar1 = String.op_Inequality(lVar6.cityAreaID,"私宅",0);
                    if (cVar1) {
                      uVar7 = this.buildChoiceGrid;
                      uVar10 = this.buildChoiceButtonPrefab;
                      uVar7 = GlobalData.AddChild(uVar7,uVar10,0);
                      this.newObj = uVar7;
                      if (((this.newObj == null) ||
                          (lVar6 = GameObject.get_transform(this.newObj,0)) == null
                          ) || (lVar6 = Transform.Find(lVar6,"Text",0)) == null)
                      goto LAB_180a249ec;
                      uVar7 = Component.GetComponent(lVar6,DAT_181d96160);
                      LTLocalization.SetText(uVar7,"升级",0);
                      if (this.newObj == null) goto LAB_180a249ec;
                      lVar6 = GameObject.GetComponent(this.newObj,DAT_181dc7c00);
                      lVar9 = GameObject.GetComponent(target,DAT_181dc7050);
                      if (((lVar9 == null) || (*(int64 *)(lVar9 + 24) == 0)) ||
                         (uVar2 = AreaBuildingData.CanUpgrade(*(int64 *)(lVar9 + 24),0), lVar6 == null)
                         ) goto LAB_180a249ec;
                      Selectable.set_interactable(lVar6,uVar2,0);
                      if (this.newObj == null) goto LAB_180a249ec;
                      lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448);
                      lVar9 = GameObject.GetComponent(target,DAT_181dc7050);
                      if (((lVar9 == null) || (*(int64 *)(lVar9 + 24) == 0)) ||
                         (uVar7 = AreaBuildingData.GetUpgradeDescribe(*(int64 *)(lVar9 + 24),0),
                         lVar6 == null)) goto LAB_180a249ec;
                      lVar6.cityAreaID = uVar7;
                    }
                  }
                  if ((this.buildChoiceGrid == null) ||
                     (lVar6 = GameObject.get_transform(this.buildChoiceGrid,0)) == null)
                  goto LAB_180a249ec;
                  goto LAB_180a2344d;
                }
              }
            }
            lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
            if ((lVar6 == null) || (lVar6.cityAreaID == null)) {
        LAB_180a249ec:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(char *)(lVar6.cityAreaID + 36) != false) {
              return;
            }
            iVar4 = -1;
            AreaBuildController.ShowBuildChoiceGrid(this,1,0);
            uVar7 = this.buildChoiceGrid;
            uVar10 = this.buildChoiceButtonPrefab;
            uVar7 = GlobalData.AddChild(uVar7,uVar10,0);
            this.newObj = uVar7;
            lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
            if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249ec;
            if (*(int *)(lVar6.cityAreaID + 24) < 1) {
              lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
              if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249ec;
              if (*(int *)(lVar6.cityAreaID + 28) < 1) {
                lVar6 = GameObject.GetComponent(target,DAT_181dc7050);
                if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249ec;
                if (0 < *(int *)(lVar6.cityAreaID + 32)) {
                  if (((this.newObj == null) ||
                      (lVar6 = GameObject.get_transform(this.newObj,0)) == null) ||
                     (lVar6 = Transform.Find(lVar6,"Text",0)) == null) goto LAB_180a249ec;
                  uVar7 = Component.GetComponent(lVar6,DAT_181d96160);
                  LTLocalization.SetText(uVar7,"取消拆除",0);
                  iVar4 = AreaBuildController.DestroyBuildNeedForceLv;
                }
              }
              else {
                if (((this.newObj == null) ||
                    (lVar6 = GameObject.get_transform(this.newObj,0)) == null) ||
                   (lVar6 = Transform.Find(lVar6,"Text",0)) == null) goto LAB_180a249ec;
                uVar7 = Component.GetComponent(lVar6,DAT_181d96160);
                LTLocalization.SetText(uVar7,"取消升级",0);
                iVar4 = AreaBuildController.UpgradeBuildNeedForceLv;
              }
            }
            else {
              if (((this.newObj == null) ||
                  (lVar6 = GameObject.get_transform(this.newObj,0)) == null) ||
                 (lVar6 = Transform.Find(lVar6,"Text",0)) == null) goto LAB_180a249ec;
              uVar7 = Component.GetComponent(lVar6,DAT_181d96160);
              LTLocalization.SetText(uVar7,"取消建造",0);
              iVar4 = AreaBuildController.NewBuildNeedForceLv;
            }
            if (((GameController._instance == null) ||
                (lVar6 = GameController._instance.worldData) == null) ||
               (lVar6 = WorldData.Player(lVar6,0)) == null) goto LAB_180a249ec;
            if (iVar4 <= lVar6.forceMeetingStarted) {
              return;
            }
            if ((this.newObj == null) ||
               (lVar6 = GameObject.GetComponent(this.newObj,DAT_181dc7c00)) == null
               ) goto LAB_180a249ec;
            Selectable.set_interactable(lVar6,0,0);
            if (this.newObj == null) goto LAB_180a249ec;
            lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448);
            lVar9 = *(int64 *)(pStatics_3d40 + 0x3d8);
            if (lVar9 == null) goto LAB_180a249ec;
            uVar7 = FUN_180002f80(lVar9,iVar4,DAT_181da4358);
            uVar7 = GlobalData.GenerateRareLvColorText(uVar7,iVar4,0);
            uVar7 = String.Format("需要 {0}\n\n",uVar7,0);
            if (((this.newObj == null) ||
                (lVar9 = GameObject.GetComponent(this.newObj,DAT_181d73448), lVar9 == null
                )) || (uVar7 = String.Concat(uVar7,*(uint64 *)(lVar9 + 24),0), lVar6 == null))
            goto LAB_180a249ec;
            puVar13 = (uint64 *)(lVar6 + 24);
            *puVar13 = uVar7;
          }
          il2cpp_internal(puVar13,uVar7);
        }
        else {
          lVar6 = GameObject.GetComponent(target,DAT_181dc7270);
          if ((lVar6 == null) || (lVar6.cityAreaID == null)) goto LAB_180a249da;
          if (*(int *)(lVar6.cityAreaID + 48) != 1) goto LAB_180a23471;
          plVar8 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
          plVar12 = (int64 *)0;
          if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181daf348)) {
            plVar12 = plVar8;
          }
          NGUITools.PlaySound(plVar12,0);
          lVar6 = GameObject.GetComponent(target,DAT_181dc7270);
          if (((lVar6 == null) || (lVar6.cityAreaID == null)) ||
             (lVar6 = *(int64 *)(lVar6.cityAreaID + 56)) == null) goto LAB_180a249da;
          if (0.0 < (float)lVar6.cityAreaID) {
            AreaBuildController.ShowBuildChoiceGrid(this,1,0);
            uVar7 = this.buildChoiceGrid;
            uVar10 = this.buildChoiceButtonPrefab;
            uVar7 = GlobalData.AddChild(uVar7,uVar10,0);
            this.newObj = uVar7;
            if (((this.newObj != null) &&
                (lVar6 = GameObject.get_transform(this.newObj,0)) != null) &&
               (lVar6 = Transform.Find(lVar6,"Text",0)) != null) {
              uVar7 = Component.GetComponent(lVar6,DAT_181d96160);
              LTLocalization.SetText(uVar7,"取消升级",0);
              return;
            }
            goto LAB_180a249da;
          }
          lVar6 = GameObject.GetComponent(target,DAT_181dc7270);
          if (((lVar6 == null) || (lVar6.cityAreaID == null)) ||
             (lVar6 = *(int64 *)(lVar6.cityAreaID + 56)) == null) goto LAB_180a249da;
          if (*(int *)(lVar6 + 20) < 10) {
            uVar7 = this.buildChoiceGrid;
            uVar10 = this.buildChoiceButtonPrefab;
            uVar7 = GlobalData.AddChild(uVar7,uVar10,0);
            this.newObj = uVar7;
            if (((this.newObj == null) ||
                (lVar6 = GameObject.get_transform(this.newObj,0)) == null) ||
               (lVar6 = Transform.Find(lVar6,"Text",0)) == null) goto LAB_180a249da;
            uVar7 = Component.GetComponent(lVar6,DAT_181d96160);
            LTLocalization.SetText(uVar7,"升级",0);
            lVar6 = GameObject.GetComponent(target,DAT_181dc7270);
            if (((lVar6 == null) || (lVar6.cityAreaID == null)) ||
               (lVar6 = *(int64 *)(lVar6.cityAreaID + 56)) == null)
            goto LAB_180a249da;
            iVar4 = *(int *)(lVar6 + 20);
            lVar6 = FUN_18046bac0(0);
            if (((lVar6 == null) || (lVar6.TempHeros == null)) ||
               (lVar6 = AreaData.GetCenterBuilding(lVar6.TempHeros,0)) == null)
            goto LAB_180a249da;
            if (*(int *)(lVar6 + 20) <= iVar4) {
              if ((this.newObj == null) ||
                 (lVar6 = GameObject.GetComponent(this.newObj,DAT_181dc7c00),
                 lVar6 == null)) {
        LAB_180a249e6:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              Selectable.set_interactable(lVar6,0,0);
              if (this.newObj == null) goto LAB_180a249e6;
              lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448);
              uVar7 = *(uint64 *)(pStatics_3d40 + 0x2d0);
              lVar9 = PlotController.SpringFestivelRewardLvTalkText;
              if ((((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 88)) == null) ||
                  (lVar9 = AreaData.GetCenterBuilding(lVar9,0)) == null) ||
                 (lVar9 = AreaBuildingData.DataBase(lVar9,0)) == null) goto LAB_180a249e6;
              uVar7 = String.Concat(uVar7,*(uint64 *)(lVar9 + 24),0);
              lVar9 = GameObject.GetComponent(target,DAT_181dc7270);
              if (((lVar9 == null) || (*(int64 *)(lVar9 + 24) == 0)) ||
                 (lVar9 = *(int64 *)(*(int64 *)(lVar9 + 24) + 56)) == null)
              goto LAB_180a249e6;
              local_res8[0] = *(int *)(lVar9 + 20) + 1;
              uVar10 = il2cpp_value_box(DAT_181d80418,local_res8);
              uVar7 = String.Format("需要\n{0} {1}级</color>\n\n",uVar7,uVar10,0);
              if (lVar6 == null) goto LAB_180a249e6;
              lVar6.cityAreaID = uVar7;
            }
            lVar6 = FUN_18046c0a0(0);
            if ((lVar6 == null) || (lVar6.villageAreaID == null)) goto LAB_180a249da;
            lVar6 = WorldData.GetHeroForce(lVar6.villageAreaID,0,0);
            lVar9 = GameObject.GetComponent(target,DAT_181dc7270);
            if ((lVar9 == null) ||
               (((*(int64 *)(lVar9 + 24) == 0 ||
                 (lVar9 = *(int64 *)(*(int64 *)(lVar9 + 24) + 56)) == null) ||
                (uVar7 = AreaRoadData.GetUpgradeCostResource(lVar9,0), lVar6 == null)))) goto LAB_180a249da;
            cVar1 = ForceData.HaveResource(lVar6,uVar7,0);
            if (!cVar1) {
              if ((this.newObj == null) ||
                 (lVar6 = GameObject.GetComponent(this.newObj,DAT_181dc7c00),
                 lVar6 == null)) goto LAB_180a249da;
              Selectable.set_interactable(lVar6,0,0);
            }
            lVar6 = FUN_18046c0a0(0);
            if (((lVar6 == null) || (lVar6.villageAreaID == null)) ||
               (lVar6 = WorldData.Player(lVar6.villageAreaID,0)) == null) goto LAB_180a249da;
            iVar4 = lVar6.forceMeetingStarted;
            if (iVar4 < AreaBuildController.UpgradeRoadNeedForceLv) {
              if ((this.newObj == null) ||
                 (lVar6 = GameObject.GetComponent(this.newObj,DAT_181dc7c00),
                 lVar6 == null)) goto LAB_180a249da;
              Selectable.set_interactable(lVar6,0,0);
              if (this.newObj == null) goto LAB_180a249da;
              lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448);
              lVar9 = *(int64 *)(pStatics_3d40 + 0x3d8);
              if (lVar9 == null) goto LAB_180a249da;
              uVar7 = FUN_180002f80(lVar9,AreaBuildController.UpgradeRoadNeedForceLv,
                                    DAT_181da4358);
              uVar7 = GlobalData.GenerateRareLvColorText
                                (uVar7,AreaBuildController.UpgradeRoadNeedForceLv,0);
              uVar7 = String.Format("需要 {0}\n\n",uVar7,0);
              if (((this.newObj == null) ||
                  (lVar9 = GameObject.GetComponent(this.newObj,DAT_181d73448),
                  lVar9 == null)) ||
                 (uVar7 = String.Concat(uVar7,*(uint64 *)(lVar9 + 24),0), lVar6 == null))
              goto LAB_180a249da;
              lVar6.cityAreaID = uVar7;
            }
            if ((this.newObj == null) ||
               (lVar6 = GameObject.GetComponent(this.newObj,DAT_181d73448)) == null
               ) goto LAB_180a249da;
            puVar13 = (uint64 *)(lVar6 + 24);
            uVar7 = *puVar13;
            lVar6 = GameObject.GetComponent(target,DAT_181dc7270);
            if ((lVar6 == null) ||
               ((lVar6.cityAreaID == null ||
                (lVar6 = *(int64 *)(lVar6.cityAreaID + 56)) == null)))
            goto LAB_180a249da;
            uVar10 = AreaRoadData.GetUpgradeCostText(lVar6,0);
            uVar7 = String.Concat(uVar7,uVar10,0);
            *puVar13 = uVar7;
            il2cpp_internal(puVar13,uVar7);
          }
          if ((this.buildChoiceGrid == null) ||
             (lVar6 = GameObject.get_transform(this.buildChoiceGrid,0)) == null)
          goto LAB_180a249da;
        LAB_180a2344d:
          iVar4 = Transform.get_childCount(lVar6,0);
          if (0 < iVar4) {
            AreaBuildController.ShowBuildChoiceGrid(this,1,0);
          }
        }
        return;
        LAB_180a22a50:
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar6 = lVar6.speBuildingUnlocked) == null) goto LAB_180a249da;
        if (lVar6.cityAreaID <= (int)plVar14) {
          return;
        }
        lVar6 = FUN_18046bac0(0);
        if (lVar6 == null) goto LAB_180a249da;
        lVar6 = lVar6.TempHeros;
        lVar9 = FUN_18046c0a0(0);
        if ((((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
            (lVar9 = *(int64 *)(*(int64 *)(lVar9 + 32) + 0x180)) == null) ||
           (uVar3 = FUN_1800d6760(lVar9,plVar14,DAT_181d8fa18), lVar6 == null)) goto LAB_180a249da;
        lVar6 = AreaData.FindBuilding(lVar6,uVar3,0);
        if (lVar6 == null) {
          lVar6 = FUN_18046c0a0(0);
          if (((lVar6 == null) || (lVar6.villageAreaID == null)) ||
             (lVar6 = *(int64 *)(lVar6.villageAreaID + 0x180)) == null) goto LAB_180a249da;
          uVar3 = FUN_1800d6760(lVar6,plVar14,DAT_181d8fa18);
          AreaBuildController.GenerateBuildNewButton(this,uVar3,0);
        }
        plVar14 = (int64 *)(uint64)((int)plVar14 + 1);
        goto LAB_180a22a50;
    }

    // Token : 0x6000A41
    // RVA   : 0xA21680   Offset: 0xA20A80   Length: 0x6AF
    public void MoveBuildTarget(GameObject target)
    {
        long lVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        long lVar8;
        uVar6 = this.buildTargetObj;
        cVar2 = Object.op_Equality(target,uVar6,0);
        if (cVar2) {
          plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
          plVar9 = (int64 *)0;
          if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181daf348)) {
            plVar9 = plVar10;
          }
          NGUITools.PlaySound(plVar9,0);
          return;
        }
        if (this.buildTargetObj != null) {
          lVar4 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050);
          if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
            plVar10 = (int64 *)0;
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 24);
            if (this.buildTargetObj != null) {
              lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050);
              if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 24), target != null)) {
                uVar6 = GameObject.GetComponent(target,DAT_181dc7270);
                cVar2 = Object.op_Inequality(uVar6,0,0);
                if (!cVar2) {
                  lVar7 = GameObject.GetComponent(target,DAT_181dc7050);
                  if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
                  lVar7 = *(int64 *)(*(int64 *)(lVar7 + 32) + 24);
                  lVar8 = GameObject.GetComponent(target,DAT_181dc7050);
                  if (lVar8 == null) throw; // [null/range check failed]
                  plVar9 = lVar8.TestBuildPlayer;
                }
                else {
                  lVar7 = GameObject.GetComponent(target,DAT_181dc7270);
                  if (lVar7 == null) throw; // [null/range check failed]
                  lVar7 = *(int64 *)(lVar7 + 24);
                  plVar9 = plVar10;
                }
                lVar8 = GameController._instance;
                lVar1 = PlotController.SpringFestivelRewardLvTalkText;
                if ((lVar1 != null) && (lVar8 != null)) {
                  GameController.DestroyBuilding(lVar8,*(uint64 *)(lVar1 + 88),lVar4,0,0);
                  lVar8 = GameController._instance;
                  lVar1 = PlotController.SpringFestivelRewardLvTalkText;
                  if ((lVar1 != null) && (lVar8 != null)) {
                    GameController.DestroyBuilding(lVar8,*(uint64 *)(lVar1 + 88),lVar7,0,0);
                    if (lVar7 != null) {
                      *(int64 *)(lVar7 + 40) = lVar5;
                      lVar8 = *(int64 *)(lVar7 + 40);
                      if (lVar5 != null) {
                        uVar3 = AreaBuildingData.GetMoveTime(lVar5,0);
                        if (lVar8 != null) {
                          lVar8.TestBuildPlayer = uVar3;
                          if (*(int64 *)(lVar7 + 40) != 0) {
                            *(uint8 *)(*(int64 *)(lVar7 + 40) + 36) = 1;
                            if (plVar9 != (int64 *)0) {
                              if (lVar4 == null) throw; // [null/range check failed]
                              *(int64 **)(lVar4 + 40) = plVar9;
                              lVar5 = *(int64 *)(lVar4 + 40);
                              uVar3 = AreaBuildingData.GetMoveTime(plVar9,0);
                              if (lVar5 == null) throw; // [null/range check failed]
                              *(uint32 *)(lVar5 + 24) = uVar3;
                              if (*(int64 *)(lVar4 + 40) == 0) throw; // [null/range check failed]
                              *(uint8 *)(*(int64 *)(lVar4 + 40) + 36) = 1;
                            }
                            lVar5 = PlotController.SpringFestivelRewardLvTalkText;
                            if (lVar5 != null) {
                              lVar8 = *(int64 *)(lVar5 + 88);
                              if ((lVar8 != null) && (*(int *)(lVar8 + 16) == *(int *)(lVar7 + 64))) {
                                if (*(int64 *)(lVar8 + 192) == 0) throw; // [null/range check failed]
                                uVar3 = FUN_1817eb4e0(*(int64 *)(lVar8 + 192),lVar7,DAT_181d7c8e0);
                                AreaController.GenerateTileBuilding(lVar5,uVar3,0);
                              }
                              lVar5 = PlotController.SpringFestivelRewardLvTalkText;
                              if (lVar5 != null) {
                                lVar7 = *(int64 *)(lVar5 + 88);
                                if (((lVar7 != null) && (lVar4 != null)) &&
                                   (*(int *)(lVar7 + 16) == *(int *)(lVar4 + 64))) {
                                  if (*(int64 *)(lVar7 + 192) == 0) throw; // [null/range check failed]
                                  uVar3 = FUN_1817eb4e0(*(int64 *)(lVar7 + 192),lVar4,DAT_181d7c8e0);
                                  AreaController.GenerateTileBuilding(lVar5,uVar3,0);
                                }
                                AreaBuildController.CloseBuildMenu(this,0);
                                plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/WoodWork",0);
                                if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181daf348)) {
                                  plVar10 = plVar9;
                                }
                                NGUITools.PlaySound(plVar10,0);
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

    // Token : 0x6000A42
    // RVA   : 0xA1FFD0   Offset: 0xA1F3D0   Length: 0x539
    public void BuildNewButtonClicked(GameObject buttonClicked)
    {
        uint uVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        if (this.buildTargetObj != null) {
          uVar4 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7270);
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (!cVar2) {
            return;
          }
          if (((this.buildTargetObj != null) &&
              (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7270)) != null)
             && (*(int64 *)(lVar5 + 24) != 0)) {
            if (*(int *)(*(int64 *)(lVar5 + 24) + 48) != 0) {
              return;
            }
            if (((this.buildTargetObj != null) &&
                (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7270), lVar5 != null
                )) && ((lVar5 = *(int64 *)(lVar5 + 24), buttonClicked != null &&
                       (lVar6 = GameObject.GetComponent(buttonClicked,DAT_181dc7a68)) != null))) {
              uVar3 = *(uint32 *)(lVar6 + 24);
              lVar6 = FUN_18046bac0(0);
              if ((lVar6 != null) && (*(int64 *)(lVar6 + 88) != 0)) {
                uVar1 = *(uint32 *)(*(int64 *)(lVar6 + 88) + 16);
                lVar6 = il2cpp_internal(DAT_181dac558);
                *(uint32 *)(lVar6 + 56) = 0x3f800000;
                *(uint32 *)(lVar6 + 60) = 0x3f800000;
                *(uint32 *)(lVar6 + 68) = 0xffffffff;
                ZhSegment.Initialize(lVar6,0);
                *(uint32 *)(lVar6 + 16) = uVar3;
                *(uint32 *)(lVar6 + 20) = 0;
                *(uint32 *)(lVar6 + 64) = uVar1;
                uVar4 = new ItemListData(0);
                *(uint64 *)(lVar6 + 40) = uVar4;
                uVar4 = il2cpp_internal(DAT_181d94b50);
                FUN_18132faf0(uVar4,DAT_181d94888);
                *(uint64 *)(lVar6 + 48) = uVar4;
                *(float *)(lVar6 + 60) = (float)*(int *)(lVar6 + 20) * 0.2 + 1.0;
                if (lVar5 != null) {
                  plVar8 = (int64 *)(lVar5 + 40);
                  *plVar8 = lVar6;
                  il2cpp_internal(plVar8,lVar6);
                  if (((this.buildTargetObj != null) &&
                      (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7270),
                      lVar5 != null)) && (*(int64 *)(lVar5 + 24) != 0)) {
                    lVar5 = *(int64 *)(*(int64 *)(lVar5 + 24) + 40);
                    if (((this.buildTargetObj != null) &&
                        (lVar6 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7270),
                        lVar6 != null)) &&
                       ((*(int64 *)(lVar6 + 24) != 0 &&
                        ((lVar6 = *(int64 *)(*(int64 *)(lVar6 + 24) + 40), lVar6 != null &&
                         (lVar7 = AreaBuildingData.DataBase(lVar6,0)) != null))))) {
                      AreaBuildingData.GetBuildSpeedRate(lVar6,0);
                      uVar3 = Mathf.RoundToInt();
                      uVar3 = Mathf.Max(1,uVar3,0);
                      if (lVar5 != null) {
                        *(uint32 *)(lVar5 + 24) = uVar3;
                        lVar5 = FUN_18046bac0(0);
                        lVar6 = FUN_18046bac0(0);
                        if (((lVar6 != null) && (*(int64 *)(lVar6 + 160) != 0)) &&
                           (uVar3 = FUN_1817eb4e0(*(int64 *)(lVar6 + 160),
                                                  this.buildTargetObj,DAT_181d89518),
                           lVar5 != null)) {
                          AreaController.GenerateTileBuilding(lVar5,uVar3,0);
                          lVar5 = FUN_18046c0a0(0);
                          if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
                            lVar5 = WorldData.GetHeroForce(*(int64 *)(lVar5 + 32),0,0);
                            lVar6 = FUN_18046c100(0);
                            if (lVar6 != null) {
                              lVar6 = *(int64 *)(lVar6 + 224);
                              lVar7 = GameObject.GetComponent(buttonClicked,DAT_181dc7a68);
                              if ((((lVar7 != null) && (lVar6 != null)) &&
                                  (lVar6 = FUN_1817d9e10(lVar6,*(uint32 *)(lVar7 + 24),DAT_181db7bd8
                                                        ), lVar6 != null)) &&
                                 (uVar4 = AreaBuildingDataBase.GetBuildCostResource(lVar6,0x3f800000,0),
                                 lVar5 != null)) {
                                ForceData.CostResource(lVar5,uVar4,0,0);
                                AreaBuildController.CloseBuildMenu(this,0);
                                plVar8 = (int64 *)Resources.Load("Sound/SoundEffect/WoodWork",0);
                                plVar9 = (int64 *)0;
                                if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181daf348)) {
                                  plVar9 = plVar8;
                                }
                                NGUITools.PlaySound(plVar9,0);
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

    // Token : 0x6000A43
    // RVA   : 0xA1F390   Offset: 0xA1E790   Length: 0xC2F
    public void BuildChoiceButtonClicked(GameObject buttonClicked)
    {
        var pStatics_b428 = *(int64*)(DAT_181dbb428 + 184);
        float fVar1;
        int iVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        ulong uVar7;
        ulong uVar8;
        long lVar9;
        float fVar11;
        if ((((buttonClicked == null) || (lVar5 = GameObject.get_transform(buttonClicked,0)) == null) ||
            (lVar5 = Transform.Find(lVar5,"Text",0)) == null) ||
           (plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181d96160), plVar6 == (int64 *)0))
        goto LAB_180a1ffba;
        uVar7 = (**(code **)(*plVar6 + 0x5d8))(plVar6,*(uint64 *)(*plVar6 + 0x5e0));
        if (this.buildTargetObj == null) goto LAB_180a1ffba;
        uVar8 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7270);
        cVar3 = Object.op_Inequality(uVar8,0,0);
        if (!cVar3) {
        LAB_180a1f7fa:
          if (this.buildTargetObj == null) goto LAB_180a1ffba;
          uVar8 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050);
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (!cVar3) {
            return;
          }
          uVar8 = LTLocalization.GetText("拆除",0,1,0);
          cVar3 = FUN_18171e540(uVar7,uVar8,0);
          if (cVar3) {
            if ((((this.buildTargetObj == null) ||
                 (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050),
                 lVar5 == null)) || (*(int64 *)(lVar5 + 32) == 0)) ||
               (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 24)) == null)
            goto LAB_180a1ffba;
            lVar5 = *(int64 *)(lVar5 + 40);
            if ((((this.buildTargetObj == null) ||
                 (lVar9 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050),
                 lVar9 == null)) ||
                ((lVar9.villageAreaID == null ||
                 ((lVar9 = *(int64 *)(lVar9.villageAreaID + 24), lVar9 == null ||
                  (lVar9 = lVar9.forceAreaID) == null))))) ||
               (uVar4 = AreaBuildingData.GetDestroyTime(lVar9,0), lVar5 == null)) goto LAB_180a1ffba;
            *(uint32 *)(lVar5 + 32) = uVar4;
            if ((((this.buildTargetObj == null) ||
                 (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050),
                 lVar5 == null)) || (*(int64 *)(lVar5 + 32) == 0)) ||
               ((lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 24), lVar5 == null ||
                (lVar5 = *(int64 *)(lVar5 + 40)) == null))) goto LAB_180a1ffba;
            *(uint8 *)(lVar5 + 36) = 0;
            if ((this.buildTargetObj == null) ||
               ((lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050), lVar5 == null
                || (*(int64 *)(lVar5 + 24) == 0)))) goto LAB_180a1ffba;
            if (*(int *)(*(int64 *)(lVar5 + 24) + 16) == -1) {
              lVar5 = FUN_18046c0a0(0);
              if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) goto LAB_180a1ffba;
              lVar5 = WorldData.GetHeroForce(*(int64 *)(lVar5 + 32),0,0);
              if ((this.buildTargetObj == null) ||
                 ((((lVar9 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050),
                    lVar9 == null || (lVar9.villageAreaID == null)) ||
                   (lVar9 = *(int64 *)(lVar9.villageAreaID + 24)) == null) ||
                  ((lVar9.forceAreaID == null ||
                   (uVar7 = AreaBuildingData.GetObstacleRemoveCostResource(), lVar5 == null))))))
              goto LAB_180a1ffba;
              ForceData.CostResource(lVar5,uVar7,0,0);
            }
            AreaBuildController.CloseBuildMenu(this,0);
            uVar7 = "Sound/SoundEffect/TearDown";
        LAB_180a1f79e:
            plVar6 = (int64 *)Resources.Load(uVar7,0);
            goto LAB_180a1f7c8;
          }
          uVar8 = LTLocalization.GetText("升级",0,1,0);
          cVar3 = FUN_18171e540(uVar7,uVar8,0);
          if (cVar3) {
            if (((this.buildTargetObj == null) ||
                (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050), lVar5 == null
                )) || ((*(int64 *)(lVar5 + 32) == 0 ||
                       (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 24)) == null)))
            goto LAB_180a1ffba;
            lVar5 = *(int64 *)(lVar5 + 40);
            if (lVar5 == null) goto LAB_180a1ffba;
            iVar2 = *(int *)(lVar5 + 20);
            lVar9 = AreaBuildingData.DataBase(lVar5,0);
            if (lVar9 == null) goto LAB_180a1ffba;
            fVar1 = lVar9.TempHeros;
            fVar11 = (float)AreaBuildingData.GetBuildSpeedRate(lVar5,0);
            uVar4 = Mathf.RoundToInt(((float)(iVar2 + 1) * fVar1) / fVar11,0);
            uVar4 = Mathf.Max(1,uVar4);
            *(uint32 *)(lVar5 + 28) = uVar4;
            *(uint8 *)(lVar5 + 36) = 0;
            if ((GameController._instance == null) ||
               (lVar9 = GameController._instance.worldData) == null)
            goto LAB_180a1ffba;
            lVar9 = WorldData.GetHeroForce(lVar9,0,0);
            uVar7 = AreaBuildingData.GetUpgradeCostResource(lVar5);
            goto joined_r0x000180a1fdd5;
          }
          uVar8 = LTLocalization.GetText("迁移",0,1,0);
          cVar3 = FUN_18171e540(uVar7,uVar8,0);
          if (cVar3) {
            this.buildModeMovingBuilding = 1;
            cVar3 = true;
            if (!DAT_181e9d6de) {
              il2cpp_runtime_class_init(&DAT_181dbb428);
              DAT_181e9d6de = true;
              cVar3 = this.buildModeMovingBuilding;
            }
            if (*pStatics_b428 != 0) {
              uVar7 = 4;
              if (!cVar3) {
                uVar7 = 2;
              }
              CursorManager.ChangeCursorType(*pStatics_b428,uVar7,0);
              if (this.buildChoiceGrid != null) {
                GameObject.SetActive(this.buildChoiceGrid,0,0);
                return;
              }
            }
            goto LAB_180a1ffba;
          }
          uVar8 = LTLocalization.GetText("取消建造",0,1,0);
          cVar3 = FUN_18171e540(uVar7,uVar8,0);
          if (!cVar3) {
            uVar8 = LTLocalization.GetText("取消升级",0,1,0);
            cVar3 = FUN_18171e540(uVar7,uVar8,0);
            if (!cVar3) {
              uVar8 = LTLocalization.GetText("取消拆除",0,1,0);
              cVar3 = FUN_18171e540(uVar7,uVar8,0);
              if (!cVar3) {
                return;
              }
              if ((((this.buildTargetObj == null) ||
                   (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050),
                   lVar5 == null)) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 ((lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 24), lVar5 == null ||
                  (lVar5 = *(int64 *)(lVar5 + 40)) == null))) goto LAB_180a1ffba;
              *(uint32 *)(lVar5 + 32) = 0;
            }
            else {
              if ((((this.buildTargetObj == null) ||
                   (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050),
                   lVar5 == null)) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 ((lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 24), lVar5 == null ||
                  (lVar5 = *(int64 *)(lVar5 + 40)) == null))) goto LAB_180a1ffba;
              *(uint32 *)(lVar5 + 28) = 0;
            }
          }
          else {
            lVar5 = FUN_18046c0a0(0);
            lVar9 = FUN_18046bac0(0);
            if (lVar9 == null) goto LAB_180a1ffba;
            uVar7 = lVar9.TempHeros;
            if ((((this.buildTargetObj == null) ||
                 (lVar9 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050),
                 lVar9 == null)) || (lVar9.villageAreaID == null)) || (lVar5 == null)) goto LAB_180a1ffba;
            GameController.DestroyBuilding
                      (lVar5,uVar7,*(uint64 *)(lVar9.villageAreaID + 24),0,0);
            if ((this.buildTargetObj == null) ||
               (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7050)) == null
               ) goto LAB_180a1ffba;
            AreaBuildingIconController.SelfDestroy(lVar5,0);
          }
        }
        else {
          if (((this.buildTargetObj == null) ||
              (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7270)) == null)
             || (*(int64 *)(lVar5 + 24) == 0)) goto LAB_180a1ffba;
          if (*(int *)(*(int64 *)(lVar5 + 24) + 48) != 1) goto LAB_180a1f7fa;
          uVar8 = LTLocalization.GetText("升级",0,1,0);
          cVar3 = FUN_18171e540(uVar7,uVar8,0);
          if (cVar3) {
            if (((this.buildTargetObj == null) ||
                (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7270), lVar5 == null
                )) || (*(int64 *)(lVar5 + 24) == 0)) goto LAB_180a1ffba;
            lVar5 = *(int64 *)(*(int64 *)(lVar5 + 24) + 56);
            if (((this.buildTargetObj == null) ||
                (lVar9 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7270), lVar9 == null
                )) || ((lVar9.cityAreaID == null ||
                       ((lVar9 = *(int64 *)(lVar9.cityAreaID + 56), lVar9 == null ||
                        (uVar4 = AreaRoadData.GetUpgradeTime(lVar9,0), lVar5 == null))))))
            goto LAB_180a1ffba;
            *(uint32 *)(lVar5 + 24) = uVar4;
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) goto LAB_180a1ffba;
            lVar9 = WorldData.GetHeroForce(*(int64 *)(lVar5 + 32),0,0);
            if ((this.buildTargetObj == null) ||
               (((lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7270),
                 lVar5 == null || (*(int64 *)(lVar5 + 24) == 0)) ||
                (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 24) + 56)) == null)))
            goto LAB_180a1ffba;
            uVar7 = AreaRoadData.GetUpgradeCostResource(lVar5,0);
        joined_r0x000180a1fdd5:
            if (lVar9 == null) {
        LAB_180a1ffba:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            ForceData.CostResource(lVar9,uVar7,0,0);
            AreaBuildController.CloseBuildMenu(this,0);
            uVar7 = "Sound/SoundEffect/WoodWork";
            goto LAB_180a1f79e;
          }
          uVar8 = LTLocalization.GetText("取消升级",0,1,0);
          cVar3 = FUN_18171e540(uVar7,uVar8,0);
          if (!cVar3) {
            return;
          }
          if ((((this.buildTargetObj == null) ||
               (lVar5 = GameObject.GetComponent(this.buildTargetObj,DAT_181dc7270)) == null
               ) || (*(int64 *)(lVar5 + 24) == 0)) ||
             (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 24) + 56)) == null) goto LAB_180a1ffba;
          *(uint32 *)(lVar5 + 24) = 0;
        }
        AreaBuildController.CloseBuildMenu(this,0);
        plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Fail",0);
        LAB_180a1f7c8:
        plVar10 = (int64 *)0;
        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf348)) {
          plVar10 = plVar6;
        }
        NGUITools.PlaySound(plVar10,0);
    }

    // Token : 0x6000A44
    // RVA   : 0xA21D30   Offset: 0xA21130   Length: 0x15C
    public void PlayerUpgradeBuilding(AreaBuildingData targetBuilding)
    {
        float fVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        if (targetBuilding != null) {
          iVar2 = *(int *)(targetBuilding + 20);
          lVar4 = AreaBuildingData.DataBase(targetBuilding,0);
          if (lVar4 != null) {
            fVar1 = lVar4.TempHeros;
            fVar6 = (float)AreaBuildingData.GetBuildSpeedRate(targetBuilding,0);
            uVar3 = Mathf.RoundToInt(((float)(iVar2 + 1) * fVar1) / fVar6,0);
            uVar3 = Mathf.Max(1,uVar3);
            *(uint32 *)(targetBuilding + 28) = uVar3;
            *(uint8 *)(targetBuilding + 36) = 0;
            if ((GameController._instance != null) &&
               (lVar4 = GameController._instance.worldData) != null) {
              lVar4 = WorldData.GetHeroForce(lVar4,0,0);
              uVar5 = AreaBuildingData.GetUpgradeCostResource(targetBuilding);
              if (lVar4 != null) {
                ForceData.CostResource(lVar4,uVar5,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000A45
    // RVA   : 0xA24A00   Offset: 0xA23E00   Length: 0xC4
    public void ShowBuildChoiceGrid(bool show)
    {
        long lVar1;
        ulong uVar3;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar1 = this.buildChoiceGrid;
        if (!show) {
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,0,0);
            return;
          }
        }
        else if (lVar1 != null) {
          GameObject.SetActive(lVar1,1,0);
          if (this.buildChoiceGrid != null) {
            lVar1 = GameObject.get_transform(this.buildChoiceGrid,0);
            puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
            if (lVar1 != null) {
              local_20 = *(uint32 *)(puVar2 + 1);
              local_28 = *puVar2;
              Transform.set_localScale(lVar1,&local_28,0);
              if (this.buildChoiceGrid != null) {
                uVar3 = GameObject.get_transform(this.buildChoiceGrid,0);
                ShortcutExtensions.DOScale(uVar3,0x3f800000,0x3e19999a,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000A46
    // RVA   : 0xA24AD0   Offset: 0xA23ED0   Length: 0xC4
    public void ShowBuildNewPanel(bool show)
    {
        long lVar1;
        ulong uVar3;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        lVar1 = this.buildNewPanel;
        if (!show) {
          if (lVar1 != null) {
            GameObject.SetActive(lVar1,0,0);
            return;
          }
        }
        else if (lVar1 != null) {
          GameObject.SetActive(lVar1,1,0);
          if (this.buildNewPanel != null) {
            lVar1 = GameObject.get_transform(this.buildNewPanel,0);
            puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
            if (lVar1 != null) {
              local_20 = *(uint32 *)(puVar2 + 1);
              local_28 = *puVar2;
              Transform.set_localScale(lVar1,&local_28,0);
              if (this.buildNewPanel != null) {
                uVar3 = GameObject.get_transform(this.buildNewPanel,0);
                ShortcutExtensions.DOScale(uVar3,0x3f800000,0x3e19999a,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000A47
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000A48
    // RVA   : 0xA25760   Offset: 0xA24B60   Length: 0x20C
    private static void /*cctor*/()
    {
        long lVar1;
        **(uint64 **)(DAT_181dac458 + 184) = "♦在己方区域移动/升级/建造建筑";
        il2cpp_internal();
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"杂草",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"砂砾",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"碎石",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"残垣",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"废墟",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"池泽",DAT_181da3d58);
          AreaBuildController.AreaObstacleName = lVar1;
          AreaBuildController.UpgradeBuildNeedForceLv = 3;
          AreaBuildController.NewBuildNeedForceLv = 4;
          AreaBuildController.DestroyBuildNeedForceLv = 4;
          AreaBuildController.MoveBuildNeedForceLv = 5;
          AreaBuildController.UpgradeRoadNeedForceLv = 5;
          AreaBuildController.MaxSpeBuildingNum = 5;
          return;
        }
    }

}
