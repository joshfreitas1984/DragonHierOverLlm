// ============================================================
// Type  : <>c__DisplayClass28_0
// Token : 0x200046C
// ============================================================

public class <>c__DisplayClass28_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400201C
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002696
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002697
    // RVA   : 0x8D5840   Offset: 0x8D4040   Length: 0x4F
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

    // Token : 0x6002698
    // RVA   : 0x8D5890   Offset: 0x8D4090   Length: 0x37
    internal void <DOShakeAnchorPos>b__1(Vector3 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,*x,0);
          return;
        }
    }

}
