// ============================================================
// Type  : AnimatedWidget
// Token : 0x20000B3
// ============================================================

public class AnimatedWidget
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000438
    public float width;

    // Token: 0x4000439
    public float height;

    // Token: 0x400043A
    private UIWidget mWidget;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000569
    // RVA   : 0x786C60   Offset: 0x785A60   Length: 0xF5
    private void OnEnable()
    {
        long lVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        uVar4 = Component.GetComponent(this,DAT_181e7a438);
        this.mWidget = uVar4;
        uVar4 = this.mWidget;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          return;
        }
        lVar1 = this.mWidget;
        uVar3 = Mathf.RoundToInt(this.width,0);
        if (lVar1 != null) {
          UIWidget.set_width(lVar1,uVar3,0);
          lVar1 = this.mWidget;
          uVar3 = Mathf.RoundToInt(this.height,0);
          if (lVar1 != null) {
            UIWidget.set_height(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x600056A
    // RVA   : 0x786BA0   Offset: 0x7859A0   Length: 0xB0
    private void LateUpdate()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        uVar1 = this.mWidget;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (!cVar3) {
          return;
        }
        lVar2 = this.mWidget;
        uVar4 = Mathf.RoundToInt(this.width,0);
        if (lVar2 != null) {
          UIWidget.set_width(lVar2,uVar4,0);
          lVar2 = this.mWidget;
          uVar4 = Mathf.RoundToInt(this.height,0);
          if (lVar2 != null) {
            UIWidget.set_height(lVar2,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x600056B
    // RVA   : 0x786D60   Offset: 0x785B60   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180786d60(int64 this)
        {
        this.width = 0x3f800000;
        this.height = 0x3f800000;
        FUN_180ae8740(this,0);
    }

}
