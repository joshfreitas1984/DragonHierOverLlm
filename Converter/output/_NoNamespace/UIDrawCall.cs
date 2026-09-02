// ============================================================
// Type  : UIDrawCall
// Token : 0x2000099
// ============================================================

public class UIDrawCall
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400039A
    private static BetterList<UIDrawCall> mActiveList;

    // Token: 0x400039B
    private static BetterList<UIDrawCall> mInactiveList;

    // Token: 0x400039C
    public int widgetCount;

    // Token: 0x400039D
    public int depthStart;

    // Token: 0x400039E
    public int depthEnd;

    // Token: 0x400039F
    public UIPanel manager;

    // Token: 0x40003A0
    public UIPanel panel;

    // Token: 0x40003A1
    public Texture2D clipTexture;

    // Token: 0x40003A2
    public bool alwaysOnScreen;

    // Token: 0x40003A3
    public List<Vector3> verts;

    // Token: 0x40003A4
    public List<Vector3> norms;

    // Token: 0x40003A5
    public List<Vector4> tans;

    // Token: 0x40003A6
    public List<Vector2> uvs;

    // Token: 0x40003A7
    public List<Vector4> uv2;

    // Token: 0x40003A8
    public List<Color> cols;

    // Token: 0x40003A9
    private Material mMaterial;

    // Token: 0x40003AA
    private Texture mTexture;

    // Token: 0x40003AB
    private Shader mShader;

    // Token: 0x40003AC
    private int mClipCount;

    // Token: 0x40003AD
    private Transform mTrans;

    // Token: 0x40003AE
    private Mesh mMesh;

    // Token: 0x40003AF
    private MeshFilter mFilter;

    // Token: 0x40003B0
    private MeshRenderer mRenderer;

    // Token: 0x40003B1
    private Material mDynamicMat;

    // Token: 0x40003B2
    private int[] mIndices;

    // Token: 0x40003B3
    private ShadowMode mShadowMode;

    // Token: 0x40003B4
    private bool mRebuildMat;

    // Token: 0x40003B5
    private bool mLegacyShader;

    // Token: 0x40003B6
    private int mRenderQueue;

    // Token: 0x40003B7
    private int mTriangles;

    // Token: 0x40003B8
    public bool isDirty;

    // Token: 0x40003B9
    private bool mTextureClip;

    // Token: 0x40003BA
    private bool mIsNew;

    // Token: 0x40003BB
    public OnRenderCallback onRender;

    // Token: 0x40003BC
    public OnCreateDrawCall onCreateDrawCall;

    // Token: 0x40003BD
    private string mSortingLayerName;

    // Token: 0x40003BE
    private int mSortingOrder;

    // Token: 0x40003BF
    private static ColorSpace mColorSpace;

    // Token: 0x40003C0
    private const int maxIndexBufferCache;

    // Token: 0x40003C1
    private static List<int[]> mCache;

    // Token: 0x40003C2
    protected MaterialPropertyBlock mBlock;

    // Token: 0x40003C3
    private static int[] ClipRange;

    // Token: 0x40003C4
    private static int[] ClipArgs;

    // Token: 0x40003C5
    private static int dx9BugWorkaround;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600046D
    // RVA   : 0x10E5E20   Offset: 0x10E4620   Length: 0x57
    public static BetterList<UIDrawCall> get_list()
    {
        return **(uint64 **)(DAT_181d8a758 + 184);
    }

    // Token : 0x600046E
    // RVA   : 0x10E5C10   Offset: 0x10E4410   Length: 0x57
    public static BetterList<UIDrawCall> get_activeList()
    {
        return **(uint64 **)(DAT_181d8a758 + 184);
    }

    // Token : 0x600046F
    // RVA   : 0x10E5DB0   Offset: 0x10E45B0   Length: 0x58
    public static BetterList<UIDrawCall> get_inactiveList()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d8a758 + 184) + 8);
    }

    // Token : 0x6000470
    // RVA   : 0x10E5E80   Offset: 0x10E4680   Length: 0x7
    public int get_renderQueue()
    {
        uint32 FUN_1810e5e80(int64 this)
        {
        return this.mRenderQueue;
    }

    // Token : 0x6000471
    // RVA   : 0x10E61A0   Offset: 0x10E49A0   Length: 0x9F
    public void set_renderQueue(int value)
    {
        ulong uVar1;
        bool cVar2;
        if (this.mRenderQueue != value) {
          this.mRenderQueue = value;
          uVar1 = this.mDynamicMat;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.mDynamicMat == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Material.set_renderQueue(this.mDynamicMat,value,0);
          }
        }
    }

    // Token : 0x6000472
    // RVA   : 0x10E5F60   Offset: 0x10E4760   Length: 0x7
    public int get_sortingOrder()
    {
        uint32 FUN_1810e5f60(int64 this)
        {
        return this.mSortingOrder;
    }

    // Token : 0x6000473
    // RVA   : 0x10E64A0   Offset: 0x10E4CA0   Length: 0x9F
    public void set_sortingOrder(int value)
    {
        ulong uVar1;
        bool cVar2;
        if (this.mSortingOrder != value) {
          this.mSortingOrder = value;
          uVar1 = this.mRenderer;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.mRenderer == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Renderer.set_sortingOrder(this.mRenderer,value,0);
          }
        }
    }

    // Token : 0x6000474
    // RVA   : 0x10E5E90   Offset: 0x10E4690   Length: 0xC8
    public string get_sortingLayerName()
    {
        bool cVar1;
        ulong uVar2;
        cVar1 = FUN_180d6ca90(this.mSortingLayerName,0);
        if (cVar1) {
          uVar2 = this.mRenderer;
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (cVar1) {
            return 0;
          }
          if (this.mRenderer == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = Renderer.get_sortingLayerName(this.mRenderer,0);
          this.mSortingLayerName = uVar2;
        }
        return this.mSortingLayerName;
    }

    // Token : 0x6000475
    // RVA   : 0x10E63E0   Offset: 0x10E4BE0   Length: 0xBF
    public void set_sortingLayerName(string value)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mRenderer;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          cVar2 = String.op_Inequality(this.mSortingLayerName,value,0);
          if (cVar2) {
            this.mSortingLayerName = value;
            if (this.mRenderer == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Renderer.set_sortingLayerName(this.mRenderer,value,0);
          }
        }
    }

    // Token : 0x6000476
    // RVA   : 0x10E5D10   Offset: 0x10E4510   Length: 0x92
    public int get_finalRenderQueue()
    {
        ulong uVar1;
        bool cVar2;
        ulong uVar3;
        uVar1 = this.mDynamicMat;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          if (this.mDynamicMat != null) {
            uVar3 = Material.get_renderQueue(this.mDynamicMat,0);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return (uint64)this.mRenderQueue;
    }

    // Token : 0x6000477
    // RVA   : 0x10E5C70   Offset: 0x10E4470   Length: 0x9B
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

    // Token : 0x6000478
    // RVA   : 0x27AF70   Offset: 0x279770   Length: 0x5
    public Material get_baseMaterial()
    {
        return this.mMaterial;
    }

    // Token : 0x6000479
    // RVA   : 0x10E5FF0   Offset: 0x10E47F0   Length: 0x96
    public void set_baseMaterial(Material value)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mMaterial;
        cVar2 = Object.op_Inequality(uVar1,value,0);
        if (cVar2) {
          this.mMaterial = value;
          this.mRebuildMat = 1;
        }
    }

    // Token : 0x600047A
    // RVA   : 0x2A5C60   Offset: 0x2A4460   Length: 0x8
    public Material get_dynamicMaterial()
    {
        return this.mDynamicMat;
    }

    // Token : 0x600047B
    // RVA   : 0x27B040   Offset: 0x279840   Length: 0x8
    public Texture get_mainTexture()
    {
        uint64 FUN_18027b040(int64 this)
        {
        return this.mTexture;
    }

    // Token : 0x600047C
    // RVA   : 0x10E6090   Offset: 0x10E4890   Length: 0x107
    public void set_mainTexture(Texture value)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        this.mTexture = value;
        lVar3 = this.mBlock;
        if (lVar3 == null) {
          this.mBlock = new MaterialPropertyBlock(0);
          lVar3 = this.mBlock;
        }
        cVar1 = Object.op_Inequality(value,0,0);
        uVar2 = "_MainTex";
        if (!cVar1) {
          value = Texture2D.get_whiteTexture(0);
        }
        if (lVar3 != null) {
          MaterialPropertyBlock.SetTexture(lVar3,uVar2,value,0);
          return;
        }
    }

    // Token : 0x600047D
    // RVA   : 0x21B010   Offset: 0x219810   Length: 0x8
    public Shader get_shader()
    {
        uint64 FUN_18021b010(int64 this)
        {
        return this.mShader;
    }

    // Token : 0x600047E
    // RVA   : 0x10E6240   Offset: 0x10E4A40   Length: 0x9F
    public void set_shader(Shader value)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mShader;
        cVar2 = Object.op_Inequality(uVar1,value,0);
        if (cVar2) {
          this.mShader = value;
          this.mRebuildMat = 1;
        }
    }

    // Token : 0x600047F
    // RVA   : 0x27B030   Offset: 0x279830   Length: 0x7
    public ShadowMode get_shadowMode()
    {
        uint32 FUN_18027b030(int64 this)
        {
        return *(uint32 *)(this + 200);
    }

    // Token : 0x6000480
    // RVA   : 0x10E62E0   Offset: 0x10E4AE0   Length: 0xF7
    public void set_shadowMode(ShadowMode value)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if (*(int *)(this + 200) != value) {
          *(int *)(this + 200) = value;
          uVar3 = this.mRenderer;
          cVar2 = Object.op_Inequality(uVar3,0,0);
          if (cVar2) {
            lVar1 = this.mRenderer;
            if (*(int *)(this + 200) == 0) {
              if (lVar1 != null) {
                Renderer.set_shadowCastingMode(lVar1,0,0);
                if (this.mRenderer != null) {
                  Renderer.set_receiveShadows(this.mRenderer,0,0);
                  return;
                }
              }
            }
            else {
              if (*(int *)(this + 200) == 1) {
                if (lVar1 == null) goto LAB_1810e63d2;
                uVar3 = 0;
              }
              else {
                if (lVar1 == null) goto LAB_1810e63d2;
                uVar3 = 1;
              }
              Renderer.set_shadowCastingMode(lVar1,uVar3,0);
              if (this.mRenderer != null) {
                Renderer.set_receiveShadows(this.mRenderer,1,0);
                return;
              }
            }
        LAB_1810e63d2:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000481
    // RVA   : 0x10E5F70   Offset: 0x10E4770   Length: 0x7D
    public int get_triangles()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mMesh;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          return this.mTriangles;
        }
        return 0;
    }

    // Token : 0x6000482
    // RVA   : 0x10E5E10   Offset: 0x10E4610   Length: 0xB
    public bool get_isClipped()
    {
        bool FUN_1810e5e10(int64 this)
        {
        return this.mClipCount != null;
    }

    // Token : 0x6000483
    // RVA   : 0x10E2540   Offset: 0x10E0D40   Length: 0x740
    private void CreateMaterial()
    {
        bool cVar3;
        ushort uVar5;
        int iVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        uint uVar10;
        this.mTextureClip = 0;
        this.mLegacyShader = 0;
        if (this.panel == null) throw; // [null/range check failed]
        piVar1 = &this.mClipCount;
        iVar6 = UIPanel.get_clipCount(this.panel,0);
        uVar9 = this.mShader;
        this.mClipCount = iVar6;
        cVar3 = Object.op_Inequality(uVar9,0,0);
        if (!cVar3) {
          uVar9 = this.mMaterial;
          cVar3 = Object.op_Inequality(uVar9,0,0);
          lVar7 = "Unlit/Transparent Colored";
          if (cVar3) {
            if ((this.mMaterial == null) ||
               (lVar7 = Material.get_shader(this.mMaterial,0)) == null)
            throw; // [null/range check failed]
            lVar7 = Object.get_name(lVar7,0);
          }
        }
        else {
          if (this.mShader == null) throw; // [null/range check failed]
          lVar7 = Object.get_name(this.mShader,0);
        }
        if (((((lVar7 == null) || (lVar7 = String.Replace(lVar7,"GUI/Text Shader","Unlit/Text",0)) == null)
             || ((2 < *(int *)(lVar7 + 16) &&
                 (((sVar4 = String.get_Chars(lVar7,*(int *)(lVar7 + 16) + -2,0), sVar4 == 32 &&
                   (uVar5 = String.get_Chars(lVar7,*(int *)(lVar7 + 16) + -1,0), uVar5 - 49 < 9)) &&
                  (lVar7 = String.Substring(lVar7,0,*(int *)(lVar7 + 16) + -2,0)) == null))))) ||
            ((cVar3 = String.StartsWith(lVar7,"Hidden/",0), cVar3 &&
             (lVar7 = String.Substring(lVar7,7)) == null))) ||
           (lVar7 = String.Replace(lVar7," (SoftClip)","",0)) == null) throw; // [null/range check failed]
        uVar8 = String.Replace(lVar7," (TextureClip)","",0);
        uVar9 = this.panel;
        cVar3 = Object.op_Inequality(uVar9,0,0);
        if (!cVar3) {
        LAB_1810e285f:
          uVar9 = uVar8;
          if (this.mClipCount == null) goto LAB_1810e2977;
          uVar9 = Int32.ToString(piVar1);
          uVar9 = String.Concat("Hidden/",uVar8," ",uVar9,0);
          uVar9 = Shader.Find(uVar9,0);
          UIDrawCall.set_shader(this,uVar9,0);
          uVar9 = this.mShader;
          cVar3 = Object.op_Equality(uVar9,0,0);
          if (cVar3) {
            uVar9 = Int32.ToString(piVar1,0);
            uVar9 = String.Concat(uVar8," ",uVar9,0);
            uVar9 = Shader.Find(uVar9,0);
            UIDrawCall.set_shader(this,uVar9,0);
          }
          uVar9 = this.mShader;
          cVar3 = Object.op_Equality(uVar9,0,0);
          if ((cVar3) && (this.mClipCount == 1)) {
            this.mLegacyShader = 1;
            uVar9 = String.Concat(uVar8," (SoftClip)",0);
            goto LAB_1810e2977;
          }
        }
        else {
          if (this.panel == null) throw; // [null/range check failed]
          if (this.panel.mClipping != 1) goto LAB_1810e285f;
          this.mTextureClip = 1;
          uVar9 = String.Concat("Hidden/",uVar8," (TextureClip)",0);
        LAB_1810e2977:
          uVar9 = Shader.Find(uVar9,0);
          UIDrawCall.set_shader(this,uVar9,0);
        }
        uVar9 = this.mShader;
        cVar3 = Object.op_Equality(uVar9,0,0);
        if (cVar3) {
          uVar9 = Shader.Find("Unlit/Transparent Colored",0);
          UIDrawCall.set_shader(this,uVar9,0);
        }
        uVar9 = this.mMaterial;
        plVar2 = &this.mDynamicMat;
        cVar3 = Object.op_Inequality(uVar9,0,0);
        if (!cVar3) {
          uVar9 = this.mShader;
          this.mDynamicMat = new Material(uVar9,0);
          il2cpp_internal(plVar2,lVar7);
          lVar7 = this.mDynamicMat;
          if (this.mShader != null) {
            uVar9 = Object.get_name(this.mShader,0);
            uVar9 = String.Concat("[NGUI] ",uVar9,0);
            if (lVar7 != null) {
              Object.set_name(lVar7,uVar9,0);
              if (this.mDynamicMat != null) {
                Object.set_hideFlags(this.mDynamicMat,60);
                return;
              }
            }
          }
        }
        else {
          uVar9 = this.mMaterial;
          this.mDynamicMat = new Material(uVar9,0);
          il2cpp_internal(plVar2,lVar7);
          lVar7 = this.mDynamicMat;
          if (this.mMaterial != null) {
            uVar9 = Object.get_name(this.mMaterial,0);
            uVar9 = String.Concat("[NGUI] ",uVar9,0);
            if (lVar7 != null) {
              Object.set_name(lVar7,uVar9,0);
              if (this.mDynamicMat != null) {
                Object.set_hideFlags(this.mDynamicMat,60);
                if (this.mDynamicMat != null) {
                  Material.CopyPropertiesFromMaterial(this.mDynamicMat,this.mMaterial,0);
                  if (this.mMaterial != null) {
                    lVar7 = FUN_1810a6db0(this.mMaterial,0);
                    uVar10 = 0;
                    if (lVar7 != null) {
                      for (; (int)uVar10 < (int)*(uint32 *)(lVar7 + 24); uVar10 = uVar10 + 1) {
                        if (*(uint32 *)(lVar7 + 24) <= uVar10) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        if (this.mDynamicMat == null) throw; // [null/range check failed]
                        Material.EnableKeyword();
                      }
                      uVar9 = this.mShader;
                      cVar3 = Object.op_Inequality(uVar9,0,0);
                      if (!cVar3) {
                        if (this.mClipCount != null) {
                          uVar9 = Int32.ToString(piVar1,0);
                          uVar9 = String.Concat(uVar8," shader doesn't have a clipped shader version for ",uVar9," clip regions",0);
                          Debug.LogError(uVar9,0);
                        }
                      }
                      else {
                        if (this.mDynamicMat == null) throw; // [null/range check failed]
                        Material.set_shader(this.mDynamicMat,this.mShader,0);
                      }
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000484
    // RVA   : 0x10E44A0   Offset: 0x10E2CA0   Length: 0x1C6
    private Material RebuildMaterial()
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        long lVar5;
        ulong uVar6;
        uVar6 = this.mDynamicMat;
        NGUITools.DestroyImmediate(uVar6,0);
        UIDrawCall.CreateMaterial(this,0);
        if (this.mDynamicMat != null) {
          Material.set_renderQueue(this.mDynamicMat,this.mRenderQueue,0);
          uVar6 = this.mRenderer;
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (!cVar3) {
        LAB_1810e4625:
            return this.mDynamicMat;
          }
          lVar1 = this.mRenderer;
          plVar4 = (int64 *)FUN_1800d60b0(DAT_181d7ee80,1);
          lVar2 = this.mDynamicMat;
          if (plVar4 != (int64 *)0) {
            if (lVar2 != null) {
              lVar5 = il2cpp_internal(lVar2,*(uint64 *)(*plVar4 + 64));
              if (lVar5 == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
            }
            if ((int)plVar4[3] == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar4[4] = lVar2;
            il2cpp_internal(plVar4 + 4,lVar2);
            if (lVar1 != null) {
              FUN_180d94f60(lVar1,plVar4,0);
              if (this.mRenderer != null) {
                Renderer.set_sortingLayerName
                          (this.mRenderer,this.mSortingLayerName,0);
                if (this.mRenderer != null) {
                  Renderer.set_sortingOrder
                            (this.mRenderer,this.mSortingOrder,0);
                  goto LAB_1810e4625;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000485
    // RVA   : 0x10E57D0   Offset: 0x10E3FD0   Length: 0xF9
    private void UpdateMaterials()
    {
        int iVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        uVar2 = this.panel;
        cVar3 = Object.op_Equality(uVar2,0,0);
        if (!cVar3) {
          if (!this.mRebuildMat) {
            uVar2 = this.mDynamicMat;
            cVar3 = Object.op_Equality(uVar2,0,0);
            if (!cVar3) {
              iVar1 = this.mClipCount;
              if (this.panel == null) {
        LAB_1810e58c4:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              iVar4 = UIPanel.get_clipCount(this.panel,0);
              if (iVar1 == iVar4) {
                if (this.panel == null) goto LAB_1810e58c4;
                if ((bool)this.mTextureClip ==
                    (this.panel.mClipping == 1)) {
                  return;
                }
              }
            }
          }
          UIDrawCall.RebuildMaterial(this,0);
          this.mRebuildMat = 0;
        }
    }

    // Token : 0x6000486
    // RVA   : 0x10E4B70   Offset: 0x10E3370   Length: 0xC5A
    public void UpdateGeometry(int widgetCount, bool needsBounds)
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        int iVar4;
        bool cVar5;
        uint uVar6;
        uint uVar7;
        int iVar8;
        ulong uVar9;
        long lVar10;
        long lVar11;
        uint uVar14;
        uint uVar15;
        uint uVar16;
        uint[] local_res10 = new uint[2];
        byte local_res18;
        uint local_88;
        uint uStack_84;
        uint uStack_80;
        uint32 uStack_7c;
        local_res18 = needsBounds;
        this.widgetCount = widgetCount;
        if (this.verts == null) throw; // [null/range check failed]
        local_res10[0] = this.verts.Count;
        if ((int)local_res10[0] < 1) goto LAB_1810e562b;
        if (this.uvs == null) throw; // [null/range check failed]
        if (local_res10[0] != this.uvs.Count) goto LAB_1810e562b;
        if (this.cols == null) throw; // [null/range check failed]
        if (local_res10[0] == this.cols.Count) {
          uVar6 = local_res10[0] & 0x80000003;
          if ((int)uVar6 < 0) {
            uVar6 = (uVar6 - 1 | 0xfffffffc) + 1;
          }
          if (uVar6 != 0) goto LAB_1810e562b;
          if (*(int *)(pStatics + 16) == -1) {
            uVar7 = QualitySettings.get_activeColorSpace(0);
            *(uint32 *)(pStatics + 16) = uVar7;
          }
          if ((*(int *)(pStatics + 16) == 1) &&
             (uVar6 = 0, 0 < (int)local_res10[0])) {
            lVar11 = 32;
            do {
              lVar10 = this.cols;
              if (lVar10 == null) throw; // [null/range check failed]
              if (lVar10.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              puVar3 = (uint32 *)(lVar10._items + lVar11);
              uVar7 = puVar3[1];
              uVar15 = puVar3[2];
              uVar16 = puVar3[3];
              uVar14 = Mathf.GammaToLinearSpace(*puVar3,0);
              uVar7 = Mathf.GammaToLinearSpace(uVar7,0);
              uVar15 = Mathf.GammaToLinearSpace(uVar15,0);
              uVar16 = Mathf.GammaToLinearSpace(uVar16,0);
              if (this.cols == null) throw; // [null/range check failed]
              local_88 = uVar14;
              uStack_84 = uVar7;
              uStack_80 = uVar15;
              uStack_7c = uVar16;
              FUN_181814c20(this.cols,uVar6,&local_88,DAT_181d5b880);
              uVar6 = uVar6 + 1;
              lVar11 = lVar11 + 16;
            } while ((int)uVar6 < (int)local_res10[0]);
          }
          lVar11 = this.mFilter;
          cVar5 = Object.op_Equality(lVar11,0,0);
          if (cVar5) {
            lVar11 = Component.get_gameObject(this,0);
            if (lVar11 == null) throw; // [null/range check failed]
            lVar11 = GameObject.GetComponent(lVar11,DAT_181da0428);
            *plVar1 = lVar11;
            il2cpp_internal(plVar1,lVar11);
          }
          lVar11 = *plVar1;
          cVar5 = Object.op_Equality(lVar11,0,0);
          if (cVar5) {
            lVar11 = Component.get_gameObject(this,0);
            if (lVar11 == null) throw; // [null/range check failed]
            lVar11 = GameObject.AddComponent(lVar11,DAT_181d9c8a8);
            *plVar1 = lVar11;
            il2cpp_internal(plVar1,lVar11);
          }
          bVar12 = true;
          if ((int)local_res10[0] < 65000) {
            iVar4 = ((int)local_res10[0] >> 1) * 3;
            if (this.mIndices != null) {
              bVar12 = *(int *)(this.mIndices + 24) != iVar4;
            }
            lVar11 = this.mMesh;
            cVar5 = Object.op_Equality(lVar11,0,0);
            if (cVar5) {
              lVar11 = new Mesh(0);
              *plVar2 = lVar11;
              il2cpp_internal(plVar2,lVar11);
              if (*plVar2 == 0) throw; // [null/range check failed]
              Object.set_hideFlags(*plVar2,52);
              lVar11 = *plVar2;
              uVar9 = this.mMaterial;
              cVar5 = Object.op_Inequality(uVar9,0,0);
              uVar9 = "[NGUI] Mesh";
              if (cVar5) {
                if (this.mMaterial == null) throw; // [null/range check failed]
                uVar9 = Object.get_name(this.mMaterial,0);
                uVar9 = String.Concat("[NGUI] ",uVar9,0);
              }
              if (lVar11 == null) throw; // [null/range check failed]
              Object.set_name(lVar11,uVar9,0);
              if (*(int *)(pStatics + 48) == 0) {
                if (*plVar2 == 0) throw; // [null/range check failed]
                Mesh.MarkDynamic(*plVar2,0);
              }
              bVar12 = true;
            }
            if (this.uvs == null) throw; // [null/range check failed]
            if (this.uvs.Count == local_res10[0]) {
              if (this.cols == null) throw; // [null/range check failed]
              if (this.cols.Count != local_res10[0]) goto LAB_1810e5209;
              if (this.uv2 == null) throw; // [null/range check failed]
              if (this.uv2.Count != local_res10[0]) goto LAB_1810e5209;
              if (this.norms == null) throw; // [null/range check failed]
              if (this.norms.Count != local_res10[0]) goto LAB_1810e5209;
              if (this.tans == null) throw; // [null/range check failed]
              bVar13 = this.tans.Count != local_res10[0];
            }
            else {
        LAB_1810e5209:
              bVar13 = true;
            }
            if (!bVar13) {
              uVar9 = this.panel;
              cVar5 = Object.op_Inequality(uVar9,0,0);
              if (cVar5) {
                if (this.panel == null) throw; // [null/range check failed]
                if (this.panel.renderQueue != null) {
                  lVar11 = *plVar2;
                  cVar5 = Object.op_Equality(lVar11,0,0);
                  if (!cVar5) {
                    if (*plVar2 == 0) throw; // [null/range check failed]
                    iVar8 = Mesh.get_vertexCount(*plVar2,0);
                    if (this.verts == null) throw; // [null/range check failed]
                    bVar13 = iVar8 != this.verts.Count;
                  }
                  else {
                    bVar13 = true;
                  }
                  needsBounds = local_res18;
                  if (!(bVar13))
                  {
                    }
                    }
                    if (this.verts == null) throw; // [null/range check failed]
                    needsBounds = local_res18;
                    if ((int)(local_res10[0] * 2) < this.verts.Count) {
                    bVar13 = true;
                    }
                    }
                  }
            this.mTriangles = (int)local_res10[0] >> 1;
            if (*plVar2 == 0) throw; // [null/range check failed]
            uVar6 = Mesh.get_vertexCount(*plVar2,0);
            if (uVar6 != local_res10[0]) {
              if (*plVar2 == 0) throw; // [null/range check failed]
              Mesh.Clear(*plVar2,0);
              bVar12 = true;
            }
            if (*plVar2 == 0) throw; // [null/range check failed]
            Mesh.SetVertices(*plVar2,this.verts,0);
            if (*plVar2 == 0) throw; // [null/range check failed]
            Mesh.SetUVs(*plVar2,0,this.uvs,0);
            if (*plVar2 == 0) throw; // [null/range check failed]
            Mesh.SetColors(*plVar2,this.cols,0);
            lVar11 = this.uv2;
            if (lVar11 == null) throw; // [null/range check failed]
            lVar10 = 0;
            if (lVar11.Count == local_res10[0]) {
              lVar10 = lVar11;
            }
            if (*plVar2 == 0) throw; // [null/range check failed]
            Mesh.SetUVs(*plVar2,1,lVar10);
            lVar11 = this.norms;
            if (lVar11 == null) throw; // [null/range check failed]
            lVar10 = 0;
            if (lVar11.Count == local_res10[0]) {
              lVar10 = lVar11;
            }
            if (*plVar2 == 0) throw; // [null/range check failed]
            Mesh.SetNormals(*plVar2,lVar10,0);
            lVar11 = this.tans;
            if (lVar11 == null) throw; // [null/range check failed]
            lVar10 = 0;
            if (lVar11.Count == local_res10[0]) {
              lVar10 = lVar11;
            }
            if (*plVar2 == 0) throw; // [null/range check failed]
            Mesh.SetTangents(*plVar2,lVar10,0);
            if (bVar12) {
              uVar9 = UIDrawCall.GenerateCachedIndexBuffer(this,local_res10[0],iVar4,0);
              this.mIndices = uVar9;
              if (*plVar2 == 0) throw; // [null/range check failed]
              Mesh.SetTriangles(*plVar2,this.mIndices,0,needsBounds,0);
            }
            if ((bVar13) || (!this.alwaysOnScreen)) {
              if (*plVar2 == 0) throw; // [null/range check failed]
              Mesh.RecalculateBounds(*plVar2,0);
            }
            if (*plVar1 == 0) throw; // [null/range check failed]
            MeshFilter.set_mesh(*plVar1,*plVar2,0);
          }
          else {
            uVar9 = this.mMesh;
            this.mTriangles = 0;
            cVar5 = Object.op_Inequality(uVar9,0,0);
            if (cVar5) {
              if (this.mMesh == null) throw; // [null/range check failed]
              Mesh.Clear(this.mMesh,0);
            }
            uVar9 = Int32.ToString(local_res10,0);
            uVar9 = String.Concat("Too many vertices on one panel: ",uVar9,0);
            Debug.LogError(uVar9,0);
          }
          lVar11 = this.mRenderer;
          cVar5 = Object.op_Equality(lVar11,0,0);
          if (cVar5) {
            lVar11 = Component.get_gameObject(this,0);
            if (lVar11 == null) throw; // [null/range check failed]
            lVar11 = GameObject.GetComponent(lVar11,DAT_181da04b0);
            *plVar2 = lVar11;
            il2cpp_internal(plVar2,lVar11);
          }
          lVar11 = *plVar2;
          cVar5 = Object.op_Equality(lVar11,0,0);
          if (cVar5) {
            lVar11 = Component.get_gameObject(this,0);
            if (lVar11 == null) throw; // [null/range check failed]
            lVar11 = GameObject.AddComponent(lVar11,DAT_181d9c930);
            *plVar2 = lVar11;
            il2cpp_internal(plVar2,lVar11);
            lVar11 = *plVar2;
            if (*(int *)(this + 200) == 0) {
              if (lVar11 == null) throw; // [null/range check failed]
              Renderer.set_shadowCastingMode(lVar11,0,0);
              lVar11 = *plVar2;
              if (lVar11 == null) throw; // [null/range check failed]
              uVar9 = 0;
            }
            else {
              if (*(int *)(this + 200) == 1) {
                if (lVar11 == null) throw; // [null/range check failed]
                uVar9 = 0;
              }
              else {
                if (lVar11 == null) throw; // [null/range check failed]
                uVar9 = 1;
              }
              Renderer.set_shadowCastingMode(lVar11,uVar9,0);
              lVar11 = *plVar2;
              if (lVar11 == null) throw; // [null/range check failed]
              uVar9 = 1;
            }
            Renderer.set_receiveShadows(lVar11,uVar9,0);
          }
          if (this.mIsNew) {
            this.mIsNew = 0;
            if (this.onCreateDrawCall != null) {
              OnCreateDrawCall.Invoke(this.onCreateDrawCall,this,*plVar1,*plVar2,0);
            }
          }
          UIDrawCall.UpdateMaterials(this,0);
        }
        else {
        LAB_1810e562b:
          if (this.mFilter == null) throw; // [null/range check failed]
          uVar9 = MeshFilter.get_mesh(this.mFilter,0);
          cVar5 = Object.op_Inequality(uVar9,0,0);
          if (cVar5) {
            if ((this.mFilter == null) ||
               (lVar11 = MeshFilter.get_mesh(this.mFilter,0)) == null)
            throw; // [null/range check failed]
            Mesh.Clear(lVar11,0);
          }
          uVar9 = Int32.ToString(local_res10,0);
          uVar9 = String.Concat("UIWidgets must fill the buffer with 4 vertices per quad. Found ",uVar9,0);
          Debug.LogError(uVar9,0);
        }
        if (this.verts != null) {
          FUN_180f56130(this.verts,DAT_181d84378);
          if (this.uvs != null) {
            FUN_180f56130(this.uvs,DAT_181d83ff8);
            if (this.uv2 != null) {
              FUN_180f56130(this.uv2,DAT_181d846f8);
              if (this.cols != null) {
                FUN_180f56130(this.cols,DAT_181d5b700);
                if (this.norms != null) {
                  FUN_180f56130(this.norms,DAT_181d84378);
                  if (this.tans != null) {
                    FUN_180f56130(this.tans,DAT_181d846f8);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000487
    // RVA   : 0x10E3570   Offset: 0x10E1D70   Length: 0x317
    private int[] GenerateCachedIndexBuffer(int vertexCount, int indexCount)
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        uint uVar6;
        uint uVar7;
        uVar6 = 0;
        iVar5 = 0;
        lVar2 = *(int64 *)(pStatics + 24);
        if (lVar2 != null) {
          iVar1 = *(int *)(lVar2 + 24);
          if (0 < iVar1) {
            do {
              lVar2 = *(int64 *)(pStatics + 24);
              if (lVar2 == null) throw; // [null/range check failed]
              lVar2 = FUN_180002f80(lVar2,iVar5,DAT_181d52888);
              if ((lVar2 != null) && (*(int *)(lVar2 + 24) == indexCount)) {
                return lVar2;
              }
              iVar5 = iVar5 + 1;
            } while (iVar5 < iVar1);
          }
          lVar2 = FUN_1800d60b0(DAT_181d7e600,indexCount);
          if (0 < vertexCount) {
            iVar5 = 2;
            do {
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar2 + 24) <= uVar6) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              lVar3 = (int64)(int)uVar6 + 1;
              lVar2[uVar6] = iVar5 + -2;
              if (*(uint32 *)(lVar2 + 24) <= (uint32)lVar3) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              *(int *)(lVar2 + 32 + lVar3 * 4) = iVar5 + -1;
              uVar7 = uVar6 + 2;
              if (*(uint32 *)(lVar2 + 24) <= uVar7) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              lVar2[uVar7] = iVar5;
              lVar3 = (int64)(int)uVar7 + 1;
              if (*(uint32 *)(lVar2 + 24) <= (uint32)lVar3) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              *(int *)(lVar2 + 32 + lVar3 * 4) = iVar5;
              if (*(uint32 *)(lVar2 + 24) <= uVar6 + 4) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              uVar7 = uVar6 + 5;
              *(int *)(lVar2 + 32 + (int64)(int)(uVar6 + 4) * 4) = iVar5 + 1;
              uVar6 = uVar6 + 6;
              if (*(uint32 *)(lVar2 + 24) <= uVar7) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              lVar2[uVar7] = iVar5 + -2;
              iVar1 = iVar5 + 2;
              iVar5 = iVar5 + 4;
            } while (iVar1 < vertexCount);
          }
          lVar3 = *(int64 *)(pStatics + 24);
          if (lVar3 != null) {
            if (10 < *(int *)(lVar3 + 24)) {
              lVar3 = *(int64 *)(pStatics + 24);
              if (lVar3 == null) throw; // [null/range check failed]
              FUN_18182b220(lVar3,0,DAT_181d52708);
            }
            lVar3 = *(int64 *)(pStatics + 24);
            if (lVar3 != null) {
              FUN_181827900(lVar3,lVar2,DAT_181d52608);
              return lVar2;
            }
          }
        }
    }

    // Token : 0x6000488
    // RVA   : 0x10E3D90   Offset: 0x10E2590   Length: 0x70B
    private void OnWillRenderObject()
    {
        bool cVar1;
        long lVar3;
        long lVar4;
        ulong uVar6;
        long lVar7;
        int iVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        uint uVar13;
        float fVar14;
        float local_128;
        float fStack_124;
        float fStack_120;
        float fStack_11c;
        uint64 local_108;
        float local_100;
        uint64 local_f8;
        uint64 uStack_f0;
        uint64 local_e8;
        uint32 local_e0;
        float local_d0;
        uint64 local_c8;
        uint64 uStack_c0;
        uint8 local_b8 [16];
        uint8 local_a8 [16];
        uint8 local_98 [16];
        uint8 local_88 [16];
        uint8 local_78 [96];
        local_f8 = 0;
        uStack_f0 = 0;
        UIDrawCall.UpdateMaterials(this,0);
        if (this.mBlock != null) {
          if (this.mRenderer == null) throw; // [null/range check failed]
          FUN_180d94f10(this.mRenderer,this.mBlock,0);
        }
        lVar7 = this.onRender;
        if (lVar7 != null) {
          uVar6 = this.mDynamicMat;
          cVar1 = Object.op_Inequality(uVar6,0,0);
          if (!cVar1) {
            uVar6 = this.mMaterial;
          }
          else {
            uVar6 = this.mDynamicMat;
          }
          OnClickCB.Invoke(lVar7,uVar6,0);
        }
        uVar6 = this.mDynamicMat;
        cVar1 = Object.op_Equality(uVar6,0,0);
        if ((cVar1) || (this.mClipCount == null)) {
          return;
        }
        if (!this.mTextureClip) {
          lVar7 = this.panel;
          if (!this.mLegacyShader) {
            iVar8 = 0;
            do {
              cVar1 = Object.op_Inequality(lVar7,0,0);
              if (!cVar1) {
                return;
              }
              if (lVar7 == null) throw; // [null/range check failed]
              cVar1 = UIPanel.get_hasClipping(lVar7);
              if (cVar1) {
                uVar13 = 0;
                fVar9 = lVar7.drawCallClipRange;
                fVar14 = *(float *)(lVar7 + 0x104);
                fVar11 = *(float *)(lVar7 + 0x108);
                fVar12 = *(float *)(lVar7 + 0x10c);
                uVar6 = this.panel;
                local_128 = fVar9;
                fStack_124 = fVar14;
                fStack_120 = fVar11;
                fStack_11c = fVar12;
                cVar1 = Object.op_Inequality(lVar7,uVar6,0);
                if (cVar1) {
                  lVar3 = UIRect.get_cachedTransform(lVar7,0);
                  if (((this.panel == null) ||
                      (lVar4 = UIRect.get_cachedTransform(this.panel,0)) == null)
                     || (puVar5 = (uint64 *)Transform.get_position(local_b8,lVar4,0), lVar3 == null))
                  throw; // [null/range check failed]
                  local_e8 = *puVar5;
                  local_e0 = *(uint32 *)(puVar5 + 1);
                  puVar5 = (uint64 *)Transform.InverseTransformPoint(local_a8,lVar3,&local_e8,0);
                  local_128 = local_128 - (float)*puVar5;
                  fStack_124 = fStack_124 - (float)((uint64)*puVar5 >> 32);
                  if ((this.panel == null) ||
                     (lVar3 = UIRect.get_cachedTransform(this.panel,0)) == null)
                  throw; // [null/range check failed]
                  puVar5 = (uint64 *)Transform.get_rotation(local_88,lVar3,0);
                  local_f8 = *puVar5;
                  uStack_f0 = puVar5[1];
                  puVar5 = (uint64 *)Quaternion.get_eulerAngles(local_98,&local_f8,0);
                  local_108 = *puVar5;
                  local_100 = *(float *)(puVar5 + 1);
                  lVar3 = UIRect.get_cachedTransform(lVar7,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  puVar5 = (uint64 *)Transform.get_rotation(local_78,lVar3,0);
                  local_f8 = *puVar5;
                  uStack_f0 = puVar5[1];
                  puVar5 = (uint64 *)Quaternion.get_eulerAngles(&local_c8,&local_f8,0);
                  local_d0 = *(float *)(puVar5 + 1);
                  fVar14 = local_d0 - local_100;
                  fVar11 = (float)((uint64)*puVar5 >> 32) - local_108._4_4_;
                  fVar9 = (float)NGUIMath.WrapAngle((float)*puVar5 - (float)local_108,0);
                  fVar10 = (float)NGUIMath.WrapAngle(fVar11,0);
                  uVar13 = NGUIMath.WrapAngle(fVar14,0);
                  if ((0.001 < ABS(fVar9)) ||
                     (fVar9 = local_128, fVar14 = fStack_124, fVar11 = fStack_120, fVar12 = fStack_11c,
                     0.001 < ABS(fVar10))) {
                    uVar6 = this.panel;
                    Debug.LogWarning("Panel can only be clipped properly if X and Y rotation is left at 0",uVar6,0);
                    fVar9 = local_128;
                    fVar14 = fStack_124;
                    fVar11 = fStack_120;
                    fVar12 = fStack_11c;
                  }
                }
                local_128 = fVar9;
                fStack_124 = fVar14;
                fStack_120 = fVar11;
                fStack_11c = fVar12;
                UIDrawCall.SetClipping(this,iVar8,&local_128,lVar7.mClipSoftness,uVar13,0);
                iVar8 = iVar8 + 1;
              }
              lVar7 = lVar7.mParentPanel;
            } while( true );
          }
          if (lVar7 != null) {
            fVar9 = *(float *)(lVar7 + 0x108);
            fVar14 = *(float *)(lVar7 + 0x10c);
            fVar11 = 1000.0;
            fVar12 = 1000.0;
            if (0.0 < lVar7.mClipSoftness) {
              fVar11 = fVar9 / lVar7.mClipSoftness;
            }
            if (0.0 < *(float *)(lVar7 + 0x14c)) {
              fVar12 = fVar14 / *(float *)(lVar7 + 0x14c);
            }
            if (this.mDynamicMat != null) {
              Material.set_mainTextureOffset
                        (this.mDynamicMat,
                         CONCAT44(-*(float *)(lVar7 + 0x104) / fVar14,-lVar7.drawCallClipRange / fVar9),
                         0);
              if (this.mDynamicMat != null) {
                Material.set_mainTextureScale
                          (this.mDynamicMat,CONCAT44(1.0 / fVar14,1.0 / fVar9),0);
                lVar7 = this.mDynamicMat;
                pfVar2 = (float *)Vector4.op_Implicit(&local_128,CONCAT44(fVar12,fVar11),0);
                if (lVar7 != null) {
                  local_128 = *pfVar2;
                  fStack_124 = pfVar2[1];
                  fStack_120 = pfVar2[2];
                  fStack_11c = pfVar2[3];
                  Material.SetVector(lVar7,"_ClipSharpness",&local_128,0);
                  return;
                }
              }
            }
          }
        }
        else {
          lVar7 = this.panel;
          if (lVar7 != null) {
            local_128 = lVar7.drawCallClipRange;
            fStack_124 = *(float *)(lVar7 + 0x104);
            fStack_120 = *(float *)(lVar7 + 0x108);
            fStack_11c = *(float *)(lVar7 + 0x10c);
            lVar7 = this.mDynamicMat;
            lVar3 = *(int64 *)(*(int64 *)(DAT_181d8a758 + 184) + 32);
            if (lVar3 != null) {
              if (*(int *)(lVar3 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              uVar13 = *(uint32 *)(lVar3 + 32);
              local_c8 = 0;
              uStack_c0 = 0;
              FUN_1809981e0(&local_c8,CONCAT44(0x80000000,-local_128 / fStack_120),
                            CONCAT44(0x80000000,-fStack_124 / fStack_11c),1.0 / fStack_120,
                            1.0 / fStack_11c,0);
              if (lVar7 != null) {
                local_128 = (float)local_c8;
                fStack_124 = local_c8._4_4_;
                fStack_120 = (float)uStack_c0;
                fStack_11c = uStack_c0._4_4_;
                Material.SetVector(lVar7,uVar13,&local_128,0);
                if (this.mDynamicMat != null) {
                  Material.SetTexture
                            (this.mDynamicMat,"_ClipTex",this.clipTexture,0
                            );
                  return;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000489
    // RVA   : 0x10E4890   Offset: 0x10E3090   Length: 0x2DC
    private void SetClipping(int index, Vector4 cr, Vector2 soft, float angle)
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        void UIDrawCall.SetClipping
                     (int64 this,uint32 index,float *cr,uint64 soft,float angle)
        {
        uint32 uVar1;
        int64 lVar2;
        int64 lVar3;
        uint64 uVar4;
        uint32 uVar5;
        uint32 uVar6;
        float fVar7;
        float fVar8;
        uint64 local_98;
        uint64 uStack_90;
        uint64 local_88;
        uint64 uStack_80;
        uint32 local_78;
        uint32 uStack_74;
        uint32 uStack_70;
        uint32 uStack_6c;
        local_98 = soft;
        fVar7 = 1000.0;
        fVar8 = 1000.0;
        if (0.0 < (float)local_98) {
          fVar7 = cr[2] / (float)local_98;
        }
        if (0.0 < local_98._4_4_) {
          fVar8 = cr[3] / local_98._4_4_;
        }
        lVar2 = *(int64 *)(pStatics + 32);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(int *)(lVar2 + 24) <= (int)index) {
          return;
        }
        lVar2 = this.mDynamicMat;
        lVar3 = *(int64 *)(pStatics + 32);
        if (lVar3 != null) {
          if (*(uint32 *)(lVar3 + 24) <= index) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          uVar1 = lVar3[index];
          local_98 = 0;
          uStack_90 = 0;
          FUN_1809981e0(&local_98,-*cr / cr[2],-cr[1] / cr[3],1.0 / cr[2],
                        1.0 / cr[3],0);
          if (lVar2 != null) {
            local_78 = (float)local_98;
            uStack_74 = local_98._4_4_;
            uStack_70 = (uint32)uStack_90;
            uStack_6c = uStack_90._4_4_;
            Material.SetVector(lVar2,uVar1,&local_78,0);
            lVar2 = this.mDynamicMat;
            lVar3 = *(int64 *)(pStatics + 40);
            if (lVar3 != null) {
              if (*(uint32 *)(lVar3 + 24) <= index) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              uVar1 = lVar3[index];
              local_88 = 0;
              uStack_80 = 0;
              uVar5 = FUN_1801e67c0(angle * -0.017453292);
              uVar6 = FUN_1801e72c0(angle * -0.017453292);
              FUN_1809981e0(&local_88,fVar7,fVar8,uVar6,uVar5,0);
              if (lVar2 != null) {
                local_78 = (uint32)local_88;
                uStack_74 = local_88._4_4_;
                uStack_70 = (uint32)uStack_80;
                uStack_6c = uStack_80._4_4_;
                Material.SetVector(lVar2,uVar1,&local_78,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600048A
    // RVA   : 0x10E1DF0   Offset: 0x10E05F0   Length: 0x3E4
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        bool cVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        if (*(int *)(pStatics + 48) == -1) {
          iVar2 = Application.get_platform(0);
          if (iVar2 == 2) {
            iVar2 = FUN_180d9ba50(0);
            if (39 < iVar2) goto LAB_1810e1f0c;
            lVar4 = FUN_180d9b9e0(0);
            if (lVar4 == null) throw; // [null/range check failed]
            cVar1 = String.Contains(lVar4,"Direct3D",0);
            if (!cVar1) goto LAB_1810e1f0c;
            uVar3 = 1;
          }
          else {
        LAB_1810e1f0c:
            uVar3 = 0;
          }
          *(uint32 *)(pStatics + 48) = uVar3;
        }
        if (*(int64 *)(pStatics + 32) == 0) {
          lVar4 = FUN_1800d60b0(DAT_181d7e600,4);
          uVar3 = Shader.PropertyToID("_ClipRange0",0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(int *)(lVar4 + 24) == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint32 *)(lVar4 + 32) = uVar3;
          uVar3 = Shader.PropertyToID("_ClipRange1",0);
          if (*(uint32 *)(lVar4 + 24) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint32 *)(lVar4 + 36) = uVar3;
          uVar3 = Shader.PropertyToID("_ClipRange2",0);
          if (*(uint32 *)(lVar4 + 24) < 3) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint32 *)(lVar4 + 40) = uVar3;
          uVar3 = Shader.PropertyToID("_ClipRange4",0);
          if (*(uint32 *)(lVar4 + 24) < 4) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint32 *)(lVar4 + 44) = uVar3;
          plVar6 = (int64 *)(pStatics + 32);
          *plVar6 = lVar4;
          il2cpp_internal(plVar6,lVar4);
        }
        if (*(int64 *)(pStatics + 40) != 0) {
          return;
        }
        lVar4 = FUN_1800d60b0(DAT_181d7e600,4);
        uVar3 = Shader.PropertyToID("_ClipArgs0",0);
        if (lVar4 != null) {
          if (*(int *)(lVar4 + 24) == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint32 *)(lVar4 + 32) = uVar3;
          uVar3 = Shader.PropertyToID("_ClipArgs1",0);
          if (*(uint32 *)(lVar4 + 24) < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint32 *)(lVar4 + 36) = uVar3;
          uVar3 = Shader.PropertyToID("_ClipArgs2",0);
          if (*(uint32 *)(lVar4 + 24) < 3) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint32 *)(lVar4 + 40) = uVar3;
          uVar3 = Shader.PropertyToID("_ClipArgs3",0);
          if (3 < *(uint32 *)(lVar4 + 24)) {
            *(uint32 *)(lVar4 + 44) = uVar3;
            plVar6 = (int64 *)(pStatics + 40);
            *plVar6 = lVar4;
            il2cpp_internal(plVar6,lVar4);
            return;
          }
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
    }

    // Token : 0x600048B
    // RVA   : 0x10E3D80   Offset: 0x10E2580   Length: 0x8
    private void OnEnable()
    {
        void FUN_1810e3d80(int64 this)
        {
        this.mRebuildMat = 1;
    }

    // Token : 0x600048C
    // RVA   : 0x10E3C20   Offset: 0x10E2420   Length: 0x153
    private void OnDisable()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        this.depthStart = 0x7fffffff;
        this.depthEnd = 0x80000000;
        this.panel = 0;
        this.manager = 0;
        this.mMaterial = 0;
        this.mTexture = 0;
        this.clipTexture = 0;
        uVar1 = this.mRenderer;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          lVar2 = this.mRenderer;
          uVar1 = FUN_1800d60b0(DAT_181d7ee80,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_180d94f60(lVar2,uVar1,0);
        }
        uVar1 = this.mDynamicMat;
        NGUITools.DestroyImmediate(uVar1,0);
        this.mDynamicMat = 0;
    }

    // Token : 0x600048D
    // RVA   : 0x10E3BA0   Offset: 0x10E23A0   Length: 0x7B
    private void OnDestroy()
    {
        ulong uVar1;
        uVar1 = this.mMesh;
        NGUITools.DestroyImmediate(uVar1,0);
        this.mMesh = 0;
    }

    // Token : 0x600048E
    // RVA   : 0x10E2C90   Offset: 0x10E1490   Length: 0x8D
    public static UIDrawCall Create(UIPanel panel, Material mat, Texture tex, Shader shader)
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        while( true ) {
          lVar2 = *(int64 *)(pStatics + 8);
          if (lVar2 == null) goto LAB_1810e2fb0;
          if (*(int *)(lVar2 + 24) < 1) break;
          lVar2 = *(int64 *)(pStatics + 8);
          if (lVar2 == null) goto LAB_1810e2fb0;
          lVar2 = FUN_18154e410(lVar2,DAT_181d81798);
          cVar1 = Object.op_Inequality(lVar2,0);
          if (cVar1) {
            if ((*pStatics != 0) &&
               (FUN_18154cb60(*pStatics,lVar2,DAT_181d81598), lVar2 != null)) {
              if (panel != null) {
                Object.set_name(lVar2,panel,0);
              }
              uVar3 = Component.get_gameObject(lVar2,0);
              NGUITools.SetActive(uVar3,1,0);
              return lVar2;
            }
        LAB_1810e2fb0:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        lVar2 = new GameObject(panel,0);
        Object.DontDestroyOnLoad(lVar2,0);
        if (lVar2 != null) {
          lVar2 = GameObject.AddComponent(lVar2,DAT_181d9dc50);
          if (*pStatics != 0) {
            FUN_18154cb60(*pStatics,lVar2,DAT_181d81598);
            return lVar2;
          }
        }
        goto LAB_1810e2fb0;
    }

    // Token : 0x600048F
    // RVA   : 0x10E2FC0   Offset: 0x10E17C0   Length: 0x340
    private static UIDrawCall Create(string name, UIPanel pan, Material mat, Texture tex, Shader shader)
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        while( true ) {
          lVar2 = *(int64 *)(pStatics + 8);
          if (lVar2 == null) goto LAB_1810e2fb0;
          if (*(int *)(lVar2 + 24) < 1) break;
          lVar2 = *(int64 *)(pStatics + 8);
          if (lVar2 == null) goto LAB_1810e2fb0;
          lVar2 = FUN_18154e410(lVar2,DAT_181d81798);
          cVar1 = Object.op_Inequality(lVar2,0);
          if (cVar1) {
            if ((*pStatics != 0) &&
               (FUN_18154cb60(*pStatics,lVar2,DAT_181d81598), lVar2 != null)) {
              if (name != null) {
                Object.set_name(lVar2,name,0);
              }
              uVar3 = Component.get_gameObject(lVar2,0);
              NGUITools.SetActive(uVar3,1,0);
              return lVar2;
            }
        LAB_1810e2fb0:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        lVar2 = new GameObject(name,0);
        Object.DontDestroyOnLoad(lVar2,0);
        if (lVar2 != null) {
          lVar2 = GameObject.AddComponent(lVar2,DAT_181d9dc50);
          if (*pStatics != 0) {
            FUN_18154cb60(*pStatics,lVar2,DAT_181d81598);
            return lVar2;
          }
        }
        goto LAB_1810e2fb0;
    }

    // Token : 0x6000490
    // RVA   : 0x10E2D20   Offset: 0x10E1520   Length: 0x295
    private static UIDrawCall Create(string name)
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        while( true ) {
          lVar2 = *(int64 *)(pStatics + 8);
          if (lVar2 == null) goto LAB_1810e2fb0;
          if (*(int *)(lVar2 + 24) < 1) break;
          lVar2 = *(int64 *)(pStatics + 8);
          if (lVar2 == null) goto LAB_1810e2fb0;
          lVar2 = FUN_18154e410(lVar2,DAT_181d81798);
          cVar1 = Object.op_Inequality(lVar2,0);
          if (cVar1) {
            if ((*pStatics != 0) &&
               (FUN_18154cb60(*pStatics,lVar2,DAT_181d81598), lVar2 != null)) {
              if (name != null) {
                Object.set_name(lVar2,name,0);
              }
              uVar3 = Component.get_gameObject(lVar2,0);
              NGUITools.SetActive(uVar3,1,0);
              return lVar2;
            }
        LAB_1810e2fb0:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        lVar2 = new GameObject(name,0);
        Object.DontDestroyOnLoad(lVar2,0);
        if (lVar2 != null) {
          lVar2 = GameObject.AddComponent(lVar2,DAT_181d9dc50);
          if (*pStatics != 0) {
            FUN_18154cb60(*pStatics,lVar2,DAT_181d81598);
            return lVar2;
          }
        }
        goto LAB_1810e2fb0;
    }

    // Token : 0x6000491
    // RVA   : 0x10E21E0   Offset: 0x10E09E0   Length: 0x201
    public static void ClearAll()
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        long lVar1;
        bool cVar2;
        bool cVar3;
        ulong uVar4;
        uint uVar5;
        ulong uVar6;
        cVar2 = Application.get_isPlaying(0);
        if (*pStatics != 0) {
          uVar5 = *(uint32 *)(*pStatics + 24);
          while (0 < (int)uVar5) {
            uVar6 = (uint64)uVar5;
            if (*pStatics == 0) throw; // [null/range check failed]
            lVar1 = *(int64 *)(*pStatics + 16);
            uVar5 = uVar5 - 1;
            if (lVar1 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar1 + 24) <= uVar5) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            lVar1 = *(int64 *)(lVar1 + 24 + uVar6 * 8);
            cVar3 = Object.op_Implicit(lVar1);
            if (cVar3) {
              if (lVar1 == null) throw; // [null/range check failed]
              uVar4 = Component.get_gameObject(lVar1);
              if (!cVar2) {
                NGUITools.DestroyImmediate(uVar4);
              }
              else {
                NGUITools.SetActive(uVar4,0,0);
              }
            }
          }
          if (*pStatics != 0) {
            BetterList_1.Clear(*pStatics,DAT_181d81618);
            return;
          }
        }
    }

    // Token : 0x6000492
    // RVA   : 0x10E4670   Offset: 0x10E2E70   Length: 0x50
    public static void ReleaseAll()
    {
        UIDrawCall.ClearAll(0);
        UIDrawCall.ReleaseInactive(0);
    }

    // Token : 0x6000493
    // RVA   : 0x10E46C0   Offset: 0x10E2EC0   Length: 0x1CC
    public static void ReleaseInactive()
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uint uVar4;
        ulong uVar5;
        lVar1 = *(int64 *)(pStatics + 8);
        if (lVar1 != null) {
          uVar4 = *(uint32 *)(lVar1 + 24);
          while (0 < (int)uVar4) {
            uVar5 = (uint64)uVar4;
            lVar1 = *(int64 *)(pStatics + 8);
            if (lVar1 == null) throw; // [null/range check failed]
            lVar1 = *(int64 *)(lVar1 + 16);
            uVar4 = uVar4 - 1;
            if (lVar1 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar1 + 24) <= uVar4) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar1 = *(int64 *)(lVar1 + 24 + uVar5 * 8);
            cVar2 = Object.op_Implicit(lVar1);
            if (cVar2) {
              if (lVar1 == null) throw; // [null/range check failed]
              uVar3 = Component.get_gameObject(lVar1);
              NGUITools.DestroyImmediate(uVar3);
            }
          }
          lVar1 = *(int64 *)(pStatics + 8);
          if (lVar1 != null) {
            BetterList_1.Clear(lVar1,DAT_181d81618);
            return;
          }
        }
    }

    // Token : 0x6000494
    // RVA   : 0x10E23F0   Offset: 0x10E0BF0   Length: 0x142
    public static int Count(UIPanel panel)
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uint uVar4;
        int iVar5;
        iVar5 = 0;
        uVar4 = 0;
        while( true ) {
          if (*pStatics == 0) break;
          if (*(int *)(*pStatics + 24) <= (int)uVar4) {
            return iVar5;
          }
          if ((*pStatics == 0) ||
             (lVar1 = *(int64 *)(*pStatics + 16)) == null) break;
          if (*(uint32 *)(lVar1 + 24) <= uVar4) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
          lVar1 = lVar1[uVar4];
          if (lVar1 == null) break;
          uVar3 = *(uint64 *)(lVar1 + 40);
          cVar2 = Object.op_Equality(uVar3,panel,0);
          if (cVar2) {
            iVar5 = iVar5 + 1;
          }
          uVar4 = uVar4 + 1;
        }
    }

    // Token : 0x6000495
    // RVA   : 0x10E3310   Offset: 0x10E1B10   Length: 0x25F
    public static void Destroy(UIDrawCall dc)
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        cVar2 = Object.op_Implicit(dc);
        if (!cVar2) {
          return;
        }
        if (dc != null) {
          if (*(int64 *)(dc + 232) != 0) {
            uVar3 = Component.get_gameObject(dc);
            NGUITools.Destroy(uVar3,0);
            return;
          }
          *(uint64 *)(dc + 224) = 0;
          cVar2 = Application.get_isPlaying(0);
          if (!cVar2) {
            if (*pStatics != 0) {
              FUN_18154eb70(*pStatics,dc,DAT_181d81818);
              uVar3 = Component.get_gameObject(dc,0);
              NGUITools.DestroyImmediate(uVar3,0);
              return;
            }
          }
          else {
            if (*pStatics != 0) {
              cVar2 = FUN_18154eb70(*pStatics,dc,DAT_181d81818);
              if (!cVar2) {
                return;
              }
              uVar3 = Component.get_gameObject(dc,0);
              NGUITools.SetActive(uVar3,0,0);
              lVar1 = *(int64 *)(pStatics + 8);
              if (lVar1 != null) {
                FUN_18154cb60(lVar1,dc,DAT_181d81598);
                *(uint8 *)(dc + 218) = 1;
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000496
    // RVA   : 0x10E3890   Offset: 0x10E2090   Length: 0x30F
    public static void MoveToScene(Scene scene)
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        if (*pStatics != 0) {
          lVar2 = OrderedEnumerable_1.GetEnumerator(*pStatics,DAT_181d81718);
          while( true ) {
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            cVar1 = FUN_180002970(0,DAT_181d544d8,lVar2);
            if (!cVar1) break;
            lVar3 = FUN_180002970(0,DAT_181d69738,lVar2);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar4 = Component.get_gameObject(lVar3,0);
            SceneManager.MoveGameObjectToScene(uVar4,scene,0);
          }
          FUN_180002970(0,DAT_181d53c70,lVar2);
          lVar2 = *(int64 *)(pStatics + 8);
          if (lVar2 != null) {
            lVar2 = OrderedEnumerable_1.GetEnumerator(lVar2,DAT_181d81718);
            while( true ) {
              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar1 = FUN_180002970(0,DAT_181d544d8,lVar2);
              if (!cVar1) break;
              lVar3 = FUN_180002970(0,DAT_181d69738,lVar2);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar4 = Component.get_gameObject(lVar3,0);
              SceneManager.MoveGameObjectToScene(uVar4,scene,0);
            }
            FUN_180002970(0,DAT_181d53c70,lVar2);
            return;
          }
        }
    }

    // Token : 0x6000497
    // RVA   : 0x10E5A40   Offset: 0x10E4240   Length: 0x1C5
    public void /*ctor*/()
    {
        ulong uVar1;
        this.depthStart = 0x7fffffff;
        this.depthEnd = 0x80000000;
        uVar1 = il2cpp_internal(DAT_181d73eb0);
        FUN_180f58a90(uVar1,DAT_181d841f8);
        this.verts = uVar1;
        uVar1 = il2cpp_internal(DAT_181d73eb0);
        FUN_180f58a90(uVar1,DAT_181d841f8);
        this.norms = uVar1;
        uVar1 = il2cpp_internal(DAT_181d73f30);
        FUN_180f58a90(uVar1,DAT_181d84578);
        this.tans = uVar1;
        uVar1 = il2cpp_internal(DAT_181d73e30);
        FUN_180f58a90(uVar1,DAT_181d83ef8);
        this.uvs = uVar1;
        uVar1 = il2cpp_internal(DAT_181d73f30);
        FUN_180f58a90(uVar1,DAT_181d84578);
        this.uv2 = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6d130);
        FUN_180f58a90(uVar1,DAT_181d5b600);
        this.cols = uVar1;
        this.mRebuildMat = 1;
        this.mRenderQueue = 3000;
        this.mIsNew = 1;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000498
    // RVA   : 0x10E58D0   Offset: 0x10E40D0   Length: 0x16E
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8a758 + 184);
        ulong uVar1;
        uVar1 = new BetterList_1(DAT_181d81518);
        puVar2 = *(uint64 **)(DAT_181d8a758 + 184);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        uVar1 = new BetterList_1(DAT_181d81518);
        puVar2 = (uint64 *)(pStatics + 8);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        *(uint32 *)(pStatics + 16) = 0xffffffff;
        uVar1 = new List_1(10,DAT_181d52588);
        puVar2 = (uint64 *)(pStatics + 24);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        puVar2 = (uint64 *)(pStatics + 32);
        *puVar2 = 0;
        il2cpp_internal(puVar2,0);
        puVar2 = (uint64 *)(pStatics + 40);
        *puVar2 = 0;
        il2cpp_internal(puVar2,0);
        *(uint32 *)(pStatics + 48) = 0xffffffff;
    }

}
