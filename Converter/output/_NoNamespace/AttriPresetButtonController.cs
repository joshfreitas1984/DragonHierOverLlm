// ============================================================
// Type  : AttriPresetButtonController
// Token : 0x2000145
// ============================================================

public class AttriPresetButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A89
    // RVA   : 0x7F2AD0   Offset: 0x7F12D0   Length: 0x143
    public void OnClick()
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        lVar1 = **(int64 **)(DAT_181d815f0 + 184);
        uVar3 = Object.get_name(this,0);
        uVar2 = Int32.Parse(uVar3,0);
        if (lVar1 != null) {
          StartMenuController.SetAttriPreset(lVar1,uVar2,0);
          plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
          plVar5 = (int64 *)0;
          if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
            plVar5 = plVar4;
          }
          NGUITools.PlaySound(plVar5,0);
          return;
        }
    }

    // Token : 0x6000A8A
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
