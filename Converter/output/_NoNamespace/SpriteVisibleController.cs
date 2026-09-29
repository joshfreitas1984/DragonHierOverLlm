// ============================================================
// Type  : SpriteVisibleController
// Token : 0x200036D
// ============================================================

public class SpriteVisibleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C0D
    public bool visible;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021B2
    // RVA   : 0xC5F250   Offset: 0xC5E650   Length: 0x5
    private void OnBecameVisible()
    {
        void FUN_180c5f250(int64 this)
        {
        this.visible = 1;
    }

    // Token : 0x60021B3
    // RVA   : 0xB805A0   Offset: 0xB7F9A0   Length: 0x5
    private void OnBecameInvisible()
    {
        void FUN_180b805a0(int64 this)
        {
        this.visible = 0;
    }

    // Token : 0x60021B4
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
