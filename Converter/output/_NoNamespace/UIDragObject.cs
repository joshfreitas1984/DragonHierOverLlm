// ============================================================
// Type  : UIDragObject
// Token : 0x200003F
// ============================================================

public class UIDragObject
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000124
    public Transform target;

    // Token: 0x4000125
    public UIPanel panelRegion;

    // Token: 0x4000126
    public Vector3 scrollMomentum;

    // Token: 0x4000127
    public bool restrictWithinPanel;

    // Token: 0x4000128
    public UIRect contentRect;

    // Token: 0x4000129
    public DragEffect dragEffect;

    // Token: 0x400012A
    public float momentumAmount;

    // Token: 0x400012B
    protected Vector3 scale;

    // Token: 0x400012C
    private float scrollWheelFactor;

    // Token: 0x400012D
    private Plane mPlane;

    // Token: 0x400012E
    private Vector3 mTargetPos;

    // Token: 0x400012F
    private Vector3 mLastPos;

    // Token: 0x4000130
    private Vector3 mMomentum;

    // Token: 0x4000131
    private Vector3 mScroll;

    // Token: 0x4000132
    private Bounds mBounds;

    // Token: 0x4000133
    private int mTouchID;

    // Token: 0x4000134
    private bool mStarted;

    // Token: 0x4000135
    private bool mPressed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000116
    // RVA   : 0x13DA450   Offset: 0x13D8C50   Length: 0x13
    public Vector3 get_dragMovement()
    {
        uint64 * FUN_1813da450(uint64 *this,int64 param_2)
        {
        uint32 uVar1;
        uVar1 = *(uint32 *)(param_2 + 80);
        *this = *(uint64 *)(param_2 + 72);
        *(uint32 *)(this + 1) = uVar1;
        return this;
    }

    // Token : 0x6000117
    // RVA   : 0x13DA470   Offset: 0x13D8C70   Length: 0x10
    public void set_dragMovement(Vector3 value)
    {
        void FUN_1813da470(int64 this,uint64 *value)
        {
        uint32 uVar1;
        uVar1 = *(uint32 *)(value + 1);
        this.scale = *value;
        *(uint32 *)(this + 80) = uVar1;
    }

    // Token : 0x6000118
    // RVA   : 0x13D99A0   Offset: 0x13D81A0   Length: 0x1EF
    private void OnEnable()
    {
        float fVar1;
        uint uVar2;
        bool cVar3;
        ulong uVar4;
        ulong local_18;
        float local_10;
        fVar1 = this.scrollWheelFactor;
        if (fVar1 != 0.0) {
          local_18 = this.scale;
          local_10 = *(float *)(this + 80) * fVar1;
          this.scrollMomentum =
               CONCAT44((float)((uint64)local_18 >> 32) * fVar1,(float)local_18 * fVar1);
          *(float *)(this + 48) = local_10;
          this.scrollWheelFactor = 0;
        }
        uVar4 = this.contentRect;
        cVar3 = Object.op_Equality(uVar4,0,0);
        if (cVar3) {
          uVar4 = this.target;
          cVar3 = Object.op_Inequality(uVar4,0,0);
          if ((cVar3) && (cVar3 = Application.get_isPlaying(0), cVar3)) {
            if (this.target == null) goto LAB_1813d9b8a;
            uVar4 = Component.GetComponent(this.target,DAT_181d6e7c0);
            cVar3 = Object.op_Inequality(uVar4,0,0);
            if (cVar3) {
              this.contentRect = uVar4;
            }
          }
        }
        uVar4 = this.target;
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          puVar5 = (uint64 *)Vector3.get_zero(&local_18,0);
        }
        else {
          if (this.target == null) {
        LAB_1813d9b8a:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar5 = (uint64 *)Transform.get_position(&local_18,this.target,0);
        }
        uVar2 = *(uint32 *)(puVar5 + 1);
        this.mTargetPos = *puVar5;
        *(uint32 *)(this + 112) = uVar2;
    }

    // Token : 0x6000119
    // RVA   : 0x13D92A0   Offset: 0x13D7AA0   Length: 0x8
    private void OnDisable()
    {
        void FUN_1813d92a0(int64 this)
        {
        this.mStarted = 0;
    }

    // Token : 0x600011A
    // RVA   : 0x13D89B0   Offset: 0x13D71B0   Length: 0x115
    private void FindPanel()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = this.target;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          if (this.target != null) {
            lVar2 = Component.get_transform(this.target,0);
            if (lVar2 != null) {
              uVar3 = FUN_180da0f00(lVar2,0);
              uVar3 = UIPanel.Find(uVar3,0);
              goto LAB_1813d8a6e;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar3 = 0;
        LAB_1813d8a6e:
        this.panelRegion = uVar3;
        uVar3 = this.panelRegion;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          this.restrictWithinPanel = 0;
        }
    }

    // Token : 0x600011B
    // RVA   : 0x13DA100   Offset: 0x13D8900   Length: 0x297
    private void UpdateBounds()
    {
        long lVar1;
        uint uVar2;
        bool cVar4;
        ulong uVar5;
        long lVar7;
        long lVar8;
        uint uVar9;
        ulong local_d8;
        uint local_d0;
        ulong local_c8;
        uint local_c0;
        ulong local_b8;
        ulong uStack_b0;
        ulong local_a8;
        ulong local_98;
        ulong uStack_90;
        ulong local_88;
        ulong uStack_80;
        uint local_78;
        uint uStack_74;
        uint uStack_70;
        uint32 uStack_6c;
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        uint8 local_58 [64];
        uVar5 = this.contentRect;
        cVar4 = Object.op_Implicit(uVar5,0);
        lVar7 = this.panelRegion;
        if (!cVar4) {
          if (lVar7 != null) {
            uVar5 = UIRect.get_cachedTransform(lVar7,0);
            puVar6 = (uint64 *)
                     NGUIMath.CalculateRelativeWidgetBounds
                               (&local_b8,uVar5,this.target,0);
            uVar5 = puVar6[1];
            this.mBounds = *puVar6;
            *(uint64 *)(this + 160) = uVar5;
            *(uint64 *)(this + 168) = puVar6[2];
            return;
          }
        }
        else if ((lVar7 != null) && (lVar7 = UIRect.get_cachedTransform(lVar7,0)) != null) {
          puVar6 = (uint64 *)Transform.get_worldToLocalMatrix(local_58,lVar7,0);
          plVar3 = this.contentRect;
          local_98 = *puVar6;
          uStack_90 = puVar6[1];
          local_88 = puVar6[2];
          uStack_80 = puVar6[3];
          local_78 = *(uint32 *)(puVar6 + 4);
          uStack_74 = *(uint32 *)((int64)puVar6 + 36);
          uStack_70 = *(uint32 *)(puVar6 + 5);
          uStack_6c = *(uint32 *)((int64)puVar6 + 44);
          local_68 = *(uint32 *)(puVar6 + 6);
          uStack_64 = *(uint32 *)((int64)puVar6 + 52);
          uStack_60 = *(uint32 *)(puVar6 + 7);
          uStack_5c = *(uint32 *)((int64)puVar6 + 60);
          if (plVar3 != (int64 *)0) {
            lVar7 = (**(code **)(*plVar3 + 0x1e8))(plVar3,*(uint64 *)(*plVar3 + 0x1f0));
            uVar9 = 0;
            while (lVar7 != null) {
              lVar8 = (int64)(int)uVar9;
              if (*(uint32 *)(lVar7 + 24) <= uVar9) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              local_c8 = *(uint64 *)(lVar7 + 32 + lVar8 * 12);
              lVar1 = lVar7 + lVar8 * 12;
              local_c0 = *(uint32 *)(lVar7 + 40 + lVar8 * 12);
              puVar6 = (uint64 *)Matrix4x4.MultiplyPoint3x4(&local_d8,&local_98,&local_c8,0);
              if (*(uint32 *)(lVar7 + 24) <= uVar9) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              uVar9 = uVar9 + 1;
              *(uint64 *)(lVar1 + 32) = *puVar6;
              *(uint32 *)(lVar1 + 40) = *(uint32 *)(puVar6 + 1);
              if (3 < (int)uVar9) {
                if (*(int *)(lVar7 + 24) == 0) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                uVar5 = *(uint64 *)(lVar7 + 32);
                uVar2 = *(uint32 *)(lVar7 + 40);
                puVar6 = (uint64 *)Vector3.get_zero(&local_d8,0);
                local_c0 = *(uint32 *)(puVar6 + 1);
                local_c8 = *puVar6;
                local_b8 = 0;
                uStack_b0 = 0;
                local_a8 = 0;
                local_d8 = uVar5;
                local_d0 = uVar2;
                Bounds.ctor(&local_b8,&local_d8,&local_c8,0);
                uVar9 = 1;
                this.mBounds = (uint32)local_b8;
                *(uint32 *)(this + 156) = local_b8._4_4_;
                *(uint32 *)(this + 160) = (uint32)uStack_b0;
                *(uint32 *)(this + 164) = uStack_b0._4_4_;
                *(uint64 *)(this + 168) = local_a8;
                do {
                  if (*(uint32 *)(lVar7 + 24) <= uVar9) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  local_d8 = lVar7[uVar9];
                  local_d0 = *(uint32 *)(lVar7 + 40 + (int64)(int)uVar9 * 12);
                  Bounds.Encapsulate(this + 152,&local_d8,0);
                  uVar9 = uVar9 + 1;
                } while ((int)uVar9 < 4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600011C
    // RVA   : 0x13D9B90   Offset: 0x13D8390   Length: 0x44F
    private void OnPress(bool pressed)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        int iVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        long lVar5;
        float fVar7;
        ulong local_58;
        uint local_50;
        ulong local_48;
        uint local_40;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        if (*(int *)(pStatics + 212) != -2) {
          if ((*(int *)(pStatics + 212) != -3) &&
             (((fVar7 = (float)Time.get_timeScale(0), 0.01 <= fVar7 || (fVar7 == 0.0)) &&
              (cVar3 = Behaviour.get_enabled(this,0), cVar3)))) {
            uVar4 = Component.get_gameObject(this,0);
            cVar3 = NGUITools.GetActive(uVar4,0);
            if (cVar3) {
              uVar4 = this.target;
              cVar3 = Object.op_Inequality(uVar4,0,0);
              if (cVar3) {
                if (!pressed) {
                  if (this.mPressed) {
                    iVar1 = this.mTouchID;
                    if (((iVar1 == *(int *)(pStatics + 212)) &&
                        (this.mPressed = 0, this.restrictWithinPanel)) &&
                       (this.dragEffect == 2)) {
                      if (this.panelRegion == null) goto LAB_1813d9fda;
                      cVar3 = UIPanel.ConstrainTargetToBounds
                                        (this.panelRegion,this.target,
                                         this + 152,0,0);
                      if (cVar3) {
                        UIDragObject.CancelMovement(this,0);
                      }
                    }
                  }
                }
                else if (!this.mPressed) {
                  this.mTouchID =
                       *(uint32 *)(pStatics + 212);
                  this.mStarted = 0x100;
                  UIDragObject.CancelMovement(this,0);
                  if (this.restrictWithinPanel) {
                    uVar4 = this.panelRegion;
                    cVar3 = Object.op_Equality(uVar4,0,0);
                    if (cVar3) {
                      UIDragObject.FindPanel(this,0);
                    }
                    if (this.restrictWithinPanel) {
                      UIDragObject.UpdateBounds(this,0);
                    }
                  }
                  UIDragObject.CancelSpring(this,0);
                  lVar5 = *(int64 *)(pStatics + 192);
                  if (lVar5 != null) {
                    lVar5 = Component.get_transform(lVar5,0);
                    uVar4 = this.panelRegion;
                    cVar3 = Object.op_Inequality(uVar4,0,0);
                    if (cVar3) {
                      if (this.panelRegion == null) goto LAB_1813d9fda;
                      lVar5 = UIRect.get_cachedTransform(this.panelRegion,0);
                    }
                    if (lVar5 != null) {
                      puVar6 = (uint64 *)Transform.get_rotation(&local_28,lVar5,0);
                      uVar4 = *puVar6;
                      uVar2 = puVar6[1];
                      puVar6 = (uint64 *)Vector3.get_back(&local_48,0);
                      local_58 = *puVar6;
                      local_50 = *(uint32 *)(puVar6 + 1);
                      local_28 = uVar4;
                      uStack_20 = uVar2;
                      puVar6 = (uint64 *)Quaternion.op_Multiply(&local_48,&local_28,&local_58,0);
                      local_48 = *puVar6;
                      local_40 = *(uint32 *)(puVar6 + 1);
                      local_50 = *(uint32 *)(pStatics + 108);
                      local_58 = *(uint64 *)(pStatics + 100);
                      local_38 = 0;
                      uStack_30 = 0;
                      Plane.ctor(&local_38,&local_48,&local_58,0);
                      this.mPlane = local_38;
                      *(uint64 *)(this + 96) = uStack_30;
                      return;
                    }
                  }
        LAB_1813d9fda:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
              }
            }
          }
        }
    }

    // Token : 0x600011D
    // RVA   : 0x13D92B0   Offset: 0x13D7AB0   Length: 0x6E0
    private void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        bool cVar4;
        ulong uVar5;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        uint[] local_res8 = new uint[2];
        ulong local_f8;
        float local_f0;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        float local_d0;
        ulong local_c8;
        float local_c0;
        uint local_b8;
        uint uStack_b4;
        uint uStack_b0;
        uint32 uStack_ac;
        uint64 local_a8;
        uint32 local_98;
        uint32 uStack_94;
        uint32 uStack_90;
        uint32 uStack_8c;
        uint64 local_88;
        if (this.mPressed) {
          iVar1 = this.mTouchID;
          if ((iVar1 == *(int *)(pStatics + 212)) &&
             (cVar4 = Behaviour.get_enabled(this,0), cVar4)) {
            uVar5 = Component.get_gameObject(this,0);
            cVar4 = NGUITools.GetActive(uVar5,0);
            if (cVar4) {
              uVar5 = this.target;
              cVar4 = Object.op_Inequality(uVar5,0,0);
              if (cVar4) {
                lVar2 = *(int64 *)(pStatics + 224);
                fVar8 = local_e0;
                if (lVar2 != null) {
                  *(uint32 *)(lVar2 + 112) = 2;
                  lVar2 = *(int64 *)(pStatics + 224);
                  lVar3 = *(int64 *)(pStatics + 192);
                  if ((lVar2 != null) && (lVar3 != null)) {
                    local_e0 = 0.0;
                    local_e8 = *(uint64 *)(lVar2 + 20);
                    puVar6 = (uint32 *)Camera.ScreenPointToRay(&local_b8,lVar3,&local_e8,0);
                    local_b8 = *puVar6;
                    uStack_b4 = puVar6[1];
                    uStack_b0 = puVar6[2];
                    uStack_ac = puVar6[3];
                    local_a8 = *(uint64 *)(puVar6 + 4);
                    local_res8[0] = 0;
                    local_98 = local_b8;
                    uStack_94 = uStack_b4;
                    uStack_90 = uStack_b0;
                    uStack_8c = uStack_ac;
                    local_88 = local_a8;
                    cVar4 = Plane.Raycast(this + 88,&local_b8,local_res8,0);
                    if (!cVar4) {
                      return;
                    }
                    puVar7 = (uint64 *)Ray.GetPoint(&local_c8,&local_98,local_res8[0],0);
                    local_d8 = this.mLastPos;
                    local_e8 = *puVar7;
                    local_e0 = *(float *)(puVar7 + 1);
                    local_d0 = *(float *)(this + 124);
                    fVar13 = (float)local_e8 - (float)local_d8;
                    fVar12 = (float)((uint64)local_e8 >> 32) - (float)((uint64)local_d8 >> 32);
                    local_f0 = local_e0 - local_d0;
                    this.mLastPos = *puVar7;
                    *(uint32 *)(this + 124) = *(uint32 *)(puVar7 + 1);
                    if (!this.mStarted) {
                      this.mStarted = 1;
                      puVar7 = (uint64 *)Vector3.get_zero(&local_c8,0);
                      fVar13 = (float)*puVar7;
                      fVar12 = (float)((uint64)*puVar7 >> 32);
                      local_f0 = *(float *)(puVar7 + 1);
                    }
                    if ((fVar13 != 0.0) || (fVar12 != 0.0)) {
                      fVar8 = local_e0;
                      if (this.target == null) goto LAB_1813d998b;
                      local_e8 = CONCAT44(fVar12,fVar13);
                      local_e0 = local_f0;
                      puVar7 = (uint64 *)
                               Transform.InverseTransformDirection
                                         (&local_c8,this.target,&local_e8,0);
                      local_d8 = this.scale;
                      local_d0 = *(float *)(this + 80);
                      local_f8._4_4_ = (float)((uint64)*puVar7 >> 32);
                      local_f8 = CONCAT44((float)((uint64)local_d8 >> 32) * local_f8._4_4_,
                                          (float)this.scale * (float)*puVar7);
                      local_e0 = local_d0 * *(float *)(puVar7 + 1);
                      local_e8 = local_d8;
                      fVar8 = local_d0;
                      if (this.target == null) goto LAB_1813d998b;
                      local_e8 = local_f8;
                      puVar7 = (uint64 *)
                               Transform.TransformDirection
                                         (&local_c8,this.target,&local_e8,0);
                      fVar13 = (float)*puVar7;
                      fVar12 = (float)((uint64)*puVar7 >> 32);
                      local_f0 = *(float *)(puVar7 + 1);
                    }
                    if (this.dragEffect != null) {
                      fVar11 = this.momentumAmount * 0.01;
                      local_e0 = *(float *)(this + 136);
                      uVar5 = this.mMomentum;
                      fVar9 = (float)uVar5;
                      fVar10 = (float)((uint64)uVar5 >> 32);
                      local_d8 = uVar5;
                      local_d0 = local_e0;
                      local_c0 = local_e0;
                      fVar8 = (float)Mathf.Clamp01(0x3f2b851f,0);
                      local_c0 = ((local_f0 * fVar11 + local_d0) - local_e0) * fVar8 + local_e0;
                      this.mMomentum =
                           CONCAT44(((fVar12 * fVar11 + fVar10) - fVar10) * fVar8 + fVar10,
                                    ((fVar13 * fVar11 + fVar9) - fVar9) * fVar8 + fVar9);
                      *(float *)(this + 136) = local_c0;
                      local_e8 = uVar5;
                      local_c8 = uVar5;
                    }
                    fVar8 = local_e0;
                    if (this.target != null) {
                      puVar7 = (uint64 *)
                               Transform.get_localPosition(&local_c8,this.target,0);
                      local_d8 = CONCAT44(fVar12,fVar13);
                      uVar5 = *puVar7;
                      fVar13 = *(float *)(puVar7 + 1);
                      local_d0 = local_f0;
                      UIDragObject.Move(this,&local_d8,0);
                      if (!this.restrictWithinPanel) {
                        return;
                      }
                      puVar7 = (uint64 *)FUN_18045e0a0(&local_c8,this + 152,0);
                      local_e8 = *puVar7;
                      local_e0 = *(float *)(puVar7 + 1);
                      fVar8 = local_e0;
                      if (this.target != null) {
                        puVar7 = (uint64 *)
                                 Transform.get_localPosition(&local_b8,this.target,0);
                        local_f8._0_4_ = (float)uVar5;
                        local_f8._4_4_ = (float)((uint64)uVar5 >> 32);
                        local_d0 = (*(float *)(puVar7 + 1) - fVar13) + local_e0;
                        local_d8 = CONCAT44(((float)((uint64)*puVar7 >> 32) - local_f8._4_4_) +
                                            local_e8._4_4_,
                                            ((float)*puVar7 - (float)local_f8) + (float)local_e8);
                        local_c0 = local_d0;
                        FUN_1804652d0(this + 152,&local_d8,0);
                        if (this.dragEffect == 2) {
                          return;
                        }
                        fVar8 = local_e0;
                        if (this.panelRegion != null) {
                          cVar4 = UIPanel.ConstrainTargetToBounds
                                            (this.panelRegion,this.target
                                             ,this + 152,1,0);
                          if (!cVar4) {
                            return;
                          }
                          UIDragObject.CancelMovement(this,0);
                          return;
                        }
                      }
                    }
                  }
                }
        LAB_1813d998b:
                local_e0 = fVar8;
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
            }
          }
        }
    }

    // Token : 0x600011E
    // RVA   : 0x13D8E20   Offset: 0x13D7620   Length: 0x479
    private void Move(Vector3 worldDelta)
    {
        float fVar1;
        ulong uVar2;
        bool cVar3;
        long lVar5;
        long lVar6;
        uint uVar8;
        uint uVar9;
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        float local_b0;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        ulong uStack_90;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong uStack_70;
        ulong local_68;
        ulong uStack_60;
        byte[] local_58 = new byte[80];
        uVar2 = this.panelRegion;
        local_98 = 0;
        uStack_90 = 0;
        local_88 = 0;
        uStack_80 = 0;
        local_78 = 0;
        uStack_70 = 0;
        local_68 = 0;
        uStack_60 = 0;
        cVar3 = Object.op_Inequality(uVar2,0,0);
        lVar5 = this.target;
        if (!cVar3) {
          if (lVar5 != null) {
            local_b0 = *(float *)(worldDelta + 1);
            uVar2 = *worldDelta;
            puVar4 = (uint64 *)Transform.get_position(&local_c8,lVar5,0);
            local_a0 = *(float *)(puVar4 + 1);
            local_c0 = local_a0 + *(float *)(worldDelta + 1);
            local_c8 = CONCAT44((float)((uint64)*puVar4 >> 32) + (float)((uint64)uVar2 >> 32),
                                (float)*puVar4 + (float)uVar2);
            local_b0 = local_c0;
            Transform.set_position(lVar5,&local_c8,0);
            return;
          }
          goto LAB_1813d9294;
        }
        local_c8 = this.mTargetPos;
        local_b8 = *worldDelta;
        local_c0 = *(float *)(this + 112);
        local_a0 = *(float *)(worldDelta + 1);
        local_b0 = local_c0 + local_a0;
        this.mTargetPos =
             CONCAT44((float)((uint64)local_c8 >> 32) + (float)((uint64)local_b8 >> 32),
                      (float)local_b8 + (float)local_c8);
        *(float *)(this + 112) = local_b0;
        local_a8 = local_b8;
        if (lVar5 == null) goto LAB_1813d9294;
        lVar5 = FUN_180da0f00(lVar5,0);
        if (this.target == null) goto LAB_1813d9294;
        lVar6 = Component.GetComponent(this.target,DAT_181d6c840);
        cVar3 = Object.op_Inequality(lVar5,0,0);
        if (!cVar3) {
          cVar3 = Object.op_Inequality(lVar6,0,0);
          if (!cVar3) {
            if (this.target == null) goto LAB_1813d9294;
            local_c8 = this.mTargetPos;
            local_c0 = *(float *)(this + 112);
            Transform.set_position(this.target,&local_c8,0);
          }
          else {
            if (lVar6 == null) goto LAB_1813d9294;
            uVar8 = (uint32)this.mTargetPos;
            uVar9 = (uint32)((uint64)this.mTargetPos >> 32);
            local_c0 = *(float *)(this + 112);
        LAB_1813d9213:
            local_c8 = CONCAT44(uVar9,uVar8);
            Rigidbody.set_position(lVar6,&local_c8,0);
          }
        }
        else {
          if (lVar5 == null) goto LAB_1813d9294;
          puVar4 = (uint64 *)Transform.get_worldToLocalMatrix(local_58,lVar5,0);
          local_98 = *puVar4;
          uStack_90 = puVar4[1];
          local_88 = puVar4[2];
          uStack_80 = puVar4[3];
          local_78 = puVar4[4];
          uStack_70 = puVar4[5];
          local_68 = puVar4[6];
          uStack_60 = puVar4[7];
          local_c0 = *(float *)(this + 112);
          local_c8 = this.mTargetPos;
          puVar4 = (uint64 *)Matrix4x4.MultiplyPoint3x4(&local_b8,&local_98,&local_c8,0);
          local_a8 = *puVar4;
          fVar1 = *(float *)(puVar4 + 1);
          uVar8 = FUN_18000d7c0((int)local_a8);
          local_a8 = CONCAT44(local_a8._4_4_,uVar8);
          uVar8 = FUN_18000d7c0(local_a8._4_4_);
          local_a8 = CONCAT44(uVar8,(uint32)local_a8);
          cVar3 = Object.op_Inequality(lVar6,0,0);
          if (cVar3) {
            puVar4 = (uint64 *)Transform.get_localToWorldMatrix(local_58,lVar5,0);
            local_98 = *puVar4;
            uStack_90 = puVar4[1];
            local_88 = puVar4[2];
            uStack_80 = puVar4[3];
            local_78 = puVar4[4];
            uStack_70 = puVar4[5];
            local_68 = puVar4[6];
            uStack_60 = puVar4[7];
            local_c8 = local_a8;
            local_c0 = fVar1;
            puVar4 = (uint64 *)Matrix4x4.MultiplyPoint3x4(&local_b8,&local_98,&local_c8,0);
            if (lVar6 == null) goto LAB_1813d9294;
            uVar8 = (uint32)*puVar4;
            uVar9 = (uint32)((uint64)*puVar4 >> 32);
            local_c0 = *(float *)(puVar4 + 1);
            goto LAB_1813d9213;
          }
          if (this.target == null) goto LAB_1813d9294;
          local_c8 = local_a8;
          local_c0 = fVar1;
          Transform.set_localPosition(this.target,&local_c8,0);
        }
        if (this.panelRegion == null) {
        LAB_1813d9294:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        plVar7 = (int64 *)Component.GetComponent(this.panelRegion,DAT_181d6e540);
        cVar3 = Object.op_Inequality(plVar7,0,0);
        if (cVar3) {
          if (plVar7 == (int64 *)0) goto LAB_1813d9294;
          (**(code **)(*plVar7 + 0x1b8))(plVar7,1,*(uint64 *)(*plVar7 + 0x1c0));
        }
    }

    // Token : 0x600011F
    // RVA   : 0x13D8AD0   Offset: 0x13D72D0   Length: 0x348
    private void LateUpdate()
    {
        uint uVar2;
        ulong uVar3;
        bool cVar4;
        uint uVar6;
        float fVar7;
        ulong in_stack_ffffffffffffff88;
        uint uVar8;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        uVar8 = (uint32)((uint64)in_stack_ffffffffffffff88 >> 32);
        uVar3 = this.target;
        cVar4 = Object.op_Equality(uVar3,0,0);
        if (!cVar4) {
          uVar6 = RealTime.get_deltaTime(0);
          uVar3 = this.mScroll;
          local_68 = this.mMomentum;
          local_60 = *(float *)(this + 136);
          local_50 = *(float *)(this + 148);
          local_40 = local_60 - local_50;
          uVar2 = *(uint32 *)(this + 148);
          *puVar1 = CONCAT44((float)((uint64)local_68 >> 32) - (float)((uint64)uVar3 >> 32),
                             (float)local_68 - (float)uVar3);
          *(float *)(this + 136) = local_40;
          local_58 = uVar3;
          local_48 = uVar3;
          puVar5 = (uint64 *)Vector3.get_zero(&local_48,0);
          local_58 = *puVar5;
          local_50 = *(float *)(puVar5 + 1);
          local_68 = uVar3;
          local_60 = (float)uVar2;
          puVar5 = (uint64 *)
                   NGUIMath.SpringLerp(&local_48,&local_68,&local_58,0x41a00000,CONCAT44(uVar8,uVar6),0);
          this.mScroll = *puVar5;
          *(uint32 *)(this + 148) = *(uint32 *)(puVar5 + 1);
          fVar7 = (float)Vector3.get_magnitude(puVar1,0);
          if (0.0001 <= fVar7) {
            if (!this.mPressed) {
              uVar3 = this.panelRegion;
              cVar4 = Object.op_Equality(uVar3,0,0);
              if (cVar4) {
                UIDragObject.FindPanel(this,0);
              }
              puVar5 = (uint64 *)NGUIMath.SpringDampen(&local_48,puVar1,0x41100000,uVar6,0);
              local_58 = *puVar5;
              local_50 = *(float *)(puVar5 + 1);
              UIDragObject.Move(this,&local_58,0);
              if (this.restrictWithinPanel) {
                uVar3 = this.panelRegion;
                cVar4 = Object.op_Inequality(uVar3,0,0);
                if (cVar4) {
                  UIDragObject.UpdateBounds(this,0);
                  if (this.panelRegion == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  cVar4 = UIPanel.ConstrainTargetToBounds
                                    (this.panelRegion,this.target,
                                     this + 152,this.dragEffect == null,0);
                  if (!cVar4) {
                    UIDragObject.CancelSpring();
                  }
                  else {
                    UIDragObject.CancelMovement(this,0);
                  }
                }
              }
              NGUIMath.SpringDampen(&local_48,puVar1,0x41100000,uVar6,0);
              fVar7 = (float)Vector3.get_magnitude(puVar1,0);
              if (fVar7 < 0.0001) {
                UIDragObject.CancelMovement(this,0);
              }
            }
            else {
              NGUIMath.SpringDampen(&local_48,puVar1,0x41100000,uVar6,0);
            }
          }
        }
    }

    // Token : 0x6000120
    // RVA   : 0x13D8750   Offset: 0x13D6F50   Length: 0x1BC
    public void CancelMovement()
    {
        uint uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        ulong local_28;
        ulong local_18;
        float local_10;
        uVar2 = this.target;
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (cVar3) {
          if (this.target == null) goto LAB_1813d8907;
          Transform.get_localPosition(&local_18,this.target,0);
          iVar4 = Mathf.RoundToInt();
          iVar5 = Mathf.RoundToInt();
          local_28 = CONCAT44((float)iVar5,(float)iVar4);
          iVar4 = Mathf.RoundToInt();
          if (this.target == null) goto LAB_1813d8907;
          local_18 = local_28;
          local_10 = (float)iVar4;
          Transform.set_localPosition(this.target,&local_18,0);
        }
        uVar2 = this.target;
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (!cVar3) {
          puVar6 = (uint64 *)Vector3.get_zero(&local_18,0);
        }
        else {
          if (this.target == null) {
        LAB_1813d8907:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar6 = (uint64 *)Transform.get_position(&local_18,this.target,0);
        }
        uVar1 = *(uint32 *)(puVar6 + 1);
        this.mTargetPos = *puVar6;
        *(uint32 *)(this + 112) = uVar1;
        puVar6 = (uint64 *)Vector3.get_zero(&local_18,0);
        this.mMomentum = *puVar6;
        *(uint32 *)(this + 136) = *(uint32 *)(puVar6 + 1);
        puVar6 = (uint64 *)Vector3.get_zero(&local_18,0);
        this.mScroll = *puVar6;
        *(uint32 *)(this + 148) = *(uint32 *)(puVar6 + 1);
    }

    // Token : 0x6000121
    // RVA   : 0x13D8910   Offset: 0x13D7110   Length: 0x9A
    public void CancelSpring()
    {
        long lVar1;
        bool cVar2;
        if (this.target != null) {
          lVar1 = Component.GetComponent(this.target,DAT_181d6d4c0);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            return;
          }
          if (lVar1 != null) {
            Behaviour.set_enabled(lVar1,0,0);
            return;
          }
        }
    }

    // Token : 0x6000122
    // RVA   : 0x13D9FE0   Offset: 0x13D87E0   Length: 0x117
    private void OnScroll(float delta)
    {
        bool cVar1;
        ulong uVar2;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          cVar1 = NGUITools.GetActive(uVar2,0);
          if (cVar1) {
            delta = delta * 0.05;
            this.mScroll =
                 CONCAT44((float)((uint64)this.mScroll >> 32) -
                          (float)((uint64)this.scrollMomentum >> 32) * delta,
                          (float)this.mScroll -
                          (float)this.scrollMomentum * delta);
            *(float *)(this + 148) = *(float *)(this + 148) - *(float *)(this + 48) * delta
            ;
          }
        }
    }

    // Token : 0x6000123
    // RVA   : 0x13DA3A0   Offset: 0x13D8BA0   Length: 0xA6
    public void /*ctor*/()
    {
        byte[] local_18 = new byte[8];
        uint local_10;
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this.scrollMomentum = *puVar1;
        local_10 = 0;
        *(uint32 *)(this + 48) = *(uint32 *)(puVar1 + 1);
        this.scale = 0x3f8000003f800000;
        *(uint32 *)(this + 80) = 0;
        this.dragEffect = 2;
        this.momentumAmount = 0x420c0000;
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this.mMomentum = *puVar1;
        *(uint32 *)(this + 136) = *(uint32 *)(puVar1 + 1);
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this.mScroll = *puVar1;
        *(uint32 *)(this + 148) = *(uint32 *)(puVar1 + 1);
        FUN_18044ef50(this,0);
    }

}
