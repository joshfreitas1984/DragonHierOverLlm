// ============================================================
// Type  : UISlider
// Token : 0x2000067
// ============================================================

public class UISlider
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000279
    private Transform foreground;

    // Token: 0x400027A
    private float rawValue;

    // Token: 0x400027B
    private Direction direction;

    // Token: 0x400027C
    protected bool mInverted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000261
    // RVA   : 0x16091D0   Offset: 0x1607FD0   Length: 0x105
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

    // Token : 0x6000262
    // RVA   : 0x15FE8C0   Offset: 0x15FD6C0   Length: 0x47
    public float get_sliderValue()
    {
        byte[] auVar1 = new byte[16];
        byte[] auVar2 = new byte[16];
        uint64 extraout_XMM0_Qb;
        if (*(int *)(this + 100) < 2) {
          return (uint64)(uint32)*(float *)(this + 56);
        }
        auVar1._0_8_ = FUN_18007dbc0((float)(*(int *)(this + 100) + -1) * *(float *)(this + 56));
        auVar1._8_8_ = extraout_XMM0_Qb;
        auVar2._4_12_ = auVar1._4_12_;
        auVar2._0_4_ = (float)auVar1._0_8_ / (float)(*(int *)(this + 100) + -1);
        return auVar2._0_8_;
    }

    // Token : 0x6000263
    // RVA   : 0x15FEFD0   Offset: 0x15FDDD0   Length: 0xB
    public void set_sliderValue(float value)
    {
        UIProgressBar.Set(this,value,1,0);
    }

    // Token : 0x6000264
    // RVA   : 0x15FE8B0   Offset: 0x15FD6B0   Length: 0x10
    public bool get_inverted()
    {
        uint32 FUN_1815fe8b0(int64 this)
        {
        int iVar1;
        iVar1 = *(int *)(this + 60);
        if (iVar1 == 1) {
          return true;
        }
        return CONCAT31((int3)((uint32)iVar1 >> 8),iVar1 == 3);
    }

    // Token : 0x6000265
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    public void set_inverted(bool value)
    {
    }

    // Token : 0x6000266
    // RVA   : 0x1609050   Offset: 0x1607E50   Length: 0xE2
    protected override void Upgrade()
    {
        bool cVar1;
        ulong uVar2;
        if (this.direction != 2) {
          *(uint32 *)(this + 56) = this.rawValue;
          uVar2 = this.foreground;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.foreground == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar2 = Component.GetComponent(this.foreground,DAT_181e7a438);
            *(uint64 *)(this + 48) = uVar2;
          }
          if (this.direction != null) {
            *(uint32 *)(this + 60) = (this.mInverted) + 2;
            this.direction = 2;
            return;
          }
          *(uint32 *)(this + 60) = (uint32)(this.mInverted);
          this.direction = 2;
        }
    }

    // Token : 0x6000267
    // RVA   : 0x1608B60   Offset: 0x1607960   Length: 0x4E5
    protected override void OnStart()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uVar1 = *(uint64 *)(this + 40);
        cVar2 = Object.op_Inequality(uVar1,0,0);
        lVar3 = this;
        if (cVar2) {
          if (*(int64 *)(this + 40) == 0) throw; // [null/range check failed]
          uVar1 = Component.GetComponent(*(int64 *)(this + 40),DAT_181e76eb8);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (!cVar2) {
            if (*(int64 *)(this + 40) == 0) throw; // [null/range check failed]
            uVar1 = Component.GetComponent(*(int64 *)(this + 40),DAT_181e76f38);
            cVar2 = Object.op_Inequality(uVar1,0,0);
            if (!(!cVar2))
            {
              }
              lVar3 = *(int64 *)(this + 40);
              if (lVar3 == null) throw; // [null/range check failed]
              }
            }
        uVar1 = Component.get_gameObject(lVar3,0);
        lVar3 = UIEventListener.Get(uVar1,0);
        if (lVar3 != null) {
          uVar1 = *(uint64 *)(lVar3 + 64);
          uVar4 = new OnTooltipCB(this,DAT_181e52ad0,0);
          plVar5 = (int64 *)Delegate.Combine(uVar1,uVar4,0);
          plVar7 = (int64 *)0;
          plVar6 = plVar7;
          if (plVar5 != (int64 *)0) {
            if (*plVar5 == DAT_181e6e110) {
              plVar6 = plVar5;
            }
            if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar5,DAT_181e6e110);
            }
          }
          *(int64 **)(lVar3 + 64) = plVar6;
          uVar1 = *(uint64 *)(lVar3 + 96);
          uVar4 = new OnTooltipCB(this,DAT_181e529c0,0);
          plVar5 = (int64 *)Delegate.Combine(uVar1,uVar4,0);
          plVar6 = plVar7;
          if (plVar5 != (int64 *)0) {
            if (*plVar5 == DAT_181e6e190) {
              plVar6 = plVar5;
            }
            if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1801dfd50(plVar5,DAT_181e6e190);
            }
          }
          *(int64 **)(lVar3 + 96) = plVar6;
          uVar1 = *(uint64 *)(this + 32);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (!cVar2) {
            return;
          }
          if (*(int64 *)(this + 32) != 0) {
            uVar1 = Component.GetComponent(*(int64 *)(this + 32),DAT_181e76eb8);
            cVar2 = Object.op_Inequality(uVar1,0,0);
            if (!cVar2) {
              if (*(int64 *)(this + 32) == 0) throw; // [null/range check failed]
              uVar1 = Component.GetComponent(*(int64 *)(this + 32),DAT_181e76f38);
              cVar2 = Object.op_Inequality(uVar1,0,0);
              if (!cVar2) {
                return;
              }
            }
            uVar1 = *(uint64 *)(this + 48);
            cVar2 = Object.op_Equality(uVar1,0,0);
            if (!cVar2) {
              uVar1 = *(uint64 *)(this + 32);
              if (*(int64 *)(this + 48) == 0) throw; // [null/range check failed]
              uVar4 = UIRect.get_cachedTransform(*(int64 *)(this + 48),0);
              cVar2 = Object.op_Inequality(uVar1,uVar4,0);
              if (!cVar2) {
                return;
              }
            }
            if (*(int64 *)(this + 32) != 0) {
              uVar1 = Component.get_gameObject(*(int64 *)(this + 32),0);
              lVar3 = UIEventListener.Get(uVar1,0);
              if (lVar3 != null) {
                uVar1 = *(uint64 *)(lVar3 + 64);
                uVar4 = new OnTooltipCB(this,DAT_181e52b58,0);
                plVar5 = (int64 *)Delegate.Combine(uVar1,uVar4,0);
                plVar6 = plVar7;
                if (plVar5 != (int64 *)0) {
                  if (*plVar5 == DAT_181e6e110) {
                    plVar6 = plVar5;
                  }
                  if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1801dfd50(plVar5,DAT_181e6e110);
                  }
                }
                *(int64 **)(lVar3 + 64) = plVar6;
                uVar1 = *(uint64 *)(lVar3 + 96);
                uVar4 = new OnTooltipCB(this,DAT_181e52a48,0);
                plVar6 = (int64 *)Delegate.Combine(uVar1,uVar4,0);
                if (plVar6 != (int64 *)0) {
                  if (*plVar6 == DAT_181e6e190) {
                    plVar7 = plVar6;
                  }
                  if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1801dfd50(plVar6);
                  }
                }
                *(int64 **)(lVar3 + 96) = plVar7;
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000268
    // RVA   : 0x16088F0   Offset: 0x16076F0   Length: 0xDF
    protected void OnPressBackground(GameObject go, bool isPressed)
    {
        int iVar1;
        ulong uVar2;
        uint uVar3;
        iVar1 = UICamera.get_currentScheme(0);
        if (iVar1 != 2) {
          *(uint64 *)(this + 88) = *(uint64 *)(*(int64 *)(DAT_181e8fad0 + 184) + 192);
          uVar2 = UICamera.get_lastEventPosition(0);
          uVar3 = UIProgressBar.ScreenToValue(this,uVar2,0);
          UIProgressBar.Set(this,uVar3,1,0);
          if ((!isPressed) && (*(int64 *)(this + 24) != 0)) {
            OnGeometryUpdated.Invoke(*(int64 *)(this + 24),0);
          }
        }
    }

    // Token : 0x6000269
    // RVA   : 0x16085B0   Offset: 0x16073B0   Length: 0xC2
    protected void OnDragBackground(GameObject go, Vector2 delta)
    {
        int iVar1;
        ulong uVar2;
        uint uVar3;
        iVar1 = UICamera.get_currentScheme(0);
        if (iVar1 != 2) {
          *(uint64 *)(this + 88) = *(uint64 *)(*(int64 *)(DAT_181e8fad0 + 184) + 192);
          uVar2 = UICamera.get_lastEventPosition(0);
          uVar3 = UIProgressBar.ScreenToValue(this,uVar2,0);
          UIProgressBar.Set(this,uVar3,1,0);
          return;
        }
    }

    // Token : 0x600026A
    // RVA   : 0x16089D0   Offset: 0x16077D0   Length: 0x187
    protected void OnPressForeground(GameObject go, bool isPressed)
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        float fVar4;
        float fVar5;
        iVar2 = UICamera.get_currentScheme(0);
        if (iVar2 != 2) {
          *(uint64 *)(this + 88) = *(uint64 *)(*(int64 *)(DAT_181e8fad0 + 184) + 192);
          if (!isPressed) {
            if (*(int64 *)(this + 24) != 0) {
              OnGeometryUpdated.Invoke(*(int64 *)(this + 24),0);
              return;
            }
          }
          else {
            uVar3 = *(uint64 *)(this + 48);
            cVar1 = Object.op_Equality(uVar3,0,0);
            if (!cVar1) {
              fVar5 = *(float *)(this + 56);
              if (1 < *(int *)(this + 100)) {
                fVar5 = (float)FUN_18007dbc0((float)(*(int *)(this + 100) + -1) * fVar5);
                fVar5 = fVar5 / (float)(*(int *)(this + 100) + -1);
              }
              uVar3 = UICamera.get_lastEventPosition(0);
              fVar4 = (float)UIProgressBar.ScreenToValue(this,uVar3,0);
              fVar5 = fVar5 - fVar4;
            }
            else {
              fVar5 = 0.0;
            }
            *(float *)(this + 96) = fVar5;
          }
        }
    }

    // Token : 0x600026B
    // RVA   : 0x1608680   Offset: 0x1607480   Length: 0xD0
    protected void OnDragForeground(GameObject go, Vector2 delta)
    {
        float fVar1;
        int iVar2;
        ulong uVar3;
        float fVar4;
        iVar2 = UICamera.get_currentScheme(0);
        if (iVar2 != 2) {
          *(uint64 *)(this + 88) = *(uint64 *)(*(int64 *)(DAT_181e8fad0 + 184) + 192);
          fVar1 = *(float *)(this + 96);
          uVar3 = UICamera.get_lastEventPosition(0);
          fVar4 = (float)UIProgressBar.ScreenToValue(this,uVar3,0);
          UIProgressBar.Set(this,fVar4 + fVar1,1,0);
        }
    }

    // Token : 0x600026C
    // RVA   : 0x1608750   Offset: 0x1607550   Length: 0x198
    public override void OnPan(Vector2 delta)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        float local_28;
        float fStack_24;
        cVar3 = Behaviour.get_enabled(this,0);
        if (cVar3) {
          lVar2 = Component.GetComponent(this,DAT_181e76eb8);
          cVar3 = Object.op_Inequality(lVar2,0,0);
          if (!cVar3) {
            lVar2 = Component.GetComponent(this,DAT_181e76f38);
            cVar3 = Object.op_Inequality(lVar2,0,0);
            if (!cVar3) {
              return;
            }
            if (lVar2 == null) {
        LAB_1816088e3:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar3 = Behaviour.get_enabled(lVar2,0);
          }
          else {
            if (lVar2 == null) goto LAB_1816088e3;
            cVar3 = Collider.get_enabled(lVar2,0);
          }
          if ((cVar3) && (cVar3 = Behaviour.get_enabled(this,0), cVar3)) {
            iVar1 = *(int *)(this + 60);
            local_28 = (float)delta;
            if (iVar1 == 0) {
              fStack_24 = local_28 + *(float *)(this + 56);
            }
            else if (iVar1 == 1) {
              fStack_24 = *(float *)(this + 56) - local_28;
            }
            else {
              fStack_24 = (float)((uint64)delta >> 32);
              if (iVar1 == 2) {
                fStack_24 = fStack_24 + *(float *)(this + 56);
              }
              else {
                if (iVar1 != 3) {
                  return;
                }
                fStack_24 = *(float *)(this + 56) - fStack_24;
              }
            }
            uVar4 = Mathf.Clamp01(fStack_24,0);
            UIProgressBar.Set(this,uVar4,1,0);
            *(uint32 *)(this + 56) = uVar4;
          }
        }
    }

    // Token : 0x600026D
    // RVA   : 0x1609140   Offset: 0x1607F40   Length: 0x8B
    public void /*ctor*/()
    {
        ulong uVar1;
        bVar2 = !DAT_181ebe250;
        this.rawValue = 0x3f800000;
        this.direction = 2;
        if (bVar2) {
          il2cpp_runtime_class_init(&DAT_181e680f8);
          il2cpp_runtime_class_init(&DAT_181e72638);
          DAT_181ebe250 = true;
        }
        *(uint32 *)(this + 56) = 0x3f800000;
        uVar1 = il2cpp_internal(DAT_181e72638);
        FUN_1810f3480(uVar1,DAT_181e680f8);
        *(uint64 *)(this + 104) = uVar1;
        TrailRenderer_Base.ctor(this,0);
    }

}
