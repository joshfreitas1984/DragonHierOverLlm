// ============================================================
// Type  : UISoundVolume
// Token : 0x2000069
// ============================================================

public class UISoundVolume
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600026F
    // RVA   : 0x168EC10   Offset: 0x168D410   Length: 0x110
    private void Awake()
    {
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        lVar2 = Component.GetComponent(this,DAT_181d6e5c0);
        uVar4 = NGUITools.get_soundVolume(0);
        if (lVar2 != null) {
          UIProgressBar.set_value(lVar2,uVar4,0);
          uVar1 = *(uint64 *)(lVar2 + 104);
          uVar3 = new OnTooltipCB(this,DAT_181d9d488,0);
          EventDelegate.Add(uVar1,uVar3,0);
          return;
        }
    }

    // Token : 0x6000270
    // RVA   : 0x168ED30   Offset: 0x168D530   Length: 0x87
    private void OnChange()
    {
        var pStatics = *(int64*)(DAT_181d8ae58 + 184);
        uint uVar1;
        if (*pStatics != 0) {
          uVar1 = UIProgressBar.get_value(*pStatics,0);
          NGUITools.set_soundVolume(uVar1,0);
          return;
        }
    }

    // Token : 0x6000271
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
