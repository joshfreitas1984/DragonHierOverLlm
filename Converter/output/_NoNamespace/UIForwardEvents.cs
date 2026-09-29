// ============================================================
// Type  : UIForwardEvents
// Token : 0x2000046
// ============================================================

public class UIForwardEvents
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000186
    public GameObject target;

    // Token: 0x4000187
    public bool onHover;

    // Token: 0x4000188
    public bool onPress;

    // Token: 0x4000189
    public bool onClick;

    // Token: 0x400018A
    public bool onDoubleClick;

    // Token: 0x400018B
    public bool onSelect;

    // Token: 0x400018C
    public bool onDrag;

    // Token: 0x400018D
    public bool onDrop;

    // Token: 0x400018E
    public bool onSubmit;

    // Token: 0x400018F
    public bool onScroll;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600015F
    // RVA   : 0x12C1FC0   Offset: 0x12C13C0   Length: 0xD7
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
            uVar1 = il2cpp_value_box(DAT_181db2ae0,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SendMessage(lVar2,"OnHover",uVar1,1,0);
          }
        }
    }

    // Token : 0x6000160
    // RVA   : 0x12C20A0   Offset: 0x12C14A0   Length: 0xD7
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
            uVar1 = il2cpp_value_box(DAT_181db2ae0,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SendMessage(lVar2,"OnPress",uVar1,1,0);
          }
        }
    }

    // Token : 0x6000161
    // RVA   : 0x12C1CC0   Offset: 0x12C10C0   Length: 0xA0
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

    // Token : 0x6000162
    // RVA   : 0x12C1D70   Offset: 0x12C1170   Length: 0xA0
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

    // Token : 0x6000163
    // RVA   : 0x12C2260   Offset: 0x12C1660   Length: 0xD7
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
            uVar1 = il2cpp_value_box(DAT_181db2ae0,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SendMessage(lVar2,"OnSelect",uVar1,1,0);
          }
        }
    }

    // Token : 0x6000164
    // RVA   : 0x12C1E20   Offset: 0x12C1220   Length: 0xDB
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
            uVar1 = il2cpp_value_box(DAT_181db3968,&local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SendMessage(lVar2,"OnDrag",uVar1,1,0);
          }
        }
    }

    // Token : 0x6000165
    // RVA   : 0x12C1F00   Offset: 0x12C1300   Length: 0xB2
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

    // Token : 0x6000166
    // RVA   : 0x12C2340   Offset: 0x12C1740   Length: 0xA0
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

    // Token : 0x6000167
    // RVA   : 0x12C2180   Offset: 0x12C1580   Length: 0xD9
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
            uVar1 = il2cpp_value_box(DAT_181da22f0,local_res8);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            GameObject.SendMessage(lVar2,"OnScroll",uVar1,1,0);
          }
        }
    }

    // Token : 0x6000168
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
