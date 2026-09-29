// ============================================================
// Type  : ForceHeroSettingController
// Token : 0x200028C
// ============================================================

public class ForceHeroSettingController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001477
    public GameObject forceSettingUIPanel;

    // Token: 0x4001478
    public ForceData targetForce;

    // Token: 0x4001479
    public GameObject forceAISettingHeroList;

    // Token: 0x400147A
    public GameObject HeroAISettingTabPrefab;

    // Token: 0x400147B
    private GameObject temp;

    // Token: 0x400147C
    private static ForceHeroSettingController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014BC
    // RVA   : 0xB3E1D0   Offset: 0xB3D5D0   Length: 0x36
    public static ForceHeroSettingController get_Instance()
    {
        return **(uint64 **)(DAT_181dc7eb0 + 184);
    }

    // Token : 0x60014BD
    // RVA   : 0xB3DDD0   Offset: 0xB3D1D0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181dc7eb0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60014BE
    // RVA   : 0xB3DE20   Offset: 0xB3D220   Length: 0x80
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

    // Token : 0x60014BF
    // RVA   : 0xB3DEB0   Offset: 0xB3D2B0   Length: 0x318
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
        LAB_180b3e1c3:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        GameObject.SetActive(this.forceSettingUIPanel,1,0);
        lVar2 = this.targetForce;
        local_res8[0] = 0;
        plVar5 = plVar7;
        do {
          if ((lVar2 == null) || (lVar2.ownHeros == null)) goto LAB_180b3e1c3;
          uVar6 = (uint32)plVar5;
          if (*(int *)(lVar2.ownHeros + 24) <= (int)uVar6) {
            uVar1 = this.forceAISettingHeroList;
            GlobalData.SortChild(uVar1,0);
            plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
            if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181daf360)) {
              plVar7 = plVar5;
            }
            NGUITools.PlaySound(plVar7,0);
            return;
          }
          if ((lVar2 = lVar2?.ownHeros) == null) goto LAB_180b3e1c3;
          if (lVar2.forceName <= uVar6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar2.forceID[uVar6] != 0) {
            uVar1 = this.forceAISettingHeroList;
            uVar4 = this.HeroAISettingTabPrefab;
            uVar1 = GlobalData.AddChild(uVar1,uVar4,0);
            this.temp = uVar1;
            if (this.temp == null) goto LAB_180b3e1c3;
            lVar2 = GameObject.GetComponent(this.temp,DAT_181d718a8);
            if ((this.targetForce == null) ||
               (uVar1 = ForceData.GetOwnHero(this.targetForce,local_res8[0],0), lVar2 == null))
            goto LAB_180b3e1c3;
            lVar2.forceName = uVar1;
            if ((this.temp == null) ||
               (lVar2 = GameObject.GetComponent(this.temp,DAT_181d718a8)) == null
               ) goto LAB_180b3e1c3;
            HeroAISettingTabController.Generate(lVar2,0);
            lVar2 = this.temp;
            if ((this.targetForce == null) ||
               (lVar3 = ForceData.GetOwnHero(this.targetForce,local_res8[0],0)) == null)
            goto LAB_180b3e1c3;
            local_res10[0] = 5 - *(int *)(lVar3 + 184);
            uVar1 = Int32.ToString(local_res10,0);
            uVar4 = Int32.ToString(local_res8,"0000",0);
            uVar1 = String.Concat(uVar1,"_",uVar4,0);
            if (lVar2 == null) goto LAB_180b3e1c3;
            Object.set_name(lVar2,uVar1);
          }
          lVar2 = this.targetForce;
          local_res8[0] = local_res8[0] + 1;
          plVar5 = (int64 *)(uint64)local_res8[0];
        } while( true );
    }

    // Token : 0x60014C0
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
