// ============================================================
// Type  : <>c__DisplayClass49_0
// Token : 0x20002C5
// ============================================================

public class <>c__DisplayClass49_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001710
    public GameObject target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017B9
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60017BA
    // RVA   : 0x939FE0   Offset: 0x9393E0   Length: 0x20
    internal void <UnshowEquipIcon>b__0()
    {
        if (this.target != null) {
          GameObject.SetActive(this.target,0,0);
          return;
        }
    }

}
