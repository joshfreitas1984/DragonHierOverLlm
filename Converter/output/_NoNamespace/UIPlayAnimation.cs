// ============================================================
// Type  : UIPlayAnimation
// Token : 0x2000050
// ============================================================

public class UIPlayAnimation
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40001B0
    public static UIPlayAnimation current;

    // Token: 0x40001B1
    public Animation target;

    // Token: 0x40001B2
    public Animator animator;

    // Token: 0x40001B3
    public string clipName;

    // Token: 0x40001B4
    public Trigger trigger;

    // Token: 0x40001B5
    public Direction playDirection;

    // Token: 0x40001B6
    public bool resetOnPlay;

    // Token: 0x40001B7
    public bool clearSelection;

    // Token: 0x40001B8
    public EnableCondition ifDisabledOnPlay;

    // Token: 0x40001B9
    public DisableCondition disableWhenFinished;

    // Token: 0x40001BA
    public List<EventDelegate> onFinished;

    // Token: 0x40001BB
    private GameObject eventReceiver;

    // Token: 0x40001BC
    private string callWhenFinished;

    // Token: 0x40001BD
    private bool mStarted;

    // Token: 0x40001BE
    private bool mActivated;

    // Token: 0x40001BF
    private bool dragHighlight;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000193
    // RVA   : 0xF9CBC0   Offset: 0xF9B9C0   Length: 0x12
    private bool get_dualState()
    {
        uint32 FUN_180f9cbc0(int64 this)
        {
        int iVar1;
        iVar1 = this.trigger;
        if (iVar1 == 2) {
          return true;
        }
        return CONCAT31((int3)((uint32)iVar1 >> 8),iVar1 == 1);
    }

    // Token : 0x6000194
    // RVA   : 0xF9B6D0   Offset: 0xF9A4D0   Length: 0x131
    private void Awake()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        lVar3 = Component.GetComponent(this,DAT_181e79b38);
        cVar2 = Object.op_Inequality(lVar3,0,0);
        if (cVar2) {
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          this.dragHighlight = *(uint8 *)(lVar3 + 136);
        }
        uVar1 = this.eventReceiver;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.onFinished;
          cVar2 = EventDelegate.IsValid(uVar1,0);
          if (cVar2) {
            this.eventReceiver = 0;
            this.callWhenFinished = 0;
          }
        }
    }

    // Token : 0x6000195
    // RVA   : 0xF9C950   Offset: 0xF9B750   Length: 0x1E9
    private void Start()
    {
        bool cVar2;
        ulong uVar3;
        long lVar4;
        uVar3 = this.target;
        plVar1 = &this.target;
        this.mStarted = 1;
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          uVar3 = this.animator;
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (cVar2) {
            uVar3 = Component.GetComponentInChildren(this,DAT_181e7a738);
            this.animator = uVar3;
          }
        }
        uVar3 = this.animator;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          lVar4 = this.target;
          cVar2 = Object.op_Equality(lVar4,0,0);
          if (cVar2) {
            lVar4 = Component.GetComponentInChildren(this,DAT_181e7a6b8);
            this.target = lVar4;
            il2cpp_internal(plVar1,lVar4);
          }
          lVar4 = this.target;
          cVar2 = Object.op_Inequality(lVar4,0,0);
          if (!cVar2) {
            return;
          }
          if (this.target == null) throw; // [null/range check failed]
          cVar2 = Behaviour.get_enabled(this.target,0);
          if (!cVar2) {
            return;
          }
          lVar4 = this.target;
        }
        else {
          if (this.animator == null) throw; // [null/range check failed]
          cVar2 = Behaviour.get_enabled(this.animator,0);
          if (!cVar2) {
            return;
          }
          lVar4 = this.animator;
        }
        if (lVar4 != null) {
          Behaviour.set_enabled(lVar4,0,0);
          return;
        }
    }

    // Token : 0x6000196
    // RVA   : 0xF9BDB0   Offset: 0xF9ABB0   Length: 0x2F3
    private void OnEnable()
    {
        bool cVar1;
        bool cVar2;
        byte uVar3;
        int iVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        if (this.mStarted) {
          uVar5 = Component.get_gameObject(this,0);
          cVar1 = UICamera.IsHighlighted(uVar5,0);
          cVar2 = Behaviour.get_enabled(this,0);
          if (cVar2) {
            iVar4 = this.trigger;
            if (iVar4 == 1) {
        LAB_180f9be87:
              bVar8 = iVar4 == 1;
            }
            else {
              cVar2 = false;
              if (iVar4 == 3) {
                cVar2 = cVar1;
              }
              if (!cVar2) {
                if ((iVar4 != 4) || (cVar1)) goto LAB_180f9be9a;
                goto LAB_180f9be87;
              }
              if (iVar4 != 2) goto LAB_180f9be87;
              bVar8 = true;
            }
            UIPlayAnimation.Play(this,cVar1,bVar8,0);
          }
        }
        LAB_180f9be9a:
        if (UICamera.currentTouch != null) {
          iVar4 = this.trigger;
          if ((iVar4 == 2) || (iVar4 == 5)) {
            lVar7 = UICamera.currentTouch;
            if (lVar7 == null) goto LAB_180f9c09e;
            uVar5 = lVar7.pressed;
            uVar6 = Component.get_gameObject(this,0);
            uVar3 = Object.op_Equality(uVar5,uVar6,0);
            this.mActivated = uVar3;
            iVar4 = this.trigger;
          }
          if ((iVar4 - 1U & 0xfffffffd) == 0) {
            lVar7 = UICamera.currentTouch;
            if (lVar7 == null) goto LAB_180f9c09e;
            uVar5 = lVar7.current;
            uVar6 = Component.get_gameObject(this,0);
            uVar3 = Object.op_Equality(uVar5,uVar6,0);
            this.mActivated = uVar3;
          }
        }
        lVar7 = Component.GetComponent(this,DAT_181e7a3b8);
        cVar1 = Object.op_Inequality(lVar7,0,0);
        if (cVar1) {
          if (lVar7 == null) {
        LAB_180f9c09e:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar5 = lVar7.pressed;
          uVar6 = new OnTooltipCB(this,DAT_181e524f8,0);
          EventDelegate.Add(uVar5,uVar6,0);
        }
    }

    // Token : 0x6000197
    // RVA   : 0xF9B8D0   Offset: 0xF9A6D0   Length: 0x10D
    private void OnDisable()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        lVar2 = Component.GetComponent(this,DAT_181e7a3b8);
        cVar3 = Object.op_Inequality(lVar2,0,0);
        if (cVar3) {
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar1 = *(uint64 *)(lVar2 + 80);
          uVar4 = new OnTooltipCB(this,DAT_181e524f8,0);
          EventDelegate.Remove(uVar1,uVar4,0);
        }
    }

    // Token : 0x6000198
    // RVA   : 0xF9C280   Offset: 0xF9B080   Length: 0x68
    private void OnHover(bool isOver)
    {
        int iVar1;
        bool cVar2;
        uint uVar3;
        cVar2 = Behaviour.get_enabled(this,0);
        if (!cVar2) {
          return;
        }
        iVar1 = this.trigger;
        if (iVar1 != 1) {
          cVar2 = false;
          if (iVar1 == 3) {
            cVar2 = isOver;
          }
          if (!cVar2) {
            if (iVar1 != 4) {
              return;
            }
            if (isOver) {
              return;
            }
          }
          else if (iVar1 == 2) {
            uVar3 = 1;
            goto LAB_180f9c2c4;
          }
        }
        uVar3 = CONCAT31((int3)((uint32)iVar1 >> 8),iVar1 == 1);
        LAB_180f9c2c4:
        UIPlayAnimation.Play(this,isOver,uVar3,0);
    }

    // Token : 0x6000199
    // RVA   : 0xF9C2F0   Offset: 0xF9B0F0   Length: 0xE3
    private void OnPress(bool isPressed)
    {
        int iVar1;
        bool cVar2;
        cVar2 = Behaviour.get_enabled(this,0);
        if (cVar2) {
          if (UICamera.currentTouchID != -2) {
            if (UICamera.currentTouchID != -3) {
              iVar1 = this.trigger;
              if (iVar1 == 2) {
                bVar3 = true;
              }
              else {
                cVar2 = false;
                if (iVar1 == 5) {
                  cVar2 = isPressed;
                }
                if (!cVar2) {
                  if (iVar1 != 6) {
                    return;
                  }
                  if (isPressed) {
                    return;
                  }
                }
                bVar3 = iVar1 == 1;
              }
              UIPlayAnimation.Play(this,isPressed,bVar3,0);
            }
          }
        }
    }

    // Token : 0x600019A
    // RVA   : 0xF9B810   Offset: 0xF9A610   Length: 0xB2
    private void OnClick()
    {
        bool cVar1;
        if (UICamera.currentTouchID != -2) {
          if (UICamera.currentTouchID != -3) {
            cVar1 = Behaviour.get_enabled(this,0);
            if ((cVar1) && (this.trigger == null)) {
              UIPlayAnimation.Play(this,1,0,0);
            }
          }
        }
    }

    // Token : 0x600019B
    // RVA   : 0xF9B9E0   Offset: 0xF9A7E0   Length: 0xB2
    private void OnDoubleClick()
    {
        bool cVar1;
        if (UICamera.currentTouchID != -2) {
          if (UICamera.currentTouchID != -3) {
            cVar1 = Behaviour.get_enabled(this,0);
            if ((cVar1) && (this.trigger == 10)) {
              UIPlayAnimation.Play(this,1,0,0);
            }
          }
        }
    }

    // Token : 0x600019C
    // RVA   : 0xF9C3E0   Offset: 0xF9B1E0   Length: 0x68
    private void OnSelect(bool isSelected)
    {
        int iVar1;
        bool cVar2;
        uint uVar3;
        cVar2 = Behaviour.get_enabled(this,0);
        if (!cVar2) {
          return;
        }
        iVar1 = this.trigger;
        if (iVar1 != 11) {
          cVar2 = false;
          if (iVar1 == 12) {
            cVar2 = isSelected;
          }
          if (!cVar2) {
            if (iVar1 != 13) {
              return;
            }
            if (isSelected) {
              return;
            }
          }
          else if (iVar1 == 2) {
            uVar3 = 1;
            goto LAB_180f9c424;
          }
        }
        uVar3 = CONCAT31((int3)((uint32)iVar1 >> 8),iVar1 == 1);
        LAB_180f9c424:
        UIPlayAnimation.Play(this,isSelected,uVar3,0);
    }

    // Token : 0x600019D
    // RVA   : 0xF9C450   Offset: 0xF9B250   Length: 0x1DE
    private void OnToggle()
    {
        var pStatics = *(int64*)(DAT_181e90950 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        byte uVar4;
        cVar3 = Behaviour.get_enabled(this,0);
        if (!cVar3) {
          return;
        }
        uVar1 = *(uint64 *)(pStatics + 8);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          return;
        }
        if (this.trigger != 7) {
          if (this.trigger == 8) {
            lVar2 = *(int64 *)(pStatics + 8);
            if (lVar2 == null) throw; // [null/range check failed]
            cVar3 = UIToggle.get_isChecked(lVar2,0);
            if (cVar3) goto LAB_180f9c5ac;
          }
          if (this.trigger != 9) {
            return;
          }
          lVar2 = *(int64 *)(pStatics + 8);
          if (lVar2 == null) throw; // [null/range check failed]
          cVar3 = UIToggle.get_isChecked(lVar2,0);
          if (cVar3) {
            return;
          }
        }
        LAB_180f9c5ac:
        lVar2 = *(int64 *)(pStatics + 8);
        if (lVar2 != null) {
          uVar4 = UIToggle.get_isChecked(lVar2,0);
          if (this.trigger != 2) {
            UIPlayAnimation.Play(this,uVar4,this.trigger == 1,0);
            return;
          }
          UIPlayAnimation.Play(this,uVar4,1,0);
          return;
        }
    }

    // Token : 0x600019E
    // RVA   : 0xF9BB90   Offset: 0xF9A990   Length: 0x111
    private void OnDragOver()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        cVar3 = Behaviour.get_enabled(this,0);
        if ((cVar3) && ((this.trigger == 2 || (this.trigger == 1)))) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e8fad0 + 184) + 224);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar2 = *(uint64 *)(lVar1 + 88);
          uVar4 = Component.get_gameObject(this,0);
          cVar3 = Object.op_Equality(uVar2,uVar4,0);
          if ((cVar3) || ((this.dragHighlight && (this.trigger == 2))))
          {
            UIPlayAnimation.Play(this,1,1,0);
            return;
          }
        }
    }

    // Token : 0x600019F
    // RVA   : 0xF9BAA0   Offset: 0xF9A8A0   Length: 0xE8
    private void OnDragOut()
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        cVar1 = Behaviour.get_enabled(this,0);
        if ((cVar1) && ((this.trigger == 2 || (this.trigger == 1)))) {
          uVar2 = UICamera.get_hoveredObject(0);
          uVar3 = Component.get_gameObject(this,0);
          cVar1 = Object.op_Inequality(uVar2,uVar3,0);
          if (cVar1) {
            UIPlayAnimation.Play(this,0,1,0);
            return;
          }
        }
    }

    // Token : 0x60001A0
    // RVA   : 0xF9BCB0   Offset: 0xF9AAB0   Length: 0xFD
    private void OnDrop(GameObject go)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        cVar3 = Behaviour.get_enabled(this,0);
        if ((cVar3) && (this.trigger == 2)) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e8fad0 + 184) + 224);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar2 = *(uint64 *)(lVar1 + 88);
          uVar4 = Component.get_gameObject(this,0);
          cVar3 = Object.op_Inequality(uVar2,uVar4,0);
          if (cVar3) {
            UIPlayAnimation.Play(this,0,1,0);
            return;
          }
        }
    }

    // Token : 0x60001A1
    // RVA   : 0xF9C940   Offset: 0xF9B740   Length: 0xB
    public void Play(bool forward)
    {
        long lVar1;
        int iVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        int iVar7;
        uVar4 = this.target;
        cVar3 = Object.op_Implicit(uVar4,0);
        if (!cVar3) {
          uVar4 = this.animator;
          cVar3 = Object.op_Implicit(uVar4,0);
          if (!cVar3) {
            return;
          }
        }
        if (param_3) {
          if (this.mActivated == forward) {
            return;
          }
          this.mActivated = forward;
        }
        if (this.clearSelection) {
          uVar4 = UICamera.get_selectedObject(0);
          uVar5 = Component.get_gameObject(this,0);
          cVar3 = Object.op_Equality(uVar4,uVar5,0);
          if (cVar3) {
            UICamera.set_selectedObject(0,0);
          }
        }
        uVar4 = this.target;
        iVar2 = this.playDirection;
        if (!forward) {
          iVar2 = -this.playDirection;
        }
        cVar3 = Object.op_Implicit(uVar4,0);
        iVar7 = 0;
        if (!cVar3) {
          lVar6 = ActiveAnimation.Play
                            (this.animator,this.clipName,iVar2,
                             this.ifDisabledOnPlay,this.disableWhenFinished,0);
        }
        else {
          lVar6 = ActiveAnimation.Play(this.target);
        }
        cVar3 = Object.op_Inequality(lVar6,0,0);
        if (!cVar3) {
          return;
        }
        if (this.resetOnPlay) {
          if (lVar6 == null) throw; // [null/range check failed]
          ActiveAnimation.Reset(lVar6,0);
        }
        lVar1 = this.onFinished;
        while (lVar1 != null) {
          if (lVar1.Count <= iVar7) {
            return;
          }
          if (lVar6 == null) break;
          uVar4 = *(uint64 *)(lVar6 + 24);
          uVar5 = new OnTooltipCB(this,DAT_181e52470,0);
          EventDelegate.Add(uVar4,uVar5,1);
          iVar7 = iVar7 + 1;
          lVar1 = this.onFinished;
        }
    }

    // Token : 0x60001A2
    // RVA   : 0xF9C650   Offset: 0xF9B450   Length: 0x2E3
    public void Play(bool forward, bool onlyIfDifferent)
    {
        long lVar1;
        int iVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        int iVar7;
        uVar4 = this.target;
        cVar3 = Object.op_Implicit(uVar4,0);
        if (!cVar3) {
          uVar4 = this.animator;
          cVar3 = Object.op_Implicit(uVar4,0);
          if (!cVar3) {
            return;
          }
        }
        if (onlyIfDifferent) {
          if (this.mActivated == forward) {
            return;
          }
          this.mActivated = forward;
        }
        if (this.clearSelection) {
          uVar4 = UICamera.get_selectedObject(0);
          uVar5 = Component.get_gameObject(this,0);
          cVar3 = Object.op_Equality(uVar4,uVar5,0);
          if (cVar3) {
            UICamera.set_selectedObject(0,0);
          }
        }
        uVar4 = this.target;
        iVar2 = this.playDirection;
        if (!forward) {
          iVar2 = -this.playDirection;
        }
        cVar3 = Object.op_Implicit(uVar4,0);
        iVar7 = 0;
        if (!cVar3) {
          lVar6 = ActiveAnimation.Play
                            (this.animator,this.clipName,iVar2,
                             this.ifDisabledOnPlay,this.disableWhenFinished,0);
        }
        else {
          lVar6 = ActiveAnimation.Play(this.target);
        }
        cVar3 = Object.op_Inequality(lVar6,0,0);
        if (!cVar3) {
          return;
        }
        if (this.resetOnPlay) {
          if (lVar6 == null) throw; // [null/range check failed]
          ActiveAnimation.Reset(lVar6,0);
        }
        lVar1 = this.onFinished;
        while (lVar1 != null) {
          if (lVar1.Count <= iVar7) {
            return;
          }
          if (lVar6 == null) break;
          uVar4 = *(uint64 *)(lVar6 + 24);
          uVar5 = new OnTooltipCB(this,DAT_181e52470,0);
          EventDelegate.Add(uVar4,uVar5,1);
          iVar7 = iVar7 + 1;
          lVar1 = this.onFinished;
        }
    }

    // Token : 0x60001A3
    // RVA   : 0xF9C630   Offset: 0xF9B430   Length: 0xF
    public void PlayForward()
    {
        void FUN_180f9c630(uint64 this)
        {
        UIPlayAnimation.Play(this,1,1,0);
    }

    // Token : 0x60001A4
    // RVA   : 0xF9C640   Offset: 0xF9B440   Length: 0xD
    public void PlayReverse()
    {
        void FUN_180f9c640(uint64 this)
        {
        UIPlayAnimation.Play(this,0,1,0);
    }

    // Token : 0x60001A5
    // RVA   : 0xF9C0B0   Offset: 0xF9AEB0   Length: 0x1C4
    private void OnFinished()
    {
        ulong uVar1;
        long lVar3;
        bool cVar5;
        uVar1 = **(uint64 **)(DAT_181e90350 + 184);
        cVar5 = Object.op_Equality(uVar1,0,0);
        if (cVar5) {
          plVar2 = *(int64 **)(DAT_181e90350 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar1 = this.onFinished;
          EventDelegate.Execute(uVar1,0);
          lVar3 = this.eventReceiver;
          cVar5 = Object.op_Inequality(lVar3,0,0);
          if (cVar5) {
            cVar5 = FUN_180ad1200(this.callWhenFinished,0);
            if (!cVar5) {
              if (*plVar2 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              GameObject.SendMessage(*plVar2,this.callWhenFinished,1);
            }
          }
          *plVar2 = 0;
          il2cpp_internal(plVar2,0);
          puVar4 = *(uint64 **)(DAT_181e90350 + 184);
          *puVar4 = 0;
          il2cpp_internal(puVar4,0);
        }
    }

    // Token : 0x60001A6
    // RVA   : 0xF9CB40   Offset: 0xF9B940   Length: 0x7D
    public void /*ctor*/()
    {
        ulong uVar1;
        this.playDirection = 1;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        this.onFinished = uVar1;
        FUN_180ae8740(this,0);
    }

    // Token : 0x60001A7
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private static void /*cctor*/()
    {
    }

}
