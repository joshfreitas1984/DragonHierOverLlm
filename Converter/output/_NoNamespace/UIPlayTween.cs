// ============================================================
// Type  : UIPlayTween
// Token : 0x2000054
// ============================================================

public class UIPlayTween
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40001EE
    public static UIPlayTween current;

    // Token: 0x40001EF
    public GameObject tweenTarget;

    // Token: 0x40001F0
    public int tweenGroup;

    // Token: 0x40001F1
    public Trigger trigger;

    // Token: 0x40001F2
    public Direction playDirection;

    // Token: 0x40001F3
    public bool resetOnPlay;

    // Token: 0x40001F4
    public bool resetIfDisabled;

    // Token: 0x40001F5
    public EnableCondition ifDisabledOnPlay;

    // Token: 0x40001F6
    public DisableCondition disableWhenFinished;

    // Token: 0x40001F7
    public bool includeChildren;

    // Token: 0x40001F8
    public List<EventDelegate> onFinished;

    // Token: 0x40001F9
    private GameObject eventReceiver;

    // Token: 0x40001FA
    private string callWhenFinished;

    // Token: 0x40001FB
    private UITweener[] mTweens;

    // Token: 0x40001FC
    private bool mStarted;

    // Token: 0x40001FD
    private int mActive;

    // Token: 0x40001FE
    private bool mActivated;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60001CB
    // RVA   : 0x119FDB0   Offset: 0x119F1B0   Length: 0xCC
    private void Awake()
    {
        ulong uVar1;
        bool cVar2;
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

    // Token : 0x60001CC
    // RVA   : 0x11A1030   Offset: 0x11A0430   Length: 0x8F
    private void Start()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.tweenTarget;
        this.mStarted = 1;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          this.tweenTarget = uVar2;
        }
    }

    // Token : 0x60001CD
    // RVA   : 0x11A0320   Offset: 0x119F720   Length: 0x2A7
    private void OnEnable()
    {
        byte uVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        if (this.mStarted) {
          uVar4 = Component.get_gameObject(this,0);
          uVar1 = UICamera.IsHighlighted(uVar4,0);
          UIPlayTween.OnHover(this,uVar1,0);
        }
        if (UICamera.currentTouch != null) {
          iVar3 = this.trigger;
          if ((iVar3 == 2) || (iVar3 == 5)) {
            lVar6 = UICamera.currentTouch;
            if (lVar6 == null) goto LAB_1811a05c2;
            uVar4 = lVar6.pressed;
            uVar5 = Component.get_gameObject(this,0);
            uVar1 = Object.op_Equality(uVar4,uVar5,0);
            this.mActivated = uVar1;
            iVar3 = this.trigger;
          }
          if ((iVar3 - 1U & 0xfffffffd) == 0) {
            lVar6 = UICamera.currentTouch;
            if (lVar6 == null) goto LAB_1811a05c2;
            uVar4 = lVar6.current;
            uVar5 = Component.get_gameObject(this,0);
            uVar1 = Object.op_Equality(uVar4,uVar5,0);
            this.mActivated = uVar1;
          }
        }
        lVar6 = Component.GetComponent(this,DAT_181d96ff8);
        cVar2 = Object.op_Inequality(lVar6,0,0);
        if (cVar2) {
          if (lVar6 == null) {
        LAB_1811a05c2:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = lVar6.pressed;
          uVar5 = new OnTooltipCB(this,DAT_181dc63d8,0);
          EventDelegate.Add(uVar4,uVar5,0);
        }
    }

    // Token : 0x60001CE
    // RVA   : 0x11A0100   Offset: 0x119F500   Length: 0x10D
    private void OnDisable()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        lVar2 = Component.GetComponent(this,DAT_181d96ff8);
        cVar3 = Object.op_Inequality(lVar2,0,0);
        if (cVar3) {
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = *(uint64 *)(lVar2 + 80);
          uVar4 = new OnTooltipCB(this,DAT_181dc63d8,0);
          EventDelegate.Remove(uVar1,uVar4,0);
        }
    }

    // Token : 0x60001CF
    // RVA   : 0x11A0290   Offset: 0x119F690   Length: 0x8C
    private void OnDragOver()
    {
        bool cVar1;
        if (this.trigger == 1) {
          cVar1 = Behaviour.get_enabled(this,0);
          if (((cVar1) && ((this.trigger - 1U & 0xfffffffd) == 0)) &&
             (!this.mActivated)) {
            this.mActivated = this.trigger == 1;
            UIPlayTween.Play(this,1,0);
          }
        }
    }

    // Token : 0x60001D0
    // RVA   : 0x11A0750   Offset: 0x119FB50   Length: 0x249
    private void OnHover(bool isOver)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        int iVar6;
        cVar1 = Behaviour.get_enabled(this,0);
        if (!cVar1) {
          return;
        }
        iVar6 = this.trigger;
        plVar7 = (int64 *)0;
        if (iVar6 != 1) {
          cVar1 = false;
          if (iVar6 == 3) {
            cVar1 = isOver;
          }
          if (!cVar1) {
            if (iVar6 != 4) {
              return;
            }
            if (isOver) {
              return;
            }
          }
        }
        if (isOver == this.mActivated) {
          return;
        }
        if (!isOver) {
          uVar2 = UICamera.get_hoveredObject(0);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (!cVar1) goto LAB_1811a0961;
          lVar3 = UICamera.get_hoveredObject(0);
          if (lVar3 == null) {
        LAB_1811a0988:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = GameObject.get_transform(lVar3,0);
          uVar2 = Component.get_transform(this,0);
          if (lVar3 == null) goto LAB_1811a0988;
          cVar1 = Transform.IsChildOf(lVar3,uVar2,0);
          if (!cVar1) goto LAB_1811a0961;
          uVar2 = UICamera.onHover;
          uVar4 = new OnTooltipCB(this,DAT_181dc62c8,0);
          plVar5 = (int64 *)Delegate.Combine(uVar2,uVar4,0);
          if (plVar5 != (int64 *)0) {
            if (*plVar5 == DAT_181d8d250) {
              plVar7 = plVar5;
            }
            if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar5,DAT_181d8d250);
            }
          }
          UICamera.onHover = plVar7;
          isOver = true;
          if (this.mActivated) {
            return;
          }
          iVar6 = this.trigger;
        }
        plVar7 = (int64 *)(uint64)(iVar6 == 1);
        LAB_1811a0961:
        this.mActivated = (char)plVar7;
        UIPlayTween.Play(this,isOver,0);
    }

    // Token : 0x60001D1
    // RVA   : 0x119FE80   Offset: 0x119F280   Length: 0x231
    private void CustomHoverListener(GameObject go, bool isOver)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        cVar1 = Object.op_Implicit(this,0);
        if (cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          cVar1 = Object.op_Implicit(uVar2,0);
          if (cVar1) {
            cVar1 = Object.op_Implicit(go,0);
            if (cVar1) {
              cVar1 = Object.op_Equality(go,uVar2,0);
              if (cVar1) {
                return;
              }
              if (go == null) {
        LAB_1811a00ac:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar3 = GameObject.get_transform(go,0);
              uVar2 = Component.get_transform(this,0);
              if (lVar3 == null) goto LAB_1811a00ac;
              cVar1 = Transform.IsChildOf(lVar3,uVar2,0);
              if (cVar1) {
                return;
              }
            }
          }
          UIPlayTween.OnHover(this,0,0);
          uVar2 = UICamera.onHover;
          uVar4 = new OnTooltipCB(this,DAT_181dc62c8,0);
          plVar5 = (int64 *)Delegate.Remove(uVar2,uVar4,0);
          plVar6 = (int64 *)0;
          if (plVar5 != (int64 *)0) {
            if (*plVar5 == DAT_181d8d250) {
              plVar6 = plVar5;
            }
            if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar5,DAT_181d8d250);
            }
          }
          UICamera.onHover = plVar6;
        }
    }

    // Token : 0x60001D2
    // RVA   : 0x11A0250   Offset: 0x119F650   Length: 0x36
    private void OnDragOut()
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if ((cVar1) && (this.mActivated)) {
          this.mActivated = 0;
          UIPlayTween.Play(this,0,0);
          return;
        }
    }

    // Token : 0x60001D3
    // RVA   : 0x11A09A0   Offset: 0x119FDA0   Length: 0x6B
    private void OnPress(bool isPressed)
    {
        int iVar1;
        bool cVar2;
        cVar2 = Behaviour.get_enabled(this,0);
        if (!cVar2) {
          return;
        }
        iVar1 = this.trigger;
        bVar3 = false;
        if (iVar1 != 2) {
          cVar2 = bVar3;
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
            goto LAB_1811a09ee;
          }
        }
        if (isPressed) {
          bVar3 = iVar1 == 2;
        }
        LAB_1811a09ee:
        this.mActivated = bVar3;
        UIPlayTween.Play(this,isPressed,0);
    }

    // Token : 0x60001D4
    // RVA   : 0x11A00C0   Offset: 0x119F4C0   Length: 0x32
    private void OnClick()
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if ((cVar1) && (this.trigger == null)) {
          UIPlayTween.Play(this,1,0);
          return;
        }
    }

    // Token : 0x60001D5
    // RVA   : 0x11A0210   Offset: 0x119F610   Length: 0x32
    private void OnDoubleClick()
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if ((cVar1) && (this.trigger == 10)) {
          UIPlayTween.Play(this,1,0);
          return;
        }
    }

    // Token : 0x60001D6
    // RVA   : 0x11A0A10   Offset: 0x119FE10   Length: 0x6B
    private void OnSelect(bool isSelected)
    {
        int iVar1;
        bool cVar2;
        cVar2 = Behaviour.get_enabled(this,0);
        if (!cVar2) {
          return;
        }
        iVar1 = this.trigger;
        bVar3 = false;
        if (iVar1 != 11) {
          cVar2 = bVar3;
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
            goto LAB_1811a0a5e;
          }
        }
        if (isSelected) {
          bVar3 = iVar1 == 11;
        }
        LAB_1811a0a5e:
        this.mActivated = bVar3;
        UIPlayTween.Play(this,isSelected,0);
    }

    // Token : 0x60001D7
    // RVA   : 0x11A0A80   Offset: 0x119FE80   Length: 0x1B5
    private void OnToggle()
    {
        var pStatics = *(int64*)(DAT_181db0510 + 184);
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
            if (cVar3) goto LAB_1811a0bd8;
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
        LAB_1811a0bd8:
        lVar2 = *(int64 *)(pStatics + 8);
        if (lVar2 != null) {
          uVar4 = UIToggle.get_isChecked(lVar2,0);
          UIPlayTween.Play(this,uVar4,0);
          return;
        }
    }

    // Token : 0x60001D8
    // RVA   : 0x11A10C0   Offset: 0x11A04C0   Length: 0x145
    private void Update()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        int iVar4;
        ulong uVar5;
        uint uVar6;
        uint uVar7;
        if (this.disableWhenFinished == null) {
          return;
        }
        if (this.mTweens == null) {
          return;
        }
        uVar7 = 1;
        iVar1 = *(int *)(this.mTweens + 24);
        uVar6 = 0;
        if (0 < iVar1) {
          do {
            lVar2 = this.mTweens;
            if (lVar2 == null) {
        LAB_1811a11f0:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(uint32 *)(lVar2 + 24) <= uVar6) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            lVar2 = lVar2[uVar6];
            if (lVar2 == null) goto LAB_1811a11f0;
            if (*(int *)(lVar2 + 56) == this.tweenGroup) {
              cVar3 = Behaviour.get_enabled(lVar2);
              if (cVar3) {
                return;
              }
              iVar4 = UITweener.get_direction(lVar2);
              if (iVar4 != this.disableWhenFinished) {
                uVar7 = 0;
              }
            }
            uVar6 = uVar6 + 1;
          } while ((int)uVar6 < iVar1);
          if (!((char)!uVar7))
          {
            }
            uVar5 = this.tweenTarget;
            NGUITools.SetActive(uVar5,0,0);
          }
        this.mTweens = 0;
    }

    // Token : 0x60001D9
    // RVA   : 0x11A0C40   Offset: 0x11A0040   Length: 0xA
    public void Play()
    {
        long lVar1;
        bool cVar5;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        int iVar9;
        uVar7 = this.tweenTarget;
        uVar8 = 0;
        *(uint32 *)(this + 100) = 0;
        cVar5 = Object.op_Equality(uVar7,0,0);
        if (!cVar5) {
          lVar6 = this.tweenTarget;
        }
        else {
          lVar6 = Component.get_gameObject(this,0);
        }
        cVar5 = NGUITools.GetActive(lVar6,0);
        if (!cVar5) {
          if (this.ifDisabledOnPlay != 1) {
            return;
          }
          NGUITools.SetActive(lVar6,1,0);
        }
        if (lVar6 != null) {
          if (!this.includeChildren) {
            uVar7 = GameObject.GetComponents(lVar6,DAT_181d74f60);
          }
          else {
            uVar7 = FUN_180967b70(lVar6,DAT_181d75538);
          }
          this.mTweens = uVar7;
          if (this.mTweens != null) {
            lVar1 = *(int64 *)(this.mTweens + 24);
            if (lVar1 == null) {
              if (this.disableWhenFinished != null) {
                uVar7 = this.tweenTarget;
                NGUITools.SetActive(uVar7,0,0);
              }
            }
            else {
              bVar4 = false;
              bVar3 = param_2 ^ 1;
              if (this.playDirection != -1) {
                bVar3 = param_2;
              }
              iVar9 = (int)lVar1;
              if (0 < iVar9) {
                do {
                  lVar1 = this.mTweens;
                  if (lVar1 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar1 + 24) <= uVar8) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar2 = lVar1[uVar8];
                  if (plVar2 == (int64 *)0) throw; // [null/range check failed]
                  if ((int)plVar2[7] == this.tweenGroup) {
                    if (!bVar4) {
                      cVar5 = NGUITools.GetActive(lVar6,0);
                      if (!cVar5) {
                        bVar4 = true;
                        NGUITools.SetActive(lVar6,1,0);
                      }
                    }
                    *(int *)(this + 100) = *(int *)(this + 100) + 1;
                    if (this.playDirection == null) {
                      lVar1 = plVar2[8];
                      uVar7 = new OnTooltipCB(this,DAT_181dc6350,0);
                      EventDelegate.Add(lVar1);
                      UITweener.Toggle(plVar2);
                    }
                    else {
                      if ((this.resetOnPlay) ||
                         ((this.resetIfDisabled &&
                          (cVar5 = Behaviour.get_enabled(plVar2,0), !cVar5)))) {
                        (**(code **)(*plVar2 + 0x188))(plVar2,bVar3,*(uint64 *)(*plVar2 + 400));
                        UITweener.ResetToBeginning(plVar2,0);
                      }
                      lVar1 = plVar2[8];
                      uVar7 = new OnTooltipCB(this,DAT_181dc6350,0);
                      EventDelegate.Add(lVar1,uVar7,1);
                      (**(code **)(*plVar2 + 0x188))(plVar2);
                    }
                  }
                  uVar8 = uVar8 + 1;
                } while ((int)uVar8 < iVar9);
              }
            }
            return;
          }
        }
    }

    // Token : 0x60001DA
    // RVA   : 0x11A0C50   Offset: 0x11A0050   Length: 0x3D7
    public void Play(bool forward)
    {
        long lVar1;
        bool cVar5;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        int iVar9;
        uVar7 = this.tweenTarget;
        uVar8 = 0;
        *(uint32 *)(this + 100) = 0;
        cVar5 = Object.op_Equality(uVar7,0,0);
        if (!cVar5) {
          lVar6 = this.tweenTarget;
        }
        else {
          lVar6 = Component.get_gameObject(this,0);
        }
        cVar5 = NGUITools.GetActive(lVar6,0);
        if (!cVar5) {
          if (this.ifDisabledOnPlay != 1) {
            return;
          }
          NGUITools.SetActive(lVar6,1,0);
        }
        if (lVar6 != null) {
          if (!this.includeChildren) {
            uVar7 = GameObject.GetComponents(lVar6,DAT_181d74f60);
          }
          else {
            uVar7 = FUN_180967b70(lVar6,DAT_181d75538);
          }
          this.mTweens = uVar7;
          if (this.mTweens != null) {
            lVar1 = *(int64 *)(this.mTweens + 24);
            if (lVar1 == null) {
              if (this.disableWhenFinished != null) {
                uVar7 = this.tweenTarget;
                NGUITools.SetActive(uVar7,0,0);
              }
            }
            else {
              bVar4 = false;
              bVar3 = forward ^ 1;
              if (this.playDirection != -1) {
                bVar3 = forward;
              }
              iVar9 = (int)lVar1;
              if (0 < iVar9) {
                do {
                  lVar1 = this.mTweens;
                  if (lVar1 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar1 + 24) <= uVar8) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                  plVar2 = lVar1[uVar8];
                  if (plVar2 == (int64 *)0) throw; // [null/range check failed]
                  if ((int)plVar2[7] == this.tweenGroup) {
                    if (!bVar4) {
                      cVar5 = NGUITools.GetActive(lVar6,0);
                      if (!cVar5) {
                        bVar4 = true;
                        NGUITools.SetActive(lVar6,1,0);
                      }
                    }
                    *(int *)(this + 100) = *(int *)(this + 100) + 1;
                    if (this.playDirection == null) {
                      lVar1 = plVar2[8];
                      uVar7 = new OnTooltipCB(this,DAT_181dc6350,0);
                      EventDelegate.Add(lVar1);
                      UITweener.Toggle(plVar2);
                    }
                    else {
                      if ((this.resetOnPlay) ||
                         ((this.resetIfDisabled &&
                          (cVar5 = Behaviour.get_enabled(plVar2,0), !cVar5)))) {
                        (**(code **)(*plVar2 + 0x188))(plVar2,bVar3,*(uint64 *)(*plVar2 + 400));
                        UITweener.ResetToBeginning(plVar2,0);
                      }
                      lVar1 = plVar2[8];
                      uVar7 = new OnTooltipCB(this,DAT_181dc6350,0);
                      EventDelegate.Add(lVar1,uVar7,1);
                      (**(code **)(*plVar2 + 0x188))(plVar2);
                    }
                  }
                  uVar8 = uVar8 + 1;
                } while ((int)uVar8 < iVar9);
              }
            }
            return;
          }
        }
    }

    // Token : 0x60001DB
    // RVA   : 0x11A05D0   Offset: 0x119F9D0   Length: 0x173
    private void OnFinished()
    {
        ulong uVar2;
        long lVar4;
        bool cVar6;
        this.mActive = *piVar1 + -1;
        if (*piVar1 == 0) {
          uVar2 = **(uint64 **)(DAT_181daff90 + 184);
          cVar6 = Object.op_Equality(uVar2,0,0);
          if (cVar6) {
            plVar3 = *(int64 **)(DAT_181daff90 + 184);
            *plVar3 = this;
            il2cpp_internal(plVar3,this);
            uVar2 = this.onFinished;
            EventDelegate.Execute(uVar2,0);
            lVar4 = this.eventReceiver;
            cVar6 = Object.op_Inequality(lVar4,0,0);
            if ((cVar6) &&
               (cVar6 = FUN_180d75bc0(this.callWhenFinished,0), !cVar6)) {
              if (*plVar3 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              GameObject.SendMessage(*plVar3,this.callWhenFinished,1);
            }
            *plVar3 = 0;
            il2cpp_internal(plVar3,0);
            puVar5 = *(uint64 **)(DAT_181daff90 + 184);
            *puVar5 = 0;
            il2cpp_internal(puVar5,0);
          }
        }
    }

    // Token : 0x60001DC
    // RVA   : 0x11A1210   Offset: 0x11A0610   Length: 0x7D
    public void /*ctor*/()
    {
        ulong uVar1;
        this.playDirection = 1;
        uVar1 = il2cpp_internal(DAT_181d92670);
        FUN_181330100(uVar1,DAT_181d85eb8);
        this.onFinished = uVar1;
        FUN_18044ef50(this,0);
    }

}
