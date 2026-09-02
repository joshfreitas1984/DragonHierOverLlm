// ============================================================
// Type  : FightResultContributionController
// Token : 0x200027D
// ============================================================

public class FightResultContributionController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001394
    public GameObject fightResultContributionPanel;

    // Token: 0x4001395
    public GameObject figthResultContributionHeroList;

    // Token: 0x4001396
    public GameObject figthResultContributionHeroPrefab;

    // Token: 0x4001397
    public GameObject fightResultButton;

    // Token: 0x4001398
    public List<HeroData> targetHeroList;

    // Token: 0x4001399
    private static List<int> RankExtraContribution;

    // Token: 0x400139A
    private GameObject temp;

    // Token: 0x400139B
    private static FightResultContributionController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001440
    // RVA   : 0xBA5660   Offset: 0xBA3E60   Length: 0x58
    public static FightResultContributionController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181da1ca0 + 184) + 8);
    }

    // Token : 0x6001441
    // RVA   : 0xBA4DC0   Offset: 0xBA35C0   Length: 0x11E
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181da1ca0 + 184);
        bool cVar1;
        ulong uVar2;
        uVar2 = *(uint64 *)(pStatics + 8);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          Object.Destroy(uVar2,0);
          return;
        }
        puVar3 = (uint64 *)(pStatics + 8);
        *puVar3 = this;
        il2cpp_internal(puVar3,this);
    }

    // Token : 0x6001442
    // RVA   : 0xBA4FB0   Offset: 0xBA37B0   Length: 0x546
    public void ShowFightResultContribution(List<HeroData> _targetHeroList)
    {
        var pStatics_1ca0 = *(int64*)(DAT_181da1ca0 + 184);
        var pStatics_1ea8 = *(int64*)(DAT_181d51ea8 + 184);
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
        lVar3 = *(int64 *)(pStatics_1ea8 + 8);
        if (lVar3 == null) {
          uVar4 = **(uint64 **)(DAT_181d51ea8 + 184);
          var lVar3 = new OnTooltipCB(uVar4,DAT_181d7a908,DAT_181d85f18);
          plVar8 = (int64 *)(pStatics_1ea8 + 8);
          *plVar8 = lVar3;
          il2cpp_internal(plVar8,lVar3);
        }
        if (lVar5 != null) {
          List_1.Sort(lVar5,lVar3,DAT_181d64278);
          lVar5 = this.targetHeroList;
          plVar8 = plVar9;
          if (lVar5 != null) {
            while (iVar7 = (int)plVar8, iVar7 < lVar5.Count) {
              uVar4 = this.figthResultContributionHeroList;
              uVar6 = this.figthResultContributionHeroPrefab;
              uVar4 = GlobalData.AddChild(uVar4,uVar6,0);
              this.temp = uVar4;
              if (this.temp == null) throw; // [null/range check failed]
              lVar5 = GameObject.GetComponent(this.temp,DAT_181d9f658);
              if ((this.targetHeroList == null) ||
                 (uVar4 = FUN_180002f80(this.targetHeroList,plVar8), lVar5 == null))
              throw; // [null/range check failed]
              lVar5.Count = uVar4;
              if (this.temp == null) throw; // [null/range check failed]
              lVar5 = GameObject.GetComponent(this.temp,DAT_181d9f658);
              if (*pStatics_1ca0 == 0) throw; // [null/range check failed]
              uVar4 = "";
              if (iVar7 < *(int *)(*pStatics_1ca0 + 24)) {
                uVar4 = *(uint64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x260);
                if (*pStatics_1ca0 == 0) throw; // [null/range check failed]
                local_res8[0] = FUN_1800d6750(*pStatics_1ca0,plVar8,DAT_181d68270);
                uVar6 = Int32.ToString(local_res8,"+0;-0;0",0);
                uVar4 = String.Concat(uVar4,uVar6,"</color>",0);
              }
              if (lVar5 == null) throw; // [null/range check failed]
              FightResultContributionHeroController.Init(lVar5,uVar4);
              if (*pStatics_1ca0 == 0) throw; // [null/range check failed]
              if (iVar7 < *(int *)(*pStatics_1ca0 + 24)) {
                if ((this.targetHeroList == null) ||
                   (lVar5 = FUN_180002f80(this.targetHeroList,plVar8,DAT_181d643f8)) == null
                   ) throw; // [null/range check failed]
                fVar1 = *(float *)(lVar5 + 176);
                if (*pStatics_1ca0 == 0) throw; // [null/range check failed]
                iVar2 = FUN_1800d6750(*pStatics_1ca0,plVar8);
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
                if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181d8a228)) {
                  plVar9 = plVar8;
                }
                NGUITools.PlaySound(plVar9,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001443
    // RVA   : 0xBA4EE0   Offset: 0xBA36E0   Length: 0xC8
    public void FightResultButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (this.fightResultButton != null) {
          GameObject.SetActive(this.fightResultButton,0,0);
          if (*pStatics != 0) {
            PlotController.StartFightResultContributionPlot(*pStatics,0);
            return;
          }
        }
    }

    // Token : 0x6001444
    // RVA   : 0xBA5500   Offset: 0xBA3D00   Length: 0x8A
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

    // Token : 0x6001445
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001446
    // RVA   : 0xBA5590   Offset: 0xBA3D90   Length: 0xC8
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar2,DAT_181d678f8);
        if (lVar2 != null) {
          FUN_181814fa0(lVar2,100,DAT_181d67a78);
          FUN_181814fa0(lVar2,50,DAT_181d67a78);
          FUN_181814fa0(lVar2,20,DAT_181d67a78);
          plVar1 = *(int64 **)(DAT_181da1ca0 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

}
