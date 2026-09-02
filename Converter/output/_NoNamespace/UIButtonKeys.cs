// ============================================================
// Type  : UIButtonKeys
// Token : 0x2000031
// ============================================================

public class UIButtonKeys
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000DE
    public UIButtonKeys selectOnClick;

    // Token: 0x40000DF
    public UIButtonKeys selectOnUp;

    // Token: 0x40000E0
    public UIButtonKeys selectOnDown;

    // Token: 0x40000E1
    public UIButtonKeys selectOnLeft;

    // Token: 0x40000E2
    public UIButtonKeys selectOnRight;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000C0
    // RVA   : 0x13BE8C0   Offset: 0x13BD0C0   Length: 0x1F
    protected override void OnEnable()
    {
        UIButtonKeys.Upgrade(this,0);
        UIKeyNavigation.OnEnable(this,0);
    }

    // Token : 0x60000C1
    // RVA   : 0x13BE8E0   Offset: 0x13BD0E0   Length: 0x471
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
            if (this.selectOnClick == null) goto LAB_1813bed4c;
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
            if (this.selectOnLeft == null) goto LAB_1813bed4c;
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
            if (this.selectOnRight == null) goto LAB_1813bed4c;
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
            if (this.selectOnUp == null) goto LAB_1813bed4c;
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
        LAB_1813bed4c:
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

    // Token : 0x60000C2
    // RVA   : 0x13BED60   Offset: 0x13BD560   Length: 0x52
    public void /*ctor*/()
    {
        TrailRenderer_Base.ctor(this,0);
    }

}
