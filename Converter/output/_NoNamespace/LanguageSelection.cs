// ============================================================
// Type  : LanguageSelection
// Token : 0x2000029
// ============================================================

public class LanguageSelection
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000A4
    private UIPopupList mList;

    // Token: 0x40000A5
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600008B
    // RVA   : 0x7C4240   Offset: 0x7C3040   Length: 0x48
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181e79fb8);
        this.mList = uVar1;
    }

    // Token : 0x600008C
    // RVA   : 0x7C4490   Offset: 0x7C3290   Length: 0x152
    private void Start()
    {
        var pStatics = *(int64*)(DAT_181e5bed0 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        this.mStarted = 1;
        LanguageSelection.Refresh(this,0);
        if (this.mList != null) {
          uVar1 = this.mList.onChange;
          lVar3 = *(int64 *)(pStatics + 8);
          if (lVar3 == null) {
            uVar2 = **(uint64 **)(DAT_181e5bed0 + 184);
            lVar3 = new OnTooltipCB(uVar2,DAT_181e8a6a0,0);
            plVar4 = (int64 *)(pStatics + 8);
            *plVar4 = lVar3;
            il2cpp_internal(plVar4,lVar3);
          }
          EventDelegate.Add(uVar1,lVar3,0);
          return;
        }
    }

    // Token : 0x600008D
    // RVA   : 0x7C4290   Offset: 0x7C3090   Length: 0xE
    private void OnEnable()
    {
        void FUN_1807c4290(int64 this)
        {
        if (this.mStarted) {
          LanguageSelection.Refresh(this,0);
          return;
        }
    }

    // Token : 0x600008E
    // RVA   : 0x7C42B0   Offset: 0x7C30B0   Length: 0x1DC
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
                    if (this.mList == null) goto LAB_1807c4477;
                    lVar4 = this.mList.items;
                    lVar5 = Localization.get_knownLanguages(0);
                    if (lVar5 == null) goto LAB_1807c4477;
                    if (*(uint32 *)(lVar5 + 24) <= uVar7) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar6,0);
                    }
                    if (lVar4 == null) goto LAB_1807c4477;
                    FUN_18175de30(lVar4,lVar5[uVar7],
                                  DAT_181e86370);
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
        LAB_1807c4477:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x600008F
    // RVA   : 0x7C42A0   Offset: 0x7C30A0   Length: 0x7
    private void OnLocalize()
    {
        void FUN_1807c42a0(uint64 this)
        {
        LanguageSelection.Refresh(this,0);
    }

    // Token : 0x6000090
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
