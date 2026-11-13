// ============================================================
// Type  : UIButton
// Token : 0x200002D
// ============================================================

public class UIButton
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000BA
    public static UIButton current;

    // Token: 0x40000BB
    public bool dragHighlight;

    // Token: 0x40000BC
    public string hoverSprite;

    // Token: 0x40000BD
    public string pressedSprite;

    // Token: 0x40000BE
    public string disabledSprite;

    // Token: 0x40000BF
    public Sprite hoverSprite2D;

    // Token: 0x40000C0
    public Sprite pressedSprite2D;

    // Token: 0x40000C1
    public Sprite disabledSprite2D;

    // Token: 0x40000C2
    public bool pixelSnap;

    // Token: 0x40000C3
    public List<EventDelegate> onClick;

    // Token: 0x40000C4
    private UISprite mSprite;

    // Token: 0x40000C5
    private UI2DSprite mSprite2D;

    // Token: 0x40000C6
    private string mNormalSprite;

    // Token: 0x40000C7
    private Sprite mNormalSprite2D;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600009B
    // RVA   : 0x141F330   Offset: 0x141E130   Length: 0x138
    public override bool get_isEnabled()
    {
        bool cVar1;
        byte uVar2;
        long lVar3;
        cVar1 = Behaviour.get_enabled(this,0);
        if (!cVar1) {
          return false;
        }
        lVar3 = Component.get_gameObject(this,0);
        if (lVar3 != null) {
          lVar3 = GameObject.GetComponent(lVar3,DAT_181e54178);
          cVar1 = Object.op_Implicit(lVar3,0);
          if (cVar1) {
            if (lVar3 == null) throw; // [null/range check failed]
            cVar1 = Collider.get_enabled(lVar3,0);
            if (cVar1) {
              return true;
            }
          }
          lVar3 = Component.GetComponent(this,DAT_181e76f38);
          cVar1 = Object.op_Implicit(lVar3,0);
          if (!cVar1) {
            return false;
          }
          if (lVar3 != null) {
            uVar2 = Behaviour.get_enabled(lVar3,0);
            return uVar2;
          }
        }
    }

    // Token : 0x600009C
    // RVA   : 0x141F4F0   Offset: 0x141E2F0   Length: 0x245
    public override void set_isEnabled(bool value)
    {
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        cVar2 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        if (cVar2 == value) {
          return;
        }
        lVar3 = Component.get_gameObject(this,0);
        if (lVar3 != null) {
          lVar3 = GameObject.GetComponent(lVar3,DAT_181e54178);
          cVar2 = Object.op_Inequality(lVar3,0,0);
          if (!cVar2) {
            lVar3 = Component.GetComponent(this,DAT_181e76f38);
            cVar2 = Object.op_Inequality(lVar3,0,0);
            if (!cVar2) {
              Behaviour.set_enabled(this,value,0);
              return;
            }
            if (lVar3 != null) {
              Behaviour.set_enabled(lVar3,value,0);
              lVar3 = Component.GetComponents(this,DAT_181e7b4b8);
              uVar5 = 0;
              if (lVar3 != null) {
                while( true ) {
                  if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar5) {
                    return;
                  }
                  if (*(uint32 *)(lVar3 + 24) <= uVar5) {
                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar4,0);
                  }
                  plVar1 = lVar3[uVar5];
                  if (plVar1 == (int64 *)0) break;
                  uVar4 = 0;
                  if (!value) {
                    uVar4 = 3;
                  }
                  (**(code **)(*plVar1 + 0x208))(plVar1,uVar4,0,*(uint64 *)(*plVar1 + 0x210));
                  uVar5 = uVar5 + 1;
                }
              }
            }
          }
          else if (lVar3 != null) {
            Collider.set_enabled(lVar3,value,0);
            lVar3 = Component.GetComponents(this,DAT_181e7b4b8);
            uVar5 = 0;
            if (lVar3 != null) {
              while( true ) {
                if ((int)*(uint32 *)(lVar3 + 24) <= (int)uVar5) {
                  return;
                }
                if (*(uint32 *)(lVar3 + 24) <= uVar5) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar4,0);
                }
                plVar1 = lVar3[uVar5];
                if (plVar1 == (int64 *)0) break;
                uVar4 = 0;
                if (!value) {
                  uVar4 = 3;
                }
                (**(code **)(*plVar1 + 0x208))(plVar1,uVar4,0,*(uint64 *)(*plVar1 + 0x210));
                uVar5 = uVar5 + 1;
              }
            }
          }
        }
    }

    // Token : 0x600009D
    // RVA   : 0x141F4B0   Offset: 0x141E2B0   Length: 0x39
    public string get_normalSprite()
    {
        if (*(char *)((int64)this + 116) == false) {
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
          return this[28];
        }
        return this[28];
    }

    // Token : 0x600009E
    // RVA   : 0x141F8E0   Offset: 0x141E6E0   Length: 0x184
    public void set_normalSprite(string value)
    {
        long lVar1;
        bool cVar2;
        if (*(char *)((int64)this + 116) == false) {
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
        }
        lVar1 = this[26];
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (cVar2) {
          cVar2 = FUN_180ad1200(this[28],0);
          if (!cVar2) {
            if (this[26] == 0) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar2 = FUN_1816387f0(this[28],*(uint64 *)(this[26] + 0x200),0);
            if (cVar2) {
              this[28] = value;
              il2cpp_internal(this + 28,value);
              UIButton.SetSprite(this,value,0);
              lVar1 = this[26];
              ZhSegment.Initialize(lVar1,"last change",0);
              return;
            }
          }
        }
        this[28] = value;
        il2cpp_internal(this + 28,value);
        if ((int)this[16] == 0) {
          UIButton.SetSprite(this,value,0);
        }
    }

    // Token : 0x600009F
    // RVA   : 0x141F470   Offset: 0x141E270   Length: 0x39
    public Sprite get_normalSprite2D()
    {
        if (*(char *)((int64)this + 116) == false) {
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
          return this[29];
        }
        return this[29];
    }

    // Token : 0x60000A0
    // RVA   : 0x141F740   Offset: 0x141E540   Length: 0x199
    public void set_normalSprite2D(Sprite value)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        if (*(char *)((int64)this + 116) == false) {
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
        }
        lVar1 = this[27];
        cVar3 = Object.op_Inequality(lVar1,0,0);
        if (cVar3) {
          lVar1 = this[29];
          if (this[27] == 0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar2 = *(uint64 *)(this[27] + 0x1f8);
          cVar3 = Object.op_Equality(lVar1,uVar2,0);
          if (cVar3) {
            this[29] = value;
            il2cpp_internal(this + 29,value);
            UIButton.SetSprite(this,value,0);
            lVar1 = this[26];
            ZhSegment.Initialize(lVar1,"last change",0);
            return;
          }
        }
        this[29] = value;
        il2cpp_internal(this + 29,value);
        if ((int)this[16] == 0) {
          UIButton.SetSprite(this,value,0);
        }
    }

    // Token : 0x60000A1
    // RVA   : 0x141EBD0   Offset: 0x141D9D0   Length: 0x1D1
    protected override void OnInit()
    {
        ulong uVar2;
        bool cVar4;
        UIButtonColor.OnInit(this,0);
        plVar1 = *(int64 **)(this + 120);
        if (plVar1 == (int64 *)0) {
          plVar5 = (int64 *)0;
        }
        else {
          plVar5 = plVar1;
        }
        this.mSprite = plVar5;
        plVar1 = *(int64 **)(this + 120);
        plVar5 = (int64 *)0;
        if (plVar1 != (int64 *)0) {
          if ((*(byte *)(*plVar1 + 300) < *(byte *)(DAT_181e8f8d0 + 300)) ||
             (*(int64 *)
               (*(int64 *)(*plVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181e8f8d0 + 300) * 8) !=
              DAT_181e8f8d0)) {
            bVar3 = false;
          }
          else {
            bVar3 = true;
          }
          if (bVar3) {
            plVar5 = plVar1;
          }
        }
        this.mSprite2D = plVar5;
        uVar2 = this.mSprite;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (cVar4) {
          if (this.mSprite != null)
          {
            this.mNormalSprite = this.mSprite.mSpriteName;
            }
            uVar2 = this.mSprite2D;
            cVar4 = Object.op_Inequality(uVar2,0,0);
            if (cVar4) {
            if (this.mSprite2D == null) {
          }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          this.mNormalSprite2D = this.mSprite2D.mSprite;
        }
    }

    // Token : 0x60000A2
    // RVA   : 0x141EAC0   Offset: 0x141D8C0   Length: 0x105
    protected override void OnEnable()
    {
        bool cVar1;
        byte uVar2;
        ulong uVar3;
        ulong uVar4;
        cVar1 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        if (!cVar1) {
                          // WARNING: Could not recover jumptable at 0x00018141eb22. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x208))(this,3,1,*(uint64 *)(*this + 0x210));
          return;
        }
        if (*(char *)((int64)this + 116) != false) {
          uVar3 = UICamera.get_hoveredObject(0);
          uVar4 = Component.get_gameObject(this,0);
          uVar2 = Object.op_Equality(uVar3,uVar4,0);
          (**(code **)(*this + 0x1c8))(this,uVar2,*(uint64 *)(*this + 0x1d0));
        }
    }

    // Token : 0x60000A3
    // RVA   : 0x141E920   Offset: 0x141D720   Length: 0x195
    protected override void OnDragOver()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        cVar3 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        if (cVar3) {
          if ((char)this[17] == false) {
            lVar1 = *(int64 *)(*(int64 *)(DAT_181e8fad0 + 184) + 224);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar2 = *(uint64 *)(lVar1 + 80);
            uVar4 = Component.get_gameObject(this,0);
            cVar3 = Object.op_Equality(uVar2,uVar4,0);
            if (!cVar3) {
              return;
            }
          }
          cVar3 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
          if (cVar3) {
            if (*(char *)((int64)this + 116) == false) {
              (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
            }
            lVar1 = this[3];
            cVar3 = Object.op_Inequality(lVar1,0,0);
            if (cVar3) {
              (**(code **)(*this + 0x208))(this,2,0,*(uint64 *)(*this + 0x210));
            }
          }
        }
    }

    // Token : 0x60000A4
    // RVA   : 0x141E780   Offset: 0x141D580   Length: 0x193
    protected override void OnDragOut()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        cVar3 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        if (cVar3) {
          if ((char)this[17] == false) {
            lVar1 = *(int64 *)(*(int64 *)(DAT_181e8fad0 + 184) + 224);
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar2 = *(uint64 *)(lVar1 + 80);
            uVar4 = Component.get_gameObject(this,0);
            cVar3 = Object.op_Equality(uVar2,uVar4,0);
            if (!cVar3) {
              return;
            }
          }
          cVar3 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
          if (cVar3) {
            if (*(char *)((int64)this + 116) == false) {
              (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
            }
            lVar1 = this[3];
            cVar3 = Object.op_Inequality(lVar1,0,0);
            if (cVar3) {
              (**(code **)(*this + 0x208))(this,0,0,*(uint64 *)(*this + 0x210));
            }
          }
        }
    }

    // Token : 0x60000A5
    // RVA   : 0x141E5F0   Offset: 0x141D3F0   Length: 0x182
    protected virtual void OnClick()
    {
        ulong uVar1;
        long lVar3;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181e8fa50 + 184);
        cVar4 = Object.op_Equality(uVar1,0,0);
        if (cVar4) {
          cVar4 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
          if (cVar4) {
            if (UICamera.currentTouchID != -2) {
              if (UICamera.currentTouchID != -3) {
                puVar2 = *(uint64 **)(DAT_181e8fa50 + 184);
                *puVar2 = this;
                il2cpp_internal(puVar2,this);
                lVar3 = this[25];
                EventDelegate.Execute(lVar3,0);
                puVar2 = *(uint64 **)(DAT_181e8fa50 + 184);
                *puVar2 = 0;
                il2cpp_internal(puVar2,0);
              }
            }
          }
        }
    }

    // Token : 0x60000A6
    // RVA   : 0x141EFE0   Offset: 0x141DDE0   Length: 0x211
    public override void SetState(State state, bool immediate)
    {
        bool cVar1;
        ulong uVar2;
        UIButtonColor.SetState(this,state,immediate,0);
        uVar2 = this.mSprite;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = this.mSprite2D;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (!cVar1) {
            return;
          }
          if (state == null) {
            UIButton.SetSprite(this,this.mNormalSprite2D,0);
            return;
          }
          if (state != 1) {
            if (state == 2) {
              UIButton.SetSprite(this,this.pressedSprite2D,0);
              return;
            }
            if (state != 3) {
              return;
            }
            UIButton.SetSprite(this,this.disabledSprite2D,0);
            return;
          }
          uVar2 = this.hoverSprite2D;
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (!cVar1) {
            UIButton.SetSprite(this,this.hoverSprite2D,0);
            return;
          }
          UIButton.SetSprite(this,this.mNormalSprite2D,0);
          return;
        }
        if (state != null) {
          if (state != 1) {
            if (state == 2) {
              uVar2 = this.pressedSprite;
            }
            else {
              if (state != 3) {
                return;
              }
              uVar2 = this.disabledSprite;
            }
            goto LAB_18141f1d6;
          }
          cVar1 = FUN_180ad1200(this.hoverSprite,0);
          if (!cVar1) {
            uVar2 = this.hoverSprite;
            goto LAB_18141f1d6;
          }
        }
        uVar2 = this.mNormalSprite;
        LAB_18141f1d6:
        UIButton.SetSprite(this,uVar2,0);
    }

    // Token : 0x60000A7
    // RVA   : 0x141EDB0   Offset: 0x141DBB0   Length: 0xE8
    protected void SetSprite(string sp)
    {
        ulong uVar1;
        bool cVar3;
        cVar3 = Object.op_Inequality(sp,0,0);
        if (cVar3) {
          uVar1 = this.mSprite2D;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            if (this.mSprite2D == null) {
        LAB_18141efd1:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar1 = this.mSprite2D.mSprite;
            cVar3 = Object.op_Inequality(uVar1,sp,0);
            if (cVar3) {
              if (this.mSprite2D == null) goto LAB_18141efd1;
              UI2DSprite.set_sprite2D(this.mSprite2D,sp,0);
              if (this.pixelSnap) {
                plVar2 = this.mSprite2D;
                if (plVar2 == (int64 *)0) goto LAB_18141efd1;
                (**(code **)(*plVar2 + 0x348))(plVar2,*(uint64 *)(*plVar2 + 0x350));
              }
            }
          }
        }
    }

    // Token : 0x60000A8
    // RVA   : 0x141EEA0   Offset: 0x141DCA0   Length: 0x136
    protected void SetSprite(Sprite sp)
    {
        ulong uVar1;
        bool cVar3;
        cVar3 = Object.op_Inequality(sp,0,0);
        if (cVar3) {
          uVar1 = this.mSprite2D;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            if (this.mSprite2D == null) {
        LAB_18141efd1:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar1 = this.mSprite2D.mSprite;
            cVar3 = Object.op_Inequality(uVar1,sp,0);
            if (cVar3) {
              if (this.mSprite2D == null) goto LAB_18141efd1;
              UI2DSprite.set_sprite2D(this.mSprite2D,sp,0);
              if (this.pixelSnap) {
                plVar2 = this.mSprite2D;
                if (plVar2 == (int64 *)0) goto LAB_18141efd1;
                (**(code **)(*plVar2 + 0x348))(plVar2,*(uint64 *)(*plVar2 + 0x350));
              }
            }
          }
        }
    }

    // Token : 0x60000A9
    // RVA   : 0x141F200   Offset: 0x141E000   Length: 0x127
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar5;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        uVar5 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar5,DAT_181e680f8);
        *(uint64 *)(this + 200) = uVar5;
        local_48 = 0;
        uStack_40 = 0;
        FUN_1807282e0(&local_48,0x3f61e1e2,0x3f48c8c9,0x3f169697,0x3f800000,0);
        local_38 = 0;
        uStack_30 = 0;
        *(uint32 *)(this + 32) = (uint32)local_48;
        *(uint32 *)(this + 36) = local_48._4_4_;
        *(uint32 *)(this + 40) = (uint32)uStack_40;
        *(uint32 *)(this + 44) = uStack_40._4_4_;
        FUN_1807282e0(&local_38,0x3f37b7b8,0x3f23a3a4,0x3ef6f6f7,0x3f800000,0);
        *(uint32 *)(this + 48) = (uint32)local_38;
        *(uint32 *)(this + 52) = local_38._4_4_;
        *(uint32 *)(this + 56) = (uint32)uStack_30;
        *(uint32 *)(this + 60) = uStack_30._4_4_;
        puVar6 = (uint32 *)FUN_180f24b80(local_28,0);
        uVar1 = *puVar6;
        uVar2 = puVar6[1];
        uVar3 = puVar6[2];
        uVar4 = puVar6[3];
        *(uint32 *)(this + 80) = 0x3e4ccccd;
        *(uint32 *)(this + 64) = uVar1;
        *(uint32 *)(this + 68) = uVar2;
        *(uint32 *)(this + 72) = uVar3;
        *(uint32 *)(this + 76) = uVar4;
        TrailRenderer_Base.ctor(this,0);
    }

}
