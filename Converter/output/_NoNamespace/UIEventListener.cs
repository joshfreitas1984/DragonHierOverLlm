// ============================================================
// Type  : UIEventListener
// Token : 0x200009E
// ============================================================

public class UIEventListener
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40003CF
    public object parameter;

    // Token: 0x40003D0
    public VoidDelegate onSubmit;

    // Token: 0x40003D1
    public VoidDelegate onClick;

    // Token: 0x40003D2
    public VoidDelegate onDoubleClick;

    // Token: 0x40003D3
    public BoolDelegate onHover;

    // Token: 0x40003D4
    public BoolDelegate onPress;

    // Token: 0x40003D5
    public BoolDelegate onSelect;

    // Token: 0x40003D6
    public FloatDelegate onScroll;

    // Token: 0x40003D7
    public VoidDelegate onDragStart;

    // Token: 0x40003D8
    public VectorDelegate onDrag;

    // Token: 0x40003D9
    public VoidDelegate onDragOver;

    // Token: 0x40003DA
    public VoidDelegate onDragOut;

    // Token: 0x40003DB
    public VoidDelegate onDragEnd;

    // Token: 0x40003DC
    public ObjectDelegate onDrop;

    // Token: 0x40003DD
    public KeyCodeDelegate onKey;

    // Token: 0x40003DE
    public BoolDelegate onTooltip;

    // Token: 0x40003DF
    public bool needsActiveCollider;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60004A1
    // RVA   : 0x10E6D60   Offset: 0x10E5560   Length: 0x11B
    private bool get_isColliderEnabled()
    {
        long lVar1;
        bool cVar2;
        byte uVar3;
        if (this.needsActiveCollider) {
          lVar1 = Component.GetComponent(this,DAT_181d6b340);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            lVar1 = Component.GetComponent(this,DAT_181d6b3c0);
            cVar2 = Object.op_Inequality(lVar1,0,0);
            if (!cVar2) {
              return false;
            }
            if (lVar1 != null) {
              uVar3 = Behaviour.get_enabled(lVar1,0);
              return uVar3;
            }
          }
          else if (lVar1 != null) {
            uVar3 = Collider.get_enabled(lVar1,0);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return true;
    }

    // Token : 0x60004A2
    // RVA   : 0x10E6CA0   Offset: 0x10E54A0   Length: 0x45
    private void OnSubmit()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onSubmit) != null) {
          uVar2 = Component.get_gameObject(this,0);
          VoidDelegate.Invoke(lVar1,uVar2,0);
        }
    }

    // Token : 0x60004A3
    // RVA   : 0x10E6880   Offset: 0x10E5080   Length: 0x45
    private void OnClick()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onClick) != null) {
          uVar2 = Component.get_gameObject(this,0);
          VoidDelegate.Invoke(lVar1,uVar2,0);
        }
    }

    // Token : 0x60004A4
    // RVA   : 0x10E68D0   Offset: 0x10E50D0   Length: 0x45
    private void OnDoubleClick()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onDoubleClick) != null) {
          uVar2 = Component.get_gameObject(this,0);
          VoidDelegate.Invoke(lVar1,uVar2,0);
        }
    }

    // Token : 0x60004A5
    // RVA   : 0x10E6AC0   Offset: 0x10E52C0   Length: 0x55
    private void OnHover(bool isOver)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onHover) != null) {
          uVar2 = Component.get_gameObject(this,0);
          OnTooltipCB.Invoke(lVar1,uVar2,isOver,0);
        }
    }

    // Token : 0x60004A6
    // RVA   : 0x10E6B80   Offset: 0x10E5380   Length: 0x55
    private void OnPress(bool isPressed)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onPress) != null) {
          uVar2 = Component.get_gameObject(this,0);
          OnTooltipCB.Invoke(lVar1,uVar2,isPressed,0);
        }
    }

    // Token : 0x60004A7
    // RVA   : 0x10E6C40   Offset: 0x10E5440   Length: 0x55
    private void OnSelect(bool selected)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onSelect) != null) {
          uVar2 = Component.get_gameObject(this,0);
          OnTooltipCB.Invoke(lVar1,uVar2,selected,0);
        }
    }

    // Token : 0x60004A8
    // RVA   : 0x10E6BE0   Offset: 0x10E53E0   Length: 0x55
    private void OnScroll(float delta)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onScroll) != null) {
          uVar2 = Component.get_gameObject(this,0);
          FloatDelegate.Invoke(lVar1,uVar2,delta,0);
        }
    }

    // Token : 0x60004A9
    // RVA   : 0x10E69F0   Offset: 0x10E51F0   Length: 0x2F
    private void OnDragStart()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.onDragStart;
        if (lVar1 != null) {
          uVar2 = Component.get_gameObject(this,0);
          VoidDelegate.Invoke(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x60004AA
    // RVA   : 0x10E6A20   Offset: 0x10E5220   Length: 0x3E
    private void OnDrag(Vector2 delta)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.onDrag;
        if (lVar1 != null) {
          uVar2 = Component.get_gameObject(this,0);
          VectorDelegate.Invoke(lVar1,uVar2,delta,0);
        }
    }

    // Token : 0x60004AB
    // RVA   : 0x10E69A0   Offset: 0x10E51A0   Length: 0x45
    private void OnDragOver()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onDragOver) != null) {
          uVar2 = Component.get_gameObject(this,0);
          VoidDelegate.Invoke(lVar1,uVar2,0);
        }
    }

    // Token : 0x60004AC
    // RVA   : 0x10E6950   Offset: 0x10E5150   Length: 0x45
    private void OnDragOut()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onDragOut) != null) {
          uVar2 = Component.get_gameObject(this,0);
          VoidDelegate.Invoke(lVar1,uVar2,0);
        }
    }

    // Token : 0x60004AD
    // RVA   : 0x10E6920   Offset: 0x10E5120   Length: 0x2F
    private void OnDragEnd()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.onDragEnd;
        if (lVar1 != null) {
          uVar2 = Component.get_gameObject(this,0);
          VoidDelegate.Invoke(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x60004AE
    // RVA   : 0x10E6A60   Offset: 0x10E5260   Length: 0x57
    private void OnDrop(GameObject go)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onDrop) != null) {
          uVar2 = Component.get_gameObject(this,0);
          ObjectDelegate.Invoke(lVar1,uVar2,go,0);
        }
    }

    // Token : 0x60004AF
    // RVA   : 0x10E6B20   Offset: 0x10E5320   Length: 0x56
    private void OnKey(KeyCode key)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onKey) != null) {
          uVar2 = Component.get_gameObject(this,0);
          KeyCodeDelegate.Invoke(lVar1,uVar2,key,0);
        }
    }

    // Token : 0x60004B0
    // RVA   : 0x10E6CF0   Offset: 0x10E54F0   Length: 0x58
    private void OnTooltip(bool show)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = UIEventListener.get_isColliderEnabled(this,0);
        if ((cVar3) && (lVar1 = this.onTooltip) != null) {
          uVar2 = Component.get_gameObject(this,0);
          OnTooltipCB.Invoke(lVar1,uVar2,show,0);
        }
    }

    // Token : 0x60004B1
    // RVA   : 0x10E66D0   Offset: 0x10E4ED0   Length: 0xF4
    public void Clear()
    {
        this.onSubmit = 0;
        this.onClick = 0;
        this.onDoubleClick = 0;
        this.onHover = 0;
        this.onPress = 0;
        this.onSelect = 0;
        this.onScroll = 0;
        this.onDragStart = 0;
        this.onDrag = 0;
        this.onDragOver = 0;
        this.onDragOut = 0;
        this.onDragEnd = 0;
        this.onDrop = 0;
        this.onKey = 0;
        this.onTooltip = 0;
    }

    // Token : 0x60004B2
    // RVA   : 0x10E67D0   Offset: 0x10E4FD0   Length: 0xAD
    public static UIEventListener Get(GameObject go)
    {
        bool cVar1;
        ulong uVar2;
        if (go != null) {
          uVar2 = GameObject.GetComponent(go,DAT_181da2530);
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (cVar1) {
            uVar2 = GameObject.AddComponent(go,DAT_181d9dcd8);
          }
          return uVar2;
        }
    }

    // Token : 0x60004B3
    // RVA   : 0x10E6D50   Offset: 0x10E5550   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1810e6d50(int64 this)
        {
        this.needsActiveCollider = 1;
        FUN_18044ef50(this,0);
    }

}
