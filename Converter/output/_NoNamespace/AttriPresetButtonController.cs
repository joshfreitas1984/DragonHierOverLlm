// ============================================================
// Type  : AttriPresetButtonController
// Token : 0x2000145
// ============================================================

public class AttriPresetButtonController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A8B
    // RVA   : 0x5231E0   Offset: 0x521FE0   Length: 0x143
    public void OnClick()
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        lVar1 = StartMenuController._instance;
        uVar3 = Object.get_name(this,0);
        uVar2 = Int32.Parse(uVar3,0);
        if (lVar1 != null) {
          StartMenuController.SetAttriPreset(lVar1,uVar2,0);
          plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
          plVar5 = (int64 *)0;
          if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
            plVar5 = plVar4;
          }
          NGUITools.PlaySound(plVar5,0);
          return;
        }
    }

    // Token : 0x6000A8C
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
