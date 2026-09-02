// ============================================================
// Type  : UIButtonColor
// Token : 0x200002F
// ============================================================

public class UIButtonColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000CF
    public GameObject tweenTarget;

    // Token: 0x40000D0
    public Color hover;

    // Token: 0x40000D1
    public Color pressed;

    // Token: 0x40000D2
    public Color disabledColor;

    // Token: 0x40000D3
    public float duration;

    // Token: 0x40000D4
    protected Color mStartingColor;

    // Token: 0x40000D5
    protected Color mDefaultColor;

    // Token: 0x40000D6
    protected bool mInitDone;

    // Token: 0x40000D7
    protected UIWidget mWidget;

    // Token: 0x40000D8
    protected State mState;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000AD
    // RVA   : 0xF5A0B0   Offset: 0xF588B0   Length: 0x7
    public State get_state()
    {
        uint32 FUN_180f5a0b0(int64 this)
        {
        return this.mState;
    }

    // Token : 0x60000AE
    // RVA   : 0x13BE8A0   Offset: 0x13BD0A0   Length: 0x14
    public void set_state(State value)
    {
        void FUN_1813be8a0(int64 *this,uint64 value)
        {
                          // WARNING: Could not recover jumptable at 0x0001813be8ad. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x208))(this,value,0,*(uint64 *)(*this + 0x210));
    }

    // Token : 0x60000AF
    // RVA   : 0x13BE7F0   Offset: 0x13BCFF0   Length: 0x3E
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

    // Token : 0x60000B0
    // RVA   : 0x13BE830   Offset: 0x13BD030   Length: 0x5E
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
                          // WARNING: Could not recover jumptable at 0x0001813be887. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x208))(this,(int)lVar4,0,*(uint64 *)(*this + 0x210));
    }

    // Token : 0x60000B1
    // RVA   : 0xA75790   Offset: 0xA73F90   Length: 0x7
    public virtual bool get_isEnabled()
    {
        void FUN_180a75790(uint64 this)
        {
        Behaviour.get_enabled(this,0);
    }

    // Token : 0x60000B2
    // RVA   : 0x13BE890   Offset: 0x13BD090   Length: 0x8
    public virtual void set_isEnabled(bool value)
    {
        void FUN_1813be890(uint64 this,uint64 value)
        {
        Behaviour.set_enabled(this,value,0);
    }

    // Token : 0x60000B3
    // RVA   : 0x13BE3B0   Offset: 0x13BCBB0   Length: 0x5D
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
                          // WARNING: Could not recover jumptable at 0x0001813be406. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x208))(this,(int)lVar5,0,*(uint64 *)(*this + 0x210));
    }

    // Token : 0x60000B4
    // RVA   : 0x13BD8D0   Offset: 0x13BC0D0   Length: 0x18
    public void CacheDefaultColor()
    {
        void FUN_1813bd8d0(int64 *this)
        {
        if (*(char *)((int64)this + 116) == false) {
                          // WARNING: Could not recover jumptable at 0x0001813bd8e0. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
          return;
        }
    }

    // Token : 0x60000B5
    // RVA   : 0x13BE580   Offset: 0x13BCD80   Length: 0x5D
    private void Start()
    {
        bool cVar1;
        if (*(char *)((int64)this + 116) == false) {
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
        }
        cVar1 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        if (!cVar1) {
                          // WARNING: Could not recover jumptable at 0x0001813be5d0. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x208))(this,3,1,*(uint64 *)(*this + 0x210));
          return;
        }
    }

    // Token : 0x60000B6
    // RVA   : 0x13BDE70   Offset: 0x13BC670   Length: 0x2D0
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
          uVar2 = GameObject.GetComponent(this.tweenTarget,DAT_181da2930);
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
            lVar3 = GameObject.GetComponent(this.tweenTarget,DAT_181da0c20);
            cVar1 = Object.op_Inequality(lVar3,0,0);
            if (!cVar1) {
              if (this.tweenTarget != null) {
                lVar3 = GameObject.GetComponent(this.tweenTarget,DAT_181da0180);
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
        LAB_1813be0cb:
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
                  lVar3 = FUN_180d94d10(lVar3,0);
                }
                else {
                  lVar3 = FUN_180d94be0();
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
                  goto LAB_1813be0cb;
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
            goto LAB_1813be0cb;
          }
        }
    }

    // Token : 0x60000B7
    // RVA   : 0x13BDB90   Offset: 0x13BC390   Length: 0x210
    protected virtual void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
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
                          // WARNING: Could not recover jumptable at 0x0001813bdd94. Too many branches
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

    // Token : 0x60000B8
    // RVA   : 0x13BD8F0   Offset: 0x13BC0F0   Length: 0x11A
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
        LAB_1813bda05:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar2 = GameObject.GetComponent(this[3],DAT_181da21b0);
            cVar1 = Object.op_Inequality(lVar2,0,0);
            if (cVar1) {
              if (lVar2 == null) goto LAB_1813bda05;
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

    // Token : 0x60000B9
    // RVA   : 0x13BDDB0   Offset: 0x13BC5B0   Length: 0xBC
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

    // Token : 0x60000BA
    // RVA   : 0x13BE150   Offset: 0x13BC950   Length: 0x25B
    protected virtual void OnPress(bool isPressed)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
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
          goto LAB_1813be380;
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
        LAB_1813be370:
              uVar5 = 1;
              goto LAB_1813be380;
            }
            iVar3 = UICamera.get_currentScheme(0);
            if (iVar3 == 0) {
              uVar5 = UICamera.get_hoveredObject(0);
              uVar4 = Component.get_gameObject(this,0);
              cVar2 = Object.op_Equality(uVar5,uVar4,0);
              if (cVar2) goto LAB_1813be370;
            }
          }
        }
        uVar5 = 0;
        LAB_1813be380:
        (**(code **)(*this + 0x208))(this,uVar5,0,*(uint64 *)(*this + 0x210));
    }

    // Token : 0x60000BB
    // RVA   : 0x13BDAD0   Offset: 0x13BC2D0   Length: 0xB8
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
                          // WARNING: Could not recover jumptable at 0x0001813bdb7b. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x208))(this,2,0,*(uint64 *)(*this + 0x210));
            return;
          }
        }
    }

    // Token : 0x60000BC
    // RVA   : 0x13BDA10   Offset: 0x13BC210   Length: 0xB6
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
                          // WARNING: Could not recover jumptable at 0x0001813bdab9. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x208))(this,0,0,*(uint64 *)(*this + 0x210));
            return;
          }
        }
    }

    // Token : 0x60000BD
    // RVA   : 0x13BE410   Offset: 0x13BCC10   Length: 0x169
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
          bVar4 = !DAT_181e7d7cc;
          *(int *)(this + 16) = state;
          if (bVar4) {
            il2cpp_runtime_class_init(&DAT_181d68fe8);
            DAT_181e7d7cc = true;
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

    // Token : 0x60000BE
    // RVA   : 0x13BE5E0   Offset: 0x13BCDE0   Length: 0x13A
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

    // Token : 0x60000BF
    // RVA   : 0x13BE720   Offset: 0x13BCF20   Length: 0xC9
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
        FUN_1809981e0(&local_48,0x3f61e1e2,0x3f48c8c9,0x3f169697,0x3f800000,0);
        local_38 = 0;
        uStack_30 = 0;
        this.hover = (uint32)local_48;
        *(uint32 *)(this + 36) = local_48._4_4_;
        *(uint32 *)(this + 40) = (uint32)uStack_40;
        *(uint32 *)(this + 44) = uStack_40._4_4_;
        FUN_1809981e0(&local_38,0x3f37b7b8,0x3f23a3a4,0x3ef6f6f7,0x3f800000,0);
        this.pressed = (uint32)local_38;
        *(uint32 *)(this + 52) = local_38._4_4_;
        *(uint32 *)(this + 56) = (uint32)uStack_30;
        *(uint32 *)(this + 60) = uStack_30._4_4_;
        puVar5 = (uint32 *)FUN_1810988d0(local_28,0);
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
