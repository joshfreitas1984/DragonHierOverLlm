// ============================================================
// Type  : UIEventTrigger
// Token : 0x2000044
// ============================================================

public class UIEventTrigger
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000158
    public static UIEventTrigger current;

    // Token: 0x4000159
    public List<EventDelegate> onHoverOver;

    // Token: 0x400015A
    public List<EventDelegate> onHoverOut;

    // Token: 0x400015B
    public List<EventDelegate> onPress;

    // Token: 0x400015C
    public List<EventDelegate> onRelease;

    // Token: 0x400015D
    public List<EventDelegate> onSelect;

    // Token: 0x400015E
    public List<EventDelegate> onDeselect;

    // Token: 0x400015F
    public List<EventDelegate> onClick;

    // Token: 0x4000160
    public List<EventDelegate> onDoubleClick;

    // Token: 0x4000161
    public List<EventDelegate> onDragStart;

    // Token: 0x4000162
    public List<EventDelegate> onDragEnd;

    // Token: 0x4000163
    public List<EventDelegate> onDragOver;

    // Token: 0x4000164
    public List<EventDelegate> onDragOut;

    // Token: 0x4000165
    public List<EventDelegate> onDrag;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600013A
    // RVA   : 0x1145860   Offset: 0x1144660   Length: 0x105
    public bool get_isColliderEnabled()
    {
        long lVar1;
        bool cVar2;
        lVar1 = Component.GetComponent(this,DAT_181e76eb8);
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (!cVar2) {
          lVar1 = Component.GetComponent(this,DAT_181e76f38);
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

    // Token : 0x600013B
    // RVA   : 0x1145260   Offset: 0x1144060   Length: 0x113
    private void OnHover(bool isOver)
    {
        bool cVar3;
        ulong uVar4;
        uVar4 = **(uint64 **)(DAT_181e8fed0 + 184);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          cVar3 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar3) {
            plVar1 = *(int64 **)(DAT_181e8fed0 + 184);
            *plVar1 = this;
            il2cpp_internal(plVar1,this);
            if (!isOver) {
              uVar4 = this.onHoverOut;
            }
            else {
              uVar4 = this.onHoverOver;
            }
            EventDelegate.Execute(uVar4,0);
            puVar2 = *(uint64 **)(DAT_181e8fed0 + 184);
            *puVar2 = 0;
            il2cpp_internal(puVar2,0);
          }
        }
    }

    // Token : 0x600013C
    // RVA   : 0x1145380   Offset: 0x1144180   Length: 0x113
    private void OnPress(bool pressed)
    {
        bool cVar3;
        ulong uVar4;
        uVar4 = **(uint64 **)(DAT_181e8fed0 + 184);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          cVar3 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar3) {
            plVar1 = *(int64 **)(DAT_181e8fed0 + 184);
            *plVar1 = this;
            il2cpp_internal(plVar1,this);
            if (!pressed) {
              uVar4 = this.onRelease;
            }
            else {
              uVar4 = this.onPress;
            }
            EventDelegate.Execute(uVar4,0);
            puVar2 = *(uint64 **)(DAT_181e8fed0 + 184);
            *puVar2 = 0;
            il2cpp_internal(puVar2,0);
          }
        }
    }

    // Token : 0x600013D
    // RVA   : 0x11454A0   Offset: 0x11442A0   Length: 0x113
    private void OnSelect(bool selected)
    {
        bool cVar3;
        ulong uVar4;
        uVar4 = **(uint64 **)(DAT_181e8fed0 + 184);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          cVar3 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar3) {
            plVar1 = *(int64 **)(DAT_181e8fed0 + 184);
            *plVar1 = this;
            il2cpp_internal(plVar1,this);
            if (!selected) {
              uVar4 = this.onDeselect;
            }
            else {
              uVar4 = this.onSelect;
            }
            EventDelegate.Execute(uVar4,0);
            puVar2 = *(uint64 **)(DAT_181e8fed0 + 184);
            *puVar2 = 0;
            il2cpp_internal(puVar2,0);
          }
        }
    }

    // Token : 0x600013E
    // RVA   : 0x1144B90   Offset: 0x1143990   Length: 0xFB
    private void OnClick()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181e8fed0 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181e8fed0 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onClick;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181e8fed0 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x600013F
    // RVA   : 0x1144C90   Offset: 0x1143A90   Length: 0xFB
    private void OnDoubleClick()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181e8fed0 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181e8fed0 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onDoubleClick;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181e8fed0 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x6000140
    // RVA   : 0x1145080   Offset: 0x1143E80   Length: 0xED
    private void OnDragStart()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181e8fed0 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          plVar2 = *(int64 **)(DAT_181e8fed0 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar1 = this.onDragStart;
          EventDelegate.Execute(uVar1,0);
          puVar3 = *(uint64 **)(DAT_181e8fed0 + 184);
          *puVar3 = 0;
          il2cpp_internal(puVar3,0);
        }
    }

    // Token : 0x6000141
    // RVA   : 0x1144D90   Offset: 0x1143B90   Length: 0xED
    private void OnDragEnd()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181e8fed0 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          plVar2 = *(int64 **)(DAT_181e8fed0 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar1 = this.onDragEnd;
          EventDelegate.Execute(uVar1,0);
          puVar3 = *(uint64 **)(DAT_181e8fed0 + 184);
          *puVar3 = 0;
          il2cpp_internal(puVar3,0);
        }
    }

    // Token : 0x6000142
    // RVA   : 0x1144F80   Offset: 0x1143D80   Length: 0xFB
    private void OnDragOver(GameObject go)
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181e8fed0 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181e8fed0 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onDragOver;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181e8fed0 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x6000143
    // RVA   : 0x1144E80   Offset: 0x1143C80   Length: 0xFB
    private void OnDragOut(GameObject go)
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181e8fed0 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          cVar4 = UIEventTrigger.get_isColliderEnabled(this,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181e8fed0 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onDragOut;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181e8fed0 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x6000144
    // RVA   : 0x1145170   Offset: 0x1143F70   Length: 0xED
    private void OnDrag(Vector2 delta)
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181e8fed0 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          plVar2 = *(int64 **)(DAT_181e8fed0 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar1 = this.onDrag;
          EventDelegate.Execute(uVar1,0);
          puVar3 = *(uint64 **)(DAT_181e8fed0 + 184);
          *puVar3 = 0;
          il2cpp_internal(puVar3,0);
        }
    }

    // Token : 0x6000145
    // RVA   : 0x11455C0   Offset: 0x11443C0   Length: 0x292
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onHoverOver = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onHoverOut = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onPress = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onRelease = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onSelect = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onDeselect = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onClick = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onDoubleClick = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onDragStart = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onDragEnd = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onDragOver = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onDragOut = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onDrag = uVar1;
        FUN_180ae8740(this,0);
    }

}
