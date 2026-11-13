// ============================================================
// Type  : ForceHeroSettingController
// Token : 0x2000294
// ============================================================

public class ForceHeroSettingController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014BA
    public GameObject forceSettingUIPanel;

    // Token: 0x40014BB
    public ForceData targetForce;

    // Token: 0x40014BC
    public GameObject forceAISettingHeroList;

    // Token: 0x40014BD
    public GameObject HeroAISettingTabPrefab;

    // Token: 0x40014BE
    private GameObject temp;

    // Token: 0x40014BF
    private static ForceHeroSettingController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001528
    // RVA   : 0x8FFBB0   Offset: 0x8FE9B0   Length: 0x36
    public static ForceHeroSettingController get_Instance()
    {
        return **(uint64 **)(DAT_181e50bc0 + 184);
    }

    // Token : 0x6001529
    // RVA   : 0x8FF7B0   Offset: 0x8FE5B0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e50bc0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600152A
    // RVA   : 0x8FF800   Offset: 0x8FE600   Length: 0x80
    public void HideForceHeroSettingUI()
    {
        ulong uVar1;
        this.targetForce = 0;
        if (this.forceSettingUIPanel != null) {
          GameObject.SetActive(this.forceSettingUIPanel,0,0);
          uVar1 = this.forceAISettingHeroList;
          GlobalData.DeleteAllChild(uVar1,0);
          return;
        }
    }

    // Token : 0x600152B
    // RVA   : 0x8FF890   Offset: 0x8FE690   Length: 0x318
    public void ShowForceHeroSettingUI(ForceData _targetForce)
    {
        ulong uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint uVar6;
        uint[] local_res8 = new uint[2];
        int[] local_res10 = new int[2];
        plVar7 = (int64 *)0;
        local_res10[0] = 0;
        this.targetForce = _targetForce;
        if (this.forceSettingUIPanel == null) {
        LAB_1808ffba3:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        GameObject.SetActive(this.forceSettingUIPanel,1,0);
        lVar2 = this.targetForce;
        local_res8[0] = 0;
        plVar5 = plVar7;
        do {
          if ((lVar2 == null) || (lVar2.ownHeros == null)) goto LAB_1808ffba3;
          uVar6 = (uint32)plVar5;
          if (*(int *)(lVar2.ownHeros + 24) <= (int)uVar6) {
            uVar1 = this.forceAISettingHeroList;
            GlobalData.SortChild(uVar1,0);
            plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
              plVar7 = plVar5;
            }
            NGUITools.PlaySound(plVar7,0);
            return;
          }
          if ((lVar2 = lVar2?.ownHeros) == null) goto LAB_1808ffba3;
          if (lVar2.forceName <= uVar6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar2.forceID[uVar6] != 0) {
            uVar1 = this.forceAISettingHeroList;
            uVar4 = this.HeroAISettingTabPrefab;
            uVar1 = GlobalData.AddChild(uVar1,uVar4,0);
            this.temp = uVar1;
            if (this.temp == null) goto LAB_1808ffba3;
            lVar2 = GameObject.GetComponent(this.temp,DAT_181e54970);
            if ((this.targetForce == null) ||
               (uVar1 = ForceData.GetOwnHero(this.targetForce,local_res8[0],0), lVar2 == null))
            goto LAB_1808ffba3;
            lVar2.forceName = uVar1;
            if ((this.temp == null) ||
               (lVar2 = GameObject.GetComponent(this.temp,DAT_181e54970)) == null
               ) goto LAB_1808ffba3;
            HeroAISettingTabController.Generate(lVar2,0);
            lVar2 = this.temp;
            if ((this.targetForce == null) ||
               (lVar3 = ForceData.GetOwnHero(this.targetForce,local_res8[0],0)) == null)
            goto LAB_1808ffba3;
            local_res10[0] = 5 - *(int *)(lVar3 + 184);
            uVar1 = Int32.ToString(local_res10,0);
            uVar4 = Int32.ToString(local_res8,"0000",0);
            uVar1 = String.Concat(uVar1,"_",uVar4,0);
            if (lVar2 == null) goto LAB_1808ffba3;
            Object.set_name(lVar2,uVar1);
          }
          lVar2 = this.targetForce;
          local_res8[0] = local_res8[0] + 1;
          plVar5 = (int64 *)(uint64)local_res8[0];
        } while( true );
    }

    // Token : 0x600152C
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
