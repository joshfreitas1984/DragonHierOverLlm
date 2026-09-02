// ============================================================
// Type  : UIPanel
// Token : 0x2000103
// ============================================================

public class UIPanel
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000654
    public static List<UIPanel> list;

    // Token: 0x4000655
    public OnGeometryUpdated onGeometryUpdated;

    // Token: 0x4000656
    public bool showInPanelTool;

    // Token: 0x4000657
    public bool generateNormals;

    // Token: 0x4000658
    public bool generateUV2;

    // Token: 0x4000659
    public ShadowMode shadowMode;

    // Token: 0x400065A
    public bool widgetsAreStatic;

    // Token: 0x400065B
    public bool cullWhileDragging;

    // Token: 0x400065C
    public bool alwaysOnScreen;

    // Token: 0x400065D
    public bool anchorOffset;

    // Token: 0x400065E
    public bool softBorderPadding;

    // Token: 0x400065F
    public RenderQueue renderQueue;

    // Token: 0x4000660
    public int startingRenderQueue;

    // Token: 0x4000661
    public List<UIWidget> widgets;

    // Token: 0x4000662
    public List<UIDrawCall> drawCalls;

    // Token: 0x4000663
    public Matrix4x4 worldToLocal;

    // Token: 0x4000664
    public Vector4 drawCallClipRange;

    // Token: 0x4000665
    public OnClippingMoved onClipMove;

    // Token: 0x4000666
    public OnCreateMaterial onCreateMaterial;

    // Token: 0x4000667
    public OnCreateDrawCall onCreateDrawCall;

    // Token: 0x4000668
    private Texture2D mClipTexture;

    // Token: 0x4000669
    private float mAlpha;

    // Token: 0x400066A
    private Clipping mClipping;

    // Token: 0x400066B
    private Vector4 mClipRange;

    // Token: 0x400066C
    private Vector2 mClipSoftness;

    // Token: 0x400066D
    private int mDepth;

    // Token: 0x400066E
    private int mSortingOrder;

    // Token: 0x400066F
    private string mSortingLayerName;

    // Token: 0x4000670
    private bool mRebuild;

    // Token: 0x4000671
    private bool mResized;

    // Token: 0x4000672
    private Vector2 mClipOffset;

    // Token: 0x4000673
    private int mMatrixFrame;

    // Token: 0x4000674
    private int mAlphaFrameID;

    // Token: 0x4000675
    private int mLayer;

    // Token: 0x4000676
    private static float[] mTemp;

    // Token: 0x4000677
    private Vector2 mMin;

    // Token: 0x4000678
    private Vector2 mMax;

    // Token: 0x4000679
    private bool mSortWidgets;

    // Token: 0x400067A
    private bool mUpdateScroll;

    // Token: 0x400067B
    public bool useSortingOrder;

    // Token: 0x400067C
    private UIPanel mParentPanel;

    // Token: 0x400067D
    private static Vector3[] mCorners;

    // Token: 0x400067E
    private static int mUpdateFrame;

    // Token: 0x400067F
    private bool mHasMoved;

    // Token: 0x4000680
    private OnRenderCallback mOnRender;

    // Token: 0x4000681
    private bool mForced;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000877
    // RVA   : 0xF02070   Offset: 0xF00870   Length: 0x8
    public string get_sortingLayerName()
    {
        uint64 FUN_180f02070(int64 this)
        {
        return this.mSortingLayerName;
    }

    // Token : 0x6000878
    // RVA   : 0x1577810   Offset: 0x1576010   Length: 0xD1
    public void set_sortingLayerName(string value)
    {
        var pStatics = *(int64*)(DAT_181d8ac58 + 184);
        bool cVar1;
        uint uVar2;
        cVar1 = String.op_Inequality(this.mSortingLayerName,value,0);
        if (cVar1) {
          this.mSortingLayerName = value;
          if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = FUN_1817ff280(*pStatics,this,DAT_181d82778);
          UIPanel.UpdateDrawCalls(this,uVar2,0);
        }
    }

    // Token : 0x6000879
    // RVA   : 0x15769D0   Offset: 0x15751D0   Length: 0x121
    public static int get_nextUnusedDepth()
    {
        var pStatics = *(int64*)(DAT_181d8ac58 + 184);
        int iVar1;
        int iVar2;
        long lVar3;
        int iVar4;
        iVar4 = 0;
        iVar2 = -0x80000000;
        if (*pStatics == 0) {
        LAB_181576aec:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar1 = *(int *)(*pStatics + 24);
        if (0 < iVar1) {
          do {
            if ((*pStatics == 0) ||
               (lVar3 = FUN_180002f80(*pStatics,iVar4,DAT_181d82978),
               lVar3 == null)) goto LAB_181576aec;
            iVar2 = Mathf.Max(iVar2,*(uint32 *)(lVar3 + 0x150),0);
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar1);
          if (iVar2 != -0x80000000) {
            return iVar2 + 1;
          }
        }
        return 0;
    }

    // Token : 0x600087A
    // RVA   : 0x1576030   Offset: 0x1574830   Length: 0xB
    public override bool get_canBeAnchored()
    {
        bool FUN_181576030(int64 this)
        {
        return this.mClipping != null;
    }

    // Token : 0x600087B
    // RVA   : 0x1361580   Offset: 0x135FD80   Length: 0x9
    public override float get_alpha()
    {
        uint32 FUN_181361580(int64 this)
        {
        return this.mAlpha;
    }

    // Token : 0x600087C
    // RVA   : 0x15772D0   Offset: 0x1575AD0   Length: 0x16C
    public override void set_alpha(float value)
    {
        float fVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        float fVar8;
        fVar8 = (float)Mathf.Clamp01(value,0);
        fVar1 = *(float *)(this + 38);
        if (fVar1 != fVar8) {
          *(uint32 *)(this + 46) = 0xffffffff;
          *(uint8 *)((int64)this + 0x161) = 1;
          *(float *)(this + 38) = fVar8;
          uVar7 = 0;
          if (this[23] == 0) {
        LAB_181577437:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar5 = (int64)*(int *)(this[23] + 24);
          if (0 < lVar5) {
            lVar6 = 32;
            uVar3 = uVar7;
            uVar4 = uVar7;
            do {
              lVar2 = this[23];
              if (lVar2 == null) goto LAB_181577437;
              if (*(uint32 *)(lVar2 + 24) <= (uint32)uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar6 + *(int64 *)(lVar2 + 16));
              if (lVar2 == null) goto LAB_181577437;
              uVar4 = (uint64)((uint32)uVar4 + 1);
              *(uint8 *)(lVar2 + 216) = 1;
              uVar3 = uVar3 + 1;
              lVar6 = lVar6 + 8;
            } while ((int64)uVar3 < lVar5);
          }
          if (fVar1 <= 0.001) {
            uVar7 = (uint64)(0.001 < *(float *)(this + 38));
          }
          (**(code **)(*this + 0x1f8))(this,uVar7,*(uint64 *)(*this + 0x200));
        }
    }

    // Token : 0x600087D
    // RVA   : 0x1576130   Offset: 0x1574930   Length: 0x7
    public int get_depth()
    {
        uint32 FUN_181576130(int64 this)
        {
        return this.mDepth;
    }

    // Token : 0x600087E
    // RVA   : 0x1577720   Offset: 0x1575F20   Length: 0xE9
    public void set_depth(int value)
    {
        long lVar1;
        ulong uVar2;
        if (this.mDepth != value) {
          this.mDepth = value;
          lVar1 = **(int64 **)(DAT_181d8ac58 + 184);
          uVar2 = new OnTooltipCB(0,DAT_181d9cc90,DAT_181d86518);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          List_1.Sort(lVar1,uVar2,DAT_181d82878);
        }
    }

    // Token : 0x600087F
    // RVA   : 0x1576B00   Offset: 0x1575300   Length: 0x7
    public int get_sortingOrder()
    {
        uint32 FUN_181576b00(int64 this)
        {
        return this.mSortingOrder;
    }

    // Token : 0x6000880
    // RVA   : 0x15778F0   Offset: 0x15760F0   Length: 0xA8
    public void set_sortingOrder(int value)
    {
        var pStatics = *(int64*)(DAT_181d8ac58 + 184);
        uint uVar1;
        if (this.mSortingOrder != value) {
          this.mSortingOrder = value;
          if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = FUN_1817ff280(*pStatics,this,DAT_181d82778);
          UIPanel.UpdateDrawCalls(this,uVar1,0);
        }
    }

    // Token : 0x6000881
    // RVA   : 0x15706E0   Offset: 0x156EEE0   Length: 0x128
    public static int CompareFunc(UIPanel a, UIPanel b)
    {
        bool cVar1;
        int iVar2;
        int iVar3;
        cVar1 = Object.op_Inequality(a,b,0);
        if (cVar1) {
          cVar1 = Object.op_Inequality(a,0,0);
          if (cVar1) {
            cVar1 = Object.op_Inequality(b,0,0);
            if (cVar1) {
              if ((a != null) && (b != null)) {
                if (*(int *)(a + 0x150) < *(int *)(b + 0x150)) {
                  return 0xffffffff;
                }
                if (*(int *)(a + 0x150) <= *(int *)(b + 0x150)) {
                  iVar2 = Object.GetInstanceID(a,0);
                  iVar3 = Object.GetInstanceID(b,0);
                  if (iVar2 < iVar3) {
                    return 0xffffffff;
                  }
                }
                return 1;
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
        return 0;
    }

    // Token : 0x6000882
    // RVA   : 0x1576BB0   Offset: 0x15753B0   Length: 0x1B
    public float get_width()
    {
        uint uVar1;
        uVar1 = UIPanel.GetViewSize(this,0);
        return uVar1;
    }

    // Token : 0x6000883
    // RVA   : 0x1576660   Offset: 0x1574E60   Length: 0x1B
    public float get_height()
    {
        uint32 extraout_var;
        UIPanel.GetViewSize(this,0);
        return extraout_var;
    }

    // Token : 0x6000884
    // RVA   : 0x215A90   Offset: 0x214290   Length: 0x3
    public bool get_halfPixelOffset()
    {
        return false;
    }

    // Token : 0x6000885
    // RVA   : 0x1576B10   Offset: 0x1575310   Length: 0x92
    public bool get_usedForUI()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = UIRect.get_anchorCamera(this,0);
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          return;
        }
        if (*(int64 *)(this + 128) != 0) {
          Camera.get_orthographic(*(int64 *)(this + 128),0);
          return;
        }
    }

    // Token : 0x6000886
    // RVA   : 0x1576140   Offset: 0x1574940   Length: 0x292
    public Vector3 get_drawCallOffset()
    {
        bool cVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar5;
        long lVar6;
        float fVar8;
        float fVar9;
        float local_res8;
        float fStackX_c;
        uint8 local_48 [64];
        uVar5 = UIRect.get_anchorCamera(param_2,0);
        cVar1 = Object.op_Inequality(uVar5,0,0);
        if (!cVar1) {
        LAB_18157638d:
          puVar7 = (uint64 *)Vector3.get_zero(local_48,0);
          fVar8 = *(float *)(puVar7 + 1);
          *(uint64 *)this = *puVar7;
          this[2] = fVar8;
          return this;
        }
        if (*(int64 *)(param_2 + 128) != 0) {
          cVar1 = Camera.get_orthographic(*(int64 *)(param_2 + 128),0);
          if (!cVar1) goto LAB_18157638d;
          lVar6 = UIRect.get_root(param_2,0);
          uVar5 = NGUITools.get_screenSize(0);
          cVar1 = Object.op_Inequality(lVar6,0,0);
          local_res8 = (float)uVar5;
          fStackX_c = (float)((uint64)uVar5 >> 32);
          if (cVar1) {
            uVar2 = Mathf.RoundToInt(fStackX_c,0);
            if (lVar6 == null) throw; // [null/range check failed]
            fVar8 = (float)UIRoot.GetPixelSizeAdjustment(lVar6,uVar2,0);
            local_res8 = local_res8 * fVar8;
            fStackX_c = fStackX_c * fVar8;
          }
          uVar5 = UIRect.get_root(param_2,0);
          cVar1 = Object.op_Inequality(uVar5,0,0);
          if (!cVar1) {
            fVar8 = 1.0;
          }
          else {
            lVar6 = UIRect.get_root(param_2,0);
            if (lVar6 == null) throw; // [null/range check failed]
            fVar8 = (float)UIRoot.get_pixelSizeAdjustment(lVar6,0);
          }
          if (*(int64 *)(param_2 + 128) != 0) {
            fVar9 = (float)Camera.get_orthographicSize(*(int64 *)(param_2 + 128),0);
            fVar9 = (fVar8 / fStackX_c) / fVar9;
            uVar3 = Mathf.RoundToInt(local_res8,0);
            uVar4 = Mathf.RoundToInt(fStackX_c,0);
            if ((uVar3 & 1) == 0) {
              fVar8 = 0.0;
            }
            else {
              fVar8 = -fVar9;
            }
            if ((uVar4 & 1) == 0) {
              fVar9 = 0.0;
            }
            *this = fVar8;
            this[1] = fVar9;
            this[2] = 0.0;
            return this;
          }
        }
    }

    // Token : 0x6000887
    // RVA   : 0x12034A0   Offset: 0x1201CA0   Length: 0x7
    public Clipping get_clipping()
    {
        uint32 FUN_1812034a0(int64 this)
        {
        return this.mClipping;
    }

    // Token : 0x6000888
    // RVA   : 0x1577700   Offset: 0x1575F00   Length: 0x20
    public void set_clipping(Clipping value)
    {
        if (this.mClipping != value) {
          this.mResized = 1;
          this.mClipping = value;
          this.mMatrixFrame = 0xffffffff;
        }
    }

    // Token : 0x6000889
    // RVA   : 0xF02010   Offset: 0xF00810   Length: 0x8
    public UIPanel get_parentPanel()
    {
        uint64 FUN_180f02010(int64 this)
        {
        return *(uint64 *)(this + 400);
    }

    // Token : 0x600088A
    // RVA   : 0x1576040   Offset: 0x1574840   Length: 0x90
    public int get_clipCount()
    {
        bool cVar1;
        int iVar2;
        iVar2 = 0;
        while( true ) {
          cVar1 = Object.op_Inequality(this,0,0);
          if (!cVar1) break;
          if (this == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((this.mClipping - 1U & 0xfffffffd) == 0) {
            iVar2 = iVar2 + 1;
          }
          this = *(int64 *)(this + 400);
        }
        return iVar2;
    }

    // Token : 0x600088B
    // RVA   : 0x15765A0   Offset: 0x1574DA0   Length: 0x15
    public bool get_hasClipping()
    {
        int iVar1;
        iVar1 = this.mClipping;
        if (iVar1 == 3) {
          return true;
        }
        return CONCAT31((int3)((uint32)iVar1 >> 8),iVar1 == 1);
    }

    // Token : 0x600088C
    // RVA   : 0x15765C0   Offset: 0x1574DC0   Length: 0x93
    public bool get_hasCumulativeClipping()
    {
        bool cVar1;
        int iVar2;
        iVar2 = 0;
        while( true ) {
          cVar1 = Object.op_Inequality(this,0,0);
          if (!cVar1) break;
          if (this == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((this.mClipping - 1U & 0xfffffffd) == 0) {
            iVar2 = iVar2 + 1;
          }
          this = *(int64 *)(this + 400);
        }
        return iVar2 != 0;
    }

    // Token : 0x600088D
    // RVA   : 0x1576120   Offset: 0x1574920   Length: 0x7
    public bool get_clipsChildren()
    {
        void FUN_181576120(uint64 this)
        {
        UIPanel.get_hasCumulativeClipping(this,0);
    }

    // Token : 0x600088E
    // RVA   : 0x15760E0   Offset: 0x15748E0   Length: 0x19
    public Vector2 get_clipOffset()
    {
        uint64 FUN_1815760e0(int64 this)
        {
        return this.mClipOffset;
    }

    // Token : 0x600088F
    // RVA   : 0x1577580   Offset: 0x1575D80   Length: 0x7F
    public void set_clipOffset(Vector2 value)
    {
        float fVar1;
        uint32 uStackX_c;
        fVar1 = ABS(this.mClipOffset - (float)value);
        if ((0.001 < fVar1) ||
           (uStackX_c = (float)((uint64)value >> 32),
           fVar1 = ABS(*(float *)(this + 0x168) - uStackX_c), 0.001 < fVar1)) {
          this.mClipOffset = value;
          UIPanel.InvalidateClipping(fVar1,0);
          if (this.onClipMove != null) {
            OnClickCB.Invoke(this.onClipMove,this,0);
            return;
          }
        }
    }

    // Token : 0x6000890
    // RVA   : 0x15727C0   Offset: 0x1570FC0   Length: 0x19D
    private void InvalidateClipping()
    {
        var pStatics = *(int64*)(DAT_181d8ac58 + 184);
        int iVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        int iVar5;
        this.mResized = 1;
        iVar5 = 0;
        this.mMatrixFrame = 0xffffffff;
        if (*pStatics == 0) {
        LAB_181572958:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar1 = *(int *)(*pStatics + 24);
        if (0 < iVar1) {
          do {
            if (*pStatics == 0) goto LAB_181572958;
            lVar4 = FUN_180002f80(*pStatics,iVar5,DAT_181d82978);
            cVar3 = Object.op_Inequality(lVar4,this,0);
            if (cVar3) {
              if (lVar4 == null) goto LAB_181572958;
              uVar2 = *(uint64 *)(lVar4 + 400);
              cVar3 = Object.op_Equality(uVar2,this,0);
              if (cVar3) {
                UIPanel.InvalidateClipping(lVar4,0);
              }
            }
            iVar5 = iVar5 + 1;
          } while (iVar5 < iVar1);
        }
    }

    // Token : 0x6000891
    // RVA   : 0xD67B90   Offset: 0xD66390   Length: 0x8
    public Texture2D get_clipTexture()
    {
        uint64 FUN_180d67b90(int64 this)
        {
        return this.mClipTexture;
    }

    // Token : 0x6000892
    // RVA   : 0x1577670   Offset: 0x1575E70   Length: 0x8E
    public void set_clipTexture(Texture2D value)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mClipTexture;
        cVar2 = Object.op_Inequality(uVar1,value,0);
        if (cVar2) {
          this.mClipTexture = value;
        }
    }

    // Token : 0x6000893
    // RVA   : 0x1576020   Offset: 0x1574820   Length: 0xE
    public Vector4 get_clipRange()
    {
        uint64 * FUN_181576020(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x140);
        *this = *(uint64 *)(param_2 + 0x138);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x6000894
    // RVA   : 0x1577600   Offset: 0x1575E00   Length: 0x1E
    public void set_clipRange(Vector4 value)
    {
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_18 = *value;
        uStack_14 = value[1];
        uStack_10 = value[2];
        uStack_c = value[3];
        UIPanel.set_baseClipRegion(local_18,&local_18,0);
    }

    // Token : 0x6000895
    // RVA   : 0x1576020   Offset: 0x1574820   Length: 0xE
    public Vector4 get_baseClipRegion()
    {
        uint64 * FUN_181576020(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x140);
        *this = *(uint64 *)(param_2 + 0x138);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x6000896
    // RVA   : 0x1577440   Offset: 0x1575C40   Length: 0x131
    public void set_baseClipRegion(Vector4 value)
    {
        long lVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        bool cVar6;
        if ((((0.001 < ABS(this.mClipRange - *value)) ||
             (0.001 < ABS(*(float *)(this + 0x13c) - value[1]))) ||
            (0.001 < ABS(*(float *)(this + 0x140) - value[2]))) ||
           (0.001 < ABS(*(float *)(this + 0x144) - value[3]))) {
          fVar2 = *value;
          fVar3 = value[1];
          fVar4 = value[2];
          fVar5 = value[3];
          this.mResized = 1;
          this.mMatrixFrame = 0xffffffff;
          this.mClipRange = fVar2;
          *(float *)(this + 0x13c) = fVar3;
          *(float *)(this + 0x140) = fVar4;
          *(float *)(this + 0x144) = fVar5;
          lVar1 = Component.GetComponent(this,DAT_181d6e540);
          cVar6 = Object.op_Inequality(lVar1,0,0);
          if (cVar6) {
            if (lVar1 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            UIScrollView.UpdatePosition(lVar1,0);
          }
          if (this.onClipMove != null) {
            OnClickCB.Invoke(this.onClipMove,this,0);
          }
        }
    }

    // Token : 0x6000897
    // RVA   : 0x15763E0   Offset: 0x1574BE0   Length: 0x1BD
    public Vector4 get_finalClipRegion()
    {
        float fVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        float local_res8;
        float fStackX_c;
        uint64 local_58;
        uint32 local_50;
        uint64 local_48;
        uint64 uStack_40;
        uint64 local_38;
        uint64 uStack_30;
        local_38 = 0;
        uStack_30 = 0;
        uVar2 = UIPanel.GetViewSize(param_2,0);
        local_res8 = (float)uVar2;
        fStackX_c = (float)((uint64)uVar2 >> 32);
        if (*(int *)(param_2 + 0x134) != 0) {
          local_48 = 0;
          uStack_40 = 0;
          FUN_1809981e0(&local_48,*(float *)(param_2 + 0x164) + *(float *)(param_2 + 0x138),
                        *(float *)(param_2 + 0x168) + *(float *)(param_2 + 0x13c),local_res8,fStackX_c,0);
          *(uint64 *)this = local_48;
          *(uint64 *)(this + 2) = uStack_40;
          return this;
        }
        FUN_1809981e0(&local_38,0,0,local_res8,fStackX_c,0);
        lVar3 = UIRect.get_anchorCamera(param_2,0);
        lVar4 = UIRect.get_cachedTransform(param_2,0);
        if (lVar4 != null) {
          puVar5 = (uint64 *)Transform.get_position(&local_48,lVar4,0);
          if (lVar3 != null) {
            local_58 = *puVar5;
            local_50 = *(uint32 *)(puVar5 + 1);
            puVar5 = (uint64 *)Camera.WorldToScreenPoint(&local_48,lVar3,&local_58,0);
            fVar1 = *(float *)((int64)puVar5 + 4);
            *this = (float)local_38 - ((float)*puVar5 - local_res8 * 0.5);
            this[1] = local_38._4_4_ - (fVar1 - fStackX_c * 0.5);
            this[2] = (float)uStack_30;
            this[3] = uStack_30._4_4_;
            return this;
          }
        }
    }

    // Token : 0x6000898
    // RVA   : 0x1576100   Offset: 0x1574900   Length: 0x19
    public Vector2 get_clipSoftness()
    {
        uint64 FUN_181576100(int64 this)
        {
        return this.mClipSoftness;
    }

    // Token : 0x6000899
    // RVA   : 0x1577620   Offset: 0x1575E20   Length: 0x46
    public void set_clipSoftness(Vector2 value)
    {
        void FUN_181577620(int64 this,uint64 value)
        {
        float fVar1;
        float fVar2;
        fVar1 = this.mClipSoftness - (float)value;
        fVar2 = *(float *)(this + 0x14c) - (float)((uint64)value >> 32);
        if (9.9999994e-11 <= fVar2 * fVar2 + fVar1 * fVar1) {
          this.mClipSoftness = value;
        }
    }

    // Token : 0x600089A
    // RVA   : 0x1576680   Offset: 0x1574E80   Length: 0x349
    public override Vector3[] get_localCorners()
    {
        var pStatics = *(int64*)(DAT_181d8ac58 + 184);
        long lVar1;
        long lVar2;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        ulong local_68;
        uint local_60;
        byte[] local_58 = new byte[80];
        if (*(int *)((int64)this + 0x134) == 0) {
          lVar1 = (**(code **)(*this + 0x1e8))(this,*(uint64 *)(*this + 0x1f0));
          lVar2 = UIRect.get_cachedTransform(this,0);
          uVar6 = 0;
          while (lVar1 != null) {
            lVar5 = (int64)(int)uVar6;
            if (*(uint32 *)(lVar1 + 24) <= uVar6) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (lVar2 == null) break;
            local_68 = *(uint64 *)(lVar1 + 32 + lVar5 * 12);
            local_60 = *(uint32 *)(lVar1 + 40 + lVar5 * 12);
            puVar3 = (uint64 *)Transform.InverseTransformPoint(local_58,lVar2,&local_68,0);
            if (*(uint32 *)(lVar1 + 24) <= uVar6) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            uVar6 = uVar6 + 1;
            *(uint64 *)(lVar1 + 32 + lVar5 * 12) = *puVar3;
            *(uint32 *)(lVar1 + 40 + lVar5 * 12) = *(uint32 *)(puVar3 + 1);
            if (3 < (int)uVar6) {
              return lVar1;
            }
          }
        }
        else {
          fVar7 = (*(float *)((int64)this + 0x164) + *(float *)(this + 39)) -
                  *(float *)(this + 40) * 0.5;
          fVar8 = (*(float *)(this + 45) + *(float *)((int64)this + 0x13c)) -
                  *(float *)((int64)this + 0x144) * 0.5;
          fVar9 = *(float *)(this + 40) + fVar7;
          fVar10 = *(float *)((int64)this + 0x144) + fVar8;
          local_68 = CONCAT44(fVar8,fVar7);
          local_60 = 0;
          lVar1 = *(int64 *)(pStatics + 16);
          if (lVar1 != null) {
            if (*(int *)(lVar1 + 24) == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            *(uint64 *)(lVar1 + 32) = local_68;
            *(uint32 *)(lVar1 + 40) = 0;
            local_68 = CONCAT44(fVar10,fVar7);
            local_60 = 0;
            lVar1 = *(int64 *)(pStatics + 16);
            if (lVar1 != null) {
              if (*(uint32 *)(lVar1 + 24) < 2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              *(uint64 *)(lVar1 + 44) = local_68;
              *(uint32 *)(lVar1 + 52) = 0;
              local_68 = CONCAT44(fVar10,fVar9);
              local_60 = 0;
              lVar1 = *(int64 *)(pStatics + 16);
              if (lVar1 != null) {
                if (*(uint32 *)(lVar1 + 24) < 3) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                *(uint64 *)(lVar1 + 56) = local_68;
                *(uint32 *)(lVar1 + 64) = 0;
                local_68 = CONCAT44(fVar8,fVar9);
                local_60 = 0;
                lVar1 = *(int64 *)(pStatics + 16);
                if (lVar1 != null) {
                  if (3 < *(uint32 *)(lVar1 + 24)) {
                    *(uint64 *)(lVar1 + 68) = local_68;
                    *(uint32 *)(lVar1 + 76) = 0;
                    return *(int64 *)(pStatics + 16);
                  }
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
              }
            }
          }
        }
    }

    // Token : 0x600089B
    // RVA   : 0x1576BD0   Offset: 0x15753D0   Length: 0x6FC
    public override Vector3[] get_worldCorners()
    {
        var pStatics = *(int64*)(DAT_181d8ac58 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        long lVar6;
        uint uVar7;
        uint uVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float local_res8;
        float fStackX_c;
        uint64 local_78;
        uint8 local_68 [96];
        if (this.mClipping == null) {
          uVar2 = UIRect.get_anchorCamera();
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            uVar2 = *(uint64 *)(this + 128);
            uVar8 = UIRect.get_cameraRayDistance(this,0);
            uVar2 = NGUITools.GetWorldCorners(uVar2,uVar8,0);
            return uVar2;
          }
          uVar2 = UIPanel.GetViewSize();
          local_res8 = (float)uVar2;
          fStackX_c = (float)((uint64)uVar2 >> 32);
          fVar9 = local_res8 * -0.5;
          fVar10 = fStackX_c * -0.5;
          local_78 = CONCAT44(fVar10,fVar9);
          lVar3 = *(int64 *)(pStatics + 16);
          if (lVar3 != null) {
            if (*(int *)(lVar3 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar3 + 32) = local_78;
            *(uint32 *)(lVar3 + 40) = 0;
            local_78 = CONCAT44(fStackX_c + fVar10,fVar9);
            lVar3 = *(int64 *)(pStatics + 16);
            if (lVar3 != null) {
              if (*(uint32 *)(lVar3 + 24) < 2) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar3 + 44) = local_78;
              *(uint32 *)(lVar3 + 52) = 0;
              local_78 = CONCAT44(fStackX_c + fVar10,local_res8 + fVar9);
              lVar3 = *(int64 *)(pStatics + 16);
              if (lVar3 != null) {
                if (*(uint32 *)(lVar3 + 24) < 3) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                *(uint64 *)(lVar3 + 56) = local_78;
                *(uint32 *)(lVar3 + 64) = 0;
                local_78 = CONCAT44(fVar10,local_res8 + fVar9);
                lVar3 = *(int64 *)(pStatics + 16);
                if (lVar3 != null) {
                  if (*(uint32 *)(lVar3 + 24) < 4) {
                    uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar2,0);
                  }
                  *(uint64 *)(lVar3 + 68) = local_78;
                  *(uint32 *)(lVar3 + 76) = 0;
                  if (this.anchorOffset) {
                    uVar2 = *(uint64 *)(this + 128);
                    cVar1 = Object.op_Equality(uVar2,0,0);
                    if (!cVar1) {
                      if ((*(int64 *)(this + 128) == 0) ||
                         (lVar3 = Component.get_transform(*(int64 *)(this + 128),0)) == null)
                      throw; // [null/range check failed]
                      uVar2 = FUN_180da0f00(lVar3,0);
                      uVar4 = UIRect.get_cachedTransform(this,0);
                      cVar1 = Object.op_Inequality(uVar2,uVar4,0);
                      if (!cVar1) goto LAB_1815771ff;
                    }
                    lVar3 = UIRect.get_cachedTransform(this,0);
                    if (lVar3 == null) throw; // [null/range check failed]
                    puVar5 = (uint64 *)Transform.get_position(local_68,lVar3,0);
                    uVar7 = 0;
                    fVar9 = *(float *)(puVar5 + 1);
                    local_78._4_4_ = (float)((uint64)*puVar5 >> 32);
                    local_78._0_4_ = (float)*puVar5;
                    do {
                      lVar3 = *(int64 *)(pStatics + 16);
                      if (lVar3 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                        uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar2,0);
                      }
                      lVar6 = (int64)(int)uVar7;
                      uVar2 = *(uint64 *)(lVar3 + 32 + lVar6 * 12);
                      uVar7 = uVar7 + 1;
                      *(float *)(lVar3 + 32 + lVar6 * 12) = (float)local_78 + (float)uVar2;
                      *(float *)(lVar3 + 36 + lVar6 * 12) =
                           local_78._4_4_ + (float)((uint64)uVar2 >> 32);
                      *(float *)(lVar3 + 40 + lVar6 * 12) =
                           fVar9 + *(float *)(lVar3 + 40 + lVar6 * 12);
                    } while ((int)uVar7 < 4);
                  }
        LAB_1815771ff:
                  return *(uint64 *)(pStatics + 16);
                }
              }
            }
          }
        }
        else {
          fVar9 = (this.mClipOffset + this.mClipRange) -
                  *(float *)(this + 0x140) * 0.5;
          fVar10 = (*(float *)(this + 0x168) + *(float *)(this + 0x13c)) -
                   *(float *)(this + 0x144) * 0.5;
          fVar12 = *(float *)(this + 0x140) + fVar9;
          fVar11 = *(float *)(this + 0x144) + fVar10;
          lVar3 = UIRect.get_cachedTransform(this);
          lVar6 = *(int64 *)(pStatics + 16);
          if ((lVar3 != null) &&
             (puVar5 = (uint64 *)Transform.TransformPoint(local_68,lVar3,fVar9,fVar10,0,0),
             lVar6 != null)) {
            if (*(int *)(lVar6 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar6 + 32) = *puVar5;
            *(uint32 *)(lVar6 + 40) = *(uint32 *)(puVar5 + 1);
            lVar6 = *(int64 *)(pStatics + 16);
            puVar5 = (uint64 *)Transform.TransformPoint(local_68,lVar3,fVar9,fVar11,0,0);
            if (lVar6 != null) {
              if (*(uint32 *)(lVar6 + 24) < 2) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar6 + 44) = *puVar5;
              *(uint32 *)(lVar6 + 52) = *(uint32 *)(puVar5 + 1);
              lVar6 = *(int64 *)(pStatics + 16);
              puVar5 = (uint64 *)Transform.TransformPoint(local_68,lVar3,fVar12,fVar11,0,0);
              if (lVar6 != null) {
                if (*(uint32 *)(lVar6 + 24) < 3) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                *(uint64 *)(lVar6 + 56) = *puVar5;
                *(uint32 *)(lVar6 + 64) = *(uint32 *)(puVar5 + 1);
                lVar6 = *(int64 *)(pStatics + 16);
                puVar5 = (uint64 *)Transform.TransformPoint(local_68,lVar3,fVar12,fVar10,0,0);
                if (lVar6 != null) {
                  if (*(uint32 *)(lVar6 + 24) < 4) {
                    uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar2,0);
                  }
                  *(uint64 *)(lVar6 + 68) = *puVar5;
                  *(uint32 *)(lVar6 + 76) = *(uint32 *)(puVar5 + 1);
                  goto LAB_1815771ff;
                }
              }
            }
          }
        }
    }

    // Token : 0x600089C
    // RVA   : 0x1571FB0   Offset: 0x15707B0   Length: 0x67A
    public override Vector3[] GetSides(Transform relativeTo)
    {
        var pStatics = *(int64*)(DAT_181d8aed8 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        ulong local_98;
        float local_90;
        ulong local_88;
        float local_80;
        if (this.mClipping == null) {
          uVar2 = UIRect.get_anchorCamera();
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if ((!cVar1) || (!this.anchorOffset)) {
            lVar3 = UIRect.GetSides(this,relativeTo,0);
          }
          else {
            uVar2 = *(uint64 *)(this + 128);
            uVar8 = UIRect.get_cameraRayDistance(this,0);
            lVar3 = NGUITools.GetSides(uVar2,uVar8,0);
            lVar4 = UIRect.get_cachedTransform(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_position(&local_88,lVar4,0);
            uVar7 = 0;
            uVar2 = *puVar5;
            fVar9 = *(float *)(puVar5 + 1);
            local_98._4_4_ = (float)((uint64)uVar2 >> 32);
            fVar11 = local_98._4_4_;
            local_98._0_4_ = (float)uVar2;
            fVar10 = (float)local_98;
            local_98 = uVar2;
            local_90 = fVar9;
            uVar6 = uVar7;
            do {
              if (lVar3 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar3 + 24) <= uVar6) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              lVar4 = (int64)(int)uVar6;
              local_98 = *(uint64 *)(lVar3 + 32 + lVar4 * 12);
              local_90 = *(float *)(lVar3 + 40 + lVar4 * 12);
              uVar6 = uVar6 + 1;
              *(float *)(lVar3 + 32 + lVar4 * 12) = fVar10 + (float)local_98;
              *(float *)(lVar3 + 36 + lVar4 * 12) = fVar11 + (float)((uint64)local_98 >> 32);
              *(float *)(lVar3 + 40 + lVar4 * 12) = fVar9 + local_90;
              local_88 = local_98;
              local_80 = local_90;
            } while ((int)uVar6 < 4);
            cVar1 = Object.op_Inequality(relativeTo,0,0);
            if (cVar1) {
              do {
                lVar4 = (int64)(int)uVar7;
                if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                if (relativeTo == null) throw; // [null/range check failed]
                local_98 = *(uint64 *)(lVar3 + 32 + lVar4 * 12);
                local_90 = *(float *)(lVar3 + 40 + lVar4 * 12);
                puVar5 = (uint64 *)Transform.InverseTransformPoint(&local_88,relativeTo,&local_98,0);
                if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                uVar7 = uVar7 + 1;
                *(uint64 *)(lVar3 + 32 + lVar4 * 12) = *puVar5;
                *(uint32 *)(lVar3 + 40 + lVar4 * 12) = *(uint32 *)(puVar5 + 1);
              } while ((int)uVar7 < 4);
            }
          }
          return lVar3;
        }
        fVar9 = (this.mClipOffset + this.mClipRange) -
                *(float *)(this + 0x140) * 0.5;
        fVar12 = (*(float *)(this + 0x168) + *(float *)(this + 0x13c)) -
                 *(float *)(this + 0x144) * 0.5;
        fVar14 = *(float *)(this + 0x140) + fVar9;
        fVar13 = *(float *)(this + 0x144) + fVar12;
        fVar11 = (fVar14 + fVar9) * 0.5;
        fVar10 = (fVar13 + fVar12) * 0.5;
        lVar3 = UIRect.get_cachedTransform(this);
        lVar4 = *pStatics;
        if (lVar3 != null) {
          uVar6 = 0;
          puVar5 = (uint64 *)Transform.TransformPoint(&local_88,lVar3,fVar9,fVar10,0,0);
          if (lVar4 != null) {
            if (*(int *)(lVar4 + 24) == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            *(uint64 *)(lVar4 + 32) = *puVar5;
            *(uint32 *)(lVar4 + 40) = *(uint32 *)(puVar5 + 1);
            lVar4 = *pStatics;
            puVar5 = (uint64 *)Transform.TransformPoint(&local_88,lVar3,fVar11,fVar13,0,0);
            if (lVar4 != null) {
              if (*(uint32 *)(lVar4 + 24) < 2) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              *(uint64 *)(lVar4 + 44) = *puVar5;
              *(uint32 *)(lVar4 + 52) = *(uint32 *)(puVar5 + 1);
              lVar4 = *pStatics;
              puVar5 = (uint64 *)Transform.TransformPoint(&local_88,lVar3,fVar14,fVar10,0,0);
              if (lVar4 != null) {
                if (*(uint32 *)(lVar4 + 24) < 3) {
                  uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar2,0);
                }
                *(uint64 *)(lVar4 + 56) = *puVar5;
                *(uint32 *)(lVar4 + 64) = *(uint32 *)(puVar5 + 1);
                lVar4 = *pStatics;
                puVar5 = (uint64 *)Transform.TransformPoint(&local_88,lVar3,fVar11,fVar12,0,0);
                if (lVar4 != null) {
                  if (*(uint32 *)(lVar4 + 24) < 4) {
                    uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar2,0);
                  }
                  *(uint64 *)(lVar4 + 68) = *puVar5;
                  *(uint32 *)(lVar4 + 76) = *(uint32 *)(puVar5 + 1);
                  cVar1 = Object.op_Inequality(relativeTo,0,0);
                  if (cVar1) {
                    do {
                      lVar3 = *pStatics;
                      if (lVar3 == null) throw; // [null/range check failed]
                      lVar4 = (int64)(int)uVar6;
                      if (*(uint32 *)(lVar3 + 24) <= uVar6) {
                        uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar2,0);
                      }
                      if (relativeTo == null) throw; // [null/range check failed]
                      local_98 = *(uint64 *)(lVar3 + 32 + lVar4 * 12);
                      local_90 = *(float *)(lVar3 + 40 + lVar4 * 12);
                      puVar5 = (uint64 *)
                               Transform.InverseTransformPoint(&local_88,relativeTo,&local_98,0);
                      if (*(uint32 *)(lVar3 + 24) <= uVar6) {
                        uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar2,0);
                      }
                      uVar6 = uVar6 + 1;
                      *(uint64 *)(lVar3 + 32 + lVar4 * 12) = *puVar5;
                      *(uint32 *)(lVar3 + 40 + lVar4 * 12) = *(uint32 *)(puVar5 + 1);
                    } while ((int)uVar6 < 4);
                  }
                  return *pStatics;
                }
              }
            }
          }
        }
    }

    // Token : 0x600089D
    // RVA   : 0x1572960   Offset: 0x1571160   Length: 0x9C
    public override void Invalidate(bool includeChildren)
    {
        long lVar1;
        long lVar2;
        ulong uVar4;
        uint uVar5;
        this.mAlphaFrameID = 0xffffffff;
        *(uint8 *)(this + 88) = 1;
        if (!includeChildren) {
          return;
        }
        uVar5 = 0;
        lVar1 = *(int64 *)(this + 80);
        while (lVar1 != null) {
          if (*(int *)(lVar1 + 24) <= (int)uVar5) {
            return;
          }
          if ((lVar1 == null) || (lVar2 = *(int64 *)(lVar1 + 16)) == null) break;
          if (*(uint32 *)(lVar2 + 24) <= uVar5) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar3 = lVar2[uVar5];
          if (plVar3 == (int64 *)0) break;
          (**(code **)(*plVar3 + 0x1f8))
                    (plVar3,CONCAT71((int7)((uint64)lVar1 >> 8),1),*(uint64 *)(*plVar3 + 0x200));
          uVar5 = uVar5 + 1;
          lVar1 = *(int64 *)(this + 80);
        }
    }

    // Token : 0x600089E
    // RVA   : 0x15705F0   Offset: 0x156EDF0   Length: 0xE6
    public override float CalculateFinalAlpha(int frameID)
    {
        bool cVar1;
        ulong uVar3;
        float fVar4;
        if (this.mAlphaFrameID != frameID) {
          this.mAlphaFrameID = frameID;
          plVar2 = (int64 *)UIRect.get_parent(this,0);
          uVar3 = UIRect.get_parent(this,0);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) {
            fVar4 = this.mAlpha;
          }
          else {
            if (plVar2 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar4 = (float)(**(code **)(*plVar2 + 0x1c8))(plVar2,frameID,*(uint64 *)(*plVar2 + 0x1d0))
            ;
            fVar4 = fVar4 * this.mAlpha;
          }
          *(float *)(this + 140) = fVar4;
        }
        return *(uint32 *)(this + 140);
    }

    // Token : 0x600089F
    // RVA   : 0x1574850   Offset: 0x1573050   Length: 0x2F9
    public override void SetRect(float x, float y, float width, float height)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        float fVar5;
        float fVar6;
        byte[] auVar7 = new byte[16];
        byte[] in_XMM3 = new byte[16];
        ulong local_78;
        ulong uStack_70;
        ulong local_68;
        ulong uStack_60;
        auVar7._4_12_ = in_XMM3._4_12_;
        auVar7._0_4_ = in_XMM3._0_4_ + 0.5;
        Mathf.FloorToInt(auVar7._0_8_,0);
        Mathf.FloorToInt(height + 0.5,0);
        lVar3 = UIRect.get_cachedTransform(this,0);
        if (lVar3 != null) {
          Transform.get_localPosition(&local_78,lVar3,0);
          fVar5 = floorf(x + 0.5);
          fVar6 = floorf(y + 0.5);
          local_78 = 0;
          uStack_70 = 0;
          FUN_1809981e0(&local_78,fVar5,fVar6);
          local_68 = local_78;
          uStack_60 = uStack_70;
          UIPanel.set_baseClipRegion(this,&local_68,0);
          cVar2 = UIRect.get_isAnchored(this,0);
          if (!cVar2) {
            return;
          }
          uVar4 = FUN_180da0f00(lVar3,0);
          if (*(int64 *)(this + 24) != 0) {
            uVar1 = *(uint64 *)(*(int64 *)(this + 24) + 16);
            cVar2 = Object.op_Implicit(uVar1,0);
            if (cVar2) {
              if (*(int64 *)(this + 24) == 0) throw; // [null/range check failed]
              AnchorPoint.SetHorizontal(*(int64 *)(this + 24),uVar4,x,0);
            }
            if (*(int64 *)(this + 32) != 0) {
              uVar1 = *(uint64 *)(*(int64 *)(this + 32) + 16);
              cVar2 = Object.op_Implicit(uVar1,0);
              if (cVar2) {
                if (*(int64 *)(this + 32) == 0) throw; // [null/range check failed]
                AnchorPoint.SetHorizontal(*(int64 *)(this + 32),uVar4,x + in_XMM3._0_4_,0);
              }
              if (*(int64 *)(this + 40) != 0) {
                uVar1 = *(uint64 *)(*(int64 *)(this + 40) + 16);
                cVar2 = Object.op_Implicit(uVar1,0);
                if (cVar2) {
                  if (*(int64 *)(this + 40) == 0) throw; // [null/range check failed]
                  AnchorPoint.SetVertical(*(int64 *)(this + 40),uVar4,y,0);
                }
                if (*(int64 *)(this + 48) != 0) {
                  uVar1 = *(uint64 *)(*(int64 *)(this + 48) + 16);
                  cVar2 = Object.op_Implicit(uVar1,0);
                  if (cVar2) {
                    if (*(int64 *)(this + 48) == 0) throw; // [null/range check failed]
                    AnchorPoint.SetVertical(*(int64 *)(this + 48),uVar4,y + height,0);
                  }
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60008A0
    // RVA   : 0x1572CA0   Offset: 0x15714A0   Length: 0x44E
    public bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
    {
        uint uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong local_48;
        uint local_40;
        ulong local_38;
        uint local_30;
        ulong local_28;
        uint local_20;
        ulong local_18;
        uint local_10;
        lVar3 = 0;
        do {
          while( true ) {
            cVar2 = Object.op_Inequality(this,0,0);
            if (!cVar2) {
              return true;
            }
            if (this == 0) goto LAB_181572bcf;
            if ((this.mClipping & 0xfffffffb) == 0) break;
        LAB_181572aa2:
            if ((lVar3 == null) &&
               ((a == (int64 *)0 ||
                (lVar3 = (**(code **)(*a + 0x1e8))(a,*(uint64 *)(*a + 0x1f0)),
                lVar3 == null)))) {
        LAB_181572bcf:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar1 = *(uint32 *)(lVar3 + 24);
            if (uVar1 == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar1 < 2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar1 < 3) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar1 < 4) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            local_40 = *(uint32 *)(lVar3 + 76);
            local_48 = *(uint64 *)(lVar3 + 68);
            local_30 = *(uint32 *)(lVar3 + 64);
            local_38 = *(uint64 *)(lVar3 + 56);
            local_20 = *(uint32 *)(lVar3 + 52);
            local_28 = *(uint64 *)(lVar3 + 44);
            local_10 = *(uint32 *)(lVar3 + 40);
            local_18 = *(uint64 *)(lVar3 + 32);
            cVar2 = UIPanel.IsVisible(this,&local_18,&local_28,&local_38,&local_48,0);
            if (!cVar2) {
              return false;
            }
            this = *(int64 *)(this + 400);
          }
          if (a == (int64 *)0) goto LAB_181572bcf;
          if (*(char *)((int64)a + 209) != false) goto LAB_181572aa2;
          this = *(int64 *)(this + 400);
        } while( true );
    }

    // Token : 0x60008A1
    // RVA   : 0x1572BE0   Offset: 0x15713E0   Length: 0xBA
    public bool IsVisible(Vector3 worldPos)
    {
        uint uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong local_48;
        uint local_40;
        ulong local_38;
        uint local_30;
        ulong local_28;
        uint local_20;
        ulong local_18;
        uint local_10;
        lVar3 = 0;
        do {
          while( true ) {
            cVar2 = Object.op_Inequality(this,0,0);
            if (!cVar2) {
              return true;
            }
            if (this == 0) goto LAB_181572bcf;
            if ((this.mClipping & 0xfffffffb) == 0) break;
        LAB_181572aa2:
            if ((lVar3 == null) &&
               ((worldPos == (int64 *)0 ||
                (lVar3 = (**(code **)(*worldPos + 0x1e8))(worldPos,*(uint64 *)(*worldPos + 0x1f0)),
                lVar3 == null)))) {
        LAB_181572bcf:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar1 = *(uint32 *)(lVar3 + 24);
            if (uVar1 == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar1 < 2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar1 < 3) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar1 < 4) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            local_40 = *(uint32 *)(lVar3 + 76);
            local_48 = *(uint64 *)(lVar3 + 68);
            local_30 = *(uint32 *)(lVar3 + 64);
            local_38 = *(uint64 *)(lVar3 + 56);
            local_20 = *(uint32 *)(lVar3 + 52);
            local_28 = *(uint64 *)(lVar3 + 44);
            local_10 = *(uint32 *)(lVar3 + 40);
            local_18 = *(uint64 *)(lVar3 + 32);
            cVar2 = UIPanel.IsVisible(this,&local_18,&local_28,&local_38,&local_48,0);
            if (!cVar2) {
              return false;
            }
            this = *(int64 *)(this + 400);
          }
          if (worldPos == (int64 *)0) goto LAB_181572bcf;
          if (*(char *)((int64)worldPos + 209) != false) goto LAB_181572aa2;
          this = *(int64 *)(this + 400);
        } while( true );
    }

    // Token : 0x60008A2
    // RVA   : 0x1572A00   Offset: 0x1571200   Length: 0x1D4
    public bool IsVisible(UIWidget w)
    {
        uint uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong local_48;
        uint local_40;
        ulong local_38;
        uint local_30;
        ulong local_28;
        uint local_20;
        ulong local_18;
        uint local_10;
        lVar3 = 0;
        do {
          while( true ) {
            cVar2 = Object.op_Inequality(this,0,0);
            if (!cVar2) {
              return true;
            }
            if (this == 0) goto LAB_181572bcf;
            if ((this.mClipping & 0xfffffffb) == 0) break;
        LAB_181572aa2:
            if ((lVar3 == null) &&
               ((w == (int64 *)0 ||
                (lVar3 = (**(code **)(*w + 0x1e8))(w,*(uint64 *)(*w + 0x1f0)),
                lVar3 == null)))) {
        LAB_181572bcf:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar1 = *(uint32 *)(lVar3 + 24);
            if (uVar1 == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar1 < 2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar1 < 3) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar1 < 4) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            local_40 = *(uint32 *)(lVar3 + 76);
            local_48 = *(uint64 *)(lVar3 + 68);
            local_30 = *(uint32 *)(lVar3 + 64);
            local_38 = *(uint64 *)(lVar3 + 56);
            local_20 = *(uint32 *)(lVar3 + 52);
            local_28 = *(uint64 *)(lVar3 + 44);
            local_10 = *(uint32 *)(lVar3 + 40);
            local_18 = *(uint64 *)(lVar3 + 32);
            cVar2 = UIPanel.IsVisible(this,&local_18,&local_28,&local_38,&local_48,0);
            if (!cVar2) {
              return false;
            }
            this = *(int64 *)(this + 400);
          }
          if (w == (int64 *)0) goto LAB_181572bcf;
          if (*(char *)((int64)w + 209) != false) goto LAB_181572aa2;
          this = *(int64 *)(this + 400);
        } while( true );
    }

    // Token : 0x60008A3
    // RVA   : 0x1570280   Offset: 0x156EA80   Length: 0x14A
    public bool Affects(UIWidget w)
    {
        ulong uVar1;
        bool cVar2;
        cVar2 = Object.op_Equality(w,0,0);
        if (!cVar2) {
          if (w == null) {
        LAB_1815703c5:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = *(uint64 *)(w + 232);
          cVar2 = Object.op_Equality(uVar1,0,0);
          if (!cVar2) {
            while( true ) {
              cVar2 = Object.op_Inequality(this,0,0);
              if (!cVar2) break;
              cVar2 = Object.op_Equality(this);
              if (cVar2) {
                return true;
              }
              if (this == 0) goto LAB_1815703c5;
              cVar2 = UIPanel.get_hasCumulativeClipping(this);
              if (!cVar2) {
                return false;
              }
              this = *(int64 *)(this + 400);
            }
          }
        }
        return false;
    }

    // Token : 0x60008A4
    // RVA   : 0x1574540   Offset: 0x1572D40   Length: 0x8
    public void RebuildAllDrawCalls()
    {
        this.mRebuild = 1;
    }

    // Token : 0x60008A5
    // RVA   : 0x1574770   Offset: 0x1572F70   Length: 0xD4
    public void SetDirty()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        uVar3 = 0;
        if (this[23] != 0) {
          lVar2 = (int64)*(int *)(this[23] + 24);
          if (0 < lVar2) {
            lVar5 = 32;
            uVar4 = uVar3;
            do {
              lVar1 = this[23];
              if (lVar1 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar1 + 24) <= (uint32)uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = *(int64 *)(lVar5 + *(int64 *)(lVar1 + 16));
              if (lVar1 == null) throw; // [null/range check failed]
              uVar4 = (uint64)((uint32)uVar4 + 1);
              *(uint8 *)(lVar1 + 216) = 1;
              uVar3 = uVar3 + 1;
              lVar5 = lVar5 + 8;
            } while ((int64)uVar3 < lVar2);
          }
                          // WARNING: Could not recover jumptable at 0x000181574838. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x1f8))(this,1,*(uint64 *)(*this + 0x200));
          return;
        }
    }

    // Token : 0x60008A6
    // RVA   : 0x15703D0   Offset: 0x156EBD0   Length: 0xA1
    protected override void Awake()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        ZhSegment.Initialize(uVar1,0);
        *(uint8 *)(this + 136) = 0;
        uVar1 = Component.get_gameObject(this,0);
        *(uint64 *)(this + 64) = uVar1;
        uVar1 = Component.get_transform(this,0);
        *(uint64 *)(this + 72) = uVar1;
    }

    // Token : 0x60008A7
    // RVA   : 0x1571B80   Offset: 0x1570380   Length: 0xFA
    private void FindParent()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = UIRect.get_cachedTransform(this,0);
        if (lVar2 != null) {
          lVar2 = FUN_180da0f00(lVar2,0);
          cVar1 = Object.op_Inequality(lVar2,0,0);
          if (!cVar1) {
            uVar3 = 0;
          }
          else {
            if (lVar2 == null) throw; // [null/range check failed]
            uVar3 = Component.get_gameObject(lVar2,0);
            uVar3 = NGUITools.FindInParents(uVar3,DAT_181d66900);
          }
          if (this != 0) {
            *(uint64 *)(this + 400) = uVar3;
            return;
          }
        }
    }

    // Token : 0x60008A8
    // RVA   : 0x1574520   Offset: 0x1572D20   Length: 0x1F
    public override void ParentHasChanged()
    {
        UIRect.ParentHasChanged(this,0);
        UIPanel.FindParent(this,0);
    }

    // Token : 0x60008A9
    // RVA   : 0x15744E0   Offset: 0x1572CE0   Length: 0x30
    protected override void OnStart()
    {
        uint uVar1;
        long lVar2;
        lVar2 = UIRect.get_cachedGameObject(this,0);
        if (lVar2 != null) {
          uVar1 = GameObject.get_layer(lVar2,0);
          this.mLayer = uVar1;
          return;
        }
    }

    // Token : 0x60008AA
    // RVA   : 0x15740A0   Offset: 0x15728A0   Length: 0x73
    protected override void OnEnable()
    {
        *(uint8 *)(this + 44) = 1;
        *(uint64 *)((int64)this + 0x16c) = 0xffffffffffffffff;
        (**(code **)(*this + 0x288))(this,*(uint64 *)(*this + 0x290));
        *(uint32 *)((int64)this + 92) = 0xffffffff;
        if ((int)this[7] == 0) {
          *(uint8 *)(this + 12) = 0;
          *(uint8 *)((int64)this + 90) = 1;
        }
        if ((char)this[17] != false) {
          (**(code **)(*this + 0x228))(this,*(uint64 *)(*this + 0x230));
        }
        *(uint32 *)((int64)this + 0x16c) = 0xffffffff;
        *(uint32 *)((int64)this + 92) = 0xffffffff;
    }

    // Token : 0x60008AB
    // RVA   : 0x1574120   Offset: 0x1572920   Length: 0x3B3
    protected override void OnInit()
    {
        var pStatics = *(int64*)(DAT_181d8ac58 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        if (*pStatics == 0) throw; // [null/range check failed]
        cVar1 = FUN_1818279a0(*pStatics,this,DAT_181d826f8);
        if (cVar1) {
          return;
        }
        *(uint16 *)(this + 88) = 1;
        *(uint8 *)(this + 120) = 0;
        uVar2 = UIRect.get_parent(this,0);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if ((*(int64 *)(this + 112) == 0) ||
             (lVar3 = *(int64 *)(*(int64 *)(this + 112) + 80)) == null)
          throw; // [null/range check failed]
          FUN_18154cb60(lVar3,this,DAT_181d81c18);
        }
        UIPanel.FindParent(this,0);
        uVar2 = Component.GetComponent(this,DAT_181d6c840);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = *(uint64 *)(this + 400);
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (cVar1) {
            uVar2 = UIRect.get_anchorCamera(this,0);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (!cVar1) {
              lVar3 = 0;
            }
            else {
              if (*(int64 *)(this + 128) == 0) throw; // [null/range check failed]
              lVar3 = Component.GetComponent(*(int64 *)(this + 128),DAT_181d6dfc0);
            }
            cVar1 = Object.op_Inequality(lVar3,0,0);
            if (cVar1) {
              if (lVar3 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar3 + 24) < 2) {
                lVar3 = Component.get_gameObject(this,0);
                if ((lVar3 == null) || (lVar3 = GameObject.AddComponent(lVar3,DAT_181d9cd70)) == null)
                throw; // [null/range check failed]
                Rigidbody.set_isKinematic(lVar3,1,0);
                Rigidbody.set_useGravity(lVar3,0,0);
              }
            }
          }
        }
        this.mRebuild = 1;
        this.mMatrixFrame = 0xffffffffffffffff;
        if (*pStatics != 0) {
          FUN_181827900(*pStatics,this,DAT_181d82678);
          lVar3 = *pStatics;
          uVar2 = new OnTooltipCB(0,DAT_181d9cc90,DAT_181d86518);
          if (lVar3 != null) {
            List_1.Sort(lVar3,uVar2,DAT_181d82878);
            return;
          }
        }
    }

    // Token : 0x60008AC
    // RVA   : 0x1573DA0   Offset: 0x15725A0   Length: 0x2FF
    protected override void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181d8ac58 + 184);
        int iVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        lVar6 = this.drawCalls;
        uVar5 = 0;
        if (lVar6 != null) {
          iVar1 = lVar6.Count;
          if (0 < (int64)iVar1) {
            lVar6 = 0;
            lVar7 = 32;
            do {
              lVar2 = this.drawCalls;
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.Count <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar3 = *(uint64 *)(lVar7 + lVar2._items);
              cVar4 = Object.op_Inequality(uVar3,0,0);
              if (cVar4) {
                UIDrawCall.Destroy();
              }
              uVar5 = uVar5 + 1;
              lVar6 = lVar6 + 1;
              lVar7 = lVar7 + 8;
            } while (lVar6 < iVar1);
            lVar6 = this.drawCalls;
            if (lVar6 == null) throw; // [null/range check failed]
          }
          FUN_180f56130(lVar6,DAT_181d81df8);
          if (*pStatics != 0) {
            FUN_181801c10(*pStatics,this,DAT_181d827f8);
            this.mMatrixFrame = 0xffffffffffffffff;
            if (*pStatics != 0) {
              if (*(int *)(*pStatics + 24) == 0) {
                UIDrawCall.ReleaseAll(0);
                *(uint32 *)(pStatics + 24) = 0xffffffff;
              }
              uVar3 = *(uint64 *)(this + 112);
              cVar4 = Object.op_Implicit(uVar3,0);
              if (cVar4) {
                if ((*(int64 *)(this + 112) == 0) ||
                   (lVar6 = *(int64 *)(*(int64 *)(this + 112) + 80)) == null)
                throw; // [null/range check failed]
                FUN_18154eb70(lVar6,this,DAT_181d81c98);
              }
              *(uint64 *)(this + 112) = 0;
              *(uint64 *)(this + 104) = 0;
              *(uint8 *)(this + 120) = 0;
              *(uint8 *)(this + 89) = 0;
              return;
            }
          }
        }
    }

    // Token : 0x60008AD
    // RVA   : 0x1575640   Offset: 0x1573E40   Length: 0x105
    private void UpdateTransformMatrix()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        int iVar4;
        long lVar5;
        ulong uVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        byte[] local_48 = new byte[64];
        iVar4 = Time.get_frameCount(0);
        if ((this.mHasMoved) || (this.mMatrixFrame != iVar4)) {
          this.mMatrixFrame = iVar4;
          lVar5 = UIRect.get_cachedTransform(this,0);
          if (lVar5 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar6 = (uint64 *)Transform.get_worldToLocalMatrix(local_48,lVar5,0);
          uVar7 = puVar6[1];
          this.worldToLocal = *puVar6;
          *(uint64 *)(this + 200) = uVar7;
          uVar7 = puVar6[3];
          *(uint64 *)(this + 208) = puVar6[2];
          *(uint64 *)(this + 216) = uVar7;
          uVar1 = *(uint32 *)((int64)puVar6 + 36);
          uVar2 = *(uint32 *)(puVar6 + 5);
          uVar3 = *(uint32 *)((int64)puVar6 + 44);
          *(uint32 *)(this + 224) = *(uint32 *)(puVar6 + 4);
          *(uint32 *)(this + 228) = uVar1;
          *(uint32 *)(this + 232) = uVar2;
          *(uint32 *)(this + 236) = uVar3;
          uVar1 = *(uint32 *)((int64)puVar6 + 52);
          uVar2 = *(uint32 *)(puVar6 + 7);
          uVar3 = *(uint32 *)((int64)puVar6 + 60);
          *(uint32 *)(this + 240) = *(uint32 *)(puVar6 + 6);
          *(uint32 *)(this + 244) = uVar1;
          *(uint32 *)(this + 248) = uVar2;
          *(uint32 *)(this + 252) = uVar3;
          uVar7 = UIPanel.GetViewSize(this,0);
          fVar11 = (float)uVar7 * 0.5;
          fVar10 = (float)((uint64)uVar7 >> 32) * 0.5;
          fVar8 = this.mClipOffset + this.mClipRange;
          fVar9 = *(float *)(this + 0x168) + *(float *)(this + 0x13c);
          this.mMin = fVar8 - fVar11;
          *(float *)(this + 0x17c) = fVar9 - fVar10;
          this.mMax = fVar11 + fVar8;
          *(float *)(this + 0x184) = fVar10 + fVar9;
        }
    }

    // Token : 0x60008AE
    // RVA   : 0x1573390   Offset: 0x1571B90   Length: 0xA0C
    protected override void OnAnchor()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar8;
        uint uVar9;
        float fVar10;
        uint uVar11;
        uint uVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        float local_res8;
        float fStackX_c;
        uint64 in_stack_ffffffffffffff08;
        uint32 uVar17;
        float local_e8;
        uint64 local_d8;
        uint64 local_c8;
        uint64 local_b8;
        uint32 uStack_b0;
        uint32 uStack_ac;
        uint64 local_a8;
        uint64 uStack_a0;
        uVar17 = (uint32)((uint64)in_stack_ffffffffffffff08 >> 32);
        if (this.mClipping == null) {
          return;
        }
        lVar3 = UIRect.get_cachedTransform(this,0);
        uVar8 = local_d8;
        if (lVar3 == null) goto LAB_181573cd7;
        uVar4 = FUN_180da0f00(lVar3,0);
        uVar5 = UIPanel.GetViewSize(this,0);
        puVar6 = (uint64 *)Transform.get_localPosition(&local_d8,lVar3,0);
        local_c8 = *puVar6;
        uStack_b0 = *(uint32 *)(puVar6 + 1);
        uVar8 = local_d8;
        local_b8 = local_c8;
        if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
        uVar1 = *(uint64 *)(*(int64 *)(this + 24) + 16);
        if (*(int64 *)(this + 40) == 0) goto LAB_181573cd7;
        uVar8 = *(uint64 *)(*(int64 *)(this + 40) + 16);
        cVar2 = Object.op_Equality(uVar1,uVar8,0);
        if (!cVar2) {
        LAB_181573767:
          uVar8 = local_d8;
          if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
          uVar8 = *(uint64 *)(*(int64 *)(this + 24) + 16);
          cVar2 = Object.op_Implicit(uVar8,0);
          local_res8 = (float)uVar5;
          if (!cVar2) {
            fVar16 = this.mClipRange - local_res8 * 0.5;
          }
          else {
            uVar8 = local_d8;
            if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
            lVar3 = AnchorPoint.GetSides(*(int64 *)(this + 24),uVar4,0);
            if (lVar3 == null) {
              uVar17 = 0;
              pfVar7 = (float *)UIRect.GetLocalPos(&local_a8,this,*(uint64 *)(this + 24),
                                                    uVar4,0);
              uVar8 = local_d8;
              if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
              fVar16 = (float)*(int *)(*(int64 *)(this + 24) + 28) + *pfVar7;
            }
            else {
              if (*(uint32 *)(lVar3 + 24) == 0) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(lVar3 + 24) < 3) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              uVar8 = local_d8;
              if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
              fVar16 = (float)NGUIMath.Lerp(*(uint32 *)(lVar3 + 32),*(uint32 *)(lVar3 + 56),
                                             *(uint32 *)(*(int64 *)(this + 24) + 24),0);
              uVar8 = local_d8;
              if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
              fVar16 = (float)*(int *)(*(int64 *)(this + 24) + 28) + fVar16;
            }
          }
          uVar8 = local_d8;
          if (*(int64 *)(this + 32) == 0) goto LAB_181573cd7;
          uVar8 = *(uint64 *)(*(int64 *)(this + 32) + 16);
          cVar2 = Object.op_Implicit(uVar8,0);
          if (!cVar2) {
            local_e8 = local_res8 * 0.5 + this.mClipRange;
          }
          else {
            uVar8 = local_d8;
            if (*(int64 *)(this + 32) == 0) goto LAB_181573cd7;
            lVar3 = AnchorPoint.GetSides(*(int64 *)(this + 32),uVar4,0);
            if (lVar3 == null) {
              uVar17 = 0;
              pfVar7 = (float *)UIRect.GetLocalPos(&local_a8,this,*(uint64 *)(this + 32),
                                                    uVar4,0);
              uVar8 = local_d8;
              if (*(int64 *)(this + 32) == 0) goto LAB_181573cd7;
              local_e8 = (float)*(int *)(*(int64 *)(this + 32) + 28) + *pfVar7;
            }
            else {
              if (*(uint32 *)(lVar3 + 24) == 0) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(lVar3 + 24) < 3) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              uVar8 = local_d8;
              if (*(int64 *)(this + 32) == 0) goto LAB_181573cd7;
              local_e8 = (float)NGUIMath.Lerp(*(uint32 *)(lVar3 + 32),*(uint32 *)(lVar3 + 56)
                                               ,*(uint32 *)(*(int64 *)(this + 32) + 24),0);
              uVar8 = local_d8;
              if (*(int64 *)(this + 32) == 0) goto LAB_181573cd7;
              local_e8 = (float)*(int *)(*(int64 *)(this + 32) + 28) + local_e8;
            }
          }
          uVar8 = local_d8;
          if (*(int64 *)(this + 40) == 0) goto LAB_181573cd7;
          uVar8 = *(uint64 *)(*(int64 *)(this + 40) + 16);
          cVar2 = Object.op_Implicit(uVar8,0);
          fStackX_c = (float)((uint64)uVar5 >> 32);
          if (!cVar2) {
            fVar15 = *(float *)(this + 0x13c) - fStackX_c * 0.5;
          }
          else {
            uVar8 = local_d8;
            if (*(int64 *)(this + 40) == 0) goto LAB_181573cd7;
            lVar3 = AnchorPoint.GetSides(*(int64 *)(this + 40),uVar4,0);
            if (lVar3 == null) {
              uVar17 = 0;
              puVar6 = (uint64 *)
                       UIRect.GetLocalPos(&local_a8,this,*(uint64 *)(this + 40),uVar4,0);
              uVar8 = *puVar6;
              if (*(int64 *)(this + 40) == 0) goto LAB_181573cd7;
              local_d8._4_4_ = (float)((uint64)uVar8 >> 32);
              fVar15 = (float)*(int *)(*(int64 *)(this + 40) + 28) + local_d8._4_4_;
              local_d8 = uVar8;
            }
            else {
              if (*(uint32 *)(lVar3 + 24) < 4) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              uVar8 = local_d8;
              if (*(int64 *)(this + 40) == 0) goto LAB_181573cd7;
              fVar15 = (float)NGUIMath.Lerp(*(uint32 *)(lVar3 + 72),*(uint32 *)(lVar3 + 48),
                                             *(uint32 *)(*(int64 *)(this + 40) + 24),0);
              uVar8 = local_d8;
              if (*(int64 *)(this + 40) == 0) goto LAB_181573cd7;
              fVar15 = (float)*(int *)(*(int64 *)(this + 40) + 28) + fVar15;
            }
          }
          uVar8 = local_d8;
          if (*(int64 *)(this + 48) == 0) goto LAB_181573cd7;
          uVar8 = *(uint64 *)(*(int64 *)(this + 48) + 16);
          cVar2 = Object.op_Implicit(uVar8,0);
          if (!cVar2) {
            fVar14 = fStackX_c * 0.5 + *(float *)(this + 0x13c);
            goto LAB_181573b67;
          }
          uVar8 = local_d8;
          if (*(int64 *)(this + 48) == 0) goto LAB_181573cd7;
          lVar3 = AnchorPoint.GetSides(*(int64 *)(this + 48),uVar4,0);
          if (lVar3 == null) {
            uVar17 = 0;
            puVar6 = (uint64 *)
                     UIRect.GetLocalPos(&local_a8,this,*(uint64 *)(this + 48),uVar4,0);
            uVar8 = *puVar6;
            if (*(int64 *)(this + 48) != 0) {
              local_d8._4_4_ = (float)((uint64)uVar8 >> 32);
              fVar14 = (float)*(int *)(*(int64 *)(this + 48) + 28) + local_d8._4_4_;
              local_d8 = uVar8;
              goto LAB_181573b67;
            }
            goto LAB_181573cd7;
          }
          if (*(uint32 *)(lVar3 + 24) < 4) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          uVar8 = local_d8;
          if (*(int64 *)(this + 48) == 0) goto LAB_181573cd7;
          uVar11 = *(uint32 *)(*(int64 *)(this + 48) + 24);
          uVar12 = *(uint32 *)(lVar3 + 48);
          uVar9 = *(uint32 *)(lVar3 + 72);
        }
        else {
          uVar8 = local_d8;
          if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
          uVar1 = *(uint64 *)(*(int64 *)(this + 24) + 16);
          if (*(int64 *)(this + 32) == 0) goto LAB_181573cd7;
          uVar8 = *(uint64 *)(*(int64 *)(this + 32) + 16);
          cVar2 = Object.op_Equality(uVar1,uVar8,0);
          if (!cVar2) goto LAB_181573767;
          uVar8 = local_d8;
          if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
          uVar1 = *(uint64 *)(*(int64 *)(this + 24) + 16);
          if (*(int64 *)(this + 48) == 0) goto LAB_181573cd7;
          uVar8 = *(uint64 *)(*(int64 *)(this + 48) + 16);
          cVar2 = Object.op_Equality(uVar1,uVar8,0);
          if (!cVar2) goto LAB_181573767;
          uVar8 = local_d8;
          if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
          lVar3 = AnchorPoint.GetSides(*(int64 *)(this + 24),uVar4,0);
          if (lVar3 == null) {
            uVar17 = 0;
            puVar6 = (uint64 *)
                     UIRect.GetLocalPos(&local_a8,this,*(uint64 *)(this + 24),uVar4,0);
            uVar8 = *puVar6;
            if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
            local_e8 = (float)uVar8;
            fVar16 = (float)*(int *)(*(int64 *)(this + 24) + 28) + local_e8;
            if (*(int64 *)(this + 40) == 0) goto LAB_181573cd7;
            local_d8._4_4_ = (float)((uint64)uVar8 >> 32);
            fVar15 = (float)*(int *)(*(int64 *)(this + 40) + 28) + local_d8._4_4_;
            if (*(int64 *)(this + 32) == 0) goto LAB_181573cd7;
            local_e8 = (float)*(int *)(*(int64 *)(this + 32) + 28) + local_e8;
            if (*(int64 *)(this + 48) == 0) goto LAB_181573cd7;
            fVar14 = (float)*(int *)(*(int64 *)(this + 48) + 28) + local_d8._4_4_;
            local_d8 = uVar8;
            goto LAB_181573b67;
          }
          if (*(uint32 *)(lVar3 + 24) == 0) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if (*(uint32 *)(lVar3 + 24) < 3) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          uVar8 = local_d8;
          if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
          fVar16 = (float)NGUIMath.Lerp(*(uint32 *)(lVar3 + 32),*(uint32 *)(lVar3 + 56),
                                         *(uint32 *)(*(int64 *)(this + 24) + 24),0);
          uVar8 = local_d8;
          if (*(int64 *)(this + 24) == 0) goto LAB_181573cd7;
          fVar16 = (float)*(int *)(*(int64 *)(this + 24) + 28) + fVar16;
          if (*(uint32 *)(lVar3 + 24) == 0) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if (*(uint32 *)(lVar3 + 24) < 3) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if (*(int64 *)(this + 32) == 0) goto LAB_181573cd7;
          local_e8 = (float)NGUIMath.Lerp(*(uint32 *)(lVar3 + 32),*(uint32 *)(lVar3 + 56),
                                           *(uint32 *)(*(int64 *)(this + 32) + 24),0);
          uVar8 = local_d8;
          if (*(int64 *)(this + 32) == 0) goto LAB_181573cd7;
          local_e8 = (float)*(int *)(*(int64 *)(this + 32) + 28) + local_e8;
          if (*(uint32 *)(lVar3 + 24) < 4) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if (*(int64 *)(this + 40) == 0) goto LAB_181573cd7;
          fVar15 = (float)NGUIMath.Lerp(*(uint32 *)(lVar3 + 72),*(uint32 *)(lVar3 + 48),
                                         *(uint32 *)(*(int64 *)(this + 40) + 24),0);
          uVar8 = local_d8;
          if (*(int64 *)(this + 40) == 0) goto LAB_181573cd7;
          fVar15 = (float)*(int *)(*(int64 *)(this + 40) + 28) + fVar15;
          if (*(uint32 *)(lVar3 + 24) < 4) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          if (*(int64 *)(this + 48) == 0) goto LAB_181573cd7;
          uVar11 = *(uint32 *)(*(int64 *)(this + 48) + 24);
          uVar12 = *(uint32 *)(lVar3 + 48);
          uVar9 = *(uint32 *)(lVar3 + 72);
        }
        fVar14 = (float)NGUIMath.Lerp(uVar9,uVar12,uVar11,0);
        uVar8 = local_d8;
        if (*(int64 *)(this + 48) == 0) {
        LAB_181573cd7:
          local_d8 = uVar8;
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        fVar14 = (float)*(int *)(*(int64 *)(this + 48) + 28) + fVar14;
        LAB_181573b67:
        fVar13 = local_b8._4_4_ + *(float *)(this + 0x168);
        fVar10 = (float)local_c8 + this.mClipOffset;
        fVar15 = fVar15 - fVar13;
        fVar14 = fVar14 - fVar13;
        local_e8 = local_e8 - fVar10;
        fVar16 = fVar16 - fVar10;
        uVar11 = Mathf.Lerp(fVar16,local_e8,0x3f000000,0);
        uVar12 = Mathf.Lerp(fVar15,fVar14,0x3f000000,0);
        fVar13 = (float)Mathf.Max(0x40000000,this.mClipSoftness,0);
        fVar10 = (float)Mathf.Max(0x40000000,*(uint32 *)(this + 0x14c),0);
        local_a8 = 0;
        uStack_a0 = 0;
        local_e8 = local_e8 - fVar16;
        fVar14 = fVar14 - fVar15;
        if (fVar13 <= local_e8) {
          fVar13 = local_e8;
        }
        if (fVar10 <= fVar14) {
          fVar10 = fVar14;
        }
        FUN_1809981e0(&local_a8,uVar11,uVar12,fVar13,CONCAT44(uVar17,fVar10),0);
        local_b8 = local_a8;
        uStack_b0 = (uint32)uStack_a0;
        uStack_ac = uStack_a0._4_4_;
        UIPanel.set_baseClipRegion(this,&local_b8,0);
    }

    // Token : 0x60008AF
    // RVA   : 0x15730F0   Offset: 0x15718F0   Length: 0x298
    private void LateUpdate()
    {
        var plVar5 = *(int64*)(lVar5 + 184);
        var pStatics = *(int64*)(DAT_181d8ac58 + 184);
        int iVar1;
        int iVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        int iVar6;
        iVar6 = *(int *)(pStatics + 24);
        iVar3 = Time.get_frameCount(0);
        if (iVar6 == iVar3) {
          return;
        }
        uVar4 = Time.get_frameCount(0);
        iVar3 = 0;
        *(uint32 *)(pStatics + 24) = uVar4;
        iVar6 = 0;
        if (*pStatics != 0) {
          iVar1 = *(int *)(*pStatics + 24);
          if (0 < iVar1) {
            do {
              if ((*pStatics == 0) ||
                 (lVar5 = FUN_180002f80(*pStatics,iVar6,DAT_181d82978),
                 lVar5 == null)) throw; // [null/range check failed]
              UIPanel.UpdateSelf(lVar5,0);
              iVar6 = iVar6 + 1;
            } while (iVar6 < iVar1);
          }
          iVar6 = 3000;
          if (*pStatics != 0) {
            iVar1 = *(int *)(*pStatics + 24);
            if (iVar1 < 1) {
              return;
            }
            while( true ) {
              if ((*pStatics == 0) ||
                 (lVar5 = FUN_180002f80(*pStatics,iVar3,DAT_181d82978),
                 lVar5 == null)) break;
              if (*(int *)(lVar5 + 168) == 0) {
                *(int *)(lVar5 + 172) = iVar6;
                UIPanel.UpdateDrawCalls(lVar5,iVar3,0);
                if (plVar5 == 0) break;
                iVar6 = iVar6 + *(int *)(plVar5 + 24);
              }
              else if (*(int *)(lVar5 + 168) == 1) {
                UIPanel.UpdateDrawCalls(lVar5,iVar3,0);
                if (plVar5 == 0) break;
                iVar2 = *(int *)(plVar5 + 24);
                if (iVar2 != 0) {
                  iVar6 = Mathf.Max(iVar6,*(int *)(lVar5 + 172) + iVar2,0);
                }
              }
              else {
                UIPanel.UpdateDrawCalls(lVar5,iVar3);
                if (plVar5 == 0) break;
                if (*(int *)(plVar5 + 24) != 0) {
                  iVar6 = Mathf.Max(iVar6,*(int *)(lVar5 + 172) + 1,0);
                }
              }
              iVar3 = iVar3 + 1;
              if (iVar1 <= iVar3) {
                return;
              }
            }
          }
        }
    }

    // Token : 0x60008B0
    // RVA   : 0x15753A0   Offset: 0x1573BA0   Length: 0x29C
    private void UpdateSelf()
    {
        ulong uVar1;
        byte uVar2;
        bool cVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        lVar4 = UIRect.get_cachedTransform(this,0);
        if (lVar4 != null) {
          uVar2 = Transform.get_hasChanged(lVar4,0);
          this.mHasMoved = uVar2;
          UIPanel.UpdateTransformMatrix(this,0);
          UIPanel.UpdateLayers(this,0);
          UIPanel.UpdateWidgets(this,0);
          if (this.mRebuild) {
            this.mRebuild = 0;
            UIPanel.FillAllDrawCalls(this,0);
        LAB_18157559a:
            if (this.mUpdateScroll) {
              this.mUpdateScroll = 0;
              lVar4 = Component.GetComponent(this,DAT_181d6e540);
              cVar3 = Object.op_Inequality(lVar4,0,0);
              if (cVar3) {
                if (lVar4 == null) throw; // [null/range check failed]
                UIScrollView.UpdateScrollbars(lVar4,0);
              }
            }
            if (this.mHasMoved) {
              this.mHasMoved = 0;
              if (*(int64 *)(this + 72) == 0) throw; // [null/range check failed]
              Transform.set_hasChanged(*(int64 *)(this + 72),0,0);
            }
            return;
          }
          uVar1 = *(uint64 *)(this + 128);
          cVar3 = Object.op_Equality(uVar1,0,0);
          if (!cVar3) {
            if (*(int64 *)(this + 128) == 0) throw; // [null/range check failed]
            uVar2 = Camera.get_useOcclusionCulling(*(int64 *)(this + 128),0);
          }
          else {
            uVar2 = 1;
          }
          lVar4 = this.drawCalls;
          uVar5 = 0;
          if (lVar4 != null) {
            lVar6 = 32;
            do {
              if (lVar4.Count <= (int)uVar5) goto LAB_18157559a;
              if (lVar4 == null) break;
              if (lVar4.Count <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(lVar6 + lVar4._items);
              if (lVar4 == null) break;
              if ((*(char *)(lVar4 + 216) == false) ||
                 (cVar3 = UIPanel.FillDrawCall(this,lVar4,uVar2,0), cVar3)) {
                uVar5 = uVar5 + 1;
                lVar6 = lVar6 + 8;
              }
              else {
                UIDrawCall.Destroy(lVar4,0);
                if (this.drawCalls == null) break;
                FUN_18182b220(this.drawCalls,uVar5);
              }
              lVar4 = this.drawCalls;
            } while (lVar4 != null);
          }
        }
    }

    // Token : 0x60008B1
    // RVA   : 0x1574B50   Offset: 0x1573350   Length: 0xA8
    public void SortWidgets()
    {
        long lVar1;
        ulong uVar2;
        this.mSortWidgets = 0;
        lVar1 = this.widgets;
        uVar2 = new OnTooltipCB(0,DAT_181d9dea0,DAT_181d86618);
        if (lVar1 != null) {
          List_1.Sort(lVar1,uVar2,DAT_181d83678);
          return;
        }
    }

    // Token : 0x60008B2
    // RVA   : 0x1570CC0   Offset: 0x156F4C0   Length: 0x7DE
    private void FillAllDrawCalls()
    {
        int iVar1;
        uint uVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        long lVar10;
        uint uVar11;
        ulong uVar12;
        int iVar13;
        byte local_res8;
        int local_res18;
        uint local_res20;
        ulong local_58;
        ulong local_50;
        long local_48;
        lVar7 = this.drawCalls;
        uVar11 = 0;
        if (lVar7 != null) {
          local_48 = 32;
          lVar10 = 32;
          do {
            if (lVar7.Count <= (int)uVar11) {
              FUN_180f56130(lVar7);
              uVar12 = 0;
              uVar4 = *(uint64 *)(this + 128);
              iVar13 = 0;
              lVar7 = 0;
              local_58 = 0;
              local_50 = 0;
              local_res18 = 0;
              cVar3 = Object.op_Equality(uVar4,0,0);
              if (!cVar3) {
                if (*(int64 *)(this + 128) == 0) break;
                local_res8 = Camera.get_useOcclusionCulling();
              }
              else {
                local_res8 = 1;
              }
              if (this.mSortWidgets) {
                UIPanel.SortWidgets(this);
              }
              lVar10 = this.widgets;
              local_res20 = 0;
              if (lVar10 != null) goto LAB_181570ec0;
              break;
            }
            if (lVar7 == null) break;
            if (lVar7.Count <= uVar11) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar4 = *(uint64 *)(lVar10 + lVar7._items);
            UIDrawCall.Destroy(uVar4,0);
            lVar7 = this.drawCalls;
            uVar11 = uVar11 + 1;
            lVar10 = lVar10 + 8;
          } while (lVar7 != null);
        }
        LAB_18157148d:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_181570ec0:
        if (lVar10.Count <= (int)local_res20) {
          cVar3 = Object.op_Inequality(lVar7,0,0);
          if (cVar3) {
            if ((lVar7 == null) || (*(int64 *)(lVar7 + 72) == 0)) goto LAB_18157148d;
            if (*(int *)(*(int64 *)(lVar7 + 72) + 24) != 0) {
              if (this.drawCalls == null) goto LAB_18157148d;
              FUN_181827900(this.drawCalls,lVar7,DAT_181d81d78);
              UIDrawCall.UpdateGeometry(lVar7,iVar13,local_res8,0);
              *(uint64 *)(lVar7 + 224) = this.mOnRender;
              this.mOnRender = 0;
            }
          }
          return;
        }
        if (lVar10 == null) goto LAB_18157148d;
        if (lVar10.Count <= local_res20) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        plVar9 = *(int64 **)(local_48 + lVar10._items);
        if (plVar9 == (int64 *)0) goto LAB_18157148d;
        cVar3 = UIWidget.get_isVisible(plVar9,0);
        if ((!cVar3) || (cVar3 = UIWidget.get_hasVertices(plVar9,0), !cVar3)) {
          plVar9[43] = 0;
          il2cpp_internal(plVar9 + 43,0);
        }
        else {
          uVar4 = (**(code **)(*plVar9 + 0x2c8))(plVar9,*(uint64 *)(*plVar9 + 0x2d0));
          if (this.onCreateMaterial != null) {
            uVar4 = OnCreateMaterial.Invoke(this.onCreateMaterial,plVar9,uVar4);
          }
          uVar5 = (**(code **)(*plVar9 + 0x2e8))(plVar9,*(uint64 *)(*plVar9 + 0x2f0));
          uVar6 = (**(code **)(*plVar9 + 0x308))(plVar9,*(uint64 *)(*plVar9 + 0x310));
          cVar3 = Object.op_Inequality(uVar12,uVar4,0);
          if (!cVar3) {
            cVar3 = Object.op_Inequality(local_58,uVar5,0);
            if (cVar3) goto LAB_18157100b;
            cVar3 = Object.op_Inequality(local_50,uVar6,0);
            if (cVar3) goto LAB_18157100b;
          }
          else {
        LAB_18157100b:
            cVar3 = Object.op_Inequality(lVar7,0,0);
            uVar12 = uVar4;
            local_58 = uVar5;
            local_50 = uVar6;
            if (cVar3) {
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 72) == 0)) goto LAB_18157148d;
              if (*(int *)(*(int64 *)(lVar7 + 72) + 24) != 0) {
                if (this.drawCalls == null) goto LAB_18157148d;
                FUN_181827900(this.drawCalls,lVar7,DAT_181d81d78);
                UIDrawCall.UpdateGeometry(lVar7,local_res18,local_res8,0);
                *(uint64 *)(lVar7 + 224) = this.mOnRender;
                this.mOnRender = 0;
                local_res18 = 0;
                lVar7 = 0;
              }
            }
          }
          cVar3 = Object.op_Inequality(uVar12,0,0);
          iVar13 = local_res18;
          if (!cVar3) {
            cVar3 = Object.op_Inequality(local_50,0,0);
            if (!cVar3) {
              cVar3 = Object.op_Inequality(local_58,0,0);
              if (!cVar3) goto LAB_181571376;
            }
          }
          cVar3 = Object.op_Equality(lVar7,0);
          if (!cVar3) {
            iVar1 = *(int *)((int64)plVar9 + 172);
            if (lVar7 == null) goto LAB_18157148d;
            if (iVar1 < lVar7._version) {
              lVar7._version = iVar1;
            }
            if (*(int *)(lVar7 + 32) < iVar1) {
              *(int *)(lVar7 + 32) = iVar1;
            }
          }
          else {
            lVar7 = UIDrawCall.Create(this,uVar12,local_58,local_50,0);
            if (lVar7 == null) goto LAB_18157148d;
            uVar2 = *(uint32 *)((int64)plVar9 + 172);
            lVar7._version = uVar2;
            *(uint32 *)(lVar7 + 32) = uVar2;
            *(int64 *)(lVar7 + 48) = this;
            *(uint64 *)(lVar7 + 232) = this.onCreateDrawCall;
          }
          plVar9[43] = lVar7;
          il2cpp_internal();
          cVar3 = Object.op_Inequality(lVar7,0,0);
          if (cVar3) {
            local_res18 = local_res18 + 1;
            if (!this.generateNormals) {
              if (!this.generateUV2) {
                uVar6 = 0;
                uVar4 = 0;
                uVar5 = 0;
              }
              else {
                uVar6 = *(uint64 *)(lVar7 + 104);
                uVar4 = 0;
                uVar5 = 0;
              }
            }
            else {
              uVar4 = *(uint64 *)(lVar7 + 80);
              uVar5 = *(uint64 *)(lVar7 + 88);
              if (!this.generateUV2) {
                uVar6 = 0;
              }
              else {
                uVar6 = *(uint64 *)(lVar7 + 104);
              }
            }
            UIWidget.WriteToBuffers
                      (plVar9,*(uint64 *)(lVar7 + 72),*(uint64 *)(lVar7 + 96),
                       *(uint64 *)(lVar7 + 112),uVar4,uVar5,uVar6,0);
            plVar9 = (int64 *)plVar9[25];
            iVar13 = local_res18;
            if (plVar9 != (int64 *)0) {
              if (this.mOnRender != null) {
                plVar8 = (int64 *)Delegate.Combine();
                plVar9 = (int64 *)0;
                if (plVar8 != (int64 *)0) {
                  if (*plVar8 == DAT_181d68510) {
                    plVar9 = plVar8;
                  }
                  if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar8,DAT_181d68510);
                  }
                }
              }
              this.mOnRender = plVar9;
            }
          }
        }
        LAB_181571376:
        lVar10 = this.widgets;
        local_res20 = local_res20 + 1;
        local_48 = local_48 + 8;
        if (lVar10 == null) goto LAB_18157148d;
        goto LAB_181570ec0;
    }

    // Token : 0x60008B3
    // RVA   : 0x15714A0   Offset: 0x156FCA0   Length: 0xA4
    public bool FillDrawCall(UIDrawCall dc)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar5;
        ulong uVar6;
        long lVar8;
        int iVar9;
        uint uVar10;
        cVar1 = Object.op_Inequality(dc,0,0);
        if (!cVar1) {
          return false;
        }
        if (dc != null) {
          *(uint8 *)(dc + 216) = 0;
          iVar9 = 0;
          lVar2 = this.widgets;
          uVar10 = 0;
          if (lVar2 != null) {
            lVar8 = 32;
            do {
              if (lVar2.Count <= (int)uVar10) {
                if (*(int64 *)(dc + 72) != 0) {
                  if (*(int *)(*(int64 *)(dc + 72) + 24) == 0) {
                    return false;
                  }
                  UIDrawCall.UpdateGeometry(dc,iVar9,param_3,0);
                  *(uint64 *)(dc + 224) = this.mOnRender;
                  this.mOnRender = 0;
                  return true;
                }
                break;
              }
              if (lVar2 == null) break;
              if (lVar2.Count <= uVar10) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar8 + lVar2._items);
              cVar1 = Object.op_Equality(lVar2,0,0);
              if (!cVar1) {
                if (lVar2 == null) break;
                uVar5 = *(uint64 *)(lVar2 + 0x158);
                cVar1 = Object.op_Equality(uVar5,dc,0);
                if (cVar1) {
                  cVar1 = UIWidget.get_isVisible(lVar2);
                  if ((!cVar1) || (cVar1 = UIWidget.get_hasVertices(), !cVar1)) {
                    *(uint64 *)(lVar2 + 0x158) = 0;
                  }
                  else {
                    iVar9 = iVar9 + 1;
                    if (!this.generateNormals) {
                      if (!this.generateUV2) {
                        uVar3 = 0;
                        uVar5 = 0;
                        uVar6 = 0;
                      }
                      else {
                        uVar3 = *(uint64 *)(dc + 104);
                        uVar5 = 0;
                        uVar6 = 0;
                      }
                    }
                    else {
                      uVar5 = *(uint64 *)(dc + 80);
                      uVar6 = *(uint64 *)(dc + 88);
                      if (!this.generateUV2) {
                        uVar3 = 0;
                      }
                      else {
                        uVar3 = *(uint64 *)(dc + 104);
                      }
                    }
                    UIWidget.WriteToBuffers
                              (lVar2,*(uint64 *)(dc + 72),*(uint64 *)(dc + 96),
                               *(uint64 *)(dc + 112),uVar5,uVar6,uVar3,0);
                    plVar7 = *(int64 **)(lVar2 + 200);
                    if (plVar7 != (int64 *)0) {
                      if (this.mOnRender != null) {
                        plVar4 = (int64 *)Delegate.Combine();
                        plVar7 = (int64 *)0;
                        if (plVar4 != (int64 *)0) {
                          if (*plVar4 == DAT_181d68510) {
                            plVar7 = plVar4;
                          }
                          if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6070(plVar4,DAT_181d68510);
                          }
                        }
                      }
                      this.mOnRender = plVar7;
                      uVar10 = uVar10 + 1;
                      lVar8 = lVar8 + 8;
                      goto LAB_181571809;
                    }
                  }
                }
                uVar10 = uVar10 + 1;
                lVar8 = lVar8 + 8;
              }
              else {
                if (this.widgets == null) break;
                FUN_18182b220();
              }
        LAB_181571809:
              lVar2 = this.widgets;
            } while (lVar2 != null);
          }
        }
    }

    // Token : 0x60008B4
    // RVA   : 0x1571550   Offset: 0x156FD50   Length: 0x368
    public bool FillDrawCall(UIDrawCall dc, bool needsCulling)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar5;
        ulong uVar6;
        long lVar8;
        int iVar9;
        uint uVar10;
        cVar1 = Object.op_Inequality(dc,0,0);
        if (!cVar1) {
          return false;
        }
        if (dc != null) {
          *(uint8 *)(dc + 216) = 0;
          iVar9 = 0;
          lVar2 = this.widgets;
          uVar10 = 0;
          if (lVar2 != null) {
            lVar8 = 32;
            do {
              if (lVar2.Count <= (int)uVar10) {
                if (*(int64 *)(dc + 72) != 0) {
                  if (*(int *)(*(int64 *)(dc + 72) + 24) == 0) {
                    return false;
                  }
                  UIDrawCall.UpdateGeometry(dc,iVar9,needsCulling,0);
                  *(uint64 *)(dc + 224) = this.mOnRender;
                  this.mOnRender = 0;
                  return true;
                }
                break;
              }
              if (lVar2 == null) break;
              if (lVar2.Count <= uVar10) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar8 + lVar2._items);
              cVar1 = Object.op_Equality(lVar2,0,0);
              if (!cVar1) {
                if (lVar2 == null) break;
                uVar5 = *(uint64 *)(lVar2 + 0x158);
                cVar1 = Object.op_Equality(uVar5,dc,0);
                if (cVar1) {
                  cVar1 = UIWidget.get_isVisible(lVar2);
                  if ((!cVar1) || (cVar1 = UIWidget.get_hasVertices(), !cVar1)) {
                    *(uint64 *)(lVar2 + 0x158) = 0;
                  }
                  else {
                    iVar9 = iVar9 + 1;
                    if (!this.generateNormals) {
                      if (!this.generateUV2) {
                        uVar3 = 0;
                        uVar5 = 0;
                        uVar6 = 0;
                      }
                      else {
                        uVar3 = *(uint64 *)(dc + 104);
                        uVar5 = 0;
                        uVar6 = 0;
                      }
                    }
                    else {
                      uVar5 = *(uint64 *)(dc + 80);
                      uVar6 = *(uint64 *)(dc + 88);
                      if (!this.generateUV2) {
                        uVar3 = 0;
                      }
                      else {
                        uVar3 = *(uint64 *)(dc + 104);
                      }
                    }
                    UIWidget.WriteToBuffers
                              (lVar2,*(uint64 *)(dc + 72),*(uint64 *)(dc + 96),
                               *(uint64 *)(dc + 112),uVar5,uVar6,uVar3,0);
                    plVar7 = *(int64 **)(lVar2 + 200);
                    if (plVar7 != (int64 *)0) {
                      if (this.mOnRender != null) {
                        plVar4 = (int64 *)Delegate.Combine();
                        plVar7 = (int64 *)0;
                        if (plVar4 != (int64 *)0) {
                          if (*plVar4 == DAT_181d68510) {
                            plVar7 = plVar4;
                          }
                          if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6070(plVar4,DAT_181d68510);
                          }
                        }
                      }
                      this.mOnRender = plVar7;
                      uVar10 = uVar10 + 1;
                      lVar8 = lVar8 + 8;
                      goto LAB_181571809;
                    }
                  }
                }
                uVar10 = uVar10 + 1;
                lVar8 = lVar8 + 8;
              }
              else {
                if (this.widgets == null) break;
                FUN_18182b220();
              }
        LAB_181571809:
              lVar2 = this.widgets;
            } while (lVar2 != null);
          }
        }
    }

    // Token : 0x60008B5
    // RVA   : 0x1574C00   Offset: 0x1573400   Length: 0x52D
    private void UpdateDrawCalls(int sortOrder)
    {
        ulong uVar1;
        float fVar2;
        ulong uVar3;
        ulong uVar4;
        bool cVar5;
        int iVar6;
        int iVar7;
        long lVar8;
        ulong uVar9;
        long lVar11;
        ulong uVar12;
        uint uVar13;
        long lVar14;
        float fVar16;
        ulong local_98;
        float local_90;
        ulong local_88;
        float local_80;
        byte[] local_78 = new byte[16];
        ulong local_68;
        ulong uStack_60;
        lVar8 = UIRect.get_cachedTransform(this,0);
        uVar9 = UIRect.get_anchorCamera(this,0);
        cVar5 = Object.op_Inequality(uVar9,0,0);
        if (!cVar5) {
          cVar5 = false;
        }
        else {
          if (*(int64 *)(this + 128) == 0) throw; // [null/range check failed]
          cVar5 = Camera.get_orthographic(*(int64 *)(this + 128),0);
        }
        if (this.mClipping == null) {
          puVar10 = (uint64 *)Vector4.get_zero(&local_68,0);
          uVar9 = puVar10[1];
          this.drawCallClipRange = *puVar10;
          *(uint64 *)(this + 0x108) = uVar9;
        }
        else {
          puVar10 = (uint64 *)UIPanel.get_finalClipRegion(&local_68,this,0);
          uVar9 = puVar10[1];
          this.drawCallClipRange = *puVar10;
          *(uint64 *)(this + 0x108) = uVar9;
          *(float *)(this + 0x108) = *(float *)(this + 0x108) * 0.5;
          *(float *)(this + 0x10c) = *(float *)(this + 0x10c) * 0.5;
        }
        iVar6 = Screen.get_width(0);
        iVar7 = Screen.get_height(0);
        if (*(float *)(this + 0x108) == 0.0) {
          *(float *)(this + 0x108) = (float)iVar6 * 0.5;
        }
        if (*(float *)(this + 0x10c) == 0.0) {
          *(float *)(this + 0x10c) = (float)iVar7 * 0.5;
        }
        if (!cVar5) {
          if (lVar8 == null) throw; // [null/range check failed]
          puVar10 = (uint64 *)Transform.get_position(local_78,lVar8,0);
          fVar16 = *(float *)(puVar10 + 1);
          uVar9 = *puVar10;
        }
        else {
          lVar14 = UIRect.get_cachedTransform(this,0);
          if (lVar14 == null) throw; // [null/range check failed]
          lVar14 = FUN_180da0f00(lVar14,0);
          lVar11 = UIRect.get_cachedTransform(this,0);
          if (lVar11 == null) throw; // [null/range check failed]
          puVar10 = (uint64 *)Transform.get_localPosition(local_78,lVar11,0);
          local_98 = *puVar10;
          fVar16 = *(float *)(puVar10 + 1);
          local_90 = fVar16;
          if (this.mClipping != null) {
            iVar6 = Mathf.RoundToInt();
            iVar7 = Mathf.RoundToInt();
            local_98 = CONCAT44((float)iVar7,(float)iVar6);
          }
          uVar9 = local_98;
          cVar5 = Object.op_Inequality(lVar14,0,0);
          if (cVar5) {
            if (lVar14 == null) throw; // [null/range check failed]
            local_88 = uVar9;
            local_80 = fVar16;
            puVar10 = (uint64 *)Transform.TransformPoint(local_78,lVar14,&local_88,0);
            local_98 = *puVar10;
            local_90 = *(float *)(puVar10 + 1);
          }
          puVar10 = (uint64 *)UIPanel.get_drawCallOffset(&local_68,this,0);
          local_88 = *puVar10;
          local_80 = *(float *)(puVar10 + 1);
          fVar16 = local_80 + local_90;
          local_98 = CONCAT44((float)((uint64)local_88 >> 32) + local_98._4_4_,
                              (float)local_88 + (float)local_98);
          uVar9 = local_98;
          local_90 = fVar16;
          if (lVar8 == null) throw; // [null/range check failed]
        }
        puVar10 = (uint64 *)Transform.get_rotation(&local_68,lVar8,0);
        uVar3 = *puVar10;
        uVar4 = puVar10[1];
        puVar10 = (uint64 *)Transform.get_lossyScale(&local_68,lVar8,0);
        uVar13 = 0;
        uVar1 = *puVar10;
        fVar2 = *(float *)(puVar10 + 1);
        lVar8 = this.drawCalls;
        if (lVar8 != null) {
          lVar14 = 32;
          while( true ) {
            if (lVar8.Count <= (int)uVar13) {
              return;
            }
            if (lVar8 == null) break;
            if (lVar8.Count <= uVar13) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar8 = *(int64 *)(lVar14 + lVar8._items);
            if ((lVar8 == null) || (lVar11 = UIDrawCall.get_cachedTransform(lVar8,0)) == null) break;
            local_88 = uVar9;
            local_80 = fVar16;
            Transform.set_position(lVar11,&local_88,0);
            local_68 = uVar3;
            uStack_60 = uVar4;
            Transform.set_rotation(lVar11,&local_68);
            local_98 = uVar1;
            local_90 = fVar2;
            Transform.set_localScale(lVar11,&local_98);
            iVar6 = this.startingRenderQueue;
            if (this.renderQueue != 2) {
              iVar6 = this.startingRenderQueue + uVar13;
            }
            UIDrawCall.set_renderQueue(lVar8,iVar6);
            if (!this.alwaysOnScreen) {
              bVar15 = false;
            }
            else if (this.mClipping == null) {
              bVar15 = true;
            }
            else {
              bVar15 = this.mClipping == 4;
            }
            *(bool *)(lVar8 + 64) = bVar15;
            if (!this.useSortingOrder) {
              iVar6 = 0;
            }
            else {
              iVar6 = this.mSortingOrder;
              if ((iVar6 == 0) && (this.renderQueue == null)) {
                iVar6 = sortOrder;
              }
            }
            UIDrawCall.set_sortingOrder(lVar8,iVar6);
            if (!this.useSortingOrder) {
              uVar12 = 0;
            }
            else {
              uVar12 = this.mSortingLayerName;
            }
            UIDrawCall.set_sortingLayerName(lVar8,uVar12);
            *(uint64 *)(lVar8 + 56) = this.mClipTexture;
            UIDrawCall.set_shadowMode(lVar8);
            lVar8 = this.drawCalls;
            uVar13 = uVar13 + 1;
            lVar14 = lVar14 + 8;
            if (lVar8 == null) break;
          }
        }
    }

    // Token : 0x60008B6
    // RVA   : 0x1575130   Offset: 0x1573930   Length: 0x263
    private void UpdateLayers()
    {
        int iVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        long lVar8;
        uint uVar9;
        long lVar10;
        uint uVar11;
        long lVar12;
        iVar1 = this.mLayer;
        lVar5 = UIRect.get_cachedGameObject(this,0);
        if (lVar5 != null) {
          iVar3 = GameObject.get_layer(lVar5,0);
          if (iVar1 == iVar3) {
            return;
          }
          if (*(int64 *)(this + 64) != 0) {
            uVar4 = GameObject.get_layer(*(int64 *)(this + 64),0);
            uVar9 = 0;
            this.mLayer = uVar4;
            uVar11 = 0;
            if (this.widgets != null) {
              lVar5 = (int64)this.widgets.Count;
              lVar10 = 32;
              if (0 < lVar5) {
                lVar8 = 0;
                lVar12 = 32;
                do {
                  lVar7 = this.widgets;
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (lVar7.Count <= uVar11) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = *(int64 *)(lVar12 + lVar7._items);
                  cVar2 = Object.op_Implicit(lVar7,0);
                  if (cVar2) {
                    if (lVar7 == null) throw; // [null/range check failed]
                    uVar6 = UIRect.get_parent(lVar7,0);
                    cVar2 = Object.op_Equality(uVar6,this,0);
                    if (cVar2) {
                      lVar7 = Component.get_gameObject(lVar7,0);
                      if (lVar7 == null) throw; // [null/range check failed]
                      GameObject.set_layer();
                    }
                  }
                  uVar11 = uVar11 + 1;
                  lVar8 = lVar8 + 1;
                  lVar12 = lVar12 + 8;
                } while (lVar8 < lVar5);
              }
              UIRect.ResetAnchors(this,0);
              lVar5 = this.drawCalls;
              if (lVar5 != null) {
                while( true ) {
                  if (lVar5.Count <= (int)uVar9) {
                    return;
                  }
                  if (lVar5 == null) break;
                  if (lVar5.Count <= uVar9) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar5 = *(int64 *)(lVar10 + lVar5._items);
                  if ((lVar5 == null) || (lVar5 = Component.get_gameObject(lVar5,0)) == null) break;
                  GameObject.set_layer(lVar5,this.mLayer,0);
                  lVar5 = this.drawCalls;
                  uVar9 = uVar9 + 1;
                  lVar10 = lVar10 + 8;
                  if (lVar5 == null) break;
                }
              }
            }
          }
        }
    }

    // Token : 0x60008B7
    // RVA   : 0x1575750   Offset: 0x1573F50   Length: 0x3F2
    private void UpdateWidgets()
    {
        var pStatics = *(int64*)(DAT_181d8b058 + 184);
        long lVar1;
        bool cVar3;
        bool cVar4;
        byte uVar5;
        uint uVar6;
        long lVar7;
        ulong uVar8;
        uint uVar9;
        ulong uVar10;
        ulong uVar11;
        long lVar13;
        bool cVar14;
        float fVar15;
        cVar14 = false;
        bVar2 = false;
        cVar3 = UIPanel.get_hasCumulativeClipping(this,0);
        uVar11 = 0;
        if (!this.cullWhileDragging) {
          uVar10 = uVar11;
          cVar14 = false;
          while( true ) {
            if (*pStatics == 0) break;
            uVar9 = (uint32)uVar10;
            if (*(int *)(*pStatics + 24) <= (int)uVar9) goto LAB_1815758db;
            if ((*pStatics == 0) ||
               (lVar7 = *(int64 *)(*pStatics + 16)) == null) break;
            if (*(uint32 *)(lVar7 + 24) <= uVar9) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            lVar7 = lVar7[uVar9];
            if (lVar7 == null) break;
            uVar8 = *(uint64 *)(lVar7 + 152);
            cVar4 = Object.op_Equality(uVar8,this);
            if ((cVar4) && (cVar4 = UIScrollView.get_isDragging(lVar7,0), cVar4)) {
              cVar14 = true;
            }
            uVar10 = (uint64)(uVar9 + 1);
          }
        }
        else {
        LAB_1815758db:
          if (this.mForced != cVar14) {
            this.mForced = cVar14;
            this.mResized = 1;
          }
          uVar6 = Time.get_frameCount(0);
          if (this.widgets != null) {
            lVar7 = (int64)this.widgets.Count;
            if (0 < lVar7) {
              lVar13 = 32;
              uVar10 = uVar11;
              do {
                lVar1 = this.widgets;
                if (lVar1 == null) throw; // [null/range check failed]
                if (lVar1.Count <= (uint32)uVar10) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar1 = *(int64 *)(lVar13 + lVar1._items);
                if (lVar1 == null) throw; // [null/range check failed]
                uVar8 = *(uint64 *)(lVar1 + 232);
                cVar4 = Object.op_Equality(uVar8,this,0);
                if ((cVar4) && (cVar4 = Behaviour.get_enabled(lVar1,0), cVar4)) {
                  cVar4 = UIWidget.UpdateTransform(lVar1,uVar6);
                  if (((cVar4) || (this.mResized)) ||
                     ((this.mHasMoved && (!this.alwaysOnScreen)))) {
                    if (!cVar14) {
                      fVar15 = (float)UIWidget.CalculateCumulativeAlpha(lVar1,uVar6,0);
                      bVar12 = 0.001 < fVar15;
                      if (!this.alwaysOnScreen) {
                        if ((!cVar3) && (*(char *)(lVar1 + 209) == false)) {
                          uVar5 = 1;
                        }
                        else {
                          uVar5 = UIPanel.IsVisible(this,lVar1,0);
                        }
                      }
                      else {
                        uVar5 = 1;
                      }
                    }
                    else {
                      bVar12 = true;
                      uVar5 = 1;
                    }
                    UIWidget.UpdateVisibility(lVar1,bVar12,uVar5,0);
                  }
                  cVar4 = UIWidget.UpdateGeometry(lVar1,uVar6);
                  if ((cVar4) && (bVar2 = true, !this.mRebuild)) {
                    uVar8 = *(uint64 *)(lVar1 + 0x158);
                    cVar4 = Object.op_Inequality(uVar8,0);
                    if (!cVar4) {
                      UIPanel.FindDrawCall(this,lVar1);
                    }
                    else {
                      if (*(int64 *)(lVar1 + 0x158) == 0) throw; // [null/range check failed]
                      *(uint8 *)(*(int64 *)(lVar1 + 0x158) + 216) = 1;
                    }
                  }
                }
                uVar10 = (uint64)((uint32)uVar10 + 1);
                uVar11 = uVar11 + 1;
                lVar13 = lVar13 + 8;
              } while ((int64)uVar11 < lVar7);
              if ((bVar2) && (this.onGeometryUpdated != null)) {
                OnGeometryUpdated.Invoke(this.onGeometryUpdated,0);
              }
            }
            this.mResized = 0;
            return;
          }
        }
    }

    // Token : 0x60008B8
    // RVA   : 0x15718C0   Offset: 0x15700C0   Length: 0x2BD
    public UIDrawCall FindDrawCall(UIWidget w)
    {
        int iVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        long lVar9;
        uint uVar10;
        int iVar11;
        long lVar12;
        if (w != (int64 *)0) {
          uVar5 = (**(code **)(*w + 0x2c8))(w,*(uint64 *)(*w + 0x2d0));
          uVar6 = (**(code **)(*w + 0x2e8))(w,*(uint64 *)(*w + 0x2f0));
          uVar7 = (**(code **)(*w + 0x308))(w,*(uint64 *)(*w + 0x310));
          lVar9 = this.drawCalls;
          uVar10 = 0;
          iVar1 = *(int *)((int64)w + 172);
          if (lVar9 != null) {
            lVar12 = 32;
            do {
              if (lVar9.Count <= (int)uVar10) {
        LAB_181571b6d:
                this.mRebuild = 1;
                return 0;
              }
              if (lVar9 == null) break;
              if (lVar9.Count <= uVar10) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(lVar12 + lVar9._items);
              if (uVar10 == 0) {
                iVar11 = -0x80000000;
              }
              else {
                if ((this.drawCalls == null) ||
                   (lVar8 = FUN_180002f80(this.drawCalls,uVar10 - 1,DAT_181d81f78),
                   lVar8 == null)) break;
                iVar11 = *(int *)(lVar8 + 32) + 1;
              }
              lVar8 = this.drawCalls;
              if (lVar8 == null) break;
              uVar10 = uVar10 + 1;
              if (uVar10 == lVar8.Count) {
                iVar4 = 0x7fffffff;
              }
              else {
                lVar8 = FUN_180002f80(lVar8,uVar10,DAT_181d81f78);
                if (lVar8 == null) break;
                iVar4 = lVar8._version + -1;
              }
              if ((iVar11 <= iVar1) && (iVar1 <= iVar4)) {
                if (lVar9 != null) {
                  uVar2 = *(uint64 *)(lVar9 + 120);
                  cVar3 = Object.op_Equality(uVar2,uVar5,0);
                  if (cVar3) {
                    uVar5 = *(uint64 *)(lVar9 + 136);
                    cVar3 = Object.op_Equality(uVar5,uVar7,0);
                    if (cVar3) {
                      uVar5 = *(uint64 *)(lVar9 + 128);
                      cVar3 = Object.op_Equality(uVar5,uVar6,0);
                      if (cVar3) {
                        cVar3 = UIWidget.get_isVisible(w,0);
                        if (!cVar3) {
                          return 0;
                        }
                        w[43] = lVar9;
                        il2cpp_internal(w + 43,lVar9);
                        cVar3 = UIWidget.get_hasVertices(w,0);
                        if (cVar3) {
                          *(uint8 *)(lVar9 + 216) = 1;
                          return lVar9;
                        }
                        return lVar9;
                      }
                    }
                  }
                  goto LAB_181571b6d;
                }
                break;
              }
              lVar9 = this.drawCalls;
              lVar12 = lVar12 + 8;
            } while (lVar9 != null);
          }
        }
    }

    // Token : 0x60008B9
    // RVA   : 0x15700D0   Offset: 0x156E8D0   Length: 0x1AC
    public void AddWidget(UIWidget w)
    {
        long lVar1;
        int iVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        lVar1 = this.widgets;
        this.mUpdateScroll = 1;
        if (lVar1 == null) goto LAB_181570277;
        if (lVar1.Count == null) {
          FUN_181827900(lVar1,w,DAT_181d83478);
        }
        else {
          if (!this.mSortWidgets) {
            if (lVar1.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            iVar2 = UIWidget.PanelCompareFunc
                              (w,*(uint64 *)(lVar1._items + 32),0);
            lVar1 = this.widgets;
            if (iVar2 == -1) {
              if (lVar1 != null) {
                FUN_18182ac70(lVar1,0,w,DAT_181d834f8);
                goto LAB_181570252;
              }
            }
            else if (lVar1 != null) {
              uVar4 = (uint64)lVar1.Count;
              uVar5 = uVar4;
              do {
                uVar6 = uVar4 & 0xffffffff;
                if ((int64)uVar5 < 1) goto LAB_181570252;
                lVar1 = this.widgets;
                uVar3 = (int)uVar4 - 1;
                uVar4 = (uint64)uVar3;
                uVar5 = uVar5 - 1;
                if (lVar1 == null) goto LAB_181570277;
                if (lVar1.Count <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                iVar2 = UIWidget.PanelCompareFunc
                                  (w,*(uint64 *)(lVar1._items + 32 + uVar5 * 8)
                                   ,0);
              } while (iVar2 == -1);
              if (this.widgets != null) {
                FUN_18182ac70(this.widgets,uVar6,w,DAT_181d834f8);
                goto LAB_181570252;
              }
            }
        LAB_181570277:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181827900(lVar1,w,DAT_181d83478);
          UIPanel.SortWidgets(this,0);
        }
        LAB_181570252:
        UIPanel.FindDrawCall(this,w,0);
    }

    // Token : 0x60008BA
    // RVA   : 0x1574650   Offset: 0x1572E50   Length: 0x111
    public void RemoveWidget(UIWidget w)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        if (this.widgets != null) {
          cVar2 = FUN_181801c10(this.widgets,w,DAT_181d83578);
          if (!cVar2) {
            return;
          }
          if (w != null) {
            uVar1 = *(uint64 *)(w + 0x158);
            cVar2 = Object.op_Inequality(uVar1,0,0);
            if (!cVar2) {
              return;
            }
            lVar3 = *(int64 *)(w + 0x158);
            if (lVar3 != null) {
              if ((*(int *)(w + 172) == *(int *)(lVar3 + 28)) ||
                 (*(int *)(w + 172) == *(int *)(lVar3 + 32))) {
                this.mRebuild = 1;
                lVar3 = *(int64 *)(w + 0x158);
              }
              if (lVar3 != null) {
                *(uint8 *)(lVar3 + 216) = 1;
                *(uint64 *)(w + 0x158) = 0;
                return;
              }
            }
          }
        }
    }

    // Token : 0x60008BB
    // RVA   : 0x1574550   Offset: 0x1572D50   Length: 0xF4
    public void Refresh()
    {
        var pStatics = *(int64*)(DAT_181d8ac58 + 184);
        long lVar1;
        this.mRebuild = 1;
        *(uint32 *)(pStatics + 24) = 0xffffffff;
        if (*pStatics != 0) {
          if (*(int *)(*pStatics + 24) < 1) {
            return;
          }
          lVar1 = *pStatics;
          if (lVar1 != null) {
            if (*(int *)(lVar1 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 32);
            if (lVar1 != null) {
              UIPanel.LateUpdate(lVar1,0);
              return;
            }
          }
        }
    }

    // Token : 0x60008BC
    // RVA   : 0x1570480   Offset: 0x156EC80   Length: 0x168
    public virtual Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
    {
        uint64 *
        UIPanel.CalculateConstrainOffset
                (uint64 *this,int64 min,uint64 max,uint64 param_4)
        {
        float *pfVar1;
        uint64 uVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        uint32 local_res8;
        uint32 uStackX_c;
        uint32 local_48;
        uint32 uStack_44;
        pfVar1 = (float *)UIPanel.get_finalClipRegion(&local_48,min,0);
        local_res8 = (uint32)max;
        uStackX_c = (uint32)((uint64)max >> 32);
        local_48 = local_res8;
        fVar5 = *pfVar1 - pfVar1[2] * 0.5;
        uStack_44 = uStackX_c;
        fVar3 = *pfVar1 + pfVar1[2] * 0.5;
        fVar6 = pfVar1[1] - pfVar1[3] * 0.5;
        fVar4 = pfVar1[1] + pfVar1[3] * 0.5;
        if ((*(char *)(min + 164) != false) && (*(int *)(min + 0x134) == 3)) {
          fVar3 = fVar3 - *(float *)(min + 0x148);
          fVar4 = fVar4 - *(float *)(min + 0x14c);
          fVar5 = *(float *)(min + 0x148) + fVar5;
          fVar6 = *(float *)(min + 0x14c) + fVar6;
        }
        uVar2 = NGUIMath.ConstrainRect(max,param_4,CONCAT44(fVar6,fVar5),CONCAT44(fVar4,fVar3),0);
        *this = uVar2;
        *(uint32 *)(this + 1) = 0;
        return this;
    }

    // Token : 0x60008BD
    // RVA   : 0x1570810   Offset: 0x156F010   Length: 0x420
    public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
    {
        ulong uVar1;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        uint8 local_20 [24];
        uVar1 = UIRect.get_cachedTransform(this,0);
        puVar2 = (uint32 *)NGUIMath.CalculateRelativeWidgetBounds(local_20,uVar1,target,0);
        local_38 = *puVar2;
        uStack_34 = puVar2[1];
        uStack_30 = puVar2[2];
        uStack_2c = puVar2[3];
        local_28 = *(uint64 *)(puVar2 + 4);
        UIPanel.ConstrainTargetToBounds(this,target,&local_38,targetBounds,0);
    }

    // Token : 0x60008BE
    // RVA   : 0x1570C40   Offset: 0x156F440   Length: 0x73
    public bool ConstrainTargetToBounds(Transform target, bool immediate)
    {
        ulong uVar1;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        uint8 local_20 [24];
        uVar1 = UIRect.get_cachedTransform(this,0);
        puVar2 = (uint32 *)NGUIMath.CalculateRelativeWidgetBounds(local_20,uVar1,target,0);
        local_38 = *puVar2;
        uStack_34 = puVar2[1];
        uStack_30 = puVar2[2];
        uStack_2c = puVar2[3];
        local_28 = *(uint64 *)(puVar2 + 4);
        UIPanel.ConstrainTargetToBounds(this,target,&local_38,immediate,0);
    }

    // Token : 0x60008BF
    // RVA   : 0x1571C80   Offset: 0x1570480   Length: 0x14C
    public static UIPanel Find(Transform trans)
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = NGUITools.FindInParents(trans,DAT_181d66980);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          return uVar2;
        }
        for (; trans != null; trans = FUN_180da0f00(trans)) {
          uVar2 = FUN_180da0f00(trans,0);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (!cVar1) {
            if (param_2) {
              uVar2 = NGUITools.CreateUI(trans,0,param_3,0);
              return uVar2;
            }
            return 0;
          }
          if (trans == null) break;
        }
    }

    // Token : 0x60008C0
    // RVA   : 0x1571DD0   Offset: 0x15705D0   Length: 0x66
    public static UIPanel Find(Transform trans, bool createIfMissing)
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = NGUITools.FindInParents(trans,DAT_181d66980);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          return uVar2;
        }
        for (; trans != null; trans = FUN_180da0f00(trans)) {
          uVar2 = FUN_180da0f00(trans,0);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (!cVar1) {
            if (createIfMissing) {
              uVar2 = NGUITools.CreateUI(trans,0,param_3,0);
              return uVar2;
            }
            return false;
          }
          if (trans == null) break;
        }
    }

    // Token : 0x60008C1
    // RVA   : 0x1571E40   Offset: 0x1570640   Length: 0x16B
    public static UIPanel Find(Transform trans, bool createIfMissing, int layer)
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = NGUITools.FindInParents(trans,DAT_181d66980);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          return uVar2;
        }
        for (; trans != null; trans = FUN_180da0f00(trans)) {
          uVar2 = FUN_180da0f00(trans,0);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (!cVar1) {
            if (createIfMissing) {
              uVar2 = NGUITools.CreateUI(trans,0,layer,0);
              return uVar2;
            }
            return false;
          }
          if (trans == null) break;
        }
    }

    // Token : 0x60008C2
    // RVA   : 0x15726B0   Offset: 0x1570EB0   Length: 0x107
    public Vector2 GetWindowSize()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        float fVar5;
        float local_res20;
        float fStackX_24;
        lVar3 = UIRect.get_root(this,0);
        uVar4 = NGUITools.get_screenSize(0);
        cVar1 = Object.op_Inequality(lVar3,0,0);
        if (cVar1) {
          fStackX_24 = (float)((uint64)uVar4 >> 32);
          uVar2 = Mathf.RoundToInt(fStackX_24,0);
          if (lVar3 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar5 = (float)UIRoot.GetPixelSizeAdjustment(lVar3,uVar2,0);
          local_res20 = (float)uVar4;
          uVar4 = CONCAT44(fStackX_24 * fVar5,local_res20 * fVar5);
        }
        return uVar4;
    }

    // Token : 0x60008C3
    // RVA   : 0x1572630   Offset: 0x1570E30   Length: 0x76
    public Vector2 GetViewSize()
    {
        ulong uVar1;
        if (this.mClipping == null) {
          uVar1 = NGUITools.get_screenSize(0);
          return uVar1;
        }
        return *(uint64 *)(this + 0x140);
    }

    // Token : 0x60008C4
    // RVA   : 0x1575C50   Offset: 0x1574450   Length: 0x3C2
    public void /*ctor*/()
    {
        ulong uVar1;
        uint local_res8;
        uint32 uStackX_c;
        uint64 local_78;
        uint64 uStack_70;
        uint64 local_68;
        uint64 uStack_60;
        uint8 local_58 [80];
        this.showInPanelTool = 1;
        this.cullWhileDragging = 1;
        this.softBorderPadding = 1;
        this.startingRenderQueue = 3000;
        uVar1 = il2cpp_internal(DAT_181d73cb0);
        FUN_180f58a90(uVar1,DAT_181d833f8);
        this.widgets = uVar1;
        uVar1 = il2cpp_internal(DAT_181d738b0);
        FUN_180f58a90(uVar1,DAT_181d81cf8);
        this.drawCalls = uVar1;
        puVar2 = (uint64 *)Matrix4x4.get_identity(local_58,0);
        uVar1 = puVar2[1];
        this.worldToLocal = *puVar2;
        *(uint64 *)(this + 200) = uVar1;
        uVar1 = puVar2[3];
        *(uint64 *)(this + 208) = puVar2[2];
        *(uint64 *)(this + 216) = uVar1;
        uVar1 = puVar2[5];
        *(uint64 *)(this + 224) = puVar2[4];
        *(uint64 *)(this + 232) = uVar1;
        uVar1 = puVar2[7];
        *(uint64 *)(this + 240) = puVar2[6];
        *(uint64 *)(this + 248) = uVar1;
        local_78 = 0;
        uStack_70 = 0;
        FUN_1809981e0(&local_78,0,0,0x3f800000,0x3f800000,0);
        this.drawCallClipRange = local_78;
        *(uint64 *)(this + 0x108) = uStack_70;
        this.mAlpha = 0x3f800000;
        local_68 = 0;
        uStack_60 = 0;
        FUN_1809981e0(&local_68,0,0,0x43960000,0x43480000,0);
        this.mClipSoftness = 0x40800000;
        *(uint32 *)(this + 0x14c) = 0x40800000;
        this.mClipRange = (uint32)local_68;
        *(uint32 *)(this + 0x13c) = local_68._4_4_;
        *(uint32 *)(this + 0x140) = (uint32)uStack_60;
        *(uint32 *)(this + 0x144) = uStack_60._4_4_;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.mClipOffset = local_res8;
        *(uint32 *)(this + 0x168) = uStackX_c;
        this.mMatrixFrame = 0xffffffff;
        this.mLayer = 0xffffffff;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.mMin = local_res8;
        *(uint32 *)(this + 0x17c) = uStackX_c;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.mMax = local_res8;
        *(uint32 *)(this + 0x184) = uStackX_c;
        uVar1 = new c.DisplayClass9_0(0);
        *(uint64 *)(this + 24) = uVar1;
        uVar1 = new AnchorPoint(0x3f800000,0);
        *(uint64 *)(this + 32) = uVar1;
        uVar1 = new c.DisplayClass9_0(0);
        *(uint64 *)(this + 40) = uVar1;
        uVar1 = new AnchorPoint(0x3f800000,0);
        *(uint64 *)(this + 48) = uVar1;
        *(uint32 *)(this + 56) = 1;
        uVar1 = new BetterList_1(DAT_181d81b98);
        *(uint64 *)(this + 80) = uVar1;
        *(uint8 *)(this + 88) = 1;
        *(uint8 *)(this + 90) = 1;
        *(uint32 *)(this + 92) = 0xffffffff;
        *(uint32 *)(this + 140) = 0x3f800000;
        FUN_18044ef50(this,0);
    }

    // Token : 0x60008C5
    // RVA   : 0x1575B50   Offset: 0x1574350   Length: 0x100
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8ac58 + 184);
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d73ab0);
        FUN_180f58a90(uVar1,DAT_181d825f8);
        puVar2 = *(uint64 **)(DAT_181d8ac58 + 184);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        uVar1 = FUN_1800d60b0(DAT_181d80340,4);
        puVar2 = (uint64 *)(pStatics + 8);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        uVar1 = FUN_1800d60b0(DAT_181d81c40,4);
        puVar2 = (uint64 *)(pStatics + 16);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        *(uint32 *)(pStatics + 24) = 0xffffffff;
    }

}
