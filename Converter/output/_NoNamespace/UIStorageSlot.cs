// ============================================================
// Type  : UIStorageSlot
// Token : 0x2000009
// ============================================================

public class UIStorageSlot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000021
    public UIItemStorage storage;

    // Token: 0x4000022
    public int slot;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000021
    // RVA   : 0x1693BA0   Offset: 0x16923A0   Length: 0x8C
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

    // Token : 0x6000022
    // RVA   : 0x1693AE0   Offset: 0x16922E0   Length: 0xA2
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

    // Token : 0x6000023
    // RVA   : 0x1693B90   Offset: 0x1692390   Length: 0x7
    public void /*ctor*/()
    {
        void FUN_181693b90(uint64 this)
        {
        UIItemSlot.ctor(this,0);
    }

}
