// ============================================================
// Type  : UIForwardEvents
// Token : 0x2000045
// ============================================================

public class UIForwardEvents
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400016A
    public GameObject target;

    // Token: 0x400016B
    public bool onHover;

    // Token: 0x400016C
    public bool onPress;

    // Token: 0x400016D
    public bool onClick;

    // Token: 0x400016E
    public bool onDoubleClick;

    // Token: 0x400016F
    public bool onSelect;

    // Token: 0x4000170
    public bool onDrag;

    // Token: 0x4000171
    public bool onDrop;

    // Token: 0x4000172
    public bool onSubmit;

    // Token: 0x4000173
    public bool onScroll;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000147
    // RVA   : 0x10EAF70   Offset: 0x10E9770   Length: 0xD7
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
            uVar1 = il2cpp_value_box(DAT_181d8d920,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SendMessage(lVar2,"OnHover",uVar1,1,0);
          }
        }
    }

    // Token : 0x6000148
    // RVA   : 0x10EB050   Offset: 0x10E9850   Length: 0xD7
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
            uVar1 = il2cpp_value_box(DAT_181d8d920,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SendMessage(lVar2,"OnPress",uVar1,1,0);
          }
        }
    }

    // Token : 0x6000149
    // RVA   : 0x10EAC70   Offset: 0x10E9470   Length: 0xA0
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
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x600014A
    // RVA   : 0x10EAD20   Offset: 0x10E9520   Length: 0xA0
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
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x600014B
    // RVA   : 0x10EB210   Offset: 0x10E9A10   Length: 0xD7
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
            uVar1 = il2cpp_value_box(DAT_181d8d920,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SendMessage(lVar2,"OnSelect",uVar1,1,0);
          }
        }
    }

    // Token : 0x600014C
    // RVA   : 0x10EADD0   Offset: 0x10E95D0   Length: 0xDB
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
            uVar1 = il2cpp_value_box(DAT_181d8e698,&local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SendMessage(lVar2,"OnDrag",uVar1,1,0);
          }
        }
    }

    // Token : 0x600014D
    // RVA   : 0x10EAEB0   Offset: 0x10E96B0   Length: 0xB2
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
              FUN_1800d6620();
            }
            GameObject.SendMessage(this.target,"OnDrop",go,1,0);
          }
        }
    }

    // Token : 0x600014E
    // RVA   : 0x10EB2F0   Offset: 0x10E9AF0   Length: 0xA0
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
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x600014F
    // RVA   : 0x10EB130   Offset: 0x10E9930   Length: 0xD9
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
            uVar1 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SendMessage(lVar2,"OnScroll",uVar1,1,0);
          }
        }
    }

    // Token : 0x6000150
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
