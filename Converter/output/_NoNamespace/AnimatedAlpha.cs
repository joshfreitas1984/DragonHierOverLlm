// ============================================================
// Type  : AnimatedAlpha
// Token : 0x20000B1
// ============================================================

public class AnimatedAlpha
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000433
    public float alpha;

    // Token: 0x4000434
    private UIWidget mWidget;

    // Token: 0x4000435
    private UIPanel mPanel;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000563
    // RVA   : 0x786940   Offset: 0x785740   Length: 0x155
    private void OnEnable()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = Component.GetComponent(this,DAT_181e7a438);
        this.mWidget = uVar3;
        uVar3 = Component.GetComponent(this,DAT_181e79f38);
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
            FUN_1801e0300();
          }
          (**(code **)(*plVar1 + 0x1b8))
                    (plVar1,this.alpha,*(uint64 *)(*plVar1 + 0x1c0));
        }
    }

    // Token : 0x6000564
    // RVA   : 0x786860   Offset: 0x785660   Length: 0xDB
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
            FUN_1801e0300();
          }
          (**(code **)(*plVar2 + 0x1b8))
                    (plVar2,this.alpha,*(uint64 *)(*plVar2 + 0x1c0));
        }
    }

    // Token : 0x6000565
    // RVA   : 0x786AA0   Offset: 0x7858A0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180786aa0(int64 this)
        {
        this.alpha = 0x3f800000;
        FUN_180ae8740(this,0);
    }

}
