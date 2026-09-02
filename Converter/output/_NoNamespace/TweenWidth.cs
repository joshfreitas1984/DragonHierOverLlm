// ============================================================
// Type  : TweenWidth
// Token : 0x20000C5
// ============================================================

public class TweenWidth
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400049E
    public int from;

    // Token: 0x400049F
    public int to;

    // Token: 0x40004A0
    public UIWidget fromTarget;

    // Token: 0x40004A1
    public UIWidget toTarget;

    // Token: 0x40004A2
    public bool updateTable;

    // Token: 0x40004A3
    private UIWidget mWidget;

    // Token: 0x40004A4
    private UITable mTable;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005F8
    // RVA   : 0xA741F0   Offset: 0xA729F0   Length: 0xAC
    public UIWidget get_cachedWidget()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mWidget;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.GetComponent(this,DAT_181d6e7c0);
          this.mWidget = uVar2;
        }
        return this.mWidget;
    }

    // Token : 0x60005F9
    // RVA   : 0xA742A0   Offset: 0xA72AA0   Length: 0x20
    public int get_width()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 164);
        }
    }

    // Token : 0x60005FA
    // RVA   : 0xA742D0   Offset: 0xA72AD0   Length: 0x2B
    public void set_width(int value)
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          UIWidget.set_width(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005FB
    // RVA   : 0xA742A0   Offset: 0xA72AA0   Length: 0x20
    public int get_value()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 164);
        }
    }

    // Token : 0x60005FC
    // RVA   : 0xA742D0   Offset: 0xA72AD0   Length: 0x2B
    public void set_value(int value)
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          UIWidget.set_width(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005FD
    // RVA   : 0xA73EF0   Offset: 0xA726F0   Length: 0x23D
    protected override void OnUpdate(float factor, bool isFinished)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        uVar4 = this.fromTarget;
        cVar1 = Object.op_Implicit(uVar4,0);
        if (cVar1) {
          if (this.fromTarget == null) goto LAB_180a74128;
          this.from = this.fromTarget.mWidth;
        }
        uVar4 = this.toTarget;
        cVar1 = Object.op_Implicit(uVar4,0);
        if (cVar1) {
          if (this.toTarget == null) goto LAB_180a74128;
          this.to = this.toTarget.mWidth;
        }
        uVar2 = Mathf.RoundToInt((1.0 - factor) * (float)this.from +
                                  (float)this.to * factor,0);
        lVar3 = TweenWidth.get_cachedWidget(this,0);
        if (lVar3 == null) {
        LAB_180a74128:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        UIWidget.set_width(lVar3,uVar2,0);
        if (this.updateTable) {
          uVar4 = this.mTable;
          cVar1 = Object.op_Equality(uVar4,0,0);
          if (cVar1) {
            uVar4 = Component.get_gameObject(this,0);
            uVar4 = NGUITools.FindInParents(uVar4,DAT_181d66d00);
            this.mTable = uVar4;
            uVar4 = this.mTable;
            cVar1 = Object.op_Equality(uVar4,0,0);
            if (cVar1) {
              this.updateTable = 0;
              return;
            }
          }
          if (this.mTable == null) goto LAB_180a74128;
          UITable.set_repositionNow(this.mTable,1,0);
        }
    }

    // Token : 0x60005FE
    // RVA   : 0xA73E20   Offset: 0xA72620   Length: 0xC3
    public static TweenWidth Begin(UIWidget widget, float duration, int width)
    {
        ulong uVar1;
        long lVar2;
        if (widget != null) {
          uVar1 = Component.get_gameObject(widget,0);
          lVar2 = UITweener.Begin(uVar1,duration,0,DAT_181d9dd90);
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

    // Token : 0x60005FF
    // RVA   : 0xA741C0   Offset: 0xA729C0   Length: 0x29
    public override void SetStartToCurrentValue()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          this.from = *(uint32 *)(lVar1 + 164);
          return;
        }
    }

    // Token : 0x6000600
    // RVA   : 0xA74190   Offset: 0xA72990   Length: 0x29
    public override void SetEndToCurrentValue()
    {
        long lVar1;
        lVar1 = TweenWidth.get_cachedWidget(this,0);
        if (lVar1 != null) {
          this.to = *(uint32 *)(lVar1 + 164);
          return;
        }
    }

    // Token : 0x6000601
    // RVA   : 0xA74160   Offset: 0xA72960   Length: 0x2C
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

    // Token : 0x6000602
    // RVA   : 0xA74130   Offset: 0xA72930   Length: 0x2C
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

    // Token : 0x6000603
    // RVA   : 0xA70640   Offset: 0xA6EE40   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180a70640(int64 this)
        {
        this.from = 100;
        this.to = 100;
        UITweener.ctor(this,0);
    }

}
