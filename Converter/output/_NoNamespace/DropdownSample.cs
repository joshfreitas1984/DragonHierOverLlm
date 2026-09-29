// ============================================================
// Type  : DropdownSample
// Token : 0x20003DC
// ============================================================

public class DropdownSample
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EE9
    private TextMeshProUGUI text;

    // Token: 0x4001EEA
    private TMP_Dropdown dropdownWithoutPlaceholder;

    // Token: 0x4001EEB
    private TMP_Dropdown dropdownWithPlaceholder;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002454
    // RVA   : 0x940DF0   Offset: 0x9401F0   Length: 0x108
    public void OnButtonClick()
    {
        ulong uVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        plVar1 = this.text;
        local_res8[0] = 0;
        if (this.dropdownWithPlaceholder == null) throw; // [null/range check failed]
        uVar2 = "Error: Please make a selection";
        if (-1 < *(int *)(this.dropdownWithPlaceholder + 0x128)) {
          if (this.dropdownWithoutPlaceholder == null) throw; // [null/range check failed]
          local_res8[0] = *(uint32 *)(this.dropdownWithoutPlaceholder + 0x128);
          uVar2 = Int32.ToString(local_res8,0);
          if (this.dropdownWithPlaceholder == null) throw; // [null/range check failed]
          local_res8[0] = *(uint32 *)(this.dropdownWithPlaceholder + 0x128);
          uVar3 = Int32.ToString(local_res8,0);
          uVar2 = String.Concat("Selected values:\n",uVar2," - ",uVar3,0);
        }
        if (plVar1 != (int64 *)0) {
          (**(code **)(*plVar1 + 0x558))(plVar1,uVar2,*(uint64 *)(*plVar1 + 0x560));
          return;
        }
    }

    // Token : 0x6002455
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
