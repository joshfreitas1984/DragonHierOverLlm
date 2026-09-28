// ============================================================
// Type  : <>c__DisplayClass29_0
// Token : 0x2000474
// ============================================================

public class <>c__DisplayClass29_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002127
    public RectTransform target;

    // Token: 0x4002128
    public float startPosY;

    // Token: 0x4002129
    public bool offsetYSet;

    // Token: 0x400212A
    public float offsetY;

    // Token: 0x400212B
    public Sequence s;

    // Token: 0x400212C
    public Vector2 endValue;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600271C
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600271D
    // RVA   : 0x9378E0   Offset: 0x936CE0   Length: 0x1D
    internal Vector2 <DOJumpAnchorPos>b__0()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x600271E
    // RVA   : 0x937900   Offset: 0x936D00   Length: 0x1E
    internal void <DOJumpAnchorPos>b__1(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

    // Token : 0x600271F
    // RVA   : 0x937EE0   Offset: 0x9372E0   Length: 0x34
    internal void <DOJumpAnchorPos>b__2()
    {
        uint32 extraout_var;
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          this.startPosY = extraout_var;
          return;
        }
    }

    // Token : 0x6002720
    // RVA   : 0x9378E0   Offset: 0x936CE0   Length: 0x1D
    internal Vector2 <DOJumpAnchorPos>b__3()
    {
        if (this.target != null) {
          RectTransform.get_anchoredPosition(this.target,0);
          return;
        }
    }

    // Token : 0x6002721
    // RVA   : 0x937900   Offset: 0x936D00   Length: 0x1E
    internal void <DOJumpAnchorPos>b__4(Vector2 x)
    {
        if (this.target != null) {
          RectTransform.set_anchoredPosition(this.target,x,0);
          return;
        }
    }

    // Token : 0x6002722
    // RVA   : 0x937F20   Offset: 0x937320   Length: 0xBC
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
