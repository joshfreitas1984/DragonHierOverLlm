// ============================================================
// Type  : LanguageSelection
// Token : 0x2000029
// ============================================================

public class LanguageSelection
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000A8
    private UIPopupList mList;

    // Token: 0x40000A9
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600008C
    // RVA   : 0xA84860   Offset: 0xA83060   Length: 0x48
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6e340);
        this.mList = uVar1;
    }

    // Token : 0x600008D
    // RVA   : 0xA84AB0   Offset: 0xA832B0   Length: 0x152
    private void Start()
    {
        var pStatics = *(int64*)(DAT_181d56760 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        this.mStarted = 1;
        LanguageSelection.Refresh(this,0);
        if (this.mList != null) {
          uVar1 = this.mList.onChange;
          lVar3 = *(int64 *)(pStatics + 8);
          if (lVar3 == null) {
            uVar2 = **(uint64 **)(DAT_181d56760 + 184);
            lVar3 = new OnTooltipCB(uVar2,DAT_181d7dc68,0);
            plVar4 = (int64 *)(pStatics + 8);
            *plVar4 = lVar3;
            il2cpp_internal(plVar4,lVar3);
          }
          EventDelegate.Add(uVar1,lVar3,0);
          return;
        }
    }

    // Token : 0x600008E
    // RVA   : 0xA848B0   Offset: 0xA830B0   Length: 0xE
    private void OnEnable()
    {
        void FUN_180a848b0(int64 this)
        {
        if (this.mStarted) {
          LanguageSelection.Refresh(this,0);
          return;
        }
    }

    // Token : 0x600008F
    // RVA   : 0xA848D0   Offset: 0xA830D0   Length: 0x1DC
    public void Refresh()
    {
        int iVar1;
        bool cVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        uVar6 = this.mList;
        cVar3 = Object.op_Inequality(uVar6,0,0);
        if (cVar3) {
          lVar4 = Localization.get_knownLanguages(0);
          if (lVar4 != null) {
            plVar2 = this.mList;
            if (plVar2 != (int64 *)0) {
              (**(code **)(*plVar2 + 0x1a8))(plVar2,*(uint64 *)(*plVar2 + 0x1b0));
              uVar7 = 0;
              lVar4 = Localization.get_knownLanguages(0);
              if (lVar4 != null) {
                iVar1 = *(int *)(lVar4 + 24);
                if (0 < iVar1) {
                  do {
                    if (this.mList == null) goto LAB_180a84a97;
                    lVar4 = this.mList.items;
                    lVar5 = Localization.get_knownLanguages(0);
                    if (lVar5 == null) goto LAB_180a84a97;
                    if (*(uint32 *)(lVar5 + 24) <= uVar7) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    if (lVar4 == null) goto LAB_180a84a97;
                    FUN_181827900(lVar4,lVar5[uVar7],
                                  DAT_181d7c3d0);
                    uVar7 = uVar7 + 1;
                  } while ((int)uVar7 < iVar1);
                }
                plVar2 = this.mList;
                uVar6 = Localization.get_language(0);
                if (plVar2 != (int64 *)0) {
                  (**(code **)(*plVar2 + 0x188))(plVar2,uVar6,*(uint64 *)(*plVar2 + 400));
                  return;
                }
              }
            }
        LAB_180a84a97:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000090
    // RVA   : 0xA848C0   Offset: 0xA830C0   Length: 0x7
    private void OnLocalize()
    {
        void FUN_180a848c0(uint64 this)
        {
        LanguageSelection.Refresh(this,0);
    }

    // Token : 0x6000091
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
