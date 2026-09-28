// ============================================================
// Type  : FightResultContributionController
// Token : 0x2000283
// ============================================================

public class FightResultContributionController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001445
    public GameObject fightResultContributionPanel;

    // Token: 0x4001446
    public GameObject figthResultContributionHeroList;

    // Token: 0x4001447
    public GameObject figthResultContributionHeroPrefab;

    // Token: 0x4001448
    public GameObject fightResultButton;

    // Token: 0x4001449
    public List<HeroData> targetHeroList;

    // Token: 0x400144A
    private static List<int> RankExtraContribution;

    // Token: 0x400144B
    private GameObject temp;

    // Token: 0x400144C
    private static FightResultContributionController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001484
    // RVA   : 0xB2E060   Offset: 0xB2D460   Length: 0x58
    public static FightResultContributionController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181dc6f30 + 184) + 8);
    }

    // Token : 0x6001485
    // RVA   : 0xB2D7C0   Offset: 0xB2CBC0   Length: 0x11E
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

    // Token : 0x6001486
    // RVA   : 0xB2D9B0   Offset: 0xB2CDB0   Length: 0x546
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
          uVar4 = **(uint64 **)(DAT_181d77158 + 184);
          var lVar3 = new OnTooltipCB(uVar4,DAT_181da3788,DAT_181dab2b8);
          FightResultContributionController._instance = lVar3;
        }
        if (lVar5 != null) {
          List_1.Sort(lVar5,lVar3,DAT_181d8ba18);
          lVar5 = this.targetHeroList;
          plVar8 = plVar9;
          if (lVar5 != null) {
            while (iVar7 = (int)plVar8, iVar7 < lVar5.Count) {
              uVar4 = this.figthResultContributionHeroList;
              uVar6 = this.figthResultContributionHeroPrefab;
              uVar4 = GlobalData.AddChild(uVar4,uVar6,0);
              this.temp = uVar4;
              if (this.temp == null) throw; // [null/range check failed]
              lVar5 = GameObject.GetComponent(this.temp,DAT_181d71600);
              if ((this.targetHeroList == null) ||
                 (uVar4 = FUN_180002f80(this.targetHeroList,plVar8), lVar5 == null))
              throw; // [null/range check failed]
              lVar5.Count = uVar4;
              if (this.temp == null) throw; // [null/range check failed]
              lVar5 = GameObject.GetComponent(this.temp,DAT_181d71600);
              if (PlotController.attriIndexCache == null) throw; // [null/range check failed]
              uVar4 = "";
              if (iVar7 < PlotController.attriIndexCache.plotHappen) {
                uVar4 = *(uint64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x268);
                if (PlotController.attriIndexCache == null) throw; // [null/range check failed]
                local_res8[0] = FUN_1800d6760(PlotController.attriIndexCache,plVar8,DAT_181d8fa18);
                uVar6 = Int32.ToString(local_res8,"+0;-0;0",0);
                uVar4 = String.Concat(uVar4,uVar6,"</color>",0);
              }
              if (lVar5 == null) throw; // [null/range check failed]
              FightResultContributionHeroController.Init(lVar5,uVar4);
              if (PlotController.attriIndexCache == null) throw; // [null/range check failed]
              if (iVar7 < PlotController.attriIndexCache.plotHappen) {
                if ((this.targetHeroList == null) ||
                   (lVar5 = FUN_180002f80(this.targetHeroList,plVar8,DAT_181d8bb98)) == null
                   ) throw; // [null/range check failed]
                fVar1 = *(float *)(lVar5 + 176);
                if (PlotController.attriIndexCache == null) throw; // [null/range check failed]
                iVar2 = FUN_1800d6760(PlotController.attriIndexCache,plVar8);
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

    // Token : 0x6001487
    // RVA   : 0xB2D8E0   Offset: 0xB2CCE0   Length: 0xC9
    public void FightResultButtonClicked()
    {
        long lVar1;
        if (this.fightResultButton != null) {
          GameObject.SetActive(this.fightResultButton,0,0);
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
          if (lVar1 != null) {
            PlotController.StartFightResultContributionPlot(lVar1,0);
            return;
          }
        }
    }

    // Token : 0x6001488
    // RVA   : 0xB2DF00   Offset: 0xB2D300   Length: 0x8A
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

    // Token : 0x6001489
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600148A
    // RVA   : 0xB2DF90   Offset: 0xB2D390   Length: 0xC8
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar2,DAT_181d8f098);
        if (lVar2 != null) {
          FUN_18182a0b0(lVar2,100,DAT_181d8f218);
          FUN_18182a0b0(lVar2,50,DAT_181d8f218);
          FUN_18182a0b0(lVar2,20,DAT_181d8f218);
          plVar1 = *(int64 **)(DAT_181dc6f30 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
