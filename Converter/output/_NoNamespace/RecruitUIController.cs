// ============================================================
// Type  : RecruitUIController
// Token : 0x200034B
// ============================================================

public class RecruitUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B82
    public RecruitUIType recruitUIType;

    // Token: 0x4001B83
    public GameObject recruitUIPanel;

    // Token: 0x4001B84
    public GameObject togglePrefab;

    // Token: 0x4001B85
    private List<GameObject> tempHeroIcon;

    // Token: 0x4001B86
    public int nowChooseHero;

    // Token: 0x4001B87
    public GameObject sureButton;

    // Token: 0x4001B88
    public GameObject cancelButton;

    // Token: 0x4001B89
    private GameObject newObj;

    // Token: 0x4001B8A
    private static RecruitUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002138
    // RVA   : 0xA6BC70   Offset: 0xA6AA70   Length: 0x36
    public static RecruitUIController get_Instance()
    {
        return **(uint64 **)(DAT_181e7a5d8 + 184);
    }

    // Token : 0x6002139
    // RVA   : 0xA6AE90   Offset: 0xA69C90   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e7a5d8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600213A
    // RVA   : 0xA6B160   Offset: 0xA69F60   Length: 0xDE
    public void HideRecruitUI()
    {
        long lVar1;
        ulong uVar2;
        if (this.recruitUIPanel != null) {
          GameObject.SetActive(this.recruitUIPanel,0,0);
          if (this.recruitUIPanel != null) {
            lVar1 = GameObject.get_transform(this.recruitUIPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"ToggleGroup",0);
              if (lVar1 != null) {
                uVar2 = Component.get_gameObject(lVar1,0);
                GlobalData.DeleteAllChild(uVar2,0);
                if (this.tempHeroIcon != null) {
                  FUN_18115d8f0(this.tempHeroIcon,DAT_181e6b778);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600213B
    // RVA   : 0xA6B340   Offset: 0xA6A140   Length: 0x1EA
    public void ShowRecruitUI(RecruitUIType targetType, int heroNum, float recruitLv)
    {
        void RecruitUIController.ShowRecruitUI
                     (int64 this,uint32 targetType,uint32 heroNum,uint32 recruitLv)
        {
        int64 lVar1;
        uint64 uVar2;
        uint64 uVar3;
        if (this.recruitUIPanel != null) {
          GameObject.SetActive(this.recruitUIPanel,1,0);
          this.recruitUIType = targetType;
          if (this.recruitUIPanel != null) {
            lVar1 = GameObject.get_transform(this.recruitUIPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Title",0);
              if (lVar1 != null) {
                uVar2 = Component.GetComponent(lVar1,DAT_181e79538);
                uVar3 = "雇佣";
                if (this.recruitUIType == null) {
                  uVar3 = "招募";
                }
                LTLocalization.SetText(uVar2,uVar3,0);
                this.nowChooseHero = 0xffffffff;
                if (this.sureButton != null) {
                  lVar1 = GameObject.GetComponent(this.sureButton,DAT_181e53cb0);
                  if (lVar1 != null) {
                    Selectable.set_interactable(lVar1,this.nowChooseHero != -1,0);
                    var lVar1 = new WarpText_d__8(0,0);
                    if (lVar1 != null) {
                      *(int64 *)(lVar1 + 32) = this;
                      *(uint32 *)(lVar1 + 40) = recruitLv;
                      *(uint32 *)(lVar1 + 44) = heroNum;
                      FUN_180ae80b0(this,lVar1,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600213C
    // RVA   : 0xA6B240   Offset: 0xA6A040   Length: 0x8D
    public IEnumerator InitToggleButton(int heroNum, float recruitLv)
    {
        int64 RecruitUIController.InitToggleButton
                         (uint64 this,uint32 heroNum,uint32 recruitLv)
        {
        int64 lVar1;
        var lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          *(uint32 *)(lVar1 + 40) = recruitLv;
          *(uint32 *)(lVar1 + 44) = heroNum;
          return lVar1;
        }
    }

    // Token : 0x600213D
    // RVA   : 0xA6B2D0   Offset: 0xA6A0D0   Length: 0x69
    public void SetRecruitHero(int heroID)
    {
        long lVar1;
        this.nowChooseHero = heroID;
        if (this.sureButton != null) {
          lVar1 = GameObject.GetComponent(this.sureButton,DAT_181e53cb0);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,this.nowChooseHero != -1,0);
            return;
          }
        }
    }

    // Token : 0x600213E
    // RVA   : 0xA6AEE0   Offset: 0xA69CE0   Length: 0x273
    public void CancelRecruitHero()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        lVar2 = DAT_181e6dc98;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
        lVar4 = **(int64 **)(DAT_181e6dc98 + 48);
        if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
          FUN_1801a41f0(lVar4);
        }
        if ((*(byte *)(lVar4 + 0x133) & 4) != 0) {
          lVar4 = **(int64 **)(lVar2 + 48);
          if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
            FUN_1801a41f0(lVar4);
          }
          if (*(int *)(lVar4 + 224) == 0) {
            lVar4 = **(int64 **)(lVar2 + 48);
            if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
              FUN_1801a41f0(lVar4);
            }
            il2cpp_runtime_class_init(lVar4);
          }
        }
        lVar4 = **(int64 **)(lVar2 + 48);
        if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
          FUN_1801a41f0(lVar4);
        }
        uVar3 = String.Format("没有发现满意的人选，看来只能另做打算了。",**(uint64 **)(lVar4 + 184),0);
        lVar4 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar4,DAT_181e861f0);
        if (lVar4 != null) {
          FUN_18175de30(lVar4,"可惜可惜;HideInteractUI",DAT_181e86370);
          uVar5 = new SinglePlotData(uVar3,lVar4,0,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.AddPlot(lVar1,uVar5,0);
            RecruitUIController.HideRecruitUI(this,0);
            return;
          }
        }
    }

    // Token : 0x600213F
    // RVA   : 0xA6B530   Offset: 0xA6A330   Length: 0x6B3
    public void SureButtonClicked()
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        lVar3 = this.tempHeroIcon;
        if (lVar3 == null) throw; // [null/range check failed]
        uVar1 = this.nowChooseHero;
        if (lVar3.Count <= uVar1) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar3 = lVar3._items[uVar1];
        if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181e54c18)) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 32)) == null) throw; // [null/range check failed]
        iVar2 = HeroData.GetRecruitCost(lVar3,this.recruitUIType == 1,0x3f800000,0);
        if (this.recruitUIType == null) {
          if ((((GameController._instance == null) ||
               (lVar4 = GameController._instance.worldData) == null) ||
              (lVar4 = WorldData.Player(lVar4,0)) == null) || (lVar4.speBookStorageSpeAdd == null))
          throw; // [null/range check failed]
          if (*(int *)(lVar4.speBookStorageSpeAdd + 24) < iVar2) {
        LAB_180a6b8ff:
            lVar3 = FUN_1802106e0(0);
            if (lVar3 != null) {
              GameController.ShowTextOnMouse(lVar3,"银钱不足！",0);
              plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar10 = (int64 *)0;
              if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181e8f4a0)) {
                plVar10 = plVar9;
              }
              NGUITools.PlaySound(plVar10,0);
              return;
            }
            throw; // [null/range check failed]
          }
          lVar4 = FUN_1802106e0(0);
          if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
             (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) throw; // [null/range check failed]
          HeroData.ChangeMoney(lVar4,-iVar2,1,0);
          lVar4 = FUN_1802106e0(0);
          if (lVar4 == null) throw; // [null/range check failed]
          GameController.ManagePlayerRecruitHero(lVar4,lVar3,1,0);
          lVar4 = FUN_180210a70(0);
          lVar5 = HeroData.GetForce(lVar3,0,0);
          if (lVar5 == null) throw; // [null/range check failed]
          uVar6 = ForceData.GetForceName(lVar5,1,0);
          uVar6 = String.Format("承蒙#PlayerName#不弃，我必当赴汤蹈火，为{0}效犬马之劳。",uVar6,0);
          lVar5 = il2cpp_internal(DAT_181e77728);
          FUN_1810f3480(lVar5,DAT_181e861f0);
          if (lVar5 == null) throw; // [null/range check failed]
          FUN_18175de30(lVar5,"如虎添翼;HideInteractUI",DAT_181e86370);
          uVar7 = Int32.ToString(lVar3 + 88,0);
          uVar8 = new SinglePlotData(uVar6,lVar5,3,uVar7,3,"0",0,0,0);
        }
        else {
          if (this.recruitUIType != 1) goto LAB_180a6b8f0;
          lVar4 = FUN_1802106e0(0);
          if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
             ((lVar4 = WorldData.Player(lVar4.villageAreaID,0), lVar4 == null ||
              (lVar4.speBookStorageSpeAdd == null)))) throw; // [null/range check failed]
          if (*(int *)(lVar4.speBookStorageSpeAdd + 24) < iVar2) goto LAB_180a6b8ff;
          lVar4 = FUN_1802106e0(0);
          if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
             (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) throw; // [null/range check failed]
          HeroData.ChangeMoney(lVar4,-iVar2,1,0);
          lVar4 = FUN_1802106e0(0);
          if ((lVar4 == null) || (lVar4.villageAreaID == null)) throw; // [null/range check failed]
          WorldData.AddTempHero(lVar4.villageAreaID,lVar3,0);
          lVar4 = FUN_1802106e0(0);
          lVar5 = FUN_1802106e0(0);
          if ((lVar5 == null) ||
             ((*(int64 *)(lVar5 + 32) == 0 ||
              (uVar6 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar4 == null))))
          throw; // [null/range check failed]
          GameController.HeroJoinTeam(lVar4,uVar6,lVar3,30,0);
          *(uint16 *)(lVar3 + 0x304) = 0x101;
          lVar4 = FUN_180210a70(0);
          uVar6 = HeroData.HeroName(lVar3,0,0);
          uVar6 = String.Format("#PlayerName#出手果真大方！\n此后一个月有我{0}在旁护送，保管万事周全，一路太平！",uVar6,0);
          lVar5 = il2cpp_internal(DAT_181e77728);
          FUN_1810f3480(lVar5,DAT_181e861f0);
          if (lVar5 == null) throw; // [null/range check failed]
          FUN_18175de30(lVar5,"有劳阁下;HideInteractUI",DAT_181e86370);
          uVar7 = Int32.ToString(lVar3 + 88,0);
          uVar8 = new SinglePlotData(uVar6,lVar5,3,uVar7,3,"0",0,0,0);
        }
        if (lVar4 != null) {
          PlotController.AddPlot(lVar4,uVar8,0);
        LAB_180a6b8f0:
          RecruitUIController.HideRecruitUI(this,0);
          return;
        }
    }

    // Token : 0x6002140
    // RVA   : 0xA6BBF0   Offset: 0xA6A9F0   Length: 0x7D
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e72f38);
        FUN_1810f3480(uVar1,DAT_181e6b5f8);
        this.tempHeroIcon = uVar1;
        this.nowChooseHero = 0xffffffff;
        FUN_180ae8740(this,0);
    }

}
