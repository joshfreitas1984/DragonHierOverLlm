// ============================================================
// Type  : TweenHeight
// Token : 0x20000BA
// ============================================================

public class TweenHeight
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000465
    public int from;

    // Token: 0x4000466
    public int to;

    // Token: 0x4000467
    public UIWidget fromTarget;

    // Token: 0x4000468
    public UIWidget toTarget;

    // Token: 0x4000469
    public bool updateTable;

    // Token: 0x400046A
    private UIWidget mWidget;

    // Token: 0x400046B
    private UITable mTable;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005A1
    // RVA   : 0xA70660   Offset: 0xA6EE60   Length: 0xAC
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

    // Token : 0x60005A2
    // RVA   : 0xA70710   Offset: 0xA6EF10   Length: 0x20
    public int get_height()
    {
        long lVar1;
        lVar1 = TweenHeight.get_cachedWidget(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 168);
        }
    }

    // Token : 0x60005A3
    // RVA   : 0xA70740   Offset: 0xA6EF40   Length: 0x2B
    public void set_height(int value)
    {
        long lVar1;
        lVar1 = TweenHeight.get_cachedWidget(this,0);
        if (lVar1 != null) {
          UIWidget.set_height(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005A4
    // RVA   : 0xA70710   Offset: 0xA6EF10   Length: 0x20
    public int get_value()
    {
        long lVar1;
        lVar1 = TweenHeight.get_cachedWidget(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 168);
        }
    }

    // Token : 0x60005A5
    // RVA   : 0xA70740   Offset: 0xA6EF40   Length: 0x2B
    public void set_value(int value)
    {
        long lVar1;
        lVar1 = TweenHeight.get_cachedWidget(this,0);
        if (lVar1 != null) {
          UIWidget.set_height(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005A6
    // RVA   : 0xA70340   Offset: 0xA6EB40   Length: 0x23D
    protected override void OnUpdate(float factor, bool isFinished)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        uVar4 = this.fromTarget;
        cVar1 = Object.op_Implicit(uVar4,0);
        if (cVar1) {
          if (this.fromTarget == null) goto LAB_180a70578;
          this.from = this.fromTarget.mWidth;
        }
        uVar4 = this.toTarget;
        cVar1 = Object.op_Implicit(uVar4,0);
        if (cVar1) {
          if (this.toTarget == null) goto LAB_180a70578;
          this.to = this.toTarget.mWidth;
        }
        uVar2 = Mathf.RoundToInt((1.0 - factor) * (float)this.from +
                                  (float)this.to * factor,0);
        lVar3 = TweenHeight.get_cachedWidget(this,0);
        if (lVar3 == null) {
        LAB_180a70578:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        UIWidget.set_height(lVar3,uVar2,0);
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
          if (this.mTable == null) goto LAB_180a70578;
          UITable.set_repositionNow(this.mTable,1,0);
        }
    }

    // Token : 0x60005A7
    // RVA   : 0xA70270   Offset: 0xA6EA70   Length: 0xC3
    public static TweenHeight Begin(UIWidget widget, float duration, int height)
    {
        ulong uVar1;
        long lVar2;
        if (widget != null) {
          uVar1 = Component.get_gameObject(widget,0);
          lVar2 = UITweener.Begin(uVar1,duration,0,DAT_181d9d9d8);
          if (lVar2 != null) {
            *(uint32 *)(lVar2 + 120) = *(uint32 *)(widget + 168);
            *(uint32 *)(lVar2 + 124) = height;
            if (duration <= 0.0) {
              UITweener.Sample(lVar2,0x3f800000,1,0);
              Behaviour.set_enabled(lVar2,0,0);
            }
            return lVar2;
          }
        }
    }

    // Token : 0x60005A8
    // RVA   : 0xA70610   Offset: 0xA6EE10   Length: 0x29
    public override void SetStartToCurrentValue()
    {
        long lVar1;
        lVar1 = TweenHeight.get_cachedWidget(this,0);
        if (lVar1 != null) {
          this.from = *(uint32 *)(lVar1 + 168);
          return;
        }
    }

    // Token : 0x60005A9
    // RVA   : 0xA705E0   Offset: 0xA6EDE0   Length: 0x29
    public override void SetEndToCurrentValue()
    {
        long lVar1;
        lVar1 = TweenHeight.get_cachedWidget(this,0);
        if (lVar1 != null) {
          this.to = *(uint32 *)(lVar1 + 168);
          return;
        }
    }

    // Token : 0x60005AA
    // RVA   : 0xA705B0   Offset: 0xA6EDB0   Length: 0x2C
    private void SetCurrentValueToStart()
    {
        uint uVar1;
        long lVar2;
        uVar1 = this.from;
        lVar2 = TweenHeight.get_cachedWidget(this,0);
        if (lVar2 != null) {
          UIWidget.set_height(lVar2,uVar1,0);
          return;
        }
    }

    // Token : 0x60005AB
    // RVA   : 0xA70580   Offset: 0xA6ED80   Length: 0x2C
    private void SetCurrentValueToEnd()
    {
        uint uVar1;
        long lVar2;
        uVar1 = this.to;
        lVar2 = TweenHeight.get_cachedWidget(this,0);
        if (lVar2 != null) {
          UIWidget.set_height(lVar2,uVar1,0);
          return;
        }
    }

    // Token : 0x60005AC
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
