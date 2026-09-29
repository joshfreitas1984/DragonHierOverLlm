// ============================================================
// Type  : UITexture
// Token : 0x200011B
// ============================================================

public class UITexture
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400070F
    private Rect mRect;

    // Token: 0x4000710
    private Texture mTexture;

    // Token: 0x4000711
    private Shader mShader;

    // Token: 0x4000712
    private Vector4 mBorder;

    // Token: 0x4000713
    private bool mFixedAspect;

    // Token: 0x4000714
    private int mPMA;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000984
    // RVA   : 0xC05DE0   Offset: 0xC051E0   Length: 0xD6
    public override Texture get_mainTexture()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mTexture;
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
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return this.mTexture;
    }

    // Token : 0x6000985
    // RVA   : 0xC06210   Offset: 0xC05610   Length: 0x179
    public override void set_mainTexture(Texture value)
    {
        long lVar1;
        bool cVar2;
        lVar1 = this[65];
        cVar2 = Object.op_Inequality(lVar1,value,0);
        if (cVar2) {
          lVar1 = this[43];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (cVar2) {
            if (this[43] == 0) {
        LAB_180c06384:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int *)(this[43] + 24) == 1) {
              lVar1 = this[22];
              cVar2 = Object.op_Equality(lVar1,0,0);
              if (cVar2) {
                this[65] = value;
                il2cpp_internal(this + 65,value);
                if (this[43] != 0) {
                  UIDrawCall.set_mainTexture(this[43],value,0);
                  return;
                }
                goto LAB_180c06384;
              }
            }
          }
          UIWidget.RemoveFromPanel(this,0);
          this[65] = value;
          il2cpp_internal(this + 65,value);
          *(uint32 *)((int64)this + 0x22c) = 0xffffffff;
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x6000986
    // RVA   : 0x2A5C70   Offset: 0x2A5070   Length: 0x8
    public override Material get_material()
    {
        return *(uint64 *)(this + 176);
    }

    // Token : 0x6000987
    // RVA   : 0xC06390   Offset: 0xC05790   Length: 0xD4
    public override void set_material(Material value)
    {
        long lVar1;
        bool cVar2;
        lVar1 = this[22];
        cVar2 = Object.op_Inequality(lVar1,value,0);
        if (cVar2) {
          UIWidget.RemoveFromPanel(this,0);
          this[66] = 0;
          il2cpp_internal(this + 66,0);
          this[22] = value;
          il2cpp_internal(this + 22,value);
          *(uint32 *)((int64)this + 0x22c) = 0xffffffff;
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x6000988
    // RVA   : 0xC06000   Offset: 0xC05400   Length: 0xF9
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

    // Token : 0x6000989
    // RVA   : 0xC06470   Offset: 0xC05870   Length: 0x18E
    public override void set_shader(Shader value)
    {
        long lVar1;
        bool cVar2;
        lVar1 = this[66];
        cVar2 = Object.op_Inequality(lVar1,value,0);
        if (cVar2) {
          lVar1 = this[43];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (cVar2) {
            if (this[43] == 0) {
        LAB_180c065f9:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (*(int *)(this[43] + 24) == 1) {
              lVar1 = this[22];
              cVar2 = Object.op_Equality(lVar1,0,0);
              if (cVar2) {
                this[66] = value;
                il2cpp_internal(this + 66,value);
                if (this[43] != 0) {
                  UIDrawCall.set_shader(this[43],value,0);
                  return;
                }
                goto LAB_180c065f9;
              }
            }
          }
          UIWidget.RemoveFromPanel(this,0);
          this[66] = value;
          il2cpp_internal(this + 66,value);
          *(uint32 *)((int64)this + 0x22c) = 0xffffffff;
          this[22] = 0;
          il2cpp_internal(this + 22,0);
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x600098A
    // RVA   : 0xC05EC0   Offset: 0xC052C0   Length: 0x136
    public override bool get_premultipliedAlpha()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uVar4 = (uint64)*(uint32 *)((int64)this + 0x22c);
        if (*(uint32 *)((int64)this + 0x22c) != 0xffffffff) goto LAB_180c05fe0;
        lVar2 = (**(code **)(*this + 0x2c8))(this,*(uint64 *)(*this + 0x2d0));
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (!cVar1) {
        LAB_180c05fd8:
          uVar4 = 0;
        }
        else {
          if (lVar2 == null) goto LAB_180c05ff1;
          uVar3 = Material.get_shader(lVar2,0);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) goto LAB_180c05fd8;
          lVar2 = Material.get_shader(lVar2,0);
          if (lVar2 == null) {
        LAB_180c05ff1:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = Object.get_name(lVar2,0);
          if (lVar2 == null) goto LAB_180c05ff1;
          cVar1 = String.Contains(lVar2,"Premultiplied",0);
          if (!cVar1) goto LAB_180c05fd8;
          uVar4 = 1;
        }
        *(int *)((int64)this + 0x22c) = (int)uVar4;
        LAB_180c05fe0:
        return CONCAT71((int7)(uVar4 >> 8),(int)uVar4 == 1);
    }

    // Token : 0x600098B
    // RVA   : 0xC05A80   Offset: 0xC04E80   Length: 0xE
    public override Vector4 get_border()
    {
        uint64 * FUN_180c05a80(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x220);
        *this = *(uint64 *)(param_2 + 0x218);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x600098C
    // RVA   : 0xC06110   Offset: 0xC05510   Length: 0x86
    public override void set_border(Vector4 value)
    {
        void FUN_180c06110(int64 *this,float *value)
        {
        float fVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        fVar3 = *(float *)((int64)this + 0x21c) - value[1];
        fVar4 = *(float *)((int64)this + 0x224) - value[3];
        if (9.9999994e-11 <=
            fVar3 * fVar3 +
            (*(float *)(this + 67) - *value) * (*(float *)(this + 67) - *value) +
            (*(float *)(this + 68) - value[2]) * (*(float *)(this + 68) - value[2]) +
            fVar4 * fVar4) {
          fVar3 = *value;
          fVar4 = value[1];
          fVar1 = value[2];
          fVar2 = value[3];
          *(float *)(this + 67) = fVar3;
          *(float *)((int64)this + 0x21c) = fVar4;
          *(float *)(this + 68) = fVar1;
          *(float *)((int64)this + 0x224) = fVar2;
                          // WARNING: Could not recover jumptable at 0x000180c0618e. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(fVar3,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x600098D
    // RVA   : 0xC06100   Offset: 0xC05500   Length: 0xE
    public Rect get_uvRect()
    {
        uint64 * FUN_180c06100(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x200);
        *this = *(uint64 *)(param_2 + 0x1f8);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x600098E
    // RVA   : 0xC06600   Offset: 0xC05A00   Length: 0x62
    public void set_uvRect(Rect value)
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
        local_18 = (uint32)this[63];
        uStack_14 = *(uint32 *)((int64)this + 0x1fc);
        uStack_10 = (uint32)this[64];
        uStack_c = *(uint32 *)((int64)this + 0x204);
        cVar4 = Rect.op_Inequality(&local_18,&local_28,0);
        if (cVar4) {
          uVar1 = *(uint32 *)((int64)value + 4);
          uVar2 = *(uint32 *)(value + 1);
          uVar3 = *(uint32 *)((int64)value + 12);
          *(uint32 *)(this + 63) = *(uint32 *)value;
          *(uint32 *)((int64)this + 0x1fc) = uVar1;
          *(uint32 *)(this + 64) = uVar2;
          *(uint32 *)((int64)this + 0x204) = uVar3;
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x600098F
    // RVA   : 0xC05A90   Offset: 0xC04E90   Length: 0x347
    public override Vector4 get_drawingDimensions()
    {
        long lVar1;
        bool cVar3;
        byte[] local_98 = new byte[144];
        NGUIMath.GetPivotOffset((int)param_2[20],0);
        lVar1 = param_2[65];
        cVar3 = Object.op_Inequality(lVar1,0,0);
        if ((cVar3) && ((int)param_2[49] != 2)) {
          plVar2 = (int64 *)param_2[65];
          if (plVar2 != (int64 *)0) {
            (**(code **)(*plVar2 + 0x178))(plVar2,*(uint64 *)(*plVar2 + 0x180));
            plVar2 = (int64 *)param_2[65];
            if (plVar2 != (int64 *)0) {
              (**(code **)(*plVar2 + 0x198))(plVar2,*(uint64 *)(*plVar2 + 0x1a0));
              goto LAB_180c05c73;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_180c05c73:
        if ((char)param_2[69] == false) {
          (**(code **)(*param_2 + 0x378))(local_98,param_2,*(uint64 *)(*param_2 + 0x380));
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

    // Token : 0x6000990
    // RVA   : 0x3E7A40   Offset: 0x3E6E40   Length: 0x8
    public bool get_fixedAspect()
    {
        uint8 FUN_1803e7a40(int64 this)
        {
        return this.mFixedAspect;
    }

    // Token : 0x6000991
    // RVA   : 0xC061A0   Offset: 0xC055A0   Length: 0x6B
    public void set_fixedAspect(bool value)
    {
        ulong local_18;
        ulong uStack_10;
        if ((char)this[69] != value) {
          *(char *)(this + 69) = value;
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

    // Token : 0x6000992
    // RVA   : 0xC050D0   Offset: 0xC044D0   Length: 0x285
    public override void MakePixelPerfect()
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        uint uVar4;
        long lVar5;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        ulong local_48;
        ulong local_38;
        uint local_30;
        byte[] local_28 = new byte[32];
        lVar5 = UIRect.get_cachedTransform(this,0);
        if (lVar5 != null) {
          puVar6 = (uint64 *)Transform.get_localPosition(local_28,lVar5,0);
          local_30 = *(uint32 *)(puVar6 + 1);
          uVar1 = *puVar6;
          local_38 = uVar1;
          uVar8 = FUN_18000d7c0(local_30);
          uVar9 = FUN_18000d7c0(uVar1);
          local_48._4_4_ = (uint32)((uint64)uVar1 >> 32);
          uVar10 = FUN_18000d7c0(local_48._4_4_);
          local_48 = CONCAT44(uVar10,uVar9);
          lVar5 = UIRect.get_cachedTransform(this,0);
          if (lVar5 != null) {
            local_38 = local_48;
            local_30 = uVar8;
            Transform.set_localPosition(lVar5,&local_38,0);
            lVar5 = UIRect.get_cachedTransform(this,0);
            if (lVar5 != null) {
              puVar6 = (uint64 *)Transform.get_localScale(local_28,lVar5,0);
              uVar1 = *puVar6;
              uVar9 = (uint32)((uint64)uVar1 >> 32);
              local_30 = *(uint32 *)(puVar6 + 1);
              lVar5 = UIRect.get_cachedTransform(this,0);
              uVar8 = Mathf.Sign(uVar1,0);
              local_38 = uVar1;
              uVar9 = Mathf.Sign(CONCAT44(uVar9,uVar9),0);
              local_48 = CONCAT44(uVar9,uVar8);
              if (lVar5 != null) {
                local_38 = local_48;
                local_30 = 0x3f800000;
                Transform.set_localScale(lVar5,&local_38,0);
                if ((int)this[49] != 2) {
                  plVar7 = (int64 *)
                           (**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
                  cVar2 = Object.op_Equality(plVar7,0,0);
                  if (!cVar2) {
                    if ((((int)this[49] != 0) && ((int)this[49] != 3)) &&
                       (cVar2 = UIBasicSprite.get_hasBorder(this,0), cVar2)) {
                      return;
                    }
                    cVar2 = Object.op_Inequality(plVar7,0,0);
                    if (cVar2) {
                      if (plVar7 == (int64 *)0) throw; // [null/range check failed]
                      uVar3 = (**(code **)(*plVar7 + 0x178))(plVar7,*(uint64 *)(*plVar7 + 0x180));
                      uVar4 = (**(code **)(*plVar7 + 0x198))(plVar7,*(uint64 *)(*plVar7 + 0x1a0));
                      if ((uVar3 & 1) != 0) {
                        uVar3 = uVar3 + 1;
                      }
                      if ((uVar4 & 1) != 0) {
                        uVar4 = uVar4 + 1;
                      }
                      UIWidget.set_width(this,uVar3,0);
                      UIWidget.set_height(this,uVar4,0);
                    }
                  }
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000993
    // RVA   : 0xC057D0   Offset: 0xC04BD0   Length: 0x1FF
    protected override void OnUpdate()
    {
        long lVar1;
        bool cVar2;
        uint uVar3;
        uint uVar4;
        float fVar6;
        ulong local_28;
        ulong uStack_20;
        ulong local_18;
        ulong uStack_10;
        lVar1 = this[29];
        cVar2 = Object.op_Equality(lVar1,0,0);
        if (cVar2) {
          UIWidget.CreatePanel(this,0);
        }
        if ((char)this[69] != false) {
          plVar5 = (int64 *)(**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
          cVar2 = Object.op_Inequality(plVar5,0,0);
          if (cVar2) {
            if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar3 = (**(code **)(*plVar5 + 0x178))(plVar5,*(uint64 *)(*plVar5 + 0x180));
            uVar4 = (**(code **)(*plVar5 + 0x198))(plVar5,*(uint64 *)(*plVar5 + 0x1a0));
            if ((uVar3 & 1) != 0) {
              uVar3 = uVar3 + 1;
            }
            if ((uVar4 & 1) != 0) {
              uVar4 = uVar4 + 1;
            }
            fVar6 = (float)*(int *)((int64)this + 164);
            local_28 = 0;
            uStack_20 = 0;
            if ((float)(int)uVar3 / (float)(int)uVar4 < fVar6 / (float)(int)this[21]) {
              fVar6 = ((fVar6 - ((float)(int)uVar3 / (float)(int)uVar4) * (float)(int)this[21]) /
                      fVar6) * 0.5;
            }
            else {
              fVar6 = 0.0;
            }
            FUN_1809dcfa0(&local_28,fVar6);
            local_18 = local_28;
            uStack_10 = uStack_20;
            UIWidget.set_drawRegion(this,&local_18,0);
          }
        }
    }

    // Token : 0x6000994
    // RVA   : 0xC05360   Offset: 0xC04760   Length: 0x467
    public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        bool cVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        uint8 (*pauVar7) [16];
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        uint8 auVar12 [16];
        uint8 auVar13 [16];
        uint8 auVar14 [16];
        uint64 in_stack_ffffffffffffff38;
        uint32 uVar15;
        uint64 local_a8;
        uint64 uStack_a0;
        uint64 local_98;
        uint64 uStack_90;
        uint64 local_88;
        uint64 uStack_80;
        uint64 local_78;
        uint64 uStack_70;
        uVar15 = (uint32)((uint64)in_stack_ffffffffffffff38 >> 32);
        local_98 = 0;
        uStack_90 = 0;
        plVar6 = (int64 *)(**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
        cVar1 = Object.op_Equality(plVar6,0,0);
        if (!cVar1) {
          fVar8 = (float)FUN_180d995d0(this + 63,0);
          if (plVar6 != (int64 *)0) {
            iVar2 = (**(code **)(*plVar6 + 0x178))(plVar6,*(uint64 *)(*plVar6 + 0x180));
            fVar9 = (float)FUN_18044df60(this + 63,0);
            iVar3 = (**(code **)(*plVar6 + 0x198))(plVar6,*(uint64 *)(*plVar6 + 0x1a0));
            iVar4 = (**(code **)(*plVar6 + 0x178))(plVar6,*(uint64 *)(*plVar6 + 0x180));
            fVar10 = (float)FUN_180d995b0(this + 63,0);
            iVar5 = (**(code **)(*plVar6 + 0x198))(plVar6,*(uint64 *)(*plVar6 + 0x1a0));
            fVar11 = (float)FUN_18044e2b0(this + 63,0);
            FUN_1809dcfa0(&local_98,(float)iVar2 * fVar8,(float)iVar3 * fVar9,(float)iVar4 * fVar10,
                          CONCAT44(uVar15,(float)iVar5 * fVar11),0);
            local_a8 = local_98;
            uStack_a0 = uStack_90;
            pauVar7 = (uint8 (*) [16])
                      (**(code **)(*this + 0x378))(&local_78,this,*(uint64 *)(*this + 0x380))
            ;
            auVar12 = *pauVar7;
            fVar8 = auVar12._4_4_;
            fVar9 = (float)FUN_180d995d0(&local_a8,0);
            auVar12._0_4_ = auVar12._0_4_ + fVar9;
            Rect.set_xMin(&local_a8,auVar12._0_8_,0);
            fVar9 = (float)FUN_18044df60(&local_a8,0);
            auVar13._4_4_ = fVar8;
            auVar13._0_4_ = fVar8;
            auVar13._8_4_ = fVar8;
            auVar13._12_4_ = fVar8;
            auVar14._4_12_ = auVar13._4_12_;
            auVar14._0_4_ = fVar8 + fVar9;
            Rect.set_yMin(&local_a8,auVar14._0_8_,0);
            Rect.get_xMax(&local_a8,0);
            Rect.set_xMax(&local_a8);
            Rect.get_yMax(&local_a8,0);
            Rect.set_yMax(&local_a8);
            (**(code **)(*plVar6 + 0x178))(plVar6,*(uint64 *)(*plVar6 + 0x180));
            (**(code **)(*plVar6 + 0x198))(plVar6,*(uint64 *)(*plVar6 + 0x1a0));
            FUN_180d995d0(&local_98,0);
            Rect.set_xMin(&local_98);
            Rect.get_xMax(&local_98,0);
            Rect.set_xMax(&local_98);
            FUN_18044df60(&local_98,0);
            Rect.set_yMin(&local_98);
            Rect.get_yMax(&local_98,0);
            Rect.set_yMax(&local_98);
            FUN_180d995d0(&local_a8,0);
            Rect.set_xMin(&local_a8);
            Rect.get_xMax(&local_a8,0);
            Rect.set_xMax(&local_a8);
            FUN_18044df60(&local_a8,0);
            Rect.set_yMin(&local_a8);
            Rect.get_yMax(&local_a8,0);
            Rect.set_yMax(&local_a8);
            if (verts != null) {
              uVar15 = *(uint32 *)(verts + 24);
              local_88 = local_a8;
              uStack_80 = uStack_a0;
              local_78 = local_98;
              uStack_70 = uStack_90;
              UIBasicSprite.Fill(this,verts,uvs,cols,&local_78,&local_88,0);
              if (this[24] == 0) {
                return;
              }
              OnPostFillCallback.Invoke(this[24],this,uVar15,verts,uvs,cols,0);
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000995
    // RVA   : 0xC059D0   Offset: 0xC04DD0   Length: 0xAE
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        local_28 = 0;
        uStack_20 = 0;
        FUN_1809dcfa0(&local_28,0,0,0x3f800000,0x3f800000,0);
        this.mRect = (uint32)local_28;
        *(uint32 *)(this + 0x1fc) = local_28._4_4_;
        *(uint32 *)(this + 0x200) = (uint32)uStack_20;
        *(uint32 *)(this + 0x204) = uStack_20._4_4_;
        puVar5 = (uint32 *)Vector4.get_zero(local_18,0);
        uVar1 = *puVar5;
        uVar2 = puVar5[1];
        uVar3 = puVar5[2];
        uVar4 = puVar5[3];
        this.mPMA = 0xffffffff;
        this.mBorder = uVar1;
        *(uint32 *)(this + 0x21c) = uVar2;
        *(uint32 *)(this + 0x220) = uVar3;
        *(uint32 *)(this + 0x224) = uVar4;
        UIBasicSprite.ctor(this,0);
    }

}
