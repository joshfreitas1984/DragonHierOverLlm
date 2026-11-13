// ============================================================
// Type  : UISoundVolume
// Token : 0x2000069
// ============================================================

public class UISoundVolume
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600026E
    // RVA   : 0x1609370   Offset: 0x1608170   Length: 0x113
    private void Awake()
    {
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        lVar2 = Component.GetComponent(this,DAT_181e7a238);
        uVar4 = NGUITools.get_soundVolume(0);
        if (lVar2 != null) {
          UIProgressBar.Set(lVar2,uVar4,1,0);
          uVar1 = *(uint64 *)(lVar2 + 104);
          uVar3 = new OnTooltipCB(this,DAT_181e52be0,0);
          EventDelegate.Add(uVar1,uVar3,0);
          return;
        }
    }

    // Token : 0x600026F
    // RVA   : 0x1609490   Offset: 0x1608290   Length: 0xB2
    private void OnChange()
    {
        long lVar1;
        lVar1 = **(int64 **)(DAT_181e904d0 + 184);
        if (lVar1 != null) {
          if (1 < *(int *)(lVar1 + 100)) {
            FUN_18007dbc0((float)(*(int *)(lVar1 + 100) + -1) * *(float *)(lVar1 + 56));
          }
          NGUITools.set_soundVolume();
          return;
        }
    }

    // Token : 0x6000270
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
