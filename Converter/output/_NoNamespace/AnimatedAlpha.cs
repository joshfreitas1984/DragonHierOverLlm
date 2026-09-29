// ============================================================
// Type  : AnimatedAlpha
// Token : 0x20000B2
// ============================================================

public class AnimatedAlpha
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000453
    public float alpha;

    // Token: 0x4000454
    private UIWidget mWidget;

    // Token: 0x4000455
    private UIPanel mPanel;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600057C
    // RVA   : 0xA1EF10   Offset: 0xA1E310   Length: 0x155
    private void OnEnable()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = Component.GetComponent(this,DAT_181d97078);
        this.mWidget = uVar3;
        uVar3 = Component.GetComponent(this,DAT_181d96b78);
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

    // Token : 0x600057D
    // RVA   : 0xA1EE30   Offset: 0xA1E230   Length: 0xDB
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

    // Token : 0x600057E
    // RVA   : 0xA1F070   Offset: 0xA1E470   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180a1f070(int64 this)
        {
        this.alpha = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
