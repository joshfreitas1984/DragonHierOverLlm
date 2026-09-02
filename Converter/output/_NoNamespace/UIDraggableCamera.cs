// ============================================================
// Type  : UIDraggableCamera
// Token : 0x2000043
// ============================================================

public class UIDraggableCamera
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400014E
    public Transform rootForBounds;

    // Token: 0x400014F
    public Vector2 scale;

    // Token: 0x4000150
    public float scrollWheelFactor;

    // Token: 0x4000151
    public DragEffect dragEffect;

    // Token: 0x4000152
    public bool smoothDragStart;

    // Token: 0x4000153
    public float momentumAmount;

    // Token: 0x4000154
    private Camera mCam;

    // Token: 0x4000155
    private Transform mTrans;

    // Token: 0x4000156
    private bool mPressed;

    // Token: 0x4000157
    private Vector2 mMomentum;

    // Token: 0x4000158
    private Bounds mBounds;

    // Token: 0x4000159
    private float mScroll;

    // Token: 0x400015A
    private UIRoot mRoot;

    // Token: 0x400015B
    private bool mDragStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000131
    // RVA   : 0x10E1DD0   Offset: 0x10E05D0   Length: 0x13
    public Vector2 get_currentMomentum()
    {
        uint64 FUN_1810e1dd0(int64 this)
        {
        return this.mMomentum;
    }

    // Token : 0x6000132
    // RVA   : 0x3F42C0   Offset: 0x3F2AC0   Length: 0x5
    public void set_currentMomentum(Vector2 value)
    {
        void FUN_1803f42c0(int64 this,uint64 value)
        {
        this.mMomentum = value;
    }

    // Token : 0x6000133
    // RVA   : 0x10E18F0   Offset: 0x10E00F0   Length: 0x1AA
    private void Start()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = Component.GetComponent(this,DAT_181d6afc0);
        this.mCam = uVar2;
        uVar2 = Component.get_transform(this,0);
        this.mTrans = uVar2;
        uVar2 = Component.get_gameObject(this,0);
        uVar2 = NGUITools.FindInParents(uVar2,DAT_181d66b00);
        this.mRoot = uVar2;
        uVar2 = this.rootForBounds;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          uVar2 = NGUITools.GetHierarchy(uVar2,0);
          uVar2 = String.Concat(uVar2," needs the 'Root For Bounds' parameter to be set",0);
          Debug.LogError(uVar2,this,0);
          Behaviour.set_enabled(this,0,0);
        }
    }

    // Token : 0x6000134
    // RVA   : 0x10E0E40   Offset: 0x10DF640   Length: 0x36A
    private Vector3 CalculateConstrainOffset()
    {
        uint uVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        int iVar5;
        int iVar6;
        uint uVar7;
        ulong uVar10;
        float fVar11;
        float fVar12;
        uint local_res8;
        uint32 uStackX_c;
        uint64 local_98;
        uint64 local_78;
        uint32 local_70;
        uint8 local_68 [16];
        uint64 local_58;
        uint64 uStack_50;
        uVar10 = *(uint64 *)(param_2 + 24);
        cVar4 = Object.op_Equality(uVar10,0,0);
        if (!cVar4) {
          if (*(int64 *)(param_2 + 24) == 0) goto LAB_1810e11a5;
          iVar5 = Transform.get_childCount(*(int64 *)(param_2 + 24),0);
          if (iVar5 != 0) {
            if (*(int64 *)(param_2 + 56) == 0) {
        LAB_1810e11a5:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            puVar8 = (uint64 *)Camera.get_rect(local_68,*(int64 *)(param_2 + 56),0);
            local_58 = *puVar8;
            uStack_50 = puVar8[1];
            fVar11 = (float)FUN_180d904a0(&local_58,0);
            iVar5 = Screen.get_width(0);
            if (*(int64 *)(param_2 + 56) == 0) goto LAB_1810e11a5;
            puVar8 = (uint64 *)Camera.get_rect(local_68,*(int64 *)(param_2 + 56),0);
            local_58 = *puVar8;
            uStack_50 = puVar8[1];
            fVar12 = (float)FUN_18044df60(&local_58,0);
            iVar6 = Screen.get_height(0);
            local_98 = CONCAT44((float)iVar6 * fVar12,(float)iVar5 * fVar11);
            if (*(int64 *)(param_2 + 56) == 0) goto LAB_1810e11a5;
            puVar8 = (uint64 *)Camera.get_rect(local_68,*(int64 *)(param_2 + 56),0);
            local_58 = *puVar8;
            uStack_50 = puVar8[1];
            fVar11 = (float)Rect.get_xMax(&local_58,0);
            iVar5 = Screen.get_width(0);
            if (*(int64 *)(param_2 + 56) == 0) goto LAB_1810e11a5;
            puVar8 = (uint64 *)Camera.get_rect(local_68,*(int64 *)(param_2 + 56),0);
            local_58 = *puVar8;
            uStack_50 = puVar8[1];
            fVar12 = (float)Rect.get_yMax(&local_58,0);
            iVar6 = Screen.get_height(0);
            if (*(int64 *)(param_2 + 56) == 0) goto LAB_1810e11a5;
            local_78 = local_98;
            local_70 = 0;
            puVar8 = (uint64 *)
                     Camera.ScreenToWorldPoint(local_68,*(int64 *)(param_2 + 56),&local_78,0);
            uVar10 = *puVar8;
            if (*(int64 *)(param_2 + 56) == 0) goto LAB_1810e11a5;
            local_78 = CONCAT44((float)iVar6 * fVar12,(float)iVar5 * fVar11);
            local_70 = 0;
            puVar8 = (uint64 *)
                     Camera.ScreenToWorldPoint(local_68,*(int64 *)(param_2 + 56),&local_78,0);
            param_2 = param_2 + 84;
            uVar2 = *puVar8;
            puVar9 = (uint32 *)Bounds.get_min(local_68,param_2,0);
            uVar7 = *puVar9;
            puVar8 = (uint64 *)Bounds.get_min(local_68,param_2,0);
            uVar3 = *puVar8;
            local_70 = *(uint32 *)(puVar8 + 1);
            puVar9 = (uint32 *)Bounds.get_max(local_68,param_2,0);
            uVar1 = *puVar9;
            puVar8 = (uint64 *)Bounds.get_max(local_68,param_2,0);
            local_70 = *(uint32 *)(puVar8 + 1);
            uVar10 = NGUIMath.ConstrainRect
                               (CONCAT44((int)((uint64)uVar3 >> 32),uVar7),
                                CONCAT44((int)((uint64)*puVar8 >> 32),uVar1),uVar10,uVar2,0);
            uStackX_c = (uint32)((uint64)uVar10 >> 32);
            local_res8 = (uint32)uVar10;
            uVar7 = 0;
            goto LAB_1810e1172;
          }
        }
        puVar8 = (uint64 *)Vector3.get_zero(local_68,0);
        local_res8 = (uint32)*puVar8;
        uStackX_c = (uint32)((uint64)*puVar8 >> 32);
        uVar7 = *(uint32 *)(puVar8 + 1);
        LAB_1810e1172:
        *this = CONCAT44(uStackX_c,local_res8);
        *(uint32 *)(this + 1) = uVar7;
        return this;
    }

    // Token : 0x6000135
    // RVA   : 0x10E11B0   Offset: 0x10DF9B0   Length: 0x241
    public bool ConstrainToBounds(bool immediate)
    {
        ulong uVar1;
        bool cVar2;
        ulong uVar4;
        long lVar5;
        float extraout_XMM0_Da;
        float fVar6;
        uint64 local_68;
        float local_60;
        float local_50;
        uint64 local_48;
        float local_40;
        uint8 local_38 [8];
        float local_30;
        uint8 local_28 [32];
        uVar4 = this.mTrans;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (cVar2) {
          uVar4 = this.rootForBounds;
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (cVar2) {
            puVar3 = (uint64 *)UIDraggableCamera.CalculateConstrainOffset(local_38,this,0);
            local_68 = *puVar3;
            local_60 = *(float *)(puVar3 + 1);
            Vector3.get_sqrMagnitude(&local_68,0);
            if (0.0 < extraout_XMM0_Da) {
              if (!immediate) {
                uVar4 = Component.get_gameObject(this,0);
                if (this.mTrans != null) {
                  fVar6 = (float)local_68;
                  uVar1 = (uint64)local_68 >> 32;
                  local_40 = local_60;
                  puVar3 = (uint64 *)Transform.get_position(local_28,this.mTrans,0)
                  ;
                  local_50 = *(float *)(puVar3 + 1);
                  local_40 = local_50 - local_40;
                  local_48 = CONCAT44((float)((uint64)*puVar3 >> 32) - (float)uVar1,
                                      (float)*puVar3 - fVar6);
                  local_30 = local_40;
                  lVar5 = SpringPosition.Begin(uVar4,&local_48,0x41500000,0);
                  if (lVar5 != null) {
                    *(uint16 *)(lVar5 + 40) = 0x101;
                    return true;
                  }
                }
              }
              else {
                lVar5 = this.mTrans;
                if (lVar5 != null) {
                  fVar6 = (float)local_68;
                  uVar1 = (uint64)local_68 >> 32;
                  local_50 = local_60;
                  puVar3 = (uint64 *)Transform.get_position(local_28,lVar5,0);
                  local_40 = *(float *)(puVar3 + 1) - local_50;
                  local_48 = CONCAT44((float)((uint64)*puVar3 >> 32) - (float)uVar1,
                                      (float)*puVar3 - fVar6);
                  local_30 = local_40;
                  Transform.set_position(lVar5,&local_48,0);
                  return true;
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
        return false;
    }

    // Token : 0x6000136
    // RVA   : 0x10E16C0   Offset: 0x10DFEC0   Length: 0x15B
    public void Press(bool isPressed)
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        bool cVar5;
        ulong uVar7;
        uint local_res8;
        uint32 uStackX_c;
        uint8 local_28 [32];
        if (isPressed) {
          this.mDragStarted = 0;
        }
        uVar7 = this.rootForBounds;
        cVar5 = Object.op_Inequality(uVar7,0,0);
        if (cVar5) {
          this.mPressed = isPressed;
          if (!isPressed) {
            if (this.dragEffect == 2) {
              UIDraggableCamera.ConstrainToBounds(this,0,0);
            }
          }
          else {
            puVar6 = (uint32 *)
                     NGUIMath.CalculateAbsoluteWidgetBounds(local_28,this.rootForBounds,0);
            uVar2 = puVar6[1];
            uVar3 = puVar6[2];
            uVar4 = puVar6[3];
            this.mBounds = *puVar6;
            *(uint32 *)(this + 88) = uVar2;
            *(uint32 *)(this + 92) = uVar3;
            *(uint32 *)(this + 96) = uVar4;
            *(uint64 *)(this + 100) = *(uint64 *)(puVar6 + 4);
            uVar7 = Vector2.get_zero(0);
            local_res8 = (uint32)uVar7;
            uStackX_c = (uint32)((uint64)uVar7 >> 32);
            this.mMomentum = local_res8;
            *(uint32 *)(this + 80) = uStackX_c;
            this.mScroll = 0;
            lVar1 = Component.GetComponent(this,DAT_181d6d4c0);
            cVar5 = Object.op_Inequality(lVar1,0,0);
            if (cVar5) {
              if (lVar1 != null) {
                Behaviour.set_enabled(lVar1,0,0);
                return;
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
    }

    // Token : 0x6000137
    // RVA   : 0x10E1400   Offset: 0x10DFC00   Length: 0x2BE
    public void Drag(Vector2 delta)
    {
        float fVar1;
        long lVar2;
        bool cVar3;
        ulong uVar5;
        float fVar6;
        float fVar7;
        float fVar8;
        uint local_res8;
        uint32 uStackX_c;
        float local_98;
        float fStack_94;
        uint64 local_88;
        float local_80;
        float local_70;
        uint8 local_68 [96];
        if ((this.smoothDragStart) && (!this.mDragStarted)) {
          this.mDragStarted = 1;
          return;
        }
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d8a458 + 184) + 224);
        if (lVar2 != null) {
          *(uint32 *)(lVar2 + 112) = 2;
          uVar5 = this.mRoot;
          cVar3 = Object.op_Inequality(uVar5,0,0);
          local_98 = (float)delta;
          fStack_94 = (float)((uint64)delta >> 32);
          if (cVar3) {
            if (this.mRoot == null) throw; // [null/range check failed]
            fVar6 = (float)UIRoot.get_pixelSizeAdjustment(this.mRoot,0);
            local_98 = local_98 * fVar6;
            fStack_94 = fStack_94 * fVar6;
          }
          local_98 = local_98 * -this.scale;
          fStack_94 = fStack_94 * -*(float *)(this + 36);
          lVar2 = this.mTrans;
          if (lVar2 != null) {
            puVar4 = (uint64 *)Transform.get_localPosition(local_68,lVar2,0);
            local_80 = *(float *)(puVar4 + 1) + 0.0;
            local_88 = CONCAT44((float)((uint64)*puVar4 >> 32) + fStack_94,(float)*puVar4 + local_98)
            ;
            local_70 = local_80;
            Transform.set_localPosition(lVar2,&local_88,0);
            fVar7 = this.momentumAmount * 0.01;
            fVar6 = this.mMomentum;
            fVar1 = *(float *)(this + 80);
            fVar8 = (float)Mathf.Clamp01(0x3f2b851f,0);
            this.mMomentum = ((fVar6 + local_98 * fVar7) - fVar6) * fVar8 + fVar6;
            *(float *)(this + 80) = ((fVar1 + fStack_94 * fVar7) - fVar1) * fVar8 + fVar1;
            if ((this.dragEffect != 2) &&
               (cVar3 = UIDraggableCamera.ConstrainToBounds(this,1,0), cVar3)) {
              uVar5 = Vector2.get_zero(0);
              local_res8 = (uint32)uVar5;
              uStackX_c = (uint32)((uint64)uVar5 >> 32);
              this.mMomentum = local_res8;
              *(uint32 *)(this + 80) = uStackX_c;
              this.mScroll = 0;
            }
            return;
          }
        }
    }

    // Token : 0x6000138
    // RVA   : 0x10E1820   Offset: 0x10E0020   Length: 0xCF
    public void Scroll(float delta)
    {
        ulong uVar1;
        bool cVar2;
        float fVar3;
        float fVar4;
        cVar2 = Behaviour.get_enabled(this,0);
        if (cVar2) {
          uVar1 = Component.get_gameObject(this,0);
          cVar2 = NGUITools.GetActive(uVar1,0);
          if (cVar2) {
            fVar3 = (float)Mathf.Sign(this.mScroll,0);
            fVar4 = (float)Mathf.Sign(delta,0);
            if (fVar3 == fVar4) {
              fVar3 = this.mScroll;
            }
            else {
              fVar3 = 0.0;
            }
            this.mScroll = delta * this.scrollWheelFactor + fVar3;
          }
        }
    }

    // Token : 0x6000139
    // RVA   : 0x10E1AA0   Offset: 0x10E02A0   Length: 0x2B3
    private void Update()
    {
        ulong uVar2;
        uint uVar3;
        bool cVar4;
        ulong uVar6;
        long lVar8;
        uint uVar9;
        float fVar10;
        uint uVar11;
        float local_res8;
        float fStackX_c;
        uint64 local_68;
        float local_60;
        uint8 local_58 [8];
        float local_50;
        uVar9 = RealTime.get_deltaTime(0);
        if (!this.mPressed) {
          pfVar1 = &this.mMomentum;
          fVar10 = this.mScroll * 20.0;
          this.mMomentum = this.mMomentum + this.scale * fVar10;
          *(float *)(this + 80) = *(float *)(this + 80) + *(float *)(this + 36) * fVar10;
          uVar11 = NGUIMath.SpringLerp(this.mScroll,0,0x41a00000,uVar9,0);
          this.mScroll = uVar11;
          fVar10 = (float)Vector2.get_magnitude(pfVar1,0);
          if (0.01 < fVar10) {
            lVar8 = this.mTrans;
            if (lVar8 != null) {
              puVar5 = (uint64 *)Transform.get_localPosition(local_58,lVar8,0);
              uVar2 = *puVar5;
              local_60 = *(float *)(puVar5 + 1);
              uVar6 = NGUIMath.SpringDampen(pfVar1,0x41100000,uVar9,0);
              local_60 = local_60 + 0.0;
              fStackX_c = (float)((uint64)uVar6 >> 32);
              local_res8 = (float)uVar6;
              local_68 = CONCAT44((float)((uint64)uVar2 >> 32) + fStackX_c,(float)uVar2 + local_res8)
              ;
              local_50 = local_60;
              Transform.set_localPosition(lVar8,&local_68,0);
              puVar7 = (uint32 *)
                       NGUIMath.CalculateAbsoluteWidgetBounds(local_58,this.rootForBounds,0)
              ;
              uVar9 = puVar7[1];
              uVar11 = puVar7[2];
              uVar3 = puVar7[3];
              this.mBounds = *puVar7;
              *(uint32 *)(this + 88) = uVar9;
              *(uint32 *)(this + 92) = uVar11;
              *(uint32 *)(this + 96) = uVar3;
              *(uint64 *)(this + 100) = *(uint64 *)(puVar7 + 4);
              cVar4 = UIDraggableCamera.ConstrainToBounds(this,this.dragEffect == null,0);
              if (cVar4) {
                return;
              }
              lVar8 = Component.GetComponent(this,DAT_181d6d4c0);
              cVar4 = Object.op_Inequality(lVar8,0,0);
              if (!cVar4) {
                return;
              }
              if (lVar8 != null) {
                Behaviour.set_enabled(lVar8,0,0);
                return;
              }
            }
        LAB_1810e1d4e:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        else {
          lVar8 = Component.GetComponent(this,DAT_181d6d4c0);
          cVar4 = Object.op_Inequality(lVar8,0,0);
          if (cVar4) {
            if (lVar8 == null) goto LAB_1810e1d4e;
            Behaviour.set_enabled(lVar8,0,0);
          }
        }
        this.mScroll = 0;
        NGUIMath.SpringDampen(this + 76,0x41100000,uVar9,0);
    }

    // Token : 0x600013A
    // RVA   : 0x10E1D60   Offset: 0x10E0560   Length: 0x6E
    public void /*ctor*/()
    {
        ulong uVar1;
        uint local_res8;
        uint32 uStackX_c;
        uVar1 = Vector2.get_one(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.scale = local_res8;
        *(uint32 *)(this + 36) = uStackX_c;
        this.dragEffect = 2;
        this.smoothDragStart = 1;
        this.momentumAmount = 0x420c0000;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.mMomentum = local_res8;
        *(uint32 *)(this + 80) = uStackX_c;
        FUN_18044ef50(this,0);
    }

}
