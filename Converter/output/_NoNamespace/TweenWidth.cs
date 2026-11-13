// ============================================================
// Type  : TweenWidth
// Token : 0x20000C5
// ============================================================

public class TweenWidth
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400049A
    public int from;

    // Token: 0x400049B
    public int to;

    // Token: 0x400049C
    public UIWidget fromTarget;

    // Token: 0x400049D
    public UIWidget toTarget;

    // Token: 0x400049E
    public bool updateTable;

    // Token: 0x400049F
    private UIWidget mWidget;

    // Token: 0x40004A0
    private UITable mTable;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005F7
    // RVA   : 0x843300   Offset: 0x842100   Length: 0xAC
    public UIWidget get_cachedWidget()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mWidget;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.GetComponent(this,DAT_181e7a438);
          this.mWidget = uVar2;
        }
        return this.mWidget;
    }

    // Token : 0x60005F8
    // RVA   : 0x8433B0   Offset: 0x8421B0   Length: 0x20
    public int get_width()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 164);
        }
    }

    // Token : 0x60005F9
    // RVA   : 0x8433E0   Offset: 0x8421E0   Length: 0x2B
    public void set_width(int value)
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          UIWidget.set_width(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005FA
    // RVA   : 0x8433B0   Offset: 0x8421B0   Length: 0x20
    public int get_value()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 164);
        }
    }

    // Token : 0x60005FB
    // RVA   : 0x8433E0   Offset: 0x8421E0   Length: 0x2B
    public void set_value(int value)
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          UIWidget.set_width(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005FC
    // RVA   : 0x843000   Offset: 0x841E00   Length: 0x23D
    protected override void OnUpdate(float factor, bool isFinished)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        uVar4 = this.fromTarget;
        cVar1 = Object.op_Implicit(uVar4,0);
        if (cVar1) {
          if (this.fromTarget == null) goto LAB_180843238;
          this.from = this.fromTarget.mWidth;
        }
        uVar4 = this.toTarget;
        cVar1 = Object.op_Implicit(uVar4,0);
        if (cVar1) {
          if (this.toTarget == null) goto LAB_180843238;
          this.to = this.toTarget.mWidth;
        }
        uVar2 = Mathf.RoundToInt((1.0 - factor) * (float)this.from +
                                  (float)this.to * factor,0);
        lVar3 = TweenWidth.get_cachedWidget(this,0);
        if (lVar3 == null) {
        LAB_180843238:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        UIWidget.set_width(lVar3,uVar2,0);
        if (this.updateTable) {
          uVar4 = this.mTable;
          cVar1 = Object.op_Equality(uVar4,0,0);
          if (cVar1) {
            uVar4 = Component.get_gameObject(this,0);
            uVar4 = NGUITools.FindInParents(uVar4,DAT_181e72ef8);
            this.mTable = uVar4;
            uVar4 = this.mTable;
            cVar1 = Object.op_Equality(uVar4,0,0);
            if (cVar1) {
              this.updateTable = 0;
              return;
            }
          }
          if (this.mTable == null) goto LAB_180843238;
          UITable.set_repositionNow(this.mTable,1,0);
        }
    }

    // Token : 0x60005FD
    // RVA   : 0x842F30   Offset: 0x841D30   Length: 0xC3
    public static TweenWidth Begin(UIWidget widget, float duration, int width)
    {
        ulong uVar1;
        long lVar2;
        if (widget != null) {
          uVar1 = Component.get_gameObject(widget,0);
          lVar2 = UITweener.Begin(uVar1,duration,0,DAT_181e534e8);
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

    // Token : 0x60005FE
    // RVA   : 0x8432D0   Offset: 0x8420D0   Length: 0x29
    public override void SetStartToCurrentValue()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          this.from = *(uint32 *)(lVar1 + 164);
          return;
        }
    }

    // Token : 0x60005FF
    // RVA   : 0x8432A0   Offset: 0x8420A0   Length: 0x29
    public override void SetEndToCurrentValue()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          this.to = *(uint32 *)(lVar1 + 164);
          return;
        }
    }

    // Token : 0x6000600
    // RVA   : 0x843270   Offset: 0x842070   Length: 0x2C
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

    // Token : 0x6000601
    // RVA   : 0x843240   Offset: 0x842040   Length: 0x2C
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

    // Token : 0x6000602
    // RVA   : 0x83F750   Offset: 0x83E550   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_18083f750(int64 this)
        {
        this.from = 100;
        this.to = 100;
        UITweener.ctor(this,0);
    }

}
