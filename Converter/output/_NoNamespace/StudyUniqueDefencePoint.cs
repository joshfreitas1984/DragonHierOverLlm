// ============================================================
// Type  : StudyUniqueDefencePoint
// Token : 0x200038A
// ============================================================

public class StudyUniqueDefencePoint
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C2E
    public List<GameObject> insideObjs;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600222B
    // RVA   : 0xB96100   Offset: 0xB94900   Length: 0x65
    public void OnTriggerEnter2D(Collider2D other)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.insideObjs;
        if (other != null) {
          uVar2 = Component.get_gameObject(other,0);
          if (lVar1 != null) {
            FUN_181827900(lVar1,uVar2,DAT_181d61bf8);
            return;
          }
        }
    }

    // Token : 0x600222C
    // RVA   : 0xB96170   Offset: 0xB94970   Length: 0x65
    public void OnTriggerExit2D(Collider2D other)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.insideObjs;
        if (other != null) {
          uVar2 = Component.get_gameObject(other,0);
          if (lVar1 != null) {
            FUN_181801c10(lVar1,uVar2,DAT_181d61e78);
            return;
          }
        }
    }

    // Token : 0x600222D
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
