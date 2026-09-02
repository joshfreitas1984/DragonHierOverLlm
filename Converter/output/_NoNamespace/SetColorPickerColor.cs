// ============================================================
// Type  : SetColorPickerColor
// Token : 0x2000021
// ============================================================

public class SetColorPickerColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400008C
    private UIWidget mWidget;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000072
    // RVA   : 0x968B80   Offset: 0x967380   Length: 0x122
    public void SetToCurrent()
    {
        ulong uVar2;
        bool cVar3;
        long lVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar4 = this.mWidget;
        cVar3 = Object.op_Equality(lVar4,0,0);
        if (cVar3) {
          lVar4 = Component.GetComponent(this,DAT_181d6e7c0);
          *plVar1 = lVar4;
          il2cpp_internal(plVar1,lVar4);
        }
        uVar2 = **(uint64 **)(DAT_181d8a558 + 184);
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (cVar3) {
          lVar4 = **(int64 **)(DAT_181d8a558 + 184);
          if ((lVar4 == null) || (*plVar1 == 0)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_18 = *(uint32 *)(lVar4 + 24);
          uStack_14 = *(uint32 *)(lVar4 + 28);
          uStack_10 = *(uint32 *)(lVar4 + 32);
          uStack_c = *(uint32 *)(lVar4 + 36);
          UIWidget.set_color(*plVar1,&local_18,0);
        }
    }

    // Token : 0x6000073
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
