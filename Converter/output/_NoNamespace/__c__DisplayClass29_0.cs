// ============================================================
// Type  : <>c__DisplayClass29_0
// Token : 0x2000481
// ============================================================

public class <>c__DisplayClass29_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021BB
    public RectTransform target;

    // Token: 0x40021BC
    public float startPosY;

    // Token: 0x40021BD
    public bool offsetYSet;

    // Token: 0x40021BE
    public float offsetY;

    // Token: 0x40021BF
    public Sequence s;

    // Token: 0x40021C0
    public Vector2 endValue;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60027C6
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027C7
    // RVA   : 0x67E8A0   Offset: 0x67D6A0   Length: 0x1D
    internal Vector2 <DOJumpAnchorPos>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x60027C8
    // RVA   : 0x67E8C0   Offset: 0x67D6C0   Length: 0x1E
    internal void <DOJumpAnchorPos>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

    // Token : 0x60027C9
    // RVA   : 0x67EEA0   Offset: 0x67DCA0   Length: 0x34
    internal void <DOJumpAnchorPos>b__2()
    {
        uint32 extraout_var;
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          this.startPosY = extraout_var;
          return;
        }
    }

    // Token : 0x60027CA
    // RVA   : 0x67E8A0   Offset: 0x67D6A0   Length: 0x1D
    internal Vector2 <DOJumpAnchorPos>b__3()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x60027CB
    // RVA   : 0x67E8C0   Offset: 0x67D6C0   Length: 0x1E
    internal void <DOJumpAnchorPos>b__4(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

    // Token : 0x60027CC
    // RVA   : 0x67EEE0   Offset: 0x67DCE0   Length: 0xBC
    internal void <DOJumpAnchorPos>b__5()
    {
        uint uVar1;
        ulong uVar2;
        float fVar3;
        uint uVar4;
        uint32 uStackX_c;
        if (!this.offsetYSet) {
          this.offsetYSet = 1;
          if (this.s == null) throw; // [null/range check failed]
          fVar3 = *(float *)(this + 52);
          if (*(char *)(this.s + 176) == false) {
            fVar3 = fVar3 - this.startPosY;
          }
          this.offsetY = fVar3;
        }
        if (this.target != null) {
          uVar2 = RectTransform.get_anchoredPosition(this.target,0);
          uVar1 = this.offsetY;
          uVar4 = TweenExtensions.ElapsedDirectionalPercentage(this.s,0);
          fVar3 = (float)DOVirtual.EasedValue(0,uVar1,uVar4,6,0);
          uStackX_c = (float)((uint64)uVar2 >> 32);
          if (this.target != null) {
            RectTransform.set_anchoredPosition
                      (this.target,CONCAT44(fVar3 + uStackX_c,(int)uVar2),0);
            return;
          }
        }
    }

}
