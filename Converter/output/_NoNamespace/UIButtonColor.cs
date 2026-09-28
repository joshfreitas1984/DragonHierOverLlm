// ============================================================
// Type  : UIButtonColor
// Token : 0x2000030
// ============================================================

public class UIButtonColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000EB
    public GameObject tweenTarget;

    // Token: 0x40000EC
    public Color hover;

    // Token: 0x40000ED
    public Color pressed;

    // Token: 0x40000EE
    public Color disabledColor;

    // Token: 0x40000EF
    public float duration;

    // Token: 0x40000F0
    protected Color mStartingColor;

    // Token: 0x40000F1
    protected Color mDefaultColor;

    // Token: 0x40000F2
    protected bool mInitDone;

    // Token: 0x40000F3
    protected UIWidget mWidget;

    // Token: 0x40000F4
    protected State mState;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000C5
    // RVA   : 0xF4B850   Offset: 0xF4AC50   Length: 0x7
    public State get_state()
    {
        uint32 FUN_180f4b850(int64 this)
        {
        return this.mState;
    }

    // Token : 0x60000C6
    // RVA   : 0x15302B0   Offset: 0x152F6B0   Length: 0x14
    public void set_state(State value)
    {
        void FUN_1815302b0(int64 *this,uint64 value)
        {
                          // WARNING: Could not recover jumptable at 0x0001815302bd. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x208))(this,value,0,*(uint64 *)(*this + 0x210));
    }

    // Token : 0x60000C7
    // RVA   : 0x1530200   Offset: 0x152F600   Length: 0x3E
    public Color get_defaultColor()
    {
        ulong uVar1;
        if (*(char *)((int64)param_2 + 116) == false) {
          (**(code **)(*param_2 + 0x198))(param_2,*(uint64 *)(*param_2 + 0x1a0));
        }
        uVar1 = *(uint64 *)((int64)param_2 + 108);
        *this = *(uint64 *)((int64)param_2 + 100);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x60000C8
    // RVA   : 0x1530240   Offset: 0x152F640   Length: 0x5E
    public void set_defaultColor(Color value)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        if (*(char *)((int64)this + 116) == false) {
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
        }
        uVar1 = value[1];
        uVar2 = value[2];
        uVar3 = value[3];
        lVar4 = this[16];
        *(uint32 *)((int64)this + 100) = *value;
        *(uint32 *)(this + 13) = uVar1;
        *(uint32 *)((int64)this + 108) = uVar2;
        *(uint32 *)(this + 14) = uVar3;
        *(uint32 *)(this + 16) = 3;
                          // WARNING: Could not recover jumptable at 0x000181530297. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x208))(this,(int)lVar4,0,*(uint64 *)(*this + 0x210));
    }

    // Token : 0x60000C9
    // RVA   : 0xAEF460   Offset: 0xAEE860   Length: 0x7
    public virtual bool get_isEnabled()
    {
        void FUN_180aef460(uint64 this)
        {
        Behaviour.get_enabled(this,0);
    }

    // Token : 0x60000CA
    // RVA   : 0x15302A0   Offset: 0x152F6A0   Length: 0x8
    public virtual void set_isEnabled(bool value)
    {
        void FUN_1815302a0(uint64 this,uint64 value)
        {
        Behaviour.set_enabled(this,value,0);
    }

    // Token : 0x60000CB
    // RVA   : 0x152FDC0   Offset: 0x152F1C0   Length: 0x5D
    public void ResetDefaultColor()
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        uVar1 = *(uint32 *)((int64)this + 84);
        lVar3 = this[11];
        uVar2 = *(uint32 *)((int64)this + 92);
        lVar4 = this[12];
        if (*(char *)((int64)this + 116) == false) {
          (**(code **)(*this + 0x198))(uVar1,*(uint64 *)(*this + 0x1a0));
        }
        lVar5 = this[16];
        *(uint32 *)((int64)this + 100) = uVar1;
        *(int *)(this + 13) = (int)lVar3;
        *(uint32 *)((int64)this + 108) = uVar2;
        *(int *)(this + 14) = (int)lVar4;
        *(uint32 *)(this + 16) = 3;
                          // WARNING: Could not recover jumptable at 0x00018152fe16. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x208))(this,(int)lVar5,0,*(uint64 *)(*this + 0x210));
    }

    // Token : 0x60000CC
    // RVA   : 0x152F2E0   Offset: 0x152E6E0   Length: 0x18
    public void CacheDefaultColor()
    {
        void FUN_18152f2e0(int64 *this)
        {
        if (*(char *)((int64)this + 116) == false) {
                          // WARNING: Could not recover jumptable at 0x00018152f2f0. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
          return;
        }
    }

    // Token : 0x60000CD
    // RVA   : 0x152FF90   Offset: 0x152F390   Length: 0x5D
    private void Start()
    {
        bool cVar1;
        if (*(char *)((int64)this + 116) == false) {
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
        }
        cVar1 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        if (!cVar1) {
                          // WARNING: Could not recover jumptable at 0x00018152ffe0. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x208))(this,3,1,*(uint64 *)(*this + 0x210));
          return;
        }
    }

    // Token : 0x60000CE
    // RVA   : 0x152F880   Offset: 0x152EC80   Length: 0x2D0
    protected virtual void OnInit()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        uint uVar9;
        byte[] local_18 = new byte[16];
        uVar2 = this.tweenTarget;
        this.mInitDone = 1;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if ((cVar1) && (cVar1 = Application.get_isPlaying(0), !cVar1)) {
          uVar2 = Component.get_gameObject(this,0);
          this.tweenTarget = uVar2;
        }
        uVar2 = this.tweenTarget;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.tweenTarget == null) throw; // [null/range check failed]
          uVar2 = GameObject.GetComponent(this.tweenTarget,DAT_181d74c30);
          this.mWidget = uVar2;
        }
        uVar2 = this.mWidget;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = this.tweenTarget;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (!cVar1) {
            return;
          }
          if (this.tweenTarget != null) {
            lVar3 = GameObject.GetComponent(this.tweenTarget,DAT_181d72c50);
            cVar1 = Object.op_Inequality(lVar3,0,0);
            if (!cVar1) {
              if (this.tweenTarget != null) {
                lVar3 = GameObject.GetComponent(this.tweenTarget,DAT_181d721b0);
                cVar1 = Object.op_Inequality(lVar3,0,0);
                if (!cVar1) {
                  this.tweenTarget = 0;
                  this.mInitDone = 0;
                  return;
                }
                if (lVar3 != null) {
                  puVar4 = (uint64 *)Light.get_color(local_18,lVar3,0);
                  uVar2 = puVar4[1];
                  *(uint64 *)(this + 100) = *puVar4;
                  *(uint64 *)(this + 108) = uVar2;
                  uVar6 = *(uint32 *)puVar4;
                  uVar7 = *(uint32 *)((int64)puVar4 + 4);
                  uVar8 = *(uint32 *)(puVar4 + 1);
                  uVar9 = *(uint32 *)((int64)puVar4 + 12);
        LAB_18152fadb:
                  this.mStartingColor = uVar6;
                  *(uint32 *)(this + 88) = uVar7;
                  *(uint32 *)(this + 92) = uVar8;
                  *(uint32 *)(this + 96) = uVar9;
                  return;
                }
              }
            }
            else {
              cVar1 = Application.get_isPlaying(0);
              if (lVar3 != null) {
                if (!cVar1) {
                  lVar3 = FUN_180d9d830(lVar3,0);
                }
                else {
                  lVar3 = FUN_180d9d700();
                }
                if (lVar3 != null) {
                  puVar5 = (uint32 *)Material.get_color(local_18,lVar3,0);
                  uVar6 = *puVar5;
                  uVar7 = puVar5[1];
                  uVar8 = puVar5[2];
                  uVar9 = puVar5[3];
                  *(uint32 *)(this + 100) = uVar6;
                  *(uint32 *)(this + 104) = uVar7;
                  *(uint32 *)(this + 108) = uVar8;
                  *(uint32 *)(this + 112) = uVar9;
                  goto LAB_18152fadb;
                }
              }
            }
          }
        }
        else {
          lVar3 = this.mWidget;
          if (lVar3 != null) {
            uVar2 = *(uint64 *)(lVar3 + 152);
            *(uint64 *)(this + 100) = lVar3.mColor;
            *(uint64 *)(this + 108) = uVar2;
            uVar6 = lVar3.mColor;
            uVar7 = *(uint32 *)(lVar3 + 148);
            uVar8 = *(uint32 *)(lVar3 + 152);
            uVar9 = *(uint32 *)(lVar3 + 156);
            goto LAB_18152fadb;
          }
        }
    }

    // Token : 0x60000CF
    // RVA   : 0x152F5A0   Offset: 0x152E9A0   Length: 0x210
    protected virtual void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        byte uVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar5;
        if (*(char *)((int64)this + 116) != false) {
          uVar4 = Component.get_gameObject(this,0);
          uVar2 = UICamera.IsHighlighted(uVar4,0);
          (**(code **)(*this + 0x1c8))(this,uVar2,*(uint64 *)(*this + 0x1d0));
        }
        if (*(int64 *)(pStatics + 224) == 0) {
          return;
        }
        lVar1 = *(int64 *)(pStatics + 224);
        if (lVar1 != null) {
          uVar4 = *(uint64 *)(lVar1 + 80);
          uVar5 = Component.get_gameObject(this,0);
          cVar3 = Object.op_Equality(uVar4,uVar5,0);
          if (cVar3) {
                          // WARNING: Could not recover jumptable at 0x00018152f7a4. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x1d8))(this,1,*(uint64 *)(*this + 0x1e0));
            return;
          }
          lVar1 = *(int64 *)(pStatics + 224);
          if (lVar1 != null) {
            uVar4 = *(uint64 *)(lVar1 + 72);
            uVar5 = Component.get_gameObject(this,0);
            cVar3 = Object.op_Equality(uVar4,uVar5,0);
            if (!cVar3) {
              return;
            }
            (**(code **)(*this + 0x1c8))(this,1,*(uint64 *)(*this + 0x1d0));
            return;
          }
        }
    }

    // Token : 0x60000D0
    // RVA   : 0x152F300   Offset: 0x152E700   Length: 0x11A
    protected virtual void OnDisable()
    {
        bool cVar1;
        long lVar2;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if ((*(char *)((int64)this + 116) != false) && ((int)this[16] != 0)) {
          (**(code **)(*this + 0x208))(this,0,1,*(uint64 *)(*this + 0x210));
          lVar2 = this[3];
          cVar1 = Object.op_Inequality(lVar2,0,0);
          if (cVar1) {
            if (this[3] == 0) {
        LAB_18152f415:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar2 = GameObject.GetComponent(this[3],DAT_181d74438);
            cVar1 = Object.op_Inequality(lVar2,0,0);
            if (cVar1) {
              if (lVar2 == null) goto LAB_18152f415;
              local_18 = *(uint32 *)((int64)this + 100);
              uStack_14 = (uint32)this[13];
              uStack_10 = *(uint32 *)((int64)this + 108);
              uStack_c = (uint32)this[14];
              TweenColor.set_value(lVar2,&local_18,0);
              Behaviour.set_enabled(lVar2,0,0);
            }
          }
        }
    }

    // Token : 0x60000D1
    // RVA   : 0x152F7C0   Offset: 0x152EBC0   Length: 0xBC
    protected virtual void OnHover(bool isOver)
    {
        long lVar1;
        bool cVar2;
        cVar2 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        if (cVar2) {
          if (*(char *)((int64)this + 116) == false) {
            (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
          }
          lVar1 = this[3];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (cVar2) {
            (**(code **)(*this + 0x208))(this,isOver,0,*(uint64 *)(*this + 0x210));
          }
        }
    }

    // Token : 0x60000D2
    // RVA   : 0x152FB60   Offset: 0x152EF60   Length: 0x25B
    protected virtual void OnPress(bool isPressed)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        ulong uVar5;
        cVar2 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        if (!cVar2) {
          return;
        }
        if (*(char *)((int64)this + 116) == false) {
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
        }
        lVar1 = this[3];
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (!cVar2) {
          return;
        }
        if (isPressed) {
          uVar5 = 2;
          goto LAB_18152fd90;
        }
        if (*(int64 *)(pStatics + 224) != 0) {
          lVar1 = *(int64 *)(pStatics + 224);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar5 = *(uint64 *)(lVar1 + 72);
          uVar4 = Component.get_gameObject(this,0);
          cVar2 = Object.op_Equality(uVar5,uVar4,0);
          if (cVar2) {
            iVar3 = UICamera.get_currentScheme(0);
            if (iVar3 == 2) {
        LAB_18152fd80:
              uVar5 = 1;
              goto LAB_18152fd90;
            }
            iVar3 = UICamera.get_currentScheme(0);
            if (iVar3 == 0) {
              uVar5 = UICamera.get_hoveredObject(0);
              uVar4 = Component.get_gameObject(this,0);
              cVar2 = Object.op_Equality(uVar5,uVar4,0);
              if (cVar2) goto LAB_18152fd80;
            }
          }
        }
        uVar5 = 0;
        LAB_18152fd90:
        (**(code **)(*this + 0x208))(this,uVar5,0,*(uint64 *)(*this + 0x210));
    }

    // Token : 0x60000D3
    // RVA   : 0x152F4E0   Offset: 0x152E8E0   Length: 0xB8
    protected virtual void OnDragOver()
    {
        long lVar1;
        bool cVar2;
        cVar2 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        if (cVar2) {
          if (*(char *)((int64)this + 116) == false) {
            (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
          }
          lVar1 = this[3];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (cVar2) {
                          // WARNING: Could not recover jumptable at 0x00018152f58b. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x208))(this,2,0,*(uint64 *)(*this + 0x210));
            return;
          }
        }
    }

    // Token : 0x60000D4
    // RVA   : 0x152F420   Offset: 0x152E820   Length: 0xB6
    protected virtual void OnDragOut()
    {
        long lVar1;
        bool cVar2;
        cVar2 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        if (cVar2) {
          if (*(char *)((int64)this + 116) == false) {
            (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
          }
          lVar1 = this[3];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (cVar2) {
                          // WARNING: Could not recover jumptable at 0x00018152f4c9. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x208))(this,0,0,*(uint64 *)(*this + 0x210));
            return;
          }
        }
    }

    // Token : 0x60000D5
    // RVA   : 0x152FE20   Offset: 0x152F220   Length: 0x169
    public virtual void SetState(State state, bool instant)
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (*(char *)((int64)this + 116) == false) {
          *(uint8 *)((int64)this + 116) = 1;
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
        }
        if ((int)this[16] != state) {
          bVar4 = !DAT_181ea349e;
          *(int *)(this + 16) = state;
          if (bVar4) {
            il2cpp_runtime_class_init(&DAT_181d8e210);
            DAT_181ea349e = true;
          }
          if (*(char *)((int64)this + 116) != false) {
            lVar3 = this[3];
            cVar2 = Object.op_Inequality(lVar3,0,0);
            if (cVar2) {
              iVar1 = (int)this[16];
              if (iVar1 == 1) {
                local_18 = (uint32)this[4];
                uStack_14 = *(uint32 *)((int64)this + 36);
                uStack_10 = (uint32)this[5];
                uStack_c = *(uint32 *)((int64)this + 44);
              }
              else if (iVar1 == 2) {
                local_18 = (uint32)this[6];
                uStack_14 = *(uint32 *)((int64)this + 52);
                uStack_10 = (uint32)this[7];
                uStack_c = *(uint32 *)((int64)this + 60);
              }
              else if (iVar1 == 3) {
                local_18 = (uint32)this[8];
                uStack_14 = *(uint32 *)((int64)this + 68);
                uStack_10 = (uint32)this[9];
                uStack_c = *(uint32 *)((int64)this + 76);
              }
              else {
                local_18 = *(uint32 *)((int64)this + 100);
                uStack_14 = (uint32)this[13];
                uStack_10 = *(uint32 *)((int64)this + 108);
                uStack_c = (uint32)this[14];
              }
              lVar3 = TweenColor.Begin(this[3],(int)this[10],&local_18,0);
              if (instant) {
                cVar2 = Object.op_Inequality(lVar3,0,0);
                if (cVar2) {
                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  local_18 = *(uint32 *)(lVar3 + 136);
                  uStack_14 = *(uint32 *)(lVar3 + 140);
                  uStack_10 = *(uint32 *)(lVar3 + 144);
                  uStack_c = *(uint32 *)(lVar3 + 148);
                  TweenColor.set_value(lVar3,&local_18,0);
                  Behaviour.set_enabled(lVar3,0,0);
                }
              }
            }
          }
        }
    }

    // Token : 0x60000D6
    // RVA   : 0x152FFF0   Offset: 0x152F3F0   Length: 0x13A
    public void UpdateColor(bool instant)
    {
        int iVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.mInitDone) {
          uVar2 = this.tweenTarget;
          cVar4 = Object.op_Inequality(uVar2,0,0);
          if (cVar4) {
            iVar1 = this.mState;
            if (iVar1 == 1) {
              local_18 = this.hover;
              uStack_14 = *(uint32 *)(this + 36);
              uStack_10 = *(uint32 *)(this + 40);
              uStack_c = *(uint32 *)(this + 44);
            }
            else if (iVar1 == 2) {
              local_18 = this.pressed;
              uStack_14 = *(uint32 *)(this + 52);
              uStack_10 = *(uint32 *)(this + 56);
              uStack_c = *(uint32 *)(this + 60);
            }
            else if (iVar1 == 3) {
              local_18 = this.disabledColor;
              uStack_14 = *(uint32 *)(this + 68);
              uStack_10 = *(uint32 *)(this + 72);
              uStack_c = *(uint32 *)(this + 76);
            }
            else {
              local_18 = *(uint32 *)(this + 100);
              uStack_14 = *(uint32 *)(this + 104);
              uStack_10 = *(uint32 *)(this + 108);
              uStack_c = *(uint32 *)(this + 112);
            }
            lVar3 = TweenColor.Begin(this.tweenTarget,this.duration,
                                      &local_18,0);
            if (instant) {
              cVar4 = Object.op_Inequality(lVar3,0,0);
              if (cVar4) {
                if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_18 = *(uint32 *)(lVar3 + 136);
                uStack_14 = *(uint32 *)(lVar3 + 140);
                uStack_10 = *(uint32 *)(lVar3 + 144);
                uStack_c = *(uint32 *)(lVar3 + 148);
                TweenColor.set_value(lVar3,&local_18,0);
                Behaviour.set_enabled(lVar3,0,0);
              }
            }
          }
        }
    }

    // Token : 0x60000D7
    // RVA   : 0x1530130   Offset: 0x152F530   Length: 0xC9
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        local_48 = 0;
        uStack_40 = 0;
        FUN_1809dc910(&local_48,0x3f61e1e2,0x3f48c8c9,0x3f169697,0x3f800000,0);
        local_38 = 0;
        uStack_30 = 0;
        this.hover = (uint32)local_48;
        *(uint32 *)(this + 36) = local_48._4_4_;
        *(uint32 *)(this + 40) = (uint32)uStack_40;
        *(uint32 *)(this + 44) = uStack_40._4_4_;
        FUN_1809dc910(&local_38,0x3f37b7b8,0x3f23a3a4,0x3ef6f6f7,0x3f800000,0);
        this.pressed = (uint32)local_38;
        *(uint32 *)(this + 52) = local_38._4_4_;
        *(uint32 *)(this + 56) = (uint32)uStack_30;
        *(uint32 *)(this + 60) = uStack_30._4_4_;
        puVar5 = (uint32 *)FUN_1810d33f0(local_28,0);
        uVar1 = *puVar5;
        uVar2 = puVar5[1];
        uVar3 = puVar5[2];
        uVar4 = puVar5[3];
        this.duration = 0x3e4ccccd;
        this.disabledColor = uVar1;
        *(uint32 *)(this + 68) = uVar2;
        *(uint32 *)(this + 72) = uVar3;
        *(uint32 *)(this + 76) = uVar4;
        TrailRenderer_Base.ctor(this,0);
    }

}
