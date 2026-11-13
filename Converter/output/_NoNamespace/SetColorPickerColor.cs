// ============================================================
// Type  : SetColorPickerColor
// Token : 0x2000021
// ============================================================

public class SetColorPickerColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000088
    private UIWidget mWidget;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000071
    // RVA   : 0x6A3160   Offset: 0x6A1F60   Length: 0x122
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
          lVar4 = Component.GetComponent(this,DAT_181e7a438);
          *plVar1 = lVar4;
          il2cpp_internal(plVar1,lVar4);
        }
        uVar2 = **(uint64 **)(DAT_181e8fbd0 + 184);
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (cVar3) {
          lVar4 = UIColorPicker.current;
          if ((lVar4 == null) || (*plVar1 == 0)) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          local_18 = lVar4.value;
          uStack_14 = *(uint32 *)(lVar4 + 28);
          uStack_10 = *(uint32 *)(lVar4 + 32);
          uStack_c = *(uint32 *)(lVar4 + 36);
          UIWidget.set_color(*plVar1,&local_18,0);
        }
    }

    // Token : 0x6000072
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
