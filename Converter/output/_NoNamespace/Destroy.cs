// ============================================================
// Type  : Destroy
// Token : 0x20003D6
// ============================================================

public class Destroy
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EF1
    public float lifetime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024B4
    // RVA   : 0x6810B0   Offset: 0x67FEB0   Length: 0x7B
    private void Awake()
    {
        uint uVar1;
        ulong uVar2;
        uVar2 = Component.get_gameObject(this,0);
        uVar1 = this.lifetime;
        Object.Destroy(uVar2,uVar1,0);
    }

    // Token : 0x60024B5
    // RVA   : 0x681130   Offset: 0x67FF30   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180681130(int64 this)
        {
        this.lifetime = 0x40000000;
        FUN_180ae8740(this,0);
    }

}
