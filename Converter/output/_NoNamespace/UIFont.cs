// ============================================================
// Type  : UIFont
// Token : 0x20000F3
// ============================================================

public class UIFont
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40005BA
    private Material mMat;

    // Token: 0x40005BB
    private Rect mUVRect;

    // Token: 0x40005BC
    private BMFont mFont;

    // Token: 0x40005BD
    private object mAtlas;

    // Token: 0x40005BE
    private object mReplacement;

    // Token: 0x40005BF
    private List<BMSymbol> mSymbols;

    // Token: 0x40005C0
    private Font mDynamicFont;

    // Token: 0x40005C1
    private int mDynamicFontSize;

    // Token: 0x40005C2
    private FontStyle mDynamicFontStyle;

    // Token: 0x40005C3
    private UISpriteData mSprite;

    // Token: 0x40005C4
    private int mPMA;

    // Token: 0x40005C5
    private int mPacked;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000784
    // RVA   : 0x10E8C90   Offset: 0x10E7490   Length: 0x54
    public virtual BMFont get_bmFont()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002970(0,DAT_181d556d0,lVar1);
          return uVar2;
        }
        return this.mFont;
    }

    // Token : 0x6000785
    // RVA   : 0x10EA110   Offset: 0x10E8910   Length: 0xDD
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
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181d556d0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                        16 + 0x148 + lVar1);
              goto LAB_1810ea1ba;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d556d0,1);
        LAB_1810ea1ba:
                          // WARNING: Could not recover jumptable at 0x0001810ea1d3. Too many branches
                          // WARNING: Treating indirect jump as call
        (*(code *)*puVar3)(plVar2,value,puVar3[1]);
    }

    // Token : 0x6000786
    // RVA   : 0x10E9BA0   Offset: 0x10E83A0   Length: 0x6A
    public virtual int get_texWidth()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002970(2,DAT_181d556d0,lVar1);
          return uVar2;
        }
        if (this.mFont != null) {
          return (uint64)this.mFont.mWidth;
        }
        return 1;
    }

    // Token : 0x6000787
    // RVA   : 0x10EAAC0   Offset: 0x10E92C0   Length: 0x73
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
          FUN_180004670(3,DAT_181d556d0,lVar1,value);
        }
    }

    // Token : 0x6000788
    // RVA   : 0x10E9B30   Offset: 0x10E8330   Length: 0x6A
    public virtual int get_texHeight()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002970(4,DAT_181d556d0,lVar1);
          return uVar2;
        }
        if (this.mFont != null) {
          return (uint64)this.mFont.mHeight;
        }
        return 1;
    }

    // Token : 0x6000789
    // RVA   : 0x10EAA40   Offset: 0x10E9240   Length: 0x73
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
          FUN_180004670(5,DAT_181d556d0,lVar1,value);
        }
    }

    // Token : 0x600078A
    // RVA   : 0x10E8F80   Offset: 0x10E7780   Length: 0x75
    public virtual bool get_hasSymbols()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002970(6,DAT_181d556d0,lVar1);
          return uVar2;
        }
        lVar1 = this.mSymbols;
        if (lVar1 == null) {
          return false;
        }
        return CONCAT71((int7)((uint64)lVar1 >> 8),lVar1.Count != null);
    }

    // Token : 0x600078B
    // RVA   : 0x10E9A60   Offset: 0x10E8260   Length: 0xC2
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
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar5 * 16) == DAT_181d556d0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar5 * 16) *
                        16 + 0x1a8 + lVar1);
              goto LAB_1810e9ae8;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d556d0,7);
        LAB_1810e9ae8:
                          // WARNING: Could not recover jumptable at 0x0001810e9af9. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar4 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar4;
    }

    // Token : 0x600078C
    // RVA   : 0x10EA960   Offset: 0x10E9160   Length: 0xDD
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
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181d556d0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                        16 + 0x1b8 + lVar1);
              goto LAB_1810eaa0a;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d556d0,8);
        LAB_1810eaa0a:
                          // WARNING: Could not recover jumptable at 0x0001810eaa23. Too many branches
                          // WARNING: Treating indirect jump as call
        (*(code *)*puVar3)(plVar2,value,puVar3[1]);
    }

    // Token : 0x600078D
    // RVA   : 0x10E8C20   Offset: 0x10E7420   Length: 0x6E
    public virtual INGUIAtlas get_atlas()
    {
        long lVar1;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 == null) {
          il2cpp_internal(this.mAtlas,DAT_181d55650);
          return;
        }
        FUN_180002970(9,DAT_181d556d0,lVar1);
    }

    // Token : 0x600078E
    // RVA   : 0x10E9E60   Offset: 0x10E8660   Length: 0x2AA
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
          FUN_180004720(10,DAT_181d556d0,lVar3,value);
          return;
        }
        plVar4 = (int64 *)il2cpp_internal(this.mAtlas,DAT_181d55650);
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
          if ((*(byte *)(*value + 300) < *(byte *)(DAT_181d68fe8 + 300)) ||
             (*(int64 *)
               (*(int64 *)(*value + 200) + -8 + (uint64)*(byte *)(DAT_181d68fe8 + 300) * 8) !=
              DAT_181d68fe8)) {
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
          uVar5 = FUN_180002970(0,DAT_181d55650,value);
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
                FUN_1809981e0(&local_28,0,0,0x3f800000,0x3f800000,0);
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
                      DAT_181d556d0) {
                    puVar6 = (uint64 *)
                             ((int64)
                              *(int *)(*(int64 *)(lVar3 + 176) + 8 + (int64)plVar9 * 16) * 16 +
                              0x248 + lVar3);
                    goto LAB_1810ea097;
                  }
                  uVar8 = (short)plVar9 + 1;
                  plVar9 = (int64 *)(uint64)uVar8;
                } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
              }
              puVar6 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d556d0,17);
        LAB_1810ea097:
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

    // Token : 0x600078F
    // RVA   : 0x10E7CB0   Offset: 0x10E64B0   Length: 0xBA
    public virtual UISpriteData GetSprite(string spriteName)
    {
        long lVar1;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 == null) {
          lVar1 = il2cpp_internal(this.mAtlas,DAT_181d55650);
        }
        else {
          lVar1 = FUN_180002970(9,DAT_181d556d0,lVar1);
        }
        if (lVar1 == null) {
          return;
        }
        FUN_180002aa0(10,DAT_181d55650,lVar1,spriteName);
    }

    // Token : 0x6000790
    // RVA   : 0x10E9120   Offset: 0x10E7920   Length: 0x1F8
    public virtual Material get_material()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        lVar2 = UIFont.get_replacement(this,0);
        if (lVar2 != null) {
          uVar3 = FUN_180002970(12,DAT_181d556d0,lVar2);
          return uVar3;
        }
        lVar2 = il2cpp_internal(this.mAtlas,DAT_181d55650);
        if (lVar2 != null) {
          uVar3 = FUN_180002970(0,DAT_181d55650,lVar2);
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
        LAB_1810e92d5:
            return this.mMat;
          }
          uVar3 = this.mMat;
          if (this.mDynamicFont != null) {
            uVar4 = Font.get_material(this.mDynamicFont,0);
            cVar1 = Object.op_Inequality(uVar3,uVar4,0);
            if (!cVar1) goto LAB_1810e92d5;
            lVar2 = this.mMat;
            if (this.mDynamicFont != null) {
              lVar5 = Font.get_material(this.mDynamicFont,0);
              if (lVar5 != null) {
                uVar3 = Material.get_mainTexture(lVar5,0);
                if (lVar2 != null) {
                  Material.set_mainTexture(lVar2,uVar3,0);
                  goto LAB_1810e92d5;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000791
    // RVA   : 0x10EA570   Offset: 0x10E8D70   Length: 0x13C
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
              if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar6 * 16) == DAT_181d556d0) {
                puVar5 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar6 * 16) *
                          16 + 0x208 + lVar2);
                goto LAB_1810ea679;
              }
              uVar6 = uVar6 + 1;
            } while (uVar6 < *(uint16 *)(lVar2 + 0x12a));
          }
          puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d556d0,13);
        LAB_1810ea679:
          (*(code *)*puVar5)(plVar4,value,puVar5[1]);
        }
    }

    // Token : 0x6000792
    // RVA   : 0x10E9670   Offset: 0x10E7E70   Length: 0x7
    public bool get_premultipliedAlpha()
    {
        void FUN_1810e9670(uint64 this)
        {
        UIFont.get_premultipliedAlphaShader(this,0);
    }

    // Token : 0x6000793
    // RVA   : 0x10E94D0   Offset: 0x10E7CD0   Length: 0x19D
    public virtual bool get_premultipliedAlphaShader()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar2 = UIFont.get_replacement(this,0);
        if (lVar2 != null) {
          uVar3 = FUN_180002970(14,DAT_181d556d0,lVar2);
          return uVar3;
        }
        lVar2 = il2cpp_internal(this.mAtlas,DAT_181d55650);
        if (lVar2 != null) {
          uVar3 = FUN_180002970(7,DAT_181d55650,lVar2);
          return uVar3;
        }
        uVar4 = (uint64)this.mPMA;
        if (this.mPMA != 0xffffffff) goto LAB_1810e9625;
        lVar2 = UIFont.get_material(this,0);
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (!cVar1) {
        LAB_1810e9620:
          uVar4 = 0;
        }
        else {
          if (lVar2 == null) goto LAB_1810e9668;
          uVar3 = Material.get_shader(lVar2,0);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) goto LAB_1810e9620;
          lVar2 = Material.get_shader(lVar2,0);
          if (lVar2 == null) {
        LAB_1810e9668:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = Object.get_name(lVar2,0);
          if (lVar2 == null) goto LAB_1810e9668;
          cVar1 = String.Contains(lVar2,"Premultiplied",0);
          if (!cVar1) goto LAB_1810e9620;
          uVar4 = 1;
        }
        this.mPMA = (int)uVar4;
        LAB_1810e9625:
        return CONCAT71((int7)(uVar4 >> 8),(int)uVar4 == 1);
    }

    // Token : 0x6000794
    // RVA   : 0x10E9320   Offset: 0x10E7B20   Length: 0x1A2
    public virtual bool get_packedFontShader()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar2 = UIFont.get_replacement(this,0);
        if (lVar2 != null) {
          uVar3 = FUN_180002970(15,DAT_181d556d0,lVar2);
          return uVar3;
        }
        uVar4 = this.mAtlas;
        uVar3 = Object.op_Inequality(uVar4,0,0);
        if ((char)uVar3) {
          return uVar3 & 0xffffffffffffff00;
        }
        uVar3 = (uint64)this.mPacked;
        if (this.mPacked != 0xffffffff) goto LAB_1810e9486;
        lVar2 = UIFont.get_material(this,0);
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (!cVar1) {
        LAB_1810e9481:
          uVar3 = 0;
        }
        else {
          if (lVar2 == null) goto LAB_1810e94bd;
          uVar4 = Material.get_shader(lVar2,0);
          cVar1 = Object.op_Inequality(uVar4,0,0);
          if (!cVar1) goto LAB_1810e9481;
          lVar2 = Material.get_shader(lVar2,0);
          if (lVar2 == null) {
        LAB_1810e94bd:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = Object.get_name(lVar2,0);
          if (lVar2 == null) goto LAB_1810e94bd;
          cVar1 = String.Contains(lVar2,"Packed",0);
          if (!cVar1) goto LAB_1810e9481;
          uVar3 = 1;
        }
        this.mPacked = (int)uVar3;
        LAB_1810e9486:
        return CONCAT71((int7)(uVar3 >> 8),(int)uVar3 == 1);
    }

    // Token : 0x6000795
    // RVA   : 0x10E9C10   Offset: 0x10E8410   Length: 0xDB
    public virtual Texture2D get_texture()
    {
        bool cVar1;
        long lVar2;
        lVar2 = UIFont.get_replacement(this,0);
        if (lVar2 != null) {
          plVar3 = (int64 *)FUN_180002970(16,DAT_181d556d0,lVar2);
          return plVar3;
        }
        lVar2 = UIFont.get_material(this,0);
        cVar1 = Object.op_Inequality(lVar2,0,0);
        if (cVar1) {
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          plVar3 = (int64 *)Material.get_mainTexture(lVar2,0);
          if (plVar3 != (int64 *)0) {
            plVar4 = (int64 *)0;
            if (*plVar3 == DAT_181d86170) {
              plVar4 = plVar3;
            }
            return plVar4;
          }
        }
        return (int64 *)0;
    }

    // Token : 0x6000796
    // RVA   : 0x10E9CF0   Offset: 0x10E84F0   Length: 0x166
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
              goto LAB_1810e9e29;
            }
          }
          *this = 0;
          this[1] = 0;
          FUN_1809981e0(this,0,0,0x3f800000,0x3f800000,0);
          return this;
        }
        lVar4 = *plVar3;
        uVar7 = 0;
        if (*(uint16 *)(lVar4 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar7 * 16) == DAT_181d556d0) {
              puVar5 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar7 * 16) *
                        16 + 0x248 + lVar4);
              goto LAB_1810e9e18;
            }
            uVar7 = uVar7 + 1;
          } while (uVar7 < *(uint16 *)(lVar4 + 0x12a));
        }
        puVar5 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d556d0,17);
        LAB_1810e9e18:
        puVar6 = (uint32 *)(*(code *)*puVar5)(local_18,plVar3,puVar5[1]);
        uVar8 = *puVar6;
        uVar9 = puVar6[1];
        uVar10 = puVar6[2];
        uVar11 = puVar6[3];
        LAB_1810e9e29:
        *(uint32 *)this = uVar8;
        *(uint32 *)((int64)this + 4) = uVar9;
        *(uint32 *)(this + 1) = uVar10;
        *(uint32 *)((int64)this + 12) = uVar11;
        return this;
    }

    // Token : 0x6000797
    // RVA   : 0x10EAB40   Offset: 0x10E9340   Length: 0x127
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
              if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar8 * 16) == DAT_181d556d0) {
                puVar7 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 600 + lVar6);
                goto LAB_1810eac2a;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar6 + 0x12a));
          }
          puVar7 = (uint64 *)FUN_1800914f0(plVar5,DAT_181d556d0,18);
        LAB_1810eac2a:
          local_18 = *(uint32 *)value;
          uStack_14 = *(uint32 *)((int64)value + 4);
          uStack_10 = *(uint32 *)(value + 1);
          uStack_c = *(uint32 *)((int64)value + 12);
          (*(code *)*puVar7)(plVar5,&local_18,puVar7[1]);
        }
    }

    // Token : 0x6000798
    // RVA   : 0x10E9710   Offset: 0x10E7F10   Length: 0xD0
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
          FUN_1800d6620();
        }
        lVar1 = *plVar2;
        uVar5 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar5 * 16) == DAT_181d556d0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar5 * 16) *
                        16 + 0x268 + lVar1);
              goto LAB_1810e9798;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d556d0,19);
        LAB_1810e9798:
                          // WARNING: Could not recover jumptable at 0x0001810e97a9. Too many branches
                          // WARNING: Treating indirect jump as call
        uVar4 = (*(code *)*puVar3)(plVar2,puVar3[1]);
        return uVar4;
    }

    // Token : 0x6000799
    // RVA   : 0x10EA830   Offset: 0x10E9030   Length: 0x120
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
          FUN_1800d6620();
        }
        lVar1 = *plVar3;
        uVar4 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar4 * 16) == DAT_181d556d0) {
              puVar5 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar4 * 16) *
                        16 + 0x278 + lVar1);
              goto LAB_1810ea918;
            }
            uVar4 = uVar4 + 1;
          } while (uVar4 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar5 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d556d0,20);
        LAB_1810ea918:
        (*(code *)*puVar5)(plVar3,value,puVar5[1]);
    }

    // Token : 0x600079A
    // RVA   : 0x10E9090   Offset: 0x10E7890   Length: 0x88
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

    // Token : 0x600079B
    // RVA   : 0x10E8CF0   Offset: 0x10E74F0   Length: 0xF5
    public int get_size()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = UIFont.get_replacement(this,0);
        if (lVar3 != null) {
          uVar4 = FUN_180002970(22,DAT_181d556d0,lVar3);
          return uVar4;
        }
        lVar3 = UIFont.get_replacement(this,0);
        if (lVar3 == null) {
          uVar1 = this.mDynamicFont;
          cVar2 = Object.op_Inequality(uVar1,0,0);
        }
        else {
          cVar2 = FUN_180002970(28,DAT_181d556d0,lVar3);
        }
        if ((!cVar2) && (this.mFont != null)) {
          return (uint64)this.mFont.mSize;
        }
        return (uint64)this.mDynamicFontSize;
    }

    // Token : 0x600079C
    // RVA   : 0x10EA1F0   Offset: 0x10E89F0   Length: 0x69
    public void set_size(int value)
    {
        long lVar1;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 == null) {
          this.mDynamicFontSize = value;
          return;
        }
        FUN_180004670(23,DAT_181d556d0,lVar1,value);
    }

    // Token : 0x600079D
    // RVA   : 0x10E8CF0   Offset: 0x10E74F0   Length: 0xF5
    public virtual int get_defaultSize()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = UIFont.get_replacement(this,0);
        if (lVar3 != null) {
          uVar4 = FUN_180002970(22,DAT_181d556d0,lVar3);
          return uVar4;
        }
        lVar3 = UIFont.get_replacement(this,0);
        if (lVar3 == null) {
          uVar1 = this.mDynamicFont;
          cVar2 = Object.op_Inequality(uVar1,0,0);
        }
        else {
          cVar2 = FUN_180002970(28,DAT_181d556d0,lVar3);
        }
        if ((!cVar2) && (this.mFont != null)) {
          return (uint64)this.mFont.mSize;
        }
        return (uint64)this.mDynamicFontSize;
    }

    // Token : 0x600079E
    // RVA   : 0x10EA1F0   Offset: 0x10E89F0   Length: 0x69
    public virtual void set_defaultSize(int value)
    {
        long lVar1;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 == null) {
          this.mDynamicFontSize = value;
          return;
        }
        FUN_180004670(23,DAT_181d556d0,lVar1,value);
    }

    // Token : 0x600079F
    // RVA   : 0x10E97F0   Offset: 0x10E7FF0   Length: 0x268
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
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar7 * 16) == DAT_181d556d0) {
                puVar6 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar7 * 16) *
                          16 + 0x2b8 + lVar3);
                goto LAB_1810e9a27;
              }
              uVar7 = uVar7 + 1;
            } while (uVar7 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar6 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d556d0,24);
        LAB_1810e9a27:
                          // WARNING: Could not recover jumptable at 0x0001810e9a39. Too many branches
                          // WARNING: Treating indirect jump as call
          uVar4 = (*(code *)*puVar6)(plVar2,puVar6[1]);
          return uVar4;
        }
        lVar3 = il2cpp_internal(this.mAtlas,DAT_181d55650);
        if (((this.mSprite == null) && (lVar3 != null)) && (this.mFont != null)
           ) {
          cVar1 = FUN_180d6ca90(this.mFont.mSpriteName,0);
          if (!cVar1) {
            if (this.mFont != null) {
              uVar4 = FUN_180002aa0(10,DAT_181d55650,lVar3,
                                    this.mFont.mSpriteName);
              this.mSprite = uVar4;
              lVar10 = this.mSprite;
              if (lVar10 == null) {
                uVar4 = Object.get_name(this,0);
                uVar4 = FUN_180002aa0(10,DAT_181d55650,lVar3,uVar4);
                this.mSprite = uVar4;
                lVar10 = this.mSprite;
              }
              uVar8 = 0;
              if (lVar10 == null) {
                if (this.mFont == null) goto LAB_1810e9a53;
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
                    if (lVar5 == null) goto LAB_1810e9a53;
                    if (*(uint32 *)(lVar5 + 24) <= (uint32)uVar8) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (*(int64 *)(lVar10 + *(int64 *)(lVar5 + 16)) == 0) goto LAB_1810e9a53;
                    BMSymbol.MarkAsChanged();
                    uVar8 = (uint64)((uint32)uVar8 + 1);
                    uVar9 = uVar9 + 1;
                    lVar10 = lVar10 + 8;
                  } while ((int64)uVar9 < lVar3);
                }
                goto LAB_1810e99b8;
              }
            }
        LAB_1810e9a53:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        LAB_1810e99b8:
        return this.mSprite;
    }

    // Token : 0x60007A0
    // RVA   : 0x10E9680   Offset: 0x10E7E80   Length: 0x8F
    public virtual INGUIFont get_replacement()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mReplacement;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = il2cpp_internal(this.mReplacement,DAT_181d556d0);
          return uVar2;
        }
        return 0;
    }

    // Token : 0x60007A1
    // RVA   : 0x10EA6B0   Offset: 0x10E8EB0   Length: 0x17A
    public virtual void set_replacement(INGUIFont value)
    {
        long lVar1;
        bool cVar3;
        plVar5 = (int64 *)0;
        if (value != this) {
          plVar5 = value;
        }
        plVar6 = this + 8;
        plVar4 = (int64 *)il2cpp_internal(this[8],DAT_181d556d0);
        if (plVar4 != plVar5) {
          if (plVar5 != (int64 *)0) {
            plVar4 = (int64 *)FUN_180002970(25,DAT_181d556d0,plVar5);
            if (plVar4 == this) {
              FUN_180004720(26,DAT_181d556d0,plVar5,0);
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

    // Token : 0x60007A2
    // RVA   : 0x10E8EB0   Offset: 0x10E76B0   Length: 0xCE
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
            FUN_1800d6620();
          }
          lVar1 = *this;
          uVar3 = 0;
          if (*(uint16 *)(lVar1 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar1 + 176) + uVar3 * 16) == DAT_181d556d0) {
                puVar4 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + uVar3 * 16) * 16 +
                          0x2c8 + lVar1);
                goto LAB_1810e8f38;
              }
              uVar2 = (short)uVar3 + 1;
              uVar3 = (uint64)uVar2;
            } while (uVar2 < *(uint16 *)(lVar1 + 0x12a));
          }
          puVar4 = (uint64 *)FUN_1800914f0(this,DAT_181d556d0,25);
        LAB_1810e8f38:
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

    // Token : 0x60007A3
    // RVA   : 0x10E9000   Offset: 0x10E7800   Length: 0x8D
    public virtual bool get_isDynamic()
    {
        ulong uVar1;
        long lVar2;
        lVar2 = UIFont.get_replacement(this,0);
        if (lVar2 != null) {
          FUN_180002970(28,DAT_181d556d0,lVar2);
          return;
        }
        uVar1 = this.mDynamicFont;
        Object.op_Inequality(uVar1,0,0);
    }

    // Token : 0x60007A4
    // RVA   : 0x10E8E50   Offset: 0x10E7650   Length: 0x57
    public virtual Font get_dynamicFont()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002970(29,DAT_181d556d0,lVar1);
          return uVar2;
        }
        return this.mDynamicFont;
    }

    // Token : 0x60007A5
    // RVA   : 0x10EA2E0   Offset: 0x10E8AE0   Length: 0x28B
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
              if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar6 * 16) == DAT_181d556d0) {
                puVar5 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar6 * 16) *
                          16 + 0x318 + lVar2);
                goto LAB_1810ea538;
              }
              uVar6 = uVar6 + 1;
            } while (uVar6 < *(uint16 *)(lVar2 + 0x12a));
          }
          puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d556d0,30);
        LAB_1810ea538:
                          // WARNING: Could not recover jumptable at 0x0001810ea551. Too many branches
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
                  if (*(int64 *)(*(int64 *)(lVar2 + 176) + uVar7 * 16) == DAT_181d556d0) {
                    puVar5 = (uint64 *)
                             ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + uVar7 * 16) * 16 +
                              0x208 + lVar2);
                    goto LAB_1810ea498;
                  }
                  uVar6 = (short)uVar7 + 1;
                  uVar7 = (uint64)uVar6;
                } while (uVar6 < *(uint16 *)(lVar2 + 0x12a));
              }
              puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d556d0,13);
        LAB_1810ea498:
              (*(code *)*puVar5)(plVar4,0,puVar5[1]);
            }
          }
          this.mDynamicFont = value;
          UIFont.MarkAsChanged(this,0);
        }
    }

    // Token : 0x60007A6
    // RVA   : 0x10E8DF0   Offset: 0x10E75F0   Length: 0x56
    public virtual FontStyle get_dynamicFontStyle()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIFont.get_replacement(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180002970(31,DAT_181d556d0,lVar1);
          return uVar2;
        }
        return (uint64)this.mDynamicFontStyle;
    }

    // Token : 0x60007A7
    // RVA   : 0x10EA260   Offset: 0x10E8A60   Length: 0x78
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
          FUN_180004670(32,DAT_181d556d0,lVar1,value);
        }
    }

    // Token : 0x60007A8
    // RVA   : 0x10E84B0   Offset: 0x10E6CB0   Length: 0x282
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
        lVar7 = il2cpp_internal(this.mAtlas,DAT_181d55650);
        if (lVar7 != null) {
          uVar8 = FUN_180002970(4,DAT_181d55650,lVar7);
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
                FUN_1809981e0(&local_58);
                FUN_180d904a0(&local_58,0);
                FUN_180d904a0(&local_48,0);
                uVar3 = Mathf.RoundToInt();
                FUN_18044df60(&local_58,0);
                FUN_18044df60(&local_48,0);
                uVar4 = Mathf.RoundToInt();
                Rect.get_xMax(&local_58,0);
                FUN_180d904a0(&local_48,0);
                uVar5 = Mathf.RoundToInt();
                Rect.get_yMax(&local_58,0);
                FUN_18044df60(&local_48,0);
                uVar6 = Mathf.RoundToInt();
                if (this.mFont != null) {
                  BMFont.Trim(this.mFont,uVar3,uVar4,uVar5,uVar6,0);
                  return;
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x60007A9
    // RVA   : 0x10E82F0   Offset: 0x10E6AF0   Length: 0xF0
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
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar5 * 16) == DAT_181d556d0)
                {
                  puVar3 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar5 * 16)
                            * 16 + 0x348 + lVar1);
                  goto LAB_1810e8398;
                }
                uVar5 = uVar5 + 1;
              } while (uVar5 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar3 = (uint64 *)FUN_1800914f0(plVar2,DAT_181d556d0,33);
        LAB_1810e8398:
                          // WARNING: Could not recover jumptable at 0x0001810e83ac. Too many branches
                          // WARNING: Treating indirect jump as call
            uVar4 = (*(code *)*puVar3)(plVar2,font,puVar3[1]);
            return uVar4;
          }
        }
        return false;
    }

    // Token : 0x60007AA
    // RVA   : 0x10E7ED0   Offset: 0x10E66D0   Length: 0x253
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
          FUN_180002970(34,DAT_181d556d0,lVar3);
        }
        uVar6 = 0;
        this.mSprite = 0;
        lVar3 = NGUITools.FindActive(DAT_181d66400);
        if (lVar3 != null) {
          iVar1 = *(int *)(lVar3 + 24);
          uVar7 = uVar6;
          if (0 < iVar1) {
            do {
              uVar8 = (uint32)uVar7;
              if (*(uint32 *)(lVar3 + 24) <= uVar8) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
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

    // Token : 0x60007AB
    // RVA   : 0x10E8740   Offset: 0x10E6F40   Length: 0x1F5
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
          lVar6 = il2cpp_internal(this.mAtlas,DAT_181d55650);
          if (lVar6 != null) {
            plVar7 = (int64 *)FUN_180002970(4,DAT_181d55650,lVar6);
          }
          cVar3 = Object.op_Inequality(plVar7,0,0);
          if (cVar3) {
            lVar6 = this.mSprite;
            if (lVar6 != null) {
              local_48 = 0;
              uStack_40 = 0;
              FUN_1809981e0(&local_48,lVar6.paddingRight,lVar6.width,
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
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x60007AC
    // RVA   : 0x10E7D70   Offset: 0x10E6570   Length: 0x150
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
              cVar2 = FUN_1816fd990(lVar1._items,sequence,0);
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
              FUN_181827900(this.mSymbols,lVar6,DAT_181d56c40);
              return lVar6;
            }
          }
        }
    }

    // Token : 0x60007AD
    // RVA   : 0x10E8130   Offset: 0x10E6930   Length: 0x1B6
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
                      if (sVar4 != sVar5) goto LAB_1810e82c0;
                      iVar7 = iVar7 + 1;
                    } while (iVar7 < iVar6);
                  }
                  UIFont.get_atlas(this,0);
                  cVar3 = BMSymbol.Validate();
                  if (cVar3) {
                    return lVar2;
                  }
                }
        LAB_1810e82c0:
                uVar10 = uVar10 + 1;
                lVar8 = lVar8 + 1;
                lVar9 = lVar9 + 8;
              } while (lVar8 < iVar1);
            }
          }
          return 0;
        }
    }

    // Token : 0x60007AE
    // RVA   : 0x10E7C60   Offset: 0x10E6460   Length: 0x48
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

    // Token : 0x60007AF
    // RVA   : 0x10E83E0   Offset: 0x10E6BE0   Length: 0x7F
    public virtual void RemoveSymbol(string sequence)
    {
        long lVar1;
        long lVar2;
        lVar1 = UIFont.GetSymbol(this,sequence,0,0);
        if (lVar1 != null) {
          lVar2 = UIFont.get_symbols(this,0);
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181801c10(lVar2,lVar1,DAT_181d56cc0);
        }
        UIFont.MarkAsChanged(this,0);
    }

    // Token : 0x60007B0
    // RVA   : 0x10E8460   Offset: 0x10E6C60   Length: 0x43
    public virtual void RenameSymbol(string before, string after)
    {
        long lVar1;
        lVar1 = UIFont.GetSymbol(this,before,0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 16) = after;
        }
        UIFont.MarkAsChanged(this,0);
    }

    // Token : 0x60007B1
    // RVA   : 0x10E8940   Offset: 0x10E7140   Length: 0x1D9
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
        cVar2 = FUN_180d6ca90(s,0);
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
              if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar8 * 16) == DAT_181d556d0) {
                puVar4 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x268 + lVar6);
                uVar5 = (*(code *)*puVar4)(plVar3,puVar4[1]);
                goto LAB_1810e8a56;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar6 + 0x12a));
          }
          puVar4 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d556d0,19);
          uVar5 = (*(code *)*puVar4)(plVar3,puVar4[1]);
        }
        LAB_1810e8a56:
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

    // Token : 0x60007B2
    // RVA   : 0x10E8B20   Offset: 0x10E7320   Length: 0xF2
    public void /*ctor*/()
    {
        ulong uVar1;
        ulong local_18;
        ulong uStack_10;
        local_18 = 0;
        uStack_10 = 0;
        FUN_1809981e0(&local_18,0,0,0x3f800000,0x3f800000,0);
        this.mUVRect = (uint32)local_18;
        *(uint32 *)(this + 36) = local_18._4_4_;
        *(uint32 *)(this + 40) = (uint32)uStack_10;
        *(uint32 *)(this + 44) = uStack_10._4_4_;
        this.mFont = new BMFont(0);
        uVar1 = il2cpp_internal(DAT_181d6c630);
        FUN_180f58a90(uVar1,DAT_181d56bc0);
        this.mSymbols = uVar1;
        this.mDynamicFontSize = 16;
        this.mPMA = 0xffffffffffffffff;
        FUN_18044ef50(this,0);
    }

}
