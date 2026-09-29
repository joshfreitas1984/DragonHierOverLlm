// ============================================================
// Type  : StudyUniqueDefencePoint
// Token : 0x2000391
// ============================================================

public class StudyUniqueDefencePoint
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D34
    public List<GameObject> insideObjs;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022AD
    // RVA   : 0xFE5650   Offset: 0xFE4A50   Length: 0x65
    public void OnTriggerEnter2D(Collider2D other)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.insideObjs;
        if (other != null) {
          uVar2 = Component.get_gameObject(other,0);
          if (lVar1 != null) {
            FUN_18181e6b0(lVar1,uVar2,DAT_181d893b0);
            return;
          }
        }
    }

    // Token : 0x60022AE
    // RVA   : 0xFE56C0   Offset: 0xFE4AC0   Length: 0x65
    public void OnTriggerExit2D(Collider2D other)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.insideObjs;
        if (other != null) {
          uVar2 = Component.get_gameObject(other,0);
          if (lVar1 != null) {
            FUN_1817ef410(lVar1,uVar2,DAT_181d89630);
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
