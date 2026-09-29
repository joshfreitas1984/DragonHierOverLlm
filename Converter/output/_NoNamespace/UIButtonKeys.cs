// ============================================================
// Type  : UIButtonKeys
// Token : 0x2000032
// ============================================================

public class UIButtonKeys
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000FA
    public UIButtonKeys selectOnClick;

    // Token: 0x40000FB
    public UIButtonKeys selectOnUp;

    // Token: 0x40000FC
    public UIButtonKeys selectOnDown;

    // Token: 0x40000FD
    public UIButtonKeys selectOnLeft;

    // Token: 0x40000FE
    public UIButtonKeys selectOnRight;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000D8
    // RVA   : 0x15308E0   Offset: 0x152FCE0   Length: 0x1F
    protected override void OnEnable()
    {
        UIButtonKeys.Upgrade(this,0);
        UIKeyNavigation.OnEnable(this,0);
    }

    // Token : 0x60000D9
    // RVA   : 0x1530900   Offset: 0x152FD00   Length: 0x471
    public void Upgrade()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = *(uint64 *)(this + 64);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.selectOnClick;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.selectOnClick == null) goto LAB_181530d6c;
            uVar2 = Component.get_gameObject(this.selectOnClick,0);
            *(uint64 *)(this + 64) = uVar2;
            this.selectOnClick = 0;
            ZhSegment.Initialize(this,"last change",0);
          }
        }
        uVar2 = *(uint64 *)(this + 48);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.selectOnLeft;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.selectOnLeft == null) goto LAB_181530d6c;
            uVar2 = Component.get_gameObject(this.selectOnLeft,0);
            *(uint64 *)(this + 48) = uVar2;
            this.selectOnLeft = 0;
            ZhSegment.Initialize(this,"last change",0);
          }
        }
        uVar2 = *(uint64 *)(this + 56);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.selectOnRight;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.selectOnRight == null) goto LAB_181530d6c;
            uVar2 = Component.get_gameObject(this.selectOnRight,0);
            *(uint64 *)(this + 56) = uVar2;
            this.selectOnRight = 0;
            ZhSegment.Initialize(this,"last change",0);
          }
        }
        uVar2 = *(uint64 *)(this + 32);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.selectOnUp;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.selectOnUp == null) goto LAB_181530d6c;
            uVar2 = Component.get_gameObject(this.selectOnUp,0);
            *(uint64 *)(this + 32) = uVar2;
            this.selectOnUp = 0;
            ZhSegment.Initialize(this,"last change",0);
          }
        }
        uVar2 = *(uint64 *)(this + 40);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.selectOnDown;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.selectOnDown == null) {
        LAB_181530d6c:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar2 = Component.get_gameObject(this.selectOnDown,0);
            *(uint64 *)(this + 40) = uVar2;
            this.selectOnDown = 0;
            ZhSegment.Initialize(this,"last change",0);
          }
        }
    }

    // Token : 0x60000DA
    // RVA   : 0x1530D80   Offset: 0x1530180   Length: 0x52
    public void /*ctor*/()
    {
        TrailRenderer_Base.ctor(this,0);
    }

}
