// ============================================================
// Type  : UIDragScrollView
// Token : 0x2000043
// ============================================================

public class UIDragScrollView
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000163
    public UIScrollView scrollView;

    // Token: 0x4000164
    private UIScrollView draggablePanel;

    // Token: 0x4000165
    private Transform mTrans;

    // Token: 0x4000166
    private UIScrollView mScroll;

    // Token: 0x4000167
    private bool mAutoFind;

    // Token: 0x4000168
    private bool mStarted;

    // Token: 0x4000169
    private bool mPressed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000140
    // RVA   : 0x12B7330   Offset: 0x12B6730   Length: 0x134
    private void OnEnable()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = Component.get_transform(this,0);
        this.mTrans = uVar2;
        uVar2 = this.scrollView;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.draggablePanel;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            this.scrollView = this.draggablePanel;
            this.draggablePanel = 0;
          }
        }
        if (this.mStarted) {
          if (!this.mAutoFind) {
            uVar2 = this.mScroll;
            cVar1 = Object.op_Equality(uVar2,0,0);
            if (!cVar1) {
              return;
            }
          }
          UIDragScrollView.FindScrollView(this,0);
        }
    }

    // Token : 0x6000141
    // RVA   : 0x12B77D0   Offset: 0x12B6BD0   Length: 0xB
    private void Start()
    {
        void FUN_1812b77d0(int64 this)
        {
        this.mStarted = 1;
        UIDragScrollView.FindScrollView(this,0);
    }

    // Token : 0x6000142
    // RVA   : 0x12B7010   Offset: 0x12B6410   Length: 0x159
    private void FindScrollView()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        uVar1 = this.mTrans;
        uVar2 = NGUITools.FindInParents(uVar1,DAT_181d8f9a0);
        uVar1 = this.scrollView;
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (!cVar3) {
          if (this.mAutoFind) {
            uVar1 = this.scrollView;
            cVar3 = Object.op_Inequality(uVar2,uVar1,0);
            if (!(cVar3))
            {
              }
              uVar1 = this.scrollView;
              cVar3 = Object.op_Equality(uVar1,uVar2,0);
              if (!cVar3) goto LAB_1812b7145;
              }
              else {
            }
          this.scrollView = uVar2;
        }
        this.mAutoFind = 1;
        LAB_1812b7145:
        this.mScroll = this.scrollView;
    }

    // Token : 0x6000143
    // RVA   : 0x12B7170   Offset: 0x12B6570   Length: 0xF0
    private void OnDisable()
    {
        ulong uVar1;
        bool cVar2;
        if (this.mPressed) {
          uVar1 = this.mScroll;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.mScroll == null) {
        LAB_1812b725b:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar1 = Component.GetComponentInChildren(this.mScroll,DAT_181d97860);
            cVar2 = Object.op_Equality(uVar1,0,0);
            if (cVar2) {
              if (this.mScroll == null) goto LAB_1812b725b;
              UIScrollView.Press(this.mScroll,0,0);
              this.mScroll = 0;
            }
          }
        }
    }

    // Token : 0x6000144
    // RVA   : 0x12B7540   Offset: 0x12B6940   Length: 0x1B9
    private void OnPress(bool pressed)
    {
        ulong uVar1;
        bool cVar2;
        ulong uVar3;
        this.mPressed = pressed;
        if (this.mAutoFind) {
          uVar3 = this.mScroll;
          uVar1 = this.scrollView;
          cVar2 = Object.op_Inequality(uVar3,uVar1,0);
          if (cVar2) {
            this.mScroll = this.scrollView;
            this.mAutoFind = 0;
          }
        }
        uVar3 = this.scrollView;
        cVar2 = Object.op_Implicit(uVar3,0);
        if (cVar2) {
          cVar2 = Behaviour.get_enabled(this,0);
          if (cVar2) {
            uVar3 = Component.get_gameObject(this,0);
            cVar2 = NGUITools.GetActive(uVar3,0);
            if (cVar2) {
              if (this.scrollView == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              UIScrollView.Press(this.scrollView,pressed,0);
              if ((!pressed) && (this.mAutoFind)) {
                uVar3 = this.mTrans;
                uVar3 = NGUITools.FindInParents(uVar3,DAT_181d8f9a0);
                this.scrollView = uVar3;
                this.mScroll = this.scrollView;
              }
            }
          }
        }
    }

    // Token : 0x6000145
    // RVA   : 0x12B7270   Offset: 0x12B6670   Length: 0xB1
    private void OnDrag(Vector2 delta)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.scrollView;
        cVar2 = Object.op_Implicit(uVar1,0);
        if (cVar2) {
          cVar2 = NGUITools.GetActive(this,0);
          if (cVar2) {
            if (this.scrollView == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            UIScrollView.Drag(this.scrollView,0);
          }
        }
    }

    // Token : 0x6000146
    // RVA   : 0x12B7700   Offset: 0x12B6B00   Length: 0xC2
    private void OnScroll(float delta)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.scrollView;
        cVar2 = Object.op_Implicit(uVar1,0);
        if (cVar2) {
          cVar2 = NGUITools.GetActive(this,0);
          if (cVar2) {
            if (this.scrollView == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            UIScrollView.Scroll(this.scrollView,delta,0);
          }
        }
    }

    // Token : 0x6000147
    // RVA   : 0x12B7470   Offset: 0x12B6870   Length: 0xC6
    public void OnPan(Vector2 delta)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.scrollView;
        cVar2 = Object.op_Implicit(uVar1,0);
        if (cVar2) {
          cVar2 = NGUITools.GetActive(this,0);
          if (cVar2) {
            if (this.scrollView == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            UIScrollView.OnPan(this.scrollView,delta,0);
          }
        }
    }

    // Token : 0x6000148
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
