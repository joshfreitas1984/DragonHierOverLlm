// ============================================================
// Type  : UIInputOnGUI
// Token : 0x20000FA
// ============================================================

public class UIInputOnGUI
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400060C
    private UIInput mInput;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60007E9
    // RVA   : 0x10ED500   Offset: 0x10EBD00   Length: 0x48
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6e140);
        this.mInput = uVar1;
    }

    // Token : 0x60007EA
    // RVA   : 0x10ED550   Offset: 0x10EBD50   Length: 0x5B
    private void OnGUI()
    {
        ulong uVar2;
        int iVar3;
        long lVar4;
        lVar4 = Event.get_current(0);
        if (lVar4 != null) {
          iVar3 = Event.get_rawType(lVar4,0);
          if (iVar3 != 4) {
            return;
          }
          plVar1 = this.mInput;
          uVar2 = Event.get_current(0);
          if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x0001810ed599. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar1 + 0x198))(plVar1,uVar2,*(uint64 *)(*plVar1 + 0x1a0));
            return;
          }
        }
    }

    // Token : 0x60007EB
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
