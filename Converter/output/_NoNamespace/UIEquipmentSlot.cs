// ============================================================
// Type  : UIEquipmentSlot
// Token : 0x2000006
// ============================================================

public class UIEquipmentSlot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400000A
    public InvEquipment equipment;

    // Token: 0x400000B
    public Slot slot;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600000F
    // RVA   : 0x1144350   Offset: 0x1143150   Length: 0x8C
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
          FUN_1801e0300();
        }
        return 0;
    }

    // Token : 0x6000010
    // RVA   : 0x1144290   Offset: 0x1143090   Length: 0xA2
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
          FUN_1801e0300();
        }
        return item;
    }

    // Token : 0x6000011
    // RVA   : 0x1144340   Offset: 0x1143140   Length: 0x7
    public void /*ctor*/()
    {
        void FUN_181144340(uint64 this)
        {
        UIItemSlot.ctor(this,0);
    }

}
