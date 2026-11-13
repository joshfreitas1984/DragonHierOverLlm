// ============================================================
// Type  : StudyUniqueDefencePoint
// Token : 0x200039E
// ============================================================

public class StudyUniqueDefencePoint
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DC6
    public List<GameObject> insideObjs;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002357
    // RVA   : 0xDB6710   Offset: 0xDB5510   Length: 0x65
    public void OnTriggerEnter2D(Collider2D other)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.insideObjs;
        if (other != null) {
          uVar2 = Component.get_gameObject(other,0);
          if (lVar1 != null) {
            FUN_18175de30(lVar1,uVar2,DAT_181e6b6f8);
            return;
          }
        }
    }

    // Token : 0x6002358
    // RVA   : 0xDB6780   Offset: 0xDB5580   Length: 0x65
    public void OnTriggerExit2D(Collider2D other)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.insideObjs;
        if (other != null) {
          uVar2 = Component.get_gameObject(other,0);
          if (lVar1 != null) {
            FUN_181665e90(lVar1,uVar2,DAT_181e6b978);
            return;
          }
        }
    }

    // Token : 0x6002359
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
