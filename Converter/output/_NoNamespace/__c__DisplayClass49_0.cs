// ============================================================
// Type  : <>c__DisplayClass49_0
// Token : 0x20002BF
// ============================================================

public class <>c__DisplayClass49_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400165C
    public GameObject target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001775
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001776
    // RVA   : 0x8D7460   Offset: 0x8D5C60   Length: 0x20
    internal void <UnshowEquipIcon>b__0()
    {
        if (this.target != null) {
          GameObject.SetActive(this.target,0,0);
          return;
        }
    }

}
