// ============================================================
// Type  : SpriteVisibleController
// Token : 0x2000366
// ============================================================

public class SpriteVisibleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B0B
    public bool visible;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002131
    // RVA   : 0xC6F620   Offset: 0xC6DE20   Length: 0x5
    private void OnBecameVisible()
    {
        this.visible = 1;
    }

    // Token : 0x6002132
    // RVA   : 0xBD5650   Offset: 0xBD3E50   Length: 0x5
    private void OnBecameInvisible()
    {
        this.visible = 0;
    }

    // Token : 0x6002133
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
