// ============================================================
// Type  : <>c__DisplayClass48_0
// Token : 0x20002BE
// ============================================================

public class <>c__DisplayClass48_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400165B
    public GameObject target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001773
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001774
    // RVA   : 0x8D7400   Offset: 0x8D5C00   Length: 0x56
    internal void <ShowEquipIcon>b__0()
    {
        long lVar1;
        if (this.target != null) {
          lVar1 = GameObject.GetComponent(this.target,DAT_181d9ee60);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,1,0);
            return;
          }
        }
    }

}
