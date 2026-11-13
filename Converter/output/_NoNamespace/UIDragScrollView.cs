// ============================================================
// Type  : UIDragScrollView
// Token : 0x2000042
// ============================================================

public class UIDragScrollView
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000143
    public UIScrollView scrollView;

    // Token: 0x4000144
    private UIScrollView draggablePanel;

    // Token: 0x4000145
    private Transform mTrans;

    // Token: 0x4000146
    private UIScrollView mScroll;

    // Token: 0x4000147
    private bool mAutoFind;

    // Token: 0x4000148
    private bool mStarted;

    // Token: 0x4000149
    private bool mPressed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000127
    // RVA   : 0x113E6D0   Offset: 0x113D4D0   Length: 0x134
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

    // Token : 0x6000128
    // RVA   : 0x113EB70   Offset: 0x113D970   Length: 0xB
    private void Start()
    {
        void FUN_18113eb70(int64 this)
        {
        this.mStarted = 1;
        UIDragScrollView.FindScrollView(this,0);
    }

    // Token : 0x6000129
    // RVA   : 0x113E3B0   Offset: 0x113D1B0   Length: 0x159
    private void FindScrollView()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        uVar1 = this.mTrans;
        uVar2 = NGUITools.FindInParents(uVar1,DAT_181e72e78);
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
              if (!cVar3) goto LAB_18113e4e5;
              }
              else {
            }
          this.scrollView = uVar2;
        }
        this.mAutoFind = 1;
        LAB_18113e4e5:
        this.mScroll = this.scrollView;
    }

    // Token : 0x600012A
    // RVA   : 0x113E510   Offset: 0x113D310   Length: 0xF0
    private void OnDisable()
    {
        ulong uVar1;
        bool cVar2;
        if (this.mPressed) {
          uVar1 = this.mScroll;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.mScroll == null) {
        LAB_18113e5fb:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar1 = Component.GetComponentInChildren(this.mScroll,DAT_181e7ac38);
            cVar2 = Object.op_Equality(uVar1,0,0);
            if (cVar2) {
              if (this.mScroll == null) goto LAB_18113e5fb;
              UIScrollView.Press(this.mScroll,0,0);
              this.mScroll = 0;
            }
          }
        }
    }

    // Token : 0x600012B
    // RVA   : 0x113E8E0   Offset: 0x113D6E0   Length: 0x1B9
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
                FUN_1801e0300();
              }
              UIScrollView.Press(this.scrollView,pressed,0);
              if ((!pressed) && (this.mAutoFind)) {
                uVar3 = this.mTrans;
                uVar3 = NGUITools.FindInParents(uVar3,DAT_181e72e78);
                this.scrollView = uVar3;
                this.mScroll = this.scrollView;
              }
            }
          }
        }
    }

    // Token : 0x600012C
    // RVA   : 0x113E610   Offset: 0x113D410   Length: 0xB1
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
              FUN_1801e0300();
            }
            UIScrollView.Drag(this.scrollView,0);
          }
        }
    }

    // Token : 0x600012D
    // RVA   : 0x113EAA0   Offset: 0x113D8A0   Length: 0xC2
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
              FUN_1801e0300();
            }
            UIScrollView.Scroll(this.scrollView,delta,0);
          }
        }
    }

    // Token : 0x600012E
    // RVA   : 0x113E810   Offset: 0x113D610   Length: 0xC6
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
              FUN_1801e0300();
            }
            UIScrollView.OnPan(this.scrollView,delta,0);
          }
        }
    }

    // Token : 0x600012F
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
