// ============================================================
// Type  : DestroyAfterTime
// Token : 0x200011F
// ============================================================

public class DestroyAfterTime
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400070F
    public float lifetime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000990
    // RVA   : 0x92BA30   Offset: 0x92A230   Length: 0x41
    private void Start()
    {
        MonoBehaviour.Invoke(this,"DestroyMe",this.lifetime,0);
    }

    // Token : 0x6000991
    // RVA   : 0x92B9D0   Offset: 0x92A1D0   Length: 0x5F
    private void DestroyMe()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        Object.Destroy(uVar1,0);
    }

    // Token : 0x6000992
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
