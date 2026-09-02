// ============================================================
// Type  : UIProgressBar
// Token : 0x200005B
// ============================================================

public class UIProgressBar
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000228
    public static UIProgressBar current;

    // Token: 0x4000229
    public OnDragFinished onDragFinished;

    // Token: 0x400022A
    public Transform thumb;

    // Token: 0x400022B
    protected UIWidget mBG;

    // Token: 0x400022C
    protected UIWidget mFG;

    // Token: 0x400022D
    protected float mValue;

    // Token: 0x400022E
    protected FillDirection mFill;

    // Token: 0x400022F
    protected bool mStarted;

    // Token: 0x4000230
    protected Transform mTrans;

    // Token: 0x4000231
    protected bool mIsDirty;

    // Token: 0x4000232
    protected Camera mCam;

    // Token: 0x4000233
    protected float mOffset;

    // Token: 0x4000234
    public int numberOfSteps;

    // Token: 0x4000235
    public List<EventDelegate> onChange;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000208
    // RVA   : 0x1581D40   Offset: 0x1580540   Length: 0x8F
    public Transform get_cachedTransform()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mTrans;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.get_transform(this,0);
          this.mTrans = uVar2;
        }
        return this.mTrans;
    }

    // Token : 0x6000209
    // RVA   : 0x1581C60   Offset: 0x1580460   Length: 0xD8
    public Camera get_cachedCamera()
    {
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        uVar5 = this.mCam;
        cVar2 = Object.op_Equality(uVar5,0,0);
        if (cVar2) {
          lVar4 = Component.get_gameObject(this,0);
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = GameObject.get_layer(lVar4,0);
          uVar5 = NGUITools.FindCameraForLayer(uVar3,0);
          *puVar1 = uVar5;
          il2cpp_internal(puVar1,uVar5);
        }
        return *puVar1;
    }

    // Token : 0x600020A
    // RVA   : 0x2284C0   Offset: 0x226CC0   Length: 0x68
    public UIWidget get_foregroundWidget()
    {
        return this.mFG;
    }

    // Token : 0x600020B
    // RVA   : 0x1582470   Offset: 0x1580C70   Length: 0x93
    public void set_foregroundWidget(UIWidget value)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mFG;
        cVar2 = Object.op_Inequality(uVar1,value,0);
        if (cVar2) {
          this.mFG = value;
          this.mIsDirty = 1;
        }
    }

    // Token : 0x600020C
    // RVA   : 0x268280   Offset: 0x266A80   Length: 0x5
    public UIWidget get_backgroundWidget()
    {
        return this.mBG;
    }

    // Token : 0x600020D
    // RVA   : 0x15823B0   Offset: 0x1580BB0   Length: 0x93
    public void set_backgroundWidget(UIWidget value)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mBG;
        cVar2 = Object.op_Inequality(uVar1,value,0);
        if (cVar2) {
          this.mBG = value;
          this.mIsDirty = 1;
        }
    }

    // Token : 0x600020E
    // RVA   : 0x362670   Offset: 0x360E70   Length: 0x4
    public FillDirection get_fillDirection()
    {
        uint32 FUN_180362670(int64 this)
        {
        return this.mFill;
    }

    // Token : 0x600020F
    // RVA   : 0x1582450   Offset: 0x1580C50   Length: 0x20
    public void set_fillDirection(FillDirection value)
    {
        void FUN_181582450(int64 *this,int value)
        {
        if ((*(int *)((int64)this + 60) != value) &&
           (*(int *)((int64)this + 60) = value, (char)this[8] != false)) {
                          // WARNING: Could not recover jumptable at 0x000181582468. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x1a8))(this,*(uint64 *)(*this + 0x1b0));
          return;
        }
    }

    // Token : 0x6000210
    // RVA   : 0x1581E00   Offset: 0x1580600   Length: 0x47
    public float get_value()
    {
        byte[] auVar1 = new byte[16];
        byte[] auVar2 = new byte[16];
        uint64 extraout_XMM0_Qb;
        if (*(int *)(this + 100) < 2) {
          return (uint64)(uint32)this.mValue;
        }
        auVar1._0_8_ = FUN_18000d7c0((float)(*(int *)(this + 100) + -1) * this.mValue);
        auVar1._8_8_ = extraout_XMM0_Qb;
        auVar2._4_12_ = auVar1._4_12_;
        auVar2._0_4_ = (float)auVar1._0_8_ / (float)(*(int *)(this + 100) + -1);
        return auVar2._0_8_;
    }

    // Token : 0x6000211
    // RVA   : 0x1582510   Offset: 0x1580D10   Length: 0xB
    public void set_value(float value)
    {
        UIProgressBar.Set(this,value,1,0);
    }

    // Token : 0x6000212
    // RVA   : 0x1581B80   Offset: 0x1580380   Length: 0xD1
    public float get_alpha()
    {
        bool cVar1;
        ulong uVar3;
        uVar3 = this.mFG;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (!cVar1) {
          uVar3 = this.mBG;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) {
            return 0x3f800000;
          }
          plVar2 = this.mBG;
        }
        else {
          plVar2 = this.mFG;
        }
        if (plVar2 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000181581c45. Too many branches
                          // WARNING: Treating indirect jump as call
          uVar3 = (**(code **)(*plVar2 + 0x1a8))(plVar2,*(uint64 *)(*plVar2 + 0x1b0));
          return uVar3;
        }
    }

    // Token : 0x6000213
    // RVA   : 0x1581E50   Offset: 0x1580650   Length: 0x554
    public void set_alpha(float value)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        float fVar5;
        uVar2 = this.mFG;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          plVar4 = this.mFG;
          if (plVar4 == (int64 *)0) goto LAB_18158239f;
          (**(code **)(*plVar4 + 0x1b8))(plVar4,value,*(uint64 *)(*plVar4 + 0x1c0));
          if (this.mFG == null) goto LAB_18158239f;
          uVar2 = Component.GetComponent(this.mFG,DAT_181d6b340);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          lVar3 = this.mFG;
          if (!cVar1) {
            if (lVar3 == null) goto LAB_18158239f;
            uVar2 = Component.GetComponent(lVar3,DAT_181d6b3c0);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (cVar1) {
              if (this.mFG == null) goto LAB_18158239f;
              lVar3 = Component.GetComponent(this.mFG,DAT_181d6b3c0);
              plVar4 = this.mFG;
              if (plVar4 == (int64 *)0) goto LAB_18158239f;
              fVar5 = (float)(**(code **)(*plVar4 + 0x1a8))(plVar4,*(uint64 *)(*plVar4 + 0x1b0));
              if (lVar3 == null) goto LAB_18158239f;
              Behaviour.set_enabled(lVar3,0.001 < fVar5,0);
            }
          }
          else {
            if (lVar3 == null) goto LAB_18158239f;
            lVar3 = Component.GetComponent(lVar3,DAT_181d6b340);
            plVar4 = this.mFG;
            if (plVar4 == (int64 *)0) goto LAB_18158239f;
            fVar5 = (float)(**(code **)(*plVar4 + 0x1a8))(plVar4,*(uint64 *)(*plVar4 + 0x1b0));
            if (lVar3 == null) goto LAB_18158239f;
            Collider.set_enabled(lVar3,0.001 < fVar5,0);
          }
        }
        uVar2 = this.mBG;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          plVar4 = this.mBG;
          if (plVar4 == (int64 *)0) goto LAB_18158239f;
          (**(code **)(*plVar4 + 0x1b8))(plVar4,value,*(uint64 *)(*plVar4 + 0x1c0));
          if (this.mBG == null) goto LAB_18158239f;
          uVar2 = Component.GetComponent(this.mBG,DAT_181d6b340);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          lVar3 = this.mBG;
          if (!cVar1) {
            if (lVar3 == null) goto LAB_18158239f;
            uVar2 = Component.GetComponent(lVar3,DAT_181d6b3c0);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (cVar1) {
              if (this.mBG == null) goto LAB_18158239f;
              lVar3 = Component.GetComponent(this.mBG,DAT_181d6b3c0);
              plVar4 = this.mBG;
              if (plVar4 == (int64 *)0) goto LAB_18158239f;
              fVar5 = (float)(**(code **)(*plVar4 + 0x1a8))(plVar4,*(uint64 *)(*plVar4 + 0x1b0));
              if (lVar3 == null) goto LAB_18158239f;
              Behaviour.set_enabled(lVar3,0.001 < fVar5,0);
            }
          }
          else {
            if (lVar3 == null) goto LAB_18158239f;
            lVar3 = Component.GetComponent(lVar3,DAT_181d6b340);
            plVar4 = this.mBG;
            if (plVar4 == (int64 *)0) goto LAB_18158239f;
            fVar5 = (float)(**(code **)(*plVar4 + 0x1a8))(plVar4,*(uint64 *)(*plVar4 + 0x1b0));
            if (lVar3 == null) goto LAB_18158239f;
            Collider.set_enabled(lVar3,0.001 < fVar5,0);
          }
        }
        uVar2 = this.thumb;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.thumb == null) {
        LAB_18158239f:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar4 = (int64 *)Component.GetComponent(this.thumb,DAT_181d6e7c0);
          cVar1 = Object.op_Inequality(plVar4,0,0);
          if (cVar1) {
            if (plVar4 == (int64 *)0) goto LAB_18158239f;
            (**(code **)(*plVar4 + 0x1b8))(plVar4,value,*(uint64 *)(*plVar4 + 0x1c0));
            uVar2 = Component.GetComponent(plVar4,DAT_181d6b340);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (!cVar1) {
              uVar2 = Component.GetComponent(plVar4,DAT_181d6b3c0);
              cVar1 = Object.op_Inequality(uVar2,0,0);
              if (cVar1) {
                lVar3 = Component.GetComponent(plVar4,DAT_181d6b3c0);
                fVar5 = (float)(**(code **)(*plVar4 + 0x1a8))(plVar4,*(uint64 *)(*plVar4 + 0x1b0));
                if (lVar3 == null) goto LAB_18158239f;
                Behaviour.set_enabled(lVar3,0.001 < fVar5,0);
              }
            }
            else {
              lVar3 = Component.GetComponent(plVar4,DAT_181d6b340);
              fVar5 = (float)(**(code **)(*plVar4 + 0x1a8))(plVar4,*(uint64 *)(*plVar4 + 0x1b0));
              if (lVar3 == null) goto LAB_18158239f;
              Collider.set_enabled(lVar3,0.001 < fVar5,0);
            }
          }
        }
    }

    // Token : 0x6000214
    // RVA   : 0x1581DD0   Offset: 0x15805D0   Length: 0x11
    protected bool get_isHorizontal()
    {
        int iVar1;
        iVar1 = this.mFill;
        if (iVar1 == 0) {
          return true;
        }
        return CONCAT31((int3)((uint32)iVar1 >> 8),iVar1 == 1);
    }

    // Token : 0x6000215
    // RVA   : 0x1581DF0   Offset: 0x15805F0   Length: 0x10
    protected bool get_isInverted()
    {
        int iVar1;
        iVar1 = this.mFill;
        if (iVar1 == 1) {
          return true;
        }
        return CONCAT31((int3)((uint32)iVar1 >> 8),iVar1 == 3);
    }

    // Token : 0x6000216
    // RVA   : 0x1581760   Offset: 0x157FF60   Length: 0x1D5
    public void Set(float val, bool notify)
    {
        long lVar1;
        bool cVar3;
        int iVar4;
        float fVar5;
        float fVar6;
        fVar5 = (float)Mathf.Clamp01();
        fVar6 = *(float *)(this + 7);
        if (fVar6 != fVar5) {
          iVar4 = *(int *)((int64)this + 100);
          if (1 < iVar4) {
            fVar6 = (float)FUN_18000d7c0((float)(iVar4 + -1) * fVar6);
            iVar4 = *(int *)((int64)this + 100);
            fVar6 = fVar6 / (float)(iVar4 + -1);
          }
          *(float *)(this + 7) = fVar5;
          if ((char)this[8] != false) {
            if (1 < iVar4) {
              fVar5 = (float)FUN_18000d7c0((float)(iVar4 + -1) * fVar5);
              fVar5 = fVar5 / (float)(*(int *)((int64)this + 100) + -1);
            }
            if (fVar6 != fVar5) {
              if (notify) {
                cVar3 = NGUITools.GetActive(this,0);
                if (cVar3) {
                  lVar1 = this[13];
                  cVar3 = EventDelegate.IsValid(lVar1,0);
                  if (cVar3) {
                    puVar2 = *(uint64 **)(DAT_181d8ae58 + 184);
                    *puVar2 = this;
                    il2cpp_internal(puVar2,this);
                    lVar1 = this[13];
                    EventDelegate.Execute(lVar1,0);
                    puVar2 = *(uint64 **)(DAT_181d8ae58 + 184);
                    *puVar2 = 0;
                    il2cpp_internal(puVar2,0);
                  }
                }
              }
              (**(code **)(*this + 0x1a8))(this,*(uint64 *)(*this + 0x1b0));
            }
          }
        }
    }

    // Token : 0x6000217
    // RVA   : 0x1581940   Offset: 0x1580140   Length: 0x197
    public void Start()
    {
        long lVar1;
        ulong uVar2;
        bool cVar4;
        if ((char)this[8] == false) {
          *(uint8 *)(this + 8) = 1;
          (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
          cVar4 = Application.get_isPlaying(0);
          if (cVar4) {
            lVar1 = this[5];
            cVar4 = Object.op_Inequality(lVar1,0,0);
            if (cVar4) {
              if (this[5] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              *(uint8 *)(this[5] + 208) = 1;
            }
            (**(code **)(*this + 0x188))(this,*(uint64 *)(*this + 400));
            uVar2 = **(uint64 **)(DAT_181d8ae58 + 184);
            cVar4 = Object.op_Equality(uVar2,0,0);
            if ((cVar4) && (this[13] != 0)) {
              puVar3 = *(uint64 **)(DAT_181d8ae58 + 184);
              *puVar3 = this;
              il2cpp_internal(puVar3,this);
              lVar1 = this[13];
              EventDelegate.Execute(lVar1,0);
              puVar3 = *(uint64 **)(DAT_181d8ae58 + 184);
              *puVar3 = 0;
              il2cpp_internal(puVar3,0);
            }
          }
          (**(code **)(*this + 0x1a8))(this,*(uint64 *)(*this + 0x1b0));
        }
    }

    // Token : 0x6000218
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    protected virtual void Upgrade()
    {
    }

    // Token : 0x6000219
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    protected virtual void OnStart()
    {
    }

    // Token : 0x600021A
    // RVA   : 0x1581AE0   Offset: 0x15802E0   Length: 0x18
    protected void Update()
    {
        void FUN_181581ae0(int64 *this)
        {
        if ((char)this[10] != false) {
                          // WARNING: Could not recover jumptable at 0x000181581af0. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x1a8))(this,*(uint64 *)(*this + 0x1b0));
          return;
        }
    }

    // Token : 0x600021B
    // RVA   : 0x1581120   Offset: 0x157F920   Length: 0x107
    protected void OnValidate()
    {
        bool cVar1;
        float fVar2;
        cVar1 = NGUITools.GetActive(this,0);
        if (!cVar1) {
          fVar2 = (float)Mathf.Clamp01((int)this[7],0);
          if (*(float *)(this + 7) != fVar2) {
            *(float *)(this + 7) = fVar2;
          }
          if (*(int *)((int64)this + 100) < 0) {
            *(uint32 *)((int64)this + 100) = 0;
            return;
          }
          if (*(int *)((int64)this + 100) < 22) {
            return;
          }
          *(uint32 *)((int64)this + 100) = 21;
          return;
        }
        (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        *(uint8 *)(this + 10) = 1;
        fVar2 = (float)Mathf.Clamp01((int)this[7],0);
        if (*(float *)(this + 7) != fVar2) {
          *(float *)(this + 7) = fVar2;
        }
        if (*(int *)((int64)this + 100) < 0) {
          *(uint32 *)((int64)this + 100) = 0;
        }
        else if (21 < *(int *)((int64)this + 100)) {
          *(uint32 *)((int64)this + 100) = 21;
        }
                          // WARNING: Could not recover jumptable at 0x00018158121a. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x1a8))(this,*(uint64 *)(*this + 0x1b0));
    }

    // Token : 0x600021C
    // RVA   : 0x1581230   Offset: 0x157FA30   Length: 0x329
    protected float ScreenToValue(Vector2 screenPos)
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar7;
        uint[] local_res8 = new uint[4];
        ulong local_b8;
        uint local_b0;
        ulong local_a8;
        uint local_a0;
        ulong local_88;
        ulong local_78;
        ulong uStack_70;
        ulong local_68;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        local_58 = 0;
        uStack_50 = 0;
        local_res8[0] = 0;
        local_88 = screenPos;
        lVar5 = this[9];
        cVar3 = Object.op_Equality(lVar5,0,0);
        if (cVar3) {
          lVar5 = Component.get_transform(this,0);
          this[9] = lVar5;
          il2cpp_internal(this + 9,lVar5);
        }
        lVar5 = this[9];
        if (lVar5 != null) {
          puVar6 = (uint64 *)Transform.get_rotation(&local_78,lVar5,0);
          uVar1 = *puVar6;
          uVar2 = puVar6[1];
          puVar6 = (uint64 *)Vector3.get_back(&local_b8,0);
          local_a8 = *puVar6;
          local_a0 = *(uint32 *)(puVar6 + 1);
          local_78 = uVar1;
          uStack_70 = uVar2;
          puVar6 = (uint64 *)Quaternion.op_Multiply(&local_b8,&local_78,&local_a8,0);
          uVar1 = *puVar6;
          uVar4 = *(uint32 *)(puVar6 + 1);
          puVar6 = (uint64 *)Transform.get_position(&local_b8,lVar5,0);
          local_a8 = *puVar6;
          local_a0 = *(uint32 *)(puVar6 + 1);
          local_b8 = uVar1;
          local_b0 = uVar4;
          Plane.ctor(&local_58,&local_b8,&local_a8,0);
          lVar7 = this[11];
          cVar3 = Object.op_Equality(lVar7,0,0);
          if (cVar3) {
            lVar7 = Component.get_gameObject(this,0);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar4 = GameObject.get_layer(lVar7,0);
            lVar7 = NGUITools.FindCameraForLayer(uVar4,0);
            this[11] = lVar7;
            il2cpp_internal(this + 11,lVar7);
          }
          local_a8 = local_88;
          local_a0 = 0;
          if (this[11] != 0) {
            local_b0 = 0;
            local_b8 = local_a8;
            puVar6 = (uint64 *)Camera.ScreenPointToRay(&local_a8,this[11],&local_b8,0);
            local_48 = *puVar6;
            uStack_40 = puVar6[1];
            local_38 = puVar6[2];
            local_78 = *puVar6;
            uStack_70 = puVar6[1];
            local_68 = puVar6[2];
            cVar3 = Plane.Raycast(&local_58,&local_78,local_res8,0);
            if (!cVar3) {
              if (1 < *(int *)((int64)this + 100)) {
                FUN_18000d7c0((float)(*(int *)((int64)this + 100) + -1) * *(float *)(this + 7));
              }
            }
            else {
              puVar6 = (uint64 *)Ray.GetPoint(&local_a8,&local_48,local_res8[0],0);
              local_b8 = *puVar6;
              local_b0 = *(uint32 *)(puVar6 + 1);
              puVar6 = (uint64 *)Transform.InverseTransformPoint(&local_a8,lVar5,&local_b8,0);
              (**(code **)(*this + 0x198))(this,*puVar6,*(uint64 *)(*this + 0x1a0));
            }
            return;
          }
        }
    }

    // Token : 0x600021D
    // RVA   : 0x1580F10   Offset: 0x157F710   Length: 0x17D
    protected virtual float LocalToValue(Vector2 localPos)
    {
        int iVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        float local_28;
        float fStack_24;
        uVar5 = this.mFG;
        cVar3 = Object.op_Inequality(uVar5,0,0);
        if (!cVar3) {
          fVar6 = this.mValue;
          if (1 < *(int *)(this + 100)) {
            fVar6 = (float)FUN_18000d7c0((float)(*(int *)(this + 100) + -1) * fVar6);
            fVar6 = fVar6 / (float)(*(int *)(this + 100) + -1);
          }
          return fVar6;
        }
        plVar2 = this.mFG;
        if (plVar2 != (int64 *)0) {
          lVar4 = (**(code **)(*plVar2 + 0x1d8))(plVar2,*(uint64 *)(*plVar2 + 0x1e0));
          if (lVar4 != null) {
            if (*(uint32 *)(lVar4 + 24) < 3) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            fVar6 = (float)*(uint64 *)(lVar4 + 56) - (float)*(uint64 *)(lVar4 + 32);
            iVar1 = this.mFill;
            local_28 = (float)localPos;
            if (iVar1 == 0) {
              return (local_28 - *(float *)(lVar4 + 32)) / fVar6;
            }
            if (iVar1 == 1) {
              fVar6 = (local_28 - *(float *)(lVar4 + 32)) / fVar6;
            }
            else {
              fStack_24 = (float)((uint64)localPos >> 32);
              fVar6 = (fStack_24 - *(float *)(lVar4 + 36)) /
                      ((float)((uint64)*(uint64 *)(lVar4 + 56) >> 32) -
                      (float)((uint64)*(uint64 *)(lVar4 + 32) >> 32));
              if (iVar1 != 3) {
                return fVar6;
              }
            }
            return 1.0 - fVar6;
          }
        }
    }

    // Token : 0x600021E
    // RVA   : 0x1580430   Offset: 0x157EC30   Length: 0xADB
    public virtual void ForceUpdate()
    {
        ulong uVar1;
        bool cVar3;
        int iVar4;
        long lVar5;
        long lVar7;
        ulong uVar8;
        long lVar10;
        uint uVar11;
        float fVar15;
        float fVar16;
        float fVar17;
        float fVar18;
        float fVar19;
        float fVar20;
        float fVar21;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        ulong uStack_90;
        uVar8 = this.mFG;
        bVar2 = false;
        this.mIsDirty = 0;
        cVar3 = Object.op_Inequality(uVar8,0,0);
        plVar12 = (int64 *)0;
        if (cVar3) {
          plVar9 = this.mFG;
          plVar13 = plVar12;
          if (plVar9 != (int64 *)0) {
            plVar13 = plVar9;
          }
          if ((this.mFill == null) || (this.mFill == 1)) {
            cVar3 = Object.op_Inequality(plVar13,0,0);
            if (cVar3) {
              if (plVar13 == (int64 *)0) goto LAB_181580e26;
              iVar4 = (**(code **)(*plVar13 + 0x3a8))(plVar13,*(uint64 *)(*plVar13 + 0x3b0));
              if (iVar4 == 3) {
                if (*(uint32 *)((int64)plVar13 + 0x18c) < 2) {
                  UIBasicSprite.set_fillDirection(plVar13,0,0);
                  iVar4 = this.mFill;
                  if (iVar4 != 1) goto LAB_1815805c9;
                  bVar14 = true;
                  goto LAB_1815805cf;
                }
                goto LAB_1815805da;
              }
            }
            lVar5 = this.mFG;
            if ((this.mFill == 1) || (this.mFill == 3)) {
              UIProgressBar.get_value(this,0);
            }
            else {
              UIProgressBar.get_value(this,0);
            }
          }
          else {
            cVar3 = Object.op_Inequality(plVar13,0,0);
            if (cVar3) {
              if (plVar13 == (int64 *)0) goto LAB_181580e26;
              iVar4 = (**(code **)(*plVar13 + 0x3a8))(plVar13,*(uint64 *)(*plVar13 + 0x3b0));
              if (iVar4 == 3) {
                if (*(uint32 *)((int64)plVar13 + 0x18c) < 2) {
                  UIBasicSprite.set_fillDirection(plVar13,1,0);
                  iVar4 = this.mFill;
                  if (iVar4 == 1) {
                    bVar14 = true;
                  }
                  else {
        LAB_1815805c9:
                    bVar14 = iVar4 == 3;
                  }
        LAB_1815805cf:
                  UIBasicSprite.set_invert(plVar13,bVar14,0);
                }
        LAB_1815805da:
                UIProgressBar.get_value(this,0);
                UIBasicSprite.set_fillAmount(plVar13);
                goto LAB_1815807b7;
              }
            }
            lVar5 = this.mFG;
            if ((this.mFill == 1) || (this.mFill == 3)) {
              UIProgressBar.get_value(this,0);
            }
            else {
              UIProgressBar.get_value(this,0);
            }
          }
          uStack_90 = 0;
          local_98 = 0;
          FUN_1809981e0(&local_98);
          if (lVar5 == null) goto LAB_181580e26;
          UIWidget.set_drawRegion(lVar5,&local_98,0);
          if (this.mFG == null) goto LAB_181580e26;
          Behaviour.set_enabled(this.mFG,1,0);
          fVar15 = this.mValue;
          if (1 < *(int *)(this + 100)) {
            fVar15 = (float)FUN_18000d7c0((float)(*(int *)(this + 100) + -1) * fVar15);
            fVar15 = fVar15 / (float)(*(int *)(this + 100) + -1);
          }
          bVar2 = fVar15 < 0.001;
        }
        LAB_1815807b7:
        uVar8 = this.thumb;
        cVar3 = Object.op_Inequality(uVar8,0,0);
        if (cVar3) {
          uVar8 = this.mFG;
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (!cVar3) {
            uVar8 = this.mBG;
            cVar3 = Object.op_Inequality(uVar8,0,0);
            if (!cVar3) goto LAB_181580c54;
          }
          uVar8 = this.mFG;
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (!cVar3) {
            plVar9 = this.mBG;
          }
          else {
            plVar9 = this.mFG;
          }
          if (plVar9 == (int64 *)0) goto LAB_181580e26;
          lVar5 = (**(code **)(*plVar9 + 0x1d8))(plVar9,*(uint64 *)(*plVar9 + 0x1e0));
          uVar8 = this.mFG;
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (!cVar3) {
            plVar9 = this.mBG;
          }
          else {
            plVar9 = this.mFG;
          }
          if (plVar9 == (int64 *)0) goto LAB_181580e26;
          puVar6 = (uint64 *)
                   (**(code **)(*plVar9 + 0x378))(&local_98,plVar9,*(uint64 *)(*plVar9 + 0x380));
          local_98 = *puVar6;
          uStack_90 = puVar6[1];
          if (lVar5 == null) goto LAB_181580e26;
          uVar11 = *(uint32 *)(lVar5 + 24);
          if (uVar11 == 0) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          *(float *)(lVar5 + 32) = (float)local_98 + *(float *)(lVar5 + 32);
          if (uVar11 < 2) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          *(float *)(lVar5 + 44) = (float)local_98 + *(float *)(lVar5 + 44);
          if (uVar11 < 3) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          *(float *)(lVar5 + 56) = *(float *)(lVar5 + 56) - (float)uStack_90;
          if (uVar11 < 4) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          local_98._4_4_ = (float)((uint64)local_98 >> 32);
          *(float *)(lVar5 + 68) = *(float *)(lVar5 + 68) - (float)uStack_90;
          *(float *)(lVar5 + 36) = local_98._4_4_ + *(float *)(lVar5 + 36);
          uStack_90._4_4_ = (float)((uint64)uStack_90 >> 32);
          *(float *)(lVar5 + 48) = *(float *)(lVar5 + 48) - uStack_90._4_4_;
          *(float *)(lVar5 + 60) = *(float *)(lVar5 + 60) - uStack_90._4_4_;
          *(float *)(lVar5 + 72) = local_98._4_4_ + *(float *)(lVar5 + 72);
          uVar8 = this.mFG;
          cVar3 = Object.op_Inequality(uVar8,0,0);
          if (!cVar3) {
            lVar7 = this.mBG;
          }
          else {
            lVar7 = this.mFG;
          }
          if (lVar7 == null) goto LAB_181580e26;
          lVar7 = UIRect.get_cachedTransform(lVar7,0);
          do {
            uVar11 = (uint32)plVar12;
            lVar10 = (int64)(int)uVar11;
            if (*(uint32 *)(lVar5 + 24) <= uVar11) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            if (lVar7 == null) goto LAB_181580e26;
            local_a8 = *(uint64 *)(lVar5 + 32 + lVar10 * 12);
            local_a0 = *(float *)(lVar5 + 40 + lVar10 * 12);
            puVar6 = (uint64 *)Transform.TransformPoint(&local_98,lVar7,&local_a8,0);
            if (*(uint32 *)(lVar5 + 24) <= uVar11) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            plVar12 = (int64 *)(uint64)(uVar11 + 1);
            *(uint64 *)(lVar5 + 32 + lVar10 * 12) = *puVar6;
            *(uint32 *)(lVar5 + 40 + lVar10 * 12) = *(uint32 *)(puVar6 + 1);
          } while ((int)(uVar11 + 1) < 4);
          if ((this.mFill == null) || (this.mFill == 1)) {
            if (*(uint32 *)(lVar5 + 24) == 0) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            if (*(uint32 *)(lVar5 + 24) < 2) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            uStack_90._0_4_ = *(float *)(lVar5 + 52);
            uVar8 = *(uint64 *)(lVar5 + 44);
            uVar1 = *(uint64 *)(lVar5 + 32);
            local_a0 = *(float *)(lVar5 + 40);
            fVar15 = (float)Mathf.Clamp01();
            local_a8._4_4_ = (float)((uint64)uVar1 >> 32);
            fVar21 = ((float)uStack_90 - local_a0) * fVar15 + local_a0;
            fVar20 = ((float)uVar8 - (float)uVar1) * fVar15 + (float)uVar1;
            fVar15 = ((float)((uint64)uVar8 >> 32) - local_a8._4_4_) * fVar15 + local_a8._4_4_;
            local_a8 = uVar1;
            local_98 = uVar8;
            if (*(uint32 *)(lVar5 + 24) < 3) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            if (*(uint32 *)(lVar5 + 24) < 4) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            uVar8 = *(uint64 *)(lVar5 + 68);
            uVar1 = *(uint64 *)(lVar5 + 56);
            uStack_90 = CONCAT44(uStack_90._4_4_,*(uint32 *)(lVar5 + 76));
            local_a0 = *(float *)(lVar5 + 64);
            fVar16 = (float)Mathf.Clamp01();
            fVar19 = ((float)uVar8 - (float)uVar1) * fVar16 + (float)uVar1;
            local_a8._4_4_ = (float)((uint64)uVar1 >> 32);
            fVar18 = ((float)uStack_90 - local_a0) * fVar16 + local_a0;
            fVar17 = ((float)((uint64)uVar8 >> 32) - local_a8._4_4_) * fVar16 + local_a8._4_4_;
            iVar4 = *(int *)(this + 100);
            fVar16 = this.mValue;
            local_a8 = uVar1;
            local_98 = uVar8;
            if ((this.mFill == 1) || (this.mFill == 3)) goto LAB_181580b95;
            if (1 < iVar4) {
              FUN_18000d7c0((float)(iVar4 + -1) * fVar16);
            }
          }
          else {
            if (*(uint32 *)(lVar5 + 24) == 0) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            if (*(uint32 *)(lVar5 + 24) < 4) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            uStack_90._0_4_ = *(float *)(lVar5 + 76);
            uVar8 = *(uint64 *)(lVar5 + 68);
            uVar1 = *(uint64 *)(lVar5 + 32);
            local_a0 = *(float *)(lVar5 + 40);
            fVar15 = (float)Mathf.Clamp01();
            local_a8._4_4_ = (float)((uint64)uVar1 >> 32);
            fVar21 = ((float)uStack_90 - local_a0) * fVar15 + local_a0;
            fVar20 = ((float)uVar8 - (float)uVar1) * fVar15 + (float)uVar1;
            fVar15 = ((float)((uint64)uVar8 >> 32) - local_a8._4_4_) * fVar15 + local_a8._4_4_;
            local_a8 = uVar1;
            local_98 = uVar8;
            if (*(uint32 *)(lVar5 + 24) < 2) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            if (*(uint32 *)(lVar5 + 24) < 3) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            uVar8 = *(uint64 *)(lVar5 + 56);
            uVar1 = *(uint64 *)(lVar5 + 44);
            uStack_90 = CONCAT44(uStack_90._4_4_,*(uint32 *)(lVar5 + 64));
            local_a0 = *(float *)(lVar5 + 52);
            fVar16 = (float)Mathf.Clamp01();
            fVar19 = ((float)uVar8 - (float)uVar1) * fVar16 + (float)uVar1;
            local_a8._4_4_ = (float)((uint64)uVar1 >> 32);
            fVar18 = ((float)uStack_90 - local_a0) * fVar16 + local_a0;
            fVar17 = ((float)((uint64)uVar8 >> 32) - local_a8._4_4_) * fVar16 + local_a8._4_4_;
            iVar4 = *(int *)(this + 100);
            fVar16 = this.mValue;
            local_a8 = uVar1;
            local_98 = uVar8;
            if ((this.mFill == 1) || (this.mFill == 3)) {
        LAB_181580b95:
              if (1 < iVar4) {
                FUN_18000d7c0((float)(iVar4 + -1) * fVar16);
              }
            }
            else if (1 < iVar4) {
              FUN_18000d7c0((float)(iVar4 + -1) * fVar16);
            }
          }
          fVar16 = (float)Mathf.Clamp01();
          local_a0 = (fVar18 - fVar21) * fVar16 + fVar21;
          uStack_90 = CONCAT44(uStack_90._4_4_,local_a0);
          local_98 = CONCAT44((fVar17 - fVar15) * fVar16 + fVar15,(fVar19 - fVar20) * fVar16 + fVar20);
          UIProgressBar.SetThumbPosition(this,&local_98,0);
        }
        LAB_181580c54:
        if (bVar2) {
          if (this.mFG == null) {
        LAB_181580e26:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Behaviour.set_enabled(this.mFG,0,0);
        }
    }

    // Token : 0x600021F
    // RVA   : 0x1581560   Offset: 0x157FD60   Length: 0x1FF
    protected void SetThumbPosition(Vector3 worldPos)
    {
        bool cVar1;
        long lVar2;
        float fVar4;
        uint uVar5;
        uint uVar6;
        ulong local_38;
        uint local_30;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (this.thumb != null) {
          lVar2 = FUN_180da0f00(this.thumb,0);
          cVar1 = Object.op_Inequality(lVar2,0,0);
          if (!cVar1) {
            if (this.thumb != null) {
              local_38 = *worldPos;
              local_30 = *(uint32 *)(worldPos + 1);
              puVar3 = (uint64 *)Transform.get_position(local_18,this.thumb,0);
              local_28 = *puVar3;
              local_20 = *(uint32 *)(puVar3 + 1);
              fVar4 = (float)Vector3.Distance(&local_28,&local_38,0);
              if (1e-05 < fVar4) {
                if (this.thumb == null) throw; // [null/range check failed]
                local_28 = *worldPos;
                local_20 = *(uint32 *)(worldPos + 1);
                Transform.set_position(this.thumb,&local_28,0);
              }
              return;
            }
          }
          else if (lVar2 != null) {
            local_28 = *worldPos;
            local_20 = *(uint32 *)(worldPos + 1);
            puVar3 = (uint64 *)Transform.InverseTransformPoint(local_18,lVar2,&local_28,0);
            uVar5 = *(uint32 *)(puVar3 + 1);
            *worldPos = *puVar3;
            *(uint32 *)(worldPos + 1) = uVar5;
            uVar5 = FUN_18000d7c0(*(uint32 *)worldPos);
            uVar6 = (uint32)((uint64)*worldPos >> 32);
            local_28 = CONCAT44(uVar6,uVar5);
            *worldPos = local_28;
            local_20 = *(uint32 *)(worldPos + 1);
            uVar5 = FUN_18000d7c0(CONCAT44(uVar6,uVar6));
            lVar2 = this.thumb;
            *(uint32 *)((int64)worldPos + 4) = uVar5;
            *(uint32 *)(worldPos + 1) = 0;
            if (lVar2 != null) {
              local_28 = *worldPos;
              local_20 = *(uint32 *)(worldPos + 1);
              puVar3 = (uint64 *)Transform.get_localPosition(local_18,lVar2,0);
              local_38 = *puVar3;
              local_30 = *(uint32 *)(puVar3 + 1);
              fVar4 = (float)Vector3.Distance(&local_38,&local_28,0);
              if (fVar4 <= 0.001) {
                return;
              }
              if (this.thumb != null) {
                local_28 = *worldPos;
                local_20 = *(uint32 *)(worldPos + 1);
                Transform.set_localPosition(this.thumb,&local_28,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000220
    // RVA   : 0x1581090   Offset: 0x157F890   Length: 0x8C
    public virtual void OnPan(Vector2 delta)
    {
        int iVar1;
        bool cVar2;
        uint uVar3;
        float local_28;
        float fStack_24;
        cVar2 = Behaviour.get_enabled(this,0);
        if (!cVar2) {
          return;
        }
        iVar1 = this.mFill;
        local_28 = (float)delta;
        if (iVar1 != 0) {
          if (iVar1 == 1) {
            fStack_24 = this.mValue - local_28;
            goto LAB_1815810f1;
          }
          fStack_24 = (float)((uint64)delta >> 32);
          local_28 = fStack_24;
          if (iVar1 != 2) {
            if (iVar1 != 3) {
              return;
            }
            fStack_24 = this.mValue - fStack_24;
            goto LAB_1815810f1;
          }
        }
        fStack_24 = local_28 + this.mValue;
        LAB_1815810f1:
        uVar3 = Mathf.Clamp01(fStack_24,0);
        UIProgressBar.Set(this,uVar3,1,0);
        this.mValue = uVar3;
    }

    // Token : 0x6000221
    // RVA   : 0x1581B00   Offset: 0x1580300   Length: 0x7D
    public void /*ctor*/()
    {
        ulong uVar1;
        this.mValue = 0x3f800000;
        uVar1 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar1,DAT_181d5e700);
        this.onChange = uVar1;
        TrailRenderer_Base.ctor(this,0);
    }

}
