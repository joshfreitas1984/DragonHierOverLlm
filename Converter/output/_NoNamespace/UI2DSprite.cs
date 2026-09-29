// ============================================================
// Type  : UI2DSprite
// Token : 0x20000D0
// ============================================================

public class UI2DSprite
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40004F7
    private Sprite mSprite;

    // Token: 0x40004F8
    private Shader mShader;

    // Token: 0x40004F9
    private Vector4 mBorder;

    // Token: 0x40004FA
    private bool mFixedAspect;

    // Token: 0x40004FB
    private float mPixelSize;

    // Token: 0x40004FC
    public Sprite nextSprite;

    // Token: 0x40004FD
    private int mPMA;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60006B6
    // RVA   : 0xAF0F10   Offset: 0xAF0310   Length: 0x8
    public Sprite get_sprite2D()
    {
        uint64 FUN_180af0f10(int64 this)
        {
        return this.mSprite;
    }

    // Token : 0x60006B7
    // RVA   : 0xAF11E0   Offset: 0xAF05E0   Length: 0xC1
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

    // Token : 0x60006B8
    // RVA   : 0x2A5C70   Offset: 0x2A5070   Length: 0x8
    public override Material get_material()
    {
        return *(uint64 *)(this + 176);
    }

    // Token : 0x60006B9
    // RVA   : 0xAF1020   Offset: 0xAF0420   Length: 0xBF
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

    // Token : 0x60006BA
    // RVA   : 0xAF0E10   Offset: 0xAF0210   Length: 0xF9
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

    // Token : 0x60006BB
    // RVA   : 0xAF10E0   Offset: 0xAF04E0   Length: 0xF5
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

    // Token : 0x60006BC
    // RVA   : 0xAF0C30   Offset: 0xAF0030   Length: 0xE1
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

    // Token : 0x60006BD
    // RVA   : 0xAF0C20   Offset: 0xAF0020   Length: 0x8
    public bool get_fixedAspect()
    {
        uint8 FUN_180af0c20(int64 this)
        {
        return this.mFixedAspect;
    }

    // Token : 0x60006BE
    // RVA   : 0xAF0FB0   Offset: 0xAF03B0   Length: 0x6B
    public void set_fixedAspect(bool value)
    {
        ulong local_18;
        ulong uStack_10;
        if ((char)this[67] != value) {
          *(char *)(this + 67) = value;
          local_18 = 0;
          uStack_10 = 0;
          FUN_1809dcfa0(&local_18,0,0,0x3f800000,0x3f800000,0);
          *(uint32 *)((int64)this + 252) = (uint32)local_18;
          *(uint32 *)(this + 32) = local_18._4_4_;
          *(uint32 *)((int64)this + 0x104) = (uint32)uStack_10;
          *(uint32 *)(this + 33) = uStack_10._4_4_;
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x60006BF
    // RVA   : 0xAF0D30   Offset: 0xAF0130   Length: 0xD5
    public override bool get_premultipliedAlpha()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = (uint64)*(uint32 *)(this + 69);
        if (*(uint32 *)(this + 69) != 0xffffffff) goto LAB_180af0def;
        lVar2 = (**(code **)(*this + 0x308))(this,*(uint64 *)(*this + 0x310));
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (!cVar1) {
        LAB_180af0de7:
          uVar3 = 0;
        }
        else {
          if (lVar2 == null) {
        LAB_180af0e00:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = Object.get_name(lVar2,0);
          if (lVar2 == null) goto LAB_180af0e00;
          cVar1 = String.Contains(lVar2,"Premultiplied",0);
          if (!cVar1) goto LAB_180af0de7;
          uVar3 = 1;
        }
        *(int *)(this + 69) = (int)uVar3;
        LAB_180af0def:
        return CONCAT71((int7)(uVar3 >> 8),(int)uVar3 == 1);
    }

    // Token : 0x60006C0
    // RVA   : 0xAF0D20   Offset: 0xAF0120   Length: 0x9
    public override float get_pixelSize()
    {
        uint32 FUN_180af0d20(int64 this)
        {
        return this.mPixelSize;
    }

    // Token : 0x60006C1
    // RVA   : 0xAF0660   Offset: 0xAEFA60   Length: 0x5BA
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
            uVar4 = FUN_180d995b0(&local_c8,0);
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
                    FUN_180d995b0(&local_c8,0);
                    if (param_2[63] != 0) {
                      puVar3 = (uint64 *)Sprite.get_textureRect(&local_b8,param_2[63],0);
                      local_c8 = *puVar3;
                      uStack_c0 = puVar3[1];
                      FUN_180d995b0(&local_c8,0);
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
                              goto LAB_180af0a40;
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
        LAB_180af0a40:
        if ((char)param_2[67] == false) {
          (**(code **)(*param_2 + 0x378))(&local_b8,param_2,*(uint64 *)(*param_2 + 0x380));
          (**(code **)(*param_2 + 0x3d8))(param_2,*(uint64 *)(*param_2 + 0x3e0));
          local_b8 = 0;
          uStack_b0 = 0;
          FUN_1809dcfa0(&local_b8);
        }
        Mathf.Lerp();
        Mathf.Lerp();
        Mathf.Lerp();
        Mathf.Lerp();
        *this = 0;
        this[1] = 0;
        FUN_1809dcfa0(this);
        return this;
    }

    // Token : 0x60006C2
    // RVA   : 0xAF0650   Offset: 0xAEFA50   Length: 0xE
    public override Vector4 get_border()
    {
        uint64 * FUN_180af0650(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x210);
        *this = *(uint64 *)(param_2 + 0x208);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x60006C3
    // RVA   : 0xAF0F20   Offset: 0xAF0320   Length: 0x86
    public override void set_border(Vector4 value)
    {
        void FUN_180af0f20(int64 *this,float *value)
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
                          // WARNING: Could not recover jumptable at 0x000180af0f9e. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(fVar3,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x60006C4
    // RVA   : 0xAF0110   Offset: 0xAEF510   Length: 0x4B1
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
              uVar11 = FUN_180d995b0(&local_78,0);
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
                      FUN_180d995b0(&local_78,0);
                      if (this[63] != 0) {
                        puVar12 = (uint64 *)Sprite.get_textureRect(&local_58,this[63],0);
                        local_78 = *puVar12;
                        uStack_70 = puVar12[1];
                        FUN_180d995b0(&local_78,0);
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
                                FUN_1809dcfa0(&local_68,fVar13);
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

    // Token : 0x60006C5
    // RVA   : 0xAEFB30   Offset: 0xAEEF30   Length: 0x1B0
    public override void MakePixelPerfect()
    {
        bool cVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        float fVar6;
        float fVar7;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint8 local_28 [32];
        UIWidget.MakePixelPerfect(this,0);
        if ((int)this[49] != 2) {
          uVar4 = (**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
          cVar1 = Object.op_Equality(uVar4,0,0);
          if ((!cVar1) &&
             ((((int)this[49] == 0 || ((int)this[49] == 3)) ||
              (cVar1 = UIBasicSprite.get_hasBorder(this,0), !cVar1)))) {
            cVar1 = Object.op_Inequality(uVar4,0,0);
            if (cVar1) {
              if (this[63] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              puVar5 = (uint32 *)Sprite.get_rect(local_28,this[63],0);
              local_38 = *puVar5;
              uStack_34 = puVar5[1];
              uStack_30 = puVar5[2];
              uStack_2c = puVar5[3];
              fVar6 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              fVar7 = (float)FUN_180d995b0(&local_38,0);
              uVar2 = Mathf.RoundToInt(fVar7 * fVar6,0);
              fVar6 = (float)(**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              fVar7 = (float)FUN_18044e2b0(&local_38,0);
              uVar3 = Mathf.RoundToInt(fVar7 * fVar6,0);
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

    // Token : 0x60006C6
    // RVA   : 0xAEFCF0   Offset: 0xAEF0F0   Length: 0x416
    public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        uint uVar1;
        long lVar2;
        float fVar3;
        bool cVar4;
        uint8 (*pauVar7) [16];
        float fVar8;
        uint8 auVar9 [16];
        uint8 auVar10 [16];
        uint8 auVar11 [16];
        uint64 local_78;
        uint64 uStack_70;
        uint64 local_68;
        uint64 uStack_60;
        uint64 local_58;
        uint64 uStack_50;
        uint64 local_48;
        uint64 uStack_40;
        plVar5 = (int64 *)(**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
        cVar4 = Object.op_Equality(plVar5,0,0);
        if (cVar4) {
          return;
        }
        lVar2 = this[63];
        cVar4 = Object.op_Inequality(lVar2,0,0);
        if (!cVar4) {
          if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          (**(code **)(*plVar5 + 0x178))(plVar5,*(uint64 *)(*plVar5 + 0x180));
          (**(code **)(*plVar5 + 0x198))(plVar5,*(uint64 *)(*plVar5 + 0x1a0));
          local_58 = 0;
          uStack_50 = 0;
          FUN_1809dcfa0(&local_58);
          local_78 = local_58;
          uStack_70 = uStack_50;
        }
        else {
          if (this[63] == 0) throw; // [null/range check failed]
          puVar6 = (uint64 *)Sprite.get_textureRect(&local_48,this[63],0);
          local_78 = *puVar6;
          uStack_70 = puVar6[1];
        }
        local_68 = local_78;
        uStack_60 = uStack_70;
        pauVar7 = (uint8 (*) [16])
                  (**(code **)(*this + 0x378))(&local_48,this,*(uint64 *)(*this + 0x380));
        auVar9 = *pauVar7;
        fVar3 = auVar9._4_4_;
        fVar8 = (float)FUN_180d995d0(&local_78,0);
        auVar9._0_4_ = auVar9._0_4_ + fVar8;
        Rect.set_xMin(&local_78,auVar9._0_8_,0);
        fVar8 = (float)FUN_18044df60(&local_78,0);
        auVar10._4_4_ = fVar3;
        auVar10._0_4_ = fVar3;
        auVar10._8_4_ = fVar3;
        auVar10._12_4_ = fVar3;
        auVar11._4_12_ = auVar10._4_12_;
        auVar11._0_4_ = fVar3 + fVar8;
        Rect.set_yMin(&local_78,auVar11._0_8_,0);
        Rect.get_xMax(&local_78,0);
        Rect.set_xMax(&local_78);
        Rect.get_yMax(&local_78,0);
        Rect.set_yMax(&local_78);
        if (plVar5 != (int64 *)0) {
          (**(code **)(*plVar5 + 0x178))(plVar5,*(uint64 *)(*plVar5 + 0x180));
          (**(code **)(*plVar5 + 0x198))(plVar5,*(uint64 *)(*plVar5 + 0x1a0));
          FUN_180d995d0(&local_68,0);
          Rect.set_xMin(&local_68);
          Rect.get_xMax(&local_68,0);
          Rect.set_xMax(&local_68);
          FUN_18044df60(&local_68,0);
          Rect.set_yMin(&local_68);
          Rect.get_yMax(&local_68,0);
          Rect.set_yMax(&local_68);
          FUN_180d995d0(&local_78,0);
          Rect.set_xMin(&local_78);
          Rect.get_xMax(&local_78,0);
          Rect.set_xMax(&local_78);
          FUN_18044df60(&local_78,0);
          Rect.set_yMin(&local_78);
          Rect.get_yMax(&local_78,0);
          Rect.set_yMax(&local_78);
          if (verts != null) {
            uVar1 = *(uint32 *)(verts + 24);
            local_58 = local_78;
            uStack_50 = uStack_70;
            local_48 = local_68;
            uStack_40 = uStack_60;
            UIBasicSprite.Fill(this,verts,uvs,cols,&local_48,&local_58,0);
            if (this[24] == 0) {
              return;
            }
            OnPostFillCallback.Invoke(this[24],this,uVar1,verts,uvs,cols,0);
            return;
          }
        }
    }

    // Token : 0x60006C7
    // RVA   : 0xAF05D0   Offset: 0xAEF9D0   Length: 0x7C
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        byte[] local_18 = new byte[16];
        puVar5 = (uint32 *)Vector4.get_zero(local_18,0);
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
        UIBasicSprite.ctor(this,0);
    }

}
