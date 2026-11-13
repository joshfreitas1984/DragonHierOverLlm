// ============================================================
// Type  : UIEventListener
// Token : 0x200009E
// ============================================================

public class UIEventListener
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40003CB
    public object parameter;

    // Token: 0x40003CC
    public VoidDelegate onSubmit;

    // Token: 0x40003CD
    public VoidDelegate onClick;

    // Token: 0x40003CE
    public VoidDelegate onDoubleClick;

    // Token: 0x40003CF
    public BoolDelegate onHover;

    // Token: 0x40003D0
    public BoolDelegate onPress;

    // Token: 0x40003D1
    public BoolDelegate onSelect;

    // Token: 0x40003D2
    public FloatDelegate onScroll;

    // Token: 0x40003D3
    public VoidDelegate onDragStart;

    // Token: 0x40003D4
    public VectorDelegate onDrag;

    // Token: 0x40003D5
    public VoidDelegate onDragOver;

    // Token: 0x40003D6
    public VoidDelegate onDragOut;

    // Token: 0x40003D7
    public VoidDelegate onDragEnd;

    // Token: 0x40003D8
    public ObjectDelegate onDrop;

    // Token: 0x40003D9
    public KeyCodeDelegate onKey;

    // Token: 0x40003DA
    public BoolDelegate onTooltip;

    // Token: 0x40003DB
    public bool needsActiveCollider;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60004A0
    // RVA   : 0x1144A70   Offset: 0x1143870   Length: 0x11B
    private bool get_isColliderEnabled()
    {
        long lVar1;
        bool cVar2;
        byte uVar3;
        if (this.needsActiveCollider) {
          lVar1 = Component.GetComponent(this,DAT_181e76eb8);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            lVar1 = Component.GetComponent(this,DAT_181e76f38);
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
          FUN_1801e0300();
        }
        return true;
    }

    // Token : 0x60004A1
    // RVA   : 0x11449B0   Offset: 0x11437B0   Length: 0x45
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

    // Token : 0x60004A2
    // RVA   : 0x1144590   Offset: 0x1143390   Length: 0x45
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

    // Token : 0x60004A3
    // RVA   : 0x11445E0   Offset: 0x11433E0   Length: 0x45
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

    // Token : 0x60004A4
    // RVA   : 0x11447D0   Offset: 0x11435D0   Length: 0x55
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

    // Token : 0x60004A5
    // RVA   : 0x1144890   Offset: 0x1143690   Length: 0x55
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

    // Token : 0x60004A6
    // RVA   : 0x1144950   Offset: 0x1143750   Length: 0x55
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

    // Token : 0x60004A7
    // RVA   : 0x11448F0   Offset: 0x11436F0   Length: 0x55
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

    // Token : 0x60004A8
    // RVA   : 0x1144700   Offset: 0x1143500   Length: 0x2F
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

    // Token : 0x60004A9
    // RVA   : 0x1144730   Offset: 0x1143530   Length: 0x3E
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

    // Token : 0x60004AA
    // RVA   : 0x11446B0   Offset: 0x11434B0   Length: 0x45
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

    // Token : 0x60004AB
    // RVA   : 0x1144660   Offset: 0x1143460   Length: 0x45
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

    // Token : 0x60004AC
    // RVA   : 0x1144630   Offset: 0x1143430   Length: 0x2F
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

    // Token : 0x60004AD
    // RVA   : 0x1144770   Offset: 0x1143570   Length: 0x57
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

    // Token : 0x60004AE
    // RVA   : 0x1144830   Offset: 0x1143630   Length: 0x56
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

    // Token : 0x60004AF
    // RVA   : 0x1144A00   Offset: 0x1143800   Length: 0x58
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

    // Token : 0x60004B0
    // RVA   : 0x11443E0   Offset: 0x11431E0   Length: 0xF4
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

    // Token : 0x60004B1
    // RVA   : 0x11444E0   Offset: 0x11432E0   Length: 0xAD
    public static UIEventListener Get(GameObject go)
    {
        bool cVar1;
        ulong uVar2;
        if (go != null) {
          uVar2 = GameObject.GetComponent(go,DAT_181e578b8);
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (cVar1) {
            uVar2 = GameObject.AddComponent(go,DAT_181e52b28);
          }
          return uVar2;
        }
    }

    // Token : 0x60004B2
    // RVA   : 0x1144A60   Offset: 0x1143860   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_181144a60(int64 this)
        {
        this.needsActiveCollider = 1;
        FUN_180ae8740(this,0);
    }

}
