// ============================================================
// Type  : SpriteVisibleController
// Token : 0x200037A
// ============================================================

public class SpriteVisibleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C9F
    public bool visible;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600225C
    // RVA   : 0xA08470   Offset: 0xA07270   Length: 0x5
    private void OnBecameVisible()
    {
        void FUN_180a08470(int64 this)
        {
        this.visible = 1;
    }

    // Token : 0x600225D
    // RVA   : 0x939850   Offset: 0x938650   Length: 0x5
    private void OnBecameInvisible()
    {
        void FUN_180939850(int64 this)
        {
        this.visible = 0;
    }

    // Token : 0x600225E
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
