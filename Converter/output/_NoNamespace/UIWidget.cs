// ============================================================
// Type  : UIWidget
// Token : 0x20000AB
// ============================================================

public class UIWidget
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400040A
    protected Color mColor;

    // Token: 0x400040B
    protected Pivot mPivot;

    // Token: 0x400040C
    protected int mWidth;

    // Token: 0x400040D
    protected int mHeight;

    // Token: 0x400040E
    protected int mDepth;

    // Token: 0x400040F
    protected Material mMat;

    // Token: 0x4000410
    public OnDimensionsChanged onChange;

    // Token: 0x4000411
    public OnPostFillCallback onPostFill;

    // Token: 0x4000412
    public OnRenderCallback mOnRender;

    // Token: 0x4000413
    public bool autoResizeBoxCollider;

    // Token: 0x4000414
    public bool hideIfOffScreen;

    // Token: 0x4000415
    public AspectRatioSource keepAspectRatio;

    // Token: 0x4000416
    public float aspectRatio;

    // Token: 0x4000417
    public HitCheck hitCheck;

    // Token: 0x4000418
    public UIPanel panel;

    // Token: 0x4000419
    public UIGeometry geometry;

    // Token: 0x400041A
    public bool fillGeometry;

    // Token: 0x400041B
    protected bool mPlayMode;

    // Token: 0x400041C
    protected Vector4 mDrawRegion;

    // Token: 0x400041D
    private Matrix4x4 mLocalToPanel;

    // Token: 0x400041E
    private bool mIsVisibleByAlpha;

    // Token: 0x400041F
    private bool mIsVisibleByPanel;

    // Token: 0x4000420
    private bool mIsInFront;

    // Token: 0x4000421
    private float mLastAlpha;

    // Token: 0x4000422
    private bool mMoved;

    // Token: 0x4000423
    public UIDrawCall drawCall;

    // Token: 0x4000424
    protected Vector3[] mCorners;

    // Token: 0x4000425
    private int mAlphaFrameID;

    // Token: 0x4000426
    private int mMatrixFrame;

    // Token: 0x4000427
    private Vector3 mOldV0;

    // Token: 0x4000428
    private Vector3 mOldV1;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600050D
    // RVA   : 0x228550   Offset: 0x226D50   Length: 0x8
    public OnRenderCallback get_onRender()
    {
        uint64 FUN_180228550(int64 this)
        {
        return *(uint64 *)(this + 200);
    }

    // Token : 0x600050E
    // RVA   : 0x9DA6C0   Offset: 0x9D8EC0   Length: 0x1C3
    public void set_onRender(OnRenderCallback value)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        cVar3 = Delegate.op_Inequality(*(uint64 *)(this + 200),value,0);
        if (cVar3) {
          uVar1 = this.drawCall;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          plVar6 = (int64 *)0;
          if (cVar3) {
            lVar2 = this.drawCall;
            if (lVar2 == null) goto LAB_1809da869;
            if ((lVar2.onRender != null) && (*(int64 *)(this + 200) != 0)) {
              plVar4 = (int64 *)
                       Delegate.Remove(lVar2.onRender,*(int64 *)(this + 200),0);
              plVar5 = plVar6;
              if (plVar4 != (int64 *)0) {
                if (*plVar4 == DAT_181d68510) {
                  plVar5 = plVar4;
                }
                if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6070(plVar4,DAT_181d68510);
                }
              }
              lVar2.onRender = plVar5;
            }
          }
          *(uint64 *)(this + 200) = value;
          uVar1 = this.drawCall;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            lVar2 = this.drawCall;
            if (lVar2 == null) {
        LAB_1809da869:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar5 = (int64 *)Delegate.Combine(lVar2.onRender,value,0);
            if (plVar5 != (int64 *)0) {
              if (*plVar5 == DAT_181d68510) {
                plVar6 = plVar5;
              }
              if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar5);
              }
            }
            lVar2.onRender = plVar6;
          }
        }
    }

    // Token : 0x600050F
    // RVA   : 0x9D93D0   Offset: 0x9D7BD0   Length: 0xE
    public Vector4 get_drawRegion()
    {
        uint64 * FUN_1809d93d0(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x104);
        *this = *(uint64 *)(param_2 + 252);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x6000510
    // RVA   : 0x9DA260   Offset: 0x9D8A60   Length: 0xAC
    public void set_drawRegion(Vector4 value)
    {
        float fVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        fVar4 = *(float *)((int64)this + 252) - *value;
        fVar3 = *(float *)((int64)this + 0x104) - value[2];
        if (9.9999994e-11 <=
            (*(float *)(this + 32) - value[1]) * (*(float *)(this + 32) - value[1]) +
            fVar4 * fVar4 + fVar3 * fVar3 +
            (*(float *)(this + 33) - value[3]) * (*(float *)(this + 33) - value[3])) {
          fVar3 = *value;
          fVar4 = value[1];
          fVar1 = value[2];
          fVar2 = value[3];
          *(float *)((int64)this + 252) = fVar3;
          *(float *)(this + 32) = fVar4;
          *(float *)((int64)this + 0x104) = fVar1;
          *(float *)(this + 33) = fVar2;
          if ((char)this[26] != false) {
            UIWidget.ResizeCollider(fVar3,0);
          }
                          // WARNING: Could not recover jumptable at 0x0001809da2ff. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x6000511
    // RVA   : 0x9D9B10   Offset: 0x9D8310   Length: 0xD
    public Vector2 get_pivotOffset()
    {
        NGUIMath.GetPivotOffset(this.mPivot,0);
    }

    // Token : 0x6000512
    // RVA   : 0x9D9CB0   Offset: 0x9D84B0   Length: 0x7
    public int get_width()
    {
        uint32 FUN_1809d9cb0(int64 this)
        {
        return this.mWidth;
    }

    // Token : 0x6000513
    // RVA   : 0x9DAB80   Offset: 0x9D9380   Length: 0x265
    public void set_width(int value)
    {
        uint uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        iVar4 = (**(code **)(*this + 0x358))(this,*(uint64 *)(*this + 0x360));
        if (value < iVar4) {
          value = iVar4;
        }
        if (*(int *)((int64)this + 164) == value) {
          return;
        }
        if (*(int *)((int64)this + 212) == 2) {
          return;
        }
        cVar3 = (**(code **)(*this + 0x178))(this,*(uint64 *)(*this + 0x180));
        if (!cVar3) {
          UIWidget.SetDimensions(this,value,(int)this[21],0);
          return;
        }
        if (this[3] != 0) {
          uVar2 = *(uint64 *)(this[3] + 16);
          cVar3 = Object.op_Inequality(uVar2,0,0);
          if (cVar3) {
            if (this[4] == 0) throw; // [null/range check failed]
            uVar2 = *(uint64 *)(this[4] + 16);
            cVar3 = Object.op_Inequality(uVar2,0,0);
            if (cVar3) {
              uVar1 = *(uint32 *)(this + 20);
              if ((((6 < uVar1) || ((0x49U >> (uVar1 & 31) & 1) == 0)) &&
                  ((8 < uVar1 || ((0x124U >> (uVar1 & 31) & 1) == 0)))) &&
                 ((value - *(int *)((int64)this + 164) & 0xfffffffeU) == 0)) {
                return;
              }
              goto LAB_1809dacd5;
            }
          }
          if (this[3] != 0) {
            uVar2 = *(uint64 *)(this[3] + 16);
            Object.op_Inequality(uVar2,0,0);
        LAB_1809dacd5:
            NGUIMath.AdjustWidget(this);
            return;
          }
        }
    }

    // Token : 0x6000514
    // RVA   : 0x9D96C0   Offset: 0x9D7EC0   Length: 0x7
    public int get_height()
    {
        uint32 FUN_1809d96c0(int64 this)
        {
        return this.mHeight;
    }

    // Token : 0x6000515
    // RVA   : 0x9DA310   Offset: 0x9D8B10   Length: 0x258
    public void set_height(int value)
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        iVar3 = (**(code **)(*this + 0x368))(this,*(uint64 *)(*this + 0x370));
        if (value < iVar3) {
          value = iVar3;
        }
        if ((int)this[21] == value) {
          return;
        }
        if (*(int *)((int64)this + 212) == 1) {
          return;
        }
        cVar2 = (**(code **)(*this + 0x188))(this,*(uint64 *)(*this + 400));
        if (!cVar2) {
          UIWidget.SetDimensions(this,*(uint32 *)((int64)this + 164),value,0);
          return;
        }
        if (this[5] != 0) {
          uVar1 = *(uint64 *)(this[5] + 16);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this[6] == 0) throw; // [null/range check failed]
            uVar1 = *(uint64 *)(this[6] + 16);
            cVar2 = Object.op_Inequality(uVar1,0,0);
            if (cVar2) {
              if (((2 < *(uint32 *)(this + 20) - 6) && (2 < *(uint32 *)(this + 20))) &&
                 ((value - (int)this[21] & 0xfffffffeU) == 0)) {
                return;
              }
              goto LAB_1809da485;
            }
          }
          if (this[5] != 0) {
            uVar1 = *(uint64 *)(this[5] + 16);
            Object.op_Inequality(uVar1,0,0);
        LAB_1809da485:
            NGUIMath.AdjustWidget(this);
            return;
          }
        }
    }

    // Token : 0x6000516
    // RVA   : 0x9D93C0   Offset: 0x9D7BC0   Length: 0xE
    public Color get_color()
    {
        uint64 * FUN_1809d93c0(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 152);
        *this = *(uint64 *)(param_2 + 144);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x6000517
    // RVA   : 0x9DA0B0   Offset: 0x9D88B0   Length: 0x78
    public void set_color(Color value)
    {
        float fVar1;
        float fVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;
        bool cVar6;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_28 = *value;
        uStack_20 = value[1];
        local_18 = (uint32)this[18];
        uStack_14 = *(uint32 *)((int64)this + 148);
        uStack_10 = (uint32)this[19];
        uStack_c = *(uint32 *)((int64)this + 156);
        cVar6 = Color.op_Inequality(&local_18,&local_28,0);
        if (cVar6) {
          fVar1 = *(float *)((int64)this + 156);
          fVar2 = *(float *)((int64)value + 12);
          uVar3 = *(uint32 *)((int64)value + 4);
          uVar4 = *(uint32 *)(value + 1);
          uVar5 = *(uint32 *)((int64)value + 12);
          *(uint32 *)(this + 18) = *(uint32 *)value;
          *(uint32 *)((int64)this + 148) = uVar3;
          *(uint32 *)(this + 19) = uVar4;
          *(uint32 *)((int64)this + 156) = uVar5;
          (**(code **)(*this + 0x1f8))(this,fVar1 != fVar2,*(uint64 *)(*this + 0x200));
        }
    }

    // Token : 0x6000518
    // RVA   : 0x9D80D0   Offset: 0x9D68D0   Length: 0x69
    public void SetColorNoAlpha(Color c)
    {
        void FUN_1809d80d0(int64 *this,float *c)
        {
        float fVar1;
        float fVar2;
        if (((*(float *)(this + 18) == *c) &&
            (*(float *)((int64)this + 148) == c[1])) &&
           (*(float *)(this + 19) == c[2])) {
          return;
        }
        fVar1 = c[1];
        fVar2 = c[2];
        *(float *)(this + 18) = *c;
        *(float *)((int64)this + 148) = fVar1;
        *(float *)(this + 19) = fVar2;
                          // WARNING: Could not recover jumptable at 0x0001809d8131. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x1f8))(fVar1,0,*(uint64 *)(*this + 0x200));
    }

    // Token : 0x6000519
    // RVA   : 0x9D9380   Offset: 0x9D7B80   Length: 0x9
    public override float get_alpha()
    {
        uint32 FUN_1809d9380(int64 this)
        {
        return *(uint32 *)(this + 156);
    }

    // Token : 0x600051A
    // RVA   : 0x9DA080   Offset: 0x9D8880   Length: 0x2B
    public override void set_alpha(float value)
    {
        void FUN_1809da080(int64 *this,float value)
        {
        float fVar1;
        fVar1 = *(float *)((int64)this + 156);
        if (fVar1 != value) {
          *(float *)((int64)this + 156) = value;
                          // WARNING: Could not recover jumptable at 0x0001809da0a3. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x1f8))(fVar1,1,*(uint64 *)(*this + 0x200));
          return;
        }
    }

    // Token : 0x600051B
    // RVA   : 0x9D96D0   Offset: 0x9D7ED0   Length: 0x86
    public bool get_isVisible()
    {
        byte uVar1;
        if ((((this.mIsVisibleByPanel) && (this.mIsVisibleByAlpha)) &&
            (this.mIsInFront)) && (0.001 < *(float *)(this + 140))) {
          uVar1 = NGUITools.GetActive(this,0);
          return uVar1;
        }
        return false;
    }

    // Token : 0x600051C
    // RVA   : 0x9D96A0   Offset: 0x9D7EA0   Length: 0x16
    public bool get_hasVertices()
    {
        byte uVar1;
        if (this.geometry == null) {
          return false;
        }
        uVar1 = UIGeometry.get_hasVertices(this.geometry,0);
        return uVar1;
    }

    // Token : 0x600051D
    // RVA   : 0x9D9B20   Offset: 0x9D8320   Length: 0x7
    public Pivot get_rawPivot()
    {
        uint32 FUN_1809d9b20(int64 this)
        {
        return this.mPivot;
    }

    // Token : 0x600051E
    // RVA   : 0x9DAAA0   Offset: 0x9D92A0   Length: 0x46
    public void set_rawPivot(Pivot value)
    {
        if ((int)this[20] != value) {
          *(int *)(this + 20) = value;
          if ((char)this[26] != false) {
            UIWidget.ResizeCollider(this,0);
          }
                          // WARNING: Could not recover jumptable at 0x0001809daad9. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x600051F
    // RVA   : 0x9D9B20   Offset: 0x9D8320   Length: 0x7
    public Pivot get_pivot()
    {
        uint32 FUN_1809d9b20(int64 this)
        {
        return this.mPivot;
    }

    // Token : 0x6000520
    // RVA   : 0x9DA890   Offset: 0x9D9090   Length: 0x205
    public void set_pivot(Pivot value)
    {
        long lVar1;
        ulong uVar3;
        uint uVar4;
        ulong local_58;
        uint local_50;
        ulong local_48;
        ulong local_38;
        uint local_30;
        ulong local_28;
        uint local_20;
        if ((int)this[20] == value) {
          return;
        }
        lVar1 = (**(code **)(*this + 0x1e8))(this,*(uint64 *)(*this + 0x1f0));
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) == 0) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          local_48 = *(uint64 *)(lVar1 + 32);
          *(int *)(this + 20) = value;
          *(uint8 *)(this + 11) = 1;
          lVar1 = (**(code **)(*this + 0x1e8))(this,*(uint64 *)(*this + 0x1f0));
          if (lVar1 != null) {
            if (*(int *)(lVar1 + 24) == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            local_38 = *(uint64 *)(lVar1 + 32);
            local_30 = *(uint32 *)(lVar1 + 40);
            lVar1 = UIRect.get_cachedTransform(this,0);
            if (lVar1 != null) {
              puVar2 = (uint64 *)Transform.get_position(&local_28,lVar1,0);
              uVar3 = *puVar2;
              uVar4 = *(uint32 *)(puVar2 + 1);
              puVar2 = (uint64 *)Transform.get_localPosition(&local_58,lVar1,0);
              local_28 = *puVar2;
              local_20 = *(uint32 *)(puVar2 + 1);
              local_58._4_4_ = (float)((uint64)uVar3 >> 32);
              local_58 = CONCAT44((local_48._4_4_ - local_38._4_4_) + local_58._4_4_,
                                  ((float)local_48 - (float)local_38) + (float)uVar3);
              lVar1 = UIRect.get_cachedTransform(this,0);
              if (lVar1 != null) {
                local_38 = local_58;
                local_30 = uVar4;
                Transform.set_position(lVar1,&local_38,0);
                lVar1 = UIRect.get_cachedTransform(this,0);
                if (lVar1 != null) {
                  puVar2 = (uint64 *)Transform.get_localPosition(&local_38,lVar1,0);
                  local_58 = *puVar2;
                  uVar4 = FUN_18000d7c0(local_58);
                  local_58 = CONCAT44(local_58._4_4_,uVar4);
                  uVar4 = FUN_18000d7c0(local_58._4_4_);
                  local_58 = CONCAT44(uVar4,(uint32)local_58);
                  local_50 = local_20;
                  lVar1 = UIRect.get_cachedTransform(this,0);
                  if (lVar1 != null) {
                    local_20 = local_50;
                    local_28 = local_58;
                    Transform.set_localPosition(lVar1,&local_28,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000521
    // RVA   : 0x27AF80   Offset: 0x279780   Length: 0x7
    public int get_depth()
    {
        uint32 FUN_18027af80(int64 this)
        {
        return this.mDepth;
    }

    // Token : 0x6000522
    // RVA   : 0x9DA130   Offset: 0x9D8930   Length: 0x126
    public void set_depth(int value)
    {
        ulong uVar1;
        bool cVar2;
        if (this.mDepth != value) {
          uVar1 = this.panel;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.panel == null) goto LAB_1809da251;
            UIPanel.RemoveWidget(this.panel,this,0);
          }
          this.mDepth = value;
          uVar1 = this.panel;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.panel != null) {
              UIPanel.AddWidget(this.panel,this,0);
              cVar2 = Application.get_isPlaying(0);
              if (cVar2) {
                return;
              }
              if (this.panel != null) {
                UIPanel.SortWidgets(this.panel,0);
                if (this.panel != null) {
                  UIPanel.RebuildAllDrawCalls(this.panel,0);
                  return;
                }
              }
            }
        LAB_1809da251:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000523
    // RVA   : 0x9D9B30   Offset: 0x9D8330   Length: 0xDC
    public int get_raycastDepth()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.panel;
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (cVar2) {
          UIWidget.CreatePanel(this,0);
        }
        uVar1 = this.panel;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          if (this.panel != null) {
            return this.panel.mDepth * 1000 + this.mDepth;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return this.mDepth;
    }

    // Token : 0x6000524
    // RVA   : 0x9D9870   Offset: 0x9D8070   Length: 0x19D
    public override Vector3[] get_localCorners()
    {
        long lVar1;
        ulong uVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        uint local_res8;
        uint32 uStackX_c;
        uVar2 = NGUIMath.GetPivotOffset(this.mPivot,0);
        lVar1 = this.mCorners;
        local_res8 = (float)uVar2;
        uStackX_c = (float)((uint64)uVar2 >> 32);
        fVar5 = -local_res8 * (float)this.mWidth;
        fVar6 = -uStackX_c * (float)this.mHeight;
        fVar3 = (float)this.mWidth + fVar5;
        fVar4 = (float)this.mHeight + fVar6;
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) == 0) {
            uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
          *(uint64 *)(lVar1 + 32) = CONCAT44(fVar6,fVar5);
          *(uint32 *)(lVar1 + 40) = 0;
          lVar1 = this.mCorners;
          if (lVar1 != null) {
            if (*(uint32 *)(lVar1 + 24) < 2) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 44) = CONCAT44(fVar4,fVar5);
            *(uint32 *)(lVar1 + 52) = 0;
            lVar1 = this.mCorners;
            if (lVar1 != null) {
              if (*(uint32 *)(lVar1 + 24) < 3) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 56) = CONCAT44(fVar4,fVar3);
              *(uint32 *)(lVar1 + 64) = 0;
              lVar1 = this.mCorners;
              if (lVar1 != null) {
                if (3 < *(uint32 *)(lVar1 + 24)) {
                  *(uint64 *)(lVar1 + 68) = CONCAT44(fVar6,fVar3);
                  *(uint32 *)(lVar1 + 76) = 0;
                  return this.mCorners;
                }
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
            }
          }
        }
    }

    // Token : 0x6000525
    // RVA   : 0x9D9A10   Offset: 0x9D8210   Length: 0x64
    public virtual Vector2 get_localSize()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = (**(code **)(*this + 0x1d8))(this,*(uint64 *)(*this + 0x1e0));
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (2 < *(uint32 *)(lVar1 + 24)) {
          return CONCAT44((float)((uint64)*(uint64 *)(lVar1 + 56) >> 32) -
                          (float)((uint64)*(uint64 *)(lVar1 + 32) >> 32),
                          (float)*(uint64 *)(lVar1 + 56) - (float)*(uint64 *)(lVar1 + 32));
        }
        uVar2 = il2cpp_internal();
    }

    // Token : 0x6000526
    // RVA   : 0x9D9760   Offset: 0x9D7F60   Length: 0x101
    public Vector3 get_localCenter()
    {
        ulong uVar1;
        float fVar2;
        float fVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        float fVar7;
        float fStack_44;
        lVar4 = (**(code **)(*param_2 + 0x1d8))(param_2,*(uint64 *)(*param_2 + 0x1e0));
        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(uint32 *)(lVar4 + 24) != 0) {
          if (2 < *(uint32 *)(lVar4 + 24)) {
            fVar2 = *(float *)(lVar4 + 64);
            uVar5 = *(uint64 *)(lVar4 + 32);
            fVar7 = (float)uVar5;
            fVar3 = *(float *)(lVar4 + 40);
            uVar1 = *(uint64 *)(lVar4 + 56);
            fVar6 = (float)Mathf.Clamp01(0x3f000000,0);
            fStack_44 = (float)((uint64)uVar5 >> 32);
            *this = CONCAT44(((float)((uint64)uVar1 >> 32) - fStack_44) * fVar6 + fStack_44,
                                ((float)uVar1 - fVar7) * fVar6 + fVar7);
            *(float *)(this + 1) = (fVar2 - fVar3) * fVar6 + fVar3;
            return this;
          }
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        uVar5 = il2cpp_internal();
    }

    // Token : 0x6000527
    // RVA   : 0x9D9E30   Offset: 0x9D8630   Length: 0x248
    public override Vector3[] get_worldCorners()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        float fVar5;
        float fVar6;
        float fVar7;
        float fVar8;
        float local_res8;
        float fStackX_c;
        uint8 local_68 [96];
        uVar2 = NGUIMath.GetPivotOffset(this.mPivot,0);
        local_res8 = (float)uVar2;
        fStackX_c = (float)((uint64)uVar2 >> 32);
        fVar5 = -local_res8 * (float)this.mWidth;
        fVar6 = -fStackX_c * (float)this.mHeight;
        fVar8 = (float)this.mWidth + fVar5;
        fVar7 = (float)this.mHeight + fVar6;
        lVar3 = UIRect.get_cachedTransform(this,0);
        lVar1 = this.mCorners;
        if (lVar3 != null) {
          puVar4 = (uint64 *)Transform.TransformPoint(local_68,lVar3,fVar5,fVar6,0,0);
          if (lVar1 != null) {
            if (*(int *)(lVar1 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar1 + 32) = *puVar4;
            *(uint32 *)(lVar1 + 40) = *(uint32 *)(puVar4 + 1);
            lVar1 = this.mCorners;
            puVar4 = (uint64 *)Transform.TransformPoint(local_68,lVar3,fVar5,fVar7,0,0);
            if (lVar1 != null) {
              if (*(uint32 *)(lVar1 + 24) < 2) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar1 + 44) = *puVar4;
              *(uint32 *)(lVar1 + 52) = *(uint32 *)(puVar4 + 1);
              lVar1 = this.mCorners;
              puVar4 = (uint64 *)Transform.TransformPoint(local_68,lVar3,fVar8,fVar7,0,0);
              if (lVar1 != null) {
                if (*(uint32 *)(lVar1 + 24) < 3) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                *(uint64 *)(lVar1 + 56) = *puVar4;
                *(uint32 *)(lVar1 + 64) = *(uint32 *)(puVar4 + 1);
                lVar1 = this.mCorners;
                puVar4 = (uint64 *)Transform.TransformPoint(local_68,lVar3,fVar8,fVar6,0,0);
                if (lVar1 != null) {
                  if (3 < *(uint32 *)(lVar1 + 24)) {
                    *(uint64 *)(lVar1 + 68) = *puVar4;
                    *(uint32 *)(lVar1 + 76) = *(uint32 *)(puVar4 + 1);
                    return this.mCorners;
                  }
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
              }
            }
          }
        }
    }

    // Token : 0x6000528
    // RVA   : 0x9D9CC0   Offset: 0x9D84C0   Length: 0x168
    public Vector3 get_worldCenter()
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar6;
        float fVar7;
        float fVar8;
        ulong local_48;
        float local_40;
        ulong local_38;
        float local_30;
        lVar3 = UIRect.get_cachedTransform(param_2,0);
        lVar4 = (**(code **)(*param_2 + 0x1d8))(param_2,*(uint64 *)(*param_2 + 0x1e0));
        if (lVar4 != null) {
          if (*(uint32 *)(lVar4 + 24) == 0) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          if (*(uint32 *)(lVar4 + 24) < 3) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          uVar6 = *(uint64 *)(lVar4 + 32);
          uVar1 = *(uint64 *)(lVar4 + 56);
          local_30 = *(float *)(lVar4 + 64);
          local_40 = *(float *)(lVar4 + 40);
          fVar7 = (float)Mathf.Clamp01(0x3f000000,0);
          local_48._4_4_ = (float)((uint64)uVar6 >> 32);
          fVar8 = ((float)((uint64)uVar1 >> 32) - local_48._4_4_) * fVar7 + local_48._4_4_;
          local_48 = uVar6;
          local_38 = uVar1;
          if (lVar3 != null) {
            local_38 = CONCAT44(fVar8,((float)uVar1 - (float)uVar6) * fVar7 + (float)uVar6);
            local_30 = (local_30 - local_40) * fVar7 + local_40;
            puVar5 = (uint64 *)Transform.TransformPoint(&local_48,lVar3,&local_38,0);
            uVar2 = *(uint32 *)(puVar5 + 1);
            *this = *puVar5;
            *(uint32 *)(this + 1) = uVar2;
            return this;
          }
        }
    }

    // Token : 0x6000529
    // RVA   : 0x9D93E0   Offset: 0x9D7BE0   Length: 0x19D
    public virtual Vector4 get_drawingDimensions()
    {
        ulong uVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        float fVar7;
        float local_res8;
        float fStackX_c;
        uVar1 = NGUIMath.GetPivotOffset(*(uint32 *)(param_2 + 160),0);
        local_res8 = (float)uVar1;
        fStackX_c = (float)((uint64)uVar1 >> 32);
        fVar4 = -local_res8 * (float)*(int *)(param_2 + 164);
        fVar6 = -fStackX_c * (float)*(int *)(param_2 + 168);
        fVar7 = (float)*(int *)(param_2 + 164) + fVar4;
        fVar5 = (float)*(int *)(param_2 + 168) + fVar6;
        fVar2 = fVar4;
        if (*(float *)(param_2 + 252) != 0.0) {
          fVar2 = (float)Mathf.Lerp(fVar4,fVar7,*(float *)(param_2 + 252),0);
        }
        fVar3 = fVar6;
        if (*(float *)(param_2 + 0x100) != 0.0) {
          fVar3 = (float)Mathf.Lerp(fVar6,fVar5,*(float *)(param_2 + 0x100),0);
        }
        if (*(float *)(param_2 + 0x104) != 1.0) {
          fVar7 = (float)Mathf.Lerp(fVar4,fVar7,*(float *)(param_2 + 0x104),0);
        }
        if (*(float *)(param_2 + 0x108) != 1.0) {
          fVar5 = (float)Mathf.Lerp(fVar6,fVar5,*(float *)(param_2 + 0x108),0);
        }
        *this = 0;
        this[1] = 0;
        FUN_1809981e0(this,fVar2,fVar3,fVar7,fVar5,0);
        return this;
    }

    // Token : 0x600052A
    // RVA   : 0x2A5C70   Offset: 0x2A4470   Length: 0x8
    public virtual Material get_material()
    {
        return this.mMat;
    }

    // Token : 0x600052B
    // RVA   : 0x9DA600   Offset: 0x9D8E00   Length: 0xB5
    public virtual void set_material(Material value)
    {
        long lVar1;
        bool cVar2;
        lVar1 = this[22];
        cVar2 = Object.op_Inequality(lVar1,value,0);
        if (cVar2) {
          UIWidget.RemoveFromPanel(this,0);
          this[22] = value;
          il2cpp_internal(this + 22,value);
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x600052C
    // RVA   : 0x9D9A80   Offset: 0x9D8280   Length: 0x8B
    public virtual Texture get_mainTexture()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = (**(code **)(*this + 0x2c8))(this,*(uint64 *)(*this + 0x2d0));
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (cVar1) {
          if (lVar2 != null) {
            uVar3 = Material.get_mainTexture(lVar2,0);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x600052D
    // RVA   : 0x9DA570   Offset: 0x9D8D70   Length: 0x8E
    public virtual void set_mainTexture(Texture value)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        lVar1 = Object.GetType(this,0);
        if (lVar1 == null) {
          uVar2 = 0;
        }
        else {
          FUN_180002fb0(lVar1);
          uVar2 = FUN_180002df0(3,lVar1);
        }
        uVar3 = il2cpp_internal(&" has no mainTexture setter");
        uVar2 = String.Concat(uVar2,uVar3,0);
        uVar3 = il2cpp_runtime_class_init(&DAT_181d681e8);
        uVar3 = il2cpp_internal(uVar3);
        NotImplementedException.ctor(uVar3,uVar2,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d9df28);
    }

    // Token : 0x600052E
    // RVA   : 0x9D9C20   Offset: 0x9D8420   Length: 0x8B
    public virtual Shader get_shader()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = (**(code **)(*this + 0x2c8))(this,*(uint64 *)(*this + 0x2d0));
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (cVar1) {
          if (lVar2 != null) {
            uVar3 = Material.get_shader(lVar2,0);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x600052F
    // RVA   : 0x9DAAF0   Offset: 0x9D92F0   Length: 0x8E
    public virtual void set_shader(Shader value)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        lVar1 = Object.GetType(this,0);
        if (lVar1 == null) {
          uVar2 = 0;
        }
        else {
          FUN_180002fb0(lVar1);
          uVar2 = FUN_180002df0(3,lVar1);
        }
        uVar3 = il2cpp_internal(&" has no shader setter");
        uVar2 = String.Concat(uVar2,uVar3,0);
        uVar3 = il2cpp_runtime_class_init(&DAT_181d681e8);
        uVar3 = il2cpp_internal(uVar3);
        NotImplementedException.ctor(uVar3,uVar2,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d9dfb0);
    }

    // Token : 0x6000530
    // RVA   : 0x9D9C10   Offset: 0x9D8410   Length: 0x7
    public Vector2 get_relativeSize()
    {
        void FUN_1809d9c10(void)
        {
        Vector2.get_one(0);
    }

    // Token : 0x6000531
    // RVA   : 0x9D9580   Offset: 0x9D7D80   Length: 0x11D
    public bool get_hasBoxCollider()
    {
        bool cVar2;
        ulong uVar4;
        plVar3 = (int64 *)Component.GetComponent(this,DAT_181d6b340);
        if (plVar3 == (int64 *)0) {
          plVar5 = (int64 *)0;
        }
        else {
          plVar5 = plVar3;
        }
        cVar2 = Object.op_Inequality(plVar5,0,0);
        if (!cVar2) {
          uVar4 = Component.GetComponent(this,DAT_181d6ae40);
          uVar4 = Object.op_Inequality(uVar4,0,0);
          return uVar4;
        }
        return true;
    }

    // Token : 0x6000532
    // RVA   : 0x9D8140   Offset: 0x9D6940   Length: 0xD0
    public void SetDimensions(int w, int h)
    {
        int iVar1;
        uint uVar2;
        if ((*(int *)((int64)this + 164) == w) && ((int)this[21] == h)) {
          return;
        }
        iVar1 = *(int *)((int64)this + 212);
        *(int *)((int64)this + 164) = w;
        *(int *)(this + 21) = h;
        if (iVar1 == 1) {
          uVar2 = Mathf.RoundToInt((float)w / *(float *)(this + 27),0);
          *(uint32 *)(this + 21) = uVar2;
        }
        else if (iVar1 == 2) {
          uVar2 = Mathf.RoundToInt((float)h * *(float *)(this + 27),0);
          *(uint32 *)((int64)this + 164) = uVar2;
        }
        else if (iVar1 == 0) {
          *(float *)(this + 27) = (float)w / (float)h;
        }
        *(uint8 *)((int64)this + 0x154) = 1;
        if ((char)this[26] != false) {
          UIWidget.ResizeCollider(this,0);
        }
                          // WARNING: Could not recover jumptable at 0x0001809d8203. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
    }

    // Token : 0x6000533
    // RVA   : 0x9D66B0   Offset: 0x9D4EB0   Length: 0x381
    public override Vector3[] GetSides(Transform relativeTo)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        uint uVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float local_res8;
        float fStackX_c;
        uint64 local_a8;
        uint32 local_a0;
        uint8 local_98 [128];
        uVar3 = NGUIMath.GetPivotOffset(this.mPivot,0);
        local_res8 = (float)uVar3;
        fStackX_c = (float)((uint64)uVar3 >> 32);
        fVar7 = -local_res8 * (float)this.mWidth;
        fVar10 = -fStackX_c * (float)this.mHeight;
        fVar12 = (float)this.mWidth + fVar7;
        fVar11 = (float)this.mHeight + fVar10;
        fVar9 = (fVar12 + fVar7) * 0.5;
        fVar8 = (fVar11 + fVar10) * 0.5;
        lVar4 = UIRect.get_cachedTransform(this,0);
        lVar1 = this.mCorners;
        if (lVar4 != null) {
          uVar6 = 0;
          puVar5 = (uint64 *)Transform.TransformPoint(&local_a8,lVar4,fVar7,fVar8,0,0);
          if (lVar1 != null) {
            if (*(int *)(lVar1 + 24) == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            *(uint64 *)(lVar1 + 32) = *puVar5;
            *(uint32 *)(lVar1 + 40) = *(uint32 *)(puVar5 + 1);
            lVar1 = this.mCorners;
            puVar5 = (uint64 *)Transform.TransformPoint(&local_a8,lVar4,fVar9,fVar11,0,0);
            if (lVar1 != null) {
              if (*(uint32 *)(lVar1 + 24) < 2) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              *(uint64 *)(lVar1 + 44) = *puVar5;
              *(uint32 *)(lVar1 + 52) = *(uint32 *)(puVar5 + 1);
              lVar1 = this.mCorners;
              puVar5 = (uint64 *)Transform.TransformPoint(&local_a8,lVar4,fVar12,fVar8,0,0);
              if (lVar1 != null) {
                if (*(uint32 *)(lVar1 + 24) < 3) {
                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar3,0);
                }
                *(uint64 *)(lVar1 + 56) = *puVar5;
                *(uint32 *)(lVar1 + 64) = *(uint32 *)(puVar5 + 1);
                lVar1 = this.mCorners;
                puVar5 = (uint64 *)Transform.TransformPoint(&local_a8,lVar4,fVar9,fVar10,0,0);
                if (lVar1 != null) {
                  if (*(uint32 *)(lVar1 + 24) < 4) {
                    uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar3,0);
                  }
                  *(uint64 *)(lVar1 + 68) = *puVar5;
                  *(uint32 *)(lVar1 + 76) = *(uint32 *)(puVar5 + 1);
                  cVar2 = Object.op_Inequality(relativeTo,0,0);
                  if (cVar2) {
                    do {
                      lVar1 = this.mCorners;
                      if (lVar1 == null) throw; // [null/range check failed]
                      lVar4 = (int64)(int)uVar6;
                      if (*(uint32 *)(lVar1 + 24) <= uVar6) {
                        uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar3,0);
                      }
                      if (relativeTo == null) throw; // [null/range check failed]
                      local_a8 = *(uint64 *)(lVar1 + 32 + lVar4 * 12);
                      local_a0 = *(uint32 *)(lVar1 + 40 + lVar4 * 12);
                      puVar5 = (uint64 *)
                               Transform.InverseTransformPoint(local_98,relativeTo,&local_a8,0);
                      if (*(uint32 *)(lVar1 + 24) <= uVar6) {
                        uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar3,0);
                      }
                      uVar6 = uVar6 + 1;
                      *(uint64 *)(lVar1 + 32 + lVar4 * 12) = *puVar5;
                      *(uint32 *)(lVar1 + 40 + lVar4 * 12) = *(uint32 *)(puVar5 + 1);
                    } while ((int)uVar6 < 4);
                  }
                  return this.mCorners;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000534
    // RVA   : 0x9D6120   Offset: 0x9D4920   Length: 0x3B
    public override float CalculateFinalAlpha(int frameID)
    {
        if (this.mAlphaFrameID != frameID) {
          this.mAlphaFrameID = frameID;
          UIWidget.UpdateFinalAlpha(this,frameID,0);
          return *(uint32 *)(this + 140);
        }
        return *(uint32 *)(this + 140);
    }

    // Token : 0x6000535
    // RVA   : 0x9D8750   Offset: 0x9D6F50   Length: 0xE4
    protected void UpdateFinalAlpha(int frameID)
    {
        bool cVar1;
        float fVar3;
        if ((this.mIsVisibleByAlpha) && (this.mIsInFront)) {
          plVar2 = (int64 *)UIRect.get_parent(this,0);
          cVar1 = Object.op_Inequality(plVar2,0,0);
          if (!cVar1) {
            fVar3 = *(float *)(this + 156);
          }
          else {
            if (plVar2 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar3 = (float)(**(code **)(*plVar2 + 0x1c8))(plVar2,frameID,*(uint64 *)(*plVar2 + 0x1d0))
            ;
            fVar3 = fVar3 * *(float *)(this + 156);
          }
          *(float *)(this + 140) = fVar3;
          return;
        }
        *(uint32 *)(this + 140) = 0;
    }

    // Token : 0x6000536
    // RVA   : 0x9D6A40   Offset: 0x9D5240   Length: 0x1CF
    public override void Invalidate(bool includeChildren)
    {
        ulong uVar1;
        bool cVar2;
        bool cVar3;
        uint uVar4;
        float fVar6;
        uVar1 = this.panel;
        *(uint8 *)(this + 88) = 1;
        this.mAlphaFrameID = 0xffffffff;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          return;
        }
        if (!this.hideIfOffScreen) {
          if (this.panel == null) goto LAB_1809d6c0a;
          cVar2 = UIPanel.get_hasCumulativeClipping(this.panel,0);
          if (!(cVar2))
          {
            cVar2 = true;
            }
            else {
          }
          if (this.panel == null) goto LAB_1809d6c0a;
          cVar2 = UIPanel.IsVisible(this.panel,this,0);
        }
        uVar4 = Time.get_frameCount(0);
        plVar5 = (int64 *)UIRect.get_parent(this,0);
        cVar3 = Object.op_Inequality(plVar5,0,0);
        if (!cVar3) {
          fVar6 = *(float *)(this + 156);
        }
        else {
          if (plVar5 == (int64 *)0) {
        LAB_1809d6c0a:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar6 = (float)(**(code **)(*plVar5 + 0x1c8))(plVar5,uVar4,*(uint64 *)(*plVar5 + 0x1d0));
          fVar6 = fVar6 * *(float *)(this + 156);
        }
        if (((bool)this.mIsVisibleByAlpha != null.001 < fVar6) || (this.mIsVisibleByPanel != cVar2))
        {
          *(uint8 *)(this + 88) = 1;
          this.mIsVisibleByAlpha = 0.001 < fVar6;
          this.mIsVisibleByPanel = cVar2;
        }
        uVar4 = Time.get_frameCount(0);
        UIWidget.UpdateFinalAlpha(this,uVar4,0);
        if (includeChildren) {
          UIRect.Invalidate(this,1,0);
        }
    }

    // Token : 0x6000537
    // RVA   : 0x9D6060   Offset: 0x9D4860   Length: 0xBB
    public float CalculateCumulativeAlpha(int frameID)
    {
        bool cVar1;
        float fVar3;
        plVar2 = (int64 *)UIRect.get_parent(this,0);
        cVar1 = Object.op_Inequality(plVar2,0,0);
        if (cVar1) {
          if (plVar2 != (int64 *)0) {
            fVar3 = (float)(**(code **)(*plVar2 + 0x1c8))(plVar2,frameID,*(uint64 *)(*plVar2 + 0x1d0))
            ;
            return fVar3 * *(float *)(this + 156);
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return *(float *)(this + 156);
    }

    // Token : 0x6000538
    // RVA   : 0x9D8340   Offset: 0x9D6B40   Length: 0x408
    public override void SetRect(float x, float y, float width, float height)
    {
                            float height)
        {
        uint32 uVar1;
        uint64 uVar2;
        char cVar3;
        uint32 uVar4;
        uint32 uVar5;
        int iVar6;
        uint64 uVar7;
        int64 lVar8;
        uint64 *puVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float local_res8;
        float fStackX_c;
        uint64 local_d8;
        uint32 local_d0;
        uint8 local_c8 [176];
        uVar7 = NGUIMath.GetPivotOffset((int)this[20],0);
        local_res8 = (float)uVar7;
        fVar13 = (float)x + width;
        fVar10 = (float)Mathf.Lerp(x,fVar13,local_res8,0);
        fStackX_c = (float)((uint64)uVar7 >> 32);
        fVar11 = (float)y + height;
        fVar12 = (float)Mathf.Lerp(y,fVar11,fStackX_c,0);
        uVar4 = Mathf.FloorToInt(width + 0.5,0);
        uVar5 = Mathf.FloorToInt(height + 0.5,0);
        if (local_res8 == 0.5) {
          uVar4 = uVar4 & 0xfffffffe;
        }
        if (fStackX_c == 0.5) {
          uVar5 = uVar5 & 0xfffffffe;
        }
        lVar8 = UIRect.get_cachedTransform(this,0);
        if (lVar8 != null) {
          puVar9 = (uint64 *)Transform.get_localPosition(local_c8,lVar8,0);
          local_d8 = *puVar9;
          uVar1 = *(uint32 *)(puVar9 + 1);
          fVar10 = floorf(fVar10 + 0.5);
          local_d8 = CONCAT44(local_d8._4_4_,fVar10);
          fVar10 = floorf(fVar12 + 0.5);
          local_d8 = CONCAT44(fVar10,(uint32)local_d8);
          iVar6 = (**(code **)(*this + 0x358))(this,*(uint64 *)(*this + 0x360));
          if ((int)uVar4 < iVar6) {
            uVar4 = (**(code **)(*this + 0x358))(this,*(uint64 *)(*this + 0x360));
          }
          iVar6 = (**(code **)(*this + 0x368))(this,*(uint64 *)(*this + 0x370));
          if ((int)uVar5 < iVar6) {
            uVar5 = (**(code **)(*this + 0x368))(this,*(uint64 *)(*this + 0x370));
          }
          local_d0 = uVar1;
          Transform.set_localPosition(lVar8,&local_d8,0);
          UIWidget.set_width(this,uVar4,0);
          UIWidget.set_height(this,uVar5,0);
          cVar3 = UIRect.get_isAnchored(this,0);
          if (!cVar3) {
            return;
          }
          uVar7 = FUN_180da0f00(lVar8,0);
          if (this[3] != 0) {
            uVar2 = *(uint64 *)(this[3] + 16);
            cVar3 = Object.op_Implicit(uVar2,0);
            if (cVar3) {
              if (this[3] == 0) throw; // [null/range check failed]
              AnchorPoint.SetHorizontal(this[3],uVar7,(float)x,0);
            }
            if (this[4] != 0) {
              uVar2 = *(uint64 *)(this[4] + 16);
              cVar3 = Object.op_Implicit(uVar2,0);
              if (cVar3) {
                if (this[4] == 0) throw; // [null/range check failed]
                AnchorPoint.SetHorizontal(this[4],uVar7,fVar13,0);
              }
              if (this[5] != 0) {
                uVar2 = *(uint64 *)(this[5] + 16);
                cVar3 = Object.op_Implicit(uVar2,0);
                if (cVar3) {
                  if (this[5] == 0) throw; // [null/range check failed]
                  AnchorPoint.SetVertical(this[5],uVar7,(float)y,0);
                }
                if (this[6] != 0) {
                  uVar2 = *(uint64 *)(this[6] + 16);
                  cVar3 = Object.op_Implicit(uVar2,0);
                  if (cVar3) {
                    if (this[6] == 0) throw; // [null/range check failed]
                    AnchorPoint.SetVertical(this[6],uVar7,fVar11,0);
                  }
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000539
    // RVA   : 0x9D7FC0   Offset: 0x9D67C0   Length: 0x10C
    public void ResizeCollider()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = Component.GetComponent(this,DAT_181d6adc0);
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          uVar1 = Component.GetComponent(this,DAT_181d6ae40);
          NGUITools.UpdateWidgetCollider(this,uVar1,0);
          return;
        }
        NGUITools.UpdateWidgetCollider(this,uVar1,0);
    }

    // Token : 0x600053A
    // RVA   : 0x9D64A0   Offset: 0x9D4CA0   Length: 0x20D
    public static int FullCompareFunc(UIWidget left, UIWidget right)
    {
        bool cVar1;
        int iVar2;
        int iVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        if ((left == (int64 *)0) || (lVar5 = left[29], right == (int64 *)0)) {
        LAB_1809d66a8:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar6 = right[29];
        uVar4 = UIPanel.CompareFunc(lVar5,lVar6,0);
        if ((int)uVar4 == 0) {
          if (DAT_181e782b3 == (char)uVar4) {
            il2cpp_runtime_class_init(&DAT_181d68fe8);
            DAT_181e782b3 = true;
          }
          if (*(int *)((int64)right + 172) <= *(int *)((int64)left + 172)) {
            if (*(int *)((int64)right + 172) < *(int *)((int64)left + 172)) {
              return 1;
            }
            lVar5 = (**(code **)(*left + 0x2c8))(left,*(uint64 *)(*left + 0x2d0));
            lVar6 = (**(code **)(*right + 0x2c8))(right,*(uint64 *)(*right + 0x2d0));
            cVar1 = Object.op_Equality(lVar5,lVar6,0);
            if (cVar1) {
              return 0;
            }
            cVar1 = Object.op_Equality(lVar5,0,0);
            if (cVar1) {
              return 1;
            }
            cVar1 = Object.op_Equality(lVar6,0,0);
            if (!cVar1) {
              if ((lVar5 != null) && (iVar2 = Object.GetInstanceID(lVar5,0), lVar6 != null)) {
                iVar3 = Object.GetInstanceID(lVar6,0);
                uVar4 = 1;
                if (iVar2 < iVar3) {
                  uVar4 = 0xffffffff;
                }
                return uVar4;
              }
              goto LAB_1809d66a8;
            }
          }
          uVar4 = 0xffffffff;
        }
        return uVar4;
    }

    // Token : 0x600053B
    // RVA   : 0x9D7C50   Offset: 0x9D6450   Length: 0x16B
    public static int PanelCompareFunc(UIWidget left, UIWidget right)
    {
        bool cVar1;
        int iVar2;
        int iVar3;
        long lVar4;
        long lVar5;
        if ((left == (int64 *)0) || (right == (int64 *)0)) {
        LAB_1809d7db6:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(int *)((int64)left + 172) < *(int *)((int64)right + 172)) {
          return 0xffffffff;
        }
        if (*(int *)((int64)left + 172) <= *(int *)((int64)right + 172)) {
          lVar4 = (**(code **)(*left + 0x2c8))(left,*(uint64 *)(*left + 0x2d0));
          lVar5 = (**(code **)(*right + 0x2c8))(right,*(uint64 *)(*right + 0x2d0));
          cVar1 = Object.op_Equality(lVar4,lVar5,0);
          if (cVar1) {
            return 0;
          }
          cVar1 = Object.op_Equality(lVar4,0,0);
          if (!cVar1) {
            cVar1 = Object.op_Equality(lVar5,0,0);
            if (cVar1) {
              return 0xffffffff;
            }
            if ((lVar4 != null) && (iVar2 = Object.GetInstanceID(lVar4,0), lVar5 != null)) {
              iVar3 = Object.GetInstanceID(lVar5,0);
              if (iVar2 < iVar3) {
                return 0xffffffff;
              }
              return 1;
            }
            goto LAB_1809d7db6;
          }
        }
        return 1;
    }

    // Token : 0x600053C
    // RVA   : 0x9D6020   Offset: 0x9D4820   Length: 0x32
    public Bounds CalculateBounds()
    {
        bool cVar1;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        ulong local_e8;
        uint local_e0;
        ulong local_d8;
        uint local_d0;
        ulong local_c8;
        ulong uStack_c0;
        ulong local_b8;
        ulong local_b0;
        ulong uStack_a8;
        ulong local_a0;
        byte[] local_98 = new byte[16];
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong uStack_70;
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        uint32 local_58;
        uint32 uStack_54;
        uint32 uStack_50;
        uint32 uStack_4c;
        uint8 local_48 [64];
        local_a0 = 0;
        local_b8 = 0;
        local_b0 = 0;
        uStack_a8 = 0;
        local_c8 = 0;
        uStack_c0 = 0;
        cVar1 = Object.op_Equality(param_3,0,0);
        if (!cVar1) {
          if (param_3 != 0) {
            puVar2 = (uint64 *)Transform.get_worldToLocalMatrix(local_48,param_3,0);
            local_88 = *puVar2;
            uStack_80 = puVar2[1];
            local_78 = puVar2[2];
            uStack_70 = puVar2[3];
            local_68 = *(uint32 *)(puVar2 + 4);
            uStack_64 = *(uint32 *)((int64)puVar2 + 36);
            uStack_60 = *(uint32 *)(puVar2 + 5);
            uStack_5c = *(uint32 *)((int64)puVar2 + 44);
            local_58 = *(uint32 *)(puVar2 + 6);
            uStack_54 = *(uint32 *)((int64)puVar2 + 52);
            uStack_50 = *(uint32 *)(puVar2 + 7);
            uStack_4c = *(uint32 *)((int64)puVar2 + 60);
            lVar3 = (**(code **)(*param_2 + 0x1e8))(param_2,*(uint64 *)(*param_2 + 0x1f0));
            if (lVar3 != null) {
              if (*(int *)(lVar3 + 24) == 0) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              local_d8 = *(uint64 *)(lVar3 + 32);
              local_d0 = *(uint32 *)(lVar3 + 40);
              puVar2 = (uint64 *)Matrix4x4.MultiplyPoint3x4(&local_e8,&local_88,&local_d8,0);
              uVar4 = *puVar2;
              uVar6 = *(uint32 *)(puVar2 + 1);
              puVar2 = (uint64 *)Vector3.get_zero(&local_e8,0);
              local_d8 = *puVar2;
              local_d0 = *(uint32 *)(puVar2 + 1);
              local_e8 = uVar4;
              local_e0 = uVar6;
              Bounds.ctor(&local_c8,&local_e8,&local_d8,0);
              uVar5 = 1;
              do {
                if (*(uint32 *)(lVar3 + 24) <= uVar5) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_e8 = lVar3[uVar5];
                local_e0 = *(uint32 *)(lVar3 + 40 + (int64)(int)uVar5 * 12);
                puVar2 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_98,&local_88,&local_e8,0);
                local_d8 = *puVar2;
                local_d0 = *(uint32 *)(puVar2 + 1);
                Bounds.Encapsulate(&local_c8,&local_d8,0);
                uVar5 = uVar5 + 1;
              } while ((int)uVar5 < 4);
              uVar6 = (uint32)local_b8;
              uVar7 = (uint32)((uint64)local_b8 >> 32);
              *this = local_c8;
              this[1] = uStack_c0;
              goto LAB_1809d5eeb;
            }
          }
        }
        else {
          lVar3 = (**(code **)(*param_2 + 0x1d8))(param_2,*(uint64 *)(*param_2 + 0x1e0));
          if (lVar3 != null) {
            if (*(int *)(lVar3 + 24) == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            uVar4 = *(uint64 *)(lVar3 + 32);
            uVar6 = *(uint32 *)(lVar3 + 40);
            puVar2 = (uint64 *)Vector3.get_zero(local_98,0);
            local_e8 = *puVar2;
            local_e0 = *(uint32 *)(puVar2 + 1);
            local_d8 = uVar4;
            local_d0 = uVar6;
            Bounds.ctor(&local_b0,&local_d8,&local_e8,0);
            uVar5 = 1;
            do {
              if (*(uint32 *)(lVar3 + 24) <= uVar5) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              local_e8 = lVar3[uVar5];
              local_e0 = *(uint32 *)(lVar3 + 40 + (int64)(int)uVar5 * 12);
              Bounds.Encapsulate(&local_b0,&local_e8,0);
              uVar5 = uVar5 + 1;
            } while ((int)uVar5 < 4);
            uVar6 = (uint32)local_a0;
            uVar7 = (uint32)((uint64)local_a0 >> 32);
            *this = local_b0;
            this[1] = uStack_a8;
        LAB_1809d5eeb:
            this[2] = CONCAT44(uVar7,uVar6);
            return this;
          }
        }
    }

    // Token : 0x600053D
    // RVA   : 0x9D5D20   Offset: 0x9D4520   Length: 0x2F3
    public Bounds CalculateBounds(Transform relativeParent)
    {
        bool cVar1;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        ulong local_e8;
        uint local_e0;
        ulong local_d8;
        uint local_d0;
        ulong local_c8;
        ulong uStack_c0;
        ulong local_b8;
        ulong local_b0;
        ulong uStack_a8;
        ulong local_a0;
        byte[] local_98 = new byte[16];
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong uStack_70;
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        uint32 local_58;
        uint32 uStack_54;
        uint32 uStack_50;
        uint32 uStack_4c;
        uint8 local_48 [64];
        local_a0 = 0;
        local_b8 = 0;
        local_b0 = 0;
        uStack_a8 = 0;
        local_c8 = 0;
        uStack_c0 = 0;
        cVar1 = Object.op_Equality(param_3,0,0);
        if (!cVar1) {
          if (param_3 != 0) {
            puVar2 = (uint64 *)Transform.get_worldToLocalMatrix(local_48,param_3,0);
            local_88 = *puVar2;
            uStack_80 = puVar2[1];
            local_78 = puVar2[2];
            uStack_70 = puVar2[3];
            local_68 = *(uint32 *)(puVar2 + 4);
            uStack_64 = *(uint32 *)((int64)puVar2 + 36);
            uStack_60 = *(uint32 *)(puVar2 + 5);
            uStack_5c = *(uint32 *)((int64)puVar2 + 44);
            local_58 = *(uint32 *)(puVar2 + 6);
            uStack_54 = *(uint32 *)((int64)puVar2 + 52);
            uStack_50 = *(uint32 *)(puVar2 + 7);
            uStack_4c = *(uint32 *)((int64)puVar2 + 60);
            lVar3 = (**(code **)(*relativeParent + 0x1e8))(relativeParent,*(uint64 *)(*relativeParent + 0x1f0));
            if (lVar3 != null) {
              if (*(int *)(lVar3 + 24) == 0) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              local_d8 = *(uint64 *)(lVar3 + 32);
              local_d0 = *(uint32 *)(lVar3 + 40);
              puVar2 = (uint64 *)Matrix4x4.MultiplyPoint3x4(&local_e8,&local_88,&local_d8,0);
              uVar4 = *puVar2;
              uVar6 = *(uint32 *)(puVar2 + 1);
              puVar2 = (uint64 *)Vector3.get_zero(&local_e8,0);
              local_d8 = *puVar2;
              local_d0 = *(uint32 *)(puVar2 + 1);
              local_e8 = uVar4;
              local_e0 = uVar6;
              Bounds.ctor(&local_c8,&local_e8,&local_d8,0);
              uVar5 = 1;
              do {
                if (*(uint32 *)(lVar3 + 24) <= uVar5) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                local_e8 = lVar3[uVar5];
                local_e0 = *(uint32 *)(lVar3 + 40 + (int64)(int)uVar5 * 12);
                puVar2 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_98,&local_88,&local_e8,0);
                local_d8 = *puVar2;
                local_d0 = *(uint32 *)(puVar2 + 1);
                Bounds.Encapsulate(&local_c8,&local_d8,0);
                uVar5 = uVar5 + 1;
              } while ((int)uVar5 < 4);
              uVar6 = (uint32)local_b8;
              uVar7 = (uint32)((uint64)local_b8 >> 32);
              *this = local_c8;
              this[1] = uStack_c0;
              goto LAB_1809d5eeb;
            }
          }
        }
        else {
          lVar3 = (**(code **)(*relativeParent + 0x1d8))(relativeParent,*(uint64 *)(*relativeParent + 0x1e0));
          if (lVar3 != null) {
            if (*(int *)(lVar3 + 24) == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            uVar4 = *(uint64 *)(lVar3 + 32);
            uVar6 = *(uint32 *)(lVar3 + 40);
            puVar2 = (uint64 *)Vector3.get_zero(local_98,0);
            local_e8 = *puVar2;
            local_e0 = *(uint32 *)(puVar2 + 1);
            local_d8 = uVar4;
            local_d0 = uVar6;
            Bounds.ctor(&local_b0,&local_d8,&local_e8,0);
            uVar5 = 1;
            do {
              if (*(uint32 *)(lVar3 + 24) <= uVar5) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              local_e8 = lVar3[uVar5];
              local_e0 = *(uint32 *)(lVar3 + 40 + (int64)(int)uVar5 * 12);
              Bounds.Encapsulate(&local_b0,&local_e8,0);
              uVar5 = uVar5 + 1;
            } while ((int)uVar5 < 4);
            uVar6 = (uint32)local_a0;
            uVar7 = (uint32)((uint64)local_a0 >> 32);
            *this = local_b0;
            this[1] = uStack_a8;
        LAB_1809d5eeb:
            this[2] = CONCAT44(uVar7,uVar6);
            return this;
          }
        }
    }

    // Token : 0x600053E
    // RVA   : 0x9D8210   Offset: 0x9D6A10   Length: 0x125
    public void SetDirty()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.drawCall;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          if ((((this.mIsVisibleByPanel) && (this.mIsVisibleByAlpha)) &&
              (this.mIsInFront)) && (0.001 < *(float *)(this + 140))) {
            cVar2 = NGUITools.GetActive(this,0);
            if ((cVar2) && (this.geometry != null)) {
              cVar2 = UIGeometry.get_hasVertices(this.geometry,0);
              if (cVar2) {
                UIWidget.CreatePanel(this,0);
              }
            }
          }
          return;
        }
        if (this.drawCall != null) {
          this.drawCall.isDirty = 1;
          return;
        }
    }

    // Token : 0x600053F
    // RVA   : 0x9D7F00   Offset: 0x9D6700   Length: 0xB7
    public void RemoveFromPanel()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.panel;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          if (this.panel == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          UIPanel.RemoveWidget(this.panel,this,0);
          this.panel = 0;
        }
        this.drawCall = 0;
    }

    // Token : 0x6000540
    // RVA   : 0x9D6D60   Offset: 0x9D5560   Length: 0x21D
    public virtual void MarkAsChanged()
    {
        bool cVar1;
        ulong uVar2;
        cVar1 = NGUITools.GetActive(this,0);
        if (cVar1) {
          *(uint8 *)(this + 88) = 1;
          uVar2 = this.panel;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if ((cVar1) && (cVar1 = Behaviour.get_enabled(this,0), cVar1)) {
            uVar2 = Component.get_gameObject(this,0);
            cVar1 = NGUITools.GetActive(uVar2,0);
            if ((cVar1) && (!this.mPlayMode)) {
              uVar2 = this.drawCall;
              cVar1 = Object.op_Inequality(uVar2,0,0);
              if (!cVar1) {
                if ((((this.mIsVisibleByPanel) && (this.mIsVisibleByAlpha)) &&
                    (this.mIsInFront)) && (0.001 < *(float *)(this + 140))) {
                  cVar1 = NGUITools.GetActive(this,0);
                  if (((cVar1) && (this.geometry != null)) &&
                     (cVar1 = UIGeometry.get_hasVertices(this.geometry,0), cVar1)
                     ) {
                    UIWidget.CreatePanel(this,0);
                  }
                }
              }
              else {
                if (this.drawCall == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                this.drawCall.isDirty = 1;
              }
              UIWidget.CheckLayer(this,0);
            }
          }
        }
    }

    // Token : 0x6000541
    // RVA   : 0x9D62B0   Offset: 0x9D4AB0   Length: 0x1E3
    public UIPanel CreatePanel()
    {
        bool cVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        if ((char)this[17] != false) {
          lVar4 = this[29];
          cVar1 = Object.op_Equality(lVar4,0,0);
          if (cVar1) {
            cVar1 = Behaviour.get_enabled(this,0);
            if (cVar1) {
              uVar3 = Component.get_gameObject(this,0);
              cVar1 = NGUITools.GetActive(uVar3,0);
              if (cVar1) {
                uVar3 = UIRect.get_cachedTransform(this,0);
                lVar4 = UIRect.get_cachedGameObject(this,0);
                if (lVar4 == null) {
        LAB_1809d648e:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar2 = GameObject.get_layer(lVar4,0);
                lVar4 = UIPanel.Find(uVar3,1,uVar2,0);
                this[29] = lVar4;
                il2cpp_internal(this + 29,lVar4);
                lVar4 = this[29];
                cVar1 = Object.op_Inequality(lVar4,0,0);
                if (cVar1) {
                  *(uint8 *)((int64)this + 89) = 0;
                  if (this[29] == 0) goto LAB_1809d648e;
                  UIPanel.AddWidget(this[29],this,0);
                  UIWidget.CheckLayer(this,0);
                  (**(code **)(*this + 0x1f8))(this,1,*(uint64 *)(*this + 0x200));
                }
              }
            }
          }
        }
        return this[29];
    }

    // Token : 0x6000542
    // RVA   : 0x9D6160   Offset: 0x9D4960   Length: 0x149
    public void CheckLayer()
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        uVar1 = this.panel;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          return;
        }
        if ((this.panel != null) &&
           (lVar6 = Component.get_gameObject(this.panel,0)) != null) {
          iVar3 = GameObject.get_layer(lVar6,0);
          lVar6 = Component.get_gameObject(this,0);
          if (lVar6 != null) {
            iVar4 = GameObject.get_layer(lVar6,0);
            if (iVar3 == iVar4) {
              return;
            }
            Debug.LogWarning("You can't place widgets on a layer different than the UIPanel that manages them.\nIf you want to move widgets to a different layer, parent them to a new panel instead.",this,0);
            lVar6 = Component.get_gameObject(this,0);
            if (((this.panel != null) &&
                (lVar7 = Component.get_gameObject(this.panel,0)) != null) &&
               (uVar5 = GameObject.get_layer(lVar7,0), lVar6 != null)) {
              GameObject.set_layer(lVar6,uVar5,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000543
    // RVA   : 0x9D7DC0   Offset: 0x9D65C0   Length: 0x13B
    public override void ParentHasChanged()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        UIRect.ParentHasChanged(this,0);
        uVar1 = this.panel;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          uVar1 = UIRect.get_cachedTransform(this,0);
          lVar5 = UIRect.get_cachedGameObject(this,0);
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar4 = GameObject.get_layer(lVar5,0);
          uVar2 = UIPanel.Find(uVar1,1,uVar4,0);
          uVar1 = this.panel;
          cVar3 = Object.op_Inequality(uVar1,uVar2,0);
          if (cVar3) {
            UIWidget.RemoveFromPanel(this,0);
            UIWidget.CreatePanel(this,0);
          }
        }
    }

    // Token : 0x6000544
    // RVA   : 0x9D5CF0   Offset: 0x9D44F0   Length: 0x23
    protected override void Awake()
    {
        byte uVar1;
        UIPanel.Awake(this,0);
        uVar1 = Application.get_isPlaying(0);
        this.mPlayMode = uVar1;
    }

    // Token : 0x6000545
    // RVA   : 0x9D7B90   Offset: 0x9D6390   Length: 0x30
    protected override void OnInit()
    {
        UIRect.OnInit(this,0);
        UIWidget.RemoveFromPanel(this,0);
        this.mMoved = 1;
        UIRect.Update(this,0);
    }

    // Token : 0x6000546
    // RVA   : 0x9D9120   Offset: 0x9D7920   Length: 0xCE
    protected virtual void UpgradeFrom265()
    {
        ulong uVar1;
        uint uVar3;
        long lVar4;
        byte[] local_28 = new byte[32];
        lVar4 = UIRect.get_cachedTransform(this,0);
        if (lVar4 != null) {
          puVar2 = (uint64 *)Transform.get_localScale(local_28,lVar4,0);
          uVar1 = *puVar2;
          uVar3 = Mathf.RoundToInt((int)uVar1,0);
          uVar3 = Mathf.Abs(uVar3,0);
          this.mWidth = uVar3;
          uVar3 = Mathf.RoundToInt((int)((uint64)uVar1 >> 32),0);
          uVar3 = Mathf.Abs(uVar3,0);
          this.mHeight = uVar3;
          uVar1 = Component.get_gameObject(this,0);
          NGUITools.UpdateWidgetCollider(uVar1,1,0);
          return;
        }
    }

    // Token : 0x6000547
    // RVA   : 0x9D7BC0   Offset: 0x9D63C0   Length: 0x7
    protected override void OnStart()
    {
        UIWidget.CreatePanel(this,0);
    }

    // Token : 0x6000548
    // RVA   : 0x9D6F80   Offset: 0x9D5780   Length: 0xBB5
    protected override void OnAnchor()
    {
        float fVar1;
        float fVar2;
        ulong uVar3;
        ulong uVar4;
        bool cVar5;
        int iVar6;
        int iVar7;
        int iVar8;
        long lVar9;
        ulong uVar10;
        ulong uVar12;
        ulong uVar14;
        float fVar15;
        float fVar16;
        uint64 extraout_XMM0_Qa;
        uint64 extraout_XMM0_Qa_00;
        uint64 extraout_XMM0_Qa_01;
        uint64 extraout_XMM0_Qa_02;
        uint64 extraout_XMM0_Qa_03;
        uint64 extraout_XMM0_Qa_04;
        uint64 uVar17;
        uint64 extraout_XMM0_Qa_05;
        uint64 extraout_XMM0_Qa_06;
        uint64 extraout_XMM0_Qa_07;
        uint64 extraout_XMM0_Qa_08;
        uint64 extraout_XMM0_Qa_09;
        uint64 extraout_XMM0_Qa_10;
        uint64 extraout_XMM0_Qa_11;
        uint64 extraout_XMM0_Qa_12;
        uint64 extraout_XMM0_Qa_13;
        float local_res18;
        float fStackX_1c;
        uint64 local_f8;
        float local_e8;
        float fStack_e4;
        uint64 local_d8;
        float local_d0;
        uint8 local_c8 [176];
        lVar9 = UIRect.get_cachedTransform(this,0);
        uVar17 = extraout_XMM0_Qa;
        if (lVar9 == null) goto LAB_1809d7a70;
        uVar10 = FUN_180da0f00(lVar9,0);
        puVar11 = (uint64 *)Transform.get_localPosition(&local_d8,lVar9,0);
        fVar2 = *(float *)(puVar11 + 1);
        uVar14 = *puVar11;
        uVar12 = NGUIMath.GetPivotOffset((int)this[20],0);
        uVar17 = extraout_XMM0_Qa_00;
        if (this[3] == 0) goto LAB_1809d7a70;
        uVar3 = *(uint64 *)(this[3] + 16);
        if (this[5] == 0) goto LAB_1809d7a70;
        uVar4 = *(uint64 *)(this[5] + 16);
        cVar5 = Object.op_Equality(uVar3,uVar4,0);
        fStack_e4 = (float)((uint64)uVar14 >> 32);
        local_e8 = (float)uVar14;
        fStackX_1c = (float)((uint64)uVar12 >> 32);
        local_res18 = (float)uVar12;
        uVar17 = extraout_XMM0_Qa_01;
        if (!cVar5) {
        LAB_1809d73e3:
          *(uint8 *)((int64)this + 0x14e) = 1;
          if (this[3] == 0) goto LAB_1809d7a70;
          uVar14 = *(uint64 *)(this[3] + 16);
          cVar5 = Object.op_Implicit(uVar14,0);
          if (!cVar5) {
            uVar17 = (uint64)(uint32)((float)*(int *)((int64)this + 164) * local_res18);
          }
          else {
            uVar17 = extraout_XMM0_Qa_05;
            if (this[3] == 0) goto LAB_1809d7a70;
            lVar9 = AnchorPoint.GetSides(this[3],uVar10,0);
            if (lVar9 == null) {
              uVar17 = UIRect.GetLocalPos(local_c8,this,this[3],uVar10,0);
              lVar9 = this[3];
            }
            else {
              if (*(uint32 *)(lVar9 + 24) == 0) {
                uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar14,0);
              }
              if (*(uint32 *)(lVar9 + 24) < 3) {
                uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar14,0);
              }
              uVar17 = extraout_XMM0_Qa_06;
              if (this[3] == 0) goto LAB_1809d7a70;
              uVar17 = NGUIMath.Lerp();
              lVar9 = this[3];
            }
            if (lVar9 == null) goto LAB_1809d7a70;
          }
          if (this[4] == 0) goto LAB_1809d7a70;
          uVar14 = *(uint64 *)(this[4] + 16);
          cVar5 = Object.op_Implicit(uVar14,0);
          if (!cVar5) {
            uVar17 = (uint64)(uint32)(local_res18 * (float)*(int *)((int64)this + 164));
          }
          else {
            uVar17 = extraout_XMM0_Qa_07;
            if (this[4] == 0) goto LAB_1809d7a70;
            lVar9 = AnchorPoint.GetSides(this[4],uVar10,0);
            if (lVar9 == null) {
              uVar17 = UIRect.GetLocalPos(local_c8,this,this[4],uVar10,0);
              lVar9 = this[4];
            }
            else {
              if (*(uint32 *)(lVar9 + 24) == 0) {
                uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar14,0);
              }
              if (*(uint32 *)(lVar9 + 24) < 3) {
                uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar14,0);
              }
              uVar17 = extraout_XMM0_Qa_08;
              if (this[4] == 0) goto LAB_1809d7a70;
              uVar17 = NGUIMath.Lerp();
              lVar9 = this[4];
            }
            if (lVar9 == null) goto LAB_1809d7a70;
          }
          if (this[5] == 0) goto LAB_1809d7a70;
          uVar14 = *(uint64 *)(this[5] + 16);
          cVar5 = Object.op_Implicit(uVar14,0);
          if (!cVar5) {
            uVar17 = (uint64)(uint32)((float)(int)this[21] * fStackX_1c);
          }
          else {
            uVar17 = extraout_XMM0_Qa_09;
            if (this[5] == 0) goto LAB_1809d7a70;
            lVar9 = AnchorPoint.GetSides(this[5],uVar10,0);
            if (lVar9 == null) {
              puVar13 = (uint64 *)UIRect.GetLocalPos(local_c8,this,this[5],uVar10,0);
              uVar17 = *puVar13;
              local_d0 = *(float *)(puVar13 + 1);
              lVar9 = this[5];
              local_d8 = uVar17;
            }
            else {
              if (*(uint32 *)(lVar9 + 24) < 4) {
                uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar14,0);
              }
              uVar17 = extraout_XMM0_Qa_10;
              if (this[5] == 0) goto LAB_1809d7a70;
              uVar17 = NGUIMath.Lerp();
              lVar9 = this[5];
            }
            if (lVar9 == null) goto LAB_1809d7a70;
          }
          if (this[6] == 0) goto LAB_1809d7a70;
          uVar14 = *(uint64 *)(this[6] + 16);
          cVar5 = Object.op_Implicit(uVar14,0);
          if (cVar5) {
            uVar17 = extraout_XMM0_Qa_11;
            if (this[6] == 0) goto LAB_1809d7a70;
            lVar9 = AnchorPoint.GetSides(this[6],uVar10,0);
            if (lVar9 == null) {
              puVar13 = (uint64 *)UIRect.GetLocalPos(local_c8,this,this[6],uVar10,0);
              uVar17 = *puVar13;
              local_d0 = *(float *)(puVar13 + 1);
              lVar9 = this[6];
              local_d8 = uVar17;
            }
            else {
              if (*(uint32 *)(lVar9 + 24) < 4) {
                uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar14,0);
              }
              uVar17 = extraout_XMM0_Qa_12;
              if (this[6] == 0) goto LAB_1809d7a70;
              uVar17 = NGUIMath.Lerp();
              lVar9 = this[6];
            }
            if (lVar9 == null) goto LAB_1809d7a70;
          }
        }
        else {
          if (this[3] == 0) goto LAB_1809d7a70;
          uVar14 = *(uint64 *)(this[3] + 16);
          if (this[4] == 0) goto LAB_1809d7a70;
          uVar12 = *(uint64 *)(this[4] + 16);
          cVar5 = Object.op_Equality(uVar14,uVar12,0);
          uVar17 = extraout_XMM0_Qa_02;
          if (!cVar5) goto LAB_1809d73e3;
          if (this[3] == 0) goto LAB_1809d7a70;
          uVar14 = *(uint64 *)(this[3] + 16);
          if (this[6] == 0) goto LAB_1809d7a70;
          uVar12 = *(uint64 *)(this[6] + 16);
          cVar5 = Object.op_Equality(uVar14,uVar12,0);
          uVar17 = extraout_XMM0_Qa_03;
          if (!cVar5) goto LAB_1809d73e3;
          if (this[3] == 0) goto LAB_1809d7a70;
          lVar9 = AnchorPoint.GetSides(this[3],uVar10,0);
          if (lVar9 == null) {
            puVar13 = (uint64 *)UIRect.GetLocalPos(local_c8,this,this[3],uVar10,0);
            uVar17 = *puVar13;
            local_d0 = *(float *)(puVar13 + 1);
            local_d8 = uVar17;
            if ((((this[3] == 0) || (this[5] == 0)) || (this[4] == 0)) || (this[6] == 0))
            goto LAB_1809d7a70;
            if (*(char *)((int64)this + 209) == false) {
              *(uint8 *)((int64)this + 0x14e) = 1;
            }
            else {
              *(bool *)((int64)this + 0x14e) = 0.0 <= local_d0;
            }
          }
          else {
            if (*(uint32 *)(lVar9 + 24) == 0) {
              uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar14,0);
            }
            if (*(uint32 *)(lVar9 + 24) < 3) {
              uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar14,0);
            }
            uVar17 = extraout_XMM0_Qa_04;
            if ((this[3] == 0) || (uVar17 = NGUIMath.Lerp(), this[3] == 0)) goto LAB_1809d7a70;
            if (*(uint32 *)(lVar9 + 24) == 0) {
              uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar14,0);
            }
            if (*(uint32 *)(lVar9 + 24) < 3) {
              uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar14,0);
            }
            if ((this[4] == 0) || (uVar17 = NGUIMath.Lerp(), this[4] == 0)) goto LAB_1809d7a70;
            if (*(uint32 *)(lVar9 + 24) < 4) {
              uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar14,0);
            }
            if ((this[5] == 0) || (uVar17 = NGUIMath.Lerp(), this[5] == 0)) goto LAB_1809d7a70;
            if (*(uint32 *)(lVar9 + 24) < 4) {
              uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar14,0);
            }
            if ((this[6] == 0) || (uVar17 = NGUIMath.Lerp(), this[6] == 0)) goto LAB_1809d7a70;
            *(uint8 *)((int64)this + 0x14e) = 1;
          }
        }
        Mathf.Lerp();
        Mathf.Lerp();
        fVar15 = (float)FUN_18000d7c0();
        fVar16 = (float)FUN_18000d7c0();
        local_f8 = CONCAT44(fVar16,fVar15);
        iVar6 = Mathf.FloorToInt();
        iVar7 = Mathf.FloorToInt();
        if ((*(int *)((int64)this + 212) != 0) &&
           (fVar1 = *(float *)(this + 27), fVar1 != 0.0)) {
          if (*(int *)((int64)this + 212) == 2) {
            iVar6 = Mathf.RoundToInt((float)iVar7 * fVar1,0);
          }
          else {
            iVar7 = Mathf.RoundToInt((float)iVar6 / fVar1,0);
          }
        }
        iVar8 = (**(code **)(*this + 0x358))(this,*(uint64 *)(*this + 0x360));
        if (iVar6 < iVar8) {
          iVar6 = (**(code **)(*this + 0x358))(this,*(uint64 *)(*this + 0x360));
        }
        iVar8 = (**(code **)(*this + 0x368))(this,*(uint64 *)(*this + 0x370));
        if (iVar7 < iVar8) {
          iVar7 = (**(code **)(*this + 0x368))(this,*(uint64 *)(*this + 0x370));
        }
        if (0.001 < (local_e8 - fVar15) * (local_e8 - fVar15) +
                    (fStack_e4 - fVar16) * (fStack_e4 - fVar16) + (fVar2 - fVar2) * (fVar2 - fVar2)) {
          lVar9 = UIRect.get_cachedTransform(this,0);
          uVar17 = extraout_XMM0_Qa_13;
          if (lVar9 == null) {
        LAB_1809d7a70:
                          // WARNING: Subroutine does not return
            FUN_1800d6620(uVar17);
          }
          local_d8 = local_f8;
          local_d0 = fVar2;
          Transform.set_localPosition(lVar9,&local_d8,0);
          if (*(char *)((int64)this + 0x14e) != false) {
            *(uint8 *)(this + 11) = 1;
          }
        }
        if ((*(int *)((int64)this + 164) != iVar6) || ((int)this[21] != iVar7)) {
          *(int *)((int64)this + 164) = iVar6;
          *(int *)(this + 21) = iVar7;
          if (*(char *)((int64)this + 0x14e) != false) {
            *(uint8 *)(this + 11) = 1;
          }
          if ((char)this[26] != false) {
            UIWidget.ResizeCollider(this,0);
          }
        }
    }

    // Token : 0x6000549
    // RVA   : 0x9D7BD0   Offset: 0x9D63D0   Length: 0x74
    protected override void OnUpdate()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.panel;
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (cVar2) {
          UIWidget.CreatePanel(this,0);
        }
    }

    // Token : 0x600054A
    // RVA   : 0x9D7B40   Offset: 0x9D6340   Length: 0x16
    private void OnApplicationPause(bool paused)
    {
        void FUN_1809d7b40(int64 *this,char paused)
        {
        if (!paused) {
                          // WARNING: Could not recover jumptable at 0x0001809d7b4e. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x600054B
    // RVA   : 0x9D7B70   Offset: 0x9D6370   Length: 0x1F
    protected override void OnDisable()
    {
        UIWidget.RemoveFromPanel(this,0);
        UIRect.OnDisable(this,0);
    }

    // Token : 0x600054C
    // RVA   : 0x9D7B60   Offset: 0x9D6360   Length: 0x7
    private void OnDestroy()
    {
        void FUN_1809d7b60(uint64 this)
        {
        UIWidget.RemoveFromPanel(this,0);
    }

    // Token : 0x600054D
    // RVA   : 0x9D90F0   Offset: 0x9D78F0   Length: 0x28
    public bool UpdateVisibility(bool visibleByAlpha, bool visibleByPanel)
    {
        if ((this.mIsVisibleByAlpha == visibleByAlpha) && (this.mIsVisibleByPanel == visibleByPanel)) {
          return false;
        }
        *(uint8 *)(this + 88) = 1;
        this.mIsVisibleByAlpha = visibleByAlpha;
        this.mIsVisibleByPanel = visibleByPanel;
        return true;
    }

    // Token : 0x600054E
    // RVA   : 0x9D8C80   Offset: 0x9D7480   Length: 0x46A
    public bool UpdateTransform(int frame)
    {
        ulong uVar1;
        int iVar2;
        int iVar3;
        float fVar4;
        long lVar5;
        byte uVar6;
        bool cVar7;
        long lVar8;
        ulong uVar9;
        float fVar11;
        float fVar12;
        float fVar13;
        float local_res8;
        float fStackX_c;
        uint64 local_b8;
        float local_b0;
        uint64 local_a8;
        float local_a0;
        uint8 local_98 [16];
        uint8 local_88 [112];
        lVar8 = UIRect.get_cachedTransform(this,0);
        uVar6 = Application.get_isPlaying(0);
        this.mPlayMode = uVar6;
        if (!this.mMoved) {
          if (this.panel == null) goto LAB_1809d90e5;
          if (!this.panel.widgetsAreStatic) {
            if (lVar8 == null) goto LAB_1809d90e5;
            cVar7 = Transform.get_hasChanged(lVar8,0);
            if (cVar7) {
              this.mMatrixFrame = 0xffffffff;
              Transform.set_hasChanged(lVar8,0,0);
              uVar9 = NGUIMath.GetPivotOffset(this.mPivot,0);
              iVar2 = this.mWidth;
              iVar3 = this.mHeight;
              lVar5 = this.panel;
              local_res8 = (float)uVar9;
              fStackX_c = (float)((uint64)uVar9 >> 32);
              fVar12 = -local_res8 * (float)iVar2;
              fVar13 = -fStackX_c * (float)iVar3;
              if (lVar5 == null) goto LAB_1809d90e5;
              puVar10 = (uint64 *)
                        Transform.TransformPoint(local_98,lVar8,fVar12,CONCAT44(0x80000000,fVar13),0,0);
              local_b8 = *puVar10;
              local_b0 = *(float *)(puVar10 + 1);
              puVar10 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_98,lVar5 + 192,&local_b8,0);
              lVar5 = this.panel;
              uVar9 = *puVar10;
              fVar4 = *(float *)(puVar10 + 1);
              local_b8 = uVar9;
              local_b0 = fVar4;
              if (lVar5 == null) goto LAB_1809d90e5;
              puVar10 = (uint64 *)
                        Transform.TransformPoint
                                  (local_98,lVar8,(float)iVar2 + fVar12,(float)iVar3 + fVar13,0,0);
              local_a8 = *puVar10;
              local_a0 = *(float *)(puVar10 + 1);
              puVar10 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_88,lVar5 + 192,&local_a8,0);
              local_a0 = *(float *)(this + 0x178);
              fVar11 = (float)this.mOldV0 - (float)local_b8;
              uVar1 = *puVar10;
              fVar12 = *(float *)(puVar10 + 1);
              fVar13 = (float)((uint64)this.mOldV0 >> 32) - local_b8._4_4_;
              if (fVar13 * fVar13 + fVar11 * fVar11 + (local_a0 - local_b0) * (local_a0 - local_b0) <=
                  1e-06) {
                local_a0 = *(float *)(this + 0x184);
                fVar11 = (float)this.mOldV1 - (float)uVar1;
                fVar13 = (float)((uint64)this.mOldV1 >> 32) -
                         (float)((uint64)uVar1 >> 32);
                local_b0 = fVar12;
                if (fVar13 * fVar13 + fVar11 * fVar11 + (local_a0 - fVar12) * (local_a0 - fVar12) <= 1e-06
                   ) goto LAB_1809d907d;
              }
              this.mOldV0 = uVar9;
              this.mOldV1 = uVar1;
              *(float *)(this + 0x178) = fVar4;
              *(float *)(this + 0x184) = fVar12;
              this.mMoved = 1;
            }
          }
        }
        else {
          this.mMoved = 1;
          this.mMatrixFrame = 0xffffffff;
          if (lVar8 == null) {
        LAB_1809d90e5:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Transform.set_hasChanged(lVar8,0,0);
          uVar9 = NGUIMath.GetPivotOffset(this.mPivot,0);
          iVar2 = this.mWidth;
          iVar3 = this.mHeight;
          lVar5 = this.panel;
          local_res8 = (float)uVar9;
          fStackX_c = (float)((uint64)uVar9 >> 32);
          fVar12 = -local_res8 * (float)iVar2;
          fVar13 = -fStackX_c * (float)iVar3;
          if (lVar5 == null) goto LAB_1809d90e5;
          puVar10 = (uint64 *)
                    Transform.TransformPoint(local_88,lVar8,fVar12,CONCAT44(0x80000000,fVar13),0,0);
          local_a8 = *puVar10;
          local_a0 = *(float *)(puVar10 + 1);
          puVar10 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_88,lVar5 + 192,&local_a8,0);
          lVar5 = this.panel;
          this.mOldV0 = *puVar10;
          *(uint32 *)(this + 0x178) = *(uint32 *)(puVar10 + 1);
          if (lVar5 == null) goto LAB_1809d90e5;
          puVar10 = (uint64 *)
                    Transform.TransformPoint
                              (local_88,lVar8,(float)iVar2 + fVar12,(float)iVar3 + fVar13,0,0);
          local_a8 = *puVar10;
          local_a0 = *(float *)(puVar10 + 1);
          puVar10 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_88,lVar5 + 192,&local_a8,0);
          this.mOldV1 = *puVar10;
          *(uint32 *)(this + 0x184) = *(uint32 *)(puVar10 + 1);
        }
        LAB_1809d907d:
        if (!this.mMoved) {
        LAB_1809d90df:
          uVar6 = *(uint8 *)(this + 88);
        }
        else {
          if (this.onChange != null) {
            OnGeometryUpdated.Invoke(this.onChange,0);
            if (!this.mMoved) goto LAB_1809d90df;
          }
          uVar6 = 1;
        }
        return uVar6;
    }

    // Token : 0x600054F
    // RVA   : 0x9D8840   Offset: 0x9D7040   Length: 0x431
    public bool UpdateGeometry(int frame)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        bool cVar11;
        byte uVar12;
        long lVar13;
        ulong uVar15;
        float fVar18;
        ulong local_108;
        ulong uStack_100;
        ulong local_f8;
        ulong uStack_f0;
        ulong local_e8;
        ulong uStack_e0;
        ulong local_d8;
        ulong uStack_d0;
        ulong local_c8;
        ulong uStack_c0;
        ulong local_b8;
        ulong uStack_b0;
        ulong local_a8;
        ulong uStack_a0;
        ulong local_98;
        ulong uStack_90;
        byte[] local_88 = new byte[128];
        fVar18 = (float)(**(code **)(*this + 0x1c8))(this,frame,*(uint64 *)(*this + 0x1d0))
        ;
        if ((*(char *)((int64)this + 0x14c) != false) && (*(float *)(this + 42) != fVar18)) {
          *(uint8 *)(this + 11) = 1;
        }
        *(float *)(this + 42) = fVar18;
        if ((char)this[11] == false) {
          if (*(char *)((int64)this + 0x154) != false) {
            if (this[30] == 0) goto LAB_1809d8c6c;
            cVar11 = UIGeometry.get_hasVertices(this[30],0);
            if (cVar11) {
              if (*(int *)((int64)this + 0x16c) != frame) {
                lVar13 = this[29];
                if (lVar13 == null) goto LAB_1809d8c6c;
                uVar15 = *(uint64 *)(lVar13 + 192);
                uVar4 = *(uint64 *)(lVar13 + 200);
                uVar5 = *(uint64 *)(lVar13 + 208);
                uVar6 = *(uint64 *)(lVar13 + 216);
                uVar7 = *(uint64 *)(lVar13 + 224);
                uVar8 = *(uint64 *)(lVar13 + 232);
                uVar9 = *(uint64 *)(lVar13 + 240);
                uVar10 = *(uint64 *)(lVar13 + 248);
                lVar13 = UIRect.get_cachedTransform(this,0);
                if (lVar13 == null) goto LAB_1809d8c6c;
                puVar14 = (uint64 *)Transform.get_localToWorldMatrix(&local_108,lVar13,0);
                puVar16 = &local_c8;
                puVar17 = &local_108;
                local_108 = uVar15;
                uStack_100 = uVar4;
                local_f8 = uVar5;
                uStack_f0 = uVar6;
                local_e8 = uVar7;
                uStack_e0 = uVar8;
                local_d8 = uVar9;
                uStack_d0 = uVar10;
                local_c8 = *puVar14;
                uStack_c0 = puVar14[1];
                local_b8 = puVar14[2];
                uStack_b0 = puVar14[3];
                local_a8 = puVar14[4];
                uStack_a0 = puVar14[5];
                local_98 = puVar14[6];
                uStack_90 = puVar14[7];
        LAB_1809d8b42:
                puVar16 = (uint64 *)Matrix4x4.op_Multiply(local_88,puVar17,puVar16,0);
                uVar15 = puVar16[1];
                *(uint64 *)((int64)this + 0x10c) = *puVar16;
                *(uint64 *)((int64)this + 0x114) = uVar15;
                uVar15 = puVar16[3];
                *(uint64 *)((int64)this + 0x11c) = puVar16[2];
                *(uint64 *)((int64)this + 0x124) = uVar15;
                uVar1 = *(uint32 *)((int64)puVar16 + 36);
                uVar2 = *(uint32 *)(puVar16 + 5);
                uVar3 = *(uint32 *)((int64)puVar16 + 44);
                *(uint32 *)((int64)this + 300) = *(uint32 *)(puVar16 + 4);
                *(uint32 *)(this + 38) = uVar1;
                *(uint32 *)((int64)this + 0x134) = uVar2;
                *(uint32 *)(this + 39) = uVar3;
                uVar15 = puVar16[6];
                uVar4 = puVar16[7];
                *(int *)((int64)this + 0x16c) = frame;
                *(uint64 *)((int64)this + 0x13c) = uVar15;
                *(uint64 *)((int64)this + 0x144) = uVar4;
              }
              goto LAB_1809d8b7f;
            }
          }
        LAB_1809d8c47:
          uVar12 = 0;
        }
        else {
          if ((*(char *)((int64)this + 0x14c) == false) || (fVar18 <= 0.001)) {
        LAB_1809d8c30:
            if (this[30] == 0) {
        LAB_1809d8c6c:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar11 = UIGeometry.get_hasVertices(this[30],0);
            if (!cVar11) goto LAB_1809d8c47;
            if ((char)this[31] != false) {
              if (this[30] == 0) goto LAB_1809d8c6c;
              UIGeometry.Clear(this[30],0);
            }
          }
          else {
            uVar15 = (**(code **)(*this + 0x308))(this,*(uint64 *)(*this + 0x310));
            cVar11 = Object.op_Inequality(uVar15,0,0);
            if (!cVar11) goto LAB_1809d8c30;
            if (this[30] == 0) goto LAB_1809d8c6c;
            uVar12 = UIGeometry.get_hasVertices(this[30],0);
            if ((char)this[31] != false) {
              if (this[30] == 0) goto LAB_1809d8c6c;
              UIGeometry.Clear(this[30],0);
              lVar13 = this[30];
              if (lVar13 == null) goto LAB_1809d8c6c;
              (**(code **)(*this + 0x398))
                        (this,*(uint64 *)(lVar13 + 16),*(uint64 *)(lVar13 + 24),
                         *(uint64 *)(lVar13 + 32),*(uint64 *)(*this + 0x3a0));
            }
            if (this[30] == 0) goto LAB_1809d8c6c;
            cVar11 = UIGeometry.get_hasVertices(this[30],0);
            if (!cVar11) goto LAB_1809d8bed;
            if (*(int *)((int64)this + 0x16c) != frame) {
              lVar13 = this[29];
              if (lVar13 == null) goto LAB_1809d8c6c;
              uVar15 = *(uint64 *)(lVar13 + 192);
              uVar4 = *(uint64 *)(lVar13 + 200);
              uVar5 = *(uint64 *)(lVar13 + 208);
              uVar6 = *(uint64 *)(lVar13 + 216);
              uVar7 = *(uint64 *)(lVar13 + 224);
              uVar8 = *(uint64 *)(lVar13 + 232);
              uVar9 = *(uint64 *)(lVar13 + 240);
              uVar10 = *(uint64 *)(lVar13 + 248);
              lVar13 = UIRect.get_cachedTransform(this,0);
              if (lVar13 == null) goto LAB_1809d8c6c;
              puVar14 = (uint64 *)Transform.get_localToWorldMatrix(local_88,lVar13,0);
              puVar16 = &local_108;
              puVar17 = &local_c8;
              local_108 = *puVar14;
              uStack_100 = puVar14[1];
              local_f8 = puVar14[2];
              uStack_f0 = puVar14[3];
              local_e8 = puVar14[4];
              uStack_e0 = puVar14[5];
              local_d8 = puVar14[6];
              uStack_d0 = puVar14[7];
              local_c8 = uVar15;
              uStack_c0 = uVar4;
              local_b8 = uVar5;
              uStack_b0 = uVar6;
              local_a8 = uVar7;
              uStack_a0 = uVar8;
              local_98 = uVar9;
              uStack_90 = uVar10;
              goto LAB_1809d8b42;
            }
        LAB_1809d8b7f:
            if ((this[29] == 0) || (this[30] == 0)) goto LAB_1809d8c6c;
            local_108 = *(uint64 *)((int64)this + 0x10c);
            uStack_100 = *(uint64 *)((int64)this + 0x114);
            local_f8 = *(uint64 *)((int64)this + 0x11c);
            uStack_f0 = *(uint64 *)((int64)this + 0x124);
            local_e8 = *(uint64 *)((int64)this + 300);
            uStack_e0 = *(uint64 *)((int64)this + 0x134);
            local_d8 = *(uint64 *)((int64)this + 0x13c);
            uStack_d0 = *(uint64 *)((int64)this + 0x144);
            UIGeometry.ApplyTransform(this[30],&local_108,*(uint8 *)(this[29] + 153),0);
          }
          uVar12 = 1;
        }
        *(uint8 *)((int64)this + 0x154) = 0;
        LAB_1809d8bed:
        *(uint8 *)(this + 11) = 0;
        return uVar12;
    }

    // Token : 0x6000550
    // RVA   : 0x9D91F0   Offset: 0x9D79F0   Length: 0x2A
    public void WriteToBuffers(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2)
    {
        if (this.geometry != null) {
          UIGeometry.WriteToBuffers();
          return;
        }
    }

    // Token : 0x6000551
    // RVA   : 0x9D6C10   Offset: 0x9D5410   Length: 0x14B
    public virtual void MakePixelPerfect()
    {
        ulong uVar1;
        long lVar2;
        uint uVar4;
        uint uVar5;
        uint uVar6;
        ulong local_48;
        ulong local_38;
        uint local_30;
        byte[] local_28 = new byte[32];
        lVar2 = UIRect.get_cachedTransform(this,0);
        if (lVar2 != null) {
          puVar3 = (uint64 *)Transform.get_localPosition(local_28,lVar2,0);
          local_30 = *(uint32 *)(puVar3 + 1);
          uVar1 = *puVar3;
          local_38 = uVar1;
          uVar4 = FUN_18000d7c0(local_30);
          uVar5 = FUN_18000d7c0(uVar1);
          local_48._4_4_ = (uint32)((uint64)uVar1 >> 32);
          uVar6 = FUN_18000d7c0(local_48._4_4_);
          local_48 = CONCAT44(uVar6,uVar5);
          lVar2 = UIRect.get_cachedTransform(this,0);
          if (lVar2 != null) {
            local_38 = local_48;
            local_30 = uVar4;
            Transform.set_localPosition(lVar2,&local_38,0);
            lVar2 = UIRect.get_cachedTransform(this,0);
            if (lVar2 != null) {
              puVar3 = (uint64 *)Transform.get_localScale(local_28,lVar2,0);
              uVar1 = *puVar3;
              uVar5 = (uint32)((uint64)uVar1 >> 32);
              local_30 = *(uint32 *)(puVar3 + 1);
              lVar2 = UIRect.get_cachedTransform(this,0);
              uVar4 = Mathf.Sign(uVar1,0);
              local_38 = uVar1;
              uVar5 = Mathf.Sign(CONCAT44(uVar5,uVar5),0);
              local_48 = CONCAT44(uVar5,uVar4);
              if (lVar2 != null) {
                local_38 = local_48;
                local_30 = 0x3f800000;
                Transform.set_localScale(lVar2,&local_38,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000552
    // RVA   : 0x2C1010   Offset: 0x2BF810   Length: 0x6
    public virtual int get_minWidth()
    {
        return 2;
    }

    // Token : 0x6000553
    // RVA   : 0x2C1010   Offset: 0x2BF810   Length: 0x6
    public virtual int get_minHeight()
    {
        return 2;
    }

    // Token : 0x6000554
    // RVA   : 0x9D9390   Offset: 0x9D7B90   Length: 0x24
    public virtual Vector4 get_border()
    {
        ulong uVar1;
        byte[] local_18 = new byte[16];
        puVar2 = (uint64 *)Vector4.get_zero(local_18,0);
        uVar1 = puVar2[1];
        *this = *puVar2;
        this[1] = uVar1;
        return this;
    }

    // Token : 0x6000555
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    public virtual void set_border(Vector4 value)
    {
    }

    // Token : 0x6000556
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    public virtual void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
    }

    // Token : 0x6000557
    // RVA   : 0x9D9220   Offset: 0x9D7A20   Length: 0x15F
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar6;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        puVar5 = (uint32 *)FUN_181098a50(local_18,0);
        uVar1 = *puVar5;
        uVar2 = puVar5[1];
        uVar3 = puVar5[2];
        uVar4 = puVar5[3];
        this.mPivot = 4;
        this.mWidth = 100;
        this.mColor = uVar1;
        *(uint32 *)(this + 148) = uVar2;
        *(uint32 *)(this + 152) = uVar3;
        *(uint32 *)(this + 156) = uVar4;
        this.mHeight = 100;
        this.aspectRatio = 0x3f800000;
        this.geometry = new UIGeometry(0);
        this.fillGeometry = 0x101;
        local_28 = 0;
        uStack_20 = 0;
        FUN_1809981e0(&local_28,0,0,0x3f800000,0x3f800000,0);
        this.mIsVisibleByAlpha = 0x101;
        this.mIsInFront = 1;
        this.mDrawRegion = (uint32)local_28;
        *(uint32 *)(this + 0x100) = local_28._4_4_;
        *(uint32 *)(this + 0x104) = (uint32)uStack_20;
        *(uint32 *)(this + 0x108) = uStack_20._4_4_;
        uVar6 = FUN_1800d60b0(DAT_181d81c40,4);
        this.mCorners = uVar6;
        this.mAlphaFrameID = 0xffffffffffffffff;
        UIRect.ctor(this,0);
    }

}
