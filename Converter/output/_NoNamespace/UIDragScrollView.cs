// ============================================================
// Type  : UIDragScrollView
// Token : 0x2000042
// ============================================================

public class UIDragScrollView
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000147
    public UIScrollView scrollView;

    // Token: 0x4000148
    private UIScrollView draggablePanel;

    // Token: 0x4000149
    private Transform mTrans;

    // Token: 0x400014A
    private UIScrollView mScroll;

    // Token: 0x400014B
    private bool mAutoFind;

    // Token: 0x400014C
    private bool mStarted;

    // Token: 0x400014D
    private bool mPressed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000128
    // RVA   : 0x10E0990   Offset: 0x10DF190   Length: 0x134
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

    // Token : 0x6000129
    // RVA   : 0x10E0E30   Offset: 0x10DF630   Length: 0xB
    private void Start()
    {
        void FUN_1810e0e30(int64 this)
        {
        this.mStarted = 1;
        UIDragScrollView.FindScrollView(this,0);
    }

    // Token : 0x600012A
    // RVA   : 0x10E0670   Offset: 0x10DEE70   Length: 0x159
    private void FindScrollView()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        uVar1 = this.mTrans;
        uVar2 = NGUITools.FindInParents(uVar1,DAT_181d66c80);
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
              if (!cVar3) goto LAB_1810e07a5;
              }
              else {
            }
          this.scrollView = uVar2;
        }
        this.mAutoFind = 1;
        LAB_1810e07a5:
        this.mScroll = this.scrollView;
    }

    // Token : 0x600012B
    // RVA   : 0x10E07D0   Offset: 0x10DEFD0   Length: 0xF0
    private void OnDisable()
    {
        ulong uVar1;
        bool cVar2;
        if (this.mPressed) {
          uVar1 = this.mScroll;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.mScroll == null) {
        LAB_1810e08bb:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar1 = Component.GetComponentInChildren(this.mScroll,DAT_181d6efc0);
            cVar2 = Object.op_Equality(uVar1,0,0);
            if (cVar2) {
              if (this.mScroll == null) goto LAB_1810e08bb;
              UIScrollView.Press(this.mScroll,0,0);
              this.mScroll = 0;
            }
          }
        }
    }

    // Token : 0x600012C
    // RVA   : 0x10E0BA0   Offset: 0x10DF3A0   Length: 0x1B9
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
                uVar3 = NGUITools.FindInParents(uVar3,DAT_181d66c80);
                this.scrollView = uVar3;
                this.mScroll = this.scrollView;
              }
            }
          }
        }
    }

    // Token : 0x600012D
    // RVA   : 0x10E08D0   Offset: 0x10DF0D0   Length: 0xB1
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

    // Token : 0x600012E
    // RVA   : 0x10E0D60   Offset: 0x10DF560   Length: 0xC2
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

    // Token : 0x600012F
    // RVA   : 0x10E0AD0   Offset: 0x10DF2D0   Length: 0xC6
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

    // Token : 0x6000130
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
