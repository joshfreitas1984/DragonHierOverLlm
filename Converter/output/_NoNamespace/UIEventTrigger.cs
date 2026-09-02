// ============================================================
// Type  : UIEventTrigger
// Token : 0x2000044
// ============================================================

public class UIEventTrigger
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400015C
    public static UIEventTrigger current;

    // Token: 0x400015D
    public List<EventDelegate> onHoverOver;

    // Token: 0x400015E
    public List<EventDelegate> onHoverOut;

    // Token: 0x400015F
    public List<EventDelegate> onPress;

    // Token: 0x4000160
    public List<EventDelegate> onRelease;

    // Token: 0x4000161
    public List<EventDelegate> onSelect;

    // Token: 0x4000162
    public List<EventDelegate> onDeselect;

    // Token: 0x4000163
    public List<EventDelegate> onClick;

    // Token: 0x4000164
    public List<EventDelegate> onDoubleClick;

    // Token: 0x4000165
    public List<EventDelegate> onDragStart;

    // Token: 0x4000166
    public List<EventDelegate> onDragEnd;

    // Token: 0x4000167
    public List<EventDelegate> onDragOver;

    // Token: 0x4000168
    public List<EventDelegate> onDragOut;

    // Token: 0x4000169
    public List<EventDelegate> onDrag;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600013B
    // RVA   : 0x10E7B50   Offset: 0x10E6350   Length: 0x105
    public bool get_isColliderEnabled()
    {
        long lVar1;
        bool cVar2;
        lVar1 = Component.GetComponent(this,DAT_181d6b340);
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (!cVar2) {
          lVar1 = Component.GetComponent(this,DAT_181d6b3c0);
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

    // Token : 0x600013C
    // RVA   : 0x10E7550   Offset: 0x10E5D50   Length: 0x113
    private void OnHover(bool isOver)
    {
        bool cVar3;
        ulong uVar4;
        uVar4 = **(uint64 **)(DAT_181d8a858 + 184);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          cVar3 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar3) {
            plVar1 = *(int64 **)(DAT_181d8a858 + 184);
            *plVar1 = this;
            il2cpp_internal(plVar1,this);
            if (!isOver) {
              uVar4 = this.onHoverOut;
            }
            else {
              uVar4 = this.onHoverOver;
            }
            EventDelegate.Execute(uVar4,0);
            puVar2 = *(uint64 **)(DAT_181d8a858 + 184);
            *puVar2 = 0;
            il2cpp_internal(puVar2,0);
          }
        }
    }

    // Token : 0x600013D
    // RVA   : 0x10E7670   Offset: 0x10E5E70   Length: 0x113
    private void OnPress(bool pressed)
    {
        bool cVar3;
        ulong uVar4;
        uVar4 = **(uint64 **)(DAT_181d8a858 + 184);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          cVar3 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar3) {
            plVar1 = *(int64 **)(DAT_181d8a858 + 184);
            *plVar1 = this;
            il2cpp_internal(plVar1,this);
            if (!pressed) {
              uVar4 = this.onRelease;
            }
            else {
              uVar4 = this.onPress;
            }
            EventDelegate.Execute(uVar4,0);
            puVar2 = *(uint64 **)(DAT_181d8a858 + 184);
            *puVar2 = 0;
            il2cpp_internal(puVar2,0);
          }
        }
    }

    // Token : 0x600013E
    // RVA   : 0x10E7790   Offset: 0x10E5F90   Length: 0x113
    private void OnSelect(bool selected)
    {
        bool cVar3;
        ulong uVar4;
        uVar4 = **(uint64 **)(DAT_181d8a858 + 184);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          cVar3 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar3) {
            plVar1 = *(int64 **)(DAT_181d8a858 + 184);
            *plVar1 = this;
            il2cpp_internal(plVar1,this);
            if (!selected) {
              uVar4 = this.onDeselect;
            }
            else {
              uVar4 = this.onSelect;
            }
            EventDelegate.Execute(uVar4,0);
            puVar2 = *(uint64 **)(DAT_181d8a858 + 184);
            *puVar2 = 0;
            il2cpp_internal(puVar2,0);
          }
        }
    }

    // Token : 0x600013F
    // RVA   : 0x10E6E80   Offset: 0x10E5680   Length: 0xFB
    private void OnClick()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181d8a858 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181d8a858 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onClick;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181d8a858 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x6000140
    // RVA   : 0x10E6F80   Offset: 0x10E5780   Length: 0xFB
    private void OnDoubleClick()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181d8a858 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181d8a858 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onDoubleClick;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181d8a858 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x6000141
    // RVA   : 0x10E7370   Offset: 0x10E5B70   Length: 0xED
    private void OnDragStart()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181d8a858 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          plVar2 = *(int64 **)(DAT_181d8a858 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar1 = this.onDragStart;
          EventDelegate.Execute(uVar1,0);
          puVar3 = *(uint64 **)(DAT_181d8a858 + 184);
          *puVar3 = 0;
          il2cpp_internal(puVar3,0);
        }
    }

    // Token : 0x6000142
    // RVA   : 0x10E7080   Offset: 0x10E5880   Length: 0xED
    private void OnDragEnd()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181d8a858 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          plVar2 = *(int64 **)(DAT_181d8a858 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar1 = this.onDragEnd;
          EventDelegate.Execute(uVar1,0);
          puVar3 = *(uint64 **)(DAT_181d8a858 + 184);
          *puVar3 = 0;
          il2cpp_internal(puVar3,0);
        }
    }

    // Token : 0x6000143
    // RVA   : 0x10E7270   Offset: 0x10E5A70   Length: 0xFB
    private void OnDragOver(GameObject go)
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181d8a858 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181d8a858 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onDragOver;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181d8a858 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x6000144
    // RVA   : 0x10E7170   Offset: 0x10E5970   Length: 0xFB
    private void OnDragOut(GameObject go)
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181d8a858 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181d8a858 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onDragOut;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181d8a858 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x6000145
    // RVA   : 0x10E7460   Offset: 0x10E5C60   Length: 0xED
    private void OnDrag(Vector2 delta)
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181d8a858 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          plVar2 = *(int64 **)(DAT_181d8a858 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar1 = this.onDrag;
          EventDelegate.Execute(uVar1,0);
          puVar3 = *(uint64 **)(DAT_181d8a858 + 184);
          *puVar3 = 0;
          il2cpp_internal(puVar3,0);
        }
    }

    // Token : 0x6000146
    // RVA   : 0x10E78B0   Offset: 0x10E60B0   Length: 0x292
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onHoverOver = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onHoverOut = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onPress = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onRelease = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onSelect = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onDeselect = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onClick = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onDoubleClick = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onDragStart = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onDragEnd = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onDragOver = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onDragOut = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onDrag = uVar1;
        FUN_18044ef50(this,0);
    }

}
