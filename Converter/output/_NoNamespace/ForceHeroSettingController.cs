// ============================================================
// Type  : ForceHeroSettingController
// Token : 0x2000286
// ============================================================

public class ForceHeroSettingController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013C6
    public GameObject forceSettingUIPanel;

    // Token: 0x40013C7
    public ForceData targetForce;

    // Token: 0x40013C8
    public GameObject forceAISettingHeroList;

    // Token: 0x40013C9
    public GameObject HeroAISettingTabPrefab;

    // Token: 0x40013CA
    private GameObject temp;

    // Token: 0x40013CB
    private static ForceHeroSettingController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001478
    // RVA   : 0xBB4E90   Offset: 0xBB3690   Length: 0x98
    public static ForceHeroSettingController get_Instance()
    {
        return **(uint64 **)(DAT_181da2b20 + 184);
    }

    // Token : 0x6001479
    // RVA   : 0xBB4A90   Offset: 0xBB3290   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181da2b20 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600147A
    // RVA   : 0xBB4AE0   Offset: 0xBB32E0   Length: 0x80
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

    // Token : 0x600147B
    // RVA   : 0xBB4B70   Offset: 0xBB3370   Length: 0x318
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
        LAB_180bb4e83:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        GameObject.SetActive(this.forceSettingUIPanel,1,0);
        lVar2 = this.targetForce;
        local_res8[0] = 0;
        plVar5 = plVar7;
        do {
          if ((lVar2 == null) || (lVar2.ownHeros == null)) goto LAB_180bb4e83;
          uVar6 = (uint32)plVar5;
          if (*(int *)(lVar2.ownHeros + 24) <= (int)uVar6) {
            uVar1 = this.forceAISettingHeroList;
            GlobalData.SortChild(uVar1,0);
            plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
              plVar7 = plVar5;
            }
            NGUITools.PlaySound(plVar7,0);
            return;
          }
          if ((lVar2 = lVar2?.ownHeros) == null) goto LAB_180bb4e83;
          if (lVar2.forceName <= uVar6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar2.forceID[uVar6] != 0) {
            uVar1 = this.forceAISettingHeroList;
            uVar4 = this.HeroAISettingTabPrefab;
            uVar1 = GlobalData.AddChild(uVar1,uVar4,0);
            this.temp = uVar1;
            if (this.temp == null) goto LAB_180bb4e83;
            lVar2 = GameObject.GetComponent(this.temp,DAT_181d9f878);
            if ((this.targetForce == null) ||
               (uVar1 = ForceData.GetOwnHero(this.targetForce,local_res8[0],0), lVar2 == null))
            goto LAB_180bb4e83;
            lVar2.forceName = uVar1;
            if ((this.temp == null) ||
               (lVar2 = GameObject.GetComponent(this.temp,DAT_181d9f878)) == null
               ) goto LAB_180bb4e83;
            HeroAISettingTabController.Generate(lVar2,0);
            lVar2 = this.temp;
            if ((this.targetForce == null) ||
               (lVar3 = ForceData.GetOwnHero(this.targetForce,local_res8[0],0)) == null)
            goto LAB_180bb4e83;
            local_res10[0] = 5 - *(int *)(lVar3 + 184);
            uVar1 = Int32.ToString(local_res10,0);
            uVar4 = Int32.ToString(local_res8,"0000",0);
            uVar1 = String.Concat(uVar1,"_",uVar4,0);
            if (lVar2 == null) goto LAB_180bb4e83;
            Object.set_name(lVar2,uVar1);
          }
          lVar2 = this.targetForce;
          local_res8[0] = local_res8[0] + 1;
          plVar5 = (int64 *)(uint64)local_res8[0];
        } while( true );
    }

    // Token : 0x600147C
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
