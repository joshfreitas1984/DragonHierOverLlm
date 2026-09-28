// ============================================================
// Type  : UIEventTrigger
// Token : 0x2000045
// ============================================================

public class UIEventTrigger
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000178
    public static UIEventTrigger current;

    // Token: 0x4000179
    public List<EventDelegate> onHoverOver;

    // Token: 0x400017A
    public List<EventDelegate> onHoverOut;

    // Token: 0x400017B
    public List<EventDelegate> onPress;

    // Token: 0x400017C
    public List<EventDelegate> onRelease;

    // Token: 0x400017D
    public List<EventDelegate> onSelect;

    // Token: 0x400017E
    public List<EventDelegate> onDeselect;

    // Token: 0x400017F
    public List<EventDelegate> onClick;

    // Token: 0x4000180
    public List<EventDelegate> onDoubleClick;

    // Token: 0x4000181
    public List<EventDelegate> onDragStart;

    // Token: 0x4000182
    public List<EventDelegate> onDragEnd;

    // Token: 0x4000183
    public List<EventDelegate> onDragOver;

    // Token: 0x4000184
    public List<EventDelegate> onDragOut;

    // Token: 0x4000185
    public List<EventDelegate> onDrag;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000153
    // RVA   : 0x12BE4B0   Offset: 0x12BD8B0   Length: 0x105
    public bool get_isColliderEnabled()
    {
        long lVar1;
        bool cVar2;
        lVar1 = Component.GetComponent(this,DAT_181d93b60);
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (!cVar2) {
          lVar1 = Component.GetComponent(this,DAT_181d93be0);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            return;
          }
          if (lVar1 != null) {
            Behaviour.get_enabled(lVar1,0);
            return;
          }
        }
        else if (lVar1 != null) {
          Collider.get_enabled(lVar1,0);
          return;
        }
    }

    // Token : 0x6000154
    // RVA   : 0x12BDEB0   Offset: 0x12BD2B0   Length: 0x113
    private void OnHover(bool isOver)
    {
        bool cVar3;
        ulong uVar4;
        uVar4 = **(uint64 **)(DAT_181dafa78 + 184);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          cVar3 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar3) {
            plVar1 = *(int64 **)(DAT_181dafa78 + 184);
            *plVar1 = this;
            il2cpp_internal(plVar1,this);
            if (!isOver) {
              uVar4 = this.onHoverOut;
            }
            else {
              uVar4 = this.onHoverOver;
            }
            EventDelegate.Execute(uVar4,0);
            puVar2 = *(uint64 **)(DAT_181dafa78 + 184);
            *puVar2 = 0;
            il2cpp_internal(puVar2,0);
          }
        }
    }

    // Token : 0x6000155
    // RVA   : 0x12BDFD0   Offset: 0x12BD3D0   Length: 0x113
    private void OnPress(bool pressed)
    {
        bool cVar3;
        ulong uVar4;
        uVar4 = **(uint64 **)(DAT_181dafa78 + 184);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          cVar3 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar3) {
            plVar1 = *(int64 **)(DAT_181dafa78 + 184);
            *plVar1 = this;
            il2cpp_internal(plVar1,this);
            if (!pressed) {
              uVar4 = this.onRelease;
            }
            else {
              uVar4 = this.onPress;
            }
            EventDelegate.Execute(uVar4,0);
            puVar2 = *(uint64 **)(DAT_181dafa78 + 184);
            *puVar2 = 0;
            il2cpp_internal(puVar2,0);
          }
        }
    }

    // Token : 0x6000156
    // RVA   : 0x12BE0F0   Offset: 0x12BD4F0   Length: 0x113
    private void OnSelect(bool selected)
    {
        bool cVar3;
        ulong uVar4;
        uVar4 = **(uint64 **)(DAT_181dafa78 + 184);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          cVar3 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar3) {
            plVar1 = *(int64 **)(DAT_181dafa78 + 184);
            *plVar1 = this;
            il2cpp_internal(plVar1,this);
            if (!selected) {
              uVar4 = this.onDeselect;
            }
            else {
              uVar4 = this.onSelect;
            }
            EventDelegate.Execute(uVar4,0);
            puVar2 = *(uint64 **)(DAT_181dafa78 + 184);
            *puVar2 = 0;
            il2cpp_internal(puVar2,0);
          }
        }
    }

    // Token : 0x6000157
    // RVA   : 0x12BD7E0   Offset: 0x12BCBE0   Length: 0xFB
    private void OnClick()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181dafa78 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181dafa78 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onClick;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181dafa78 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x6000158
    // RVA   : 0x12BD8E0   Offset: 0x12BCCE0   Length: 0xFB
    private void OnDoubleClick()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181dafa78 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181dafa78 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onDoubleClick;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181dafa78 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x6000159
    // RVA   : 0x12BDCD0   Offset: 0x12BD0D0   Length: 0xED
    private void OnDragStart()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181dafa78 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          plVar2 = *(int64 **)(DAT_181dafa78 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar1 = this.onDragStart;
          EventDelegate.Execute(uVar1,0);
          puVar3 = *(uint64 **)(DAT_181dafa78 + 184);
          *puVar3 = 0;
          il2cpp_internal(puVar3,0);
        }
    }

    // Token : 0x600015A
    // RVA   : 0x12BD9E0   Offset: 0x12BCDE0   Length: 0xED
    private void OnDragEnd()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181dafa78 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          plVar2 = *(int64 **)(DAT_181dafa78 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar1 = this.onDragEnd;
          EventDelegate.Execute(uVar1,0);
          puVar3 = *(uint64 **)(DAT_181dafa78 + 184);
          *puVar3 = 0;
          il2cpp_internal(puVar3,0);
        }
    }

    // Token : 0x600015B
    // RVA   : 0x12BDBD0   Offset: 0x12BCFD0   Length: 0xFB
    private void OnDragOver(GameObject go)
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181dafa78 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181dafa78 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onDragOver;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181dafa78 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x600015C
    // RVA   : 0x12BDAD0   Offset: 0x12BCED0   Length: 0xFB
    private void OnDragOut(GameObject go)
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181dafa78 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181dafa78 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onDragOut;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181dafa78 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x600015D
    // RVA   : 0x12BDDC0   Offset: 0x12BD1C0   Length: 0xED
    private void OnDrag(Vector2 delta)
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181dafa78 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          plVar2 = *(int64 **)(DAT_181dafa78 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar1 = this.onDrag;
          EventDelegate.Execute(uVar1,0);
          puVar3 = *(uint64 **)(DAT_181dafa78 + 184);
          *puVar3 = 0;
          il2cpp_internal(puVar3,0);
        }
    }

    // Token : 0x600015E
    // RVA   : 0x12BE210   Offset: 0x12BD610   Length: 0x292
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onHoverOver = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onHoverOut = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onPress = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onRelease = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onSelect = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onDeselect = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onClick = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onDoubleClick = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onDragStart = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onDragEnd = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onDragOver = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onDragOut = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onDrag = uVar1;
        FUN_18044ef50(this,0);
    }

}
