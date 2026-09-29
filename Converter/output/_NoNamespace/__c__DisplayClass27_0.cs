// ============================================================
// Type  : <>c__DisplayClass27_0
// Token : 0x2000472
// ============================================================

public class <>c__DisplayClass27_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002126
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002716
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002717
    // RVA   : 0x9383C0   Offset: 0x9377C0   Length: 0x4F
    internal Vector3 <DOShakeAnchorPos>b__0()
    {
        ulong uVar1;
        if (*(int64 *)(param_2 + 16) != 0) {
          uVar1 = RectTransform.get_anchoredPosition(*(int64 *)(param_2 + 16),0);
          *this = uVar1;
          *(uint32 *)(this + 1) = 0;
          return this;
        }
    }

    // Token : 0x6002718
    // RVA   : 0x938410   Offset: 0x937810   Length: 0x37
    internal void <DOShakeAnchorPos>b__1(Vector3 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,*x,0);
          return;
        }
    }

}
