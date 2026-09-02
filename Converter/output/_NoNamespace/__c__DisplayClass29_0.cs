// ============================================================
// Type  : <>c__DisplayClass29_0
// Token : 0x200046D
// ============================================================

public class <>c__DisplayClass29_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400201D
    public RectTransform target;

    // Token: 0x400201E
    public float startPosY;

    // Token: 0x400201F
    public bool offsetYSet;

    // Token: 0x4002020
    public float offsetY;

    // Token: 0x4002021
    public Sequence s;

    // Token: 0x4002022
    public Vector2 endValue;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002699
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600269A
    // RVA   : 0x8D5330   Offset: 0x8D3B30   Length: 0x1D
    internal Vector2 <DOJumpAnchorPos>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x600269B
    // RVA   : 0x8D5350   Offset: 0x8D3B50   Length: 0x1E
    internal void <DOJumpAnchorPos>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

    // Token : 0x600269C
    // RVA   : 0x8D59F0   Offset: 0x8D41F0   Length: 0x34
    internal void <DOJumpAnchorPos>b__2()
    {
        uint32 extraout_var;
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          this.startPosY = extraout_var;
          return;
        }
    }

    // Token : 0x600269D
    // RVA   : 0x8D5330   Offset: 0x8D3B30   Length: 0x1D
    internal Vector2 <DOJumpAnchorPos>b__3()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x600269E
    // RVA   : 0x8D5350   Offset: 0x8D3B50   Length: 0x1E
    internal void <DOJumpAnchorPos>b__4(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

    // Token : 0x600269F
    // RVA   : 0x8D5A30   Offset: 0x8D4230   Length: 0xBC
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
