// ============================================================
// Type  : <>c__DisplayClass49_0
// Token : 0x20002CE
// ============================================================

public class <>c__DisplayClass49_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001764
    public GameObject target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001835
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001836
    // RVA   : 0x617660   Offset: 0x616460   Length: 0x20
    internal void <UnshowEquipIcon>b__0()
    {
        if (this.target != null) {
          GameObject.SetActive(this.target,0,0);
          return;
        }
    }

}
