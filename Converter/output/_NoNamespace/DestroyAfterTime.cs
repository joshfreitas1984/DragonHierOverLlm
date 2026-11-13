// ============================================================
// Type  : DestroyAfterTime
// Token : 0x200011F
// ============================================================

public class DestroyAfterTime
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400070B
    public float lifetime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600098F
    // RVA   : 0x681060   Offset: 0x67FE60   Length: 0x41
    private void Start()
    {
        MonoBehaviour.Invoke(this,"DestroyMe",this.lifetime,0);
    }

    // Token : 0x6000990
    // RVA   : 0x681000   Offset: 0x67FE00   Length: 0x5F
    private void DestroyMe()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        Object.Destroy(uVar1,0);
    }

    // Token : 0x6000991
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
