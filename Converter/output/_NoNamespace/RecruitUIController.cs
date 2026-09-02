// ============================================================
// Type  : RecruitUIController
// Token : 0x200033A
// ============================================================

public class RecruitUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A10
    public RecruitUIType recruitUIType;

    // Token: 0x4001A11
    public GameObject recruitUIPanel;

    // Token: 0x4001A12
    public GameObject togglePrefab;

    // Token: 0x4001A13
    private List<GameObject> tempHeroIcon;

    // Token: 0x4001A14
    public int nowChooseHero;

    // Token: 0x4001A15
    public GameObject sureButton;

    // Token: 0x4001A16
    public GameObject cancelButton;

    // Token: 0x4001A17
    private GameObject newObj;

    // Token: 0x4001A18
    private static RecruitUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002019
    // RVA   : 0xC61820   Offset: 0xC60020   Length: 0x36
    public static RecruitUIController get_Instance()
    {
        return **(uint64 **)(DAT_181d74fe0 + 184);
    }

    // Token : 0x600201A
    // RVA   : 0xC60A80   Offset: 0xC5F280   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d74fe0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600201B
    // RVA   : 0xC60D50   Offset: 0xC5F550   Length: 0xDE
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
                  FUN_180f56130(this.tempHeroIcon,DAT_181d61c78);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600201C
    // RVA   : 0xC60F30   Offset: 0xC5F730   Length: 0x1B0
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
                uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                uVar3 = "雇佣";
                if (this.recruitUIType == null) {
                  uVar3 = "招募";
                }
                LTLocalization.SetText(uVar2,uVar3,0);
                this.nowChooseHero = 0xffffffff;
                if (this.sureButton != null) {
                  lVar1 = GameObject.GetComponent(this.sureButton,DAT_181d9ee60);
                  if (lVar1 != null) {
                    Selectable.set_interactable(lVar1,this.nowChooseHero != -1,0);
                    var lVar1 = new WarpText_d__8(0,0);
                    if (lVar1 != null) {
                      *(int64 *)(lVar1 + 32) = this;
                      *(uint32 *)(lVar1 + 40) = recruitLv;
                      *(uint32 *)(lVar1 + 44) = heroNum;
                      FUN_180d837c0(this,lVar1,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600201D
    // RVA   : 0xC60E30   Offset: 0xC5F630   Length: 0x8D
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

    // Token : 0x600201E
    // RVA   : 0xC60EC0   Offset: 0xC5F6C0   Length: 0x69
    public void SetRecruitHero(int heroID)
    {
        long lVar1;
        this.nowChooseHero = heroID;
        if (this.sureButton != null) {
          lVar1 = GameObject.GetComponent(this.sureButton,DAT_181d9ee60);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,this.nowChooseHero != -1,0);
            return;
          }
        }
    }

    // Token : 0x600201F
    // RVA   : 0xC60AD0   Offset: 0xC5F2D0   Length: 0x272
    public void CancelRecruitHero()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        lVar2 = DAT_181d63120;
        lVar1 = **(int64 **)(DAT_181d6c960 + 184);
        lVar4 = **(int64 **)(DAT_181d63120 + 48);
        if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
          FUN_18009a510(lVar4);
        }
        if ((*(byte *)(lVar4 + 0x133) & 4) != 0) {
          lVar4 = **(int64 **)(lVar2 + 48);
          if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
            FUN_18009a510(lVar4);
          }
          if (*(int *)(lVar4 + 224) == 0) {
            lVar4 = **(int64 **)(lVar2 + 48);
            if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
              FUN_18009a510(lVar4);
            }
            il2cpp_runtime_class_init(lVar4);
          }
        }
        lVar4 = **(int64 **)(lVar2 + 48);
        if ((*(byte *)(lVar4 + 0x132) & 1) == 0) {
          FUN_18009a510(lVar4);
        }
        uVar3 = String.Format("没有发现满意的人选，看来只能另做打算了。",**(uint64 **)(lVar4 + 184),0);
        lVar4 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar4,DAT_181d7c250);
        if (lVar4 != null) {
          FUN_181827900(lVar4,"可惜可惜;HideInteractUI",DAT_181d7c3d0);
          uVar5 = new SinglePlotData(uVar3,lVar4,0,0,3,"0",1,0,0);
          if (lVar1 != null) {
            PlotController.AddPlot(lVar1,uVar5,0);
            RecruitUIController.HideRecruitUI(this,0);
            return;
          }
        }
    }

    // Token : 0x6002020
    // RVA   : 0xC610F0   Offset: 0xC5F8F0   Length: 0x6AA
    public void SureButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
        if (((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d9fb20)) == null) ||
           (lVar3 = *(int64 *)(lVar3 + 32)) == null) throw; // [null/range check failed]
        iVar2 = HeroData.GetRecruitCost(lVar3,this.recruitUIType == 1,0x3f800000,0);
        if (this.recruitUIType == null) {
          if ((((*pStatics == 0) ||
               (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
              (lVar4 = WorldData.Player(lVar4,0)) == null) || (*(int64 *)(lVar4 + 0x220) == 0))
          throw; // [null/range check failed]
          if (*(int *)(*(int64 *)(lVar4 + 0x220) + 24) < iVar2) {
        LAB_180c614b3:
            lVar3 = FUN_18046c0a0(0);
            if (lVar3 != null) {
              GameController.ShowTextOnMouse(lVar3,"银钱不足！",0);
              plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
              plVar10 = (int64 *)0;
              if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
                plVar10 = plVar9;
              }
              NGUITools.PlaySound(plVar10,0);
              return;
            }
            throw; // [null/range check failed]
          }
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
             (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null) throw; // [null/range check failed]
          HeroData.ChangeMoney(lVar4,-iVar2,1,0);
          lVar4 = FUN_18046c0a0(0);
          if (lVar4 == null) throw; // [null/range check failed]
          GameController.ManagePlayerRecruitHero(lVar4,lVar3,1,0);
          lVar4 = FUN_18046c440(0);
          lVar5 = HeroData.GetForce(lVar3,0,0);
          if (lVar5 == null) throw; // [null/range check failed]
          uVar6 = String.Format("承蒙#PlayerName#不弃，我必当赴汤蹈火，为{0}效犬马之劳。",*(uint64 *)(lVar5 + 24),0);
          lVar5 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar5,DAT_181d7c250);
          if (lVar5 == null) throw; // [null/range check failed]
          FUN_181827900(lVar5,"如虎添翼;HideInteractUI",DAT_181d7c3d0);
          uVar7 = Int32.ToString(lVar3 + 88,0);
          uVar8 = new SinglePlotData(uVar6,lVar5,3,uVar7,3,"0",0,0,0);
        }
        else {
          if (this.recruitUIType != 1) goto LAB_180c614a4;
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
             ((lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0), lVar4 == null ||
              (*(int64 *)(lVar4 + 0x220) == 0)))) throw; // [null/range check failed]
          if (*(int *)(*(int64 *)(lVar4 + 0x220) + 24) < iVar2) goto LAB_180c614b3;
          lVar4 = FUN_18046c0a0(0);
          if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
             (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null) throw; // [null/range check failed]
          HeroData.ChangeMoney(lVar4,-iVar2,1,0);
          lVar4 = FUN_18046c0a0(0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
          WorldData.AddTempHero(*(int64 *)(lVar4 + 32),lVar3,0);
          lVar4 = FUN_18046c0a0(0);
          lVar5 = FUN_18046c0a0(0);
          if ((lVar5 == null) ||
             ((*(int64 *)(lVar5 + 32) == 0 ||
              (uVar6 = WorldData.Player(*(int64 *)(lVar5 + 32),0), lVar4 == null))))
          throw; // [null/range check failed]
          GameController.HeroJoinTeam(lVar4,uVar6,lVar3,30,0);
          *(uint16 *)(lVar3 + 0x304) = 0x101;
          lVar4 = FUN_18046c440(0);
          uVar6 = HeroData.HeroName(lVar3,0,0);
          uVar6 = String.Format("#PlayerName#出手果真大方！\n此后一个月有我{0}在旁护送，保管万事周全，一路太平！",uVar6,0);
          lVar5 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar5,DAT_181d7c250);
          if (lVar5 == null) throw; // [null/range check failed]
          FUN_181827900(lVar5,"有劳阁下;HideInteractUI",DAT_181d7c3d0);
          uVar7 = Int32.ToString(lVar3 + 88,0);
          uVar8 = new SinglePlotData(uVar6,lVar5,3,uVar7,3,"0",0,0,0);
        }
        if (lVar4 != null) {
          PlotController.AddPlot(lVar4,uVar8,0);
        LAB_180c614a4:
          RecruitUIController.HideRecruitUI(this,0);
          return;
        }
    }

    // Token : 0x6002021
    // RVA   : 0xC617A0   Offset: 0xC5FFA0   Length: 0x7D
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e2b0);
        FUN_180f58a90(uVar1,DAT_181d61af8);
        this.tempHeroIcon = uVar1;
        this.nowChooseHero = 0xffffffff;
        FUN_18044ef50(this,0);
    }

}
