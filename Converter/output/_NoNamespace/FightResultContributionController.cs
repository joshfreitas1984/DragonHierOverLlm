// ============================================================
// Type  : FightResultContributionController
// Token : 0x200028A
// ============================================================

public class FightResultContributionController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001483
    public GameObject fightResultContributionPanel;

    // Token: 0x4001484
    public GameObject figthResultContributionHeroList;

    // Token: 0x4001485
    public GameObject figthResultContributionHeroPrefab;

    // Token: 0x4001486
    public GameObject fightResultButton;

    // Token: 0x4001487
    public List<HeroData> targetHeroList;

    // Token: 0x4001488
    private static List<int> RankExtraContribution;

    // Token: 0x4001489
    private GameObject temp;

    // Token: 0x400148A
    private static FightResultContributionController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014EC
    // RVA   : 0x8F00E0   Offset: 0x8EEEE0   Length: 0x58
    public static FightResultContributionController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181ea7428 + 184) + 8);
    }

    // Token : 0x60014ED
    // RVA   : 0x8EF840   Offset: 0x8EE640   Length: 0x11E
    private void Awake()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = PlotController.fightSkillIndexCache;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          Object.Destroy(uVar2,0);
          return;
        }
        PlotController.fightSkillIndexCache = this;
    }

    // Token : 0x60014EE
    // RVA   : 0x8EFA30   Offset: 0x8EE830   Length: 0x546
    public void ShowFightResultContribution(List<HeroData> _targetHeroList)
    {
        void FightResultContributionController.ShowFightResultContribution
                     (int64 this,uint64 _targetHeroList)
        {
        float fVar1;
        int iVar2;
        int64 lVar3;
        uint64 uVar4;
        int64 lVar5;
        uint64 uVar6;
        int iVar7;
        int64 *plVar8;
        int64 *plVar9;
        uint32 local_res8 [2];
        plVar9 = (int64 *)0;
        this.targetHeroList = _targetHeroList;
        local_res8[0] = 0;
        il2cpp_internal(this + 56,_targetHeroList);
        lVar5 = this.targetHeroList;
        lVar3 = FightResultContributionController._instance;
        if (lVar3 == null) {
          uVar4 = **(uint64 **)(DAT_181e56f48 + 184);
          var lVar3 = new OnTooltipCB(uVar4,DAT_181e87020,DAT_181e8bc90);
          FightResultContributionController._instance = lVar3;
        }
        if (lVar5 != null) {
          List_1.Sort(lVar5,lVar3,DAT_181e6dc70);
          lVar5 = this.targetHeroList;
          plVar8 = plVar9;
          if (lVar5 != null) {
            while (iVar7 = (int)plVar8, iVar7 < lVar5.Count) {
              uVar4 = this.figthResultContributionHeroList;
              uVar6 = this.figthResultContributionHeroPrefab;
              uVar4 = GlobalData.AddChild(uVar4,uVar6,0);
              this.temp = uVar4;
              if (this.temp == null) throw; // [null/range check failed]
              lVar5 = GameObject.GetComponent(this.temp,DAT_181e546c8);
              if ((this.targetHeroList == null) ||
                 (uVar4 = FUN_1800024b0(this.targetHeroList,plVar8), lVar5 == null))
              throw; // [null/range check failed]
              lVar5.Count = uVar4;
              if (this.temp == null) throw; // [null/range check failed]
              lVar5 = GameObject.GetComponent(this.temp,DAT_181e546c8);
              if (PlotController.attriIndexCache == null) throw; // [null/range check failed]
              uVar4 = "";
              if (iVar7 < PlotController.attriIndexCache.plotHappen) {
                uVar4 = *(uint64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x270);
                if (PlotController.attriIndexCache == null) throw; // [null/range check failed]
                local_res8[0] = FUN_180002480(PlotController.attriIndexCache,plVar8,DAT_181e71bf0);
                uVar6 = Int32.ToString(local_res8,"+0;-0;0",0);
                uVar4 = String.Concat(uVar4,uVar6,"</color>",0);
              }
              if (lVar5 == null) throw; // [null/range check failed]
              FightResultContributionHeroController.Init(lVar5,uVar4);
              if (PlotController.attriIndexCache == null) throw; // [null/range check failed]
              if (iVar7 < PlotController.attriIndexCache.plotHappen) {
                if ((this.targetHeroList == null) ||
                   (lVar5 = FUN_1800024b0(this.targetHeroList,plVar8,DAT_181e6dd70)) == null
                   ) throw; // [null/range check failed]
                fVar1 = *(float *)(lVar5 + 176);
                if (PlotController.attriIndexCache == null) throw; // [null/range check failed]
                iVar2 = FUN_180002480(PlotController.attriIndexCache,plVar8);
                *(float *)(lVar5 + 176) = (float)iVar2 + fVar1;
              }
              lVar5 = this.targetHeroList;
              plVar8 = (int64 *)(uint64)(iVar7 + 1);
              if (lVar5 == null) throw; // [null/range check failed]
            }
            if (this.fightResultContributionPanel != null) {
              GameObject.SetActive(this.fightResultContributionPanel,1,0);
              if (this.fightResultButton != null) {
                GameObject.SetActive(this.fightResultButton,1,0);
                plVar8 = (int64 *)Resources.Load("Sound/SoundEffect/人群欢呼",0);
                if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181e8f4a0)) {
                  plVar9 = plVar8;
                }
                NGUITools.PlaySound(plVar9,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60014EF
    // RVA   : 0x8EF960   Offset: 0x8EE760   Length: 0xC9
    public void FightResultButtonClicked()
    {
        long lVar1;
        if (this.fightResultButton != null) {
          GameObject.SetActive(this.fightResultButton,0,0);
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
          if (lVar1 != null) {
            PlotController.StartFightResultContributionPlot(lVar1,0);
            return;
          }
        }
    }

    // Token : 0x60014F0
    // RVA   : 0x8EFF80   Offset: 0x8EED80   Length: 0x8A
    public void UnshowFightResultContribution()
    {
        ulong uVar1;
        if (this.fightResultContributionPanel != null) {
          GameObject.SetActive(this.fightResultContributionPanel,0,0);
          uVar1 = this.figthResultContributionHeroList;
          GlobalData.DeleteAllChild(uVar1,0);
          this.targetHeroList = 0;
          return;
        }
    }

    // Token : 0x60014F1
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60014F2
    // RVA   : 0x8F0010   Offset: 0x8EEE10   Length: 0xC8
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar2,DAT_181e71270);
        if (lVar2 != null) {
          FUN_181769fe0(lVar2,100,DAT_181e713f0);
          FUN_181769fe0(lVar2,50,DAT_181e713f0);
          FUN_181769fe0(lVar2,20,DAT_181e713f0);
          plVar1 = *(int64 **)(DAT_181ea7428 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
