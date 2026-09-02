// ============================================================
// Type  : UIToggle
// Token : 0x200006E
// ============================================================

public class UIToggle
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400029B
    public static BetterList<UIToggle> list;

    // Token: 0x400029C
    public static UIToggle current;

    // Token: 0x400029D
    public int group;

    // Token: 0x400029E
    public UIWidget activeSprite;

    // Token: 0x400029F
    public bool invertSpriteState;

    // Token: 0x40002A0
    public Animation activeAnimation;

    // Token: 0x40002A1
    public Animator animator;

    // Token: 0x40002A2
    public UITweener tween;

    // Token: 0x40002A3
    public bool startsActive;

    // Token: 0x40002A4
    public bool instantTween;

    // Token: 0x40002A5
    public bool optionCanBeNone;

    // Token: 0x40002A6
    public List<EventDelegate> onChange;

    // Token: 0x40002A7
    public Validate validator;

    // Token: 0x40002A8
    private UISprite checkSprite;

    // Token: 0x40002A9
    private Animation checkAnimation;

    // Token: 0x40002AA
    private GameObject eventReceiver;

    // Token: 0x40002AB
    private string functionName;

    // Token: 0x40002AC
    private bool startsChecked;

    // Token: 0x40002AD
    private bool mIsActive;

    // Token: 0x40002AE
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000280
    // RVA   : 0x16996A0   Offset: 0x1697EA0   Length: 0x16
    public bool get_value()
    {
        if (this.mStarted) {
          return this.mIsActive;
        }
        return this.startsActive;
    }

    // Token : 0x6000281
    // RVA   : 0x16997D0   Offset: 0x1697FD0   Length: 0x2F
    public void set_value(bool value)
    {
        void FUN_1816997d0(int64 this,char value)
        {
        if (!this.mStarted) {
          this.startsActive = value;
        }
        else {
          if (this.group == null) {
            value = true;
          }
          if ((value) || (this.optionCanBeNone)) {
            UIToggle.Set();
            return;
          }
        }
    }

    // Token : 0x6000282
    // RVA   : 0x16996C0   Offset: 0x1697EC0   Length: 0x105
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

    // Token : 0x6000283
    // RVA   : 0x16996A0   Offset: 0x1697EA0   Length: 0x16
    public bool get_isChecked()
    {
        if (this.mStarted) {
          return this.mIsActive;
        }
        return this.startsActive;
    }

    // Token : 0x6000284
    // RVA   : 0x16997D0   Offset: 0x1697FD0   Length: 0x2F
    public void set_isChecked(bool value)
    {
        void FUN_1816997d0(int64 this,char value)
        {
        if (!this.mStarted) {
          this.startsActive = value;
        }
        else {
          if (this.group == null) {
            value = true;
          }
          if ((value) || (this.optionCanBeNone)) {
            UIToggle.Set();
            return;
          }
        }
    }

    // Token : 0x6000285
    // RVA   : 0x1698610   Offset: 0x1696E10   Length: 0x14B
    public static UIToggle GetActiveToggle(int group)
    {
        var pStatics = *(int64*)(DAT_181d8b2d8 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uint uVar4;
        uVar4 = 0;
        while( true ) {
          if (*pStatics == 0) break;
          if (*(int *)(*pStatics + 24) <= (int)uVar4) {
            return 0;
          }
          if ((*pStatics == 0) ||
             (lVar1 = *(int64 *)(*pStatics + 16)) == null) break;
          if (*(uint32 *)(lVar1 + 24) <= uVar4) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar1 = lVar1[uVar4];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (cVar2) {
            if (lVar1 == null) break;
            if ((*(int *)(lVar1 + 24) == group) && (*(char *)(lVar1 + 129) != false)) {
              return lVar1;
            }
          }
          uVar4 = uVar4 + 1;
        }
    }

    // Token : 0x6000286
    // RVA   : 0x16989B0   Offset: 0x16971B0   Length: 0x81
    private void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181d8b2d8 + 184);
        if (*pStatics != 0) {
          FUN_18154cb60(*pStatics,this,DAT_181d81f18);
          return;
        }
    }

    // Token : 0x6000287
    // RVA   : 0x1698920   Offset: 0x1697120   Length: 0x81
    private void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181d8b2d8 + 184);
        if (*pStatics != 0) {
          FUN_18154eb70(*pStatics,this,DAT_181d81f98);
          return;
        }
    }

    // Token : 0x6000288
    // RVA   : 0x16992D0   Offset: 0x1697AD0   Length: 0x2A5
    public void Start()
    {
        byte uVar1;
        ulong uVar2;
        bool cVar4;
        uint uVar5;
        if (this.mStarted) {
          return;
        }
        if (this.startsChecked) {
          this.startsChecked = 0;
          this.startsActive = 1;
        }
        cVar4 = Application.get_isPlaying(0);
        if (cVar4) {
          uVar1 = this.instantTween;
          this.mStarted = 1;
          this.instantTween = 1;
          this.mIsActive = !this.startsActive;
          UIToggle.Set(this,this.startsActive,1,0);
          this.instantTween = uVar1;
          return;
        }
        uVar2 = this.checkSprite;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (cVar4) {
          uVar2 = this.activeSprite;
          cVar4 = Object.op_Equality(uVar2,0,0);
          if (cVar4) {
            this.activeSprite = this.checkSprite;
            this.checkSprite = 0;
          }
        }
        uVar2 = this.checkAnimation;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (cVar4) {
          uVar2 = this.activeAnimation;
          cVar4 = Object.op_Equality(uVar2,0,0);
          if (cVar4) {
            this.activeAnimation = this.checkAnimation;
            this.checkAnimation = 0;
          }
        }
        cVar4 = Application.get_isPlaying(0);
        if (!cVar4) goto LAB_181699514;
        uVar2 = this.activeSprite;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (!cVar4) goto LAB_181699514;
        plVar3 = this.activeSprite;
        if (!this.invertSpriteState) {
          if (!(!this.startsActive))
          {
            uVar5 = 0x3f800000;
            }
            else if (!this.startsActive) {
            uVar5 = 0x3f800000;
            }
            else {
          }
          uVar5 = 0;
        }
        if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620(0,uVar5);
        }
        (**(code **)(*plVar3 + 0x1b8))(plVar3,uVar5,*(uint64 *)(*plVar3 + 0x1c0));
        LAB_181699514:
        uVar2 = this.onChange;
        cVar4 = EventDelegate.IsValid(uVar2,0);
        if (cVar4) {
          this.eventReceiver = 0;
          this.functionName = 0;
        }
    }

    // Token : 0x6000289
    // RVA   : 0x1698760   Offset: 0x1696F60   Length: 0x1B9
    private void OnClick()
    {
        bool cVar1;
        long lVar2;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          lVar2 = Component.GetComponent(this,DAT_181d6b340);
          cVar1 = Object.op_Inequality(lVar2,0,0);
          if (!cVar1) {
            lVar2 = Component.GetComponent(this,DAT_181d6b3c0);
            cVar1 = Object.op_Inequality(lVar2,0,0);
            if (!cVar1) {
              return;
            }
            if (lVar2 == null) {
        LAB_181698914:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar1 = Behaviour.get_enabled(lVar2,0);
          }
          else {
            if (lVar2 == null) goto LAB_181698914;
            cVar1 = Collider.get_enabled(lVar2,0);
          }
          if (cVar1) {
            if (*(int *)(*(int64 *)(DAT_181d8a458 + 184) + 212) != -2) {
              if (!this.mStarted) {
                this.startsActive = !this.startsActive;
                return;
              }
              bVar3 = !this.mIsActive;
              if ((this.group == null || bVar3) || (this.optionCanBeNone)) {
                UIToggle.Set(this,bVar3,1,0);
              }
            }
          }
        }
    }

    // Token : 0x600028A
    // RVA   : 0x1698A40   Offset: 0x1697240   Length: 0x886
    public void Set(bool state, bool notify)
    {
        var pStatics = *(int64*)(DAT_181d8b2d8 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        int iVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        byte[] local_res8 = new byte[8];
        ulong in_stack_ffffffffffffffb8;
        if ((this.validator != null) &&
           (cVar2 = Validate.Invoke(this.validator,state,0), !cVar2)) {
          return;
        }
        if (this.mStarted) {
          if (this.mIsActive == state) {
            return;
          }
          uVar10 = 0;
          bVar3 = 0;
          if (this.group != null) {
            bVar3 = state;
          }
          if (bVar3 != 0) {
            if (*pStatics == 0) throw; // [null/range check failed]
            iVar8 = *(int *)(*pStatics + 24);
            uVar9 = uVar10;
            if (0 < iVar8) {
              do {
                if ((*pStatics == 0) ||
                   (lVar6 = *(int64 *)(*pStatics + 16)) == null)
                throw; // [null/range check failed]
                if (*(uint32 *)(lVar6 + 24) <= uVar9) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                lVar6 = lVar6[uVar9];
                cVar2 = Object.op_Inequality(lVar6,this,0);
                if (cVar2) {
                  if (lVar6 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar6 + 24) == this.group) {
                    UIToggle.Set(lVar6,0,1,0);
                  }
                }
                if (*pStatics == 0) throw; // [null/range check failed]
                if (*(int *)(*pStatics + 24) == iVar8) {
                  uVar9 = uVar9 + 1;
                }
                else {
                  if (*pStatics == 0) throw; // [null/range check failed]
                  iVar8 = *(int *)(*pStatics + 24);
                  uVar9 = uVar10;
                }
              } while ((int)uVar9 < iVar8);
            }
          }
          uVar4 = this.activeSprite;
          this.mIsActive = state;
          cVar2 = Object.op_Inequality(uVar4,0,0);
          uVar12 = 0x3f800000;
          if (cVar2) {
            if (!this.instantTween) {
              cVar2 = NGUITools.GetActive(this,0);
              if (cVar2) {
                if (this.activeSprite == null) throw; // [null/range check failed]
                uVar4 = Component.get_gameObject(this.activeSprite,0);
                if (!this.invertSpriteState) {
                  if (!(!this.mIsActive))
                  {
                    uVar11 = 0x3f800000;
                    }
                    else if (!this.mIsActive) {
                    uVar11 = 0x3f800000;
                    }
                    else {
                  }
                  uVar11 = 0;
                }
                in_stack_ffffffffffffffb8 = 0;
                TweenAlpha.Begin(uVar4,0x3e19999a,uVar11,0,0);
                goto LAB_181698d8a;
              }
            }
            plVar7 = this.activeSprite;
            if (!this.invertSpriteState) {
              if (!(!this.mIsActive))
              {
                uVar11 = 0x3f800000;
                }
                else if (!this.mIsActive) {
                uVar11 = 0x3f800000;
                }
                else {
              }
              uVar11 = 0;
            }
            if (plVar7 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar7 + 0x1b8))(plVar7,uVar11,*(uint64 *)(*plVar7 + 0x1c0));
          }
        LAB_181698d8a:
          if (notify) {
            uVar4 = *(uint64 *)(pStatics + 8);
            cVar2 = Object.op_Equality(uVar4,0,0);
            if (cVar2) {
              plVar7 = (int64 *)(pStatics + 8);
              lVar6 = *plVar7;
              *plVar7 = this;
              il2cpp_internal(plVar7,this);
              uVar4 = this.onChange;
              cVar2 = EventDelegate.IsValid(uVar4,0);
              if (!cVar2) {
                uVar4 = this.eventReceiver;
                cVar2 = Object.op_Inequality(uVar4,0,0);
                if ((cVar2) &&
                   (cVar2 = FUN_180d6ca90(this.functionName,0), !cVar2)) {
                  local_res8[0] = this.mIsActive;
                  lVar1 = this.eventReceiver;
                  uVar4 = this.functionName;
                  uVar5 = il2cpp_value_box(DAT_181d8d920,local_res8);
                  if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  in_stack_ffffffffffffffb8 = 0;
                  GameObject.SendMessage(lVar1,uVar4,uVar5,1,0);
                }
              }
              else {
                uVar4 = this.onChange;
                EventDelegate.Execute(uVar4,0);
              }
              plVar7 = (int64 *)(pStatics + 8);
              *plVar7 = lVar6;
              il2cpp_internal(plVar7,lVar6);
            }
          }
          uVar4 = this.animator;
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (!cVar2) {
            uVar4 = this.activeAnimation;
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (!cVar2) {
              uVar4 = this.tween;
              cVar2 = Object.op_Inequality(uVar4,0,0);
              if (!cVar2) {
                return;
              }
              cVar2 = NGUITools.GetActive(this,0);
              plVar7 = this.tween;
              if (plVar7 != (int64 *)0) {
                if ((int)plVar7[7] == 0) {
                  (**(code **)(*plVar7 + 0x188))(plVar7,state,*(uint64 *)(*plVar7 + 400));
                  if ((!this.instantTween) && (cVar2)) {
                    return;
                  }
                  if (state == null) {
                    uVar12 = 0;
                  }
                  if (this.tween != null) {
                    UITweener.set_tweenFactor(this.tween,uVar12,0);
                    return;
                  }
                }
                else {
                  lVar6 = FUN_180956ba0(plVar7,1,DAT_181d70340);
                  if (lVar6 != null) {
                    iVar8 = *(int *)(lVar6 + 24);
                    if (iVar8 < 1) {
                      return;
                    }
                    while( true ) {
                      if (*(uint32 *)(lVar6 + 24) <= uVar10) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      plVar7 = lVar6[uVar10];
                      if ((plVar7 == (int64 *)0) || (this.tween == null)) break;
                      if (((int)plVar7[7] == this.tween.tweenGroup) &&
                         (((**(code **)(*plVar7 + 0x188))(plVar7,state,*(uint64 *)(*plVar7 + 400)),
                          this.instantTween || (!cVar2)))) {
                        if (state == null) {
                          uVar12 = 0;
                        }
                        else {
                          uVar12 = 0x3f800000;
                        }
                        UITweener.set_tweenFactor(plVar7,uVar12,0);
                      }
                      uVar10 = uVar10 + 1;
                      if (iVar8 <= (int)uVar10) {
                        return;
                      }
                    }
                  }
                }
              }
              throw; // [null/range check failed]
            }
            lVar6 = ActiveAnimation.Play
                              (this.activeAnimation,0,(uint32)state * 2 + -1,2,
                               in_stack_ffffffffffffffb8 & 0xffffffff00000000,0);
          }
          else {
            lVar6 = ActiveAnimation.Play
                              (this.animator,0,(uint32)state * 2 + -1,2,
                               in_stack_ffffffffffffffb8 & 0xffffffff00000000,0);
          }
          cVar2 = Object.op_Inequality(lVar6,0,0);
          if (!cVar2) {
            return;
          }
          if (!this.instantTween) {
            cVar2 = NGUITools.GetActive(this,0);
            if (cVar2) {
              return;
            }
          }
          if (lVar6 != null) {
            ActiveAnimation.Finish(lVar6,0);
            return;
          }
          throw; // [null/range check failed]
        }
        uVar4 = this.activeSprite;
        this.mIsActive = state;
        this.startsActive = state;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          return;
        }
        plVar7 = this.activeSprite;
        if (!this.invertSpriteState) {
          if (state != null)
          {
            uVar12 = 0x3f800000;
            }
            else if (state == null) {
            uVar12 = 0x3f800000;
            }
            else {
          }
          uVar12 = 0;
        }
        if (plVar7 != (int64 *)0) {
          (**(code **)(*plVar7 + 0x1b8))(plVar7,uVar12,*(uint64 *)(*plVar7 + 0x1c0));
          return;
        }
    }

    // Token : 0x600028B
    // RVA   : 0x1699600   Offset: 0x1697E00   Length: 0x9C
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onChange = uVar1;
        this.functionName = "OnActivate";
        this.mIsActive = 1;
        TrailRenderer_Base.ctor(this,0);
    }

    // Token : 0x600028C
    // RVA   : 0x1699580   Offset: 0x1697D80   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new BetterList_1(DAT_181d81e98);
        puVar1 = *(uint64 **)(DAT_181d8b2d8 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
