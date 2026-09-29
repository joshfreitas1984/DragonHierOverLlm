// ============================================================
// Type  : BuildingUIController
// Token : 0x20001B0
// ============================================================

public class BuildingUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BBB
    public AreaBuildingData buildingData;

    // Token: 0x4000BBC
    public GameObject buildingButtonGrid;

    // Token: 0x4000BBD
    public GameObject buildingButtonPrefab;

    // Token: 0x4000BBE
    public AreaBuildingChoice buildingChoiceSelected;

    // Token: 0x4000BBF
    private GameObject newButton;

    // Token: 0x4000BC0
    public static float InsideBuildingVolumn;

    // Token: 0x4000BC1
    private float refreshTime;

    // Token: 0x4000BC2
    private static BuildingUIController _instance;

    // Token: 0x4000BC3
    private AreaBuildingData targetBuildingData;

    // Token: 0x4000BC4
    private Vector3 showPosition;

    // Token: 0x4000BC5
    public static List<string> CheckHideBuildingChoice;

    // Token: 0x4000BC6
    public static List<string> PartyLvName;

    // Token: 0x4000BC7
    private List<string> ProduceBuildingWorkText;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000DD1
    // RVA   : 0xB7DB70   Offset: 0xB7CF70   Length: 0x58
    public static BuildingUIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181db4020 + 184) + 8);
    }

    // Token : 0x6000DD2
    // RVA   : 0xB61480   Offset: 0xB60880   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181db4020 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000DD3
    // RVA   : 0xB78490   Offset: 0xB77890   Length: 0x12
    private void Start()
    {
        void FUN_180b78490(int64 this)
        {
        this.buildingData = 0;
    }

    // Token : 0x6000DD4
    // RVA   : 0xB7D030   Offset: 0xB7C430   Length: 0x97
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
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

    // Token : 0x6000DD5
    // RVA   : 0xB642D0   Offset: 0xB636D0   Length: 0x2AE
    public void EnterBuilding(AreaBuildingData _targetBuildingData, Vector3 _showPosition)
    {
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
        LAB_180b64551:
            local_18 = this.showPosition;
            local_10 = *(uint32 *)(this + 88);
            BuildingUIController.ShowBuildingUI(this,this.targetBuildingData,&local_18,0);
            return;
          }
          if (((GameController._instance != null) &&
              (lVar3 = GameController._instance.worldData) != null) &&
             (lVar3 = WorldData.Player(lVar3,0)) != null) {
            iVar2 = HeroData.GetBountyPirce(lVar3,0);
            if (iVar2 < 1) goto LAB_180b64551;
            lVar3 = FUN_18046c400(0);
            lVar4 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar4,DAT_181da3bf0);
            if (lVar4 != null) {
              FUN_18181e6b0(lVar4,"冒险一试;PlotSureEnterBuilding",DAT_181da3d70);
              FUN_18181e6b0(lVar4,"还是算了;HideInteractUI",DAT_181da3d70);
              uVar5 = new SinglePlotData("眼下正被官差通缉，若是贸然进入官府重地，很可能会被抓捕。\n还需三思而后行才是......",lVar4,1,0,3,"0",1,0,0);
              if (lVar3 != null) {
                PlotController.AddPlot(lVar3,uVar5,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000DD6
    // RVA   : 0xB7CEC0   Offset: 0xB7C2C0   Length: 0x2C
    public void SureEnterBuilding()
    {
        ulong local_18;
        uint local_10;
        local_18 = this.showPosition;
        local_10 = *(uint32 *)(this + 88);
        BuildingUIController.ShowBuildingUI(local_18,this.targetBuildingData,&local_18,0);
    }

    // Token : 0x6000DD7
    // RVA   : 0xB6E200   Offset: 0xB6D600   Length: 0x1353
    public void ShowBuildingUI(AreaBuildingData targetBuildingData, Vector3 showPosition)
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
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
        if ((*pStatics_2ee8 == 0) ||
           (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null)
        throw; // [null/range check failed]
        GameObject.SetActive(lVar3,1,0);
        if (((((*pStatics_2ee8 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
             (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
            ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"BuildingButtonScrollView",0)) == null))) ||
           (lVar3 = Component.GetComponent(lVar3,DAT_181d951f8)) == null) throw; // [null/range check failed]
        Behaviour.set_enabled(lVar3,0,0);
        if (((*pStatics_2ee8 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
           (lVar3 = GameObject.get_transform(lVar3,0)) == null) throw; // [null/range check failed]
        lVar3 = Transform.Find(lVar3,"BuildingUI",0);
        if (((((*pStatics_2ee8 == 0) ||
              (lVar4 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
             (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
            ((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 == null ||
             (lVar4 = Component.get_transform(lVar4,0)) == null))) ||
           (lVar4 = FUN_180daa030(lVar4,0)) == null) throw; // [null/range check failed]
        uStack_60 = *(uint32 *)(showPosition + 1);
        local_68 = *showPosition;
        puVar5 = (uint64 *)Transform.InverseTransformPoint(&local_58,lVar4,&local_68,0);
        if (lVar3 == null) throw; // [null/range check failed]
        local_68 = *puVar5;
        uStack_60 = *(uint32 *)(puVar5 + 1);
        Transform.set_localPosition(lVar3,&local_68,0);
        if (((*pStatics_2ee8 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
           (lVar3 = GameObject.get_transform(lVar3,0)) == null) throw; // [null/range check failed]
        uVar6 = Transform.Find(lVar3,"BuildingUI",0);
        puVar5 = (uint64 *)Vector3.get_zero(&local_58,0);
        uVar11 = 0;
        uStack_60 = *(uint32 *)(puVar5 + 1);
        local_68 = *puVar5;
        uVar6 = ShortcutExtensions.DOMove(uVar6,&local_68,0x3e4ccccd,0,0);
        uVar6 = TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181dc1f60);
        lVar3 = BuildingUIController._instance;
        if (lVar3 == null) {
          uVar7 = **(uint64 **)(DAT_181dc4148 + 184);
          lVar3 = new OnTooltipCB(uVar7,DAT_181d98ad0,0);
          BuildingUIController._instance = lVar3;
        }
        TweenSettingsExtensions.OnComplete(uVar6,lVar3,DAT_181dc0380);
        if ((((*pStatics_2ee8 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
            (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
           (lVar3 = Transform.Find(lVar3,"BuildingUI",0)) == null) throw; // [null/range check failed]
        local_68 = 0;
        uStack_60 = 0x3f800000;
        Transform.set_localScale(lVar3,&local_68,0);
        if (((*pStatics_2ee8 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
           (lVar3 = GameObject.get_transform(lVar3,0)) == null) throw; // [null/range check failed]
        uVar6 = Transform.Find(lVar3,"BuildingUI",0);
        puVar5 = (uint64 *)Vector3.get_one(&local_58,0);
        uStack_60 = *(uint32 *)(puVar5 + 1);
        local_68 = *puVar5;
        uVar6 = ShortcutExtensions.DOScale(uVar6,&local_68,0x3e4ccccd,0);
        TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181dc1f60);
        if (((*pStatics_2ee8 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
           ((lVar3 = GameObject.get_transform(lVar3,0), lVar3 == null ||
            (lVar3 = Transform.Find(lVar3,"BlackBackground",0)) == null))) throw; // [null/range check failed]
        uVar6 = Component.GetComponent(lVar3,DAT_181d94478);
        uVar6 = DOTweenModuleUI.DOFade(uVar6,0x3f333333,0x3e4ccccd,0);
        TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181dc1dc8);
        if ((this.buildingData == null) ||
           (lVar3 = AreaBuildingData.DataBase(this.buildingData,0)) == null)
        throw; // [null/range check failed]
        lVar3 = *(int64 *)(lVar3 + 152);
        if (lVar3 != null) {
          cVar1 = FUN_18171eb50(lVar3,"door",0);
          if (!cVar1) {
            cVar1 = FUN_18171eb50(lVar3,"bigdoor");
            if (!cVar1) {
              cVar1 = FUN_18171eb50(lVar3,"footstep");
              uVar6 = "Sound/SoundEffect/FootStepContinue";
              if (!cVar1) goto LAB_180b6eab5;
            }
            else {
              local_res8[0] = FUN_180d96040(1);
              uVar6 = Int32.ToString(local_res8,0);
              uVar6 = String.Concat("Sound/SoundEffect/Door/BigDoor",uVar6,0);
            }
          }
          else {
            local_res8[0] = FUN_180d96040(0,7);
            uVar6 = Int32.ToString(local_res8,0);
            uVar6 = String.Concat("Sound/SoundEffect/Door/Door",uVar6,0);
          }
          plVar9 = (int64 *)Resources.Load(uVar6,0);
          plVar10 = plVar8;
          if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181daf360)) {
            plVar10 = plVar9;
          }
          NGUITools.PlaySound(plVar10,0);
        }
        LAB_180b6eab5:
        if ((((*pStatics_2ee8 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
            (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
           ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
            (lVar3 = Transform.Find(lVar3,"Pic",0)) == null))) {
        LAB_180b6f54e:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar3 = Component.GetComponent(lVar3,DAT_181d94478);
        if ((this.buildingData == null) ||
           (lVar4 = AreaBuildingData.DataBase(this.buildingData,0)) == null)
        goto LAB_180b6f54e;
        uVar7 = String.Concat("Textures/Background/",*(uint64 *)(lVar4 + 24),0);
        uVar6 = DAT_181dc1928;
        uVar6 = Type.GetTypeFromHandle(uVar6,0);
        plVar9 = (int64 *)Resources.Load(uVar7,uVar6,0);
        if (lVar3 == null) goto LAB_180b6f54e;
        if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181da4be8)) {
          plVar8 = plVar9;
        }
        Image.set_sprite(lVar3,plVar8,0);
        if ((((*pStatics_2ee8 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
            (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
           ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
            (lVar3 = Transform.Find(lVar3,"Pic",0)) == null))) goto LAB_180b6f54e;
        plVar8 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
        local_58 = 0;
        uStack_50 = 0;
        FUN_1809dcfa0(&local_58,0x3f800000,0x3f800000,0x3f800000,uVar11 & 0xffffffff00000000,0);
        if (plVar8 == (int64 *)0) goto LAB_180b6f54e;
        local_68 = local_58;
        uStack_60 = (uint32)uStack_50;
        uStack_5c = uStack_50._4_4_;
        (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_68,*(uint64 *)(*plVar8 + 0x2b0));
        if (((*pStatics_2ee8 == 0) ||
            (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
           ((lVar3 = GameObject.get_transform(lVar3,0), lVar3 == null ||
            ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"Pic",0)) == null))))) goto LAB_180b6f54e;
        uVar6 = Component.GetComponent(lVar3,DAT_181d94478);
        uVar6 = DOTweenModuleUI.DOFade(uVar6,0x3f800000,0x3ecccccd,0);
        TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181dc1dc8);
        if (((((*pStatics_2ee8 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
             (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
            ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"ExtraButtonGrid",0)) == null))) ||
           (lVar3 = Transform.Find(lVar3,"StealButton",0)) == null) goto LAB_180b6f54e;
        lVar3 = Component.get_gameObject(lVar3,0);
        if (((this.buildingData == null) ||
            (lVar4 = AreaBuildingData.DataBase(this.buildingData,0)) == null) ||
           (lVar3 == null)) goto LAB_180b6f54e;
        GameObject.SetActive(lVar3,*(uint8 *)(lVar4 + 160),0);
        if (((((*pStatics_2ee8 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
             (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
            ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"ExtraButtonGrid",0)) == null))) ||
           (lVar3 = Transform.Find(lVar3,"StealButton",0)) == null) goto LAB_180b6f54e;
        lVar3 = Component.GetComponent(lVar3,DAT_181d95578);
        if (this.buildingData == null) goto LAB_180b6f54e;
        local_res10[0] = AreaBuildingData.GetStealItemMaxLv(this.buildingData,0);
        uVar6 = il2cpp_value_box(DAT_181d80430,local_res10);
        uVar6 = String.Format("等级{0}",uVar6,0);
        if (this.buildingData == null) goto LAB_180b6f54e;
        uVar2 = AreaBuildingData.GetStealItemMaxLv(this.buildingData,0);
        uVar6 = GlobalData.GenerateRareLvColorText(uVar6,uVar2,0);
        uVar6 = String.Format("穿越迷宫后，可以窃取商店内一件<b>{0}</b>以下物品",uVar6,0);
        if (lVar3 == null) goto LAB_180b6f54e;
        lVar3.TestBuildPlayer = uVar6;
        if ((((*pStatics_2ee8 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_2ee8 + 72)) == null) ||
            (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
           (((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 == null ||
             (lVar3 = Transform.Find(lVar3,"ExtraButtonGrid",0)) == null) ||
            (lVar3 = Transform.Find(lVar3,"RobButton",0)) == null))) goto LAB_180b6f54e;
        lVar3 = Component.get_gameObject(lVar3,0);
        if (((this.buildingData == null) ||
            (lVar4 = AreaBuildingData.DataBase(this.buildingData,0)) == null) ||
           (lVar3 == null)) goto LAB_180b6f54e;
        GameObject.SetActive(lVar3,*(uint8 *)(lVar4 + 161),0);
        BuildingUIController.RefreshBuildingUI(this,0);
        BuildingUIController.GenerateBuildingButton(this,0);
        if (this.buildingData == null) goto LAB_180b6f54e;
        if (this.buildingData.belongHeroID == null) {
          if (GameController._instance == null) throw; // [null/range check failed]
          cVar1 = GameController.CheckGameResultTrigger(GameController._instance,0);
          if (cVar1) {
            return;
          }
        }
        lVar3 = GameController._instance;
        lVar4 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
        if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 88)) != null) {
          uVar6 = Int32.ToString(lVar4 + 16,0);
          if (this.buildingData != null) {
            uVar7 = Int32.ToString(this.buildingData + 16,0);
            uVar6 = String.Concat(uVar6,":",uVar7,0);
            if (lVar3 != null) {
              GameController.CheckPlotTrigger(lVar3,4,uVar6,999999,0);
              lVar3 = BuildingUIController.PartyLvName;
              if (lVar3 != null) {
                cVar1 = PlotController.HaveNoPlotWait(lVar3,0);
                if (cVar1) {
                  BuildingUIController.CheckEnterBuildingMission(this,0);
                }
                lVar3 = BuildingUIController.PartyLvName;
                if (lVar3 != null) {
                  cVar1 = PlotController.HaveNoPlotWait(lVar3,0);
                  if (cVar1) {
                    BuildingUIController.CheckEnterBuildingSpePlot(this,0);
                  }
                  lVar3 = BuildingUIController.PartyLvName;
                  if (lVar3 != null) {
                    cVar1 = PlotController.HaveNoPlotWait(lVar3,0);
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

    // Token : 0x6000DD8
    // RVA   : 0xB626A0   Offset: 0xB61AA0   Length: 0x602
    public void CheckEnterBuildingSpePlot()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        if (this.buildingData == null) throw; // [null/range check failed]
        if (this.buildingData.buildingID != null) goto LAB_180b62a14;
        if (((GameController._instance == null) ||
            (lVar2 = GameController._instance.worldData) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        if (!lVar2.hour) {
          cVar1 = GameController.MeetCondition("我",0,0);
          if (!cVar1) goto LAB_180b62a14;
          lVar2 = FUN_18046c0a0(0);
          if ((lVar2 == null) || (lVar2.villageAreaID == null)) throw; // [null/range check failed]
          if (*(char *)(lVar2.villageAreaID + 184) == false) {
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 != null) && (lVar2.villageAreaID != null)) &&
               (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) != null) {
              if (*(int64 *)(lVar2 + 0x2e0) == 0) {
                return;
              }
              lVar2 = FUN_18046c400(0);
              if (lVar2 != null) {
                PlotController.AddAskForceMissionPlot(lVar2,0);
                return;
              }
            }
            throw; // [null/range check failed]
          }
          lVar2 = FUN_18046c400(0);
          lVar3 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar3,DAT_181da3bf0);
          if (lVar3 == null) throw; // [null/range check failed]
          FUN_18181e6b0(lVar3,"参加会议;EnterMeeting",DAT_181da3d70);
          uVar4 = new SinglePlotData("哎呀，会议好像已经开始了，得赶快入座才行。",lVar3,1,0,3,"0",1,0,0);
        }
        else {
        LAB_180b62a14:
          if (this.buildingData == null) throw; // [null/range check failed]
          if (this.buildingData.buildingID != 4) {
            return;
          }
          if (((GameController._instance == null) ||
              (lVar2 = GameController._instance.worldData) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          if (lVar2.hour) {
            return;
          }
          cVar1 = GameController.MeetCondition("我",0,0);
          if (!cVar1) {
            return;
          }
          lVar2 = FUN_18046c0a0(0);
          if ((lVar2 == null) || (lVar2.villageAreaID == null)) throw; // [null/range check failed]
          if (*(char *)(lVar2.villageAreaID + 185) == false) {
            return;
          }
          lVar2 = FUN_18046c0a0(0);
          if ((lVar2 == null) || (lVar2.villageAreaID == null)) throw; // [null/range check failed]
          *(uint8 *)(lVar2.villageAreaID + 185) = 0;
          lVar2 = FUN_18046c400(0);
          lVar3 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar3,DAT_181da3bf0);
          if (lVar3 == null) throw; // [null/range check failed]
          FUN_18181e6b0(lVar3,"参加宴会;JoinForceParty",DAT_181da3d70);
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

    // Token : 0x6000DD9
    // RVA   : 0xB62240   Offset: 0xB61640   Length: 0x45B
    public void CheckEnterBuildingMission()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        iVar5 = 0;
        do {
          if ((((GameController._instance == null) ||
               (lVar2 = GameController._instance.worldData) == null) ||
              (lVar2 = WorldData.Player(lVar2,0)) == null) || (*(int64 *)(lVar2 + 0x2e8) == 0))
          goto LAB_180b62676;
          if (*(int *)(*(int64 *)(lVar2 + 0x2e8) + 24) <= iVar5) {
            return;
          }
          lVar2 = FUN_18046c0a0(0);
          if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
             ((lVar2 = WorldData.Player(lVar2.villageAreaID,0), lVar2 == null ||
              (((*(int64 *)(lVar2 + 0x2e8) == 0 ||
                (lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 0x2e8),iVar5,DAT_181d94ca0)) == null) ||
               (lVar2 = lVar2.WorldEventDatasSaveRecord) == null))))) goto LAB_180b62676;
          if (lVar2.cityAreaID == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(lVar2.chapter + 32);
          if (lVar2 == null) goto LAB_180b62676;
          if (lVar2.forceAreaID == 4) {
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
               ((lVar2 = WorldData.Player(lVar2.villageAreaID,0), lVar2 == null ||
                (((*(int64 *)(lVar2 + 0x2e8) == 0 ||
                  (lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 0x2e8),iVar5,DAT_181d94ca0)) == null)
                 || (lVar2 = lVar2.WorldEventDatasSaveRecord) == null))))) goto LAB_180b62676;
            if (lVar2.cityAreaID == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar2.chapter + 32);
            if (lVar2 == null) goto LAB_180b62676;
            lVar2 = lVar2.Areas;
            lVar3 = FUN_1800d60b0(DAT_181da1058,1);
            if (lVar3 == null) goto LAB_180b62676;
            if (*(int *)(lVar3 + 24) == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            *(uint16 *)(lVar3 + 32) = 58;
            if ((lVar2 == null) || (lVar2 = String.Split(lVar2,lVar3,0)) == null) goto LAB_180b62676;
            if (lVar2.cityAreaID == 2) {
              iVar1 = Int32.Parse(lVar2.villageAreaID);
              lVar3 = FUN_18046bac0(0);
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 88) == 0)) goto LAB_180b62676;
              if (iVar1 == *(int *)(*(int64 *)(lVar3 + 88) + 16)) {
                if (lVar2.cityAreaID < 2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                iVar1 = Int32.Parse(lVar2.forceAreaID);
                if (this.buildingData == null) goto LAB_180b62676;
                if (iVar1 == this.buildingData.buildingID) {
                  lVar2 = FUN_18046c400(0);
                  lVar3 = FUN_18046c0a0(0);
                  if (((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                       (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) &&
                      ((*(int64 *)(lVar3 + 0x2e8) != 0 &&
                       (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x2e8),iVar5,DAT_181d94ca0),
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
        LAB_180b62676:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
              }
            }
          }
          iVar5 = iVar5 + 1;
        } while( true );
    }

    // Token : 0x6000DDA
    // RVA   : 0xB6CA90   Offset: 0xB6BE90   Length: 0x7B0
    public void RefreshBuildingUI()
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
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
          uVar5 = Component.GetComponent(lVar4,DAT_181d96178);
          if ((this.buildingData != null) &&
             (lVar4 = AreaBuildingData.DataBase(this.buildingData,0)) != null) {
            uVar6 = *(uint64 *)(lVar4 + 24);
            LTLocalization.SetText(uVar5,uVar6,0);
            if ((((*pStatics != 0) &&
                 (lVar4 = *(int64 *)(*pStatics + 72)) != null) &&
                (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
               ((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 != null &&
                (lVar4 = Transform.Find(lVar4,"Level",0)) != null))) {
              uVar5 = Component.GetComponent(lVar4,DAT_181d96178);
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
                  uVar5 = Component.GetComponent(lVar4,DAT_181d96178);
                  if (this.buildingData != null) {
                    uVar6 = AreaBuildingData.GetBuildingText(this.buildingData,0,0,0,0);
                    LTLocalization.SetText(uVar5,uVar6,0);
                    if (((*pStatics != 0) &&
                        (lVar4 = *(int64 *)(*pStatics + 72)) != null)
                       && ((lVar4 = GameObject.get_transform(lVar4,0), lVar4 != null &&
                           ((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 != null &&
                            (lVar4 = Transform.Find(lVar4,"Describe",0)) != null))))) {
                      uVar5 = Component.GetComponent(lVar4,DAT_181d96178);
                      if ((this.buildingData != null) &&
                         (lVar4 = AreaBuildingData.DataBase(this.buildingData,0)) != null
                         ) {
                        uVar6 = *(uint64 *)(lVar4 + 40);
                        if (this.buildingData != null) {
                          cVar2 = AreaBuildingData.BuildingAvailable(this.buildingData,0);
                          uVar8 = "";
                          if (!cVar2) {
                            uVar8 = *(uint64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x2d0);
                            if (this.buildingData == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            local_res8[0] = this.buildingData.enemyMonth;
                            uVar7 = il2cpp_value_box(DAT_181d80430,local_res8);
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
                            lVar4 = Component.GetComponent(lVar4,DAT_181d93778);
                            if ((this.buildingData != null) &&
                               (uVar3 = AreaBuildingData.BuildingAvailable
                                                  (this.buildingData,0), lVar4 != null)) {
                              Selectable.set_interactable(lVar4,uVar3,0);
                              if (((((*pStatics != 0) &&
                                    (lVar4 = *(int64 *)(*pStatics + 72),
                                    lVar4 != null)) &&
                                   (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                                  ((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 != null &&
                                   (lVar4 = Transform.Find(lVar4,"ExtraButtonGrid",0)) != null))) &&
                                 (lVar4 = Transform.Find(lVar4,"RobButton",0)) != null) {
                                lVar4 = Component.GetComponent(lVar4,DAT_181d93778);
                                if ((this.buildingData != null) &&
                                   (uVar3 = AreaBuildingData.BuildingAvailable
                                                      (this.buildingData,0), lVar4 != null)) {
                                  Selectable.set_interactable(lVar4,uVar3,0);
                                  BuildingUIController.RefreshUpgradeButton(this,0);
                                  if ((((*pStatics != 0) &&
                                       (lVar4 = *(int64 *)
                                                 (*pStatics + 72),
                                       lVar4 != null)) &&
                                      (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                                     (((lVar4 = Transform.Find(lVar4,"BuildingUI",0), lVar4 != null &&
                                       (lVar4 = Transform.Find(lVar4,"ExtraButtonGrid",0)) != null) &&
                                      (lVar4 = Component.GetComponent(lVar4,DAT_181d96978)) != null))
                                     ) {
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

    // Token : 0x6000DDB
    // RVA   : 0xB6D250   Offset: 0xB6C650   Length: 0x680
    public void RefreshUpgradeButton()
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
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
                        uVar6 = Component.GetComponent(lVar5,DAT_181d96178);
                        LTLocalization.SetText(uVar6,"登峰造极",0);
                        lVar5 = Component.GetComponent(lVar4,DAT_181d93778);
                        if (lVar5 == null) throw; // [null/range check failed]
                        Selectable.set_interactable(lVar5,0,0);
                        lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
                        uVar6 = "";
                        if (lVar4 == null) throw; // [null/range check failed]
                        puVar7 = (uint64 *)(lVar4 + 24);
                        *puVar7 = "";
                        goto LAB_180b6d625;
                      }
                      lVar5 = Transform.Find(lVar4,"Text");
                      if (lVar5 == null) throw; // [null/range check failed]
                      uVar6 = Component.GetComponent(lVar5,DAT_181d96178);
                      LTLocalization.SetText(uVar6,"升级",0);
                      lVar5 = Component.GetComponent(lVar4,DAT_181d93778);
                      if ((this.buildingData == null) ||
                         (uVar3 = AreaBuildingData.CanUpgrade(this.buildingData,0),
                         lVar5 == null)) throw; // [null/range check failed]
                      Selectable.set_interactable(lVar5,uVar3,0);
                      lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
                      if ((this.buildingData == null) ||
                         (uVar6 = AreaBuildingData.GetUpgradeDescribe(this.buildingData,0),
                         lVar4 == null)) throw; // [null/range check failed]
                    }
                    else {
                      lVar5 = Transform.Find(lVar4,"Text");
                      if (lVar5 == null) {
        LAB_180b6d8c5:
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      uVar6 = Component.GetComponent(lVar5,DAT_181d96178);
                      LTLocalization.SetText(uVar6,"升级中",0);
                      lVar5 = Component.GetComponent(lVar4,DAT_181d93778);
                      if (lVar5 == null) goto LAB_180b6d8c5;
                      Selectable.set_interactable(lVar5,0,0);
                      lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
                      if (this.buildingData == null) goto LAB_180b6d8c5;
                      local_res18[0] = this.buildingData.upgradeTimeLeft;
                      uVar6 = il2cpp_value_box(DAT_181d80430,local_res18);
                      uVar6 = String.Format("剩余{0}天",uVar6,0);
                      if (lVar4 == null) goto LAB_180b6d8c5;
                    }
                  }
                  else {
                    lVar5 = Transform.Find(lVar4,"Text");
                    if (lVar5 == null) {
        LAB_180b6d8cb:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    uVar6 = Component.GetComponent(lVar5,DAT_181d96178);
                    LTLocalization.SetText(uVar6,"建造中",0);
                    lVar5 = Component.GetComponent(lVar4,DAT_181d93778);
                    if (lVar5 == null) goto LAB_180b6d8cb;
                    Selectable.set_interactable(lVar5,0,0);
                    lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
                    if (this.buildingData == null) goto LAB_180b6d8cb;
                    local_res18[0] = this.buildingData.buildTimeLeft;
                    uVar6 = il2cpp_value_box(DAT_181d80430,local_res18);
                    uVar6 = String.Format("剩余{0}天",uVar6,0);
                    if (lVar4 == null) goto LAB_180b6d8cb;
                  }
                  puVar7 = (uint64 *)(lVar4 + 24);
                  *puVar7 = uVar6;
        LAB_180b6d625:
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

    // Token : 0x6000DDC
    // RVA   : 0xB7D0D0   Offset: 0xB7C4D0   Length: 0x16B
    public void UpgradeButtonClicked()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        uint[] local_res8 = new uint[2];
        lVar2 = **(int64 **)(DAT_181da8728 + 184);
        if (this.buildingData != null) {
          uVar3 = AreaBuildingData.Name(this.buildingData,0,0);
          if (this.buildingData != null) {
            iVar1 = this.buildingData.lv;
            uVar4 = GlobalData.GetNumText(iVar1 + 1,0);
            if (this.buildingData != null) {
              local_res8[0] = AreaBuildingData.GetUpgradeTime(this.buildingData,0);
              uVar5 = il2cpp_value_box(DAT_181d80430,local_res8);
              uVar3 = String.Format("确认要将{0}提升至{1}级吗？\n大约需要{2}天时间。",uVar3,uVar4,uVar5,0);
              if (lVar2 != null) {
                SureMenu.CallSureMenu(lVar2,uVar3,"SureUpgradeBuliding",0,"UIController",0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000DDD
    // RVA   : 0xB7CEF0   Offset: 0xB7C2F0   Length: 0x130
    public void SureUpgradeBuliding()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dac470 + 184) + 16);
        if (lVar1 != null) {
          AreaBuildController.PlayerUpgradeBuilding(lVar1,this.buildingData,0);
          BuildingUIController.RefreshUpgradeButton(this,0);
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/WoodWork",0);
          plVar3 = (int64 *)0;
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181daf360)) {
            plVar3 = plVar2;
          }
          NGUITools.PlaySound(plVar3,0);
          return;
        }
    }

    // Token : 0x6000DDE
    // RVA   : 0xB66330   Offset: 0xB65730   Length: 0x459
    public void HideBuildingUI()
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        var pStatics_dd10 = *(int64*)(DAT_181dadd10 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        uint local_18;
        uint local_14;
        uint local_10;
        if (*pStatics_dd10 == 0) throw; // [null/range check failed]
        if (*(char *)(*pStatics_dd10 + 89) != false) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 8);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 16)) == null) throw; // [null/range check failed]
          iVar1 = PlayerPrefDictionary.GetInt(lVar2,"SkipTutorial",0);
          if (iVar1 != 1) {
            lVar2 = FUN_18046c400(0);
            lVar3 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar3,DAT_181da3bf0);
            if (lVar3 != null) {
              FUN_18181e6b0(lVar3,"不敢不敢;HideInteractUI",DAT_181da3d70);
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
        if ((*pStatics_2ee8 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_2ee8 + 72)) != null) {
          lVar2 = GameObject.get_transform(lVar2,0);
          if (lVar2 != null) {
            uVar4 = Transform.Find(lVar2,"BuildingUI",0);
            local_18 = 0;
            local_14 = 0x3f800000;
            local_10 = 0x3f800000;
            uVar4 = ShortcutExtensions.DOScale(uVar4,&local_18,0x3e4ccccd,0);
            uVar5 = new OnTooltipCB(this,DAT_181d8d708,0);
            uVar4 = TweenSettingsExtensions.OnComplete(uVar4,uVar5,DAT_181dc0380);
            TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181dc1f60);
            if ((*pStatics_2ee8 != 0) &&
               (lVar2 = *(int64 *)(*pStatics_2ee8 + 72)) != null) {
              lVar2 = GameObject.get_transform(lVar2,0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"BlackBackground",0);
                if (lVar2 != null) {
                  uVar4 = Component.GetComponent(lVar2,DAT_181d94478);
                  uVar4 = DOTweenModuleUI.DOFade(uVar4,0,0x3e4ccccd,0);
                  TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181dc1dc8);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DDF
    // RVA   : 0xB63BD0   Offset: 0xB62FD0   Length: 0x151
    public void DisactiveBuildingPanel()
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
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
                    lVar1 = Component.GetComponent(lVar1,DAT_181d95278);
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

    // Token : 0x6000DE0
    // RVA   : 0xB66110   Offset: 0xB65510   Length: 0x21D
    public void HideBuildingFinished()
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
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
                (lVar1 = Component.GetComponent(lVar1,DAT_181d95278)) != null))) {
              Scrollbar.set_value(lVar1,0x3f800000,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000DE1
    // RVA   : 0xB64940   Offset: 0xB63D40   Length: 0x1E3
    public void GenerateBuildingButton()
    {
        var pStatics = *(int64*)(DAT_181d72ee8 + 184);
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
              (lVar1 = Component.GetComponent(lVar1,DAT_181d95278)) != null))) {
            Scrollbar.set_value(lVar1,0x3f800000,0);
            return;
          }
        }
    }

    // Token : 0x6000DE2
    // RVA   : 0xB63830   Offset: 0xB62C30   Length: 0x397
    public void CreateBuildingButton(AreaBuildingChoice buildingChoice)
    {
        bool cVar1;
        byte uVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        if (**(int **)(DAT_181d73d40 + 184) == 2) {
          lVar4 = *(int64 *)(*(int64 *)(DAT_181db4020 + 184) + 16);
          if ((buildingChoice == null) || (lVar4 == null)) throw; // [null/range check failed]
          cVar1 = FUN_18181ea10(lVar4,*(uint64 *)(buildingChoice + 16),DAT_181da3e70);
          if (cVar1) {
            return;
          }
        }
        if (buildingChoice != null) {
          uVar3 = *(uint64 *)(buildingChoice + 40);
          uVar2 = *(uint8 *)(buildingChoice + 32);
          uVar5 = this.buildingData;
          cVar1 = GameController.MeetCondition(uVar3,uVar2,uVar5,0);
          if (!cVar1) {
            return;
          }
          uVar3 = this.buildingButtonGrid;
          uVar5 = this.buildingButtonPrefab;
          uVar3 = GlobalData.AddChild(uVar3,uVar5,0);
          this.newButton = uVar3;
          if ((this.newButton != null) &&
             (lVar4 = GameObject.GetComponent(this.newButton,DAT_181dc7b90)) != null)
          {
            *(int64 *)(lVar4 + 24) = buildingChoice;
            if ((this.newButton != null) &&
               ((lVar4 = GameObject.get_transform(this.newButton,0), lVar4 != null &&
                (lVar4 = Transform.Find(lVar4,"Text",0)) != null))) {
              uVar5 = Component.GetComponent(lVar4,DAT_181d96178);
              uVar3 = *(uint64 *)(buildingChoice + 16);
              LTLocalization.SetText(uVar5,uVar3,0);
              uVar3 = *(uint64 *)(buildingChoice + 48);
              uVar2 = *(uint8 *)(buildingChoice + 32);
              uVar5 = this.buildingData;
              cVar1 = GameController.MeetCondition(uVar3,uVar2,uVar5,0);
              if (this.newButton != null) {
                lVar4 = GameObject.GetComponent(this.newButton,DAT_181dc7c18);
                if (!cVar1) {
                  uVar2 = 0;
                }
                else {
                  if (this.buildingData == null) throw; // [null/range check failed]
                  uVar2 = AreaBuildingData.BuildingAvailable(this.buildingData,0);
                }
                if (lVar4 != null) {
                  Selectable.set_interactable(lVar4,uVar2,0);
                  if ((this.newButton != null) &&
                     (lVar4 = GameObject.get_transform(this.newButton,0)) != null) {
                    lVar4 = Component.GetComponent(lVar4,DAT_181d95578);
                    if (!cVar1) {
                      uVar3 = *(uint64 *)(buildingChoice + 48);
                      uVar3 = GameController.GetConditionDescribe(uVar3,0);
                    }
                    else {
                      uVar3 = *(uint64 *)(buildingChoice + 24);
                    }
                    if (lVar4 != null) {
                      *(uint64 *)(lVar4 + 24) = uVar3;
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DE3
    // RVA   : 0xB67DA0   Offset: 0xB671A0   Length: 0xAC
    public void InteractOtherForce()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.StartInteractOtherForce(lVar1,0);
          return;
        }
    }

    // Token : 0x6000DE4
    // RVA   : 0xB67E50   Offset: 0xB67250   Length: 0xAC
    public void LeaderInteractOtherForce()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.StartLeaderInteractOtherForce(lVar1,0);
          return;
        }
    }

    // Token : 0x6000DE5
    // RVA   : 0xB64EC0   Offset: 0xB642C0   Length: 0x371
    public string GenerateForceNPCString(string name)
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        lVar1 = PlotController.SpringFestivelRewardLvTalkText;
        if (lVar1 == null) throw; // [null/range check failed]
        if (*(int64 *)(lVar1 + 88) == 0) {
        LAB_180b650ae:
          uVar2 = 0xffffffff;
        }
        else {
          lVar1 = PlotController.SpringFestivelRewardLvTalkText;
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 88)) == null) throw; // [null/range check failed]
          lVar1 = AreaData.GetForce(lVar1,0);
          if (lVar1 == null) goto LAB_180b650ae;
          lVar1 = FUN_18046bac0(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 88) == 0)) throw; // [null/range check failed]
          lVar1 = AreaData.GetForce(*(int64 *)(lVar1 + 88),0);
          if (lVar1 == null) throw; // [null/range check failed]
          if (*(int *)(lVar1 + 32) == -99) goto LAB_180b650ae;
          lVar1 = FUN_18046bac0(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 88) == 0)) throw; // [null/range check failed]
          lVar1 = AreaData.GetForce(*(int64 *)(lVar1 + 88),0);
          if (lVar1 == null) throw; // [null/range check failed]
          uVar2 = *(uint32 *)(lVar1 + 32);
        }
        lVar1 = PlotController.SpringFestivelRewardLvTalkText;
        if (lVar1 == null) throw; // [null/range check failed]
        if (*(int64 *)(lVar1 + 88) == 0) {
        LAB_180b651f2:
          uVar3 = 0xffffffff;
        }
        else {
          lVar1 = PlotController.SpringFestivelRewardLvTalkText;
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 88)) == null) throw; // [null/range check failed]
          lVar1 = AreaData.GetForce(lVar1,0);
          if (lVar1 == null) goto LAB_180b651f2;
          lVar1 = FUN_18046bac0(0);
          if ((lVar1 == null) || (*(int64 *)(lVar1 + 88) == 0)) throw; // [null/range check failed]
          uVar3 = *(uint32 *)(*(int64 *)(lVar1 + 88) + 112);
        }
        if (this != 0) {
          BuildingUIController.GenerateBuildingNPCString(this,name,uVar2,uVar3,0xffffffff,0);
          return;
        }
    }

    // Token : 0x6000DE6
    // RVA   : 0xB64B30   Offset: 0xB63F30   Length: 0x38F
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
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181da4138,6);
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
        local_res10[0] = (float)FUN_180d96040(20);
        lVar2 = il2cpp_value_box(DAT_181d80430,local_res10);
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
        lVar2 = il2cpp_value_box(DAT_181da22f0,local_res10);
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
        lVar2 = il2cpp_value_box(DAT_181d80430,&local_28);
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
          lVar2 = il2cpp_value_box(DAT_181d80430,local_24);
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

    // Token : 0x6000DE7
    // RVA   : 0xB652B0   Offset: 0xB646B0   Length: 0xDA
    public float GetBuildingHeroLv()
    {
        float fVar1;
        if (GameController._instance != null) {
          fVar1 = (float)GameController.GetTimeDifficulty(GameController._instance,0);
          if (this.buildingData != null) {
            return ((float)this.buildingData.lv + fVar1) * 0.5 * 0.5;
          }
        }
    }

    // Token : 0x6000DE8
    // RVA   : 0xB61C80   Offset: 0xB61080   Length: 0x5B0
    public void BuyCityHouse()
    {
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
          lVar2 = BuildingUIController.PartyLvName;
          uVar3 = new PlotData(0);
          if (lVar2 != null) {
            puVar1 = (uint64 *)(lVar2 + 0x108);
            *puVar1 = uVar3;
            il2cpp_internal(puVar1,uVar3);
            lVar2 = BuildingUIController.PartyLvName;
            if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 0x108)) != null) {
              lVar2 = *(int64 *)(lVar2 + 64);
              uVar3 = FUN_180228420(DAT_181d8b158);
              uVar3 = String.Format("少侠真是好眼光！这栋房产位于#AreaName#城内，\n交通便利，闹中取静，景观优雅，装饰奢华。\n日后孩子要去城中有名的学堂上课，也是方便得很呐！",uVar3,0);
              uVar9 = 0;
              uVar4 = BuildingUIController.GenerateBuildingNPCString
                                (this,"地产商人",0xfffffffd,0xffffffff,CONCAT44(uVar7,0xffffffff),0)
              ;
              uVar5 = il2cpp_internal(DAT_181da24f0);
              uVar8 = CONCAT44(uVar9,3);
              SinglePlotData.ctor(uVar5,uVar3,0,5,uVar4,uVar8,"0",0,0,0);
              uVar7 = (uint32)((uint64)uVar8 >> 32);
              if (lVar2 != null) {
                FUN_18181e6b0(lVar2,uVar5,DAT_181da1408);
                lVar2 = BuildingUIController.PartyLvName;
                if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 0x108)) != null) {
                  lVar2 = *(int64 *)(lVar2 + 64);
                  local_res18[0] = local_res8[0];
                  uVar3 = il2cpp_value_box(DAT_181d80430,local_res18);
                  if (this.buildingData != null) {
                    local_res20[0] =
                         (float)AreaBuildingData.GetSelfHouseTotalAdd(this.buildingData,0);
                    local_res20[0] = local_res20[0] * 100.0;
                    uVar4 = il2cpp_value_box(DAT_181da22f0,local_res20);
                    if (this.buildingData != null) {
                      local_38[0] = (float)AreaBuildingData.GetSelfHouseTotalAdd
                                                     (this.buildingData,0);
                      local_38[0] = local_38[0] * 5.0;
                      uVar5 = il2cpp_value_box(DAT_181da22f0,local_38);
                      uVar3 = String.Format("眼下这处房产正在打折，只需要{0}两银子便可。\n买下这处房产后，少侠便可在此休憩，读书或存储物品了。\n此外还可以增加少侠{1}点的仓库容量以及{2}%的声望获取速度。",uVar3,uVar4,uVar5,0);
                      lVar6 = il2cpp_internal(DAT_181d97768);
                      FUN_181330100(lVar6,DAT_181da3bf0);
                      uVar4 = Int32.ToString(local_res8,0);
                      uVar4 = String.Concat("把地契拿来吧;BuyCityHouse;;0/",uVar4,0);
                      if (lVar6 != null) {
                        FUN_18181e6b0(lVar6,uVar4,DAT_181da3d70);
                        FUN_18181e6b0(lVar6,"我就随便看看;HideInteractUI",DAT_181da3d70);
                        uVar4 = new SinglePlotData(uVar3,lVar6,0,0,CONCAT44(uVar7,3),"0",0,0,0);
                        if (lVar2 != null) {
                          FUN_18181e6b0(lVar2,uVar4,DAT_181da1408);
                          lVar2 = BuildingUIController.PartyLvName;
                          lVar6 = BuildingUIController.PartyLvName;
                          if ((lVar6 != null) && (lVar2 != null)) {
                            PlotController.ChangePlot(lVar2,*(uint64 *)(lVar6 + 0x108),0);
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

    // Token : 0x6000DE9
    // RVA   : 0xB7D240   Offset: 0xB7C640   Length: 0x484
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
                lVar1 = FUN_18046c400(0);
                local_res18[0] = local_res8[0];
                uVar2 = il2cpp_value_box(DAT_181d80430,local_res18);
                if (this.buildingData != null) {
                  local_res20[0] = AreaBuildingData.GetUpgradeTime(this.buildingData,0);
                  uVar3 = il2cpp_value_box(DAT_181d80430,local_res20);
                  uVar2 = String.Format("要修缮升级这处房产需要{0}两银子以及{1}天时间，\n这可以增加少侠您10点的仓库容量以及0.5%的声望获取速度。",uVar2,uVar3,0);
                  lVar4 = il2cpp_internal(DAT_181d97768);
                  FUN_181330100(lVar4,DAT_181da3bf0);
                  uVar3 = Int32.ToString(local_res8,0);
                  uVar3 = String.Concat("开始动工吧;UpgradeCityHouse;;0/",uVar3,0);
                  if (lVar4 != null) {
                    FUN_18181e6b0(lVar4,uVar3,DAT_181da3d70);
                    FUN_18181e6b0(lVar4,"还是算了;HideInteractUI",DAT_181da3d70);
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
            lVar1 = FUN_18046c400(0);
            uVar2 = FUN_180228420(DAT_181d8b158);
            uVar2 = String.Format("此住宅已修缮至最高等级，若再加扩建只怕有违礼制了。",uVar2,0);
            uVar3 = il2cpp_internal(DAT_181da24f0);
          }
          else {
            lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
            uVar2 = FUN_180228420(DAT_181d8b158);
            uVar2 = String.Format("此住宅正在修缮中，还请稍安勿躁，静候些时日。",uVar2,0);
            uVar3 = il2cpp_internal(DAT_181da24f0);
          }
          SinglePlotData.ctor(uVar3,uVar2,0,1,0,CONCAT44(uVar7,3),"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DEA
    // RVA   : 0xB631A0   Offset: 0xB625A0   Length: 0x1F0
    public void CityHouseBookRoom()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        if (lVar2 != null) {
          FUN_18181e6b0(lVar2,"阅读秘籍;ChooseReadBook;false",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"编纂秘籍;ShowBookWriterSelf",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"离开;HideInteractUI",DAT_181da3d70);
          uVar3 = new SinglePlotData("书山有路勤为径，学海无涯苦作舟。",lVar2,1,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DEB
    // RVA   : 0xB633A0   Offset: 0xB627A0   Length: 0x216
    public void CityHousePracticeRoom()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        if (lVar2 != null) {
          FUN_18181e6b0(lVar2,"自行练习;StartPracticeCityHousePlot",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"突破;BreakThroughSkill",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"天赋;ChooseManageTagTargetSelfHouse",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"离开;HideInteractUI",DAT_181da3d70);
          uVar3 = new SinglePlotData("冬练三九，夏练三伏。\n便是在自己家中，这练功之事亦不能落下。",lVar2,1,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DEC
    // RVA   : 0xB62FA0   Offset: 0xB623A0   Length: 0x1F0
    public void CityHouseBedRoom()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        if (lVar2 != null) {
          FUN_18181e6b0(lVar2,"休息;HomeRest",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"私人仓库;OpenSelfStorage",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"离开;HideInteractUI",DAT_181da3d70);
          uVar3 = new SinglePlotData("江湖之中惊涛骇浪，波云诡谲。\n能有这样一方温馨的小天地以供休憩，也算是桩幸事。",lVar2,1,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DED
    // RVA   : 0xB64580   Offset: 0xB63980   Length: 0x3B1
    public void ExploreArea()
    {
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
        if (((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 88)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 0x100)) != null) {
          if (*(int *)(lVar1 + 16) < 1) {
            lVar1 = BuildingUIController.PartyLvName;
            uVar4 = new SinglePlotData("本月已探索过此地，即便再做努力只怕也难有收获。",0,1,0,CONCAT44(uVar6,3),"0",1,0,0);
          }
          else {
            lVar1 = BuildingUIController.PartyLvName;
            lVar2 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar2,DAT_181da3bf0);
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_18181e6b0(lVar2,"开始探索;ExploreAreaStart",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"还是算了;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000DEE
    // RVA   : 0xB6A830   Offset: 0xB69C30   Length: 0x3B1
    public void PatrolArea()
    {
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
        if (((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 88)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 0x100)) != null) {
          if (*(int *)(lVar1 + 20) < 1) {
            lVar1 = BuildingUIController.PartyLvName;
            uVar4 = new SinglePlotData("本月已巡查过此地，即便再做努力只怕也很难有所收获。",0,1,0,CONCAT44(uVar6,3),"0",1,0,0);
          }
          else {
            lVar1 = BuildingUIController.PartyLvName;
            lVar2 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar2,DAT_181da3bf0);
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_18181e6b0(lVar2,"开始巡查;PatrolAreaStart",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"还是算了;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000DEF
    // RVA   : 0xB68EA0   Offset: 0xB682A0   Length: 0xE9
    public void ManageBranch()
    {
        long lVar1;
        long lVar2;
        lVar1 = **(int64 **)(DAT_181db3470 + 184);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
        if ((lVar2 != null) && (lVar1 != null)) {
          BranchUIController.ShowBranchUI(lVar1,*(uint64 *)(lVar2 + 88),0);
          return;
        }
    }

    // Token : 0x6000DF0
    // RVA   : 0xB67F00   Offset: 0xB67300   Length: 0xD63
    public void LeaderManageForceAttack()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          iVar1 = WorldData.GetPlayerForceTotalArea(lVar3,0);
          if ((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          iVar2 = WorldData.GetPlayerForceMaxAttackTime(lVar3,0);
          if ((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          if (!lVar3.openForceAttackArea) {
            lVar3 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
            uVar8 = new SinglePlotData("目前各大门派间，尚且风平浪静。\n若此时贸然进攻其他门派领地，怕是会引起众怒，再等待时机吧！",0,1,0,3,"0",1,0,0);
          }
          else {
            if (((GameController._instance == null) ||
                (lVar3 = GameController._instance.worldData) == null) ||
               (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar3 + 0x2e0) == 0) {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                 ((lVar3 = WorldData.Player(lVar3.villageAreaID,0), lVar3 == null ||
                  (lVar3 = HeroData.GetForce(lVar3,0)) == null))) throw; // [null/range check failed]
              local_res20[0] = iVar1;
              if (lVar3.monthPartyTime < iVar2) {
                lVar3 = FUN_18046c400(0);
                plVar4 = (int64 *)FUN_1800d60b0(DAT_181da4138,4);
                lVar5 = il2cpp_value_box(DAT_181d80430,local_res20);
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
                      lVar5 = il2cpp_value_box(DAT_181d80430,&local_38);
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
                      lVar5 = il2cpp_value_box(DAT_181d80430,&local_34);
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
                      lVar5 = il2cpp_internal(DAT_181d97768);
                      FUN_181330100(lVar5,DAT_181da3bf0);
                      if (lVar5 != null) {
                        FUN_18181e6b0(lVar5,"选择目标;ChooseForceAttackArea",DAT_181da3d70);
                        FUN_18181e6b0(lVar5,"还是算了;HideInteractUI");
                        uVar8 = new SinglePlotData(uVar7,lVar5,1,0,3,"0",1,0,0);
                        if (lVar3 != null) goto LAB_180b685c6;
                      }
                    }
                  }
                }
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar3 = FUN_18046c400(0);
              plVar4 = (int64 *)FUN_1800d60b0(DAT_181da4138,4);
              lVar5 = il2cpp_value_box(DAT_181d80430,local_res20);
              if (plVar4 == (int64 *)0) {
        LAB_180b68c5e:
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
              goto LAB_180b68c5e;
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
                  (lVar5 = HeroData.GetForce(lVar5,0)) == null))) goto LAB_180b68c5e;
              local_34 = *(int *)(lVar5 + 0x118);
              lVar5 = il2cpp_value_box(DAT_181d80430,&local_34);
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
              lVar5 = *(int64 *)(pStatics_3d40 + 0x148);
              if (lVar5 == null) goto LAB_180b68c5e;
              lVar6 = "";
              if (iVar2 < *(int *)(lVar5 + 24) + 1) {
                lVar5 = *(int64 *)(pStatics_3d40 + 0x148);
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(uint32 *)(lVar5 + 24) <= iVar2 - 1U) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_38 = *(int *)(*(int64 *)(lVar5 + 16) + 32 + (int64)(int)(iVar2 - 1U) * 4);
                uVar7 = il2cpp_value_box(DAT_181d80430,&local_38);
                local_30[0] = iVar2 + 1;
                uVar9 = il2cpp_value_box(DAT_181d80430,local_30);
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
              goto LAB_180b685c6;
            }
            lVar3 = FUN_18046c400(0);
            lVar5 = FUN_18046c0a0(0);
            if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) ||
               (*(int64 *)(lVar5 + 0x2e0) == 0)) throw; // [null/range check failed]
            uVar7 = String.Format("目前已有{0}门派任务在身，还是先将此事料理妥当再说。",*(uint64 *)(*(int64 *)(lVar5 + 0x2e0) + 24));
            uVar8 = new SinglePlotData(uVar7,0,1,0,3,"0",1,0,0);
          }
          if (lVar3 != null) {
        LAB_180b685c6:
            PlotController.ChangePlot(lVar3,uVar8,0);
            return;
          }
        }
    }

    // Token : 0x6000DF1
    // RVA   : 0xB69140   Offset: 0xB68540   Length: 0xF8
    public void ManageForceSetting()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181dc80d0 + 184);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
          uVar3 = AreaData.GetForce(lVar2,0);
          if (lVar1 != null) {
            ForceSettingController.ShowForceSettingUI(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DF2
    // RVA   : 0xB68F90   Offset: 0xB68390   Length: 0xF8
    public void ManageForceHeroSetting()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181dc7eb0 + 184);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
          uVar3 = AreaData.GetForce(lVar2,0);
          if (lVar1 != null) {
            ForceHeroSettingController.ShowForceHeroSettingUI(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DF3
    // RVA   : 0xB6FCF0   Offset: 0xB6F0F0   Length: 0x197
    public void ShowForceHero()
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        lVar1 = **(int64 **)(DAT_181dc7f38 + 184);
        cVar3 = GameController.MeetCondition("我",0,0);
        if (!cVar3) {
          cVar3 = false;
        }
        else {
          cVar3 = GameController.MeetCondition("掌门",0,0);
          cVar3 = (cVar3) + true;
        }
        lVar2 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
          uVar4 = AreaData.GetForce(lVar2,0);
          if (lVar1 != null) {
            ForceHeroUIController.ShowForceHeroUI(lVar1,cVar3,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000DF4
    // RVA   : 0xB715C0   Offset: 0xB709C0   Length: 0x34F
    public void ShowResearch()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d9c598 + 184) + 8);
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
        if (lVar3.forceMeetingStarted < **(int **)(DAT_181d9c598 + 184)) {
        LAB_180b7186a:
          uVar5 = 0;
        }
        else {
          if (((GameController._instance == null) ||
              (lVar3 = GameController._instance.worldData) == null) ||
             (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
          iVar1 = *(int *)(lVar3 + 132);

          if ((lVar3 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
          if (iVar1 != lVar3.lastRandomWorldEventDay) goto LAB_180b7186a;
          uVar5 = 1;
        }

        if (((lVar3 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) != null) &&
           (uVar4 = AreaData.GetForce(lVar3,0), lVar2 != null)) {
          ResearchUIController.ShowResearchUI(lVar2,uVar5,uVar4,0);
          return;
        }
    }

    // Token : 0x6000DF5
    // RVA   : 0xB71A70   Offset: 0xB70E70   Length: 0x46
    public void ShowWeaponResearch()
    {
        var pStatics = *(int64*)(DAT_181db4ea8 + 184);
        if (*pStatics != 0) {
          WeaponResearchUIController.ShowWeaponResearchUI(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DF6
    // RVA   : 0xB704C0   Offset: 0xB6F8C0   Length: 0x46
    public void ShowMeditation()
    {
        var pStatics = *(int64*)(DAT_181d889a8 + 184);
        if (*pStatics != 0) {
          MeditationUIController.ShowMeditationUI(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000DF7
    // RVA   : 0xB69090   Offset: 0xB68490   Length: 0xAC
    public void ManageForceMoney()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.ManageForceMoneyPlotStart(lVar1,0);
          return;
        }
    }

    // Token : 0x6000DF8
    // RVA   : 0xB695D0   Offset: 0xB689D0   Length: 0x11A6
    public void OpenForceStorage()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        long lVar9;
        ulong uVar10;
        ulong uVar11;
        float fVar12;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong in_stack_ffffffffffffffa8;
        ulong in_stack_ffffffffffffffb0;
        uint uVar13;
        uVar13 = (uint32)((uint64)in_stack_ffffffffffffffb0 >> 32);
        if (((GameController._instance == null) ||
            (GameController._instance.worldData == null)) ||
           (lVar3 = WorldData.Player()) == null) throw; // [null/range check failed]
        iVar1 = *(int *)(lVar3 + 132);

        if ((lVar3 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
        if (iVar1 == lVar3.lastRandomWorldEventDay) {
        LAB_180b6a457:
          if (((GameController._instance != null) &&
              (GameController._instance.worldData != null)) &&
             (lVar3 = WorldData.Player()) != null) {
            if (!lVar3.hour) {
              lVar3 = FUN_18046c6c0(0);
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                 (lVar4 = WorldData.Player()) != null) {
                uVar5 = *(uint64 *)(lVar4 + 0x220);
                lVar4 = FUN_18046bac0(0);
                if (((lVar4 != null) && (*(int64 *)(lVar4 + 88) != 0)) &&
                   ((lVar4 = AreaData.GetForce(), lVar4 != null && (lVar3 != null)))) {
                  TradeUIController.ShowTradeUI
                            (lVar3,2,uVar5,*(uint64 *)(lVar4 + 160),
                             in_stack_ffffffffffffffa8 & 0xffffffffffffff00,0);
                  return;
                }
              }
            }
            else {
              lVar3 = FUN_18046c6c0(0);
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                 (lVar4 = WorldData.Player()) != null) {
                uVar5 = *(uint64 *)(lVar4 + 0x220);
                lVar4 = FUN_18046bac0(0);
                if (((lVar4 != null) && (*(int64 *)(lVar4 + 88) != 0)) &&
                   ((lVar4 = AreaData.GetForce(), lVar4 != null && (lVar3 != null)))) {
                  TradeUIController.ShowTradeUI
                            (lVar3,1,uVar5,*(uint64 *)(lVar4 + 160),
                             in_stack_ffffffffffffffa8 & 0xffffffffffffff00,0);
                  return;
                }
              }
            }
          }
        }
        else {
          lVar3 = PlotController.SpringFestivelRewardLvTalkText;
          if (((lVar3 == null) || (lVar3.TempHeros == null)) ||
             (lVar3 = AreaData.GetForce()) == null) throw; // [null/range check failed]
          if (*(int *)(lVar3 + 60) != -1) {
            lVar3 = FUN_18046bac0(0);
            if (((lVar3 == null) || (lVar3.TempHeros == null)) ||
               (lVar3 = AreaData.GetForce()) == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar3 + 60);
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
               (lVar3 = WorldData.Player()) == null) throw; // [null/range check failed]
            if (iVar1 == *(int *)(lVar3 + 132)) goto LAB_180b6a457;
          }
          if (((GameController._instance == null) ||
              (lVar3 = GameController._instance.worldData) == null) ||
             (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
          cVar2 = HeroData.HaveForce(lVar3,0);
          if (cVar2) {
            lVar3 = FUN_18046bac0(0);
            if ((lVar3 == null) || (lVar3.TempHeros == null)) throw; // [null/range check failed]
            lVar3 = AreaData.GetForce(lVar3.TempHeros,0);
            lVar4 = FUN_18046c0a0(0);
            if ((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null) || (lVar3 == null))
            throw; // [null/range check failed]
            fVar12 = (float)ForceData.GetForceFavor(lVar3,*(uint32 *)(lVar4 + 132),0);
            if (fVar12 <= 40.0) {
              lVar4 = FUN_18046c400(0);
              lVar3 = FUN_18046bac0(0);
              if (((lVar3 == null) || (lVar3.TempHeros == null)) ||
                 (lVar3 = AreaData.GetForce(lVar3.TempHeros,0)) == null)
              throw; // [null/range check failed]
              uVar5 = ForceData.GetForceName(lVar3,1,0);
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                 ((lVar3 = WorldData.Player(lVar3.villageAreaID,0), lVar3 == null ||
                  (lVar3 = HeroData.GetForce(lVar3,0,0)) == null))) throw; // [null/range check failed]
              uVar6 = ForceData.GetForceName(lVar3,1,0);
              uVar5 = String.Format("这{0}素来与我{1}关系不和，\n想必不会将库存物品售卖与我。\n(需要门派好感40以上)",uVar5,uVar6,0);
              uVar6 = new SinglePlotData(uVar5,0,1,0,CONCAT44(uVar13,3),"0",1,0,0);
              if (lVar4 == null) throw; // [null/range check failed]
              goto LAB_180b69c48;
            }
          }
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 != null) && (lVar3.villageAreaID != null)) &&
             (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) != null) {
            cVar2 = HeroData.HaveForce(lVar3,0);
            if (!cVar2) {
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                 (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) == null)
              throw; // [null/range check failed]
              local_res18[0] = lVar3.forceMeetingStarted;
            }
            else {
              lVar3 = FUN_18046bac0(0);
              if ((lVar3 == null) || (lVar3.TempHeros == null)) throw; // [null/range check failed]
              lVar3 = AreaData.GetForce(lVar3.TempHeros,0);
              lVar4 = FUN_18046c0a0(0);
              if ((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                  (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null) || (lVar3 == null))
              throw; // [null/range check failed]
              fVar12 = (float)ForceData.GetForceFavor(lVar3,*(uint32 *)(lVar4 + 132),0);
              local_res18[0] = (uint32)((fVar12 - 50.0) * 0.1);
            }
            lVar3 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar3,DAT_181da3bf0);
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("购买库存;OpenOtherForceStorage;",uVar5,0);
            if (lVar3 != null) {
              FUN_18181e6b0(lVar3,uVar5,DAT_181da3d70);
              FUN_18181e6b0(lVar3,"告辞;HideInteractUI",DAT_181da3d70);
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                 (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) != null) {
                cVar2 = HeroData.HaveServantForce(lVar4,0);
                if (cVar2) {
                  lVar4 = FUN_18046c0a0(0);
                  if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                     (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null)
                  throw; // [null/range check failed]
                  iVar1 = *(int *)(lVar4 + 0x380);
                  lVar4 = FUN_18046bac0(0);
                  if ((lVar4 == null) || (*(int64 *)(lVar4 + 88) == 0)) throw; // [null/range check failed]
                  if (iVar1 == *(int *)(*(int64 *)(lVar4 + 88) + 112)) {
                    uVar5 = Int32.ToString(local_res18,0);
                    uVar5 = String.Concat("功绩兑换;OpenServantForceStorage;",uVar5,0);
                    FUN_181822b30(lVar3,1,uVar5,DAT_181da4070);
                  }
                }
                lVar4 = FUN_18046c400(0);
                lVar7 = FUN_18046c0a0(0);
                if (((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) &&
                   (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) != null) {
                  cVar2 = HeroData.HaveForce(lVar7,0);
                  uVar5 = "鉴于我现在的{4}地位，\n{0}愿意将最高等级为{3}的库存物品售卖给我。";
                  if (cVar2) {
                    uVar5 = "这{0}与我{1}的关系为{2}，\n因此愿意将最高等级为{3}的库存物品售卖给我。";
                  }
                  plVar8 = (int64 *)FUN_1800d60b0(DAT_181da4138,5);
                  lVar7 = FUN_18046bac0(0);
                  if (((lVar7 != null) && (*(int64 *)(lVar7 + 88) != 0)) &&
                     ((lVar7 = AreaData.GetForce(*(int64 *)(lVar7 + 88),0), lVar7 != null &&
                      (lVar7 = ForceData.GetForceName(lVar7,1,0), plVar8 != (int64 *)0)))) {
                    if ((lVar7 != null) &&
                       (lVar9 = il2cpp_internal(lVar7,*(uint64 *)(*plVar8 + 64))) == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                    if ((int)plVar8[3] == 0) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                    plVar8[4] = lVar7;
                    il2cpp_internal(plVar8 + 4,lVar7);
                    lVar7 = FUN_18046c0a0(0);
                    if (((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) &&
                       (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) != null) {
                      lVar9 = HeroData.GetForce(lVar7,0,0);
                      lVar7 = "";
                      if (lVar9 != null) {
                        lVar7 = FUN_18046c0a0(0);
                        if (((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
                           ((lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0), lVar7 == null ||
                            (lVar7 = HeroData.GetForce(lVar7,0,0)) == null))) throw; // [null/range check failed]
                        lVar7 = ForceData.GetForceName(lVar7,1,0);
                      }
                      if ((lVar7 != null) &&
                         (lVar9 = il2cpp_internal(lVar7,*(uint64 *)(*plVar8 + 64))) == null)
                      {
                        uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar5,0);
                      }
                      if (*(uint32 *)(plVar8 + 3) < 2) {
                        uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar5,0);
                      }
                      plVar8[5] = lVar7;
                      il2cpp_internal(plVar8 + 5,lVar7);
                      lVar7 = FUN_18046bac0(0);
                      if ((lVar7 != null) && (*(int64 *)(lVar7 + 88) != 0)) {
                        lVar7 = AreaData.GetForce(*(int64 *)(lVar7 + 88),0);
                        lVar9 = FUN_18046c0a0(0);
                        if ((((lVar9 != null) && (*(int64 *)(lVar9 + 32) != 0)) &&
                            (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) != null) &&
                           (lVar7 != null)) {
                          local_res20[0] = ForceData.GetForceFavor(lVar7,*(uint32 *)(lVar9 + 132),0)
                          ;
                          lVar7 = il2cpp_value_box(DAT_181da22f0,local_res20);
                          if ((lVar7 != null) &&
                             (lVar9 = il2cpp_internal(lVar7,*(uint64 *)(*plVar8 + 64)),
                             lVar9 == null)) {
                            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar5,0);
                          }
                          if (*(uint32 *)(plVar8 + 3) < 3) {
                            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar5,0);
                          }
                          plVar8[6] = lVar7;
                          il2cpp_internal(plVar8 + 6,lVar7);
                          uVar10 = (uint64)(int)local_res18[0];
                          lVar7 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x4f0);
                          if (lVar7 != null) {
                            uVar11 = uVar10;
                            if (*(uint32 *)(lVar7 + 24) <= local_res18[0]) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              uVar11 = (uint64)local_res18[0];
                            }
                            lVar7 = GlobalData.GenerateRareLvColorText
                                              (*(uint64 *)
                                                (*(int64 *)(lVar7 + 16) + 32 + uVar10 * 8),uVar11,0
                                              );
                            if ((lVar7 != null) &&
                               (lVar9 = il2cpp_internal(lVar7,*(uint64 *)(*plVar8 + 64)),
                               lVar9 == null)) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            if (*(uint32 *)(plVar8 + 3) < 4) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            plVar8[7] = lVar7;
                            il2cpp_internal(plVar8 + 7,lVar7);
                            lVar7 = FUN_18046c0a0(0);
                            if (((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) &&
                               (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) != null) {
                              lVar7 = HeroData.GetHeroForceLvDescribe(lVar7,0,0);
                              if ((lVar7 != null) &&
                                 (lVar9 = il2cpp_internal(lVar7,*(uint64 *)(*plVar8 + 64)),
                                 lVar9 == null)) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(plVar8 + 3) < 5) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              plVar8[8] = lVar7;
                              il2cpp_internal(plVar8 + 8,lVar7);
                              uVar5 = String.Format(uVar5,plVar8,0);
                              uVar6 = il2cpp_internal(DAT_181da24f0);
                              SinglePlotData.ctor
                                        (uVar6,uVar5,lVar3,1,0,CONCAT44(uVar13,3),"0",1,0,0);
                              if (lVar4 != null) {
        LAB_180b69c48:
                                PlotController.ChangePlot(lVar4,uVar6,0);
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

    // Token : 0x6000DF9
    // RVA   : 0xB69240   Offset: 0xB68640   Length: 0xAC
    public void ManageForceStorage()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.StartSetForceStorageDiscount(lVar1,0);
          return;
        }
    }

    // Token : 0x6000DFA
    // RVA   : 0xB786D0   Offset: 0xB77AD0   Length: 0x5E5
    public void StealForceResource()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar1 = PlotController.SpringFestivelRewardLvTalkText;
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 88)) != null) {
          lVar1 = AreaData.GetForce(lVar1,0);
          if ((lVar1 != null) && (*(int64 *)(lVar1 + 0x168) != 0)) {
            if (*(int *)(*(int64 *)(lVar1 + 0x168) + 24) < 1) {
              lVar1 = BuildingUIController.PartyLvName;
              uVar4 = "本月已窃取过{0}之仓库。\n此时守备森严，已然无从下手，还需另待良机才是。";
              if (*(char *)(pStatics_3d40 + 4) != false) {
                uVar4 = "本月已挑战过{0}之仓库。\n还需另待良机才是。";
              }
              lVar2 = PlotController.SpringFestivelRewardLvTalkText;
              if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 88)) == null) throw; // [null/range check failed]
              lVar2 = AreaData.GetForce(lVar2,0);
              if (lVar2 == null) throw; // [null/range check failed]
              uVar3 = ForceData.GetForceName(lVar2,1);
              uVar4 = String.Format(uVar4,uVar3);
              uVar3 = il2cpp_internal(DAT_181da24f0);
              lVar2 = 0;
            }
            else {
              lVar1 = BuildingUIController.PartyLvName;
              uVar4 = "此地乃是{0}储藏资源宝物之所，若能花费五日时间，\n想必可打探出一条潜入道路，从中窃取资源或宝物以为己用。";
              if (*(char *)(pStatics_3d40 + 4) != false) {
                uVar4 = "此地乃是{0}储藏资源宝物之所，若能花费五日时间准备进行江湖挑战。\n如果挑战成功，就可以赢取仓库内资源或物品。";
              }
              lVar2 = PlotController.SpringFestivelRewardLvTalkText;
              if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 88)) == null) throw; // [null/range check failed]
              lVar2 = AreaData.GetForce(lVar2,0);
              if (lVar2 == null) throw; // [null/range check failed]
              uVar3 = ForceData.GetForceName(lVar2,1,0);
              uVar4 = String.Format(uVar4,uVar3,0);
              lVar2 = il2cpp_internal(DAT_181d97768);
              FUN_181330100(lVar2,DAT_181da3bf0);
              uVar3 = "开始准备";
              if (*(char *)(pStatics_3d40 + 4) == false) {
                uVar3 = "开始潜入";
              }
              uVar3 = String.Format("{0};StealForceResourceStart",uVar3,0);
              if (lVar2 == null) throw; // [null/range check failed]
              FUN_18181e6b0(lVar2,uVar3,DAT_181da3d70);
              FUN_18181e6b0(lVar2,"还是算了;HideInteractUI");
              uVar3 = il2cpp_internal(DAT_181da24f0);
            }
            SinglePlotData.ctor(uVar3,uVar4,lVar2,1,0,3,"0",1,0,0);
            if (lVar1 != null) {
              PlotController.ChangePlot(lVar1,uVar3,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000DFB
    // RVA   : 0xB78CC0   Offset: 0xB780C0   Length: 0x5A1
    public void StealForceSkill()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        uint[] local_res8 = new uint[2];
        if (this.buildingData != null) {
          if (0 < this.buildingData.enemyMonth) {
            lVar5 = BuildingUIController.PartyLvName;
            uVar3 = "不久前刚偷师过{0}之武学，此刻守备森严，已然无从下手。\n至少要等{1}个月后风平浪静，方可另择良机。";
            if (*(char *)(pStatics_3d40 + 4) != false) {
              uVar3 = "不久前刚挑战过{0}之藏经阁。\n至少要等{1}个月后风平浪静，方可另择良机。";
            }
            lVar1 = PlotController.SpringFestivelRewardLvTalkText;
            if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 88)) != null) {
              lVar1 = AreaData.GetForce(lVar1,0);
              if (lVar1 != null) {
                uVar2 = ForceData.GetForceName(lVar1,1,0);
                if (this.buildingData != null) {
                  local_res8[0] = this.buildingData.enemyMonth;
                  uVar4 = il2cpp_value_box(DAT_181d80430,local_res8);
                  uVar3 = String.Format(uVar3,uVar2,uVar4,0);
                  uVar2 = new SinglePlotData(uVar3,0,1,0,3,"0",1,0,0);
                  if (lVar5 != null) goto LAB_180b79045;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = BuildingUIController.PartyLvName;
          uVar3 = "此地乃是{0}藏经习武之所，若想打探出一条潜入道路，非得花费十日时间不可。\n只是此处亦是门派守卫最为森严之处，若无万全准备，切不可贸然行动。";
          if (*(char *)(pStatics_3d40 + 4) != false) {
            uVar3 = "此地乃是{0}藏经习武之所，可以花费十日时间准备进行江湖挑战。\n如果挑战成功，就可以赢取藏经阁内一本秘籍。";
          }
          lVar1 = PlotController.SpringFestivelRewardLvTalkText;
          if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 88)) != null) {
            lVar1 = AreaData.GetForce(lVar1,0);
            if (lVar1 != null) {
              uVar2 = ForceData.GetForceName(lVar1,1,0);
              uVar3 = String.Format(uVar3,uVar2,0);
              lVar1 = il2cpp_internal(DAT_181d97768);
              FUN_181330100(lVar1,DAT_181da3bf0);
              uVar2 = "开始准备";
              if (*(char *)(pStatics_3d40 + 4) == false) {
                uVar2 = "开始潜入";
              }
              uVar2 = String.Format("{0};StealForceSkillStart",uVar2,0);
              if (lVar1 != null) {
                FUN_18181e6b0(lVar1,uVar2,DAT_181da3d70);
                FUN_18181e6b0(lVar1,"还是算了;HideInteractUI");
                uVar2 = new SinglePlotData(uVar3,lVar1,1,0,3,"0",1,0,0);
                if (lVar5 != null) {
        LAB_180b79045:
                  PlotController.ChangePlot(lVar5,uVar2,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000DFC
    // RVA   : 0xB6A780   Offset: 0xB69B80   Length: 0xAC
    public void OpenSelfStorage()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.OpenSelfStorage(lVar1,0);
          return;
        }
    }

    // Token : 0x6000DFD
    // RVA   : 0xB68C70   Offset: 0xB68070   Length: 0x228
    public void ManageBookStore()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dad390 + 184) + 8);
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            uVar2 = lVar3.speBookStorageSpeAdd;

            if ((lVar3 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56)?.TempHeros) != null) {
              lVar3 = AreaData.GetForce(lVar3,0);
              if ((lVar3 != null) && (lVar1 != null)) {
                TradeUIController.ShowTradeUI(lVar1,1,3,uVar2,lVar3.forceMeetingStarted,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000DFE
    // RVA   : 0xB6DB00   Offset: 0xB6CF00   Length: 0xFA
    public void ShowBookStore()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181db2838 + 184);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
          uVar3 = AreaData.GetForce(lVar2,0);
          if (lVar1 != null) {
            BookStoreController.ShowBookStoreUI(lVar1,0,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000DFF
    // RVA   : 0xB62ED0   Offset: 0xB622D0   Length: 0xC0
    public void ChooseReadBook()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.ChooseReadBook(lVar1,"false",0);
          return;
        }
    }

    // Token : 0x6000E00
    // RVA   : 0xB79270   Offset: 0xB78670   Length: 0x350
    public void StudyFightMoney()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        iVar6 = 0;
        do {
          uVar7 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
          lVar1 = *(int64 *)(pStatics + 0x4a0);
          if (lVar1 == null) {
        LAB_180b795b5:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int *)(lVar1 + 24) <= iVar6) {
            if (lVar2 != null) {
              FUN_18181e6b0(lVar2,"取消;HideInteractUI",DAT_181da3d70);
              lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
              uVar3 = FUN_180228420(DAT_181d8b158);
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
            goto LAB_180b795b5;
          }
          lVar1 = *(int64 *)(pStatics + 0x4a0);
          if (lVar1 == null) {
        LAB_180b795bb:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = FUN_180002f80(lVar1,iVar6,DAT_181da4370);
          local_res18[0] = iVar6;
          uVar4 = il2cpp_value_box(DAT_181d80430,local_res18);
          uVar3 = String.Format("修炼{0};StudyFightSelfChooseMoney;{1}",uVar3,uVar4,0);
          if (lVar2 == null) goto LAB_180b795bb;
          FUN_18181e6b0(lVar2,uVar3,DAT_181da3d70);
          iVar6 = iVar6 + 1;
        } while( true );
    }

    // Token : 0x6000E01
    // RVA   : 0xB795D0   Offset: 0xB789D0   Length: 0x391
    public void StudyFightOtherMoney()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        iVar6 = 0;
        do {
          uVar7 = (uint32)((uint64)in_stack_ffffffffffffff88 >> 32);
          lVar1 = *(int64 *)(pStatics + 0x418);
          if (lVar1 == null) {
        LAB_180b79956:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int *)(lVar1 + 24) <= iVar6) {
            if (lVar2 != null) {
              FUN_18181e6b0(lVar2,"取消;HideInteractUI",DAT_181da3d70);
              uVar8 = 0;
              lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
              uVar3 = BuildingUIController.GenerateBuildingNPCString
                                (this,"武师",0xffffffff,0xffffffff,CONCAT44(uVar7,0xffffffff),0)
              ;
              uVar4 = il2cpp_internal(DAT_181da24f0);
              SinglePlotData.ctor
                        (uVar4,"不知大侠想雇佣何种级别的武师进行陪练？\n须知武师级别越高，出场费自然也越贵。",lVar2,5,uVar3,CONCAT44(uVar8,3),"0",0,0,0);
              if (lVar1 != null) {
                PlotController.ChangePlot(lVar1,uVar4,0);
                return;
              }
            }
            goto LAB_180b79956;
          }
          lVar1 = *(int64 *)(pStatics + 0x418);
          if (lVar1 == null) {
        LAB_180b7995c:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = FUN_180002f80(lVar1,iVar6,DAT_181da4370);
          local_res18[0] = iVar6;
          uVar4 = il2cpp_value_box(DAT_181d80430,local_res18);
          local_res20[0] = (float)FUN_1801f8ab0(0x40000000);
          local_res20[0] = local_res20[0] * 10.0;
          uVar5 = il2cpp_value_box(DAT_181da22f0,local_res20);
          in_stack_ffffffffffffff88 = 0;
          uVar3 = String.Format("{0};StudyFightOtherMoneyChoose;{1};0/{2}",uVar3,uVar4,uVar5,0);
          if (lVar2 == null) goto LAB_180b7995c;
          FUN_18181e6b0(lVar2,uVar3,DAT_181da3d70);
          iVar6 = iVar6 + 1;
        } while( true );
    }

    // Token : 0x6000E02
    // RVA   : 0xB62CB0   Offset: 0xB620B0   Length: 0x217
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        if (lVar2 != null) {
          FUN_18181e6b0(lVar2,"选择秘籍;ChooseReadBook;true",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"取消;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000E03
    // RVA   : 0xB60FD0   Offset: 0xB603D0   Length: 0x4A9
    public void AttackMartialClub()
    {
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
        if ((GameController._instance == null) ||
           (lVar1 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        if (lVar1.monthAttackMartialClubTime < 1) {
          if (((this.buildingData == null) ||
              (lVar1 = this.buildingData.shopItemList) == null) ||
             (lVar1 = lVar1.Areas) == null) throw; // [null/range check failed]
          if (lVar1.cityAreaID < 4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(lVar1.chapter + 56);
          if (lVar1 == null) throw; // [null/range check failed]
          if (lVar1.cityAreaID != null) {
            lVar1 = FUN_18046c400(0);
            if ((this.buildingData == null) ||
               (lVar2 = AreaBuildingData.DataBase(this.buildingData,0)) == null)
            throw; // [null/range check failed]
            uVar3 = String.Format("大侠目露凶光，气势逼人，莫不是来踢馆的？\n武林中人向来以和为贵，还望大侠三思啊！",*(uint64 *)(lVar2 + 24),0);
            lVar2 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar2,DAT_181da3bf0);
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_18181e6b0(lVar2,"没错！;AttackMartialClubStart",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"开个玩笑;HideInteractUI",DAT_181da3d70);
            uVar7 = 0;
            uVar4 = BuildingUIController.GenerateBuildingNPCString
                              (this,"武师",0xffffffff,0xffffffff,CONCAT44(uVar6,0xffffffff),0);
            uVar5 = new SinglePlotData(uVar3,lVar2,5,uVar4,CONCAT44(uVar7,3),"0",0,0,0);
            if (lVar1 == null) throw; // [null/range check failed]
            goto LAB_180b6144b;
          }
          lVar1 = FUN_18046c400(0);
          uVar3 = FUN_180228420(DAT_181d8b158);
          uVar3 = String.Format("这破武馆中似乎已无秘籍藏品了，又有何踢馆的必要呢？",uVar3,0);
          uVar5 = il2cpp_internal(DAT_181da24f0);
        }
        else {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
          uVar3 = FUN_180228420(DAT_181d8b158);
          uVar3 = String.Format("这个月已在此武馆大闹过一场，\n还需低调些时日避避风头，免得引起武林公愤。",uVar3,0);
          uVar5 = il2cpp_internal(DAT_181da24f0);
        }
        SinglePlotData.ctor(uVar5,uVar3,0,1,0,CONCAT44(uVar7,3),"0",1,0,0);
        if (lVar1 != null) {
        LAB_180b6144b:
          PlotController.ChangePlot(lVar1,uVar5,0);
          return;
        }
    }

    // Token : 0x6000E04
    // RVA   : 0xB6DCB0   Offset: 0xB6D0B0   Length: 0x1D7
    public void ShowBookWriter()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181db29d0 + 184) + 8);
        lVar3 = PlotController.SpringFestivelRewardLvTalkText;
        if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 88)) != null) {
          lVar3 = AreaData.GetForce(lVar3,0);
          if (lVar3 != null) {
            uVar2 = *(uint64 *)(lVar3 + 176);
            lVar3 = PlotController.SpringFestivelRewardLvTalkText;
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

    // Token : 0x6000E05
    // RVA   : 0xB6DC00   Offset: 0xB6D000   Length: 0xAC
    public void ShowBookWriterSelf()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.ShowBookWriterSelf(lVar1,0);
          return;
        }
    }

    // Token : 0x6000E06
    // RVA   : 0xB6E080   Offset: 0xB6D480   Length: 0x17D
    public void ShowBuildingShop()
    {
        long lVar1;
        long lVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dad390 + 184) + 8);
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if ((lVar2 != null) && ((this.buildingData != null && (lVar1 != null)))) {
            TradeUIController.ShowTradeUI
                      (lVar1,0,lVar2.speBookStorageSpeAdd,
                       this.buildingData.shopItemList,1,0);
            return;
          }
        }
    }

    // Token : 0x6000E07
    // RVA   : 0xB6DEF0   Offset: 0xB6D2F0   Length: 0x180
    public void ShowBuildingShopForceStorage()
    {
        long lVar1;
        long lVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dad390 + 184) + 8);
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if ((lVar2 != null) && ((this.buildingData != null && (lVar1 != null)))) {
            TradeUIController.ShowTradeUI
                      (lVar1,2,lVar2.speBookStorageSpeAdd,
                       this.buildingData.shopItemList,0,0);
            return;
          }
        }
    }

    // Token : 0x6000E08
    // RVA   : 0xB784B0   Offset: 0xB778B0   Length: 0x211
    public void StealBuildingShop()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        float fVar4;
        uint[] local_res18 = new uint[4];
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        fVar4 = (float)BuildingUIController.GetBuildingHeroLv(this,0);
        local_res18[0] = Mathf.RoundToInt((fVar4 + 1.0) * 25.0,0);
        uVar3 = Int32.ToString(local_res18,0);
        uVar3 = String.Concat("潜入库房;StealBuildingShopStart;;;;Dodge/",uVar3,0);
        if (lVar2 != null) {
          FUN_18181e6b0(lVar2,uVar3,DAT_181da3d70);
          FUN_18181e6b0(lVar2,"还是算了;HideInteractUI",DAT_181da3d70);
          uVar3 = new SinglePlotData("嘿嘿，眼下趁着店家不备，可以潜入库房中去。\n虽说库房内堆放的商品大多不是精品，但能免费顺走也是美事一桩啊！",lVar2,1,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000E09
    // RVA   : 0xB6D8E0   Offset: 0xB6CCE0   Length: 0x216
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        if (lVar2 != null) {
          FUN_18181e6b0(lVar2,"我要打劫！;RobBuildingShopStart",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"没事没事;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000E0A
    // RVA   : 0xB6DE90   Offset: 0xB6D290   Length: 0x5E
    public void ShowBuildingMission()
    {
        var pStatics = *(int64*)(DAT_181db30b8 + 184);
        if ((this.buildingChoiceSelected != null) && (*pStatics != 0)) {
          BountyUIController.ShowBountyUI
                    (*pStatics,this.buildingData,
                     this.buildingChoiceSelected.text,0);
          return;
        }
    }

    // Token : 0x6000E0B
    // RVA   : 0xB70510   Offset: 0xB6F910   Length: 0x6AA
    public void ShowOtherForceMission()
    {
        var pStatics_30b8 = *(int64*)(DAT_181db30b8 + 184);
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        float fVar8;
        if (((GameController._instance == null) ||
            (lVar2 = GameController._instance.worldData) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        if (100.0 < *(float *)(lVar2 + 0x1c4) || *(float *)(lVar2 + 0x1c4) == 100.0) {
        LAB_180b70916:
          if (((GameController._instance == null) ||
              (lVar2 = GameController._instance.worldData) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          lVar2 = HeroData.GetForce(lVar2,0,0);
          if (lVar2 != null) {
            if (((GameController._instance == null) ||
                (lVar2 = GameController._instance.worldData) == null) ||
               (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
            lVar2 = HeroData.GetForce(lVar2,0,0);
            lVar5 = PlotController.SpringFestivelRewardLvTalkText;
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) || (lVar2 == null))
            throw; // [null/range check failed]
            fVar8 = (float)ForceData.GetForceFavor(lVar2,*(uint32 *)(lVar5 + 112),0);
            if (fVar8 < 40.0) {
              lVar2 = FUN_18046c400(0);
              uVar3 = FUN_180228420(DAT_181d8b158);
              uVar4 = "#PlayerForceName#与本门不甚和睦，恐怕还不能将本门任务委托于你。\n(需要至少40点门派好感。)";
              goto LAB_180b707f5;
            }
          }
          if ((this.buildingChoiceSelected != null) && (*pStatics_30b8 != 0)) {
            BountyUIController.ShowBountyUI
                      (*pStatics_30b8,this.buildingData,
                       this.buildingChoiceSelected.text,0);
            return;
          }
        }
        else {
          if (((GameController._instance == null) ||
              (lVar2 = GameController._instance.worldData) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          iVar1 = *(int *)(lVar2 + 0x380);

          if ((lVar2 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
          if (iVar1 == lVar2.lastRandomWorldEventDay) goto LAB_180b70916;
          lVar2 = FUN_18046c400(0);
          uVar3 = FUN_180228420(DAT_181d8b158);
          uVar4 = "#PlayerName#的江湖声望太低，若将本门任务委托于你，只怕难以服众。\n(需要至少100点声望。)";
        LAB_180b707f5:
          uVar4 = String.Format(uVar4,uVar3,0);
          lVar5 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar5,DAT_181da3bf0);
          if (lVar5 != null) {
            FUN_18181e6b0(lVar5,"是我唐突了;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000E0C
    // RVA   : 0xB6F560   Offset: 0xB6E960   Length: 0x785
    public void ShowContributionExchange()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        float fVar8;
        if (((GameController._instance == null) ||
            (lVar2 = GameController._instance.worldData) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        if (100.0 < *(float *)(lVar2 + 0x1c4) || *(float *)(lVar2 + 0x1c4) == 100.0) {
        LAB_180b6f976:
          if (((GameController._instance == null) ||
              (lVar2 = GameController._instance.worldData) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          lVar2 = HeroData.GetForce(lVar2,0,0);
          if (lVar2 != null) {
            if (((GameController._instance == null) ||
                (lVar2 = GameController._instance.worldData) == null) ||
               (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
            lVar2 = HeroData.GetForce(lVar2,0,0);
            lVar5 = PlotController.SpringFestivelRewardLvTalkText;
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 88)) == null) || (lVar2 == null))
            throw; // [null/range check failed]
            fVar8 = (float)ForceData.GetForceFavor(lVar2,*(uint32 *)(lVar5 + 112),0);
            if (fVar8 < 40.0) {
              lVar2 = FUN_18046c400(0);
              uVar3 = FUN_180228420(DAT_181d8b158);
              uVar4 = "#PlayerForceName#与本门不甚和睦，恐怕还不能将本门秘藏兑换于你。\n(需要至少40点门派好感。)";
              goto LAB_180b6f851;
            }
          }
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d8f4a8 + 184) + 16);
          lVar5 = PlotController.SpringFestivelRewardLvTalkText;
          if (((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 88)) != null) &&
             (uVar4 = AreaData.GetForce(lVar5,0), lVar2 != null)) {
            OtherForceContributionExchangeController.ShowExchangeUI(lVar2,uVar4,0);
            return;
          }
        }
        else {
          if (((GameController._instance == null) ||
              (lVar2 = GameController._instance.worldData) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          iVar1 = *(int *)(lVar2 + 0x380);

          if ((lVar2 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) throw; // [null/range check failed]
          if (iVar1 == lVar2.lastRandomWorldEventDay) goto LAB_180b6f976;
          lVar2 = FUN_18046c400(0);
          uVar3 = FUN_180228420(DAT_181d8b158);
          uVar4 = "#PlayerName#的江湖声望太低，若将本门秘藏兑换于你，只怕难以服众。\n(需要至少100点声望。)";
        LAB_180b6f851:
          uVar4 = String.Format(uVar4,uVar3,0);
          lVar5 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar5,DAT_181da3bf0);
          if (lVar5 != null) {
            FUN_18181e6b0(lVar5,"是我唐突了;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000E0D
    // RVA   : 0xB70BC0   Offset: 0xB6FFC0   Length: 0x9FC
    public void ShowReplaceOtherForce()
    {
        float fVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        float fVar8;
        uint[] local_res18 = new uint[4];
        lVar3 = PlotController.SpringFestivelRewardLvTalkText;
        if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 88)) != null) {
          lVar3 = AreaData.GetForce(lVar3,0);
          if (((GameController._instance == null) ||
              (lVar6 = GameController._instance.worldData) == null) ||
             (uVar4 = WorldData.Player(lVar6,0), lVar3 == null)) throw; // [null/range check failed]
          cVar2 = ForceData.MeetForceSexLimit(lVar3,uVar4);
          if (!cVar2) {
            lVar3 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
            if (((GameController._instance == null) ||
                (lVar6 = GameController._instance.worldData) == null) ||
               (lVar6 = WorldData.Player(lVar6,0), uVar4 = "身为{0}性，恐怕无法在{1}自立门户啊......") == null)
            throw; // [null/range check failed]
            uVar5 = "女";
            if (!lVar6.WorldEventDatas) {
              uVar5 = "男";
            }

            if (((lVar6 = PlotController.SpringFestivelRewardLvTalkText?.TempHeros) == null) ||
               (lVar6 = AreaData.GetForce(lVar6,0)) == null) throw; // [null/range check failed]
            uVar7 = ForceData.GetForceName(lVar6,1,0);
            uVar5 = String.Format(uVar4,uVar5,uVar7,0);
            uVar4 = new SinglePlotData(uVar5,0,1,0,3,"0",1,0,0);
          }
          else {
            lVar3 = PlotController.SpringFestivelRewardLvTalkText;
            if ((((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 88)) == null) ||
                (lVar3 = AreaData.GetForce(lVar3,0)) == null) || (*(int64 *)(lVar3 + 96) == 0))
            throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar3 + 96) + 24) < 5) {
              lVar3 = FUN_18046c0a0(0);
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
              if (0 < *(int *)(*(int64 *)(lVar3 + 32) + 204)) {
                lVar3 = FUN_18046c400(0);
                lVar6 = FUN_18046c0a0(0);
                if ((lVar6 == null) || (lVar6.villageAreaID == null)) {
        LAB_180b715b7:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_res18[0] = *(uint32 *)(lVar6.villageAreaID + 204);
                uVar4 = il2cpp_value_box(DAT_181d80430,local_res18);
                uVar5 = String.Format("此前不久才刚刚挑战过门派。\n还需等待{0}天后风平浪静，方能避免引起武林公愤。",uVar4);
                uVar4 = new SinglePlotData(uVar5,0,1,0,3,"0",1,0,0);
                if (lVar3 == null) goto LAB_180b715b7;
                goto LAB_180b710eb;
              }
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null)
              throw; // [null/range check failed]
              fVar1 = *(float *)(lVar3 + 0x1c4);
              lVar3 = FUN_18046bac0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 88) == 0)) ||
                 (lVar3 = AreaData.GetCenterBuilding(*(int64 *)(lVar3 + 88),0)) == null)
              throw; // [null/range check failed]
              fVar8 = (float)Mathf.Max(0x42c80000,(float)*(int *)(lVar3 + 20) * 200.0);
              if (fVar1 < fVar8) {
                lVar3 = FUN_18046c400(0);
                lVar6 = FUN_18046bac0(0);
                if (((lVar6 != null) && (lVar6.TempHeros != null)) &&
                   (lVar6 = AreaData.GetCenterBuilding(lVar6.TempHeros,0)) != null) {
                  local_res18[0] = Mathf.Max(0x42c80000,(float)*(int *)(lVar6 + 20) * 200.0);
                  uVar4 = il2cpp_value_box(DAT_181da22f0,local_res18);
                  uVar5 = String.Format("我在江湖中尚未积累足够的声望，若想在此开宗立派，恐怕还难以服众。\n(在此总舵开宗立派需至少{0}点声望)",uVar4);
                  uVar4 = new SinglePlotData(uVar5,0,1,0,3,"0",1,0,0);
                  if (lVar3 != null) goto LAB_180b710eb;
                }
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null)
              throw; // [null/range check failed]
              cVar2 = HeroData.HaveServantForce(lVar3,0);
              if (!cVar2) {
                lVar3 = FUN_18046c400(0);
                if (lVar3 != null) {
                  PlotController.StartReplaceOtherForcePlot(lVar3,0);
                  return;
                }
                throw; // [null/range check failed]
              }
              lVar3 = FUN_18046c400(0);
              uVar5 = FUN_180228420(DAT_181d8b158);
              uVar4 = "我眼下已是#PlayerForceDescribe#。\n需要先结束门客关系，方可自立门户。";
            }
            else {
              lVar3 = FUN_18046c400(0);
              uVar5 = FUN_180228420(DAT_181d8b158);
              uVar4 = "对方门派占据区域已超过四处，称得上是名门大派。\n我这种江湖人士上门挑战，对方想必不会应允，而且还可能引起武林公愤。\n(对方门派占领区域不可超过4处)";
            }
            uVar5 = String.Format(uVar4,uVar5);
            uVar4 = new SinglePlotData(uVar5,0,1,0,3,"0",1,0,0);
          }
          if (lVar3 != null) {
        LAB_180b710eb:
            PlotController.ChangePlot(lVar3,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000E0E
    // RVA   : 0xB700A0   Offset: 0xB6F4A0   Length: 0x1AD
    public void ShowFreeTrade()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        lVar2 = **(int64 **)(DAT_181d71ab8 + 184);
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            cVar1 = lVar3.hour;
            if ((GameController._instance != null) &&
               (lVar3 = GameController._instance.worldData) != null) {
              uVar4 = WorldData.GetHeroForce(lVar3,0,0);
              if (lVar2 != null) {
                FreeTradeUIController.ShowFreeTradeUI(lVar2,cVar1,uVar4,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000E0F
    // RVA   : 0xB70320   Offset: 0xB6F720   Length: 0xC0
    public void ShowGovernLv()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.GovernPlotStart(lVar1,"0",0);
          return;
        }
    }

    // Token : 0x6000E10
    // RVA   : 0xB703F0   Offset: 0xB6F7F0   Length: 0xC0
    public void ShowHornorPlot()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.HornorPlotStart(lVar1,"0",0);
          return;
        }
    }

    // Token : 0x6000E11
    // RVA   : 0xB70250   Offset: 0xB6F650   Length: 0xC0
    public void ShowGovernContribution()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.ShowGovernShop(lVar1,"0",0);
          return;
        }
    }

    // Token : 0x6000E12
    // RVA   : 0xB65B70   Offset: 0xB64F70   Length: 0x596
    public void GovernmentClearBadFame()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if (((GameController._instance == null) ||
            (lVar1 = GameController._instance.worldData) == null) ||
           (lVar1 = WorldData.Player(lVar1,0)) == null) throw; // [null/range check failed]
        if (lVar1.thisYearExploreSpeEventNum <= 0.0) {
          lVar1 = BuildingUIController.PartyLvName;
          uVar4 = new SinglePlotData("我目前在江湖中并无恶名，何必庸人自扰。",0,1,0,CONCAT44(uVar7,3),"0",1,0,0);
        }
        else {
          lVar1 = BuildingUIController.PartyLvName;
          uVar4 = "少侠目前在江湖中恶名为{0}，是否要洗心革面，重归正道呢？";
          if (*(char *)(pStatics_3d40 + 4) != false) {
            uVar4 = "少侠目前在江湖中威慑为{0}，是否要降低威慑呢？";
          }
          if (((GameController._instance == null) ||
              (lVar2 = GameController._instance.worldData) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          uVar3 = Single.ToString(lVar2 + 0x1c8,"f0",0);
          uVar3 = String.Format(uVar4,uVar3,0);
          lVar2 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar2,DAT_181da3bf0);
          if (lVar2 == null) throw; // [null/range check failed]
          FUN_18181e6b0(lVar2,"缴纳罚金;GovernmentClearBadFame;0",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"牺牲声望;GovernmentClearBadFame;1",DAT_181da3d70);
          uVar4 = "自愿思过";
          if (*(char *)(pStatics_3d40 + 4) == false) {
            uVar4 = "自首入狱";
          }
          uVar4 = String.Format("{0};GovernmentClearBadFame;2",uVar4,0);
          FUN_18181e6b0(lVar2,uVar4,DAT_181da3d70);
          FUN_18181e6b0(lVar2,"还是算了;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000E13
    // RVA   : 0xB694F0   Offset: 0xB688F0   Length: 0xD8
    public int MaxGambleTime()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
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

    // Token : 0x6000E14
    // RVA   : 0xB76810   Offset: 0xB75C10   Length: 0x2D2
    public void StartGamble()
    {
        int iVar1;
        long lVar2;
        int iVar3;
        uint uVar4;
        ulong uVar5;
        ulong uVar6;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          iVar1 = lVar2.monthGambleTime;
          iVar3 = BuildingUIController.MaxGambleTime(this,0);
          if (iVar1 < iVar3) {
            lVar2 = BuildingUIController.PartyLvName;
            if (lVar2 != null) {
              PlotController.ChooseGambleTarget(lVar2,0);
              return;
            }
          }
          else {
            lVar2 = BuildingUIController.PartyLvName;
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

    // Token : 0x6000E15
    // RVA   : 0xB653D0   Offset: 0xB647D0   Length: 0x4B6
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
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181da4138,7);
        lVar3 = *(int64 *)(*(int64 *)(DAT_181db4020 + 184) + 24);
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
            lVar3 = il2cpp_value_box(DAT_181d80430,local_res18);
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
            lVar3 = il2cpp_value_box(DAT_181d80430,&local_38);
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
            local_34 = (float)FUN_1801f8ab0(0x40000000);
            local_34 = local_34 * 100.0;
            lVar3 = il2cpp_value_box(DAT_181da22f0,&local_34);
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
              lVar3 = il2cpp_value_box(DAT_181da22f0,&local_30);
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
                lVar3 = il2cpp_value_box(DAT_181da22f0,local_2c);
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

    // Token : 0x6000E16
    // RVA   : 0xB778C0   Offset: 0xB76CC0   Length: 0xAC5
    public void StartParty()
    {
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
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
        if (*(float *)(lVar3 + 0x1c4) <= 100.0 && *(float *)(lVar3 + 0x1c4) != 100.0) {
          lVar3 = BuildingUIController.PartyLvName;
          uVar5 = il2cpp_internal(DAT_181da24f0);
          uVar4 = "若是连100点声望都没有就贸然举办宴会，怕是没人会赏脸参加呀。";
        }
        else {
          if ((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          if (lVar3.monthPartyTime < 3) {
            lVar3 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar3,DAT_181da3bf0);
            iVar9 = 0;
            while( true ) {
              uVar12 = (uint32)((uint64)in_stack_ffffffffffffff98 >> 32);
              lVar2 = *(int64 *)(*(int64 *)(DAT_181db4020 + 184) + 24);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(int *)(lVar2 + 24) <= iVar9) break;
              uVar4 = BuildingUIController.GetPartyChoiceString(this,0,iVar9,0);
              if (lVar3 == null) throw; // [null/range check failed]
              FUN_18181e6b0(lVar3,uVar4,DAT_181da3d70);
              iVar9 = iVar9 + 1;
            }
            if (lVar3 != null) {
              FUN_18181e6b0(lVar3,"还是算了;HideInteractUI",DAT_181da3d70);
              lVar2 = BuildingUIController.PartyLvName;
              uVar4 = new PlotData(0);
              if (lVar2 != null) {
                puVar1 = (uint64 *)(lVar2 + 0x108);
                *puVar1 = uVar4;
                il2cpp_internal(puVar1,uVar4);
                lVar2 = BuildingUIController.PartyLvName;
                if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 0x108)) != null) {
                  lVar2 = *(int64 *)(lVar2 + 64);
                  uVar11 = 0;
                  uVar4 = BuildingUIController.GenerateBuildingNPCString
                                    (this,"掌柜",0xfffffffd,0xffffffff,
                                     CONCAT44(uVar12,0xffffffff),0);
                  uVar5 = il2cpp_internal(DAT_181da24f0);
                  uVar10 = CONCAT44(uVar11,3);
                  SinglePlotData.ctor(uVar5,"啊呀呀，少侠想要在本店举办宴会？那可真是欢迎之至！\n举办宴会可以吸引周遭声望相近的武林人士前来参与，一道把酒言欢。\n宴会评分越高，客人的身份也会越尊贵，增进的好感自然也越多。",0,5,uVar4,uVar10,"0",0,0,0);
                  uVar12 = (uint32)((uint64)uVar10 >> 32);
                  if (lVar2 != null) {
                    FUN_18181e6b0(lVar2,uVar5,DAT_181da1408);
                    lVar2 = BuildingUIController.PartyLvName;
                    if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 0x108)) != null) {
                      lVar2 = *(int64 *)(lVar2 + 64);
                      plVar6 = (int64 *)FUN_1800d60b0(DAT_181da4138,4);
                      uVar4 = "不知，少侠此回想要筹备何种档次的宴会呢？\n(当前{0}为等级{1}，可提升宴会{2}点基础评分和{3}%的评分加成)";
                      lVar8 = "建筑";
                      if (**(int **)(DAT_181d73d40 + 184) != 2) {
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
                            lVar8 = il2cpp_value_box(DAT_181da22f0,local_res18);
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
                              lVar8 = il2cpp_value_box(DAT_181da22f0,local_res20);
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
                              uVar5 = il2cpp_internal(DAT_181da24f0);
                              SinglePlotData.ctor
                                        (uVar5,uVar4,lVar3,0,0,CONCAT44(uVar12,3),"0",0,0,0);
                              if (lVar2 != null) {
                                FUN_18181e6b0(lVar2,uVar5,DAT_181da1408);
                                lVar3 = BuildingUIController.PartyLvName;
                                lVar2 = BuildingUIController.PartyLvName;
                                if ((lVar2 != null) && (lVar3 != null)) {
                                  PlotController.ChangePlot(lVar3,*(uint64 *)(lVar2 + 0x108),0);
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
          lVar3 = FUN_18046c400(0);
          uVar5 = il2cpp_internal(DAT_181da24f0);
          uVar4 = "这个月已经宴饮三日，若是天天饮酒作乐，只怕为江湖中人耻笑。";
        }
        SinglePlotData.ctor(uVar5,uVar4,0,1,0,CONCAT44(uVar12,3),"0",1,0,0);
        if (lVar3 != null) {
          PlotController.ChangePlot(lVar3,uVar5,0);
          return;
        }
    }

    // Token : 0x6000E17
    // RVA   : 0xB75F20   Offset: 0xB75320   Length: 0x8E2
    public void StartForceParty()
    {
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
        if ((GameController._instance != null) &&
           (lVar4 = GameController._instance.worldData) != null) {
          if (lVar4.monthForcePartyTime < 1) {
            lVar4 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar4,DAT_181da3bf0);
            iVar10 = 0;
            while( true ) {
              lVar3 = *(int64 *)(*(int64 *)(DAT_181db4020 + 184) + 24);
              if (lVar3 == null) break;
              if (*(int *)(lVar3 + 24) <= iVar10) {
                if (lVar4 != null) {
                  FUN_18181e6b0(lVar4,"还是算了;HideInteractUI",DAT_181da3d70);
                  lVar3 = BuildingUIController.PartyLvName;
                  uVar5 = new PlotData(0);
                  if (lVar3 != null) {
                    puVar1 = (uint64 *)(lVar3 + 0x108);
                    *puVar1 = uVar5;
                    il2cpp_internal(puVar1,uVar5);
                    lVar3 = BuildingUIController.PartyLvName;
                    if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 0x108)) != null) {
                      lVar3 = *(int64 *)(lVar3 + 64);
                      uVar5 = new SinglePlotData("在此举办宴会，可召唤本门弟子前来参与，增进好感与忠诚。\n宴会评分越高，增加好感与忠诚自然也越多。",0,1,0,3,"0",1,0,0);
                      if (lVar3 != null) {
                        FUN_18181e6b0(lVar3,uVar5,DAT_181da1408);
                        lVar3 = BuildingUIController.PartyLvName;
                        if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 0x108)) != null) {
                          lVar3 = *(int64 *)(lVar3 + 64);
                          plVar6 = (int64 *)FUN_1800d60b0(DAT_181da4138,4);
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
                                lVar7 = il2cpp_value_box(DAT_181da22f0,local_res18);
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
                                  lVar7 = il2cpp_value_box(DAT_181da22f0,local_res20);
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
                                    FUN_18181e6b0(lVar3,uVar9,DAT_181da1408);
                                    lVar4 = BuildingUIController.PartyLvName;
                                    lVar3 = BuildingUIController.PartyLvName;
                                    if ((lVar3 != null) && (lVar4 != null)) {
                                      PlotController.ChangePlot(lVar4,*(uint64 *)(lVar3 + 0x108),0);
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
              FUN_18181e6b0(lVar4,uVar5,DAT_181da3d70);
              iVar10 = iVar10 + 1;
            }
          }
          else {
            lVar4 = BuildingUIController.PartyLvName;
            uVar5 = new SinglePlotData("这个月已经举办过门派宴会，还需等待场地打扫整备妥当才是。",0,1,0,3,"0",1,0,0);
            if (lVar4 != null) {
              PlotController.ChangePlot(lVar4,uVar5,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000E18
    // RVA   : 0xB76AF0   Offset: 0xB75EF0   Length: 0x652
    public void StartHireBodyGuard()
    {
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
        if ((((GameController._instance != null) &&
             (lVar3 = GameController._instance.worldData) != null) &&
            (lVar3 = WorldData.Player(lVar3,0)) != null) && (*(int64 *)(lVar3 + 0x2f8) != 0)) {
          iVar2 = *(int *)(*(int64 *)(lVar3 + 0x2f8) + 24);
          if (((GameController._instance == null) ||
              (lVar3 = GameController._instance.worldData) == null) ||
             (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
          iVar1 = HeroData.GetMaxStudent(lVar3,0);
          if (iVar2 < iVar1) {
            if (((GameController._instance == null) ||
                (lVar3 = GameController._instance.worldData) == null) ||
               (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
            iVar2 = HeroData.GetBodyGuardNum(lVar3,0);
            if (iVar2 < 1) {
              iVar2 = 0;
              if (this.buildingData != null) {
                iVar2 = this.buildingData.lv;
              }
              lVar3 = FUN_18046c400(0);
              lVar4 = il2cpp_internal(DAT_181d97768);
              FUN_181330100(lVar4,DAT_181da3bf0);
              if (lVar4 == null) throw; // [null/range check failed]
              FUN_18181e6b0(lVar4,"物色普通人手;StartRecruitHero;1-Hire-0",DAT_181da3d70);
              local_res18[0] = (float)(iVar2 + 1) * 50.0;
              uVar5 = Single.ToString(local_res18,0);
              uVar5 = String.Concat("物色优良人手;StartRecruitHero;1-Hire-1;0/",uVar5,0);
              FUN_18181e6b0(lVar4,uVar5,DAT_181da3d70);
              local_res18[0] = (float)(iVar2 + 1) * 100.0;
              uVar5 = Single.ToString(local_res18,0);
              uVar5 = String.Concat("物色顶尖人手;StartRecruitHero;1-Hire-2;0/",uVar5,0);
              FUN_18181e6b0(lVar4,uVar5,DAT_181da3d70);
              FUN_18181e6b0(lVar4,"取消;HideInteractUI",DAT_181da3d70);
              uVar9 = 0;
              uVar5 = BuildingUIController.GenerateBuildingNPCString
                                (this,"掌柜",0xfffffffd,0xffffffff,CONCAT44(uVar8,0xffffffff),0)
              ;
              uVar6 = il2cpp_internal(DAT_181da24f0);
              SinglePlotData.ctor
                        (uVar6,"别看咱们这不起眼，却也是人才济济，卧虎藏龙。\n少侠行走江湖若遇到什么不便之处，掌柜的可以为您介绍一名江湖人士作为保镖。\n不仅价钱实惠，而且定能竭智尽忠，替您分忧解难！",lVar4,5,uVar5,CONCAT44(uVar9,3),"0",0,0,0);
              if (lVar3 == null) throw; // [null/range check failed]
              goto LAB_180b77027;
            }
            lVar3 = FUN_18046c400(0);
            uVar9 = 0;
            uVar7 = BuildingUIController.GenerateBuildingNPCString
                              (this,"掌柜",0xfffffffd,0xffffffff,CONCAT44(uVar8,0xffffffff),0);
            uVar6 = il2cpp_internal(DAT_181da24f0);
            uVar5 = "少侠已雇佣过保镖护卫了，可惜可惜。";
          }
          else {
            uVar9 = 0;
            lVar3 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
            uVar7 = BuildingUIController.GenerateBuildingNPCString
                              (this,"掌柜",0xfffffffd,0xffffffff,CONCAT44(uVar8,0xffffffff),0);
            uVar6 = il2cpp_internal(DAT_181da24f0);
            uVar5 = "少侠的队伍已经满员，还是改日再说吧。";
          }
          SinglePlotData.ctor(uVar6,uVar5,0,5,uVar7,CONCAT44(uVar9,3),"0",0,0,0);
          if (lVar3 != null) {
        LAB_180b77027:
            PlotController.ChangePlot(lVar3,uVar6,0);
            return;
          }
        }
    }

    // Token : 0x6000E19
    // RVA   : 0xB77150   Offset: 0xB76550   Length: 0x763
    public void StartHireFollower()
    {
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
        if (((GameController._instance == null) ||
            (lVar2 = GameController._instance.worldData) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        cVar1 = HeroData.HaveForce(lVar2,0);
        if (!cVar1) {
        LAB_180b777c5:
          uVar10 = 0;
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
          uVar6 = BuildingUIController.GenerateBuildingNPCString
                            (this,"杂役",0xfffffffc,0xffffffff,CONCAT44(uVar9,0xffffffff),0);
          uVar5 = il2cpp_internal(DAT_181da24f0);
          uVar4 = "抱歉少侠，只有掌门本人或是奉掌门之命者才能在此进行弟子招募。";
        }
        else {
          if (((GameController._instance == null) ||
              (lVar2 = GameController._instance.worldData) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          if (!lVar2.hour) {
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
               (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar2 + 0x2e0) != 0) {
              lVar2 = FUN_18046c0a0(0);
              if ((((lVar2 == null) || (lVar2.villageAreaID == null)) ||
                  (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) == null) ||
                 ((*(int64 *)(lVar2 + 0x2e0) == 0 ||
                  (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 0x2e0) + 120)) == null)))
              throw; // [null/range check failed]
              if (lVar2.cityAreaID == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar2.chapter + 32);
              if ((lVar2 = lVar2?.Inns) == null) throw; // [null/range check failed]
              if (lVar2.cityAreaID == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar2.chapter + 32);
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.chapter == 6) goto LAB_180b774c3;
            }
            goto LAB_180b777c5;
          }
        LAB_180b774c3:
          lVar2 = FUN_18046c0a0(0);
          if ((((lVar2 == null) || (lVar2.villageAreaID == null)) ||
              (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) == null) ||
             (lVar2 = HeroData.GetForce(lVar2,0,0)) == null) throw; // [null/range check failed]
          cVar1 = ForceData.PopulationNotFull(lVar2,0);
          if (cVar1) {
            iVar7 = 0;
            if (this.buildingData != null) {
              iVar7 = this.buildingData.lv;
            }
            fVar8 = (float)iVar7 * 0.5 + 1.0;
            lVar2 = FUN_18046c400(0);
            lVar3 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar3,DAT_181da3bf0);
            if (lVar3 != null) {
              FUN_18181e6b0(lVar3,"物色普通人选;StartRecruitHero;5-Normal-0",DAT_181da3d70);
              local_res18[0] = fVar8 * 500.0;
              uVar4 = Single.ToString(local_res18,0);
              uVar4 = String.Concat("物色优良人选;StartRecruitHero;5-Normal-1;0/",uVar4,0);
              FUN_18181e6b0(lVar3,uVar4,DAT_181da3d70);
              local_res18[0] = fVar8 * 1000.0;
              uVar4 = Single.ToString(local_res18,0);
              uVar4 = String.Concat("物色顶尖人选;StartRecruitHero;5-Normal-2;0/",uVar4,0);
              FUN_18181e6b0(lVar3,uVar4,DAT_181da3d70);
              FUN_18181e6b0(lVar3,"取消;HideInteractUI",DAT_181da3d70);
              uVar10 = 0;
              uVar4 = BuildingUIController.GenerateBuildingNPCString
                                (this,"杂役",0xfffffffc,0xffffffff,CONCAT44(uVar9,0xffffffff),0)
              ;
              uVar5 = il2cpp_internal(DAT_181da24f0);
              SinglePlotData.ctor
                        (uVar5,"这分舵中人来人往，不乏一些意欲拜入本门的武林人士。\n若是少侠有心，可在此物色一名新弟子人选，估摸着花上五天时间就够了。",lVar3,5,uVar4,CONCAT44(uVar10,3),"0",0,0,0);
              if (lVar2 == null) throw; // [null/range check failed]
              goto LAB_180b77795;
            }
            throw; // [null/range check failed]
          }
          lVar2 = FUN_18046c400(0);
          uVar10 = 0;
          uVar6 = BuildingUIController.GenerateBuildingNPCString
                            (this,"杂役",0xfffffffc,0xffffffff,CONCAT44(uVar9,0xffffffff),0);
          uVar5 = il2cpp_internal(DAT_181da24f0);
          uVar4 = "抱歉少侠，本门的弟子容量已满，无法进行招募。";
        }
        SinglePlotData.ctor(uVar5,uVar4,0,5,uVar6,CONCAT44(uVar10,3),"0",0,0,0);
        if (lVar2 != null) {
        LAB_180b77795:
          PlotController.ChangePlot(lVar2,uVar5,0);
          return;
        }
    }

    // Token : 0x6000E1A
    // RVA   : 0xB72630   Offset: 0xB71A30   Length: 0x6F2
    public void SpeHireFollower()
    {
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
        if (((GameController._instance == null) ||
            (lVar2 = GameController._instance.worldData) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        cVar1 = HeroData.HaveForce(lVar2,0);
        if (!cVar1) {
        LAB_180b72c34:
          uVar9 = 0;
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
          uVar6 = BuildingUIController.GenerateBuildingNPCString
                            (this,"名士",0xfffffffa,0xffffffff,CONCAT44(uVar8,0xffffffff),0);
          uVar5 = il2cpp_internal(DAT_181da24f0);
          uVar4 = "抱歉少侠，只有掌门本人或是奉掌门之命者才能在此进行弟子招募。";
        }
        else {
          if (((GameController._instance == null) ||
              (lVar2 = GameController._instance.worldData) == null) ||
             (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
          if (!lVar2.hour) {
            lVar2 = FUN_18046c0a0(0);
            if (((lVar2 == null) || (lVar2.villageAreaID == null)) ||
               (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar2 + 0x2e0) != 0) {
              lVar2 = FUN_18046c0a0(0);
              if ((((lVar2 == null) || (lVar2.villageAreaID == null)) ||
                  (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) == null) ||
                 ((*(int64 *)(lVar2 + 0x2e0) == 0 ||
                  (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 0x2e0) + 120)) == null)))
              throw; // [null/range check failed]
              if (lVar2.cityAreaID == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar2.chapter + 32);
              if ((lVar2 = lVar2?.Inns) == null) throw; // [null/range check failed]
              if (lVar2.cityAreaID == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar2.chapter + 32);
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.chapter == 6) goto LAB_180b72986;
            }
            goto LAB_180b72c34;
          }
        LAB_180b72986:
          lVar2 = FUN_18046c0a0(0);
          if ((((lVar2 == null) || (lVar2.villageAreaID == null)) ||
              (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) == null) ||
             (lVar2 = HeroData.GetForce(lVar2,0,0)) == null) throw; // [null/range check failed]
          cVar1 = ForceData.PopulationNotFull(lVar2,0);
          if (cVar1) {
            iVar7 = 0;
            if (this.buildingData != null) {
              iVar7 = this.buildingData.lv;
            }
            lVar2 = FUN_18046c400(0);
            lVar3 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar3,DAT_181da3bf0);
            local_res18[0] = ((float)iVar7 * 0.5 + 1.0) * 2000.0;
            uVar4 = Single.ToString(local_res18,0);
            uVar4 = String.Concat("选贤举能;StartRecruitHero;5-Normal-3;0/",uVar4,0);
            if (lVar3 != null) {
              FUN_18181e6b0(lVar3,uVar4,DAT_181da3d70);
              FUN_18181e6b0(lVar3,"取消;HideInteractUI",DAT_181da3d70);
              uVar9 = 0;
              uVar4 = BuildingUIController.GenerateBuildingNPCString
                                (this,"名士",0xfffffffa,0xffffffff,CONCAT44(uVar8,0xffffffff),0)
              ;
              uVar5 = il2cpp_internal(DAT_181da24f0);
              SinglePlotData.ctor
                        (uVar5,"这黄鹤楼乃是江南胜景，来往之人不乏小有名气的意气游侠，青年才俊，\n少侠若是愿意花上五日时间在此处寻访，必能拔擢一批可造之材。",lVar3,5,uVar4,CONCAT44(uVar9,3),"0",0,0,0);
              if (lVar2 == null) throw; // [null/range check failed]
              goto LAB_180b72c0b;
            }
            throw; // [null/range check failed]
          }
          lVar2 = FUN_18046c400(0);
          uVar9 = 0;
          uVar6 = BuildingUIController.GenerateBuildingNPCString
                            (this,"名士",0xfffffffa,0xffffffff,CONCAT44(uVar8,0xffffffff),0);
          uVar5 = il2cpp_internal(DAT_181da24f0);
          uVar4 = "抱歉少侠，本门的弟子容量已满，无法进行招募。";
        }
        SinglePlotData.ctor(uVar5,uVar4,0,5,uVar6,CONCAT44(uVar9,3),"0",0,0,0);
        if (lVar2 != null) {
        LAB_180b72c0b:
          PlotController.ChangePlot(lVar2,uVar5,0);
          return;
        }
    }

    // Token : 0x6000E1B
    // RVA   : 0xB61960   Offset: 0xB60D60   Length: 0x310
    public float BuildingStudySkillCostRate(AreaBuildingData targetBuilding)
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        float fVar4;
        if ((targetBuilding == null) || (lVar3 = AreaBuildingData.GetArea(targetBuilding,0)) == null)
        throw; // [null/range check failed]
        cVar2 = AreaData.HaveForce(lVar3,0);
        if (!cVar2) {
          return 1.0;
        }
        lVar3 = AreaBuildingData.GetArea(targetBuilding,0);
        if (lVar3 == null) throw; // [null/range check failed]
        iVar1 = lVar3.lastRandomWorldEventDay;
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
        if (iVar1 != *(int *)(lVar3 + 132)) {
          lVar3 = AreaBuildingData.GetArea(targetBuilding,0);
          if ((lVar3 == null) || (lVar3 = AreaData.GetForce(lVar3,0)) == null) throw; // [null/range check failed]
          if (-1 < *(int *)(lVar3 + 60)) {
            lVar3 = AreaBuildingData.GetArea(targetBuilding,0);
            if ((lVar3 == null) || (lVar3 = AreaData.GetForce(lVar3,0)) == null) throw; // [null/range check failed]
            iVar1 = *(int *)(lVar3 + 60);
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
               (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) == null) throw; // [null/range check failed]
            if (iVar1 == *(int *)(lVar3 + 132)) goto LAB_180b61b8b;
          }
          lVar3 = AreaBuildingData.GetArea(targetBuilding,0);
          if (lVar3 == null) throw; // [null/range check failed]
          iVar1 = lVar3.lastRandomWorldEventDay;
          lVar3 = FUN_18046c0a0(0);
          if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
             (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) == null) throw; // [null/range check failed]
          if (iVar1 != *(int *)(lVar3 + 0x380)) {
            return 1.0;
          }
        }
        LAB_180b61b8b:
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar3 = WorldData.Player(lVar3,0)) != null) {
          fVar4 = (float)Mathf.Max(0x3d4ccccd,(float)lVar3.forceMeetingStarted * 0.1,0);
          return 1.0 - fVar4;
        }
    }

    // Token : 0x6000E1C
    // RVA   : 0xB7A080   Offset: 0xB79480   Length: 0xC7C
    public void StudyLivingSkill(string param)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if ((((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null) ||
            (lVar3 = WorldData.Player(lVar3,0)) == null) ||
           (lVar3 = lVar3.monthLeaderInteractOtherForceTime) == null) throw; // [null/range check failed]
        if (lVar3.cityAreaID <= uVar1) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        fVar14 = *(float *)(lVar3.chapter + 32 + lVar11 * 4);
        if ((float)*(int *)(pStatics_3d40 + 0x108) <= fVar14) {
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
          lVar5 = *(int64 *)(pStatics_3d40 + 0x4b0);
          if (lVar5 == null) throw; // [null/range check failed]
          uVar7 = "少侠的{0}已然登峰造极，无需再进行修炼了吧。";
          if (*(uint32 *)(lVar5 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            uVar7 = "少侠的{0}已然登峰造极，无需再进行修炼了吧。";
          }
        }
        else {
          if ((((GameController._instance == null) ||
               (lVar3 = GameController._instance.worldData) == null) ||
              (lVar3 = WorldData.Player(lVar3,0)) == null) ||
             (lVar3 = lVar3.monthLeaderInteractOtherForceTime) == null) throw; // [null/range check failed]
          if (lVar3.cityAreaID <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar14 = *(float *)(lVar3.chapter + 32 + lVar11 * 4);
          if (((GameController._instance == null) ||
              (lVar3 = GameController._instance.worldData) == null) ||
             (lVar3 = WorldData.Player(lVar3,0)) == null) throw; // [null/range check failed]
          fVar13 = (float)HeroData.GetMaxLivingSkill(lVar3,uVar1,0);
          if (fVar14 < fVar13) {
            fVar14 = (float)BuildingUIController.BuildingStudySkillCostRate
                                      (this,this.buildingData,0);
            lVar3 = FUN_18046c0a0(0);
            if ((((lVar3 != null) && (lVar3.villageAreaID != null)) &&
                (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) != null) &&
               (lVar3 = lVar3.monthLeaderInteractOtherForceTime) != null) {
              if (lVar3.cityAreaID <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              iVar12 = 1 - (int)(*(float *)(lVar3.chapter + 32 + lVar11 * 4) * -0.05);
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 != null) && (lVar3.villageAreaID != null)) &&
                 ((lVar3 = WorldData.Player(lVar3.villageAreaID,0), lVar3 != null &&
                  (lVar3 = lVar3.monthLeaderInteractOtherForceTime) != null))) {
                if (lVar3.cityAreaID <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar2 = Mathf.RoundToInt((float)(1 - (int)(*(float *)(lVar3.chapter + 32
                                                                      + lVar11 * 4) * -0.1)) *
                                          fVar14 * 250.0,0);
                local_58 = uVar2;
                lVar3 = FUN_18046c400(0);
                plVar4 = (int64 *)FUN_1800d60b0(DAT_181da4138,7);
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
                    lVar5 = ForceData.GetForceName(lVar5,1,0);
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
                    lVar5 = *(int64 *)(pStatics_3d40 + 0x4b0);
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
                        lVar11 = il2cpp_value_box(DAT_181da22f0,local_res10);
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
                        lVar11 = il2cpp_value_box(DAT_181d80430,local_res20);
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
                        lVar11 = il2cpp_value_box(DAT_181d80430,&local_68);
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
                          uVar8 = il2cpp_value_box(DAT_181d80430,&local_64);
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
                        lVar11 = il2cpp_internal(DAT_181d97768);
                        FUN_181330100(lVar11,DAT_181da3bf0);
                        local_60 = uVar1;
                        uVar8 = il2cpp_value_box(DAT_181d80430,&local_60);
                        local_5c = iVar12;
                        uVar9 = il2cpp_value_box(DAT_181d80430,&local_5c);
                        local_54[0] = local_58;
                        uVar10 = il2cpp_value_box(DAT_181d80430,local_54);
                        uVar8 = String.Format("开始修炼;StudyLivingSkillStart;{0}-{1};0/{2}",uVar8,uVar9,uVar10,0);
                        if (lVar11 != null) {
                          FUN_18181e6b0(lVar11,uVar8,DAT_181da3d70);
                          FUN_18181e6b0(lVar11,"还是算了;HideInteractUI",DAT_181da3d70);
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
          lVar3 = FUN_18046c400(0);
          lVar5 = *(int64 *)(pStatics_3d40 + 0x4b0);
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

    // Token : 0x6000E1D
    // RVA   : 0xB7B930   Offset: 0xB7AD30   Length: 0xB66
    public void StudyMaxLivingSkill(string param)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar3 = WorldData.Player(lVar3,0)) != null) {
          fVar12 = (float)HeroData.GetMaxLivingSkill(lVar3,uVar1,0);
          if (fVar12 < (float)*(int *)(pStatics_3d40 + 0x108)) {
            fVar12 = (float)BuildingUIController.BuildingStudySkillCostRate
                                      (this,this.buildingData,0);
            if (((GameController._instance != null) &&
                (lVar3 = GameController._instance.worldData) != null) &&
               (lVar3 = WorldData.Player(lVar3,0)) != null) {
              fVar13 = (float)HeroData.GetMaxLivingSkill(lVar3,uVar1,0);
              iVar11 = 1 - (int)(fVar13 * -0.05);
              if (((GameController._instance != null) &&
                  (lVar3 = GameController._instance.worldData) != null) &&
                 (lVar3 = WorldData.Player(lVar3,0)) != null) {
                fVar13 = (float)HeroData.GetMaxLivingSkill(lVar3,uVar1,0);
                uVar2 = Mathf.RoundToInt((float)(1 - (int)(fVar13 * -0.1)) * fVar12 * 500.0,0);
                local_58 = uVar2;
                lVar3 = BuildingUIController.PartyLvName;
                plVar4 = (int64 *)FUN_1800d60b0(DAT_181da4138,7);
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
                    lVar5 = ForceData.GetForceName(lVar5,1,0);
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
                    lVar5 = *(int64 *)(pStatics_3d40 + 0x4b0);
                    if (lVar5 != null) {
                      if (lVar5.cityAreaID <= uVar1) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = lVar5.chapter[uVar1]
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
                      if (((GameController._instance != null) &&
                          (lVar5 = GameController._instance.worldData, lVar5 != null
                          )) && (lVar5 = WorldData.Player(lVar5,0)) != null) {
                        local_res10[0] = HeroData.GetMaxLivingSkill(lVar5,uVar1,0);
                        lVar5 = il2cpp_value_box(DAT_181da22f0,local_res10);
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
                        lVar5 = il2cpp_value_box(DAT_181d80430,local_res20);
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
                        lVar5 = il2cpp_value_box(DAT_181d80430,&local_68);
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
                          uVar8 = il2cpp_value_box(DAT_181d80430,&local_64);
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
                        lVar5 = il2cpp_internal(DAT_181d97768);
                        FUN_181330100(lVar5,DAT_181da3bf0);
                        local_60 = uVar1;
                        uVar8 = il2cpp_value_box(DAT_181d80430,&local_60);
                        local_5c = iVar11;
                        uVar9 = il2cpp_value_box(DAT_181d80430,&local_5c);
                        local_54[0] = local_58;
                        uVar10 = il2cpp_value_box(DAT_181d80430,local_54);
                        uVar8 = String.Format("开始修炼;StudyMaxLivingSkillStart;{0}-{1};0/{2}",uVar8,uVar9,uVar10,0);
                        if (lVar5 != null) {
                          FUN_18181e6b0(lVar5,uVar8,DAT_181da3d70);
                          FUN_18181e6b0(lVar5,"还是算了;HideInteractUI",DAT_181da3d70);
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
          lVar3 = BuildingUIController.PartyLvName;
          lVar5 = *(int64 *)(pStatics_3d40 + 0x4b0);
          if (lVar5 != null) {
            if (lVar5.cityAreaID <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = String.Format("少侠的{0}潜力已然登峰造极，无需再进行修炼了吧。",
                                   *(uint64 *)
                                    (lVar5.chapter + 32 + (int64)(int)uVar1 * 8),0);
            uVar8 = BuildingUIController.GenerateForceNPCString(this,"弟子",0);
            uVar9 = new SinglePlotData(uVar7,0,5,uVar8,3,"0",0,0,0);
            if (lVar3 != null) {
              PlotController.ChangePlot(lVar3,uVar9,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000E1E
    // RVA   : 0xB7ADB0   Offset: 0xB7A1B0   Length: 0xB76
    public void StudyMaxFightSkill(string param)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar3 = WorldData.Player(lVar3,0)) != null) {
          fVar12 = (float)HeroData.GetMaxFightSkill(lVar3,uVar1,0);
          if (fVar12 < (float)*(int *)(pStatics_3d40 + 0x104)) {
            fVar12 = (float)BuildingUIController.BuildingStudySkillCostRate
                                      (this,this.buildingData,0);
            if (((GameController._instance != null) &&
                (lVar3 = GameController._instance.worldData) != null) &&
               (lVar3 = WorldData.Player(lVar3,0)) != null) {
              fVar13 = (float)HeroData.GetMaxFightSkill(lVar3,uVar1,0);
              iVar11 = 1 - (int)(fVar13 * -0.1);
              if (((GameController._instance != null) &&
                  (lVar3 = GameController._instance.worldData) != null) &&
                 (lVar3 = WorldData.Player(lVar3,0)) != null) {
                fVar13 = (float)HeroData.GetMaxFightSkill(lVar3,uVar1,0);
                uVar2 = Mathf.RoundToInt((float)(1 - (int)(fVar13 * -0.1)) * fVar12 * 1000.0,0);
                local_68 = uVar2;
                lVar3 = BuildingUIController.PartyLvName;
                plVar4 = (int64 *)FUN_1800d60b0(DAT_181da4138,7);
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
                    lVar5 = ForceData.GetForceName(lVar5,1,0);
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
                    lVar5 = *(int64 *)(pStatics_3d40 + 0x4a0);
                    if (lVar5 != null) {
                      if (lVar5.cityAreaID <= uVar1) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = lVar5.chapter[uVar1]
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
                      if (((GameController._instance != null) &&
                          (lVar5 = GameController._instance.worldData, lVar5 != null
                          )) && (lVar5 = WorldData.Player(lVar5,0)) != null) {
                        local_res10[0] = HeroData.GetMaxFightSkill(lVar5,uVar1,0);
                        lVar5 = il2cpp_value_box(DAT_181da22f0,local_res10);
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
                        lVar5 = il2cpp_value_box(DAT_181d80430,local_res20);
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
                        lVar5 = il2cpp_value_box(DAT_181d80430,&local_78);
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
                          uVar8 = il2cpp_value_box(DAT_181d80430,&local_74);
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
                        lVar5 = il2cpp_internal(DAT_181d97768);
                        FUN_181330100(lVar5,DAT_181da3bf0);
                        local_70 = uVar1;
                        uVar8 = il2cpp_value_box(DAT_181d80430,&local_70);
                        local_6c = iVar11;
                        uVar9 = il2cpp_value_box(DAT_181d80430,&local_6c);
                        local_64[0] = local_68;
                        uVar10 = il2cpp_value_box(DAT_181d80430,local_64);
                        uVar8 = String.Format("开始修炼;StudyMaxFightSkillStart;{0}-{1};0/{2}",uVar8,uVar9,uVar10,0);
                        if (lVar5 != null) {
                          FUN_18181e6b0(lVar5,uVar8,DAT_181da3d70);
                          FUN_18181e6b0(lVar5,"还是算了;HideInteractUI",DAT_181da3d70);
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
          lVar3 = BuildingUIController.PartyLvName;
          lVar5 = *(int64 *)(pStatics_3d40 + 0x4a0);
          if (lVar5 != null) {
            if (lVar5.cityAreaID <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar7 = String.Format("少侠的{0}潜力已然登峰造极，无需再进行修炼了吧。",
                                   *(uint64 *)
                                    (lVar5.chapter + 32 + (int64)(int)uVar1 * 8),0);
            uVar8 = BuildingUIController.GenerateForceNPCString(this,"弟子",0);
            uVar9 = new SinglePlotData(uVar7,0,5,uVar8,3,"0",0,0,0);
            if (lVar3 != null) {
              PlotController.ChangePlot(lVar3,uVar9,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000E1F
    // RVA   : 0xB7C4A0   Offset: 0xB7B8A0   Length: 0xA19
    public void StudyMaxState(string param)
    {
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
        uint[] local_54 = new uint[7];
        fVar13 = (float)BuildingUIController.BuildingStudySkillCostRate
                                  (this,this.buildingData,0);
        uVar1 = Int32.Parse(param,0);
        lVar3 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar3,DAT_181da3bf0);
        if (lVar3 != null) {
          FUN_18181e6b0(lVar3,"生命上限",DAT_181da3d70);
          FUN_18181e6b0(lVar3,"内力上限",DAT_181da3d70);
          if (uVar1 == 0) {
            if (((GameController._instance == null) ||
                (lVar4 = GameController._instance.worldData) == null) ||
               (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
            fVar14 = (float)HeroData.GetExtraMaxHp(lVar4,0);
            fVar14 = fVar14 * 0.1;
          }
          else {
            if (((GameController._instance == null) ||
                (lVar4 = GameController._instance.worldData) == null) ||
               (lVar4 = WorldData.Player(lVar4,0)) == null) throw; // [null/range check failed]
            fVar14 = (float)HeroData.GetExtraMaxMana(lVar4,0);
            fVar14 = fVar14 * 0.05;
          }
          uVar12 = (int)fVar14 + 2;
          uVar2 = Mathf.RoundToInt(fVar13 * 750.0 * (float)(int)uVar12,0);
          lVar4 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181da4138,7);
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
            if ((this.buildingData != null) &&
               (lVar6 = AreaBuildingData.GetArea(this.buildingData,0)) != null) {
              lVar6 = AreaData.GetForce(lVar6,0);
              if (lVar6 != null) {
                lVar6 = ForceData.GetForceName(lVar6,1,0);
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
                if (lVar3.cityAreaID <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = lVar3.chapter[uVar1];
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
                  if (((GameController._instance != null) &&
                      (lVar3 = GameController._instance.worldData) != null)
                     && (lVar3 = WorldData.Player(lVar3,0)) != null) {
                    local_res8[0] = HeroData.GetExtraMaxHp(lVar3,0);
        LAB_180b7cacb:
                    lVar3 = il2cpp_value_box(DAT_181da22f0,local_res8);
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
                    lVar3 = il2cpp_value_box(DAT_181d80430,local_res10);
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
                    lVar3 = il2cpp_value_box(DAT_181d80430,local_res20);
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
                      uVar9 = il2cpp_value_box(DAT_181d80430,local_res8);
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
                    lVar3 = il2cpp_internal(DAT_181d97768);
                    FUN_181330100(lVar3,DAT_181da3bf0);
                    local_res10[0] = uVar1;
                    uVar9 = il2cpp_value_box(DAT_181d80430,local_res10);
                    local_res20[0] = uVar12;
                    uVar10 = il2cpp_value_box(DAT_181d80430,local_res20);
                    local_54[0] = uVar2;
                    uVar11 = il2cpp_value_box(DAT_181d80430,local_54);
                    uVar9 = String.Format("开始修炼;StudyMaxStateStart;{0}-{1};0/{2}",uVar9,uVar10,uVar11,0);
                    if (lVar3 != null) {
                      FUN_18181e6b0(lVar3,uVar9,DAT_181da3d70);
                      FUN_18181e6b0(lVar3,"还是算了;HideInteractUI",DAT_181da3d70);
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
                  if (((GameController._instance != null) &&
                      (lVar3 = GameController._instance.worldData) != null)
                     && (lVar3 = WorldData.Player(lVar3,0)) != null) {
                    local_res8[0] = HeroData.GetExtraMaxMana(lVar3,0);
                    goto LAB_180b7cacb;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000E20
    // RVA   : 0xB6BA70   Offset: 0xB6AE70   Length: 0xCF7
    public void ProduceBuildingWork(string param)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        cVar1 = FUN_18171eb50(param,"5",0);
        local_68 = -1;
        if (cVar1) {
          local_68 = 2;
        }
        lVar5 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar5,DAT_181da3bf0);
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
          plVar9 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,8);
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
          FUN_18181e6b0(lVar5,uVar6);
          iVar13 = iVar13 + 1;
          iVar12 = iVar12 + 5;
        } while (iVar12 < 15);
        FUN_18181e6b0(lVar5,"取消;HideInteractUI",DAT_181da3d70);
        lVar4 = BuildingUIController.PartyLvName;
        plVar9 = (int64 *)FUN_1800d60b0(DAT_181da4138,6);
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
            lVar8 = *(int64 *)(pStatics_3d40 + 0x438);
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
              lVar8 = BuildingUIController.PartyLvName;
              uVar3 = Int32.Parse(param,0);
              if (lVar8 != null) {
                uVar3 = PlotController.GetResourceProduceNum(lVar8,uVar3,0x3f800000,0);
                local_5c[0] = Mathf.CeilToInt(uVar3,0);
                lVar8 = il2cpp_value_box(DAT_181d80430,local_5c);
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
                if (((GameController._instance != null) &&
                    (lVar8 = GameController._instance.worldData) != null) &&
                   (lVar8 = WorldData.Player(lVar8,0)) != null) {
                  lVar8 = HeroData.GetForce(lVar8,0,0);
                  if (lVar8 == null) {

                    if ((lVar8 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56)?.TempHeros) == null)
                    throw; // [null/range check failed]
                    lVar8 = AreaData.GetForce(lVar8,0);
                    if (lVar8 == null) throw; // [null/range check failed]
                    uVar7 = ForceData.GetForceName(lVar8,1,0);
                    lVar8 = *(int64 *)(pStatics_3d40 + 0x438);
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

    // Token : 0x6000E21
    // RVA   : 0xB6B000   Offset: 0xB6A400   Length: 0xA62
    public void ProduceBuildingSteal(string param)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
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
        lVar4 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar4,DAT_181da3bf0);
        iVar10 = 0;
        while( true ) {
          local_res10[0] = Mathf.Max(1,iVar10);
          plVar5 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,7);
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
          FUN_18181e6b0(lVar4,uVar8);
          iVar10 = iVar10 + 5;
          if (14 < iVar10) {
            FUN_18181e6b0(lVar4,"取消;HideInteractUI",DAT_181da3d70);
            lVar3 = BuildingUIController.PartyLvName;
            uVar8 = "趁{2}不备，何不在此偷偷收取{3}，以贴补本门所用。在{0}{1}几天？\n({5}预计每日可获取{4}{3})\n(非本门资源效率减半)";
            if (*(char *)(pStatics_3d40 + 4) != false) {
              uVar8 = "在此处回收{2}多余的{3}，以贴补本门所用。在{0}{1}几天？\n({5}预计每日可获取{4}{3})\n(非本门资源效率减半)";
            }
            plVar5 = (int64 *)FUN_1800d60b0(DAT_181da4138,6);
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
                lVar6 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
                if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 88)) != null) {
                  lVar6 = AreaData.GetForce(lVar6,0);
                  if (lVar6 != null) {
                    lVar6 = ForceData.GetForceName(lVar6,1,0);
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
                    lVar6 = *(int64 *)(pStatics_3d40 + 0x438);
                    uVar1 = Int32.Parse(param,0);
                    if (lVar6 != null) {
                      if (*(uint32 *)(lVar6 + 24) <= uVar1) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar6 = lVar6[uVar1]
                      ;
                      if ((lVar6 != null) &&
                         (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64))) == null)
                      {
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
                      lVar6 = BuildingUIController.PartyLvName;
                      uVar2 = Int32.Parse(param,0);
                      if (lVar6 != null) {
                        uVar2 = PlotController.GetResourceProduceNum(lVar6,uVar2,0x3f000000,0);
                        local_48[0] = Mathf.CeilToInt(uVar2,0);
                        lVar6 = il2cpp_value_box(DAT_181d80430,local_48);
                        if ((lVar6 != null) &&
                           (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64)), lVar7 == null
                           )) {
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
                             (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar5 + 64)),
                             lVar7 == null)) {
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
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000E22
    // RVA   : 0xB60150   Offset: 0xB5F550   Length: 0xC5C
    public void AreaBuildingWork(string param)
    {
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
              cVar2 = FUN_18171eb50(param,"4",0);
              if (cVar2) {
                local_res10[0] = 5;
                lVar12 = "在此处分发药物，免费问诊，可使民众身体康健，百病不侵。";
              }
            }
            else if (uVar3 == 0x340ca71c) {
              cVar2 = FUN_18171eb50(param,"1",0);
              lVar6 = "打磨武器，整备军械，方能将敌对细作一网打尽！";
              goto joined_r0x000180b60552;
            }
          }
          else if (uVar3 == 0x360caa42) {
            cVar2 = FUN_18171eb50(param,"3",0);
            if (cVar2) {
              local_res10[0] = 3;
              lVar12 = "在此处修缮防御工事，营造壁垒，以防敌袭。";
            }
          }
          else if ((uVar3 == 0x370cabd5) &&
                  (cVar2 = FUN_18171eb50(param,"2",0), cVar2)) {
            local_res10[0] = 2;
            lVar12 = "不妨给老弱病残者分发一些饮食，他们必定对#AreaForceName#感恩戴德";
          }
        }
        else if (uVar3 < 0xc03eb115) {
          if (uVar3 == 0xbe3eadee) {
            cVar2 = FUN_18171eb50(param,"负4",0);
            if (cVar2) {
              local_res10[0] = 5;
              lVar12 = "在此地投下使人恶心呕吐，腹泻不止的疫病之物，可使人心惶惶，民众离散。";
            }
          }
          else if ((uVar3 == 0xc03eb114) &&
                  (cVar2 = FUN_18171eb50(param,"负2",0), cVar2)) {
            local_res10[0] = 2;
            lVar12 = "贫苦乡亲们，收下这些食物吧！#AreaForceName#不管你们死活，我#PlayerForceName#断不会如此！";
          }
        }
        else if (uVar3 == 0xc13eb2a7) {
          cVar2 = FUN_18171eb50(param,"负3",0);
          if (cVar2) {
            local_res10[0] = 3;
            lVar12 = "哼哼，只需在这些城墙工事上动些手脚......";
          }
        }
        else if (uVar3 == 0xc33eb5cd) {
          cVar2 = FUN_18171eb50(param,"负1",0);
          lVar6 = "将此处的武器军械破坏殆尽，#AreaForceName#便更难在此处维持治安。";
        joined_r0x000180b60552:
          if (cVar2) {
            local_res10[0] = 4;
            lVar12 = lVar6;
          }
        }
        uVar5 = String.Replace(param,"负","-",0);
        local_60 = Int32.Parse(uVar5,0);
        lVar6 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar6,DAT_181da3bf0);
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
          plVar9 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,8);
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
          FUN_18181e6b0(lVar6,uVar5);
          iVar14 = iVar14 + 1;
          iVar13 = iVar13 + 5;
        } while (iVar13 < 15);
        FUN_18181e6b0(lVar6,"取消;HideInteractUI",DAT_181da3d70);
        lVar4 = BuildingUIController.PartyLvName;
        uVar5 = String.Concat(lVar12,"在{0}{1}几天？\n(预计每日可使该地{2}{3})",0);
        plVar9 = (int64 *)FUN_1800d60b0(DAT_181da4138,4);
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
            lVar12 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x608);
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
              lVar12 = BuildingUIController.PartyLvName;
              if (lVar12 != null) {
                local_64 = PlotController.GetWorkInAreaBuildingNum(lVar12,uVar1,0);
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

    // Token : 0x6000E23
    // RVA   : 0xB6C770   Offset: 0xB6BB70   Length: 0x31B
    public void RecoverBuildingResourceRate()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        float[] local_res8 = new float[2];
        lVar1 = BuildingUIController.PartyLvName;
        if (this.buildingData != null) {
          lVar2 = AreaBuildingData.DataBase(this.buildingData,0);
          if (lVar2 != null) {
            uVar4 = *(uint64 *)(lVar2 + 24);
            if (this.buildingChoiceSelected != null) {
              uVar5 = this.buildingChoiceSelected.text;
              lVar2 = BuildingUIController.PartyLvName;
              if (lVar2 != null) {
                local_res8[0] = (float)PlotController.GetRecoverBuildingResourceRate(lVar2,0);
                local_res8[0] = local_res8[0] * 100.0;
                uVar3 = Single.ToString(local_res8,"f0",0);
                uVar4 = String.Format("在{0}{1}几天？\n(预计每日可提升资源储量{2}%)",uVar4,uVar5,uVar3,0);
                lVar2 = il2cpp_internal(DAT_181d97768);
                FUN_181330100(lVar2,DAT_181da3bf0);
                if (lVar2 != null) {
                  FUN_18181e6b0(lVar2,"5天;RecoverBuildingResourceRate;5",DAT_181da3d70);
                  FUN_18181e6b0(lVar2,"10天;RecoverBuildingResourceRate;10",DAT_181da3d70);
                  FUN_18181e6b0(lVar2,"15天;RecoverBuildingResourceRate;15",DAT_181da3d70);
                  FUN_18181e6b0(lVar2,"取消;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000E24
    // RVA   : 0xB60DB0   Offset: 0xB601B0   Length: 0x216
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        if (lVar2 != null) {
          FUN_18181e6b0(lVar2,"开始探听;StartAskNearRandomEvent;;0/50",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"取消;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000E25
    // RVA   : 0xB79970   Offset: 0xB78D70   Length: 0xAC
    public void StudyFightOther()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.ChooseStudyFightOtherTarget(lVar1,0);
          return;
        }
    }

    // Token : 0x6000E26
    // RVA   : 0xB79A20   Offset: 0xB78E20   Length: 0x34F
    public void StudyFightSelf()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int iVar5;
        int[] local_res18 = new int[2];
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        iVar5 = 3;
        while( true ) {
          lVar1 = *(int64 *)(pStatics + 0x4a0);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(int *)(lVar1 + 24) <= iVar5) {
            if (lVar2 != null) {
              FUN_18181e6b0(lVar2,"取消;HideInteractUI",DAT_181da3d70);
              lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
              local_res18[0] = *(int *)(pStatics + 0x168);
              uVar3 = il2cpp_value_box(DAT_181d80430,local_res18);
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
          lVar1 = *(int64 *)(pStatics + 0x4a0);
          if (lVar1 == null) break;
          uVar3 = FUN_180002f80(lVar1,iVar5,DAT_181da4370);
          local_res18[0] = iVar5;
          uVar4 = il2cpp_value_box(DAT_181d80430,local_res18);
          uVar3 = String.Format("修炼{0};StudyFightSelfChoose;{1}",uVar3,uVar4,0);
          if (lVar2 == null) break;
          FUN_18181e6b0(lVar2,uVar3,DAT_181da3d70);
          iVar5 = iVar5 + 1;
        }
    }

    // Token : 0x6000E27
    // RVA   : 0xB79D70   Offset: 0xB79170   Length: 0x301
    public void StudyInternalSelf()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int iVar5;
        int[] local_res18 = new int[2];
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        iVar5 = 0;
        while( true ) {
          lVar1 = *(int64 *)(pStatics + 0x4a0);
          if (lVar1 == null) break;
          uVar3 = FUN_180002f80(lVar1,iVar5,DAT_181da4370);
          local_res18[0] = iVar5;
          uVar4 = il2cpp_value_box(DAT_181d80430,local_res18);
          uVar3 = String.Format("修炼{0};StudyFightSelfChoose;{1}",uVar3,uVar4,0);
          if (lVar2 == null) break;
          FUN_18181e6b0(lVar2,uVar3,DAT_181da3d70);
          iVar5 = iVar5 + 1;
          if (2 < iVar5) {
            FUN_18181e6b0(lVar2,"取消;HideInteractUI",DAT_181da3d70);
            lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
            local_res18[0] = *(int *)(pStatics + 0x164);
            uVar3 = il2cpp_value_box(DAT_181d80430,local_res18);
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

    // Token : 0x6000E28
    // RVA   : 0xB6FE90   Offset: 0xB6F290   Length: 0x150
    public void ShowForceShowRoom()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181da2070 + 184) + 32);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 88)) != null) {
          uVar3 = AreaData.GetForce(lVar2,0);
          if (lVar1 != null) {
            ShowRoomController.ShowShowRoomUI(lVar1,0,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000E29
    // RVA   : 0xB71910   Offset: 0xB70D10   Length: 0xB4
    public void ShowSelfShowRoom()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181da2070 + 184) + 32);
        if (lVar1 != null) {
          ShowRoomController.ShowShowRoomUI(lVar1,1,0);
          return;
        }
    }

    // Token : 0x6000E2A
    // RVA   : 0xB65240   Offset: 0xB64640   Length: 0x6D
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

    // Token : 0x6000E2B
    // RVA   : 0xB65390   Offset: 0xB64790   Length: 0x3D
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

    // Token : 0x6000E2C
    // RVA   : 0xB679F0   Offset: 0xB66DF0   Length: 0x3A0
    public void IdentifyItem()
    {
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (this.buildingData != null) {
          uVar3 = AreaBuildingData.Name(this.buildingData,1,0);
          if (this.buildingData != null) {
            auVar8._0_8_ = Mathf.Max(this.buildingData,0x3f000000,0);
            auVar8._8_8_ = extraout_XMM0_Qb;
            auVar9._4_12_ = auVar8._4_12_;
            auVar9._0_4_ = (float)auVar8._0_8_ + (float)auVar8._0_8_;
            local_res8[0] = Mathf.RoundToInt(auVar9._0_8_,0);
            uVar4 = il2cpp_value_box(DAT_181d80430,local_res8);
            if ((GameController._instance != null) &&
               (lVar5 = GameController._instance.worldData) != null) {
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
                  uVar6 = il2cpp_value_box(DAT_181da22f0,local_res18);
                  uVar3 = String.Format("世间奇珍异宝可谓浩如繁星，若想一一准确鉴定，非有渊博之学识不可。\n({0}提升{1}点学识效果，当前可鉴定学识要求{2}以下的珍宝)",uVar3,uVar4,uVar6,0);
                  lVar5 = il2cpp_internal(DAT_181d97768);
                  FUN_181330100(lVar5,DAT_181da3bf0);
                  if (lVar5 != null) {
                    FUN_18181e6b0(lVar5,"鉴定物品;ChooseIdentifyItem;false",DAT_181da3d70);
                    FUN_18181e6b0(lVar5,"取消;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000E2D
    // RVA   : 0xB67440   Offset: 0xB66840   Length: 0x5A4
    public void IdentifyItemMoney()
    {
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        plVar3 = (int64 *)FUN_1800d60b0(DAT_181da4138,4);
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
              lVar4 = il2cpp_value_box(DAT_181d80430,local_res8);
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
              if ((GameController._instance != null) &&
                 (lVar4 = GameController._instance.worldData) != null) {
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
                    lVar4 = il2cpp_value_box(DAT_181da22f0,local_res18);
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
                      lVar4 = il2cpp_value_box(DAT_181d80430,local_res20);
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
                      lVar4 = il2cpp_internal(DAT_181d97768);
                      FUN_181330100(lVar4,DAT_181da3bf0);
                      if (lVar4 != null) {
                        FUN_18181e6b0(lVar4,"鉴定物品;ChooseIdentifyItem;true",DAT_181da3d70);
                        FUN_18181e6b0(lVar4,"取消;HideInteractUI",DAT_181da3d70);
                        uVar17 = 0;
                        uVar7 = BuildingUIController.GenerateBuildingNPCString
                                          (this,"店铺商人",0xfffffffd,0xffffffff,
                                           CONCAT44(uVar16,0xffffffff),0);
                        uVar8 = il2cpp_internal(DAT_181da24f0);
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

    // Token : 0x6000E2E
    // RVA   : 0xB61740   Offset: 0xB60B40   Length: 0x218
    public void BreakThroughSkill()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        uVar2 = FUN_180228420(DAT_181d8b158);
        uVar2 = String.Format("博观约取，厚积薄发，突破抵达瓶颈的武功，方能更进一步。",uVar2,0);
        lVar3 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar3,DAT_181da3bf0);
        if (lVar3 != null) {
          FUN_18181e6b0(lVar3,"选择功法;BreakThroughSkill",DAT_181da3d70);
          FUN_18181e6b0(lVar3,"取消;HideInteractUI",DAT_181da3d70);
          uVar4 = new SinglePlotData(uVar2,lVar3,1,"",3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000E2F
    // RVA   : 0xB614F0   Offset: 0xB608F0   Length: 0x243
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        uVar2 = FUN_180228420(DAT_181d8b158);
        uVar2 = String.Format("这位少侠想租用本武馆的闭关室，用于突破瓶颈吗？\n保证安静舒适，价钱实惠~",uVar2,0);
        lVar3 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar3,DAT_181da3bf0);
        if (lVar3 != null) {
          FUN_18181e6b0(lVar3,"选择功法;BreakThroughSkillMoney",DAT_181da3d70);
          FUN_18181e6b0(lVar3,"还是算了;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000E30
    // RVA   : 0xB69440   Offset: 0xB68840   Length: 0xAC
    public void ManageTag()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.ChooseManageTagTarget(lVar1,0);
          return;
        }
    }

    // Token : 0x6000E31
    // RVA   : 0xB692F0   Offset: 0xB686F0   Length: 0x14F
    public void ManageTagMoney()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = ManageTagController._instance;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          uVar3 = WorldData.Player(lVar2,0);
          if (lVar1 != null) {
            ManageTagController.ShowManageTagUI(lVar1,uVar3,1,0);
            return;
          }
        }
    }

    // Token : 0x6000E32
    // RVA   : 0xB66790   Offset: 0xB65B90   Length: 0xAC
    public void HomeRest()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.HomeRest(lVar1,0);
          return;
        }
    }

    // Token : 0x6000E33
    // RVA   : 0xB67360   Offset: 0xB66760   Length: 0xD8
    public void HotelRest()
    {
        long lVar1;
        long lVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (this.buildingData != null) {
          lVar2 = AreaBuildingData.DataBase(this.buildingData,0);
          if ((lVar2 != null) && (lVar1 != null)) {
            PlotController.HotelRest(lVar1,*(uint64 *)(lVar2 + 24),0);
            return;
          }
        }
    }

    // Token : 0x6000E34
    // RVA   : 0xB71AC0   Offset: 0xB70EC0   Length: 0xD8
    public void SimpleWork()
    {
        long lVar1;
        long lVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (this.buildingData != null) {
          lVar2 = AreaBuildingData.DataBase(this.buildingData,0);
          if ((lVar2 != null) && (lVar1 != null)) {
            PlotController.SimpleWork(lVar1,*(uint64 *)(lVar2 + 24),0);
            return;
          }
        }
    }

    // Token : 0x6000E35
    // RVA   : 0xB6ABF0   Offset: 0xB69FF0   Length: 0x405
    public void PerformForMoney()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        if ((GameController._instance == null) ||
           (lVar5 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        if (lVar5.monthPerformForMoneyTime < 3) {
          lVar5 = BuildingUIController.PartyLvName;
          if (this.buildingData == null) throw; // [null/range check failed]
          lVar1 = AreaBuildingData.DataBase(this.buildingData,0);
          if (lVar1 == null) throw; // [null/range check failed]
          uVar2 = String.Format("此{0}之处人来人往，热闹非凡。\n何不找个显眼之处吆喝卖艺，好赚些盘缠？",*(uint64 *)(lVar1 + 24),0);
          lVar1 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar1,DAT_181da3bf0);
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_18181e6b0(lVar1,"武艺表演;StartCoachPlot",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"讲经说书;ChoosePerformForMoney;2",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"珍宝鉴定;ChoosePerformForMoney;3",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"还是算了;HideInteractUI",DAT_181da3d70);
          uVar3 = il2cpp_internal();
          uVar4 = "";
        }
        else {
          lVar5 = BuildingUIController.PartyLvName;
          uVar4 = FUN_180228420(DAT_181d8b158);
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

    // Token : 0x6000E36
    // RVA   : 0xB63D30   Offset: 0xB63130   Length: 0x590
    public void DoctorWork()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        uint[] local_res18 = new uint[2];
        int[] local_res20 = new int[2];
        if (((GameController._instance != null) &&
            (lVar2 = GameController._instance.worldData) != null) &&
           (lVar2 = WorldData.Player(lVar2,0)) != null) {
          iVar1 = HeroData.GetMaxDoctorTime(lVar2,0);
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            if (iVar1 <= lVar2.monthDoctorTime) {
              lVar2 = BuildingUIController.PartyLvName;
              uVar5 = GlobalData.GetNumText(iVar1,0);
              if ((((GameController._instance != null) &&
                   (lVar3 = GameController._instance.worldData) != null) &&
                  (lVar3 = WorldData.Player(lVar3,0)) != null) &&
                 (lVar3 = lVar3.showRoomChangeFame) != null) {
                if (lVar3.cityAreaID == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_res18[0] = *(uint32 *)(lVar3.chapter + 32);
                uVar4 = il2cpp_value_box(DAT_181da22f0,local_res18);
                local_res20[0] = iVar1;
                uVar6 = il2cpp_value_box(DAT_181d80430,local_res20);
                uVar4 = String.Format("这个月已经坐诊{0}日，还是应当再去多加磨炼医术，免得误人性命。\n(当前医术{1}点，每月最多可坐诊{2}次。)",uVar5,uVar4,uVar6,0);
                uVar5 = new SinglePlotData(uVar4,0,1,0,3,"0",1,0,0);
                if (lVar2 != null) {
        LAB_180b64081:
                  PlotController.ChangePlot(lVar2,uVar5,0);
                  return;
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar2 = BuildingUIController.PartyLvName;
            if ((this.buildingData != null) &&
               (lVar3 = AreaBuildingData.DataBase(this.buildingData,0)) != null) {
              uVar4 = String.Format("要在此处{0}坐诊吗？附近若有武林人士遭伤病困扰，便会来寻医问药。\n若能悬壶济世，救死扶伤，自是再好不过。",lVar3.cityAreaID,0);
              lVar3 = il2cpp_internal(DAT_181d97768);
              FUN_181330100(lVar3,DAT_181da3bf0);
              if (lVar3 != null) {
                FUN_18181e6b0(lVar3,"开诊;SureDoctorWork;;;;Med/20",DAT_181da3d70);
                FUN_18181e6b0(lVar3,"还是算了;HideInteractUI",DAT_181da3d70);
                uVar5 = new SinglePlotData(uVar4,lVar3,1,0,3,"0",1,0,0);
                if (lVar2 != null) goto LAB_180b64081;
              }
            }
          }
        }
    }

    // Token : 0x6000E37
    // RVA   : 0xB635C0   Offset: 0xB629C0   Length: 0x263
    public void CityQuickTravel()
    {
        var pStatics_4018 = *(int64*)(DAT_181d94018 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          cVar2 = WorldData.CanQuickTravel(lVar1,0);
          if (!cVar2) {
            lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
            uVar3 = FUN_180228420(DAT_181d8b158);
            uVar3 = String.Format("眼下身上有些重要任务，不便乘坐马车，还是改日吧。",uVar3,0);
            uVar4 = new SinglePlotData(uVar3,0,1,0,3,"0",1,0,0);
            if (lVar1 != null) {
              PlotController.ChangePlot(lVar1,uVar4,0);
              return;
            }
          }
          else {
            if (*pStatics_4018 != 0) {
              QuickTravelUIController.ShowQuickTravelUI(*pStatics_4018,1);
              return;
            }
          }
        }
    }

    // Token : 0x6000E38
    // RVA   : 0xB66EC0   Offset: 0xB662C0   Length: 0x49B
    public void HospitalCureInjury()
    {
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            local_res18[0] = Mathf.FloorToInt(lVar2.studyFightWithGreatHeroMultiWinNum,0);
            uVar3 = il2cpp_value_box(DAT_181d80430,local_res18);
            if ((GameController._instance != null) &&
               (lVar2 = GameController._instance.worldData) != null) {
              lVar2 = WorldData.Player(lVar2,0);
              if (lVar2 != null) {
                local_res20[0] = Mathf.FloorToInt(lVar2.studyFightWithGreatHeroFinalWinNum,0);
                uVar4 = il2cpp_value_box(DAT_181d80430,local_res20);
                if ((GameController._instance != null) &&
                   (lVar2 = GameController._instance.worldData) != null) {
                  lVar2 = WorldData.Player(lVar2,0);
                  if (lVar2 != null) {
                    local_38[0] = Mathf.FloorToInt(lVar2.totalHeroMeet,0);
                    uVar5 = il2cpp_value_box(DAT_181d80430,local_38);
                    uVar6 = 0;
                    uVar3 = String.Format("本馆医术精湛，深受周遭武林人士及百姓信赖。\n阁下身上若有什么疑难杂症，旧病沉疴，只管交给在下便是。\n（当前伤势：外伤{0}/内伤{1}/中毒{2}）",uVar3,uVar4,uVar5,0);
                    lVar2 = il2cpp_internal(DAT_181d97768);
                    FUN_181330100(lVar2,DAT_181da3bf0);
                    if (lVar2 != null) {
                      FUN_18181e6b0(lVar2,"包扎;HospitalCureExternalInjury;;;技能影响:医术",DAT_181da3d70);
                      FUN_18181e6b0(lVar2,"调息;HospitalCureInternalInjury;;;技能影响:医术 内功",DAT_181da3d70);
                      FUN_18181e6b0(lVar2,"解毒;HospitalCurePoison;;;技能影响:毒术",DAT_181da3d70);
                      FUN_18181e6b0(lVar2,"取消;HideInteractUI",DAT_181da3d70);
                      uVar7 = 0;
                      uVar4 = BuildingUIController.GenerateBuildingNPCString
                                        (this,"医师",2,0xffffffff,CONCAT44(uVar6,0xffffffff),0);
                      uVar5 = il2cpp_internal(DAT_181da24f0);
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

    // Token : 0x6000E39
    // RVA   : 0xB66840   Offset: 0xB65C40   Length: 0x67A
    public void HospitalCureInjuryForce()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint[] local_28 = new uint[4];
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            cVar2 = HeroData.HaveServantForce(lVar3,0);
            if (!cVar2) {
        LAB_180b66b06:
              lVar3 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
              if ((GameController._instance != null) &&
                 (lVar4 = GameController._instance.worldData) != null) {
                lVar4 = WorldData.Player(lVar4,0);
                if (lVar4 != null) {
                  local_res18[0] = Mathf.FloorToInt(lVar4.studyFightWithGreatHeroMultiWinNum,0);
                  uVar5 = il2cpp_value_box(DAT_181d80430,local_res18);
                  if ((GameController._instance != null) &&
                     (lVar4 = GameController._instance.worldData) != null) {
                    lVar4 = WorldData.Player(lVar4,0);
                    if (lVar4 != null) {
                      local_res20[0] = Mathf.FloorToInt(lVar4.studyFightWithGreatHeroFinalWinNum,0);
                      uVar6 = il2cpp_value_box(DAT_181d80430,local_res20);
                      if ((GameController._instance != null) &&
                         (lVar4 = GameController._instance.worldData) != null
                         ) {
                        lVar4 = WorldData.Player(lVar4,0);
                        if (lVar4 != null) {
                          local_28[0] = Mathf.FloorToInt(lVar4.totalHeroMeet,0);
                          uVar7 = il2cpp_value_box(DAT_181d80430,local_28);
                          uVar5 = String.Format("在疗伤室中，只需消耗门派药材便可治疗自身伤势。\n（当前伤势：外伤{0}/内伤{1}/中毒{2}）",uVar5,uVar6,uVar7,0);
                          lVar4 = il2cpp_internal(DAT_181d97768);
                          FUN_181330100(lVar4,DAT_181da3bf0);
                          if (lVar4 != null) {
                            FUN_18181e6b0(lVar4,"包扎;HospitalCureExternalInjuryForce;;;技能影响:医术",DAT_181da3d70);
                            FUN_18181e6b0(lVar4,"调息;HospitalCureInternalInjuryForce;;;技能影响:医术 内功",DAT_181da3d70);
                            FUN_18181e6b0(lVar4,"解毒;HospitalCurePoisonForce;;;技能影响:毒术",DAT_181da3d70);
                            FUN_18181e6b0(lVar4,"取消;HideInteractUI",DAT_181da3d70);
                            uVar6 = new SinglePlotData(uVar5,lVar4,1,0,3,"0",1,0,0);
                            if (lVar3 != null) {
                              PlotController.ChangePlot(lVar3,uVar6,0);
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
            if ((GameController._instance != null) &&
               (lVar3 = GameController._instance.worldData) != null) {
              lVar3 = WorldData.Player(lVar3,0);
              if (lVar3 != null) {
                iVar1 = *(int *)(lVar3 + 0x380);

                if ((lVar3 = *(int64 *)(*(int64 *)(DAT_181dac770 + 184) + 56)?.TempHeros) != null) {
                  if (iVar1 == lVar3.lastRandomWorldEventDay) {
                    BuildingUIController.HospitalCureInjury(this,0);
                    return;
                  }
                  goto LAB_180b66b06;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000E3A
    // RVA   : 0xB74840   Offset: 0xB73C40   Length: 0x45A
    public void StartBreakEquipment()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint[] local_res18 = new uint[2];
        if ((GameController._instance != null) &&
           (lVar4 = GameController._instance.worldData) != null) {
          if (2 < lVar4.monthBreakEquipTime) {
            lVar4 = BuildingUIController.PartyLvName;
            if ((GameController._instance != null) &&
               (lVar3 = GameController._instance.worldData) != null) {
              local_res18[0] = lVar3.monthBreakEquipTime;
              uVar1 = il2cpp_value_box(DAT_181d80430,local_res18);
              uVar2 = String.Format("本月已拆解过{0}件装备，还需等待弟子将废料清理完毕。",uVar1);
              uVar1 = new SinglePlotData(uVar2,0,1,0,3,"0",1,0,0);
              if (lVar4 != null) goto LAB_180b74ade;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = BuildingUIController.PartyLvName;
          uVar1 = FUN_180228420(DAT_181d8b158);
          uVar2 = String.Format("凭借我#PlayerForceName#秘法，可拆解成品装备，将其熔炼成锻造材料。\n所得材料会保留装备上的最多三个加成效果。",uVar1,0);
          lVar3 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar3,DAT_181da3bf0);
          if (lVar3 != null) {
            FUN_18181e6b0(lVar3,"选择装备;ChooseBreakEquipment",DAT_181da3d70);
            FUN_18181e6b0(lVar3,"取消;HideInteractUI");
            uVar1 = new SinglePlotData(uVar2,lVar3,1,0,3,"0",1,0,0);
            if (lVar4 != null) {
        LAB_180b74ade:
              PlotController.ChangePlot(lVar4,uVar1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000E3B
    // RVA   : 0xB75100   Offset: 0xB74500   Length: 0x45A
    public void StartBreakMed()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint[] local_res18 = new uint[2];
        if ((GameController._instance != null) &&
           (lVar4 = GameController._instance.worldData) != null) {
          if (2 < lVar4.monthBreakEquipTime) {
            lVar4 = BuildingUIController.PartyLvName;
            if ((GameController._instance != null) &&
               (lVar3 = GameController._instance.worldData) != null) {
              local_res18[0] = lVar3.monthBreakEquipTime;
              uVar1 = il2cpp_value_box(DAT_181d80430,local_res18);
              uVar2 = String.Format("本月已炼化过{0}件丹药，还需等待弟子将废料清理完毕。",uVar1);
              uVar1 = new SinglePlotData(uVar2,0,1,0,3,"0",1,0,0);
              if (lVar4 != null) goto LAB_180b7539e;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = BuildingUIController.PartyLvName;
          uVar1 = FUN_180228420(DAT_181d8b158);
          uVar2 = String.Format("凭借我#PlayerForceName#秘法，可将成品丹药炼化为药引。\n所得材料会保留丹药上的最多两个加成效果。",uVar1,0);
          lVar3 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar3,DAT_181da3bf0);
          if (lVar3 != null) {
            FUN_18181e6b0(lVar3,"选择丹药;ChooseBreakMed",DAT_181da3d70);
            FUN_18181e6b0(lVar3,"取消;HideInteractUI");
            uVar1 = new SinglePlotData(uVar2,lVar3,1,0,3,"0",1,0,0);
            if (lVar4 != null) {
        LAB_180b7539e:
              PlotController.ChangePlot(lVar4,uVar1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000E3C
    // RVA   : 0xB74CA0   Offset: 0xB740A0   Length: 0x45A
    public void StartBreakFood()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint[] local_res18 = new uint[2];
        if ((GameController._instance != null) &&
           (lVar4 = GameController._instance.worldData) != null) {
          if (2 < lVar4.monthBreakEquipTime) {
            lVar4 = BuildingUIController.PartyLvName;
            if ((GameController._instance != null) &&
               (lVar3 = GameController._instance.worldData) != null) {
              local_res18[0] = lVar3.monthBreakEquipTime;
              uVar1 = il2cpp_value_box(DAT_181d80430,local_res18);
              uVar2 = String.Format("本月已重烩过{0}件饮食，还需等待弟子将废料清理完毕。",uVar1);
              uVar1 = new SinglePlotData(uVar2,0,1,0,3,"0",1,0,0);
              if (lVar4 != null) goto LAB_180b74f3e;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar4 = BuildingUIController.PartyLvName;
          uVar1 = FUN_180228420(DAT_181d8b158);
          uVar2 = String.Format("凭借我#PlayerForceName#秘法，可将成品饮食重烩为食材。\n所得材料会保留饮食上的最多两个加成效果。",uVar1,0);
          lVar3 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar3,DAT_181da3bf0);
          if (lVar3 != null) {
            FUN_18181e6b0(lVar3,"选择饮食;ChooseBreakFood",DAT_181da3d70);
            FUN_18181e6b0(lVar3,"取消;HideInteractUI");
            uVar1 = new SinglePlotData(uVar2,lVar3,1,0,3,"0",1,0,0);
            if (lVar4 != null) {
        LAB_180b74f3e:
              PlotController.ChangePlot(lVar4,uVar1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000E3D
    // RVA   : 0xB75A00   Offset: 0xB74E00   Length: 0x5D
    public void StartCraftEquipment()
    {
        var pStatics = *(int64*)(DAT_181dba818 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,0,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E3E
    // RVA   : 0xB75D20   Offset: 0xB75120   Length: 0x5D
    public void StartEnhanceEquipment()
    {
        var pStatics = *(int64*)(DAT_181dc3788 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,0,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E3F
    // RVA   : 0xB75BA0   Offset: 0xB74FA0   Length: 0x5F
    public void StartCraftMed()
    {
        var pStatics = *(int64*)(DAT_181dba818 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,1,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E40
    // RVA   : 0xB75EC0   Offset: 0xB752C0   Length: 0x5F
    public void StartEnhanceMed()
    {
        var pStatics = *(int64*)(DAT_181dc3788 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,1,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E41
    // RVA   : 0xB75AD0   Offset: 0xB74ED0   Length: 0x5F
    public void StartCraftFood()
    {
        var pStatics = *(int64*)(DAT_181dba818 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,2,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E42
    // RVA   : 0xB75DF0   Offset: 0xB751F0   Length: 0x5F
    public void StartEnhanceFood()
    {
        var pStatics = *(int64*)(DAT_181dc3788 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,2,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E43
    // RVA   : 0xB75C60   Offset: 0xB75060   Length: 0x54
    public void StartCraftPoison()
    {
        var pStatics = *(int64*)(DAT_181dba790 + 184);
        if (*pStatics != 0) {
          CraftPoisonUIController.OpenCraftPoisonUI
                    (*pStatics,this.buildingData,0,0);
          return;
        }
    }

    // Token : 0x6000E44
    // RVA   : 0xB759A0   Offset: 0xB74DA0   Length: 0x5D
    public void StartCraftEquipmentMoney()
    {
        var pStatics = *(int64*)(DAT_181dba818 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,0,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E45
    // RVA   : 0xB75CC0   Offset: 0xB750C0   Length: 0x5D
    public void StartEnhanceEquipmentMoney()
    {
        var pStatics = *(int64*)(DAT_181dc3788 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,0,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E46
    // RVA   : 0xB75B30   Offset: 0xB74F30   Length: 0x60
    public void StartCraftMedMoney()
    {
        var pStatics = *(int64*)(DAT_181dba818 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,1,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E47
    // RVA   : 0xB75E50   Offset: 0xB75250   Length: 0x60
    public void StartEnhanceMedMoney()
    {
        var pStatics = *(int64*)(DAT_181dc3788 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,1,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E48
    // RVA   : 0xB75A60   Offset: 0xB74E60   Length: 0x60
    public void StartCraftFoodMoney()
    {
        var pStatics = *(int64*)(DAT_181dba818 + 184);
        if (*pStatics != 0) {
          CraftUIController.OpenCraftUI
                    (*pStatics,2,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E49
    // RVA   : 0xB75D80   Offset: 0xB75180   Length: 0x60
    public void StartEnhanceFoodMoney()
    {
        var pStatics = *(int64*)(DAT_181dc3788 + 184);
        if (*pStatics != 0) {
          EnhanceUIController.OpenEnhanceUI
                    (*pStatics,2,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E4A
    // RVA   : 0xB75C00   Offset: 0xB75000   Length: 0x54
    public void StartCraftPoisonMoney()
    {
        var pStatics = *(int64*)(DAT_181dba790 + 184);
        if (*pStatics != 0) {
          CraftPoisonUIController.OpenCraftPoisonUI
                    (*pStatics,this.buildingData,1,0);
          return;
        }
    }

    // Token : 0x6000E4B
    // RVA   : 0xB65AC0   Offset: 0xB64EC0   Length: 0xAC
    public void GiveTreasureToGovern()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.GiveTreasureToGovern(lVar1,0);
          return;
        }
    }

    // Token : 0x6000E4C
    // RVA   : 0xB71BA0   Offset: 0xB70FA0   Length: 0x536
    public void SpeCure()
    {
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
        if (((GameController._instance != null) &&
            (lVar1 = GameController._instance.worldData) != null) &&
           (lVar1 = WorldData.Player(lVar1,0)) != null) {
          fVar6 = (float)HeroData.GetTotalInjury(lVar1,0);
          if (fVar6 != 0.0) {
            if (((GameController._instance != null) &&
                (lVar1 = GameController._instance.worldData) != null) &&
               (lVar1 = WorldData.Player(lVar1,0)) != null) {
              fVar6 = (float)HeroData.GetTotalInjury(lVar1,0);
              local_res18[0] = Mathf.RoundToInt((fVar6 * 0.02 + 1.0) * 1000.0,0);
              lVar1 = BuildingUIController.PartyLvName;
              local_res20[0] = local_res18[0];
              uVar2 = il2cpp_value_box(DAT_181d80430,local_res20);
              uVar2 = String.Format("本寺以医术闻名于世，无论大侠伤重几何，只需在此疗养三日便可痊愈。\n以大侠当前的伤势，在此处治愈需消耗{0}两银钱。",uVar2,0);
              lVar4 = il2cpp_internal(DAT_181d97768);
              FUN_181330100(lVar4,DAT_181da3bf0);
              uVar3 = Int32.ToString(local_res18,0);
              uVar3 = String.Concat("治愈;SpeCureStart;;0/",uVar3,0);
              if (lVar4 != null) {
                FUN_18181e6b0(lVar4,uVar3,DAT_181da3d70);
                FUN_18181e6b0(lVar4,"还是算了;HideInteractUI",DAT_181da3d70);
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
          lVar1 = BuildingUIController.PartyLvName;
          uVar2 = FUN_180228420(DAT_181d8b158);
          uVar2 = String.Format("我目前并无伤势在身，何必庸人自扰。",uVar2,0);
          uVar3 = new SinglePlotData(uVar2,0,1,0,CONCAT44(uVar8,3),"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000E4D
    // RVA   : 0xB72D30   Offset: 0xB72130   Length: 0x486
    public void SpeReduceBadFame()
    {
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
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          if (lVar1.monthSpeReduceBadFameTime < 1) {
            if (this.buildingData != null) {
              local_res18[0] =
                   Mathf.RoundToInt(((float)this.buildingData.lv * 0.5 + 1.0) *
                                     500.0,0);
              lVar1 = BuildingUIController.PartyLvName;
              local_res20[0] = local_res18[0];
              uVar2 = il2cpp_value_box(DAT_181d80430,local_res20);
              uVar2 = String.Format("少侠若在此处捐赠银两，修缮祠堂或是分发给穷苦百姓，便能削减在江湖中留下的恶名。\n以少侠当前的名望，在此处布施三日，需消耗{0}两银钱。",uVar2,0);
              lVar3 = il2cpp_internal(DAT_181d97768);
              FUN_181330100(lVar3,DAT_181da3bf0);
              uVar4 = Int32.ToString(local_res18,0);
              uVar4 = String.Concat("布施;SpeReduceBadFameStart;;0/",uVar4,0);
              if (lVar3 != null) {
                FUN_18181e6b0(lVar3,uVar4,DAT_181da3d70);
                FUN_18181e6b0(lVar3,"还是算了;HideInteractUI",DAT_181da3d70);
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
          lVar1 = BuildingUIController.PartyLvName;
          uVar2 = FUN_180228420(DAT_181d8b158);
          uVar2 = String.Format("这个月已经捐出许多银两，\n若是再大肆布施，只怕落得个虚仁假义的名声。",uVar2,0);
          uVar4 = new SinglePlotData(uVar2,0,1,0,CONCAT44(uVar7,3),"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000E4E
    // RVA   : 0xB73B00   Offset: 0xB72F00   Length: 0xD3B
    public void SpeStartParty()
    {
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
        if (((GameController._instance != null) &&
            (lVar2 = GameController._instance.worldData) != null) &&
           (lVar2 = WorldData.Player(lVar2,0)) != null) {
          if (*(float *)(lVar2 + 0x1c4) <= 200.0 && *(float *)(lVar2 + 0x1c4) != 200.0) {
            lVar2 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
            uVar6 = new SinglePlotData("需要至少200点声望才能在此举办宴会",0,1,0,CONCAT44(uVar1,3),"0",1,0,0);
            if (lVar2 != null) {
              PlotController.ChangePlot(lVar2,uVar6,0);
              return;
            }
          }
          else {
            if ((GameController._instance != null) &&
               (lVar2 = GameController._instance.worldData) != null) {
              if (lVar2.monthSpeAddFameTime < 1) {
                if (this.buildingData != null) {
                  uVar1 = Mathf.RoundToInt(((float)this.buildingData.lv * 0.5 +
                                            1.0) * 800.0,0);
                  lVar2 = il2cpp_internal(DAT_181d97768);
                  FUN_181330100(lVar2,DAT_181da3bf0);
                  plVar3 = (int64 *)FUN_1800d60b0(DAT_181da4138,7);
                  lVar5 = *(int64 *)(*(int64 *)(DAT_181db4020 + 184) + 24);
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
                      lVar5 = il2cpp_value_box(DAT_181d80430,local_res18);
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
                      lVar5 = il2cpp_value_box(DAT_181d80430,local_res20);
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
                      lVar5 = il2cpp_value_box(DAT_181d80430,&local_58);
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
                        lVar5 = il2cpp_value_box(DAT_181da22f0,&local_54);
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
                          lVar5 = il2cpp_value_box(DAT_181da22f0,&local_50);
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
                            FUN_18181e6b0(lVar2,uVar6,DAT_181da3d70);
                            FUN_18181e6b0(lVar2,"还是算了;HideInteractUI",DAT_181da3d70);
                            lVar5 = FUN_18046c400(0);
                            uVar6 = new PlotData(0);
                            if (lVar5 != null) {
                              *(uint64 *)(lVar5 + 0x108) = uVar6;
                              lVar5 = FUN_18046c400(0);
                              if ((lVar5 != null) && (*(int64 *)(lVar5 + 0x108) != 0)) {
                                lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x108) + 64);
                                uVar13 = 0;
                                uVar6 = BuildingUIController.GenerateBuildingNPCString
                                                  (this,"豪商",0xfffffffd,0xffffffff,
                                                   CONCAT44(uVar11,0xffffffff),0);
                                uVar7 = il2cpp_internal(DAT_181da24f0);
                                uVar12 = CONCAT44(uVar13,3);
                                SinglePlotData.ctor
                                          (uVar7,"落魄江湖载酒行，楚腰纤细掌中轻。十年一觉扬州梦，赢得青楼薄幸名。\n这烟花柳巷，自古以来便是名人雅士宴饮会客的不二场所。",0,5,uVar6,uVar12,"0",0,0,0);
                                uVar11 = (uint32)((uint64)uVar12 >> 32);
                                if (lVar5 != null) {
                                  FUN_18181e6b0(lVar5,uVar7,DAT_181da1408);
                                  lVar5 = FUN_18046c400(0);
                                  if ((lVar5 != null) && (*(int64 *)(lVar5 + 0x108) != 0)) {
                                    lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x108) + 64);
                                    plVar3 = (int64 *)FUN_1800d60b0(DAT_181da4138,5);
                                    local_4c = uVar1;
                                    lVar4 = il2cpp_value_box(DAT_181d80430,&local_4c);
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
                                            lVar4 = il2cpp_value_box(DAT_181da22f0,&local_48);
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
                                              uVar7 = il2cpp_internal(DAT_181da24f0);
                                              SinglePlotData.ctor
                                                        (uVar7,uVar6,lVar2,0,0,CONCAT44(uVar11,3),
                                                         "0",0,0,0);
                                              if (lVar5 != null) {
                                                FUN_18181e6b0(lVar5,uVar7,DAT_181da1408);
                                                lVar2 = FUN_18046c400(0);
                                                lVar5 = FUN_18046c400(0);
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
              lVar2 = FUN_18046c400(0);
              uVar6 = new SinglePlotData("这个月已经大肆宴饮一番，若是天天在这烟花柳巷中流连，只怕为江湖中人耻笑。",0,1,0,CONCAT44(uVar1,3),"0",1,0,0);
              if (lVar2 != null) {
                PlotController.ChangePlot(lVar2,uVar6,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000E4F
    // RVA   : 0xB65A80   Offset: 0xB64E80   Length: 0x36
    public int GetSpeTalentPoint()
    {
        if (this.buildingData == null) {
          return 1;
        }
        return (int)((float)this.buildingData.lv * 0.5 + 1.0);
    }

    // Token : 0x6000E50
    // RVA   : 0xB720E0   Offset: 0xB714E0   Length: 0x54F
    public void SpeGetTalentPoint()
    {
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
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          if (lVar1.monthSpeGetTalentPointTime < 1) {
            if (((GameController._instance != null) &&
                (lVar1 = GameController._instance.worldData) != null) &&
               (lVar1 = WorldData.Player(lVar1,0)) != null) {
              auVar7._0_8_ = HeroData.GetTotalTagPoint(lVar1,0);
              auVar7._8_8_ = extraout_XMM0_Qb;
              auVar8._4_12_ = auVar7._4_12_;
              auVar8._0_4_ = ((float)auVar7._0_8_ * 0.05 + 1.0) * 500.0;
              local_res18[0] = Mathf.RoundToInt(auVar8._0_8_,0);
              lVar1 = BuildingUIController.PartyLvName;
              local_res20[0] = local_res18[0];
              uVar2 = il2cpp_value_box(DAT_181d80430,local_res20);
              if (this.buildingData == null) {
                fVar6 = 0.0;
              }
              else {
                fVar6 = (float)this.buildingData.lv * 0.5;
              }
              local_38[0] = (int)(fVar6 + 1.0);
              uVar3 = il2cpp_value_box(DAT_181d80430,local_38);
              uVar2 = String.Format("这莫高窟虽地处幽僻，却藏有经书典籍无数。\n悬崖壁上的石窟亦是潜心闭关，修炼天赋的不二之选。\n以少侠当前之天赋，在此处闭关十五日需消耗{0}两银钱，预计可获得{1}点天赋。",uVar2,uVar3,0);
              lVar4 = il2cpp_internal(DAT_181d97768);
              FUN_181330100(lVar4,DAT_181da3bf0);
              uVar3 = Int32.ToString(local_res18,0);
              uVar3 = String.Concat("闭关;SpeGetTalentPointStart;;0/",uVar3,0);
              if (lVar4 != null) {
                FUN_18181e6b0(lVar4,uVar3,DAT_181da3d70);
                FUN_18181e6b0(lVar4,"还是算了;HideInteractUI",DAT_181da3d70);
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
          lVar1 = BuildingUIController.PartyLvName;
          uVar2 = FUN_180228420(DAT_181d8b158);
          uVar2 = String.Format("这个月已经潜心闭关过，还需要再积累些实践感悟才是。",uVar2,0);
          uVar3 = new SinglePlotData(uVar2,0,1,0,CONCAT44(uVar10,3),"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000E51
    // RVA   : 0xB65890   Offset: 0xB64C90   Length: 0xF8
    public int GetSpeRemoveSkillCost()
    {
        long lVar1;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          lVar1 = WorldData.Player(lVar1,0);
          if ((lVar1 != null) && (lVar1.customDifficultyData != null)) {
            Mathf.RoundToInt(((float)*(int *)(lVar1.customDifficultyData + 24) * 0.1 + 1.0) * 500.0,0
                             );
            return;
          }
        }
    }

    // Token : 0x6000E52
    // RVA   : 0xB731C0   Offset: 0xB725C0   Length: 0x357
    public void SpeRemoveSkill()
    {
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if ((lVar2 != null) && (lVar2.customDifficultyData != null)) {
            local_res18[0] =
                 Mathf.RoundToInt(((float)*(int *)(lVar2.customDifficultyData + 24) * 0.1 + 1.0) *
                                   500.0,0);
            uVar3 = il2cpp_value_box(DAT_181d80430,local_res18);
            uVar3 = String.Format("在这石窟之中与世隔绝，酣然入梦，足以明心见性，忘却前尘旧事。\n少侠只需耗费{0}银两在此闭关十日，便可遗忘一门<b>零重修为</b>的武学。",uVar3,0);
            lVar2 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar2,DAT_181da3bf0);
            if (lVar2 != null) {
              FUN_18181e6b0(lVar2,"选择武学;SpeRemoveSkillChoose",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"还是算了;HideInteractUI",DAT_181da3d70);
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

    // Token : 0x6000E53
    // RVA   : 0xB65990   Offset: 0xB64D90   Length: 0xE2
    public int GetSpeRemoveTagCost()
    {
        long lVar1;
        float fVar2;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          lVar1 = WorldData.Player(lVar1,0);
          if (lVar1 != null) {
            fVar2 = (float)HeroData.GetTotalTagPoint(lVar1,0);
            Mathf.RoundToInt((fVar2 * 0.05 + 1.0) * 2000.0,0);
            return;
          }
        }
    }

    // Token : 0x6000E54
    // RVA   : 0xB73520   Offset: 0xB72920   Length: 0x5D4
    public void SpeRemoveTag()
    {
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
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        iVar8 = 0;
        while( true ) {
          if ((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null) break;
          lVar3 = WorldData.Player(lVar3,0);
          uVar10 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x368) == 0)) break;
          if (*(int *)(*(int64 *)(lVar3 + 0x368) + 24) <= iVar8) {
            if (lVar2 != null) {
              FUN_18181e6b0(lVar2,"还是算了;HideInteractUI",DAT_181da3d70);
              lVar3 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
              if ((GameController._instance != null) &&
                 (lVar6 = GameController._instance.worldData) != null) {
                lVar6 = WorldData.Player(lVar6,0);
                if (lVar6 != null) {
                  fVar9 = (float)HeroData.GetTotalTagPoint(lVar6,0);
                  local_res18[0] = Mathf.RoundToInt((fVar9 * 0.05 + 1.0) * 2000.0,0);
                  uVar4 = il2cpp_value_box(DAT_181d80430,local_res18);
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
          if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
          lVar3 = WorldData.Player(lVar3.villageAreaID,0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x368) == 0)) break;
          lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x368),iVar8,DAT_181d8c730);
          if (lVar3 == null) break;
          cVar1 = HeroTagData.IsPermanentTag(lVar3);
          if (cVar1) {
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (lVar3.villageAreaID == null)) {
        LAB_180b73ae9:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = WorldData.Player(lVar3.villageAreaID,0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x368) == 0)) goto LAB_180b73ae9;
            lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x368),iVar8,DAT_181d8c730);
            if (lVar3 == null) goto LAB_180b73ae9;
            lVar3 = HeroTagData.DataBase(lVar3,0);
            if (lVar3 == null) goto LAB_180b73ae9;
            uVar4 = HeroTagDataBase.Name(lVar3,0);
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (lVar3.villageAreaID == null)) goto LAB_180b73ae9;
            lVar3 = WorldData.Player(lVar3.villageAreaID,0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x368) == 0)) goto LAB_180b73ae9;
            lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x368),iVar8,DAT_181d8c730);
            if (lVar3 == null) goto LAB_180b73ae9;
            local_res18[0] = lVar3.chapter;
            uVar5 = il2cpp_value_box(DAT_181d80430,local_res18);
            uVar4 = String.Format("遗忘“{0}”;SpeRemoveTagChoose;{1}",uVar4,uVar5,0);
            if (lVar2 == null) goto LAB_180b73ae9;
            FUN_18181e6b0(lVar2,uVar4,DAT_181da3d70);
          }
          iVar8 = iVar8 + 1;
        }
    }

    // Token : 0x6000E55
    // RVA   : 0xB75560   Offset: 0xB74960   Length: 0x43F
    public void StartChallengeGhostGatePlot()
    {
        long lVar1;
        int iVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        int[] local_res18 = new int[2];
        if (((GameController._instance != null) &&
            (lVar1 = GameController._instance.worldData) != null) &&
           (lVar1 = lVar1.PlotEventLog) != null) {
          iVar2 = PlotEventLogData.GetInt(lVar1,"GhostGateLv");
          if (iVar2 < 41) {
            uVar4 = "在鬼门关孤身挑战强敌，于绝境之中磨炼心性与体魄，\n如此方能探求#PlayerForceName#修罗武道之神髓。\n当前鬼门关试炼为第{0}层，要进行挑战吗？";
            if (iVar2 == 40) {
              uVar4 = "历时多日，终于闯到鬼门关最后一层。\n此战需以一己之力，挑战十名绝顶高手，\n若未做好万全之准备，还是不要贸然尝试的好。";
            }
            lVar1 = BuildingUIController.PartyLvName;
            local_res18[0] = iVar2;
            uVar3 = il2cpp_value_box(DAT_181d80430,local_res18);
            uVar4 = String.Format(uVar4,uVar3,0);
            lVar5 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar5,DAT_181da3bf0);
            uVar3 = FUN_180228420(DAT_181d8b158);
            uVar3 = String.Format("开始试炼;StartChallengeGhostGateFight",uVar3,0);
            if (lVar5 != null) {
              FUN_18181e6b0(lVar5,uVar3,DAT_181da3d70);
              FUN_18181e6b0(lVar5,"还是算了;HideInteractUI");
              uVar3 = new SinglePlotData(uVar4,lVar5,1,0,3,"0",1,0,0);
              if (lVar1 != null) {
                PlotController.ChangePlot(lVar1,uVar3,0);
                return;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar1 = BuildingUIController.PartyLvName;
          uVar4 = FUN_180228420(DAT_181d8b158);
          uVar4 = String.Format("我已闯过阎罗殿最后一层，无需再继续试炼了。",uVar4);
          uVar3 = new SinglePlotData(uVar4,0,1,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.ChangePlot(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000E56
    // RVA   : 0xB6FFF0   Offset: 0xB6F3F0   Length: 0xAC
    public void ShowForceSpeResearch()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dc8378 + 184) + 56);
        if (lVar1 != null) {
          ForceSpeResearchUIController.ShowForceSpeResearchUI(lVar1,0);
          return;
        }
    }

    // Token : 0x6000E57
    // RVA   : 0xB719D0   Offset: 0xB70DD0   Length: 0x46
    public void ShowSpePoison()
    {
        var pStatics = *(int64*)(DAT_181da4368 + 184);
        if (*pStatics != 0) {
          SpePoisonController.ShowSpePoisonUI(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000E58
    // RVA   : 0xB78390   Offset: 0xB77790   Length: 0xAB
    public void StartSpeBookStorage()
    {
        if (SpeBookStorageController._instance != null) {
          SpeBookStorageController.ShowSpeBookStorageUI(SpeBookStorageController._instance,0);
          return;
        }
    }

    // Token : 0x6000E59
    // RVA   : 0xB71A20   Offset: 0xB70E20   Length: 0x46
    public void ShowSpeSummonResearch()
    {
        var pStatics = *(int64*)(DAT_181da44e8 + 184);
        if (*pStatics != 0) {
          SpeSummonResearchController.ShowSpeSummonResearchUI(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000E5A
    // RVA   : 0xB78440   Offset: 0xB77840   Length: 0x46
    public void StartSpeEnhanceEquip()
    {
        var pStatics = *(int64*)(DAT_181da4268 + 184);
        if (*pStatics != 0) {
          SpeEnhanceEquipController.ShowSpeEnhanceEquipUI(*pStatics,0);
          return;
        }
    }

    // Token : 0x6000E5B
    // RVA   : 0xB7AD00   Offset: 0xB7A100   Length: 0xAC
    public void StudyMartialClubSkill()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar1 != null) {
          PlotController.StudyMartialClubSkillStart(lVar1,0);
          return;
        }
    }

    // Token : 0x6000E5C
    // RVA   : 0xB7DA10   Offset: 0xB7CE10   Length: 0x15C
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar1,DAT_181da3bf0);
        if (lVar1 != null) {
          FUN_18181e6b0(lVar1,"天下熙熙皆为利来，这次一定要大赚特赚一笔！",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"春种一粒粟，秋收万颗子。",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"此地的树木苍翠葱郁，想必能制成优良的木材。",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"活动活动筋骨，准备大干一场吧。",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"得好好参照医书，辨认出各种药材才行。",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"必须把#AreaForceName#的声威向全武林传扬开来！",DAT_181da3d70);
          this.ProduceBuildingWorkText = lVar1;
          FUN_18044ef50(this,0);
          return;
        }
    }

    // Token : 0x6000E5D
    // RVA   : 0xB7D6D0   Offset: 0xB7CAD0   Length: 0x332
    private static void /*cctor*/()
    {
        long lVar1;
        **(uint32 **)(DAT_181db4020 + 184) = 0x3e99999a;
        lVar1 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar1,DAT_181da3bf0);
        if (lVar1 != null) {
          FUN_18181e6b0(lVar1,"盗窃",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"抢劫",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"用毒",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"投药",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"博骰",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"恶名",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"宴会",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"宴饮",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"分舵管理",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"任教",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"踢馆",DAT_181da3d70);
          FUN_18181e6b0(lVar1,"布施",DAT_181da3d70);
          PlotController.livingSkillIndexCache = lVar1;
          lVar1 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar1,DAT_181da3bf0);
          if (lVar1 != null) {
            FUN_18181e6b0(lVar1,"简陋",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"朴素",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"普通",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"精美",DAT_181da3d70);
            FUN_18181e6b0(lVar1,"奢华",DAT_181da3d70);
            PlotController._instance = lVar1;
            return;
          }
        }
    }

}
