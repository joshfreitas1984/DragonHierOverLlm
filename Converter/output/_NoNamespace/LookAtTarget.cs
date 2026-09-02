// ============================================================
// Type  : LookAtTarget
// Token : 0x20003C7
// ============================================================

public class LookAtTarget
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D77
    public Transform Target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002398
    // RVA   : 0xA8B1F0   Offset: 0xA899F0   Length: 0x2E
    private void Update()
    {
        long lVar1;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          Transform.LookAt(lVar1,this.Target,0);
          return;
        }
    }

    // Token : 0x6002399
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
