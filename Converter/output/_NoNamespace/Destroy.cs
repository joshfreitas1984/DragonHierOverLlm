// ============================================================
// Type  : Destroy
// Token : 0x20003C2
// ============================================================

public class Destroy
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D54
    public float lifetime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002387
    // RVA   : 0x92BA80   Offset: 0x92A280   Length: 0x7B
    private void Awake()
    {
        uint uVar1;
        ulong uVar2;
        uVar2 = Component.get_gameObject(this,0);
        uVar1 = this.lifetime;
        Object.Destroy(uVar2,uVar1,0);
    }

    // Token : 0x6002388
    // RVA   : 0x92BB00   Offset: 0x92A300   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_18092bb00(int64 this)
        {
        this.lifetime = 0x40000000;
        FUN_18044ef50(this,0);
    }

}
