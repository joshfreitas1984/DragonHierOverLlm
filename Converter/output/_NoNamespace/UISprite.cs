// ============================================================
// Type  : UISprite
// Token : 0x200010B
// ============================================================

public class UISprite
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400069A
    private object mAtlas;

    // Token: 0x400069B
    private string mSpriteName;

    // Token: 0x400069C
    private bool mFixedAspect;

    // Token: 0x400069D
    private bool mFillCenter;

    // Token: 0x400069E
    protected UISpriteData mSprite;

    // Token: 0x400069F
    private bool mSpriteSet;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60008E2
    // RVA   : 0x1693060   Offset: 0x1691860   Length: 0xBD
    public override Texture get_mainTexture()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = 0;
        lVar2 = il2cpp_internal(this.mAtlas,DAT_181d55650);
        if (lVar2 != null) {
          lVar3 = FUN_180002970(0,DAT_181d55650,lVar2);
        }
        cVar1 = Object.op_Inequality(lVar3,0,0);
        if (cVar1) {
          if (lVar3 != null) {
            uVar4 = Material.get_mainTexture(lVar3,0);
            return uVar4;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x60008E3
    // RVA   : 0x10FCE70   Offset: 0x10FB670   Length: 0x8
    public override void set_mainTexture(Texture value)
    {
        void FUN_1810fce70(uint64 this,uint64 value)
        {
        UIWidget.set_mainTexture(this,value,0);
    }

    // Token : 0x60008E4
    // RVA   : 0x1693120   Offset: 0x1691920   Length: 0xB7
    public override Material get_material()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = *(uint64 *)(this + 176);
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (!cVar1) {
          lVar2 = il2cpp_internal(this.mAtlas,DAT_181d55650);
          if (lVar2 == null) {
            return 0;
          }
          uVar3 = FUN_180002970(0,DAT_181d55650,lVar2);
          return uVar3;
        }
        return uVar3;
    }

    // Token : 0x60008E5
    // RVA   : 0x10FCE80   Offset: 0x10FB680   Length: 0x8
    public override void set_material(Material value)
    {
        void FUN_1810fce80(uint64 this,uint64 value)
        {
        UIWidget.set_material(this,value,0);
    }

    // Token : 0x60008E6
    // RVA   : 0x16929F0   Offset: 0x16911F0   Length: 0x3D
    public INGUIAtlas get_atlas()
    {
        il2cpp_internal(this.mAtlas,DAT_181d55650);
    }

    // Token : 0x60008E7
    // RVA   : 0x1693670   Offset: 0x1691E70   Length: 0x219
    public void set_atlas(INGUIAtlas value)
    {
        bool cVar2;
        long lVar4;
        long lVar5;
        plVar3 = (int64 *)il2cpp_internal(this[63]);
        if (plVar3 != value) {
          UIWidget.RemoveFromPanel(this);
          if (value == (int64 *)0) {
            plVar3 = (int64 *)0;
          }
          else {
            plVar3 = value;
          }
          this[63] = (int64)plVar3;
          il2cpp_internal(this + 63);
          *(uint8 *)(this + 67) = 0;
          this[66] = 0;
          il2cpp_internal(this + 66,0);
          plVar3 = this + 64;
          cVar2 = FUN_180d6ca90(*plVar3,0);
          if ((cVar2) && (lVar4 = il2cpp_internal(this[63],DAT_181d55650)) != null) {
            lVar5 = FUN_180002970(2,DAT_181d55650,lVar4);
            if (lVar5 == null) goto LAB_181693884;
            if (0 < *(int *)(lVar5 + 24)) {
              lVar4 = FUN_180002970(2,DAT_181d55650,lVar4);
              if (lVar4 == null) {
        LAB_181693884:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(int *)(lVar4 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              UISprite.SetAtlasSprite(this,*(uint64 *)(*(int64 *)(lVar4 + 16) + 32),0);
              if (this[66] == 0) goto LAB_181693884;
              *plVar3 = *(int64 *)(this[66] + 16);
              il2cpp_internal(plVar3);
            }
          }
          cVar2 = FUN_180d6ca90(*plVar3,0);
          if (!cVar2) {
            lVar4 = *plVar3;
            *plVar3 = "";
            il2cpp_internal(plVar3);
            UISprite.set_spriteName(this,lVar4,0);
            (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          }
        }
    }

    // Token : 0x60008E8
    // RVA   : 0x1693010   Offset: 0x1691810   Length: 0x8
    public bool get_fixedAspect()
    {
        uint8 FUN_181693010(int64 this)
        {
        return this.mFixedAspect;
    }

    // Token : 0x60008E9
    // RVA   : 0x16938C0   Offset: 0x16920C0   Length: 0x6B
    public void set_fixedAspect(bool value)
    {
        ulong local_18;
        ulong uStack_10;
        if ((char)this[65] != value) {
          *(char *)(this + 65) = value;
          local_18 = 0;
          uStack_10 = 0;
          FUN_1809981e0(&local_18,0,0,0x3f800000,0x3f800000,0);
          *(uint32 *)((int64)this + 252) = (uint32)local_18;
          *(uint32 *)(this + 32) = local_18._4_4_;
          *(uint32 *)((int64)this + 0x104) = (uint32)uStack_10;
          *(uint32 *)(this + 33) = uStack_10._4_4_;
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x60008EA
    // RVA   : 0x1692150   Offset: 0x1690950   Length: 0x8C
    public UISpriteData GetSprite(string spriteName)
    {
        long lVar1;
        lVar1 = il2cpp_internal(this.mAtlas,DAT_181d55650);
        if (lVar1 != null) {
          FUN_180002aa0(10,DAT_181d55650,lVar1,spriteName);
          return;
        }
    }

    // Token : 0x60008EB
    // RVA   : 0x1692390   Offset: 0x1690B90   Length: 0x34
    public override void MarkAsChanged()
    {
        this.mSprite = 0;
        this.mSpriteSet = 0;
        UIWidget.MarkAsChanged(this,0);
    }

    // Token : 0x60008EC
    // RVA   : 0x111E430   Offset: 0x111CC30   Length: 0x8
    public string get_spriteName()
    {
        uint64 FUN_18111e430(int64 this)
        {
        return this.mSpriteName;
    }

    // Token : 0x60008ED
    // RVA   : 0x1693A10   Offset: 0x1692210   Length: 0xC9
    public void set_spriteName(string value)
    {
        bool cVar1;
        cVar1 = FUN_180d6ca90(value,0);
        if (!cVar1) {
          cVar1 = String.op_Inequality(this[64],value,0);
          if (!cVar1) {
            return;
          }
          this[64] = value;
        }
        else {
          cVar1 = FUN_180d6ca90(this[64],0);
          value = "";
          if (cVar1) {
            return;
          }
          this[64] = "";
        }
        il2cpp_internal(this + 64,value);
        this[66] = 0;
        il2cpp_internal(this + 66,0);
        *(uint8 *)(this + 11) = 1;
        *(uint8 *)(this + 67) = 0;
        (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
    }

    // Token : 0x60008EE
    // RVA   : 0x1693040   Offset: 0x1691840   Length: 0x16
    public bool get_isValid()
    {
        long lVar1;
        lVar1 = UISprite.GetAtlasSprite(this,0);
        return lVar1 != null;
    }

    // Token : 0x60008EF
    // RVA   : 0x1693000   Offset: 0x1691800   Length: 0xB
    public bool get_fillCenter()
    {
        bool FUN_181693000(int64 this)
        {
        return *(int *)(this + 0x1e0) != 0;
    }

    // Token : 0x60008F0
    // RVA   : 0x1693890   Offset: 0x1692090   Length: 0x2D
    public void set_fillCenter(bool value)
    {
        void FUN_181693890(int64 *this,byte value)
        {
        if ((uint32)value != (uint32)((int)this[60] != 0)) {
          *(uint32 *)(this + 60) = (uint32)value;
                          // WARNING: Could not recover jumptable at 0x0001816938b5. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x60008F1
    // RVA   : 0x16929E0   Offset: 0x16911E0   Length: 0x8
    public bool get_applyGradient()
    {
        uint8 FUN_1816929e0(int64 this)
        {
        return *(uint8 *)(this + 0x19c);
    }

    // Token : 0x60008F2
    // RVA   : 0x1693650   Offset: 0x1691E50   Length: 0x20
    public void set_applyGradient(bool value)
    {
        void FUN_181693650(int64 *this,char value)
        {
        if (*(char *)((int64)this + 0x19c) != value) {
          *(char *)((int64)this + 0x19c) = value;
                          // WARNING: Could not recover jumptable at 0x000181693668. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x60008F3
    // RVA   : 0x1693030   Offset: 0x1691830   Length: 0xE
    public Color get_gradientTop()
    {
        uint64 * FUN_181693030(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x1a8);
        *this = *(uint64 *)(param_2 + 0x1a0);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x60008F4
    // RVA   : 0x16939A0   Offset: 0x16921A0   Length: 0x6B
    public void set_gradientTop(Color value)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        bool cVar4;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_28 = *value;
        uStack_20 = value[1];
        local_18 = (uint32)this[52];
        uStack_14 = *(uint32 *)((int64)this + 0x1a4);
        uStack_10 = (uint32)this[53];
        uStack_c = *(uint32 *)((int64)this + 0x1ac);
        cVar4 = Color.op_Inequality(&local_18,&local_28,0);
        if (cVar4) {
          uVar1 = *(uint32 *)((int64)value + 4);
          uVar2 = *(uint32 *)(value + 1);
          uVar3 = *(uint32 *)((int64)value + 12);
          *(uint32 *)(this + 52) = *(uint32 *)value;
          *(uint32 *)((int64)this + 0x1a4) = uVar1;
          *(uint32 *)(this + 53) = uVar2;
          *(uint32 *)((int64)this + 0x1ac) = uVar3;
          if (*(char *)((int64)this + 0x19c) != false) {
            (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          }
        }
    }

    // Token : 0x60008F5
    // RVA   : 0x1693020   Offset: 0x1691820   Length: 0xE
    public Color get_gradientBottom()
    {
        uint64 * FUN_181693020(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x1b8);
        *this = *(uint64 *)(param_2 + 0x1b0);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x60008F6
    // RVA   : 0x1693930   Offset: 0x1692130   Length: 0x6B
    public void set_gradientBottom(Color value)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        bool cVar4;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_28 = *value;
        uStack_20 = value[1];
        local_18 = (uint32)this[54];
        uStack_14 = *(uint32 *)((int64)this + 0x1b4);
        uStack_10 = (uint32)this[55];
        uStack_c = *(uint32 *)((int64)this + 0x1bc);
        cVar4 = Color.op_Inequality(&local_18,&local_28,0);
        if (cVar4) {
          uVar1 = *(uint32 *)((int64)value + 4);
          uVar2 = *(uint32 *)(value + 1);
          uVar3 = *(uint32 *)((int64)value + 12);
          *(uint32 *)(this + 54) = *(uint32 *)value;
          *(uint32 *)((int64)this + 0x1b4) = uVar1;
          *(uint32 *)(this + 55) = uVar2;
          *(uint32 *)((int64)this + 0x1bc) = uVar3;
          if (*(char *)((int64)this + 0x19c) != false) {
            (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          }
        }
    }

    // Token : 0x60008F7
    // RVA   : 0x1692A30   Offset: 0x1691230   Length: 0x9A
    public override Vector4 get_border()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        int iVar4;
        ulong uVar5;
        long lVar6;
        byte[] local_18 = new byte[16];
        lVar6 = UISprite.GetAtlasSprite(param_2,0);
        if (lVar6 != null) {
          uVar1 = *(uint32 *)(lVar6 + 40);
          uVar2 = *(uint32 *)(lVar6 + 52);
          uVar3 = *(uint32 *)(lVar6 + 44);
          iVar4 = *(int *)(lVar6 + 48);
          *this = 0;
          this[1] = 0;
          FUN_1809981e0(this,uVar3,uVar2,uVar1,(float)iVar4,0);
          return this;
        }
        puVar7 = (uint64 *)UIWidget.get_border(local_18,param_2,0);
        uVar5 = puVar7[1];
        *this = *puVar7;
        this[1] = uVar5;
        return this;
    }

    // Token : 0x60008F8
    // RVA   : 0x16934A0   Offset: 0x1691CA0   Length: 0x89
    protected override Vector4 get_padding()
    {
        long lVar1;
        this[0] = 0.0;
        this[1] = 0.0;
        this[2] = 0.0;
        this[3] = 0.0;
        lVar1 = UISprite.GetAtlasSprite(param_2,0);
        FUN_1809981e0(this);
        if (lVar1 != null) {
          *this = (float)*(int *)(lVar1 + 56);
          this[1] = (float)*(int *)(lVar1 + 68);
          this[2] = (float)*(int *)(lVar1 + 60);
          this[3] = (float)*(int *)(lVar1 + 64);
        }
        return this;
    }

    // Token : 0x60008F9
    // RVA   : 0x1693530   Offset: 0x1691D30   Length: 0xB4
    public override float get_pixelSize()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = this.mAtlas;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (!cVar1) {
          lVar2 = il2cpp_internal(this.mAtlas,DAT_181d55650);
          if (lVar2 != null) {
            uVar3 = FUN_180149d90(5,DAT_181d55650,lVar2);
            return uVar3;
          }
        }
        return 0x3f800000;
    }

    // Token : 0x60008FA
    // RVA   : 0x1693340   Offset: 0x1691B40   Length: 0x151
    public override int get_minWidth()
    {
        uint uVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        int iVar6;
        uint uVar7;
        uint uVar8;
        long lVar10;
        float fVar11;
        float fVar12;
        ulong local_38;
        ulong uStack_30;
        iVar6 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
        if (iVar6 != 1) {
          iVar6 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
          if (iVar6 != 4) {
            UIBasicSprite.get_minWidth(this,0);
            return;
          }
        }
        fVar11 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        pfVar9 = (float *)(**(code **)(*this + 0x378))
                                    (&local_38,this,*(uint64 *)(*this + 0x380));
        fVar2 = *pfVar9;
        fVar3 = pfVar9[1];
        fVar4 = pfVar9[2];
        fVar5 = pfVar9[3];
        fVar12 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        local_38 = 0;
        uStack_30 = 0;
        FUN_1809981e0(&local_38,fVar2 * fVar12,fVar3 * fVar12,fVar4 * fVar12,fVar5 * fVar12,0);
        uVar7 = Mathf.RoundToInt((float)uStack_30 + (float)local_38,0);
        lVar10 = UISprite.GetAtlasSprite(this,0);
        if (lVar10 != null) {
          iVar6 = Mathf.RoundToInt((float)(*(int *)(lVar10 + 56) + *(int *)(lVar10 + 60)) * fVar11,0)
          ;
          uVar7 = uVar7 + iVar6;
        }
        uVar8 = UIBasicSprite.get_minWidth(this,0);
        uVar1 = uVar7 + 1;
        if ((uVar7 & 1) == 0) {
          uVar1 = uVar7;
        }
        Mathf.Max(uVar8,uVar1,0);
    }

    // Token : 0x60008FB
    // RVA   : 0x16931E0   Offset: 0x16919E0   Length: 0x151
    public override int get_minHeight()
    {
        uint uVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        int iVar6;
        uint uVar7;
        uint uVar8;
        long lVar10;
        float fVar11;
        float fVar12;
        ulong local_38;
        ulong uStack_30;
        iVar6 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
        if (iVar6 != 1) {
          iVar6 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
          if (iVar6 != 4) {
            UIBasicSprite.get_minHeight(this,0);
            return;
          }
        }
        fVar11 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        pfVar9 = (float *)(**(code **)(*this + 0x378))
                                    (&local_38,this,*(uint64 *)(*this + 0x380));
        fVar2 = *pfVar9;
        fVar3 = pfVar9[1];
        fVar4 = pfVar9[2];
        fVar5 = pfVar9[3];
        fVar12 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
        local_38 = 0;
        uStack_30 = 0;
        FUN_1809981e0(&local_38,fVar2 * fVar12,fVar3 * fVar12,fVar4 * fVar12,fVar5 * fVar12,0);
        uVar7 = Mathf.RoundToInt(uStack_30._4_4_ + local_38._4_4_,0);
        lVar10 = UISprite.GetAtlasSprite(this,0);
        if (lVar10 != null) {
          iVar6 = Mathf.RoundToInt((float)(*(int *)(lVar10 + 64) + *(int *)(lVar10 + 68)) * fVar11,0)
          ;
          uVar7 = uVar7 + iVar6;
        }
        uVar8 = UIBasicSprite.get_minHeight(this,0);
        uVar1 = uVar7 + 1;
        if ((uVar7 & 1) == 0) {
          uVar1 = uVar7;
        }
        Mathf.Max(uVar8,uVar1,0);
    }

    // Token : 0x60008FC
    // RVA   : 0x1692AD0   Offset: 0x16912D0   Length: 0x526
    public override Vector4 get_drawingDimensions()
    {
        int iVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        bool cVar5;
        long lVar6;
        float fVar8;
        ulong local_a8;
        ulong uStack_a0;
        UIWidget.get_pivotOffset(param_2,0);
        lVar6 = UISprite.GetAtlasSprite(param_2,0);
        if ((lVar6 != null) && ((int)param_2[49] != 2)) {
          lVar6 = param_2[66];
          if (lVar6 != null) {
            iVar1 = *(int *)(lVar6 + 56);
            iVar2 = *(int *)(lVar6 + 68);
            iVar3 = *(int *)(lVar6 + 60);
            iVar4 = *(int *)(lVar6 + 64);
            if (((int)param_2[49] != 0) &&
               (fVar8 = (float)(**(code **)(*param_2 + 0x3d8))(param_2,*(uint64 *)(*param_2 + 0x3e0)),
               fVar8 != 1.0)) {
              Mathf.RoundToInt((float)iVar1 * fVar8,0);
              Mathf.RoundToInt((float)iVar2 * fVar8,0);
              Mathf.RoundToInt((float)iVar3 * fVar8,0);
              Mathf.RoundToInt((float)iVar4 * fVar8,0);
            }
            if (param_2[66] == 0)
            {
              }
              // WARNING: Subroutine does not return
              FUN_1800d6620();
              }
            }
        if ((((*(float *)((int64)param_2 + 252) == 0.0) && (*(float *)(param_2 + 32) == 0.0)) &&
            (*(float *)((int64)param_2 + 0x104) == 1.0)) && (*(float *)(param_2 + 33) == 0.0)) {
          *this = 0;
          this[1] = 0;
          FUN_1809981e0(this);
        }
        else {
          if ((char)param_2[65] == false) {
            lVar6 = param_2[63];
            cVar5 = Object.op_Inequality(lVar6,0,0);
            if (!cVar5) {
              puVar7 = (uint64 *)Vector4.get_zero(&local_a8,0);
              local_a8 = *puVar7;
              uStack_a0 = puVar7[1];
            }
            else {
              (**(code **)(*param_2 + 0x378))(&local_a8,param_2,*(uint64 *)(*param_2 + 0x380));
              (**(code **)(*param_2 + 0x3d8))(param_2,*(uint64 *)(*param_2 + 0x3e0));
              local_a8 = 0;
              uStack_a0 = 0;
              FUN_1809981e0(&local_a8);
            }
          }
          Mathf.Lerp();
          Mathf.Lerp();
          Mathf.Lerp();
          Mathf.Lerp();
          *this = 0;
          this[1] = 0;
          FUN_1809981e0(this);
        }
        return this;
    }

    // Token : 0x60008FD
    // RVA   : 0x16935F0   Offset: 0x1691DF0   Length: 0x5C
    public override bool get_premultipliedAlpha()
    {
        long lVar1;
        lVar1 = il2cpp_internal(this.mAtlas,DAT_181d55650);
        if (lVar1 == null) {
          return;
        }
        FUN_180002970(7,DAT_181d55650,lVar1);
    }

    // Token : 0x60008FE
    // RVA   : 0x1691F00   Offset: 0x1690700   Length: 0x246
    public UISpriteData GetAtlasSprite()
    {
        bool cVar1;
        long lVar3;
        ulong uVar4;
        if (!this.mSpriteSet) {
          this.mSprite = 0;
        }
        if ((this.mSprite == null) &&
           (plVar2 = (int64 *)il2cpp_internal(this.mAtlas,DAT_181d55650),
           plVar2 != (int64 *)0)) {
          cVar1 = FUN_180d6ca90(this.mSpriteName,0);
          if (!cVar1) {
            lVar3 = FUN_180002aa0(10,DAT_181d55650,plVar2,this.mSpriteName);
            if (lVar3 == null) {
              return 0;
            }
            UISprite.SetAtlasSprite(this,lVar3,0);
          }
          if (this.mSprite == null) {
            lVar3 = FUN_180002970(2,DAT_181d55650,plVar2);
            if (lVar3 != null) {
              if (*(int *)(lVar3 + 24) < 1) goto LAB_18169209e;
              lVar3 = FUN_180002970(2,DAT_181d55650,plVar2);
              if (lVar3 != null) {
                if (*(int *)(lVar3 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = *(int64 *)(*(int64 *)(lVar3 + 16) + 32);
                if (lVar3 != null) {
                  UISprite.SetAtlasSprite(this,lVar3,0);
                  if (this.mSprite != null) {
                    this.mSpriteName =
                         this.mSprite.name;
                    il2cpp_internal(this + 0x200);
                    goto LAB_18169209e;
                  }
                  if ((*(byte *)(*plVar2 + 300) < *(byte *)(DAT_181d68fe8 + 300)) ||
                     (*(int64 *)
                       (*(int64 *)(*plVar2 + 200) + -8 + (uint64)*(byte *)(DAT_181d68fe8 + 300) * 8)
                      != DAT_181d68fe8)) goto LAB_181692141;
                  uVar4 = Object.get_name(plVar2,0);
                  uVar4 = String.Concat(uVar4," seems to have a null sprite!",0);
                  Debug.LogError(uVar4,0);
                }
                return 0;
              }
            }
        LAB_181692141:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        LAB_18169209e:
        return this.mSprite;
    }

    // Token : 0x60008FF
    // RVA   : 0x16928C0   Offset: 0x16910C0   Length: 0xB7
    protected void SetAtlasSprite(UISpriteData sp)
    {
        ulong uVar2;
        long lVar3;
        *(uint8 *)(this + 88) = 1;
        plVar1 = &this.mSprite;
        this.mSpriteSet = 1;
        if (sp == null) {
          uVar2 = "";
          if (this.mSprite != null) {
            uVar2 = this.mSprite.name;
          }
          this.mSpriteName = uVar2;
          lVar3 = 0;
          this.mSprite = 0;
        }
        else {
          this.mSprite = sp;
          il2cpp_internal(plVar1,sp);
          if (this.mSprite == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar3 = this.mSprite.name;
          this.mSpriteName = lVar3;
        }
        il2cpp_internal(plVar1,lVar3);
    }

    // Token : 0x6000900
    // RVA   : 0x16921E0   Offset: 0x16909E0   Length: 0x1AE
    public override void MakePixelPerfect()
    {
        bool cVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        lVar4 = UISprite.GetAtlasSprite(this,0);
        if (((lVar4 != null) && (UIWidget.MakePixelPerfect(this,0), (int)this[49] != 2)) &&
           (lVar4 = UISprite.GetAtlasSprite(this,0)) != null) {
          uVar5 = (**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
          cVar1 = Object.op_Equality(uVar5,0,0);
          if ((!cVar1) &&
             ((((int)this[49] == 0 || ((int)this[49] == 3)) ||
              (((*(int *)(lVar4 + 52) == 0 && *(int *)(lVar4 + 48) == 0) &&
               *(int *)(lVar4 + 44) == 0) && *(int *)(lVar4 + 40) == 0)))) {
            cVar1 = Object.op_Inequality(uVar5,0,0);
            if (cVar1) {
              fVar6 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              uVar2 = Mathf.RoundToInt((float)(*(int *)(lVar4 + 60) + *(int *)(lVar4 + 56) +
                                               *(int *)(lVar4 + 32)) * fVar6,0);
              fVar6 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              uVar3 = Mathf.RoundToInt((float)(*(int *)(lVar4 + 68) + *(int *)(lVar4 + 64) +
                                               *(int *)(lVar4 + 36)) * fVar6,0);
              if ((uVar2 & 1) != 0) {
                uVar2 = uVar2 + 1;
              }
              if ((uVar3 & 1) != 0) {
                uVar3 = uVar3 + 1;
              }
              UIWidget.set_width(this,uVar2,0);
              UIWidget.set_height(this,uVar3,0);
            }
          }
        }
    }

    // Token : 0x6000901
    // RVA   : 0x16926C0   Offset: 0x1690EC0   Length: 0x21
    protected override void OnInit()
    {
        void FUN_1816926c0(int64 this)
        {
        if (!this.mFillCenter) {
          this.mFillCenter = 1;
          *(uint32 *)(this + 0x1e0) = 0;
        }
        UIWidget.OnInit(this,0);
    }

    // Token : 0x6000902
    // RVA   : 0x16926F0   Offset: 0x1690EF0   Length: 0x1CB
    protected override void OnUpdate()
    {
        int iVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        int iVar7;
        long lVar8;
        float fVar9;
        float fVar10;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        UIWidget.OnUpdate(this,0);
        if ((*(char *)(this + 88) != false) || (!this.mSpriteSet)) {
          this.mSpriteSet = true;
          this.mSprite = 0;
          *(uint8 *)(this + 88) = 1;
        }
        if (this.mFixedAspect) {
          if (((!this.mSpriteSet) || (this.mSprite == null)) &&
             (lVar8 = UISprite.GetAtlasSprite(this,0)) == null) {
            return;
          }
          lVar8 = this.mSprite;
          if (lVar8 != null) {
            iVar2 = lVar8.paddingLeft;
            iVar3 = lVar8.paddingRight;
            iVar4 = lVar8.paddingBottom;
            iVar5 = lVar8.paddingTop;
            iVar6 = Mathf.RoundToInt();
            if (this.mSprite == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            iVar7 = Mathf.RoundToInt(this.mSprite,0);
            fVar10 = (float)*(int *)(this + 164);
            fVar9 = (float)(iVar6 + iVar3 + iVar2) / (float)(iVar7 + iVar5 + iVar4);
            local_38 = 0;
            uStack_30 = 0;
            if (fVar9 < fVar10 / (float)*(int *)(this + 168)) {
              fVar9 = ((fVar10 - fVar9 * (float)*(int *)(this + 168)) / fVar10) * 0.5;
            }
            else {
              fVar9 = 0.0;
            }
            FUN_1809981e0(&local_38,fVar9);
            local_28 = local_38;
            uStack_20 = uStack_30;
            UIWidget.set_drawRegion(this,&local_28,0);
          }
        }
    }

    // Token : 0x6000903
    // RVA   : 0x16923D0   Offset: 0x1690BD0   Length: 0x2EE
    public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        uint uVar5;
        long lVar7;
        ulong uVar9;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        local_68 = 0;
        uStack_60 = 0;
        local_58 = 0;
        uStack_50 = 0;
        plVar6 = (int64 *)(**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
        cVar3 = Object.op_Equality(plVar6,0,0);
        if ((!cVar3) &&
           ((((char)this[67] != false && (this[66] != 0)) ||
            (lVar7 = UISprite.GetAtlasSprite(this,0)) != null))) {
          if ((this[66] != 0) && (FUN_1809981e0(&local_68), this[66] != 0)) {
            uVar9 = 0;
            FUN_1809981e0(&local_58);
            uVar2 = uStack_60;
            uVar1 = local_68;
            if (plVar6 != (int64 *)0) {
              uVar4 = (**(code **)(*plVar6 + 0x178))(plVar6,*(uint64 *)(*plVar6 + 0x180));
              uVar5 = (**(code **)(*plVar6 + 0x198))(plVar6,*(uint64 *)(*plVar6 + 0x1a0));
              local_48 = uVar1;
              uStack_40 = uVar2;
              puVar8 = (uint64 *)NGUIMath.ConvertToTexCoords(&local_38,&local_48,uVar4,uVar5,0,uVar9)
              ;
              uVar2 = uStack_50;
              uVar1 = local_58;
              local_68 = *puVar8;
              uStack_60 = puVar8[1];
              uVar4 = (**(code **)(*plVar6 + 0x178))(plVar6,*(uint64 *)(*plVar6 + 0x180));
              uVar5 = (**(code **)(*plVar6 + 0x198))(plVar6,*(uint64 *)(*plVar6 + 0x1a0));
              local_48 = uVar1;
              uStack_40 = uVar2;
              puVar8 = (uint64 *)NGUIMath.ConvertToTexCoords(&local_38,&local_48,uVar4,uVar5,0);
              local_58 = *puVar8;
              uStack_50 = puVar8[1];
              if (verts != null) {
                local_48 = *puVar8;
                uStack_40 = puVar8[1];
                uVar4 = *(uint32 *)(verts + 24);
                local_38 = local_68;
                uStack_30 = uStack_60;
                UIBasicSprite.Fill(this,verts,uvs,cols,&local_38,&local_48,0);
                if (this[24] == 0) {
                  return;
                }
                OnPostFillCallback.Invoke(this[24],this,uVar4,verts,uvs,cols,0);
                return;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000904
    // RVA   : 0x1692980   Offset: 0x1691180   Length: 0x59
    public void /*ctor*/()
    {
        this.mFillCenter = 1;
        UIBasicSprite.ctor(this,0);
    }

}
