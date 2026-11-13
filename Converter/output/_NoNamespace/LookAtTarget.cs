// ============================================================
// Type  : LookAtTarget
// Token : 0x20003DB
// ============================================================

public class LookAtTarget
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001F14
    public Transform Target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024C5
    // RVA   : 0x7CAD50   Offset: 0x7C9B50   Length: 0x2E
    private void Update()
    {
        long lVar1;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          Transform.LookAt(lVar1,this.Target,0);
          return;
        }
    }

    // Token : 0x60024C6
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
