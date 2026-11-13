// ============================================================
// Type  : NGUIFont
// Token : 0x20000CE
// ============================================================

public class NGUIFont
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40004CB
    private Material mMat;

    // Token: 0x40004CC
    private Rect mUVRect;

    // Token: 0x40004CD
    private BMFont mFont;

    // Token: 0x40004CE
    private object mAtlas;

    // Token: 0x40004CF
    private object mReplacement;

    // Token: 0x40004D0
    private List<BMSymbol> mSymbols;

    // Token: 0x40004D1
    private Font mDynamicFont;

    // Token: 0x40004D2
    private int mDynamicFontSize;

    // Token: 0x40004D3
    private FontStyle mDynamicFontStyle;

    // Token: 0x40004D4
    private UISpriteData mSprite;

    // Token: 0x40004D5
    private int mPMA;

    // Token: 0x40004D6
    private int mPacked;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600066E
    // RVA   : 0x8558D0   Offset: 0x8546D0   Length: 0x54
    public virtual BMFont get_bmFont()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002280(0,DAT_181e5a6e0,lVar1);
          return uVar2;
        }
        return this.mFont;
    }

    // Token : 0x600066F
    // RVA   : 0x856E30   Offset: 0x855C30   Length: 0xDD
    public virtual void set_bmFont(BMFont value)
    {
        long lVar1;
        ushort uVar4;
        plVar2 = (int64 *)NGUIFont.get_replacement(this,0);
        if (plVar2 == (int64 *)0) {
          this.mFont = value;
          return;
        }
        lVar1 = *plVar2;
        uVar4 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181e5a6e0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                        16 + 0x148 + lVar1);
              goto LAB_180856eda;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,1);
        LAB_180856eda:
                          // WARNING: Could not recover jumptable at 0x000180856ef3. Too many branches
                          // WARNING: Treating indirect jump as call
        (*(code *)*puVar3)(plVar2,value,puVar3[1]);
    }

    // Token : 0x6000670
    // RVA   : 0x856850   Offset: 0x855650   Length: 0x6A
    public virtual int get_texWidth()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002280(2,DAT_181e5a6e0,lVar1);
          return uVar2;
        }
        if (this.mFont != null) {
          return (uint64)this.mFont.mWidth;
        }
        return 1;
    }

    // Token : 0x6000671
    // RVA   : 0x8576A0   Offset: 0x8564A0   Length: 0x73
    public virtual void set_texWidth(int value)
    {
        long lVar1;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 == null) {
          if (this.mFont != null) {
            this.mFont.mWidth = value;
            return;
          }
        }
        else {
          FUN_180054430(3,DAT_181e5a6e0,lVar1,value);
        }
    }

    // Token : 0x6000672
    // RVA   : 0x8567E0   Offset: 0x8555E0   Length: 0x6A
    public virtual int get_texHeight()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002280(4,DAT_181e5a6e0,lVar1);
          return uVar2;
        }
        if (this.mFont != null) {
          return (uint64)this.mFont.mHeight;
        }
        return 1;
    }

    // Token : 0x6000673
    // RVA   : 0x857620   Offset: 0x856420   Length: 0x73
    public virtual void set_texHeight(int value)
    {
        long lVar1;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 == null) {
          if (this.mFont != null) {
            this.mFont.mHeight = value;
            return;
          }
        }
        else {
          FUN_180054430(5,DAT_181e5a6e0,lVar1,value);
        }
    }

    // Token : 0x6000674
    // RVA   : 0x855C30   Offset: 0x854A30   Length: 0x75
    public virtual bool get_hasSymbols()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002280(6,DAT_181e5a6e0,lVar1);
          return uVar2;
        }
        lVar1 = this.mSymbols;
        if (lVar1 == null) {
          return false;
        }
        return CONCAT71((int7)((uint64)lVar1 >> 8),lVar1.Count != null);
    }

    // Token : 0x6000675
    // RVA   : 0x856710   Offset: 0x855510   Length: 0xC2
    public virtual List<BMSymbol> get_symbols()
    {
        long lVar1;
        ulong uVar4;
        ushort uVar5;
        plVar2 = (int64 *)NGUIFont.get_replacement(this,0);
        if (plVar2 == (int64 *)0) {
          return this.mSymbols;
        }
        lVar1 = *plVar2;
        uVar5 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar5 * 16) == DAT_181e5a6e0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar5 * 16) *
                        16 + 0x1a8 + lVar1);
              goto LAB_180856798;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,7);
        LAB_180856798:
                          // WARNING: Could not recover jumptable at 0x0001808567a9. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar4 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar4;
    }

    // Token : 0x6000676
    // RVA   : 0x857540   Offset: 0x856340   Length: 0xDD
    public virtual void set_symbols(List<BMSymbol> value)
    {
        long lVar1;
        ushort uVar4;
        plVar2 = (int64 *)NGUIFont.get_replacement(this,0);
        if (plVar2 == (int64 *)0) {
          this.mSymbols = value;
          return;
        }
        lVar1 = *plVar2;
        uVar4 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181e5a6e0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                        16 + 0x1b8 + lVar1);
              goto LAB_1808575ea;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,8);
        LAB_1808575ea:
                          // WARNING: Could not recover jumptable at 0x000180857603. Too many branches
                          // WARNING: Treating indirect jump as call
        (*(code *)*puVar3)(plVar2,value,puVar3[1]);
    }

    // Token : 0x6000677
    // RVA   : 0x855860   Offset: 0x854660   Length: 0x6E
    public virtual INGUIAtlas get_atlas()
    {
        long lVar1;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 == null) {
          il2cpp_internal(this.mAtlas,DAT_181e5a658);
          return;
        }
        FUN_180002280(9,DAT_181e5a6e0,lVar1);
    }

    // Token : 0x6000678
    // RVA   : 0x856B80   Offset: 0x855980   Length: 0x2AA
    public virtual void set_atlas(INGUIAtlas value)
    {
        bool cVar2;
        long lVar3;
        ulong uVar5;
        ushort uVar8;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        uint uVar13;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        lVar3 = NGUIFont.get_replacement(this,0);
        if (lVar3 != null) {
          FUN_18005fa20(10,DAT_181e5a6e0,lVar3,value);
          return;
        }
        plVar4 = (int64 *)il2cpp_internal(this.mAtlas,DAT_181e5a658);
        if (plVar4 == value) {
          return;
        }
        this.mPMA = 0xffffffff;
        if (value == (int64 *)0) {
          this.mAtlas = 0;
          this.mAtlas = 0;
          this.mMat = 0;
        }
        else {
          if ((*(byte *)(*value + 300) < *(byte *)(DAT_181e6e5e8 + 300)) ||
             (*(int64 *)
               (*(int64 *)(*value + 200) + -8 + (uint64)*(byte *)(DAT_181e6e5e8 + 300) * 8) !=
              DAT_181e6e5e8)) {
            bVar1 = false;
          }
          else {
            bVar1 = true;
          }
          plVar9 = (int64 *)0;
          plVar4 = plVar9;
          if (bVar1) {
            plVar4 = value;
          }
          this.mAtlas = plVar4;
          uVar5 = FUN_180002280(0,DAT_181e5a658,value);
          this.mMat = uVar5;
          lVar3 = NGUIFont.get_sprite(this,0);
          if (lVar3 != null) {
            plVar4 = (int64 *)NGUIFont.get_replacement(this,0);
            if (plVar4 == (int64 *)0) {
              uVar5 = this.mAtlas;
              cVar2 = Object.op_Inequality(uVar5,0,0);
              if ((!cVar2) || (lVar3 = NGUIFont.get_sprite(this,0)) == null) {
                local_28 = 0;
                uStack_20 = 0;
                FUN_1807282e0(&local_28,0,0,0x3f800000,0x3f800000,0);
                uVar10 = (uint32)local_28;
                uVar11 = local_28._4_4_;
                uVar12 = (uint32)uStack_20;
                uVar13 = uStack_20._4_4_;
              }
              else {
                uVar10 = this.mUVRect;
                uVar11 = *(uint32 *)(this + 36);
                uVar12 = *(uint32 *)(this + 40);
                uVar13 = *(uint32 *)(this + 44);
              }
            }
            else {
              lVar3 = *plVar4;
              if (*(uint16 *)(lVar3 + 0x12a) != 0) {
                do {
                  if (*(int64 *)(*(int64 *)(lVar3 + 176) + (int64)plVar9 * 16) ==
                      DAT_181e5a6e0) {
                    puVar6 = (uint64 *)
                             ((int64)
                              *(int *)(*(int64 *)(lVar3 + 176) + 8 + (int64)plVar9 * 16) * 16 +
                              0x248 + lVar3);
                    goto LAB_180856db7;
                  }
                  uVar8 = (short)plVar9 + 1;
                  plVar9 = (int64 *)(uint64)uVar8;
                } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
              }
              puVar6 = (uint64 *)FUN_18019b1f0(plVar4,DAT_181e5a6e0,17);
        LAB_180856db7:
              puVar7 = (uint32 *)(*(code *)*puVar6)(local_18,plVar4,puVar6[1]);
              uVar10 = *puVar7;
              uVar11 = puVar7[1];
              uVar12 = puVar7[2];
              uVar13 = puVar7[3];
            }
            this.mUVRect = uVar10;
            *(uint32 *)(this + 36) = uVar11;
            *(uint32 *)(this + 40) = uVar12;
            *(uint32 *)(this + 44) = uVar13;
          }
        }
        NGUIFont.MarkAsChanged(this,0);
    }

    // Token : 0x6000679
    // RVA   : 0x854720   Offset: 0x853520   Length: 0xBA
    public virtual UISpriteData GetSprite(string spriteName)
    {
        long lVar1;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 == null) {
          lVar1 = il2cpp_internal(this.mAtlas,DAT_181e5a658);
        }
        else {
          lVar1 = FUN_180002280(9,DAT_181e5a6e0,lVar1);
        }
        if (lVar1 == null) {
          return;
        }
        FUN_180054130(10,DAT_181e5a658,lVar1,spriteName);
    }

    // Token : 0x600067A
    // RVA   : 0x855DD0   Offset: 0x854BD0   Length: 0x1F8
    public virtual Material get_material()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        lVar2 = NGUIFont.get_replacement(this,0);
        if (lVar2 != null) {
          uVar3 = FUN_180002280(12,DAT_181e5a6e0,lVar2);
          return uVar3;
        }
        lVar2 = il2cpp_internal(this.mAtlas,DAT_181e5a658);
        if (lVar2 != null) {
          uVar3 = FUN_180002280(0,DAT_181e5a658,lVar2);
          return uVar3;
        }
        uVar3 = this.mMat;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        uVar3 = this.mDynamicFont;
        if (!cVar1) {
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) {
            return 0;
          }
          if (this.mDynamicFont != null) {
            uVar3 = Font.get_material(this.mDynamicFont,0);
            return uVar3;
          }
        }
        else {
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) {
        LAB_180855f85:
            return this.mMat;
          }
          uVar3 = this.mMat;
          if (this.mDynamicFont != null) {
            uVar4 = Font.get_material(this.mDynamicFont,0);
            cVar1 = Object.op_Inequality(uVar3,uVar4,0);
            if (!cVar1) goto LAB_180855f85;
            lVar2 = this.mMat;
            if (this.mDynamicFont != null) {
              lVar5 = Font.get_material(this.mDynamicFont,0);
              if (lVar5 != null) {
                uVar3 = Material.get_mainTexture(lVar5,0);
                if (lVar2 != null) {
                  Material.set_mainTexture(lVar2,uVar3,0);
                  goto LAB_180855f85;
                }
              }
            }
          }
        }
    }

    // Token : 0x600067B
    // RVA   : 0x857230   Offset: 0x856030   Length: 0xDB
    public virtual void set_material(Material value)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        lVar3 = NGUIFont.get_replacement(this,0);
        if (lVar3 == null) {
          uVar1 = this.mMat;
          cVar2 = Object.op_Inequality(uVar1,value,0);
          if (cVar2) {
            this.mPMA = 0xffffffff;
            this.mMat = value;
            NGUIFont.MarkAsChanged(this,0);
          }
          return;
        }
        FUN_18005fa20(13,DAT_181e5a6e0,lVar3,value);
    }

    // Token : 0x600067C
    // RVA   : 0x856320   Offset: 0x855120   Length: 0x7
    public bool get_premultipliedAlpha()
    {
        void FUN_180856320(uint64 this)
        {
        NGUIFont.get_premultipliedAlphaShader(this,0);
    }

    // Token : 0x600067D
    // RVA   : 0x856180   Offset: 0x854F80   Length: 0x19D
    public virtual bool get_premultipliedAlphaShader()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar2 = NGUIFont.get_replacement(this,0);
        if (lVar2 != null) {
          uVar3 = FUN_180002280(14,DAT_181e5a6e0,lVar2);
          return uVar3;
        }
        lVar2 = il2cpp_internal(this.mAtlas,DAT_181e5a658);
        if (lVar2 != null) {
          uVar3 = FUN_180002280(7,DAT_181e5a658,lVar2);
          return uVar3;
        }
        uVar4 = (uint64)this.mPMA;
        if (this.mPMA != 0xffffffff) goto LAB_1808562d5;
        lVar2 = NGUIFont.get_material(this,0);
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (!cVar1) {
        LAB_1808562d0:
          uVar4 = 0;
        }
        else {
          if (lVar2 == null) goto LAB_180856318;
          uVar3 = Material.get_shader(lVar2,0);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) goto LAB_1808562d0;
          lVar2 = Material.get_shader(lVar2,0);
          if (lVar2 == null) {
        LAB_180856318:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar2 = Object.get_name(lVar2,0);
          if (lVar2 == null) goto LAB_180856318;
          cVar1 = String.Contains(lVar2,"Premultiplied",0);
          if (!cVar1) goto LAB_1808562d0;
          uVar4 = 1;
        }
        this.mPMA = (int)uVar4;
        LAB_1808562d5:
        return CONCAT71((int7)(uVar4 >> 8),(int)uVar4 == 1);
    }

    // Token : 0x600067E
    // RVA   : 0x855FD0   Offset: 0x854DD0   Length: 0x1A2
    public virtual bool get_packedFontShader()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar2 = NGUIFont.get_replacement(this,0);
        if (lVar2 != null) {
          uVar3 = FUN_180002280(15,DAT_181e5a6e0,lVar2);
          return uVar3;
        }
        uVar4 = this.mAtlas;
        uVar3 = Object.op_Inequality(uVar4,0,0);
        if ((char)uVar3) {
          return uVar3 & 0xffffffffffffff00;
        }
        uVar3 = (uint64)this.mPacked;
        if (this.mPacked != 0xffffffff) goto LAB_180856136;
        lVar2 = NGUIFont.get_material(this,0);
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (!cVar1) {
        LAB_180856131:
          uVar3 = 0;
        }
        else {
          if (lVar2 == null) goto LAB_18085616d;
          uVar4 = Material.get_shader(lVar2,0);
          cVar1 = Object.op_Inequality(uVar4,0,0);
          if (!cVar1) goto LAB_180856131;
          lVar2 = Material.get_shader(lVar2,0);
          if (lVar2 == null) {
        LAB_18085616d:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar2 = Object.get_name(lVar2,0);
          if (lVar2 == null) goto LAB_18085616d;
          cVar1 = String.Contains(lVar2,"Packed",0);
          if (!cVar1) goto LAB_180856131;
          uVar3 = 1;
        }
        this.mPacked = (int)uVar3;
        LAB_180856136:
        return CONCAT71((int7)(uVar3 >> 8),(int)uVar3 == 1);
    }

    // Token : 0x600067F
    // RVA   : 0x8568C0   Offset: 0x8556C0   Length: 0x148
    public virtual Texture2D get_texture()
    {
        bool cVar1;
        long lVar3;
        ushort uVar6;
        ulong uVar7;
        plVar2 = (int64 *)NGUIFont.get_replacement(this);
        uVar7 = 0;
        if (plVar2 == (int64 *)0) {
          lVar3 = NGUIFont.get_material(this);
          cVar1 = Object.op_Inequality(lVar3,0,0);
          if (cVar1) {
            if (lVar3 != null) {
              plVar4 = (int64 *)Material.get_mainTexture(lVar3,0);
              plVar2 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8b7e8)) {
                plVar2 = plVar4;
              }
              return plVar2;
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          return (int64 *)0;
        }
        lVar3 = *plVar2;
        if (*(uint16 *)(lVar3 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar3 + 176) + uVar7 * 16) == DAT_181e5a6e0) {
              puVar5 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + uVar7 * 16) * 16 + 0x238
                       + lVar3);
              goto LAB_1808569d8;
            }
            uVar6 = (short)uVar7 + 1;
            uVar7 = (uint64)uVar6;
          } while (uVar6 < *(uint16 *)(lVar3 + 0x12a));
        }
        puVar5 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,16);
        LAB_1808569d8:
                          // WARNING: Could not recover jumptable at 0x0001808569e9. Too many branches
                          // WARNING: Treating indirect jump as call
        plVar2 = (int64 *)(*(code *)*puVar5)(plVar2,puVar5[1]);
        return plVar2;
    }

    // Token : 0x6000680
    // RVA   : 0x856A10   Offset: 0x855810   Length: 0x166
    public virtual Rect get_uvRect()
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        ushort uVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        byte[] local_18 = new byte[16];
        plVar3 = (int64 *)NGUIFont.get_replacement(param_2,0);
        if (plVar3 == (int64 *)0) {
          uVar1 = *(uint64 *)(param_2 + 56);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            lVar4 = NGUIFont.get_sprite(param_2,0);
            if (lVar4 != null) {
              uVar8 = *(uint32 *)(param_2 + 32);
              uVar9 = *(uint32 *)(param_2 + 36);
              uVar10 = *(uint32 *)(param_2 + 40);
              uVar11 = *(uint32 *)(param_2 + 44);
              goto LAB_180856b49;
            }
          }
          *this = 0;
          this[1] = 0;
          FUN_1807282e0(this,0,0,0x3f800000,0x3f800000,0);
          return this;
        }
        lVar4 = *plVar3;
        uVar7 = 0;
        if (*(uint16 *)(lVar4 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar7 * 16) == DAT_181e5a6e0) {
              puVar5 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar7 * 16) *
                        16 + 0x248 + lVar4);
              goto LAB_180856b38;
            }
            uVar7 = uVar7 + 1;
          } while (uVar7 < *(uint16 *)(lVar4 + 0x12a));
        }
        puVar5 = (uint64 *)FUN_18019b1f0(plVar3,DAT_181e5a6e0,17);
        LAB_180856b38:
        puVar6 = (uint32 *)(*(code *)*puVar5)(local_18,plVar3,puVar5[1]);
        uVar8 = *puVar6;
        uVar9 = puVar6[1];
        uVar10 = puVar6[2];
        uVar11 = puVar6[3];
        LAB_180856b49:
        *(uint32 *)this = uVar8;
        *(uint32 *)((int64)this + 4) = uVar9;
        *(uint32 *)(this + 1) = uVar10;
        *(uint32 *)((int64)this + 12) = uVar11;
        return this;
    }

    // Token : 0x6000681
    // RVA   : 0x857720   Offset: 0x856520   Length: 0x127
    public virtual void set_uvRect(Rect value)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        bool cVar4;
        long lVar6;
        ushort uVar8;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        plVar5 = (int64 *)NGUIFont.get_replacement(this,0);
        if (plVar5 == (int64 *)0) {
          lVar6 = NGUIFont.get_sprite(this,0);
          if (lVar6 == null) {
            local_28 = *value;
            uStack_20 = value[1];
            local_18 = this.mUVRect;
            uStack_14 = *(uint32 *)(this + 36);
            uStack_10 = *(uint32 *)(this + 40);
            uStack_c = *(uint32 *)(this + 44);
            cVar4 = Rect.op_Inequality(&local_18,&local_28,0);
            if (cVar4) {
              uVar1 = *(uint32 *)((int64)value + 4);
              uVar2 = *(uint32 *)(value + 1);
              uVar3 = *(uint32 *)((int64)value + 12);
              this.mUVRect = *(uint32 *)value;
              *(uint32 *)(this + 36) = uVar1;
              *(uint32 *)(this + 40) = uVar2;
              *(uint32 *)(this + 44) = uVar3;
              NGUIFont.MarkAsChanged(this,0);
              return;
            }
          }
        }
        else {
          lVar6 = *plVar5;
          uVar8 = 0;
          if (*(uint16 *)(lVar6 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar8 * 16) == DAT_181e5a6e0) {
                puVar7 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 600 + lVar6);
                goto LAB_18085780a;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar6 + 0x12a));
          }
          puVar7 = (uint64 *)FUN_18019b1f0(plVar5,DAT_181e5a6e0,18);
        LAB_18085780a:
          local_18 = *(uint32 *)value;
          uStack_14 = *(uint32 *)((int64)value + 4);
          uStack_10 = *(uint32 *)(value + 1);
          uStack_c = *(uint32 *)((int64)value + 12);
          (*(code *)*puVar7)(plVar5,&local_18,puVar7[1]);
        }
    }

    // Token : 0x6000682
    // RVA   : 0x8563C0   Offset: 0x8551C0   Length: 0xD0
    public virtual string get_spriteName()
    {
        long lVar1;
        ulong uVar4;
        ushort uVar5;
        plVar2 = (int64 *)NGUIFont.get_replacement(this,0);
        if (plVar2 == (int64 *)0) {
          if (this.mFont != null) {
            return this.mFont.mSpriteName;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar1 = *plVar2;
        uVar5 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar5 * 16) == DAT_181e5a6e0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar5 * 16) *
                        16 + 0x268 + lVar1);
              goto LAB_180856448;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,19);
        LAB_180856448:
                          // WARNING: Could not recover jumptable at 0x000180856459. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar4 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar4;
    }

    // Token : 0x6000683
    // RVA   : 0x857490   Offset: 0x856290   Length: 0xAA
    public virtual void set_spriteName(string value)
    {
        bool cVar1;
        long lVar2;
        lVar2 = NGUIFont.get_replacement(this,0);
        if (lVar2 != null) {
          FUN_18005fa20(20,DAT_181e5a6e0,lVar2,value);
          return;
        }
        if (this.mFont != null) {
          cVar1 = String.op_Inequality(this.mFont.mSpriteName,value,0);
          if (!cVar1) {
            return;
          }
          if (this.mFont != null) {
            this.mFont.mSpriteName = value;
            NGUIFont.MarkAsChanged(this,0);
            return;
          }
        }
    }

    // Token : 0x6000684
    // RVA   : 0x855D40   Offset: 0x854B40   Length: 0x88
    public virtual bool get_isValid()
    {
        ulong uVar1;
        bool cVar2;
        byte uVar3;
        uVar1 = this.mDynamicFont;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          return true;
        }
        if (this.mFont != null) {
          uVar3 = BMFont.get_isValid(this.mFont,0);
          return uVar3;
        }
    }

    // Token : 0x6000685
    // RVA   : 0x855930   Offset: 0x854730   Length: 0xF5
    public int get_size()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = NGUIFont.get_replacement(this,0);
        if (lVar3 != null) {
          uVar4 = FUN_180002280(22,DAT_181e5a6e0,lVar3);
          return uVar4;
        }
        lVar3 = NGUIFont.get_replacement(this,0);
        if (lVar3 == null) {
          uVar1 = this.mDynamicFont;
          cVar2 = Object.op_Inequality(uVar1,0,0);
        }
        else {
          cVar2 = FUN_180002280(28,DAT_181e5a6e0,lVar3);
        }
        if ((!cVar2) && (this.mFont != null)) {
          return (uint64)this.mFont.mSize;
        }
        return (uint64)this.mDynamicFontSize;
    }

    // Token : 0x6000686
    // RVA   : 0x856F10   Offset: 0x855D10   Length: 0x69
    public void set_size(int value)
    {
        long lVar1;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 == null) {
          this.mDynamicFontSize = value;
          return;
        }
        FUN_180054430(23,DAT_181e5a6e0,lVar1,value);
    }

    // Token : 0x6000687
    // RVA   : 0x855930   Offset: 0x854730   Length: 0xF5
    public virtual int get_defaultSize()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = NGUIFont.get_replacement(this,0);
        if (lVar3 != null) {
          uVar4 = FUN_180002280(22,DAT_181e5a6e0,lVar3);
          return uVar4;
        }
        lVar3 = NGUIFont.get_replacement(this,0);
        if (lVar3 == null) {
          uVar1 = this.mDynamicFont;
          cVar2 = Object.op_Inequality(uVar1,0,0);
        }
        else {
          cVar2 = FUN_180002280(28,DAT_181e5a6e0,lVar3);
        }
        if ((!cVar2) && (this.mFont != null)) {
          return (uint64)this.mFont.mSize;
        }
        return (uint64)this.mDynamicFontSize;
    }

    // Token : 0x6000688
    // RVA   : 0x856F10   Offset: 0x855D10   Length: 0x69
    public virtual void set_defaultSize(int value)
    {
        long lVar1;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 == null) {
          this.mDynamicFontSize = value;
          return;
        }
        FUN_180054430(23,DAT_181e5a6e0,lVar1,value);
    }

    // Token : 0x6000689
    // RVA   : 0x8564A0   Offset: 0x8552A0   Length: 0x268
    public virtual UISpriteData get_sprite()
    {
        bool cVar1;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ushort uVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        plVar2 = (int64 *)NGUIFont.get_replacement(this,0);
        if (plVar2 != (int64 *)0) {
          lVar3 = *plVar2;
          uVar7 = 0;
          if (*(uint16 *)(lVar3 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar7 * 16) == DAT_181e5a6e0) {
                puVar6 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar7 * 16) *
                          16 + 0x2b8 + lVar3);
                goto LAB_1808566d7;
              }
              uVar7 = uVar7 + 1;
            } while (uVar7 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar6 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,24);
        LAB_1808566d7:
                          // WARNING: Could not recover jumptable at 0x0001808566e9. Too many branches
                          // WARNING: Treating indirect jump as call
          uVar4 = (*(code *)*puVar6)(plVar2,puVar6[1]);
          return uVar4;
        }
        lVar3 = il2cpp_internal(this.mAtlas,DAT_181e5a658);
        if (((this.mSprite == null) && (lVar3 != null)) && (this.mFont != null)
           ) {
          cVar1 = FUN_180ad1200(this.mFont.mSpriteName,0);
          if (!cVar1) {
            if (this.mFont != null) {
              uVar4 = FUN_180054130(10,DAT_181e5a658,lVar3,
                                    this.mFont.mSpriteName);
              this.mSprite = uVar4;
              lVar10 = this.mSprite;
              if (lVar10 == null) {
                uVar4 = Object.get_name(this,0);
                uVar4 = FUN_180054130(10,DAT_181e5a658,lVar3,uVar4);
                this.mSprite = uVar4;
                lVar10 = this.mSprite;
              }
              uVar8 = 0;
              if (lVar10 == null) {
                if (this.mFont == null) goto LAB_180856703;
                this.mFont.mSpriteName = 0;
              }
              else {
                NGUIFont.UpdateUVRect(this,0);
              }
              if (this.mSymbols != null) {
                lVar3 = (int64)this.mSymbols.Count;
                if (0 < lVar3) {
                  lVar10 = 32;
                  uVar9 = uVar8;
                  do {
                    lVar5 = NGUIFont.get_symbols(this,0);
                    if (lVar5 == null) goto LAB_180856703;
                    if (*(uint32 *)(lVar5 + 24) <= (uint32)uVar8) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (*(int64 *)(lVar10 + *(int64 *)(lVar5 + 16)) == 0) goto LAB_180856703;
                    BMSymbol.MarkAsChanged();
                    uVar8 = (uint64)((uint32)uVar8 + 1);
                    uVar9 = uVar9 + 1;
                    lVar10 = lVar10 + 8;
                  } while ((int64)uVar9 < lVar3);
                }
                goto LAB_180856668;
              }
            }
        LAB_180856703:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
        LAB_180856668:
        return this.mSprite;
    }

    // Token : 0x600068A
    // RVA   : 0x856330   Offset: 0x855130   Length: 0x8F
    public virtual INGUIFont get_replacement()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mReplacement;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = il2cpp_internal(this.mReplacement,DAT_181e5a6e0);
          return uVar2;
        }
        return 0;
    }

    // Token : 0x600068B
    // RVA   : 0x857310   Offset: 0x856110   Length: 0x17A
    public virtual void set_replacement(INGUIFont value)
    {
        long lVar1;
        bool cVar3;
        plVar5 = (int64 *)0;
        if (value != this) {
          plVar5 = value;
        }
        plVar6 = this + 8;
        plVar4 = (int64 *)il2cpp_internal(this[8],DAT_181e5a6e0);
        if (plVar4 != plVar5) {
          if (plVar5 != (int64 *)0) {
            plVar4 = (int64 *)FUN_180002280(25,DAT_181e5a6e0,plVar5);
            if (plVar4 == this) {
              FUN_18005fa20(26,DAT_181e5a6e0,plVar5,0);
            }
          }
          lVar1 = *plVar6;
          cVar3 = Object.op_Inequality(lVar1,0,0);
          if (cVar3) {
            NGUIFont.MarkAsChanged(this,0);
          }
          if (plVar5 != (int64 *)0) {
            plVar4 = plVar5;
            *plVar6 = (int64)plVar4;
            il2cpp_internal(plVar6);
            this[3] = 0;
            *(uint32 *)(this + 13) = 0xffffffff;
            this[6] = 0;
            il2cpp_internal(this + 6,0);
            plVar6 = this + 10;
          }
          *plVar6 = 0;
          il2cpp_internal(plVar6,0);
          NGUIFont.MarkAsChanged(this,0);
        }
    }

    // Token : 0x600068C
    // RVA   : 0x855B60   Offset: 0x854960   Length: 0xCE
    public virtual INGUIFont get_finalFont()
    {
        long lVar1;
        ushort uVar2;
        int iVar6;
        ulong uVar3;
        iVar6 = 0;
        do {
          if (this == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar1 = *this;
          uVar3 = 0;
          if (*(uint16 *)(lVar1 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar1 + 176) + uVar3 * 16) == DAT_181e5a6e0) {
                puVar4 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + uVar3 * 16) * 16 +
                          0x2c8 + lVar1);
                goto LAB_180855be8;
              }
              uVar2 = (short)uVar3 + 1;
              uVar3 = (uint64)uVar2;
            } while (uVar2 < *(uint16 *)(lVar1 + 0x12a));
          }
          puVar4 = (uint64 *)FUN_18019b1f0(this,DAT_181e5a6e0,25);
        LAB_180855be8:
          plVar5 = (int64 *)(*(code *)*puVar4)(this,puVar4[1]);
          if (plVar5 != (int64 *)0) {
            this = plVar5;
          }
          iVar6 = iVar6 + 1;
          if (9 < iVar6) {
            return this;
          }
        } while( true );
    }

    // Token : 0x600068D
    // RVA   : 0x855CB0   Offset: 0x854AB0   Length: 0x8D
    public virtual bool get_isDynamic()
    {
        ulong uVar1;
        long lVar2;
        lVar2 = NGUIFont.get_replacement(this,0);
        if (lVar2 != null) {
          FUN_180002280(28,DAT_181e5a6e0,lVar2);
          return;
        }
        uVar1 = this.mDynamicFont;
        Object.op_Inequality(uVar1,0,0);
    }

    // Token : 0x600068E
    // RVA   : 0x855A90   Offset: 0x854890   Length: 0xC2
    public virtual Font get_dynamicFont()
    {
        long lVar1;
        ulong uVar4;
        ushort uVar5;
        plVar2 = (int64 *)NGUIFont.get_replacement(this,0);
        if (plVar2 == (int64 *)0) {
          return this.mDynamicFont;
        }
        lVar1 = *plVar2;
        uVar5 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar5 * 16) == DAT_181e5a6e0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar5 * 16) *
                        16 + 0x308 + lVar1);
              goto LAB_180855b18;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,29);
        LAB_180855b18:
                          // WARNING: Could not recover jumptable at 0x000180855b29. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar4 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar4;
    }

    // Token : 0x600068F
    // RVA   : 0x857000   Offset: 0x855E00   Length: 0x22B
    public virtual void set_dynamicFont(Font value)
    {
        ulong uVar1;
        bool cVar2;
        long lVar4;
        ushort uVar6;
        plVar3 = (int64 *)NGUIFont.get_replacement(this);
        if (plVar3 == (int64 *)0) {
          uVar1 = this.mDynamicFont;
          cVar2 = Object.op_Inequality(uVar1,value,0);
          if (cVar2) {
            uVar1 = this.mDynamicFont;
            cVar2 = Object.op_Inequality(uVar1,0,0);
            if (cVar2) {
              lVar4 = NGUIFont.get_replacement(this);
              if (lVar4 == null) {
                uVar1 = this.mMat;
                cVar2 = Object.op_Inequality(uVar1,0,0);
                if (cVar2) {
                  this.mPMA = 0xffffffff;
                  this.mMat = 0;
                  NGUIFont.MarkAsChanged(this,0);
                }
              }
              else {
                FUN_18005fa20(13,DAT_181e5a6e0,lVar4,0);
              }
            }
            this.mDynamicFont = value;
            NGUIFont.MarkAsChanged(this,0);
          }
          return;
        }
        lVar4 = *plVar3;
        uVar6 = 0;
        if (*(uint16 *)(lVar4 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar6 * 16) == DAT_181e5a6e0) {
              puVar5 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar6 * 16) *
                        16 + 0x318 + lVar4);
              goto LAB_1808571f8;
            }
            uVar6 = uVar6 + 1;
          } while (uVar6 < *(uint16 *)(lVar4 + 0x12a));
        }
        puVar5 = (uint64 *)FUN_18019b1f0(plVar3,DAT_181e5a6e0,30);
        LAB_1808571f8:
                          // WARNING: Could not recover jumptable at 0x000180857212. Too many branches
                          // WARNING: Treating indirect jump as call
        (*(code *)*puVar5)(plVar3,value,puVar5[1]);
    }

    // Token : 0x6000690
    // RVA   : 0x855A30   Offset: 0x854830   Length: 0x56
    public virtual FontStyle get_dynamicFontStyle()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002280(31,DAT_181e5a6e0,lVar1);
          return uVar2;
        }
        return (uint64)this.mDynamicFontStyle;
    }

    // Token : 0x6000691
    // RVA   : 0x856F80   Offset: 0x855D80   Length: 0x78
    public virtual void set_dynamicFontStyle(FontStyle value)
    {
        long lVar1;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 == null) {
          if (this.mDynamicFontStyle != value) {
            this.mDynamicFontStyle = value;
            NGUIFont.MarkAsChanged(this,0);
            return;
          }
        }
        else {
          FUN_180054430(32,DAT_181e5a6e0,lVar1,value);
        }
    }

    // Token : 0x6000692
    // RVA   : 0x854F80   Offset: 0x853D80   Length: 0x352
    private void Trim()
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;
        uint uVar6;
        long lVar7;
        ulong uVar8;
        ulong local_68;
        ulong uStack_60;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        uVar8 = 0;
        local_58 = 0;
        uStack_50 = 0;
        lVar7 = il2cpp_internal(this.mAtlas,DAT_181e5a658);
        if (lVar7 != null) {
          uVar8 = FUN_180002280(4,DAT_181e5a658,lVar7);
        }
        cVar2 = Object.op_Inequality(uVar8,0,0);
        if ((cVar2) && (this.mSprite != null)) {
          uVar8 = this.mUVRect;
          uVar1 = *(uint64 *)(this + 40);
          plVar9 = (int64 *)NGUIFont.get_texture(this,0);
          if (plVar9 != (int64 *)0) {
            (**(code **)(*plVar9 + 0x178))(plVar9,*(uint64 *)(*plVar9 + 0x180));
            plVar9 = (int64 *)NGUIFont.get_texture(this,0);
            if (plVar9 != (int64 *)0) {
              local_68 = uVar8;
              uStack_60 = uVar1;
              local_48 = uVar8;
              uStack_40 = uVar1;
              (**(code **)(*plVar9 + 0x198))(plVar9,*(uint64 *)(*plVar9 + 0x1a0));
              FUN_180af4e60(&local_48,0);
              Mathf.RoundToInt();
              Rect.set_xMin(&local_68);
              Rect.get_xMax(&local_48,0);
              Mathf.RoundToInt();
              Rect.set_xMax(&local_68);
              Rect.get_yMax(&local_48,0);
              Mathf.RoundToInt();
              Rect.set_yMin(&local_68);
              FUN_180af4e80(&local_48,0);
              Mathf.RoundToInt();
              Rect.set_yMax(&local_68);
              local_38 = local_68;
              uStack_30 = uStack_60;
              if (this.mSprite != null) {
                FUN_1807282e0(&local_58);
                FUN_180af4e60(&local_58,0);
                FUN_180af4e60(&local_38,0);
                uVar3 = Mathf.RoundToInt();
                FUN_180af4e80(&local_58,0);
                FUN_180af4e80(&local_38,0);
                uVar4 = Mathf.RoundToInt();
                Rect.get_xMax(&local_58,0);
                FUN_180af4e60(&local_38,0);
                uVar5 = Mathf.RoundToInt();
                Rect.get_yMax(&local_58,0);
                FUN_180af4e80(&local_38,0);
                uVar6 = Mathf.RoundToInt();
                if (this.mFont != null) {
                  BMFont.Trim(this.mFont,uVar3,uVar4,uVar5,uVar6,0);
                  return;
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x6000693
    // RVA   : 0x854D90   Offset: 0x853B90   Length: 0x80
    public virtual bool References(INGUIFont font)
    {
        byte uVar1;
        long lVar2;
        if (font != null) {
          if (font == this) {
            return true;
          }
          lVar2 = NGUIFont.get_replacement(this,0);
          if (lVar2 != null) {
            uVar1 = FUN_180054130(33,DAT_181e5a6e0,lVar2,font);
            return uVar1;
          }
        }
        return false;
    }

    // Token : 0x6000694
    // RVA   : 0x854930   Offset: 0x853730   Length: 0x253
    public virtual void MarkAsChanged()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        uint uVar8;
        lVar3 = NGUIFont.get_replacement(this,0);
        if (lVar3 != null) {
          FUN_180002280(34,DAT_181e5a6e0,lVar3);
        }
        uVar6 = 0;
        this.mSprite = 0;
        lVar3 = NGUITools.FindActive(DAT_181e725f8);
        if (lVar3 != null) {
          iVar1 = *(int *)(lVar3 + 24);
          uVar7 = uVar6;
          if (0 < iVar1) {
            do {
              uVar8 = (uint32)uVar7;
              if (*(uint32 *)(lVar3 + 24) <= uVar8) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar4,0);
              }
              lVar5 = lVar3[uVar8];
              if (lVar5 == null) throw; // [null/range check failed]
              cVar2 = Behaviour.get_enabled(lVar5);
              if (cVar2) {
                uVar4 = Component.get_gameObject(lVar5);
                cVar2 = NGUITools.GetActive(uVar4);
                if (cVar2) {
                  uVar4 = UILabel.get_bitmapFont(lVar5,0);
                  cVar2 = NGUITools.CheckIfRelated(this,uVar4,0);
                  if (cVar2) {
                    UILabel.get_bitmapFont(lVar5,0);
                    UILabel.set_bitmapFont(lVar5,0);
                    UILabel.set_bitmapFont(lVar5);
                  }
                }
              }
              uVar7 = (uint64)(uVar8 + 1);
            } while ((int)(uVar8 + 1) < iVar1);
          }
          lVar3 = NGUIFont.get_symbols(this,0);
          if (lVar3 != null) {
            iVar1 = *(int *)(lVar3 + 24);
            if (0 < (int64)iVar1) {
              lVar3 = 32;
              uVar7 = uVar6;
              do {
                lVar5 = NGUIFont.get_symbols(this,0);
                if (lVar5 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar5 + 24) <= (uint32)uVar6) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (*(int64 *)(lVar3 + *(int64 *)(lVar5 + 16)) == 0) throw; // [null/range check failed]
                BMSymbol.MarkAsChanged();
                uVar6 = (uint64)((uint32)uVar6 + 1);
                uVar7 = uVar7 + 1;
                lVar3 = lVar3 + 8;
              } while ((int64)uVar7 < (int64)iVar1);
            }
            return;
          }
        }
    }

    // Token : 0x6000695
    // RVA   : 0x8552E0   Offset: 0x8540E0   Length: 0x2BA
    public virtual void UpdateUVRect()
    {
        ulong uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;
        bool cVar6;
        int iVar7;
        int iVar8;
        long lVar9;
        float fVar11;
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        uint32 local_58;
        uint32 uStack_54;
        uint32 uStack_50;
        uint32 uStack_4c;
        uint64 local_48;
        uint64 uStack_40;
        uVar1 = this.mAtlas;
        cVar6 = Object.op_Equality(uVar1,0,0);
        if (!cVar6) {
          plVar10 = (int64 *)0;
          lVar9 = il2cpp_internal(this.mAtlas,DAT_181e5a658);
          if (lVar9 != null) {
            plVar10 = (int64 *)FUN_180002280(4,DAT_181e5a658,lVar9);
          }
          cVar6 = Object.op_Inequality(plVar10,0,0);
          if (cVar6) {
            lVar9 = this.mSprite;
            if (lVar9 != null) {
              local_48 = 0;
              uStack_40 = 0;
              FUN_1807282e0(&local_48,lVar9.paddingRight,lVar9.width,
                            lVar9.paddingTop,
                            (float)(lVar9.paddingBottom + lVar9.paddingTop +
                                   lVar9.height),0);
              uVar2 = (uint32)local_48;
              uVar3 = local_48._4_4_;
              uVar4 = (uint32)uStack_40;
              uVar5 = uStack_40._4_4_;
              this.mUVRect = (uint32)local_48;
              *(uint32 *)(this + 36) = local_48._4_4_;
              *(uint32 *)(this + 40) = (uint32)uStack_40;
              *(uint32 *)(this + 44) = uStack_40._4_4_;
              if (plVar10 != (int64 *)0) {
                iVar7 = (**(code **)(*plVar10 + 0x178))(plVar10,*(uint64 *)(*plVar10 + 0x180));
                iVar8 = (**(code **)(*plVar10 + 0x198))(plVar10,*(uint64 *)(*plVar10 + 0x1a0));
                local_58 = uVar2;
                uStack_54 = uVar3;
                uStack_50 = uVar4;
                uStack_4c = uVar5;
                local_68 = uVar2;
                uStack_64 = uVar3;
                uStack_60 = uVar4;
                uStack_5c = uVar5;
                if (((float)iVar7 != 0.0) && ((float)iVar8 != 0.0)) {
                  FUN_180af4e60(&local_58,0);
                  Rect.set_xMin(&local_68);
                  Rect.get_xMax(&local_58,0);
                  Rect.set_xMax(&local_68);
                  fVar11 = (float)Rect.get_yMax(&local_58,0);
                  Rect.set_yMin(&local_68,1.0 - fVar11 / (float)iVar8,0);
                  FUN_180af4e80(&local_58,0);
                  Rect.set_yMax(&local_68);
                }
                this.mUVRect = local_68;
                *(uint32 *)(this + 36) = uStack_64;
                *(uint32 *)(this + 40) = uStack_60;
                *(uint32 *)(this + 44) = uStack_5c;
                if (this.mSprite != null) {
                  cVar6 = UISpriteData.get_hasPadding(this.mSprite,0);
                  if (!cVar6) {
                    return;
                  }
                  NGUIFont.Trim(this,0);
                  return;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x6000696
    // RVA   : 0x8547E0   Offset: 0x8535E0   Length: 0x146
    private BMSymbol GetSymbol(string sequence, bool createIfMissing)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        long lVar7;
        lVar4 = NGUIFont.get_symbols(this,0);
        uVar5 = 0;
        if (lVar4 != null) {
          iVar1 = *(int *)(lVar4 + 24);
          if (0 < iVar1) {
            lVar6 = 32;
            lVar7 = 0;
            do {
              if (*(uint32 *)(lVar4 + 24) <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar6 + *(int64 *)(lVar4 + 16));
              if (lVar2 == null) throw; // [null/range check failed]
              cVar3 = FUN_1816387f0(*(uint64 *)(lVar2 + 16),sequence,0);
              if (cVar3) {
                return lVar2;
              }
              uVar5 = uVar5 + 1;
              lVar7 = lVar7 + 1;
              lVar6 = lVar6 + 8;
            } while (lVar7 < iVar1);
          }
          if (!createIfMissing) {
            lVar6 = 0;
          }
          else {
            lVar6 = new c.DisplayClass9_0(0);
            if (lVar6 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar6 + 16) = sequence;
            FUN_18175de30(lVar4,lVar6,DAT_181e60410);
          }
          return lVar6;
        }
    }

    // Token : 0x6000697
    // RVA   : 0x854B90   Offset: 0x853990   Length: 0x1F2
    public virtual BMSymbol MatchSymbol(string text, int offset, int textLength)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        int iVar6;
        long lVar7;
        int iVar8;
        long lVar9;
        uint uVar10;
        lVar7 = NGUIFont.get_replacement(this,0);
        if (lVar7 != null) {
          lVar7 = FUN_18007dd30(36,DAT_181e5a6e0,lVar7,text,offset,textLength);
          return lVar7;
        }
        if (this.mSymbols != null) {
          iVar1 = this.mSymbols.Count;
          if (iVar1 != 0) {
            uVar10 = 0;
            if (0 < iVar1) {
              lVar7 = 0;
              lVar9 = 32;
              do {
                lVar2 = this.mSymbols;
                if (lVar2 == null) throw; // [null/range check failed]
                if (lVar2.Count <= uVar10) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = *(int64 *)(lVar2._items + lVar9);
                if (lVar2 == null) throw; // [null/range check failed]
                iVar6 = BMSymbol.get_length(lVar2,0);
                if ((iVar6 != 0) && (iVar6 <= textLength - offset)) {
                  iVar8 = 0;
                  if (0 < iVar6) {
                    do {
                      if (text == null) throw; // [null/range check failed]
                      sVar4 = String.get_Chars(text,iVar8 + offset,0);
                      if (lVar2._items == null) throw; // [null/range check failed]
                      sVar5 = String.get_Chars(lVar2._items,iVar8,0);
                      if (sVar4 != sVar5) goto LAB_180854d34;
                      iVar8 = iVar8 + 1;
                    } while (iVar8 < iVar6);
                  }
                  NGUIFont.get_atlas(this,0);
                  cVar3 = BMSymbol.Validate();
                  if (cVar3) {
                    return lVar2;
                  }
                }
        LAB_180854d34:
                uVar10 = uVar10 + 1;
                lVar7 = lVar7 + 1;
                lVar9 = lVar9 + 8;
              } while (lVar7 < iVar1);
            }
          }
          return 0;
        }
    }

    // Token : 0x6000698
    // RVA   : 0x854660   Offset: 0x853460   Length: 0xB2
    public virtual void AddSymbol(string sequence, string spriteName)
    {
        long lVar1;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 == null) {
          lVar1 = NGUIFont.GetSymbol(this,sequence,1,0);
          if (lVar1 != null) {
            *(uint64 *)(lVar1 + 24) = spriteName;
            NGUIFont.MarkAsChanged(this,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        FUN_18005fd80(37,DAT_181e5a6e0,lVar1,sequence,spriteName);
    }

    // Token : 0x6000699
    // RVA   : 0x854E10   Offset: 0x853C10   Length: 0xBB
    public virtual void RemoveSymbol(string sequence)
    {
        long lVar1;
        long lVar2;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 == null) {
          lVar1 = NGUIFont.GetSymbol(this,sequence,0,0);
          if (lVar1 != null) {
            lVar2 = NGUIFont.get_symbols(this,0);
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            FUN_181665e90(lVar2,lVar1,DAT_181e60490);
          }
          NGUIFont.MarkAsChanged(this,0);
          return;
        }
        FUN_18005fa20(38,DAT_181e5a6e0,lVar1,sequence);
    }

    // Token : 0x600069A
    // RVA   : 0x854ED0   Offset: 0x853CD0   Length: 0xAD
    public virtual void RenameSymbol(string before, string after)
    {
        long lVar1;
        lVar1 = NGUIFont.get_replacement(this,0);
        if (lVar1 == null) {
          lVar1 = NGUIFont.GetSymbol(this,before,0,0);
          if (lVar1 != null) {
            *(uint64 *)(lVar1 + 16) = after;
          }
          NGUIFont.MarkAsChanged(this,0);
          return;
        }
        FUN_18005fd80(39,DAT_181e5a6e0,lVar1,before,after);
    }

    // Token : 0x600069B
    // RVA   : 0x8555A0   Offset: 0x8543A0   Length: 0x1B9
    public virtual bool UsesSprite(string s)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        ulong uVar6;
        long lVar7;
        ushort uVar8;
        ulong uVar9;
        long lVar10;
        ulong uVar11;
        cVar3 = FUN_180ad1200(s,0);
        if (cVar3) {
          return false;
        }
        plVar4 = (int64 *)NGUIFont.get_replacement(this,0);
        uVar9 = 0;
        if (plVar4 == (int64 *)0) {
          if (this.mFont == null) throw; // [null/range check failed]
          uVar6 = this.mFont.mSpriteName;
        }
        else {
          lVar7 = *plVar4;
          uVar8 = 0;
          if (*(uint16 *)(lVar7 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar7 + 176) + (uint64)uVar8 * 16) == DAT_181e5a6e0) {
                puVar5 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar7 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x268 + lVar7);
                uVar6 = (*(code *)*puVar5)(plVar4,puVar5[1]);
                goto LAB_1808556b4;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar7 + 0x12a));
          }
          puVar5 = (uint64 *)FUN_18019b1f0(plVar4,DAT_181e5a6e0,19);
          uVar6 = (*(code *)*puVar5)(plVar4,puVar5[1]);
        }
        LAB_1808556b4:
        if (s != null) {
          cVar3 = String.Equals(s,uVar6,0);
          if (cVar3) {
            return true;
          }
          lVar7 = NGUIFont.get_symbols(this,0);
          if (lVar7 != null) {
            iVar1 = *(int *)(lVar7 + 24);
            if (iVar1 < 1) {
              return false;
            }
            lVar10 = 32;
            uVar11 = uVar9;
            while( true ) {
              if (*(uint32 *)(lVar7 + 24) <= (uint32)uVar9) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar10 + *(int64 *)(lVar7 + 16));
              if (lVar2 == null) break;
              cVar3 = String.Equals(s,*(uint64 *)(lVar2 + 24),0);
              if (cVar3) {
                return true;
              }
              uVar9 = (uint64)((uint32)uVar9 + 1);
              uVar11 = uVar11 + 1;
              lVar10 = lVar10 + 8;
              if ((int64)iVar1 <= (int64)uVar11) {
                return false;
              }
            }
          }
        }
    }

    // Token : 0x600069C
    // RVA   : 0x855760   Offset: 0x854560   Length: 0xF2
    public void /*ctor*/()
    {
        ulong uVar1;
        ulong local_18;
        ulong uStack_10;
        local_18 = 0;
        uStack_10 = 0;
        FUN_1807282e0(&local_18,0,0,0x3f800000,0x3f800000,0);
        this.mUVRect = (uint32)local_18;
        *(uint32 *)(this + 36) = local_18._4_4_;
        *(uint32 *)(this + 40) = (uint32)uStack_10;
        *(uint32 *)(this + 44) = uStack_10._4_4_;
        this.mFont = new BMFont(0);
        uVar1 = il2cpp_internal(DAT_181e71138);
        FUN_1810f3480(uVar1,DAT_181e60390);
        this.mSymbols = uVar1;
        this.mDynamicFontSize = 16;
        this.mPMA = 0xffffffffffffffff;
        ScriptableObject.ctor(this,0);
    }

}
