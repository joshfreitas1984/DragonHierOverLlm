// ============================================================
// Type  : UIStorageSlot
// Token : 0x200000A
// ============================================================

public class UIStorageSlot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400003D
    public UIItemStorage storage;

    // Token: 0x400003E
    public int slot;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000039
    // RVA   : 0x170BFF0   Offset: 0x170B3F0   Length: 0x8C
    protected override InvGameItem get_observedItem()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.storage;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.storage != null) {
            uVar2 = UIItemStorage.GetItem
                              (this.storage,this.slot,0);
            return uVar2;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x600003A
    // RVA   : 0x170BF40   Offset: 0x170B340   Length: 0xA2
    protected override InvGameItem Replace(InvGameItem item)
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.storage;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.storage != null) {
            uVar2 = UIItemStorage.Replace
                              (this.storage,this.slot,item,0);
            return uVar2;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return item;
    }

    // Token : 0x600003B
    // RVA   : 0x12BD5A0   Offset: 0x12BC9A0   Length: 0x7
    public void /*ctor*/()
    {
        void FUN_1812bd5a0(uint64 this)
        {
        UIItemSlot.ctor(this,0);
    }

}
