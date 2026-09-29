// ============================================================
// Type  : UIInputOnGUI
// Token : 0x20000FB
// ============================================================

public class UIInputOnGUI
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000628
    private UIInput mInput;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000801
    // RVA   : 0x118B880   Offset: 0x118AC80   Length: 0x48
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d969f8);
        this.mInput = uVar1;
    }

    // Token : 0x6000802
    // RVA   : 0x118B8D0   Offset: 0x118ACD0   Length: 0x5B
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
                          // WARNING: Could not recover jumptable at 0x00018118b919. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar1 + 0x198))(plVar1,uVar2,*(uint64 *)(*plVar1 + 0x1a0));
            return;
          }
        }
    }

    // Token : 0x6000803
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
