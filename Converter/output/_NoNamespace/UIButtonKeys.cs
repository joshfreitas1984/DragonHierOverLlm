// ============================================================
// Type  : UIButtonKeys
// Token : 0x2000031
// ============================================================

public class UIButtonKeys
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000DA
    public UIButtonKeys selectOnClick;

    // Token: 0x40000DB
    public UIButtonKeys selectOnUp;

    // Token: 0x40000DC
    public UIButtonKeys selectOnDown;

    // Token: 0x40000DD
    public UIButtonKeys selectOnLeft;

    // Token: 0x40000DE
    public UIButtonKeys selectOnRight;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000BF
    // RVA   : 0x141C9A0   Offset: 0x141B7A0   Length: 0x1F
    protected override void OnEnable()
    {
        UIButtonKeys.Upgrade(this,0);
        UIKeyNavigation.OnEnable(this,0);
    }

    // Token : 0x60000C0
    // RVA   : 0x141C9C0   Offset: 0x141B7C0   Length: 0x471
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
            if (this.selectOnClick == null) goto LAB_18141ce2c;
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
            if (this.selectOnLeft == null) goto LAB_18141ce2c;
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
            if (this.selectOnRight == null) goto LAB_18141ce2c;
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
            if (this.selectOnUp == null) goto LAB_18141ce2c;
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
        LAB_18141ce2c:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar2 = Component.get_gameObject(this.selectOnDown,0);
            *(uint64 *)(this + 40) = uVar2;
            this.selectOnDown = 0;
            ZhSegment.Initialize(this,"last change",0);
          }
        }
    }

    // Token : 0x60000C1
    // RVA   : 0x141CE40   Offset: 0x141BC40   Length: 0x52
    public void /*ctor*/()
    {
        TrailRenderer_Base.ctor(this,0);
    }

}
