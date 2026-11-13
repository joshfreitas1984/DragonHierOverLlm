// ============================================================
// Type  : UIInputOnGUI
// Token : 0x20000FA
// ============================================================

public class UIInputOnGUI
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000608
    private UIInput mInput;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60007E8
    // RVA   : 0xF88D40   Offset: 0xF87B40   Length: 0x48
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181e79db8);
        this.mInput = uVar1;
    }

    // Token : 0x60007E9
    // RVA   : 0xF88D90   Offset: 0xF87B90   Length: 0x5B
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
                          // WARNING: Could not recover jumptable at 0x000180f88dd9. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar1 + 0x198))(plVar1,uVar2,*(uint64 *)(*plVar1 + 0x1a0));
            return;
          }
        }
    }

    // Token : 0x60007EA
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
