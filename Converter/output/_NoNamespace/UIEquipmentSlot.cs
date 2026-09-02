// ============================================================
// Type  : UIEquipmentSlot
// Token : 0x2000006
// ============================================================

public class UIEquipmentSlot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400000E
    public InvEquipment equipment;

    // Token: 0x400000F
    public Slot slot;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000010
    // RVA   : 0x10E6640   Offset: 0x10E4E40   Length: 0x8C
    protected override InvGameItem get_observedItem()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.equipment;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.equipment != null) {
            uVar2 = InvEquipment.GetItem(this.equipment,this.slot,0)
            ;
            return uVar2;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x6000011
    // RVA   : 0x10E6540   Offset: 0x10E4D40   Length: 0xA2
    protected override InvGameItem Replace(InvGameItem item)
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.equipment;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.equipment != null) {
            uVar2 = InvEquipment.Replace
                              (this.equipment,this.slot,item,0);
            return uVar2;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return item;
    }

    // Token : 0x6000012
    // RVA   : 0x10E65F0   Offset: 0x10E4DF0   Length: 0x47
    public void /*ctor*/()
    {
        *(uint64 *)(this + 80) = "";
        FUN_18044ef50(this,0);
    }

}
