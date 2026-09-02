// ============================================================
// Type  : UI2DSprite
// Token : 0x20000CF
// ============================================================

public class UI2DSprite
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40004DB
    private Sprite mSprite;

    // Token: 0x40004DC
    private Shader mShader;

    // Token: 0x40004DD
    private Vector4 mBorder;

    // Token: 0x40004DE
    private bool mFixedAspect;

    // Token: 0x40004DF
    private float mPixelSize;

    // Token: 0x40004E0
    public Sprite nextSprite;

    // Token: 0x40004E1
    private int mPMA;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600069E
    // RVA   : 0xA76E30   Offset: 0xA75630   Length: 0x8
    public Sprite get_sprite2D()
    {
        uint64 FUN_180a76e30(int64 this)
        {
        return this.mSprite;
    }

    // Token : 0x600069F
    // RVA   : 0xA77100   Offset: 0xA75900   Length: 0xC1
    public void set_sprite2D(Sprite value)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mSprite;
        cVar2 = Object.op_Inequality(uVar1,value,0);
        if (cVar2) {
          UIWidget.RemoveFromPanel(this,0);
          this.mSprite = value;
          this.nextSprite = 0;
          UIWidget.CreatePanel(this,0);
        }
    }

    // Token : 0x60006A0
    // RVA   : 0x2A5C70   Offset: 0x2A4470   Length: 0x8
    public override Material get_material()
    {
        return *(uint64 *)(this + 176);
    }

    // Token : 0x60006A1
    // RVA   : 0xA76F40   Offset: 0xA75740   Length: 0xBF
    public override void set_material(Material value)
    {
        long lVar1;
        bool cVar2;
        lVar1 = this[22];
        cVar2 = Object.op_Inequality(lVar1,value,0);
        if (cVar2) {
          UIWidget.RemoveFromPanel(this,0);
          this[22] = value;
          il2cpp_internal(this + 22,value);
          *(uint32 *)(this + 69) = 0xffffffff;
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x60006A2
    // RVA   : 0xA76D30   Offset: 0xA75530   Length: 0xF9
    public override Shader get_shader()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = *(uint64 *)(this + 176);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = this.mShader;
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (cVar1) {
            uVar2 = Shader.Find("Unlit/Transparent Colored",0);
            this.mShader = uVar2;
          }
          return this.mShader;
        }
        if (*(int64 *)(this + 176) != 0) {
          uVar2 = Material.get_shader(*(int64 *)(this + 176),0);
          return uVar2;
        }
    }

    // Token : 0x60006A3
    // RVA   : 0xA77000   Offset: 0xA75800   Length: 0xF5
    public override void set_shader(Shader value)
    {
        long lVar1;
        bool cVar2;
        lVar1 = this[64];
        cVar2 = Object.op_Inequality(lVar1,value,0);
        if (cVar2) {
          UIWidget.RemoveFromPanel(this,0);
          this[64] = value;
          il2cpp_internal(this + 64,value);
          lVar1 = this[22];
          cVar2 = Object.op_Equality(lVar1,0,0);
          if (cVar2) {
            *(uint32 *)(this + 69) = 0xffffffff;
            (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          }
        }
    }

    // Token : 0x60006A4
    // RVA   : 0xA76B50   Offset: 0xA75350   Length: 0xE1
    public override Texture get_mainTexture()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mSprite;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = *(uint64 *)(this + 176);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (!cVar1) {
            return 0;
          }
          if (*(int64 *)(this + 176) != 0) {
            uVar2 = Material.get_mainTexture(*(int64 *)(this + 176),0);
            return uVar2;
          }
        }
        else if (this.mSprite != null) {
          uVar2 = Sprite.get_texture(this.mSprite,0);
          return uVar2;
        }
    }

    // Token : 0x60006A5
    // RVA   : 0xA76B40   Offset: 0xA75340   Length: 0x8
    public bool get_fixedAspect()
    {
        uint8 FUN_180a76b40(int64 this)
        {
        return this.mFixedAspect;
    }

    // Token : 0x60006A6
    // RVA   : 0xA76ED0   Offset: 0xA756D0   Length: 0x6B
    public void set_fixedAspect(bool value)
    {
        ulong local_18;
        ulong uStack_10;
        if ((char)this[67] != value) {
          *(char *)(this + 67) = value;
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

    // Token : 0x60006A7
    // RVA   : 0xA76C50   Offset: 0xA75450   Length: 0xD5
    public override bool get_premultipliedAlpha()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = (uint64)*(uint32 *)(this + 69);
        if (*(uint32 *)(this + 69) != 0xffffffff) goto LAB_180a76d0f;
        lVar2 = (**(code **)(*this + 0x308))(this,*(uint64 *)(*this + 0x310));
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (!cVar1) {
        LAB_180a76d07:
          uVar3 = 0;
        }
        else {
          if (lVar2 == null) {
        LAB_180a76d20:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = Object.get_name(lVar2,0);
          if (lVar2 == null) goto LAB_180a76d20;
          cVar1 = String.Contains(lVar2,"Premultiplied",0);
          if (!cVar1) goto LAB_180a76d07;
          uVar3 = 1;
        }
        *(int *)(this + 69) = (int)uVar3;
        LAB_180a76d0f:
        return CONCAT71((int7)(uVar3 >> 8),(int)uVar3 == 1);
    }

    // Token : 0x60006A8
    // RVA   : 0xA76C40   Offset: 0xA75440   Length: 0x9
    public override float get_pixelSize()
    {
        uint32 FUN_180a76c40(int64 this)
        {
        return this.mPixelSize;
    }

    // Token : 0x60006A9
    // RVA   : 0xA76580   Offset: 0xA74D80   Length: 0x5BA
    public override Vector4 get_drawingDimensions()
    {
        long lVar1;
        bool cVar2;
        ulong uVar4;
        ulong local_c8;
        ulong uStack_c0;
        ulong local_b8;
        ulong uStack_b0;
        local_c8 = 0;
        uStack_c0 = 0;
        UIWidget.get_pivotOffset(param_2,0);
        lVar1 = param_2[63];
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if ((cVar2) && ((int)param_2[49] != 2)) {
          if (param_2[63] != 0) {
            puVar3 = (uint64 *)Sprite.get_rect(&local_b8,param_2[63],0);
            local_c8 = *puVar3;
            uStack_c0 = puVar3[1];
            uVar4 = FUN_180d90480(&local_c8,0);
            Mathf.RoundToInt(uVar4,0);
            if (param_2[63] != 0) {
              puVar3 = (uint64 *)Sprite.get_rect(&local_b8,param_2[63],0);
              local_c8 = *puVar3;
              uStack_c0 = puVar3[1];
              uVar4 = FUN_18044e2b0(&local_c8,0);
              Mathf.RoundToInt(uVar4,0);
              if (param_2[63] != 0) {
                Sprite.get_textureRectOffset(param_2[63],0);
                Mathf.RoundToInt();
                if (param_2[63] != 0) {
                  Sprite.get_textureRectOffset(param_2[63],0);
                  Mathf.RoundToInt();
                  if (param_2[63] != 0) {
                    puVar3 = (uint64 *)Sprite.get_rect(&local_b8,param_2[63],0);
                    local_c8 = *puVar3;
                    uStack_c0 = puVar3[1];
                    FUN_180d90480(&local_c8,0);
                    if (param_2[63] != 0) {
                      puVar3 = (uint64 *)Sprite.get_textureRect(&local_b8,param_2[63],0);
                      local_c8 = *puVar3;
                      uStack_c0 = puVar3[1];
                      FUN_180d90480(&local_c8,0);
                      if (param_2[63] != 0) {
                        Sprite.get_textureRectOffset(param_2[63],0);
                        Mathf.RoundToInt();
                        if (param_2[63] != 0) {
                          puVar3 = (uint64 *)Sprite.get_rect(&local_b8,param_2[63],0);
                          local_c8 = *puVar3;
                          uStack_c0 = puVar3[1];
                          FUN_18044e2b0(&local_c8,0);
                          if (param_2[63] != 0) {
                            puVar3 = (uint64 *)Sprite.get_textureRect(&local_b8,param_2[63],0);
                            local_c8 = *puVar3;
                            uStack_c0 = puVar3[1];
                            FUN_18044e2b0(&local_c8,0);
                            if (param_2[63] != 0) {
                              Sprite.get_textureRectOffset(param_2[63],0);
                              Mathf.RoundToInt();
                              goto LAB_180a76960;
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
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_180a76960:
        if ((char)param_2[67] == false) {
          (**(code **)(*param_2 + 0x378))(&local_b8,param_2,*(uint64 *)(*param_2 + 0x380));
          (**(code **)(*param_2 + 0x3d8))(param_2,*(uint64 *)(*param_2 + 0x3e0));
          local_b8 = 0;
          uStack_b0 = 0;
          FUN_1809981e0(&local_b8);
        }
        Mathf.Lerp();
        Mathf.Lerp();
        Mathf.Lerp();
        Mathf.Lerp();
        *this = 0;
        this[1] = 0;
        FUN_1809981e0(this);
        return this;
    }

    // Token : 0x60006AA
    // RVA   : 0xA76570   Offset: 0xA74D70   Length: 0xE
    public override Vector4 get_border()
    {
        uint64 * FUN_180a76570(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x210);
        *this = *(uint64 *)(param_2 + 0x208);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x60006AB
    // RVA   : 0xA76E40   Offset: 0xA75640   Length: 0x86
    public override void set_border(Vector4 value)
    {
        void FUN_180a76e40(int64 *this,float *value)
        {
        float fVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        fVar3 = *(float *)((int64)this + 0x20c) - value[1];
        fVar4 = *(float *)((int64)this + 0x214) - value[3];
        if (9.9999994e-11 <=
            fVar3 * fVar3 +
            (*(float *)(this + 65) - *value) * (*(float *)(this + 65) - *value) +
            (*(float *)(this + 66) - value[2]) * (*(float *)(this + 66) - value[2]) +
            fVar4 * fVar4) {
          fVar3 = *value;
          fVar4 = value[1];
          fVar1 = value[2];
          fVar2 = value[3];
          *(float *)(this + 65) = fVar3;
          *(float *)((int64)this + 0x20c) = fVar4;
          *(float *)(this + 66) = fVar1;
          *(float *)((int64)this + 0x214) = fVar2;
                          // WARNING: Could not recover jumptable at 0x000180a76ebe. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(fVar3,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x60006AC
    // RVA   : 0xA75FA0   Offset: 0xA747A0   Length: 0x4B1
    protected override void OnUpdate()
    {
        long lVar2;
        long lVar3;
        bool cVar4;
        int iVar5;
        int iVar6;
        int iVar7;
        int iVar8;
        int iVar9;
        int iVar10;
        ulong uVar11;
        float fVar13;
        float fVar14;
        ulong local_78;
        ulong uStack_70;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        ulong uStack_50;
        plVar1 = this + 68;
        lVar2 = *plVar1;
        cVar4 = Object.op_Inequality(lVar2,0,0);
        if (cVar4) {
          lVar2 = *plVar1;
          lVar3 = this[63];
          cVar4 = Object.op_Inequality(lVar2,lVar3,0);
          if (cVar4) {
            lVar2 = *plVar1;
            lVar3 = this[63];
            cVar4 = Object.op_Inequality(lVar3,lVar2,0);
            if (cVar4) {
              UIWidget.RemoveFromPanel(this,0);
              this[63] = lVar2;
              il2cpp_internal(this + 63,lVar2);
              *plVar1 = 0;
              il2cpp_internal(plVar1,0);
              UIWidget.CreatePanel(this,0);
            }
          }
          *plVar1 = 0;
          il2cpp_internal(plVar1,0);
        }
        UIWidget.OnUpdate(this,0);
        if ((char)this[67] != false) {
          uVar11 = (**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
          cVar4 = Object.op_Inequality(uVar11,0,0);
          if (cVar4) {
            if (this[63] != 0) {
              puVar12 = (uint64 *)Sprite.get_rect(&local_58,this[63],0);
              local_78 = *puVar12;
              uStack_70 = puVar12[1];
              uVar11 = FUN_180d90480(&local_78,0);
              iVar5 = Mathf.RoundToInt(uVar11,0);
              if (this[63] != 0) {
                puVar12 = (uint64 *)Sprite.get_rect(&local_58,this[63],0);
                local_78 = *puVar12;
                uStack_70 = puVar12[1];
                uVar11 = FUN_18044e2b0(&local_78,0);
                iVar6 = Mathf.RoundToInt(uVar11,0);
                if (this[63] != 0) {
                  Sprite.get_textureRectOffset(this[63],0);
                  iVar7 = Mathf.RoundToInt();
                  if (this[63] != 0) {
                    Sprite.get_textureRectOffset(this[63],0);
                    iVar8 = Mathf.RoundToInt();
                    if (this[63] != 0) {
                      puVar12 = (uint64 *)Sprite.get_rect(&local_58,this[63],0);
                      local_78 = *puVar12;
                      uStack_70 = puVar12[1];
                      FUN_180d90480(&local_78,0);
                      if (this[63] != 0) {
                        puVar12 = (uint64 *)Sprite.get_textureRect(&local_58,this[63],0);
                        local_78 = *puVar12;
                        uStack_70 = puVar12[1];
                        FUN_180d90480(&local_78,0);
                        if (this[63] != 0) {
                          Sprite.get_textureRectOffset(this[63],0);
                          iVar9 = Mathf.RoundToInt();
                          if (this[63] != 0) {
                            puVar12 = (uint64 *)Sprite.get_rect(&local_58,this[63],0);
                            local_78 = *puVar12;
                            uStack_70 = puVar12[1];
                            FUN_18044e2b0(&local_78,0);
                            if (this[63] != 0) {
                              puVar12 = (uint64 *)Sprite.get_textureRect(&local_58,this[63],0);
                              local_78 = *puVar12;
                              uStack_70 = puVar12[1];
                              FUN_18044e2b0(&local_78,0);
                              if (this[63] != 0) {
                                Sprite.get_textureRectOffset(this[63],0);
                                iVar10 = Mathf.RoundToInt();
                                fVar14 = (float)*(int *)((int64)this + 164);
                                fVar13 = (float)(iVar5 + iVar9 + iVar7) / (float)(iVar10 + iVar8 + iVar6);
                                local_68 = 0;
                                uStack_60 = 0;
                                if (fVar13 < fVar14 / (float)(int)this[21]) {
                                  fVar13 = ((fVar14 - fVar13 * (float)(int)this[21]) / fVar14) * 0.5;
                                }
                                else {
                                  fVar13 = 0.0;
                                }
                                FUN_1809981e0(&local_68,fVar13);
                                local_58 = local_68;
                                uStack_50 = uStack_60;
                                UIWidget.set_drawRegion(this,&local_58,0);
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
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x60006AD
    // RVA   : 0xA757A0   Offset: 0xA73FA0   Length: 0x20F
    public override void MakePixelPerfect()
    {
        bool cVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        float fVar7;
        float fVar8;
        float local_38;
        float fStack_34;
        float fStack_30;
        float fStack_2c;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        UIWidget.MakePixelPerfect(this,0);
        if ((int)this[49] != 2) {
          uVar4 = (**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
          cVar1 = Object.op_Equality(uVar4,0,0);
          if (!cVar1) {
            if (((int)this[49] != 0) && ((int)this[49] != 3)) {
              pfVar5 = (float *)(**(code **)(*this + 0x378))
                                          (&local_38,this,*(uint64 *)(*this + 0x380));
              local_38 = *pfVar5;
              fStack_34 = pfVar5[1];
              fStack_30 = pfVar5[2];
              fStack_2c = pfVar5[3];
              if (local_38 != 0.0) {
                return;
              }
              if (fStack_34 != 0.0) {
                return;
              }
              if (fStack_30 != 0.0) {
                return;
              }
              if (fStack_2c != 0.0) {
                return;
              }
            }
            cVar1 = Object.op_Inequality(uVar4,0,0);
            if (cVar1) {
              if (this[63] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              puVar6 = (uint32 *)Sprite.get_rect(&local_38,this[63],0);
              local_28 = *puVar6;
              uStack_24 = puVar6[1];
              uStack_20 = puVar6[2];
              uStack_1c = puVar6[3];
              fVar7 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              fVar8 = (float)FUN_180d90480(&local_28,0);
              uVar2 = Mathf.RoundToInt(fVar8 * fVar7,0);
              fVar7 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              fVar8 = (float)FUN_18044e2b0(&local_28,0);
              uVar3 = Mathf.RoundToInt(fVar8 * fVar7,0);
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

    // Token : 0x60006AE
    // RVA   : 0xA759B0   Offset: 0xA741B0   Length: 0x5E0
    public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        uint uVar1;
        long lVar2;
        float fVar3;
        bool cVar4;
        int iVar5;
        uint8 (*pauVar8) [16];
        uint64 *puVar9;
        float fVar10;
        uint8 auVar11 [16];
        uint8 auVar12 [16];
        uint8 auVar13 [16];
        int64 local_a8;
        int64 lStack_a0;
        int64 local_98;
        int64 lStack_90;
        int64 local_88;
        uint64 uStack_80;
        uint64 local_78;
        uint64 uStack_70;
        int64 local_68;
        int64 lStack_60;
        uint8 local_58 [48];
        plVar6 = (int64 *)(**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
        cVar4 = Object.op_Equality(plVar6,0,0);
        if (cVar4) {
          return;
        }
        lVar2 = this[63];
        cVar4 = Object.op_Inequality(lVar2,0,0);
        if (!cVar4) {
          if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          (**(code **)(*plVar6 + 0x178))(plVar6,*(uint64 *)(*plVar6 + 0x180));
          (**(code **)(*plVar6 + 0x198))(plVar6,*(uint64 *)(*plVar6 + 0x1a0));
          local_68 = 0;
          lStack_60 = 0;
          FUN_1809981e0(&local_68);
          local_a8 = local_68;
          lStack_a0 = lStack_60;
        }
        else {
          if (this[63] == 0) throw; // [null/range check failed]
          plVar7 = (int64 *)Sprite.get_textureRect(&local_68,this[63],0);
          local_a8 = *plVar7;
          lStack_a0 = plVar7[1];
        }
        local_98 = local_a8;
        lStack_90 = lStack_a0;
        pauVar8 = (uint8 (*) [16])
                  (**(code **)(*this + 0x378))(&local_68,this,*(uint64 *)(*this + 0x380));
        auVar11 = *pauVar8;
        fVar3 = auVar11._4_4_;
        fVar10 = (float)FUN_180d904a0(&local_a8,0);
        auVar11._0_4_ = auVar11._0_4_ + fVar10;
        Rect.set_xMin(&local_a8,auVar11._0_8_,0);
        fVar10 = (float)FUN_18044df60(&local_a8,0);
        auVar12._4_4_ = fVar3;
        auVar12._0_4_ = fVar3;
        auVar12._8_4_ = fVar3;
        auVar12._12_4_ = fVar3;
        auVar13._4_12_ = auVar12._4_12_;
        auVar13._0_4_ = fVar3 + fVar10;
        Rect.set_yMin(&local_a8,auVar13._0_8_,0);
        Rect.get_xMax(&local_a8,0);
        Rect.set_xMax(&local_a8);
        Rect.get_yMax(&local_a8,0);
        Rect.set_yMax(&local_a8);
        if (plVar6 != (int64 *)0) {
          (**(code **)(*plVar6 + 0x178))(plVar6,*(uint64 *)(*plVar6 + 0x180));
          (**(code **)(*plVar6 + 0x198))(plVar6,*(uint64 *)(*plVar6 + 0x1a0));
          FUN_180d904a0(&local_98,0);
          Rect.set_xMin(&local_98);
          Rect.get_xMax(&local_98,0);
          Rect.set_xMax(&local_98);
          FUN_18044df60(&local_98,0);
          Rect.set_yMin(&local_98);
          Rect.get_yMax(&local_98,0);
          Rect.set_yMax(&local_98);
          FUN_180d904a0(&local_a8,0);
          Rect.set_xMin(&local_a8);
          Rect.get_xMax(&local_a8,0);
          Rect.set_xMax(&local_a8);
          FUN_18044df60(&local_a8,0);
          Rect.set_yMin(&local_a8);
          Rect.get_yMax(&local_a8,0);
          Rect.set_yMax(&local_a8);
          if (verts != null) {
            uVar1 = *(uint32 *)(verts + 24);
            this[58] = local_98;
            this[59] = lStack_90;
            this[56] = local_a8;
            this[57] = lStack_a0;
            puVar9 = (uint64 *)
                     (**(code **)(*this + 0x2b8))(&local_68,this,*(uint64 *)(*this + 0x2c0));
            local_78 = *puVar9;
            uStack_70 = puVar9[1];
            plVar6 = (int64 *)UIBasicSprite.get_drawingUVs(&local_68,this,0);
            local_68 = *plVar6;
            lStack_60 = plVar6[1];
            local_88 = this[18];
            uStack_80 = CONCAT44(*(uint32 *)((int64)this + 140),(int)this[19]);
            cVar4 = (**(code **)(*this + 0x3c8))(this,*(uint64 *)(*this + 0x3d0));
            if (cVar4) {
              plVar6 = (int64 *)NGUITools.ApplyPMA(local_58,&local_88,0);
              local_88 = *plVar6;
              uStack_80 = plVar6[1];
            }
            iVar5 = (**(code **)(*this + 0x3a8))(this,*(uint64 *)(*this + 0x3b0));
            if (iVar5 == 0) {
              UIBasicSprite.SimpleFill(this,verts,uvs,cols,&local_78,&local_68,&local_88,0);
            }
            else if (iVar5 == 1) {
              UIBasicSprite.SlicedFill(this,verts,uvs,cols,&local_78,&local_68,&local_88,0);
            }
            else if (iVar5 == 2) {
              UIBasicSprite.TiledFill(this,verts,uvs,cols,&local_78,&local_88,0);
            }
            else if (iVar5 == 3) {
              UIBasicSprite.FilledFill(this,verts,uvs,cols,&local_78,&local_68,&local_88,0);
            }
            else if (iVar5 == 4) {
              UIBasicSprite.AdvancedFill(this,verts,uvs,cols,&local_78,&local_68,&local_88,0)
              ;
            }
            if (this[24] == 0) {
              return;
            }
            OnPostFillCallback.Invoke(this[24],this,uVar1,verts,uvs,cols,0);
            return;
          }
        }
    }

    // Token : 0x60006AF
    // RVA   : 0xA76460   Offset: 0xA74C60   Length: 0x10E
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        puVar5 = (uint32 *)Vector4.get_zero(&local_28,0);
        uVar1 = *puVar5;
        uVar2 = puVar5[1];
        uVar3 = puVar5[2];
        uVar4 = puVar5[3];
        this.mPixelSize = 0x3f800000;
        this.mPMA = 0xffffffff;
        this.mBorder = uVar1;
        *(uint32 *)(this + 0x20c) = uVar2;
        *(uint32 *)(this + 0x210) = uVar3;
        *(uint32 *)(this + 0x214) = uVar4;
        *(uint32 *)(this + 0x18c) = 4;
        *(uint32 *)(this + 400) = 0x3f800000;
        puVar5 = (uint32 *)FUN_181098a50(local_18,0);
        uVar1 = puVar5[1];
        uVar2 = puVar5[2];
        uVar3 = puVar5[3];
        local_28 = 0;
        uStack_20 = 0;
        *(uint32 *)(this + 0x1a0) = *puVar5;
        *(uint32 *)(this + 0x1a4) = uVar1;
        *(uint32 *)(this + 0x1a8) = uVar2;
        *(uint32 *)(this + 0x1ac) = uVar3;
        Color.ctor(&local_28,0x3f333333,0x3f333333,0x3f333333,0);
        *(uint32 *)(this + 0x1e0) = 1;
        *(uint32 *)(this + 0x1e4) = 1;
        *(uint32 *)(this + 0x1b0) = (uint32)local_28;
        *(uint32 *)(this + 0x1b4) = local_28._4_4_;
        *(uint32 *)(this + 0x1b8) = (uint32)uStack_20;
        *(uint32 *)(this + 0x1bc) = uStack_20._4_4_;
        *(uint32 *)(this + 0x1e8) = 1;
        *(uint32 *)(this + 0x1ec) = 1;
        *(uint32 *)(this + 0x1f0) = 1;
        UIWidget.ctor(this,0);
    }

}
