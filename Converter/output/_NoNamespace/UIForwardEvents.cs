// ============================================================
// Type  : UIForwardEvents
// Token : 0x2000045
// ============================================================

public class UIForwardEvents
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000166
    public GameObject target;

    // Token: 0x4000167
    public bool onHover;

    // Token: 0x4000168
    public bool onPress;

    // Token: 0x4000169
    public bool onClick;

    // Token: 0x400016A
    public bool onDoubleClick;

    // Token: 0x400016B
    public bool onSelect;

    // Token: 0x400016C
    public bool onDrag;

    // Token: 0x400016D
    public bool onDrop;

    // Token: 0x400016E
    public bool onSubmit;

    // Token: 0x400016F
    public bool onScroll;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000146
    // RVA   : 0x1148D60   Offset: 0x1147B60   Length: 0xD7
    private void OnHover(bool isOver)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        byte[] local_res8 = new byte[8];
        if (this.onHover) {
          uVar1 = this.target;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            lVar2 = this.target;
            local_res8[0] = isOver;
            uVar1 = il2cpp_value_box(DAT_181e92da8,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            GameObject.SendMessage(lVar2,"OnHover",uVar1,1,0);
          }
        }
    }

    // Token : 0x6000147
    // RVA   : 0x1148E40   Offset: 0x1147C40   Length: 0xD7
    private void OnPress(bool pressed)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        byte[] local_res8 = new byte[8];
        if (this.onPress) {
          uVar1 = this.target;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            lVar2 = this.target;
            local_res8[0] = pressed;
            uVar1 = il2cpp_value_box(DAT_181e92da8,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            GameObject.SendMessage(lVar2,"OnPress",uVar1,1,0);
          }
        }
    }

    // Token : 0x6000148
    // RVA   : 0x1148A60   Offset: 0x1147860   Length: 0xA0
    private void OnClick()
    {
        ulong uVar1;
        bool cVar2;
        if (this.onClick) {
          uVar1 = this.target;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.target != null) {
              GameObject.SendMessage(this.target,"OnClick",1);
              return;
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x6000149
    // RVA   : 0x1148B10   Offset: 0x1147910   Length: 0xA0
    private void OnDoubleClick()
    {
        ulong uVar1;
        bool cVar2;
        if (this.onDoubleClick) {
          uVar1 = this.target;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.target != null) {
              GameObject.SendMessage(this.target,"OnDoubleClick",1);
              return;
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x600014A
    // RVA   : 0x1149000   Offset: 0x1147E00   Length: 0xD7
    private void OnSelect(bool selected)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        byte[] local_res8 = new byte[8];
        if (this.onSelect) {
          uVar1 = this.target;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            lVar2 = this.target;
            local_res8[0] = selected;
            uVar1 = il2cpp_value_box(DAT_181e92da8,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            GameObject.SendMessage(lVar2,"OnSelect",uVar1,1,0);
          }
        }
    }

    // Token : 0x600014B
    // RVA   : 0x1148BC0   Offset: 0x11479C0   Length: 0xDB
    private void OnDrag(Vector2 delta)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ulong local_res8;
        if (this.onDrag) {
          uVar1 = this.target;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            lVar2 = this.target;
            local_res8 = delta;
            uVar1 = il2cpp_value_box(DAT_181e93e40,&local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            GameObject.SendMessage(lVar2,"OnDrag",uVar1,1,0);
          }
        }
    }

    // Token : 0x600014C
    // RVA   : 0x1148CA0   Offset: 0x1147AA0   Length: 0xB2
    private void OnDrop(GameObject go)
    {
        ulong uVar1;
        bool cVar2;
        if (this.onDrop) {
          uVar1 = this.target;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.target == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            GameObject.SendMessage(this.target,"OnDrop",go,1,0);
          }
        }
    }

    // Token : 0x600014D
    // RVA   : 0x11490E0   Offset: 0x1147EE0   Length: 0xA0
    private void OnSubmit()
    {
        ulong uVar1;
        bool cVar2;
        if (this.onSubmit) {
          uVar1 = this.target;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.target != null) {
              GameObject.SendMessage(this.target,"OnSubmit",1);
              return;
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x600014E
    // RVA   : 0x1148F20   Offset: 0x1147D20   Length: 0xD9
    private void OnScroll(float delta)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uint[] local_res8 = new uint[2];
        if (this.onScroll) {
          uVar1 = this.target;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            lVar2 = this.target;
            local_res8[0] = delta;
            uVar1 = il2cpp_value_box(DAT_181e82730,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            GameObject.SendMessage(lVar2,"OnScroll",uVar1,1,0);
          }
        }
    }

    // Token : 0x600014F
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
