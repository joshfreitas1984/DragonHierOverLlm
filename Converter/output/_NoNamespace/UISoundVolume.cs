// ============================================================
// Type  : UISoundVolume
// Token : 0x200006A
// ============================================================

public class UISoundVolume
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000287
    // RVA   : 0x1706A30   Offset: 0x1705E30   Length: 0x113
    private void Awake()
    {
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        lVar2 = Component.GetComponent(this,DAT_181d96e60);
        uVar4 = NGUITools.get_soundVolume(0);
        if (lVar2 != null) {
          UIProgressBar.Set(lVar2,uVar4,1,0);
          uVar1 = *(uint64 *)(lVar2 + 104);
          uVar3 = new OnTooltipCB(this,DAT_181dc6778,0);
          EventDelegate.Add(uVar1,uVar3,0);
          return;
        }
    }

    // Token : 0x6000288
    // RVA   : 0x1706B50   Offset: 0x1705F50   Length: 0xB2
    private void OnChange()
    {
        long lVar1;
        lVar1 = **(int64 **)(DAT_181db0078 + 184);
        if (lVar1 != null) {
          if (1 < *(int *)(lVar1 + 100)) {
            FUN_18000d7c0((float)(*(int *)(lVar1 + 100) + -1) * *(float *)(lVar1 + 56));
          }
          NGUITools.set_soundVolume();
          return;
        }
    }

    // Token : 0x6000289
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
