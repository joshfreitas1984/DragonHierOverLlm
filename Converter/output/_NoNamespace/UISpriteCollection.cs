// ============================================================
// Type  : UISpriteCollection
// Token : 0x200010D
// ============================================================

public class UISpriteCollection
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40006A9
    private object mAtlas;

    // Token: 0x40006AA
    private Dictionary<object, Sprite> mSprites;

    // Token: 0x40006AB
    private UISpriteData mSprite;

    // Token: 0x40006AC
    public OnHoverCB onHover;

    // Token: 0x40006AD
    public OnPressCB onPress;

    // Token: 0x40006AE
    public OnClickCB onClick;

    // Token: 0x40006AF
    public OnDragCB onDrag;

    // Token: 0x40006B0
    public OnTooltipCB onTooltip;

    // Token: 0x40006B1
    private object mLastHover;

    // Token: 0x40006B2
    private object mLastPress;

    // Token: 0x40006B3
    private object mLastTooltip;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000914
    // RVA   : 0x1691900   Offset: 0x1690100   Length: 0xD8
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

    // Token : 0x6000915
    // RVA   : 0x10FCE70   Offset: 0x10FB670   Length: 0x8
    public override void set_mainTexture(Texture value)
    {
        void FUN_1810fce70(uint64 this,uint64 value)
        {
        UIWidget.set_mainTexture(this,value,0);
    }

    // Token : 0x6000916
    // RVA   : 0x16919E0   Offset: 0x16901E0   Length: 0xD2
    public override Material get_material()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = *(uint64 *)(this + 176);
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          return uVar3;
        }
        lVar2 = il2cpp_internal(this.mAtlas,DAT_181d55650);
        if (lVar2 == null) {
          return 0;
        }
        uVar3 = FUN_180002970(0,DAT_181d55650,lVar2);
        return uVar3;
    }

    // Token : 0x6000917
    // RVA   : 0x10FCE80   Offset: 0x10FB680   Length: 0x8
    public override void set_material(Material value)
    {
        void FUN_1810fce80(uint64 this,uint64 value)
        {
        UIWidget.set_material(this,value,0);
    }

    // Token : 0x6000918
    // RVA   : 0x1691840   Offset: 0x1690040   Length: 0x3D
    public INGUIAtlas get_atlas()
    {
        il2cpp_internal(this.mAtlas,DAT_181d55650);
    }

    // Token : 0x6000919
    // RVA   : 0x1691C70   Offset: 0x1690470   Length: 0x100
    public void set_atlas(INGUIAtlas value)
    {
        plVar2 = (int64 *)il2cpp_internal(this[63]);
        if (plVar2 != value) {
          UIWidget.RemoveFromPanel(this);
          if (value == (int64 *)0) {
            plVar2 = (int64 *)0;
          }
          else {
            plVar2 = value;
          }
          this[63] = (int64)plVar2;
          il2cpp_internal(this + 63);
          if (this[64] == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Dictionary_2.Clear(this[64],DAT_181da0500);
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x600091A
    // RVA   : 0x1691B70   Offset: 0x1690370   Length: 0x80
    public override float get_pixelSize()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = il2cpp_internal(this.mAtlas,DAT_181d55650);
        if (lVar1 == null) {
          return 0x3f800000;
        }
        uVar2 = FUN_180149d90(5,DAT_181d55650,lVar1);
        return uVar2;
    }

    // Token : 0x600091B
    // RVA   : 0x1691BF0   Offset: 0x16903F0   Length: 0x78
    public override bool get_premultipliedAlpha()
    {
        long lVar1;
        lVar1 = il2cpp_internal(this.mAtlas,DAT_181d55650);
        if (lVar1 == null) {
          return;
        }
        FUN_180002970(7,DAT_181d55650,lVar1);
    }

    // Token : 0x600091C
    // RVA   : 0x1691880   Offset: 0x1690080   Length: 0x80
    public override Vector4 get_border()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        byte[] local_18 = new byte[16];
        lVar5 = *(int64 *)(param_2 + 0x208);
        if (lVar5 != null) {
          uVar1 = *(uint32 *)(lVar5 + 40);
          uVar2 = *(uint32 *)(lVar5 + 52);
          uVar3 = *(uint32 *)(lVar5 + 44);
          iVar4 = *(int *)(lVar5 + 48);
          *this = 0;
          this[1] = 0;
          FUN_1809981e0(0,uVar3,uVar2,uVar1,(float)iVar4,0);
          return this;
        }
        puVar7 = (uint64 *)UIWidget.get_border(local_18,param_2,0);
        uVar6 = puVar7[1];
        *this = *puVar7;
        this[1] = uVar6;
        return this;
    }

    // Token : 0x600091D
    // RVA   : 0x1691AC0   Offset: 0x16902C0   Length: 0xA9
    protected override Vector4 get_padding()
    {
        this[0] = 0.0;
        this[1] = 0.0;
        this[2] = 0.0;
        this[3] = 0.0;
        FUN_1809981e0(this,0,0,0,0,0);
        if (*(int64 *)(param_2 + 0x208) == 0) {
          return this;
        }
        *this = (float)*(int *)(*(int64 *)(param_2 + 0x208) + 56);
        if (*(int64 *)(param_2 + 0x208) != 0) {
          this[1] = (float)*(int *)(*(int64 *)(param_2 + 0x208) + 68);
          if (*(int64 *)(param_2 + 0x208) != 0) {
            this[2] = (float)*(int *)(*(int64 *)(param_2 + 0x208) + 60);
            if (*(int64 *)(param_2 + 0x208) != 0) {
              this[3] = (float)*(int *)(*(int64 *)(param_2 + 0x208) + 64);
              return this;
            }
          }
        }
    }

    // Token : 0x600091E
    // RVA   : 0x16904E0   Offset: 0x168ECE0   Length: 0x913
    public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        void UISpriteCollection.OnFill
                     (int64 *this,int64 verts,uint64 uvs,uint64 cols)
        {
        uint64 uVar1;
        uint32 uVar2;
        int iVar3;
        int64 lVar4;
        uint64 uVar5;
        char cVar6;
        uint32 uVar7;
        uint32 uVar8;
        int64 *plVar9;
        uint64 *puVar10;
        int64 *plVar11;
        uint32 uVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        uint64 *in_stack_fffffffffffffd28;
        uint64 local_2b0;
        uint64 uStack_2a8;
        uint64 local_2a0;
        uint32 local_298;
        uint64 local_290;
        uint64 uStack_288;
        uint64 local_280;
        uint64 uStack_278;
        uint64 local_268;
        uint64 uStack_260;
        uint32 local_250;
        int64 local_248;
        uint64 uStack_240;
        uint64 local_238;
        uint64 uStack_230;
        uint64 local_228;
        uint64 uStack_220;
        uint64 local_218;
        uint64 local_208;
        uint32 local_200;
        uint64 local_1f8;
        uint32 local_1f0;
        uint64 local_1e8;
        uint64 uStack_1e0;
        uint64 local_1d8;
        uint64 uStack_1d0;
        uint64 local_1c8;
        uint64 uStack_1c0;
        uint64 local_1b8;
        int64 lStack_1b0;
        uint64 local_1a8;
        uint64 uStack_1a0;
        uint64 local_198;
        uint64 uStack_190;
        uint64 local_188;
        uint64 uStack_180;
        uint64 local_178;
        uint64 local_168;
        uint64 local_150;
        uint64 uStack_148;
        uint64 local_140;
        int64 lStack_138;
        uint64 local_130;
        uint64 uStack_128;
        uint64 local_120;
        uint64 uStack_118;
        uint64 local_110;
        uint64 uStack_108;
        uint64 local_100;
        uint8 local_f8 [16];
        uint8 local_e8 [16];
        uint8 local_d8 [16];
        uint8 local_c8 [16];
        uint8 local_b8 [16];
        uint8 local_a8 [112];
        local_248 = 0;
        uStack_240 = 0;
        local_238 = 0;
        uStack_230 = 0;
        local_228 = 0;
        uStack_220 = 0;
        local_218 = 0;
        local_2b0 = 0;
        uStack_2a8 = 0;
        local_1e8 = 0;
        uStack_1e0 = 0;
        local_1d8 = 0;
        uStack_1d0 = 0;
        local_290 = 0;
        uStack_288 = 0;
        local_280 = 0;
        uStack_278 = 0;
        local_250 = 0;
        plVar9 = (int64 *)(**(code **)(*this + 0x2e8))(this,*(uint64 *)(*this + 0x2f0));
        cVar6 = Object.op_Equality(plVar9,0,0);
        if (cVar6) {
          return;
        }
        if (verts != null) {
          uVar2 = *(uint32 *)(verts + 24);
          if (this[64] != 0) {
            FUN_181774a90(&local_150,this[64],DAT_181da0698);
            local_1c8 = local_150;
            uStack_1c0 = uStack_148;
            local_1b8 = local_140;
            lStack_1b0 = lStack_138;
            local_1a8 = local_130;
            uStack_1a0 = uStack_128;
            local_198 = local_120;
            uStack_190 = uStack_118;
            local_188 = local_110;
            uStack_180 = uStack_108;
            local_178 = local_100;
            while( true ) {
              do {
                do {
                  do {
                    cVar6 = FUN_1811d5790(&local_1c8,DAT_181d79b28);
                    if (!cVar6) {
                      ZhSegment.Initialize(&local_1c8,DAT_181d79aa8);
                      this[65] = 0;
                      il2cpp_internal(this + 65,0);
                      if (this[24] == 0) {
                        return;
                      }
                      OnPostFillCallback.Invoke(this[24],this,uVar2,verts,uvs,cols,0);
                      return;
                    }
                    local_248 = lStack_1b0;
                    uStack_240 = local_1a8;
                    local_238 = uStack_1a0;
                    uStack_230 = local_198;
                    local_228 = uStack_190;
                    uStack_220 = local_188;
                    local_218 = uStack_180;
                  } while ((char)!uStack_180);
                  this[65] = lStack_1b0;
                  il2cpp_internal(this + 65);
                } while (this[65] == 0);
                puVar10 = (uint64 *)Color32.op_Implicit(local_f8,uStack_230 >> 32,0);
                local_2b0 = *puVar10;
                uStack_2a8 = CONCAT44(*(float *)((int64)this + 140),(int)puVar10[1]);
              } while (*(float *)((int64)this + 140) == 0.0);
              if (this[65] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar7 = (uint32)((uint64)in_stack_fffffffffffffd28 >> 32);
              FUN_1809981e0(&local_1e8);
              lVar4 = this[65];
              if (lVar4 == null) break;
              FUN_1809981e0(&local_1d8,*(int *)(lVar4 + 48),*(uint32 *)(lVar4 + 28),
                            *(uint32 *)(lVar4 + 40),
                            CONCAT44(uVar7,(float)((*(int *)(lVar4 + 36) - *(int *)(lVar4 + 48)) -
                                                  *(int *)(lVar4 + 52))),0);
              uVar5 = uStack_1e0;
              uVar1 = local_1e8;
              if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar7 = (**(code **)(*plVar9 + 0x178))(plVar9,*(uint64 *)(*plVar9 + 0x180));
              uVar8 = (**(code **)(*plVar9 + 0x198))(plVar9,*(uint64 *)(*plVar9 + 0x1a0));
              local_268 = uVar1;
              uStack_260 = uVar5;
              plVar11 = (int64 *)NGUIMath.ConvertToTexCoords(local_e8,&local_268,uVar7,uVar8,0);
              uVar5 = uStack_1d0;
              uVar1 = local_1d8;
              lVar4 = plVar11[1];
              this[58] = *plVar11;
              this[59] = lVar4;
              uVar7 = (**(code **)(*plVar9 + 0x178))(plVar9,*(uint64 *)(*plVar9 + 0x180));
              uVar8 = (**(code **)(*plVar9 + 0x198))(plVar9,*(uint64 *)(*plVar9 + 0x1a0));
              local_268 = uVar1;
              uStack_260 = uVar5;
              in_stack_fffffffffffffd28 = (uint64 *)0;
              plVar11 = (int64 *)NGUIMath.ConvertToTexCoords(local_d8,&local_268,uVar7,uVar8,0);
              lVar4 = plVar11[1];
              this[56] = *plVar11;
              this[57] = lVar4;
              *(uint32 *)(this + 51) = uStack_220._4_4_;
              (**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              puVar10 = (uint64 *)Sprite.GetDrawingDimensions(local_c8,&local_248);
              local_290 = *puVar10;
              uStack_288 = puVar10[1];
              puVar10 = (uint64 *)UIBasicSprite.get_drawingUVs(local_b8,this);
              local_280 = *puVar10;
              uStack_278 = puVar10[1];
              cVar6 = (**(code **)(*this + 0x3c8))(this,*(uint64 *)(*this + 0x3d0));
              uVar5 = uStack_2a8;
              uVar1 = local_2b0;
              if (cVar6) {
                local_268 = uVar1;
                uStack_260 = uVar5;
                puVar10 = (uint64 *)NGUITools.ApplyPMA(local_a8,&local_268);
                local_2b0 = *puVar10;
                uStack_2a8 = puVar10[1];
              }
              uVar12 = *(uint32 *)(verts + 24);
              if ((int)uStack_220 == 0) {
                in_stack_fffffffffffffd28 = &local_290;
                UIBasicSprite.SimpleFill
                          (this,verts,uvs,cols,in_stack_fffffffffffffd28,&local_280,&local_2b0
                           ,0);
              }
              else if ((int)uStack_220 == 1) {
                in_stack_fffffffffffffd28 = &local_290;
                UIBasicSprite.SlicedFill
                          (this,verts,uvs,cols,in_stack_fffffffffffffd28,&local_280,&local_2b0
                           ,0);
              }
              else if ((int)uStack_220 == 2) {
                in_stack_fffffffffffffd28 = &local_290;
                UIBasicSprite.TiledFill
                          (this,verts,uvs,cols,in_stack_fffffffffffffd28,&local_2b0,0);
              }
              else if ((int)uStack_220 == 3) {
                in_stack_fffffffffffffd28 = &local_290;
                UIBasicSprite.FilledFill
                          (this,verts,uvs,cols,in_stack_fffffffffffffd28,&local_280,&local_2b0
                           ,0);
              }
              else if ((int)uStack_220 == 4) {
                in_stack_fffffffffffffd28 = &local_290;
                UIBasicSprite.AdvancedFill
                          (this,verts,uvs,cols,in_stack_fffffffffffffd28,&local_280,&local_2b0
                           ,0);
              }
              iVar3 = *(int *)(verts + 24);
              if ((float)local_238 == 0.0) {
                for (; (int)uVar12 < iVar3; uVar12 = uVar12 + 1) {
                  if (*(uint32 *)(verts + 24) <= uVar12) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar1 = *(uint64 *)
                           (*(int64 *)(verts + 16) + 32 + (int64)(int)uVar12 * 12);
                  local_200 = *(uint32 *)
                               (*(int64 *)(verts + 16) + 40 + (int64)(int)uVar12 * 12);
                  local_168._4_4_ = (float)((uint64)uVar1 >> 32);
                  local_208 = CONCAT44(uStack_240._4_4_ + local_168._4_4_,(float)uVar1 + (float)uStack_240
                                      );
                  local_168 = uVar1;
                  FUN_181814c90(verts,uVar12,&local_208,DAT_181d844f8);
                }
              }
              else {
                fVar13 = (float)FUN_1801e72c0();
                fVar14 = (float)FUN_1801e67c0();
                fVar14 = fVar14 * (fVar13 + fVar13);
                for (; (int)uVar12 < iVar3; uVar12 = uVar12 + 1) {
                  if (*(uint32 *)(verts + 24) <= uVar12) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar1 = *(uint64 *)
                           (*(int64 *)(verts + 16) + 32 + (int64)(int)uVar12 * 12);
                  local_298 = *(uint32 *)
                               (*(int64 *)(verts + 16) + 40 + (int64)(int)uVar12 * 12);
                  fVar15 = 1.0 - fVar13 * (fVar13 + fVar13);
                  local_2a0._4_4_ = (float)((uint64)uVar1 >> 32);
                  local_1f8 = CONCAT44(uStack_240._4_4_ + (float)uVar1 * fVar14 + local_2a0._4_4_ * fVar15
                                       ,(float)uStack_240 +
                                        ((float)uVar1 * fVar15 - local_2a0._4_4_ * fVar14));
                  local_2a0 = uVar1;
                  local_250 = local_298;
                  local_1f0 = local_298;
                  FUN_181814c90(verts,uVar12,&local_1f8,DAT_181d844f8);
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x600091F
    // RVA   : 0x168F650   Offset: 0x168DE50   Length: 0xD3
    public void Add(object obj, string spriteName, Vector2 pos, float width, float height)
    {
        UISpriteCollection.AddSprite();
    }

    // Token : 0x6000920
    // RVA   : 0x168F730   Offset: 0x168DF30   Length: 0x68
    public void Add(object obj, string spriteName, Vector2 pos, float width, float height, Color32 color)
    {
        UISpriteCollection.AddSprite();
    }

    // Token : 0x6000921
    // RVA   : 0x168F410   Offset: 0x168DC10   Length: 0x235
    public void AddSprite(object id, string spriteName, Vector2 pos, float width, float height, Color32 color, Vector2 pivot, float rot, Type type, Flip flip, bool enabled)
    {
        void UISpriteCollection.AddSprite
                     (int64 *this,uint64 id,uint64 spriteName,uint64 pos,
                     uint32 width,uint32 height,uint32 color,uint64 pivot,
                     uint32 rot,uint32 type,uint32 flip,char enabled)
        {
        uint64 uVar1;
        char cVar2;
        int64 lVar3;
        int64 local_98;
        uint64 uStack_90;
        uint64 local_88;
        uint64 uStack_80;
        uint64 local_78;
        uint64 uStack_70;
        uint64 local_68;
        int64 local_58;
        uint64 uStack_50;
        uint64 local_48;
        uint64 uStack_40;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        lVar3 = this[63];
        cVar2 = Object.op_Equality(lVar3,0,0);
        if (!cVar2) {
          local_98 = 0;
          uStack_90 = 0;
          local_68 = 0;
          local_88 = 0;
          uStack_80 = 0;
          local_78 = 0;
          uStack_70 = 0;
          lVar3 = il2cpp_internal(this[63],DAT_181d55650);
          if (lVar3 != null) {
            local_98 = FUN_180002aa0(10,DAT_181d55650,lVar3,spriteName);
            il2cpp_internal(&local_98,local_98);
          }
          if (local_98 != 0) {
            uStack_80 = CONCAT44(color,height);
            local_78 = pivot;
            uVar1 = local_78;
            local_88 = CONCAT44(width,rot);
            uStack_70 = CONCAT44(flip,type);
            local_68 = CONCAT71(local_68._1_7_,enabled);
            uStack_90 = pos;
            if (this[64] == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_58 = local_98;
            local_78._0_4_ = (uint32)pivot;
            local_78._4_4_ = (uint32)((uint64)pivot >> 32);
            local_48 = local_88;
            uStack_40 = uStack_80;
            local_38 = (uint32)local_78;
            uStack_34 = local_78._4_4_;
            uStack_30 = type;
            uStack_2c = flip;
            local_28 = local_68;
            local_78 = uVar1;
            uStack_50 = pos;
            FUN_181789af0(this[64],id,&local_58,DAT_181da0c70);
            if ((enabled) && ((char)this[11] == false)) {
              (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
            }
          }
        }
        else {
          Debug.LogError("Atlas must be assigned first",0);
        }
    }

    // Token : 0x6000922
    // RVA   : 0x1690280   Offset: 0x168EA80   Length: 0x14A
    public Nullable<Sprite> GetSprite(object id)
    {
        bool cVar1;
        ulong local_c8;
        ulong uStack_c0;
        ulong local_b8;
        ulong uStack_b0;
        ulong local_a8;
        ulong uStack_a0;
        ulong local_98;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong uStack_70;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint64 local_18;
        local_98 = 0;
        local_c8 = 0;
        uStack_c0 = 0;
        local_b8 = 0;
        uStack_b0 = 0;
        local_a8 = 0;
        uStack_a0 = 0;
        if (*(int64 *)(id + 0x200) != 0) {
          cVar1 = FUN_181783890(*(int64 *)(id + 0x200),param_3,&local_c8,DAT_181da0a50);
          if (!cVar1) {
            *this = 0;
            this[1] = 0;
            this[2] = 0;
            this[3] = 0;
            this[4] = 0;
            this[5] = 0;
            this[6] = 0;
            this[7] = 0;
          }
          else {
            local_88 = 0;
            uStack_80 = 0;
            local_78 = 0;
            uStack_70 = 0;
            local_68 = 0;
            uStack_60 = 0;
            local_58 = 0;
            uStack_50 = 0;
            local_38 = local_b8;
            uStack_30 = uStack_b0;
            local_48 = local_c8;
            uStack_40 = uStack_c0;
            local_18 = local_98;
            local_28 = (uint32)local_a8;
            uStack_24 = local_a8._4_4_;
            uStack_20 = (uint32)uStack_a0;
            uStack_1c = uStack_a0._4_4_;
            FUN_1815cf2e0(&local_88,&local_48,DAT_181d93170);
            *this = local_88;
            this[1] = uStack_80;
            this[2] = local_78;
            this[3] = uStack_70;
            this[4] = local_68;
            this[5] = uStack_60;
            this[6] = local_58;
            this[7] = uStack_50;
          }
          return this;
        }
    }

    // Token : 0x6000923
    // RVA   : 0x1691320   Offset: 0x168FB20   Length: 0x81
    public bool RemoveSprite(object id)
    {
        bool cVar1;
        if (this[64] != 0) {
          cVar1 = FUN_18177b2b0(this[64],id,DAT_181da08b8);
          if (!cVar1) {
            return false;
          }
          if ((char)this[11] == false) {
            (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          }
          return true;
        }
    }

    // Token : 0x6000924
    // RVA   : 0x16916E0   Offset: 0x168FEE0   Length: 0xA9
    public bool SetSprite(object id, Sprite sp)
    {
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint64 local_18;
        if (this[64] != 0) {
          local_48 = *sp;
          uStack_40 = sp[1];
          local_38 = sp[2];
          uStack_30 = sp[3];
          local_28 = *(uint32 *)(sp + 4);
          uStack_24 = *(uint32 *)((int64)sp + 36);
          uStack_20 = *(uint32 *)(sp + 5);
          uStack_1c = *(uint32 *)((int64)sp + 44);
          local_18 = sp[6];
          FUN_181789af0(this[64],id,&local_48,DAT_181da0c70);
          if ((char)this[11] == false) {
            (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          }
          return true;
        }
    }

    // Token : 0x6000925
    // RVA   : 0x168F7A0   Offset: 0x168DFA0   Length: 0x89
    public void Clear()
    {
        int iVar1;
        if (this[64] != 0) {
          iVar1 = Dictionary_2.get_Count(this[64],DAT_181da0b60);
          if (iVar1 == 0) {
            return;
          }
          if (this[64] != 0) {
            Dictionary_2.Clear(this[64],DAT_181da0500);
                          // WARNING: Could not recover jumptable at 0x00018168f817. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
            return;
          }
        }
    }

    // Token : 0x6000926
    // RVA   : 0x16903D0   Offset: 0x168EBD0   Length: 0x84
    public bool IsActive(object id)
    {
        bool cVar1;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        ulong local_18;
        local_18 = 0;
        local_48 = 0;
        uStack_40 = 0;
        local_38 = 0;
        uStack_30 = 0;
        local_28 = 0;
        uStack_20 = 0;
        if (this.mSprites != null) {
          cVar1 = FUN_181783890(this.mSprites,id,&local_48,DAT_181da0a50);
          if (!cVar1) {
            local_18._0_1_ = 0;
          }
          return (uint8)local_18;
        }
    }

    // Token : 0x6000927
    // RVA   : 0x1691460   Offset: 0x168FC60   Length: 0x11B
    public bool SetActive(object id, bool visible)
    {
        bool cVar1;
        byte uVar2;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong uStack_70;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint64 local_18;
        local_58 = 0;
        local_88 = 0;
        uStack_80 = 0;
        local_78 = 0;
        uStack_70 = 0;
        local_68 = 0;
        uStack_60 = 0;
        if (this[64] != 0) {
          cVar1 = FUN_181783890(this[64],id,&local_88,DAT_181da0a50);
          uVar2 = 0;
          if (cVar1) {
            if ((char)local_58 != visible) {
              local_58 = CONCAT71(local_58._1_7_,visible);
              if (this[64] == 0) throw; // [null/range check failed]
              local_48 = local_88;
              uStack_40 = uStack_80;
              local_38 = local_78;
              uStack_30 = uStack_70;
              local_28 = (uint32)local_68;
              uStack_24 = local_68._4_4_;
              uStack_20 = (uint32)uStack_60;
              uStack_1c = uStack_60._4_4_;
              local_18 = local_58;
              FUN_181789af0(this[64],id,&local_48,DAT_181da0c70);
              if ((char)this[11] == false) {
                (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
              }
            }
            uVar2 = 1;
          }
          return uVar2;
        }
    }

    // Token : 0x6000928
    // RVA   : 0x1691580   Offset: 0x168FD80   Length: 0x159
    public bool SetPosition(object id, Vector2 pos, bool visible)
    {
        uint8
        UISpriteCollection.SetPosition
                (int64 *this,uint64 id,uint64 pos,char visible)
        {
        uint64 uVar1;
        char cVar2;
        uint8 uVar3;
        float local_98;
        float fStack_94;
        uint64 local_90;
        uint64 uStack_88;
        uint64 local_80;
        uint64 uStack_78;
        uint64 local_70;
        uint64 uStack_68;
        uint64 local_60;
        uint64 local_58;
        uint64 uStack_50;
        uint64 local_48;
        uint64 uStack_40;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        local_60 = 0;
        local_90 = 0;
        uStack_88 = 0;
        local_80 = 0;
        uStack_78 = 0;
        local_70 = 0;
        uStack_68 = 0;
        if (this[64] != 0) {
          cVar2 = FUN_181783890(this[64],id,&local_90,DAT_181da0a50);
          uVar3 = 0;
          if (cVar2) {
            local_98 = (float)pos;
            fStack_94 = (float)((uint64)pos >> 32);
            uVar1 = pos;
            if ((9.9999994e-11 <=
                 (uStack_88._4_4_ - fStack_94) * (uStack_88._4_4_ - fStack_94) +
                 ((float)uStack_88 - local_98) * ((float)uStack_88 - local_98)) ||
               (uVar1 = uStack_88, (char)local_60 != visible)) {
              uStack_88 = uVar1;
              local_60 = CONCAT71(local_60._1_7_,visible);
              if (this[64] == 0) throw; // [null/range check failed]
              local_58 = local_90;
              uStack_50 = uStack_88;
              local_48 = local_80;
              uStack_40 = uStack_78;
              local_38 = (uint32)local_70;
              uStack_34 = local_70._4_4_;
              uStack_30 = (uint32)uStack_68;
              uStack_2c = uStack_68._4_4_;
              local_28 = local_60;
              FUN_181789af0(this[64],id,&local_58,DAT_181da0c70);
              if ((char)this[11] == false) {
                (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
              }
            }
            uVar3 = 1;
          }
          return uVar3;
        }
    }

    // Token : 0x6000929
    // RVA   : 0x16913B0   Offset: 0x168FBB0   Length: 0xA9
    private static Vector2 Rotate(Vector2 pos, float rot)
    {
        float fVar1;
        float fVar2;
        uint local_res20;
        uint uStackX_24;
        fVar2 = rot * 0.017453292 * 0.5;
        fVar1 = (float)FUN_1801e72c0(fVar2);
        fVar2 = (float)FUN_1801e67c0(fVar2);
        uStackX_24 = (float)((uint64)pos >> 32);
        local_res20 = (float)pos;
        fVar2 = fVar2 * (fVar1 + fVar1);
        fVar1 = 1.0 - fVar1 * (fVar1 + fVar1);
        return CONCAT44(fVar1 * uStackX_24 + local_res20 * fVar2,fVar1 * local_res20 - uStackX_24 * fVar2)
        ;
    }

    // Token : 0x600092A
    // RVA   : 0x168FBF0   Offset: 0x168E3F0   Length: 0x7C
    public object GetCurrentSpriteID()
    {
        float fVar1;
        float fVar2;
        bool cVar3;
        ulong uVar5;
        ulong uVar7;
        int iVar8;
        float local_res8;
        float fStackX_c;
        int aiStack_1bc [5];
        uint64 local_1a8;
        uint32 local_1a0;
        float local_198;
        float fStack_194;
        float fStack_190;
        float fStack_18c;
        uint64 local_188;
        uint64 uStack_180;
        uint64 local_178;
        uint64 uStack_170;
        uint64 local_168;
        uint64 uStack_160;
        uint64 local_158;
        uint64 uStack_150;
        uint32 local_148;
        uint32 uStack_144;
        uint32 uStack_140;
        uint32 uStack_13c;
        uint64 local_138;
        uint64 local_128;
        uint64 uStack_120;
        uint64 local_118;
        uint64 uStack_110;
        uint64 local_108;
        uint64 uStack_100;
        uint64 local_f8;
        uint64 local_e8;
        uint64 uStack_e0;
        uint64 local_d8;
        uint64 uStack_d0;
        uint64 local_c8;
        uint64 uStack_c0;
        uint64 local_b8;
        uint64 uStack_b0;
        uint32 local_a8;
        uint32 uStack_a4;
        uint32 uStack_a0;
        uint32 uStack_9c;
        uint64 local_98;
        local_128 = 0;
        uStack_120 = 0;
        local_118 = 0;
        uStack_110 = 0;
        local_108 = 0;
        uStack_100 = 0;
        local_f8 = 0;
        uVar7 = 0;
        aiStack_1bc[3] = 0;
        if (this[9] != 0) {
          local_1a8 = *param_2;
          local_1a0 = *(uint32 *)(param_2 + 1);
          puVar4 = (uint64 *)Transform.InverseTransformPoint(&local_198,this[9],&local_1a8,0);
          uVar5 = *puVar4;
          local_1a0 = *(uint32 *)(puVar4 + 1);
          local_1a8 = uVar5;
          if (this[64] != 0) {
            FUN_181774a90(&local_e8,this[64],DAT_181da0698);
            local_188 = local_e8;
            uStack_180 = uStack_e0;
            local_178 = local_d8;
            uStack_170 = uStack_d0;
            local_168 = local_c8;
            uStack_160 = uStack_c0;
            local_158 = local_b8;
            uStack_150 = uStack_b0;
            local_148 = local_a8;
            uStack_144 = uStack_a4;
            uStack_140 = uStack_a0;
            uStack_13c = uStack_9c;
            local_138 = local_98;
            fStackX_c = (float)((uint64)uVar5 >> 32);
            fVar2 = fStackX_c;
            local_res8 = (float)uVar5;
            fVar1 = local_res8;
            do {
              cVar3 = FUN_1811d5790(&local_188,DAT_181d79b28);
              if (!cVar3) {
                aiStack_1bc[1] = 212;
                iVar8 = aiStack_1bc[3] + 1;
                aiStack_1bc[3] = iVar8;
                ZhSegment.Initialize(&local_188,DAT_181d79aa8);
                goto LAB_18168fb90;
              }
              local_e8 = local_178;
              uStack_e0 = uStack_170;
              local_128 = uStack_170;
              uStack_120 = local_168;
              local_118 = uStack_160;
              uStack_110 = local_158;
              local_108 = uStack_150;
              uStack_100 = CONCAT44(uStack_144,local_148);
              local_f8 = CONCAT44(uStack_13c,uStack_140);
              local_res8 = fVar1 - (float)local_168;
              fStackX_c = fVar2 - local_168._4_4_;
              if ((float)uStack_160 != 0.0) {
                uVar5 = UISpriteCollection.Rotate(CONCAT44(fStackX_c,local_res8),-(float)uStack_160,0);
                local_res8 = (float)uVar5;
                fStackX_c = (float)((uint64)uVar5 >> 32);
              }
              uVar5 = (**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              pfVar6 = (float *)Sprite.GetDrawingDimensions(&local_1a8,&local_128,uVar5,0);
              uVar5 = local_e8;
              local_198 = *pfVar6;
              fStack_194 = pfVar6[1];
              fStack_190 = pfVar6[2];
              fStack_18c = pfVar6[3];
            } while ((((local_res8 < local_198) || (fStackX_c < fStack_194)) || (fStack_190 < local_res8))
                    || (fStack_18c < fStackX_c));
            aiStack_1bc[1] = 214;
            iVar8 = aiStack_1bc[3] + 1;
            aiStack_1bc[3] = iVar8;
            ZhSegment.Initialize(&local_188,DAT_181d79aa8);
            uVar7 = uVar5;
        LAB_18168fb90:
            if ((iVar8 == 0) || (aiStack_1bc[iVar8] != 214)) {
              uVar7 = 0;
            }
            return uVar7;
          }
        }
    }

    // Token : 0x600092B
    // RVA   : 0x16901C0   Offset: 0x168E9C0   Length: 0xB1
    public Nullable<Sprite> GetCurrentSprite()
    {
        uint64 *
        UISpriteCollection.GetCurrentSprite(uint64 *this,int64 *param_2,uint64 *param_3)
        {
        float fVar1;
        float fVar2;
        char cVar3;
        uint64 *puVar4;
        uint64 uVar5;
        float *pfVar6;
        int iVar7;
        uint32 uVar8;
        uint32 uVar9;
        uint32 uVar10;
        uint32 uVar11;
        uint32 uVar12;
        uint32 uVar13;
        uint32 uVar14;
        uint32 uVar15;
        uint32 uVar16;
        uint32 uVar17;
        uint32 uVar18;
        uint32 uVar19;
        uint32 uVar20;
        uint32 uVar21;
        uint32 uVar22;
        uint32 uVar23;
        uint32 uVar24;
        float local_res10;
        float fStackX_14;
        int aiStack_2bc [5];
        uint64 local_2a8;
        uint32 local_2a0;
        float local_298;
        float fStack_294;
        float fStack_290;
        float fStack_28c;
        uint64 local_288;
        uint64 uStack_280;
        uint64 local_278;
        uint64 uStack_270;
        uint64 local_268;
        uint64 uStack_260;
        uint64 local_258;
        uint64 uStack_250;
        uint32 local_248;
        uint32 uStack_244;
        uint32 uStack_240;
        uint32 uStack_23c;
        uint64 local_238;
        uint64 local_228;
        uint64 uStack_220;
        uint64 local_218;
        uint64 uStack_210;
        uint64 local_208;
        uint64 uStack_200;
        uint64 local_1f8;
        uint64 uStack_1f0;
        uint64 local_1e8;
        uint64 uStack_1e0;
        float local_1d8;
        float fStack_1d4;
        float fStack_1d0;
        uint32 uStack_1cc;
        uint64 local_1c8;
        uint64 uStack_1c0;
        uint64 local_1b8;
        uint64 uStack_1b0;
        uint32 local_1a8;
        uint32 uStack_1a4;
        uint32 uStack_1a0;
        uint32 uStack_19c;
        uint64 local_198;
        uint64 local_188;
        uint64 uStack_180;
        uint64 local_178;
        uint64 uStack_170;
        uint64 local_168;
        uint64 uStack_160;
        uint64 local_158;
        uint64 local_148;
        uint64 uStack_140;
        uint64 local_138;
        uint64 uStack_130;
        uint64 local_128;
        uint64 uStack_120;
        uint64 local_118;
        uint64 uStack_110;
        uint64 local_f8;
        uint64 uStack_f0;
        uint64 local_e8;
        uint64 uStack_e0;
        uint32 local_d8;
        uint32 uStack_d4;
        uint32 uStack_d0;
        uint32 uStack_cc;
        uint64 local_c8;
        local_188 = 0;
        uStack_180 = 0;
        local_178 = 0;
        uStack_170 = 0;
        local_168 = 0;
        uStack_160 = 0;
        local_158 = 0;
        uVar9 = 0;
        uVar10 = 0;
        uVar11 = 0;
        uVar12 = 0;
        local_228 = 0;
        uStack_220 = 0;
        uVar13 = 0;
        uVar14 = 0;
        uVar15 = 0;
        uVar16 = 0;
        local_218 = 0;
        uStack_210 = 0;
        uVar17 = 0;
        uVar18 = 0;
        uVar19 = 0;
        uVar20 = 0;
        local_208 = 0;
        uStack_200 = 0;
        uVar21 = 0;
        uVar22 = 0;
        uVar23 = 0;
        uVar24 = 0;
        local_1f8 = 0;
        uStack_1f0 = 0;
        aiStack_2bc[3] = 0;
        if (param_2[9] != 0) {
          local_2a8 = *param_3;
          local_2a0 = *(uint32 *)(param_3 + 1);
          puVar4 = (uint64 *)Transform.InverseTransformPoint(&local_298,param_2[9],&local_2a8,0);
          uVar5 = *puVar4;
          local_2a0 = *(uint32 *)(puVar4 + 1);
          local_2a8 = uVar5;
          if (param_2[64] != 0) {
            FUN_181774a90(&local_1e8,param_2[64],DAT_181da0698);
            local_288 = local_1e8;
            uStack_280 = uStack_1e0;
            local_278 = CONCAT44(fStack_1d4,local_1d8);
            uStack_270 = CONCAT44(uStack_1cc,fStack_1d0);
            local_268 = local_1c8;
            uStack_260 = uStack_1c0;
            local_258 = local_1b8;
            uStack_250 = uStack_1b0;
            local_248 = local_1a8;
            uStack_244 = uStack_1a4;
            uStack_240 = uStack_1a0;
            uStack_23c = uStack_19c;
            local_238 = local_198;
            fStackX_14 = (float)((uint64)uVar5 >> 32);
            fVar2 = fStackX_14;
            local_res10 = (float)uVar5;
            fVar1 = local_res10;
            do {
              cVar3 = FUN_1811d5790(&local_288,DAT_181d79b28);
              if (!cVar3) {
                aiStack_2bc[1] = 217;
                iVar7 = aiStack_2bc[3] + 1;
                aiStack_2bc[3] = iVar7;
                ZhSegment.Initialize(&local_288,DAT_181d79aa8);
                goto LAB_181690129;
              }
              local_1e8 = local_278;
              uStack_1e0 = uStack_270;
              local_1d8 = (float)local_268;
              fStack_1d4 = local_268._4_4_;
              fStack_1d0 = (float)uStack_260;
              uStack_1cc = uStack_260._4_4_;
              local_1c8 = local_258;
              uStack_1c0 = uStack_250;
              local_1b8 = CONCAT44(uStack_244,local_248);
              uStack_1b0 = CONCAT44(uStack_23c,uStack_240);
              local_188 = uStack_270;
              uStack_180 = local_268;
              local_178 = uStack_260;
              uStack_170 = local_258;
              local_168 = uStack_250;
              uStack_160 = CONCAT44(uStack_244,local_248);
              local_res10 = fVar1 - (float)local_268;
              fStackX_14 = fVar2 - local_268._4_4_;
              local_158 = uStack_1b0;
              if ((float)uStack_260 != 0.0) {
                uVar5 = UISpriteCollection.Rotate(CONCAT44(fStackX_14,local_res10),-(float)uStack_260,0);
                local_res10 = (float)uVar5;
                fStackX_14 = (float)((uint64)uVar5 >> 32);
              }
              uVar8 = (**(code **)(*param_2 + 0x3d8))(param_2,*(uint64 *)(*param_2 + 0x3e0));
              pfVar6 = (float *)Sprite.GetDrawingDimensions(&local_2a8,&local_188,uVar8,0);
              local_298 = *pfVar6;
              fStack_294 = pfVar6[1];
              fStack_290 = pfVar6[2];
              fStack_28c = pfVar6[3];
            } while ((((local_res10 < local_298) || (fStackX_14 < fStack_294)) ||
                     (fStack_290 < local_res10)) || (fStack_28c < fStackX_14));
            local_148 = 0;
            uStack_140 = 0;
            local_138 = 0;
            uStack_130 = 0;
            local_128 = 0;
            uStack_120 = 0;
            local_118 = 0;
            uStack_110 = 0;
            uStack_f0 = CONCAT44(fStack_1d4,local_1d8);
            local_f8 = uStack_1e0;
            local_e8 = CONCAT44(uStack_1cc,fStack_1d0);
            uStack_e0 = local_1c8;
            local_d8 = (uint32)uStack_1c0;
            uStack_d4 = uStack_1c0._4_4_;
            uStack_d0 = (uint32)local_1b8;
            uStack_cc = local_1b8._4_4_;
            local_c8 = uStack_1b0;
            FUN_1815cf2e0(&local_148,&local_f8,DAT_181d93170);
            uVar9 = (uint32)local_148;
            uVar10 = local_148._4_4_;
            uVar11 = (uint32)uStack_140;
            uVar12 = uStack_140._4_4_;
            local_228 = local_148;
            uStack_220 = uStack_140;
            uVar13 = (uint32)local_138;
            uVar14 = local_138._4_4_;
            uVar15 = (uint32)uStack_130;
            uVar16 = uStack_130._4_4_;
            local_218 = local_138;
            uStack_210 = uStack_130;
            uVar17 = (uint32)local_128;
            uVar18 = local_128._4_4_;
            uVar19 = (uint32)uStack_120;
            uVar20 = uStack_120._4_4_;
            local_208 = local_128;
            uStack_200 = uStack_120;
            uVar21 = (uint32)local_118;
            uVar22 = local_118._4_4_;
            uVar23 = (uint32)uStack_110;
            uVar24 = uStack_110._4_4_;
            local_1f8 = local_118;
            uStack_1f0 = uStack_110;
            aiStack_2bc[1] = 228;
            iVar7 = aiStack_2bc[3] + 1;
            aiStack_2bc[3] = iVar7;
            ZhSegment.Initialize(&local_288,DAT_181d79aa8);
        LAB_181690129:
            if ((iVar7 == 0) || (aiStack_2bc[iVar7] != 228)) {
              *this = 0;
              this[1] = 0;
              this[2] = 0;
              this[3] = 0;
              this[4] = 0;
              this[5] = 0;
              this[6] = 0;
              this[7] = 0;
            }
            else {
              *(uint32 *)this = uVar9;
              *(uint32 *)((int64)this + 4) = uVar10;
              *(uint32 *)(this + 1) = uVar11;
              *(uint32 *)((int64)this + 12) = uVar12;
              *(uint32 *)(this + 2) = uVar13;
              *(uint32 *)((int64)this + 20) = uVar14;
              *(uint32 *)(this + 3) = uVar15;
              *(uint32 *)((int64)this + 28) = uVar16;
              *(uint32 *)(this + 4) = uVar17;
              *(uint32 *)((int64)this + 36) = uVar18;
              *(uint32 *)(this + 5) = uVar19;
              *(uint32 *)((int64)this + 44) = uVar20;
              *(uint32 *)(this + 6) = uVar21;
              *(uint32 *)((int64)this + 52) = uVar22;
              *(uint32 *)(this + 7) = uVar23;
              *(uint32 *)((int64)this + 60) = uVar24;
            }
            return this;
          }
        }
    }

    // Token : 0x600092C
    // RVA   : 0x168F830   Offset: 0x168E030   Length: 0x3B7
    public object GetCurrentSpriteID(Vector3 worldPos)
    {
        float fVar1;
        float fVar2;
        bool cVar3;
        ulong uVar5;
        ulong uVar7;
        int iVar8;
        float local_res8;
        float fStackX_c;
        int aiStack_1bc [5];
        uint64 local_1a8;
        uint32 local_1a0;
        float local_198;
        float fStack_194;
        float fStack_190;
        float fStack_18c;
        uint64 local_188;
        uint64 uStack_180;
        uint64 local_178;
        uint64 uStack_170;
        uint64 local_168;
        uint64 uStack_160;
        uint64 local_158;
        uint64 uStack_150;
        uint32 local_148;
        uint32 uStack_144;
        uint32 uStack_140;
        uint32 uStack_13c;
        uint64 local_138;
        uint64 local_128;
        uint64 uStack_120;
        uint64 local_118;
        uint64 uStack_110;
        uint64 local_108;
        uint64 uStack_100;
        uint64 local_f8;
        uint64 local_e8;
        uint64 uStack_e0;
        uint64 local_d8;
        uint64 uStack_d0;
        uint64 local_c8;
        uint64 uStack_c0;
        uint64 local_b8;
        uint64 uStack_b0;
        uint32 local_a8;
        uint32 uStack_a4;
        uint32 uStack_a0;
        uint32 uStack_9c;
        uint64 local_98;
        local_128 = 0;
        uStack_120 = 0;
        local_118 = 0;
        uStack_110 = 0;
        local_108 = 0;
        uStack_100 = 0;
        local_f8 = 0;
        uVar7 = 0;
        aiStack_1bc[3] = 0;
        if (this[9] != 0) {
          local_1a8 = *worldPos;
          local_1a0 = *(uint32 *)(worldPos + 1);
          puVar4 = (uint64 *)Transform.InverseTransformPoint(&local_198,this[9],&local_1a8,0);
          uVar5 = *puVar4;
          local_1a0 = *(uint32 *)(puVar4 + 1);
          local_1a8 = uVar5;
          if (this[64] != 0) {
            FUN_181774a90(&local_e8,this[64],DAT_181da0698);
            local_188 = local_e8;
            uStack_180 = uStack_e0;
            local_178 = local_d8;
            uStack_170 = uStack_d0;
            local_168 = local_c8;
            uStack_160 = uStack_c0;
            local_158 = local_b8;
            uStack_150 = uStack_b0;
            local_148 = local_a8;
            uStack_144 = uStack_a4;
            uStack_140 = uStack_a0;
            uStack_13c = uStack_9c;
            local_138 = local_98;
            fStackX_c = (float)((uint64)uVar5 >> 32);
            fVar2 = fStackX_c;
            local_res8 = (float)uVar5;
            fVar1 = local_res8;
            do {
              cVar3 = FUN_1811d5790(&local_188,DAT_181d79b28);
              if (!cVar3) {
                aiStack_1bc[1] = 212;
                iVar8 = aiStack_1bc[3] + 1;
                aiStack_1bc[3] = iVar8;
                ZhSegment.Initialize(&local_188,DAT_181d79aa8);
                goto LAB_18168fb90;
              }
              local_e8 = local_178;
              uStack_e0 = uStack_170;
              local_128 = uStack_170;
              uStack_120 = local_168;
              local_118 = uStack_160;
              uStack_110 = local_158;
              local_108 = uStack_150;
              uStack_100 = CONCAT44(uStack_144,local_148);
              local_f8 = CONCAT44(uStack_13c,uStack_140);
              local_res8 = fVar1 - (float)local_168;
              fStackX_c = fVar2 - local_168._4_4_;
              if ((float)uStack_160 != 0.0) {
                uVar5 = UISpriteCollection.Rotate(CONCAT44(fStackX_c,local_res8),-(float)uStack_160,0);
                local_res8 = (float)uVar5;
                fStackX_c = (float)((uint64)uVar5 >> 32);
              }
              uVar5 = (**(code **)(*this + 0x3d8))(this,*(uint64 *)(*this + 0x3e0));
              pfVar6 = (float *)Sprite.GetDrawingDimensions(&local_1a8,&local_128,uVar5,0);
              uVar5 = local_e8;
              local_198 = *pfVar6;
              fStack_194 = pfVar6[1];
              fStack_190 = pfVar6[2];
              fStack_18c = pfVar6[3];
            } while ((((local_res8 < local_198) || (fStackX_c < fStack_194)) || (fStack_190 < local_res8))
                    || (fStack_18c < fStackX_c));
            aiStack_1bc[1] = 214;
            iVar8 = aiStack_1bc[3] + 1;
            aiStack_1bc[3] = iVar8;
            ZhSegment.Initialize(&local_188,DAT_181d79aa8);
            uVar7 = uVar5;
        LAB_18168fb90:
            if ((iVar8 == 0) || (aiStack_1bc[iVar8] != 214)) {
              uVar7 = 0;
            }
            return uVar7;
          }
        }
    }

    // Token : 0x600092D
    // RVA   : 0x168FC70   Offset: 0x168E470   Length: 0x54D
    public Nullable<Sprite> GetCurrentSprite(Vector3 worldPos)
    {
        uint64 *
        UISpriteCollection.GetCurrentSprite(uint64 *this,int64 *worldPos,uint64 *param_3)
        {
        float fVar1;
        float fVar2;
        char cVar3;
        uint64 *puVar4;
        uint64 uVar5;
        float *pfVar6;
        int iVar7;
        uint32 uVar8;
        uint32 uVar9;
        uint32 uVar10;
        uint32 uVar11;
        uint32 uVar12;
        uint32 uVar13;
        uint32 uVar14;
        uint32 uVar15;
        uint32 uVar16;
        uint32 uVar17;
        uint32 uVar18;
        uint32 uVar19;
        uint32 uVar20;
        uint32 uVar21;
        uint32 uVar22;
        uint32 uVar23;
        uint32 uVar24;
        float local_res10;
        float fStackX_14;
        int aiStack_2bc [5];
        uint64 local_2a8;
        uint32 local_2a0;
        float local_298;
        float fStack_294;
        float fStack_290;
        float fStack_28c;
        uint64 local_288;
        uint64 uStack_280;
        uint64 local_278;
        uint64 uStack_270;
        uint64 local_268;
        uint64 uStack_260;
        uint64 local_258;
        uint64 uStack_250;
        uint32 local_248;
        uint32 uStack_244;
        uint32 uStack_240;
        uint32 uStack_23c;
        uint64 local_238;
        uint64 local_228;
        uint64 uStack_220;
        uint64 local_218;
        uint64 uStack_210;
        uint64 local_208;
        uint64 uStack_200;
        uint64 local_1f8;
        uint64 uStack_1f0;
        uint64 local_1e8;
        uint64 uStack_1e0;
        float local_1d8;
        float fStack_1d4;
        float fStack_1d0;
        uint32 uStack_1cc;
        uint64 local_1c8;
        uint64 uStack_1c0;
        uint64 local_1b8;
        uint64 uStack_1b0;
        uint32 local_1a8;
        uint32 uStack_1a4;
        uint32 uStack_1a0;
        uint32 uStack_19c;
        uint64 local_198;
        uint64 local_188;
        uint64 uStack_180;
        uint64 local_178;
        uint64 uStack_170;
        uint64 local_168;
        uint64 uStack_160;
        uint64 local_158;
        uint64 local_148;
        uint64 uStack_140;
        uint64 local_138;
        uint64 uStack_130;
        uint64 local_128;
        uint64 uStack_120;
        uint64 local_118;
        uint64 uStack_110;
        uint64 local_f8;
        uint64 uStack_f0;
        uint64 local_e8;
        uint64 uStack_e0;
        uint32 local_d8;
        uint32 uStack_d4;
        uint32 uStack_d0;
        uint32 uStack_cc;
        uint64 local_c8;
        local_188 = 0;
        uStack_180 = 0;
        local_178 = 0;
        uStack_170 = 0;
        local_168 = 0;
        uStack_160 = 0;
        local_158 = 0;
        uVar9 = 0;
        uVar10 = 0;
        uVar11 = 0;
        uVar12 = 0;
        local_228 = 0;
        uStack_220 = 0;
        uVar13 = 0;
        uVar14 = 0;
        uVar15 = 0;
        uVar16 = 0;
        local_218 = 0;
        uStack_210 = 0;
        uVar17 = 0;
        uVar18 = 0;
        uVar19 = 0;
        uVar20 = 0;
        local_208 = 0;
        uStack_200 = 0;
        uVar21 = 0;
        uVar22 = 0;
        uVar23 = 0;
        uVar24 = 0;
        local_1f8 = 0;
        uStack_1f0 = 0;
        aiStack_2bc[3] = 0;
        if (worldPos[9] != 0) {
          local_2a8 = *param_3;
          local_2a0 = *(uint32 *)(param_3 + 1);
          puVar4 = (uint64 *)Transform.InverseTransformPoint(&local_298,worldPos[9],&local_2a8,0);
          uVar5 = *puVar4;
          local_2a0 = *(uint32 *)(puVar4 + 1);
          local_2a8 = uVar5;
          if (worldPos[64] != 0) {
            FUN_181774a90(&local_1e8,worldPos[64],DAT_181da0698);
            local_288 = local_1e8;
            uStack_280 = uStack_1e0;
            local_278 = CONCAT44(fStack_1d4,local_1d8);
            uStack_270 = CONCAT44(uStack_1cc,fStack_1d0);
            local_268 = local_1c8;
            uStack_260 = uStack_1c0;
            local_258 = local_1b8;
            uStack_250 = uStack_1b0;
            local_248 = local_1a8;
            uStack_244 = uStack_1a4;
            uStack_240 = uStack_1a0;
            uStack_23c = uStack_19c;
            local_238 = local_198;
            fStackX_14 = (float)((uint64)uVar5 >> 32);
            fVar2 = fStackX_14;
            local_res10 = (float)uVar5;
            fVar1 = local_res10;
            do {
              cVar3 = FUN_1811d5790(&local_288,DAT_181d79b28);
              if (!cVar3) {
                aiStack_2bc[1] = 217;
                iVar7 = aiStack_2bc[3] + 1;
                aiStack_2bc[3] = iVar7;
                ZhSegment.Initialize(&local_288,DAT_181d79aa8);
                goto LAB_181690129;
              }
              local_1e8 = local_278;
              uStack_1e0 = uStack_270;
              local_1d8 = (float)local_268;
              fStack_1d4 = local_268._4_4_;
              fStack_1d0 = (float)uStack_260;
              uStack_1cc = uStack_260._4_4_;
              local_1c8 = local_258;
              uStack_1c0 = uStack_250;
              local_1b8 = CONCAT44(uStack_244,local_248);
              uStack_1b0 = CONCAT44(uStack_23c,uStack_240);
              local_188 = uStack_270;
              uStack_180 = local_268;
              local_178 = uStack_260;
              uStack_170 = local_258;
              local_168 = uStack_250;
              uStack_160 = CONCAT44(uStack_244,local_248);
              local_res10 = fVar1 - (float)local_268;
              fStackX_14 = fVar2 - local_268._4_4_;
              local_158 = uStack_1b0;
              if ((float)uStack_260 != 0.0) {
                uVar5 = UISpriteCollection.Rotate(CONCAT44(fStackX_14,local_res10),-(float)uStack_260,0);
                local_res10 = (float)uVar5;
                fStackX_14 = (float)((uint64)uVar5 >> 32);
              }
              uVar8 = (**(code **)(*worldPos + 0x3d8))(worldPos,*(uint64 *)(*worldPos + 0x3e0));
              pfVar6 = (float *)Sprite.GetDrawingDimensions(&local_2a8,&local_188,uVar8,0);
              local_298 = *pfVar6;
              fStack_294 = pfVar6[1];
              fStack_290 = pfVar6[2];
              fStack_28c = pfVar6[3];
            } while ((((local_res10 < local_298) || (fStackX_14 < fStack_294)) ||
                     (fStack_290 < local_res10)) || (fStack_28c < fStackX_14));
            local_148 = 0;
            uStack_140 = 0;
            local_138 = 0;
            uStack_130 = 0;
            local_128 = 0;
            uStack_120 = 0;
            local_118 = 0;
            uStack_110 = 0;
            uStack_f0 = CONCAT44(fStack_1d4,local_1d8);
            local_f8 = uStack_1e0;
            local_e8 = CONCAT44(uStack_1cc,fStack_1d0);
            uStack_e0 = local_1c8;
            local_d8 = (uint32)uStack_1c0;
            uStack_d4 = uStack_1c0._4_4_;
            uStack_d0 = (uint32)local_1b8;
            uStack_cc = local_1b8._4_4_;
            local_c8 = uStack_1b0;
            FUN_1815cf2e0(&local_148,&local_f8,DAT_181d93170);
            uVar9 = (uint32)local_148;
            uVar10 = local_148._4_4_;
            uVar11 = (uint32)uStack_140;
            uVar12 = uStack_140._4_4_;
            local_228 = local_148;
            uStack_220 = uStack_140;
            uVar13 = (uint32)local_138;
            uVar14 = local_138._4_4_;
            uVar15 = (uint32)uStack_130;
            uVar16 = uStack_130._4_4_;
            local_218 = local_138;
            uStack_210 = uStack_130;
            uVar17 = (uint32)local_128;
            uVar18 = local_128._4_4_;
            uVar19 = (uint32)uStack_120;
            uVar20 = uStack_120._4_4_;
            local_208 = local_128;
            uStack_200 = uStack_120;
            uVar21 = (uint32)local_118;
            uVar22 = local_118._4_4_;
            uVar23 = (uint32)uStack_110;
            uVar24 = uStack_110._4_4_;
            local_1f8 = local_118;
            uStack_1f0 = uStack_110;
            aiStack_2bc[1] = 228;
            iVar7 = aiStack_2bc[3] + 1;
            aiStack_2bc[3] = iVar7;
            ZhSegment.Initialize(&local_288,DAT_181d79aa8);
        LAB_181690129:
            if ((iVar7 == 0) || (aiStack_2bc[iVar7] != 228)) {
              *this = 0;
              this[1] = 0;
              this[2] = 0;
              this[3] = 0;
              this[4] = 0;
              this[5] = 0;
              this[6] = 0;
              this[7] = 0;
            }
            else {
              *(uint32 *)this = uVar9;
              *(uint32 *)((int64)this + 4) = uVar10;
              *(uint32 *)(this + 1) = uVar11;
              *(uint32 *)((int64)this + 12) = uVar12;
              *(uint32 *)(this + 2) = uVar13;
              *(uint32 *)((int64)this + 20) = uVar14;
              *(uint32 *)(this + 3) = uVar15;
              *(uint32 *)((int64)this + 28) = uVar16;
              *(uint32 *)(this + 4) = uVar17;
              *(uint32 *)((int64)this + 36) = uVar18;
              *(uint32 *)(this + 5) = uVar19;
              *(uint32 *)((int64)this + 44) = uVar20;
              *(uint32 *)(this + 6) = uVar21;
              *(uint32 *)((int64)this + 52) = uVar22;
              *(uint32 *)(this + 7) = uVar23;
              *(uint32 *)((int64)this + 60) = uVar24;
            }
            return this;
          }
        }
    }

    // Token : 0x600092E
    // RVA   : 0x1690460   Offset: 0x168EC60   Length: 0x46
    protected void OnClick()
    {
        long lVar1;
        if (this.onClick != null) {
          lVar1 = UISpriteCollection.GetCurrentSpriteID(this,0);
          if (lVar1 != null) {
            if (this.onClick != null) {
              OnClickCB.Invoke(this.onClick,lVar1,0);
              return;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x600092F
    // RVA   : 0x16911C0   Offset: 0x168F9C0   Length: 0xA8
    protected void OnPress(bool isPressed)
    {
        long lVar2;
        if ((this.onPress != null) &&
           ((!isPressed || (this.mLastPress == null)))) {
          plVar1 = &this.mLastPress;
          if (!isPressed) {
            if (this.mLastPress != null) {
              OnTooltipCB.Invoke(this.onPress,this.mLastPress,0,0);
              this.mLastPress = 0;
              il2cpp_internal(plVar1,0);
            }
          }
          else {
            lVar2 = UISpriteCollection.GetCurrentSpriteID(this,0);
            this.mLastPress = lVar2;
            il2cpp_internal(plVar1,lVar2);
            if (this.mLastPress != null) {
              if (this.onPress == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              OnTooltipCB.Invoke(this.onPress,this.mLastPress,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000930
    // RVA   : 0x1690E00   Offset: 0x168F600   Length: 0x2B1
    protected void OnHover(bool isOver)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        long lVar6;
        if (this.onHover != null) {
          if (!isOver) {
            uVar1 = *(uint64 *)(pStatics + 0x180);
            uVar4 = new OnTooltipCB(this,DAT_181d9d510,0);
            plVar5 = (int64 *)Delegate.Remove(uVar1,uVar4,0);
            plVar7 = (int64 *)0;
            if (plVar5 != (int64 *)0) {
              if (*plVar5 == DAT_181d68290) {
                plVar7 = plVar5;
              }
              if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar5,DAT_181d68290);
              }
            }
            *(int64 **)(pStatics + 0x180) = plVar7;
            return;
          }
          uVar1 = *(uint64 *)(pStatics + 0x180);
          uVar4 = new OnTooltipCB(this,DAT_181d9d510,0);
          plVar5 = (int64 *)Delegate.Combine(uVar1,uVar4,0);
          plVar7 = (int64 *)0;
          if (plVar5 != (int64 *)0) {
            if (*plVar5 == DAT_181d68290) {
              plVar7 = plVar5;
            }
            if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6070(plVar5,DAT_181d68290);
            }
          }
          *(int64 **)(pStatics + 0x180) = plVar7;
          Vector2.get_zero(0);
          cVar3 = Object.op_Implicit(this,0);
          if (!cVar3) {
            return;
          }
          if (this.onHover == null) {
            return;
          }
          lVar6 = UISpriteCollection.GetCurrentSpriteID(this,0);
          lVar2 = this.mLastHover;
          if (lVar2 == lVar6) {
            return;
          }
          if (lVar2 != null) {
            if (this.onHover != null)
            {
              OnTooltipCB.Invoke(this.onHover,lVar2,0,0);
              }
              this.mLastHover = lVar6;
              if (this.mLastHover != null) {
              if (this.onHover != null) {
              OnTooltipCB.Invoke(this.onHover,this.mLastHover,1,0);
              return;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000931
    // RVA   : 0x16910C0   Offset: 0x168F8C0   Length: 0xF0
    protected void OnMove(Vector2 delta)
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        cVar2 = Object.op_Implicit(this,0);
        if ((cVar2) && (this.onHover != null)) {
          lVar3 = UISpriteCollection.GetCurrentSpriteID(this,0);
          lVar1 = this.mLastHover;
          if (lVar1 == lVar3) {
            return;
          }
          if (lVar1 != null) {
            if (this.onHover != null)
            {
              OnTooltipCB.Invoke(this.onHover,lVar1,0,0);
              }
              this.mLastHover = lVar3;
              if (this.mLastHover != null) {
              if (this.onHover == null) {
            }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            OnTooltipCB.Invoke(this.onHover,this.mLastHover,1,0);
          }
        }
    }

    // Token : 0x6000932
    // RVA   : 0x16904B0   Offset: 0x168ECB0   Length: 0x2E
    protected void OnDrag(Vector2 delta)
    {
        void FUN_1816904b0(int64 this,uint64 delta)
        {
        if ((this.onDrag != null) && (this.mLastPress != null)) {
          OnDragCB.Invoke(this.onDrag,this.mLastPress,delta,0);
          return;
        }
    }

    // Token : 0x6000933
    // RVA   : 0x1691270   Offset: 0x168FA70   Length: 0xA5
    protected void OnTooltip(bool show)
    {
        long lVar2;
        long lVar3;
        lVar3 = this.onTooltip;
        if (lVar3 != null) {
          lVar2 = this.mLastTooltip;
          if (!show) {
            OnTooltipCB.Invoke(lVar3,lVar2,0,0);
            *plVar1 = 0;
            il2cpp_internal(plVar1,0);
          }
          else {
            if (lVar2 != null) {
              OnTooltipCB.Invoke(lVar3,lVar2,0,0);
            }
            lVar3 = UISpriteCollection.GetCurrentSpriteID(this,0);
            *plVar1 = lVar3;
            il2cpp_internal(plVar1,lVar3);
            if (*plVar1 != 0) {
              if (this.onTooltip == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              OnTooltipCB.Invoke(this.onTooltip,*plVar1,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000934
    // RVA   : 0x1691790   Offset: 0x168FF90   Length: 0xA3
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d5d6c8);
        FUN_1808ae540(uVar1,DAT_181da0368);
        this.mSprites = uVar1;
        UIBasicSprite.ctor(this,0);
    }

}
