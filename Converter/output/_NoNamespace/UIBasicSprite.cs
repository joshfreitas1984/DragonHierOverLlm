// ============================================================
// Type  : UIBasicSprite
// Token : 0x2000094
// ============================================================

public class UIBasicSprite
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000374
    protected Type mType;

    // Token: 0x4000375
    protected FillDirection mFillDirection;

    // Token: 0x4000376
    protected float mFillAmount;

    // Token: 0x4000377
    protected bool mInvert;

    // Token: 0x4000378
    protected Flip mFlip;

    // Token: 0x4000379
    protected bool mApplyGradient;

    // Token: 0x400037A
    protected Color mGradientTop;

    // Token: 0x400037B
    protected Color mGradientBottom;

    // Token: 0x400037C
    protected Rect mInnerUV;

    // Token: 0x400037D
    protected Rect mOuterUV;

    // Token: 0x400037E
    public AdvancedType centerType;

    // Token: 0x400037F
    public AdvancedType leftType;

    // Token: 0x4000380
    public AdvancedType rightType;

    // Token: 0x4000381
    public AdvancedType bottomType;

    // Token: 0x4000382
    public AdvancedType topType;

    // Token: 0x4000383
    protected static Vector2[] mTempPos;

    // Token: 0x4000384
    protected static Vector2[] mTempUVs;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600044F
    // RVA   : 0xA80D30   Offset: 0xA7F530   Length: 0x7
    public virtual Type get_type()
    {
        uint32 FUN_180a80d30(int64 this)
        {
        return this.mType;
    }

    // Token : 0x6000450
    // RVA   : 0xA80DE0   Offset: 0xA7F5E0   Length: 0x20
    public virtual void set_type(Type value)
    {
        void FUN_180a80de0(int64 *this,int value)
        {
        if ((int)this[49] != value) {
          *(int *)(this + 49) = value;
                          // WARNING: Could not recover jumptable at 0x000180a80df8. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x6000451
    // RVA   : 0xA80A30   Offset: 0xA7F230   Length: 0x7
    public Flip get_flip()
    {
        uint32 FUN_180a80a30(int64 this)
        {
        return this.mFlip;
    }

    // Token : 0x6000452
    // RVA   : 0xA80DA0   Offset: 0xA7F5A0   Length: 0x20
    public void set_flip(Flip value)
    {
        void FUN_180a80da0(int64 *this,int value)
        {
        if ((int)this[51] != value) {
          *(int *)(this + 51) = value;
                          // WARNING: Could not recover jumptable at 0x000180a80db8. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x6000453
    // RVA   : 0xA80A20   Offset: 0xA7F220   Length: 0x7
    public FillDirection get_fillDirection()
    {
        uint32 FUN_180a80a20(int64 this)
        {
        return this.mFillDirection;
    }

    // Token : 0x6000454
    // RVA   : 0xA80D80   Offset: 0xA7F580   Length: 0x13
    public void set_fillDirection(FillDirection value)
    {
        if (this.mFillDirection != value) {
          this.mFillDirection = value;
          *(uint8 *)(this + 88) = 1;
        }
    }

    // Token : 0x6000455
    // RVA   : 0xA80A10   Offset: 0xA7F210   Length: 0x9
    public float get_fillAmount()
    {
        uint32 FUN_180a80a10(int64 this)
        {
        return *(uint32 *)(this + 400);
    }

    // Token : 0x6000456
    // RVA   : 0xA80D40   Offset: 0xA7F540   Length: 0x34
    public void set_fillAmount(float value)
    {
        float fVar1;
        fVar1 = (float)Mathf.Clamp01(value,0);
        if (*(float *)(this + 400) != fVar1) {
          *(float *)(this + 400) = fVar1;
          *(uint8 *)(this + 88) = 1;
        }
    }

    // Token : 0x6000457
    // RVA   : 0xA80BD0   Offset: 0xA7F3D0   Length: 0x108
    public override int get_minWidth()
    {
        float fVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        int iVar5;
        uint uVar6;
        uint uVar7;
        float fVar9;
        ulong local_28;
        ulong uStack_20;
        iVar5 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
        if (iVar5 != 1) {
          iVar5 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
          if (iVar5 != 4) {
            UIWidget.get_minHeight(this,0);
            return;
          }
        }
        pfVar8 = (float *)(**(code **)(*this + 0x378))
                                    (&local_28,this,*(uint64 *)(*this + 0x380));
        fVar1 = *pfVar8;
        fVar2 = pfVar8[1];
        fVar3 = pfVar8[2];
        fVar4 = pfVar8[3];
        fVar9 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        local_28 = 0;
        uStack_20 = 0;
        FUN_1809981e0(&local_28,fVar1 * fVar9,fVar2 * fVar9,fVar3 * fVar9,fVar4 * fVar9,0);
        uVar6 = Mathf.RoundToInt((float)uStack_20 + (float)local_28,0);
        uVar7 = UIWidget.get_minHeight(this,0);
        if ((uVar6 & 1) != 0) {
          uVar6 = uVar6 + 1;
        }
        Mathf.Max(uVar7,uVar6,0);
    }

    // Token : 0x6000458
    // RVA   : 0xA80AC0   Offset: 0xA7F2C0   Length: 0x108
    public override int get_minHeight()
    {
        float fVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        int iVar5;
        uint uVar6;
        uint uVar7;
        float fVar9;
        ulong local_28;
        ulong uStack_20;
        iVar5 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
        if (iVar5 != 1) {
          iVar5 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
          if (iVar5 != 4) {
            UIWidget.get_minHeight(this,0);
            return;
          }
        }
        pfVar8 = (float *)(**(code **)(*this + 0x378))
                                    (&local_28,this,*(uint64 *)(*this + 0x380));
        fVar1 = *pfVar8;
        fVar2 = pfVar8[1];
        fVar3 = pfVar8[2];
        fVar4 = pfVar8[3];
        fVar9 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        local_28 = 0;
        uStack_20 = 0;
        FUN_1809981e0(&local_28,fVar1 * fVar9,fVar2 * fVar9,fVar3 * fVar9,fVar4 * fVar9,0);
        uVar6 = Mathf.RoundToInt(uStack_20._4_4_ + local_28._4_4_,0);
        uVar7 = UIWidget.get_minHeight(this,0);
        if ((uVar6 & 1) != 0) {
          uVar6 = uVar6 + 1;
        }
        Mathf.Max(uVar7,uVar6,0);
    }

    // Token : 0x6000459
    // RVA   : 0xA80AB0   Offset: 0xA7F2B0   Length: 0x8
    public bool get_invert()
    {
        uint8 FUN_180a80ab0(int64 this)
        {
        return this.mInvert;
    }

    // Token : 0x600045A
    // RVA   : 0xA80DC0   Offset: 0xA7F5C0   Length: 0x13
    public void set_invert(bool value)
    {
        if (this.mInvert != value) {
          this.mInvert = value;
          *(uint8 *)(this + 88) = 1;
        }
    }

    // Token : 0x600045B
    // RVA   : 0xA80A40   Offset: 0xA7F240   Length: 0x63
    public bool get_hasBorder()
    {
        byte[] local_18 = new byte[24];
        pfVar1 = (float *)(**(code **)(*this + 0x378))
                                    (local_18,this,*(uint64 *)(*this + 0x380));
        if ((((*pfVar1 == 0.0) && (pfVar1[1] == 0.0)) && (pfVar1[2] == 0.0)) && (pfVar1[3] == 0.0)) {
          return false;
        }
        return true;
    }

    // Token : 0x600045C
    // RVA   : 0x215A90   Offset: 0x214290   Length: 0x3
    public virtual bool get_premultipliedAlpha()
    {
        return false;
    }

    // Token : 0x600045D
    // RVA   : 0xA80D20   Offset: 0xA7F520   Length: 0x9
    public virtual float get_pixelSize()
    {
        uint64 FUN_180a80d20(void)
        {
        return 0x3f800000;
    }

    // Token : 0x600045E
    // RVA   : 0xA80CE0   Offset: 0xA7F4E0   Length: 0x35
    protected virtual Vector4 get_padding()
    {
        *this = 0;
        this[1] = 0;
        FUN_1809981e0(0,0,0,0,0,0);
        return this;
    }

    // Token : 0x600045F
    // RVA   : 0xA808D0   Offset: 0xA7F0D0   Length: 0x13F
    protected Vector4 get_drawingUVs()
    {
        int iVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;
        iVar1 = *(int *)(param_2 + 0x198);
        param_2 = param_2 + 0x1d0;
        if (iVar1 == 1) {
          uVar2 = Rect.get_xMax(param_2,0);
          uVar3 = FUN_18044df60(param_2,0);
          uVar4 = FUN_180d904a0(param_2,0);
        }
        else {
          if (iVar1 == 2) {
            uVar2 = FUN_180d904a0(param_2,0);
            uVar3 = Rect.get_yMax(param_2,0);
            uVar4 = Rect.get_xMax(param_2,0);
            uVar5 = FUN_18044df60(param_2,0);
            goto LAB_180a809ca;
          }
          if (iVar1 == 3) {
            uVar2 = Rect.get_xMax(param_2,0);
            uVar3 = Rect.get_yMax(param_2,0);
            uVar4 = FUN_180d904a0(param_2,0);
            uVar5 = FUN_18044df60(param_2,0);
            goto LAB_180a809ca;
          }
          uVar2 = FUN_180d904a0();
          uVar3 = FUN_18044df60(param_2,0);
          uVar4 = Rect.get_xMax(param_2,0);
        }
        uVar5 = Rect.get_yMax(param_2,0);
        LAB_180a809ca:
        *this = 0;
        this[1] = 0;
        FUN_1809981e0(this,uVar2,uVar3,uVar4,uVar5,0);
        return this;
    }

    // Token : 0x6000460
    // RVA   : 0xA80820   Offset: 0xA7F020   Length: 0xAE
    protected Color get_drawingColor()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        bool cVar7;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        uVar1 = *(uint32 *)((int64)param_2 + 140);
        uVar2 = *(uint32 *)((int64)param_2 + 148);
        lVar6 = param_2[19];
        uVar3 = *(uint32 *)((int64)param_2 + 156);
        *(int *)this = (int)param_2[18];
        *(uint32 *)((int64)this + 4) = uVar2;
        *(int *)(this + 1) = (int)lVar6;
        *(uint32 *)((int64)this + 12) = uVar3;
        *(uint32 *)((int64)this + 12) = uVar1;
        cVar7 = (**(code **)(*param_2 + 0x3c8))(param_2,*(uint64 *)(*param_2 + 0x3d0));
        if (cVar7) {
          uVar4 = *this;
          uVar5 = this[1];
          local_38 = uVar4;
          uStack_30 = uVar5;
          puVar8 = (uint64 *)NGUITools.ApplyPMA(local_28,&local_38,0);
          uVar4 = puVar8[1];
          *this = *puVar8;
          this[1] = uVar4;
        }
        return this;
    }

    // Token : 0x6000461
    // RVA   : 0xA7C820   Offset: 0xA7B020   Length: 0x270
    protected void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, Rect outer, Rect inner)
    {
                              uint32 outer,uint32 inner,uint32 param_7,uint32 param_8,
                              uint32 param_9,uint32 param_10,uint32 param_11,
                              uint32 *param_12)
        {
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        if (this != 0) {
          uStack_44 = inner;
          uStack_40 = 0;
          local_48 = cols;
          FUN_181805a40(this,&local_48,DAT_181d84278);
          uStack_44 = param_7;
          uStack_40 = 0;
          local_48 = cols;
          FUN_181805a40(this,&local_48,DAT_181d84278);
          local_48 = outer;
          uStack_44 = param_7;
          uStack_40 = 0;
          FUN_181805a40(this,&local_48,DAT_181d84278);
          local_48 = outer;
          uStack_44 = inner;
          uStack_40 = 0;
          FUN_181805a40(this,&local_48,DAT_181d84278);
          if (verts != null) {
            FUN_181814e80(verts,CONCAT44(param_10,param_8),DAT_181d83f78);
            FUN_181814e80(verts,CONCAT44(param_11,param_8),DAT_181d83f78);
            FUN_181814e80(verts,CONCAT44(param_11,param_9),DAT_181d83f78);
            FUN_181814e80(verts,CONCAT44(param_10,param_9),DAT_181d83f78);
            if (uvs != null) {
              local_48 = *param_12;
              uStack_44 = param_12[1];
              uStack_40 = param_12[2];
              uStack_3c = param_12[3];
              FUN_1818059b0(uvs,&local_48,DAT_181d5b680);
              local_48 = *param_12;
              uStack_44 = param_12[1];
              uStack_40 = param_12[2];
              uStack_3c = param_12[3];
              FUN_1818059b0(uvs,&local_48,DAT_181d5b680);
              local_48 = *param_12;
              uStack_44 = param_12[1];
              uStack_40 = param_12[2];
              uStack_3c = param_12[3];
              FUN_1818059b0(uvs,&local_48,DAT_181d5b680);
              local_48 = *param_12;
              uStack_44 = param_12[1];
              uStack_40 = param_12[2];
              uStack_3c = param_12[3];
              FUN_1818059b0(uvs,&local_48,DAT_181d5b680);
              return;
            }
          }
        }
    }

    // Token : 0x6000462
    // RVA   : 0xA7E8A0   Offset: 0xA7D0A0   Length: 0x7EB
    protected void SimpleFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
    {
        void UIBasicSprite.SimpleFill
                     (int64 *this,int64 verts,int64 uvs,int64 cols,
                     uint64 *v,uint32 *u,int64 *c)
        {
        int iVar1;
        int64 lVar2;
        int64 *plVar3;
        float fVar4;
        float fVar5;
        uint64 in_stack_ffffffffffffff88;
        uint32 uVar7;
        uint64 uVar6;
        uint64 uVar8;
        uint64 local_68;
        uint64 uStack_60;
        int64 local_58;
        int64 lStack_50;
        uint8 local_48 [48];
        uVar7 = (uint32)((uint64)in_stack_ffffffffffffff88 >> 32);
        if (verts == null) goto LAB_180a7f086;
        uStack_60 = uStack_60 & 0xffffffff00000000;
        local_68 = *v;
        FUN_181805a40(verts,&local_68,DAT_181d84278);
        local_68 = CONCAT44(*(uint32 *)((int64)v + 12),*(uint32 *)v);
        uStack_60 = uStack_60 & 0xffffffff00000000;
        FUN_181805a40(verts,&local_68,DAT_181d84278);
        local_68 = v[1];
        uStack_60 = uStack_60 & 0xffffffff00000000;
        FUN_181805a40(verts,&local_68,DAT_181d84278);
        local_68 = CONCAT44(*(uint32 *)((int64)v + 4),*(uint32 *)(v + 1));
        uStack_60 = uStack_60 & 0xffffffff00000000;
        FUN_181805a40(verts,&local_68,DAT_181d84278);
        if (uvs == null) goto LAB_180a7f086;
        FUN_181814e80(uvs,CONCAT44(u[1],*u),DAT_181d83f78);
        FUN_181814e80(uvs,CONCAT44(u[3],*u),DAT_181d83f78);
        FUN_181814e80(uvs,*(uint64 *)(u + 2),DAT_181d83f78);
        FUN_181814e80(uvs,CONCAT44(u[1],u[2]),DAT_181d83f78);
        if (*(char *)((int64)this + 0x19c) == false) {
          if (cols == null) goto LAB_180a7f086;
          local_58 = *c;
          lStack_50 = c[1];
          FUN_1818059b0(cols,&local_58,DAT_181d5b680);
          local_58 = *c;
          lStack_50 = c[1];
          FUN_1818059b0(cols,&local_58,DAT_181d5b680);
          local_58 = *c;
          lStack_50 = c[1];
          FUN_1818059b0(cols,&local_58,DAT_181d5b680);
          local_58 = *c;
          lStack_50 = c[1];
          goto LAB_180a7efe9;
        }
        lVar2 = (**(code **)(*this + 0x378))(&local_58,this,*(uint64 *)(*this + 0x380));
        fVar5 = *(float *)(lVar2 + 12);
        fVar4 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        local_68 = 0;
        uStack_60 = 0;
        uVar8 = 0;
        uVar6 = CONCAT44(uVar7,fVar4 * fVar5);
        FUN_1809981e0(&local_68);
        iVar1 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
        if (iVar1 == 0) {
        LAB_180a7eb92:
          local_58 = this[54];
          lStack_50 = this[55];
        }
        else {
          if (((((float)local_68 == 0.0) && (local_68._4_4_ == null.0)) && ((float)uStack_60 == 0.0)) &&
             (uStack_60._4_4_ == null.0)) goto LAB_180a7eb92;
          uStack_60 = this[53];
          uVar6 = 0;
          local_58 = this[54];
          lStack_50 = this[55];
          fVar5 = local_68._4_4_ / (float)(int)this[21];
          local_68 = this[52];
          plVar3 = (int64 *)Color.Lerp(local_48,&local_58,&local_68,fVar5,0,uVar8);
          local_58 = *plVar3;
          lStack_50 = plVar3[1];
        }
        local_68 = *c;
        uStack_60 = c[1];
        plVar3 = (int64 *)Color.op_Multiply(local_48,&local_68,&local_58,0,uVar6);
        uVar7 = (uint32)((uint64)uVar6 >> 32);
        if (cols == null) {
        LAB_180a7f086:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        local_58 = *plVar3;
        lStack_50 = plVar3[1];
        FUN_1818059b0(cols,&local_58,DAT_181d5b680);
        lVar2 = (**(code **)(*this + 0x378))(local_48,this,*(uint64 *)(*this + 0x380));
        fVar5 = *(float *)(lVar2 + 12);
        fVar4 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        uVar8 = 0;
        local_68 = 0;
        uStack_60 = 0;
        uVar6 = CONCAT44(uVar7,fVar4 * fVar5);
        FUN_1809981e0(&local_68);
        iVar1 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
        if (iVar1 == 0) {
        LAB_180a7ed00:
          local_58 = this[52];
          lStack_50 = this[53];
        }
        else {
          if ((((float)local_68 == 0.0) && (local_68._4_4_ == null.0)) &&
             (((float)uStack_60 == 0.0 && (uStack_60._4_4_ == null.0)))) goto LAB_180a7ed00;
          local_58 = this[54];
          lStack_50 = this[55];
          uVar6 = 0;
          local_68 = this[52];
          fVar5 = uStack_60._4_4_ / (float)(int)this[21];
          uStack_60 = this[53];
          plVar3 = (int64 *)Color.Lerp(local_48,&local_68,&local_58,fVar5,0,uVar8);
          local_58 = *plVar3;
          lStack_50 = plVar3[1];
        }
        local_68 = *c;
        uStack_60 = c[1];
        plVar3 = (int64 *)Color.op_Multiply(local_48,&local_68,&local_58,0,uVar6);
        uVar7 = (uint32)((uint64)uVar6 >> 32);
        local_58 = *plVar3;
        lStack_50 = plVar3[1];
        FUN_1818059b0(cols,&local_58,DAT_181d5b680);
        lVar2 = (**(code **)(*this + 0x378))(local_48,this,*(uint64 *)(*this + 0x380));
        fVar5 = *(float *)(lVar2 + 12);
        fVar4 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        uVar8 = 0;
        local_68 = 0;
        uStack_60 = 0;
        uVar6 = CONCAT44(uVar7,fVar4 * fVar5);
        FUN_1809981e0(&local_68);
        iVar1 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
        if (iVar1 == 0) {
        LAB_180a7ee60:
          local_58 = this[52];
          lStack_50 = this[53];
        }
        else {
          if ((((float)local_68 == 0.0) && (local_68._4_4_ == null.0)) &&
             (((float)uStack_60 == 0.0 && (uStack_60._4_4_ == null.0)))) goto LAB_180a7ee60;
          local_58 = this[54];
          lStack_50 = this[55];
          uVar6 = 0;
          local_68 = this[52];
          fVar5 = uStack_60._4_4_ / (float)(int)this[21];
          uStack_60 = this[53];
          plVar3 = (int64 *)Color.Lerp(local_48,&local_68,&local_58,fVar5,0,uVar8);
          local_58 = *plVar3;
          lStack_50 = plVar3[1];
        }
        local_68 = *c;
        uStack_60 = c[1];
        plVar3 = (int64 *)Color.op_Multiply(local_48,&local_68,&local_58,0,uVar6);
        uVar7 = (uint32)((uint64)uVar6 >> 32);
        local_58 = *plVar3;
        lStack_50 = plVar3[1];
        FUN_1818059b0(cols,&local_58,DAT_181d5b680);
        lVar2 = (**(code **)(*this + 0x378))(local_48,this,*(uint64 *)(*this + 0x380));
        fVar5 = *(float *)(lVar2 + 12);
        fVar4 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        uVar8 = 0;
        local_68 = 0;
        uStack_60 = 0;
        uVar6 = CONCAT44(uVar7,fVar4 * fVar5);
        FUN_1809981e0(&local_68);
        iVar1 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
        if (iVar1 == 0) {
        LAB_180a7efc0:
          local_58 = this[54];
          lStack_50 = this[55];
        }
        else {
          if (((((float)local_68 == 0.0) && (local_68._4_4_ == null.0)) && ((float)uStack_60 == 0.0)) &&
             (uStack_60._4_4_ == null.0)) goto LAB_180a7efc0;
          local_58 = this[52];
          lStack_50 = this[53];
          uVar6 = 0;
          uStack_60 = this[55];
          fVar5 = local_68._4_4_ / (float)(int)this[21];
          local_68 = this[54];
          plVar3 = (int64 *)Color.Lerp(local_48,&local_68,&local_58,fVar5,0,uVar8);
          local_58 = *plVar3;
          lStack_50 = plVar3[1];
        }
        local_68 = *c;
        uStack_60 = c[1];
        plVar3 = (int64 *)Color.op_Multiply(local_48,&local_68,&local_58,0,uVar6);
        local_58 = *plVar3;
        lStack_50 = plVar3[1];
        LAB_180a7efe9:
        FUN_1818059b0(cols,&local_58,DAT_181d5b680);
    }

    // Token : 0x6000463
    // RVA   : 0xA7F090   Offset: 0xA7D890   Length: 0xFAA
    protected void SlicedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color gc)
    {
        var pStatics = *(int64*)(DAT_181d8a358 + 184);
        void UIBasicSprite.SlicedFill
                     (int64 *this,int64 verts,int64 uvs,int64 cols,
                     uint32 *v,uint64 u,uint32 *gc)
        {
        int64 lVar1;
        int64 lVar2;
        int64 lVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        float fVar7;
        float *pfVar8;
        uint64 uVar9;
        uint32 uVar10;
        uint32 uVar11;
        int64 *plVar12;
        uint32 uVar13;
        int64 *plVar14;
        uint32 uVar15;
        int64 lVar16;
        uint32 uVar17;
        int64 lVar18;
        float fVar19;
        uint32 uVar20;
        uint64 in_stack_ffffffffffffff08;
        uint32 local_c8;
        uint32 local_c4;
        uint32 local_c0;
        uint32 local_b8;
        uint32 local_b4;
        uint32 local_b0;
        uint32 local_a8;
        uint32 local_a4;
        uint32 local_a0;
        uint64 local_98;
        uint64 uStack_90;
        uint32 local_88;
        uint32 uStack_84;
        uint32 uStack_80;
        uint32 uStack_7c;
        uVar20 = (uint32)((uint64)in_stack_ffffffffffffff08 >> 32);
        pfVar8 = (float *)(**(code **)(*this + 0x378))
                                    (&local_88,this,*(uint64 *)(*this + 0x380));
        fVar4 = *pfVar8;
        fVar5 = pfVar8[1];
        fVar6 = pfVar8[2];
        fVar7 = pfVar8[3];
        fVar19 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        local_98 = 0;
        uStack_90 = 0;
        FUN_1809981e0(&local_98,fVar4 * fVar19,fVar5 * fVar19,fVar6 * fVar19,
                      CONCAT44(uVar20,fVar7 * fVar19),0);
        fVar4 = (float)local_98;
        fVar7 = uStack_90._4_4_;
        fVar6 = (float)uStack_90;
        fVar5 = local_98._4_4_;
        if (((((float)local_98 == 0.0) && (local_98._4_4_ == null.0)) && ((float)uStack_90 == 0.0)) &&
           (uStack_90._4_4_ == null.0)) {
          UIBasicSprite.SimpleFill(this,verts,uvs,cols,v,u,gc,0);
          return;
        }
        lVar3 = *pStatics;
        if (lVar3 != null) {
          if (*(int *)(lVar3 + 24) == 0) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          *(uint32 *)(lVar3 + 32) = *v;
          lVar3 = *pStatics;
          if (lVar3 != null) {
            if (*(int *)(lVar3 + 24) == 0) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar9,0);
            }
            *(uint32 *)(lVar3 + 36) = v[1];
            lVar3 = *pStatics;
            if (lVar3 != null) {
              if (*(uint32 *)(lVar3 + 24) < 4) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar9,0);
              }
              *(uint32 *)(lVar3 + 56) = v[2];
              lVar3 = *pStatics;
              if (lVar3 != null) {
                if (*(uint32 *)(lVar3 + 24) < 4) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                *(uint32 *)(lVar3 + 60) = v[3];
                if (((int)this[51] - 1U & 0xfffffffd) == 0) {
                  lVar3 = *pStatics;
                  if (lVar3 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar3 + 24) == 0) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  if (*(uint32 *)(lVar3 + 24) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(float *)(lVar3 + 40) = fVar6 + *(float *)(lVar3 + 32);
                  lVar3 = *pStatics;
                  if (lVar3 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar3 + 24) < 4) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(float *)(lVar3 + 48) = *(float *)(lVar3 + 56) - fVar4;
                  lVar3 = *(int64 *)(pStatics + 8);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = FUN_180d904a0(this + 58,0);
                  if (*(uint32 *)(lVar3 + 24) < 4) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint32 *)(lVar3 + 56) = uVar20;
                  lVar3 = *(int64 *)(pStatics + 8);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = FUN_180d904a0(this + 56,0);
                  if (*(uint32 *)(lVar3 + 24) < 3) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint32 *)(lVar3 + 48) = uVar20;
                  lVar3 = *(int64 *)(pStatics + 8);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = Rect.get_xMax(this + 56,0);
                  if (*(uint32 *)(lVar3 + 24) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint32 *)(lVar3 + 40) = uVar20;
                  lVar3 = *(int64 *)(pStatics + 8);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = Rect.get_xMax(this + 58,0);
                  if (*(int *)(lVar3 + 24) == 0) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint32 *)(lVar3 + 32) = uVar20;
                }
                else {
                  lVar3 = *pStatics;
                  if (lVar3 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar3 + 24) == 0) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  if (*(uint32 *)(lVar3 + 24) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(float *)(lVar3 + 40) = fVar4 + *(float *)(lVar3 + 32);
                  lVar3 = *pStatics;
                  if (lVar3 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar3 + 24) < 4) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(float *)(lVar3 + 48) = *(float *)(lVar3 + 56) - fVar6;
                  lVar3 = *(int64 *)(pStatics + 8);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = FUN_180d904a0(this + 58,0);
                  if (*(int *)(lVar3 + 24) == 0) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint32 *)(lVar3 + 32) = uVar20;
                  lVar3 = *(int64 *)(pStatics + 8);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = FUN_180d904a0(this + 56,0);
                  if (*(uint32 *)(lVar3 + 24) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint32 *)(lVar3 + 40) = uVar20;
                  lVar3 = *(int64 *)(pStatics + 8);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = Rect.get_xMax(this + 56,0);
                  if (*(uint32 *)(lVar3 + 24) < 3) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint32 *)(lVar3 + 48) = uVar20;
                  lVar3 = *(int64 *)(pStatics + 8);
                  if (lVar3 == null) throw; // [null/range check failed]
                  uVar20 = Rect.get_xMax(this + 58,0);
                  if (*(uint32 *)(lVar3 + 24) < 4) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  *(uint32 *)(lVar3 + 56) = uVar20;
                }
                plVar14 = this + 56;
                plVar12 = this + 58;
                if ((int)this[51] - 2U < 2) {
                  lVar3 = *pStatics;
                  if (lVar3 != null) {
                    if (*(uint32 *)(lVar3 + 24) == 0) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    if (*(uint32 *)(lVar3 + 24) < 2) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    *(float *)(lVar3 + 44) = fVar7 + *(float *)(lVar3 + 36);
                    lVar3 = *pStatics;
                    if (lVar3 != null) {
                      if (*(uint32 *)(lVar3 + 24) < 4) {
                        uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar9,0);
                      }
                      *(float *)(lVar3 + 52) = *(float *)(lVar3 + 60) - fVar5;
                      lVar3 = *(int64 *)(pStatics + 8);
                      if (lVar3 != null) {
                        uVar20 = FUN_18044df60(plVar12,0);
                        if (*(uint32 *)(lVar3 + 24) < 4) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        *(uint32 *)(lVar3 + 60) = uVar20;
                        lVar3 = *(int64 *)(pStatics + 8);
                        if (lVar3 != null) {
                          uVar20 = FUN_18044df60(plVar14,0);
                          if (*(uint32 *)(lVar3 + 24) < 3) {
                            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar9,0);
                          }
                          *(uint32 *)(lVar3 + 52) = uVar20;
                          lVar3 = *(int64 *)(pStatics + 8);
                          if (lVar3 != null) {
                            uVar20 = Rect.get_yMax(plVar14,0);
                            if (*(uint32 *)(lVar3 + 24) < 2) {
                              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar9,0);
                            }
                            *(uint32 *)(lVar3 + 44) = uVar20;
                            lVar3 = *(int64 *)(pStatics + 8);
                            if (lVar3 != null) {
                              uVar20 = Rect.get_yMax(plVar12,0);
                              if (*(int *)(lVar3 + 24) == 0) {
                                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar9,0);
                              }
                              *(uint32 *)(lVar3 + 36) = uVar20;
                              goto LAB_180a7f8a0;
                            }
                          }
                        }
                      }
                    }
                  }
                }
                else {
                  lVar3 = *pStatics;
                  if (lVar3 != null) {
                    if (*(uint32 *)(lVar3 + 24) == 0) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    if (*(uint32 *)(lVar3 + 24) < 2) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    *(float *)(lVar3 + 44) = fVar5 + *(float *)(lVar3 + 36);
                    lVar3 = *pStatics;
                    if (lVar3 != null) {
                      if (*(uint32 *)(lVar3 + 24) < 4) {
                        uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar9,0);
                      }
                      *(float *)(lVar3 + 52) = *(float *)(lVar3 + 60) - fVar7;
                      lVar3 = *(int64 *)(pStatics + 8);
                      if (lVar3 != null) {
                        uVar20 = FUN_18044df60(plVar12,0);
                        if (*(int *)(lVar3 + 24) == 0) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar9,0);
                        }
                        *(uint32 *)(lVar3 + 36) = uVar20;
                        lVar3 = *(int64 *)(pStatics + 8);
                        if (lVar3 != null) {
                          uVar20 = FUN_18044df60(plVar14,0);
                          if (*(uint32 *)(lVar3 + 24) < 2) {
                            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar9,0);
                          }
                          *(uint32 *)(lVar3 + 44) = uVar20;
                          lVar3 = *(int64 *)(pStatics + 8);
                          if (lVar3 != null) {
                            uVar20 = Rect.get_yMax(plVar14,0);
                            if (*(uint32 *)(lVar3 + 24) < 3) {
                              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar9,0);
                            }
                            *(uint32 *)(lVar3 + 52) = uVar20;
                            lVar3 = *(int64 *)(pStatics + 8);
                            if (lVar3 != null) {
                              uVar20 = Rect.get_yMax(plVar12,0);
                              if (*(uint32 *)(lVar3 + 24) < 4) {
                                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar9,0);
                              }
                              *(uint32 *)(lVar3 + 60) = uVar20;
        LAB_180a7f8a0:
                              uVar11 = 0;
                              do {
                                uVar15 = uVar11 + 1;
                                uVar13 = 0;
                                do {
                                  if ((((int)this[60] != 0) || (uVar11 != 1)) || (uVar13 != 1)) {
                                    lVar3 = *pStatics;
                                    if (lVar3 == null) throw; // [null/range check failed]
                                    lVar18 = (int64)(int)uVar11;
                                    if (*(uint32 *)(lVar3 + 24) <= uVar11) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    if (*(uint32 *)(lVar3 + 24) <= uVar13) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    lVar16 = (int64)(int)uVar13;
                                    if (verts == null) throw; // [null/range check failed]
                                    local_c0 = 0;
                                    local_c8 = *(uint32 *)(lVar3 + 32 + lVar18 * 8);
                                    local_c4 = *(uint32 *)(lVar3 + 36 + lVar16 * 8);
                                    FUN_181805a40(verts,&local_c8,DAT_181d84278);
                                    lVar3 = *pStatics;
                                    if (lVar3 == null) throw; // [null/range check failed]
                                    if (*(uint32 *)(lVar3 + 24) <= uVar11) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    lVar1 = lVar16 + 1;
                                    uVar17 = (uint32)lVar1;
                                    if (*(uint32 *)(lVar3 + 24) <= uVar17) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    local_b8 = *(uint32 *)(lVar3 + 32 + lVar18 * 8);
                                    local_b4 = *(uint32 *)(lVar3 + 36 + lVar1 * 8);
                                    local_b0 = 0;
                                    FUN_181805a40(verts,&local_b8,DAT_181d84278);
                                    lVar3 = *pStatics;
                                    if (lVar3 == null) throw; // [null/range check failed]
                                    lVar2 = lVar18 + 1;
                                    uVar10 = (uint32)lVar2;
                                    if (*(uint32 *)(lVar3 + 24) <= uVar10) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    if (*(uint32 *)(lVar3 + 24) <= uVar17) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    local_a8 = *(uint32 *)(lVar3 + 32 + lVar2 * 8);
                                    local_a4 = *(uint32 *)(lVar3 + 36 + lVar1 * 8);
                                    local_a0 = 0;
                                    FUN_181805a40(verts,&local_a8,DAT_181d84278);
                                    lVar3 = *pStatics;
                                    if (lVar3 == null) throw; // [null/range check failed]
                                    if (*(uint32 *)(lVar3 + 24) <= uVar10) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    if (*(uint32 *)(lVar3 + 24) <= uVar13) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    local_98 = CONCAT44(*(uint32 *)(lVar3 + 36 + lVar16 * 8),
                                                        *(uint32 *)(lVar3 + 32 + lVar2 * 8));
                                    uStack_90 = uStack_90 & 0xffffffff00000000;
                                    FUN_181805a40(verts,&local_98,DAT_181d84278);
                                    lVar3 = *(int64 *)(pStatics + 8);
                                    if (lVar3 == null) throw; // [null/range check failed]
                                    if (*(uint32 *)(lVar3 + 24) <= uVar11) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    if (*(uint32 *)(lVar3 + 24) <= uVar13) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    if (uvs == null) throw; // [null/range check failed]
                                    FUN_181814e80(uvs,CONCAT44(*(uint32 *)
                                                                    (lVar3 + 36 + lVar16 * 8),
                                                                   *(uint32 *)
                                                                    (lVar3 + 32 + lVar18 * 8)),
                                                  DAT_181d83f78);
                                    lVar3 = *(int64 *)(pStatics + 8);
                                    if (lVar3 == null) throw; // [null/range check failed]
                                    if (*(uint32 *)(lVar3 + 24) <= uVar11) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    if (*(uint32 *)(lVar3 + 24) <= uVar17) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    FUN_181814e80(uvs,CONCAT44(*(uint32 *)
                                                                    (lVar3 + 36 + lVar1 * 8),
                                                                   *(uint32 *)
                                                                    (lVar3 + 32 + lVar18 * 8)),
                                                  DAT_181d83f78);
                                    lVar3 = *(int64 *)(pStatics + 8);
                                    if (lVar3 == null) throw; // [null/range check failed]
                                    if (*(uint32 *)(lVar3 + 24) <= uVar10) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    if (*(uint32 *)(lVar3 + 24) <= uVar17) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    FUN_181814e80(uvs,CONCAT44(*(uint32 *)
                                                                    (lVar3 + 36 + lVar1 * 8),
                                                                   *(uint32 *)
                                                                    (lVar3 + 32 + lVar2 * 8)),
                                                  DAT_181d83f78);
                                    lVar3 = *(int64 *)(pStatics + 8);
                                    if (lVar3 == null) throw; // [null/range check failed]
                                    if (*(uint32 *)(lVar3 + 24) <= uVar10) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    if (*(uint32 *)(lVar3 + 24) <= uVar13) {
                                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar9,0);
                                    }
                                    FUN_181814e80(uvs,CONCAT44(*(uint32 *)
                                                                    (lVar3 + 36 + lVar16 * 8),
                                                                   *(uint32 *)
                                                                    (lVar3 + 32 + lVar2 * 8)),
                                                  DAT_181d83f78);
                                    if (*(char *)((int64)this + 0x19c) == false) {
                                      if (cols == null) throw; // [null/range check failed]
                                      local_88 = *gc;
                                      uStack_84 = gc[1];
                                      uStack_80 = gc[2];
                                      uStack_7c = gc[3];
                                      FUN_1818059b0(cols,&local_88,DAT_181d5b680);
                                      local_88 = *gc;
                                      uStack_84 = gc[1];
                                      uStack_80 = gc[2];
                                      uStack_7c = gc[3];
                                      FUN_1818059b0(cols,&local_88,DAT_181d5b680);
                                      local_88 = *gc;
                                      uStack_84 = gc[1];
                                      uStack_80 = gc[2];
                                      uStack_7c = gc[3];
                                      FUN_1818059b0(cols,&local_88,DAT_181d5b680);
                                      local_88 = *gc;
                                      uStack_84 = gc[1];
                                      uStack_80 = gc[2];
                                      uStack_7c = gc[3];
                                      FUN_1818059b0(cols,&local_88,DAT_181d5b680);
                                    }
                                    else {
                                      UIBasicSprite.AddVertexColours
                                                (this,cols,gc,uVar11,uVar13,0);
                                      UIBasicSprite.AddVertexColours
                                                (this,cols,gc,uVar11,uVar13 + 1,0);
                                      UIBasicSprite.AddVertexColours
                                                (this,cols,gc,uVar15,uVar13 + 1,0);
                                      UIBasicSprite.AddVertexColours
                                                (this,cols,gc,uVar15,uVar13,0);
                                    }
                                  }
                                  uVar13 = uVar13 + 1;
                                } while ((int)uVar13 < 3);
                                uVar11 = uVar15;
                                if (2 < (int)uVar15) {
                                  return;
                                }
                              } while( true );
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000464
    // RVA   : 0xA7A800   Offset: 0xA79000   Length: 0x246
    private void AddVertexColours(List<Color> cols, ref Color color, int x, int y)
    {
        void UIBasicSprite.AddVertexColours
                     (int64 *this,int64 cols,int64 *color,uint64 x,int y)
        {
        float fVar1;
        float fVar2;
        float fVar3;
        int iVar4;
        float *pfVar5;
        int64 *plVar6;
        int64 *plVar7;
        float fVar8;
        float fVar9;
        uint64 in_stack_ffffffffffffffa8;
        uint32 uVar10;
        uint64 local_48;
        uint64 uStack_40;
        int64 local_38;
        int64 lStack_30;
        uint8 local_28 [32];
        uVar10 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        pfVar5 = (float *)(**(code **)(*this + 0x378))
                                    (&local_38,this,*(uint64 *)(*this + 0x380));
        fVar9 = *pfVar5;
        fVar1 = pfVar5[1];
        fVar2 = pfVar5[2];
        fVar3 = pfVar5[3];
        fVar8 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        local_48 = 0;
        uStack_40 = 0;
        FUN_1809981e0(&local_48,fVar9 * fVar8,fVar1 * fVar8,fVar2 * fVar8,CONCAT44(uVar10,fVar3 * fVar8),0
                     );
        iVar4 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
        if (iVar4 == 0) {
        LAB_180a7a9c2:
          if ((y == null) || (y == 1)) {
            local_38 = this[54];
            lStack_30 = this[55];
          }
          else {
            if (y != 2) {
        LAB_180a7a9d3:
              if (y != 3) {
                return;
              }
            }
            local_38 = this[52];
            lStack_30 = this[53];
          }
        }
        else {
          if (((((float)local_48 == 0.0) && (local_48._4_4_ == null.0)) && ((float)uStack_40 == 0.0)) &&
             (uStack_40._4_4_ == null.0)) goto LAB_180a7a9c2;
          if (y == null) {
            local_48 = this[54];
            uStack_40 = this[55];
            plVar6 = &local_48;
            local_38 = *color;
            lStack_30 = color[1];
            plVar7 = &local_38;
            goto LAB_180a7a9f2;
          }
          if (y != 1) {
            if (y == 2) {
              local_38 = this[54];
              lStack_30 = this[55];
              local_48 = this[52];
              fVar9 = uStack_40._4_4_ / (float)(int)this[21];
              uStack_40 = this[53];
              plVar6 = (int64 *)Color.Lerp(local_28,&local_48,&local_38,fVar9,0);
              local_38 = *plVar6;
              lStack_30 = plVar6[1];
              goto LAB_180a7a9df;
            }
            goto LAB_180a7a9d3;
          }
          local_38 = this[52];
          lStack_30 = this[53];
          uStack_40 = this[55];
          fVar9 = local_48._4_4_ / (float)(int)this[21];
          local_48 = this[54];
          plVar6 = (int64 *)Color.Lerp(local_28,&local_48,&local_38,fVar9,0);
          local_38 = *plVar6;
          lStack_30 = plVar6[1];
        }
        LAB_180a7a9df:
        local_48 = *color;
        uStack_40 = color[1];
        plVar6 = &local_38;
        plVar7 = &local_48;
        LAB_180a7a9f2:
        plVar6 = (int64 *)Color.op_Multiply(local_28,plVar7,plVar6,0);
        if (cols != null) {
          local_38 = *plVar6;
          lStack_30 = plVar6[1];
          FUN_1818059b0(cols,&local_38,DAT_181d5b680);
          return;
        }
    }

    // Token : 0x6000465
    // RVA   : 0xA80040   Offset: 0xA7E840   Length: 0x69A
    protected void TiledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Color c)
    {
        void UIBasicSprite.TiledFill
                     (int64 *this,int64 verts,int64 uvs,int64 cols,float *v,
                     uint32 *c)
        {
        int64 *plVar1;
        char cVar2;
        int iVar3;
        int iVar4;
        int64 *plVar5;
        float *pfVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        uint32 uVar10;
        uint32 uVar11;
        uint32 uVar12;
        uint32 uVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        float fVar17;
        uint32 local_res8;
        float local_138;
        float fStack_134;
        float fStack_130;
        float fStack_12c;
        float local_128;
        uint32 local_124;
        float local_120;
        float local_11c;
        uint32 local_118;
        uint32 uStack_114;
        uint32 uStack_110;
        uint32 uStack_10c;
        float local_108;
        uint32 local_100;
        uint32 uStack_fc;
        float local_f8;
        float local_f4;
        uint32 local_f0;
        float local_e8;
        float local_e4;
        uint32 local_e0;
        float local_d8;
        float local_d4;
        uint32 local_d0;
        plVar5 = (int64 *)(**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
        cVar2 = Object.op_Equality(plVar5,0,0);
        if (!cVar2) {
          plVar1 = this + 56;
          fVar7 = (float)FUN_180d90480(plVar1,0);
          if (plVar5 == (int64 *)0) {
        LAB_180a806d5:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar3 = (**(code **)(*plVar5 + 0x178))(plVar5,*(uint64 *)(*plVar5 + 0x180));
          fVar8 = (float)FUN_18044e2b0(plVar1,0);
          iVar4 = (**(code **)(*plVar5 + 0x198))(plVar5,*(uint64 *)(*plVar5 + 0x1a0));
          fVar9 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
          fVar8 = (float)iVar4 * fVar8 * fVar9;
          fVar9 = (float)iVar3 * fVar7 * fVar9;
          if ((2.0 <= fVar9) && (2.0 <= fVar8)) {
            local_108 = fVar8;
            pfVar6 = (float *)(**(code **)(*this + 1000))
                                        (&local_118,this,*(uint64 *)(*this + 0x3f0));
            local_138 = *pfVar6;
            fStack_134 = pfVar6[1];
            fStack_130 = pfVar6[2];
            fStack_12c = pfVar6[3];
            if (((int)this[51] - 1U & 0xfffffffd) == 0) {
              uVar10 = Rect.get_xMax(plVar1,0);
              uVar11 = FUN_180d904a0(plVar1,0);
              fVar7 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              fVar7 = fVar7 * fStack_130;
              local_128 = (float)(**(code **)(*this + 0x3d8))
                                           (this,*(uint64 *)(*this + 0x3e0));
              local_128 = local_128 * local_138;
            }
            else {
              uVar10 = FUN_180d904a0();
              uVar11 = Rect.get_xMax(plVar1,0);
              fVar7 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              fVar7 = fVar7 * local_138;
              local_128 = (float)(**(code **)(*this + 0x3d8))
                                           (this,*(uint64 *)(*this + 0x3e0));
              local_128 = local_128 * fStack_130;
            }
            if ((int)this[51] - 2U < 2) {
              uVar12 = Rect.get_yMax(plVar1,0);
              uVar13 = FUN_18044df60(plVar1,0);
              local_124 = uVar13;
              fVar14 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              fVar14 = fVar14 * fStack_12c;
              local_11c = fVar14;
              local_120 = (float)(**(code **)(*this + 0x3d8))
                                           (this,*(uint64 *)(*this + 0x3e0));
              local_120 = local_120 * fStack_134;
            }
            else {
              uVar12 = FUN_18044df60();
              uVar13 = Rect.get_yMax(plVar1,0);
              local_124 = uVar13;
              fVar14 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              fVar14 = fVar14 * fStack_134;
              local_11c = fVar14;
              local_120 = (float)(**(code **)(*this + 0x3d8))
                                           (this,*(uint64 *)(*this + 0x3e0));
              local_120 = local_120 * fStack_12c;
            }
            fVar16 = v[1];
            fVar15 = v[3];
            if (fVar16 < fVar15) {
              do {
                fVar16 = fVar16 + fVar14;
                fVar14 = *v;
                fVar17 = fVar8 + fVar16;
                local_res8 = uVar13;
                if (fVar15 < fVar17) {
                  local_res8 = Mathf.Lerp(uVar12,uVar13,(fVar15 - fVar16) / fVar8,0);
                  fVar17 = v[3];
                }
                fVar15 = v[2];
                if (fVar14 < fVar15) {
                  do {
                    fVar14 = fVar14 + fVar7;
                    fVar8 = fVar9 + fVar14;
                    uVar13 = uVar11;
                    if (fVar15 < fVar8) {
                      uVar13 = Mathf.Lerp(uVar10,uVar11,(fVar15 - fVar14) / fVar9,0);
                      fVar8 = v[2];
                    }
                    if (verts == null) goto LAB_180a806d5;
                    local_f0 = 0;
                    local_f8 = fVar14;
                    local_f4 = fVar16;
                    FUN_181805a40(verts,&local_f8,DAT_181d84278);
                    local_e0 = 0;
                    local_e8 = fVar14;
                    local_e4 = fVar17;
                    FUN_181805a40(verts,&local_e8,DAT_181d84278);
                    local_d0 = 0;
                    local_d8 = fVar8;
                    local_d4 = fVar17;
                    FUN_181805a40(verts,&local_d8,DAT_181d84278);
                    fStack_130 = 0.0;
                    local_138 = fVar8;
                    fStack_134 = fVar16;
                    FUN_181805a40(verts,&local_138,DAT_181d84278);
                    local_100 = uVar10;
                    uStack_fc = uVar12;
                    if (uvs == null) goto LAB_180a806d5;
                    FUN_181814e80(uvs,CONCAT44(uVar12,uVar10),DAT_181d83f78);
                    FUN_181814e80(uvs,CONCAT44(local_res8,uVar10),DAT_181d83f78);
                    FUN_181814e80(uvs,CONCAT44(local_res8,uVar13),DAT_181d83f78);
                    FUN_181814e80(uvs,CONCAT44(uVar12,uVar13),DAT_181d83f78);
                    if (cols == null) goto LAB_180a806d5;
                    local_118 = *c;
                    uStack_114 = c[1];
                    uStack_110 = c[2];
                    uStack_10c = c[3];
                    FUN_1818059b0(cols,&local_118,DAT_181d5b680);
                    local_118 = *c;
                    uStack_114 = c[1];
                    uStack_110 = c[2];
                    uStack_10c = c[3];
                    FUN_1818059b0(cols,&local_118,DAT_181d5b680);
                    local_118 = *c;
                    uStack_114 = c[1];
                    uStack_110 = c[2];
                    uStack_10c = c[3];
                    FUN_1818059b0(cols,&local_118,DAT_181d5b680);
                    local_118 = *c;
                    uStack_114 = c[1];
                    uStack_110 = c[2];
                    uStack_10c = c[3];
                    FUN_1818059b0(cols,&local_118,DAT_181d5b680);
                    fVar15 = v[2];
                    fVar14 = fVar14 + local_128 + fVar9;
                    uVar13 = local_124;
                    fVar8 = local_108;
                  } while (fVar14 < fVar15);
                }
                fVar15 = v[3];
                fVar16 = fVar16 + local_120 + fVar8;
                fVar14 = local_11c;
              } while (fVar16 < fVar15);
            }
          }
        }
    }

    // Token : 0x6000466
    // RVA   : 0xA7CA90   Offset: 0xA7B290   Length: 0x16DE
    protected void FilledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
    {
        var pStatics = *(int64*)(DAT_181d8a358 + 184);
        void UIBasicSprite.FilledFill
                     (int64 this,int64 verts,int64 uvs,int64 cols,float *v,
                     float *u,uint64 *c)
        {
        uint8 uVar1;
        int64 lVar2;
        uint64 uVar3;
        char cVar4;
        uint64 uVar5;
        uint32 uVar6;
        uint32 uVar7;
        int64 lVar8;
        int iVar9;
        float fVar10;
        uint32 uVar11;
        float fVar12;
        uint32 uVar13;
        uint32 uVar14;
        uint32 uVar15;
        uint32 uVar16;
        uint64 local_res8;
        int local_e8;
        uint64 local_c8;
        uint32 local_c0;
        uint64 local_b8;
        uint64 uStack_b0;
        fVar10 = *(float *)(this + 400);
        if (fVar10 < 0.001) {
          return;
        }
        if (this.mFillDirection == null) {
          fVar12 = (u[2] - *u) * fVar10;
          fVar10 = (v[2] - *v) * fVar10;
          if (!this.mInvert) {
            v[2] = fVar10 + *v;
            u[2] = fVar12 + *u;
          }
          else {
            *v = v[2] - fVar10;
            *u = u[2] - fVar12;
          }
        }
        else if (this.mFillDirection == 1) {
          fVar12 = (u[3] - u[1]) * fVar10;
          fVar10 = (v[3] - v[1]) * fVar10;
          if (!this.mInvert) {
            v[3] = fVar10 + v[1];
            u[3] = fVar12 + u[1];
          }
          else {
            v[1] = v[3] - fVar10;
            u[1] = u[3] - fVar12;
          }
        }
        fVar10 = v[1];
        lVar2 = *pStatics;
        if (lVar2 != null) {
          if (*(int *)(lVar2 + 24) == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(float *)(lVar2 + 32) = *v;
          *(float *)(lVar2 + 36) = fVar10;
          fVar10 = v[3];
          lVar2 = *pStatics;
          if (lVar2 != null) {
            if (*(uint32 *)(lVar2 + 24) < 2) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            *(float *)(lVar2 + 40) = *v;
            *(float *)(lVar2 + 44) = fVar10;
            fVar10 = v[3];
            lVar2 = *pStatics;
            if (lVar2 != null) {
              if (*(uint32 *)(lVar2 + 24) < 3) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              *(float *)(lVar2 + 48) = v[2];
              *(float *)(lVar2 + 52) = fVar10;
              fVar10 = v[1];
              lVar2 = *pStatics;
              if (lVar2 != null) {
                if (*(uint32 *)(lVar2 + 24) < 4) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                *(float *)(lVar2 + 56) = v[2];
                *(float *)(lVar2 + 60) = fVar10;
                fVar10 = u[1];
                lVar2 = *(int64 *)(pStatics + 8);
                if (lVar2 != null) {
                  if (*(int *)(lVar2 + 24) == 0) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  *(float *)(lVar2 + 32) = *u;
                  *(float *)(lVar2 + 36) = fVar10;
                  fVar10 = u[3];
                  lVar2 = *(int64 *)(pStatics + 8);
                  if (lVar2 != null) {
                    if (*(uint32 *)(lVar2 + 24) < 2) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                    *(float *)(lVar2 + 40) = *u;
                    *(float *)(lVar2 + 44) = fVar10;
                    fVar10 = u[3];
                    lVar2 = *(int64 *)(pStatics + 8);
                    if (lVar2 != null) {
                      if (*(uint32 *)(lVar2 + 24) < 3) {
                        uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar5,0);
                      }
                      *(float *)(lVar2 + 48) = u[2];
                      *(float *)(lVar2 + 52) = fVar10;
                      fVar10 = u[1];
                      lVar2 = *(int64 *)(pStatics + 8);
                      if (lVar2 != null) {
                        if (*(uint32 *)(lVar2 + 24) < 4) {
                          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar5,0);
                        }
                        *(float *)(lVar2 + 56) = u[2];
                        *(float *)(lVar2 + 60) = fVar10;
                        fVar10 = *(float *)(this + 400);
                        if (fVar10 < 1.0) {
                          iVar9 = this.mFillDirection;
                          if (iVar9 == 2) {
                            if (((*(byte *)(DAT_181d8a358 + 0x133) & 4) != 0) &&
                               (*(int *)(DAT_181d8a358 + 224) == 0)) {
                              il2cpp_runtime_class_init(DAT_181d8a358);
                              fVar10 = *(float *)(this + 400);
                            }
                            uVar6 = 0;
                            cVar4 = UIBasicSprite.RadialCut
                                              (**(uint64 **)(DAT_181d8a358 + 184),
                                               (*(uint64 **)(DAT_181d8a358 + 184))[1],fVar10,
                                               this.mInvert,0,0);
                            if (!cVar4) {
                              return;
                            }
                            while( true ) {
                              lVar2 = *pStatics;
                              if (lVar2 == null) break;
                              lVar8 = (int64)(int)uVar6;
                              if (*(uint32 *)(lVar2 + 24) <= uVar6) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (verts == null) break;
                              local_c8 = CONCAT44(*(uint32 *)(lVar2 + 36 + lVar8 * 8),
                                                  *(uint32 *)(lVar2 + 32 + lVar8 * 8));
                              local_c0 = 0;
                              FUN_181805a40(verts,&local_c8,DAT_181d84278);
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) break;
                              if (*(uint32 *)(lVar2 + 24) <= uVar6) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              local_res8 = CONCAT44(*(uint32 *)(lVar2 + 36 + lVar8 * 8),
                                                    *(uint32 *)(lVar2 + 32 + lVar8 * 8));
                              if ((uvs == null) ||
                                 (FUN_181814e80(uvs,local_res8,DAT_181d83f78), cols == null)) break;
                              local_b8 = *c;
                              uStack_b0 = c[1];
                              FUN_1818059b0(cols,&local_b8,DAT_181d5b680);
                              uVar6 = uVar6 + 1;
                              if (3 < (int)uVar6) {
                                return;
                              }
                            }
                            throw; // [null/range check failed]
                          }
                          if (iVar9 == 3) {
                            uVar6 = 0;
                            while( true ) {
                              if (uVar6 == 0) {
                                uVar13 = 0;
                                uVar14 = 0x3f000000;
                              }
                              else {
                                uVar13 = 0x3f000000;
                                uVar14 = 0x3f800000;
                              }
                              lVar2 = *pStatics;
                              if (lVar2 == null) break;
                              uVar15 = Mathf.Lerp();
                              if (*(int *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 32) = uVar15;
                              lVar2 = *pStatics;
                              if (lVar2 == null) break;
                              if (*(uint32 *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 40) = *(uint32 *)(lVar2 + 32);
                              lVar2 = *pStatics;
                              if (lVar2 == null) break;
                              uVar15 = Mathf.Lerp(pStatics,v[2],uVar14,
                                                   0);
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 48) = uVar15;
                              lVar2 = *pStatics;
                              if (lVar2 == null) break;
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 4) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 56) = *(uint32 *)(lVar2 + 48);
                              lVar2 = *pStatics;
                              if (lVar2 == null) break;
                              uVar15 = Mathf.Lerp(pStatics,v[3],0,0);
                              if (*(int *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 36) = uVar15;
                              lVar2 = *pStatics;
                              if (lVar2 == null) break;
                              uVar15 = Mathf.Lerp(pStatics,v[3],
                                                   0x3f800000,0);
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 44) = uVar15;
                              lVar2 = *pStatics;
                              if (lVar2 == null) break;
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 52) = *(uint32 *)(lVar2 + 44);
                              lVar2 = *pStatics;
                              if (lVar2 == null) break;
                              if (*(uint32 *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 4) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 60) = *(uint32 *)(lVar2 + 36);
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) break;
                              uVar13 = Mathf.Lerp(pStatics,u[2],uVar13,0
                                                  );
                              if (*(int *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 32) = uVar13;
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) break;
                              if (*(uint32 *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 40) = *(uint32 *)(lVar2 + 32);
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) break;
                              uVar13 = Mathf.Lerp(pStatics,u[2],uVar14,0
                                                  );
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 48) = uVar13;
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) break;
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 4) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 56) = *(uint32 *)(lVar2 + 48);
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) break;
                              uVar13 = Mathf.Lerp(pStatics,u[3],0,0);
                              if (*(int *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 36) = uVar13;
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) break;
                              uVar13 = Mathf.Lerp(pStatics,u[3],
                                                   0x3f800000,0);
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 44) = uVar13;
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) break;
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 52) = *(uint32 *)(lVar2 + 44);
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) break;
                              if (*(uint32 *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 4) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 60) = *(uint32 *)(lVar2 + 36);
                              uVar5 = **(uint64 **)(DAT_181d8a358 + 184);
                              uVar3 = (*(uint64 **)(DAT_181d8a358 + 184))[1];
                              uVar14 = Mathf.Clamp01();
                              cVar4 = this.mInvert;
                              uVar13 = NGUIMath.RepeatIndex(uVar6 + 3,4);
                              cVar4 = UIBasicSprite.RadialCut(uVar5,uVar3,uVar14,!cVar4,uVar13,0);
                              uVar7 = 0;
                              if (cVar4) {
                                do {
                                  lVar2 = *pStatics;
                                  if (lVar2 == null) throw; // [null/range check failed]
                                  lVar8 = (int64)(int)uVar7;
                                  if (*(uint32 *)(lVar2 + 24) <= uVar7) {
                                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar5,0);
                                  }
                                  if (verts == null) throw; // [null/range check failed]
                                  local_c8 = CONCAT44(*(uint32 *)(lVar2 + 36 + lVar8 * 8),
                                                      *(uint32 *)(lVar2 + 32 + lVar8 * 8));
                                  local_c0 = 0;
                                  FUN_181805a40(verts,&local_c8,DAT_181d84278);
                                  lVar2 = *(int64 *)(pStatics + 8);
                                  if (lVar2 == null) throw; // [null/range check failed]
                                  if (*(uint32 *)(lVar2 + 24) <= uVar7) {
                                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar5,0);
                                  }
                                  if ((uvs == null) ||
                                     (FUN_181814e80(uvs,CONCAT44(*(uint32 *)
                                                                      (lVar2 + 36 + lVar8 * 8),
                                                                     *(uint32 *)
                                                                      (lVar2 + 32 + lVar8 * 8)),
                                                    DAT_181d83f78), cols == null)) throw; // [null/range check failed]
                                  local_b8 = *c;
                                  uStack_b0 = c[1];
                                  FUN_1818059b0(cols);
                                  uVar7 = uVar7 + 1;
                                } while ((int)uVar7 < 4);
                              }
                              uVar6 = uVar6 + 1;
                              if (1 < (int)uVar6) {
                                return;
                              }
                            }
                            throw; // [null/range check failed]
                          }
                          if (iVar9 == 4) {
                            local_e8 = 0;
                            do {
                              if (local_e8 < 2) {
                                uVar13 = 0;
                                uVar14 = 0x3f000000;
                                if (local_e8 != 0) goto LAB_180a7ce90;
        LAB_180a7ce9f:
                                uVar15 = 0;
                                uVar16 = 0x3f000000;
                              }
                              else {
                                uVar13 = 0x3f000000;
                                uVar14 = 0x3f800000;
        LAB_180a7ce90:
                                if (local_e8 == 3) goto LAB_180a7ce9f;
                                uVar15 = 0x3f000000;
                                uVar16 = 0x3f800000;
                              }
                              lVar2 = *pStatics;
                              if (lVar2 == null) throw; // [null/range check failed]
                              uVar11 = Mathf.Lerp();
                              if (*(int *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 32) = uVar11;
                              lVar2 = *pStatics;
                              if (lVar2 == null) throw; // [null/range check failed]
                              if (*(uint32 *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 40) = *(uint32 *)(lVar2 + 32);
                              lVar2 = *pStatics;
                              if (lVar2 == null) throw; // [null/range check failed]
                              uVar11 = Mathf.Lerp(pStatics,v[2],uVar14,
                                                   0);
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 48) = uVar11;
                              lVar2 = *pStatics;
                              if (lVar2 == null) throw; // [null/range check failed]
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 4) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 56) = *(uint32 *)(lVar2 + 48);
                              lVar2 = *pStatics;
                              if (lVar2 == null) throw; // [null/range check failed]
                              uVar11 = Mathf.Lerp(pStatics,v[3],uVar15,
                                                   0);
                              if (*(int *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 36) = uVar11;
                              lVar2 = *pStatics;
                              if (lVar2 == null) throw; // [null/range check failed]
                              uVar11 = Mathf.Lerp(pStatics,v[3],uVar16,
                                                   0);
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 44) = uVar11;
                              lVar2 = *pStatics;
                              if (lVar2 == null) throw; // [null/range check failed]
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 52) = *(uint32 *)(lVar2 + 44);
                              lVar2 = *pStatics;
                              if (lVar2 == null) throw; // [null/range check failed]
                              if (*(uint32 *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 4) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 60) = *(uint32 *)(lVar2 + 36);
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) throw; // [null/range check failed]
                              uVar13 = Mathf.Lerp(pStatics,u[2],uVar13,0
                                                  );
                              if (*(int *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 32) = uVar13;
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) throw; // [null/range check failed]
                              if (*(uint32 *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 40) = *(uint32 *)(lVar2 + 32);
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) throw; // [null/range check failed]
                              uVar13 = Mathf.Lerp(pStatics,u[2],uVar14,0
                                                  );
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 48) = uVar13;
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) throw; // [null/range check failed]
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 4) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 56) = *(uint32 *)(lVar2 + 48);
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) throw; // [null/range check failed]
                              uVar13 = Mathf.Lerp(pStatics,u[3],uVar15,0
                                                  );
                              if (*(int *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 36) = uVar13;
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) throw; // [null/range check failed]
                              uVar13 = Mathf.Lerp(pStatics,u[3],uVar16,0
                                                  );
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 44) = uVar13;
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) throw; // [null/range check failed]
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              *(uint32 *)(lVar2 + 52) = *(uint32 *)(lVar2 + 44);
                              lVar2 = *(int64 *)(pStatics + 8);
                              if (lVar2 == null) throw; // [null/range check failed]
                              if (*(uint32 *)(lVar2 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(lVar2 + 24) < 4) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              iVar9 = local_e8 + 2;
                              *(uint32 *)(lVar2 + 60) = *(uint32 *)(lVar2 + 36);
                              if (!this.mInvert) {
                                NGUIMath.RepeatIndex(iVar9,4);
                              }
                              else {
                                NGUIMath.RepeatIndex(iVar9,4);
                              }
                              uVar5 = **(uint64 **)(DAT_181d8a358 + 184);
                              uVar3 = (*(uint64 **)(DAT_181d8a358 + 184))[1];
                              uVar14 = Mathf.Clamp01();
                              uVar1 = this.mInvert;
                              uVar13 = NGUIMath.RepeatIndex(iVar9,4);
                              cVar4 = UIBasicSprite.RadialCut(uVar5,uVar3,uVar14,uVar1,uVar13,0);
                              uVar6 = 0;
                              if (cVar4) {
                                do {
                                  lVar2 = *pStatics;
                                  if (lVar2 == null) throw; // [null/range check failed]
                                  lVar8 = (int64)(int)uVar6;
                                  if (*(uint32 *)(lVar2 + 24) <= uVar6) {
                                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar5,0);
                                  }
                                  if (verts == null) throw; // [null/range check failed]
                                  local_c8 = CONCAT44(*(uint32 *)(lVar2 + 36 + lVar8 * 8),
                                                      *(uint32 *)(lVar2 + 32 + lVar8 * 8));
                                  local_c0 = 0;
                                  FUN_181805a40(verts,&local_c8,DAT_181d84278);
                                  lVar2 = *(int64 *)(pStatics + 8);
                                  if (lVar2 == null) throw; // [null/range check failed]
                                  if (*(uint32 *)(lVar2 + 24) <= uVar6) {
                                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar5,0);
                                  }
                                  if ((uvs == null) ||
                                     (FUN_181814e80(uvs,CONCAT44(*(uint32 *)
                                                                      (lVar2 + 36 + lVar8 * 8),
                                                                     *(uint32 *)
                                                                      (lVar2 + 32 + lVar8 * 8)),
                                                    DAT_181d83f78), cols == null)) throw; // [null/range check failed]
                                  local_b8 = *c;
                                  uStack_b0 = c[1];
                                  FUN_1818059b0(cols);
                                  uVar6 = uVar6 + 1;
                                } while ((int)uVar6 < 4);
                              }
                              local_e8 = local_e8 + 1;
                              if (3 < local_e8) {
                                return;
                              }
                            } while( true );
                          }
                        }
                        uVar6 = 0;
                        while( true ) {
                          lVar2 = *pStatics;
                          if (lVar2 == null) break;
                          lVar8 = (int64)(int)uVar6;
                          if (*(uint32 *)(lVar2 + 24) <= uVar6) {
                            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar5,0);
                          }
                          if (verts == null) break;
                          local_c8 = CONCAT44(*(uint32 *)(lVar2 + 36 + lVar8 * 8),
                                              *(uint32 *)(lVar2 + 32 + lVar8 * 8));
                          local_c0 = 0;
                          FUN_181805a40(verts,&local_c8,DAT_181d84278);
                          lVar2 = *(int64 *)(pStatics + 8);
                          if (lVar2 == null) break;
                          if (*(uint32 *)(lVar2 + 24) <= uVar6) {
                            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar5,0);
                          }
                          local_res8 = CONCAT44(*(uint32 *)(lVar2 + 36 + lVar8 * 8),
                                                *(uint32 *)(lVar2 + 32 + lVar8 * 8));
                          if ((uvs == null) ||
                             (FUN_181814e80(uvs,local_res8,DAT_181d83f78), cols == null)) break;
                          local_b8 = *c;
                          uStack_b0 = c[1];
                          FUN_1818059b0(cols,&local_b8,DAT_181d5b680);
                          uVar6 = uVar6 + 1;
                          if (3 < (int)uVar6) {
                            return;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000467
    // RVA   : 0xA7AA50   Offset: 0xA79250   Length: 0x1B8A
    protected void AdvancedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, ref Vector4 v, ref Vector4 u, ref Color c)
    {
        var plVar12 = *(int64*)(lVar12 + 184);
        var pStatics = *(int64*)(DAT_181d8a358 + 184);
        void UIBasicSprite.AdvancedFill
                     (int64 *this,uint64 verts,uint64 uvs,uint64 cols,
                     uint32 *v,uint64 u,uint64 *c)
        {
        int64 *plVar1;
        float fVar2;
        float fVar3;
        uint32 uVar4;
        int64 lVar5;
        uint64 uVar6;
        uint64 uVar7;
        char cVar8;
        int iVar9;
        int iVar10;
        int64 *plVar11;
        int64 lVar12;
        int64 lVar13;
        uint32 uVar14;
        uint32 uVar15;
        int64 lVar16;
        int64 lVar17;
        int64 lVar18;
        int64 lVar19;
        float fVar20;
        float fVar21;
        uint32 uVar22;
        uint32 uVar23;
        uint32 uVar24;
        uint32 uVar25;
        uint32 uVar26;
        uint32 uVar27;
        uint32 uVar28;
        float fVar29;
        float fVar30;
        float fVar31;
        float fVar32;
        float fVar33;
        float local_res8;
        uint64 in_stack_fffffffffffffeb8;
        uint64 uVar34;
        uint32 uVar35;
        uint64 in_stack_fffffffffffffec8;
        uint64 in_stack_fffffffffffffed0;
        uint32 uVar36;
        uint32 uVar37;
        float local_f8;
        uint64 local_d8;
        uint64 uStack_d0;
        uVar15 = (uint32)((uint64)in_stack_fffffffffffffeb8 >> 32);
        plVar11 = (int64 *)(**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
        cVar8 = Object.op_Equality(plVar11,0,0);
        if (!cVar8) {
          (**(code **)(*this + 0x378))(&local_d8,this,*(uint64 *)(*this + 0x380));
          (**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
          uVar34 = 0;
          local_d8 = 0;
          uStack_d0 = 0;
          lVar13 = (uint64)uVar15 << 32;
          FUN_1809981e0(&local_d8);
          fVar2 = (float)local_d8;
          fVar31 = uStack_d0._4_4_;
          fVar29 = (float)uStack_d0;
          fVar3 = local_d8._4_4_;
          if (((((float)local_d8 != 0.0) || (local_d8._4_4_ != null.0)) || ((float)uStack_d0 != 0.0)) ||
             (uStack_d0._4_4_ != null.0)) {
            plVar1 = this + 56;
            fVar20 = (float)FUN_180d90480(plVar1,0);
            if (plVar11 != (int64 *)0) {
              iVar9 = (**(code **)(*plVar11 + 0x178))(plVar11,*(uint64 *)(*plVar11 + 0x180));
              fVar21 = (float)FUN_18044e2b0(plVar1,0);
              iVar10 = (**(code **)(*plVar11 + 0x198))(plVar11,*(uint64 *)(*plVar11 + 0x1a0));
              local_res8 = (float)(**(code **)(*this + 0x3d8))
                                            (this,*(uint64 *)(*this + 0x3e0));
              local_f8 = (float)iVar10 * fVar21 * local_res8;
              local_res8 = (float)iVar9 * fVar20 * local_res8;
              if (local_res8 < 1.0) {
                local_res8 = 1.0;
              }
              if (local_f8 < 1.0) {
                local_f8 = 1.0;
              }
              lVar12 = *pStatics;
              if (lVar12 != null) {
                if (*(int *)(lVar12 + 24) == 0) {
                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar34,0);
                }
                *(uint32 *)(lVar12 + 32) = *v;
                lVar12 = *pStatics;
                if (lVar12 != null) {
                  if (*(int *)(lVar12 + 24) == 0) {
                    uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar34,0);
                  }
                  *(uint32 *)(lVar12 + 36) = v[1];
                  lVar12 = *pStatics;
                  if (lVar12 != null) {
                    if (*(uint32 *)(lVar12 + 24) < 4) {
                      uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar34,0);
                    }
                    *(uint32 *)(lVar12 + 56) = v[2];
                    lVar12 = *pStatics;
                    if (lVar12 != null) {
                      if (*(uint32 *)(lVar12 + 24) < 4) {
                        uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar34,0);
                      }
                      *(uint32 *)(lVar12 + 60) = v[3];
                      if (((int)this[51] - 1U & 0xfffffffd) == 0) {
                        lVar12 = *pStatics;
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        if (*(uint32 *)(lVar12 + 24) == 0) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        if (*(uint32 *)(lVar12 + 24) < 2) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(float *)(lVar12 + 40) = fVar29 + *(float *)(lVar12 + 32);
                        lVar12 = *pStatics;
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        if (*(uint32 *)(lVar12 + 24) < 4) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(float *)(lVar12 + 48) = *(float *)(lVar12 + 56) - fVar2;
                        lVar12 = *(int64 *)(pStatics + 8);
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        uVar22 = FUN_180d904a0(this + 58,0);
                        if (*(uint32 *)(lVar12 + 24) < 4) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(uint32 *)(lVar12 + 56) = uVar22;
                        lVar12 = *(int64 *)(pStatics + 8);
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        uVar22 = FUN_180d904a0(plVar1,0);
                        if (*(uint32 *)(lVar12 + 24) < 3) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(uint32 *)(lVar12 + 48) = uVar22;
                        lVar12 = *(int64 *)(pStatics + 8);
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        uVar22 = Rect.get_xMax(plVar1,0);
                        if (*(uint32 *)(lVar12 + 24) < 2) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(uint32 *)(lVar12 + 40) = uVar22;
                        lVar12 = *(int64 *)(pStatics + 8);
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        uVar22 = Rect.get_xMax(this + 58,0);
                        if (*(int *)(lVar12 + 24) == 0) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(uint32 *)(lVar12 + 32) = uVar22;
                      }
                      else {
                        lVar12 = *pStatics;
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        if (*(uint32 *)(lVar12 + 24) == 0) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        if (*(uint32 *)(lVar12 + 24) < 2) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(float *)(lVar12 + 40) = fVar2 + *(float *)(lVar12 + 32);
                        lVar12 = *pStatics;
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        if (*(uint32 *)(lVar12 + 24) < 4) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(float *)(lVar12 + 48) = *(float *)(lVar12 + 56) - fVar29;
                        lVar12 = *(int64 *)(pStatics + 8);
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        uVar22 = FUN_180d904a0(this + 58,0);
                        if (*(int *)(lVar12 + 24) == 0) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(uint32 *)(lVar12 + 32) = uVar22;
                        lVar12 = *(int64 *)(pStatics + 8);
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        uVar22 = FUN_180d904a0(plVar1,0);
                        if (*(uint32 *)(lVar12 + 24) < 2) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(uint32 *)(lVar12 + 40) = uVar22;
                        lVar12 = *(int64 *)(pStatics + 8);
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        uVar22 = Rect.get_xMax(plVar1,0);
                        if (*(uint32 *)(lVar12 + 24) < 3) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(uint32 *)(lVar12 + 48) = uVar22;
                        lVar12 = *(int64 *)(pStatics + 8);
                        if (lVar12 == null) goto LAB_180a7c5d5;
                        uVar22 = Rect.get_xMax(this + 58,0);
                        if (*(uint32 *)(lVar12 + 24) < 4) {
                          uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar34,0);
                        }
                        *(uint32 *)(lVar12 + 56) = uVar22;
                      }
                      plVar11 = this + 58;
                      if ((int)this[51] - 2U < 2) {
                        lVar12 = *pStatics;
                        if (lVar12 != null) {
                          if (*(uint32 *)(lVar12 + 24) == 0) {
                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar34,0);
                          }
                          if (*(uint32 *)(lVar12 + 24) < 2) {
                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar34,0);
                          }
                          *(float *)(lVar12 + 44) = *(float *)(lVar12 + 36) + fVar31;
                          lVar12 = *pStatics;
                          if (lVar12 != null) {
                            if (*(uint32 *)(lVar12 + 24) < 4) {
                              uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar34,0);
                            }
                            *(float *)(lVar12 + 52) = *(float *)(lVar12 + 60) - fVar3;
                            lVar12 = *(int64 *)(pStatics + 8);
                            if (lVar12 != null) {
                              uVar22 = FUN_18044df60(plVar11,0);
                              if (*(uint32 *)(lVar12 + 24) < 4) {
                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar34,0);
                              }
                              *(uint32 *)(lVar12 + 60) = uVar22;
                              lVar12 = *(int64 *)(pStatics + 8);
                              if (lVar12 != null) {
                                uVar22 = FUN_18044df60(plVar1,0);
                                if (*(uint32 *)(lVar12 + 24) < 3) {
                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar34,0);
                                }
                                *(uint32 *)(lVar12 + 52) = uVar22;
                                lVar12 = *(int64 *)(pStatics + 8);
                                if (lVar12 != null) {
                                  uVar22 = Rect.get_yMax(plVar1,0);
                                  if (*(uint32 *)(lVar12 + 24) < 2) {
                                    uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar34,0);
                                  }
                                  *(uint32 *)(lVar12 + 44) = uVar22;
                                  lVar12 = *(int64 *)(pStatics + 8);
                                  if (lVar12 != null) {
                                    uVar22 = Rect.get_yMax(plVar11,0);
                                    if (*(int *)(lVar12 + 24) == 0) {
                                      uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar34,0);
                                    }
                                    *(uint32 *)(lVar12 + 36) = uVar22;
                                    goto LAB_180a7b3b4;
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                      else {
                        lVar12 = *pStatics;
                        if (lVar12 != null) {
                          if (*(uint32 *)(lVar12 + 24) == 0) {
                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar34,0);
                          }
                          if (*(uint32 *)(lVar12 + 24) < 2) {
                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar34,0);
                          }
                          *(float *)(lVar12 + 44) = *(float *)(lVar12 + 36) + fVar3;
                          lVar12 = *pStatics;
                          if (lVar12 != null) {
                            if (*(uint32 *)(lVar12 + 24) < 4) {
                              uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar34,0);
                            }
                            *(float *)(lVar12 + 52) = *(float *)(lVar12 + 60) - fVar31;
                            lVar12 = *(int64 *)(pStatics + 8);
                            if (lVar12 != null) {
                              uVar22 = FUN_18044df60(plVar11,0);
                              if (*(int *)(lVar12 + 24) == 0) {
                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar34,0);
                              }
                              *(uint32 *)(lVar12 + 36) = uVar22;
                              lVar12 = *(int64 *)(pStatics + 8);
                              if (lVar12 != null) {
                                uVar22 = FUN_18044df60(plVar1,0);
                                if (*(uint32 *)(lVar12 + 24) < 2) {
                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar34,0);
                                }
                                *(uint32 *)(lVar12 + 44) = uVar22;
                                lVar12 = *(int64 *)(pStatics + 8);
                                if (lVar12 != null) {
                                  uVar22 = Rect.get_yMax(plVar1,0);
                                  if (*(uint32 *)(lVar12 + 24) < 3) {
                                    uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar34,0);
                                  }
                                  *(uint32 *)(lVar12 + 52) = uVar22;
                                  lVar12 = *(int64 *)(pStatics + 8);
                                  if (lVar12 != null) {
                                    uVar22 = Rect.get_yMax(plVar11,0);
                                    if (*(uint32 *)(lVar12 + 24) < 4) {
                                      uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar34,0);
                                    }
                                    *(uint32 *)(lVar12 + 60) = uVar22;
        LAB_180a7b3b4:
                                    uVar15 = 0;
                                    lVar12 = DAT_181d8a358;
                                    do {
                                      uVar14 = 0;
                                      do {
                                        uVar22 = (uint32)((uint64)lVar13 >> 32);
                                        uVar35 = (uint32)((uint64)uVar34 >> 32);
                                        uVar24 = (uint32)
                                                 ((uint64)in_stack_fffffffffffffec8 >> 32);
                                        uVar27 = (uint32)
                                                 ((uint64)in_stack_fffffffffffffed0 >> 32);
                                        iVar9 = (int)this[60];
                                        if (iVar9 == 0) {
                                          if (uVar15 != 1) goto LAB_180a7bb1e;
                                          if (uVar14 == 1) goto LAB_180a7bfac;
        LAB_180a7b401:
                                          if (uVar14 != 0) {
                                            if (uVar14 == 2) {
                                              if ((int)this[62] == 2) goto LAB_180a7b547;
                                              if ((int)this[62] != 0) goto LAB_180a7b43e;
                                            }
                                            goto LAB_180a7bfac;
                                          }
                                          if (*(int *)((int64)this + 0x1ec) == 2) {
        LAB_180a7b547:
                                            if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                               (*(int *)(lVar12 + 224) == 0)) {
                                              il2cpp_runtime_class_init();
                                              lVar12 = DAT_181d8a358;
                                            }
                                            lVar16 = *plVar12;
                                            if (lVar16 != null) {
                                              uVar4 = *(uint32 *)(lVar16 + 24);
                                              if (uVar4 <= uVar15) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              lVar17 = (int64)(int)uVar15 + 1;
                                              if (uVar4 <= (uint32)lVar17) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              lVar18 = (int64)(int)uVar14;
                                              if (uVar4 <= uVar14) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              uVar22 = *(uint32 *)(lVar16 + 36 + lVar18 * 8);
                                              lVar19 = lVar18 + 1;
                                              if (uVar4 <= (uint32)lVar19) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              lVar5 = (plVar12)[1];
                                              uVar35 = *(uint32 *)(lVar16 + 36 + lVar19 * 8);
                                              if (lVar5 != null) {
                                                uVar4 = *(uint32 *)(lVar5 + 24);
                                                if (uVar4 <= uVar15) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                uVar24 = *(uint32 *)(lVar5 + 40);
                                                if (uVar4 <= uVar14) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                uVar27 = *(uint32 *)(lVar5 + 36 + lVar18 * 8);
                                                if (uVar4 <= (uint32)lVar19) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                fVar2 = *(float *)(lVar16 + 32 + lVar17 * 8);
                                                uVar36 = *(uint32 *)(lVar5 + 36 + lVar19 * 8);
                                                fVar3 = *(float *)(lVar16 + 40);
                                                while (fVar3 < fVar2) {
                                                  uVar28 = (uint32)((uint64)lVar13 >> 32);
                                                  uVar37 = (uint32)((uint64)uVar34 >> 32);
                                                  uVar25 = (uint32)
                                                           ((uint64)in_stack_fffffffffffffec8 >> 32);
                                                  uVar26 = (uint32)
                                                           ((uint64)in_stack_fffffffffffffed0 >> 32);
                                                  fVar29 = local_res8 + fVar3;
                                                  if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                                     (*(int *)(lVar12 + 224) == 0)) {
                                                    il2cpp_runtime_class_init();
                                                    lVar12 = DAT_181d8a358;
                                                  }
                                                  lVar13 = *(int64 *)(plVar12 + 8)
                                                  ;
                                                  if (lVar13 == null) goto LAB_180a7c5d5;
                                                  lVar16 = (int64)(int)uVar15 + 1;
                                                  if (*(uint32 *)(lVar13 + 24) <= (uint32)lVar16) {
                                                    uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                    FUN_1800d65f0(uVar34,0);
                                                  }
                                                  uVar23 = *(uint32 *)(lVar13 + 32 + lVar16 * 8);
                                                  fVar31 = fVar29;
                                                  if (fVar2 < fVar29) {
                                                    uVar23 = Mathf.Lerp(uVar24,lVar13,
                                                                         (fVar2 - fVar3) / local_res8,0);
                                                    lVar12 = DAT_181d8a358;
                                                    fVar31 = fVar2;
                                                  }
                                                  uVar6 = *c;
                                                  uVar7 = c[1];
                                                  if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                                     (*(int *)(lVar12 + 224) == 0)) {
                                                    il2cpp_runtime_class_init();
                                                  }
                                                  in_stack_fffffffffffffed0 = CONCAT44(uVar26,uVar24);
                                                  in_stack_fffffffffffffec8 = CONCAT44(uVar25,uVar35);
                                                  uVar34 = CONCAT44(uVar37,uVar22);
                                                  lVar13 = CONCAT44(uVar28,fVar31);
                                                  local_d8 = uVar6;
                                                  uStack_d0 = uVar7;
                                                  UIBasicSprite.Fill(verts,uvs,cols,fVar3,lVar13
                                                                      ,uVar34,in_stack_fffffffffffffec8,
                                                                      in_stack_fffffffffffffed0,uVar23,
                                                                      uVar27,uVar36,&local_d8,0);
                                                  fVar3 = fVar29;
                                                  lVar12 = DAT_181d8a358;
                                                }
                                                goto LAB_180a7bfac;
                                              }
                                            }
                                            goto LAB_180a7c5d5;
                                          }
                                          if (*(int *)((int64)this + 0x1ec) == 0)
                                          goto LAB_180a7bfac;
        LAB_180a7b43e:
                                          if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                             (*(int *)(lVar12 + 224) == 0)) {
                                            il2cpp_runtime_class_init();
                                            lVar12 = DAT_181d8a358;
                                          }
                                          lVar13 = *plVar12;
                                          if (lVar13 == null) goto LAB_180a7c5d5;
                                          uVar4 = *(uint32 *)(lVar13 + 24);
                                          if (uVar4 <= uVar15) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          lVar16 = (int64)(int)uVar15 + 1;
                                          if (uVar4 <= (uint32)lVar16) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          if (uVar4 <= uVar14) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          lVar18 = (int64)(int)uVar14;
                                          lVar17 = lVar18 + 1;
                                          if (uVar4 <= (uint32)lVar17) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          lVar12 = (plVar12)[1];
                                          if (lVar12 == null) goto LAB_180a7c5d5;
                                          uVar4 = *(uint32 *)(lVar12 + 24);
                                          if (uVar4 <= uVar15) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          if (uVar4 <= (uint32)lVar16) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          if (uVar4 <= uVar14) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          if (uVar4 <= (uint32)lVar17) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          local_d8 = *c;
                                          uStack_d0 = c[1];
                                          uVar36 = *(uint32 *)(lVar12 + 36 + lVar18 * 8);
                                          uVar28 = *(uint32 *)(lVar13 + 40);
                                          uVar37 = *(uint32 *)(lVar12 + 36 + lVar17 * 8);
                                          uVar25 = *(uint32 *)(lVar12 + 32 + lVar16 * 8);
                                          in_stack_fffffffffffffed0 =
                                               CONCAT44(uVar27,*(uint32 *)(lVar12 + 40));
                                          uVar27 = *(uint32 *)(lVar13 + 36 + lVar18 * 8);
                                          in_stack_fffffffffffffec8 =
                                               CONCAT44(uVar24,*(uint32 *)(lVar13 + 36 + lVar17 * 8)
                                                       );
                                          uVar24 = *(uint32 *)(lVar13 + 32 + lVar16 * 8);
        LAB_180a7bc70:
                                          uVar34 = CONCAT44(uVar35,uVar27);
                                          lVar13 = CONCAT44(uVar22,uVar24);
                                          UIBasicSprite.Fill(verts,uvs,cols,uVar28,lVar13,uVar34
                                                              ,in_stack_fffffffffffffec8,
                                                              in_stack_fffffffffffffed0,uVar25,uVar36,
                                                              uVar37,&local_d8,0);
                                          lVar12 = DAT_181d8a358;
                                        }
                                        else if (uVar15 == 1) {
                                          if (uVar14 != 1) goto LAB_180a7b401;
                                          if (iVar9 != 2) {
                                            if (iVar9 != 1) goto LAB_180a7bfac;
                                            if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                               (*(int *)(lVar12 + 224) == 0)) {
                                              il2cpp_runtime_class_init();
                                              lVar12 = DAT_181d8a358;
                                            }
                                            lVar13 = *plVar12;
                                            if (lVar13 != null) {
                                              uVar4 = *(uint32 *)(lVar13 + 24);
                                              if (uVar4 < 2) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              if (uVar4 < 3) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              if (uVar4 < 2) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              if (uVar4 < 3) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              lVar12 = (plVar12)[1];
                                              if (lVar12 != null) {
                                                uVar4 = *(uint32 *)(lVar12 + 24);
                                                if (uVar4 < 2) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                if (uVar4 < 3) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                if (uVar4 < 2) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                if (uVar4 < 3) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                local_d8 = *c;
                                                uStack_d0 = c[1];
                                                uVar36 = *(uint32 *)(lVar12 + 44);
                                                uVar28 = *(uint32 *)(lVar13 + 40);
                                                uVar37 = *(uint32 *)(lVar12 + 52);
                                                uVar25 = *(uint32 *)(lVar12 + 48);
                                                in_stack_fffffffffffffed0 =
                                                     CONCAT44(uVar27,*(uint32 *)(lVar12 + 40));
                                                uVar27 = *(uint32 *)(lVar13 + 44);
                                                in_stack_fffffffffffffec8 =
                                                     CONCAT44(uVar24,*(uint32 *)(lVar13 + 52));
                                                uVar24 = *(uint32 *)(lVar13 + 48);
                                                goto LAB_180a7bc70;
                                              }
                                            }
                                            goto LAB_180a7c5d5;
                                          }
                                          if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                             (*(int *)(lVar12 + 224) == 0)) {
                                            il2cpp_runtime_class_init();
                                            lVar12 = DAT_181d8a358;
                                          }
                                          lVar16 = *plVar12;
                                          if (lVar16 == null) goto LAB_180a7c5d5;
                                          uVar4 = *(uint32 *)(lVar16 + 24);
                                          if (uVar4 < 2) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          fVar2 = *(float *)(lVar16 + 40);
                                          if (uVar4 < 3) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          fVar3 = *(float *)(lVar16 + 48);
                                          if (uVar4 < 2) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          if (uVar4 < 3) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          lVar17 = (plVar12)[1];
                                          if (lVar17 == null) goto LAB_180a7c5d5;
                                          if (*(uint32 *)(lVar17 + 24) < 2) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          uVar22 = *(uint32 *)(lVar17 + 40);
                                          if (*(uint32 *)(lVar17 + 24) < 2) {
                                            uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar34,0);
                                          }
                                          fVar29 = *(float *)(lVar16 + 52);
                                          uVar35 = *(uint32 *)(lVar17 + 44);
                                          fVar31 = *(float *)(lVar16 + 44);
                                          while (fVar20 = fVar31, fVar20 < fVar29) {
                                            if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                               (*(int *)(lVar12 + 224) == 0)) {
                                              il2cpp_runtime_class_init();
                                              lVar12 = DAT_181d8a358;
                                            }
                                            lVar16 = *(int64 *)(plVar12 + 8);
                                            if (lVar16 == null) goto LAB_180a7c5d5;
                                            if (*(uint32 *)(lVar16 + 24) < 3) {
                                              uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar34,0);
                                            }
                                            uVar24 = *(uint32 *)(lVar16 + 52);
                                            fVar31 = local_f8 + fVar20;
                                            fVar21 = fVar2;
                                            fVar33 = fVar31;
                                            if (fVar29 < fVar31) {
                                              uVar24 = Mathf.Lerp(uVar35,lVar16,
                                                                   (fVar29 - fVar20) / local_f8,0);
                                              lVar12 = DAT_181d8a358;
                                              fVar33 = fVar29;
                                            }
                                            while (fVar21 < fVar3) {
                                              uVar27 = (uint32)((uint64)lVar13 >> 32);
                                              uVar36 = (uint32)((uint64)uVar34 >> 32);
                                              uVar28 = (uint32)
                                                       ((uint64)in_stack_fffffffffffffec8 >> 32);
                                              uVar37 = (uint32)
                                                       ((uint64)in_stack_fffffffffffffed0 >> 32);
                                              fVar30 = local_res8 + fVar21;
                                              if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                                 (*(int *)(lVar12 + 224) == 0)) {
                                                il2cpp_runtime_class_init();
                                                lVar12 = DAT_181d8a358;
                                              }
                                              lVar13 = *(int64 *)(plVar12 + 8);
                                              if (lVar13 == null) goto LAB_180a7c5d5;
                                              if (*(uint32 *)(lVar13 + 24) < 3) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              uVar25 = *(uint32 *)(lVar13 + 48);
                                              fVar32 = fVar30;
                                              if (fVar3 < fVar30) {
                                                uVar25 = Mathf.Lerp(uVar22,lVar13,
                                                                     (fVar3 - fVar21) / local_res8,0);
                                                lVar12 = DAT_181d8a358;
                                                fVar32 = fVar3;
                                              }
                                              uVar6 = *c;
                                              uVar7 = c[1];
                                              if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                                 (*(int *)(lVar12 + 224) == 0)) {
                                                il2cpp_runtime_class_init();
                                              }
                                              in_stack_fffffffffffffed0 = CONCAT44(uVar37,uVar22);
                                              in_stack_fffffffffffffec8 = CONCAT44(uVar28,fVar33);
                                              uVar34 = CONCAT44(uVar36,fVar20);
                                              lVar13 = CONCAT44(uVar27,fVar32);
                                              local_d8 = uVar6;
                                              uStack_d0 = uVar7;
                                              UIBasicSprite.Fill(verts,uvs,cols,fVar21,lVar13,
                                                                  uVar34,in_stack_fffffffffffffec8,
                                                                  in_stack_fffffffffffffed0,uVar25,uVar35,
                                                                  uVar24,&local_d8,0);
                                              fVar21 = fVar30;
                                              lVar12 = DAT_181d8a358;
                                            }
                                          }
                                        }
                                        else {
        LAB_180a7bb1e:
                                          if (uVar14 != 1) {
                                            if (uVar14 == 0) {
                                              iVar9 = *(int *)((int64)this + 0x1ec);
        LAB_180a7bb41:
                                              if (iVar9 == 0) goto LAB_180a7bfac;
                                            }
                                            else if (uVar14 == 2) {
                                              iVar9 = (int)this[62];
                                              goto LAB_180a7bb41;
                                            }
                                            if (uVar15 == 0) {
                                              iVar9 = *(int *)((int64)this + 0x1e4);
        LAB_180a7bb61:
                                              if (iVar9 == 0) goto LAB_180a7bfac;
                                            }
                                            else if (uVar15 == 2) {
                                              iVar9 = (int)this[61];
                                              goto LAB_180a7bb61;
                                            }
                                            if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                               (*(int *)(lVar12 + 224) == 0)) {
                                              il2cpp_runtime_class_init();
                                              lVar12 = DAT_181d8a358;
                                            }
                                            lVar13 = *plVar12;
                                            if (lVar13 != null) {
                                              uVar4 = *(uint32 *)(lVar13 + 24);
                                              if (uVar4 <= uVar15) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              lVar17 = (int64)(int)uVar15;
                                              lVar16 = lVar17 + 1;
                                              if (uVar4 <= (uint32)lVar16) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              if (uVar4 <= uVar14) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              lVar19 = (int64)(int)uVar14;
                                              lVar18 = lVar19 + 1;
                                              if (uVar4 <= (uint32)lVar18) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              lVar12 = (plVar12)[1];
                                              if (lVar12 != null) {
                                                uVar4 = *(uint32 *)(lVar12 + 24);
                                                if (uVar4 <= uVar15) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                if (uVar4 <= (uint32)lVar16) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                if (uVar4 <= uVar14) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                if (uVar4 <= (uint32)lVar18) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                local_d8 = *c;
                                                uStack_d0 = c[1];
                                                uVar36 = *(uint32 *)(lVar12 + 36 + lVar19 * 8);
                                                uVar28 = *(uint32 *)(lVar13 + 32 + lVar17 * 8);
                                                uVar37 = *(uint32 *)(lVar12 + 36 + lVar18 * 8);
                                                uVar25 = *(uint32 *)(lVar12 + 32 + lVar16 * 8);
                                                uVar26 = *(uint32 *)(lVar13 + 36 + lVar18 * 8);
                                                in_stack_fffffffffffffed0 =
                                                     CONCAT44(uVar27,*(uint32 *)
                                                                      (lVar12 + 32 + lVar17 * 8));
                                                uVar27 = *(uint32 *)(lVar13 + 36 + lVar19 * 8);
        LAB_180a7bc63:
                                                in_stack_fffffffffffffec8 = CONCAT44(uVar24,uVar26);
                                                uVar24 = *(uint32 *)(lVar13 + 32 + lVar16 * 8);
                                                goto LAB_180a7bc70;
                                              }
                                            }
                                            goto LAB_180a7c5d5;
                                          }
                                          if (uVar15 == 0) {
                                            if (*(int *)((int64)this + 0x1e4) != 2) {
                                              if (*(int *)((int64)this + 0x1e4) == 0)
                                              goto LAB_180a7bfac;
        LAB_180a7bcd3:
                                              if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                                 (*(int *)(lVar12 + 224) == 0)) {
                                                il2cpp_runtime_class_init();
                                                lVar12 = DAT_181d8a358;
                                              }
                                              lVar13 = *plVar12;
                                              if (lVar13 != null) {
                                                uVar4 = *(uint32 *)(lVar13 + 24);
                                                if (uVar4 <= uVar15) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                lVar17 = (int64)(int)uVar15;
                                                lVar16 = lVar17 + 1;
                                                if (uVar4 <= (uint32)lVar16) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                if (uVar4 < 2) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                if (uVar4 < 3) {
                                                  uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar34,0);
                                                }
                                                lVar12 = (plVar12)[1];
                                                if (lVar12 != null) {
                                                  uVar4 = *(uint32 *)(lVar12 + 24);
                                                  if (uVar4 <= uVar15) {
                                                    uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                    FUN_1800d65f0(uVar34,0);
                                                  }
                                                  if (uVar4 <= (uint32)lVar16) {
                                                    uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                    FUN_1800d65f0(uVar34,0);
                                                  }
                                                  if (uVar4 < 2) {
                                                    uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                    FUN_1800d65f0(uVar34,0);
                                                  }
                                                  if (uVar4 < 3) {
                                                    uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                    FUN_1800d65f0(uVar34,0);
                                                  }
                                                  local_d8 = *c;
                                                  uStack_d0 = c[1];
                                                  uVar36 = *(uint32 *)(lVar12 + 44);
                                                  uVar28 = *(uint32 *)(lVar13 + 32 + lVar17 * 8);
                                                  uVar37 = *(uint32 *)(lVar12 + 52);
                                                  uVar25 = *(uint32 *)(lVar12 + 32 + lVar16 * 8);
                                                  uVar26 = *(uint32 *)(lVar13 + 52);
                                                  in_stack_fffffffffffffed0 =
                                                       CONCAT44(uVar27,*(uint32 *)
                                                                        (lVar12 + 32 + lVar17 * 8));
                                                  uVar27 = *(uint32 *)(lVar13 + 44);
                                                  goto LAB_180a7bc63;
                                                }
                                              }
                                              goto LAB_180a7c5d5;
                                            }
        LAB_180a7bdc7:
                                            if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                               (*(int *)(lVar12 + 224) == 0)) {
                                              il2cpp_runtime_class_init();
                                              lVar12 = DAT_181d8a358;
                                            }
                                            lVar16 = *plVar12;
                                            if (lVar16 == null) goto LAB_180a7c5d5;
                                            uVar4 = *(uint32 *)(lVar16 + 24);
                                            if (uVar4 <= uVar15) {
                                              uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar34,0);
                                            }
                                            lVar18 = (int64)(int)uVar15;
                                            uVar22 = *(uint32 *)(lVar16 + 32 + lVar18 * 8);
                                            lVar17 = lVar18 + 1;
                                            if (uVar4 <= (uint32)lVar17) {
                                              uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar34,0);
                                            }
                                            uVar35 = *(uint32 *)(lVar16 + 32 + lVar17 * 8);
                                            if (uVar4 < 2) {
                                              uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar34,0);
                                            }
                                            if (uVar4 < 3) {
                                              uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar34,0);
                                            }
                                            lVar19 = (plVar12)[1];
                                            if (lVar19 == null) goto LAB_180a7c5d5;
                                            uVar4 = *(uint32 *)(lVar19 + 24);
                                            if (uVar4 <= uVar15) {
                                              uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar34,0);
                                            }
                                            uVar24 = *(uint32 *)(lVar19 + 32 + lVar18 * 8);
                                            if (uVar4 <= (uint32)lVar17) {
                                              uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar34,0);
                                            }
                                            uVar27 = *(uint32 *)(lVar19 + 32 + lVar17 * 8);
                                            if (uVar4 < 2) {
                                              uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar34,0);
                                            }
                                            fVar2 = *(float *)(lVar16 + 52);
                                            uVar36 = *(uint32 *)(lVar19 + 44);
                                            fVar3 = *(float *)(lVar16 + 44);
                                            while (fVar3 < fVar2) {
                                              uVar28 = (uint32)((uint64)lVar13 >> 32);
                                              uVar37 = (uint32)((uint64)uVar34 >> 32);
                                              uVar25 = (uint32)
                                                       ((uint64)in_stack_fffffffffffffec8 >> 32);
                                              uVar26 = (uint32)
                                                       ((uint64)in_stack_fffffffffffffed0 >> 32);
                                              if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                                 (*(int *)(lVar12 + 224) == 0)) {
                                                il2cpp_runtime_class_init();
                                                lVar12 = DAT_181d8a358;
                                              }
                                              lVar13 = *(int64 *)(plVar12 + 8);
                                              if (lVar13 == null) goto LAB_180a7c5d5;
                                              if (*(uint32 *)(lVar13 + 24) < 3) {
                                                uVar34 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar34,0);
                                              }
                                              uVar23 = *(uint32 *)(lVar13 + 52);
                                              fVar31 = local_f8 + fVar3;
                                              fVar29 = fVar31;
                                              if (fVar2 < fVar31) {
                                                uVar23 = Mathf.Lerp(uVar36,lVar13,
                                                                     (fVar2 - fVar3) / local_f8,0);
                                                lVar12 = DAT_181d8a358;
                                                fVar29 = fVar2;
                                              }
                                              uVar6 = *c;
                                              uVar7 = c[1];
                                              if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                                 (*(int *)(lVar12 + 224) == 0)) {
                                                il2cpp_runtime_class_init();
                                              }
                                              in_stack_fffffffffffffed0 = CONCAT44(uVar26,uVar24);
                                              in_stack_fffffffffffffec8 = CONCAT44(uVar25,fVar29);
                                              uVar34 = CONCAT44(uVar37,fVar3);
                                              lVar13 = CONCAT44(uVar28,uVar35);
                                              local_d8 = uVar6;
                                              uStack_d0 = uVar7;
                                              UIBasicSprite.Fill(verts,uvs,cols,uVar22,lVar13,
                                                                  uVar34,in_stack_fffffffffffffec8,
                                                                  in_stack_fffffffffffffed0,uVar27,uVar36,
                                                                  uVar23,&local_d8,0);
                                              fVar3 = fVar31;
                                              lVar12 = DAT_181d8a358;
                                            }
                                          }
                                          else if (uVar15 == 2) {
                                            if ((int)this[61] == 2) goto LAB_180a7bdc7;
                                            if ((int)this[61] != 0) goto LAB_180a7bcd3;
                                          }
                                        }
        LAB_180a7bfac:
                                        uVar14 = uVar14 + 1;
                                      } while ((int)uVar14 < 3);
                                      uVar15 = uVar15 + 1;
                                      if (2 < (int)uVar15) {
                                        return;
                                      }
                                    } while( true );
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
        LAB_180a7c5d5:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          UIBasicSprite.SimpleFill(this,verts,uvs,cols,v,u,c,0);
        }
    }

    // Token : 0x6000468
    // RVA   : 0xA7E750   Offset: 0xA7CF50   Length: 0x14C
    private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
    {
        void UIBasicSprite.RadialCut
                     (int64 xy,float uv,float fill,char invert,uint32 corner)
        {
        uint32 uVar1;
        uint32 uVar2;
        uint32 uVar3;
        uint64 uVar4;
        int64 lVar5;
        uint64 uVar6;
        int64 lVar7;
        int64 lVar8;
        uint32 uVar9;
        uVar6 = (uint64)(int)corner;
        uVar1 = NGUIMath.RepeatIndex(corner + 1,4);
        lVar8 = (int64)(int)uVar1;
        uVar2 = NGUIMath.RepeatIndex(corner + 2,4);
        lVar5 = (int64)(int)uVar2;
        uVar3 = NGUIMath.RepeatIndex(corner + 3,4);
        lVar7 = (int64)(int)uVar3;
        if ((uVar6 & 1) != 0) {
          if (uv < fill) {
            uv = uv / fill;
            if (invert) {
              if (xy == null) throw; // [null/range check failed]
              if (*(uint32 *)(xy + 24) <= corner) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (*(uint32 *)(xy + 24) <= uVar2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              uVar9 = Mathf.Lerp(*(uint32 *)(xy + 32 + uVar6 * 8),
                                  *(uint32 *)(xy + 32 + lVar5 * 8),uv,0);
              if (*(uint32 *)(xy + 24) <= uVar1) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              *(uint32 *)(xy + 32 + lVar8 * 8) = uVar9;
              if (*(uint32 *)(xy + 24) <= uVar1) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (*(uint32 *)(xy + 24) <= uVar2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              fill = 1.0;
              *(uint32 *)(xy + 32 + lVar5 * 8) = uVar9;
              goto LAB_180a7e4b7;
            }
        LAB_180a7e4f7:
            if (xy != null) {
        LAB_180a7e4fc:
              if (*(uint32 *)(xy + 24) <= corner) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (uVar2 < *(uint32 *)(xy + 24)) {
                uVar9 = Mathf.Lerp(*(uint32 *)(xy + 32 + uVar6 * 8),
                                    *(uint32 *)(xy + 32 + lVar5 * 8),uv,0);
                if (uVar3 < *(uint32 *)(xy + 24)) {
                  *(uint32 *)(xy + 32 + lVar7 * 8) = uVar9;
                  return;
                }
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
          }
          else {
            if (fill < uv) {
              fill = fill / uv;
              uv = 1.0;
              if (!invert) {
                if (xy == null) throw; // [null/range check failed]
                if (*(uint32 *)(xy + 24) <= corner) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                if (*(uint32 *)(xy + 24) <= uVar2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                uVar9 = Mathf.Lerp(*(uint32 *)(xy + 36 + uVar6 * 8),
                                    *(uint32 *)(xy + 36 + lVar5 * 8),fill,0);
                if (*(uint32 *)(xy + 24) <= uVar2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                *(uint32 *)(xy + 36 + lVar5 * 8) = uVar9;
                if (*(uint32 *)(xy + 24) <= uVar2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                if (*(uint32 *)(xy + 24) <= uVar3) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                *(uint32 *)(xy + 36 + lVar7 * 8) = uVar9;
                goto LAB_180a7e4fc;
              }
            }
            else {
              fill = 1.0;
              uv = 1.0;
              if (!invert) goto LAB_180a7e4f7;
            }
            if (xy != null) {
        LAB_180a7e4b7:
              if (*(uint32 *)(xy + 24) <= corner) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (uVar2 < *(uint32 *)(xy + 24)) {
                uVar9 = Mathf.Lerp(*(uint32 *)(xy + 36 + uVar6 * 8),
                                    *(uint32 *)(xy + 36 + lVar5 * 8),fill,0);
                if (uVar1 < *(uint32 *)(xy + 24)) {
                  *(uint32 *)(xy + 36 + lVar8 * 8) = uVar9;
                  return;
                }
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
          }
          throw; // [null/range check failed]
        }
        if (fill < uv) {
          fill = fill / uv;
          uv = 1.0;
          if (!invert) {
            if (xy == null) throw; // [null/range check failed]
            if (*(uint32 *)(xy + 24) <= corner) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (*(uint32 *)(xy + 24) <= uVar2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            uVar9 = Mathf.Lerp(*(uint32 *)(xy + 36 + uVar6 * 8),
                                *(uint32 *)(xy + 36 + lVar5 * 8),fill,0);
            if (*(uint32 *)(xy + 24) <= uVar1) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            *(uint32 *)(xy + 36 + lVar8 * 8) = uVar9;
            if (*(uint32 *)(xy + 24) <= uVar1) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (*(uint32 *)(xy + 24) <= uVar2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            *(uint32 *)(xy + 36 + lVar5 * 8) = uVar9;
            goto LAB_180a7e2fd;
          }
        LAB_180a7e35b:
          if (xy != null) {
        LAB_180a7e364:
            if (*(uint32 *)(xy + 24) <= corner) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar2 < *(uint32 *)(xy + 24)) {
              uVar9 = Mathf.Lerp(*(uint32 *)(xy + 36 + uVar6 * 8),
                                  *(uint32 *)(xy + 36 + lVar5 * 8),fill,0);
              if (uVar3 < *(uint32 *)(xy + 24)) {
                *(uint32 *)(xy + 36 + lVar7 * 8) = uVar9;
                return;
              }
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        else {
          if (uv < fill) {
            uv = uv / fill;
            if (invert) {
              if (xy == null) throw; // [null/range check failed]
              if (*(uint32 *)(xy + 24) <= corner) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (*(uint32 *)(xy + 24) <= uVar2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              uVar9 = Mathf.Lerp(*(uint32 *)(xy + 32 + uVar6 * 8),
                                  *(uint32 *)(xy + 32 + lVar5 * 8),uv,0);
              if (*(uint32 *)(xy + 24) <= uVar2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              *(uint32 *)(xy + 32 + lVar5 * 8) = uVar9;
              if (*(uint32 *)(xy + 24) <= uVar2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (*(uint32 *)(xy + 24) <= uVar3) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              fill = 1.0;
              *(uint32 *)(xy + 32 + lVar7 * 8) = uVar9;
              goto LAB_180a7e364;
            }
          }
          else {
            fill = 1.0;
            uv = 1.0;
            if (invert) goto LAB_180a7e35b;
          }
          if (xy != null) {
        LAB_180a7e2fd:
            if (*(uint32 *)(xy + 24) <= corner) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar2 < *(uint32 *)(xy + 24)) {
              uVar9 = Mathf.Lerp(*(uint32 *)(xy + 32 + uVar6 * 8),
                                  *(uint32 *)(xy + 32 + lVar5 * 8),uv,0);
              if (uVar1 < *(uint32 *)(xy + 24)) {
                *(uint32 *)(xy + 32 + lVar8 * 8) = uVar9;
                return;
              }
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
    }

    // Token : 0x6000469
    // RVA   : 0xA7E170   Offset: 0xA7C970   Length: 0x5D1
    private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
    {
        void UIBasicSprite.RadialCut
                     (int64 xy,float cos,float sin,char invert,uint32 corner)
        {
        uint32 uVar1;
        uint32 uVar2;
        uint32 uVar3;
        uint64 uVar4;
        int64 lVar5;
        uint64 uVar6;
        int64 lVar7;
        int64 lVar8;
        uint32 uVar9;
        uVar6 = (uint64)(int)corner;
        uVar1 = NGUIMath.RepeatIndex(corner + 1,4);
        lVar8 = (int64)(int)uVar1;
        uVar2 = NGUIMath.RepeatIndex(corner + 2,4);
        lVar5 = (int64)(int)uVar2;
        uVar3 = NGUIMath.RepeatIndex(corner + 3,4);
        lVar7 = (int64)(int)uVar3;
        if ((uVar6 & 1) != 0) {
          if (cos < sin) {
            cos = cos / sin;
            if (invert) {
              if (xy == null) throw; // [null/range check failed]
              if (*(uint32 *)(xy + 24) <= corner) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (*(uint32 *)(xy + 24) <= uVar2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              uVar9 = Mathf.Lerp(*(uint32 *)(xy + 32 + uVar6 * 8),
                                  *(uint32 *)(xy + 32 + lVar5 * 8),cos,0);
              if (*(uint32 *)(xy + 24) <= uVar1) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              *(uint32 *)(xy + 32 + lVar8 * 8) = uVar9;
              if (*(uint32 *)(xy + 24) <= uVar1) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (*(uint32 *)(xy + 24) <= uVar2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              sin = 1.0;
              *(uint32 *)(xy + 32 + lVar5 * 8) = uVar9;
              goto LAB_180a7e4b7;
            }
        LAB_180a7e4f7:
            if (xy != null) {
        LAB_180a7e4fc:
              if (*(uint32 *)(xy + 24) <= corner) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (uVar2 < *(uint32 *)(xy + 24)) {
                uVar9 = Mathf.Lerp(*(uint32 *)(xy + 32 + uVar6 * 8),
                                    *(uint32 *)(xy + 32 + lVar5 * 8),cos,0);
                if (uVar3 < *(uint32 *)(xy + 24)) {
                  *(uint32 *)(xy + 32 + lVar7 * 8) = uVar9;
                  return;
                }
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
          }
          else {
            if (sin < cos) {
              sin = sin / cos;
              cos = 1.0;
              if (!invert) {
                if (xy == null) throw; // [null/range check failed]
                if (*(uint32 *)(xy + 24) <= corner) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                if (*(uint32 *)(xy + 24) <= uVar2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                uVar9 = Mathf.Lerp(*(uint32 *)(xy + 36 + uVar6 * 8),
                                    *(uint32 *)(xy + 36 + lVar5 * 8),sin,0);
                if (*(uint32 *)(xy + 24) <= uVar2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                *(uint32 *)(xy + 36 + lVar5 * 8) = uVar9;
                if (*(uint32 *)(xy + 24) <= uVar2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                if (*(uint32 *)(xy + 24) <= uVar3) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                *(uint32 *)(xy + 36 + lVar7 * 8) = uVar9;
                goto LAB_180a7e4fc;
              }
            }
            else {
              sin = 1.0;
              cos = 1.0;
              if (!invert) goto LAB_180a7e4f7;
            }
            if (xy != null) {
        LAB_180a7e4b7:
              if (*(uint32 *)(xy + 24) <= corner) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (uVar2 < *(uint32 *)(xy + 24)) {
                uVar9 = Mathf.Lerp(*(uint32 *)(xy + 36 + uVar6 * 8),
                                    *(uint32 *)(xy + 36 + lVar5 * 8),sin,0);
                if (uVar1 < *(uint32 *)(xy + 24)) {
                  *(uint32 *)(xy + 36 + lVar8 * 8) = uVar9;
                  return;
                }
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
          }
          throw; // [null/range check failed]
        }
        if (sin < cos) {
          sin = sin / cos;
          cos = 1.0;
          if (!invert) {
            if (xy == null) throw; // [null/range check failed]
            if (*(uint32 *)(xy + 24) <= corner) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (*(uint32 *)(xy + 24) <= uVar2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            uVar9 = Mathf.Lerp(*(uint32 *)(xy + 36 + uVar6 * 8),
                                *(uint32 *)(xy + 36 + lVar5 * 8),sin,0);
            if (*(uint32 *)(xy + 24) <= uVar1) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            *(uint32 *)(xy + 36 + lVar8 * 8) = uVar9;
            if (*(uint32 *)(xy + 24) <= uVar1) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (*(uint32 *)(xy + 24) <= uVar2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            *(uint32 *)(xy + 36 + lVar5 * 8) = uVar9;
            goto LAB_180a7e2fd;
          }
        LAB_180a7e35b:
          if (xy != null) {
        LAB_180a7e364:
            if (*(uint32 *)(xy + 24) <= corner) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar2 < *(uint32 *)(xy + 24)) {
              uVar9 = Mathf.Lerp(*(uint32 *)(xy + 36 + uVar6 * 8),
                                  *(uint32 *)(xy + 36 + lVar5 * 8),sin,0);
              if (uVar3 < *(uint32 *)(xy + 24)) {
                *(uint32 *)(xy + 36 + lVar7 * 8) = uVar9;
                return;
              }
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        else {
          if (cos < sin) {
            cos = cos / sin;
            if (invert) {
              if (xy == null) throw; // [null/range check failed]
              if (*(uint32 *)(xy + 24) <= corner) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (*(uint32 *)(xy + 24) <= uVar2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              uVar9 = Mathf.Lerp(*(uint32 *)(xy + 32 + uVar6 * 8),
                                  *(uint32 *)(xy + 32 + lVar5 * 8),cos,0);
              if (*(uint32 *)(xy + 24) <= uVar2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              *(uint32 *)(xy + 32 + lVar5 * 8) = uVar9;
              if (*(uint32 *)(xy + 24) <= uVar2) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              if (*(uint32 *)(xy + 24) <= uVar3) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              sin = 1.0;
              *(uint32 *)(xy + 32 + lVar7 * 8) = uVar9;
              goto LAB_180a7e364;
            }
          }
          else {
            sin = 1.0;
            cos = 1.0;
            if (invert) goto LAB_180a7e35b;
          }
          if (xy != null) {
        LAB_180a7e2fd:
            if (*(uint32 *)(xy + 24) <= corner) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (uVar2 < *(uint32 *)(xy + 24)) {
              uVar9 = Mathf.Lerp(*(uint32 *)(xy + 32 + uVar6 * 8),
                                  *(uint32 *)(xy + 32 + lVar5 * 8),cos,0);
              if (uVar1 < *(uint32 *)(xy + 24)) {
                *(uint32 *)(xy + 32 + lVar8 * 8) = uVar9;
                return;
              }
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
    }

    // Token : 0x600046A
    // RVA   : 0xA7C5E0   Offset: 0xA7ADE0   Length: 0x23C
    private static void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
    {
                              uint32 v1x,uint32 v0y,uint32 v1y,uint32 u0x,
                              uint32 u1x,uint32 u0y,uint32 u1y,
                              uint32 *col)
        {
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        if (verts != null) {
          uStack_44 = v0y;
          uStack_40 = 0;
          local_48 = v0x;
          FUN_181805a40(verts,&local_48,DAT_181d84278);
          uStack_44 = v1y;
          uStack_40 = 0;
          local_48 = v0x;
          FUN_181805a40(verts,&local_48,DAT_181d84278);
          local_48 = v1x;
          uStack_44 = v1y;
          uStack_40 = 0;
          FUN_181805a40(verts,&local_48,DAT_181d84278);
          local_48 = v1x;
          uStack_44 = v0y;
          uStack_40 = 0;
          FUN_181805a40(verts,&local_48,DAT_181d84278);
          if (uvs != null) {
            FUN_181814e80(uvs,CONCAT44(u0y,u0x),DAT_181d83f78);
            FUN_181814e80(uvs,CONCAT44(u1y,u0x),DAT_181d83f78);
            FUN_181814e80(uvs,CONCAT44(u1y,u1x),DAT_181d83f78);
            FUN_181814e80(uvs,CONCAT44(u0y,u1x),DAT_181d83f78);
            if (cols != null) {
              local_48 = *col;
              uStack_44 = col[1];
              uStack_40 = col[2];
              uStack_3c = col[3];
              FUN_1818059b0(cols,&local_48,DAT_181d5b680);
              local_48 = *col;
              uStack_44 = col[1];
              uStack_40 = col[2];
              uStack_3c = col[3];
              FUN_1818059b0(cols,&local_48,DAT_181d5b680);
              local_48 = *col;
              uStack_44 = col[1];
              uStack_40 = col[2];
              uStack_3c = col[3];
              FUN_1818059b0(cols,&local_48,DAT_181d5b680);
              local_48 = *col;
              uStack_44 = col[1];
              uStack_40 = col[2];
              uStack_3c = col[3];
              FUN_1818059b0(cols,&local_48,DAT_181d5b680);
              return;
            }
          }
        }
    }

    // Token : 0x600046B
    // RVA   : 0xA80770   Offset: 0xA7EF70   Length: 0xAA
    protected void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        this.mFillDirection = 4;
        *(uint32 *)(this + 400) = 0x3f800000;
        puVar4 = (uint32 *)FUN_181098a50(local_18,0);
        uVar1 = puVar4[1];
        uVar2 = puVar4[2];
        uVar3 = puVar4[3];
        local_28 = 0;
        uStack_20 = 0;
        this.mGradientTop = *puVar4;
        *(uint32 *)(this + 0x1a4) = uVar1;
        *(uint32 *)(this + 0x1a8) = uVar2;
        *(uint32 *)(this + 0x1ac) = uVar3;
        Color.ctor(&local_28,0x3f333333,0x3f333333,0x3f333333,0);
        this.centerType = 1;
        this.leftType = 1;
        this.mGradientBottom = (uint32)local_28;
        *(uint32 *)(this + 0x1b4) = local_28._4_4_;
        *(uint32 *)(this + 0x1b8) = (uint32)uStack_20;
        *(uint32 *)(this + 0x1bc) = uStack_20._4_4_;
        this.rightType = 1;
        this.bottomType = 1;
        this.topType = 1;
        UIWidget.ctor(this,0);
    }

    // Token : 0x600046C
    // RVA   : 0xA806E0   Offset: 0xA7EEE0   Length: 0x88
    private static void /*cctor*/()
    {
        ulong uVar1;
        uVar1 = FUN_1800d60b0(DAT_181d81bc0,4);
        puVar2 = *(uint64 **)(DAT_181d8a358 + 184);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        uVar1 = FUN_1800d60b0(DAT_181d81bc0,4);
        puVar2 = (uint64 *)(*(int64 *)(DAT_181d8a358 + 184) + 8);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
    }

}
