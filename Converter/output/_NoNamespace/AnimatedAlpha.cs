// ============================================================
// Type  : AnimatedAlpha
// Token : 0x20000B1
// ============================================================

public class AnimatedAlpha
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000437
    public float alpha;

    // Token: 0x4000438
    private UIWidget mWidget;

    // Token: 0x4000439
    private UIPanel mPanel;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000564
    // RVA   : 0xA0CFB0   Offset: 0xA0B7B0   Length: 0x155
    private void OnEnable()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = Component.GetComponent(this,DAT_181d6e7c0);
        this.mWidget = uVar3;
        uVar3 = Component.GetComponent(this,DAT_181d6e2c0);
        this.mPanel = uVar3;
        uVar3 = this.mWidget;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (cVar2) {
          plVar1 = this.mWidget;
          if (plVar1 != (int64 *)0)
          {
            (**(code **)(*plVar1 + 0x1b8))
            (plVar1,this.alpha,*(uint64 *)(*plVar1 + 0x1c0));
            }
            uVar3 = this.mPanel;
            cVar2 = Object.op_Inequality(uVar3,0,0);
            if (cVar2) {
            plVar1 = this.mPanel;
            if (plVar1 == (int64 *)0) {
          }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          (**(code **)(*plVar1 + 0x1b8))
                    (plVar1,this.alpha,*(uint64 *)(*plVar1 + 0x1c0));
        }
    }

    // Token : 0x6000565
    // RVA   : 0xA0CED0   Offset: 0xA0B6D0   Length: 0xDB
    private void LateUpdate()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = this.mWidget;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          plVar2 = this.mWidget;
          if (plVar2 != (int64 *)0)
          {
            (**(code **)(*plVar2 + 0x1b8))
            (plVar2,this.alpha,*(uint64 *)(*plVar2 + 0x1c0));
            }
            uVar1 = this.mPanel;
            cVar3 = Object.op_Inequality(uVar1,0,0);
            if (cVar3) {
            plVar2 = this.mPanel;
            if (plVar2 == (int64 *)0) {
          }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          (**(code **)(*plVar2 + 0x1b8))
                    (plVar2,this.alpha,*(uint64 *)(*plVar2 + 0x1c0));
        }
    }

    // Token : 0x6000566
    // RVA   : 0xA0D110   Offset: 0xA0B910   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180a0d110(int64 this)
        {
        this.alpha = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
