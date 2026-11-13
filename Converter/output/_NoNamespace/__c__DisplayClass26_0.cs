// ============================================================
// Type  : <>c__DisplayClass26_0
// Token : 0x200047E
// ============================================================

public class <>c__DisplayClass26_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021B8
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027BD
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027BE
    // RVA   : 0x67EC90   Offset: 0x67DA90   Length: 0x4F
    internal Vector3 <DOPunchAnchorPos>b__0()
    {
        ulong uVar1;
        if (*(int64 *)(param_2 + 16) != 0) {
          uVar1 = RectTransform.get_anchoredPosition(*(int64 *)(param_2 + 16),0);
          *this = uVar1;
          *(uint32 *)(this + 1) = 0;
          return this;
        }
    }

    // Token : 0x60027BF
    // RVA   : 0x67ECE0   Offset: 0x67DAE0   Length: 0x37
    internal void <DOPunchAnchorPos>b__1(Vector3 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,*x,0);
          return;
        }
    }

}
