// ============================================================
// Type  : UIStorageSlot
// Token : 0x2000009
// ============================================================

public class UIStorageSlot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400001D
    public UIItemStorage storage;

    // Token: 0x400001E
    public int slot;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000020
    // RVA   : 0x160E320   Offset: 0x160D120   Length: 0x8C
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
          FUN_1801e0300();
        }
        return 0;
    }

    // Token : 0x6000021
    // RVA   : 0x160E270   Offset: 0x160D070   Length: 0xA2
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
          FUN_1801e0300();
        }
        return item;
    }

    // Token : 0x6000022
    // RVA   : 0x1144340   Offset: 0x1143140   Length: 0x7
    public void /*ctor*/()
    {
        void FUN_181144340(uint64 this)
        {
        UIItemSlot.ctor(this,0);
    }

}
