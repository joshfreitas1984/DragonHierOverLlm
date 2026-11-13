// ============================================================
// Type  : UIFont
// Token : 0x20000F3
// ============================================================

public class UIFont
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40005B6
    private Material mMat;

    // Token: 0x40005B7
    private Rect mUVRect;

    // Token: 0x40005B8
    private BMFont mFont;

    // Token: 0x40005B9
    private object mAtlas;

    // Token: 0x40005BA
    private object mReplacement;

    // Token: 0x40005BB
    private List<BMSymbol> mSymbols;

    // Token: 0x40005BC
    private Font mDynamicFont;

    // Token: 0x40005BD
    private int mDynamicFontSize;

    // Token: 0x40005BE
    private FontStyle mDynamicFontStyle;

    // Token: 0x40005BF
    private UISpriteData mSprite;

    // Token: 0x40005C0
    private int mPMA;

    // Token: 0x40005C1
    private int mPacked;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000783
    // RVA   : 0x11469A0   Offset: 0x11457A0   Length: 0x54
    public virtual BMFont get_bmFont()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002280(0,DAT_181e5a6e0,lVar1);
          return uVar2;
        }
        return this.mFont;
    }

    // Token : 0x6000784
    // RVA   : 0x1147F00   Offset: 0x1146D00   Length: 0xDD
    public virtual void set_bmFont(BMFont value)
    {
        long lVar1;
        ushort uVar4;
        plVar2 = (int64 *)UIFont.get_replacement(this,0);
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
              goto LAB_181147faa;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,1);
        LAB_181147faa:
                          // WARNING: Could not recover jumptable at 0x000181147fc3. Too many branches
                          // WARNING: Treating indirect jump as call
        (*(code *)*puVar3)(plVar2,value,puVar3[1]);
    }

    // Token : 0x6000785
    // RVA   : 0x1147920   Offset: 0x1146720   Length: 0x6A
    public virtual int get_texWidth()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002280(2,DAT_181e5a6e0,lVar1);
          return uVar2;
        }
        if (this.mFont != null) {
          return (uint64)this.mFont.mWidth;
        }
        return 1;
    }

    // Token : 0x6000786
    // RVA   : 0x11488B0   Offset: 0x11476B0   Length: 0x73
    public virtual void set_texWidth(int value)
    {
        long lVar1;
        lVar1 = UIFont.get_replacement(this,0);
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

    // Token : 0x6000787
    // RVA   : 0x11478B0   Offset: 0x11466B0   Length: 0x6A
    public virtual int get_texHeight()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002280(4,DAT_181e5a6e0,lVar1);
          return uVar2;
        }
        if (this.mFont != null) {
          return (uint64)this.mFont.mHeight;
        }
        return 1;
    }

    // Token : 0x6000788
    // RVA   : 0x1148830   Offset: 0x1147630   Length: 0x73
    public virtual void set_texHeight(int value)
    {
        long lVar1;
        lVar1 = UIFont.get_replacement(this,0);
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

    // Token : 0x6000789
    // RVA   : 0x1146D00   Offset: 0x1145B00   Length: 0x75
    public virtual bool get_hasSymbols()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIFont.get_replacement(this,0);
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

    // Token : 0x600078A
    // RVA   : 0x11477E0   Offset: 0x11465E0   Length: 0xC2
    public virtual List<BMSymbol> get_symbols()
    {
        long lVar1;
        ulong uVar4;
        ushort uVar5;
        plVar2 = (int64 *)UIFont.get_replacement(this,0);
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
              goto LAB_181147868;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,7);
        LAB_181147868:
                          // WARNING: Could not recover jumptable at 0x000181147879. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar4 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar4;
    }

    // Token : 0x600078B
    // RVA   : 0x1148750   Offset: 0x1147550   Length: 0xDD
    public virtual void set_symbols(List<BMSymbol> value)
    {
        long lVar1;
        ushort uVar4;
        plVar2 = (int64 *)UIFont.get_replacement(this,0);
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
              goto LAB_1811487fa;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,8);
        LAB_1811487fa:
                          // WARNING: Could not recover jumptable at 0x000181148813. Too many branches
                          // WARNING: Treating indirect jump as call
        (*(code *)*puVar3)(plVar2,value,puVar3[1]);
    }

    // Token : 0x600078C
    // RVA   : 0x1146930   Offset: 0x1145730   Length: 0x6E
    public virtual INGUIAtlas get_atlas()
    {
        long lVar1;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 == null) {
          il2cpp_internal(this.mAtlas,DAT_181e5a658);
          return;
        }
        FUN_180002280(9,DAT_181e5a6e0,lVar1);
    }

    // Token : 0x600078D
    // RVA   : 0x1147C50   Offset: 0x1146A50   Length: 0x2AA
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
        lVar3 = UIFont.get_replacement(this,0);
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
          lVar3 = UIFont.get_sprite(this,0);
          if (lVar3 != null) {
            plVar4 = (int64 *)UIFont.get_replacement(this,0);
            if (plVar4 == (int64 *)0) {
              uVar5 = this.mAtlas;
              cVar2 = Object.op_Inequality(uVar5,0,0);
              if ((!cVar2) || (lVar3 = UIFont.get_sprite(this,0)) == null) {
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
                    goto LAB_181147e87;
                  }
                  uVar8 = (short)plVar9 + 1;
                  plVar9 = (int64 *)(uint64)uVar8;
                } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
              }
              puVar6 = (uint64 *)FUN_18019b1f0(plVar4,DAT_181e5a6e0,17);
        LAB_181147e87:
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
        UIFont.MarkAsChanged(this,0);
    }

    // Token : 0x600078E
    // RVA   : 0x11459C0   Offset: 0x11447C0   Length: 0xBA
    public virtual UISpriteData GetSprite(string spriteName)
    {
        long lVar1;
        lVar1 = UIFont.get_replacement(this,0);
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

    // Token : 0x600078F
    // RVA   : 0x1146EA0   Offset: 0x1145CA0   Length: 0x1F8
    public virtual Material get_material()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        lVar2 = UIFont.get_replacement(this,0);
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
        LAB_181147055:
            return this.mMat;
          }
          uVar3 = this.mMat;
          if (this.mDynamicFont != null) {
            uVar4 = Font.get_material(this.mDynamicFont,0);
            cVar1 = Object.op_Inequality(uVar3,uVar4,0);
            if (!cVar1) goto LAB_181147055;
            lVar2 = this.mMat;
            if (this.mDynamicFont != null) {
              lVar5 = Font.get_material(this.mDynamicFont,0);
              if (lVar5 != null) {
                uVar3 = Material.get_mainTexture(lVar5,0);
                if (lVar2 != null) {
                  Material.set_mainTexture(lVar2,uVar3,0);
                  goto LAB_181147055;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000790
    // RVA   : 0x1148360   Offset: 0x1147160   Length: 0x13C
    public virtual void set_material(Material value)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ushort uVar6;
        plVar4 = (int64 *)UIFont.get_replacement(this,0);
        if (plVar4 == (int64 *)0) {
          uVar1 = this.mMat;
          cVar3 = Object.op_Inequality(uVar1,value,0);
          if (cVar3) {
            this.mPMA = 0xffffffff;
            this.mMat = value;
            UIFont.MarkAsChanged(this,0);
            return;
          }
        }
        else {
          lVar2 = *plVar4;
          uVar6 = 0;
          if (*(uint16 *)(lVar2 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar6 * 16) == DAT_181e5a6e0) {
                puVar5 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar6 * 16) *
                          16 + 0x208 + lVar2);
                goto LAB_181148469;
              }
              uVar6 = uVar6 + 1;
            } while (uVar6 < *(uint16 *)(lVar2 + 0x12a));
          }
          puVar5 = (uint64 *)FUN_18019b1f0(plVar4,DAT_181e5a6e0,13);
        LAB_181148469:
          (*(code *)*puVar5)(plVar4,value,puVar5[1]);
        }
    }

    // Token : 0x6000791
    // RVA   : 0x11473F0   Offset: 0x11461F0   Length: 0x7
    public bool get_premultipliedAlpha()
    {
        void FUN_1811473f0(uint64 this)
        {
        UIFont.get_premultipliedAlphaShader(this,0);
    }

    // Token : 0x6000792
    // RVA   : 0x1147250   Offset: 0x1146050   Length: 0x19D
    public virtual bool get_premultipliedAlphaShader()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar2 = UIFont.get_replacement(this,0);
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
        if (this.mPMA != 0xffffffff) goto LAB_1811473a5;
        lVar2 = UIFont.get_material(this,0);
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (!cVar1) {
        LAB_1811473a0:
          uVar4 = 0;
        }
        else {
          if (lVar2 == null) goto LAB_1811473e8;
          uVar3 = Material.get_shader(lVar2,0);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) goto LAB_1811473a0;
          lVar2 = Material.get_shader(lVar2,0);
          if (lVar2 == null) {
        LAB_1811473e8:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar2 = Object.get_name(lVar2,0);
          if (lVar2 == null) goto LAB_1811473e8;
          cVar1 = String.Contains(lVar2,"Premultiplied",0);
          if (!cVar1) goto LAB_1811473a0;
          uVar4 = 1;
        }
        this.mPMA = (int)uVar4;
        LAB_1811473a5:
        return CONCAT71((int7)(uVar4 >> 8),(int)uVar4 == 1);
    }

    // Token : 0x6000793
    // RVA   : 0x11470A0   Offset: 0x1145EA0   Length: 0x1A2
    public virtual bool get_packedFontShader()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar2 = UIFont.get_replacement(this,0);
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
        if (this.mPacked != 0xffffffff) goto LAB_181147206;
        lVar2 = UIFont.get_material(this,0);
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (!cVar1) {
        LAB_181147201:
          uVar3 = 0;
        }
        else {
          if (lVar2 == null) goto LAB_18114723d;
          uVar4 = Material.get_shader(lVar2,0);
          cVar1 = Object.op_Inequality(uVar4,0,0);
          if (!cVar1) goto LAB_181147201;
          lVar2 = Material.get_shader(lVar2,0);
          if (lVar2 == null) {
        LAB_18114723d:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar2 = Object.get_name(lVar2,0);
          if (lVar2 == null) goto LAB_18114723d;
          cVar1 = String.Contains(lVar2,"Packed",0);
          if (!cVar1) goto LAB_181147201;
          uVar3 = 1;
        }
        this.mPacked = (int)uVar3;
        LAB_181147206:
        return CONCAT71((int7)(uVar3 >> 8),(int)uVar3 == 1);
    }

    // Token : 0x6000794
    // RVA   : 0x1147990   Offset: 0x1146790   Length: 0x148
    public virtual Texture2D get_texture()
    {
        bool cVar1;
        long lVar3;
        ushort uVar6;
        ulong uVar7;
        plVar2 = (int64 *)UIFont.get_replacement(this);
        uVar7 = 0;
        if (plVar2 == (int64 *)0) {
          lVar3 = UIFont.get_material(this);
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
              goto LAB_181147aa8;
            }
            uVar6 = (short)uVar7 + 1;
            uVar7 = (uint64)uVar6;
          } while (uVar6 < *(uint16 *)(lVar3 + 0x12a));
        }
        puVar5 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,16);
        LAB_181147aa8:
                          // WARNING: Could not recover jumptable at 0x000181147ab9. Too many branches
                          // WARNING: Treating indirect jump as call
        plVar2 = (int64 *)(*(code *)*puVar5)(plVar2,puVar5[1]);
        return plVar2;
    }

    // Token : 0x6000795
    // RVA   : 0x1147AE0   Offset: 0x11468E0   Length: 0x166
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
        plVar3 = (int64 *)UIFont.get_replacement(param_2,0);
        if (plVar3 == (int64 *)0) {
          uVar1 = *(uint64 *)(param_2 + 56);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            lVar4 = UIFont.get_sprite(param_2,0);
            if (lVar4 != null) {
              uVar8 = *(uint32 *)(param_2 + 32);
              uVar9 = *(uint32 *)(param_2 + 36);
              uVar10 = *(uint32 *)(param_2 + 40);
              uVar11 = *(uint32 *)(param_2 + 44);
              goto LAB_181147c19;
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
              goto LAB_181147c08;
            }
            uVar7 = uVar7 + 1;
          } while (uVar7 < *(uint16 *)(lVar4 + 0x12a));
        }
        puVar5 = (uint64 *)FUN_18019b1f0(plVar3,DAT_181e5a6e0,17);
        LAB_181147c08:
        puVar6 = (uint32 *)(*(code *)*puVar5)(local_18,plVar3,puVar5[1]);
        uVar8 = *puVar6;
        uVar9 = puVar6[1];
        uVar10 = puVar6[2];
        uVar11 = puVar6[3];
        LAB_181147c19:
        *(uint32 *)this = uVar8;
        *(uint32 *)((int64)this + 4) = uVar9;
        *(uint32 *)(this + 1) = uVar10;
        *(uint32 *)((int64)this + 12) = uVar11;
        return this;
    }

    // Token : 0x6000796
    // RVA   : 0x1148930   Offset: 0x1147730   Length: 0x127
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
        plVar5 = (int64 *)UIFont.get_replacement(this,0);
        if (plVar5 == (int64 *)0) {
          lVar6 = UIFont.get_sprite(this,0);
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
              UIFont.MarkAsChanged(this,0);
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
                goto LAB_181148a1a;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar6 + 0x12a));
          }
          puVar7 = (uint64 *)FUN_18019b1f0(plVar5,DAT_181e5a6e0,18);
        LAB_181148a1a:
          local_18 = *(uint32 *)value;
          uStack_14 = *(uint32 *)((int64)value + 4);
          uStack_10 = *(uint32 *)(value + 1);
          uStack_c = *(uint32 *)((int64)value + 12);
          (*(code *)*puVar7)(plVar5,&local_18,puVar7[1]);
        }
    }

    // Token : 0x6000797
    // RVA   : 0x1147490   Offset: 0x1146290   Length: 0xD0
    public virtual string get_spriteName()
    {
        long lVar1;
        ulong uVar4;
        ushort uVar5;
        plVar2 = (int64 *)UIFont.get_replacement(this,0);
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
              goto LAB_181147518;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,19);
        LAB_181147518:
                          // WARNING: Could not recover jumptable at 0x000181147529. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar4 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar4;
    }

    // Token : 0x6000798
    // RVA   : 0x1148620   Offset: 0x1147420   Length: 0x120
    public virtual void set_spriteName(string value)
    {
        long lVar1;
        bool cVar2;
        ushort uVar4;
        plVar3 = (int64 *)UIFont.get_replacement(this,0);
        if (plVar3 == (int64 *)0) {
          if (this.mFont != null) {
            cVar2 = String.op_Inequality(this.mFont.mSpriteName,value,0)
            ;
            if (!cVar2) {
              return;
            }
            if (this.mFont != null) {
              this.mFont.mSpriteName = value;
              UIFont.MarkAsChanged(this,0);
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar1 = *plVar3;
        uVar4 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181e5a6e0) {
              puVar5 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                        16 + 0x278 + lVar1);
              goto LAB_181148708;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar5 = (uint64 *)FUN_18019b1f0(plVar3,DAT_181e5a6e0,20);
        LAB_181148708:
        (*(code *)*puVar5)(plVar3,value,puVar5[1]);
    }

    // Token : 0x6000799
    // RVA   : 0x1146E10   Offset: 0x1145C10   Length: 0x88
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

    // Token : 0x600079A
    // RVA   : 0x1146A00   Offset: 0x1145800   Length: 0xF5
    public int get_size()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = UIFont.get_replacement(this,0);
        if (lVar3 != null) {
          uVar4 = FUN_180002280(22,DAT_181e5a6e0,lVar3);
          return uVar4;
        }
        lVar3 = UIFont.get_replacement(this,0);
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

    // Token : 0x600079B
    // RVA   : 0x1147FE0   Offset: 0x1146DE0   Length: 0x69
    public void set_size(int value)
    {
        long lVar1;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 == null) {
          this.mDynamicFontSize = value;
          return;
        }
        FUN_180054430(23,DAT_181e5a6e0,lVar1,value);
    }

    // Token : 0x600079C
    // RVA   : 0x1146A00   Offset: 0x1145800   Length: 0xF5
    public virtual int get_defaultSize()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = UIFont.get_replacement(this,0);
        if (lVar3 != null) {
          uVar4 = FUN_180002280(22,DAT_181e5a6e0,lVar3);
          return uVar4;
        }
        lVar3 = UIFont.get_replacement(this,0);
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

    // Token : 0x600079D
    // RVA   : 0x1147FE0   Offset: 0x1146DE0   Length: 0x69
    public virtual void set_defaultSize(int value)
    {
        long lVar1;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 == null) {
          this.mDynamicFontSize = value;
          return;
        }
        FUN_180054430(23,DAT_181e5a6e0,lVar1,value);
    }

    // Token : 0x600079E
    // RVA   : 0x1147570   Offset: 0x1146370   Length: 0x268
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
        plVar2 = (int64 *)UIFont.get_replacement(this,0);
        if (plVar2 != (int64 *)0) {
          lVar3 = *plVar2;
          uVar7 = 0;
          if (*(uint16 *)(lVar3 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar7 * 16) == DAT_181e5a6e0) {
                puVar6 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar7 * 16) *
                          16 + 0x2b8 + lVar3);
                goto LAB_1811477a7;
              }
              uVar7 = uVar7 + 1;
            } while (uVar7 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar6 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,24);
        LAB_1811477a7:
                          // WARNING: Could not recover jumptable at 0x0001811477b9. Too many branches
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
                if (this.mFont == null) goto LAB_1811477d3;
                this.mFont.mSpriteName = 0;
              }
              else {
                UIFont.UpdateUVRect(this,0);
              }
              if (this.mSymbols != null) {
                lVar3 = (int64)this.mSymbols.Count;
                if (0 < lVar3) {
                  lVar10 = 32;
                  uVar9 = uVar8;
                  do {
                    lVar5 = UIFont.get_symbols(this,0);
                    if (lVar5 == null) goto LAB_1811477d3;
                    if (*(uint32 *)(lVar5 + 24) <= (uint32)uVar8) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (*(int64 *)(lVar10 + *(int64 *)(lVar5 + 16)) == 0) goto LAB_1811477d3;
                    BMSymbol.MarkAsChanged();
                    uVar8 = (uint64)((uint32)uVar8 + 1);
                    uVar9 = uVar9 + 1;
                    lVar10 = lVar10 + 8;
                  } while ((int64)uVar9 < lVar3);
                }
                goto LAB_181147738;
              }
            }
        LAB_1811477d3:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
        LAB_181147738:
        return this.mSprite;
    }

    // Token : 0x600079F
    // RVA   : 0x1147400   Offset: 0x1146200   Length: 0x8F
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

    // Token : 0x60007A0
    // RVA   : 0x11484A0   Offset: 0x11472A0   Length: 0x17A
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
            UIFont.MarkAsChanged(this,0);
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
          UIFont.MarkAsChanged(this,0);
        }
    }

    // Token : 0x60007A1
    // RVA   : 0x1146C30   Offset: 0x1145A30   Length: 0xCE
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
                goto LAB_181146cb8;
              }
              uVar2 = (short)uVar3 + 1;
              uVar3 = (uint64)uVar2;
            } while (uVar2 < *(uint16 *)(lVar1 + 0x12a));
          }
          puVar4 = (uint64 *)FUN_18019b1f0(this,DAT_181e5a6e0,25);
        LAB_181146cb8:
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

    // Token : 0x60007A2
    // RVA   : 0x1146D80   Offset: 0x1145B80   Length: 0x8D
    public virtual bool get_isDynamic()
    {
        ulong uVar1;
        long lVar2;
        lVar2 = UIFont.get_replacement(this,0);
        if (lVar2 != null) {
          FUN_180002280(28,DAT_181e5a6e0,lVar2);
          return;
        }
        uVar1 = this.mDynamicFont;
        Object.op_Inequality(uVar1,0,0);
    }

    // Token : 0x60007A3
    // RVA   : 0x1146B60   Offset: 0x1145960   Length: 0xC2
    public virtual Font get_dynamicFont()
    {
        long lVar1;
        ulong uVar4;
        ushort uVar5;
        plVar2 = (int64 *)UIFont.get_replacement(this,0);
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
              goto LAB_181146be8;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,29);
        LAB_181146be8:
                          // WARNING: Could not recover jumptable at 0x000181146bf9. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar4 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar4;
    }

    // Token : 0x60007A4
    // RVA   : 0x11480D0   Offset: 0x1146ED0   Length: 0x28B
    public virtual void set_dynamicFont(Font value)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        ushort uVar6;
        ulong uVar7;
        plVar4 = (int64 *)UIFont.get_replacement(this);
        if (plVar4 != (int64 *)0) {
          lVar2 = *plVar4;
          uVar6 = 0;
          if (*(uint16 *)(lVar2 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar6 * 16) == DAT_181e5a6e0) {
                puVar5 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar6 * 16) *
                          16 + 0x318 + lVar2);
                goto LAB_181148328;
              }
              uVar6 = uVar6 + 1;
            } while (uVar6 < *(uint16 *)(lVar2 + 0x12a));
          }
          puVar5 = (uint64 *)FUN_18019b1f0(plVar4,DAT_181e5a6e0,30);
        LAB_181148328:
                          // WARNING: Could not recover jumptable at 0x000181148341. Too many branches
                          // WARNING: Treating indirect jump as call
          (*(code *)*puVar5)(plVar4,value,puVar5[1]);
          return;
        }
        uVar1 = this.mDynamicFont;
        cVar3 = Object.op_Inequality(uVar1,value,0);
        if (cVar3) {
          uVar1 = this.mDynamicFont;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            plVar4 = (int64 *)UIFont.get_replacement(this);
            if (plVar4 == (int64 *)0) {
              uVar1 = this.mMat;
              cVar3 = Object.op_Inequality(uVar1,0,0);
              if (cVar3) {
                this.mPMA = 0xffffffff;
                this.mMat = 0;
                UIFont.MarkAsChanged(this,0);
              }
            }
            else {
              lVar2 = *plVar4;
              uVar7 = 0;
              if (*(uint16 *)(lVar2 + 0x12a) != 0) {
                do {
                  if (*(int64 *)(*(int64 *)(lVar2 + 176) + uVar7 * 16) == DAT_181e5a6e0) {
                    puVar5 = (uint64 *)
                             ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + uVar7 * 16) * 16 +
                              0x208 + lVar2);
                    goto LAB_181148288;
                  }
                  uVar6 = (short)uVar7 + 1;
                  uVar7 = (uint64)uVar6;
                } while (uVar6 < *(uint16 *)(lVar2 + 0x12a));
              }
              puVar5 = (uint64 *)FUN_18019b1f0(plVar4,DAT_181e5a6e0,13);
        LAB_181148288:
              (*(code *)*puVar5)(plVar4,0,puVar5[1]);
            }
          }
          this.mDynamicFont = value;
          UIFont.MarkAsChanged(this,0);
        }
    }

    // Token : 0x60007A5
    // RVA   : 0x1146B00   Offset: 0x1145900   Length: 0x56
    public virtual FontStyle get_dynamicFontStyle()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002280(31,DAT_181e5a6e0,lVar1);
          return uVar2;
        }
        return (uint64)this.mDynamicFontStyle;
    }

    // Token : 0x60007A6
    // RVA   : 0x1148050   Offset: 0x1146E50   Length: 0x78
    public virtual void set_dynamicFontStyle(FontStyle value)
    {
        long lVar1;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 == null) {
          if (this.mDynamicFontStyle != value) {
            this.mDynamicFontStyle = value;
            UIFont.MarkAsChanged(this,0);
            return;
          }
        }
        else {
          FUN_180054430(32,DAT_181e5a6e0,lVar1,value);
        }
    }

    // Token : 0x60007A7
    // RVA   : 0x11461C0   Offset: 0x1144FC0   Length: 0x282
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
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
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
          plVar9 = (int64 *)UIFont.get_texture(this,0);
          if (plVar9 != (int64 *)0) {
            uVar3 = (**(code **)(*plVar9 + 0x178))(plVar9,*(uint64 *)(*plVar9 + 0x180));
            plVar9 = (int64 *)UIFont.get_texture(this,0);
            if (plVar9 != (int64 *)0) {
              uVar4 = (**(code **)(*plVar9 + 0x198))(plVar9,*(uint64 *)(*plVar9 + 0x1a0));
              local_38 = uVar8;
              uStack_30 = uVar1;
              puVar10 = (uint64 *)NGUIMath.ConvertToPixels(local_28,&local_38,uVar3,uVar4,1,0);
              local_48 = *puVar10;
              uStack_40 = puVar10[1];
              if (this.mSprite != null) {
                FUN_1807282e0(&local_58);
                FUN_180af4e60(&local_58,0);
                FUN_180af4e60(&local_48,0);
                uVar3 = Mathf.RoundToInt();
                FUN_180af4e80(&local_58,0);
                FUN_180af4e80(&local_48,0);
                uVar4 = Mathf.RoundToInt();
                Rect.get_xMax(&local_58,0);
                FUN_180af4e60(&local_48,0);
                uVar5 = Mathf.RoundToInt();
                Rect.get_yMax(&local_58,0);
                FUN_180af4e80(&local_48,0);
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

    // Token : 0x60007A8
    // RVA   : 0x1146000   Offset: 0x1144E00   Length: 0xF0
    public virtual bool References(INGUIFont font)
    {
        long lVar1;
        ulong uVar4;
        ushort uVar5;
        if (font != null) {
          if (font == this) {
            return true;
          }
          plVar2 = (int64 *)UIFont.get_replacement(this,0);
          if (plVar2 != (int64 *)0) {
            lVar1 = *plVar2;
            uVar5 = 0;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar5 * 16) == DAT_181e5a6e0)
                {
                  puVar3 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar5 * 16)
                            * 16 + 0x348 + lVar1);
                  goto LAB_1811460a8;
                }
                uVar5 = uVar5 + 1;
              } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar3 = (uint64 *)FUN_18019b1f0(plVar2,DAT_181e5a6e0,33);
        LAB_1811460a8:
                          // WARNING: Could not recover jumptable at 0x0001811460bc. Too many branches
                          // WARNING: Treating indirect jump as call
            uVar4 = (*(code *)*puVar3)(plVar2,font,puVar3[1]);
            return uVar4;
          }
        }
        return false;
    }

    // Token : 0x60007A9
    // RVA   : 0x1145BE0   Offset: 0x11449E0   Length: 0x253
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
        lVar3 = UIFont.get_replacement(this,0);
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
          lVar3 = UIFont.get_symbols(this,0);
          if (lVar3 != null) {
            iVar1 = *(int *)(lVar3 + 24);
            if (0 < (int64)iVar1) {
              lVar3 = 32;
              uVar7 = uVar6;
              do {
                lVar5 = UIFont.get_symbols(this,0);
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

    // Token : 0x60007AA
    // RVA   : 0x1146450   Offset: 0x1145250   Length: 0x1F5
    public virtual void UpdateUVRect()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        uint uVar5;
        long lVar6;
        ulong in_stack_ffffffffffffffa8;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        uVar4 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        uVar1 = this.mAtlas;
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (!cVar3) {
          plVar7 = (int64 *)0;
          lVar6 = il2cpp_internal(this.mAtlas,DAT_181e5a658);
          if (lVar6 != null) {
            plVar7 = (int64 *)FUN_180002280(4,DAT_181e5a658,lVar6);
          }
          cVar3 = Object.op_Inequality(plVar7,0,0);
          if (cVar3) {
            lVar6 = this.mSprite;
            if (lVar6 != null) {
              local_48 = 0;
              uStack_40 = 0;
              FUN_1807282e0(&local_48,lVar6.paddingRight,lVar6.width,
                            lVar6.paddingTop,
                            CONCAT44(uVar4,(float)(lVar6.paddingBottom + lVar6.paddingTop +
                                                  lVar6.height)),0);
              uVar2 = uStack_40;
              uVar1 = local_48;
              this.mUVRect = local_48;
              *(uint64 *)(this + 40) = uStack_40;
              if (plVar7 != (int64 *)0) {
                uVar4 = (**(code **)(*plVar7 + 0x178))(plVar7,*(uint64 *)(*plVar7 + 0x180));
                uVar5 = (**(code **)(*plVar7 + 0x198))(plVar7,*(uint64 *)(*plVar7 + 0x1a0));
                local_38 = uVar1;
                uStack_30 = uVar2;
                puVar8 = (uint64 *)NGUIMath.ConvertToTexCoords(local_28,&local_38,uVar4,uVar5,0);
                uVar1 = puVar8[1];
                this.mUVRect = *puVar8;
                *(uint64 *)(this + 40) = uVar1;
                if (this.mSprite != null) {
                  cVar3 = UISpriteData.get_hasPadding(this.mSprite,0);
                  if (!cVar3) {
                    return;
                  }
                  UIFont.Trim(this,0);
                  return;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x60007AB
    // RVA   : 0x1145A80   Offset: 0x1144880   Length: 0x150
    private BMSymbol GetSymbol(string sequence, bool createIfMissing)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        uVar3 = 0;
        if (this.mSymbols != null) {
          lVar6 = (int64)this.mSymbols.Count;
          if (0 < lVar6) {
            lVar5 = 32;
            uVar4 = uVar3;
            do {
              lVar1 = this.mSymbols;
              if (lVar1 == null) throw; // [null/range check failed]
              if (lVar1.Count <= (uint32)uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar1 = *(int64 *)(lVar5 + lVar1._items);
              if (lVar1 == null) throw; // [null/range check failed]
              cVar2 = FUN_1816387f0(lVar1._items,sequence,0);
              if (cVar2) {
                return lVar1;
              }
              uVar4 = (uint64)((uint32)uVar4 + 1);
              uVar3 = uVar3 + 1;
              lVar5 = lVar5 + 8;
            } while ((int64)uVar3 < lVar6);
          }
          if (!createIfMissing) {
            return false;
          }
          lVar6 = new c.DisplayClass9_0(0);
          if (lVar6 != null) {
            *(uint64 *)(lVar6 + 16) = sequence;
            if (this.mSymbols != null) {
              FUN_18175de30(this.mSymbols,lVar6,DAT_181e60410);
              return lVar6;
            }
          }
        }
    }

    // Token : 0x60007AC
    // RVA   : 0x1145E40   Offset: 0x1144C40   Length: 0x1B6
    public virtual BMSymbol MatchSymbol(string text, int offset, int textLength)
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        int iVar6;
        int iVar7;
        long lVar8;
        long lVar9;
        uint uVar10;
        if (this.mSymbols != null) {
          iVar1 = this.mSymbols.Count;
          if (iVar1 != 0) {
            uVar10 = 0;
            if (0 < iVar1) {
              lVar8 = 0;
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
                  iVar7 = 0;
                  if (0 < iVar6) {
                    do {
                      if (text == null) throw; // [null/range check failed]
                      sVar4 = String.get_Chars(text,iVar7 + offset,0);
                      if (lVar2._items == null) throw; // [null/range check failed]
                      sVar5 = String.get_Chars(lVar2._items,iVar7,0);
                      if (sVar4 != sVar5) goto LAB_181145fd0;
                      iVar7 = iVar7 + 1;
                    } while (iVar7 < iVar6);
                  }
                  UIFont.get_atlas(this,0);
                  cVar3 = BMSymbol.Validate();
                  if (cVar3) {
                    return lVar2;
                  }
                }
        LAB_181145fd0:
                uVar10 = uVar10 + 1;
                lVar8 = lVar8 + 1;
                lVar9 = lVar9 + 8;
              } while (lVar8 < iVar1);
            }
          }
          return 0;
        }
    }

    // Token : 0x60007AD
    // RVA   : 0x1145970   Offset: 0x1144770   Length: 0x48
    public virtual void AddSymbol(string sequence, string spriteName)
    {
        long lVar1;
        lVar1 = UIFont.GetSymbol(this,sequence,1,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 24) = spriteName;
          UIFont.MarkAsChanged(this,0);
          return;
        }
    }

    // Token : 0x60007AE
    // RVA   : 0x11460F0   Offset: 0x1144EF0   Length: 0x7F
    public virtual void RemoveSymbol(string sequence)
    {
        long lVar1;
        long lVar2;
        lVar1 = UIFont.GetSymbol(this,sequence,0,0);
        if (lVar1 != null) {
          lVar2 = UIFont.get_symbols(this,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          FUN_181665e90(lVar2,lVar1,DAT_181e60490);
        }
        UIFont.MarkAsChanged(this,0);
    }

    // Token : 0x60007AF
    // RVA   : 0x1146170   Offset: 0x1144F70   Length: 0x43
    public virtual void RenameSymbol(string before, string after)
    {
        long lVar1;
        lVar1 = UIFont.GetSymbol(this,before,0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 16) = after;
        }
        UIFont.MarkAsChanged(this,0);
    }

    // Token : 0x60007B0
    // RVA   : 0x1146650   Offset: 0x1145450   Length: 0x1D9
    public virtual bool UsesSprite(string s)
    {
        int iVar1;
        bool cVar2;
        ulong uVar5;
        long lVar6;
        long lVar7;
        ushort uVar8;
        ulong uVar9;
        ulong uVar10;
        cVar2 = FUN_180ad1200(s,0);
        if (cVar2) {
          return false;
        }
        plVar3 = (int64 *)UIFont.get_replacement(this,0);
        uVar9 = 0;
        if (plVar3 == (int64 *)0) {
          if (this.mFont == null) throw; // [null/range check failed]
          uVar5 = this.mFont.mSpriteName;
        }
        else {
          lVar6 = *plVar3;
          uVar8 = 0;
          if (*(uint16 *)(lVar6 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar8 * 16) == DAT_181e5a6e0) {
                puVar4 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x268 + lVar6);
                uVar5 = (*(code *)*puVar4)(plVar3,puVar4[1]);
                goto LAB_181146766;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar6 + 0x12a));
          }
          puVar4 = (uint64 *)FUN_18019b1f0(plVar3,DAT_181e5a6e0,19);
          uVar5 = (*(code *)*puVar4)(plVar3,puVar4[1]);
        }
        LAB_181146766:
        if (s != null) {
          cVar2 = String.Equals(s,uVar5,0);
          if (cVar2) {
            return true;
          }
          lVar6 = UIFont.get_symbols(this,0);
          if (lVar6 != null) {
            iVar1 = *(int *)(lVar6 + 24);
            if ((int64)iVar1 < 1) {
              return false;
            }
            lVar6 = 32;
            uVar10 = uVar9;
            while (lVar7 = UIFont.get_symbols(this,0)) != null {
              if (*(uint32 *)(lVar7 + 24) <= (uint32)uVar10) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = *(int64 *)(lVar6 + *(int64 *)(lVar7 + 16));
              if (lVar7 == null) break;
              cVar2 = String.Equals(s,*(uint64 *)(lVar7 + 24),0);
              if (cVar2) {
                return true;
              }
              uVar10 = (uint64)((uint32)uVar10 + 1);
              uVar9 = uVar9 + 1;
              lVar6 = lVar6 + 8;
              if ((int64)iVar1 <= (int64)uVar9) {
                return false;
              }
            }
          }
        }
    }

    // Token : 0x60007B1
    // RVA   : 0x1146830   Offset: 0x1145630   Length: 0xF2
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
        FUN_180ae8740(this,0);
    }

}
