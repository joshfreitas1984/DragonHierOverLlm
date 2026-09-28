// ============================================================
// Type  : UIPlayAnimation
// Token : 0x2000051
// ============================================================

public class UIPlayAnimation
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40001D0
    public static UIPlayAnimation current;

    // Token: 0x40001D1
    public Animation target;

    // Token: 0x40001D2
    public Animator animator;

    // Token: 0x40001D3
    public string clipName;

    // Token: 0x40001D4
    public Trigger trigger;

    // Token: 0x40001D5
    public Direction playDirection;

    // Token: 0x40001D6
    public bool resetOnPlay;

    // Token: 0x40001D7
    public bool clearSelection;

    // Token: 0x40001D8
    public EnableCondition ifDisabledOnPlay;

    // Token: 0x40001D9
    public DisableCondition disableWhenFinished;

    // Token: 0x40001DA
    public List<EventDelegate> onFinished;

    // Token: 0x40001DB
    private GameObject eventReceiver;

    // Token: 0x40001DC
    private string callWhenFinished;

    // Token: 0x40001DD
    private bool mStarted;

    // Token: 0x40001DE
    private bool mActivated;

    // Token: 0x40001DF
    private bool dragHighlight;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60001AC
    // RVA   : 0x119F0F0   Offset: 0x119E4F0   Length: 0x12
    private bool get_dualState()
    {
        uint32 FUN_18119f0f0(int64 this)
        {
        int iVar1;
        iVar1 = this.trigger;
        if (iVar1 == 2) {
          return true;
        }
        return CONCAT31((int3)((uint32)iVar1 >> 8),iVar1 == 1);
    }

    // Token : 0x60001AD
    // RVA   : 0x119DC00   Offset: 0x119D000   Length: 0x131
    private void Awake()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        lVar3 = Component.GetComponent(this,DAT_181d96760);
        cVar2 = Object.op_Inequality(lVar3,0,0);
        if (cVar2) {
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
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

    // Token : 0x60001AE
    // RVA   : 0x119EE80   Offset: 0x119E280   Length: 0x1E9
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
            uVar3 = Component.GetComponentInChildren(this,DAT_181d97360);
            this.animator = uVar3;
          }
        }
        uVar3 = this.animator;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          lVar4 = this.target;
          cVar2 = Object.op_Equality(lVar4,0,0);
          if (cVar2) {
            lVar4 = Component.GetComponentInChildren(this,DAT_181d972e0);
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

    // Token : 0x60001AF
    // RVA   : 0x119E2E0   Offset: 0x119D6E0   Length: 0x2F3
    private void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
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
        LAB_18119e3b7:
              bVar8 = iVar4 == 1;
            }
            else {
              cVar2 = false;
              if (iVar4 == 3) {
                cVar2 = cVar1;
              }
              if (!cVar2) {
                if ((iVar4 != 4) || (cVar1)) goto LAB_18119e3ca;
                goto LAB_18119e3b7;
              }
              if (iVar4 != 2) goto LAB_18119e3b7;
              bVar8 = true;
            }
            UIPlayAnimation.Play(this,cVar1,bVar8,0);
          }
        }
        LAB_18119e3ca:
        if (*(int64 *)(pStatics + 224) != 0) {
          iVar4 = this.trigger;
          if ((iVar4 == 2) || (iVar4 == 5)) {
            lVar7 = *(int64 *)(pStatics + 224);
            if (lVar7 == null) goto LAB_18119e5ce;
            uVar5 = *(uint64 *)(lVar7 + 80);
            uVar6 = Component.get_gameObject(this,0);
            uVar3 = Object.op_Equality(uVar5,uVar6,0);
            this.mActivated = uVar3;
            iVar4 = this.trigger;
          }
          if ((iVar4 - 1U & 0xfffffffd) == 0) {
            lVar7 = *(int64 *)(pStatics + 224);
            if (lVar7 == null) goto LAB_18119e5ce;
            uVar5 = *(uint64 *)(lVar7 + 72);
            uVar6 = Component.get_gameObject(this,0);
            uVar3 = Object.op_Equality(uVar5,uVar6,0);
            this.mActivated = uVar3;
          }
        }
        lVar7 = Component.GetComponent(this,DAT_181d96fe0);
        cVar1 = Object.op_Inequality(lVar7,0,0);
        if (cVar1) {
          if (lVar7 == null) {
        LAB_18119e5ce:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar5 = *(uint64 *)(lVar7 + 80);
          uVar6 = new OnTooltipCB(this,DAT_181dc6090,0);
          EventDelegate.Add(uVar5,uVar6,0);
        }
    }

    // Token : 0x60001B0
    // RVA   : 0x119DE00   Offset: 0x119D200   Length: 0x10D
    private void OnDisable()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        lVar2 = Component.GetComponent(this,DAT_181d96fe0);
        cVar3 = Object.op_Inequality(lVar2,0,0);
        if (cVar3) {
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = *(uint64 *)(lVar2 + 80);
          uVar4 = new OnTooltipCB(this,DAT_181dc6090,0);
          EventDelegate.Remove(uVar1,uVar4,0);
        }
    }

    // Token : 0x60001B1
    // RVA   : 0x119E7B0   Offset: 0x119DBB0   Length: 0x68
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
            goto LAB_18119e7f4;
          }
        }
        uVar3 = CONCAT31((int3)((uint32)iVar1 >> 8),iVar1 == 1);
        LAB_18119e7f4:
        UIPlayAnimation.Play(this,isOver,uVar3,0);
    }

    // Token : 0x60001B2
    // RVA   : 0x119E820   Offset: 0x119DC20   Length: 0xE3
    private void OnPress(bool isPressed)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        int iVar1;
        bool cVar2;
        cVar2 = Behaviour.get_enabled(this,0);
        if (cVar2) {
          if (*(int *)(pStatics + 212) != -2) {
            if (*(int *)(pStatics + 212) != -3) {
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

    // Token : 0x60001B3
    // RVA   : 0x119DD40   Offset: 0x119D140   Length: 0xB2
    private void OnClick()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        bool cVar1;
        if (*(int *)(pStatics + 212) != -2) {
          if (*(int *)(pStatics + 212) != -3) {
            cVar1 = Behaviour.get_enabled(this,0);
            if ((cVar1) && (this.trigger == null)) {
              UIPlayAnimation.Play(this,1,0,0);
            }
          }
        }
    }

    // Token : 0x60001B4
    // RVA   : 0x119DF10   Offset: 0x119D310   Length: 0xB2
    private void OnDoubleClick()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        bool cVar1;
        if (*(int *)(pStatics + 212) != -2) {
          if (*(int *)(pStatics + 212) != -3) {
            cVar1 = Behaviour.get_enabled(this,0);
            if ((cVar1) && (this.trigger == 10)) {
              UIPlayAnimation.Play(this,1,0,0);
            }
          }
        }
    }

    // Token : 0x60001B5
    // RVA   : 0x119E910   Offset: 0x119DD10   Length: 0x68
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
            goto LAB_18119e954;
          }
        }
        uVar3 = CONCAT31((int3)((uint32)iVar1 >> 8),iVar1 == 1);
        LAB_18119e954:
        UIPlayAnimation.Play(this,isSelected,uVar3,0);
    }

    // Token : 0x60001B6
    // RVA   : 0x119E980   Offset: 0x119DD80   Length: 0x1DE
    private void OnToggle()
    {
        var pStatics = *(int64*)(DAT_181db04f8 + 184);
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
            if (cVar3) goto LAB_18119eadc;
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
        LAB_18119eadc:
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

    // Token : 0x60001B7
    // RVA   : 0x119E0C0   Offset: 0x119D4C0   Length: 0x111
    private void OnDragOver()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        cVar3 = Behaviour.get_enabled(this,0);
        if ((cVar3) && ((this.trigger == 2 || (this.trigger == 1)))) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181daf678 + 184) + 224);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
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

    // Token : 0x60001B8
    // RVA   : 0x119DFD0   Offset: 0x119D3D0   Length: 0xE8
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

    // Token : 0x60001B9
    // RVA   : 0x119E1E0   Offset: 0x119D5E0   Length: 0xFD
    private void OnDrop(GameObject go)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        cVar3 = Behaviour.get_enabled(this,0);
        if ((cVar3) && (this.trigger == 2)) {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181daf678 + 184) + 224);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
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

    // Token : 0x60001BA
    // RVA   : 0x119EE70   Offset: 0x119E270   Length: 0xB
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
          uVar5 = new OnTooltipCB(this,DAT_181dc6008,0);
          EventDelegate.Add(uVar4,uVar5,1);
          iVar7 = iVar7 + 1;
          lVar1 = this.onFinished;
        }
    }

    // Token : 0x60001BB
    // RVA   : 0x119EB80   Offset: 0x119DF80   Length: 0x2E3
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
          uVar5 = new OnTooltipCB(this,DAT_181dc6008,0);
          EventDelegate.Add(uVar4,uVar5,1);
          iVar7 = iVar7 + 1;
          lVar1 = this.onFinished;
        }
    }

    // Token : 0x60001BC
    // RVA   : 0x119EB60   Offset: 0x119DF60   Length: 0xF
    public void PlayForward()
    {
        void FUN_18119eb60(uint64 this)
        {
        UIPlayAnimation.Play(this,1,1,0);
    }

    // Token : 0x60001BD
    // RVA   : 0x119EB70   Offset: 0x119DF70   Length: 0xD
    public void PlayReverse()
    {
        void FUN_18119eb70(uint64 this)
        {
        UIPlayAnimation.Play(this,0,1,0);
    }

    // Token : 0x60001BE
    // RVA   : 0x119E5E0   Offset: 0x119D9E0   Length: 0x1C4
    private void OnFinished()
    {
        ulong uVar1;
        long lVar3;
        bool cVar5;
        uVar1 = **(uint64 **)(DAT_181dafef8 + 184);
        cVar5 = Object.op_Equality(uVar1,0,0);
        if (cVar5) {
          plVar2 = *(int64 **)(DAT_181dafef8 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
          uVar1 = this.onFinished;
          EventDelegate.Execute(uVar1,0);
          lVar3 = this.eventReceiver;
          cVar5 = Object.op_Inequality(lVar3,0,0);
          if (cVar5) {
            cVar5 = FUN_180d755b0(this.callWhenFinished,0);
            if (!cVar5) {
              if (*plVar2 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              GameObject.SendMessage(*plVar2,this.callWhenFinished,1);
            }
          }
          *plVar2 = 0;
          il2cpp_internal(plVar2,0);
          puVar4 = *(uint64 **)(DAT_181dafef8 + 184);
          *puVar4 = 0;
          il2cpp_internal(puVar4,0);
        }
    }

    // Token : 0x60001BF
    // RVA   : 0x119F070   Offset: 0x119E470   Length: 0x7D
    public void /*ctor*/()
    {
        ulong uVar1;
        this.playDirection = 1;
        uVar1 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar1,DAT_181d85ea0);
        this.onFinished = uVar1;
        FUN_18044ef50(this,0);
    }

    // Token : 0x60001C0
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private static void /*cctor*/()
    {
    }

}
