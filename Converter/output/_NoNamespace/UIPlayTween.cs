// ============================================================
// Type  : UIPlayTween
// Token : 0x2000053
// ============================================================

public class UIPlayTween
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40001D2
    public static UIPlayTween current;

    // Token: 0x40001D3
    public GameObject tweenTarget;

    // Token: 0x40001D4
    public int tweenGroup;

    // Token: 0x40001D5
    public Trigger trigger;

    // Token: 0x40001D6
    public Direction playDirection;

    // Token: 0x40001D7
    public bool resetOnPlay;

    // Token: 0x40001D8
    public bool resetIfDisabled;

    // Token: 0x40001D9
    public EnableCondition ifDisabledOnPlay;

    // Token: 0x40001DA
    public DisableCondition disableWhenFinished;

    // Token: 0x40001DB
    public bool includeChildren;

    // Token: 0x40001DC
    public List<EventDelegate> onFinished;

    // Token: 0x40001DD
    private GameObject eventReceiver;

    // Token: 0x40001DE
    private string callWhenFinished;

    // Token: 0x40001DF
    private UITweener[] mTweens;

    // Token: 0x40001E0
    private bool mStarted;

    // Token: 0x40001E1
    private int mActive;

    // Token: 0x40001E2
    private bool mActivated;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60001B3
    // RVA   : 0x1579540   Offset: 0x1577D40   Length: 0xCC
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

    // Token : 0x60001B4
    // RVA   : 0x157A7C0   Offset: 0x1578FC0   Length: 0x8F
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

    // Token : 0x60001B5
    // RVA   : 0x1579AB0   Offset: 0x15782B0   Length: 0x2A7
    private void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
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
        if (*(int64 *)(pStatics + 224) != 0) {
          iVar3 = this.trigger;
          if ((iVar3 == 2) || (iVar3 == 5)) {
            lVar6 = *(int64 *)(pStatics + 224);
            if (lVar6 == null) goto LAB_181579d52;
            uVar4 = *(uint64 *)(lVar6 + 80);
            uVar5 = Component.get_gameObject(this,0);
            uVar1 = Object.op_Equality(uVar4,uVar5,0);
            this.mActivated = uVar1;
            iVar3 = this.trigger;
          }
          if ((iVar3 - 1U & 0xfffffffd) == 0) {
            lVar6 = *(int64 *)(pStatics + 224);
            if (lVar6 == null) goto LAB_181579d52;
            uVar4 = *(uint64 *)(lVar6 + 72);
            uVar5 = Component.get_gameObject(this,0);
            uVar1 = Object.op_Equality(uVar4,uVar5,0);
            this.mActivated = uVar1;
          }
        }
        lVar6 = Component.GetComponent(this,DAT_181d6e740);
        cVar2 = Object.op_Inequality(lVar6,0,0);
        if (cVar2) {
          if (lVar6 == null) {
        LAB_181579d52:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = *(uint64 *)(lVar6 + 80);
          uVar5 = new OnTooltipCB(this,DAT_181d9cf38,0);
          EventDelegate.Add(uVar4,uVar5,0);
        }
    }

    // Token : 0x60001B6
    // RVA   : 0x1579890   Offset: 0x1578090   Length: 0x10D
    private void OnDisable()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        lVar2 = Component.GetComponent(this,DAT_181d6e740);
        cVar3 = Object.op_Inequality(lVar2,0,0);
        if (cVar3) {
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = *(uint64 *)(lVar2 + 80);
          uVar4 = new OnTooltipCB(this,DAT_181d9cf38,0);
          EventDelegate.Remove(uVar1,uVar4,0);
        }
    }

    // Token : 0x60001B7
    // RVA   : 0x1579A20   Offset: 0x1578220   Length: 0x8C
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

    // Token : 0x60001B8
    // RVA   : 0x1579EE0   Offset: 0x15786E0   Length: 0x249
    private void OnHover(bool isOver)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
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
          if (!cVar1) goto LAB_18157a0f1;
          lVar3 = UICamera.get_hoveredObject(0);
          if (lVar3 == null) {
        LAB_18157a118:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = GameObject.get_transform(lVar3,0);
          uVar2 = Component.get_transform(this,0);
          if (lVar3 == null) goto LAB_18157a118;
          cVar1 = Transform.IsChildOf(lVar3,uVar2,0);
          if (!cVar1) goto LAB_18157a0f1;
          uVar2 = *(uint64 *)(pStatics + 0x110);
          uVar4 = new OnTooltipCB(this,DAT_181d9ce28,0);
          plVar5 = (int64 *)Delegate.Combine(uVar2,uVar4,0);
          if (plVar5 != (int64 *)0) {
            if (*plVar5 == DAT_181d67e90) {
              plVar7 = plVar5;
            }
            if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar5,DAT_181d67e90);
            }
          }
          *(int64 **)(pStatics + 0x110) = plVar7;
          isOver = true;
          if (this.mActivated) {
            return;
          }
          iVar6 = this.trigger;
        }
        plVar7 = (int64 *)(uint64)(iVar6 == 1);
        LAB_18157a0f1:
        this.mActivated = (char)plVar7;
        UIPlayTween.Play(this,isOver,0);
    }

    // Token : 0x60001B9
    // RVA   : 0x1579610   Offset: 0x1577E10   Length: 0x231
    private void CustomHoverListener(GameObject go, bool isOver)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
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
        LAB_18157983c:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar3 = GameObject.get_transform(go,0);
              uVar2 = Component.get_transform(this,0);
              if (lVar3 == null) goto LAB_18157983c;
              cVar1 = Transform.IsChildOf(lVar3,uVar2,0);
              if (cVar1) {
                return;
              }
            }
          }
          UIPlayTween.OnHover(this,0,0);
          uVar2 = *(uint64 *)(pStatics + 0x110);
          uVar4 = new OnTooltipCB(this,DAT_181d9ce28,0);
          plVar5 = (int64 *)Delegate.Remove(uVar2,uVar4,0);
          plVar6 = (int64 *)0;
          if (plVar5 != (int64 *)0) {
            if (*plVar5 == DAT_181d67e90) {
              plVar6 = plVar5;
            }
            if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar5,DAT_181d67e90);
            }
          }
          *(int64 **)(pStatics + 0x110) = plVar6;
        }
    }

    // Token : 0x60001BA
    // RVA   : 0x15799E0   Offset: 0x15781E0   Length: 0x36
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

    // Token : 0x60001BB
    // RVA   : 0x157A130   Offset: 0x1578930   Length: 0x6B
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
            goto LAB_18157a17e;
          }
        }
        if (isPressed) {
          bVar3 = iVar1 == 2;
        }
        LAB_18157a17e:
        this.mActivated = bVar3;
        UIPlayTween.Play(this,isPressed,0);
    }

    // Token : 0x60001BC
    // RVA   : 0x1579850   Offset: 0x1578050   Length: 0x32
    private void OnClick()
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if ((cVar1) && (this.trigger == null)) {
          UIPlayTween.Play(this,1,0);
          return;
        }
    }

    // Token : 0x60001BD
    // RVA   : 0x15799A0   Offset: 0x15781A0   Length: 0x32
    private void OnDoubleClick()
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if ((cVar1) && (this.trigger == 10)) {
          UIPlayTween.Play(this,1,0);
          return;
        }
    }

    // Token : 0x60001BE
    // RVA   : 0x157A1A0   Offset: 0x15789A0   Length: 0x6B
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
            goto LAB_18157a1ee;
          }
        }
        if (isSelected) {
          bVar3 = iVar1 == 11;
        }
        LAB_18157a1ee:
        this.mActivated = bVar3;
        UIPlayTween.Play(this,isSelected,0);
    }

    // Token : 0x60001BF
    // RVA   : 0x157A210   Offset: 0x1578A10   Length: 0x1B5
    private void OnToggle()
    {
        var pStatics = *(int64*)(DAT_181d8b2d8 + 184);
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
            if (cVar3) goto LAB_18157a368;
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
        LAB_18157a368:
        lVar2 = *(int64 *)(pStatics + 8);
        if (lVar2 != null) {
          uVar4 = UIToggle.get_isChecked(lVar2,0);
          UIPlayTween.Play(this,uVar4,0);
          return;
        }
    }

    // Token : 0x60001C0
    // RVA   : 0x157A850   Offset: 0x1579050   Length: 0x145
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
        LAB_18157a980:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(uint32 *)(lVar2 + 24) <= uVar6) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            lVar2 = lVar2[uVar6];
            if (lVar2 == null) goto LAB_18157a980;
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

    // Token : 0x60001C1
    // RVA   : 0x157A3D0   Offset: 0x1578BD0   Length: 0xA
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
            uVar7 = GameObject.GetComponents(lVar6,DAT_181da2c30);
          }
          else {
            uVar7 = FUN_180956bf0(lVar6,DAT_181da31b0);
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
                      uVar7 = new OnTooltipCB(this,DAT_181d9ceb0,0);
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
                      uVar7 = new OnTooltipCB(this,DAT_181d9ceb0,0);
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

    // Token : 0x60001C2
    // RVA   : 0x157A3E0   Offset: 0x1578BE0   Length: 0x3D7
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
            uVar7 = GameObject.GetComponents(lVar6,DAT_181da2c30);
          }
          else {
            uVar7 = FUN_180956bf0(lVar6,DAT_181da31b0);
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
                      uVar7 = new OnTooltipCB(this,DAT_181d9ceb0,0);
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
                      uVar7 = new OnTooltipCB(this,DAT_181d9ceb0,0);
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

    // Token : 0x60001C3
    // RVA   : 0x1579D60   Offset: 0x1578560   Length: 0x173
    private void OnFinished()
    {
        ulong uVar2;
        long lVar4;
        bool cVar6;
        this.mActive = *piVar1 + -1;
        if (*piVar1 == 0) {
          uVar2 = **(uint64 **)(DAT_181d8ad58 + 184);
          cVar6 = Object.op_Equality(uVar2,0,0);
          if (cVar6) {
            plVar3 = *(int64 **)(DAT_181d8ad58 + 184);
            *plVar3 = this;
            il2cpp_internal(plVar3,this);
            uVar2 = this.onFinished;
            EventDelegate.Execute(uVar2,0);
            lVar4 = this.eventReceiver;
            cVar6 = Object.op_Inequality(lVar4,0,0);
            if ((cVar6) &&
               (cVar6 = FUN_180d6ca90(this.callWhenFinished,0), !cVar6)) {
              if (*plVar3 == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              GameObject.SendMessage(*plVar3,this.callWhenFinished,1);
            }
            *plVar3 = 0;
            il2cpp_internal(plVar3,0);
            puVar5 = *(uint64 **)(DAT_181d8ad58 + 184);
            *puVar5 = 0;
            il2cpp_internal(puVar5,0);
          }
        }
    }

    // Token : 0x60001C4
    // RVA   : 0x157A9A0   Offset: 0x15791A0   Length: 0x7D
    public void /*ctor*/()
    {
        ulong uVar1;
        this.playDirection = 1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onFinished = uVar1;
        FUN_18044ef50(this,0);
    }

}
