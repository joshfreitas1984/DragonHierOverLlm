// ============================================================
// Type  : StudyUniqueDefencePoint
// Token : 0x2000391
// ============================================================

public class StudyUniqueDefencePoint
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D33
    public List<GameObject> insideObjs;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022AD
    // RVA   : 0xFE5040   Offset: 0xFE4440   Length: 0x65
    public void OnTriggerEnter2D(Collider2D other)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.insideObjs;
        if (other != null) {
          uVar2 = Component.get_gameObject(other,0);
          if (lVar1 != null) {
            FUN_18181e0a0(lVar1,uVar2,DAT_181d89398);
            return;
          }
        }
    }

    // Token : 0x60022AE
    // RVA   : 0xFE50B0   Offset: 0xFE44B0   Length: 0x65
    public void OnTriggerExit2D(Collider2D other)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.insideObjs;
        if (other != null) {
          uVar2 = Component.get_gameObject(other,0);
          if (lVar1 != null) {
            FUN_1817eee00(lVar1,uVar2,DAT_181d89618);
            return;
          }
        }
    }

    // Token : 0x60022AF
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
