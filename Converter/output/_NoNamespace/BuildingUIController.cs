// ============================================================
// Type  : BuildingUIController
// Token : 0x20001AA
// ============================================================

public class BuildingUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B2F
    public AreaBuildingData buildingData;

    // Token: 0x4000B30
    public GameObject buildingButtonGrid;

    // Token: 0x4000B31
    public GameObject buildingButtonPrefab;

    // Token: 0x4000B32
    public AreaBuildingChoice buildingChoiceSelected;

    // Token: 0x4000B33
    private GameObject newButton;

    // Token: 0x4000B34
    public static float InsideBuildingVolumn;

    // Token: 0x4000B35
    private float refreshTime;

    // Token: 0x4000B36
    private static BuildingUIController _instance;

    // Token: 0x4000B37
    private AreaBuildingData targetBuildingData;

    // Token: 0x4000B38
    private Vector3 showPosition;

    // Token: 0x4000B39
    public static List<string> CheckHideBuildingChoice;

    // Token: 0x4000B3A
    public static List<string> PartyLvName;

    // Token: 0x4000B3B
    private List<string> ProduceBuildingWorkText;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D9D
    // RVA   : 0xBD2C20   Offset: 0xBD1420   Length: 0x58
    public static BuildingUIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 8);
    }

    // Token : 0x6000D9E
    // RVA   : 0xBB7230   Offset: 0xBB5A30   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000D9F
    // RVA   : 0xBCD5D0   Offset: 0xBCBDD0   Length: 0x12
    private void Start()
    {
        void FUN_180bcd5d0(int64 this)
        {
        this.buildingData = 0;
    }

    // Token : 0x6000DA0
    // RVA   : 0xBD20E0   Offset: 0xBD08E0   Length: 0x97
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        long lVar1;
        bool cVar2;
        float fVar3;
        float fVar4;
        if (this.buildingData != null) {
          if ((*pStatics == 0) ||
             (lVar1 = *(int64 *)(*pStatics + 72)) == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar2 = GameObject.get_activeInHierarchy(lVar1,0);
          if (cVar2) {
            fVar4 = this.refreshTime;
            fVar3 = (float)Time.get_deltaTime(0);
            fVar4 = fVar4 - fVar3;
            this.refreshTime = fVar4;
            if (fVar4 <= 0.0) {
              BuildingUIController.RefreshBuildingUI(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000DA1
    // RVA   : 0xBB9FF0   Offset: 0xBB87F0   Length: 0x2AE
    public void EnterBuilding(AreaBuildingData _targetBuildingData, Vector3 _showPosition)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong local_18;
        uint local_10;
        this.targetBuildingData = _targetBuildingData;
        uVar1 = *(uint32 *)(_showPosition + 1);
        this.showPosition = *_showPosition;
        *(uint32 *)(this + 88) = uVar1;
        if (this.targetBuildingData != null) {
          if (this.targetBuildingData.buildingID != 15) {
        LAB_180bba271:
            local_18 = this.showPosition;
            local_10 = *(uint32 *)(this + 88);
            BuildingUIController.ShowBuildingUI(this,this.targetBuildingData,&local_18,0);
            return;
          }
          if (((*pStatics != 0) &&
              (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar3 = WorldData.Player(lVar3,0)) != null) {
            iVar2 = HeroData.GetBountyPirce(lVar3,0);
            if (iVar2 < 1) goto LAB_180bba271;
            lVar3 = FUN_18046c440(0);
            lVar4 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar4,DAT_181d7c250);
            if (lVar4 != null) {
              FUN_181827900(lVar4,"冒险一试;PlotSureEnterBuilding",DAT_181d7c3d0);
              FUN_181827900(lVar4,"还是算了;HideInteractUI",DAT_181d7c3d0);
              uVar5 = new SinglePlotData("眼下正被官差通缉，若是贸然进入官府重地，很可能会被抓捕。\n还需三思而后行才是......",lVar4,1,0,3,"0",1,0,0);
              if (lVar3 != null) {
                PlotController.AddPlot(lVar3,uVar5,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000DA2
    // RVA   : 0xBD1F70   Offset: 0xBD0770   Length: 0x2C
    public void SureEnterBuilding()
    {
        ulong local_18;
        uint local_10;
        local_18 = this.showPosition;
        local_10 = *(uint32 *)(this + 88);
        BuildingUIController.ShowBuildingUI(local_18,this.targetBuildingData,&local_18,0);
    }

    // Token : 0x6000DA3
    // RVA   : 0xBC3DB0   Offset: 0xBC25B0   Length: 0x1350
    public void ShowBuildingUI(AreaBuildingData targetBuildingData, Vector3 showPosition)
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        var pStatics_edf8 = *(int64*)(DAT_181d9edf8 + 184);
        bool cVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar6;
        ulong uVar7;
        uint[] local_res8 = new uint[2];
        uint[] local_res10 = new uint[2];
        ulong uVar11;
        ulong local_68;
        uint uStack_60;
        uint32 uStack_5c;
        uint64 local_58;
        uint64 uStack_50;
        plVar8 = (int64 *)0;
        this.buildingData = targetBuildingData;
        local_res8[0] = 0;
        il2cpp_internal(this + 24,targetBuildingData);
        if ((*pStatics_e188 == 0) ||
           (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null)
        throw; // [null/range check failed]
        GameObject.SetActive(lVar3,1,0);
        if (((((*pStatics_e188 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
             (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
            ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"BuildingButtonScrollView",0)) == null))) ||
           (lVar3 = Component.GetComponent(lVar3,DAT_181d6c940)) == null) throw; // [null/range check failed]
        Behaviour.set_enabled(lVar3,0,0);
        if (((*pStatics_e188 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
           (lVar3 = GameObject.get_transform(lVar3,0)) == null) throw; // [null/range check failed]
        lVar3 = Transform.Find(lVar3,"BuildingUI",0);
        if (((((*pStatics_e188 == 0) ||
              (lVar4 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
             (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
            ((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 == null ||
             (lVar4 = Component.get_transform(lVar4,0)) == null))) ||
           (lVar4 = FUN_180da0f00(lVar4,0)) == null) throw; // [null/range check failed]
        uStack_60 = *(uint32 *)(showPosition + 1);
        local_68 = *showPosition;
        puVar5 = (uint64 *)Transform.InverseTransformPoint(&local_58,lVar4,&local_68,0);
        if (lVar3 == null) throw; // [null/range check failed]
        local_68 = *puVar5;
        uStack_60 = *(uint32 *)(puVar5 + 1);
        Transform.set_localPosition(lVar3,&local_68,0);
        if (((*pStatics_e188 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
           (lVar3 = GameObject.get_transform(lVar3,0)) == null) throw; // [null/range check failed]
        uVar6 = Transform.Find(lVar3,"BuildingUI",0);
        puVar5 = (uint64 *)Vector3.get_zero(&local_58,0);
        uVar11 = 0;
        uStack_60 = *(uint32 *)(puVar5 + 1);
        local_68 = *puVar5;
        uVar6 = ShortcutExtensions.DOMove(uVar6,&local_68,0x3e4ccccd,0,0);
        uVar6 = TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181d98af0);
        lVar3 = *(int64 *)(pStatics_edf8 + 8);
        if (lVar3 == null) {
          uVar7 = **(uint64 **)(DAT_181d9edf8 + 184);
          lVar3 = new OnTooltipCB(uVar7,DAT_181d6fa98,0);
          plVar9 = (int64 *)(pStatics_edf8 + 8);
          *plVar9 = lVar3;
          il2cpp_internal(plVar9,lVar3);
        }
        TweenSettingsExtensions.OnComplete(uVar6,lVar3,DAT_181d96ee8);
        if ((((*pStatics_e188 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
            (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"BuildingUI",0)) == null) throw; // [null/range check failed]
        local_68 = 0;
        uStack_60 = 0x3f800000;
        Transform.set_localScale(lVar3,&local_68,0);
        if (((*pStatics_e188 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
           (lVar3 = GameObject.get_transform(lVar3,0)) == null) throw; // [null/range check failed]
        uVar6 = Transform.Find(lVar3,"BuildingUI",0);
        puVar5 = (uint64 *)Vector3.get_one(&local_58,0);
        uStack_60 = *(uint32 *)(puVar5 + 1);
        local_68 = *puVar5;
        uVar6 = ShortcutExtensions.DOScale(uVar6,&local_68,0x3e4ccccd,0);
        TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181d98af0);
        if (((*pStatics_e188 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
           ((lVar3 = GameObject.get_transform(lVar3,0), lVar3 == null ||
            (lVar3 = Transform.Find(lVar3,"BlackBackground",0)) == null))) throw; // [null/range check failed]
        uVar6 = Component.GetComponent(lVar3,DAT_181d6bc40);
        uVar6 = DOTweenModuleUI.DOFade(uVar6,0x3f333333,0x3e4ccccd,0);
        TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181d98958);
        if ((this.buildingData == null) ||
           (lVar3 = AreaBuildingData.DataBase(this.buildingData,0)) == null)
        throw; // [null/range check failed]
        lVar3 = *(int64 *)(lVar3 + 152);
        if (lVar3 != null) {
          cVar1 = FUN_1816fd990(lVar3,"door",0);
          if (!cVar1) {
            cVar1 = FUN_1816fd990(lVar3,"bigdoor");
            if (!cVar1) {
              cVar1 = FUN_1816fd990(lVar3,"footstep");
              uVar6 = "Sound/SoundEffect/FootStepContinue";
              if (!cVar1) goto LAB_180bc4665;
            }
            else {
              local_res8[0] = FUN_180d8cf10(1);
              uVar6 = Int32.ToString(local_res8,0);
              uVar6 = String.Concat("Sound/SoundEffect/Door/BigDoor",uVar6,0);
            }
          }
          else {
            local_res8[0] = FUN_180d8cf10(0,7);
            uVar6 = Int32.ToString(local_res8,0);
            uVar6 = String.Concat("Sound/SoundEffect/Door/Door",uVar6,0);
          }
          plVar9 = (int64 *)Resources.Load(uVar6,0);
          plVar10 = plVar8;
          if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
            plVar10 = plVar9;
          }
          NGUITools.PlaySound(plVar10,0);
        }
        LAB_180bc4665:
        if ((((*pStatics_e188 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
            (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
           ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
            (lVar3 = Transform.Find(lVar3,"Pic",0)) == null))) {
        LAB_180bc50fb:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
        if ((this.buildingData == null) ||
           (lVar4 = AreaBuildingData.DataBase(this.buildingData,0)) == null)
        goto LAB_180bc50fb;
        uVar7 = String.Concat("Textures/Background/",*(uint64 *)(lVar4 + 24),0);
        uVar6 = DAT_181d9d060;
        uVar6 = Type.GetTypeFromHandle(uVar6,0);
        plVar9 = (int64 *)Resources.Load(uVar7,uVar6,0);
        if (lVar3 == null) goto LAB_180bc50fb;
        if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d7f9b0)) {
          plVar8 = plVar9;
        }
        Image.set_sprite(lVar3,plVar8,0);
        if ((((*pStatics_e188 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
            (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
           ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
            (lVar3 = Transform.Find(lVar3,"Pic",0)) == null))) goto LAB_180bc50fb;
        plVar8 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
        local_58 = 0;
        uStack_50 = 0;
        FUN_1809981e0(&local_58,0x3f800000,0x3f800000,0x3f800000,uVar11 & 0xffffffff00000000,0);
        if (plVar8 == (int64 *)0) goto LAB_180bc50fb;
        local_68 = local_58;
        uStack_60 = (uint32)uStack_50;
        uStack_5c = uStack_50._4_4_;
        (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
        if (((*pStatics_e188 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
           ((lVar3 = GameObject.get_transform(lVar3,0), lVar3 == null ||
            ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"Pic",0)) == null))))) goto LAB_180bc50fb;
        uVar6 = Component.GetComponent(lVar3,DAT_181d6bc40);
        uVar6 = DOTweenModuleUI.DOFade(uVar6,0x3f800000,0x3ecccccd,0);
        TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181d98958);
        if (((((*pStatics_e188 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
             (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
            ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"ExtraButtonGrid",0)) == null))) ||
           (lVar3 = Transform.Find(lVar3,"StealButton",0)) == null) goto LAB_180bc50fb;
        lVar3 = Component.get_gameObject(lVar3,0);
        if (((this.buildingData == null) ||
            (lVar4 = AreaBuildingData.DataBase(this.buildingData,0)) == null) ||
           (lVar3 == null)) goto LAB_180bc50fb;
        GameObject.SetActive(lVar3,*(uint8 *)(lVar4 + 160),0);
        if (((((*pStatics_e188 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
             (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
            ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"ExtraButtonGrid",0)) == null))) ||
           (lVar3 = Transform.Find(lVar3,"StealButton",0)) == null) goto LAB_180bc50fb;
        lVar3 = Component.GetComponent(lVar3,DAT_181d6ccc0);
        if (this.buildingData == null) goto LAB_180bc50fb;
        local_res10[0] = AreaBuildingData.GetStealItemMaxLv(this.buildingData,0);
        uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
        uVar6 = String.Format("等级{0}",uVar6,0);
        if (this.buildingData == null) goto LAB_180bc50fb;
        uVar2 = AreaBuildingData.GetStealItemMaxLv(this.buildingData,0);
        uVar6 = GlobalData.GenerateRareLvColorText(uVar6,uVar2,0);
        uVar6 = String.Format("穿越迷宫后，可以窃取商店内一件<b>{0}</b>以下物品",uVar6,0);
        if (lVar3 == null) goto LAB_180bc50fb;
        *(uint64 *)(lVar3 + 24) = uVar6;
        if ((((*pStatics_e188 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_e188 + 72)) == null) ||
            (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
           (((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"ExtraButtonGrid",0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"RobButton",0)) == null))) goto LAB_180bc50fb;
        lVar3 = Component.get_gameObject(lVar3,0);
        if (((this.buildingData == null) ||
            (lVar4 = AreaBuildingData.DataBase(this.buildingData,0)) == null) ||
           (lVar3 == null)) goto LAB_180bc50fb;
        GameObject.SetActive(lVar3,*(uint8 *)(lVar4 + 161),0);
        BuildingUIController.RefreshBuildingUI(this,0);
        BuildingUIController.GenerateBuildingButton(this,0);
        if (this.buildingData == null) goto LAB_180bc50fb;
        if (this.buildingData.belongHeroID == null) {
          if (*pStatics_df90 == 0) throw; // [null/range check failed]
          cVar1 = GameController.CheckGameResultTrigger(*pStatics_df90,0);
          if (cVar1) {
            return;
          }
        }
        lVar3 = *pStatics_df90;
        lVar4 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 88)) != null) {
          uVar6 = Int32.ToString(lVar4 + 16,0);
          if (this.buildingData != null) {
            uVar7 = Int32.ToString(this.buildingData + 16,0);
            uVar6 = String.Concat(uVar6,":",uVar7,0);
            if (lVar3 != null) {
              GameController.CheckPlotTrigger(lVar3,4,uVar6,999999,0);
              if (*pStatics_c960 != 0) {
                cVar1 = PlotController.HaveNoPlotWait(*pStatics_c960,0);
                if (cVar1) {
                  BuildingUIController.CheckEnterBuildingMission(this,0);
                }
                if (*pStatics_c960 != 0) {
                  cVar1 = PlotController.HaveNoPlotWait(*pStatics_c960,0);
                  if (cVar1) {
                    BuildingUIController.CheckEnterBuildingSpePlot(this,0);
                  }
                  if (*pStatics_c960 != 0) {
                    cVar1 = PlotController.HaveNoPlotWait(*pStatics_c960,0);
                    if (cVar1) {
                      if (this.buildingData == null) throw; // [null/range check failed]
                      if (this.buildingData.buildingID == 15) {
                        lVar3 = FUN_18046c0a0(0);
                        if (lVar3 == null) throw; // [null/range check failed]
                        cVar1 = GameController.CheckCatchBadFamePlayerEventHappen(lVar3,0x40000000,0);
                        if (cVar1) {
                          lVar3 = FUN_18046c0a0(0);
                          if (lVar3 == null) throw; // [null/range check failed]
                          GameController.CatchBadFamePlayerEventHappen(lVar3,0);
                        }
                      }
                    }
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DA4
    // RVA   : 0xBB8430   Offset: 0xBB6C30   Length: 0x602
    public void CheckEnterBuildingSpePlot()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        if (this.buildingData == null) throw; // [null/range check failed]
        if (this.buildingData.buildingID != null) goto LAB_180bb87a4;
        if (((*pStatics == 0) ||
            (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        if (*(char *)(lVar2 + 180) == false) {
          cVar1 = GameController.MeetCondition("我",0,0);
          if (!cVar1) goto LAB_180bb87a4;
          lVar2 = FUN_18046c0a0(0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
          if (*(char *)(*(int64 *)(lVar2 + 32) + 184) == false) {
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
              if (*(int64 *)(lVar2 + 0x2e0) == 0) {
                return;
              }
              lVar2 = FUN_18046c440(0);
              if (lVar2 != null) {
                PlotController.AddAskForceMissionPlot(lVar2,0);
                return;
              }
            }
            throw; // [null/range check failed]
          }
          lVar2 = FUN_18046c440(0);
          lVar3 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar3,DAT_181d7c250);
          if (lVar3 == null) throw; // [null/range check failed]
          FUN_181827900(lVar3,"参加会议;EnterMeeting",DAT_181d7c3d0);
          uVar4 = new SinglePlotData("哎呀，会议好像已经开始了，得赶快入座才行。",lVar3,1,0,3,"0",1,0,0);
        }
        else {
        LAB_180bb87a4:
          if (this.buildingData == null) throw; // [null/range check failed]
          if (this.buildingData.buildingID != 4) {
            return;
          }
          if (((*pStatics == 0) ||
              (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          if (*(char *)(lVar2 + 180) != false) {
            return;
          }
          cVar1 = GameController.MeetCondition("我",0,0);
          if (!cVar1) {
            return;
          }
          lVar2 = FUN_18046c0a0(0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
          if (*(char *)(*(int64 *)(lVar2 + 32) + 185) == false) {
            return;
          }
          lVar2 = FUN_18046c0a0(0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
          *(uint8 *)(*(int64 *)(lVar2 + 32) + 185) = 0;
          lVar2 = FUN_18046c440(0);
          lVar3 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar3,DAT_181d7c250);
          if (lVar3 == null) throw; // [null/range check failed]
          FUN_181827900(lVar3,"参加宴会;JoinForceParty",DAT_181d7c3d0);
          lVar5 = FUN_18046c0a0(0);
          if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
              (lVar5 = WorldData.Player()) == null) ||
             (lVar5 = HeroData.GetForceLeader(lVar5)) == null) throw; // [null/range check failed]
          uVar6 = Int32.ToString(lVar5 + 88);
          uVar4 = new SinglePlotData("哎呀，#PlayerName#可算来了，师兄弟们已经等候良久，赶紧入座吧。",lVar3,3,uVar6,3,"0",0,0,0);
        }
        if (lVar2 != null) {
          PlotController.AddPlot(lVar2,uVar4,0);
          return;
        }
    }

    // Token : 0x6000DA5
    // RVA   : 0xBB7FD0   Offset: 0xBB67D0   Length: 0x45B
    public void CheckEnterBuildingMission()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        iVar5 = 0;
        do {
          if ((((*pStatics == 0) ||
               (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
              (lVar2 = WorldData.Player(lVar2,0)) == null) || (*(int64 *)(lVar2 + 0x2e8) == 0))
          goto LAB_180bb8406;
          if (*(int *)(*(int64 *)(lVar2 + 0x2e8) + 24) <= iVar5) {
            return;
          }
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             ((lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0), lVar2 == null ||
              (((*(int64 *)(lVar2 + 0x2e8) == 0 ||
                (lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 0x2e8),iVar5,DAT_181d6d4e8)) == null) ||
               (lVar2 = *(int64 *)(lVar2 + 120)) == null))))) goto LAB_180bb8406;
          if (*(int *)(lVar2 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
          if (lVar2 == null) goto LAB_180bb8406;
          if (*(int *)(lVar2 + 40) == 4) {
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
               ((lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0), lVar2 == null ||
                (((*(int64 *)(lVar2 + 0x2e8) == 0 ||
                  (lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 0x2e8),iVar5,DAT_181d6d4e8)) == null)
                 || (lVar2 = *(int64 *)(lVar2 + 120)) == null))))) goto LAB_180bb8406;
            if (*(int *)(lVar2 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
            if (lVar2 == null) goto LAB_180bb8406;
            lVar2 = *(int64 *)(lVar2 + 48);
            lVar3 = FUN_1800d60b0(DAT_181d7c118,1);
            if (lVar3 == null) goto LAB_180bb8406;
            if (*(int *)(lVar3 + 24) == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            *(uint16 *)(lVar3 + 32) = 58;
            if ((lVar2 == null) || (lVar2 = String.Split(lVar2,lVar3,0)) == null) goto LAB_180bb8406;
            if (*(int *)(lVar2 + 24) == 2) {
              iVar1 = Int32.Parse(*(uint64 *)(lVar2 + 32));
              lVar3 = FUN_18046bac0(0);
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 88) == 0)) goto LAB_180bb8406;
              if (iVar1 == *(int *)(*(int64 *)(lVar3 + 88) + 16)) {
                if (*(uint32 *)(lVar2 + 24) < 2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                iVar1 = Int32.Parse(*(uint64 *)(lVar2 + 40));
                if (this.buildingData == null) goto LAB_180bb8406;
                if (iVar1 == this.buildingData.buildingID) {
                  lVar2 = FUN_18046c440(0);
                  lVar3 = FUN_18046c0a0(0);
                  if (((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                       (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) &&
                      ((*(int64 *)(lVar3 + 0x2e8) != 0 &&
                       (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x2e8),iVar5,DAT_181d6d4e8),
                       lVar3 != null)))) && (lVar3 = *(int64 *)(lVar3 + 120)) != null) {
                    if (*(int *)(lVar3 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar3 = *(int64 *)(*(int64 *)(lVar3 + 16) + 32);
                    if ((lVar3 != null) && (lVar2 != null)) {
                      PlotController.AddPlotEvent(lVar2,*(uint64 *)(lVar3 + 32),0);
                      return;
                    }
                  }
        LAB_180bb8406:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
              }
            }
          }
          iVar5 = iVar5 + 1;
        } while( true );
    }

    // Token : 0x6000DA6
    // RVA   : 0xBC2720   Offset: 0xBC0F20   Length: 0x762
    public void RefreshBuildingUI()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        uint uVar1;
        bool cVar2;
        byte uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        uint[] local_res8 = new uint[2];
        this.refreshTime = 0x3e99999a;
        if ((((*pStatics != 0) &&
             (lVar4 = *(int64 *)(*pStatics + 72)) != null) &&
            (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
           ((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 != null &&
            (lVar4 = Transform.Find(lVar4,"Name",0)) != null))) {
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          if ((this.buildingData != null) &&
             (lVar4 = AreaBuildingData.DataBase(this.buildingData,0)) != null) {
            LTLocalization.SetText(uVar5,*(uint64 *)(lVar4 + 24),0);
            if (((*pStatics != 0) &&
                (lVar4 = *(int64 *)(*pStatics + 72)) != null) &&
               ((lVar4 = GameObject.get_transform(lVar4,0), lVar4 != null &&
                ((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 != null &&
                 (lVar4 = Transform.Find(lVar4,"Level",0)) != null))))) {
              uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
              if (this.buildingData != null) {
                uVar1 = this.buildingData.lv;
                uVar6 = GlobalData.GetNumText(uVar1,0);
                uVar6 = String.Concat(uVar6,"级",0);
                LTLocalization.SetText(uVar5,uVar6,0);
                if ((((*pStatics != 0) &&
                     (lVar4 = *(int64 *)(*pStatics + 72)) != null) &&
                    (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                   ((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 != null &&
                    (lVar4 = Transform.Find(lVar4,"Produce",0)) != null))) {
                  uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                  if (this.buildingData != null) {
                    uVar6 = AreaBuildingData.GetBuildingText(this.buildingData,0,0,0,0);
                    LTLocalization.SetText(uVar5,uVar6,0);
                    if (((*pStatics != 0) &&
                        (lVar4 = *(int64 *)(*pStatics + 72)) != null)
                       && ((lVar4 = GameObject.get_transform(lVar4,0), lVar4 != null &&
                           ((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 != null &&
                            (lVar4 = Transform.Find(lVar4,"Describe",0)) != null))))) {
                      uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
                      if ((this.buildingData != null) &&
                         (lVar4 = AreaBuildingData.DataBase(this.buildingData,0)) != null
                         ) {
                        uVar6 = *(uint64 *)(lVar4 + 40);
                        if (this.buildingData != null) {
                          cVar2 = AreaBuildingData.BuildingAvailable(this.buildingData,0);
                          uVar8 = "";
                          if (!cVar2) {
                            uVar8 = *(uint64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x2c8);
                            if (this.buildingData == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            local_res8[0] = this.buildingData.enemyMonth;
                            uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                            uVar8 = String.Format("\n{0}<b>作恶导致禁用{1}个月</b></color>",uVar8,uVar7,0);
                          }
                          uVar6 = String.Concat(uVar6,uVar8,0);
                          LTLocalization.SetText(uVar5,uVar6,0);
                          if ((((*pStatics != 0) &&
                               (lVar4 = *(int64 *)(*pStatics + 72),
                               lVar4 != null)) && (lVar4 = GameObject.get_transform(lVar4,0)) != null)
                             && (((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 != null &&
                                  (lVar4 = Transform.Find(lVar4,"ExtraButtonGrid",0)) != null) &&
                                 (lVar4 = Transform.Find(lVar4,"StealButton",0)) != null))) {
                            lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
                            if ((this.buildingData != null) &&
                               (uVar3 = AreaBuildingData.BuildingAvailable
                                                  (this.buildingData,0), lVar4 != null)) {
                              Selectable.set_interactable(lVar4,uVar3,0);
                              if ((((*pStatics != 0) &&
                                   (lVar4 = *(int64 *)(*pStatics + 72),
                                   lVar4 != null)) &&
                                  (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                                 (((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 != null &&
                                   (lVar4 = Transform.Find(lVar4,"ExtraButtonGrid",0)) != null) &&
                                  (lVar4 = Transform.Find(lVar4,"RobButton",0)) != null))) {
                                lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
                                if ((this.buildingData != null) &&
                                   (uVar3 = AreaBuildingData.BuildingAvailable
                                                      (this.buildingData,0), lVar4 != null)) {
                                  Selectable.set_interactable(lVar4,uVar3,0);
                                  BuildingUIController.RefreshUpgradeButton(this,0);
                                  if (((((*pStatics != 0) &&
                                        (lVar4 = *(int64 *)
                                                  (*pStatics + 72),
                                        lVar4 != null)) &&
                                       (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                                      ((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 != null &&
                                       (lVar4 = Transform.Find(lVar4,"ExtraButtonGrid",0)) != null))) &&
                                     (lVar4 = Component.GetComponent(lVar4,DAT_181d6e0c0)) != null) {
                                    UIGrid.set_repositionNow(lVar4,1,0);
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

    // Token : 0x6000DA7
    // RVA   : 0xBC2E90   Offset: 0xBC1690   Length: 0x5F0
    public void RefreshUpgradeButton()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        int iVar1;
        bool cVar2;
        byte uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        uint[] local_res18 = new uint[4];
        if ((((*pStatics != 0) &&
             (lVar4 = *(int64 *)(*pStatics + 72)) != null) &&
            (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
           ((lVar4 = Transform.Find(lVar4,"BuildingUI"), lVar4 != null &&
            (lVar4 = Transform.Find(lVar4,"ExtraButtonGrid")) != null))) {
          lVar4 = Transform.Find(lVar4,"UpgradeButton");
          if ((this.buildingData == null) ||
             (lVar5 = AreaBuildingData.DataBase(this.buildingData,0)) == null)
          throw; // [null/range check failed]
          cVar2 = String.op_Inequality(lVar5.buildTimeLeft,"私宅");
          if (cVar2) {
            if (this.buildingData == null) throw; // [null/range check failed]
            lVar5 = AreaBuildingData.GetArea(this.buildingData,0);
            if (lVar5 != null) {
              if ((this.buildingData == null) ||
                 (lVar5 = AreaBuildingData.GetArea(this.buildingData,0)) == null)
              throw; // [null/range check failed]
              lVar5 = AreaData.GetForce(lVar5,0);
              if (lVar5 != null) {
                if ((this.buildingData == null) ||
                   (lVar5 = AreaBuildingData.GetArea(this.buildingData,0)) == null)
                throw; // [null/range check failed]
                iVar1 = *(int *)(lVar5 + 112);
                lVar5 = FUN_18046c0a0(0);
                if (((lVar5 == null) || (lVar5.destroyTimeLeft == null)) ||
                   (lVar5 = WorldData.Player(lVar5.destroyTimeLeft,0)) == null)
                throw; // [null/range check failed]
                if (iVar1 == *(int *)(lVar5 + 132)) {
                  if ((lVar4 == null) || (lVar5 = Component.get_gameObject(lVar4,0)) == null)
                  throw; // [null/range check failed]
                  cVar2 = GameObject.get_activeSelf(lVar5,0);
                  if (!cVar2) {
                    lVar5 = Component.get_gameObject(lVar4,0);
                    if (lVar5 == null) throw; // [null/range check failed]
                    GameObject.SetActive(lVar5,1);
                  }
                  lVar5 = this.buildingData;
                  if (lVar5 == null) throw; // [null/range check failed]
                  if (lVar5.buildTimeLeft < 1) {
                    if (lVar5.upgradeTimeLeft < 1) {
                      if (9 < lVar5.lv) {
                        lVar5 = Transform.Find(lVar4,"Text");
                        if (lVar5 == null) throw; // [null/range check failed]
                        uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                        LTLocalization.SetText(uVar6,"登峰造极",0);
                        lVar5 = Component.GetComponent(lVar4,DAT_181d6af40);
                        if (lVar5 == null) throw; // [null/range check failed]
                        Selectable.set_interactable(lVar5,0,0);
                        lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                        uVar6 = "";
                        if (lVar4 == null) throw; // [null/range check failed]
                        puVar7 = (uint64 *)(lVar4 + 24);
                        *puVar7 = "";
                        goto LAB_180bc3238;
                      }
                      lVar5 = Transform.Find(lVar4,"Text");
                      if (lVar5 == null) throw; // [null/range check failed]
                      uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                      LTLocalization.SetText(uVar6,"升级",0);
                      lVar5 = Component.GetComponent(lVar4,DAT_181d6af40);
                      if ((this.buildingData == null) ||
                         (uVar3 = AreaBuildingData.CanUpgrade(this.buildingData,0),
                         lVar5 == null)) throw; // [null/range check failed]
                      Selectable.set_interactable(lVar5,uVar3,0);
                      lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                      if ((this.buildingData == null) ||
                         (uVar6 = AreaBuildingData.GetUpgradeDescribe(this.buildingData,0),
                         lVar4 == null)) throw; // [null/range check failed]
                    }
                    else {
                      lVar5 = Transform.Find(lVar4,"Text");
                      if (lVar5 == null) {
        LAB_180bc3475:
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                      LTLocalization.SetText(uVar6,"升级中",0);
                      lVar5 = Component.GetComponent(lVar4,DAT_181d6af40);
                      if (lVar5 == null) goto LAB_180bc3475;
                      Selectable.set_interactable(lVar5,0,0);
                      lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                      if (this.buildingData == null) goto LAB_180bc3475;
                      local_res18[0] = this.buildingData.upgradeTimeLeft;
                      uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                      uVar6 = String.Format("剩余{0}天",uVar6,0);
                      if (lVar4 == null) goto LAB_180bc3475;
                    }
                  }
                  else {
                    lVar5 = Transform.Find(lVar4,"Text");
                    if (lVar5 == null) {
        LAB_180bc347b:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                    LTLocalization.SetText(uVar6,"建造中",0);
                    lVar5 = Component.GetComponent(lVar4,DAT_181d6af40);
                    if (lVar5 == null) goto LAB_180bc347b;
                    Selectable.set_interactable(lVar5,0,0);
                    lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                    if (this.buildingData == null) goto LAB_180bc347b;
                    local_res18[0] = this.buildingData.buildTimeLeft;
                    uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                    uVar6 = String.Format("剩余{0}天",uVar6,0);
                    if (lVar4 == null) goto LAB_180bc347b;
                  }
                  puVar7 = (uint64 *)(lVar4 + 24);
                  *puVar7 = uVar6;
        LAB_180bc3238:
                  il2cpp_internal(puVar7,uVar6);
                  return;
                }
              }
            }
          }
          if ((lVar4 != null) && (lVar5 = Component.get_gameObject(lVar4,0)) != null) {
            cVar2 = GameObject.get_activeSelf(lVar5,0);
            if (!cVar2) {
              return;
            }
            lVar4 = Component.get_gameObject(lVar4,0);
            if (lVar4 != null) {
              GameObject.SetActive(lVar4,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000DA8
    // RVA   : 0xBD2180   Offset: 0xBD0980   Length: 0x16B
    public void UpgradeButtonClicked()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        uint[] local_res8 = new uint[2];
        lVar2 = **(int64 **)(DAT_181d834f0 + 184);
        if (this.buildingData != null) {
          uVar3 = AreaBuildingData.Name(this.buildingData,0,0);
          if (this.buildingData != null) {
            iVar1 = this.buildingData.lv;
            uVar4 = GlobalData.GetNumText(iVar1 + 1,0);
            if (this.buildingData != null) {
              local_res8[0] = AreaBuildingData.GetUpgradeTime(this.buildingData,0);
              uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
              uVar3 = String.Format("确认要将{0}提升至{1}级吗？\n大约需要{2}天时间。",uVar3,uVar4,uVar5,0);
              if (lVar2 != null) {
                SureMenu.CallSureMenu(lVar2,uVar3,"SureUpgradeBuliding",0,"UIController",0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000DA9
    // RVA   : 0xBD1FA0   Offset: 0xBD07A0   Length: 0x130
    public void SureUpgradeBuliding()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87338 + 184) + 16);
        if (lVar1 != null) {
          AreaBuildController.PlayerUpgradeBuilding(lVar1,this.buildingData,0);
          BuildingUIController.RefreshUpgradeButton(this,0);
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/WoodWork",0);
          plVar3 = (int64 *)0;
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
            plVar3 = plVar2;
          }
          NGUITools.PlaySound(plVar3,0);
          return;
        }
    }

    // Token : 0x6000DAA
    // RVA   : 0xBBC040   Offset: 0xBBA840   Length: 0x459
    public void HideBuildingUI()
    {
        var pStatics_8ad8 = *(int64*)(DAT_181d88ad8 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        uint local_18;
        uint local_14;
        uint local_10;
        if (*pStatics_8ad8 == 0) throw; // [null/range check failed]
        if (*(char *)(*pStatics_8ad8 + 89) != false) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 16)) == null) throw; // [null/range check failed]
          iVar1 = PlayerPrefDictionary.GetInt(lVar2,"SkipTutorial",0);
          if (iVar1 != 1) {
            lVar2 = FUN_18046c440(0);
            lVar3 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar3,DAT_181d7c250);
            if (lVar3 != null) {
              FUN_181827900(lVar3,"不敢不敢;HideInteractUI",DAT_181d7c3d0);
              uVar4 = new SinglePlotData("#PlayerName#你要去哪儿？此处的修炼尚未完成呢。\n你若敢偷奸耍滑，趁机开溜，可别怪我翻脸不认人！",lVar3,5,"顾游年",3,"0",0,0,0);
              if (lVar2 != null) {
                PlotController.AddPlot(lVar2,uVar4,0);
                return;
              }
            }
            throw; // [null/range check failed]
          }
        }
        this.buildingData = 0;
        uVar4 = this.buildingButtonGrid;
        GlobalData.DeleteAllChild(uVar4,0);
        if ((*pStatics_e188 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_e188 + 72)) != null) {
          lVar2 = GameObject.get_transform(lVar2,0);
          if (lVar2 != null) {
            uVar4 = Transform.Find(lVar2,"BuildingUI",0);
            local_18 = 0;
            local_14 = 0x3f800000;
            local_10 = 0x3f800000;
            uVar4 = ShortcutExtensions.DOScale(uVar4,&local_18,0x3e4ccccd,0);
            uVar5 = new OnTooltipCB(this,DAT_181d64ed0,0);
            uVar4 = TweenSettingsExtensions.OnComplete(uVar4,uVar5,DAT_181d96ee8);
            TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181d98af0);
            if ((*pStatics_e188 != 0) &&
               (lVar2 = *(int64 *)(*pStatics_e188 + 72)) != null) {
              lVar2 = GameObject.get_transform(lVar2,0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"BlackBackground",0);
                if (lVar2 != null) {
                  uVar4 = Component.GetComponent(lVar2,DAT_181d6bc40);
                  uVar4 = DOTweenModuleUI.DOFade(uVar4,0,0x3e4ccccd,0);
                  TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181d98958);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DAB
    // RVA   : 0xBB9900   Offset: 0xBB8100   Length: 0x151
    public void DisactiveBuildingPanel()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
          GameObject.SetActive(lVar1,0,0);
          if ((*pStatics != 0) &&
             (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
            lVar1 = GameObject.get_transform(lVar1,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"BuildingUI",0);
              if (lVar1 != null) {
                lVar1 = Transform.Find(lVar1,"BuildingButtonScrollView",0);
                if (lVar1 != null) {
                  lVar1 = Transform.Find(lVar1,"Scrollbar Vertical",0);
                  if (lVar1 != null) {
                    lVar1 = Component.GetComponent(lVar1,DAT_181d6c9c0);
                    if (lVar1 != null) {
                      Scrollbar.set_value(lVar1,0x3f800000,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DAC
    // RVA   : 0xBBBE20   Offset: 0xBBA620   Length: 0x21D
    public void HideBuildingFinished()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        long lVar1;
        byte[] local_18 = new byte[24];
        if ((((*pStatics != 0) &&
             (lVar1 = *(int64 *)(*pStatics + 72)) != null) &&
            (lVar1 = GameObject.get_transform(lVar1,0)) != null) &&
           ((lVar1 = Transform.Find(lVar1,"BuildingUI",0), lVar1 != null &&
            (lVar1 = Component.get_transform(lVar1,0)) != null))) {
          pfVar2 = (float *)Transform.get_localScale(local_18,lVar1,0);
          if (*pfVar2 != 0.0) {
            return;
          }
          if ((*pStatics != 0) &&
             (lVar1 = *(int64 *)(*pStatics + 72)) != null) {
            GameObject.SetActive(lVar1,0,0);
            if (((((*pStatics != 0) &&
                  (lVar1 = *(int64 *)(*pStatics + 72)) != null) &&
                 (lVar1 = GameObject.get_transform(lVar1,0)) != null) &&
                ((lVar1 = Transform.Find(lVar1,"BuildingUI",0), lVar1 != null &&
                 (lVar1 = Transform.Find(lVar1,"BuildingButtonScrollView",0)) != null))) &&
               ((lVar1 = Transform.Find(lVar1,"Scrollbar Vertical",0), lVar1 != null &&
                (lVar1 = Component.GetComponent(lVar1,DAT_181d6c9c0)) != null))) {
              Scrollbar.set_value(lVar1,0x3f800000,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000DAD
    // RVA   : 0xBBA650   Offset: 0xBB8E50   Length: 0x1E3
    public void GenerateBuildingButton()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        long lVar1;
        uint uVar2;
        lVar1 = this.buildingData;
        uVar2 = 0;
        if (lVar1 != null) {
          while( true ) {
            lVar1 = AreaBuildingData.DataBase(lVar1,0);
            if ((lVar1 == null) || (lVar1.areaID == null)) throw; // [null/range check failed]
            if (*(int *)(lVar1.areaID + 24) <= (int)uVar2) break;
            if (((this.buildingData == null) ||
                (lVar1 = AreaBuildingData.DataBase(this.buildingData,0)) == null) ||
               (lVar1.areaID == null)) throw; // [null/range check failed]
            if (*(uint32 *)(lVar1.areaID + 24) <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            BuildingUIController.CreateBuildingButton(this);
            lVar1 = this.buildingData;
            uVar2 = uVar2 + 1;
            if (lVar1 == null) throw; // [null/range check failed]
          }
          if (((((*pStatics != 0) &&
                (lVar1 = *(int64 *)(*pStatics + 72)) != null) &&
               (lVar1 = GameObject.get_transform(lVar1,0)) != null) &&
              ((lVar1 = Transform.Find(lVar1,"BuildingUI",0), lVar1 != null &&
               (lVar1 = Transform.Find(lVar1,"BuildingButtonScrollView",0)) != null))) &&
             ((lVar1 = Transform.Find(lVar1,"Scrollbar Vertical",0), lVar1 != null &&
              (lVar1 = Component.GetComponent(lVar1,DAT_181d6c9c0)) != null))) {
            Scrollbar.set_value(lVar1,0x3f800000,0);
            return;
          }
        }
    }

    // Token : 0x6000DAE
    // RVA   : 0xBB9590   Offset: 0xBB7D90   Length: 0x369
    public void CreateBuildingButton(AreaBuildingChoice buildingChoice)
    {
        ulong uVar1;
        bool cVar2;
        byte uVar3;
        ulong uVar4;
        long lVar5;
        if (**(int **)(DAT_181d4ef00 + 184) == 2) {
          lVar5 = *(int64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 16);
          if ((buildingChoice == null) || (lVar5 == null)) throw; // [null/range check failed]
          cVar2 = FUN_1818279a0(lVar5,*(uint64 *)(buildingChoice + 16),DAT_181d7c4d0);
          if (cVar2) {
            return;
          }
        }
        if (buildingChoice != null) {
          uVar4 = *(uint64 *)(buildingChoice + 40);
          uVar3 = *(uint8 *)(buildingChoice + 32);
          uVar1 = this.buildingData;
          cVar2 = GameController.MeetCondition(uVar4,uVar3,uVar1,0);
          if (!cVar2) {
            return;
          }
          uVar4 = this.buildingButtonGrid;
          uVar1 = this.buildingButtonPrefab;
          uVar4 = GlobalData.AddChild(uVar4,uVar1,0);
          this.newButton = uVar4;
          if ((this.newButton != null) &&
             (lVar5 = GameObject.GetComponent(this.newButton,DAT_181d9edd8)) != null)
          {
            *(int64 *)(lVar5 + 24) = buildingChoice;
            if ((this.newButton != null) &&
               ((lVar5 = GameObject.get_transform(this.newButton,0), lVar5 != null &&
                (lVar5 = Transform.Find(lVar5,"Text",0)) != null))) {
              uVar4 = Component.GetComponent(lVar5,DAT_181d6d8c0);
              LTLocalization.SetText(uVar4,*(uint64 *)(buildingChoice + 16),0);
              uVar4 = *(uint64 *)(buildingChoice + 48);
              uVar3 = *(uint8 *)(buildingChoice + 32);
              uVar1 = this.buildingData;
              cVar2 = GameController.MeetCondition(uVar4,uVar3,uVar1,0);
              if (this.newButton != null) {
                lVar5 = GameObject.GetComponent(this.newButton,DAT_181d9ee60);
                if (!cVar2) {
                  uVar3 = 0;
                }
                else {
                  if (this.buildingData == null) throw; // [null/range check failed]
                  uVar3 = AreaBuildingData.BuildingAvailable(this.buildingData,0);
                }
                if (lVar5 != null) {
                  Selectable.set_interactable(lVar5,uVar3,0);
                  if ((this.newButton != null) &&
                     (lVar5 = GameObject.get_transform(this.newButton,0)) != null) {
                    lVar5 = Component.GetComponent(lVar5,DAT_181d6ccc0);
                    if (!cVar2) {
                      uVar4 = *(uint64 *)(buildingChoice + 48);
                      uVar4 = GameController.GetConditionDescribe(uVar4,0);
                    }
                    else {
                      uVar4 = *(uint64 *)(buildingChoice + 24);
                    }
                    if (lVar5 != null) {
                      *(uint64 *)(lVar5 + 24) = uVar4;
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DAF
    // RVA   : 0xBBDAA0   Offset: 0xBBC2A0   Length: 0xAB
    public void InteractOtherForce()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.StartInteractOtherForce(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DB0
    // RVA   : 0xBBDB50   Offset: 0xBBC350   Length: 0xAB
    public void LeaderInteractOtherForce()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.StartLeaderInteractOtherForce(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DB1
    // RVA   : 0xBBABD0   Offset: 0xBB93D0   Length: 0x371
    public string GenerateForceNPCString(string name)
    {
        var pStatics = *(int64*)(DAT_181d87630 + 184);
        long lVar1;
        uint uVar2;
        uint uVar3;
        lVar1 = *(int64 *)(pStatics + 56);
        if (lVar1 == null) throw; // [null/range check failed]
        if (*(int64 *)(lVar1 + 88) == 0) {
        LAB_180bbadbe:
          uVar2 = 0xffffffff;
        }
        else {
          lVar1 = *(int64 *)(pStatics + 56);
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 88)) == null) throw; // [null/range check failed]
          lVar1 = AreaData.GetForce(lVar1,0);
          if (lVar1 == null) goto LAB_180bbadbe;
          lVar1 = FUN_18046bac0(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 88) == 0)) throw; // [null/range check failed]
          lVar1 = AreaData.GetForce(*(int64 *)(lVar1 + 88),0);
          if (lVar1 == null) throw; // [null/range check failed]
          if (*(int *)(lVar1 + 32) == -99) goto LAB_180bbadbe;
          lVar1 = FUN_18046bac0(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 88) == 0)) throw; // [null/range check failed]
          lVar1 = AreaData.GetForce(*(int64 *)(lVar1 + 88),0);
          if (lVar1 == null) throw; // [null/range check failed]
          uVar2 = *(uint32 *)(lVar1 + 32);
        }
        lVar1 = *(int64 *)(pStatics + 56);
        if (lVar1 == null) throw; // [null/range check failed]
        if (*(int64 *)(lVar1 + 88) == 0) {
        LAB_180bbaf02:
          uVar3 = 0xffffffff;
        }
        else {
          lVar1 = *(int64 *)(pStatics + 56);
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 88)) == null) throw; // [null/range check failed]
          lVar1 = AreaData.GetForce(lVar1,0);
          if (lVar1 == null) goto LAB_180bbaf02;
          lVar1 = FUN_18046bac0(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 88) == 0)) throw; // [null/range check failed]
          uVar3 = *(uint32 *)(*(int64 *)(lVar1 + 88) + 112);
        }
        if (this != 0) {
          BuildingUIController.GenerateBuildingNPCString(this,name,uVar2,uVar3,0xffffffff,0);
          return;
        }
    }

    // Token : 0x6000DB2
    // RVA   : 0xBBA840   Offset: 0xBB9040   Length: 0x38F
    public string GenerateBuildingNPCString(string name, int skinID, int forceID, int forceLv)
    {
        void BuildingUIController.GenerateBuildingNPCString
                     (int64 this,int64 name,int skinID,uint32 forceID,int forceLv)
        {
        int64 *plVar1;
        int64 lVar2;
        int64 lVar3;
        uint64 uVar4;
        float fVar5;
        float local_res10 [2];
        int local_28;
        uint32 local_24 [3];
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181d7f180,6);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (name != null) {
          lVar2 = il2cpp_internal(name,*(uint64 *)(*plVar1 + 64));
          if (lVar2 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        if ((int)plVar1[3] == 0) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[4] = name;
        il2cpp_internal(plVar1 + 4,name);
        uVar4 = "临时:{0}&{1};{2};{5};{3};{4}";
        if (skinID != 10) {
          fVar5 = (float)Random.get_value(0);
          lVar2 = "女";
          if (0.5 > fVar5)
          {
            }
            lVar2 = "男";
          }
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        if (*(uint32 *)(plVar1 + 3) < 2) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[5] = lVar2;
        il2cpp_internal(plVar1 + 5,lVar2);
        local_res10[0] = (float)FUN_180d8cf10(20);
        lVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        if (*(uint32 *)(plVar1 + 3) < 3) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[6] = lVar2;
        il2cpp_internal(plVar1 + 6,lVar2);
        if (forceLv == -1) {
          if (this.buildingData == null) {
            local_res10[0] = 0.0;
          }
          else {
            local_res10[0] = (float)BuildingUIController.GetBuildingHeroLv(this,0);
          }
        }
        else {
          local_res10[0] = (float)forceLv;
        }
        lVar2 = il2cpp_value_box(DAT_181d7d0b8,local_res10);
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        if (*(uint32 *)(plVar1 + 3) < 4) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[7] = lVar2;
        il2cpp_internal(plVar1 + 7,lVar2);
        local_28 = skinID;
        lVar2 = il2cpp_value_box(DAT_181d5b2f8,&local_28);
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        if (4 < *(uint32 *)(plVar1 + 3)) {
          plVar1[8] = lVar2;
          il2cpp_internal(plVar1 + 8,lVar2);
          local_24[0] = forceID;
          lVar2 = il2cpp_value_box(DAT_181d5b2f8,local_24);
          if (lVar2 != null) {
            lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
            if (lVar3 == null) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
          }
          if (5 < *(uint32 *)(plVar1 + 3)) {
            plVar1[9] = lVar2;
            il2cpp_internal(plVar1 + 9,lVar2);
            String.Format(uVar4,plVar1,0);
            return;
          }
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        uVar4 = il2cpp_internal();
    }

    // Token : 0x6000DB3
    // RVA   : 0xBBAFC0   Offset: 0xBB97C0   Length: 0xDA
    public float GetBuildingHeroLv()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        if (*pStatics != 0) {
          fVar1 = (float)GameController.GetTimeDifficulty(*pStatics,0);
          if (this.buildingData != null) {
            return ((float)this.buildingData.lv + fVar1) * 0.5 * 0.5;
          }
        }
    }

    // Token : 0x6000DB4
    // RVA   : 0xBB7A20   Offset: 0xBB6220   Length: 0x5AB
    public void BuyCityHouse()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        float[] local_res20 = new float[2];
        ulong in_stack_ffffffffffffff98;
        uint uVar7;
        uint uVar9;
        ulong uVar8;
        float[] local_38 = new float[4];
        uVar7 = (uint32)((uint64)in_stack_ffffffffffffff98 >> 32);
        if (this.buildingData != null) {
          local_res8[0] = AreaBuildingData.GetBuyMoney(this.buildingData,0);
          lVar2 = *pStatics;
          uVar3 = new PlotData(0);
          if (lVar2 != null) {
            puVar1 = (uint64 *)(lVar2 + 0x108);
            *puVar1 = uVar3;
            il2cpp_internal(puVar1,uVar3);
            if ((*pStatics != 0) &&
               (lVar2 = *(int64 *)(*pStatics + 0x108)) != null) {
              lVar2 = *(int64 *)(lVar2 + 64);
              uVar3 = FUN_180228420(DAT_181d63120);
              uVar3 = String.Format("少侠真是好眼光！这栋房产位于#AreaName#城内，\n交通便利，闹中取静，景观优雅，装饰奢华。\n日后孩子要去城中有名的学堂上课，也是方便得很呐！",uVar3,0);
              uVar9 = 0;
              uVar4 = BuildingUIController.GenerateBuildingNPCString
                                (this,"地产商人",0xfffffffd,0xffffffff,CONCAT44(uVar7,0xffffffff),0)
              ;
              uVar5 = il2cpp_internal(DAT_181d7d2b0);
              uVar8 = CONCAT44(uVar9,3);
              SinglePlotData.ctor(uVar5,uVar3,0,5,uVar4,uVar8,"0",0,0,0);
              uVar7 = (uint32)((uint64)uVar8 >> 32);
              if (lVar2 != null) {
                FUN_181827900(lVar2,uVar5,DAT_181d79a58);
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 0x108)) != null) {
                  lVar2 = *(int64 *)(lVar2 + 64);
                  local_res18[0] = local_res8[0];
                  uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                  if (this.buildingData != null) {
                    local_res20[0] =
                         (float)AreaBuildingData.GetSelfHouseTotalAdd(this.buildingData,0);
                    local_res20[0] = local_res20[0] * 100.0;
                    uVar4 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
                    if (this.buildingData != null) {
                      local_38[0] = (float)AreaBuildingData.GetSelfHouseTotalAdd
                                                     (this.buildingData,0);
                      local_38[0] = local_38[0] * 5.0;
                      uVar5 = il2cpp_value_box(DAT_181d7d0b8,local_38);
                      uVar3 = String.Format("眼下这处房产正在打折，只需要{0}两银子便可。\n买下这处房产后，少侠便可在此休憩，读书或存储物品了。\n此外还可以增加少侠{1}点的仓库容量以及{2}%的声望获取速度。",uVar3,uVar4,uVar5,0);
                      lVar6 = il2cpp_internal(DAT_181d72a30);
                      FUN_180f58a90(lVar6,DAT_181d7c250);
                      uVar4 = Int32.ToString(local_res8,0);
                      uVar4 = String.Concat("把地契拿来吧;BuyCityHouse;;0/",uVar4,0);
                      if (lVar6 != null) {
                        FUN_181827900(lVar6,uVar4,DAT_181d7c3d0);
                        FUN_181827900(lVar6,"我就随便看看;HideInteractUI",DAT_181d7c3d0);
                        uVar4 = new SinglePlotData(uVar3,lVar6,0,0,CONCAT44(uVar7,3),"0",0,0,0);
                        if (lVar2 != null) {
                          FUN_181827900(lVar2,uVar4,DAT_181d79a58);
                          lVar2 = *pStatics;
                          if ((*pStatics != 0) && (lVar2 != null)) {
                            PlotController.ChangePlot
                                      (lVar2,*(uint64 *)
                                              (*pStatics + 0x108),0);
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

    // Token : 0x6000DB5
    // RVA   : 0xBD22F0   Offset: 0xBD0AF0   Length: 0x483
    public void UpgradeCityHouse()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffffa8;
        uint uVar6;
        ulong in_stack_ffffffffffffffb0;
        uint uVar7;
        uVar6 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        uVar7 = (uint32)((uint64)in_stack_ffffffffffffffb0 >> 32);
        lVar1 = this.buildingData;
        if (lVar1 != null) {
          if ((lVar1.upgradeTimeLeft < 1) && (lVar1.buildTimeLeft < 1)) {
            if (lVar1.lv < 10) {
              lVar1 = AreaBuildingData.GetUpgradeCostResource(lVar1,0x3f800000,0);
              if (lVar1 != null) {
                if (lVar1.buildTimeLeft == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_res8[0] = (int)*(float *)(lVar1.buildingID + 32);
                lVar1 = FUN_18046c440(0);
                local_res18[0] = local_res8[0];
                uVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                if (this.buildingData != null) {
                  local_res20[0] = AreaBuildingData.GetUpgradeTime(this.buildingData,0);
                  uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                  uVar2 = String.Format("要修缮升级这处房产需要{0}两银子以及{1}天时间，\n这可以增加少侠您10点的仓库容量以及0.5%的声望获取速度。",uVar2,uVar3,0);
                  lVar4 = il2cpp_internal(DAT_181d72a30);
                  FUN_180f58a90(lVar4,DAT_181d7c250);
                  uVar3 = Int32.ToString(local_res8,0);
                  uVar3 = String.Concat("开始动工吧;UpgradeCityHouse;;0/",uVar3,0);
                  if (lVar4 != null) {
                    FUN_181827900(lVar4,uVar3,DAT_181d7c3d0);
                    FUN_181827900(lVar4,"还是算了;HideInteractUI",DAT_181d7c3d0);
                    uVar7 = 0;
                    uVar3 = BuildingUIController.GenerateBuildingNPCString
                                      (this,"工匠",0xfffffffc,0xffffffff,
                                       CONCAT44(uVar6,0xffffffff),0);
                    uVar5 = new SinglePlotData(uVar2,lVar4,5,uVar3,CONCAT44(uVar7,3),"0",0,0,0);
                    if (lVar1 != null) {
                      PlotController.ChangePlot(lVar1,uVar5,0);
                      return;
                    }
                  }
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar1 = FUN_18046c440(0);
            uVar2 = FUN_180228420(DAT_181d63120);
            uVar2 = String.Format("此住宅已修缮至最高等级，若再加扩建只怕有违礼制了。",uVar2,0);
            uVar3 = il2cpp_internal(DAT_181d7d2b0);
          }
          else {
            lVar1 = **(int64 **)(DAT_181d6c960 + 184);
            uVar2 = FUN_180228420(DAT_181d63120);
            uVar2 = String.Format("此住宅正在修缮中，还请稍安勿躁，静候些时日。",uVar2,0);
            uVar3 = il2cpp_internal(DAT_181d7d2b0);
          }
          SinglePlotData.ctor(uVar3,uVar2,0,1,0,CONCAT44(uVar7,3),"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DB6
    // RVA   : 0xBB8F10   Offset: 0xBB7710   Length: 0x1EF
    public void CityHouseBookRoom()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        if (lVar2 != null) {
          FUN_181827900(lVar2,"阅读秘籍;ChooseReadBook;false",DAT_181d7c3d0);
          FUN_181827900(lVar2,"编纂秘籍;ShowBookWriterSelf",DAT_181d7c3d0);
          FUN_181827900(lVar2,"离开;HideInteractUI",DAT_181d7c3d0);
          uVar3 = new SinglePlotData("书山有路勤为径，学海无涯苦作舟。",lVar2,1,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DB7
    // RVA   : 0xBB9100   Offset: 0xBB7900   Length: 0x215
    public void CityHousePracticeRoom()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        if (lVar2 != null) {
          FUN_181827900(lVar2,"自行练习;StartPracticeCityHousePlot",DAT_181d7c3d0);
          FUN_181827900(lVar2,"突破;BreakThroughSkill",DAT_181d7c3d0);
          FUN_181827900(lVar2,"天赋;ChooseManageTagTargetSelfHouse",DAT_181d7c3d0);
          FUN_181827900(lVar2,"离开;HideInteractUI",DAT_181d7c3d0);
          uVar3 = new SinglePlotData("冬练三九，夏练三伏。\n便是在自己家中，这练功之事亦不能落下。",lVar2,1,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DB8
    // RVA   : 0xBB8D20   Offset: 0xBB7520   Length: 0x1EF
    public void CityHouseBedRoom()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        if (lVar2 != null) {
          FUN_181827900(lVar2,"休息;HomeRest",DAT_181d7c3d0);
          FUN_181827900(lVar2,"私人仓库;OpenSelfStorage",DAT_181d7c3d0);
          FUN_181827900(lVar2,"离开;HideInteractUI",DAT_181d7c3d0);
          uVar3 = new SinglePlotData("江湖之中惊涛骇浪，波云诡谲。\n能有这样一方温馨的小天地以供休憩，也算是桩幸事。",lVar2,1,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DB9
    // RVA   : 0xBBA2A0   Offset: 0xBB8AA0   Length: 0x3AF
    public void ExploreArea()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong in_stack_ffffffffffffffc8;
        uint uVar5;
        ulong in_stack_ffffffffffffffd0;
        uint uVar6;
        uVar5 = (uint32)((uint64)in_stack_ffffffffffffffc8 >> 32);
        uVar6 = (uint32)((uint64)in_stack_ffffffffffffffd0 >> 32);
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if (((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 88)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 0x100)) != null) {
          if (*(int *)(lVar1 + 16) < 1) {
            lVar1 = *pStatics;
            uVar4 = new SinglePlotData("本月已探索过此地，即便再做努力只怕也难有收获。",0,1,0,CONCAT44(uVar6,3),"0",1,0,0);
          }
          else {
            lVar1 = *pStatics;
            lVar2 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar2,DAT_181d7c250);
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_181827900(lVar2,"开始探索;ExploreAreaStart",DAT_181d7c3d0);
            FUN_181827900(lVar2,"还是算了;HideInteractUI",DAT_181d7c3d0);
            uVar6 = 0;
            uVar3 = BuildingUIController.GenerateBuildingNPCString
                              (this,"马夫",0xfffffffc,0xffffffff,CONCAT44(uVar5,0xffffffff),0);
            uVar4 = new SinglePlotData("听闻此处近郊时有异状发生，\n少侠若花上三日在此探索一番，或许会有所收获。",lVar2,5,uVar3,CONCAT44(uVar6,3),"0",0,0,0);
          }
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000DBA
    // RVA   : 0xBC04F0   Offset: 0xBBECF0   Length: 0x3AF
    public void PatrolArea()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong in_stack_ffffffffffffffc8;
        uint uVar5;
        ulong in_stack_ffffffffffffffd0;
        uint uVar6;
        uVar5 = (uint32)((uint64)in_stack_ffffffffffffffc8 >> 32);
        uVar6 = (uint32)((uint64)in_stack_ffffffffffffffd0 >> 32);
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if (((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 88)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 0x100)) != null) {
          if (*(int *)(lVar1 + 20) < 1) {
            lVar1 = *pStatics;
            uVar4 = new SinglePlotData("本月已巡查过此地，即便再做努力只怕也很难有所收获。",0,1,0,CONCAT44(uVar6,3),"0",1,0,0);
          }
          else {
            lVar1 = *pStatics;
            lVar2 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar2,DAT_181d7c250);
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_181827900(lVar2,"开始巡查;PatrolAreaStart",DAT_181d7c3d0);
            FUN_181827900(lVar2,"还是算了;HideInteractUI",DAT_181d7c3d0);
            uVar6 = 0;
            uVar3 = BuildingUIController.GenerateBuildingNPCString
                              (this,"官差",0xfffffffb,0xffffffff,CONCAT44(uVar5,0xffffffff),0);
            uVar4 = new SinglePlotData("这#AreaName#近来不甚太平，少侠若能在此义务巡查五日，\n便可整治风气，震慑宵小，也能替自己赢得些许善名不是！",lVar2,5,uVar3,CONCAT44(uVar6,3),"0",0,0,0);
          }
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000DBB
    // RVA   : 0xBBEBA0   Offset: 0xBBD3A0   Length: 0xE9
    public void ManageBranch()
    {
        long lVar1;
        long lVar2;
        lVar1 = **(int64 **)(DAT_181d8e2b0 + 184);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if ((lVar2 != null) && (lVar1 != null)) {
          BranchUIController.ShowBranchUI(lVar1,*(uint64 *)(lVar2 + 88),0);
          return;
        }
    }

    // Token : 0x6000DBC
    // RVA   : 0xBBDC00   Offset: 0xBBC400   Length: 0xD62
    public void LeaderManageForceAttack()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        int iVar1;
        int iVar2;
        long lVar3;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        float[] local_res18 = new float[2];
        int[] local_res20 = new int[2];
        int local_38;
        int local_34;
        int[] local_30 = new int[2];
        if ((*pStatics_df90 != 0) &&
           (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          iVar1 = WorldData.GetPlayerForceTotalArea(lVar3,0);
          if ((*pStatics_df90 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null)
          throw; // [null/range check failed]
          iVar2 = WorldData.GetPlayerForceMaxAttackTime(lVar3,0);
          if ((*pStatics_df90 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null)
          throw; // [null/range check failed]
          if (*(char *)(lVar3 + 0x10b) == false) {
            lVar3 = **(int64 **)(DAT_181d6c960 + 184);
            uVar8 = new SinglePlotData("目前各大门派间，尚且风平浪静。\n若此时贸然进攻其他门派领地，怕是会引起众怒，再等待时机吧！",0,1,0,3,"0",1,0,0);
          }
          else {
            if (((*pStatics_df90 == 0) ||
                (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
               (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar3 + 0x2e0) == 0) {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 == null ||
                  (lVar3 = HeroData.GetForce(lVar3,0)) == null))) throw; // [null/range check failed]
              local_res20[0] = iVar1;
              if (*(int *)(lVar3 + 0x118) < iVar2) {
                lVar3 = FUN_18046c440(0);
                plVar4 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                if (plVar4 != (int64 *)0) {
                  if ((lVar5 != null) &&
                     (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if ((int)plVar4[3] == 0) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  plVar4[4] = lVar5;
                  il2cpp_internal(plVar4 + 4,lVar5);
                  lVar5 = FUN_18046c0a0(0);
                  if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                     (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 48)) != null) {
                    local_res18[0] = ((float)iVar1 * 100.0) / (float)*(int *)(lVar5 + 24);
                    lVar5 = Single.ToString(local_res18,"f0",0);
                    if ((lVar5 != null) &&
                       (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    if (*(uint32 *)(plVar4 + 3) < 2) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    plVar4[5] = lVar5;
                    il2cpp_internal(plVar4 + 5,lVar5);
                    lVar5 = FUN_18046c0a0(0);
                    if (((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                       ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 != null &&
                        (lVar5 = HeroData.GetForce(lVar5,0,0)) != null))) {
                      local_38 = iVar2 - *(int *)(lVar5 + 0x118);
                      lVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_38);
                      if ((lVar5 != null) &&
                         (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null)
                      {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar8,0);
                      }
                      if (*(uint32 *)(plVar4 + 3) < 3) {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar8,0);
                      }
                      plVar4[6] = lVar5;
                      il2cpp_internal(plVar4 + 6,lVar5);
                      local_34 = iVar2;
                      lVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_34);
                      if ((lVar5 != null) &&
                         (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null)
                      {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar8,0);
                      }
                      if (*(uint32 *)(plVar4 + 3) < 4) {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar8,0);
                      }
                      plVar4[7] = lVar5;
                      il2cpp_internal(plVar4 + 7,lVar5);
                      uVar7 = String.Format("如今本门占领/附庸/同盟区域共计{0}处，已占天下江山之{1}%。\n剩余每月出征次数{2}/{3}，是否要向周边区域发起进攻？",plVar4,0);
                      lVar5 = il2cpp_internal(DAT_181d72a30);
                      FUN_180f58a90(lVar5,DAT_181d7c250);
                      if (lVar5 != null) {
                        FUN_181827900(lVar5,"选择目标;ChooseForceAttackArea",DAT_181d7c3d0);
                        FUN_181827900(lVar5,"还是算了;HideInteractUI");
                        uVar8 = new SinglePlotData(uVar7,lVar5,1,0,3,"0",1,0,0);
                        if (lVar3 != null) goto LAB_180bbe2c6;
                      }
                    }
                  }
                }
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar3 = FUN_18046c440(0);
              plVar4 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
              lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
              if (plVar4 == (int64 *)0) {
        LAB_180bbe95d:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if ((lVar5 != null) &&
                 (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if ((int)plVar4[3] == 0) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar4[4] = lVar5;
              il2cpp_internal(plVar4 + 4,lVar5);
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 32) + 48)) == null)
              goto LAB_180bbe95d;
              local_res18[0] = ((float)iVar1 * 100.0) / (float)*(int *)(lVar5 + 24);
              lVar5 = Single.ToString(local_res18,"f0");
              if ((lVar5 != null) &&
                 (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(plVar4 + 3) < 2) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar4[5] = lVar5;
              il2cpp_internal(plVar4 + 5,lVar5);
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 ((lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar5 == null ||
                  (lVar5 = HeroData.GetForce(lVar5,0)) == null))) goto LAB_180bbe95d;
              local_34 = *(int *)(lVar5 + 0x118);
              lVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_34);
              if ((lVar5 != null) &&
                 (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(plVar4 + 3) < 3) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar4[6] = lVar5;
              il2cpp_internal(plVar4 + 6,lVar5);
              uVar8 = "如今本门占领/附庸/同盟区域共计{0}处，已占天下江山之{1}%。\n本月已达出征次数上限({2}次)，弟子们还需再休养整备一段时间。{3}";
              lVar5 = *(int64 *)(pStatics_ef00 + 0x148);
              if (lVar5 == null) goto LAB_180bbe95d;
              lVar6 = "";
              if (iVar2 < *(int *)(lVar5 + 24) + 1) {
                lVar5 = *(int64 *)(pStatics_ef00 + 0x148);
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(uint32 *)(lVar5 + 24) <= iVar2 - 1U) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_38 = *(int *)(*(int64 *)(lVar5 + 16) + 32 + (int64)(int)(iVar2 - 1U) * 4);
                uVar7 = il2cpp_value_box(DAT_181d5b2f8,&local_38);
                local_30[0] = iVar2 + 1;
                uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_30);
                lVar6 = String.Format("\n(控制{0}处区域后，可提升每月出征上限至{1}次)",uVar7,uVar9,0);
              }
              if ((lVar6 != null) &&
                 (lVar5 = il2cpp_internal(lVar6,*(uint64 *)(*plVar4 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(plVar4 + 3) < 4) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar4[7] = lVar6;
              il2cpp_internal(plVar4 + 7,lVar6);
              uVar7 = String.Format(uVar8,plVar4);
              uVar8 = new SinglePlotData(uVar7,0,1,0,3,"0",1,0,0);
              if (lVar3 == null) throw; // [null/range check failed]
              goto LAB_180bbe2c6;
            }
            lVar3 = FUN_18046c440(0);
            lVar5 = FUN_18046c0a0(0);
            if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) ||
               (*(int64 *)(lVar5 + 0x2e0) == 0)) throw; // [null/range check failed]
            uVar7 = String.Format("目前已有{0}门派任务在身，还是先将此事料理妥当再说。",*(uint64 *)(*(int64 *)(lVar5 + 0x2e0) + 24));
            uVar8 = new SinglePlotData(uVar7,0,1,0,3,"0",1,0,0);
          }
          if (lVar3 != null) {
        LAB_180bbe2c6:
            PlotController.ChangePlot(lVar3,uVar8,0);
            return;
          }
        }
    }

    // Token : 0x6000DBD
    // RVA   : 0xBBEE40   Offset: 0xBBD640   Length: 0xF8
    public void ManageForceSetting()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181da2d20 + 184);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
          uVar3 = AreaData.GetForce(lVar2,0);
          if (lVar1 != null) {
            ForceSettingController.ShowForceSettingUI(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DBE
    // RVA   : 0xBBEC90   Offset: 0xBBD490   Length: 0xF8
    public void ManageForceHeroSetting()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181da2b20 + 184);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
          uVar3 = AreaData.GetForce(lVar2,0);
          if (lVar1 != null) {
            ForceHeroSettingController.ShowForceHeroSettingUI(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DBF
    // RVA   : 0xBC58A0   Offset: 0xBC40A0   Length: 0x197
    public void ShowForceHero()
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        lVar1 = **(int64 **)(DAT_181da2ba0 + 184);
        cVar3 = GameController.MeetCondition("我",0,0);
        if (!cVar3) {
          cVar3 = false;
        }
        else {
          cVar3 = GameController.MeetCondition("掌门",0,0);
          cVar3 = (cVar3) + true;
        }
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
          uVar4 = AreaData.GetForce(lVar2,0);
          if (lVar1 != null) {
            ForceHeroUIController.ShowForceHeroUI(lVar1,cVar3,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000DC0
    // RVA   : 0xBC6740   Offset: 0xBC4F40   Length: 0x34F
    public void ShowResearch()
    {
        var pStatics_7630 = *(int64*)(DAT_181d87630 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d77350 + 184) + 8);
        if (((*pStatics_df90 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar3 + 184) < **(int **)(DAT_181d77350 + 184)) {
        LAB_180bc69ea:
          uVar5 = 0;
        }
        else {
          if (((*pStatics_df90 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
          iVar1 = *(int *)(lVar3 + 132);
          lVar3 = *(int64 *)(pStatics_7630 + 56);
          if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 88)) == null) throw; // [null/range check failed]
          if (iVar1 != *(int *)(lVar3 + 112)) goto LAB_180bc69ea;
          uVar5 = 1;
        }
        lVar3 = *(int64 *)(pStatics_7630 + 56);
        if (((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 88)) != null) &&
           (uVar4 = AreaData.GetForce(lVar3,0), lVar2 != null)) {
          ResearchUIController.ShowResearchUI(lVar2,uVar5,uVar4,0);
          return;
        }
    }

    // Token : 0x6000DC1
    // RVA   : 0xBC6BF0   Offset: 0xBC53F0   Length: 0x46
    public void ShowWeaponResearch()
    {
        var pStatics = *(int64*)(DAT_181d8fbd8 + 184);
        if (*pStatics != 0) {
          WeaponResearchUIController.ShowWeaponResearchUI(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DC2
    // RVA   : 0xBC6040   Offset: 0xBC4840   Length: 0x46
    public void ShowMeditation()
    {
        var pStatics = *(int64*)(DAT_181d63770 + 184);
        if (*pStatics != 0) {
          MeditationUIController.ShowMeditationUI(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DC3
    // RVA   : 0xBBED90   Offset: 0xBBD590   Length: 0xAB
    public void ManageForceMoney()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.ManageForceMoneyPlotStart(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DC4
    // RVA   : 0xBBF2D0   Offset: 0xBBDAD0   Length: 0x1162
    public void OpenForceStorage()
    {
        var pStatics_7630 = *(int64*)(DAT_181d87630 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        float fVar11;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffffa8;
        ulong in_stack_ffffffffffffffb0;
        uint uVar12;
        uVar12 = (uint32)((uint64)in_stack_ffffffffffffffb0 >> 32);
        if (((*pStatics_df90 == 0) ||
            (*(int64 *)(*pStatics_df90 + 32) == 0)) ||
           (lVar2 = WorldData.Player()) == null) throw; // [null/range check failed]
        iVar1 = *(int *)(lVar2 + 132);
        lVar2 = *(int64 *)(pStatics_7630 + 56);
        if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 88)) == null) throw; // [null/range check failed]
        if (iVar1 == *(int *)(lVar2 + 112)) {
        LAB_180bc0113:
          if (((*pStatics_df90 != 0) &&
              (*(int64 *)(*pStatics_df90 + 32) != 0)) &&
             (lVar2 = WorldData.Player()) != null) {
            if (*(char *)(lVar2 + 180) == false) {
              lVar2 = FUN_18046c700(0);
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                 (lVar3 = WorldData.Player()) != null) {
                uVar4 = *(uint64 *)(lVar3 + 0x220);
                lVar3 = FUN_18046bac0(0);
                if (((lVar3 != null) && (*(int64 *)(lVar3 + 88) != 0)) &&
                   ((lVar3 = AreaData.GetForce(), lVar3 != null && (lVar2 != null)))) {
                  TradeUIController.ShowTradeUI
                            (lVar2,2,uVar4,*(uint64 *)(lVar3 + 160),
                             in_stack_ffffffffffffffa8 & 0xffffffffffffff00,0);
                  return;
                }
              }
            }
            else {
              lVar2 = FUN_18046c700(0);
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                 (lVar3 = WorldData.Player()) != null) {
                uVar4 = *(uint64 *)(lVar3 + 0x220);
                lVar3 = FUN_18046bac0(0);
                if (((lVar3 != null) && (*(int64 *)(lVar3 + 88) != 0)) &&
                   ((lVar3 = AreaData.GetForce(), lVar3 != null && (lVar2 != null)))) {
                  TradeUIController.ShowTradeUI
                            (lVar2,1,uVar4,*(uint64 *)(lVar3 + 160),
                             in_stack_ffffffffffffffa8 & 0xffffffffffffff00,0);
                  return;
                }
              }
            }
          }
        }
        else {
          lVar2 = *(int64 *)(pStatics_7630 + 56);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 88) == 0)) ||
             (lVar2 = AreaData.GetForce()) == null) throw; // [null/range check failed]
          if (*(int *)(lVar2 + 60) != -1) {
            lVar2 = FUN_18046bac0(0);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 88) == 0)) ||
               (lVar2 = AreaData.GetForce()) == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar2 + 60);
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
               (lVar2 = WorldData.Player()) == null) throw; // [null/range check failed]
            if (iVar1 == *(int *)(lVar2 + 132)) goto LAB_180bc0113;
          }
          if (((*pStatics_df90 == 0) ||
              (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          if (-1 < *(int *)(lVar2 + 132)) {
            lVar2 = FUN_18046bac0(0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 88) == 0)) throw; // [null/range check failed]
            lVar2 = AreaData.GetForce(*(int64 *)(lVar2 + 88),0);
            lVar3 = FUN_18046c0a0(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) || (lVar2 == null))
            throw; // [null/range check failed]
            fVar11 = (float)ForceData.GetForceFavor(lVar2,*(uint32 *)(lVar3 + 132),0);
            if (fVar11 <= 40.0) {
              lVar3 = FUN_18046c440(0);
              lVar2 = FUN_18046bac0(0);
              if (((lVar2 == null) || (*(int64 *)(lVar2 + 88) == 0)) ||
                 (lVar2 = AreaData.GetForce(*(int64 *)(lVar2 + 88),0)) == null)
              throw; // [null/range check failed]
              uVar4 = *(uint64 *)(lVar2 + 24);
              lVar2 = FUN_18046c0a0(0);
              if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                 ((lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0), lVar2 == null ||
                  (lVar2 = HeroData.GetForce(lVar2,0,0)) == null))) throw; // [null/range check failed]
              uVar4 = String.Format("这{0}素来与我{1}关系不和，\n想必不会将库存物品售卖与我。\n(需要门派好感40以上)",uVar4,*(uint64 *)(lVar2 + 24),0);
              uVar5 = new SinglePlotData(uVar4,0,1,0,CONCAT44(uVar12,3),"0",1,0,0);
              if (lVar3 == null) throw; // [null/range check failed]
              goto LAB_180bbf92b;
            }
          }
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 != null) && (*(int64 *)(lVar2 + 32) != 0)) &&
             (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) {
            if (*(int *)(lVar2 + 132) < 0) {
              lVar2 = FUN_18046c0a0(0);
              if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                 (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null)
              throw; // [null/range check failed]
              local_res18[0] = *(uint32 *)(lVar2 + 184);
            }
            else {
              lVar2 = FUN_18046bac0(0);
              if ((lVar2 == null) || (*(int64 *)(lVar2 + 88) == 0)) throw; // [null/range check failed]
              lVar2 = AreaData.GetForce(*(int64 *)(lVar2 + 88),0);
              lVar3 = FUN_18046c0a0(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                  (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) || (lVar2 == null))
              throw; // [null/range check failed]
              fVar11 = (float)ForceData.GetForceFavor(lVar2,*(uint32 *)(lVar3 + 132),0);
              local_res18[0] = (uint32)((fVar11 - 50.0) * 0.1);
            }
            lVar2 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar2,DAT_181d7c250);
            uVar4 = Int32.ToString(local_res18,0);
            uVar4 = String.Concat("购买库存;OpenOtherForceStorage;",uVar4,0);
            if (lVar2 != null) {
              FUN_181827900(lVar2,uVar4,DAT_181d7c3d0);
              FUN_181827900(lVar2,"告辞;HideInteractUI",DAT_181d7c3d0);
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                 (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) {
                if (-1 < *(int *)(lVar3 + 0x380)) {
                  lVar3 = FUN_18046c0a0(0);
                  if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                     (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null)
                  throw; // [null/range check failed]
                  iVar1 = *(int *)(lVar3 + 0x380);
                  lVar3 = FUN_18046bac0(0);
                  if ((lVar3 == null) || (*(int64 *)(lVar3 + 88) == 0)) throw; // [null/range check failed]
                  if (iVar1 == *(int *)(*(int64 *)(lVar3 + 88) + 112)) {
                    uVar4 = Int32.ToString(local_res18,0);
                    uVar4 = String.Concat("功绩兑换;OpenServantForceStorage;",uVar4,0);
                    FUN_18182ac70(lVar2,1,uVar4,DAT_181d7c6c8);
                  }
                }
                lVar3 = FUN_18046c440(0);
                lVar6 = FUN_18046c0a0(0);
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                  uVar4 = "鉴于我现在的{4}地位，\n{0}愿意将最高等级为{3}的库存物品售卖给我。";
                  if (-1 < *(int *)(lVar6 + 132)) {
                    uVar4 = "这{0}与我{1}的关系为{2}，\n因此愿意将最高等级为{3}的库存物品售卖给我。";
                  }
                  plVar7 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
                  lVar6 = FUN_18046bac0(0);
                  if (((lVar6 != null) && (*(int64 *)(lVar6 + 88) != 0)) &&
                     ((lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 88),0), lVar6 != null &&
                      (lVar6 = *(int64 *)(lVar6 + 24), plVar7 != (int64 *)0)))) {
                    if ((lVar6 != null) &&
                       (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar7 + 64))) == null) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    if ((int)plVar7[3] == 0) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar4,0);
                    }
                    plVar7[4] = lVar6;
                    il2cpp_internal(plVar7 + 4,lVar6);
                    lVar6 = FUN_18046c0a0(0);
                    if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                       (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                      lVar8 = HeroData.GetForce(lVar6,0,0);
                      lVar6 = "";
                      if (lVar8 != null) {
                        lVar6 = FUN_18046c0a0(0);
                        if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                           ((lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), lVar6 == null ||
                            (lVar6 = HeroData.GetForce(lVar6,0,0)) == null))) throw; // [null/range check failed]
                        lVar6 = *(int64 *)(lVar6 + 24);
                      }
                      if ((lVar6 != null) &&
                         (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar7 + 64))) == null)
                      {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      if (*(uint32 *)(plVar7 + 3) < 2) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      plVar7[5] = lVar6;
                      il2cpp_internal(plVar7 + 5,lVar6);
                      lVar6 = FUN_18046bac0(0);
                      if ((lVar6 != null) && (*(int64 *)(lVar6 + 88) != 0)) {
                        lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 88),0);
                        lVar8 = FUN_18046c0a0(0);
                        if ((((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) &&
                            (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) != null) &&
                           (lVar6 != null)) {
                          local_res20[0] = ForceData.GetForceFavor(lVar6,*(uint32 *)(lVar8 + 132),0)
                          ;
                          lVar6 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
                          if ((lVar6 != null) &&
                             (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar7 + 64)),
                             lVar8 == null)) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          if (*(uint32 *)(plVar7 + 3) < 3) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          plVar7[6] = lVar6;
                          il2cpp_internal(plVar7 + 6,lVar6);
                          uVar9 = (uint64)(int)local_res18[0];
                          lVar6 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x4e8);
                          if (lVar6 != null) {
                            uVar10 = uVar9;
                            if (*(uint32 *)(lVar6 + 24) <= local_res18[0]) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              uVar10 = (uint64)local_res18[0];
                            }
                            lVar6 = GlobalData.GenerateRareLvColorText
                                              (*(uint64 *)
                                                (*(int64 *)(lVar6 + 16) + 32 + uVar9 * 8),uVar10,0)
                            ;
                            if ((lVar6 != null) &&
                               (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar7 + 64)),
                               lVar8 == null)) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            if (*(uint32 *)(plVar7 + 3) < 4) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            plVar7[7] = lVar6;
                            il2cpp_internal(plVar7 + 7,lVar6);
                            lVar6 = FUN_18046c0a0(0);
                            if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                               (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) != null) {
                              lVar6 = HeroData.GetHeroForceLvDescribe(lVar6,0,0);
                              if ((lVar6 != null) &&
                                 (lVar8 = il2cpp_internal(lVar6,*(uint64 *)(*plVar7 + 64)),
                                 lVar8 == null)) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              if (*(uint32 *)(plVar7 + 3) < 5) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar7[8] = lVar6;
                              il2cpp_internal(plVar7 + 8,lVar6);
                              uVar4 = String.Format(uVar4,plVar7,0);
                              uVar5 = il2cpp_internal(DAT_181d7d2b0);
                              SinglePlotData.ctor
                                        (uVar5,uVar4,lVar2,1,0,CONCAT44(uVar12,3),"0",1,0,0);
                              if (lVar3 != null) {
        LAB_180bbf92b:
                                PlotController.ChangePlot(lVar3,uVar5,0);
                                return;
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
              }
            }
          }
        }
    }

    // Token : 0x6000DC5
    // RVA   : 0xBBEF40   Offset: 0xBBD740   Length: 0xAB
    public void ManageForceStorage()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.StartSetForceStorageDiscount(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DC6
    // RVA   : 0xBCD810   Offset: 0xBCC010   Length: 0x5CB
    public void StealForceResource()
    {
        var pStatics_7630 = *(int64*)(DAT_181d87630 + 184);
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar1 = *(int64 *)(pStatics_7630 + 56);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 88)) != null) {
          lVar1 = AreaData.GetForce(lVar1,0);
          if ((lVar1 != null) && (*(int64 *)(lVar1 + 0x168) != 0)) {
            if (*(int *)(*(int64 *)(lVar1 + 0x168) + 24) < 1) {
              lVar1 = *pStatics_c960;
              uVar3 = "本月已窃取过{0}之仓库。\n此时守备森严，已然无从下手，还需另待良机才是。";
              if (*(char *)(pStatics_ef00 + 4) != false) {
                uVar3 = "本月已挑战过{0}之仓库。\n还需另待良机才是。";
              }
              lVar2 = *(int64 *)(pStatics_7630 + 56);
              if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 88)) == null) throw; // [null/range check failed]
              lVar2 = AreaData.GetForce(lVar2,0);
              if (lVar2 == null) throw; // [null/range check failed]
              uVar3 = String.Format(uVar3,*(uint64 *)(lVar2 + 24));
              uVar4 = il2cpp_internal(DAT_181d7d2b0);
              lVar2 = 0;
            }
            else {
              lVar1 = *pStatics_c960;
              uVar3 = "此地乃是{0}储藏资源宝物之所，若能花费五日时间，\n想必可打探出一条潜入道路，从中窃取资源或宝物以为己用。";
              if (*(char *)(pStatics_ef00 + 4) != false) {
                uVar3 = "此地乃是{0}储藏资源宝物之所，若能花费五日时间准备进行江湖挑战。\n如果挑战成功，就可以赢取仓库内资源或物品。";
              }
              lVar2 = *(int64 *)(pStatics_7630 + 56);
              if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 88)) == null) throw; // [null/range check failed]
              lVar2 = AreaData.GetForce(lVar2,0);
              if (lVar2 == null) throw; // [null/range check failed]
              uVar3 = String.Format(uVar3,*(uint64 *)(lVar2 + 24),0);
              lVar2 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar2,DAT_181d7c250);
              uVar4 = "开始准备";
              if (*(char *)(pStatics_ef00 + 4) == false) {
                uVar4 = "开始潜入";
              }
              uVar4 = String.Format("{0};StealForceResourceStart",uVar4,0);
              if (lVar2 == null) throw; // [null/range check failed]
              FUN_181827900(lVar2,uVar4,DAT_181d7c3d0);
              FUN_181827900(lVar2,"还是算了;HideInteractUI");
              uVar4 = il2cpp_internal(DAT_181d7d2b0);
            }
            SinglePlotData.ctor(uVar4,uVar3,lVar2,1,0,3,"0",1,0,0);
            if (lVar1 != null) {
              PlotController.ChangePlot(lVar1,uVar4,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000DC7
    // RVA   : 0xBCDDE0   Offset: 0xBCC5E0   Length: 0x587
    public void StealForceSkill()
    {
        var pStatics_7630 = *(int64*)(DAT_181d87630 + 184);
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        uint[] local_res8 = new uint[2];
        if (this.buildingData != null) {
          if (0 < this.buildingData.enemyMonth) {
            lVar5 = *pStatics_c960;
            uVar2 = "不久前刚偷师过{0}之武学，此刻守备森严，已然无从下手。\n至少要等{1}个月后风平浪静，方可另择良机。";
            if (*(char *)(pStatics_ef00 + 4) != false) {
              uVar2 = "不久前刚挑战过{0}之藏经阁。\n至少要等{1}个月后风平浪静，方可另择良机。";
            }
            lVar1 = *(int64 *)(pStatics_7630 + 56);
            if (((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 88)) != null) &&
               (lVar1 = AreaData.GetForce(lVar1,0)) != null) {
              uVar3 = *(uint64 *)(lVar1 + 24);
              if (this.buildingData != null) {
                local_res8[0] = this.buildingData.enemyMonth;
                uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                uVar2 = String.Format(uVar2,uVar3,uVar4,0);
                uVar3 = new SinglePlotData(uVar2,0,1,0,3,"0",1,0,0);
                if (lVar5 != null) goto LAB_180bce158;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = *pStatics_c960;
          uVar2 = "此地乃是{0}藏经习武之所，若想打探出一条潜入道路，非得花费十日时间不可。\n只是此处亦是门派守卫最为森严之处，若无万全准备，切不可贸然行动。";
          if (*(char *)(pStatics_ef00 + 4) != false) {
            uVar2 = "此地乃是{0}藏经习武之所，可以花费十日时间准备进行江湖挑战。\n如果挑战成功，就可以赢取藏经阁内一本秘籍。";
          }
          lVar1 = *(int64 *)(pStatics_7630 + 56);
          if (((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 88)) != null) &&
             (lVar1 = AreaData.GetForce(lVar1,0)) != null) {
            uVar2 = String.Format(uVar2,*(uint64 *)(lVar1 + 24),0);
            lVar1 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar1,DAT_181d7c250);
            uVar3 = "开始准备";
            if (*(char *)(pStatics_ef00 + 4) == false) {
              uVar3 = "开始潜入";
            }
            uVar3 = String.Format("{0};StealForceSkillStart",uVar3,0);
            if (lVar1 != null) {
              FUN_181827900(lVar1,uVar3,DAT_181d7c3d0);
              FUN_181827900(lVar1,"还是算了;HideInteractUI");
              uVar3 = new SinglePlotData(uVar2,lVar1,1,0,3,"0",1,0,0);
              if (lVar5 != null) {
        LAB_180bce158:
                PlotController.ChangePlot(lVar5,uVar3,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000DC8
    // RVA   : 0xBC0440   Offset: 0xBBEC40   Length: 0xAB
    public void OpenSelfStorage()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.OpenSelfStorage(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DC9
    // RVA   : 0xBBE970   Offset: 0xBBD170   Length: 0x228
    public void ManageBookStore()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d88158 + 184) + 8);
        if ((*pStatics != 0) &&
           (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            uVar2 = *(uint64 *)(lVar3 + 0x220);
            lVar3 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
            if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 88)) != null) {
              lVar3 = AreaData.GetForce(lVar3,0);
              if ((lVar3 != null) && (lVar1 != null)) {
                TradeUIController.ShowTradeUI(lVar1,1,3,uVar2,*(uint64 *)(lVar3 + 184),0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000DCA
    // RVA   : 0xBC36B0   Offset: 0xBC1EB0   Length: 0xFA
    public void ShowBookStore()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181d8d678 + 184);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
          uVar3 = AreaData.GetForce(lVar2,0);
          if (lVar1 != null) {
            BookStoreController.ShowBookStoreUI(lVar1,0,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DCB
    // RVA   : 0xBB8C60   Offset: 0xBB7460   Length: 0xBF
    public void ChooseReadBook()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.ChooseReadBook(*pStatics,"false",0);
          return;
        }
    }

    // Token : 0x6000DCC
    // RVA   : 0xBCE370   Offset: 0xBCCB70   Length: 0x34F
    public void StudyFightMoney()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        int iVar6;
        int[] local_res18 = new int[2];
        ulong in_stack_ffffffffffffffb8;
        uint uVar7;
        uint uVar8;
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        iVar6 = 0;
        do {
          uVar7 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
          lVar1 = *(int64 *)(pStatics + 0x498);
          if (lVar1 == null) {
        LAB_180bce6b4:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int *)(lVar1 + 24) <= iVar6) {
            if (lVar2 != null) {
              FUN_181827900(lVar2,"取消;HideInteractUI",DAT_181d7c3d0);
              lVar1 = **(int64 **)(DAT_181d6c960 + 184);
              uVar3 = FUN_180228420(DAT_181d63120);
              uVar3 = String.Format("咱们武馆乃是这#AreaName#城中最佳的习武场地，设备齐全，经验丰富。\n少侠只许付上少许租金，便可在此精进武艺。",uVar3,0);
              uVar8 = 0;
              uVar4 = BuildingUIController.GenerateBuildingNPCString
                                (this,"武师",0xffffffff,0xffffffff,CONCAT44(uVar7,0xffffffff),0)
              ;
              uVar5 = new SinglePlotData(uVar3,lVar2,5,uVar4,CONCAT44(uVar8,3),"0",0,0,0);
              if (lVar1 != null) {
                PlotController.ChangePlot(lVar1,uVar5,0);
                return;
              }
            }
            goto LAB_180bce6b4;
          }
          lVar1 = *(int64 *)(pStatics + 0x498);
          if (lVar1 == null) {
        LAB_180bce6ba:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = FUN_180002f80(lVar1,iVar6,DAT_181d7c9c0);
          local_res18[0] = iVar6;
          uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          uVar3 = String.Format("修炼{0};StudyFightSelfChooseMoney;{1}",uVar3,uVar4,0);
          if (lVar2 == null) goto LAB_180bce6ba;
          FUN_181827900(lVar2,uVar3,DAT_181d7c3d0);
          iVar6 = iVar6 + 1;
        } while( true );
    }

    // Token : 0x6000DCD
    // RVA   : 0xBCE6C0   Offset: 0xBCCEC0   Length: 0x390
    public void StudyFightOtherMoney()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        int iVar6;
        int[] local_res18 = new int[2];
        float[] local_res20 = new float[2];
        ulong in_stack_ffffffffffffff88;
        uint uVar7;
        uint uVar8;
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        iVar6 = 0;
        do {
          uVar7 = (uint32)((uint64)in_stack_ffffffffffffff88 >> 32);
          lVar1 = *(int64 *)(pStatics + 0x410);
          if (lVar1 == null) {
        LAB_180bcea45:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int *)(lVar1 + 24) <= iVar6) {
            if (lVar2 != null) {
              FUN_181827900(lVar2,"取消;HideInteractUI",DAT_181d7c3d0);
              uVar8 = 0;
              lVar1 = **(int64 **)(DAT_181d6c960 + 184);
              uVar3 = BuildingUIController.GenerateBuildingNPCString
                                (this,"武师",0xffffffff,0xffffffff,CONCAT44(uVar7,0xffffffff),0)
              ;
              uVar4 = il2cpp_internal(DAT_181d7d2b0);
              SinglePlotData.ctor
                        (uVar4,"不知大侠想雇佣何种级别的武师进行陪练？\n须知武师级别越高，出场费自然也越贵。",lVar2,5,uVar3,CONCAT44(uVar8,3),"0",0,0,0);
              if (lVar1 != null) {
                PlotController.ChangePlot(lVar1,uVar4,0);
                return;
              }
            }
            goto LAB_180bcea45;
          }
          lVar1 = *(int64 *)(pStatics + 0x410);
          if (lVar1 == null) {
        LAB_180bcea4b:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = FUN_180002f80(lVar1,iVar6,DAT_181d7c9c0);
          local_res18[0] = iVar6;
          uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          local_res20[0] = (float)FUN_1801f7f00(0x40000000);
          local_res20[0] = local_res20[0] * 10.0;
          uVar5 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
          in_stack_ffffffffffffff88 = 0;
          uVar3 = String.Format("{0};StudyFightOtherMoneyChoose;{1};0/{2}",uVar3,uVar4,uVar5,0);
          if (lVar2 == null) goto LAB_180bcea4b;
          FUN_181827900(lVar2,uVar3,DAT_181d7c3d0);
          iVar6 = iVar6 + 1;
        } while( true );
    }

    // Token : 0x6000DCE
    // RVA   : 0xBB8A40   Offset: 0xBB7240   Length: 0x216
    public void ChooseReadBookMoney()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong in_stack_ffffffffffffffc8;
        uint uVar5;
        uint uVar6;
        uVar5 = (uint32)((uint64)in_stack_ffffffffffffffc8 >> 32);
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        if (lVar2 != null) {
          FUN_181827900(lVar2,"选择秘籍;ChooseReadBook;true",DAT_181d7c3d0);
          FUN_181827900(lVar2,"取消;HideInteractUI",DAT_181d7c3d0);
          uVar6 = 0;
          uVar3 = BuildingUIController.GenerateBuildingNPCString
                            (this,"武师",0xffffffff,0xffffffff,CONCAT44(uVar5,0xffffffff),0);
          uVar4 = new SinglePlotData("这位少侠想租下本武馆的书房，用于研读秘籍吗？\n保管安静舒适，价钱实惠~",lVar2,5,uVar3,CONCAT44(uVar6,3),"0",0,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000DCF
    // RVA   : 0xBB6D80   Offset: 0xBB5580   Length: 0x4A8
    public void AttackMartialClub()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        ulong in_stack_ffffffffffffffb8;
        uint uVar6;
        ulong in_stack_ffffffffffffffc0;
        uint uVar7;
        uVar6 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
        uVar7 = (uint32)((uint64)in_stack_ffffffffffffffc0 >> 32);
        if ((*pStatics == 0) ||
           (lVar1 = *(int64 *)(*pStatics + 32)) == null)
        throw; // [null/range check failed]
        if (*(int *)(lVar1 + 300) < 1) {
          if (((this.buildingData == null) ||
              (lVar1 = this.buildingData.shopItemList) == null) ||
             (lVar1 = *(int64 *)(lVar1 + 48)) == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar1 + 24) < 4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 56);
          if (lVar1 == null) throw; // [null/range check failed]
          if (*(int *)(lVar1 + 24) != 0) {
            lVar1 = FUN_18046c440(0);
            if ((this.buildingData == null) ||
               (lVar2 = AreaBuildingData.DataBase(this.buildingData,0)) == null)
            throw; // [null/range check failed]
            uVar3 = String.Format("大侠目露凶光，气势逼人，莫不是来踢馆的？\n武林中人向来以和为贵，还望大侠三思啊！",*(uint64 *)(lVar2 + 24),0);
            lVar2 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar2,DAT_181d7c250);
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_181827900(lVar2,"没错！;AttackMartialClubStart",DAT_181d7c3d0);
            FUN_181827900(lVar2,"开个玩笑;HideInteractUI",DAT_181d7c3d0);
            uVar7 = 0;
            uVar4 = BuildingUIController.GenerateBuildingNPCString
                              (this,"武师",0xffffffff,0xffffffff,CONCAT44(uVar6,0xffffffff),0);
            uVar5 = new SinglePlotData(uVar3,lVar2,5,uVar4,CONCAT44(uVar7,3),"0",0,0,0);
            if (lVar1 == null) throw; // [null/range check failed]
            goto LAB_180bb71fa;
          }
          lVar1 = FUN_18046c440(0);
          uVar3 = FUN_180228420(DAT_181d63120);
          uVar3 = String.Format("这破武馆中似乎已无秘籍藏品了，又有何踢馆的必要呢？",uVar3,0);
          uVar5 = il2cpp_internal(DAT_181d7d2b0);
        }
        else {
          lVar1 = **(int64 **)(DAT_181d6c960 + 184);
          uVar3 = FUN_180228420(DAT_181d63120);
          uVar3 = String.Format("这个月已在此武馆大闹过一场，\n还需低调些时日避避风头，免得引起武林公愤。",uVar3,0);
          uVar5 = il2cpp_internal(DAT_181d7d2b0);
        }
        SinglePlotData.ctor(uVar5,uVar3,0,1,0,CONCAT44(uVar7,3),"0",1,0,0);
        if (lVar1 != null) {
        LAB_180bb71fa:
          PlotController.ChangePlot(lVar1,uVar5,0);
          return;
        }
    }

    // Token : 0x6000DD0
    // RVA   : 0xBC3860   Offset: 0xBC2060   Length: 0x1D7
    public void ShowBookWriter()
    {
        var pStatics = *(int64*)(DAT_181d87630 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8d810 + 184) + 8);
        lVar3 = *(int64 *)(pStatics + 56);
        if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 88)) != null) {
          lVar3 = AreaData.GetForce(lVar3,0);
          if (lVar3 != null) {
            uVar2 = *(uint64 *)(lVar3 + 176);
            lVar3 = *(int64 *)(pStatics + 56);
            if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 88)) != null) {
              uVar4 = AreaData.GetForce(lVar3,0);
              if (lVar1 != null) {
                BookWriterUIController.ShowBookWriterUI(lVar1,uVar2,uVar4,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000DD1
    // RVA   : 0xBC37B0   Offset: 0xBC1FB0   Length: 0xAB
    public void ShowBookWriterSelf()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.ShowBookWriterSelf(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DD2
    // RVA   : 0xBC3C30   Offset: 0xBC2430   Length: 0x17D
    public void ShowBuildingShop()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d88158 + 184) + 8);
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if ((lVar2 != null) && ((this.buildingData != null && (lVar1 != null)))) {
            TradeUIController.ShowTradeUI
                      (lVar1,0,*(uint64 *)(lVar2 + 0x220),
                       this.buildingData.shopItemList,1,0);
            return;
          }
        }
    }

    // Token : 0x6000DD3
    // RVA   : 0xBC3AA0   Offset: 0xBC22A0   Length: 0x180
    public void ShowBuildingShopForceStorage()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d88158 + 184) + 8);
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if ((lVar2 != null) && ((this.buildingData != null && (lVar1 != null)))) {
            TradeUIController.ShowTradeUI
                      (lVar1,2,*(uint64 *)(lVar2 + 0x220),
                       this.buildingData.shopItemList,0,0);
            return;
          }
        }
    }

    // Token : 0x6000DD4
    // RVA   : 0xBCD5F0   Offset: 0xBCBDF0   Length: 0x210
    public void StealBuildingShop()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        float fVar4;
        uint[] local_res18 = new uint[4];
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        fVar4 = (float)BuildingUIController.GetBuildingHeroLv(this,0);
        local_res18[0] = Mathf.RoundToInt((fVar4 + 1.0) * 25.0,0);
        uVar3 = Int32.ToString(local_res18,0);
        uVar3 = String.Concat("潜入库房;StealBuildingShopStart;;;;Dodge/",uVar3,0);
        if (lVar2 != null) {
          FUN_181827900(lVar2,uVar3,DAT_181d7c3d0);
          FUN_181827900(lVar2,"还是算了;HideInteractUI",DAT_181d7c3d0);
          uVar3 = new SinglePlotData("嘿嘿，眼下趁着店家不备，可以潜入库房中去。\n虽说库房内堆放的商品大多不是精品，但能免费顺走也是美事一桩啊！",lVar2,1,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DD5
    // RVA   : 0xBC3490   Offset: 0xBC1C90   Length: 0x215
    public void RobBuildingShop()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong in_stack_ffffffffffffffc8;
        uint uVar5;
        uint uVar6;
        uVar5 = (uint32)((uint64)in_stack_ffffffffffffffc8 >> 32);
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        if (lVar2 != null) {
          FUN_181827900(lVar2,"我要打劫！;RobBuildingShopStart",DAT_181d7c3d0);
          FUN_181827900(lVar2,"没事没事;HideInteractUI",DAT_181d7c3d0);
          uVar6 = 0;
          uVar3 = BuildingUIController.GenerateBuildingNPCString
                            (this,"店铺商人",0xfffffffd,0xffffffff,CONCAT44(uVar5,0xffffffff),0);
          uVar4 = new SinglePlotData("少侠，你面色凝重，眼神游移，是不是突感身体不适？\n要不我唤店内的守卫，将你送到医馆去吧！",lVar2,5,uVar3,CONCAT44(uVar6,3),"0",0,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000DD6
    // RVA   : 0xBC3A40   Offset: 0xBC2240   Length: 0x5E
    public void ShowBuildingMission()
    {
        var pStatics = *(int64*)(DAT_181d8def8 + 184);
        if ((this.buildingChoiceSelected != null) && (*pStatics != 0)) {
          BountyUIController.ShowBountyUI
                    (*pStatics,this.buildingData,
                     this.buildingChoiceSelected.text,0);
          return;
        }
    }

    // Token : 0x6000DD7
    // RVA   : 0xBC6090   Offset: 0xBC4890   Length: 0x6AA
    public void ShowOtherForceMission()
    {
        var pStatics_7630 = *(int64*)(DAT_181d87630 + 184);
        var pStatics_def8 = *(int64*)(DAT_181d8def8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        float fVar8;
        if (((*pStatics_df90 == 0) ||
            (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        if (100.0 < *(float *)(lVar2 + 0x1c4) || *(float *)(lVar2 + 0x1c4) == 100.0) {
        LAB_180bc6496:
          if (((*pStatics_df90 == 0) ||
              (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          lVar2 = HeroData.GetForce(lVar2,0,0);
          if (lVar2 != null) {
            if (((*pStatics_df90 == 0) ||
                (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
               (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
            lVar2 = HeroData.GetForce(lVar2,0,0);
            lVar5 = *(int64 *)(pStatics_7630 + 56);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) || (lVar2 == null))
            throw; // [null/range check failed]
            fVar8 = (float)ForceData.GetForceFavor(lVar2,*(uint32 *)(lVar5 + 112),0);
            if (fVar8 < 40.0) {
              lVar2 = FUN_18046c440(0);
              uVar3 = FUN_180228420(DAT_181d63120);
              uVar4 = "#PlayerForceName#与本门不甚和睦，恐怕还不能将本门任务委托于你。\n(需要至少40点门派好感。)";
              goto LAB_180bc6375;
            }
          }
          if ((this.buildingChoiceSelected != null) && (*pStatics_def8 != 0)) {
            BountyUIController.ShowBountyUI
                      (*pStatics_def8,this.buildingData,
                       this.buildingChoiceSelected.text,0);
            return;
          }
        }
        else {
          if (((*pStatics_df90 == 0) ||
              (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          iVar1 = *(int *)(lVar2 + 0x380);
          lVar2 = *(int64 *)(pStatics_7630 + 56);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 88)) == null) throw; // [null/range check failed]
          if (iVar1 == *(int *)(lVar2 + 112)) goto LAB_180bc6496;
          lVar2 = FUN_18046c440(0);
          uVar3 = FUN_180228420(DAT_181d63120);
          uVar4 = "#PlayerName#的江湖声望太低，若将本门任务委托于你，只怕难以服众。\n(需要至少100点声望。)";
        LAB_180bc6375:
          uVar4 = String.Format(uVar4,uVar3,0);
          lVar5 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar5,DAT_181d7c250);
          if (lVar5 != null) {
            FUN_181827900(lVar5,"是我唐突了;HideInteractUI",DAT_181d7c3d0);
            lVar6 = FUN_18046bac0(0);
            if (((lVar6 != null) && (*(int64 *)(lVar6 + 88) != 0)) &&
               (lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 88),0)) != null) {
              uVar3 = Int32.ToString(lVar6 + 88,0);
              uVar7 = il2cpp_internal();
              SinglePlotData.ctor(uVar7,uVar4,lVar5,3,uVar3,3,"0",0,0,0);
              if (lVar2 != null) {
                PlotController.ChangePlot(lVar2,uVar7,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000DD8
    // RVA   : 0xBC5110   Offset: 0xBC3910   Length: 0x785
    public void ShowContributionExchange()
    {
        var pStatics_7630 = *(int64*)(DAT_181d87630 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        float fVar8;
        if (((*pStatics_df90 == 0) ||
            (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        if (100.0 < *(float *)(lVar2 + 0x1c4) || *(float *)(lVar2 + 0x1c4) == 100.0) {
        LAB_180bc5526:
          if (((*pStatics_df90 == 0) ||
              (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          lVar2 = HeroData.GetForce(lVar2,0,0);
          if (lVar2 != null) {
            if (((*pStatics_df90 == 0) ||
                (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
               (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
            lVar2 = HeroData.GetForce(lVar2,0,0);
            lVar5 = *(int64 *)(pStatics_7630 + 56);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) || (lVar2 == null))
            throw; // [null/range check failed]
            fVar8 = (float)ForceData.GetForceFavor(lVar2,*(uint32 *)(lVar5 + 112),0);
            if (fVar8 < 40.0) {
              lVar2 = FUN_18046c440(0);
              uVar3 = FUN_180228420(DAT_181d63120);
              uVar4 = "#PlayerForceName#与本门不甚和睦，恐怕还不能将本门秘藏兑换于你。\n(需要至少40点门派好感。)";
              goto LAB_180bc5401;
            }
          }
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d6a268 + 184) + 16);
          lVar5 = *(int64 *)(pStatics_7630 + 56);
          if (((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 88)) != null) &&
             (uVar4 = AreaData.GetForce(lVar5,0), lVar2 != null)) {
            OtherForceContributionExchangeController.ShowExchangeUI(lVar2,uVar4,0);
            return;
          }
        }
        else {
          if (((*pStatics_df90 == 0) ||
              (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          iVar1 = *(int *)(lVar2 + 0x380);
          lVar2 = *(int64 *)(pStatics_7630 + 56);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 88)) == null) throw; // [null/range check failed]
          if (iVar1 == *(int *)(lVar2 + 112)) goto LAB_180bc5526;
          lVar2 = FUN_18046c440(0);
          uVar3 = FUN_180228420(DAT_181d63120);
          uVar4 = "#PlayerName#的江湖声望太低，若将本门秘藏兑换于你，只怕难以服众。\n(需要至少100点声望。)";
        LAB_180bc5401:
          uVar4 = String.Format(uVar4,uVar3,0);
          lVar5 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar5,DAT_181d7c250);
          if (lVar5 != null) {
            FUN_181827900(lVar5,"是我唐突了;HideInteractUI",DAT_181d7c3d0);
            lVar6 = FUN_18046bac0(0);
            if (((lVar6 != null) && (*(int64 *)(lVar6 + 88) != 0)) &&
               (lVar6 = AreaData.GetForce(*(int64 *)(lVar6 + 88),0)) != null) {
              uVar3 = Int32.ToString(lVar6 + 88,0);
              uVar7 = il2cpp_internal();
              SinglePlotData.ctor(uVar7,uVar4,lVar5,3,uVar3,3,"0",0,0,0);
              if (lVar2 != null) {
                PlotController.ChangePlot(lVar2,uVar7,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000DD9
    // RVA   : 0xBC5C50   Offset: 0xBC4450   Length: 0x1AD
    public void ShowFreeTrade()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        lVar2 = **(int64 **)(DAT_181da3520 + 184);
        if ((*pStatics != 0) &&
           (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            cVar1 = *(char *)(lVar3 + 180);
            if ((*pStatics != 0) &&
               (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
              uVar4 = WorldData.GetHeroForce(lVar3,0,0);
              if (lVar2 != null) {
                FreeTradeUIController.ShowFreeTradeUI(lVar2,cVar1,uVar4,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000DDA
    // RVA   : 0xBC5EC0   Offset: 0xBC46C0   Length: 0xBF
    public void ShowGovernLv()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.GovernPlotStart(*pStatics,"0",0);
          return;
        }
    }

    // Token : 0x6000DDB
    // RVA   : 0xBC5F80   Offset: 0xBC4780   Length: 0xBF
    public void ShowHornorPlot()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.HornorPlotStart(*pStatics,"0",0);
          return;
        }
    }

    // Token : 0x6000DDC
    // RVA   : 0xBC5E00   Offset: 0xBC4600   Length: 0xBF
    public void ShowGovernContribution()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.ShowGovernShop(*pStatics,"0",0);
          return;
        }
    }

    // Token : 0x6000DDD
    // RVA   : 0xBBB880   Offset: 0xBBA080   Length: 0x594
    public void GovernmentClearBadFame()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        ulong in_stack_ffffffffffffffb8;
        uint uVar6;
        ulong in_stack_ffffffffffffffc0;
        uint uVar7;
        uVar6 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
        uVar7 = (uint32)((uint64)in_stack_ffffffffffffffc0 >> 32);
        if (((*pStatics_df90 == 0) ||
            (lVar1 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar1 = WorldData.Player(lVar1,0)) == null) throw; // [null/range check failed]
        if (*(float *)(lVar1 + 0x1c8) <= 0.0) {
          lVar1 = *pStatics_c960;
          uVar4 = new SinglePlotData("我目前在江湖中并无恶名，何必庸人自扰。",0,1,0,CONCAT44(uVar7,3),"0",1,0,0);
        }
        else {
          lVar1 = *pStatics_c960;
          uVar4 = "少侠目前在江湖中恶名为{0}，是否要洗心革面，重归正道呢？";
          if (*(char *)(pStatics_ef00 + 4) != false) {
            uVar4 = "少侠目前在江湖中威慑为{0}，是否要降低威慑呢？";
          }
          if (((*pStatics_df90 == 0) ||
              (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          uVar3 = Single.ToString(lVar2 + 0x1c8,"f0",0);
          uVar3 = String.Format(uVar4,uVar3,0);
          lVar2 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar2,DAT_181d7c250);
          if (lVar2 == null) throw; // [null/range check failed]
          FUN_181827900(lVar2,"缴纳罚金;GovernmentClearBadFame;0",DAT_181d7c3d0);
          FUN_181827900(lVar2,"牺牲声望;GovernmentClearBadFame;1",DAT_181d7c3d0);
          uVar4 = "自愿思过";
          if (*(char *)(pStatics_ef00 + 4) == false) {
            uVar4 = "自首入狱";
          }
          uVar4 = String.Format("{0};GovernmentClearBadFame;2",uVar4,0);
          FUN_181827900(lVar2,uVar4,DAT_181d7c3d0);
          FUN_181827900(lVar2,"还是算了;HideInteractUI",DAT_181d7c3d0);
          uVar7 = 0;
          uVar5 = BuildingUIController.GenerateBuildingNPCString
                            (this,"官差",0xfffffffb,0xffffffff,CONCAT44(uVar6,0xffffffff),0);
          uVar4 = new SinglePlotData(uVar3,lVar2,5,uVar5,CONCAT44(uVar7,3),"0",0,0,0);
        }
        if (lVar1 != null) {
          PlotController.ChangePlot(lVar1,uVar4,0);
          return;
        }
    }

    // Token : 0x6000DDE
    // RVA   : 0xBBF1F0   Offset: 0xBBD9F0   Length: 0xD8
    public int MaxGambleTime()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            cVar1 = HeroData.HaveForceFunction(lVar2,0,0);
            uVar3 = 3;
            if (cVar1) {
              uVar3 = 6;
            }
            return uVar3;
          }
        }
    }

    // Token : 0x6000DDF
    // RVA   : 0xBCB970   Offset: 0xBCA170   Length: 0x2D0
    public void StartGamble()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        int iVar3;
        uint uVar4;
        ulong uVar5;
        ulong uVar6;
        if ((*pStatics_df90 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          iVar1 = *(int *)(lVar2 + 0x114);
          iVar3 = BuildingUIController.MaxGambleTime(this,0);
          if (iVar1 < iVar3) {
            if (*pStatics_c960 != 0) {
              PlotController.ChooseGambleTarget(*pStatics_c960,0);
              return;
            }
          }
          else {
            lVar2 = *pStatics_c960;
            uVar4 = BuildingUIController.MaxGambleTime(this,0);
            uVar5 = GlobalData.GetNumText(uVar4,0);
            uVar5 = String.Format("这个月已经赌博{0}日。\n若是天天吆五喝六，只怕为江湖中人耻笑。",uVar5,0);
            uVar6 = new SinglePlotData(uVar5,0,1,0,3,"0",1,0,0);
            if (lVar2 != null) {
              PlotController.ChangePlot(lVar2,uVar6,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000DE0
    // RVA   : 0xBBB0E0   Offset: 0xBB98E0   Length: 0x4B6
    public string GetPartyChoiceString(int type, int lv)
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        float fVar5;
        float fVar6;
        uint[] local_res18 = new uint[4];
        uint local_38;
        float local_34;
        float local_30;
        float local_2c [5];
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181d7f180,7);
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 24);
        if (lVar3 != null) {
          if (*(uint32 *)(lVar3 + 24) <= lv) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = lVar3[lv];
          if (plVar1 != (int64 *)0) {
            if (lVar3 != null) {
              lVar2 = il2cpp_internal(lVar3,*(uint64 *)(*plVar1 + 64));
              if (lVar2 == null) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
            }
            if ((int)plVar1[3] == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            plVar1[4] = lVar3;
            il2cpp_internal(plVar1 + 4,lVar3);
            lVar3 = GlobalData.GetNumText(lv + 1,0);
            if (lVar3 != null) {
              lVar2 = il2cpp_internal(lVar3,*(uint64 *)(*plVar1 + 64));
              if (lVar2 == null) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
            }
            if (*(uint32 *)(plVar1 + 3) < 2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            plVar1[5] = lVar3;
            il2cpp_internal(plVar1 + 5,lVar3);
            local_res18[0] = type;
            lVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            if (lVar3 != null) {
              lVar2 = il2cpp_internal(lVar3,*(uint64 *)(*plVar1 + 64));
              if (lVar2 == null) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
            }
            if (*(uint32 *)(plVar1 + 3) < 3) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            plVar1[6] = lVar3;
            il2cpp_internal(plVar1 + 6,lVar3);
            local_38 = lv;
            lVar3 = il2cpp_value_box(DAT_181d5b2f8,&local_38);
            if (lVar3 != null) {
              lVar2 = il2cpp_internal(lVar3,*(uint64 *)(*plVar1 + 64));
              if (lVar2 == null) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
            }
            if (*(uint32 *)(plVar1 + 3) < 4) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            plVar1[7] = lVar3;
            il2cpp_internal(plVar1 + 7,lVar3);
            local_34 = (float)FUN_1801f7f00(0x40000000);
            local_34 = local_34 * 100.0;
            lVar3 = il2cpp_value_box(DAT_181d7d0b8,&local_34);
            if (lVar3 != null) {
              lVar2 = il2cpp_internal(lVar3,*(uint64 *)(*plVar1 + 64));
              if (lVar2 == null) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
            }
            if (*(uint32 *)(plVar1 + 3) < 5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            plVar1[8] = lVar3;
            il2cpp_internal(plVar1 + 8,lVar3);
            fVar5 = (float)PlotController.GetPartyLvBaseScore(lv,0);
            if (this.buildingData != null) {
              local_30 = (float)AreaBuildingData.GetExtraPartyScore(this.buildingData,0);
              local_30 = local_30 + fVar5;
              lVar3 = il2cpp_value_box(DAT_181d7d0b8,&local_30);
              if (lVar3 != null) {
                lVar2 = il2cpp_internal(lVar3,*(uint64 *)(*plVar1 + 64));
                if (lVar2 == null) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
              }
              if (*(uint32 *)(plVar1 + 3) < 6) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              plVar1[9] = lVar3;
              il2cpp_internal(plVar1 + 9,lVar3);
              fVar5 = (float)PlotController.GetPartyLvBaseRate(lv,0);
              if (this.buildingData != null) {
                fVar6 = (float)AreaBuildingData.GetExtraPartyRate(this.buildingData,0);
                local_2c[0] = (fVar6 + fVar5) * 100.0;
                lVar3 = il2cpp_value_box(DAT_181d7d0b8,local_2c);
                if (lVar3 != null) {
                  lVar2 = il2cpp_internal(lVar3,*(uint64 *)(*plVar1 + 64));
                  if (lVar2 == null) {
                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar4,0);
                  }
                }
                if (6 < *(uint32 *)(plVar1 + 3)) {
                  plVar1[10] = lVar3;
                  il2cpp_internal(plVar1 + 10,lVar3);
                  String.Format("{0}宴会({1}日);StartPrepareParty;{2}-{3};0/{4};基础评分{5}\n基础加成{6}%",plVar1,0);
                  return;
                }
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
            }
          }
        }
    }

    // Token : 0x6000DE1
    // RVA   : 0xBCCA10   Offset: 0xBCB210   Length: 0xABF
    public void StartParty()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar7;
        long lVar8;
        int iVar9;
        uint[] local_res18 = new uint[2];
        float[] local_res20 = new float[2];
        ulong in_stack_ffffffffffffff98;
        ulong in_stack_ffffffffffffffa0;
        uint uVar11;
        ulong uVar10;
        uint uVar12;
        uVar12 = (uint32)((uint64)in_stack_ffffffffffffffa0 >> 32);
        if (((*pStatics_df90 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
        if (*(float *)(lVar3 + 0x1c4) <= 100.0 && *(float *)(lVar3 + 0x1c4) != 100.0) {
          lVar3 = *pStatics_c960;
          uVar5 = il2cpp_internal(DAT_181d7d2b0);
          uVar4 = "若是连100点声望都没有就贸然举办宴会，怕是没人会赏脸参加呀。";
        }
        else {
          if ((*pStatics_df90 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null)
          throw; // [null/range check failed]
          if (*(int *)(lVar3 + 0x118) < 3) {
            lVar3 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar3,DAT_181d7c250);
            iVar9 = 0;
            while( true ) {
              uVar12 = (uint32)((uint64)in_stack_ffffffffffffff98 >> 32);
              lVar2 = *(int64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 24);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(int *)(lVar2 + 24) <= iVar9) break;
              uVar4 = BuildingUIController.GetPartyChoiceString(this,0,iVar9,0);
              if (lVar3 == null) throw; // [null/range check failed]
              FUN_181827900(lVar3,uVar4,DAT_181d7c3d0);
              iVar9 = iVar9 + 1;
            }
            if (lVar3 != null) {
              FUN_181827900(lVar3,"还是算了;HideInteractUI",DAT_181d7c3d0);
              lVar2 = *pStatics_c960;
              uVar4 = new PlotData(0);
              if (lVar2 != null) {
                puVar1 = (uint64 *)(lVar2 + 0x108);
                *puVar1 = uVar4;
                il2cpp_internal(puVar1,uVar4);
                if ((*pStatics_c960 != 0) &&
                   (lVar2 = *(int64 *)(*pStatics_c960 + 0x108)) != null) {
                  lVar2 = *(int64 *)(lVar2 + 64);
                  uVar11 = 0;
                  uVar4 = BuildingUIController.GenerateBuildingNPCString
                                    (this,"掌柜",0xfffffffd,0xffffffff,
                                     CONCAT44(uVar12,0xffffffff),0);
                  uVar5 = il2cpp_internal(DAT_181d7d2b0);
                  uVar10 = CONCAT44(uVar11,3);
                  SinglePlotData.ctor(uVar5,"啊呀呀，少侠想要在本店举办宴会？那可真是欢迎之至！\n举办宴会可以吸引周遭声望相近的武林人士前来参与，一道把酒言欢。\n宴会评分越高，客人的身份也会越尊贵，增进的好感自然也越多。",0,5,uVar4,uVar10,"0",0,0,0);
                  uVar12 = (uint32)((uint64)uVar10 >> 32);
                  if (lVar2 != null) {
                    FUN_181827900(lVar2,uVar5,DAT_181d79a58);
                    if ((*pStatics_c960 != 0) &&
                       (lVar2 = *(int64 *)(*pStatics_c960 + 0x108)) != null)
                    {
                      lVar2 = *(int64 *)(lVar2 + 64);
                      plVar6 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                      uVar4 = "不知，少侠此回想要筹备何种档次的宴会呢？\n(当前{0}为等级{1}，可提升宴会{2}点基础评分和{3}%的评分加成)";
                      lVar8 = "建筑";
                      if (**(int **)(DAT_181d4ef00 + 184) != 2) {
                        if (this.buildingData == null) throw; // [null/range check failed]
                        lVar8 = AreaBuildingData.Name(this.buildingData,0,0);
                      }
                      if (plVar6 != (int64 *)0) {
                        if ((lVar8 != null) &&
                           (lVar7 = il2cpp_internal(lVar8,*(uint64 *)(*plVar6 + 64)), lVar7 == null
                           )) {
                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar4,0);
                        }
                        if ((int)plVar6[3] == 0) {
                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar4,0);
                        }
                        plVar6[4] = lVar8;
                        il2cpp_internal(plVar6 + 4,lVar8);
                        if (this.buildingData != null) {
                          uVar11 = this.buildingData.lv;
                          lVar8 = GlobalData.GetNumText(uVar11,0);
                          if ((lVar8 != null) &&
                             (lVar7 = il2cpp_internal(lVar8,*(uint64 *)(*plVar6 + 64)),
                             lVar7 == null)) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          if (*(uint32 *)(plVar6 + 3) < 2) {
                            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar4,0);
                          }
                          plVar6[5] = lVar8;
                          il2cpp_internal(plVar6 + 5,lVar8);
                          if (this.buildingData != null) {
                            local_res18[0] =
                                 AreaBuildingData.GetExtraPartyScore(this.buildingData,0);
                            lVar8 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
                            if ((lVar8 != null) &&
                               (lVar7 = il2cpp_internal(lVar8,*(uint64 *)(*plVar6 + 64)),
                               lVar7 == null)) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            if (*(uint32 *)(plVar6 + 3) < 3) {
                              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar4,0);
                            }
                            plVar6[6] = lVar8;
                            il2cpp_internal(plVar6 + 6,lVar8);
                            if (this.buildingData != null) {
                              local_res20[0] =
                                   (float)AreaBuildingData.GetExtraPartyRate
                                                    (this.buildingData,0);
                              local_res20[0] = local_res20[0] * 100.0;
                              lVar8 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
                              if ((lVar8 != null) &&
                                 (lVar7 = il2cpp_internal(lVar8,*(uint64 *)(*plVar6 + 64)),
                                 lVar7 == null)) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              if (*(uint32 *)(plVar6 + 3) < 4) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar6[7] = lVar8;
                              il2cpp_internal(plVar6 + 7,lVar8);
                              uVar4 = String.Format(uVar4,plVar6,0);
                              uVar5 = il2cpp_internal(DAT_181d7d2b0);
                              SinglePlotData.ctor
                                        (uVar5,uVar4,lVar3,0,0,CONCAT44(uVar12,3),"0",0,0,0);
                              if (lVar2 != null) {
                                FUN_181827900(lVar2,uVar5,DAT_181d79a58);
                                lVar3 = *pStatics_c960;
                                if ((*pStatics_c960 != 0) && (lVar3 != null)) {
                                  PlotController.ChangePlot
                                            (lVar3,*(uint64 *)
                                                    (*pStatics_c960 + 0x108),0);
                                  return;
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
              }
            }
            throw; // [null/range check failed]
          }
          lVar3 = FUN_18046c440(0);
          uVar5 = il2cpp_internal(DAT_181d7d2b0);
          uVar4 = "这个月已经宴饮三日，若是天天饮酒作乐，只怕为江湖中人耻笑。";
        }
        SinglePlotData.ctor(uVar5,uVar4,0,1,0,CONCAT44(uVar12,3),"0",1,0,0);
        if (lVar3 != null) {
          PlotController.ChangePlot(lVar3,uVar5,0);
          return;
        }
    }

    // Token : 0x6000DE2
    // RVA   : 0xBCB090   Offset: 0xBC9890   Length: 0x8DC
    public void StartForceParty()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        long lVar7;
        long lVar8;
        ulong uVar9;
        int iVar10;
        uint[] local_res18 = new uint[2];
        float[] local_res20 = new float[2];
        if ((*pStatics_df90 != 0) &&
           (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          if (*(int *)(lVar4 + 0x11c) < 1) {
            lVar4 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar4,DAT_181d7c250);
            iVar10 = 0;
            while( true ) {
              lVar3 = *(int64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 24);
              if (lVar3 == null) break;
              if (*(int *)(lVar3 + 24) <= iVar10) {
                if (lVar4 != null) {
                  FUN_181827900(lVar4,"还是算了;HideInteractUI",DAT_181d7c3d0);
                  lVar3 = *pStatics_c960;
                  uVar5 = new PlotData(0);
                  if (lVar3 != null) {
                    puVar1 = (uint64 *)(lVar3 + 0x108);
                    *puVar1 = uVar5;
                    il2cpp_internal(puVar1,uVar5);
                    if ((*pStatics_c960 != 0) &&
                       (lVar3 = *(int64 *)(*pStatics_c960 + 0x108)) != null)
                    {
                      lVar3 = *(int64 *)(lVar3 + 64);
                      uVar5 = new SinglePlotData("在此举办宴会，可召唤本门弟子前来参与，增进好感与忠诚。\n宴会评分越高，增加好感与忠诚自然也越多。",0,1,0,3,"0",1,0,0);
                      if (lVar3 != null) {
                        FUN_181827900(lVar3,uVar5,DAT_181d79a58);
                        if ((*pStatics_c960 != 0) &&
                           (lVar3 = *(int64 *)(*pStatics_c960 + 0x108),
                           lVar3 != null)) {
                          lVar3 = *(int64 *)(lVar3 + 64);
                          plVar6 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                          if ((this.buildingData != null) &&
                             (lVar7 = AreaBuildingData.Name(this.buildingData,0,0),
                             plVar6 != (int64 *)0)) {
                            if ((lVar7 != null) &&
                               (lVar8 = il2cpp_internal(lVar7,*(uint64 *)(*plVar6 + 64)),
                               lVar8 == null)) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            if ((int)plVar6[3] == 0) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            plVar6[4] = lVar7;
                            il2cpp_internal(plVar6 + 4,lVar7);
                            if (this.buildingData != null) {
                              uVar2 = this.buildingData.lv;
                              lVar7 = GlobalData.GetNumText(uVar2,0);
                              if ((lVar7 != null) &&
                                 (lVar8 = il2cpp_internal(lVar7,*(uint64 *)(*plVar6 + 64)),
                                 lVar8 == null)) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(plVar6 + 3) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              plVar6[5] = lVar7;
                              il2cpp_internal(plVar6 + 5,lVar7);
                              if (this.buildingData != null) {
                                local_res18[0] =
                                     AreaBuildingData.GetExtraPartyScore(this.buildingData,0)
                                ;
                                lVar7 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
                                if ((lVar7 != null) &&
                                   (lVar8 = il2cpp_internal(lVar7,*(uint64 *)(*plVar6 + 64)),
                                   lVar8 == null)) {
                                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar5,0);
                                }
                                if (*(uint32 *)(plVar6 + 3) < 3) {
                                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar5,0);
                                }
                                plVar6[6] = lVar7;
                                il2cpp_internal(plVar6 + 6,lVar7);
                                if (this.buildingData != null) {
                                  local_res20[0] =
                                       (float)AreaBuildingData.GetExtraPartyRate
                                                        (this.buildingData,0);
                                  local_res20[0] = local_res20[0] * 100.0;
                                  lVar7 = il2cpp_value_box(DAT_181d7d0b8,local_res20);
                                  if ((lVar7 != null) &&
                                     (lVar8 = il2cpp_internal(lVar7,*(uint64 *)(*plVar6 + 64)),
                                     lVar8 == null)) {
                                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar5,0);
                                  }
                                  if (*(uint32 *)(plVar6 + 3) < 4) {
                                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar5,0);
                                  }
                                  plVar6[7] = lVar7;
                                  il2cpp_internal(plVar6 + 7,lVar7);
                                  uVar5 = String.Format("此回应当筹备何种档次的宴会呢？\n(当前{0}为等级{1}，可提升宴会{2}点基础评分和{3}%的评分加成)",plVar6,0);
                                  uVar9 = new SinglePlotData(uVar5,lVar4,1,0,3,"0",1,0,0);
                                  if (lVar3 != null) {
                                    FUN_181827900(lVar3,uVar9,DAT_181d79a58);
                                    lVar4 = *pStatics_c960;
                                    if ((*pStatics_c960 != 0) && (lVar4 != null)) {
                                      PlotController.ChangePlot
                                                (lVar4,*(uint64 *)
                                                        (*pStatics_c960 + 0x108),0)
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
                  }
                }
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar5 = BuildingUIController.GetPartyChoiceString(this,1,iVar10);
              if (lVar4 == null) break;
              FUN_181827900(lVar4,uVar5,DAT_181d7c3d0);
              iVar10 = iVar10 + 1;
            }
          }
          else {
            lVar4 = *pStatics_c960;
            uVar5 = new SinglePlotData("这个月已经举办过门派宴会，还需等待场地打扫整备妥当才是。",0,1,0,3,"0",1,0,0);
            if (lVar4 != null) {
              PlotController.ChangePlot(lVar4,uVar5,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000DE3
    // RVA   : 0xBCBC50   Offset: 0xBCA450   Length: 0x651
    public void StartHireBodyGuard()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        float[] local_res18 = new float[4];
        ulong in_stack_ffffffffffffffa8;
        uint uVar8;
        uint uVar9;
        uVar8 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        if ((((*pStatics != 0) &&
             (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
            (lVar3 = WorldData.Player(lVar3,0)) != null) && (*(int64 *)(lVar3 + 0x2f8) != 0)) {
          iVar2 = *(int *)(*(int64 *)(lVar3 + 0x2f8) + 24);
          if (((*pStatics == 0) ||
              (lVar3 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
          iVar1 = HeroData.GetMaxStudent(lVar3,0);
          if (iVar2 < iVar1) {
            if (((*pStatics == 0) ||
                (lVar3 = *(int64 *)(*pStatics + 32)) == null) ||
               (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
            iVar2 = HeroData.GetBodyGuardNum(lVar3,0);
            if (iVar2 < 1) {
              iVar2 = 0;
              if (this.buildingData != null) {
                iVar2 = this.buildingData.lv;
              }
              lVar3 = FUN_18046c440(0);
              lVar4 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar4,DAT_181d7c250);
              if (lVar4 == null) throw; // [null/range check failed]
              FUN_181827900(lVar4,"物色普通人手;StartRecruitHero;1-Hire-0",DAT_181d7c3d0);
              local_res18[0] = (float)(iVar2 + 1) * 50.0;
              uVar5 = Single.ToString(local_res18,0);
              uVar5 = String.Concat("物色优良人手;StartRecruitHero;1-Hire-1;0/",uVar5,0);
              FUN_181827900(lVar4,uVar5,DAT_181d7c3d0);
              local_res18[0] = (float)(iVar2 + 1) * 100.0;
              uVar5 = Single.ToString(local_res18,0);
              uVar5 = String.Concat("物色顶尖人手;StartRecruitHero;1-Hire-2;0/",uVar5,0);
              FUN_181827900(lVar4,uVar5,DAT_181d7c3d0);
              FUN_181827900(lVar4,"取消;HideInteractUI",DAT_181d7c3d0);
              uVar9 = 0;
              uVar5 = BuildingUIController.GenerateBuildingNPCString
                                (this,"掌柜",0xfffffffd,0xffffffff,CONCAT44(uVar8,0xffffffff),0)
              ;
              uVar6 = il2cpp_internal(DAT_181d7d2b0);
              SinglePlotData.ctor
                        (uVar6,"别看咱们这不起眼，却也是人才济济，卧虎藏龙。\n少侠行走江湖若遇到什么不便之处，掌柜的可以为您介绍一名江湖人士作为保镖。\n不仅价钱实惠，而且定能竭智尽忠，替您分忧解难！",lVar4,5,uVar5,CONCAT44(uVar9,3),"0",0,0,0);
              if (lVar3 == null) throw; // [null/range check failed]
              goto LAB_180bcc187;
            }
            lVar3 = FUN_18046c440(0);
            uVar9 = 0;
            uVar7 = BuildingUIController.GenerateBuildingNPCString
                              (this,"掌柜",0xfffffffd,0xffffffff,CONCAT44(uVar8,0xffffffff),0);
            uVar6 = il2cpp_internal(DAT_181d7d2b0);
            uVar5 = "少侠已雇佣过保镖护卫了，可惜可惜。";
          }
          else {
            uVar9 = 0;
            lVar3 = **(int64 **)(DAT_181d6c960 + 184);
            uVar7 = BuildingUIController.GenerateBuildingNPCString
                              (this,"掌柜",0xfffffffd,0xffffffff,CONCAT44(uVar8,0xffffffff),0);
            uVar6 = il2cpp_internal(DAT_181d7d2b0);
            uVar5 = "少侠的队伍已经满员，还是改日再说吧。";
          }
          SinglePlotData.ctor(uVar6,uVar5,0,5,uVar7,CONCAT44(uVar9,3),"0",0,0,0);
          if (lVar3 != null) {
        LAB_180bcc187:
            PlotController.ChangePlot(lVar3,uVar6,0);
            return;
          }
        }
    }

    // Token : 0x6000DE4
    // RVA   : 0xBCC2B0   Offset: 0xBCAAB0   Length: 0x75D
    public void StartHireFollower()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        int iVar7;
        float fVar8;
        float[] local_res18 = new float[4];
        ulong in_stack_ffffffffffffffa8;
        uint uVar9;
        uint uVar10;
        uVar9 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        if (((*pStatics == 0) ||
            (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar2 + 132) < 0) {
        LAB_180bcc920:
          uVar10 = 0;
          lVar2 = **(int64 **)(DAT_181d6c960 + 184);
          uVar6 = BuildingUIController.GenerateBuildingNPCString
                            (this,"杂役",0xfffffffc,0xffffffff,CONCAT44(uVar9,0xffffffff),0);
          uVar5 = il2cpp_internal(DAT_181d7d2b0);
          uVar4 = "抱歉少侠，只有掌门本人或是奉掌门之命者才能在此进行弟子招募。";
        }
        else {
          if (((*pStatics == 0) ||
              (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          if (*(char *)(lVar2 + 180) == false) {
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar2 + 0x2e0) != 0) {
              lVar2 = FUN_18046c0a0(0);
              if ((((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                  (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null) ||
                 ((*(int64 *)(lVar2 + 0x2e0) == 0 ||
                  (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 0x2e0) + 120)) == null)))
              throw; // [null/range check failed]
              if (*(int *)(lVar2 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
              if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 56)) == null) throw; // [null/range check failed]
              if (*(int *)(lVar2 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(int *)(lVar2 + 16) == 6) goto LAB_180bcc61e;
            }
            goto LAB_180bcc920;
          }
        LAB_180bcc61e:
          lVar2 = FUN_18046c0a0(0);
          if ((((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
              (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null) ||
             (lVar2 = HeroData.GetForce(lVar2,0,0)) == null) throw; // [null/range check failed]
          cVar1 = ForceData.PopulationNotFull(lVar2,0);
          if (cVar1) {
            iVar7 = 0;
            if (this.buildingData != null) {
              iVar7 = this.buildingData.lv;
            }
            fVar8 = (float)iVar7 * 0.5 + 1.0;
            lVar2 = FUN_18046c440(0);
            lVar3 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar3,DAT_181d7c250);
            if (lVar3 != null) {
              FUN_181827900(lVar3,"物色普通人选;StartRecruitHero;5-Normal-0",DAT_181d7c3d0);
              local_res18[0] = fVar8 * 500.0;
              uVar4 = Single.ToString(local_res18,0);
              uVar4 = String.Concat("物色优良人选;StartRecruitHero;5-Normal-1;0/",uVar4,0);
              FUN_181827900(lVar3,uVar4,DAT_181d7c3d0);
              local_res18[0] = fVar8 * 1000.0;
              uVar4 = Single.ToString(local_res18,0);
              uVar4 = String.Concat("物色顶尖人选;StartRecruitHero;5-Normal-2;0/",uVar4,0);
              FUN_181827900(lVar3,uVar4,DAT_181d7c3d0);
              FUN_181827900(lVar3,"取消;HideInteractUI",DAT_181d7c3d0);
              uVar10 = 0;
              uVar4 = BuildingUIController.GenerateBuildingNPCString
                                (this,"杂役",0xfffffffc,0xffffffff,CONCAT44(uVar9,0xffffffff),0)
              ;
              uVar5 = il2cpp_internal(DAT_181d7d2b0);
              SinglePlotData.ctor
                        (uVar5,"这分舵中人来人往，不乏一些意欲拜入本门的武林人士。\n若是少侠有心，可在此物色一名新弟子人选，估摸着花上五天时间就够了。",lVar3,5,uVar4,CONCAT44(uVar10,3),"0",0,0,0);
              if (lVar2 == null) throw; // [null/range check failed]
              goto LAB_180bcc8f0;
            }
            throw; // [null/range check failed]
          }
          lVar2 = FUN_18046c440(0);
          uVar10 = 0;
          uVar6 = BuildingUIController.GenerateBuildingNPCString
                            (this,"杂役",0xfffffffc,0xffffffff,CONCAT44(uVar9,0xffffffff),0);
          uVar5 = il2cpp_internal(DAT_181d7d2b0);
          uVar4 = "抱歉少侠，本门的弟子容量已满，无法进行招募。";
        }
        SinglePlotData.ctor(uVar5,uVar4,0,5,uVar6,CONCAT44(uVar10,3),"0",0,0,0);
        if (lVar2 != null) {
        LAB_180bcc8f0:
          PlotController.ChangePlot(lVar2,uVar5,0);
          return;
        }
    }

    // Token : 0x6000DE5
    // RVA   : 0xBC77B0   Offset: 0xBC5FB0   Length: 0x6EC
    public void SpeHireFollower()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        int iVar7;
        float[] local_res18 = new float[4];
        ulong in_stack_ffffffffffffffa8;
        uint uVar8;
        uint uVar9;
        uVar8 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        if (((*pStatics == 0) ||
            (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar2 + 132) < 0) {
        LAB_180bc7daf:
          uVar9 = 0;
          lVar2 = **(int64 **)(DAT_181d6c960 + 184);
          uVar6 = BuildingUIController.GenerateBuildingNPCString
                            (this,"名士",0xfffffffa,0xffffffff,CONCAT44(uVar8,0xffffffff),0);
          uVar5 = il2cpp_internal(DAT_181d7d2b0);
          uVar4 = "抱歉少侠，只有掌门本人或是奉掌门之命者才能在此进行弟子招募。";
        }
        else {
          if (((*pStatics == 0) ||
              (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          if (*(char *)(lVar2 + 180) == false) {
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar2 + 0x2e0) != 0) {
              lVar2 = FUN_18046c0a0(0);
              if ((((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
                  (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null) ||
                 ((*(int64 *)(lVar2 + 0x2e0) == 0 ||
                  (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 0x2e0) + 120)) == null)))
              throw; // [null/range check failed]
              if (*(int *)(lVar2 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
              if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 56)) == null) throw; // [null/range check failed]
              if (*(int *)(lVar2 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(int *)(lVar2 + 16) == 6) goto LAB_180bc7b01;
            }
            goto LAB_180bc7daf;
          }
        LAB_180bc7b01:
          lVar2 = FUN_18046c0a0(0);
          if ((((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
              (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null) ||
             (lVar2 = HeroData.GetForce(lVar2,0,0)) == null) throw; // [null/range check failed]
          cVar1 = ForceData.PopulationNotFull(lVar2,0);
          if (cVar1) {
            iVar7 = 0;
            if (this.buildingData != null) {
              iVar7 = this.buildingData.lv;
            }
            lVar2 = FUN_18046c440(0);
            lVar3 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar3,DAT_181d7c250);
            local_res18[0] = ((float)iVar7 * 0.5 + 1.0) * 2000.0;
            uVar4 = Single.ToString(local_res18,0);
            uVar4 = String.Concat("选贤举能;StartRecruitHero;5-Normal-3;0/",uVar4,0);
            if (lVar3 != null) {
              FUN_181827900(lVar3,uVar4,DAT_181d7c3d0);
              FUN_181827900(lVar3,"取消;HideInteractUI",DAT_181d7c3d0);
              uVar9 = 0;
              uVar4 = BuildingUIController.GenerateBuildingNPCString
                                (this,"名士",0xfffffffa,0xffffffff,CONCAT44(uVar8,0xffffffff),0)
              ;
              uVar5 = il2cpp_internal(DAT_181d7d2b0);
              SinglePlotData.ctor
                        (uVar5,"这黄鹤楼乃是江南胜景，来往之人不乏小有名气的意气游侠，青年才俊，\n少侠若是愿意花上五日时间在此处寻访，必能拔擢一批可造之材。",lVar3,5,uVar4,CONCAT44(uVar9,3),"0",0,0,0);
              if (lVar2 == null) throw; // [null/range check failed]
              goto LAB_180bc7d86;
            }
            throw; // [null/range check failed]
          }
          lVar2 = FUN_18046c440(0);
          uVar9 = 0;
          uVar6 = BuildingUIController.GenerateBuildingNPCString
                            (this,"名士",0xfffffffa,0xffffffff,CONCAT44(uVar8,0xffffffff),0);
          uVar5 = il2cpp_internal(DAT_181d7d2b0);
          uVar4 = "抱歉少侠，本门的弟子容量已满，无法进行招募。";
        }
        SinglePlotData.ctor(uVar5,uVar4,0,5,uVar6,CONCAT44(uVar9,3),"0",0,0,0);
        if (lVar2 != null) {
        LAB_180bc7d86:
          PlotController.ChangePlot(lVar2,uVar5,0);
          return;
        }
    }

    // Token : 0x6000DE6
    // RVA   : 0xBB7710   Offset: 0xBB5F10   Length: 0x308
    public float BuildingStudySkillCostRate(AreaBuildingData targetBuilding)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        float fVar3;
        if ((targetBuilding == null) || (lVar2 = AreaBuildingData.GetArea(targetBuilding,0)) == null)
        throw; // [null/range check failed]
        if (*(int *)(lVar2 + 112) < 0) {
          return 1.0;
        }
        lVar2 = AreaBuildingData.GetArea(targetBuilding,0);
        if (lVar2 == null) throw; // [null/range check failed]
        iVar1 = *(int *)(lVar2 + 112);
        if (((*pStatics == 0) ||
            (lVar2 = *(int64 *)(*pStatics + 32)) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        if (iVar1 != *(int *)(lVar2 + 132)) {
          lVar2 = AreaBuildingData.GetArea(targetBuilding,0);
          if ((lVar2 == null) || (lVar2 = AreaData.GetForce(lVar2,0)) == null) throw; // [null/range check failed]
          if (-1 < *(int *)(lVar2 + 60)) {
            lVar2 = AreaBuildingData.GetArea(targetBuilding,0);
            if ((lVar2 == null) || (lVar2 = AreaData.GetForce(lVar2,0)) == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar2 + 60);
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
               (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null) throw; // [null/range check failed]
            if (iVar1 == *(int *)(lVar2 + 132)) goto LAB_180bb7933;
          }
          lVar2 = AreaBuildingData.GetArea(targetBuilding,0);
          if (lVar2 == null) throw; // [null/range check failed]
          iVar1 = *(int *)(lVar2 + 112);
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) ||
             (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) == null) throw; // [null/range check failed]
          if (iVar1 != *(int *)(lVar2 + 0x380)) {
            return 1.0;
          }
        }
        LAB_180bb7933:
        if (((*pStatics != 0) &&
            (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar2 = WorldData.Player(lVar2,0)) != null) {
          fVar3 = (float)Mathf.Max(0x3d4ccccd,(float)*(int *)(lVar2 + 184) * 0.1,0);
          return 1.0 - fVar3;
        }
    }

    // Token : 0x6000DE7
    // RVA   : 0xBCF170   Offset: 0xBCD970   Length: 0xC6F
    public void StudyLivingSkill(string param)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        long lVar11;
        int iVar12;
        float fVar13;
        float fVar14;
        uint[] local_res10 = new uint[4];
        int[] local_res20 = new int[2];
        uint local_68;
        uint local_64;
        uint local_60;
        int local_5c;
        uint32 local_58;
        uint32 local_54 [7];
        uVar1 = Int32.Parse(param,0);
        lVar11 = (int64)(int)uVar1;
        if ((((*pStatics_df90 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
            (lVar3 = WorldData.Player(lVar3,0)) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 0x158)) == null) throw; // [null/range check failed]
        if (*(uint32 *)(lVar3 + 24) <= uVar1) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        fVar14 = *(float *)(*(int64 *)(lVar3 + 16) + 32 + lVar11 * 4);
        if ((float)*(int *)(pStatics_ef00 + 0x108) <= fVar14) {
          lVar3 = **(int64 **)(DAT_181d6c960 + 184);
          lVar5 = *(int64 *)(pStatics_ef00 + 0x4a8);
          if (lVar5 == null) throw; // [null/range check failed]
          uVar7 = "少侠的{0}已然登峰造极，无需再进行修炼了吧。";
          if (*(uint32 *)(lVar5 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            uVar7 = "少侠的{0}已然登峰造极，无需再进行修炼了吧。";
          }
        }
        else {
          if ((((*pStatics_df90 == 0) ||
               (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
              (lVar3 = WorldData.Player(lVar3,0)) == null) ||
             (lVar3 = *(int64 *)(lVar3 + 0x158)) == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar3 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar14 = *(float *)(*(int64 *)(lVar3 + 16) + 32 + lVar11 * 4);
          if (((*pStatics_df90 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
          fVar13 = (float)HeroData.GetMaxLivingSkill(lVar3,uVar1,0);
          if (fVar14 < fVar13) {
            fVar14 = (float)BuildingUIController.BuildingStudySkillCostRate
                                      (this,this.buildingData,0);
            lVar3 = FUN_18046c0a0(0);
            if ((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) &&
               (lVar3 = *(int64 *)(lVar3 + 0x158)) != null) {
              if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              iVar12 = 1 - (int)(*(float *)(*(int64 *)(lVar3 + 16) + 32 + lVar11 * 4) * -0.05);
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                 ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 != null &&
                  (lVar3 = *(int64 *)(lVar3 + 0x158)) != null))) {
                if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar2 = Mathf.RoundToInt((float)(1 - (int)(*(float *)(*(int64 *)(lVar3 + 16) + 32
                                                                      + lVar11 * 4) * -0.1)) *
                                          fVar14 * 250.0,0);
                local_58 = uVar2;
                lVar3 = FUN_18046c440(0);
                plVar4 = (int64 *)FUN_1800d60b0(DAT_181d7f180,7);
                if ((this.buildingData != null) &&
                   (lVar5 = AreaBuildingData.Name(this.buildingData,0,0),
                   plVar4 != (int64 *)0)) {
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
                  if (((this.buildingData != null) &&
                      (lVar5 = AreaBuildingData.GetArea(this.buildingData,0)) != null) &&
                     (lVar5 = AreaData.GetForce(lVar5,0)) != null) {
                    lVar5 = *(int64 *)(lVar5 + 24);
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
                    lVar5 = *(int64 *)(pStatics_ef00 + 0x4a8);
                    if (lVar5 != null) {
                      if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = *(int64 *)(*(int64 *)(lVar5 + 16) + 32 + lVar11 * 8);
                      if ((lVar5 != null) &&
                         (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null)
                      {
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
                      lVar5 = FUN_18046c0a0(0);
                      if ((((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) &&
                          (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) != null) &&
                         (lVar5 = *(int64 *)(lVar5 + 0x158)) != null) {
                        if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        local_res10[0] = *(uint32 *)(*(int64 *)(lVar5 + 16) + 32 + lVar11 * 4);
                        lVar11 = il2cpp_value_box(DAT_181d7d0b8,local_res10);
                        if ((lVar11 != null) &&
                           (lVar5 = il2cpp_internal(lVar11,*(uint64 *)(*plVar4 + 64)),
                           lVar5 == null)) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        if (*(uint32 *)(plVar4 + 3) < 4) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        plVar4[7] = lVar11;
                        il2cpp_internal(plVar4 + 7,lVar11);
                        local_res20[0] = iVar12;
                        lVar11 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                        if ((lVar11 != null) &&
                           (lVar5 = il2cpp_internal(lVar11,*(uint64 *)(*plVar4 + 64)),
                           lVar5 == null)) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        if (*(uint32 *)(plVar4 + 3) < 5) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        plVar4[8] = lVar11;
                        il2cpp_internal(plVar4 + 8,lVar11);
                        local_68 = uVar2;
                        lVar11 = il2cpp_value_box(DAT_181d5b2f8,&local_68);
                        if ((lVar11 != null) &&
                           (lVar5 = il2cpp_internal(lVar11,*(uint64 *)(*plVar4 + 64)),
                           lVar5 == null)) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        if (*(uint32 *)(plVar4 + 3) < 6) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        plVar4[9] = lVar11;
                        il2cpp_internal(plVar4 + 9,lVar11);
                        uVar7 = "这{0}乃{1}修习{2}之无上宝地，只需支付维护修缮费用便可在此修炼。\n少侠当前的{2}为{3}，修炼需要{4}日和{5}银两。{6}";
                        lVar11 = "";
                        if (fVar14 != 1.0) {
                          local_64 = Mathf.RoundToInt((1.0 - fVar14) * 100.0,0);
                          uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_64);
                          lVar11 = String.Format("\n(建筑属于本门派，门派地位可使银两消耗-{0}%)",uVar8,0);
                        }
                        if ((lVar11 != null) &&
                           (lVar5 = il2cpp_internal(lVar11,*(uint64 *)(*plVar4 + 64)),
                           lVar5 == null)) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        if (*(uint32 *)(plVar4 + 3) < 7) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        plVar4[10] = lVar11;
                        il2cpp_internal(plVar4 + 10,lVar11);
                        uVar7 = String.Format(uVar7,plVar4,0);
                        lVar11 = il2cpp_internal(DAT_181d72a30);
                        FUN_180f58a90(lVar11,DAT_181d7c250);
                        local_60 = uVar1;
                        uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_60);
                        local_5c = iVar12;
                        uVar9 = il2cpp_value_box(DAT_181d5b2f8,&local_5c);
                        local_54[0] = local_58;
                        uVar10 = il2cpp_value_box(DAT_181d5b2f8,local_54);
                        uVar8 = String.Format("开始修炼;StudyLivingSkillStart;{0}-{1};0/{2}",uVar8,uVar9,uVar10,0);
                        if (lVar11 != null) {
                          FUN_181827900(lVar11,uVar8,DAT_181d7c3d0);
                          FUN_181827900(lVar11,"还是算了;HideInteractUI",DAT_181d7c3d0);
                          uVar8 = BuildingUIController.GenerateForceNPCString(this,"弟子",0);
                          uVar9 = new SinglePlotData(uVar7,lVar11,5,uVar8,3,"0",0,0,0);
                          if (lVar3 != null) {
                            PlotController.ChangePlot(lVar3,uVar9,0);
                            return;
                          }
                        }
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                    }
                  }
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = FUN_18046c440(0);
          lVar5 = *(int64 *)(pStatics_ef00 + 0x4a8);
          if (lVar5 == null) throw; // [null/range check failed]
          uVar7 = "少侠的{0}已抵达潜力之上限，无法再继续修炼了。";
          if (*(uint32 *)(lVar5 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            uVar7 = "少侠的{0}已抵达潜力之上限，无法再继续修炼了。";
          }
        }
        uVar7 = String.Format(uVar7,*(uint64 *)(*(int64 *)(lVar5 + 16) + 32 + lVar11 * 8),0);
        uVar8 = BuildingUIController.GenerateForceNPCString(this,"弟子",0);
        uVar9 = new SinglePlotData(uVar7,0,5,uVar8,3,"0",0,0,0);
        if (lVar3 != null) {
          PlotController.ChangePlot(lVar3,uVar9,0);
          return;
        }
    }

    // Token : 0x6000DE8
    // RVA   : 0xBD0A00   Offset: 0xBCF200   Length: 0xB58
    public void StudyMaxLivingSkill(string param)
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        int iVar11;
        float fVar12;
        float fVar13;
        uint[] local_res10 = new uint[4];
        int[] local_res20 = new int[2];
        uint local_68;
        uint local_64;
        uint local_60;
        int local_5c;
        uint32 local_58;
        uint32 local_54 [7];
        uVar1 = Int32.Parse(param,0);
        if (((*pStatics_df90 != 0) &&
            (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar3 = WorldData.Player(lVar3,0)) != null) {
          fVar12 = (float)HeroData.GetMaxLivingSkill(lVar3,uVar1,0);
          if (fVar12 < (float)*(int *)(pStatics_ef00 + 0x108)) {
            fVar12 = (float)BuildingUIController.BuildingStudySkillCostRate
                                      (this,this.buildingData,0);
            if (((*pStatics_df90 != 0) &&
                (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
               (lVar3 = WorldData.Player(lVar3,0)) != null) {
              fVar13 = (float)HeroData.GetMaxLivingSkill(lVar3,uVar1,0);
              iVar11 = 1 - (int)(fVar13 * -0.05);
              if (((*pStatics_df90 != 0) &&
                  (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                 (lVar3 = WorldData.Player(lVar3,0)) != null) {
                fVar13 = (float)HeroData.GetMaxLivingSkill(lVar3,uVar1,0);
                uVar2 = Mathf.RoundToInt((float)(1 - (int)(fVar13 * -0.1)) * fVar12 * 500.0,0);
                local_58 = uVar2;
                lVar3 = *pStatics_c960;
                plVar4 = (int64 *)FUN_1800d60b0(DAT_181d7f180,7);
                if ((this.buildingData != null) &&
                   (lVar5 = AreaBuildingData.Name(this.buildingData,0,0),
                   plVar4 != (int64 *)0)) {
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
                  if (((this.buildingData != null) &&
                      (lVar5 = AreaBuildingData.GetArea(this.buildingData,0)) != null) &&
                     (lVar5 = AreaData.GetForce(lVar5,0)) != null) {
                    lVar5 = *(int64 *)(lVar5 + 24);
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
                    lVar5 = *(int64 *)(pStatics_ef00 + 0x4a8);
                    if (lVar5 != null) {
                      if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = lVar5[uVar1]
                      ;
                      if ((lVar5 != null) &&
                         (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null)
                      {
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
                      if (((*pStatics_df90 != 0) &&
                          (lVar5 = *(int64 *)(*pStatics_df90 + 32), lVar5 != null
                          )) && (lVar5 = WorldData.Player(lVar5,0)) != null) {
                        local_res10[0] = HeroData.GetMaxLivingSkill(lVar5,uVar1,0);
                        lVar5 = il2cpp_value_box(DAT_181d7d0b8,local_res10);
                        if ((lVar5 != null) &&
                           (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64)), lVar6 == null
                           )) {
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
                        local_res20[0] = iVar11;
                        lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                        if ((lVar5 != null) &&
                           (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64)), lVar6 == null
                           )) {
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
                        local_68 = uVar2;
                        lVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_68);
                        if ((lVar5 != null) &&
                           (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64)), lVar6 == null
                           )) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        if (*(uint32 *)(plVar4 + 3) < 6) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        plVar4[9] = lVar5;
                        il2cpp_internal(plVar4 + 9,lVar5);
                        uVar7 = "这{0}乃{1}提升{2}潜力之无上宝地，只需支付维护修缮费用便可在此修炼。\n少侠当前的{2}潜力为{3}，修炼需要{4}日和{5}银两。{6}";
                        lVar5 = "";
                        if (fVar12 != 1.0) {
                          local_64 = Mathf.RoundToInt((1.0 - fVar12) * 100.0,0);
                          uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_64);
                          lVar5 = String.Format("\n(建筑属于本门派，门派地位可使银两消耗-{0}%)",uVar8,0);
                        }
                        if ((lVar5 != null) &&
                           (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64)), lVar6 == null
                           )) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        if (*(uint32 *)(plVar4 + 3) < 7) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        plVar4[10] = lVar5;
                        il2cpp_internal(plVar4 + 10,lVar5);
                        uVar7 = String.Format(uVar7,plVar4,0);
                        lVar5 = il2cpp_internal(DAT_181d72a30);
                        FUN_180f58a90(lVar5,DAT_181d7c250);
                        local_60 = uVar1;
                        uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_60);
                        local_5c = iVar11;
                        uVar9 = il2cpp_value_box(DAT_181d5b2f8,&local_5c);
                        local_54[0] = local_58;
                        uVar10 = il2cpp_value_box(DAT_181d5b2f8,local_54);
                        uVar8 = String.Format("开始修炼;StudyMaxLivingSkillStart;{0}-{1};0/{2}",uVar8,uVar9,uVar10,0);
                        if (lVar5 != null) {
                          FUN_181827900(lVar5,uVar8,DAT_181d7c3d0);
                          FUN_181827900(lVar5,"还是算了;HideInteractUI",DAT_181d7c3d0);
                          uVar8 = BuildingUIController.GenerateForceNPCString(this,"弟子",0);
                          uVar9 = new SinglePlotData(uVar7,lVar5,5,uVar8,3,"0",0,0,0);
                          if (lVar3 != null) {
                            PlotController.ChangePlot(lVar3,uVar9,0);
                            return;
                          }
                        }
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                    }
                  }
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = *pStatics_c960;
          lVar5 = *(int64 *)(pStatics_ef00 + 0x4a8);
          if (lVar5 != null) {
            if (*(uint32 *)(lVar5 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = String.Format("少侠的{0}潜力已然登峰造极，无需再进行修炼了吧。",
                                   *(uint64 *)
                                    (*(int64 *)(lVar5 + 16) + 32 + (int64)(int)uVar1 * 8),0);
            uVar8 = BuildingUIController.GenerateForceNPCString(this,"弟子",0);
            uVar9 = new SinglePlotData(uVar7,0,5,uVar8,3,"0",0,0,0);
            if (lVar3 != null) {
              PlotController.ChangePlot(lVar3,uVar9,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000DE9
    // RVA   : 0xBCFE90   Offset: 0xBCE690   Length: 0xB68
    public void StudyMaxFightSkill(string param)
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        int iVar11;
        float fVar12;
        float fVar13;
        uint[] local_res10 = new uint[4];
        int[] local_res20 = new int[2];
        uint local_78;
        uint local_74;
        uint local_70;
        int local_6c;
        uint32 local_68;
        uint32 local_64 [11];
        uVar1 = Int32.Parse(param,0);
        if (((*pStatics_df90 != 0) &&
            (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar3 = WorldData.Player(lVar3,0)) != null) {
          fVar12 = (float)HeroData.GetMaxFightSkill(lVar3,uVar1,0);
          if (fVar12 < (float)*(int *)(pStatics_ef00 + 0x104)) {
            fVar12 = (float)BuildingUIController.BuildingStudySkillCostRate
                                      (this,this.buildingData,0);
            if (((*pStatics_df90 != 0) &&
                (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
               (lVar3 = WorldData.Player(lVar3,0)) != null) {
              fVar13 = (float)HeroData.GetMaxFightSkill(lVar3,uVar1,0);
              iVar11 = 1 - (int)(fVar13 * -0.1);
              if (((*pStatics_df90 != 0) &&
                  (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                 (lVar3 = WorldData.Player(lVar3,0)) != null) {
                fVar13 = (float)HeroData.GetMaxFightSkill(lVar3,uVar1,0);
                uVar2 = Mathf.RoundToInt((float)(1 - (int)(fVar13 * -0.1)) * fVar12 * 1000.0,0);
                local_68 = uVar2;
                lVar3 = *pStatics_c960;
                plVar4 = (int64 *)FUN_1800d60b0(DAT_181d7f180,7);
                if ((this.buildingData != null) &&
                   (lVar5 = AreaBuildingData.Name(this.buildingData,0,0),
                   plVar4 != (int64 *)0)) {
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
                  if (((this.buildingData != null) &&
                      (lVar5 = AreaBuildingData.GetArea(this.buildingData,0)) != null) &&
                     (lVar5 = AreaData.GetForce(lVar5,0)) != null) {
                    lVar5 = *(int64 *)(lVar5 + 24);
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
                    lVar5 = *(int64 *)(pStatics_ef00 + 0x498);
                    if (lVar5 != null) {
                      if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = lVar5[uVar1]
                      ;
                      if ((lVar5 != null) &&
                         (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64))) == null)
                      {
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
                      if (((*pStatics_df90 != 0) &&
                          (lVar5 = *(int64 *)(*pStatics_df90 + 32), lVar5 != null
                          )) && (lVar5 = WorldData.Player(lVar5,0)) != null) {
                        local_res10[0] = HeroData.GetMaxFightSkill(lVar5,uVar1,0);
                        lVar5 = il2cpp_value_box(DAT_181d7d0b8,local_res10);
                        if ((lVar5 != null) &&
                           (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64)), lVar6 == null
                           )) {
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
                        local_res20[0] = iVar11;
                        lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                        if ((lVar5 != null) &&
                           (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64)), lVar6 == null
                           )) {
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
                        local_78 = uVar2;
                        lVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_78);
                        if ((lVar5 != null) &&
                           (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64)), lVar6 == null
                           )) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        if (*(uint32 *)(plVar4 + 3) < 6) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        plVar4[9] = lVar5;
                        il2cpp_internal(plVar4 + 9,lVar5);
                        uVar7 = "这{0}乃{1}提升{2}潜力之无上宝地，只需支付维护修缮费用便可在此修炼。\n少侠当前的{2}潜力为{3}，修炼需要{4}日和{5}银两。{6}";
                        lVar5 = "";
                        if (fVar12 != 1.0) {
                          local_74 = Mathf.RoundToInt((1.0 - fVar12) * 100.0,0);
                          uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_74);
                          lVar5 = String.Format("\n(建筑属于本门派，门派地位可使银两消耗-{0}%)",uVar8,0);
                        }
                        if ((lVar5 != null) &&
                           (lVar6 = il2cpp_internal(lVar5,*(uint64 *)(*plVar4 + 64)), lVar6 == null
                           )) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        if (*(uint32 *)(plVar4 + 3) < 7) {
                          uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar7,0);
                        }
                        plVar4[10] = lVar5;
                        il2cpp_internal(plVar4 + 10,lVar5);
                        uVar7 = String.Format(uVar7,plVar4,0);
                        lVar5 = il2cpp_internal(DAT_181d72a30);
                        FUN_180f58a90(lVar5,DAT_181d7c250);
                        local_70 = uVar1;
                        uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_70);
                        local_6c = iVar11;
                        uVar9 = il2cpp_value_box(DAT_181d5b2f8,&local_6c);
                        local_64[0] = local_68;
                        uVar10 = il2cpp_value_box(DAT_181d5b2f8,local_64);
                        uVar8 = String.Format("开始修炼;StudyMaxFightSkillStart;{0}-{1};0/{2}",uVar8,uVar9,uVar10,0);
                        if (lVar5 != null) {
                          FUN_181827900(lVar5,uVar8,DAT_181d7c3d0);
                          FUN_181827900(lVar5,"还是算了;HideInteractUI",DAT_181d7c3d0);
                          uVar8 = BuildingUIController.GenerateForceNPCString(this,"弟子",0);
                          uVar9 = new SinglePlotData(uVar7,lVar5,5,uVar8,3,"0",0,0,0);
                          if (lVar3 != null) {
                            PlotController.ChangePlot(lVar3,uVar9,0);
                            return;
                          }
                        }
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                    }
                  }
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = *pStatics_c960;
          lVar5 = *(int64 *)(pStatics_ef00 + 0x498);
          if (lVar5 != null) {
            if (*(uint32 *)(lVar5 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = String.Format("少侠的{0}潜力已然登峰造极，无需再进行修炼了吧。",
                                   *(uint64 *)
                                    (*(int64 *)(lVar5 + 16) + 32 + (int64)(int)uVar1 * 8),0);
            uVar8 = BuildingUIController.GenerateForceNPCString(this,"弟子",0);
            uVar9 = new SinglePlotData(uVar7,0,5,uVar8,3,"0",0,0,0);
            if (lVar3 != null) {
              PlotController.ChangePlot(lVar3,uVar9,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000DEA
    // RVA   : 0xBD1560   Offset: 0xBCFD60   Length: 0xA0C
    public void StudyMaxState(string param)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        long lVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        uint uVar12;
        float fVar13;
        float fVar14;
        uint[] local_res8 = new uint[2];
        uint[] local_res10 = new uint[2];
        uint[] local_res20 = new uint[2];
        int[] local_54 = new int[7];
        fVar13 = (float)BuildingUIController.BuildingStudySkillCostRate
                                  (this,this.buildingData,0);
        uVar1 = Int32.Parse(param,0);
        lVar3 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar3,DAT_181d7c250);
        if (lVar3 != null) {
          FUN_181827900(lVar3,"生命上限",DAT_181d7c3d0);
          FUN_181827900(lVar3,"内力上限",DAT_181d7c3d0);
          if (uVar1 == 0) {
            if (((*pStatics == 0) ||
                (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
               (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
            fVar14 = (float)HeroData.GetExtraMaxHp(lVar4,0);
            fVar14 = fVar14 * 0.1;
          }
          else {
            if (((*pStatics == 0) ||
                (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
               (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
            fVar14 = (float)HeroData.GetExtraMaxMana(lVar4,0);
            fVar14 = fVar14 * 0.05;
          }
          uVar12 = (int)fVar14 + 2;
          uVar2 = Mathf.RoundToInt(fVar13 * 750.0 * (float)(int)uVar12,0);
          lVar4 = **(int64 **)(DAT_181d6c960 + 184);
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d7f180,7);
          if ((this.buildingData != null) &&
             (lVar6 = AreaBuildingData.Name(this.buildingData,0,0), plVar5 != (int64 *)0
             )) {
            if ((lVar6 != null) &&
               (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            if ((int)plVar5[3] == 0) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            plVar5[4] = lVar6;
            il2cpp_internal(plVar5 + 4,lVar6);
            if (((this.buildingData != null) &&
                (lVar6 = AreaBuildingData.GetArea(this.buildingData,0)) != null) &&
               (lVar6 = AreaData.GetForce(lVar6,0)) != null) {
              lVar6 = *(int64 *)(lVar6 + 24);
              if ((lVar6 != null) &&
                 (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(plVar5 + 3) < 2) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar5[5] = lVar6;
              il2cpp_internal(plVar5 + 5,lVar6);
              if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = lVar3[uVar1];
              if ((lVar3 != null) &&
                 (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(plVar5 + 3) < 3) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar5[6] = lVar3;
              il2cpp_internal(plVar5 + 6,lVar3);
              uVar8 = "这{0}乃是{1}增进{2}之无上宝地，只需支付维护修缮费用便可在此修炼。\n少侠当前的额外{2}为{3}，修炼需要{4}日和{5}银两。{6}";
              if (uVar1 == 0) {
                if (((*pStatics != 0) &&
                    (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
                   (lVar3 = WorldData.Player(lVar3,0)) != null) {
                  local_res8[0] = HeroData.GetExtraMaxHp(lVar3,0);
        LAB_180bd1b7e:
                  lVar3 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
                  if ((lVar3 != null) &&
                     (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if (*(uint32 *)(plVar5 + 3) < 4) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  plVar5[7] = lVar3;
                  il2cpp_internal(plVar5 + 7,lVar3);
                  local_res10[0] = uVar12;
                  lVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                  if ((lVar3 != null) &&
                     (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if (*(uint32 *)(plVar5 + 3) < 5) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  plVar5[8] = lVar3;
                  il2cpp_internal(plVar5 + 8,lVar3);
                  local_res20[0] = uVar2;
                  lVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                  if ((lVar3 != null) &&
                     (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if (*(uint32 *)(plVar5 + 3) < 6) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  plVar5[9] = lVar3;
                  il2cpp_internal(plVar5 + 9,lVar3);
                  lVar3 = "";
                  if (fVar13 != 1.0) {
                    local_res8[0] = Mathf.RoundToInt((1.0 - fVar13) * 100.0,0);
                    uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                    lVar3 = String.Format("\n(建筑属于本门派，门派地位可使银两消耗-{0}%)",uVar9,0);
                  }
                  if ((lVar3 != null) &&
                     (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if (*(uint32 *)(plVar5 + 3) < 7) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  plVar5[10] = lVar3;
                  il2cpp_internal(plVar5 + 10,lVar3);
                  uVar8 = String.Format(uVar8,plVar5,0);
                  lVar3 = il2cpp_internal(DAT_181d72a30);
                  FUN_180f58a90(lVar3,DAT_181d7c250);
                  local_res10[0] = uVar1;
                  uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                  local_res20[0] = uVar12;
                  uVar10 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                  local_54[0] = uVar2;
                  uVar11 = il2cpp_value_box(DAT_181d5b2f8,local_54);
                  uVar9 = String.Format("开始修炼;StudyMaxStateStart;{0}-{1};0/{2}",uVar9,uVar10,uVar11,0);
                  if (lVar3 != null) {
                    FUN_181827900(lVar3,uVar9,DAT_181d7c3d0);
                    FUN_181827900(lVar3,"还是算了;HideInteractUI",DAT_181d7c3d0);
                    uVar9 = BuildingUIController.GenerateForceNPCString(this,"弟子",0);
                    uVar10 = new SinglePlotData(uVar8,lVar3,5,uVar9,3,"0",0,0,0);
                    if (lVar4 != null) {
                      PlotController.ChangePlot(lVar4,uVar10,0);
                      return;
                    }
                  }
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
              }
              else {
                if (((*pStatics != 0) &&
                    (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
                   (lVar3 = WorldData.Player(lVar3,0)) != null) {
                  local_res8[0] = HeroData.GetExtraMaxMana(lVar3,0);
                  goto LAB_180bd1b7e;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DEB
    // RVA   : 0xBC1710   Offset: 0xBBFF10   Length: 0xCEC
    public void ProduceBuildingWork(string param)
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        long lVar10;
        long lVar11;
        int iVar12;
        int iVar13;
        int[] local_res20 = new int[2];
        int local_68;
        uint local_64;
        float local_60;
        uint32 local_5c [9];
        iVar12 = 0;
        local_res20[0] = 0;
        local_60 = 0.0;
        local_64 = 0;
        lVar4 = String.Format("WorkInProductionBuilding/{0}_1/FinishWorkInProductionBuilding/{0}_0",param,0);
        cVar1 = FUN_1816fd990(param,"5",0);
        local_68 = -1;
        if (cVar1) {
          local_68 = 2;
        }
        lVar5 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar5,DAT_181d7c250);
        iVar13 = iVar12;
        do {
          local_res20[0] = Mathf.Max(1,iVar12);
          lVar8 = "";
          if (-1 < local_68) {
            uVar6 = Int32.ToString(&local_68,0);
            local_64 = Mathf.RoundToInt((1.0 - (float)iVar13 * 0.1) * (float)(local_res20[0] * 50),0);
            uVar7 = Int32.ToString(&local_64,0);
            lVar8 = String.Concat(";",uVar6,"/",uVar7,0);
          }
          plVar9 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,8);
          lVar10 = Int32.ToString(local_res20,0);
          if (plVar9 == (int64 *)0) throw; // [null/range check failed]
          if ((lVar10 != null) &&
             (lVar11 = il2cpp_internal(lVar10,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          if ((int)plVar9[3] == 0) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          plVar9[4] = lVar10;
          il2cpp_internal(plVar9 + 4,lVar10);
          if (("天;SureBuildingWork;" != 0) &&
             (lVar10 = il2cpp_internal("天;SureBuildingWork;",*(uint64 *)(*plVar9 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          lVar10 = "天;SureBuildingWork;";
          if (*(uint32 *)(plVar9 + 3) < 2) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          plVar9[5] = "天;SureBuildingWork;";
          il2cpp_internal(plVar9 + 5,lVar10);
          if (this.buildingChoiceSelected == null) throw; // [null/range check failed]
          lVar10 = this.buildingChoiceSelected.text;
          if ((lVar10 != null) &&
             (lVar11 = il2cpp_internal(lVar10,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          if (*(uint32 *)(plVar9 + 3) < 3) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          plVar9[6] = lVar10;
          il2cpp_internal(plVar9 + 6,lVar10);
          if (("/" != 0) &&
             (lVar10 = il2cpp_internal("/",*(uint64 *)(*plVar9 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          lVar10 = "/";
          if (*(uint32 *)(plVar9 + 3) < 4) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          plVar9[7] = "/";
          il2cpp_internal(plVar9 + 7,lVar10);
          lVar10 = Int32.ToString(local_res20,0);
          if ((lVar10 != null) &&
             (lVar11 = il2cpp_internal(lVar10,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          if (*(uint32 *)(plVar9 + 3) < 5) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          plVar9[8] = lVar10;
          il2cpp_internal(plVar9 + 8,lVar10);
          if (("/" != 0) &&
             (lVar10 = il2cpp_internal("/",*(uint64 *)(*plVar9 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          lVar10 = "/";
          if (*(uint32 *)(plVar9 + 3) < 6) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          plVar9[9] = "/";
          il2cpp_internal(plVar9 + 9,lVar10);
          if ((lVar4 != null) &&
             (lVar10 = il2cpp_internal(lVar4,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          if (*(uint32 *)(plVar9 + 3) < 7) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          plVar9[10] = lVar4;
          il2cpp_internal(plVar9 + 10,lVar4);
          if ((lVar8 != null) &&
             (lVar10 = il2cpp_internal(lVar8,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          if (*(uint32 *)(plVar9 + 3) < 8) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          plVar9[11] = lVar8;
          il2cpp_internal(plVar9 + 11,lVar8);
          uVar6 = String.Concat(plVar9,0);
          if (lVar5 == null) throw; // [null/range check failed]
          FUN_181827900(lVar5,uVar6);
          iVar13 = iVar13 + 1;
          iVar12 = iVar12 + 5;
        } while (iVar12 < 15);
        FUN_181827900(lVar5,"取消;HideInteractUI",DAT_181d7c3d0);
        lVar4 = *pStatics_c960;
        plVar9 = (int64 *)FUN_1800d60b0(DAT_181d7f180,6);
        if ((this.buildingData != null) &&
           (lVar8 = AreaBuildingData.Name(this.buildingData,0,0), plVar9 != (int64 *)0))
        {
          if ((lVar8 != null) &&
             (lVar10 = il2cpp_internal(lVar8,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          if ((int)plVar9[3] == 0) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          plVar9[4] = lVar8;
          il2cpp_internal(plVar9 + 4,lVar8);
          if (this.buildingChoiceSelected != null) {
            lVar8 = this.buildingChoiceSelected.text;
            if ((lVar8 != null) &&
               (lVar10 = il2cpp_internal(lVar8,*(uint64 *)(*plVar9 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar9 + 3) < 2) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar9[5] = lVar8;
            il2cpp_internal(plVar9 + 5,lVar8);
            cVar1 = String.op_Inequality(param,"5",0);
            uVar6 = "{5}在{0}{1}几天？\n({2}预计每日可获取{4}{3})";
            lVar8 = "";
            if (cVar1) {
              if (this.buildingData == null) throw; // [null/range check failed]
              local_60 = this.buildingData.resourceStoreRate * 100.0;
              uVar7 = Single.ToString(&local_60,"f0",0);
              lVar8 = String.Format("建筑资源储量{0}%，",uVar7,0);
            }
            if ((lVar8 != null) &&
               (lVar10 = il2cpp_internal(lVar8,*(uint64 *)(*plVar9 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar9 + 3) < 3) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar9[6] = lVar8;
            il2cpp_internal(plVar9 + 6,lVar8);
            lVar8 = *(int64 *)(pStatics_ef00 + 0x430);
            uVar2 = Int32.Parse(param,0);
            if (lVar8 != null) {
              if (lVar8.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar8 = lVar8._items[uVar2];
              if ((lVar8 != null) &&
                 (lVar10 = il2cpp_internal(lVar8,*(uint64 *)(*plVar9 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(plVar9 + 3) < 4) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar9[7] = lVar8;
              il2cpp_internal(plVar9 + 7,lVar8);
              lVar8 = *pStatics_c960;
              uVar3 = Int32.Parse(param,0);
              if (lVar8 != null) {
                uVar3 = PlotController.GetResourceProduceNum(lVar8,uVar3,0x3f800000,0);
                local_5c[0] = Mathf.CeilToInt(uVar3,0);
                lVar8 = il2cpp_value_box(DAT_181d5b2f8,local_5c);
                if ((lVar8 != null) &&
                   (lVar10 = il2cpp_internal(lVar8,*(uint64 *)(*plVar9 + 64))) == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                if (*(uint32 *)(plVar9 + 3) < 5) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                plVar9[8] = lVar8;
                il2cpp_internal(plVar9 + 8,lVar8);
                if (((*pStatics_df90 != 0) &&
                    (lVar8 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                   (lVar8 = WorldData.Player(lVar8,0)) != null) {
                  lVar8 = HeroData.GetForce(lVar8,0,0);
                  if (lVar8 == null) {
                    lVar8 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
                    if (((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 88)) == null) ||
                       (lVar8 = AreaData.GetForce(lVar8,0)) == null) throw; // [null/range check failed]
                    uVar7 = lVar8.Count;
                    lVar8 = *(int64 *)(pStatics_ef00 + 0x430);
                    uVar2 = Int32.Parse(param,0);
                    if (lVar8 == null) throw; // [null/range check failed]
                    if (lVar8.Count <= uVar2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar8 = String.Format("在此处帮{0}获取{1}，可以提升我的{0}功绩。",uVar7,
                                           *(uint64 *)
                                            (lVar8._items + 32 + (int64)(int)uVar2 * 8
                                            ),0);
                  }
                  else {
                    lVar8 = this.ProduceBuildingWorkText;
                    uVar2 = Int32.Parse(param,0);
                    if (lVar8 == null) throw; // [null/range check failed]
                    if (lVar8.Count <= uVar2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar8 = lVar8._items[uVar2];
                  }
                  if ((lVar8 != null) &&
                     (lVar10 = il2cpp_internal(lVar8,*(uint64 *)(*plVar9 + 64))) == null) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  if (*(uint32 *)(plVar9 + 3) < 6) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  plVar9[9] = lVar8;
                  il2cpp_internal(plVar9 + 9,lVar8);
                  uVar6 = String.Format(uVar6,plVar9,0);
                  uVar7 = new SinglePlotData(uVar6,lVar5,1,0,3,"0",1,0,0);
                  if (lVar4 != null) {
                    PlotController.AddPlot(lVar4,uVar7,0);
                    return;
                  }
                  throw; // [null/range check failed]
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000DEC
    // RVA   : 0xBC0CB0   Offset: 0xBBF4B0   Length: 0xA54
    public void ProduceBuildingSteal(string param)
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        long lVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        int iVar10;
        uint[] local_res10 = new uint[4];
        float[] local_res20 = new float[2];
        uint[] local_48 = new uint[4];
        local_res20[0] = 0.0;
        local_res10[0] = 0;
        lVar3 = String.Format("WorkInProductionBuilding/{0}_0.5/FinishWorkInProductionBuilding/{0}_1",param,0);
        lVar4 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar4,DAT_181d7c250);
        iVar10 = 0;
        while( true ) {
          local_res10[0] = Mathf.Max(1,iVar10);
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,7);
          lVar6 = Int32.ToString(local_res10,0);
          if (plVar5 == (int64 *)0) break;
          if ((lVar6 != null) &&
             (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if ((int)plVar5[3] == 0) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar5[4] = lVar6;
          il2cpp_internal(plVar5 + 4,lVar6);
          if (("天;SureBuildingWork;" != 0) &&
             (lVar6 = il2cpp_internal("天;SureBuildingWork;",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar6 = "天;SureBuildingWork;";
          if (*(uint32 *)(plVar5 + 3) < 2) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar5[5] = "天;SureBuildingWork;";
          il2cpp_internal(plVar5 + 5,lVar6);
          if (this.buildingChoiceSelected == null) break;
          lVar6 = this.buildingChoiceSelected.text;
          if ((lVar6 != null) &&
             (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 3) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar5[6] = lVar6;
          il2cpp_internal(plVar5 + 6,lVar6);
          if (("/" != 0) &&
             (lVar6 = il2cpp_internal("/",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar6 = "/";
          if (*(uint32 *)(plVar5 + 3) < 4) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar5[7] = "/";
          il2cpp_internal(plVar5 + 7,lVar6);
          lVar6 = Int32.ToString(local_res10,0);
          if ((lVar6 != null) &&
             (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 5) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar5[8] = lVar6;
          il2cpp_internal(plVar5 + 8,lVar6);
          if (("/" != 0) &&
             (lVar6 = il2cpp_internal("/",*(uint64 *)(*plVar5 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar6 = "/";
          if (*(uint32 *)(plVar5 + 3) < 6) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar5[9] = "/";
          il2cpp_internal(plVar5 + 9,lVar6);
          if ((lVar3 != null) &&
             (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64))) == null) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if (*(uint32 *)(plVar5 + 3) < 7) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          plVar5[10] = lVar3;
          il2cpp_internal(plVar5 + 10,lVar3);
          uVar8 = String.Concat(plVar5,0);
          if (lVar4 == null) break;
          FUN_181827900(lVar4,uVar8);
          iVar10 = iVar10 + 5;
          if (14 < iVar10) {
            FUN_181827900(lVar4,"取消;HideInteractUI",DAT_181d7c3d0);
            lVar3 = *pStatics_c960;
            uVar8 = "趁{2}不备，何不在此偷偷收取{3}，以贴补本门所用。在{0}{1}几天？\n({5}预计每日可获取{4}{3})\n(非本门资源效率减半)";
            if (*(char *)(pStatics_ef00 + 4) != false) {
              uVar8 = "在此处回收{2}多余的{3}，以贴补本门所用。在{0}{1}几天？\n({5}预计每日可获取{4}{3})\n(非本门资源效率减半)";
            }
            plVar5 = (int64 *)FUN_1800d60b0(DAT_181d7f180,6);
            if ((this.buildingData != null) &&
               (lVar6 = AreaBuildingData.Name(this.buildingData,0,0),
               plVar5 != (int64 *)0)) {
              if ((lVar6 != null) &&
                 (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if ((int)plVar5[3] == 0) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar5[4] = lVar6;
              il2cpp_internal(plVar5 + 4,lVar6);
              if (this.buildingChoiceSelected != null) {
                lVar6 = this.buildingChoiceSelected.text;
                if ((lVar6 != null) &&
                   (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                if (*(uint32 *)(plVar5 + 3) < 2) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar5[5] = lVar6;
                il2cpp_internal(plVar5 + 5,lVar6);
                lVar6 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
                if (((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 88)) != null) &&
                   (lVar6 = AreaData.GetForce(lVar6,0)) != null) {
                  lVar6 = *(int64 *)(lVar6 + 24);
                  if ((lVar6 != null) &&
                     (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if (*(uint32 *)(plVar5 + 3) < 3) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  plVar5[6] = lVar6;
                  il2cpp_internal(plVar5 + 6,lVar6);
                  lVar6 = *(int64 *)(pStatics_ef00 + 0x430);
                  uVar1 = Int32.Parse(param,0);
                  if (lVar6 != null) {
                    if (*(uint32 *)(lVar6 + 24) <= uVar1) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar6 = lVar6[uVar1];
                    if ((lVar6 != null) &&
                       (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    if (*(uint32 *)(plVar5 + 3) < 4) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    plVar5[7] = lVar6;
                    il2cpp_internal(plVar5 + 7,lVar6);
                    lVar6 = *pStatics_c960;
                    uVar2 = Int32.Parse(param,0);
                    if (lVar6 != null) {
                      uVar2 = PlotController.GetResourceProduceNum(lVar6,uVar2,0x3f000000,0);
                      local_48[0] = Mathf.CeilToInt(uVar2,0);
                      lVar6 = il2cpp_value_box(DAT_181d5b2f8,local_48);
                      if ((lVar6 != null) &&
                         (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null)
                      {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar8,0);
                      }
                      if (*(uint32 *)(plVar5 + 3) < 5) {
                        uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar8,0);
                      }
                      plVar5[8] = lVar6;
                      il2cpp_internal(plVar5 + 8,lVar6);
                      if (this.buildingData != null) {
                        local_res20[0] = this.buildingData.resourceStoreRate * 100.0;
                        uVar9 = Single.ToString(local_res20,"f0",0);
                        lVar6 = String.Format("建筑资源储量{0}%，",uVar9,0);
                        if ((lVar6 != null) &&
                           (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64)), lVar7 == null
                           )) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        if (*(uint32 *)(plVar5 + 3) < 6) {
                          uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar8,0);
                        }
                        plVar5[9] = lVar6;
                        il2cpp_internal(plVar5 + 9,lVar6);
                        uVar8 = String.Format(uVar8,plVar5,0);
                        uVar9 = new SinglePlotData(uVar8,lVar4,1,0,3,"0",1,0,0);
                        if (lVar3 != null) {
                          PlotController.AddPlot(lVar3,uVar9,0);
                          return;
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

    // Token : 0x6000DED
    // RVA   : 0xBB5F00   Offset: 0xBB4700   Length: 0xC5A
    public void AreaBuildingWork(string param)
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        uint uVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        long lVar10;
        long lVar11;
        long lVar12;
        int iVar13;
        int iVar14;
        int[] local_res10 = new int[2];
        int[] local_res20 = new int[2];
        uint local_68;
        uint local_64;
        uint local_60;
        lVar12 = "";
        iVar13 = 0;
        local_64 = 0;
        local_res20[0] = 0;
        local_68 = 0;
        lVar4 = String.Format("WorkInAreaBuilding/{0}/FinishWorkInAreaBuilding/{0}",param,0);
        local_res10[0] = -1;
        if (param == null) throw; // [null/range check failed]
        uVar3 = PrivateImplementationDetails.ComputeStringHash(param,0);
        if (uVar3 < 0x370cabd6) {
          if (uVar3 < 0x340ca71d) {
            if (uVar3 == 0x310ca263) {
              cVar2 = FUN_1816fd990(param,"4",0);
              if (cVar2) {
                local_res10[0] = 5;
                lVar12 = "在此处分发药物，免费问诊，可使民众身体康健，百病不侵。";
              }
            }
            else if (uVar3 == 0x340ca71c) {
              cVar2 = FUN_1816fd990(param,"1",0);
              lVar6 = "打磨武器，整备军械，方能将敌对细作一网打尽！";
              goto joined_r0x000180bb6302;
            }
          }
          else if (uVar3 == 0x360caa42) {
            cVar2 = FUN_1816fd990(param,"3",0);
            if (cVar2) {
              local_res10[0] = 3;
              lVar12 = "在此处修缮防御工事，营造壁垒，以防敌袭。";
            }
          }
          else if ((uVar3 == 0x370cabd5) &&
                  (cVar2 = FUN_1816fd990(param,"2",0), cVar2)) {
            local_res10[0] = 2;
            lVar12 = "不妨给老弱病残者分发一些饮食，他们必定对#AreaForceName#感恩戴德";
          }
        }
        else if (uVar3 < 0xc03eb115) {
          if (uVar3 == 0xbe3eadee) {
            cVar2 = FUN_1816fd990(param,"负4",0);
            if (cVar2) {
              local_res10[0] = 5;
              lVar12 = "在此地投下使人恶心呕吐，腹泻不止的疫病之物，可使人心惶惶，民众离散。";
            }
          }
          else if ((uVar3 == 0xc03eb114) &&
                  (cVar2 = FUN_1816fd990(param,"负2",0), cVar2)) {
            local_res10[0] = 2;
            lVar12 = "贫苦乡亲们，收下这些食物吧！#AreaForceName#不管你们死活，我#PlayerForceName#断不会如此！";
          }
        }
        else if (uVar3 == 0xc13eb2a7) {
          cVar2 = FUN_1816fd990(param,"负3",0);
          if (cVar2) {
            local_res10[0] = 3;
            lVar12 = "哼哼，只需在这些城墙工事上动些手脚......";
          }
        }
        else if (uVar3 == 0xc33eb5cd) {
          cVar2 = FUN_1816fd990(param,"负1",0);
          lVar6 = "将此处的武器军械破坏殆尽，#AreaForceName#便更难在此处维持治安。";
        joined_r0x000180bb6302:
          if (cVar2) {
            local_res10[0] = 4;
            lVar12 = lVar6;
          }
        }
        uVar5 = String.Replace(param,"负","-",0);
        local_60 = Int32.Parse(uVar5,0);
        lVar6 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar6,DAT_181d7c250);
        iVar14 = iVar13;
        do {
          local_res20[0] = Mathf.Max(1,iVar13);
          lVar8 = "";
          if (-1 < local_res10[0]) {
            uVar5 = Int32.ToString(local_res10,0);
            local_68 = Mathf.RoundToInt((1.0 - (float)iVar14 * 0.1) * (float)(local_res20[0] * 20),0);
            uVar7 = Int32.ToString(&local_68,0);
            lVar8 = String.Concat(";",uVar5,"/",uVar7,0);
          }
          plVar9 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,8);
          lVar10 = Int32.ToString(local_res20,0);
          if (plVar9 == (int64 *)0) throw; // [null/range check failed]
          if ((lVar10 != null) &&
             (lVar11 = il2cpp_internal(lVar10,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if ((int)plVar9[3] == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar9[4] = lVar10;
          il2cpp_internal(plVar9 + 4,lVar10);
          if (("天;SureBuildingWork;" != 0) &&
             (lVar10 = il2cpp_internal("天;SureBuildingWork;",*(uint64 *)(*plVar9 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar10 = "天;SureBuildingWork;";
          if (*(uint32 *)(plVar9 + 3) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar9[5] = "天;SureBuildingWork;";
          il2cpp_internal(plVar9 + 5,lVar10);
          if (this.buildingChoiceSelected == null) throw; // [null/range check failed]
          lVar10 = this.buildingChoiceSelected.text;
          if ((lVar10 != null) &&
             (lVar11 = il2cpp_internal(lVar10,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar9 + 3) < 3) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar9[6] = lVar10;
          il2cpp_internal(plVar9 + 6,lVar10);
          if (("/" != 0) &&
             (lVar10 = il2cpp_internal("/",*(uint64 *)(*plVar9 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar10 = "/";
          if (*(uint32 *)(plVar9 + 3) < 4) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar9[7] = "/";
          il2cpp_internal(plVar9 + 7,lVar10);
          lVar10 = Int32.ToString(local_res20,0);
          if ((lVar10 != null) &&
             (lVar11 = il2cpp_internal(lVar10,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar9 + 3) < 5) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar9[8] = lVar10;
          il2cpp_internal(plVar9 + 8,lVar10);
          if (("/" != 0) &&
             (lVar10 = il2cpp_internal("/",*(uint64 *)(*plVar9 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar10 = "/";
          if (*(uint32 *)(plVar9 + 3) < 6) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar9[9] = "/";
          il2cpp_internal(plVar9 + 9,lVar10);
          if ((lVar4 != null) &&
             (lVar10 = il2cpp_internal(lVar4,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar9 + 3) < 7) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar9[10] = lVar4;
          il2cpp_internal(plVar9 + 10,lVar4);
          if ((lVar8 != null) &&
             (lVar10 = il2cpp_internal(lVar8,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if (*(uint32 *)(plVar9 + 3) < 8) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar9[11] = lVar8;
          il2cpp_internal(plVar9 + 11,lVar8);
          uVar5 = String.Concat(plVar9,0);
          if (lVar6 == null) throw; // [null/range check failed]
          FUN_181827900(lVar6,uVar5);
          iVar14 = iVar14 + 1;
          iVar13 = iVar13 + 5;
        } while (iVar13 < 15);
        FUN_181827900(lVar6,"取消;HideInteractUI",DAT_181d7c3d0);
        lVar4 = *pStatics;
        uVar5 = String.Concat(lVar12,"在{0}{1}几天？\n(预计每日可使该地{2}{3})",0);
        plVar9 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
        if ((this.buildingData != null) &&
           (lVar12 = AreaBuildingData.Name(this.buildingData,0,0), plVar9 != (int64 *)0)
           ) {
          if ((lVar12 != null) &&
             (lVar8 = il2cpp_internal(lVar12,*(uint64 *)(*plVar9 + 64))) == null) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          if ((int)plVar9[3] == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar9[4] = lVar12;
          il2cpp_internal(plVar9 + 4,lVar12);
          if (this.buildingChoiceSelected != null) {
            lVar12 = this.buildingChoiceSelected.text;
            if ((lVar12 != null) &&
               (lVar8 = il2cpp_internal(lVar12,*(uint64 *)(*plVar9 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if (*(uint32 *)(plVar9 + 3) < 2) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            plVar9[5] = lVar12;
            il2cpp_internal(plVar9 + 5,lVar12);
            uVar1 = local_60;
            lVar12 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x600);
            iVar13 = Mathf.Abs(local_60,0);
            if (lVar12 != null) {
              if (*(uint32 *)(lVar12 + 24) <= iVar13 - 1U) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar12 = *(int64 *)
                        (*(int64 *)(lVar12 + 16) + 32 + (int64)(int)(iVar13 - 1U) * 8);
              if ((lVar12 != null) &&
                 (lVar8 = il2cpp_internal(lVar12,*(uint64 *)(*plVar9 + 64))) == null) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              if (*(uint32 *)(plVar9 + 3) < 3) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              plVar9[6] = lVar12;
              il2cpp_internal(plVar9 + 6,lVar12);
              if (*pStatics != 0) {
                local_64 = PlotController.GetWorkInAreaBuildingNum
                                     (*pStatics,uVar1,0);
                lVar12 = Single.ToString(&local_64,"+0;-0;0",0);
                if ((lVar12 != null) &&
                   (lVar8 = il2cpp_internal(lVar12,*(uint64 *)(*plVar9 + 64))) == null) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                if (*(uint32 *)(plVar9 + 3) < 4) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar9[7] = lVar12;
                il2cpp_internal(plVar9 + 7,lVar12);
                uVar5 = String.Format(uVar5,plVar9,0);
                uVar7 = new SinglePlotData(uVar5,lVar6,1,0,3,"0",1,0,0);
                if (lVar4 != null) {
                  PlotController.AddPlot(lVar4,uVar7,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DEE
    // RVA   : 0xBC2400   Offset: 0xBC0C00   Length: 0x319
    public void RecoverBuildingResourceRate()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        float[] local_res8 = new float[2];
        lVar1 = *pStatics;
        if (this.buildingData != null) {
          lVar2 = AreaBuildingData.DataBase(this.buildingData,0);
          if (lVar2 != null) {
            uVar4 = *(uint64 *)(lVar2 + 24);
            if (this.buildingChoiceSelected != null) {
              uVar5 = this.buildingChoiceSelected.text;
              if (*pStatics != 0) {
                local_res8[0] =
                     (float)PlotController.GetRecoverBuildingResourceRate
                                      (*pStatics,0);
                local_res8[0] = local_res8[0] * 100.0;
                uVar3 = Single.ToString(local_res8,"f0",0);
                uVar4 = String.Format("在{0}{1}几天？\n(预计每日可提升资源储量{2}%)",uVar4,uVar5,uVar3,0);
                lVar2 = il2cpp_internal(DAT_181d72a30);
                FUN_180f58a90(lVar2,DAT_181d7c250);
                if (lVar2 != null) {
                  FUN_181827900(lVar2,"5天;RecoverBuildingResourceRate;5",DAT_181d7c3d0);
                  FUN_181827900(lVar2,"10天;RecoverBuildingResourceRate;10",DAT_181d7c3d0);
                  FUN_181827900(lVar2,"15天;RecoverBuildingResourceRate;15",DAT_181d7c3d0);
                  FUN_181827900(lVar2,"取消;HideInteractUI",DAT_181d7c3d0);
                  uVar5 = new SinglePlotData(uVar4,lVar2,1,"",3,"0",1,0,0);
                  if (lVar1 != null) {
                    PlotController.ChangePlot(lVar1,uVar5,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DEF
    // RVA   : 0xBB6B60   Offset: 0xBB5360   Length: 0x215
    public void AskNearRandomEvent()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong in_stack_ffffffffffffffc8;
        uint uVar5;
        uint uVar6;
        uVar5 = (uint32)((uint64)in_stack_ffffffffffffffc8 >> 32);
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        if (lVar2 != null) {
          FUN_181827900(lVar2,"开始探听;StartAskNearRandomEvent;;0/50",DAT_181d7c3d0);
          FUN_181827900(lVar2,"取消;HideInteractUI",DAT_181d7c3d0);
          uVar6 = 0;
          uVar3 = BuildingUIController.GenerateBuildingNPCString
                            (this,"小二",0xfffffffc,0xffffffff,CONCAT44(uVar5,0xffffffff),0);
          uVar4 = new SinglePlotData("此处人来人往，鱼龙混杂，附近游人旅客来此打尖住店，可谓络绎不绝。\n少侠只需花上两天时间和五十两银子，让小的为您打探情报，\n便可获知此地周边，有哪些奇闻异事发生。",lVar2,5,uVar3,CONCAT44(uVar6,3),"0",0,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000DF0
    // RVA   : 0xBCEA60   Offset: 0xBCD260   Length: 0xAB
    public void StudyFightOther()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.ChooseStudyFightOtherTarget(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DF1
    // RVA   : 0xBCEB10   Offset: 0xBCD310   Length: 0x34E
    public void StudyFightSelf()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int iVar5;
        int[] local_res18 = new int[2];
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        iVar5 = 3;
        while( true ) {
          lVar1 = *(int64 *)(pStatics + 0x498);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int *)(lVar1 + 24) <= iVar5) {
            if (lVar2 != null) {
              FUN_181827900(lVar2,"取消;HideInteractUI",DAT_181d7c3d0);
              lVar1 = **(int64 **)(DAT_181d6c960 + 184);
              local_res18[0] = *(int *)(pStatics + 0x168);
              uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
              uVar3 = String.Format("学而时习之，不亦乐乎。接下来该练习哪门外功呢？\n(练习可增加外功的实战经验，{0}级内效果最佳)",uVar3,0);
              uVar4 = new SinglePlotData(uVar3,lVar2,1,"",3,"0",1,0,0);
              if (lVar1 != null) {
                PlotController.ChangePlot(lVar1,uVar4,0);
                return;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar1 = *(int64 *)(pStatics + 0x498);
          if (lVar1 == null) break;
          uVar3 = FUN_180002f80(lVar1,iVar5,DAT_181d7c9c0);
          local_res18[0] = iVar5;
          uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          uVar3 = String.Format("修炼{0};StudyFightSelfChoose;{1}",uVar3,uVar4,0);
          if (lVar2 == null) break;
          FUN_181827900(lVar2,uVar3,DAT_181d7c3d0);
          iVar5 = iVar5 + 1;
        }
    }

    // Token : 0x6000DF2
    // RVA   : 0xBCEE60   Offset: 0xBCD660   Length: 0x300
    public void StudyInternalSelf()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int iVar5;
        int[] local_res18 = new int[2];
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        iVar5 = 0;
        while( true ) {
          lVar1 = *(int64 *)(pStatics + 0x498);
          if (lVar1 == null) break;
          uVar3 = FUN_180002f80(lVar1,iVar5,DAT_181d7c9c0);
          local_res18[0] = iVar5;
          uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          uVar3 = String.Format("修炼{0};StudyFightSelfChoose;{1}",uVar3,uVar4,0);
          if (lVar2 == null) break;
          FUN_181827900(lVar2,uVar3,DAT_181d7c3d0);
          iVar5 = iVar5 + 1;
          if (2 < iVar5) {
            FUN_181827900(lVar2,"取消;HideInteractUI",DAT_181d7c3d0);
            lVar1 = **(int64 **)(DAT_181d6c960 + 184);
            local_res18[0] = *(int *)(pStatics + 0x164);
            uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            uVar3 = String.Format("千里之行，始于足下。接下来该修炼哪门武功呢？\n(修炼可增加内功/轻功/绝技的实战经验，{0}级内效果最佳)",uVar3,0);
            uVar4 = new SinglePlotData(uVar3,lVar2,1,"",3,"0",1,0,0);
            if (lVar1 != null) {
              PlotController.ChangePlot(lVar1,uVar4,0);
              return;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000DF3
    // RVA   : 0xBC5A40   Offset: 0xBC4240   Length: 0x150
    public void ShowForceShowRoom()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d7ce38 + 184) + 32);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
          uVar3 = AreaData.GetForce(lVar2,0);
          if (lVar1 != null) {
            ShowRoomController.ShowShowRoomUI(lVar1,0,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DF4
    // RVA   : 0xBC6A90   Offset: 0xBC5290   Length: 0xB4
    public void ShowSelfShowRoom()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d7ce38 + 184) + 32);
        if (lVar1 != null) {
          ShowRoomController.ShowShowRoomUI(lVar1,1,0);
          return;
        }
    }

    // Token : 0x6000DF5
    // RVA   : 0xBBAF50   Offset: 0xBB9750   Length: 0x6D
    public int GetBuildingExtraKnowledge(bool useMoney)
    {
        byte[] auVar1 = new byte[16];
        byte[] auVar2 = new byte[16];
        byte[] auVar3 = new byte[16];
        byte[] auVar4 = new byte[16];
        uint64 extraout_XMM0_Qb;
        uint64 extraout_XMM0_Qb_00;
        if (!useMoney) {
          if (this.buildingData != null) {
            auVar3._0_8_ = Mathf.Max(this,0x3f000000,0);
            auVar3._8_8_ = extraout_XMM0_Qb_00;
            auVar4._4_12_ = auVar3._4_12_;
            auVar4._0_4_ = (float)auVar3._0_8_ + (float)auVar3._0_8_;
            Mathf.RoundToInt(auVar4._0_8_,0);
            return;
          }
        }
        else if (this.buildingData != null) {
          auVar1._0_8_ = Mathf.Max(this,0x3f000000,0);
          auVar1._8_8_ = extraout_XMM0_Qb;
          auVar2._4_12_ = auVar1._4_12_;
          auVar2._0_4_ = (float)auVar1._0_8_ * 4.0;
          Mathf.RoundToInt(auVar2._0_8_,0);
          return;
        }
    }

    // Token : 0x6000DF6
    // RVA   : 0xBBB0A0   Offset: 0xBB98A0   Length: 0x3D
    public int GetBuildingIdentifyMoney()
    {
        byte[] auVar1 = new byte[16];
        byte[] auVar2 = new byte[16];
        uint64 extraout_XMM0_Qb;
        if (this.buildingData != null) {
          auVar1._0_8_ = Mathf.Max(this,0x3f000000,0);
          auVar1._8_8_ = extraout_XMM0_Qb;
          auVar2._4_12_ = auVar1._4_12_;
          auVar2._0_4_ = (float)auVar1._0_8_ * 20.0;
          Mathf.RoundToInt(auVar2._0_8_,0);
          return;
        }
    }

    // Token : 0x6000DF7
    // RVA   : 0xBBD700   Offset: 0xBBBF00   Length: 0x39F
    public void IdentifyItem()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        int iVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        float fVar7;
        byte[] auVar8 = new byte[16];
        byte[] auVar9 = new byte[16];
        byte[] auVar10 = new byte[16];
        byte[] auVar11 = new byte[16];
        uint[] local_res8 = new uint[2];
        float[] local_res18 = new float[2];
        uint64 extraout_XMM0_Qb;
        uint64 extraout_XMM0_Qb_00;
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        if (this.buildingData != null) {
          uVar3 = AreaBuildingData.Name(this.buildingData,1,0);
          if (this.buildingData != null) {
            auVar8._0_8_ = Mathf.Max(this.buildingData,0x3f000000,0);
            auVar8._8_8_ = extraout_XMM0_Qb;
            auVar9._4_12_ = auVar8._4_12_;
            auVar9._0_4_ = (float)auVar8._0_8_ + (float)auVar8._0_8_;
            local_res8[0] = Mathf.RoundToInt(auVar9._0_8_,0);
            uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            if ((*pStatics != 0) &&
               (lVar5 = *(int64 *)(*pStatics + 32)) != null) {
              lVar5 = WorldData.Player(lVar5,0);
              if (lVar5 != null) {
                fVar7 = (float)HeroData.GetIdentifyKnowledge(lVar5,0);
                if (this.buildingData != null) {
                  auVar10._0_8_ = Mathf.Max();
                  auVar10._8_8_ = extraout_XMM0_Qb_00;
                  auVar11._4_12_ = auVar10._4_12_;
                  auVar11._0_4_ = (float)auVar10._0_8_ + (float)auVar10._0_8_;
                  iVar2 = Mathf.RoundToInt(auVar11._0_8_,0);
                  local_res18[0] = (float)iVar2 + fVar7;
                  uVar6 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
                  uVar3 = String.Format("世间奇珍异宝可谓浩如繁星，若想一一准确鉴定，非有渊博之学识不可。\n({0}提升{1}点学识效果，当前可鉴定学识要求{2}以下的珍宝)",uVar3,uVar4,uVar6,0);
                  lVar5 = il2cpp_internal(DAT_181d72a30);
                  FUN_180f58a90(lVar5,DAT_181d7c250);
                  if (lVar5 != null) {
                    FUN_181827900(lVar5,"鉴定物品;ChooseIdentifyItem;false",DAT_181d7c3d0);
                    FUN_181827900(lVar5,"取消;HideInteractUI",DAT_181d7c3d0);
                    uVar4 = new SinglePlotData(uVar3,lVar5,1,0,3,"0",1,0,0);
                    if (lVar1 != null) {
                      PlotController.ChangePlot(lVar1,uVar4,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DF8
    // RVA   : 0xBBD150   Offset: 0xBBB950   Length: 0x5A3
    public void IdentifyItemMoney()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        int iVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        float fVar9;
        byte[] auVar10 = new byte[16];
        byte[] auVar11 = new byte[16];
        byte[] auVar12 = new byte[16];
        byte[] auVar13 = new byte[16];
        byte[] auVar14 = new byte[16];
        byte[] auVar15 = new byte[16];
        uint[] local_res8 = new uint[2];
        float[] local_res18 = new float[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffff98;
        uint uVar16;
        uint uVar17;
        uint64 extraout_XMM0_Qb;
        uint64 extraout_XMM0_Qb_00;
        uint64 extraout_XMM0_Qb_01;
        uVar16 = (uint32)((uint64)in_stack_ffffffffffffff98 >> 32);
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        plVar3 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
        if (this.buildingData != null) {
          lVar4 = AreaBuildingData.Name(this.buildingData,1,0);
          if (plVar3 != (int64 *)0) {
            if (lVar4 != null) {
              lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
              if (lVar5 == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
            }
            if ((int)plVar3[3] == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar3[4] = lVar4;
            il2cpp_internal(plVar3 + 4,lVar4);
            if (this.buildingData != null) {
              auVar10._0_8_ = Mathf.Max();
              auVar10._8_8_ = extraout_XMM0_Qb;
              auVar11._4_12_ = auVar10._4_12_;
              auVar11._0_4_ = (float)auVar10._0_8_ * 4.0;
              local_res8[0] = Mathf.RoundToInt(auVar11._0_8_,0);
              lVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
              if (lVar4 != null) {
                lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                if (lVar5 == null) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
              }
              if (*(uint32 *)(plVar3 + 3) < 2) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar3[5] = lVar4;
              il2cpp_internal(plVar3 + 5,lVar4);
              if ((*pStatics != 0) &&
                 (lVar4 = *(int64 *)(*pStatics + 32)) != null) {
                lVar4 = WorldData.Player(lVar4,0);
                if (lVar4 != null) {
                  fVar9 = (float)HeroData.GetIdentifyKnowledge(lVar4,0);
                  if (this.buildingData != null) {
                    auVar12._0_8_ = Mathf.Max();
                    auVar12._8_8_ = extraout_XMM0_Qb_00;
                    auVar13._4_12_ = auVar12._4_12_;
                    auVar13._0_4_ = (float)auVar12._0_8_ * 4.0;
                    iVar2 = Mathf.RoundToInt(auVar13._0_8_,0);
                    local_res18[0] = (float)iVar2 + fVar9;
                    lVar4 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
                    if (lVar4 != null) {
                      lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                      if (lVar5 == null) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                    }
                    if (*(uint32 *)(plVar3 + 3) < 3) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    plVar3[6] = lVar4;
                    il2cpp_internal(plVar3 + 6,lVar4);
                    if (this.buildingData != null) {
                      auVar14._0_8_ = Mathf.Max();
                      auVar14._8_8_ = extraout_XMM0_Qb_01;
                      auVar15._4_12_ = auVar14._4_12_;
                      auVar15._0_4_ = (float)auVar14._0_8_ * 20.0;
                      local_res20[0] = Mathf.RoundToInt(auVar15._0_8_,0);
                      lVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                      if (lVar4 != null) {
                        lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar3 + 64));
                        if (lVar5 == null) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar6,0);
                        }
                      }
                      if (*(uint32 *)(plVar3 + 3) < 4) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      plVar3[7] = lVar4;
                      il2cpp_internal(plVar3 + 7,lVar4);
                      uVar6 = String.Format("少侠若有无法辨识的珍宝，只消花上{3}银两，便可让小店帮忙鉴别一二。\n({0}提升{1}点学识效果，当前可鉴定学识要求{2}以下的珍宝)",plVar3,0);
                      lVar4 = il2cpp_internal(DAT_181d72a30);
                      FUN_180f58a90(lVar4,DAT_181d7c250);
                      if (lVar4 != null) {
                        FUN_181827900(lVar4,"鉴定物品;ChooseIdentifyItem;true",DAT_181d7c3d0);
                        FUN_181827900(lVar4,"取消;HideInteractUI",DAT_181d7c3d0);
                        uVar17 = 0;
                        uVar7 = BuildingUIController.GenerateBuildingNPCString
                                          (this,"店铺商人",0xfffffffd,0xffffffff,
                                           CONCAT44(uVar16,0xffffffff),0);
                        uVar8 = il2cpp_internal(DAT_181d7d2b0);
                        SinglePlotData.ctor
                                  (uVar8,uVar6,lVar4,5,uVar7,CONCAT44(uVar17,3),"0",0,0,0);
                        if (lVar1 != null) {
                          PlotController.ChangePlot(lVar1,uVar8,0);
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

    // Token : 0x6000DF9
    // RVA   : 0xBB74F0   Offset: 0xBB5CF0   Length: 0x217
    public void BreakThroughSkill()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        uVar2 = FUN_180228420(DAT_181d63120);
        uVar2 = String.Format("博观约取，厚积薄发，突破抵达瓶颈的武功，方能更进一步。",uVar2,0);
        lVar3 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar3,DAT_181d7c250);
        if (lVar3 != null) {
          FUN_181827900(lVar3,"选择功法;BreakThroughSkill",DAT_181d7c3d0);
          FUN_181827900(lVar3,"取消;HideInteractUI",DAT_181d7c3d0);
          uVar4 = new SinglePlotData(uVar2,lVar3,1,"",3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000DFA
    // RVA   : 0xBB72A0   Offset: 0xBB5AA0   Length: 0x242
    public void BreakThroughSkillMoney()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong in_stack_ffffffffffffffb8;
        uint uVar6;
        uint uVar7;
        uVar6 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        uVar2 = FUN_180228420(DAT_181d63120);
        uVar2 = String.Format("这位少侠想租用本武馆的闭关室，用于突破瓶颈吗？\n保证安静舒适，价钱实惠~",uVar2,0);
        lVar3 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar3,DAT_181d7c250);
        if (lVar3 != null) {
          FUN_181827900(lVar3,"选择功法;BreakThroughSkillMoney",DAT_181d7c3d0);
          FUN_181827900(lVar3,"还是算了;HideInteractUI",DAT_181d7c3d0);
          uVar7 = 0;
          uVar4 = BuildingUIController.GenerateBuildingNPCString
                            (this,"武师",0xffffffff,0xffffffff,CONCAT44(uVar6,0xffffffff),0);
          uVar5 = new SinglePlotData(uVar2,lVar3,5,uVar4,CONCAT44(uVar7,3),"0",0,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar5,0);
            return;
          }
        }
    }

    // Token : 0x6000DFB
    // RVA   : 0xBBF140   Offset: 0xBBD940   Length: 0xAB
    public void ManageTag()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.ChooseManageTagTarget(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DFC
    // RVA   : 0xBBEFF0   Offset: 0xBBD7F0   Length: 0x14F
    public void ManageTagMoney()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181d627f0 + 184);
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          uVar3 = WorldData.Player(lVar2,0);
          if (lVar1 != null) {
            ManageTagController.ShowManageTagUI(lVar1,uVar3,1,0);
            return;
          }
        }
    }

    // Token : 0x6000DFD
    // RVA   : 0xBBC4A0   Offset: 0xBBACA0   Length: 0xAB
    public void HomeRest()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.HomeRest(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DFE
    // RVA   : 0xBBD070   Offset: 0xBBB870   Length: 0xD7
    public void HotelRest()
    {
        long lVar1;
        long lVar2;
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        if (this.buildingData != null) {
          lVar2 = AreaBuildingData.DataBase(this.buildingData,0);
          if ((lVar2 != null) && (lVar1 != null)) {
            PlotController.HotelRest(lVar1,*(uint64 *)(lVar2 + 24),0);
            return;
          }
        }
    }

    // Token : 0x6000DFF
    // RVA   : 0xBC6C40   Offset: 0xBC5440   Length: 0xD7
    public void SimpleWork()
    {
        long lVar1;
        long lVar2;
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        if (this.buildingData != null) {
          lVar2 = AreaBuildingData.DataBase(this.buildingData,0);
          if ((lVar2 != null) && (lVar1 != null)) {
            PlotController.SimpleWork(lVar1,*(uint64 *)(lVar2 + 24),0);
            return;
          }
        }
    }

    // Token : 0x6000E00
    // RVA   : 0xBC08A0   Offset: 0xBBF0A0   Length: 0x403
    public void PerformForMoney()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        if ((*pStatics_df90 == 0) ||
           (lVar5 = *(int64 *)(*pStatics_df90 + 32)) == null)
        throw; // [null/range check failed]
        if (*(int *)(lVar5 + 0x124) < 3) {
          lVar5 = *pStatics_c960;
          if (this.buildingData == null) throw; // [null/range check failed]
          lVar1 = AreaBuildingData.DataBase(this.buildingData,0);
          if (lVar1 == null) throw; // [null/range check failed]
          uVar2 = String.Format("此{0}之处人来人往，热闹非凡。\n何不找个显眼之处吆喝卖艺，好赚些盘缠？",*(uint64 *)(lVar1 + 24),0);
          lVar1 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar1,DAT_181d7c250);
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_181827900(lVar1,"武艺表演;StartCoachPlot",DAT_181d7c3d0);
          FUN_181827900(lVar1,"讲经说书;ChoosePerformForMoney;2",DAT_181d7c3d0);
          FUN_181827900(lVar1,"珍宝鉴定;ChoosePerformForMoney;3",DAT_181d7c3d0);
          FUN_181827900(lVar1,"还是算了;HideInteractUI",DAT_181d7c3d0);
          uVar3 = il2cpp_internal();
          uVar4 = "";
        }
        else {
          lVar5 = *pStatics_c960;
          uVar4 = FUN_180228420(DAT_181d63120);
          uVar2 = String.Format("这个月已经卖艺三日，若是天天不务正业，只怕为江湖中人耻笑。",uVar4,0);
          uVar3 = il2cpp_internal();
          lVar1 = 0;
          uVar4 = 0;
        }
        SinglePlotData.ctor(uVar3,uVar2,lVar1,1,uVar4,3,"0",1,0,0);
        if (lVar5 != null) {
          PlotController.ChangePlot(lVar5,uVar3,0);
          return;
        }
    }

    // Token : 0x6000E01
    // RVA   : 0xBB9A60   Offset: 0xBB8260   Length: 0x58E
    public void DoctorWork()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        uint[] local_res18 = new uint[2];
        int[] local_res20 = new int[2];
        if (((*pStatics_df90 != 0) &&
            (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar2 = WorldData.Player(lVar2,0)) != null) {
          iVar1 = HeroData.GetMaxDoctorTime(lVar2,0);
          if ((*pStatics_df90 != 0) &&
             (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
            if (iVar1 <= *(int *)(lVar2 + 0x120)) {
              lVar2 = *pStatics_c960;
              uVar5 = GlobalData.GetNumText(iVar1,0);
              if ((((*pStatics_df90 != 0) &&
                   (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                  (lVar3 = WorldData.Player(lVar3,0)) != null) &&
                 (lVar3 = *(int64 *)(lVar3 + 0x168)) != null) {
                if (*(int *)(lVar3 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_res18[0] = *(uint32 *)(*(int64 *)(lVar3 + 16) + 32);
                uVar4 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
                local_res20[0] = iVar1;
                uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                uVar4 = String.Format("这个月已经坐诊{0}日，还是应当再去多加磨炼医术，免得误人性命。\n(当前医术{1}点，每月最多可坐诊{2}次。)",uVar5,uVar4,uVar6,0);
                uVar5 = new SinglePlotData(uVar4,0,1,0,3,"0",1,0,0);
                if (lVar2 != null) {
        LAB_180bb9db0:
                  PlotController.ChangePlot(lVar2,uVar5,0);
                  return;
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar2 = *pStatics_c960;
            if ((this.buildingData != null) &&
               (lVar3 = AreaBuildingData.DataBase(this.buildingData,0)) != null) {
              uVar4 = String.Format("要在此处{0}坐诊吗？附近若有武林人士遭伤病困扰，便会来寻医问药。\n若能悬壶济世，救死扶伤，自是再好不过。",*(uint64 *)(lVar3 + 24),0);
              lVar3 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar3,DAT_181d7c250);
              if (lVar3 != null) {
                FUN_181827900(lVar3,"开诊;SureDoctorWork;;;;Med/20",DAT_181d7c3d0);
                FUN_181827900(lVar3,"还是算了;HideInteractUI",DAT_181d7c3d0);
                uVar5 = new SinglePlotData(uVar4,lVar3,1,0,3,"0",1,0,0);
                if (lVar2 != null) goto LAB_180bb9db0;
              }
            }
          }
        }
    }

    // Token : 0x6000E02
    // RVA   : 0xBB9320   Offset: 0xBB7B20   Length: 0x262
    public void CityQuickTravel()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ede0 = *(int64*)(DAT_181d6ede0 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        if ((*pStatics_df90 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          cVar2 = WorldData.CanQuickTravel(lVar1,0);
          if (!cVar2) {
            lVar1 = **(int64 **)(DAT_181d6c960 + 184);
            uVar3 = FUN_180228420(DAT_181d63120);
            uVar3 = String.Format("眼下身上有些重要任务，不便乘坐马车，还是改日吧。",uVar3,0);
            uVar4 = new SinglePlotData(uVar3,0,1,0,3,"0",1,0,0);
            if (lVar1 != null) {
              PlotController.ChangePlot(lVar1,uVar4,0);
              return;
            }
          }
          else {
            if (*pStatics_ede0 != 0) {
              QuickTravelUIController.ShowQuickTravelUI(*pStatics_ede0,1);
              return;
            }
          }
        }
    }

    // Token : 0x6000E03
    // RVA   : 0xBBCBD0   Offset: 0xBBB3D0   Length: 0x49A
    public void HospitalCureInjury()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint uVar6;
        uint uVar7;
        uint[] local_38 = new uint[4];
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            local_res18[0] = Mathf.FloorToInt(*(uint32 *)(lVar2 + 0x1a0),0);
            uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            if ((*pStatics != 0) &&
               (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
              lVar2 = WorldData.Player(lVar2,0);
              if (lVar2 != null) {
                local_res20[0] = Mathf.FloorToInt(*(uint32 *)(lVar2 + 0x1a4),0);
                uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                if ((*pStatics != 0) &&
                   (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar2 = WorldData.Player(lVar2,0);
                  if (lVar2 != null) {
                    local_38[0] = Mathf.FloorToInt(*(uint32 *)(lVar2 + 0x1a8),0);
                    uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_38);
                    uVar6 = 0;
                    uVar3 = String.Format("本馆医术精湛，深受周遭武林人士及百姓信赖。\n阁下身上若有什么疑难杂症，旧病沉疴，只管交给在下便是。\n（当前伤势：外伤{0}/内伤{1}/中毒{2}）",uVar3,uVar4,uVar5,0);
                    lVar2 = il2cpp_internal(DAT_181d72a30);
                    FUN_180f58a90(lVar2,DAT_181d7c250);
                    if (lVar2 != null) {
                      FUN_181827900(lVar2,"包扎;HospitalCureExternalInjury;;;技能影响:医术",DAT_181d7c3d0);
                      FUN_181827900(lVar2,"调息;HospitalCureInternalInjury;;;技能影响:医术 内功",DAT_181d7c3d0);
                      FUN_181827900(lVar2,"解毒;HospitalCurePoison;;;技能影响:毒术",DAT_181d7c3d0);
                      FUN_181827900(lVar2,"取消;HideInteractUI",DAT_181d7c3d0);
                      uVar7 = 0;
                      uVar4 = BuildingUIController.GenerateBuildingNPCString
                                        (this,"医师",2,0xffffffff,CONCAT44(uVar6,0xffffffff),0);
                      uVar5 = il2cpp_internal(DAT_181d7d2b0);
                      SinglePlotData.ctor
                                (uVar5,uVar3,lVar2,5,uVar4,CONCAT44(uVar7,3),"0",0,0,0);
                      if (lVar1 != null) {
                        PlotController.ChangePlot(lVar1,uVar5,0);
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

    // Token : 0x6000E04
    // RVA   : 0xBBC550   Offset: 0xBBAD50   Length: 0x674
    public void HospitalCureInjuryForce()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint[] local_28 = new uint[4];
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 0x380) < 0) {
        LAB_180bbc811:
              lVar2 = **(int64 **)(DAT_181d6c960 + 184);
              if ((*pStatics != 0) &&
                 (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
                lVar3 = WorldData.Player(lVar3,0);
                if (lVar3 != null) {
                  local_res18[0] = Mathf.FloorToInt(*(uint32 *)(lVar3 + 0x1a0),0);
                  uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                  if ((*pStatics != 0) &&
                     (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
                    lVar3 = WorldData.Player(lVar3,0);
                    if (lVar3 != null) {
                      local_res20[0] = Mathf.FloorToInt(*(uint32 *)(lVar3 + 0x1a4),0);
                      uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                      if ((*pStatics != 0) &&
                         (lVar3 = *(int64 *)(*pStatics + 32)) != null
                         ) {
                        lVar3 = WorldData.Player(lVar3,0);
                        if (lVar3 != null) {
                          local_28[0] = Mathf.FloorToInt(*(uint32 *)(lVar3 + 0x1a8),0);
                          uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_28);
                          uVar4 = String.Format("在疗伤室中，只需消耗门派药材便可治疗自身伤势。\n（当前伤势：外伤{0}/内伤{1}/中毒{2}）",uVar4,uVar5,uVar6,0);
                          lVar3 = il2cpp_internal(DAT_181d72a30);
                          FUN_180f58a90(lVar3,DAT_181d7c250);
                          if (lVar3 != null) {
                            FUN_181827900(lVar3,"包扎;HospitalCureExternalInjuryForce;;;技能影响:医术",DAT_181d7c3d0);
                            FUN_181827900(lVar3,"调息;HospitalCureInternalInjuryForce;;;技能影响:医术 内功",DAT_181d7c3d0);
                            FUN_181827900(lVar3,"解毒;HospitalCurePoisonForce;;;技能影响:毒术",DAT_181d7c3d0);
                            FUN_181827900(lVar3,"取消;HideInteractUI",DAT_181d7c3d0);
                            uVar5 = new SinglePlotData(uVar4,lVar3,1,0,3,"0",1,0,0);
                            if (lVar2 != null) {
                              PlotController.ChangePlot(lVar2,uVar5,0);
                              return;
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
            if ((*pStatics != 0) &&
               (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
              lVar2 = WorldData.Player(lVar2,0);
              if (lVar2 != null) {
                iVar1 = *(int *)(lVar2 + 0x380);
                lVar2 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
                if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
                  if (iVar1 == *(int *)(lVar2 + 112)) {
                    BuildingUIController.HospitalCureInjury(this,0);
                    return;
                  }
                  goto LAB_180bbc811;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000E05
    // RVA   : 0xBC99B0   Offset: 0xBC81B0   Length: 0x458
    public void StartBreakEquipment()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint[] local_res18 = new uint[2];
        if ((*pStatics_df90 != 0) &&
           (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          if (2 < *(int *)(lVar4 + 0x148)) {
            lVar4 = *pStatics_c960;
            if ((*pStatics_df90 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              local_res18[0] = *(uint32 *)(lVar3 + 0x148);
              uVar1 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
              uVar2 = String.Format("本月已拆解过{0}件装备，还需等待弟子将废料清理完毕。",uVar1);
              uVar1 = new SinglePlotData(uVar2,0,1,0,3,"0",1,0,0);
              if (lVar4 != null) goto LAB_180bc9c4d;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = *pStatics_c960;
          uVar1 = FUN_180228420(DAT_181d63120);
          uVar2 = String.Format("凭借我#PlayerForceName#秘法，可拆解成品装备，将其熔炼成锻造材料。\n所得材料会保留装备上的最多三个加成效果。",uVar1,0);
          lVar3 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar3,DAT_181d7c250);
          if (lVar3 != null) {
            FUN_181827900(lVar3,"选择装备;ChooseBreakEquipment",DAT_181d7c3d0);
            FUN_181827900(lVar3,"取消;HideInteractUI");
            uVar1 = new SinglePlotData(uVar2,lVar3,1,0,3,"0",1,0,0);
            if (lVar4 != null) {
        LAB_180bc9c4d:
              PlotController.ChangePlot(lVar4,uVar1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000E06
    // RVA   : 0xBCA270   Offset: 0xBC8A70   Length: 0x458
    public void StartBreakMed()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint[] local_res18 = new uint[2];
        if ((*pStatics_df90 != 0) &&
           (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          if (2 < *(int *)(lVar4 + 0x148)) {
            lVar4 = *pStatics_c960;
            if ((*pStatics_df90 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              local_res18[0] = *(uint32 *)(lVar3 + 0x148);
              uVar1 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
              uVar2 = String.Format("本月已炼化过{0}件丹药，还需等待弟子将废料清理完毕。",uVar1);
              uVar1 = new SinglePlotData(uVar2,0,1,0,3,"0",1,0,0);
              if (lVar4 != null) goto LAB_180bca50d;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = *pStatics_c960;
          uVar1 = FUN_180228420(DAT_181d63120);
          uVar2 = String.Format("凭借我#PlayerForceName#秘法，可将成品丹药炼化为药引。\n所得材料会保留丹药上的最多两个加成效果。",uVar1,0);
          lVar3 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar3,DAT_181d7c250);
          if (lVar3 != null) {
            FUN_181827900(lVar3,"选择丹药;ChooseBreakMed",DAT_181d7c3d0);
            FUN_181827900(lVar3,"取消;HideInteractUI");
            uVar1 = new SinglePlotData(uVar2,lVar3,1,0,3,"0",1,0,0);
            if (lVar4 != null) {
        LAB_180bca50d:
              PlotController.ChangePlot(lVar4,uVar1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000E07
    // RVA   : 0xBC9E10   Offset: 0xBC8610   Length: 0x458
    public void StartBreakFood()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint[] local_res18 = new uint[2];
        if ((*pStatics_df90 != 0) &&
           (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          if (2 < *(int *)(lVar4 + 0x148)) {
            lVar4 = *pStatics_c960;
            if ((*pStatics_df90 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              local_res18[0] = *(uint32 *)(lVar3 + 0x148);
              uVar1 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
              uVar2 = String.Format("本月已重烩过{0}件饮食，还需等待弟子将废料清理完毕。",uVar1);
              uVar1 = new SinglePlotData(uVar2,0,1,0,3,"0",1,0,0);
              if (lVar4 != null) goto LAB_180bca0ad;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = *pStatics_c960;
          uVar1 = FUN_180228420(DAT_181d63120);
          uVar2 = String.Format("凭借我#PlayerForceName#秘法，可将成品饮食重烩为食材。\n所得材料会保留饮食上的最多两个加成效果。",uVar1,0);
          lVar3 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar3,DAT_181d7c250);
          if (lVar3 != null) {
            FUN_181827900(lVar3,"选择饮食;ChooseBreakFood",DAT_181d7c3d0);
            FUN_181827900(lVar3,"取消;HideInteractUI");
            uVar1 = new SinglePlotData(uVar2,lVar3,1,0,3,"0",1,0,0);
            if (lVar4 != null) {
        LAB_180bca0ad:
              PlotController.ChangePlot(lVar4,uVar1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000E08
    // RVA   : 0xBCAB70   Offset: 0xBC9370   Length: 0x5D
    public void StartCraftEquipment()
    {
        var pStatics = *(int64*)(DAT_181d95650 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,0,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E09
    // RVA   : 0xBCAE90   Offset: 0xBC9690   Length: 0x5D
    public void StartEnhanceEquipment()
    {
        var pStatics = *(int64*)(DAT_181d9e5d0 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,0,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E0A
    // RVA   : 0xBCAD10   Offset: 0xBC9510   Length: 0x5F
    public void StartCraftMed()
    {
        var pStatics = *(int64*)(DAT_181d95650 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,1,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E0B
    // RVA   : 0xBCB030   Offset: 0xBC9830   Length: 0x5F
    public void StartEnhanceMed()
    {
        var pStatics = *(int64*)(DAT_181d9e5d0 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,1,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E0C
    // RVA   : 0xBCAC40   Offset: 0xBC9440   Length: 0x5F
    public void StartCraftFood()
    {
        var pStatics = *(int64*)(DAT_181d95650 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,2,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E0D
    // RVA   : 0xBCAF60   Offset: 0xBC9760   Length: 0x5F
    public void StartEnhanceFood()
    {
        var pStatics = *(int64*)(DAT_181d9e5d0 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,2,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E0E
    // RVA   : 0xBCADD0   Offset: 0xBC95D0   Length: 0x54
    public void StartCraftPoison()
    {
        var pStatics = *(int64*)(DAT_181d955c8 + 184);
        if (*pStatics != 0) {
          CraftPoisonUIController.OpenCraftPoisonUI
                    (*pStatics,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E0F
    // RVA   : 0xBCAB10   Offset: 0xBC9310   Length: 0x5D
    public void StartCraftEquipmentMoney()
    {
        var pStatics = *(int64*)(DAT_181d95650 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,0,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E10
    // RVA   : 0xBCAE30   Offset: 0xBC9630   Length: 0x5D
    public void StartEnhanceEquipmentMoney()
    {
        var pStatics = *(int64*)(DAT_181d9e5d0 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,0,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E11
    // RVA   : 0xBCACA0   Offset: 0xBC94A0   Length: 0x60
    public void StartCraftMedMoney()
    {
        var pStatics = *(int64*)(DAT_181d95650 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,1,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E12
    // RVA   : 0xBCAFC0   Offset: 0xBC97C0   Length: 0x60
    public void StartEnhanceMedMoney()
    {
        var pStatics = *(int64*)(DAT_181d9e5d0 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,1,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E13
    // RVA   : 0xBCABD0   Offset: 0xBC93D0   Length: 0x60
    public void StartCraftFoodMoney()
    {
        var pStatics = *(int64*)(DAT_181d95650 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,2,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E14
    // RVA   : 0xBCAEF0   Offset: 0xBC96F0   Length: 0x60
    public void StartEnhanceFoodMoney()
    {
        var pStatics = *(int64*)(DAT_181d9e5d0 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,2,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E15
    // RVA   : 0xBCAD70   Offset: 0xBC9570   Length: 0x54
    public void StartCraftPoisonMoney()
    {
        var pStatics = *(int64*)(DAT_181d955c8 + 184);
        if (*pStatics != 0) {
          CraftPoisonUIController.OpenCraftPoisonUI
                    (*pStatics,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E16
    // RVA   : 0xBBB7D0   Offset: 0xBB9FD0   Length: 0xAB
    public void GiveTreasureToGovern()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.GiveTreasureToGovern(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000E17
    // RVA   : 0xBC6D20   Offset: 0xBC5520   Length: 0x534
    public void SpeCure()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffffa8;
        uint uVar7;
        ulong in_stack_ffffffffffffffb0;
        uint uVar8;
        uVar7 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        uVar8 = (uint32)((uint64)in_stack_ffffffffffffffb0 >> 32);
        if (((*pStatics_df90 != 0) &&
            (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar1 = WorldData.Player(lVar1,0)) != null) {
          fVar6 = (float)HeroData.GetTotalInjury(lVar1,0);
          if (fVar6 != 0.0) {
            if (((*pStatics_df90 != 0) &&
                (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
               (lVar1 = WorldData.Player(lVar1,0)) != null) {
              fVar6 = (float)HeroData.GetTotalInjury(lVar1,0);
              local_res18[0] = Mathf.RoundToInt((fVar6 * 0.02 + 1.0) * 1000.0,0);
              lVar1 = *pStatics_c960;
              local_res20[0] = local_res18[0];
              uVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
              uVar2 = String.Format("本寺以医术闻名于世，无论大侠伤重几何，只需在此疗养三日便可痊愈。\n以大侠当前的伤势，在此处治愈需消耗{0}两银钱。",uVar2,0);
              lVar4 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar4,DAT_181d7c250);
              uVar3 = Int32.ToString(local_res18,0);
              uVar3 = String.Concat("治愈;SpeCureStart;;0/",uVar3,0);
              if (lVar4 != null) {
                FUN_181827900(lVar4,uVar3,DAT_181d7c3d0);
                FUN_181827900(lVar4,"还是算了;HideInteractUI",DAT_181d7c3d0);
                uVar8 = 0;
                uVar3 = BuildingUIController.GenerateBuildingNPCString
                                  (this,"僧众",10,0xffffffff,CONCAT44(uVar7,0xffffffff),0);
                uVar5 = new SinglePlotData(uVar2,lVar4,5,uVar3,CONCAT44(uVar8,3),"0",0,0,0);
                if (lVar1 != null) {
                  PlotController.ChangePlot(lVar1,uVar5,0);
                  return;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar1 = *pStatics_c960;
          uVar2 = FUN_180228420(DAT_181d63120);
          uVar2 = String.Format("我目前并无伤势在身，何必庸人自扰。",uVar2,0);
          uVar3 = new SinglePlotData(uVar2,0,1,0,CONCAT44(uVar8,3),"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000E18
    // RVA   : 0xBC7EA0   Offset: 0xBC66A0   Length: 0x484
    public void SpeReduceBadFame()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffffa8;
        uint uVar6;
        ulong in_stack_ffffffffffffffb0;
        uint uVar7;
        uVar6 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        uVar7 = (uint32)((uint64)in_stack_ffffffffffffffb0 >> 32);
        if ((*pStatics_df90 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          if (*(int *)(lVar1 + 0x130) < 1) {
            if (this.buildingData != null) {
              local_res18[0] =
                   Mathf.RoundToInt(((float)this.buildingData.lv * 0.5 + 1.0) *
                                     500.0,0);
              lVar1 = *pStatics_c960;
              local_res20[0] = local_res18[0];
              uVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
              uVar2 = String.Format("少侠若在此处捐赠银两，修缮祠堂或是分发给穷苦百姓，便能削减在江湖中留下的恶名。\n以少侠当前的名望，在此处布施三日，需消耗{0}两银钱。",uVar2,0);
              lVar3 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar3,DAT_181d7c250);
              uVar4 = Int32.ToString(local_res18,0);
              uVar4 = String.Concat("布施;SpeReduceBadFameStart;;0/",uVar4,0);
              if (lVar3 != null) {
                FUN_181827900(lVar3,uVar4,DAT_181d7c3d0);
                FUN_181827900(lVar3,"还是算了;HideInteractUI",DAT_181d7c3d0);
                uVar7 = 0;
                uVar4 = BuildingUIController.GenerateBuildingNPCString
                                  (this,"名士",0xfffffffa,0xffffffff,CONCAT44(uVar6,0xffffffff),
                                   0);
                uVar5 = new SinglePlotData(uVar2,lVar3,5,uVar4,CONCAT44(uVar7,3),"0",0,0,0);
                if (lVar1 != null) {
                  PlotController.ChangePlot(lVar1,uVar5,0);
                  return;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar1 = *pStatics_c960;
          uVar2 = FUN_180228420(DAT_181d63120);
          uVar2 = String.Format("这个月已经捐出许多银两，\n若是再大肆布施，只怕落得个虚仁假义的名声。",uVar2,0);
          uVar4 = new SinglePlotData(uVar2,0,1,0,CONCAT44(uVar7,3),"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000E19
    // RVA   : 0xBC8C70   Offset: 0xBC7470   Length: 0xD3A
    public void SpeStartParty()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        long lVar2;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        float fVar9;
        float fVar10;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffff78;
        uint uVar11;
        ulong in_stack_ffffffffffffff80;
        uint uVar13;
        ulong uVar12;
        uint local_58;
        float local_54;
        float local_50;
        uint32 local_4c;
        uint32 local_48;
        float local_44 [7];
        uVar11 = (uint32)((uint64)in_stack_ffffffffffffff78 >> 32);
        uVar1 = (uint32)((uint64)in_stack_ffffffffffffff80 >> 32);
        if (((*pStatics != 0) &&
            (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar2 = WorldData.Player(lVar2,0)) != null) {
          if (*(float *)(lVar2 + 0x1c4) <= 200.0 && *(float *)(lVar2 + 0x1c4) != 200.0) {
            lVar2 = **(int64 **)(DAT_181d6c960 + 184);
            uVar6 = new SinglePlotData("需要至少200点声望才能在此举办宴会",0,1,0,CONCAT44(uVar1,3),"0",1,0,0);
            if (lVar2 != null) {
              PlotController.ChangePlot(lVar2,uVar6,0);
              return;
            }
          }
          else {
            if ((*pStatics != 0) &&
               (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
              if (*(int *)(lVar2 + 0x134) < 1) {
                if (this.buildingData != null) {
                  uVar1 = Mathf.RoundToInt(((float)this.buildingData.lv * 0.5 +
                                            1.0) * 800.0,0);
                  lVar2 = il2cpp_internal(DAT_181d72a30);
                  FUN_180f58a90(lVar2,DAT_181d7c250);
                  plVar3 = (int64 *)FUN_1800d60b0(DAT_181d7f180,7);
                  lVar5 = *(int64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 24);
                  if (lVar5 != null) {
                    if (*(uint32 *)(lVar5 + 24) < 5) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar5 = *(int64 *)(*(int64 *)(lVar5 + 16) + 64);
                    if (plVar3 != (int64 *)0) {
                      if ((lVar5 != null) &&
                         (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64))) == null)
                      {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      if ((int)plVar3[3] == 0) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      plVar3[4] = lVar5;
                      il2cpp_internal(plVar3 + 4,lVar5);
                      lVar5 = GlobalData.GetNumText(5);
                      if ((lVar5 != null) &&
                         (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64))) == null)
                      {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      if (*(uint32 *)(plVar3 + 3) < 2) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      plVar3[5] = lVar5;
                      il2cpp_internal(plVar3 + 5,lVar5);
                      local_res18[0] = 0;
                      lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                      if ((lVar5 != null) &&
                         (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64))) == null)
                      {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      if (*(uint32 *)(plVar3 + 3) < 3) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      plVar3[6] = lVar5;
                      il2cpp_internal(plVar3 + 6,lVar5);
                      local_res20[0] = 4;
                      lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                      if ((lVar5 != null) &&
                         (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64))) == null)
                      {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      if (*(uint32 *)(plVar3 + 3) < 4) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      plVar3[7] = lVar5;
                      il2cpp_internal(plVar3 + 7,lVar5);
                      local_58 = uVar1;
                      lVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_58);
                      if ((lVar5 != null) &&
                         (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64))) == null)
                      {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      if (*(uint32 *)(plVar3 + 3) < 5) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      plVar3[8] = lVar5;
                      il2cpp_internal(plVar3 + 8,lVar5);
                      fVar9 = (float)PlotController.GetPartyLvBaseScore(4);
                      if (this.buildingData != null) {
                        local_54 = (float)AreaBuildingData.GetExtraPartyScore
                                                    (this.buildingData,0);
                        local_54 = local_54 + fVar9;
                        lVar5 = il2cpp_value_box(DAT_181d7d0b8,&local_54);
                        if ((lVar5 != null) &&
                           (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64)), lVar4 == null
                           )) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar6,0);
                        }
                        if (*(uint32 *)(plVar3 + 3) < 6) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar6,0);
                        }
                        plVar3[9] = lVar5;
                        il2cpp_internal(plVar3 + 9,lVar5);
                        fVar9 = (float)PlotController.GetPartyLvBaseRate(4);
                        if (this.buildingData != null) {
                          fVar10 = (float)AreaBuildingData.GetExtraPartyRate
                                                    (this.buildingData,0);
                          local_50 = (fVar10 + fVar9) * 100.0;
                          lVar5 = il2cpp_value_box(DAT_181d7d0b8,&local_50);
                          if ((lVar5 != null) &&
                             (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar3 + 64)),
                             lVar4 == null)) {
                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar6,0);
                          }
                          if (*(uint32 *)(plVar3 + 3) < 7) {
                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar6,0);
                          }
                          plVar3[10] = lVar5;
                          il2cpp_internal(plVar3 + 10,lVar5);
                          uVar6 = String.Format("{0}宴会({1}日);SpeStartPartySure;{2}-{3};0/{4};基础评分{5}\n基础加成{6}%",plVar3,0);
                          if (lVar2 != null) {
                            FUN_181827900(lVar2,uVar6,DAT_181d7c3d0);
                            FUN_181827900(lVar2,"还是算了;HideInteractUI",DAT_181d7c3d0);
                            lVar5 = FUN_18046c440(0);
                            uVar6 = new PlotData(0);
                            if (lVar5 != null) {
                              *(uint64 *)(lVar5 + 0x108) = uVar6;
                              lVar5 = FUN_18046c440(0);
                              if ((lVar5 != null) && (*(int64 *)(lVar5 + 0x108) != 0)) {
                                lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x108) + 64);
                                uVar13 = 0;
                                uVar6 = BuildingUIController.GenerateBuildingNPCString
                                                  (this,"豪商",0xfffffffd,0xffffffff,
                                                   CONCAT44(uVar11,0xffffffff),0);
                                uVar7 = il2cpp_internal(DAT_181d7d2b0);
                                uVar12 = CONCAT44(uVar13,3);
                                SinglePlotData.ctor
                                          (uVar7,"落魄江湖载酒行，楚腰纤细掌中轻。十年一觉扬州梦，赢得青楼薄幸名。\n这烟花柳巷，自古以来便是名人雅士宴饮会客的不二场所。",0,5,uVar6,uVar12,"0",0,0,0);
                                uVar11 = (uint32)((uint64)uVar12 >> 32);
                                if (lVar5 != null) {
                                  FUN_181827900(lVar5,uVar7,DAT_181d79a58);
                                  lVar5 = FUN_18046c440(0);
                                  if ((lVar5 != null) && (*(int64 *)(lVar5 + 0x108) != 0)) {
                                    lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x108) + 64);
                                    plVar3 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
                                    local_4c = uVar1;
                                    lVar4 = il2cpp_value_box(DAT_181d5b2f8,&local_4c);
                                    if (plVar3 != (int64 *)0) {
                                      if ((lVar4 != null) &&
                                         (lVar8 = il2cpp_internal(lVar4,*(uint64 *)
                                                                             (*plVar3 + 64)), lVar8 == null
                                         )) {
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
                                      if (this.buildingData != null) {
                                        lVar4 = AreaBuildingData.Name(this.buildingData,0,0);
                                        if ((lVar4 != null) &&
                                           (lVar8 = il2cpp_internal(lVar4,*(uint64 *)
                                                                               (*plVar3 + 64)),
                                           lVar8 == null)) {
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
                                        if (this.buildingData != null) {
                                          lVar4 = GlobalData.GetNumText
                                                            (*(uint32 *)
                                                              (this.buildingData + 20),0);
                                          if ((lVar4 != null) &&
                                             (lVar8 = il2cpp_internal(lVar4,*(uint64 *)
                                                                                 (*plVar3 + 64)),
                                             lVar8 == null)) {
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
                                          if (this.buildingData != null) {
                                            local_48 = AreaBuildingData.GetExtraPartyScore
                                                                 (this.buildingData,0);
                                            lVar4 = il2cpp_value_box(DAT_181d7d0b8,&local_48);
                                            if ((lVar4 != null) &&
                                               (lVar8 = il2cpp_internal(lVar4,*(uint64 *)
                                                                                   (*plVar3 + 64)),
                                               lVar8 == null)) {
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
                                            if (this.buildingData != null) {
                                              local_44[0] = (float)AreaBuildingData.GetExtraPartyRate
                                                                             (*(int64 *)
                                                                               (this + 24),0);
                                              local_44[0] = local_44[0] * 100.0;
                                              lVar4 = Single.ToString(local_44,"f0",0);
                                              if ((lVar4 != null) &&
                                                 (lVar8 = il2cpp_internal(lVar4,*(uint64 *)
                                                                                     (*plVar3 + 64)),
                                                 lVar8 == null)) {
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
                                              uVar6 = String.Format("少侠若想在此举办一场奢华宴会，纵情享乐，会见贵客，非得花上{0}两银钱不可。\n(当前{1}为等级{2}，可提升宴会{3}点基础评分和{4}%的评分加成)",plVar3,0);
                                              uVar7 = il2cpp_internal(DAT_181d7d2b0);
                                              SinglePlotData.ctor
                                                        (uVar7,uVar6,lVar2,0,0,CONCAT44(uVar11,3),
                                                         "0",0,0,0);
                                              if (lVar5 != null) {
                                                FUN_181827900(lVar5,uVar7,DAT_181d79a58);
                                                lVar2 = FUN_18046c440(0);
                                                lVar5 = FUN_18046c440(0);
                                                if ((lVar5 != null) && (lVar2 != null)) {
                                                  PlotController.ChangePlot
                                                            (lVar2,*(uint64 *)(lVar5 + 0x108),0);
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
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar2 = FUN_18046c440(0);
              uVar6 = new SinglePlotData("这个月已经大肆宴饮一番，若是天天在这烟花柳巷中流连，只怕为江湖中人耻笑。",0,1,0,CONCAT44(uVar1,3),"0",1,0,0);
              if (lVar2 != null) {
                PlotController.ChangePlot(lVar2,uVar6,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000E1A
    // RVA   : 0xBBB790   Offset: 0xBB9F90   Length: 0x36
    public int GetSpeTalentPoint()
    {
        if (this.buildingData == null) {
          return 1;
        }
        return (int)((float)this.buildingData.lv * 0.5 + 1.0);
    }

    // Token : 0x6000E1B
    // RVA   : 0xBC7260   Offset: 0xBC5A60   Length: 0x54D
    public void SpeGetTalentPoint()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        byte[] auVar7 = new byte[16];
        byte[] auVar8 = new byte[16];
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffff98;
        uint uVar9;
        ulong in_stack_ffffffffffffffa0;
        uint uVar10;
        int[] local_38 = new int[4];
        uint64 extraout_XMM0_Qb;
        uVar9 = (uint32)((uint64)in_stack_ffffffffffffff98 >> 32);
        uVar10 = (uint32)((uint64)in_stack_ffffffffffffffa0 >> 32);
        if ((*pStatics_df90 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          if (*(int *)(lVar1 + 0x138) < 1) {
            if (((*pStatics_df90 != 0) &&
                (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
               (lVar1 = WorldData.Player(lVar1,0)) != null) {
              auVar7._0_8_ = HeroData.GetTotalTagPoint(lVar1,0);
              auVar7._8_8_ = extraout_XMM0_Qb;
              auVar8._4_12_ = auVar7._4_12_;
              auVar8._0_4_ = ((float)auVar7._0_8_ * 0.05 + 1.0) * 500.0;
              local_res18[0] = Mathf.RoundToInt(auVar8._0_8_,0);
              lVar1 = *pStatics_c960;
              local_res20[0] = local_res18[0];
              uVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
              if (this.buildingData == null) {
                fVar6 = 0.0;
              }
              else {
                fVar6 = (float)this.buildingData.lv * 0.5;
              }
              local_38[0] = (int)(fVar6 + 1.0);
              uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_38);
              uVar2 = String.Format("这莫高窟虽地处幽僻，却藏有经书典籍无数。\n悬崖壁上的石窟亦是潜心闭关，修炼天赋的不二之选。\n以少侠当前之天赋，在此处闭关十五日需消耗{0}两银钱，预计可获得{1}点天赋。",uVar2,uVar3,0);
              lVar4 = il2cpp_internal(DAT_181d72a30);
              FUN_180f58a90(lVar4,DAT_181d7c250);
              uVar3 = Int32.ToString(local_res18,0);
              uVar3 = String.Concat("闭关;SpeGetTalentPointStart;;0/",uVar3,0);
              if (lVar4 != null) {
                FUN_181827900(lVar4,uVar3,DAT_181d7c3d0);
                FUN_181827900(lVar4,"还是算了;HideInteractUI",DAT_181d7c3d0);
                uVar10 = 0;
                uVar3 = BuildingUIController.GenerateBuildingNPCString
                                  (this,"高僧",10,0xffffffff,CONCAT44(uVar9,0xffffffff),0);
                uVar5 = new SinglePlotData(uVar2,lVar4,5,uVar3,CONCAT44(uVar10,3),"0",0,0,0);
                if (lVar1 != null) {
                  PlotController.ChangePlot(lVar1,uVar5,0);
                  return;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar1 = *pStatics_c960;
          uVar2 = FUN_180228420(DAT_181d63120);
          uVar2 = String.Format("这个月已经潜心闭关过，还需要再积累些实践感悟才是。",uVar2,0);
          uVar3 = new SinglePlotData(uVar2,0,1,0,CONCAT44(uVar10,3),"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000E1C
    // RVA   : 0xBBB5A0   Offset: 0xBB9DA0   Length: 0xF8
    public int GetSpeRemoveSkillCost()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          lVar1 = WorldData.Player(lVar1,0);
          if ((lVar1 != null) && (*(int64 *)(lVar1 + 0x260) != 0)) {
            Mathf.RoundToInt(((float)*(int *)(*(int64 *)(lVar1 + 0x260) + 24) * 0.1 + 1.0) * 500.0,0
                             );
            return;
          }
        }
    }

    // Token : 0x6000E1D
    // RVA   : 0xBC8330   Offset: 0xBC6B30   Length: 0x356
    public void SpeRemoveSkill()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        uint[] local_res18 = new uint[2];
        ulong in_stack_ffffffffffffffb8;
        uint uVar6;
        uint uVar7;
        uVar6 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x260) != 0)) {
            local_res18[0] =
                 Mathf.RoundToInt(((float)*(int *)(*(int64 *)(lVar2 + 0x260) + 24) * 0.1 + 1.0) *
                                   500.0,0);
            uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            uVar3 = String.Format("在这石窟之中与世隔绝，酣然入梦，足以明心见性，忘却前尘旧事。\n少侠只需耗费{0}银两在此闭关十日，便可遗忘一门<b>零重修为</b>的武学。",uVar3,0);
            lVar2 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar2,DAT_181d7c250);
            if (lVar2 != null) {
              FUN_181827900(lVar2,"选择武学;SpeRemoveSkillChoose",DAT_181d7c3d0);
              FUN_181827900(lVar2,"还是算了;HideInteractUI",DAT_181d7c3d0);
              uVar7 = 0;
              uVar4 = BuildingUIController.GenerateBuildingNPCString
                                (this,"高僧",10,0xffffffff,CONCAT44(uVar6,0xffffffff),0);
              uVar5 = new SinglePlotData(uVar3,lVar2,5,uVar4,CONCAT44(uVar7,3),"0",0,0,0);
              if (lVar1 != null) {
                PlotController.ChangePlot(lVar1,uVar5,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000E1E
    // RVA   : 0xBBB6A0   Offset: 0xBB9EA0   Length: 0xE2
    public int GetSpeRemoveTagCost()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        float fVar2;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          lVar1 = WorldData.Player(lVar1,0);
          if (lVar1 != null) {
            fVar2 = (float)HeroData.GetTotalTagPoint(lVar1,0);
            Mathf.RoundToInt((fVar2 * 0.05 + 1.0) * 2000.0,0);
            return;
          }
        }
    }

    // Token : 0x6000E1F
    // RVA   : 0xBC8690   Offset: 0xBC6E90   Length: 0x5D3
    public void SpeRemoveTag()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        int iVar8;
        float fVar9;
        uint[] local_res18 = new uint[2];
        ulong in_stack_ffffffffffffffb8;
        uint uVar10;
        uint uVar11;
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        iVar8 = 0;
        while( true ) {
          if ((*pStatics == 0) ||
             (lVar3 = *(int64 *)(*pStatics + 32)) == null) break;
          lVar3 = WorldData.Player(lVar3,0);
          uVar10 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x368) == 0)) break;
          if (*(int *)(*(int64 *)(lVar3 + 0x368) + 24) <= iVar8) {
            if (lVar2 != null) {
              FUN_181827900(lVar2,"还是算了;HideInteractUI",DAT_181d7c3d0);
              lVar3 = **(int64 **)(DAT_181d6c960 + 184);
              if ((*pStatics != 0) &&
                 (lVar6 = *(int64 *)(*pStatics + 32)) != null) {
                lVar6 = WorldData.Player(lVar6,0);
                if (lVar6 != null) {
                  fVar9 = (float)HeroData.GetTotalTagPoint(lVar6,0);
                  local_res18[0] = Mathf.RoundToInt((fVar9 * 0.05 + 1.0) * 2000.0,0);
                  uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                  uVar4 = String.Format("在这石窟之中与世隔绝，酣然入梦，足以明心见性，忘却前尘旧事。\n少侠只需耗费{0}银两在此闭关三十日，便可遗忘一个天赋。",uVar4,0);
                  uVar11 = 0;
                  uVar5 = BuildingUIController.GenerateBuildingNPCString
                                    (this,"高僧",10,0xffffffff,CONCAT44(uVar10,0xffffffff),0);
                  uVar7 = new SinglePlotData(uVar4,lVar2,5,uVar5,CONCAT44(uVar11,3),"0",0,0,0);
                  if (lVar3 != null) {
                    PlotController.ChangePlot(lVar3,uVar7,0);
                    return;
                  }
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = FUN_18046c0a0(0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) break;
          lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x368) == 0)) break;
          lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x368),iVar8,DAT_181d64f78);
          if (lVar3 == null) break;
          cVar1 = HeroTagData.IsPermanentTag(lVar3);
          if (cVar1) {
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) {
        LAB_180bc8c58:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x368) == 0)) goto LAB_180bc8c58;
            lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x368),iVar8,DAT_181d64f78);
            if (lVar3 == null) goto LAB_180bc8c58;
            lVar3 = HeroTagData.DataBase(lVar3,0);
            if (lVar3 == null) goto LAB_180bc8c58;
            uVar4 = HeroTagDataBase.Name(lVar3,0);
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) goto LAB_180bc8c58;
            lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x368) == 0)) goto LAB_180bc8c58;
            lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x368),iVar8,DAT_181d64f78);
            if (lVar3 == null) goto LAB_180bc8c58;
            local_res18[0] = *(uint32 *)(lVar3 + 16);
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            uVar4 = String.Format("遗忘“{0}”;SpeRemoveTagChoose;{1}",uVar4,uVar5,0);
            if (lVar2 == null) goto LAB_180bc8c58;
            FUN_181827900(lVar2,uVar4,DAT_181d7c3d0);
          }
          iVar8 = iVar8 + 1;
        }
    }

    // Token : 0x6000E20
    // RVA   : 0xBCA6D0   Offset: 0xBC8ED0   Length: 0x43D
    public void StartChallengeGhostGatePlot()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        int iVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        int[] local_res18 = new int[2];
        if (((*pStatics_df90 != 0) &&
            (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 232)) != null) {
          iVar2 = PlotEventLogData.GetInt(lVar1,"GhostGateLv");
          if (iVar2 < 41) {
            uVar4 = "在鬼门关孤身挑战强敌，于绝境之中磨炼心性与体魄，\n如此方能探求#PlayerForceName#修罗武道之神髓。\n当前鬼门关试炼为第{0}层，要进行挑战吗？";
            if (iVar2 == 40) {
              uVar4 = "历时多日，终于闯到鬼门关最后一层。\n此战需以一己之力，挑战十名绝顶高手，\n若未做好万全之准备，还是不要贸然尝试的好。";
            }
            lVar1 = *pStatics_c960;
            local_res18[0] = iVar2;
            uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            uVar4 = String.Format(uVar4,uVar3,0);
            lVar5 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar5,DAT_181d7c250);
            uVar3 = FUN_180228420(DAT_181d63120);
            uVar3 = String.Format("开始试炼;StartChallengeGhostGateFight",uVar3,0);
            if (lVar5 != null) {
              FUN_181827900(lVar5,uVar3,DAT_181d7c3d0);
              FUN_181827900(lVar5,"还是算了;HideInteractUI");
              uVar3 = new SinglePlotData(uVar4,lVar5,1,0,3,"0",1,0,0);
              if (lVar1 != null) {
                PlotController.ChangePlot(lVar1,uVar3,0);
                return;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar1 = *pStatics_c960;
          uVar4 = FUN_180228420(DAT_181d63120);
          uVar4 = String.Format("我已闯过阎罗殿最后一层，无需再继续试炼了。",uVar4);
          uVar3 = new SinglePlotData(uVar4,0,1,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000E21
    // RVA   : 0xBC5BA0   Offset: 0xBC43A0   Length: 0xAC
    public void ShowForceSpeResearch()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181da2fa0 + 184) + 56);
        if (lVar1 != null) {
          ForceSpeResearchUIController.ShowForceSpeResearchUI(lVar1,0);
          return;
        }
    }

    // Token : 0x6000E22
    // RVA   : 0xBC6B50   Offset: 0xBC5350   Length: 0x46
    public void ShowSpePoison()
    {
        var pStatics = *(int64*)(DAT_181d7f130 + 184);
        if (*pStatics != 0) {
          SpePoisonController.ShowSpePoisonUI(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000E23
    // RVA   : 0xBCD4D0   Offset: 0xBCBCD0   Length: 0xAB
    public void StartSpeBookStorage()
    {
        var pStatics = *(int64*)(DAT_181d7efb0 + 184);
        if (*pStatics != 0) {
          SpeBookStorageController.ShowSpeBookStorageUI(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000E24
    // RVA   : 0xBC6BA0   Offset: 0xBC53A0   Length: 0x46
    public void ShowSpeSummonResearch()
    {
        var pStatics = *(int64*)(DAT_181d7f2b0 + 184);
        if (*pStatics != 0) {
          SpeSummonResearchController.ShowSpeSummonResearchUI(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000E25
    // RVA   : 0xBCD580   Offset: 0xBCBD80   Length: 0x46
    public void StartSpeEnhanceEquip()
    {
        var pStatics = *(int64*)(DAT_181d7f030 + 184);
        if (*pStatics != 0) {
          SpeEnhanceEquipController.ShowSpeEnhanceEquipUI(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000E26
    // RVA   : 0xBCFDE0   Offset: 0xBCE5E0   Length: 0xAB
    public void StudyMartialClubSkill()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.StudyMartialClubSkillStart(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000E27
    // RVA   : 0xBD2AC0   Offset: 0xBD12C0   Length: 0x15C
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"天下熙熙皆为利来，这次一定要大赚特赚一笔！",DAT_181d7c3d0);
          FUN_181827900(lVar1,"春种一粒粟，秋收万颗子。",DAT_181d7c3d0);
          FUN_181827900(lVar1,"此地的树木苍翠葱郁，想必能制成优良的木材。",DAT_181d7c3d0);
          FUN_181827900(lVar1,"活动活动筋骨，准备大干一场吧。",DAT_181d7c3d0);
          FUN_181827900(lVar1,"得好好参照医书，辨认出各种药材才行。",DAT_181d7c3d0);
          FUN_181827900(lVar1,"必须把#AreaForceName#的声威向全武林传扬开来！",DAT_181d7c3d0);
          this.ProduceBuildingWorkText = lVar1;
          FUN_18044ef50(this,0);
          return;
        }
    }

    // Token : 0x6000E28
    // RVA   : 0xBD2780   Offset: 0xBD0F80   Length: 0x332
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8ee60 + 184);
        long lVar1;
        **(uint32 **)(DAT_181d8ee60 + 184) = 0x3e99999a;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"盗窃",DAT_181d7c3d0);
          FUN_181827900(lVar1,"抢劫",DAT_181d7c3d0);
          FUN_181827900(lVar1,"用毒",DAT_181d7c3d0);
          FUN_181827900(lVar1,"投药",DAT_181d7c3d0);
          FUN_181827900(lVar1,"博骰",DAT_181d7c3d0);
          FUN_181827900(lVar1,"恶名",DAT_181d7c3d0);
          FUN_181827900(lVar1,"宴会",DAT_181d7c3d0);
          FUN_181827900(lVar1,"宴饮",DAT_181d7c3d0);
          FUN_181827900(lVar1,"分舵管理",DAT_181d7c3d0);
          FUN_181827900(lVar1,"任教",DAT_181d7c3d0);
          FUN_181827900(lVar1,"踢馆",DAT_181d7c3d0);
          FUN_181827900(lVar1,"布施",DAT_181d7c3d0);
          plVar2 = (int64 *)(pStatics + 16);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar1,DAT_181d7c250);
          if (lVar1 != null) {
            FUN_181827900(lVar1,"简陋",DAT_181d7c3d0);
            FUN_181827900(lVar1,"朴素",DAT_181d7c3d0);
            FUN_181827900(lVar1,"普通",DAT_181d7c3d0);
            FUN_181827900(lVar1,"精美",DAT_181d7c3d0);
            FUN_181827900(lVar1,"奢华",DAT_181d7c3d0);
            plVar2 = (int64 *)(pStatics + 24);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            return;
          }
        }
    }

}
