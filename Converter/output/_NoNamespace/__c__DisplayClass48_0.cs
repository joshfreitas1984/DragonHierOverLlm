// ============================================================
// Type  : <>c__DisplayClass48_0
// Token : 0x20002C4
// ============================================================

public class <>c__DisplayClass48_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400170F
    public GameObject target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017B7
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60017B8
    // RVA   : 0x9398F0   Offset: 0x938CF0   Length: 0x56
    internal void <ShowEquipIcon>b__0()
    {
        long lVar1;
        if (this.target != null) {
          lVar1 = GameObject.GetComponent(this.target,DAT_181dc7c00);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,1,0);
            return;
          }
        }
    }

}
