// ============================================================
// Type  : SetColorPickerColor
// Token : 0x2000022
// ============================================================

public class SetColorPickerColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000A8
    private UIWidget mWidget;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600008A
    // RVA   : 0x97BB60   Offset: 0x97AF60   Length: 0x122
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
          lVar4 = Component.GetComponent(this,DAT_181d97078);
          *plVar1 = lVar4;
          il2cpp_internal(plVar1,lVar4);
        }
        uVar2 = **(uint64 **)(DAT_181daf790 + 184);
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (cVar3) {
          lVar4 = UIColorPicker.current;
          if ((lVar4 == null) || (*plVar1 == 0)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_18 = lVar4.value;
          uStack_14 = *(uint32 *)(lVar4 + 28);
          uStack_10 = *(uint32 *)(lVar4 + 32);
          uStack_c = *(uint32 *)(lVar4 + 36);
          UIWidget.set_color(*plVar1,&local_18,0);
        }
    }

    // Token : 0x600008B
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
