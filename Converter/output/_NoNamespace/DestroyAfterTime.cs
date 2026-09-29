// ============================================================
// Type  : DestroyAfterTime
// Token : 0x2000120
// ============================================================

public class DestroyAfterTime
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400072B
    public float lifetime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009A8
    // RVA   : 0x93B960   Offset: 0x93AD60   Length: 0x41
    private void Start()
    {
        MonoBehaviour.Invoke(this,"DestroyMe",this.lifetime,0);
    }

    // Token : 0x60009A9
    // RVA   : 0x93B900   Offset: 0x93AD00   Length: 0x5F
    private void DestroyMe()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        Object.Destroy(uVar1,0);
    }

    // Token : 0x60009AA
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
