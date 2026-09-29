// ============================================================
// Type  : Destroy
// Token : 0x20003C9
// ============================================================

public class Destroy
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E5F
    public float lifetime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600240A
    // RVA   : 0x93B9B0   Offset: 0x93ADB0   Length: 0x7B
    private void Awake()
    {
        uint uVar1;
        ulong uVar2;
        uVar2 = Component.get_gameObject(this,0);
        uVar1 = this.lifetime;
        Object.Destroy(uVar2,uVar1,0);
    }

    // Token : 0x600240B
    // RVA   : 0x93BA30   Offset: 0x93AE30   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_18093ba30(int64 this)
        {
        this.lifetime = 0x40000000;
        FUN_18044ef50(this,0);
    }

}
