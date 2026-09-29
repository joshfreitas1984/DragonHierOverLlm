// ============================================================
// Type  : UIEquipmentSlot
// Token : 0x2000007
// ============================================================

public class UIEquipmentSlot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400002A
    public InvEquipment equipment;

    // Token: 0x400002B
    public Slot slot;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000028
    // RVA   : 0x12BD5B0   Offset: 0x12BC9B0   Length: 0x8C
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

    // Token : 0x6000029
    // RVA   : 0x12BD4F0   Offset: 0x12BC8F0   Length: 0xA2
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

    // Token : 0x600002A
    // RVA   : 0x12BD5A0   Offset: 0x12BC9A0   Length: 0x7
    public void /*ctor*/()
    {
        void FUN_1812bd5a0(uint64 this)
        {
        UIItemSlot.ctor(this,0);
    }

}
