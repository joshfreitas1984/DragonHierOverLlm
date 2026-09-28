// ============================================================
// Type  : LookAtTarget
// Token : 0x20003CE
// ============================================================

public class LookAtTarget
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E81
    public Transform Target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600241B
    // RVA   : 0xA86730   Offset: 0xA85B30   Length: 0x2E
    private void Update()
    {
        long lVar1;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          Transform.LookAt(lVar1,this.Target,0);
          return;
        }
    }

    // Token : 0x600241C
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
