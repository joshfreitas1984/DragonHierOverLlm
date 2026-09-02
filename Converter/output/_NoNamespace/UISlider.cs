// ============================================================
// Type  : UISlider
// Token : 0x2000067
// ============================================================

public class UISlider
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400027D
    private Transform foreground;

    // Token: 0x400027E
    private float rawValue;

    // Token: 0x400027F
    private Direction direction;

    // Token: 0x4000280
    protected bool mInverted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000262
    // RVA   : 0x168EA70   Offset: 0x168D270   Length: 0x105
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

    // Token : 0x6000263
    // RVA   : 0x1689B50   Offset: 0x1688350   Length: 0x7
    public float get_sliderValue()
    {
        void FUN_181689b50(uint64 this)
        {
        UIProgressBar.get_value(this,0);
    }

    // Token : 0x6000264
    // RVA   : 0x1689CE0   Offset: 0x16884E0   Length: 0x8
    public void set_sliderValue(float value)
    {
        void FUN_181689ce0(uint64 this,uint64 value)
        {
        UIProgressBar.set_value(this,value,0);
    }

    // Token : 0x6000265
    // RVA   : 0x168EA60   Offset: 0x168D260   Length: 0x7
    public bool get_inverted()
    {
        void FUN_18168ea60(uint64 this)
        {
        UIProgressBar.get_isInverted(this,0);
    }

    // Token : 0x6000266
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    public void set_inverted(bool value)
    {
    }

    // Token : 0x6000267
    // RVA   : 0x168E950   Offset: 0x168D150   Length: 0xE2
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
              FUN_1800d6620();
            }
            uVar2 = Component.GetComponent(this.foreground,DAT_181d6e7c0);
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

    // Token : 0x6000268
    // RVA   : 0x168E460   Offset: 0x168CC60   Length: 0x4E5
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
          uVar1 = Component.GetComponent(*(int64 *)(this + 40),DAT_181d6b340);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (!cVar2) {
            if (*(int64 *)(this + 40) == 0) throw; // [null/range check failed]
            uVar1 = Component.GetComponent(*(int64 *)(this + 40),DAT_181d6b3c0);
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
          uVar4 = new OnTooltipCB(this,DAT_181d9d378,0);
          plVar5 = (int64 *)Delegate.Combine(uVar1,uVar4,0);
          plVar7 = (int64 *)0;
          plVar6 = plVar7;
          if (plVar5 != (int64 *)0) {
            if (*plVar5 == DAT_181d68590) {
              plVar6 = plVar5;
            }
            if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar5,DAT_181d68590);
            }
          }
          *(int64 **)(lVar3 + 64) = plVar6;
          uVar1 = *(uint64 *)(lVar3 + 96);
          uVar4 = new OnTooltipCB(this,DAT_181d9d268,0);
          plVar5 = (int64 *)Delegate.Combine(uVar1,uVar4,0);
          plVar6 = plVar7;
          if (plVar5 != (int64 *)0) {
            if (*plVar5 == DAT_181d68610) {
              plVar6 = plVar5;
            }
            if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar5,DAT_181d68610);
            }
          }
          *(int64 **)(lVar3 + 96) = plVar6;
          uVar1 = *(uint64 *)(this + 32);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (!cVar2) {
            return;
          }
          if (*(int64 *)(this + 32) != 0) {
            uVar1 = Component.GetComponent(*(int64 *)(this + 32),DAT_181d6b340);
            cVar2 = Object.op_Inequality(uVar1,0,0);
            if (!cVar2) {
              if (*(int64 *)(this + 32) == 0) throw; // [null/range check failed]
              uVar1 = Component.GetComponent(*(int64 *)(this + 32),DAT_181d6b3c0);
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
                uVar4 = new OnTooltipCB(this,DAT_181d9d400,0);
                plVar5 = (int64 *)Delegate.Combine(uVar1,uVar4,0);
                plVar6 = plVar7;
                if (plVar5 != (int64 *)0) {
                  if (*plVar5 == DAT_181d68590) {
                    plVar6 = plVar5;
                  }
                  if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar5,DAT_181d68590);
                  }
                }
                *(int64 **)(lVar3 + 64) = plVar6;
                uVar1 = *(uint64 *)(lVar3 + 96);
                uVar4 = new OnTooltipCB(this,DAT_181d9d2f0,0);
                plVar6 = (int64 *)Delegate.Combine(uVar1,uVar4,0);
                if (plVar6 != (int64 *)0) {
                  if (*plVar6 == DAT_181d68610) {
                    plVar7 = plVar6;
                  }
                  if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar6);
                  }
                }
                *(int64 **)(lVar3 + 96) = plVar7;
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000269
    // RVA   : 0x168E210   Offset: 0x168CA10   Length: 0xDC
    protected void OnPressBackground(GameObject go, bool isPressed)
    {
        int iVar1;
        ulong uVar2;
        uint uVar3;
        iVar1 = UICamera.get_currentScheme(0);
        if (iVar1 != 2) {
          *(uint64 *)(this + 88) = *(uint64 *)(*(int64 *)(DAT_181d8a458 + 184) + 192);
          uVar2 = UICamera.get_lastEventPosition(0);
          uVar3 = UIProgressBar.ScreenToValue(this,uVar2,0);
          UIProgressBar.set_value(this,uVar3,0);
          if ((!isPressed) && (*(int64 *)(this + 24) != 0)) {
            OnGeometryUpdated.Invoke(*(int64 *)(this + 24),0);
          }
        }
    }

    // Token : 0x600026A
    // RVA   : 0x168DF50   Offset: 0x168C750   Length: 0xBF
    protected void OnDragBackground(GameObject go, Vector2 delta)
    {
        int iVar1;
        ulong uVar2;
        uint uVar3;
        iVar1 = UICamera.get_currentScheme(0);
        if (iVar1 != 2) {
          *(uint64 *)(this + 88) = *(uint64 *)(*(int64 *)(DAT_181d8a458 + 184) + 192);
          uVar2 = UICamera.get_lastEventPosition(0);
          uVar3 = UIProgressBar.ScreenToValue(this,uVar2,0);
          UIProgressBar.set_value(this,uVar3,0);
          return;
        }
    }

    // Token : 0x600026B
    // RVA   : 0x168E2F0   Offset: 0x168CAF0   Length: 0x162
    protected void OnPressForeground(GameObject go, bool isPressed)
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        float fVar4;
        float fVar5;
        iVar2 = UICamera.get_currentScheme(0);
        if (iVar2 != 2) {
          *(uint64 *)(this + 88) = *(uint64 *)(*(int64 *)(DAT_181d8a458 + 184) + 192);
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
              fVar5 = (float)UIProgressBar.get_value(this,0);
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

    // Token : 0x600026C
    // RVA   : 0x168E010   Offset: 0x168C810   Length: 0xCD
    protected void OnDragForeground(GameObject go, Vector2 delta)
    {
        float fVar1;
        int iVar2;
        ulong uVar3;
        float fVar4;
        iVar2 = UICamera.get_currentScheme(0);
        if (iVar2 != 2) {
          *(uint64 *)(this + 88) = *(uint64 *)(*(int64 *)(DAT_181d8a458 + 184) + 192);
          fVar1 = *(float *)(this + 96);
          uVar3 = UICamera.get_lastEventPosition(0);
          fVar4 = (float)UIProgressBar.ScreenToValue(this,uVar3,0);
          UIProgressBar.set_value(this,fVar4 + fVar1,0);
        }
    }

    // Token : 0x600026D
    // RVA   : 0x168E0E0   Offset: 0x168C8E0   Length: 0x126
    public override void OnPan(Vector2 delta)
    {
        long lVar1;
        bool cVar2;
        cVar2 = Behaviour.get_enabled(this,0);
        if (cVar2) {
          lVar1 = Component.GetComponent(this,DAT_181d6b340);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            lVar1 = Component.GetComponent(this,DAT_181d6b3c0);
            cVar2 = Object.op_Inequality(lVar1,0,0);
            if (!cVar2) {
              return;
            }
            if (lVar1 == null) {
        LAB_18168e201:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar2 = Behaviour.get_enabled(lVar1,0);
          }
          else {
            if (lVar1 == null) goto LAB_18168e201;
            cVar2 = Collider.get_enabled(lVar1,0);
          }
          if (cVar2) {
            UIProgressBar.OnPan(this,delta,0);
          }
        }
    }

    // Token : 0x600026E
    // RVA   : 0x168EA40   Offset: 0x168D240   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_18168ea40(int64 this)
        {
        this.rawValue = 0x3f800000;
        this.direction = 2;
        UIProgressBar.ctor(this,0);
    }

}
