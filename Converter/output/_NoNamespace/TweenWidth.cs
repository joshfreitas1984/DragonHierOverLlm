// ============================================================
// Type  : TweenWidth
// Token : 0x20000C6
// ============================================================

public class TweenWidth
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40004BA
    public int from;

    // Token: 0x40004BB
    public int to;

    // Token: 0x40004BC
    public UIWidget fromTarget;

    // Token: 0x40004BD
    public UIWidget toTarget;

    // Token: 0x40004BE
    public bool updateTable;

    // Token: 0x40004BF
    private UIWidget mWidget;

    // Token: 0x40004C0
    private UITable mTable;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000610
    // RVA   : 0xAEE580   Offset: 0xAED980   Length: 0xAC
    public UIWidget get_cachedWidget()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mWidget;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.GetComponent(this,DAT_181d97078);
          this.mWidget = uVar2;
        }
        return this.mWidget;
    }

    // Token : 0x6000611
    // RVA   : 0xAEE630   Offset: 0xAEDA30   Length: 0x20
    public int get_width()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 164);
        }
    }

    // Token : 0x6000612
    // RVA   : 0xAEE660   Offset: 0xAEDA60   Length: 0x2B
    public void set_width(int value)
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          UIWidget.set_width(lVar1,value,0);
          return;
        }
    }

    // Token : 0x6000613
    // RVA   : 0xAEE630   Offset: 0xAEDA30   Length: 0x20
    public int get_value()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 164);
        }
    }

    // Token : 0x6000614
    // RVA   : 0xAEE660   Offset: 0xAEDA60   Length: 0x2B
    public void set_value(int value)
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          UIWidget.set_width(lVar1,value,0);
          return;
        }
    }

    // Token : 0x6000615
    // RVA   : 0xAEE280   Offset: 0xAED680   Length: 0x23D
    protected override void OnUpdate(float factor, bool isFinished)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        uVar4 = this.fromTarget;
        cVar1 = Object.op_Implicit(uVar4,0);
        if (cVar1) {
          if (this.fromTarget == null) goto LAB_180aee4b8;
          this.from = this.fromTarget.mWidth;
        }
        uVar4 = this.toTarget;
        cVar1 = Object.op_Implicit(uVar4,0);
        if (cVar1) {
          if (this.toTarget == null) goto LAB_180aee4b8;
          this.to = this.toTarget.mWidth;
        }
        uVar2 = Mathf.RoundToInt((1.0 - factor) * (float)this.from +
                                  (float)this.to * factor,0);
        lVar3 = TweenWidth.get_cachedWidget(this,0);
        if (lVar3 == null) {
        LAB_180aee4b8:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        UIWidget.set_width(lVar3,uVar2,0);
        if (this.updateTable) {
          uVar4 = this.mTable;
          cVar1 = Object.op_Equality(uVar4,0,0);
          if (cVar1) {
            uVar4 = Component.get_gameObject(this,0);
            uVar4 = NGUITools.FindInParents(uVar4,DAT_181d8f8b8);
            this.mTable = uVar4;
            uVar4 = this.mTable;
            cVar1 = Object.op_Equality(uVar4,0,0);
            if (cVar1) {
              this.updateTable = 0;
              return;
            }
          }
          if (this.mTable == null) goto LAB_180aee4b8;
          UITable.set_repositionNow(this.mTable,1,0);
        }
    }

    // Token : 0x6000616
    // RVA   : 0xAEE1B0   Offset: 0xAED5B0   Length: 0xC3
    public static TweenWidth Begin(UIWidget widget, float duration, int width)
    {
        ulong uVar1;
        long lVar2;
        if (widget != null) {
          uVar1 = Component.get_gameObject(widget,0);
          lVar2 = UITweener.Begin(uVar1,duration,0,DAT_181dc7230);
          if (lVar2 != null) {
            *(uint32 *)(lVar2 + 120) = *(uint32 *)(widget + 164);
            *(uint32 *)(lVar2 + 124) = width;
            if (duration <= 0.0) {
              UITweener.Sample(lVar2,0x3f800000,1,0);
              Behaviour.set_enabled(lVar2,0,0);
            }
            return lVar2;
          }
        }
    }

    // Token : 0x6000617
    // RVA   : 0xAEE550   Offset: 0xAED950   Length: 0x29
    public override void SetStartToCurrentValue()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          this.from = *(uint32 *)(lVar1 + 164);
          return;
        }
    }

    // Token : 0x6000618
    // RVA   : 0xAEE520   Offset: 0xAED920   Length: 0x29
    public override void SetEndToCurrentValue()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          this.to = *(uint32 *)(lVar1 + 164);
          return;
        }
    }

    // Token : 0x6000619
    // RVA   : 0xAEE4F0   Offset: 0xAED8F0   Length: 0x2C
    private void SetCurrentValueToStart()
    {
        uint uVar1;
        long lVar2;
        uVar1 = this.from;
        lVar2 = TweenWidth.get_cachedWidget(this,0);
        if (lVar2 != null) {
          UIWidget.set_width(lVar2,uVar1,0);
          return;
        }
    }

    // Token : 0x600061A
    // RVA   : 0xAEE4C0   Offset: 0xAED8C0   Length: 0x2C
    private void SetCurrentValueToEnd()
    {
        uint uVar1;
        long lVar2;
        uVar1 = this.to;
        lVar2 = TweenWidth.get_cachedWidget(this,0);
        if (lVar2 != null) {
          UIWidget.set_width(lVar2,uVar1,0);
          return;
        }
    }

    // Token : 0x600061B
    // RVA   : 0xAEA9D0   Offset: 0xAE9DD0   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180aea9d0(int64 this)
        {
        this.from = 100;
        this.to = 100;
        UITweener.ctor(this,0);
    }

}
