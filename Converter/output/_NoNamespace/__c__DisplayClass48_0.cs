// ============================================================
// Type  : <>c__DisplayClass48_0
// Token : 0x20002CD
// ============================================================

public class <>c__DisplayClass48_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001763
    public GameObject target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001833
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001834
    // RVA   : 0x617600   Offset: 0x616400   Length: 0x56
    internal void <ShowEquipIcon>b__0()
    {
        long lVar1;
        if (this.target != null) {
          lVar1 = GameObject.GetComponent(this.target,DAT_181e53cb0);
          if (lVar1 != null) {
            Selectable.set_interactable(lVar1,1,0);
            return;
          }
        }
    }

}
