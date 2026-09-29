// ============================================================
// Type  : UIEventListener
// Token : 0x200009F
// ============================================================

public class UIEventListener
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40003EB
    public object parameter;

    // Token: 0x40003EC
    public VoidDelegate onSubmit;

    // Token: 0x40003ED
    public VoidDelegate onClick;

    // Token: 0x40003EE
    public VoidDelegate onDoubleClick;

    // Token: 0x40003EF
    public BoolDelegate onHover;

    // Token: 0x40003F0
    public BoolDelegate onPress;

    // Token: 0x40003F1
    public BoolDelegate onSelect;

    // Token: 0x40003F2
    public FloatDelegate onScroll;

    // Token: 0x40003F3
    public VoidDelegate onDragStart;

    // Token: 0x40003F4
    public VectorDelegate onDrag;

    // Token: 0x40003F5
    public VoidDelegate onDragOver;

    // Token: 0x40003F6
    public VoidDelegate onDragOut;

    // Token: 0x40003F7
    public VoidDelegate onDragEnd;

    // Token: 0x40003F8
    public ObjectDelegate onDrop;

    // Token: 0x40003F9
    public KeyCodeDelegate onKey;

    // Token: 0x40003FA
    public BoolDelegate onTooltip;

    // Token: 0x40003FB
    public bool needsActiveCollider;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60004B9
    // RVA   : 0x12BDCD0   Offset: 0x12BD0D0   Length: 0x11B
    private bool get_isColliderEnabled()
    {
        long lVar1;
        bool cVar2;
        byte uVar3;
        if (this.needsActiveCollider) {
          lVar1 = Component.GetComponent(this,DAT_181d93b78);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            lVar1 = Component.GetComponent(this,DAT_181d93bf8);
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

    // Token : 0x60004BA
    // RVA   : 0x12BDC10   Offset: 0x12BD010   Length: 0x45
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

    // Token : 0x60004BB
    // RVA   : 0x12BD7F0   Offset: 0x12BCBF0   Length: 0x45
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

    // Token : 0x60004BC
    // RVA   : 0x12BD840   Offset: 0x12BCC40   Length: 0x45
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

    // Token : 0x60004BD
    // RVA   : 0x12BDA30   Offset: 0x12BCE30   Length: 0x55
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

    // Token : 0x60004BE
    // RVA   : 0x12BDAF0   Offset: 0x12BCEF0   Length: 0x55
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

    // Token : 0x60004BF
    // RVA   : 0x12BDBB0   Offset: 0x12BCFB0   Length: 0x55
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

    // Token : 0x60004C0
    // RVA   : 0x12BDB50   Offset: 0x12BCF50   Length: 0x55
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

    // Token : 0x60004C1
    // RVA   : 0x12BD960   Offset: 0x12BCD60   Length: 0x2F
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

    // Token : 0x60004C2
    // RVA   : 0x12BD990   Offset: 0x12BCD90   Length: 0x3E
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

    // Token : 0x60004C3
    // RVA   : 0x12BD910   Offset: 0x12BCD10   Length: 0x45
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

    // Token : 0x60004C4
    // RVA   : 0x12BD8C0   Offset: 0x12BCCC0   Length: 0x45
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

    // Token : 0x60004C5
    // RVA   : 0x12BD890   Offset: 0x12BCC90   Length: 0x2F
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

    // Token : 0x60004C6
    // RVA   : 0x12BD9D0   Offset: 0x12BCDD0   Length: 0x57
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

    // Token : 0x60004C7
    // RVA   : 0x12BDA90   Offset: 0x12BCE90   Length: 0x56
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

    // Token : 0x60004C8
    // RVA   : 0x12BDC60   Offset: 0x12BD060   Length: 0x58
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

    // Token : 0x60004C9
    // RVA   : 0x12BD640   Offset: 0x12BCA40   Length: 0xF4
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

    // Token : 0x60004CA
    // RVA   : 0x12BD740   Offset: 0x12BCB40   Length: 0xAD
    public static UIEventListener Get(GameObject go)
    {
        bool cVar1;
        ulong uVar2;
        if (go != null) {
          uVar2 = GameObject.GetComponent(go,DAT_181d747f0);
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (cVar1) {
            uVar2 = GameObject.AddComponent(go,DAT_181dc6a90);
          }
          return uVar2;
        }
    }

    // Token : 0x60004CB
    // RVA   : 0x12BDCC0   Offset: 0x12BD0C0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1812bdcc0(int64 this)
        {
        this.needsActiveCollider = 1;
        FUN_18044ef50(this,0);
    }

}
