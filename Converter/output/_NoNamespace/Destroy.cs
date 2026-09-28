// ============================================================
// Type  : Destroy
// Token : 0x20003C9
// ============================================================

public class Destroy
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E5E
    public float lifetime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600240A
    // RVA   : 0x93B320   Offset: 0x93A720   Length: 0x7B
    private void Awake()
    {
        uint uVar1;
        ulong uVar2;
        uVar2 = Component.get_gameObject(this,0);
        uVar1 = this.lifetime;
        Object.Destroy(uVar2,uVar1,0);
    }

    // Token : 0x600240B
    // RVA   : 0x93B3A0   Offset: 0x93A7A0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_18093b3a0(int64 this)
        {
        this.lifetime = 0x40000000;
        FUN_18044ef50(this,0);
    }

}
