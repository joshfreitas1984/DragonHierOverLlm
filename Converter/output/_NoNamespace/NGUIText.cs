// ============================================================
// Type  : NGUIText
// Token : 0x2000087
// ============================================================

public class NGUIText
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400032F
    public static INGUIFont bitmapFont;

    // Token: 0x4000330
    public static Font dynamicFont;

    // Token: 0x4000331
    public static GlyphInfo glyph;

    // Token: 0x4000332
    public static int fontSize;

    // Token: 0x4000333
    public static float fontScale;

    // Token: 0x4000334
    public static float pixelDensity;

    // Token: 0x4000335
    public static FontStyle fontStyle;

    // Token: 0x4000336
    public static Alignment alignment;

    // Token: 0x4000337
    public static Color tint;

    // Token: 0x4000338
    public static int rectWidth;

    // Token: 0x4000339
    public static int rectHeight;

    // Token: 0x400033A
    public static int regionWidth;

    // Token: 0x400033B
    public static int regionHeight;

    // Token: 0x400033C
    public static int maxLines;

    // Token: 0x400033D
    public static bool gradient;

    // Token: 0x400033E
    public static Color gradientBottom;

    // Token: 0x400033F
    public static Color gradientTop;

    // Token: 0x4000340
    public static bool encoding;

    // Token: 0x4000341
    public static float spacingX;

    // Token: 0x4000342
    public static float spacingY;

    // Token: 0x4000343
    public static bool premultiply;

    // Token: 0x4000344
    public static SymbolStyle symbolStyle;

    // Token: 0x4000345
    public static int finalSize;

    // Token: 0x4000346
    public static float finalSpacingX;

    // Token: 0x4000347
    public static float finalLineHeight;

    // Token: 0x4000348
    public static float baseline;

    // Token: 0x4000349
    public static bool useSymbols;

    // Token: 0x400034A
    private static Color mInvisible;

    // Token: 0x400034B
    private static BetterList<Color> mColors;

    // Token: 0x400034C
    private static float mAlpha;

    // Token: 0x400034D
    private static CharacterInfo mTempChar;

    // Token: 0x400034E
    private static BetterList<float> mSizes;

    // Token: 0x400034F
    private static StringBuilder mSB;

    // Token: 0x4000350
    private static Color s_c0;

    // Token: 0x4000351
    private static Color s_c1;

    // Token: 0x4000352
    private const float sizeShrinkage;

    // Token: 0x4000353
    private static float[] mBoldOffset;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60003A1
    // RVA   : 0xE0AD00   Offset: 0xE0A100   Length: 0x5B
    public static bool get_isDynamic()
    {
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        return CONCAT71((int7)((uint64)pStatics >> 8),
                        NGUIText.bitmapFont == null);
    }

    // Token : 0x60003A2
    // RVA   : 0xE084B0   Offset: 0xE078B0   Length: 0x4B
    public static void Update()
    {
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        uint uVar6;
        int iVar7;
        int iVar8;
        uVar6 = Mathf.RoundToInt((float)NGUIText.fontSize /
                                  NGUIText.pixelDensity,0);
        NGUIText.finalSize = uVar6;
        lVar1 = pStatics;
        *(float *)(lVar1 + 140) = *(float *)(lVar1 + 120) * *(float *)(lVar1 + 28);
        lVar1 = pStatics;
        *(float *)(lVar1 + 144) =
             ((float)*(int *)(lVar1 + 24) + *(float *)(lVar1 + 124)) * *(float *)(lVar1 + 28);
        uVar2 = NGUIText.dynamicFont;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (!cVar4) {
          if (NGUIText.bitmapFont != null) goto LAB_180e08664;
        LAB_180e0868f:
          bVar9 = false;
        }
        else {
        LAB_180e08664:
          if (!NGUIText.encoding) goto LAB_180e0868f;
          bVar9 = NGUIText.symbolStyle != null;
        }
        NGUIText.useSymbols = bVar9;
        lVar1 = NGUIText.dynamicFont;
        bVar5 = Object.op_Inequality(lVar1,0,0);
        if ((param_1 & bVar5) == 0) {
          return;
        }
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar6 = 0;
        Font.RequestCharactersInTexture
                  (lVar1,")_-",NGUIText.finalSize,
                   NGUIText.fontStyle,0);
        lVar3 = pStatics;
        cVar4 = Font.GetCharacterInfo
                          (lVar1,41,lVar3 + 188,*(uint32 *)(lVar3 + 136),
                           CONCAT44(uVar6,*(uint32 *)(lVar3 + 36)),0);
        if (cVar4) {
          iVar7 = CharacterInfo.get_maxY(pStatics + 188,0);
          if ((float)iVar7 != 0.0) goto LAB_180e088ad;
        }
        uVar6 = 0;
        Font.RequestCharactersInTexture
                  (lVar1,"A",NGUIText.finalSize,
                   NGUIText.fontStyle,0);
        lVar3 = pStatics;
        cVar4 = Font.GetCharacterInfo
                          (lVar1,65,lVar3 + 188,*(uint32 *)(lVar3 + 136),
                           CONCAT44(uVar6,*(uint32 *)(lVar3 + 36)),0);
        if (!cVar4) {
          NGUIText.baseline = 0;
          return;
        }
        LAB_180e088ad:
        iVar7 = CharacterInfo.get_maxY(pStatics + 188,0);
        iVar8 = CharacterInfo.get_minY(pStatics + 188,0);
        uVar6 = FUN_18000d7c0((((float)NGUIText.finalSize - (float)iVar7
                               ) + (float)iVar8) * 0.5 + (float)iVar7);
        NGUIText.baseline = uVar6;
    }

    // Token : 0x60003A3
    // RVA   : 0xE08500   Offset: 0xE07900   Length: 0x4B3
    public static void Update(bool request)
    {
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        uint uVar6;
        int iVar7;
        int iVar8;
        uVar6 = Mathf.RoundToInt((float)NGUIText.fontSize /
                                  NGUIText.pixelDensity,0);
        NGUIText.finalSize = uVar6;
        lVar1 = pStatics;
        *(float *)(lVar1 + 140) = *(float *)(lVar1 + 120) * *(float *)(lVar1 + 28);
        lVar1 = pStatics;
        *(float *)(lVar1 + 144) =
             ((float)*(int *)(lVar1 + 24) + *(float *)(lVar1 + 124)) * *(float *)(lVar1 + 28);
        uVar2 = NGUIText.dynamicFont;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (!cVar4) {
          if (NGUIText.bitmapFont != null) goto LAB_180e08664;
        LAB_180e0868f:
          bVar9 = false;
        }
        else {
        LAB_180e08664:
          if (!NGUIText.encoding) goto LAB_180e0868f;
          bVar9 = NGUIText.symbolStyle != null;
        }
        NGUIText.useSymbols = bVar9;
        lVar1 = NGUIText.dynamicFont;
        bVar5 = Object.op_Inequality(lVar1,0,0);
        if ((request & bVar5) == 0) {
          return;
        }
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar6 = 0;
        Font.RequestCharactersInTexture
                  (lVar1,")_-",NGUIText.finalSize,
                   NGUIText.fontStyle,0);
        lVar3 = pStatics;
        cVar4 = Font.GetCharacterInfo
                          (lVar1,41,lVar3 + 188,*(uint32 *)(lVar3 + 136),
                           CONCAT44(uVar6,*(uint32 *)(lVar3 + 36)),0);
        if (cVar4) {
          iVar7 = CharacterInfo.get_maxY(pStatics + 188,0);
          if ((float)iVar7 != 0.0) goto LAB_180e088ad;
        }
        uVar6 = 0;
        Font.RequestCharactersInTexture
                  (lVar1,"A",NGUIText.finalSize,
                   NGUIText.fontStyle,0);
        lVar3 = pStatics;
        cVar4 = Font.GetCharacterInfo
                          (lVar1,65,lVar3 + 188,*(uint32 *)(lVar3 + 136),
                           CONCAT44(uVar6,*(uint32 *)(lVar3 + 36)),0);
        if (!cVar4) {
          NGUIText.baseline = 0;
          return;
        }
        LAB_180e088ad:
        iVar7 = CharacterInfo.get_maxY(pStatics + 188,0);
        iVar8 = CharacterInfo.get_minY(pStatics + 188,0);
        uVar6 = FUN_18000d7c0((((float)NGUIText.finalSize - (float)iVar7
                               ) + (float)iVar8) * 0.5 + (float)iVar7);
        NGUIText.baseline = uVar6;
    }

    // Token : 0x60003A4
    // RVA   : 0xE03530   Offset: 0xE02930   Length: 0x132
    public static void Prepare(string text)
    {
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        long lVar1;
        ulong uVar2;
        bool cVar3;
        lVar1 = NGUIText.mColors;
        if (lVar1 != null) {
          BetterList_1.Clear(lVar1,DAT_181da6238);
          uVar2 = NGUIText.dynamicFont;
          cVar3 = Object.op_Inequality(uVar2,0,0);
          if (cVar3) {
            lVar1 = pStatics;
            if (*(int64 *)(lVar1 + 8) == 0) throw; // [null/range check failed]
            Font.RequestCharactersInTexture
                      (*(int64 *)(lVar1 + 8),text,*(uint32 *)(lVar1 + 136),
                       *(uint32 *)(lVar1 + 36),0);
          }
          return;
        }
    }

    // Token : 0x60003A5
    // RVA   : 0xE01DC0   Offset: 0xE011C0   Length: 0xE1
    public static BMSymbol GetSymbol(string text, int index, int textLength)
    {
        ulong uVar1;
        if (NGUIText.bitmapFont == null) {
          return 0;
        }
        if (NGUIText.bitmapFont != null) {
          uVar1 = FUN_1800028c0(36,DAT_181d7a800,NGUIText.bitmapFont,text,index,
                                textLength);
          return uVar1;
        }
    }

    // Token : 0x60003A6
    // RVA   : 0xE01130   Offset: 0xE00530   Length: 0x294
    public static float GetGlyphWidth(int ch, int prev, float fontScale)
    {
        ulong uVar1;
        int iVar2;
        long lVar4;
        uint uVar5;
        uint uVar6;
        if (((*(byte *)((int64)DAT_181d8bc90 + 0x133) & 4) != 0) && ((int)DAT_181d8bc90[28] == 0)) {
          il2cpp_runtime_class_init();
        }
        if (*(int64 *)DAT_181d8bc90[23] == 0) {
          if (((*(byte *)((int64)DAT_181d8bc90 + 0x133) & 4) != 0) && ((int)DAT_181d8bc90[28] == 0))
          {
            il2cpp_runtime_class_init();
          }
          uVar1 = *(uint64 *)(DAT_181d8bc90[23] + 8);
          plVar3 = (int64 *)Object.op_Inequality(uVar1,0,0);
          if ((char)plVar3) {
            if (((*(byte *)((int64)DAT_181d8bc90 + 0x133) & 4) != 0) && ((int)DAT_181d8bc90[28] == 0)
               ) {
              il2cpp_runtime_class_init(DAT_181d8bc90);
            }
            lVar4 = DAT_181d8bc90[23];
            if (*(int64 *)(lVar4 + 8) == 0) {
        LAB_180e013bf:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar3 = (int64 *)
                     Font.GetCharacterInfo
                               (*(int64 *)(lVar4 + 8),ch & 0xffff,lVar4 + 188,
                                *(uint32 *)(lVar4 + 136),*(uint32 *)(lVar4 + 36),0);
            if ((char)plVar3) {
              if (((*(byte *)((int64)DAT_181d8bc90 + 0x133) & 4) != 0) &&
                 ((int)DAT_181d8bc90[28] == 0)) {
                il2cpp_runtime_class_init();
              }
              CharacterInfo.get_advance(DAT_181d8bc90[23] + 188,0);
              plVar3 = DAT_181d8bc90;
            }
          }
        }
        else {
          uVar6 = 32;
          if (ch != 0x2009) {
            uVar6 = ch;
          }
          if (((*(byte *)((int64)DAT_181d8bc90 + 0x133) & 4) != 0) && ((int)DAT_181d8bc90[28] == 0))
          {
            il2cpp_runtime_class_init();
          }
          plVar3 = (int64 *)DAT_181d8bc90[23];
          if (*plVar3 != 0) {
            if (((*(byte *)((int64)DAT_181d8bc90 + 0x133) & 4) != 0) && ((int)DAT_181d8bc90[28] == 0)
               ) {
              il2cpp_runtime_class_init();
            }
            if ((*(int64 *)DAT_181d8bc90[23] == 0) ||
               (lVar4 = FUN_180002970(0,DAT_181d7a800)) == null) goto LAB_180e013bf;
            lVar4 = BMFont.GetGlyph(lVar4,uVar6,0);
            plVar3 = (int64 *)0;
            if (lVar4 != null) {
              uVar6 = *(uint32 *)(lVar4 + 44);
              if (prev == null) {
                plVar3 = (int64 *)(uint64)uVar6;
              }
              else {
                iVar2 = BMGlyph.GetKerning(lVar4,prev,0);
                uVar5 = (int)uVar6 >> 1;
                if (ch != 0x2009) {
                  uVar5 = uVar6;
                }
                plVar3 = (int64 *)(uint64)(iVar2 + uVar5);
              }
            }
          }
        }
        return plVar3;
    }

    // Token : 0x60003A7
    // RVA   : 0xE013D0   Offset: 0xE007D0   Length: 0x9E8
    public static GlyphInfo GetGlyph(int ch, int prev, float fontScale)
    {
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        uint uVar8;
        uint local_28;
        uint uStack_24;
        if (NGUIText.bitmapFont == null) {
          uVar5 = NGUIText.dynamicFont;
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (cVar2) {
            lVar6 = pStatics;
            if (*(int64 *)(lVar6 + 8) != 0) {
              cVar2 = Font.GetCharacterInfo
                                (*(int64 *)(lVar6 + 8),ch & 0xffff,lVar6 + 188,
                                 *(uint32 *)(lVar6 + 136),*(uint32 *)(lVar6 + 36),0);
              if (!cVar2) {
                return 0;
              }
              lVar6 = NGUIText.glyph;
              if (lVar6 != null) {
                iVar3 = CharacterInfo.get_minX(pStatics + 188,0);
                lVar6.v0 = (float)iVar3;
                lVar6 = NGUIText.glyph;
                if (lVar6 != null) {
                  iVar3 = CharacterInfo.get_maxX(pStatics + 188,0);
                  lVar6.v1 = (float)iVar3;
                  lVar6 = NGUIText.glyph;
                  if (lVar6 != null) {
                    iVar3 = CharacterInfo.get_maxY(pStatics + 188,0);
                    *(float *)(lVar6 + 20) =
                         (float)iVar3 - NGUIText.baseline;
                    lVar6 = NGUIText.glyph;
                    if (lVar6 != null) {
                      iVar3 = CharacterInfo.get_minY(pStatics + 188,0);
                      *(float *)(lVar6 + 28) =
                           (float)iVar3 - NGUIText.baseline;
                      lVar6 = NGUIText.glyph;
                      uVar5 = CharacterInfo.get_uvTopLeft(pStatics + 188,0);
                      if (lVar6 != null) {
                        local_28 = (uint32)uVar5;
                        uStack_24 = (uint32)((uint64)uVar5 >> 32);
                        lVar6.u0 = local_28;
                        *(uint32 *)(lVar6 + 36) = uStack_24;
                        lVar6 = NGUIText.glyph;
                        uVar5 = FUN_180456fe0(pStatics + 188,0);
                        if (lVar6 != null) {
                          local_28 = (uint32)uVar5;
                          uStack_24 = (uint32)((uint64)uVar5 >> 32);
                          lVar6.u1 = local_28;
                          *(uint32 *)(lVar6 + 44) = uStack_24;
                          lVar6 = NGUIText.glyph;
                          uVar5 = CharacterInfo.get_uvBottomRight
                                            (pStatics + 188,0);
                          if (lVar6 != null) {
                            local_28 = (uint32)uVar5;
                            uStack_24 = (uint32)((uint64)uVar5 >> 32);
                            lVar6.u2 = local_28;
                            *(uint32 *)(lVar6 + 52) = uStack_24;
                            lVar6 = NGUIText.glyph;
                            uVar5 = CharacterInfo.get_uvTopRight
                                              (pStatics + 188,0);
                            if (lVar6 != null) {
                              local_28 = (uint32)uVar5;
                              uStack_24 = (uint32)((uint64)uVar5 >> 32);
                              lVar6.u3 = local_28;
                              *(uint32 *)(lVar6 + 60) = uStack_24;
                              lVar6 = NGUIText.glyph;
                              iVar3 = CharacterInfo.get_advance
                                                (pStatics + 188,0);
                              if (lVar6 != null) {
                                lVar6.advance = (float)iVar3;
                                lVar6 = NGUIText.glyph;
                                if (lVar6 != null) {
                                  lVar6.channel = 0;
                                  lVar6 = NGUIText.glyph;
                                  if (lVar6 != null) {
                                    uVar8 = FUN_18000d7c0();
                                    lVar6.v0 = uVar8;
                                    lVar6 = NGUIText.glyph;
                                    if (lVar6 != null) {
                                      uVar8 = FUN_18000d7c0();
                                      *(uint32 *)(lVar6 + 20) = uVar8;
                                      lVar6 = NGUIText.glyph;
                                      if (lVar6 != null) {
                                        uVar8 = FUN_18000d7c0();
                                        lVar6.v1 = uVar8;
                                        lVar6 = NGUIText.glyph;
                                        if (lVar6 != null) {
                                          uVar8 = FUN_18000d7c0();
                                          *(uint32 *)(lVar6 + 28) = uVar8;
                                          fontScale = fontScale * *(float *)(*(int64 *)
                                                                          (DAT_181d8bc90 + 184) + 32);
                                          if (fontScale == 1.0) {
        LAB_180e0191c:
                                            return *(uint64 *)
                                                    (pStatics + 16);
                                          }
                                          lVar6 = *(int64 *)
                                                   (pStatics + 16);
                                          if (lVar6 != null) {
                                            lVar6.v0 = lVar6.v0 * fontScale;
                                            *(float *)(lVar6 + 20) = *(float *)(lVar6 + 20) * fontScale;
                                            lVar6 = *(int64 *)
                                                     (pStatics + 16);
                                            if (lVar6 != null) {
                                              lVar6.v1 =
                                                   lVar6.v1 * fontScale;
                                              *(float *)(lVar6 + 28) =
                                                   *(float *)(lVar6 + 28) * fontScale;
                                              lVar6 = *(int64 *)
                                                       (pStatics + 16);
                                              if (lVar6 != null) {
                                                lVar6.advance =
                                                     fontScale * lVar6.advance;
                                                goto LAB_180e0191c;
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
                      }
                    }
                  }
                }
              }
            }
        LAB_180e01db3:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        else {
          uVar7 = 32;
          if (ch != 0x2009) {
            uVar7 = ch;
          }
          if (NGUIText.bitmapFont != null) {
            if ((NGUIText.bitmapFont != null) &&
               (lVar6 = FUN_180002970(0,DAT_181d7a800)) != null) {
              lVar6 = BMFont.GetGlyph(lVar6,uVar7,0);
              if (lVar6 == null) {
                return 0;
              }
              if (prev == null) {
                iVar3 = 0;
              }
              else {
                iVar3 = BMGlyph.GetKerning(lVar6,prev,0);
              }
              lVar1 = NGUIText.glyph;
              if (lVar1 != null) {
                iVar4 = *(int *)(lVar6 + 36);
                if (prev != null) {
                  iVar4 = iVar4 + iVar3;
                }
                lVar1.v0 = (float)iVar4;
                lVar1 = NGUIText.glyph;
                if (lVar1 != null) {
                  *(float *)(lVar1 + 28) = (float)-lVar6.u1;
                  lVar1 = NGUIText.glyph;
                  if (lVar1 != null) {
                    lVar1.v1 = (float)*(int *)(lVar6 + 28) + lVar1.v0;
                    lVar1 = NGUIText.glyph;
                    if (lVar1 != null) {
                      *(float *)(lVar1 + 20) = *(float *)(lVar1 + 28) - (float)lVar6.u0;
                      lVar1 = NGUIText.glyph;
                      if (lVar1 != null) {
                        lVar1.u0 = (float)*(int *)(lVar6 + 20);
                        lVar1 = NGUIText.glyph;
                        if (lVar1 != null) {
                          *(float *)(lVar1 + 36) =
                               (float)(lVar6.u0 + lVar6.v1);
                          lVar1 = NGUIText.glyph;
                          if (lVar1 != null) {
                            lVar1.u2 =
                                 (float)(*(int *)(lVar6 + 20) + *(int *)(lVar6 + 28));
                            lVar1 = NGUIText.glyph;
                            if (lVar1 != null) {
                              *(float *)(lVar1 + 52) = (float)lVar6.v1;
                              lVar1 = NGUIText.glyph;
                              if (lVar1 != null) {
                                lVar1.u1 = lVar1.u0;
                                lVar1 = NGUIText.glyph;
                                if (lVar1 != null) {
                                  *(uint32 *)(lVar1 + 44) = *(uint32 *)(lVar1 + 52);
                                  lVar1 = NGUIText.glyph;
                                  if (lVar1 != null) {
                                    lVar1.u3 = lVar1.u2;
                                    lVar1 = NGUIText.glyph;
                                    if (lVar1 != null) {
                                      *(uint32 *)(lVar1 + 60) = *(uint32 *)(lVar1 + 36);
                                      iVar4 = *(int *)(lVar6 + 44) >> 1;
                                      if (ch != 0x2009) {
                                        iVar4 = *(int *)(lVar6 + 44);
                                      }
                                      lVar1 = NGUIText.glyph;
                                      if (lVar1 != null) {
                                        lVar1.advance = (float)(iVar4 + iVar3);
                                        lVar1 = NGUIText.glyph;
                                        if (lVar1 != null) {
                                          lVar1.channel = lVar6.u2;
                                          if (fontScale == 1.0) {
        LAB_180e01d62:
                                            return *(uint64 *)
                                                    (pStatics + 16);
                                          }
                                          lVar6 = *(int64 *)
                                                   (pStatics + 16);
                                          if (lVar6 != null) {
                                            lVar6.v0 = lVar6.v0 * fontScale;
                                            *(float *)(lVar6 + 20) = *(float *)(lVar6 + 20) * fontScale;
                                            lVar6 = *(int64 *)
                                                     (pStatics + 16);
                                            if (lVar6 != null) {
                                              lVar6.v1 =
                                                   lVar6.v1 * fontScale;
                                              *(float *)(lVar6 + 28) =
                                                   *(float *)(lVar6 + 28) * fontScale;
                                              lVar6 = *(int64 *)
                                                       (pStatics + 16);
                                              if (lVar6 != null) {
                                                lVar6.advance =
                                                     fontScale * lVar6.advance;
                                                goto LAB_180e01d62;
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
                      }
                    }
                  }
                }
              }
            }
            goto LAB_180e01db3;
          }
        }
        return 0;
    }

    // Token : 0x60003A8
    // RVA   : 0xE02290   Offset: 0xE01690   Length: 0x76
    public static float ParseAlpha(string text, int index)
    {
        ushort uVar1;
        int iVar2;
        uint uVar3;
        if (text != null) {
          uVar1 = String.get_Chars(text,index + 1,0);
          iVar2 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(text,index + 2,0);
          uVar3 = NGUIMath.HexToDecimal(uVar1,0);
          Mathf.Clamp01((float)(int)(iVar2 << 4 | uVar3) / 255.0,0);
          return;
        }
    }

    // Token : 0x60003A9
    // RVA   : 0xE02620   Offset: 0xE01A20   Length: 0x7E
    public static Color ParseColor(string text, int offset)
    {
        ulong uVar1;
        byte[] local_18 = new byte[16];
        puVar2 = (uint64 *)NGUIText.ParseColor24(local_18,offset,param_3,0);
        uVar1 = puVar2[1];
        *text = *puVar2;
        text[1] = uVar1;
        return text;
    }

    // Token : 0x60003AA
    // RVA   : 0xE02310   Offset: 0xE01710   Length: 0x155
    public static Color ParseColor24(string text, int offset)
    {
        ushort uVar1;
        int iVar2;
        uint uVar3;
        int iVar4;
        uint uVar5;
        int iVar6;
        uint uVar7;
        if (offset != null) {
          uVar1 = String.get_Chars(offset,param_3,0);
          iVar2 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 1,0);
          uVar3 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 2,0);
          iVar4 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 3,0);
          uVar5 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 4,0);
          iVar6 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 5,0);
          uVar7 = NGUIMath.HexToDecimal(uVar1,0);
          *text = 0;
          text[1] = 0;
          Color.ctor(text,(float)(int)(iVar2 << 4 | uVar3) * 0.003921569,
                      (float)(int)(iVar4 << 4 | uVar5) * 0.003921569,
                      (float)(int)(uVar7 | iVar6 << 4) * 0.003921569,0);
          return text;
        }
    }

    // Token : 0x60003AB
    // RVA   : 0xE02470   Offset: 0xE01870   Length: 0x1AE
    public static Color ParseColor32(string text, int offset)
    {
        ushort uVar1;
        int iVar2;
        uint uVar3;
        int iVar4;
        uint uVar5;
        int iVar6;
        uint uVar7;
        int iVar8;
        uint uVar9;
        if (offset != null) {
          uVar1 = String.get_Chars(offset,param_3,0);
          iVar2 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 1,0);
          uVar3 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 2,0);
          iVar4 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 3,0);
          uVar5 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 4,0);
          iVar6 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 5,0);
          uVar7 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 6,0);
          iVar8 = NGUIMath.HexToDecimal(uVar1,0);
          uVar1 = String.get_Chars(offset,param_3 + 7,0);
          uVar9 = NGUIMath.HexToDecimal(uVar1,0);
          *text = 0;
          text[1] = 0;
          FUN_1809dc910(text,(float)(int)(iVar2 << 4 | uVar3) * 0.003921569,
                        (float)(int)(iVar4 << 4 | uVar5) * 0.003921569,
                        (float)(int)(iVar6 << 4 | uVar7) * 0.003921569,
                        (float)(int)(uVar9 | iVar8 << 4) * 0.003921569,0);
          return text;
        }
    }

    // Token : 0x60003AC
    // RVA   : 0xE00C30   Offset: 0xE00030   Length: 0x5D
    public static string EncodeColor(Color c)
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5ce0,5);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (("[c][" != 0) &&
           (lVar2 = il2cpp_internal("[c][",*(uint64 *)(*plVar1 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        lVar2 = "[c][";
        if ((int)plVar1[3] == 0) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[4] = "[c][";
        il2cpp_internal(plVar1 + 4,lVar2);
        local_18 = *param_2;
        uStack_14 = param_2[1];
        uStack_10 = param_2[2];
        uStack_c = param_2[3];
        lVar2 = NGUIText.EncodeColor24(&local_18,0);
        if ((lVar2 != null) &&
           (lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        if (*(uint32 *)(plVar1 + 3) < 2) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[5] = lVar2;
        il2cpp_internal(plVar1 + 5,lVar2);
        if (("]" != 0) &&
           (lVar2 = il2cpp_internal("]",*(uint64 *)(*plVar1 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        lVar2 = "]";
        if (*(uint32 *)(plVar1 + 3) < 3) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[6] = "]";
        il2cpp_internal(plVar1 + 6,lVar2);
        if ((c != null) &&
           (lVar2 = il2cpp_internal(c,*(uint64 *)(*plVar1 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        if (*(uint32 *)(plVar1 + 3) < 4) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[7] = c;
        il2cpp_internal(plVar1 + 7,c);
        if (("[-][/c]" != 0) &&
           (lVar2 = il2cpp_internal("[-][/c]",*(uint64 *)(*plVar1 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        lVar2 = "[-][/c]";
        if (*(uint32 *)(plVar1 + 3) < 5) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[8] = "[-][/c]";
        il2cpp_internal(plVar1 + 8,lVar2);
        String.Concat(plVar1,0);
    }

    // Token : 0x60003AD
    // RVA   : 0xE00980   Offset: 0xDFFD80   Length: 0x2A9
    public static string EncodeColor(string text, Color c)
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5ce0,5);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (("[c][" != 0) &&
           (lVar2 = il2cpp_internal("[c][",*(uint64 *)(*plVar1 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        lVar2 = "[c][";
        if ((int)plVar1[3] == 0) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[4] = "[c][";
        il2cpp_internal(plVar1 + 4,lVar2);
        local_18 = *c;
        uStack_14 = c[1];
        uStack_10 = c[2];
        uStack_c = c[3];
        lVar2 = NGUIText.EncodeColor24(&local_18,0);
        if ((lVar2 != null) &&
           (lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        if (*(uint32 *)(plVar1 + 3) < 2) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[5] = lVar2;
        il2cpp_internal(plVar1 + 5,lVar2);
        if (("]" != 0) &&
           (lVar2 = il2cpp_internal("]",*(uint64 *)(*plVar1 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        lVar2 = "]";
        if (*(uint32 *)(plVar1 + 3) < 3) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[6] = "]";
        il2cpp_internal(plVar1 + 6,lVar2);
        if ((text != null) &&
           (lVar2 = il2cpp_internal(text,*(uint64 *)(*plVar1 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        if (*(uint32 *)(plVar1 + 3) < 4) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[7] = text;
        il2cpp_internal(plVar1 + 7,text);
        if (("[-][/c]" != 0) &&
           (lVar2 = il2cpp_internal("[-][/c]",*(uint64 *)(*plVar1 + 64))) == null) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        lVar2 = "[-][/c]";
        if (*(uint32 *)(plVar1 + 3) < 5) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[8] = "[-][/c]";
        il2cpp_internal(plVar1 + 8,lVar2);
        String.Concat(plVar1,0);
    }

    // Token : 0x60003AE
    // RVA   : 0xE00760   Offset: 0xDFFB60   Length: 0x69
    public static string EncodeAlpha(float a)
    {
        uint uVar1;
        uint[] local_res8 = new uint[8];
        uVar1 = Mathf.RoundToInt(a * 255.0,0);
        local_res8[0] = Mathf.Clamp(uVar1,0,255,0);
        local_res8[0] = local_res8[0] & 255;
        Int32.ToString(local_res8,"X2",0);
    }

    // Token : 0x60003AF
    // RVA   : 0xE007D0   Offset: 0xDFFBD0   Length: 0xDD
    public static string EncodeColor24(Color c)
    {
        float fVar1;
        float fVar2;
        float fVar3;
        int iVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        uint[] local_res8 = new uint[2];
        fVar1 = c[1];
        fVar2 = c[2];
        fVar3 = c[3];
        iVar4 = Mathf.RoundToInt(*c * 255.0,0);
        uVar5 = Mathf.RoundToInt(fVar1 * 255.0,0);
        uVar6 = Mathf.RoundToInt(fVar2 * 255.0,0);
        uVar7 = Mathf.RoundToInt(fVar3 * 255.0,0);
        local_res8[0] = ((int)(uVar7 | (iVar4 << 8 | uVar5) << 16) >> 8 | uVar6) & 0xffffff;
        local_res8[0] = local_res8[0] & 0xffffff;
        Int32.ToString(local_res8,"X6",0);
    }

    // Token : 0x60003B0
    // RVA   : 0xE008B0   Offset: 0xDFFCB0   Length: 0xCB
    public static string EncodeColor32(Color c)
    {
        float fVar1;
        float fVar2;
        float fVar3;
        int iVar4;
        uint uVar5;
        uint uVar6;
        uint[] local_res8 = new uint[2];
        fVar1 = c[1];
        fVar2 = c[2];
        fVar3 = c[3];
        iVar4 = Mathf.RoundToInt(*c * 255.0,0);
        uVar5 = Mathf.RoundToInt(fVar1 * 255.0,0);
        uVar6 = Mathf.RoundToInt(fVar2 * 255.0,0);
        local_res8[0] = Mathf.RoundToInt(fVar3 * 255.0,0);
        local_res8[0] = local_res8[0] | ((iVar4 << 8 | uVar5) << 8 | uVar6) << 8;
        Int32.ToString(local_res8,"X8",0);
    }

    // Token : 0x60003B1
    // RVA   : 0xE03440   Offset: 0xE02840   Length: 0xE1
    public static bool ParseSymbol(string text, ref int index)
    {
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        uint64
        NGUIText.ParseSymbol
                (int64 text,int *index,int64 param_3,char param_4,uint32 *param_5,
                uint8 *param_6,uint8 *param_7,uint8 *param_8,uint8 *param_9,
                uint8 *param_10)
        {
        uint8 auVar1 [16];
        int iVar2;
        uint8 *puVar3;
        char cVar4;
        short sVar5;
        uint16 uVar6;
        uint16 uVar7;
        uint32 uVar8;
        int iVar9;
        uint32 uVar10;
        int64 lVar11;
        uint8 (*pauVar12) [16];
        uint64 uVar13;
        uint64 uVar14;
        float *pfVar15;
        int64 lVar16;
        uint64 *puVar17;
        uint8 auVar18 [16];
        uint8 auVar19 [16];
        uint8 auVar20 [16];
        uint8 auVar21 [16];
        uint8 auVar22 [16];
        uint8 auVar23 [16];
        uint8 auVar24 [16];
        float fVar25;
        float fVar26;
        float fVar27;
        float fVar28;
        uint32 local_res8 [2];
        uint8 local_98 [16];
        uint64 local_88;
        uint64 uStack_80;
        uint8 local_78 [64];
        if (text == null) goto LAB_180e0341c;
        iVar9 = *(int *)(text + 16);
        if (iVar9 < *index + 3) {
          return false;
        }
        sVar5 = String.get_Chars(text,*index,0);
        if (sVar5 != 91) {
          return false;
        }
        sVar5 = String.get_Chars(text,*index + 2,0);
        if (sVar5 == 93) {
          sVar5 = String.get_Chars(text,*index + 1,0);
          if (sVar5 == 45) {
            if ((param_3 != 0) && (1 < *(int *)(param_3 + 24))) {
              BetterList_1.RemoveAt(param_3,*(int *)(param_3 + 24) + -1,DAT_181da62b8);
            }
            goto LAB_180e02bc8;
          }
          lVar11 = String.Substring(text,*index,3);
          if (lVar11 != null) {
            uVar8 = PrivateImplementationDetails.ComputeStringHash(lVar11,0);
            puVar3 = param_10;
            if (uVar8 < 0x7affcd23) {
              if (uVar8 < 0x76d678d0) {
                if (uVar8 == 0x76bf1f80) {
                  cVar4 = FUN_18171e540(lVar11,"[u]",0);
                  puVar3 = param_8;
                }
                else {
                  if (uVar8 != 0x76d678cf) goto LAB_180e02952;
                  cVar4 = FUN_18171e540(lVar11,"[b]",0);
                  puVar3 = param_6;
                }
              }
              else if (uVar8 == 0x77195ebc) {
                cVar4 = FUN_18171e540(lVar11,"[I]",0);
                puVar3 = param_7;
              }
              else if (uVar8 == 0x7ad8bdb2) {
                cVar4 = FUN_18171e540(lVar11,"[c]",0);
              }
              else {
                if (uVar8 != 0x7affcd22) goto LAB_180e02952;
                cVar4 = FUN_18171e540(lVar11,"[S]",0);
                puVar3 = param_9;
              }
            }
            else if (uVar8 < 0xb70f3621) {
              if (uVar8 == 0xb6ca119c) {
                cVar4 = FUN_18171e540(lVar11,"[i]",0);
                puVar3 = param_7;
              }
              else {
                if (uVar8 != 0xb70f3620) goto LAB_180e02952;
                cVar4 = FUN_18171e540(lVar11,"[U]",0);
                puVar3 = param_8;
              }
            }
            else if (uVar8 == 0xb724fc6f) {
              cVar4 = FUN_18171e540(lVar11,"[B]",0);
              puVar3 = param_6;
            }
            else if (uVar8 == 0xbab08002) {
              cVar4 = FUN_18171e540(lVar11,"[s]",0);
              puVar3 = param_9;
            }
            else {
              if (uVar8 != 0xbb274152) goto LAB_180e02952;
              cVar4 = FUN_18171e540(lVar11,"[C]",0);
            }
            if (cVar4) {
              *puVar3 = 1;
        LAB_180e02bc8:
              *index = *index + 3;
              return true;
            }
          }
        }
        LAB_180e02952:
        if (iVar9 < *index + 4) {
          return false;
        }
        sVar5 = String.get_Chars(text,*index + 3,0);
        if (sVar5 == 93) {
          lVar11 = String.Substring(text,*index,4);
          if (lVar11 != null) {
            uVar8 = PrivateImplementationDetails.ComputeStringHash(lVar11,0);
            if (uVar8 < 0x258a062a) {
              if (uVar8 < 0x21676d9c) {
                if (uVar8 == 0x213ecb2b) {
                  cVar4 = FUN_18171e540(lVar11,"[/S]",0);
        joined_r0x000180e02e3f:
                  if (cVar4) {
                    *param_9 = 0;
                    *index = *index + 4;
                    return true;
                  }
                }
                else if (uVar8 == 0x21676d9b) {
                  cVar4 = FUN_18171e540(lVar11,"[/c]",0);
                  goto joined_r0x000180e02e74;
                }
              }
              else {
                if (uVar8 == 0x2558695d) {
                  cVar4 = FUN_18171e540(lVar11,"[/i]",0);
                  goto joined_r0x000180e02da8;
                }
                if (uVar8 == 0x2569b27e) {
                  cVar4 = FUN_18171e540(lVar11,"[/b]",0);
                  goto joined_r0x000180e02dd9;
                }
                if (uVar8 == 0x258a0629) {
                  cVar4 = FUN_18171e540(lVar11,"[/u]",0);
                  goto joined_r0x000180e02e0e;
                }
              }
            }
            else if (uVar8 < 0x618ee1cc) {
              if (uVar8 == 0x6118207b) {
                cVar4 = FUN_18171e540(lVar11,"[/C]",0);
        joined_r0x000180e02e74:
                if (cVar4) {
                  *param_10 = 0;
                  *index = *index + 4;
                  return true;
                }
              }
              else if (uVar8 == 0x618ee1cb) {
                cVar4 = FUN_18171e540(lVar11,"[/s]",0);
                goto joined_r0x000180e02e3f;
              }
            }
            else if (uVar8 == 0x65091c3d) {
              cVar4 = FUN_18171e540(lVar11,"[/I]",0);
        joined_r0x000180e02da8:
              if (cVar4) {
                *param_7 = 0;
                *index = *index + 4;
                return true;
              }
            }
            else if (uVar8 == 0x651a655e) {
              cVar4 = FUN_18171e540(lVar11,"[/B]",0);
        joined_r0x000180e02dd9:
              if (cVar4) {
                *param_6 = 0;
                *index = *index + 4;
                return true;
              }
            }
            else if (uVar8 == 0x653ab909) {
              cVar4 = FUN_18171e540(lVar11,"[/U]",0);
        joined_r0x000180e02e0e:
              if (cVar4) {
                *param_8 = 0;
                *index = *index + 4;
                return true;
              }
            }
          }
          uVar6 = String.get_Chars(text,*index + 1,0);
          uVar7 = String.get_Chars(text,*index + 2,0);
          if ((((uint16)(uVar6 - 48) < 10) || ((uint16)(uVar6 - 97) < 6)) ||
             ((64 < uVar6 && (uVar6 < 71)))) {
            lVar11 = DAT_181d8bc90;
            if ((((uint16)(uVar7 - 48) < 10) || ((uint16)(uVar7 - 97) < 6)) ||
               ((64 < uVar7 && (uVar7 < 71)))) {
              iVar9 = NGUIMath.HexToDecimal(uVar6,0);
              uVar8 = NGUIMath.HexToDecimal(uVar7,0);
              if (((*(byte *)(lVar11 + 0x133) & 4) != 0) && (*(int *)(lVar11 + 224) == 0)) {
                il2cpp_runtime_class_init(lVar11);
                lVar11 = DAT_181d8bc90;
              }
              *(float *)(*(int64 *)(lVar11 + 184) + 184) = (float)(int)(iVar9 << 4 | uVar8) / 255.0;
              *index = *index + 4;
              return true;
            }
          }
        }
        if (*index + 5 <= iVar9) {
          sVar5 = String.get_Chars(text,*index + 4,0);
          if ((sVar5 == 93) && (lVar11 = String.Substring(text,*index,5)) != null) {
            cVar4 = FUN_18171e540(lVar11,"[sub]",0);
            if ((cVar4) || (cVar4 = FUN_18171e540(lVar11,"[SUB]",0), cVar4)) {
              *param_5 = 1;
              *index = *index + 5;
              return true;
            }
            cVar4 = FUN_18171e540(lVar11,"[sup]",0);
            if ((cVar4) || (cVar4 = FUN_18171e540(lVar11,"[SUP]",0), cVar4)) {
              *param_5 = 2;
              *index = *index + 5;
              return true;
            }
          }
          if (iVar9 < *index + 6) {
            return false;
          }
          sVar5 = String.get_Chars(text,*index + 5,0);
          if ((sVar5 == 93) && (lVar11 = String.Substring(text,*index,6)) != null) {
            cVar4 = FUN_18171e540(lVar11,"[/sub]",0);
            if ((cVar4) ||
               (((cVar4 = FUN_18171e540(lVar11,"[/SUB]",0), cVar4 ||
                 (cVar4 = FUN_18171e540(lVar11,"[/sup]",0), cVar4)) ||
                (cVar4 = FUN_18171e540(lVar11,"[/SUP]",0), cVar4)))) {
              *param_5 = 0;
              *index = *index + 6;
              return true;
            }
            cVar4 = FUN_18171e540(lVar11,"[/url]",0);
            if ((cVar4) || (cVar4 = FUN_18171e540(lVar11,"[/URL]",0), cVar4)) {
              *index = *index + 6;
              return true;
            }
          }
          sVar5 = String.get_Chars(text,*index + 1,0);
          if (((sVar5 == 117) && (sVar5 = String.get_Chars(text,*index + 2,0), sVar5 == 114)) &&
             ((sVar5 = String.get_Chars(text,*index + 3,0), sVar5 == 108 &&
              (sVar5 = String.get_Chars(text,*index + 4,0), sVar5 == 61)))) {
            iVar9 = String.IndexOf(text,93,*index + 4,0);
            if (iVar9 == -1) {
              *index = *(int *)(text + 16);
            }
            else {
              *index = iVar9 + 1;
            }
            return true;
          }
          if (*index + 8 <= iVar9) {
            sVar5 = String.get_Chars(text,*index + 7,0);
            iVar2 = *index;
            if (sVar5 == 93) {
              pauVar12 = (uint8 (*) [16])NGUIText.ParseColor24(local_78,text,iVar2 + 1,0);
              local_88 = *(uint64 *)*pauVar12;
              uStack_80 = *(uint64 *)(*pauVar12 + 8);
              local_98 = *pauVar12;
              uVar13 = NGUIText.EncodeColor24(&local_88,0);
              lVar11 = String.Substring(text,*index + 1,6);
              if (lVar11 == null) {
        LAB_180e0341c:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar14 = String.ToUpper(lVar11,0);
              cVar4 = String.op_Inequality(uVar13,uVar14,0);
              auVar1 = local_98;
              if (!cVar4) {
                if ((param_3 != 0) && (0 < *(int *)(param_3 + 24))) {
                  lVar11 = *(int64 *)(param_3 + 16);
                  if (lVar11 == null) goto LAB_180e0341c;
                  lVar16 = (int64)*(int *)(param_3 + 24) + -1;
                  if (*(uint32 *)(lVar11 + 24) <= (uint32)lVar16) {
                    uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar13,0);
                  }
                  fVar25 = *(float *)(lVar11 + 44 + lVar16 * 16);
                  local_98._12_4_ = fVar25;
                  auVar18 = local_98;
                  if ((!param_4) || (fVar25 == 1.0)) {
                    local_98._0_8_ = auVar1._0_8_;
                    local_98._8_8_ = auVar18._8_8_;
                    local_88 = local_98._0_8_;
                    uStack_80 = local_98._8_8_;
                    local_98 = auVar18;
                  }
                  else {
                    local_88 = local_98._0_8_;
                    uStack_80 = local_98._8_8_;
                    local_98 = *(uint8 (*) [16])(pStatics + 156);
                    puVar17 = (uint64 *)Color.Lerp(local_78,local_98,&local_88,fVar25,0);
                    local_88 = *puVar17;
                    uStack_80 = puVar17[1];
                  }
                  BetterList_1.Add(param_3,&local_88,DAT_181da61b8);
                }
                *index = *index + 8;
                return true;
              }
            }
            else if ((iVar2 + 10 <= iVar9) &&
                    (sVar5 = String.get_Chars(text,iVar2 + 9,0), sVar5 == 93)) {
              iVar9 = *index;
              pauVar12 = (uint8 (*) [16])NGUIText.ParseColor32(&local_88,text,iVar9 + 1,0);
              auVar1 = *pauVar12;
              fVar25 = auVar1._0_4_;
              fVar26 = auVar1._4_4_;
              fVar27 = auVar1._8_4_;
              fVar28 = auVar1._12_4_;
              auVar18._4_12_ = auVar1._4_12_;
              auVar18._0_4_ = fVar25 * 255.0;
              iVar9 = Mathf.RoundToInt(auVar18._0_8_,0);
              auVar19._4_4_ = fVar26;
              auVar19._0_4_ = fVar26;
              auVar19._8_4_ = fVar26;
              auVar19._12_4_ = fVar26;
              auVar20._4_12_ = auVar19._4_12_;
              auVar20._0_4_ = fVar26 * 255.0;
              uVar8 = Mathf.RoundToInt(auVar20._0_8_,0);
              auVar21._4_4_ = fVar27;
              auVar21._0_4_ = fVar27;
              auVar21._8_4_ = fVar27;
              auVar21._12_4_ = fVar27;
              auVar22._4_12_ = auVar21._4_12_;
              auVar22._0_4_ = fVar27 * 255.0;
              uVar10 = Mathf.RoundToInt(auVar22._0_8_,0);
              auVar23._4_4_ = fVar28;
              auVar23._0_4_ = fVar28;
              auVar23._8_4_ = fVar28;
              auVar23._12_4_ = fVar28;
              auVar24._4_12_ = auVar23._4_12_;
              auVar24._0_4_ = fVar28 * 255.0;
              local_res8[0] = Mathf.RoundToInt(auVar24._0_8_,0);
              local_res8[0] = local_res8[0] | ((iVar9 << 8 | uVar8) << 8 | uVar10) << 8;
              uVar13 = Int32.ToString(local_res8,"X8",0);
              lVar11 = String.Substring(text,*index + 1,8);
              if (lVar11 == null) goto LAB_180e0341c;
              uVar14 = String.ToUpper(lVar11,0);
              cVar4 = String.op_Inequality(uVar13,uVar14,0);
              if (!cVar4) {
                if (param_3 != 0) {
                  if ((param_4) && (fVar28 != 1.0)) {
                    local_88 = NGUIText.mInvisible;
                    uStack_80 = *(uint64 *)(pStatics + 164);
                    local_98 = auVar1;
                    pfVar15 = (float *)Color.Lerp(local_78,&local_88,local_98,fVar28,0);
                    fVar25 = *pfVar15;
                    fVar26 = pfVar15[1];
                    fVar27 = pfVar15[2];
                    fVar28 = pfVar15[3];
                  }
                  local_88 = CONCAT44(fVar26,fVar25);
                  uStack_80 = CONCAT44(fVar28,fVar27);
                  BetterList_1.Add(param_3,&local_88,DAT_181da61b8);
                }
                *index = *index + 10;
                return true;
              }
            }
          }
        }
        return false;
    }

    // Token : 0x60003B2
    // RVA   : 0xE02240   Offset: 0xE01640   Length: 0x26
    public static bool IsHex(char ch)
    {
        uint64 FUN_180e02240(int ch)
        {
        uint3 uVar1;
        int iVar2;
        iVar2 = ch + -48;
        if ((9 < (uint16)iVar2) && (iVar2 = ch + -97, 5 < (uint16)iVar2)) {
          uVar1 = (uint3)((uint32)iVar2 >> 8);
          if ((uint16)ch < 65) {
            return (uint64)uVar1 << 8;
          }
          return (uint64)CONCAT31(uVar1,(uint16)ch < 71);
        }
        return CONCAT71((uint7)(uint3)((uint32)iVar2 >> 8),1);
    }

    // Token : 0x60003B3
    // RVA   : 0xE026A0   Offset: 0xE01AA0   Length: 0xD91
    public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
    {
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        uint64
        NGUIText.ParseSymbol
                (int64 text,int *index,int64 colors,char premultiply,uint32 *sub,
                uint8 *bold,uint8 *italic,uint8 *underline,uint8 *strike,
                uint8 *ignoreColor)
        {
        uint8 auVar1 [16];
        int iVar2;
        uint8 *puVar3;
        char cVar4;
        short sVar5;
        uint16 uVar6;
        uint16 uVar7;
        uint32 uVar8;
        int iVar9;
        uint32 uVar10;
        int64 lVar11;
        uint8 (*pauVar12) [16];
        uint64 uVar13;
        uint64 uVar14;
        float *pfVar15;
        int64 lVar16;
        uint64 *puVar17;
        uint8 auVar18 [16];
        uint8 auVar19 [16];
        uint8 auVar20 [16];
        uint8 auVar21 [16];
        uint8 auVar22 [16];
        uint8 auVar23 [16];
        uint8 auVar24 [16];
        float fVar25;
        float fVar26;
        float fVar27;
        float fVar28;
        uint32 local_res8 [2];
        uint8 local_98 [16];
        uint64 local_88;
        uint64 uStack_80;
        uint8 local_78 [64];
        if (text == null) goto LAB_180e0341c;
        iVar9 = *(int *)(text + 16);
        if (iVar9 < *index + 3) {
          return false;
        }
        sVar5 = String.get_Chars(text,*index,0);
        if (sVar5 != 91) {
          return false;
        }
        sVar5 = String.get_Chars(text,*index + 2,0);
        if (sVar5 == 93) {
          sVar5 = String.get_Chars(text,*index + 1,0);
          if (sVar5 == 45) {
            if ((colors != null) && (1 < *(int *)(colors + 24))) {
              BetterList_1.RemoveAt(colors,*(int *)(colors + 24) + -1,DAT_181da62b8);
            }
            goto LAB_180e02bc8;
          }
          lVar11 = String.Substring(text,*index,3);
          if (lVar11 != null) {
            uVar8 = PrivateImplementationDetails.ComputeStringHash(lVar11,0);
            puVar3 = ignoreColor;
            if (uVar8 < 0x7affcd23) {
              if (uVar8 < 0x76d678d0) {
                if (uVar8 == 0x76bf1f80) {
                  cVar4 = FUN_18171e540(lVar11,"[u]",0);
                  puVar3 = underline;
                }
                else {
                  if (uVar8 != 0x76d678cf) goto LAB_180e02952;
                  cVar4 = FUN_18171e540(lVar11,"[b]",0);
                  puVar3 = bold;
                }
              }
              else if (uVar8 == 0x77195ebc) {
                cVar4 = FUN_18171e540(lVar11,"[I]",0);
                puVar3 = italic;
              }
              else if (uVar8 == 0x7ad8bdb2) {
                cVar4 = FUN_18171e540(lVar11,"[c]",0);
              }
              else {
                if (uVar8 != 0x7affcd22) goto LAB_180e02952;
                cVar4 = FUN_18171e540(lVar11,"[S]",0);
                puVar3 = strike;
              }
            }
            else if (uVar8 < 0xb70f3621) {
              if (uVar8 == 0xb6ca119c) {
                cVar4 = FUN_18171e540(lVar11,"[i]",0);
                puVar3 = italic;
              }
              else {
                if (uVar8 != 0xb70f3620) goto LAB_180e02952;
                cVar4 = FUN_18171e540(lVar11,"[U]",0);
                puVar3 = underline;
              }
            }
            else if (uVar8 == 0xb724fc6f) {
              cVar4 = FUN_18171e540(lVar11,"[B]",0);
              puVar3 = bold;
            }
            else if (uVar8 == 0xbab08002) {
              cVar4 = FUN_18171e540(lVar11,"[s]",0);
              puVar3 = strike;
            }
            else {
              if (uVar8 != 0xbb274152) goto LAB_180e02952;
              cVar4 = FUN_18171e540(lVar11,"[C]",0);
            }
            if (cVar4) {
              *puVar3 = 1;
        LAB_180e02bc8:
              *index = *index + 3;
              return true;
            }
          }
        }
        LAB_180e02952:
        if (iVar9 < *index + 4) {
          return false;
        }
        sVar5 = String.get_Chars(text,*index + 3,0);
        if (sVar5 == 93) {
          lVar11 = String.Substring(text,*index,4);
          if (lVar11 != null) {
            uVar8 = PrivateImplementationDetails.ComputeStringHash(lVar11,0);
            if (uVar8 < 0x258a062a) {
              if (uVar8 < 0x21676d9c) {
                if (uVar8 == 0x213ecb2b) {
                  cVar4 = FUN_18171e540(lVar11,"[/S]",0);
        joined_r0x000180e02e3f:
                  if (cVar4) {
                    *strike = 0;
                    *index = *index + 4;
                    return true;
                  }
                }
                else if (uVar8 == 0x21676d9b) {
                  cVar4 = FUN_18171e540(lVar11,"[/c]",0);
                  goto joined_r0x000180e02e74;
                }
              }
              else {
                if (uVar8 == 0x2558695d) {
                  cVar4 = FUN_18171e540(lVar11,"[/i]",0);
                  goto joined_r0x000180e02da8;
                }
                if (uVar8 == 0x2569b27e) {
                  cVar4 = FUN_18171e540(lVar11,"[/b]",0);
                  goto joined_r0x000180e02dd9;
                }
                if (uVar8 == 0x258a0629) {
                  cVar4 = FUN_18171e540(lVar11,"[/u]",0);
                  goto joined_r0x000180e02e0e;
                }
              }
            }
            else if (uVar8 < 0x618ee1cc) {
              if (uVar8 == 0x6118207b) {
                cVar4 = FUN_18171e540(lVar11,"[/C]",0);
        joined_r0x000180e02e74:
                if (cVar4) {
                  *ignoreColor = 0;
                  *index = *index + 4;
                  return true;
                }
              }
              else if (uVar8 == 0x618ee1cb) {
                cVar4 = FUN_18171e540(lVar11,"[/s]",0);
                goto joined_r0x000180e02e3f;
              }
            }
            else if (uVar8 == 0x65091c3d) {
              cVar4 = FUN_18171e540(lVar11,"[/I]",0);
        joined_r0x000180e02da8:
              if (cVar4) {
                *italic = 0;
                *index = *index + 4;
                return true;
              }
            }
            else if (uVar8 == 0x651a655e) {
              cVar4 = FUN_18171e540(lVar11,"[/B]",0);
        joined_r0x000180e02dd9:
              if (cVar4) {
                *bold = 0;
                *index = *index + 4;
                return true;
              }
            }
            else if (uVar8 == 0x653ab909) {
              cVar4 = FUN_18171e540(lVar11,"[/U]",0);
        joined_r0x000180e02e0e:
              if (cVar4) {
                *underline = 0;
                *index = *index + 4;
                return true;
              }
            }
          }
          uVar6 = String.get_Chars(text,*index + 1,0);
          uVar7 = String.get_Chars(text,*index + 2,0);
          if ((((uint16)(uVar6 - 48) < 10) || ((uint16)(uVar6 - 97) < 6)) ||
             ((64 < uVar6 && (uVar6 < 71)))) {
            lVar11 = DAT_181d8bc90;
            if ((((uint16)(uVar7 - 48) < 10) || ((uint16)(uVar7 - 97) < 6)) ||
               ((64 < uVar7 && (uVar7 < 71)))) {
              iVar9 = NGUIMath.HexToDecimal(uVar6,0);
              uVar8 = NGUIMath.HexToDecimal(uVar7,0);
              if (((*(byte *)(lVar11 + 0x133) & 4) != 0) && (*(int *)(lVar11 + 224) == 0)) {
                il2cpp_runtime_class_init(lVar11);
                lVar11 = DAT_181d8bc90;
              }
              *(float *)(*(int64 *)(lVar11 + 184) + 184) = (float)(int)(iVar9 << 4 | uVar8) / 255.0;
              *index = *index + 4;
              return true;
            }
          }
        }
        if (*index + 5 <= iVar9) {
          sVar5 = String.get_Chars(text,*index + 4,0);
          if ((sVar5 == 93) && (lVar11 = String.Substring(text,*index,5)) != null) {
            cVar4 = FUN_18171e540(lVar11,"[sub]",0);
            if ((cVar4) || (cVar4 = FUN_18171e540(lVar11,"[SUB]",0), cVar4)) {
              *sub = 1;
              *index = *index + 5;
              return true;
            }
            cVar4 = FUN_18171e540(lVar11,"[sup]",0);
            if ((cVar4) || (cVar4 = FUN_18171e540(lVar11,"[SUP]",0), cVar4)) {
              *sub = 2;
              *index = *index + 5;
              return true;
            }
          }
          if (iVar9 < *index + 6) {
            return false;
          }
          sVar5 = String.get_Chars(text,*index + 5,0);
          if ((sVar5 == 93) && (lVar11 = String.Substring(text,*index,6)) != null) {
            cVar4 = FUN_18171e540(lVar11,"[/sub]",0);
            if ((cVar4) ||
               (((cVar4 = FUN_18171e540(lVar11,"[/SUB]",0), cVar4 ||
                 (cVar4 = FUN_18171e540(lVar11,"[/sup]",0), cVar4)) ||
                (cVar4 = FUN_18171e540(lVar11,"[/SUP]",0), cVar4)))) {
              *sub = 0;
              *index = *index + 6;
              return true;
            }
            cVar4 = FUN_18171e540(lVar11,"[/url]",0);
            if ((cVar4) || (cVar4 = FUN_18171e540(lVar11,"[/URL]",0), cVar4)) {
              *index = *index + 6;
              return true;
            }
          }
          sVar5 = String.get_Chars(text,*index + 1,0);
          if (((sVar5 == 117) && (sVar5 = String.get_Chars(text,*index + 2,0), sVar5 == 114)) &&
             ((sVar5 = String.get_Chars(text,*index + 3,0), sVar5 == 108 &&
              (sVar5 = String.get_Chars(text,*index + 4,0), sVar5 == 61)))) {
            iVar9 = String.IndexOf(text,93,*index + 4,0);
            if (iVar9 == -1) {
              *index = *(int *)(text + 16);
            }
            else {
              *index = iVar9 + 1;
            }
            return true;
          }
          if (*index + 8 <= iVar9) {
            sVar5 = String.get_Chars(text,*index + 7,0);
            iVar2 = *index;
            if (sVar5 == 93) {
              pauVar12 = (uint8 (*) [16])NGUIText.ParseColor24(local_78,text,iVar2 + 1,0);
              local_88 = *(uint64 *)*pauVar12;
              uStack_80 = *(uint64 *)(*pauVar12 + 8);
              local_98 = *pauVar12;
              uVar13 = NGUIText.EncodeColor24(&local_88,0);
              lVar11 = String.Substring(text,*index + 1,6);
              if (lVar11 == null) {
        LAB_180e0341c:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar14 = String.ToUpper(lVar11,0);
              cVar4 = String.op_Inequality(uVar13,uVar14,0);
              auVar1 = local_98;
              if (!cVar4) {
                if ((colors != null) && (0 < *(int *)(colors + 24))) {
                  lVar11 = *(int64 *)(colors + 16);
                  if (lVar11 == null) goto LAB_180e0341c;
                  lVar16 = (int64)*(int *)(colors + 24) + -1;
                  if (*(uint32 *)(lVar11 + 24) <= (uint32)lVar16) {
                    uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar13,0);
                  }
                  fVar25 = *(float *)(lVar11 + 44 + lVar16 * 16);
                  local_98._12_4_ = fVar25;
                  auVar18 = local_98;
                  if ((!premultiply) || (fVar25 == 1.0)) {
                    local_98._0_8_ = auVar1._0_8_;
                    local_98._8_8_ = auVar18._8_8_;
                    local_88 = local_98._0_8_;
                    uStack_80 = local_98._8_8_;
                    local_98 = auVar18;
                  }
                  else {
                    local_88 = local_98._0_8_;
                    uStack_80 = local_98._8_8_;
                    local_98 = *(uint8 (*) [16])(pStatics + 156);
                    puVar17 = (uint64 *)Color.Lerp(local_78,local_98,&local_88,fVar25,0);
                    local_88 = *puVar17;
                    uStack_80 = puVar17[1];
                  }
                  BetterList_1.Add(colors,&local_88,DAT_181da61b8);
                }
                *index = *index + 8;
                return true;
              }
            }
            else if ((iVar2 + 10 <= iVar9) &&
                    (sVar5 = String.get_Chars(text,iVar2 + 9,0), sVar5 == 93)) {
              iVar9 = *index;
              pauVar12 = (uint8 (*) [16])NGUIText.ParseColor32(&local_88,text,iVar9 + 1,0);
              auVar1 = *pauVar12;
              fVar25 = auVar1._0_4_;
              fVar26 = auVar1._4_4_;
              fVar27 = auVar1._8_4_;
              fVar28 = auVar1._12_4_;
              auVar18._4_12_ = auVar1._4_12_;
              auVar18._0_4_ = fVar25 * 255.0;
              iVar9 = Mathf.RoundToInt(auVar18._0_8_,0);
              auVar19._4_4_ = fVar26;
              auVar19._0_4_ = fVar26;
              auVar19._8_4_ = fVar26;
              auVar19._12_4_ = fVar26;
              auVar20._4_12_ = auVar19._4_12_;
              auVar20._0_4_ = fVar26 * 255.0;
              uVar8 = Mathf.RoundToInt(auVar20._0_8_,0);
              auVar21._4_4_ = fVar27;
              auVar21._0_4_ = fVar27;
              auVar21._8_4_ = fVar27;
              auVar21._12_4_ = fVar27;
              auVar22._4_12_ = auVar21._4_12_;
              auVar22._0_4_ = fVar27 * 255.0;
              uVar10 = Mathf.RoundToInt(auVar22._0_8_,0);
              auVar23._4_4_ = fVar28;
              auVar23._0_4_ = fVar28;
              auVar23._8_4_ = fVar28;
              auVar23._12_4_ = fVar28;
              auVar24._4_12_ = auVar23._4_12_;
              auVar24._0_4_ = fVar28 * 255.0;
              local_res8[0] = Mathf.RoundToInt(auVar24._0_8_,0);
              local_res8[0] = local_res8[0] | ((iVar9 << 8 | uVar8) << 8 | uVar10) << 8;
              uVar13 = Int32.ToString(local_res8,"X8",0);
              lVar11 = String.Substring(text,*index + 1,8);
              if (lVar11 == null) goto LAB_180e0341c;
              uVar14 = String.ToUpper(lVar11,0);
              cVar4 = String.op_Inequality(uVar13,uVar14,0);
              if (!cVar4) {
                if (colors != null) {
                  if ((premultiply) && (fVar28 != 1.0)) {
                    local_88 = NGUIText.mInvisible;
                    uStack_80 = *(uint64 *)(pStatics + 164);
                    local_98 = auVar1;
                    pfVar15 = (float *)Color.Lerp(local_78,&local_88,local_98,fVar28,0);
                    fVar25 = *pfVar15;
                    fVar26 = pfVar15[1];
                    fVar27 = pfVar15[2];
                    fVar28 = pfVar15[3];
                  }
                  local_88 = CONCAT44(fVar26,fVar25);
                  uStack_80 = CONCAT44(fVar28,fVar27);
                  BetterList_1.Add(colors,&local_88,DAT_181da61b8);
                }
                *index = *index + 10;
                return true;
              }
            }
          }
        }
        return false;
    }

    // Token : 0x60003B4
    // RVA   : 0xE08340   Offset: 0xE07740   Length: 0x160
    public static string StripSymbols(string text)
    {
        bool cVar1;
        int iVar3;
        int iVar4;
        byte[] local_res8 = new byte[8];
        byte[] local_res18 = new byte[8];
        byte[] local_res20 = new byte[8];
        byte local_28;
        byte[] local_27 = new byte[3];
        int[] local_24 = new int[3];
        if (text != null) {
          iVar4 = *(int *)(text + 16);
          iVar3 = 0;
          if (0 < iVar4) {
            do {
              sVar2 = String.get_Chars(text,iVar3,0);
              if (sVar2 == 91) {
                local_24[1] = 0;
                local_27[0] = 0;
                local_28 = 0;
                local_res20[0] = 0;
                local_res18[0] = 0;
                local_res8[0] = 0;
                local_24[0] = iVar3;
                cVar1 = NGUIText.ParseSymbol
                                  (text,local_24,0,0,local_24 + 1,local_27,&local_28,local_res20,
                                   local_res18,local_res8,0);
                if (!(!cVar1))
                {
                  text = String.Remove(text,iVar3);
                  if (text == null) {
                  // WARNING: Subroutine does not return
                  FUN_1800d6620();
                  }
                  iVar4 = *(int *)(text + 16);
                  }
                  else {
                }
                iVar3 = iVar3 + 1;
              }
            } while (iVar3 < iVar4);
          }
        }
        return text;
    }

    // Token : 0x60003B5
    // RVA   : 0xDFF010   Offset: 0xDFE410   Length: 0x983
    public static void Align(List<Vector3> verts, int indexOffset, float printedWidth, int elements)
    {
        ulong uVar1;
        int iVar4;
        long lVar5;
        long lVar6;
        uint uVar7;
        uint uVar8;
        ulong uVar9;
        uint uVar11;
        float fVar12;
        double dVar13;
        float fVar14;
        float fVar15;
        ulong uVar16;
        uint uVar17;
        int local_1e8;
        uint64 local_1d8;
        uint32 local_1d0;
        float local_1c8;
        float local_1c4;
        double local_1c0;
        double local_1b8 [3];
        uint64 local_1a0;
        uint32 local_18c;
        uint64 local_188;
        uint32 local_180;
        uint32 local_170;
        uint64 local_168;
        uint32 local_160;
        uint32 local_150;
        uint64 local_148;
        uint32 local_140;
        uint32 local_130;
        uint64 local_128;
        uint32 local_120;
        uint32 local_110;
        uint64 local_108;
        uint32 local_100;
        uint32 local_f0;
        uint64 local_e8;
        uint32 local_e0;
        uint32 local_d0;
        uVar9 = (uint64)indexOffset;
        uVar16 = 0;
        uVar17 = 0;
        iVar4 = NGUIText.alignment;
        if (iVar4 == 2) {
          fVar15 = ((float)NGUIText.rectWidth - printedWidth) * 0.5;
          if (0.0 <= fVar15) {
            bVar2 = Mathf.RoundToInt((float)NGUIText.rectWidth -
                                      printedWidth,0);
            bVar3 = Mathf.RoundToInt(DAT_181d8bc90,0);
            if ((((bVar2 & 1) != 0) && ((bVar3 & 1) == 0)) || ((bVar3 & 1 & (bVar2 & 1 ^ 1)) != 0)) {
              fVar15 = fVar15 + NGUIText.fontScale * 0.5;
            }
            if (verts == null) {
        LAB_180dff98e:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (indexOffset < *(int *)(verts + 24)) {
              lVar6 = uVar9 * 12;
              lVar5 = (int64)*(int *)(verts + 24) - uVar9;
              do {
                if (*(uint32 *)(verts + 24) <= (uint32)uVar9) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar16 = *(uint64 *)(*(int64 *)(verts + 16) + 32 + lVar6);
                local_1d0 = *(uint32 *)(*(int64 *)(verts + 16) + 40 + lVar6);
                local_1d8 = CONCAT44((int)((uint64)uVar16 >> 32),(float)uVar16 + fVar15);
                FUN_18181dd90(verts,uVar9 & 0xffffffff,&local_1d8,DAT_181dabe90);
                uVar9 = (uint64)((uint32)uVar9 + 1);
                lVar6 = lVar6 + 12;
                lVar5 = lVar5 + -1;
              } while (lVar5 != null);
            }
          }
        }
        else if (iVar4 == 3) {
          printedWidth = (float)NGUIText.rectWidth - printedWidth;
          if (0.0 <= printedWidth) {
            if (verts == null) goto LAB_180dff98e;
            if (indexOffset < *(int *)(verts + 24)) {
              lVar6 = uVar9 * 12;
              lVar5 = (int64)*(int *)(verts + 24) - uVar9;
              do {
                if (*(uint32 *)(verts + 24) <= (uint32)uVar9) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar1 = *(uint64 *)(*(int64 *)(verts + 16) + 32 + lVar6);
                local_1d0 = *(uint32 *)(*(int64 *)(verts + 16) + 40 + lVar6);
                local_1d8 = CONCAT44((int)((uint64)uVar1 >> 32),(float)uVar1 + printedWidth);
                FUN_18181dd90(verts,uVar9 & 0xffffffff,&local_1d8,DAT_181dabe90,uVar16,uVar17);
                uVar9 = (uint64)((uint32)uVar9 + 1);
                lVar6 = lVar6 + 12;
                lVar5 = lVar5 + -1;
              } while (lVar5 != null);
            }
          }
        }
        else if (iVar4 == 4) {
          if ((float)NGUIText.rectWidth * 0.65 <= printedWidth) {
            if (1.0 <= ((float)NGUIText.rectWidth - printedWidth) * 0.5) {
              if (verts == null) goto LAB_180dff98e;
              local_1e8 = *(int *)(verts + 24);
              iVar4 = (local_1e8 - indexOffset) / elements;
              if (0 < iVar4) {
                fVar15 = 1.0 / (float)(iVar4 + -1);
                local_1c4 = fVar15;
                if (((*(byte *)(DAT_181d8bc90 + 0x133) & 4) != 0) && (*(int *)(DAT_181d8bc90 + 224) == 0)
                   ) {
                  il2cpp_runtime_class_init
                            (DAT_181d8bc90,
                             (int64)(local_1e8 - indexOffset) % (int64)elements & 0xffffffff);
                  local_1e8 = *(int *)(verts + 24);
                }
                uVar7 = indexOffset + elements;
                iVar4 = 1;
                local_1c8 = (float)NGUIText.rectWidth / printedWidth;
                if ((int)uVar7 < local_1e8) {
                  uVar11 = uVar7 + elements / 2;
                  do {
                    fVar12 = local_1c8;
                    uVar8 = *(uint32 *)(verts + 24);
                    if (uVar8 <= uVar7) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      uVar8 = *(uint32 *)(verts + 24);
                    }
                    lVar6 = *(int64 *)(verts + 16);
                    lVar5 = (int64)(int)uVar7;
                    local_1a0 = *(uint64 *)(lVar6 + 32 + lVar5 * 12);
                    if (uVar8 <= uVar11) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      lVar6 = *(int64 *)(verts + 16);
                    }
                    uVar1 = lVar6[uVar11];
                    fVar14 = (float)uVar1;
                    fVar15 = (float)Mathf.Lerp((float)local_1a0 * fVar12 + (fVar14 - (float)local_1a0),
                                                CONCAT44((int)((uint64)uVar1 >> 32),fVar14 * fVar12),
                                                (float)iVar4 * fVar15,0);
                    fVar12 = (float)Mathf.Lerp();
                    dVar13 = (double)FUN_1801e5e88((double)fVar12,&local_1c0);
                    if (fVar12 < 0.0) {
                      if (dVar13 == -0.5) {
                        fVar12 = (float)local_1c0;
                        if (((int64)local_1c0 & 1U) != 0) {
                          fVar12 = fVar12 - 1.0;
                        }
                      }
                      else {
                        fVar12 = ceilf(fVar12 - 0.5);
                      }
                    }
                    else if (dVar13 == 0.5) {
                      fVar12 = (float)local_1c0;
                      if (((int64)local_1c0 & 1U) != 0) {
                        fVar12 = fVar12 + 1.0;
                      }
                    }
                    else {
                      fVar12 = floorf(fVar12 + 0.5);
                    }
                    dVar13 = (double)FUN_1801e5e88((double)fVar15,local_1b8);
                    if (fVar15 < 0.0) {
                      if (dVar13 == -0.5) {
                        fVar15 = (float)local_1b8[0];
                        if (((int64)local_1b8[0] & 1U) != 0) {
                          fVar15 = fVar15 - 1.0;
                        }
                      }
                      else {
                        fVar15 = ceilf(fVar15 - 0.5);
                      }
                    }
                    else if (dVar13 == 0.5) {
                      fVar15 = (float)local_1b8[0];
                      if (((int64)local_1b8[0] & 1U) != 0) {
                        fVar15 = fVar15 + 1.0;
                      }
                    }
                    else {
                      fVar15 = floorf(fVar15 + 0.5);
                    }
                    if (elements == 4) {
                      if (*(uint32 *)(verts + 24) <= uVar7) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      local_130 = *(uint32 *)(*(int64 *)(verts + 16) + 40 + lVar5 * 12);
                      uVar16 = CONCAT44((int)((uint64)
                                              *(uint64 *)
                                               (*(int64 *)(verts + 16) + 32 + lVar5 * 12) >>
                                             32),fVar12);
                      local_128 = uVar16;
                      local_120 = local_130;
                      FUN_18181dd90(verts,uVar7,&local_128,DAT_181dabe90,uVar16);
                      uVar17 = (uint32)uVar16;
                      if (*(uint32 *)(verts + 24) <= uVar7 + 1) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      local_110 = *(uint32 *)(*(int64 *)(verts + 16) + 52 + lVar5 * 12);
                      local_108 = CONCAT44((int)((uint64)
                                                 *(uint64 *)
                                                  (*(int64 *)(verts + 16) + 44 + lVar5 * 12) >>
                                                32),uVar17);
                      local_100 = local_110;
                      FUN_18181dd90(verts,uVar7 + 1,&local_108,DAT_181dabe90,local_108);
                      if (*(uint32 *)(verts + 24) <= uVar7 + 2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      uVar8 = uVar7 + 3;
                      local_f0 = *(uint32 *)(*(int64 *)(verts + 16) + 64 + lVar5 * 12);
                      uVar16 = CONCAT44((int)((uint64)
                                              *(uint64 *)
                                               (*(int64 *)(verts + 16) + 56 + lVar5 * 12) >>
                                             32),fVar15);
                      local_e8 = uVar16;
                      local_e0 = local_f0;
                      FUN_18181dd90(verts,uVar7 + 2,&local_e8,DAT_181dabe90,uVar16);
                      uVar17 = (uint32)uVar16;
                      if (*(uint32 *)(verts + 24) <= uVar8) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      uVar11 = uVar11 + 4;
                      puVar10 = &local_1d8;
                      local_1d0 = *(uint32 *)(*(int64 *)(verts + 16) + 76 + lVar5 * 12);
                      uVar16 = CONCAT44((int)((uint64)
                                              *(uint64 *)
                                               (*(int64 *)(verts + 16) + 68 + lVar5 * 12) >>
                                             32),uVar17);
                      local_1d8 = uVar16;
                      local_d0 = local_1d0;
        LAB_180dff6c1:
                      uVar7 = uVar8 + 1;
                      FUN_18181dd90(verts,uVar8,puVar10,DAT_181dabe90,uVar16);
                    }
                    else {
                      if (elements == 2) {
                        if (*(uint32 *)(verts + 24) <= uVar7) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        uVar8 = uVar7 + 1;
                        local_170 = *(uint32 *)(*(int64 *)(verts + 16) + 40 + lVar5 * 12);
                        local_168 = CONCAT44((int)((uint64)
                                                   *(uint64 *)
                                                    (*(int64 *)(verts + 16) + 32 + lVar5 * 12)
                                                  >> 32),fVar12);
                        local_160 = local_170;
                        FUN_18181dd90(verts,uVar7,&local_168,DAT_181dabe90);
                        if (*(uint32 *)(verts + 24) <= uVar8) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        uVar11 = uVar11 + 2;
                        puVar10 = &local_148;
                        local_150 = *(uint32 *)(*(int64 *)(verts + 16) + 52 + lVar5 * 12);
                        local_148 = CONCAT44((int)((uint64)
                                                   *(uint64 *)
                                                    (*(int64 *)(verts + 16) + 44 + lVar5 * 12)
                                                  >> 32),fVar15);
                        local_140 = local_150;
                        goto LAB_180dff6c1;
                      }
                      if (elements == 1) {
                        if (*(uint32 *)(verts + 24) <= uVar7) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        puVar10 = &local_188;
                        uVar11 = uVar11 + 1;
                        local_18c = *(uint32 *)(*(int64 *)(verts + 16) + 40 + lVar5 * 12);
                        local_188 = CONCAT44((int)((uint64)
                                                   *(uint64 *)
                                                    (*(int64 *)(verts + 16) + 32 + lVar5 * 12)
                                                  >> 32),fVar12);
                        uVar8 = uVar7;
                        local_180 = local_18c;
                        goto LAB_180dff6c1;
                      }
                    }
                    iVar4 = iVar4 + 1;
                    fVar15 = local_1c4;
                  } while ((int)uVar7 < local_1e8);
                }
              }
            }
          }
        }
    }

    // Token : 0x60003B6
    // RVA   : 0xE00FA0   Offset: 0xE003A0   Length: 0x182
    public static int GetExactCharacterIndex(List<Vector3> verts, List<int> indices, Vector2 pos)
    {
        int iVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        int iVar6;
        long lVar7;
        float local_78;
        float fStack_74;
        iVar6 = 0;
        if (indices == null) {
        LAB_180e0111d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar2 = *(int *)(indices + 24);
        if (0 < iVar2) {
          fStack_74 = (float)((uint64)pos >> 32);
          local_78 = (float)pos;
          do {
            uVar3 = iVar6 * 2;
            if (verts == null) goto LAB_180e0111d;
            if (*(uint32 *)(verts + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(verts + 16);
            lVar7 = (int64)(int)uVar3;
            if ((float)*(uint64 *)(lVar5 + 32 + lVar7 * 12) <= local_78) {
              if (*(uint32 *)(verts + 24) <= uVar3 + 1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = *(int64 *)(verts + 16);
              }
              if (local_78 <= (float)*(uint64 *)(lVar5 + 44 + lVar7 * 12)) {
                if (*(uint32 *)(verts + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar5 = *(int64 *)(verts + 16);
                }
                if (*(float *)(lVar5 + 36 + lVar7 * 12) <= fStack_74) {
                  if (*(uint32 *)(verts + 24) <= uVar3 + 1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    lVar5 = *(int64 *)(verts + 16);
                  }
                  pfVar1 = (float *)(lVar5 + 48 + lVar7 * 12);
                  if (fStack_74 < *pfVar1 || fStack_74 == *pfVar1) {
                    uVar4 = FUN_1800d6760(indices,iVar6,DAT_181d8fa18);
                    return uVar4;
                  }
                }
              }
            }
            iVar6 = iVar6 + 1;
          } while (iVar6 < iVar2);
        }
        return 0;
    }

    // Token : 0x60003B7
    // RVA   : 0xE00D80   Offset: 0xE00180   Length: 0x19A
    public static int GetApproximateCharacterIndex(List<Vector3> verts, List<int> indices, Vector2 pos)
    {
        uint32
        NGUIText.GetApproximateCharacterIndex(int64 verts,int64 indices,uint64 pos)
        {
        int64 lVar1;
        int64 lVar2;
        uint32 uVar3;
        uint32 uVar4;
        int64 lVar5;
        float fVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float local_98;
        float fStack_94;
        fVar8 = 3.4028235e+38;
        uVar4 = 0;
        uVar3 = 0;
        if (verts != null) {
          lVar1 = (int64)*(int *)(verts + 24);
          if (0 < *(int *)(verts + 24)) {
            lVar5 = 0;
            fStack_94 = (float)((uint64)pos >> 32);
            local_98 = (float)pos;
            fVar9 = 3.4028235e+38;
            do {
              if (*(uint32 *)(verts + 24) <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(verts + 16);
              fVar7 = ABS(fStack_94 - *(float *)(lVar5 + 36 + lVar2));
              fVar10 = fVar9;
              if (fVar7 <= fVar9) {
                if (*(uint32 *)(verts + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar2 = *(int64 *)(verts + 16);
                }
                fVar6 = ABS(local_98 - (float)*(uint64 *)(lVar5 + 32 + lVar2));
                fVar10 = fVar7;
                if ((fVar7 < fVar9) || (fVar10 = fVar9, fVar6 < fVar8)) {
                  fVar8 = fVar6;
                  uVar4 = uVar3;
                }
              }
              uVar3 = uVar3 + 1;
              lVar5 = lVar5 + 12;
              lVar1 = lVar1 + -1;
              fVar9 = fVar10;
            } while (lVar1 != null);
          }
          if (indices != null) {
            if (*(uint32 *)(indices + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return indices[uVar4];
          }
        }
    }

    // Token : 0x60003B8
    // RVA   : 0xE02270   Offset: 0xE01670   Length: 0x1D
    public static bool IsSpace(int ch)
    {
        bool FUN_180e02270(int ch)
        {
        if (ch != 32) {
          if (1 < ch - 0x200aU) {
            return ch == 0x2009;
          }
        }
        return true;
    }

    // Token : 0x60003B9
    // RVA   : 0xE00C90   Offset: 0xE00090   Length: 0xE5
    public static void EndLine(ref StringBuilder s)
    {
        ushort uVar1;
        int iVar2;
        uint uVar3;
        if (*s == null) throw; // [null/range check failed]
        iVar2 = FUN_181259800(*s,0);
        iVar2 = iVar2 + -1;
        if (0 < iVar2) {
          if (*s == null) throw; // [null/range check failed]
          uVar1 = StringBuilder.get_Chars(*s,iVar2,0);
          uVar3 = (uint32)uVar1;
          if (((uVar3 == 32) || (uVar3 - 0x200a < 2)) || (uVar3 == 0x2009)) {
            if (*s != null) {
              StringBuilder.set_Chars(*s,iVar2,10,0);
              return;
            }
            throw; // [null/range check failed]
          }
        }
        if (*s != null) {
          StringBuilder.Append(*s,10,0);
          return;
        }
    }

    // Token : 0x60003BA
    // RVA   : 0xE08270   Offset: 0xE07670   Length: 0xC3
    private static void ReplaceSpaceWithNewline(ref StringBuilder s)
    {
        ushort uVar1;
        int iVar2;
        uint uVar3;
        if (*s != null) {
          iVar2 = FUN_181259800(*s,0);
          iVar2 = iVar2 + -1;
          if (0 < iVar2) {
            if (*s == null) throw; // [null/range check failed]
            uVar1 = StringBuilder.get_Chars(*s,iVar2,0);
            uVar3 = (uint32)uVar1;
            if (((uVar3 == 32) || (uVar3 - 0x200a < 2)) || (uVar3 == 0x2009)) {
              if (*s == null) throw; // [null/range check failed]
              StringBuilder.set_Chars(*s,iVar2,10,0);
            }
          }
          return;
        }
    }

    // Token : 0x60003BB
    // RVA   : 0xDFFFA0   Offset: 0xDFF3A0   Length: 0x7B3
    public static Vector2 CalculatePrintedSize(string text)
    {
        int iVar1;
        bool cVar2;
        ushort uVar3;
        int iVar4;
        ulong uVar5;
        long lVar6;
        int iVar7;
        int iVar8;
        ushort uVar9;
        ushort uVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        ulong local_res8;
        byte[] local_res18 = new byte[8];
        byte[] local_res20 = new byte[8];
        byte local_e8;
        byte[] local_e7 = new byte[3];
        int local_e4;
        int[] local_e0 = new int[42];
        uVar5 = Vector2.get_zero(0);
        local_res8._0_4_ = (float)uVar5;
        fVar12 = (float)local_res8;
        local_res8._4_4_ = (float)(uVar5 >> 32);
        fVar14 = local_res8._4_4_;
        local_res8 = uVar5;
        cVar2 = FUN_180d755b0(text,0);
        if (!cVar2) {
          NGUIText.Prepare(text,0);
          uVar9 = 0;
          fVar12 = 0.0;
          fVar15 = 0.0;
          fVar14 = 0.0;
          fVar16 = (float)NGUIText.regionWidth + 0.01;
          if (text == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar1 = *(int *)(text + 16);
          iVar8 = 0;
          local_e0[0] = 0;
          local_e7[0] = 0;
          local_e8 = 0;
          local_res20[0] = 0;
          local_res18[0] = 0;
          local_res8 = local_res8 & 0xffffffffffffff00;
          local_e4 = 0;
          if (0 < iVar1) {
            do {
              iVar7 = local_e4;
              uVar3 = String.get_Chars(text,local_e4,0);
              if (uVar3 == 10) {
                if (fVar14 < fVar12) {
                  fVar14 = fVar12;
                }
                fVar12 = 0.0;
                fVar15 = fVar15 + NGUIText.finalLineHeight;
        LAB_180e00616:
                uVar10 = 0;
              }
              else {
                uVar10 = uVar3;
                if (31 < uVar3) {
                  uVar10 = uVar9;
                  if (NGUIText.encoding) {
                    cVar2 = NGUIText.ParseSymbol
                                      (text,&local_e4,
                                       NGUIText.mColors,
                                       NGUIText.premultiply,
                                       local_e0,local_e7,&local_e8,local_res20,local_res18,&local_res8,0);
                    iVar8 = local_e0[0];
                    iVar7 = local_e4;
                    if (cVar2) {
                      iVar7 = local_e4 + -1;
                      goto LAB_180e00619;
                    }
                  }
                  if (!NGUIText.useSymbols) {
                    lVar6 = 0;
                  }
                  else {
                    lVar6 = NGUIText.GetSymbol(text,iVar7,iVar1,0);
                  }
                  if (iVar8 == 0) {
                    fVar13 = NGUIText.fontScale;
                  }
                  else {
                    fVar13 = NGUIText.fontScale * 0.75;
                  }
                  if (lVar6 != null) {
                    fVar13 = (float)*(int *)(lVar6 + 64) * fVar13;
                    fVar11 = fVar13 + fVar12;
                    if (fVar16 < fVar11) {
                      if (fVar12 == 0.0) break;
                      if (fVar14 < fVar12) {
                        fVar14 = fVar12;
                      }
                      fVar12 = 0.0;
                      fVar15 = fVar15 + NGUIText.finalLineHeight;
                    }
                    else if (fVar14 < fVar11) {
                      fVar14 = fVar11;
                    }
                    fVar12 = fVar12 + fVar13 + NGUIText.finalSpacingX;
                    iVar4 = BMSymbol.get_length(lVar6,0);
                    iVar7 = iVar7 + -1 + iVar4;
                    goto LAB_180e00616;
                  }
                  lVar6 = NGUIText.GetGlyph(uVar3,uVar9);
                  if (lVar6 != null) {
                    fVar13 = *(float *)(lVar6 + 64);
                    if (iVar8 != 0) {
                      if (iVar8 == 1) {
                        fVar11 = (float)NGUIText.fontSize *
                                 NGUIText.fontScale * 0.4;
                        *(float *)(lVar6 + 20) = *(float *)(lVar6 + 20) - fVar11;
                        fVar11 = *(float *)(lVar6 + 28) - fVar11;
                      }
                      else {
                        fVar11 = (float)NGUIText.fontSize *
                                 NGUIText.fontScale * 0.05;
                        *(float *)(lVar6 + 20) = fVar11 + *(float *)(lVar6 + 20);
                        fVar11 = fVar11 + *(float *)(lVar6 + 28);
                      }
                      *(float *)(lVar6 + 28) = fVar11;
                    }
                    fVar13 = fVar13 + NGUIText.finalSpacingX + fVar12;
                    if (fVar16 < fVar13) {
                      uVar10 = uVar3;
                      if (fVar12 == 0.0) goto LAB_180e00619;
                      fVar15 = fVar15 + NGUIText.finalLineHeight;
                    }
                    else if (fVar14 < fVar13) {
                      fVar14 = fVar13;
                    }
                    if (iVar8 != 0) {
                      fVar13 = (float)FUN_18000d7c0(fVar13);
                    }
                    fVar12 = fVar13;
                    uVar10 = uVar3;
                  }
                }
              }
        LAB_180e00619:
              local_e4 = iVar7 + 1;
              uVar9 = uVar10;
            } while (local_e4 < iVar1);
            if (fVar14 < fVar12) {
              fVar14 = fVar12 - NGUIText.finalSpacingX;
            }
          }
          lVar6 = DAT_181d8bc90;
          fVar12 = ceilf(fVar14);
          if (((*(byte *)(lVar6 + 0x133) & 4) != 0) && (*(int *)(lVar6 + 224) == 0)) {
            il2cpp_runtime_class_init(lVar6);
            lVar6 = DAT_181d8bc90;
          }
          fVar14 = ceilf(fVar15 + *(float *)(*(int64 *)(lVar6 + 184) + 144));
        }
        return CONCAT44(fVar14,fVar12);
    }

    // Token : 0x60003BC
    // RVA   : 0xDFF9A0   Offset: 0xDFEDA0   Length: 0x5F9
    public static int CalculateOffsetToFit(string text)
    {
        var plVar8 = *(int64*)(lVar8 + 184);
        int iVar1;
        long lVar2;
        uint uVar3;
        bool cVar4;
        ushort uVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        uint uVar9;
        ulong uVar10;
        int iVar11;
        int iVar12;
        ulong uVar13;
        ulong uVar14;
        float fVar15;
        byte[] local_res8 = new byte[16];
        byte[] local_res18 = new byte[8];
        byte[] local_res20 = new byte[8];
        byte local_78;
        byte[] local_77 = new byte[3];
        uint local_74;
        int[] local_70 = new int[14];
        cVar4 = FUN_180d755b0(text,0);
        if (!cVar4) {
          if (0 < NGUIText.regionWidth) {
            NGUIText.Prepare(text,0);
            if (text != null) {
              iVar1 = *(int *)(text + 16);
              uVar14 = 0;
              local_70[0] = 0;
              local_77[0] = 0;
              local_78 = 0;
              local_res20[0] = 0;
              local_res18[0] = 0;
              local_res8[0] = 0;
              local_74 = 0;
              uVar10 = uVar14;
              uVar13 = uVar14;
              if (0 < iVar1) {
                do {
                  if (local_70[0] == 0) {
                    fVar15 = NGUIText.fontScale;
                  }
                  else {
                    fVar15 = NGUIText.fontScale * 0.75;
                  }
                  uVar6 = uVar14;
                  if (NGUIText.useSymbols) {
                    uVar6 = NGUIText.GetSymbol(text,uVar13,iVar1,0);
                  }
                  if (!NGUIText.encoding) {
        LAB_180dffc8d:
                    iVar12 = (int)uVar13;
                    if (uVar6 == 0) {
                      uVar5 = String.get_Chars(text,uVar13,0);
                      fVar15 = (float)NGUIText.GetGlyphWidth(uVar5,uVar10,fVar15);
                      if (fVar15 != 0.0) {
                        if (NGUIText.mSizes == null)
                        goto LAB_180dfff94;
                        FUN_181583bd0();
                      }
                      uVar10 = (uint64)uVar5;
                    }
                    else {
                      lVar8 = NGUIText.mSizes;
                      if (lVar8 == null) goto LAB_180dfff94;
                      FUN_181583bd0(lVar8,(float)*(int *)(uVar6 + 64) * fVar15 +
                                          NGUIText.finalSpacingX);
                      if (*(int64 *)(uVar6 + 16) == 0) goto LAB_180dfff94;
                      iVar11 = *(int *)(*(int64 *)(uVar6 + 16) + 16) + -1;
                      uVar10 = uVar14;
                      if (0 < iVar11) {
                        do {
                          if (NGUIText.mSizes == null)
                          goto LAB_180dfff94;
                          FUN_181583bd0();
                          uVar9 = (int)uVar10 + 1;
                          uVar10 = (uint64)uVar9;
                        } while ((int)uVar9 < iVar11);
                      }
                      if (*(int64 *)(uVar6 + 16) == 0) goto LAB_180dfff94;
                      iVar12 = iVar12 + -1 + *(int *)(*(int64 *)(uVar6 + 16) + 16);
                      uVar10 = uVar14;
                    }
                  }
                  else {
                    cVar4 = NGUIText.ParseSymbol
                                      (text,&local_74,
                                       NGUIText.mColors,
                                       NGUIText.premultiply,
                                       local_70,local_77,&local_78,local_res20,local_res18,local_res8,0);
                    uVar13 = (uint64)local_74;
                    if (!cVar4) goto LAB_180dffc8d;
                    iVar12 = local_74 - 1;
                  }
                  local_74 = iVar12 + 1;
                  uVar13 = (uint64)local_74;
                } while ((int)local_74 < iVar1);
              }
              lVar8 = NGUIText.mSizes;
              fVar15 = (float)NGUIText.regionWidth;
              if (lVar8 != null) {
                uVar9 = *(uint32 *)(lVar8 + 24);
                lVar8 = DAT_181d8bc90;
                for (; (0 < (int)uVar9 && (uVar10 = (uint64)uVar9, 0.0 < fVar15));
                    fVar15 = fVar15 - *(float *)(lVar2 + 28 + uVar10 * 4)) {
                  if (((*(byte *)(lVar8 + 0x133) & 4) != 0) && (*(int *)(lVar8 + 224) == 0)) {
                    il2cpp_runtime_class_init();
                    lVar8 = DAT_181d8bc90;
                  }
                  lVar2 = *(int64 *)(plVar8 + 240);
                  if (lVar2 == null) goto LAB_180dfff94;
                  lVar2 = *(int64 *)(lVar2 + 16);
                  uVar9 = uVar9 - 1;
                  if (lVar2 == null) goto LAB_180dfff94;
                  if (*(uint32 *)(lVar2 + 24) <= uVar9) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                }
                if (((*(byte *)(lVar8 + 0x133) & 4) != 0) && (*(int *)(lVar8 + 224) == 0)) {
                  il2cpp_runtime_class_init();
                  lVar8 = DAT_181d8bc90;
                }
                lVar8 = *(int64 *)(plVar8 + 240);
                if (lVar8 != null) {
                  BetterList_1.Clear(lVar8,DAT_181da6438);
                  uVar3 = uVar9 + 1;
                  if (0.0 <= fVar15) {
                    uVar3 = uVar9;
                  }
                  return uVar3;
                }
              }
            }
        LAB_180dfff94:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return 0;
    }

    // Token : 0x60003BD
    // RVA   : 0xE00F20   Offset: 0xE00320   Length: 0x7B
    public static string GetEndOfLineThatFits(string text)
    {
        int iVar1;
        int iVar2;
        if (text != null) {
          iVar1 = *(int *)(text + 16);
          iVar2 = NGUIText.CalculateOffsetToFit(text,0);
          String.Substring(text,iVar2,iVar1 - iVar2,0);
          return;
        }
    }

    // Token : 0x60003BE
    // RVA   : 0xE089C0   Offset: 0xE07DC0   Length: 0x83
    public static bool WrapText(string text, ref string finalText, bool wrapLineColors)
    {
        var plVar14 = *(int64*)(lVar14 + 184);
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        int iVar2;
        long lVar3;
        long lVar4;
        int iVar8;
        int iVar9;
        bool cVar10;
        ushort uVar11;
        uint uVar12;
        ulong uVar13;
        long lVar14;
        uint uVar16;
        int iVar18;
        int iVar19;
        int iVar20;
        uint uVar21;
        float fVar25;
        byte[] auVar26 = new byte[16];
        byte[] auVar27 = new byte[16];
        float fVar28;
        float fVar29;
        float fVar30;
        float fVar31;
        int local_114;
        int local_110;
        bool[] local_108 = new bool[4];
        int local_104;
        int local_100;
        uint8 local_fc;
        uint8 local_fb;
        uint8 local_fa;
        uint8 local_f9;
        uint32 local_f8;
        int local_f4;
        int local_f0;
        uint32 local_ec;
        int local_e8;
        uint32 local_e4;
        uint8 local_d8 [16];
        uint8 local_c8 [16];
        uint8 local_b8 [128];
        uint64 extraout_XMM0_Qb;
        if (0 < NGUIText.regionWidth) {
          if (0 < NGUIText.regionHeight) {
            pfVar1 = &NGUIText.finalLineHeight;
            if (1.0 < *pfVar1 || *pfVar1 == 1.0) {
              if (NGUIText.maxLines < 1) {
              }
              else {
                Mathf.Min(DAT_181d8bc90,
                           (float)NGUIText.maxLines *
                           NGUIText.finalLineHeight);
              }
              if (((0 < NGUIText.maxLines) &&
                  ((*(byte *)(DAT_181d8bc90 + 0x133) & 4) != 0)) && (*(int *)(DAT_181d8bc90 + 224) == 0))
              {
                il2cpp_runtime_class_init();
              }
              auVar26._0_8_ = Mathf.Min();
              auVar26._8_8_ = extraout_XMM0_Qb;
              auVar27._4_12_ = auVar26._4_12_;
              auVar27._0_4_ = (float)auVar26._0_8_ + 0.01;
              local_104 = Mathf.FloorToInt(auVar27._0_8_,0);
              if (local_104 == 0) {
                *finalText = "";
                il2cpp_internal(finalText,"");
                return false;
              }
              cVar10 = FUN_180d755b0(text,0);
              if (cVar10) {
                text = " ";
              }
              if (text != null) {
                iVar2 = *(int *)(text + 16);
                NGUIText.Prepare(text,0);
                if (NGUIText.mSB == null) {
                  uVar13 = new StringBuilder(0);
                  NGUIText.mSB = uVar13;
                }
                else {
                  lVar14 = NGUIText.mSB;
                  if (lVar14 == null) goto LAB_180e0a931;
                  StringBuilder.set_Length(lVar14,0);
                }
                iVar20 = 0;
                iVar18 = 1;
                local_f8 = 0;
                local_114 = 1;
                local_110 = 0;
                auVar26 = *(uint8 (*) [16])(pStatics + 44);
                local_f0 = 0;
                fVar29 = 0.0;
                bVar24 = true;
                fVar30 = (float)NGUIText.regionWidth;
                local_e4 = CONCAT31(local_e4._1_3_,1);
                local_f4 = 0;
                local_e8 = 0;
                local_f9 = 0;
                local_fa = 0;
                local_fb = 0;
                local_fc = 0;
                local_108[0] = false;
                if (param_5 == 0) {
                  fVar31 = NGUIText.finalSpacingX;
                }
                else {
                  fVar31 = NGUIText.finalSpacingX;
                  fVar25 = (float)NGUIText.GetGlyphWidth
                                            (46,46,
                                             NGUIText.fontScale,0
                                            );
                  fVar31 = (fVar25 + fVar31) * 3.0;
                }
                local_100 = 0;
                lVar14 = NGUIText.mColors;
                if (lVar14 != null) {
                  local_c8 = auVar26;
                  BetterList_1.Add(lVar14,local_c8,DAT_181da61b8);
                  local_ec = 0;
                  if (NGUIText.useSymbols) {
                    local_ec = param_4 & 255;
                  }
                  if ((char)local_ec) {
                    lVar14 = NGUIText.mSB;
                    if (lVar14 == null) goto LAB_180e0a931;
                    StringBuilder.Append(lVar14,"[",0);
                    lVar14 = NGUIText.mSB;
                    local_c8 = auVar26;
                    uVar13 = NGUIText.EncodeColor24(local_c8,0);
                    if (lVar14 == null) goto LAB_180e0a931;
                    StringBuilder.Append(lVar14,uVar13,0);
                    lVar14 = NGUIText.mSB;
                    if (lVar14 == null) goto LAB_180e0a931;
                    StringBuilder.Append(lVar14,"]",0);
                  }
                  bVar7 = false;
                  iVar19 = local_104;
                  if (0 < iVar2) {
                    do {
                      uVar11 = String.get_Chars(text,local_110,0);
                      uVar16 = (uint32)uVar11;
                      if ((uVar11 == 32) || (uVar11 - 0x200a < 2)) {
                        bVar22 = true;
                      }
                      else {
                        bVar22 = uVar16 == 0x2009;
                      }
                      if (uVar11 < 0x3000) {
                        if (uVar11 != 10) goto LAB_180e0918e;
                        if (local_114 == local_104) break;
                        if (iVar20 < local_110) {
                          lVar14 = NGUIText.mSB;
                          uVar13 = String.Substring(text,iVar20,(local_110 - iVar20) + 1,0);
                          if (lVar14 == null) goto LAB_180e0a931;
                          StringBuilder.Append(lVar14,uVar13);
                        }
                        else {
                          lVar14 = NGUIText.mSB;
                          if (lVar14 == null) goto LAB_180e0a931;
                          StringBuilder.Append(lVar14,10);
                        }
                        if ((char)local_ec) {
                          iVar20 = 0;
                          while( true ) {
                            lVar14 = NGUIText.mColors;
                            if (lVar14 == null) goto LAB_180e0a931;
                            if (*(int *)(lVar14 + 24) <= iVar20) break;
                            lVar14 = NGUIText.mSB;
                            if (lVar14 == null) goto LAB_180e0a931;
                            iVar18 = FUN_181259800(lVar14,0);
                            StringBuilder.Insert(lVar14,iVar18 + -1);
                            iVar20 = iVar20 + 1;
                          }
                          uVar16 = 0;
                          while( true ) {
                            lVar14 = NGUIText.mColors;
                            if (lVar14 == null) goto LAB_180e0a931;
                            if (*(int *)(lVar14 + 24) <= (int)uVar16) break;
                            lVar14 = NGUIText.mSB;
                            if (lVar14 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar14,"[");
                            lVar14 = NGUIText.mColors;
                            lVar3 = NGUIText.mSB;
                            if ((lVar14 == null) || (lVar14 = *(int64 *)(lVar14 + 16)) == null)
                            goto LAB_180e0a931;
                            if (*(uint32 *)(lVar14 + 24) <= uVar16) {
                              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar13,0);
                            }
                            auVar26 = *(uint8 (*) [16])(lVar14 + ((int64)(int)uVar16 + 2) * 16);
                            local_d8 = auVar26;
                            uVar13 = NGUIText.EncodeColor24(local_d8,0);
                            if (lVar3 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar3,uVar13);
                            lVar14 = NGUIText.mSB;
                            if (lVar14 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar14,"]");
                            uVar16 = uVar16 + 1;
                          }
                        }
                        local_f8 = 0;
                        fVar29 = 0.0;
                        local_114 = local_114 + 1;
                        iVar20 = local_110 + 1;
                        bVar24 = true;
                      }
                      else {
                        bVar7 = true;
        LAB_180e0918e:
                        bVar23 = local_114 == local_104;
                        iVar18 = local_114;
                        if (NGUIText.encoding) {
                          cVar10 = NGUIText.ParseSymbol
                                             (text,&local_f0,
                                              NGUIText.mColors,
                                              NGUIText.premultiply,
                                              &local_e8,&local_f9,&local_fa,&local_fb,&local_fc,local_108,
                                              0);
                          iVar9 = local_f0;
                          iVar8 = local_100;
                          iVar19 = local_104;
                          if (cVar10) {
                            bVar17 = 0;
                            if (local_114 == local_104) {
                              bVar17 = param_5;
                            }
                            if ((bVar17 == 0) || (local_100 <= iVar20)) {
                              if (local_f0 < local_100 + 1) {
                                lVar14 = NGUIText.mSB;
                                uVar13 = String.Substring(text,iVar20,iVar9 - iVar20,0);
                                if (lVar14 == null) goto LAB_180e0a931;
                                StringBuilder.Append(lVar14,uVar13);
                                iVar20 = iVar9;
                              }
                              uVar16 = 0;
                              lVar14 = DAT_181d8bc90;
                              if ((char)local_ec) {
                                if (local_108[0] == false) {
                                  lVar14 = NGUIText.mColors;
                                  if ((lVar14 == null) || (lVar3 = *(int64 *)(lVar14 + 16)) == null)
                                  goto LAB_180e0a931;
                                  if (*(uint32 *)(lVar3 + 24) <= *(int *)(lVar14 + 24) - 1U) {
                                    uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar13,0);
                                  }
                                  local_d8 = *(uint8 (*) [16])
                                              (pStatics + 44);
                                  local_c8 = *(uint8 (*) [16])
                                              (lVar3 + ((int64)*(int *)(lVar14 + 24) + 1) * 16);
                                  Color.op_Multiply(local_b8,local_d8);
                                }
                                else {
                                  lVar14 = NGUIText.mColors;
                                  if ((lVar14 == null) || (*(int64 *)(lVar14 + 16) == 0))
                                  goto LAB_180e0a931;
                                  if (*(uint32 *)(*(int64 *)(lVar14 + 16) + 24) <=
                                      *(int *)(lVar14 + 24) - 1U) {
                                    uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar13,0);
                                  }
                                }
                                lVar14 = NGUIText.mColors;
                                if (lVar14 == null) goto LAB_180e0a931;
                                iVar18 = *(int *)(lVar14 + 24) + -2;
                                lVar14 = DAT_181d8bc90;
                                if (0 < iVar18) {
                                  do {
                                    if (((*(byte *)(lVar14 + 0x133) & 4) != 0) &&
                                       (*(int *)(lVar14 + 224) == 0)) {
                                      il2cpp_runtime_class_init();
                                      lVar14 = DAT_181d8bc90;
                                    }
                                    lVar3 = *(int64 *)(plVar14 + 176);
                                    if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 16)) == null)
                                    goto LAB_180e0a931;
                                    if (*(uint32 *)(lVar3 + 24) <= uVar16) {
                                      uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar13,0);
                                    }
                                    uVar16 = uVar16 + 1;
                                  } while ((int)uVar16 < iVar18);
                                }
                              }
                              if (iVar20 < iVar9) {
                                if (((*(byte *)(lVar14 + 0x133) & 4) != 0) &&
                                   (*(int *)(lVar14 + 224) == 0)) {
                                  il2cpp_runtime_class_init();
                                  lVar14 = DAT_181d8bc90;
                                }
                                lVar14 = *(int64 *)(plVar14 + 248);
                                uVar13 = String.Substring(text,iVar20,iVar9 - iVar20,0);
                                if (lVar14 == null) goto LAB_180e0a931;
                                StringBuilder.Append(lVar14,uVar13);
                              }
                              else {
                                if (((*(byte *)(lVar14 + 0x133) & 4) != 0) &&
                                   (*(int *)(lVar14 + 224) == 0)) {
                                  il2cpp_runtime_class_init();
                                  lVar14 = DAT_181d8bc90;
                                }
                                lVar14 = *(int64 *)(plVar14 + 248);
                                if (lVar14 == null) goto LAB_180e0a931;
                                StringBuilder.Append(lVar14,uVar11);
                              }
                              local_110 = iVar9 + -1;
                              local_100 = iVar9;
                              local_f4 = local_e8;
                              iVar20 = iVar9;
                              goto LAB_180e0956f;
                            }
                            lVar14 = NGUIText.mSB;
                            uVar13 = String.Substring(text,iVar20,(iVar8 - iVar20) + 1,0);
                            if (lVar14 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar14,uVar13,0);
                            if (local_f4 != 0) {
                              lVar14 = NGUIText.mSB;
                              if (lVar14 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar14,"[/sub]",0);
                            }
                            lVar14 = NGUIText.mSB;
                            if (lVar14 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar14,"...",0);
                            local_110 = local_f0;
                            goto LAB_180e0a438;
                          }
                          local_110 = local_f0;
                          local_f4 = local_e8;
                        }
                        iVar19 = local_f4;
                        if (!NGUIText.useSymbols) {
                          lVar14 = 0;
                        }
                        else {
                          lVar14 = NGUIText.GetSymbol(text,local_110);
                        }
                        if (iVar19 == 0) {
                          fVar25 = NGUIText.fontScale;
                        }
                        else {
                          fVar25 = NGUIText.fontScale * 0.75;
                        }
                        if (lVar14 == null) {
                          fVar25 = (float)NGUIText.GetGlyphWidth(uVar11,local_f8,fVar25);
                          if ((fVar25 == 0.0) && (!bVar22)) goto LAB_180e0956f;
                        }
                        else {
                          fVar25 = (float)*(int *)(lVar14 + 64) * fVar25;
                        }
                        fVar25 = fVar25 + NGUIText.finalSpacingX;
                        if (iVar19 != 0) {
                          fVar25 = (float)FUN_18000d7c0();
                        }
                        fVar29 = fVar29 + fVar25;
                        bVar17 = (bVar24 || bVar23) & param_5;
                        fVar28 = fVar30;
                        if (bVar17 != 0) {
                          fVar28 = fVar30 - fVar31;
                        }
                        local_f8 = uVar16;
                        bVar6 = bVar24;
                        if (((bVar22) && (!bVar7)) && (iVar20 < local_110)) {
                          iVar19 = local_110 - iVar20;
                          if (((local_114 == local_104) && (fVar28 <= fVar29)) && (local_110 < iVar2)) {
                            uVar11 = String.get_Chars(text,local_110,0);
                            if (31 < uVar11) {
                              if (((uVar11 != 32) && (1 < uVar11 - 0x200a)) && (uVar11 != 0x2009))
                              goto LAB_180e097da;
                            }
                            iVar19 = iVar19 + -1;
                          }
        LAB_180e097da:
                          iVar8 = local_100;
                          if (((bVar17 == 0) || (local_100 <= iVar20)) ||
                             ((fVar30 <= fVar29 || (fVar29 <= fVar28)))) {
                            lVar3 = NGUIText.mSB;
                            uVar13 = String.Substring(text,iVar20,iVar19 + 1,0);
                            if (lVar3 != null) {
                              StringBuilder.Append(lVar3,uVar13);
                              iVar20 = local_110 + 1;
                              bVar6 = false;
                              goto LAB_180e0987c;
                            }
                            goto LAB_180e0a931;
                          }
                          lVar14 = NGUIText.mSB;
                          uVar13 = String.Substring(text,iVar20,(iVar8 - iVar20) + 1,0);
                          if (lVar14 == null) goto LAB_180e0a931;
                          StringBuilder.Append(lVar14,uVar13,0);
                          if (local_f4 != 0) {
                            lVar14 = NGUIText.mSB;
                            if (lVar14 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar14,"[/sub]",0);
                          }
                          lVar14 = pStatics;
        LAB_180e0a639:
                          if (*(int64 *)(lVar14 + 248) == 0) goto LAB_180e0a931;
                          StringBuilder.Append(*(int64 *)(lVar14 + 248),"...",0);
                          iVar19 = local_104;
                          goto LAB_180e0a438;
                        }
        LAB_180e0987c:
                        if (((param_5 != 0) && (!bVar22)) && (fVar29 < fVar28)) {
                          local_100 = local_110;
                        }
                        iVar19 = local_100;
                        if (fVar28 < fVar29) {
                          if (!bVar24 && !bVar23) {
                            for (; iVar20 < iVar2; iVar20 = iVar20 + 1) {
                              uVar11 = String.get_Chars(text,iVar20);
                              if (((uVar11 != 32) && (1 < uVar11 - 0x200a)) && (uVar11 != 0x2009))
                              break;
                            }
                            local_110 = iVar20 + -1;
                            iVar18 = local_114 + 1;
                            local_f8 = 0;
                            fVar29 = 0.0;
                            bVar24 = local_114 != local_104;
                            local_114 = iVar18;
                            if (bVar24) {
                              if (!wrapLineColors) {
                                NGUIText.EndLine(pStatics + 248,0);
                              }
                              else {
                                NGUIText.ReplaceSpaceWithNewline
                                          (pStatics + 248,0);
                              }
                              bVar24 = true;
                              if ((char)local_ec) {
                                iVar18 = 0;
                                while( true ) {
                                  lVar14 = NGUIText.mColors;
                                  if (lVar14 == null) goto LAB_180e0a931;
                                  if (*(int *)(lVar14 + 24) <= iVar18) break;
                                  lVar14 = NGUIText.mSB;
                                  if (lVar14 == null) goto LAB_180e0a931;
                                  iVar19 = FUN_181259800(lVar14,0);
                                  StringBuilder.Insert(lVar14,iVar19 + -1);
                                  iVar18 = iVar18 + 1;
                                }
                                uVar16 = 0;
                                while( true ) {
                                  lVar14 = NGUIText.mColors;
                                  if (lVar14 == null) goto LAB_180e0a931;
                                  fVar29 = 0.0;
                                  if (*(int *)(lVar14 + 24) <= (int)uVar16) break;
                                  lVar14 = NGUIText.mSB;
                                  if (lVar14 == null) goto LAB_180e0a931;
                                  StringBuilder.Append(lVar14,"[");
                                  lVar14 = NGUIText.mColors;
                                  lVar3 = NGUIText.mSB;
                                  if ((lVar14 == null) ||
                                     (lVar14 = *(int64 *)(lVar14 + 16)) == null)
                                  goto LAB_180e0a931;
                                  if (*(uint32 *)(lVar14 + 24) <= uVar16) {
                                    uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar13,0);
                                  }
                                  auVar26 = *(uint8 (*) [16])
                                             (lVar14 + ((int64)(int)uVar16 + 2) * 16);
                                  local_d8 = auVar26;
                                  uVar13 = NGUIText.EncodeColor24(local_d8,0);
                                  if (lVar3 == null) goto LAB_180e0a931;
                                  StringBuilder.Append(lVar3,uVar13);
                                  lVar14 = NGUIText.mSB;
                                  if (lVar14 == null) goto LAB_180e0a931;
                                  StringBuilder.Append(lVar14,"]");
                                  uVar16 = uVar16 + 1;
                                }
                              }
                              goto LAB_180e0956f;
                            }
                            break;
                          }
                          if ((param_5 != 0) && (0 < local_110)) {
                            if (iVar20 < local_100) {
                              lVar14 = NGUIText.mSB;
                              uVar13 = String.Substring(text,iVar20,(iVar19 - iVar20) + 1,0);
                              if (lVar14 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar14,uVar13,0);
                            }
                            if (local_f4 != 0) {
                              lVar14 = NGUIText.mSB;
                              if (lVar14 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar14,"[/sub]",0);
                            }
                            lVar14 = pStatics;
                            goto LAB_180e0a639;
                          }
                          lVar3 = NGUIText.mSB;
                          uVar12 = Mathf.Max(0,local_110 - iVar20,0);
                          uVar13 = String.Substring(text,iVar20,uVar12,0);
                          if (lVar3 == null) goto LAB_180e0a931;
                          StringBuilder.Append(lVar3,uVar13);
                          if ((!bVar22) && (local_e4 = local_e4 & 255, !bVar7)) {
                            local_e4 = 0;
                          }
                          cVar10 = (char)local_ec;
                          if (cVar10) {
                            lVar3 = NGUIText.mColors;
                            if (lVar3 == null) goto LAB_180e0a931;
                            if (0 < *(int *)(lVar3 + 24)) {
                              lVar3 = NGUIText.mSB;
                              if (lVar3 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar3,"[-]");
                            }
                          }
                          iVar18 = local_114 + 1;
                          iVar19 = local_104;
                          if (local_114 == local_104) goto LAB_180e0a438;
                          if (!wrapLineColors) {
                            NGUIText.EndLine(pStatics + 248,0);
                          }
                          else {
                            NGUIText.ReplaceSpaceWithNewline
                                      (pStatics + 248,0);
                          }
                          uVar21 = 0;
                          uVar16 = uVar21;
                          if (cVar10) {
                            while( true ) {
                              lVar3 = NGUIText.mColors;
                              if (lVar3 == null) goto LAB_180e0a931;
                              if (*(int *)(lVar3 + 24) <= (int)uVar16) break;
                              lVar3 = NGUIText.mSB;
                              if (lVar3 == null) goto LAB_180e0a931;
                              iVar20 = FUN_181259800(lVar3,0);
                              StringBuilder.Insert(lVar3,iVar20 + -1);
                              uVar16 = uVar16 + 1;
                            }
                            while( true ) {
                              lVar3 = NGUIText.mColors;
                              if (lVar3 == null) goto LAB_180e0a931;
                              if (*(int *)(lVar3 + 24) <= (int)uVar21) break;
                              lVar3 = NGUIText.mSB;
                              if (lVar3 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar3,"[");
                              lVar3 = NGUIText.mColors;
                              lVar4 = NGUIText.mSB;
                              if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 16)) == null)
                              goto LAB_180e0a931;
                              if (*(uint32 *)(lVar3 + 24) <= uVar21) {
                                uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar13,0);
                              }
                              auVar26 = *(uint8 (*) [16])(lVar3 + ((int64)(int)uVar21 + 2) * 16)
                              ;
                              local_d8 = auVar26;
                              uVar13 = NGUIText.EncodeColor24(local_d8,0);
                              if (lVar4 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar4,uVar13);
                              lVar3 = NGUIText.mSB;
                              if (lVar3 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar3,"]");
                              uVar21 = uVar21 + 1;
                            }
                          }
                          bVar6 = true;
                          local_114 = iVar18;
                          if (bVar22) {
                            iVar20 = local_110 + 1;
                            fVar29 = 0.0;
                            local_100 = local_110;
                            local_f8 = 0;
                          }
                          else {
                            local_100 = local_110;
                            local_f8 = 0;
                            fVar29 = fVar25;
                            iVar20 = local_110;
                          }
                        }
                        bVar24 = bVar6;
                        if (lVar14 != null) {
                          iVar18 = BMSymbol.get_length(lVar14,0);
                          local_110 = local_110 + -1 + iVar18;
                          local_f8 = 0;
                        }
                      }
        LAB_180e0956f:
                      local_110 = local_110 + 1;
                      local_f0 = local_110;
                    } while (local_110 < iVar2);
                    iVar19 = local_104;
                    iVar18 = local_114;
                    if (iVar20 < local_110) {
                      lVar14 = NGUIText.mSB;
                      uVar13 = String.Substring(text,iVar20,local_110 - iVar20,0);
                      if (lVar14 == null) goto LAB_180e0a931;
                      StringBuilder.Append(lVar14,uVar13,0);
                    }
                  }
        LAB_180e0a438:
                  if ((char)local_ec) {
                    lVar14 = NGUIText.mColors;
                    if (lVar14 == null) goto LAB_180e0a931;
                    if (0 < *(int *)(lVar14 + 24)) {
                      lVar14 = NGUIText.mSB;
                      if (lVar14 == null) goto LAB_180e0a931;
                      StringBuilder.Append(lVar14,"[-]",0);
                    }
                  }
                  plVar5 = NGUIText.mSB;
                  if (plVar5 != (int64 *)0) {
                    uVar13 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
                    *finalText = uVar13;
                    il2cpp_internal(finalText,uVar13);
                    lVar14 = NGUIText.mColors;
                    if (lVar14 != null) {
                      BetterList_1.Clear(lVar14,DAT_181da6238);
                      if ((char)!local_e4) {
                        return false;
                      }
                      if (local_110 == iVar2) {
                        return true;
                      }
                      if (NGUIText.maxLines != null) {
                        return iVar18 == iVar19;
                      }
                      return iVar18 == 0;
                    }
                  }
                }
              }
        LAB_180e0a931:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
        *finalText = "";
        il2cpp_internal(finalText,"");
        return false;
    }

    // Token : 0x60003BF
    // RVA   : 0xE08A50   Offset: 0xE07E50   Length: 0x548
    public static bool WrapText(string text, ref string finalText, bool keepCharCount, bool wrapLineColors, bool useEllipsis)
    {
        var plVar14 = *(int64*)(lVar14 + 184);
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        int iVar2;
        long lVar3;
        long lVar4;
        int iVar8;
        int iVar9;
        bool cVar10;
        ushort uVar11;
        uint uVar12;
        ulong uVar13;
        long lVar14;
        uint uVar16;
        int iVar18;
        int iVar19;
        int iVar20;
        uint uVar21;
        float fVar25;
        byte[] auVar26 = new byte[16];
        byte[] auVar27 = new byte[16];
        float fVar28;
        float fVar29;
        float fVar30;
        float fVar31;
        int local_114;
        int local_110;
        bool[] local_108 = new bool[4];
        int local_104;
        int local_100;
        uint8 local_fc;
        uint8 local_fb;
        uint8 local_fa;
        uint8 local_f9;
        uint32 local_f8;
        int local_f4;
        int local_f0;
        uint32 local_ec;
        int local_e8;
        uint32 local_e4;
        uint8 local_d8 [16];
        uint8 local_c8 [16];
        uint8 local_b8 [128];
        uint64 extraout_XMM0_Qb;
        if (0 < NGUIText.regionWidth) {
          if (0 < NGUIText.regionHeight) {
            pfVar1 = &NGUIText.finalLineHeight;
            if (1.0 < *pfVar1 || *pfVar1 == 1.0) {
              if (NGUIText.maxLines < 1) {
              }
              else {
                Mathf.Min(DAT_181d8bc90,
                           (float)NGUIText.maxLines *
                           NGUIText.finalLineHeight);
              }
              if (((0 < NGUIText.maxLines) &&
                  ((*(byte *)(DAT_181d8bc90 + 0x133) & 4) != 0)) && (*(int *)(DAT_181d8bc90 + 224) == 0))
              {
                il2cpp_runtime_class_init();
              }
              auVar26._0_8_ = Mathf.Min();
              auVar26._8_8_ = extraout_XMM0_Qb;
              auVar27._4_12_ = auVar26._4_12_;
              auVar27._0_4_ = (float)auVar26._0_8_ + 0.01;
              local_104 = Mathf.FloorToInt(auVar27._0_8_,0);
              if (local_104 == 0) {
                *finalText = "";
                il2cpp_internal(finalText,"");
                return false;
              }
              cVar10 = FUN_180d755b0(text,0);
              if (cVar10) {
                text = " ";
              }
              if (text != null) {
                iVar2 = *(int *)(text + 16);
                NGUIText.Prepare(text,0);
                if (NGUIText.mSB == null) {
                  uVar13 = new StringBuilder(0);
                  NGUIText.mSB = uVar13;
                }
                else {
                  lVar14 = NGUIText.mSB;
                  if (lVar14 == null) goto LAB_180e0a931;
                  StringBuilder.set_Length(lVar14,0);
                }
                iVar20 = 0;
                iVar18 = 1;
                local_f8 = 0;
                local_114 = 1;
                local_110 = 0;
                auVar26 = *(uint8 (*) [16])(pStatics + 44);
                local_f0 = 0;
                fVar29 = 0.0;
                bVar24 = true;
                fVar30 = (float)NGUIText.regionWidth;
                local_e4 = CONCAT31(local_e4._1_3_,1);
                local_f4 = 0;
                local_e8 = 0;
                local_f9 = 0;
                local_fa = 0;
                local_fb = 0;
                local_fc = 0;
                local_108[0] = false;
                if (useEllipsis == null) {
                  fVar31 = NGUIText.finalSpacingX;
                }
                else {
                  fVar31 = NGUIText.finalSpacingX;
                  fVar25 = (float)NGUIText.GetGlyphWidth
                                            (46,46,
                                             NGUIText.fontScale,0
                                            );
                  fVar31 = (fVar25 + fVar31) * 3.0;
                }
                local_100 = 0;
                lVar14 = NGUIText.mColors;
                if (lVar14 != null) {
                  local_c8 = auVar26;
                  BetterList_1.Add(lVar14,local_c8,DAT_181da61b8);
                  local_ec = 0;
                  if (NGUIText.useSymbols) {
                    local_ec = wrapLineColors & 255;
                  }
                  if ((char)local_ec) {
                    lVar14 = NGUIText.mSB;
                    if (lVar14 == null) goto LAB_180e0a931;
                    StringBuilder.Append(lVar14,"[",0);
                    lVar14 = NGUIText.mSB;
                    local_c8 = auVar26;
                    uVar13 = NGUIText.EncodeColor24(local_c8,0);
                    if (lVar14 == null) goto LAB_180e0a931;
                    StringBuilder.Append(lVar14,uVar13,0);
                    lVar14 = NGUIText.mSB;
                    if (lVar14 == null) goto LAB_180e0a931;
                    StringBuilder.Append(lVar14,"]",0);
                  }
                  bVar7 = false;
                  iVar19 = local_104;
                  if (0 < iVar2) {
                    do {
                      uVar11 = String.get_Chars(text,local_110,0);
                      uVar16 = (uint32)uVar11;
                      if ((uVar11 == 32) || (uVar11 - 0x200a < 2)) {
                        bVar22 = true;
                      }
                      else {
                        bVar22 = uVar16 == 0x2009;
                      }
                      if (uVar11 < 0x3000) {
                        if (uVar11 != 10) goto LAB_180e0918e;
                        if (local_114 == local_104) break;
                        if (iVar20 < local_110) {
                          lVar14 = NGUIText.mSB;
                          uVar13 = String.Substring(text,iVar20,(local_110 - iVar20) + 1,0);
                          if (lVar14 == null) goto LAB_180e0a931;
                          StringBuilder.Append(lVar14,uVar13);
                        }
                        else {
                          lVar14 = NGUIText.mSB;
                          if (lVar14 == null) goto LAB_180e0a931;
                          StringBuilder.Append(lVar14,10);
                        }
                        if ((char)local_ec) {
                          iVar20 = 0;
                          while( true ) {
                            lVar14 = NGUIText.mColors;
                            if (lVar14 == null) goto LAB_180e0a931;
                            if (*(int *)(lVar14 + 24) <= iVar20) break;
                            lVar14 = NGUIText.mSB;
                            if (lVar14 == null) goto LAB_180e0a931;
                            iVar18 = FUN_181259800(lVar14,0);
                            StringBuilder.Insert(lVar14,iVar18 + -1);
                            iVar20 = iVar20 + 1;
                          }
                          uVar16 = 0;
                          while( true ) {
                            lVar14 = NGUIText.mColors;
                            if (lVar14 == null) goto LAB_180e0a931;
                            if (*(int *)(lVar14 + 24) <= (int)uVar16) break;
                            lVar14 = NGUIText.mSB;
                            if (lVar14 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar14,"[");
                            lVar14 = NGUIText.mColors;
                            lVar3 = NGUIText.mSB;
                            if ((lVar14 == null) || (lVar14 = *(int64 *)(lVar14 + 16)) == null)
                            goto LAB_180e0a931;
                            if (*(uint32 *)(lVar14 + 24) <= uVar16) {
                              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar13,0);
                            }
                            auVar26 = *(uint8 (*) [16])(lVar14 + ((int64)(int)uVar16 + 2) * 16);
                            local_d8 = auVar26;
                            uVar13 = NGUIText.EncodeColor24(local_d8,0);
                            if (lVar3 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar3,uVar13);
                            lVar14 = NGUIText.mSB;
                            if (lVar14 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar14,"]");
                            uVar16 = uVar16 + 1;
                          }
                        }
                        local_f8 = 0;
                        fVar29 = 0.0;
                        local_114 = local_114 + 1;
                        iVar20 = local_110 + 1;
                        bVar24 = true;
                      }
                      else {
                        bVar7 = true;
        LAB_180e0918e:
                        bVar23 = local_114 == local_104;
                        iVar18 = local_114;
                        if (NGUIText.encoding) {
                          cVar10 = NGUIText.ParseSymbol
                                             (text,&local_f0,
                                              NGUIText.mColors,
                                              NGUIText.premultiply,
                                              &local_e8,&local_f9,&local_fa,&local_fb,&local_fc,local_108,
                                              0);
                          iVar9 = local_f0;
                          iVar8 = local_100;
                          iVar19 = local_104;
                          if (cVar10) {
                            bVar17 = 0;
                            if (local_114 == local_104) {
                              bVar17 = useEllipsis;
                            }
                            if ((bVar17 == 0) || (local_100 <= iVar20)) {
                              if (local_f0 < local_100 + 1) {
                                lVar14 = NGUIText.mSB;
                                uVar13 = String.Substring(text,iVar20,iVar9 - iVar20,0);
                                if (lVar14 == null) goto LAB_180e0a931;
                                StringBuilder.Append(lVar14,uVar13);
                                iVar20 = iVar9;
                              }
                              uVar16 = 0;
                              lVar14 = DAT_181d8bc90;
                              if ((char)local_ec) {
                                if (local_108[0] == false) {
                                  lVar14 = NGUIText.mColors;
                                  if ((lVar14 == null) || (lVar3 = *(int64 *)(lVar14 + 16)) == null)
                                  goto LAB_180e0a931;
                                  if (*(uint32 *)(lVar3 + 24) <= *(int *)(lVar14 + 24) - 1U) {
                                    uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar13,0);
                                  }
                                  local_d8 = *(uint8 (*) [16])
                                              (pStatics + 44);
                                  local_c8 = *(uint8 (*) [16])
                                              (lVar3 + ((int64)*(int *)(lVar14 + 24) + 1) * 16);
                                  Color.op_Multiply(local_b8,local_d8);
                                }
                                else {
                                  lVar14 = NGUIText.mColors;
                                  if ((lVar14 == null) || (*(int64 *)(lVar14 + 16) == 0))
                                  goto LAB_180e0a931;
                                  if (*(uint32 *)(*(int64 *)(lVar14 + 16) + 24) <=
                                      *(int *)(lVar14 + 24) - 1U) {
                                    uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar13,0);
                                  }
                                }
                                lVar14 = NGUIText.mColors;
                                if (lVar14 == null) goto LAB_180e0a931;
                                iVar18 = *(int *)(lVar14 + 24) + -2;
                                lVar14 = DAT_181d8bc90;
                                if (0 < iVar18) {
                                  do {
                                    if (((*(byte *)(lVar14 + 0x133) & 4) != 0) &&
                                       (*(int *)(lVar14 + 224) == 0)) {
                                      il2cpp_runtime_class_init();
                                      lVar14 = DAT_181d8bc90;
                                    }
                                    lVar3 = *(int64 *)(plVar14 + 176);
                                    if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 16)) == null)
                                    goto LAB_180e0a931;
                                    if (*(uint32 *)(lVar3 + 24) <= uVar16) {
                                      uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar13,0);
                                    }
                                    uVar16 = uVar16 + 1;
                                  } while ((int)uVar16 < iVar18);
                                }
                              }
                              if (iVar20 < iVar9) {
                                if (((*(byte *)(lVar14 + 0x133) & 4) != 0) &&
                                   (*(int *)(lVar14 + 224) == 0)) {
                                  il2cpp_runtime_class_init();
                                  lVar14 = DAT_181d8bc90;
                                }
                                lVar14 = *(int64 *)(plVar14 + 248);
                                uVar13 = String.Substring(text,iVar20,iVar9 - iVar20,0);
                                if (lVar14 == null) goto LAB_180e0a931;
                                StringBuilder.Append(lVar14,uVar13);
                              }
                              else {
                                if (((*(byte *)(lVar14 + 0x133) & 4) != 0) &&
                                   (*(int *)(lVar14 + 224) == 0)) {
                                  il2cpp_runtime_class_init();
                                  lVar14 = DAT_181d8bc90;
                                }
                                lVar14 = *(int64 *)(plVar14 + 248);
                                if (lVar14 == null) goto LAB_180e0a931;
                                StringBuilder.Append(lVar14,uVar11);
                              }
                              local_110 = iVar9 + -1;
                              local_100 = iVar9;
                              local_f4 = local_e8;
                              iVar20 = iVar9;
                              goto LAB_180e0956f;
                            }
                            lVar14 = NGUIText.mSB;
                            uVar13 = String.Substring(text,iVar20,(iVar8 - iVar20) + 1,0);
                            if (lVar14 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar14,uVar13,0);
                            if (local_f4 != 0) {
                              lVar14 = NGUIText.mSB;
                              if (lVar14 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar14,"[/sub]",0);
                            }
                            lVar14 = NGUIText.mSB;
                            if (lVar14 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar14,"...",0);
                            local_110 = local_f0;
                            goto LAB_180e0a438;
                          }
                          local_110 = local_f0;
                          local_f4 = local_e8;
                        }
                        iVar19 = local_f4;
                        if (!NGUIText.useSymbols) {
                          lVar14 = 0;
                        }
                        else {
                          lVar14 = NGUIText.GetSymbol(text,local_110);
                        }
                        if (iVar19 == 0) {
                          fVar25 = NGUIText.fontScale;
                        }
                        else {
                          fVar25 = NGUIText.fontScale * 0.75;
                        }
                        if (lVar14 == null) {
                          fVar25 = (float)NGUIText.GetGlyphWidth(uVar11,local_f8,fVar25);
                          if ((fVar25 == 0.0) && (!bVar22)) goto LAB_180e0956f;
                        }
                        else {
                          fVar25 = (float)*(int *)(lVar14 + 64) * fVar25;
                        }
                        fVar25 = fVar25 + NGUIText.finalSpacingX;
                        if (iVar19 != 0) {
                          fVar25 = (float)FUN_18000d7c0();
                        }
                        fVar29 = fVar29 + fVar25;
                        bVar17 = (bVar24 || bVar23) & useEllipsis;
                        fVar28 = fVar30;
                        if (bVar17 != 0) {
                          fVar28 = fVar30 - fVar31;
                        }
                        local_f8 = uVar16;
                        bVar6 = bVar24;
                        if (((bVar22) && (!bVar7)) && (iVar20 < local_110)) {
                          iVar19 = local_110 - iVar20;
                          if (((local_114 == local_104) && (fVar28 <= fVar29)) && (local_110 < iVar2)) {
                            uVar11 = String.get_Chars(text,local_110,0);
                            if (31 < uVar11) {
                              if (((uVar11 != 32) && (1 < uVar11 - 0x200a)) && (uVar11 != 0x2009))
                              goto LAB_180e097da;
                            }
                            iVar19 = iVar19 + -1;
                          }
        LAB_180e097da:
                          iVar8 = local_100;
                          if (((bVar17 == 0) || (local_100 <= iVar20)) ||
                             ((fVar30 <= fVar29 || (fVar29 <= fVar28)))) {
                            lVar3 = NGUIText.mSB;
                            uVar13 = String.Substring(text,iVar20,iVar19 + 1,0);
                            if (lVar3 != null) {
                              StringBuilder.Append(lVar3,uVar13);
                              iVar20 = local_110 + 1;
                              bVar6 = false;
                              goto LAB_180e0987c;
                            }
                            goto LAB_180e0a931;
                          }
                          lVar14 = NGUIText.mSB;
                          uVar13 = String.Substring(text,iVar20,(iVar8 - iVar20) + 1,0);
                          if (lVar14 == null) goto LAB_180e0a931;
                          StringBuilder.Append(lVar14,uVar13,0);
                          if (local_f4 != 0) {
                            lVar14 = NGUIText.mSB;
                            if (lVar14 == null) goto LAB_180e0a931;
                            StringBuilder.Append(lVar14,"[/sub]",0);
                          }
                          lVar14 = pStatics;
        LAB_180e0a639:
                          if (*(int64 *)(lVar14 + 248) == 0) goto LAB_180e0a931;
                          StringBuilder.Append(*(int64 *)(lVar14 + 248),"...",0);
                          iVar19 = local_104;
                          goto LAB_180e0a438;
                        }
        LAB_180e0987c:
                        if (((useEllipsis != null) && (!bVar22)) && (fVar29 < fVar28)) {
                          local_100 = local_110;
                        }
                        iVar19 = local_100;
                        if (fVar28 < fVar29) {
                          if (!bVar24 && !bVar23) {
                            for (; iVar20 < iVar2; iVar20 = iVar20 + 1) {
                              uVar11 = String.get_Chars(text,iVar20);
                              if (((uVar11 != 32) && (1 < uVar11 - 0x200a)) && (uVar11 != 0x2009))
                              break;
                            }
                            local_110 = iVar20 + -1;
                            iVar18 = local_114 + 1;
                            local_f8 = 0;
                            fVar29 = 0.0;
                            bVar24 = local_114 != local_104;
                            local_114 = iVar18;
                            if (bVar24) {
                              if (!keepCharCount) {
                                NGUIText.EndLine(pStatics + 248,0);
                              }
                              else {
                                NGUIText.ReplaceSpaceWithNewline
                                          (pStatics + 248,0);
                              }
                              bVar24 = true;
                              if ((char)local_ec) {
                                iVar18 = 0;
                                while( true ) {
                                  lVar14 = NGUIText.mColors;
                                  if (lVar14 == null) goto LAB_180e0a931;
                                  if (*(int *)(lVar14 + 24) <= iVar18) break;
                                  lVar14 = NGUIText.mSB;
                                  if (lVar14 == null) goto LAB_180e0a931;
                                  iVar19 = FUN_181259800(lVar14,0);
                                  StringBuilder.Insert(lVar14,iVar19 + -1);
                                  iVar18 = iVar18 + 1;
                                }
                                uVar16 = 0;
                                while( true ) {
                                  lVar14 = NGUIText.mColors;
                                  if (lVar14 == null) goto LAB_180e0a931;
                                  fVar29 = 0.0;
                                  if (*(int *)(lVar14 + 24) <= (int)uVar16) break;
                                  lVar14 = NGUIText.mSB;
                                  if (lVar14 == null) goto LAB_180e0a931;
                                  StringBuilder.Append(lVar14,"[");
                                  lVar14 = NGUIText.mColors;
                                  lVar3 = NGUIText.mSB;
                                  if ((lVar14 == null) ||
                                     (lVar14 = *(int64 *)(lVar14 + 16)) == null)
                                  goto LAB_180e0a931;
                                  if (*(uint32 *)(lVar14 + 24) <= uVar16) {
                                    uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar13,0);
                                  }
                                  auVar26 = *(uint8 (*) [16])
                                             (lVar14 + ((int64)(int)uVar16 + 2) * 16);
                                  local_d8 = auVar26;
                                  uVar13 = NGUIText.EncodeColor24(local_d8,0);
                                  if (lVar3 == null) goto LAB_180e0a931;
                                  StringBuilder.Append(lVar3,uVar13);
                                  lVar14 = NGUIText.mSB;
                                  if (lVar14 == null) goto LAB_180e0a931;
                                  StringBuilder.Append(lVar14,"]");
                                  uVar16 = uVar16 + 1;
                                }
                              }
                              goto LAB_180e0956f;
                            }
                            break;
                          }
                          if ((useEllipsis != null) && (0 < local_110)) {
                            if (iVar20 < local_100) {
                              lVar14 = NGUIText.mSB;
                              uVar13 = String.Substring(text,iVar20,(iVar19 - iVar20) + 1,0);
                              if (lVar14 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar14,uVar13,0);
                            }
                            if (local_f4 != 0) {
                              lVar14 = NGUIText.mSB;
                              if (lVar14 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar14,"[/sub]",0);
                            }
                            lVar14 = pStatics;
                            goto LAB_180e0a639;
                          }
                          lVar3 = NGUIText.mSB;
                          uVar12 = Mathf.Max(0,local_110 - iVar20,0);
                          uVar13 = String.Substring(text,iVar20,uVar12,0);
                          if (lVar3 == null) goto LAB_180e0a931;
                          StringBuilder.Append(lVar3,uVar13);
                          if ((!bVar22) && (local_e4 = local_e4 & 255, !bVar7)) {
                            local_e4 = 0;
                          }
                          cVar10 = (char)local_ec;
                          if (cVar10) {
                            lVar3 = NGUIText.mColors;
                            if (lVar3 == null) goto LAB_180e0a931;
                            if (0 < *(int *)(lVar3 + 24)) {
                              lVar3 = NGUIText.mSB;
                              if (lVar3 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar3,"[-]");
                            }
                          }
                          iVar18 = local_114 + 1;
                          iVar19 = local_104;
                          if (local_114 == local_104) goto LAB_180e0a438;
                          if (!keepCharCount) {
                            NGUIText.EndLine(pStatics + 248,0);
                          }
                          else {
                            NGUIText.ReplaceSpaceWithNewline
                                      (pStatics + 248,0);
                          }
                          uVar21 = 0;
                          uVar16 = uVar21;
                          if (cVar10) {
                            while( true ) {
                              lVar3 = NGUIText.mColors;
                              if (lVar3 == null) goto LAB_180e0a931;
                              if (*(int *)(lVar3 + 24) <= (int)uVar16) break;
                              lVar3 = NGUIText.mSB;
                              if (lVar3 == null) goto LAB_180e0a931;
                              iVar20 = FUN_181259800(lVar3,0);
                              StringBuilder.Insert(lVar3,iVar20 + -1);
                              uVar16 = uVar16 + 1;
                            }
                            while( true ) {
                              lVar3 = NGUIText.mColors;
                              if (lVar3 == null) goto LAB_180e0a931;
                              if (*(int *)(lVar3 + 24) <= (int)uVar21) break;
                              lVar3 = NGUIText.mSB;
                              if (lVar3 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar3,"[");
                              lVar3 = NGUIText.mColors;
                              lVar4 = NGUIText.mSB;
                              if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 16)) == null)
                              goto LAB_180e0a931;
                              if (*(uint32 *)(lVar3 + 24) <= uVar21) {
                                uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar13,0);
                              }
                              auVar26 = *(uint8 (*) [16])(lVar3 + ((int64)(int)uVar21 + 2) * 16)
                              ;
                              local_d8 = auVar26;
                              uVar13 = NGUIText.EncodeColor24(local_d8,0);
                              if (lVar4 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar4,uVar13);
                              lVar3 = NGUIText.mSB;
                              if (lVar3 == null) goto LAB_180e0a931;
                              StringBuilder.Append(lVar3,"]");
                              uVar21 = uVar21 + 1;
                            }
                          }
                          bVar6 = true;
                          local_114 = iVar18;
                          if (bVar22) {
                            iVar20 = local_110 + 1;
                            fVar29 = 0.0;
                            local_100 = local_110;
                            local_f8 = 0;
                          }
                          else {
                            local_100 = local_110;
                            local_f8 = 0;
                            fVar29 = fVar25;
                            iVar20 = local_110;
                          }
                        }
                        bVar24 = bVar6;
                        if (lVar14 != null) {
                          iVar18 = BMSymbol.get_length(lVar14,0);
                          local_110 = local_110 + -1 + iVar18;
                          local_f8 = 0;
                        }
                      }
        LAB_180e0956f:
                      local_110 = local_110 + 1;
                      local_f0 = local_110;
                    } while (local_110 < iVar2);
                    iVar19 = local_104;
                    iVar18 = local_114;
                    if (iVar20 < local_110) {
                      lVar14 = NGUIText.mSB;
                      uVar13 = String.Substring(text,iVar20,local_110 - iVar20,0);
                      if (lVar14 == null) goto LAB_180e0a931;
                      StringBuilder.Append(lVar14,uVar13,0);
                    }
                  }
        LAB_180e0a438:
                  if ((char)local_ec) {
                    lVar14 = NGUIText.mColors;
                    if (lVar14 == null) goto LAB_180e0a931;
                    if (0 < *(int *)(lVar14 + 24)) {
                      lVar14 = NGUIText.mSB;
                      if (lVar14 == null) goto LAB_180e0a931;
                      StringBuilder.Append(lVar14,"[-]",0);
                    }
                  }
                  plVar5 = NGUIText.mSB;
                  if (plVar5 != (int64 *)0) {
                    uVar13 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
                    *finalText = uVar13;
                    il2cpp_internal(finalText,uVar13);
                    lVar14 = NGUIText.mColors;
                    if (lVar14 != null) {
                      BetterList_1.Clear(lVar14,DAT_181da6238);
                      if ((char)!local_e4) {
                        return false;
                      }
                      if (local_110 == iVar2) {
                        return true;
                      }
                      if (NGUIText.maxLines != null) {
                        return iVar18 == iVar19;
                      }
                      return iVar18 == 0;
                    }
                  }
                }
              }
        LAB_180e0a931:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
        *finalText = "";
        il2cpp_internal(finalText,"");
        return false;
    }

    // Token : 0x60003C0
    // RVA   : 0xE057E0   Offset: 0xE04BE0   Length: 0x2261
    public static void Print(string text, List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        var plVar12 = *(int64*)(lVar12 + 184);
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        bool cVar5;
        bool cVar6;
        ushort uVar7;
        int iVar8;
        uint8 (*pauVar10) [16];
        int64 lVar11;
        int64 lVar12;
        int64 lVar13;
        uint64 uVar14;
        float *pfVar15;
        uint32 uVar16;
        int iVar17;
        int iVar18;
        uint32 uVar19;
        float fVar20;
        uint32 uVar21;
        uint32 uVar22;
        uint64 extraout_XMM0_Qb;
        uint8 auVar23 [16];
        uint8 auVar24 [16];
        float fVar25;
        float fVar26;
        uint8 auVar27 [4];
        uint8 auVar28 [4];
        float fVar29;
        uint32 uVar30;
        uint32 uVar31;
        uint32 uVar32;
        float fVar33;
        float fVar34;
        float fVar35;
        float fVar36;
        float fVar37;
        float fVar38;
        char local_3d8;
        char local_3d7;
        char local_3d6;
        char local_3d5;
        float local_3d4;
        char local_3d0 [4];
        float local_3cc;
        uint8 local_3c8 [16];
        int local_3b8;
        uint8 local_3a8 [4];
        uint8 auStack_3a4 [4];
        uint64 uStack_3a0;
        uint32 local_398;
        int local_394;
        int local_390;
        float local_38c;
        float local_388;
        float local_384;
        int local_380;
        float local_37c;
        float local_378;
        uint64 local_370;
        uint64 uStack_368;
        uint8 local_360 [8];
        float fStack_358;
        float fStack_354;
        uint64 local_348;
        uint64 uStack_340;
        uint8 local_338 [16];
        uint64 local_328;
        uint64 uStack_320;
        uint64 local_318;
        uint64 uStack_310;
        float local_308;
        uint32 uStack_304;
        float local_300;
        uint32 uStack_2fc;
        float local_2f8;
        uint32 uStack_2f4;
        float local_2f0;
        uint32 uStack_2ec;
        uint64 local_2e8;
        uint64 uStack_2e0;
        float local_2d8;
        float local_2d4;
        uint32 local_2d0;
        float local_2c8;
        float local_2c4;
        uint32 local_2c0;
        float local_2b8;
        float local_2b4;
        uint32 local_2b0;
        float local_2a8;
        float local_2a4;
        uint32 local_2a0;
        float local_298;
        float local_294;
        uint32 local_290;
        float local_288;
        float local_284;
        uint32 local_280;
        float local_278;
        float local_274;
        uint32 local_270;
        float local_268;
        float local_264;
        uint32 local_260;
        float local_258;
        float local_254;
        uint32 local_250;
        float local_248;
        float local_244;
        uint32 local_240;
        float local_238;
        float local_234;
        uint32 local_230;
        float local_228;
        float local_224;
        uint32 local_220;
        float local_218;
        float local_214;
        uint32 local_210;
        float local_208;
        float local_204;
        uint32 local_200;
        float local_1f8;
        float local_1f4;
        uint32 local_1f0;
        float local_1e8;
        float local_1e4;
        uint32 local_1e0;
        float local_1d8;
        float local_1d4;
        uint32 local_1d0;
        float local_1c8;
        float local_1c4;
        uint32 local_1c0;
        float local_1b8;
        float local_1b4;
        uint32 local_1b0;
        float local_1a8;
        float local_1a4;
        uint32 local_1a0;
        float local_198;
        float local_194;
        uint32 local_190;
        float local_188;
        float local_184;
        uint32 local_180;
        float local_178;
        float local_174;
        uint32 local_170;
        float local_168;
        float local_164;
        uint32 local_160;
        uint8 local_158 [16];
        uint8 local_148 [16];
        uint8 local_138 [16];
        uint8 local_128 [16];
        uint8 local_118 [16];
        uint8 local_108 [16];
        uint8 local_f8 [16];
        uint8 local_e8 [16];
        uint8 local_d8 [176];
        local_2e8 = 0;
        uStack_2e0 = 0;
        cVar5 = FUN_180d755b0(text,0);
        if (cVar5) {
          return;
        }
        if (verts != null) {
          iVar18 = *(int *)(verts + 24);
          local_3b8 = iVar18;
          NGUIText.Prepare(text,0);
          lVar12 = NGUIText.mColors;
          puVar9 = (uint64 *)FUN_1810d3570(local_3c8,0);
          if (lVar12 != null) {
            local_328 = *puVar9;
            uStack_320 = puVar9[1];
            BetterList_1.Add(lVar12,&local_328,DAT_181da61b8);
            cVar5 = false;
            fVar29 = 0.0;
            uVar30 = 0;
            uVar31 = 0;
            uVar32 = 0;
            local_398 = 0;
            local_3d4 = 0.0;
            local_3cc = 0.0;
            NGUIText.mAlpha = 0x3f800000;
            lVar12 = pStatics;
            local_328 = *(uint64 *)(lVar12 + 84);
            uStack_320 = *(uint64 *)(lVar12 + 92);
            iVar8 = *(int *)(lVar12 + 136);
            local_318 = *(uint64 *)(lVar12 + 44);
            uStack_310 = *(uint64 *)(lVar12 + 52);
            puVar9 = (uint64 *)Color.op_Multiply(local_3c8,&local_318,&local_328,0);
            local_328 = *puVar9;
            uStack_320 = puVar9[1];
            lVar12 = pStatics;
            local_318 = *(uint64 *)(lVar12 + 100);
            uStack_310 = *(uint64 *)(lVar12 + 108);
            local_338 = *(uint8 (*) [16])(lVar12 + 44);
            pauVar10 = (uint8 (*) [16])Color.op_Multiply(local_3c8,local_338,&local_318,0);
            local_338 = *pauVar10;
            lVar12 = pStatics;
            pauVar10 = (uint8 (*) [16])(lVar12 + 44);
            auVar27 = *(uint8 (*) [4])*pauVar10;
            auVar28 = *(uint8 (*) [4])(lVar12 + 48);
            local_348 = *(uint64 *)*pauVar10;
            uVar21 = *(uint32 *)(lVar12 + 52);
            uVar22 = *(uint32 *)(lVar12 + 56);
            _local_3a8 = *pauVar10;
            uStack_340 = *(uint64 *)(lVar12 + 52);
            if (text != null) {
              local_380 = *(int *)(text + 16);
              local_370 = 0;
              uStack_368 = 0;
              plVar1 = pStatics;
              local_394 = 0;
              local_3d8 = false;
              local_3d7 = false;
              local_3d5 = false;
              local_37c = (float)iVar8 * *(float *)(plVar1 + 4);
              local_3d6 = false;
              local_3d0[0] = false;
              local_38c = 0.0;
              fVar36 = (float)*(int *)((int64)plVar1 + 68) + 0.01;
              local_388 = 0.0;
              local_378 = fVar36;
              if (*plVar1 != 0) {
                if (NGUIText.bitmapFont == null) throw; // [null/range check failed]
                puVar9 = (uint64 *)FUN_180007830(local_3c8,17,DAT_181d7a800);
                local_370 = *puVar9;
                uStack_368 = puVar9[1];
                fVar20 = (float)FUN_180d98fa0(&local_370,0);
                if (NGUIText.bitmapFont == null) throw; // [null/range check failed]
                iVar8 = FUN_180002970(2,DAT_181d7a800);
                local_38c = fVar20 / (float)iVar8;
                fVar20 = (float)FUN_18044e2b0(&local_370,0);
                if (NGUIText.bitmapFont == null) throw; // [null/range check failed]
                iVar8 = FUN_180002970(4,DAT_181d7a800);
                local_388 = fVar20 / (float)iVar8;
              }
              local_390 = 0;
              lVar12 = DAT_181d8bc90;
              if (0 < local_380) {
                _local_360 = ZEXT416((uint32)uStack_3a0._4_4_);
                fVar20 = 0.0;
                fVar34 = uStack_3a0._4_4_;
                do {
                  iVar18 = local_390;
                  uVar7 = String.get_Chars(text,local_390,0);
                  uVar16 = (uint32)uVar7;
                  local_384 = fVar29;
                  if (uVar7 == 10) {
                    if (NGUIText.alignment != 1) {
                      NGUIText.Align(verts,local_3b8);
                      local_3b8 = *(int *)(verts + 24);
                    }
                    local_3d4 = 0.0;
                    local_398 = 0;
                    local_3cc = fVar20 + NGUIText.finalLineHeight;
                    lVar12 = DAT_181d8bc90;
                    fVar29 = 0.0;
                    uVar30 = 0;
                    uVar31 = 0;
                    uVar32 = 0;
                    fVar35 = local_3cc;
                    uVar19 = local_398;
                  }
                  else {
                    lVar12 = DAT_181d8bc90;
                    fVar35 = fVar20;
                    uVar19 = (uint32)uVar7;
                    if (31 < uVar7) {
                      if (NGUIText.encoding) {
                        cVar6 = NGUIText.ParseSymbol
                                          (text,&local_390,
                                           NGUIText.mColors,
                                           NGUIText.premultiply,
                                           &local_394,&local_3d8,&local_3d7,&local_3d5,&local_3d6,
                                           local_3d0,0);
                        iVar18 = local_390;
                        cVar5 = local_3d8;
                        if (cVar6) {
                          if (local_3d0[0] == false) {
                            lVar12 = NGUIText.mColors;
                            if ((lVar12 == null) || (lVar13 = *(int64 *)(lVar12 + 16)) == null)
                            throw; // [null/range check failed]
                            if (*(uint32 *)(lVar13 + 24) <= *(int *)(lVar12 + 24) - 1U) {
                              uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar14,0);
                            }
                            _local_3a8 = *(uint8 (*) [16])
                                          (pStatics + 44);
                            puVar9 = (uint64 *)
                                     (lVar13 + ((int64)*(int *)(lVar12 + 24) + 1) * 16);
                            local_348 = *puVar9;
                            uStack_340 = puVar9[1];
                            pauVar10 = (uint8 (*) [16])Color.op_Multiply(local_158,local_3a8);
                            fVar36 = *(float *)(*pauVar10 + 12);
                            _local_3a8 = SUB1612(*pauVar10,0);
                            fVar34 = fVar36 * NGUIText.mAlpha;
                          }
                          else {
                            lVar12 = pStatics;
                            lVar13 = *(int64 *)(lVar12 + 176);
                            if ((lVar13 == null) || (lVar11 = *(int64 *)(lVar13 + 16)) == null)
                            throw; // [null/range check failed]
                            if (*(uint32 *)(lVar11 + 24) <= *(int *)(lVar13 + 24) - 1U) {
                              uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar14,0);
                            }
                            pauVar10 = (uint8 (*) [16])
                                       (lVar11 + ((int64)*(int *)(lVar13 + 24) + 1) * 16);
                            fVar36 = *(float *)(*pauVar10 + 12);
                            _local_3a8 = SUB1612(*pauVar10,0);
                            fVar34 = fVar36 * *(float *)(lVar12 + 184) * *(float *)(lVar12 + 56);
                          }
                          uStack_3a0._4_4_ = fVar34;
                          local_360._4_4_ = fVar36;
                          local_360._0_4_ = fVar34;
                          fStack_358 = fVar36;
                          fStack_354 = fVar36;
                          uVar16 = 0;
                          lVar12 = NGUIText.mColors;
                          if (lVar12 != null) {
                            iVar18 = *(int *)(lVar12 + 24) + -2;
                            lVar12 = DAT_181d8bc90;
                            if (0 < iVar18) {
                              do {
                                if (((*(byte *)(lVar12 + 0x133) & 4) != 0) &&
                                   (*(int *)(lVar12 + 224) == 0)) {
                                  il2cpp_runtime_class_init();
                                  lVar12 = DAT_181d8bc90;
                                }
                                lVar13 = *(int64 *)(plVar12 + 176);
                                if ((lVar13 == null) || (lVar13 = *(int64 *)(lVar13 + 16)) == null)
                                throw; // [null/range check failed]
                                if (*(uint32 *)(lVar13 + 24) <= uVar16) {
                                  uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar14,0);
                                }
                                lVar11 = (int64)(int)uVar16;
                                uVar16 = uVar16 + 1;
                                fVar34 = fVar34 * *(float *)(lVar13 + 44 + lVar11 * 16);
                                uStack_3a0._4_4_ = fVar34;
                                local_360._0_4_ = fVar34;
                              } while ((int)uVar16 < iVar18);
                            }
                            if (((*(byte *)(lVar12 + 0x133) & 4) != 0) && (*(int *)(lVar12 + 224) == 0))
                            {
                              il2cpp_runtime_class_init();
                              lVar12 = DAT_181d8bc90;
                            }
                            auVar23 = _local_3a8;
                            auVar27 = local_3a8;
                            auVar28 = auStack_3a4;
                            uVar21 = (float)uStack_3a0;
                            uVar22 = uStack_3a0._4_4_;
                            local_348 = local_3a8._0_8_;
                            uVar14 = local_348;
                            uStack_340 = local_3a8._8_8_;
                            uVar3 = uStack_340;
                            if (*(char *)(plVar12 + 80) != false) {
                              if (((*(byte *)(lVar12 + 0x133) & 4) != 0) && (*(int *)(lVar12 + 224) == 0)
                                 ) {
                                il2cpp_runtime_class_init();
                                lVar12 = DAT_181d8bc90;
                              }
                              local_338 = *(uint8 (*) [16])(plVar12 + 84);
                              local_328 = uVar14;
                              uStack_320 = uVar3;
                              puVar9 = (uint64 *)Color.op_Multiply(local_148,local_338,&local_328);
                              local_338 = auVar23;
                              local_328 = *puVar9;
                              uStack_320 = puVar9[1];
                              _local_3a8 = *(uint8 (*) [16])
                                            (pStatics + 100);
                              pauVar10 = (uint8 (*) [16])Color.op_Multiply(local_138,local_3a8);
                              local_338 = *pauVar10;
                              lVar12 = DAT_181d8bc90;
                            }
                            iVar18 = local_390 + -1;
                            uVar19 = local_398;
                            cVar5 = local_3d8;
                            goto LAB_180e070ba;
                          }
                          throw; // [null/range check failed]
                        }
                      }
                      if (!NGUIText.useSymbols) {
                        lVar12 = 0;
                      }
                      else {
                        lVar12 = NGUIText.GetSymbol(text,iVar18,local_380,0);
                      }
                      if (local_394 == 0) {
                        fVar33 = NGUIText.fontScale;
                      }
                      else {
                        fVar33 = NGUIText.fontScale * 0.75;
                      }
                      if (lVar12 == null) {
                        lVar13 = NGUIText.GetGlyph((uint32)uVar7,local_398);
                        lVar12 = DAT_181d8bc90;
                        fVar35 = local_3cc;
                        uVar19 = local_398;
                        if (lVar13 != null) {
                          fVar36 = *(float *)(lVar13 + 64);
                          uVar19 = (uint32)uVar7;
                          local_398 = uVar19;
                          if (local_394 != 0) {
                            if (local_394 == 1) {
                              fVar34 = (float)NGUIText.fontSize *
                                       NGUIText.fontScale * 0.4;
                              *(float *)(lVar13 + 20) = *(float *)(lVar13 + 20) - fVar34;
                              fVar34 = *(float *)(lVar13 + 28) - fVar34;
                            }
                            else {
                              fVar34 = (float)NGUIText.fontSize *
                                       NGUIText.fontScale * 0.05;
                              *(float *)(lVar13 + 20) = fVar34 + *(float *)(lVar13 + 20);
                              fVar34 = fVar34 + *(float *)(lVar13 + 28);
                            }
                            *(float *)(lVar13 + 28) = fVar34;
                          }
                          fVar34 = *(float *)(lVar13 + 20) - fVar20;
                          fVar38 = fVar29 + *(float *)(lVar13 + 16);
                          fVar36 = fVar36 + NGUIText.finalSpacingX;
                          fVar37 = fVar29 + *(float *)(lVar13 + 24);
                          fVar35 = *(float *)(lVar13 + 28) - fVar20;
                          if (local_378 < fVar36 + fVar29) {
                            if (fVar29 == 0.0) {
                              return;
                            }
                            if ((NGUIText.alignment != 1) &&
                               (local_3b8 < *(int *)(verts + 24))) {
                              auVar23._4_4_ = uVar30;
                              auVar23._0_4_ = fVar29;
                              auVar23._8_4_ = uVar31;
                              auVar23._12_4_ = uVar32;
                              auVar24._4_12_ = auVar23._4_12_;
                              auVar24._0_4_ =
                                   fVar29 - NGUIText.finalSpacingX;
                              NGUIText.Align(verts,local_3b8,auVar24._0_8_,4,0);
                              local_3b8 = *(int *)(verts + 24);
                            }
                            fVar38 = fVar38 - fVar29;
                            fVar37 = fVar37 - fVar29;
                            local_384 = 0.0;
                            fVar29 = NGUIText.finalLineHeight;
                            fVar20 = fVar20 + fVar29;
                            fVar34 = fVar34 - fVar29;
                            fVar35 = fVar35 - fVar29;
                            fVar29 = 0.0;
                            uVar30 = 0;
                            uVar31 = 0;
                            uVar32 = 0;
                            local_3cc = fVar20;
                          }
                          if (((uVar19 == 32) || (uVar7 - 0x200a < 2)) || (uVar19 == 0x2009)) {
                            if (!local_3d5) {
                              if (local_3d6) {
                                uVar16 = 45;
                              }
                            }
                            else {
                              uVar16 = 95;
                            }
                          }
                          fVar29 = fVar29 + fVar36;
                          if (local_394 != 0) {
                            local_3d4 = fVar29;
                            uVar14 = FUN_18000d7c0();
                            fVar29 = (float)uVar14;
                            uVar30 = (uint32)((uint64)uVar14 >> 32);
                            uVar31 = (uint32)extraout_XMM0_Qb;
                            uVar32 = (uint32)((uint64)extraout_XMM0_Qb >> 32);
                          }
                          local_3d4 = fVar29;
                          if (((uVar16 != 32) && (1 < uVar16 - 0x200a)) && (uVar16 != 0x2009)) {
                            if (uvs != null) {
                              if (NGUIText.bitmapFont != null) {
                                fVar36 = (float)FUN_180d98fc0(&local_370,0);
                                fVar29 = local_38c;
                                *(float *)(lVar13 + 32) = local_38c * *(float *)(lVar13 + 32) + fVar36
                                ;
                                fVar36 = (float)FUN_180d98fc0(&local_370,0);
                                *(float *)(lVar13 + 48) = fVar29 * *(float *)(lVar13 + 48) + fVar36;
                                fVar36 = (float)Rect.get_yMax(&local_370,0);
                                fVar29 = local_388;
                                *(float *)(lVar13 + 36) = fVar36 - local_388 * *(float *)(lVar13 + 36)
                                ;
                                fVar36 = (float)Rect.get_yMax(&local_370,0);
                                fVar36 = fVar36 - fVar29 * *(float *)(lVar13 + 52);
                                *(float *)(lVar13 + 52) = fVar36;
                                *(uint32 *)(lVar13 + 40) = *(uint32 *)(lVar13 + 32);
                                *(float *)(lVar13 + 44) = fVar36;
                                *(uint32 *)(lVar13 + 56) = *(uint32 *)(lVar13 + 48);
                                *(uint32 *)(lVar13 + 60) = *(uint32 *)(lVar13 + 36);
                              }
                              lVar12 = 1;
                              if (cVar5) {
                                lVar12 = 4;
                              }
                              do {
                                FUN_181829f90(uvs,*(uint64 *)(lVar13 + 32),DAT_181dab918);
                                FUN_181829f90(uvs,*(uint64 *)(lVar13 + 40),DAT_181dab918);
                                FUN_181829f90(uvs,*(uint64 *)(lVar13 + 48),DAT_181dab918);
                                FUN_181829f90(uvs,*(uint64 *)(lVar13 + 56),DAT_181dab918);
                                lVar12 = lVar12 + -1;
                              } while (lVar12 != null);
                            }
                            if (cols != null) {
                              if ((*(int *)(lVar13 + 68) == 0) || (*(int *)(lVar13 + 68) == 15)) {
                                if (!NGUIText.gradient) {
                                  lVar12 = 4;
                                  if (cVar5) {
                                    lVar12 = 16;
                                  }
                                  do {
                                    local_3c8._4_4_ = auVar28;
                                    local_3c8._0_4_ = auVar27;
                                    local_3c8._8_4_ = uVar21;
                                    local_3c8._12_4_ = uVar22;
                                    FUN_1817e9a90(cols,local_3c8,DAT_181d82e20);
                                    lVar12 = lVar12 + -1;
                                  } while (lVar12 != null);
                                }
                                else {
                                  fVar29 = *(float *)(lVar13 + 20);
                                  uVar3 = uStack_320;
                                  uVar14 = local_328;
                                  fVar26 = local_37c;
                                  fVar36 = *(float *)(lVar13 + 28);
                                  fVar25 = NGUIText.fontScale;
                                  local_3c8 = local_338;
                                  _local_3a8 = local_328;
                                  uStack_3a0 = uStack_320;
                                  puVar9 = (uint64 *)
                                           Color.Lerp(local_118,local_3a8,local_3c8,
                                                       (fVar29 / *(float *)(*(int64 *)
                                                                             (DAT_181d8bc90 + 184) + 28
                                                                           ) + local_37c) / local_37c,0);
                                  uStack_3a0 = uVar3;
                                  _local_3a8 = uVar14;
                                  uVar14 = puVar9[1];
                                  lVar12 = pStatics;
                                  *(uint64 *)(lVar12 + 0x100) = *puVar9;
                                  *(uint64 *)(lVar12 + 0x108) = uVar14;
                                  local_3c8 = local_338;
                                  puVar9 = (uint64 *)
                                           Color.Lerp(local_108,local_3a8,local_3c8,
                                                       (fVar36 / fVar25 + fVar26) / fVar26,0);
                                  uVar14 = puVar9[1];
                                  lVar12 = pStatics;
                                  lVar13 = 1;
                                  if (cVar5) {
                                    lVar13 = 4;
                                  }
                                  *(uint64 *)(lVar12 + 0x110) = *puVar9;
                                  *(uint64 *)(lVar12 + 0x118) = uVar14;
                                  do {
                                    local_3c8._0_8_ =
                                         NGUIText.s_c0;
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x108);
                                    FUN_1817e9a90(cols,local_3c8,DAT_181d82e20);
                                    local_3c8._0_8_ =
                                         NGUIText.s_c1;
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x118);
                                    FUN_1817e9a90(cols,local_3c8,DAT_181d82e20);
                                    local_3c8._0_8_ =
                                         NGUIText.s_c1;
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x118);
                                    FUN_1817e9a90(cols,local_3c8,DAT_181d82e20);
                                    local_3c8 = *(uint8 (*) [16])
                                                 (pStatics + 0x100);
                                    FUN_1817e9a90(cols,local_3c8,DAT_181d82e20);
                                    lVar13 = lVar13 + -1;
                                  } while (lVar13 != null);
                                }
                              }
                              else {
                                auStack_3a4 = auVar28;
                                local_3a8 = auVar27;
                                uStack_3a0._0_4_ = (float)uVar21;
                                uStack_3a0._4_4_ = (float)uVar22;
                                pauVar10 = (uint8 (*) [16])FUN_1810d3880(local_128,local_3a8);
                                iVar8 = *(int *)(lVar13 + 68);
                                _local_3a8 = *pauVar10;
                                if (iVar8 == 1) {
                                  uStack_3a0._0_4_ = (float)*(uint64 *)(*pauVar10 + 8);
                                  uStack_3a0._0_4_ = (float)uStack_3a0 + 0.51;
                                  _local_3a8 = *(uint64 *)*pauVar10;
                                }
                                else if (iVar8 == 2) {
                                  auStack_3a4 = SUB84((uint64)*(uint64 *)*pauVar10 >> 32,0);
                                  auStack_3a4 = (uint8  [4])((float)auStack_3a4 + 0.51);
                                  uStack_3a0 = *(uint64 *)(*pauVar10 + 8);
                                }
                                else if (iVar8 != 3) {
                                  if (iVar8 == 4) {
                                    local_3a8 = (uint8  [4])((float)local_3a8 + 0.51);
                                  }
                                  else if (iVar8 == 8) {
                                    uStack_3a0._4_4_ = uStack_3a0._4_4_ + 0.51;
                                  }
                                }
                                lVar12 = 4;
                                if (cVar5) {
                                  lVar12 = 16;
                                }
                                do {
                                  local_3c8 = _local_3a8;
                                  FUN_1817e9a90(cols,local_3c8,DAT_181d82e20);
                                  lVar12 = lVar12 + -1;
                                } while (lVar12 != null);
                              }
                            }
                            if (!cVar5) {
                              if (!local_3d7) {
                                local_160 = 0;
                                local_168 = fVar38;
                                local_164 = fVar34;
                                FUN_181816b80(verts,&local_168,DAT_181dabc18);
                                local_2d0 = 0;
                                local_2d8 = fVar38;
                                local_2d4 = fVar35;
                                FUN_181816b80(verts,&local_2d8,DAT_181dabc18);
                                local_2c0 = 0;
                                local_2c8 = fVar37;
                                local_2c4 = fVar35;
                                FUN_181816b80(verts,&local_2c8,DAT_181dabc18);
                                pfVar15 = &local_2b8;
                                local_2b0 = 0;
                                local_2b8 = fVar37;
                                local_2b4 = fVar34;
                              }
                              else {
                                local_1a0 = 0;
                                fVar29 = (float)NGUIText.fontSize;
                                fVar29 = ((fVar35 - fVar34) / fVar29) * fVar29 * 0.1;
                                local_1a8 = fVar38 - fVar29;
                                local_1a4 = fVar34;
                                FUN_181816b80(verts,&local_1a8,DAT_181dabc18);
                                local_198 = fVar29 + fVar38;
                                local_190 = 0;
                                local_194 = fVar35;
                                FUN_181816b80(verts,&local_198,DAT_181dabc18);
                                local_188 = fVar29 + fVar37;
                                local_180 = 0;
                                local_184 = fVar35;
                                FUN_181816b80(verts,&local_188,DAT_181dabc18);
                                local_178 = fVar37 - fVar29;
                                local_170 = 0;
                                pfVar15 = &local_178;
                                local_174 = fVar34;
                              }
                              FUN_181816b80(verts,pfVar15);
                            }
                            else {
                              uVar16 = 0;
                              do {
                                lVar12 = NGUIText.mBoldOffset;
                                if (lVar12 == null) throw; // [null/range check failed]
                                if (*(uint32 *)(lVar12 + 24) <= uVar16) {
                                  uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar14,0);
                                }
                                fVar29 = lVar12[uVar16];
                                lVar13 = (int64)(int)uVar16 + 1;
                                if (*(uint32 *)(lVar12 + 24) <= (uint32)lVar13) {
                                  uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar14,0);
                                }
                                fVar36 = *(float *)(lVar12 + 32 + lVar13 * 4);
                                if (!local_3d7) {
                                  fVar20 = 0.0;
                                }
                                else {
                                  fVar20 = (float)NGUIText.fontSize;
                                  fVar20 = ((fVar35 - fVar34) / fVar20) * fVar20 * 0.1;
                                }
                                local_1e0 = 0;
                                fVar25 = fVar29 + fVar38;
                                fVar26 = fVar36 + fVar34;
                                local_1e8 = fVar25 - fVar20;
                                local_1e4 = fVar26;
                                FUN_181816b80(verts,&local_1e8,DAT_181dabc18);
                                fVar36 = fVar36 + fVar35;
                                local_1d8 = fVar25 + fVar20;
                                local_1d0 = 0;
                                local_1d4 = fVar36;
                                FUN_181816b80(verts,&local_1d8,DAT_181dabc18);
                                fVar29 = fVar29 + fVar37;
                                local_1c0 = 0;
                                local_1c8 = fVar29 + fVar20;
                                local_1c4 = fVar36;
                                FUN_181816b80(verts,&local_1c8,DAT_181dabc18);
                                local_1b8 = fVar29 - fVar20;
                                local_1b0 = 0;
                                local_1b4 = fVar26;
                                FUN_181816b80(verts,&local_1b8);
                                uVar16 = uVar16 + 2;
                                fVar20 = local_3cc;
                              } while ((int)uVar16 < 8);
                            }
                            if (local_3d6 || local_3d5) {
                              uVar21 = 95;
                              if (local_3d6) {
                                uVar21 = 45;
                              }
                              lVar12 = NGUIText.GetGlyph(uVar21,local_398);
                              if (lVar12 != null) {
                                if (uvs != null) {
                                  if (NGUIText.bitmapFont != null) {
                                    fVar36 = (float)FUN_180d98fc0(&local_370,0);
                                    fVar29 = local_38c;
                                    *(float *)(lVar12 + 32) =
                                         local_38c * *(float *)(lVar12 + 32) + fVar36;
                                    fVar36 = (float)FUN_180d98fc0(&local_370,0);
                                    *(float *)(lVar12 + 48) =
                                         fVar29 * *(float *)(lVar12 + 48) + fVar36;
                                    fVar36 = (float)Rect.get_yMax(&local_370,0);
                                    fVar29 = local_388;
                                    *(float *)(lVar12 + 36) =
                                         fVar36 - local_388 * *(float *)(lVar12 + 36);
                                    fVar36 = (float)Rect.get_yMax(&local_370,0);
                                    *(float *)(lVar12 + 52) =
                                         fVar36 - fVar29 * *(float *)(lVar12 + 52);
                                  }
                                  lVar13 = 1;
                                  if (cVar5) {
                                    lVar13 = 4;
                                  }
                                  local_308 = (*(float *)(lVar12 + 48) + *(float *)(lVar12 + 32)) *
                                              0.5;
                                  local_300 = local_308;
                                  local_2f8 = local_308;
                                  local_2f0 = local_308;
                                  do {
                                    uStack_304 = *(uint32 *)(lVar12 + 36);
                                    FUN_181829f90(uvs,CONCAT44(uStack_304,local_308),DAT_181dab918);
                                    uStack_2fc = *(uint32 *)(lVar12 + 52);
                                    FUN_181829f90(uvs,CONCAT44(uStack_2fc,local_300),DAT_181dab918);
                                    uStack_2f4 = *(uint32 *)(lVar12 + 52);
                                    FUN_181829f90(uvs,CONCAT44(uStack_2f4,local_2f8),DAT_181dab918);
                                    uStack_2ec = *(uint32 *)(lVar12 + 36);
                                    FUN_181829f90(uvs,CONCAT44(uStack_2ec,local_2f0),DAT_181dab918);
                                    lVar13 = lVar13 + -1;
                                  } while (lVar13 != null);
                                }
                                fVar34 = local_384;
                                fVar36 = local_3d4;
                                fVar35 = -fVar20 + *(float *)(lVar12 + 20);
                                fVar20 = -fVar20 + *(float *)(lVar12 + 28);
                                if (!cVar5) {
                                  local_2a8 = local_384;
                                  local_2a0 = 0;
                                  local_2a4 = fVar35;
                                  FUN_181816b80(verts,&local_2a8,DAT_181dabc18);
                                  local_298 = fVar34;
                                  local_290 = 0;
                                  local_294 = fVar20;
                                  FUN_181816b80(verts,&local_298,DAT_181dabc18);
                                  fVar29 = local_3d4;
                                  local_288 = local_3d4;
                                  local_280 = 0;
                                  local_284 = fVar20;
                                  FUN_181816b80(verts,&local_288,DAT_181dabc18);
                                  local_278 = fVar29;
                                  local_270 = 0;
                                  local_274 = fVar35;
                                  FUN_181816b80(verts,&local_278,DAT_181dabc18);
                                }
                                else {
                                  uVar16 = 0;
                                  do {
                                    lVar13 = NGUIText.mBoldOffset;
                                    if (lVar13 == null) throw; // [null/range check failed]
                                    if (*(uint32 *)(lVar13 + 24) <= uVar16) {
                                      uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar14,0);
                                    }
                                    fVar29 = lVar13[uVar16];
                                    lVar11 = (int64)(int)uVar16 + 1;
                                    if (*(uint32 *)(lVar13 + 24) <= (uint32)lVar11) {
                                      uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar14,0);
                                    }
                                    fVar37 = *(float *)(lVar13 + 32 + lVar11 * 4);
                                    local_260 = 0;
                                    fVar25 = fVar37 + fVar35;
                                    fVar38 = fVar29 + fVar34;
                                    local_268 = fVar38;
                                    local_264 = fVar25;
                                    FUN_181816b80(verts,&local_268,DAT_181dabc18);
                                    fVar37 = fVar37 + fVar20;
                                    local_250 = 0;
                                    local_258 = fVar38;
                                    local_254 = fVar37;
                                    FUN_181816b80(verts,&local_258,DAT_181dabc18);
                                    fVar29 = fVar29 + fVar36;
                                    local_240 = 0;
                                    local_248 = fVar29;
                                    local_244 = fVar37;
                                    FUN_181816b80(verts,&local_248,DAT_181dabc18);
                                    local_230 = 0;
                                    local_238 = fVar29;
                                    local_234 = fVar25;
                                    FUN_181816b80(verts,&local_238,DAT_181dabc18);
                                    uVar16 = uVar16 + 2;
                                    fVar29 = local_3d4;
                                  } while ((int)uVar16 < 8);
                                }
                                uVar32 = 0;
                                uVar31 = 0;
                                uVar30 = 0;
                                uVar4 = uStack_320;
                                uVar3 = local_328;
                                auVar23 = local_338;
                                uVar14 = local_348;
                                if (!NGUIText.gradient) {
                                  auVar27 = (uint8  [4])(uint32)local_348;
                                  auVar28 = (uint8  [4])local_348._4_4_;
                                  uVar21 = (uint32)uStack_340;
                                  uVar22 = uStack_340._4_4_;
                                  iVar8 = 4;
                                  iVar17 = 0;
                                  if (cVar5) {
                                    iVar8 = 16;
                                    iVar17 = 0;
                                  }
                                  do {
                                    if (cols == null) throw; // [null/range check failed]
                                    local_3c8._8_4_ = uVar21;
                                    local_3c8._0_8_ = uVar14;
                                    local_3c8._12_4_ = uVar22;
                                    FUN_1817e9a90(cols,local_3c8);
                                    iVar17 = iVar17 + 1;
                                    fVar20 = local_3cc;
                                  } while (iVar17 < iVar8);
                                }
                                else {
                                  iVar8 = 0;
                                  local_3c8 = local_338;
                                  uStack_3a0 = uStack_320;
                                  _local_3a8 = local_328;
                                  fVar36 = (*(float *)(lVar12 + 28) / fVar33 + local_37c) / local_37c;
                                  puVar9 = (uint64 *)
                                           Color.Lerp(local_f8,local_3a8,local_3c8,
                                                       (*(float *)(lVar12 + 20) / fVar33 + local_37c) /
                                                       local_37c,0);
                                  uVar14 = *puVar9;
                                  uVar2 = puVar9[1];
                                  lVar12 = pStatics;
                                  local_3c8 = auVar23;
                                  uStack_3a0 = uVar4;
                                  _local_3a8 = uVar3;
                                  *(uint64 *)(lVar12 + 0x100) = uVar14;
                                  *(uint64 *)(lVar12 + 0x108) = uVar2;
                                  puVar9 = (uint64 *)
                                           Color.Lerp(local_e8,local_3a8,local_3c8,fVar36,0);
                                  uVar14 = puVar9[1];
                                  lVar12 = pStatics;
                                  iVar17 = 1;
                                  if (cVar5) {
                                    iVar17 = 4;
                                  }
                                  *(uint64 *)(lVar12 + 0x110) = *puVar9;
                                  *(uint64 *)(lVar12 + 0x118) = uVar14;
                                  do {
                                    if (cols == null) throw; // [null/range check failed]
                                    local_3c8._0_8_ =
                                         NGUIText.s_c0;
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x108);
                                    FUN_1817e9a90(cols,local_3c8,DAT_181d82e20);
                                    local_3c8._0_8_ =
                                         NGUIText.s_c1;
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x118);
                                    FUN_1817e9a90(cols,local_3c8,DAT_181d82e20);
                                    local_3c8._0_8_ =
                                         NGUIText.s_c1;
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x118);
                                    FUN_1817e9a90(cols,local_3c8,DAT_181d82e20);
                                    local_3c8 = *(uint8 (*) [16])
                                                 (pStatics + 0x100);
                                    FUN_1817e9a90(cols,local_3c8);
                                    iVar8 = iVar8 + 1;
                                  } while (iVar8 < iVar17);
                                  auVar27 = (uint8  [4])(uint32)local_348;
                                  auVar28 = (uint8  [4])local_348._4_4_;
                                  uVar21 = (uint32)uStack_340;
                                  uVar22 = uStack_340._4_4_;
                                  fVar20 = local_3cc;
                                }
                                goto LAB_180e070ae;
                              }
                            }
                            fVar29 = local_3d4;
                            fVar34 = (float)local_360._0_4_;
                            goto LAB_180e077a4;
                          }
        LAB_180e070ae:
                          lVar12 = DAT_181d8bc90;
                          fVar35 = fVar20;
                          fVar34 = (float)local_360._0_4_;
                          uVar19 = local_398;
                        }
                      }
                      else {
                        iVar8 = *(int *)(lVar12 + 48);
                        fVar37 = local_3d4;
                        fVar35 = NGUIText.fontScale;
                        fVar20 = -((float)*(int *)(lVar12 + 52) * fVar35 + fVar20);
                        fVar33 = (float)*(int *)(lVar12 + 64) * fVar33;
                        fVar38 = fVar20 - (float)*(int *)(lVar12 + 60) * fVar35;
                        fVar29 = (float)iVar8 * fVar35 + fVar29;
                        fVar35 = (float)*(int *)(lVar12 + 56) * fVar35 + fVar29;
                        if (fVar36 < fVar33 + local_3d4) {
                          if (local_3d4 == 0.0) {
                            return;
                          }
                          iVar8 = local_3b8;
                          if ((NGUIText.alignment != 1) &&
                             (local_3b8 < *(int *)(verts + 24))) {
                            NGUIText.Align(verts,iVar8,
                                            fVar37 - *(float *)(pStatics + 140
                                                               ),4,0);
                            local_3b8 = *(int *)(verts + 24);
                          }
                          fVar29 = fVar29 - fVar37;
                          fVar35 = fVar35 - fVar37;
                          local_3d4 = 0.0;
                          fVar36 = NGUIText.finalLineHeight;
                          local_3cc = local_3cc + fVar36;
                          fVar38 = fVar38 - fVar36;
                          fVar20 = fVar20 - fVar36;
                        }
                        local_220 = 0;
                        local_228 = fVar29;
                        local_224 = fVar38;
                        FUN_181816b80(verts,&local_228,DAT_181dabc18);
                        local_210 = 0;
                        local_218 = fVar29;
                        local_214 = fVar20;
                        FUN_181816b80(verts,&local_218,DAT_181dabc18);
                        local_200 = 0;
                        local_208 = fVar35;
                        local_204 = fVar20;
                        FUN_181816b80(verts,&local_208,DAT_181dabc18);
                        local_1f0 = 0;
                        local_1f8 = fVar35;
                        local_1f4 = fVar38;
                        FUN_181816b80(verts,&local_1f8);
                        fVar29 = local_3d4 +
                                 fVar33 + NGUIText.finalSpacingX;
                        local_3d4 = fVar29;
                        iVar8 = BMSymbol.get_length(lVar12,0);
                        local_398 = 0;
                        iVar18 = iVar18 + -1 + iVar8;
                        if (uvs != null) {
                          local_2e8 = *(uint64 *)(lVar12 + 68);
                          uStack_2e0 = *(uint64 *)(lVar12 + 76);
                          uVar21 = FUN_180d98fc0(&local_2e8,0);
                          uVar22 = FUN_18044df60(&local_2e8,0);
                          uVar30 = Rect.get_xMax(&local_2e8,0);
                          uVar31 = Rect.get_yMax(&local_2e8,0);
                          FUN_181829f90(uvs,CONCAT44(uVar22,uVar21),DAT_181dab918);
                          FUN_181829f90(uvs,CONCAT44(uVar31,uVar21),DAT_181dab918);
                          FUN_181829f90(uvs,CONCAT44(uVar31,uVar30),DAT_181dab918);
                          FUN_181829f90(uvs,CONCAT44(uVar22,uVar30));
                          fVar29 = local_3d4;
                        }
                        uVar32 = 0;
                        uVar31 = 0;
                        uVar30 = 0;
                        if (cols == null) {
        LAB_180e077a4:
                          uVar32 = 0;
                          uVar31 = 0;
                          uVar30 = 0;
                          lVar12 = DAT_181d8bc90;
                          auVar27 = (uint8  [4])(uint32)local_348;
                          auVar28 = (uint8  [4])local_348._4_4_;
                          uVar21 = (uint32)uStack_340;
                          uVar22 = uStack_340._4_4_;
                          fVar35 = local_3cc;
                          uVar19 = local_398;
                        }
                        else {
                          uVar14 = local_348;
                          if (NGUIText.symbolStyle == 2) {
                            auVar27 = (uint8  [4])(uint32)local_348;
                            auVar28 = (uint8  [4])local_348._4_4_;
                            uVar21 = (uint32)uStack_340;
                            uVar22 = uStack_340._4_4_;
                            lVar13 = 4;
                            do {
                              local_3c8._8_4_ = uVar21;
                              local_3c8._0_8_ = uVar14;
                              local_3c8._12_4_ = uVar22;
                              FUN_1817e9a90(cols,local_3c8);
                              lVar13 = lVar13 + -1;
                              lVar12 = DAT_181d8bc90;
                              fVar35 = local_3cc;
                              uVar19 = local_398;
                            } while (lVar13 != null);
                          }
                          else {
                            pauVar10 = (uint8 (*) [16])FUN_1810d3570(local_d8,0);
                            _local_3a8 = *pauVar10;
                            if (NGUIText.symbolStyle == 3) {
                              auVar27 = (uint8  [4])0xbf800000;
                              fVar36 = 0.0;
                            }
                            else {
                              auVar27 = local_3a8;
                              fVar36 = fVar34;
                            }
                            uVar21 = (float)uStack_3a0;
                            lVar12 = 4;
                            auVar28 = auStack_3a4;
                            local_318 = CONCAT44(auStack_3a4,auVar27);
                            uStack_310 = CONCAT44(fVar36,(float)uStack_3a0);
                            do {
                              local_3c8._4_4_ = auVar28;
                              local_3c8._0_4_ = auVar27;
                              local_3c8._8_4_ = uVar21;
                              local_3c8._12_4_ = fVar36;
                              FUN_1817e9a90(cols,local_3c8);
                              lVar12 = lVar12 + -1;
                            } while (lVar12 != null);
                            lVar12 = DAT_181d8bc90;
                            auVar27 = (uint8  [4])(uint32)local_348;
                            auVar28 = (uint8  [4])local_348._4_4_;
                            uVar21 = (uint32)uStack_340;
                            uVar22 = uStack_340._4_4_;
                            fVar35 = local_3cc;
                            uVar19 = local_398;
                          }
                        }
                      }
                    }
                  }
        LAB_180e070ba:
                  local_398 = uVar19;
                  local_390 = iVar18 + 1;
                  fVar20 = fVar35;
                  iVar18 = local_3b8;
                  fVar36 = local_378;
                } while (local_390 < local_380);
              }
              if (((*(byte *)(lVar12 + 0x133) & 4) != 0) && (*(int *)(lVar12 + 224) == 0)) {
                il2cpp_runtime_class_init();
                lVar12 = DAT_181d8bc90;
              }
              if ((*(int *)(plVar12 + 40) != 1) &&
                 (iVar18 < *(int *)(verts + 24))) {
                if (((*(byte *)(lVar12 + 0x133) & 4) != 0) && (*(int *)(lVar12 + 224) == 0)) {
                  il2cpp_runtime_class_init();
                }
                NGUIText.Align(verts,iVar18);
                lVar12 = DAT_181d8bc90;
              }
              if (((*(byte *)(lVar12 + 0x133) & 4) != 0) && (*(int *)(lVar12 + 224) == 0)) {
                il2cpp_runtime_class_init();
                lVar12 = DAT_181d8bc90;
              }
              lVar12 = *(int64 *)(plVar12 + 176);
              if (lVar12 != null) {
                BetterList_1.Clear(lVar12,DAT_181da6238);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60003C1
    // RVA   : 0xE03670   Offset: 0xE02A70   Length: 0x8C8
    public static void PrintApproximateCharacterPositions(string text, List<Vector3> verts, List<int> indices)
    {
        void NGUIText.PrintApproximateCharacterPositions
                     (int64 text,int64 verts,int64 indices)
        {
        int iVar1;
        char cVar2;
        uint16 uVar3;
        int64 lVar4;
        int iVar5;
        uint16 uVar6;
        int iVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        uint8 local_res8 [8];
        uint8 local_118;
        uint8 local_117;
        uint8 local_116;
        uint8 local_115;
        int local_114;
        int local_110;
        int local_10c;
        float local_108;
        float local_104;
        uint32 local_100;
        float local_f8;
        float local_f4;
        uint32 local_f0;
        float local_e8;
        float local_e4;
        uint32 local_e0;
        cVar2 = FUN_180d755b0(text,0);
        if (cVar2) {
          text = " ";
        }
        NGUIText.Prepare(text,0);
        fVar9 = 0.0;
        fVar11 = 0.0;
        fVar13 = (float)NGUIText.regionWidth + 0.01;
        if ((text != null) && (local_10c = *(int *)(text + 16), verts != null)) {
          iVar7 = *(int *)(verts + 24);
          uVar6 = 0;
          local_110 = 0;
          local_115 = 0;
          local_116 = 0;
          local_117 = 0;
          local_118 = 0;
          local_res8[0] = 0;
          local_114 = 0;
          if (0 < local_10c) {
            do {
              iVar5 = local_114;
              uVar3 = String.get_Chars(text,local_114,0);
              if (local_110 == 0) {
                fVar10 = NGUIText.fontScale;
              }
              else {
                fVar10 = NGUIText.fontScale * 0.75;
              }
              local_100 = 0;
              fVar12 = fVar10 * 0.5;
              local_104 = -fVar11 - fVar12;
              local_108 = fVar9;
              FUN_181816b80(verts,&local_108,DAT_181dabc18);
              if (indices == null) throw; // [null/range check failed]
              FUN_18182a0b0(indices,iVar5);
              if (uVar3 == 10) {
                if (NGUIText.alignment != 1) {
                  NGUIText.Align(verts,iVar7,
                                  fVar9 - NGUIText.finalSpacingX,1,0);
                  iVar7 = *(int *)(verts + 24);
                }
                fVar8 = 0.0;
                fVar11 = fVar11 + NGUIText.finalLineHeight;
        LAB_180e03e21:
                fVar9 = fVar8;
                uVar6 = 0;
              }
              else {
                fVar8 = fVar9;
                if (uVar3 < 32) goto LAB_180e03e21;
                if (!NGUIText.encoding) {
        LAB_180e039e2:
                  if (NGUIText.useSymbols) {
                    lVar4 = NGUIText.GetSymbol(text,iVar5,local_10c,0);
                    if (lVar4 != null) {
                      iVar1 = *(int *)(lVar4 + 64);
                      fVar10 = (float)iVar1 * fVar10 +
                               NGUIText.finalSpacingX;
                      fVar8 = fVar10 + fVar9;
                      if (fVar13 < fVar8) {
                        if (fVar9 == 0.0) {
                          return;
                        }
                        if ((NGUIText.alignment != 1) &&
                           (iVar7 < *(int *)(verts + 24))) {
                          NGUIText.Align(verts,iVar7,
                                          fVar9 - NGUIText.finalSpacingX,1
                                          ,0);
                          iVar7 = *(int *)(verts + 24);
                        }
                        fVar11 = fVar11 + NGUIText.finalLineHeight;
                        fVar8 = fVar10;
                      }
                      local_f0 = 0;
                      local_f4 = -fVar11 - fVar12;
                      local_f8 = fVar8;
                      FUN_181816b80(verts,&local_f8,DAT_181dabc18);
                      FUN_18182a0b0(indices,iVar5 + 1);
                      if (*(int64 *)(lVar4 + 16) != 0) {
                        iVar5 = iVar5 + *(int *)(*(int64 *)(lVar4 + 16) + 16) + -1;
                        goto LAB_180e03e21;
                      }
                      throw; // [null/range check failed]
                    }
                  }
                  fVar10 = (float)NGUIText.GetGlyphWidth(uVar3,uVar6,fVar10);
                  if (fVar10 != 0.0) {
                    fVar10 = fVar10 + NGUIText.finalSpacingX;
                    fVar8 = fVar10 + fVar9;
                    if (fVar13 < fVar8) {
                      if (fVar9 == 0.0) {
                        return;
                      }
                      if ((NGUIText.alignment != 1) &&
                         (iVar7 < *(int *)(verts + 24))) {
                        NGUIText.Align(verts,iVar7,
                                        fVar9 - NGUIText.finalSpacingX,1,0
                                       );
                        iVar7 = *(int *)(verts + 24);
                      }
                      fVar11 = fVar11 + NGUIText.finalLineHeight;
                      fVar8 = fVar10;
                    }
                    local_e0 = 0;
                    local_e4 = -fVar11 - fVar12;
                    local_e8 = fVar8;
                    FUN_181816b80(verts,&local_e8,DAT_181dabc18);
                    FUN_18182a0b0(indices,iVar5 + 1);
                    fVar9 = fVar8;
                    uVar6 = uVar3;
                  }
                }
                else {
                  cVar2 = NGUIText.ParseSymbol
                                    (text,&local_114,
                                     NGUIText.mColors,
                                     NGUIText.premultiply,
                                     &local_110,&local_115,&local_116,&local_117,&local_118,local_res8,0);
                  iVar5 = local_114;
                  if (!cVar2) goto LAB_180e039e2;
                  iVar5 = local_114 + -1;
                }
              }
              local_114 = iVar5 + 1;
            } while (local_114 < local_10c);
          }
          if ((NGUIText.alignment != 1) &&
             (iVar7 < *(int *)(verts + 24))) {
            NGUIText.Align(verts,iVar7,fVar9 - NGUIText.finalSpacingX,1
                            ,0);
          }
          return;
        }
    }

    // Token : 0x60003C2
    // RVA   : 0xE04FE0   Offset: 0xE043E0   Length: 0x7FE
    public static void PrintExactCharacterPositions(string text, List<Vector3> verts, List<int> indices)
    {
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        int iVar1;
        bool cVar2;
        ushort uVar3;
        long lVar4;
        int iVar5;
        ushort uVar6;
        int iVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        byte[] local_res8 = new byte[8];
        byte local_118;
        byte local_117;
        byte local_116;
        byte local_115;
        int local_114;
        int local_110;
        int local_10c;
        float local_108;
        float local_104;
        uint32 local_100;
        float local_f8;
        float local_f4;
        uint32 local_f0;
        float local_e8;
        float local_e4;
        uint32 local_e0;
        float local_d8;
        float local_d4;
        uint32 local_d0;
        cVar2 = FUN_180d755b0(text,0);
        if (cVar2) {
          text = " ";
        }
        NGUIText.Prepare(text,0);
        fVar10 = 0.0;
        fVar11 = 0.0;
        lVar4 = pStatics;
        fVar12 = (float)*(int *)(lVar4 + 68) + 0.01;
        fVar13 = (float)*(int *)(lVar4 + 24) * *(float *)(lVar4 + 28);
        if ((text == null) || (local_10c = *(int *)(text + 16), verts == null)) {
        LAB_180e057d9:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar7 = *(int *)(verts + 24);
        uVar6 = 0;
        local_110 = 0;
        local_115 = 0;
        local_116 = 0;
        local_117 = 0;
        local_118 = 0;
        local_res8[0] = 0;
        local_114 = 0;
        if (0 < local_10c) {
          do {
            iVar5 = local_114;
            uVar3 = String.get_Chars(text,local_114,0);
            if (local_110 == 0) {
              fVar8 = NGUIText.fontScale;
            }
            else {
              fVar8 = NGUIText.fontScale * 0.75;
            }
            if (uVar3 == 10) {
              if (NGUIText.alignment != 1) {
                NGUIText.Align(verts,iVar7,
                                fVar10 - NGUIText.finalSpacingX,2,0);
                iVar7 = *(int *)(verts + 24);
              }
              fVar9 = 0.0;
              fVar11 = fVar11 + NGUIText.finalLineHeight;
        LAB_180e056d3:
              fVar10 = fVar9;
              uVar6 = 0;
            }
            else {
              fVar9 = fVar10;
              if (uVar3 < 32) goto LAB_180e056d3;
              if (!NGUIText.encoding) {
        LAB_180e052eb:
                if (!NGUIText.useSymbols) {
        LAB_180e05449:
                  fVar8 = (float)NGUIText.GetGlyphWidth(uVar3,uVar6,fVar8);
                  if (fVar8 != 0.0) {
                    fVar8 = fVar8 + NGUIText.finalSpacingX + fVar10;
                    if (fVar12 < fVar8) goto LAB_180e05550;
                    if (indices == null) goto LAB_180e057d9;
                    FUN_18182a0b0(indices,iVar5,DAT_181d8f218);
                    local_e0 = 0;
                    local_e4 = -fVar11 - fVar13;
                    local_e8 = fVar10;
                    FUN_181816b80(verts,&local_e8,DAT_181dabc18);
                    local_d0 = 0;
                    local_d8 = fVar8;
                    local_d4 = -fVar11;
                    FUN_181816b80(verts,&local_d8);
                    fVar10 = fVar8;
                    uVar6 = uVar3;
                  }
                }
                else {
                  lVar4 = NGUIText.GetSymbol(text,iVar5,local_10c,0);
                  if (lVar4 == null) goto LAB_180e05449;
                  iVar1 = *(int *)(lVar4 + 64);
                  fVar9 = (float)iVar1 * fVar8 + NGUIText.finalSpacingX +
                          fVar10;
                  if (fVar9 <= fVar12) {
                    if (indices != null) {
                      FUN_18182a0b0(indices,iVar5,DAT_181d8f218);
                      local_100 = 0;
                      local_104 = -fVar11 - fVar13;
                      local_108 = fVar10;
                      FUN_181816b80(verts,&local_108,DAT_181dabc18);
                      local_f0 = 0;
                      local_f8 = fVar9;
                      local_f4 = -fVar11;
                      FUN_181816b80(verts,&local_f8);
                      if (*(int64 *)(lVar4 + 16) != 0) {
                        iVar5 = iVar5 + *(int *)(*(int64 *)(lVar4 + 16) + 16) + -1;
                        goto LAB_180e056d3;
                      }
                    }
                    goto LAB_180e057d9;
                  }
        LAB_180e05550:
                  if (fVar10 == 0.0) {
                    return;
                  }
                  if ((NGUIText.alignment != 1) &&
                     (iVar7 < *(int *)(verts + 24))) {
                    NGUIText.Align(verts,iVar7,
                                    fVar10 - NGUIText.finalSpacingX,2,0);
                    iVar7 = *(int *)(verts + 24);
                  }
                  iVar5 = iVar5 + -1;
                  fVar11 = fVar11 + NGUIText.finalLineHeight;
                  fVar10 = 0.0;
                  uVar6 = 0;
                }
              }
              else {
                cVar2 = NGUIText.ParseSymbol
                                  (text,&local_114,
                                   NGUIText.mColors,
                                   NGUIText.premultiply,&local_110,
                                   &local_115,&local_116,&local_117,&local_118,local_res8,0);
                iVar5 = local_114;
                if (!cVar2) goto LAB_180e052eb;
                iVar5 = local_114 + -1;
              }
            }
            local_114 = iVar5 + 1;
          } while (local_114 < local_10c);
        }
        if ((NGUIText.alignment != 1) &&
           (iVar7 < *(int *)(verts + 24))) {
          NGUIText.Align(verts,iVar7,fVar10 - NGUIText.finalSpacingX,2,
                          0);
        }
    }

    // Token : 0x60003C3
    // RVA   : 0xE03F40   Offset: 0xE03340   Length: 0x1090
    public static void PrintCaretAndSelection(string text, int start, int end, List<Vector3> caret, List<Vector3> highlight)
    {
        void NGUIText.PrintCaretAndSelection
                     (int64 text,uint32 start,uint32 end,uint64 caret,int64 highlight)
        {
        float fVar1;
        bool bVar2;
        bool bVar3;
        char cVar4;
        uint16 uVar5;
        uint64 uVar6;
        int64 lVar7;
        uint64 uVar8;
        float *pfVar9;
        int iVar10;
        uint32 uVar11;
        uint64 uVar12;
        uint32 uVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        float fVar17;
        float fVar18;
        float fVar19;
        float fVar20;
        float fVar21;
        float fVar22;
        float local_2b8;
        float local_2b4;
        uint32 local_2b0;
        uint8 local_2a8;
        uint8 local_2a7;
        uint8 local_2a6;
        uint8 local_2a5;
        uint8 local_2a4 [4];
        float local_2a0;
        float local_29c;
        uint32 local_298;
        uint32 local_294;
        uint32 local_290;
        uint64 local_28c;
        int local_284;
        int local_280 [2];
        uint64 local_278;
        uint32 local_270;
        uint32 local_260;
        float local_258;
        float local_254;
        uint32 local_250;
        float local_248;
        float local_244;
        uint32 local_240;
        float local_238;
        float local_234;
        uint32 local_230;
        float local_228;
        float local_224;
        uint32 local_220;
        float local_218;
        float local_214;
        uint32 local_210;
        float local_208;
        float local_204;
        uint32 local_200;
        float local_1f8;
        float local_1f4;
        uint32 local_1f0;
        float local_1e8;
        float local_1e4;
        uint32 local_1e0;
        float local_1d8;
        float local_1d4;
        uint32 local_1d0;
        float local_1c8;
        float local_1c4;
        uint32 local_1c0;
        float local_1b8;
        float local_1b4;
        uint32 local_1b0;
        float local_1a8;
        float local_1a4;
        uint32 local_1a0;
        float local_198;
        float local_194;
        uint32 local_190;
        uint64 local_188;
        uint32 local_180;
        uint64 local_178;
        uint32 local_170;
        uint64 local_168;
        uint32 local_160;
        uint64 local_158;
        uint32 local_150;
        uint64 local_148;
        uint32 local_140;
        uint32 local_130;
        uint32 local_120;
        uint32 local_110;
        uint32 local_100;
        uint32 local_f0;
        cVar4 = FUN_180d755b0(text,0);
        if (cVar4) {
          text = " ";
        }
        NGUIText.Prepare(text,0);
        fVar17 = 0.0;
        local_290 = end;
        if ((int)start <= (int)end) {
          local_290 = start;
        }
        fVar20 = 0.0;
        if ((int)start <= (int)end) {
          start = end;
        }
        uVar8 = 0;
        fVar21 = (float)NGUIText.fontSize *
                 NGUIText.fontScale;
        uVar11 = 0;
        if (caret == null) {
          local_294 = 0;
        }
        else {
          local_294 = *(uint32 *)(caret + 24);
        }
        uVar13 = uVar11;
        if (highlight != null) {
          uVar13 = *(uint32 *)(highlight + 24);
        }
        if (text == null) throw; // [null/range check failed]
        local_284 = *(int *)(text + 16);
        local_298 = 0;
        bVar2 = false;
        bVar3 = false;
        local_280[0] = 0;
        local_2a4[0] = 0;
        local_2a5 = 0;
        local_2a6 = 0;
        local_2a7 = 0;
        local_2a8 = 0;
        uVar6 = Vector2.get_zero();
        local_28c._0_4_ = (float)uVar6;
        fVar16 = (float)local_28c;
        local_28c._4_4_ = (float)((uint64)uVar6 >> 32);
        fVar19 = local_28c._4_4_;
        local_29c = (float)local_28c;
        local_2a0 = local_28c._4_4_;
        local_28c = uVar6;
        uVar6 = Vector2.get_zero(0);
        local_28c._4_4_ = (float)((uint64)uVar6 >> 32);
        local_28c._0_4_ = (float)uVar6;
        fVar22 = (float)local_28c;
        local_28c = CONCAT44(local_28c._4_4_,local_28c._4_4_);
        uVar12 = uVar8;
        fVar15 = local_28c._4_4_;
        if (0 < local_284) {
          do {
            iVar10 = (int)uVar8;
            if (local_280[0] == 0) {
              fVar14 = NGUIText.fontScale;
            }
            else {
              fVar14 = NGUIText.fontScale * 0.75;
            }
            if (((caret != null) && (!bVar3)) && ((int)end <= iVar10)) {
              bVar3 = true;
              fVar16 = -fVar20;
              local_250 = 0;
              local_258 = fVar17 - 1.0;
              local_254 = fVar16 - fVar21;
              FUN_181816b80(caret,&local_258,DAT_181dabc18);
              local_240 = 0;
              local_248 = fVar17 - 1.0;
              local_244 = fVar16;
              FUN_181816b80(caret,&local_248,DAT_181dabc18);
              local_230 = 0;
              local_238 = fVar17 + 1.0;
              local_234 = fVar16;
              FUN_181816b80(caret,&local_238,DAT_181dabc18);
              local_220 = 0;
              local_228 = fVar17 + 1.0;
              local_224 = fVar16 - fVar21;
              FUN_181816b80(caret,&local_228,DAT_181dabc18);
              fVar16 = local_29c;
              fVar19 = local_2a0;
            }
            uVar5 = String.get_Chars(text,uVar8,0);
            if (uVar5 == 10) {
              uVar12 = 0;
              uVar8 = caret;
              if ((bool)(bVar3 & caret != null)) {
                uVar8 = uVar12;
                if (NGUIText.alignment != 1) {
                  NGUIText.Align(caret,local_294,
                                  fVar17 - NGUIText.finalSpacingX,4,0);
                }
              }
              caret = uVar8;
              if (highlight != null) {
                if (bVar2) {
                  bVar2 = false;
                  local_f0 = 0;
                  local_148 = CONCAT44(fVar15,fVar22);
                  local_140 = 0;
                  FUN_181816b80(highlight,&local_148,DAT_181dabc18);
                  local_260 = 0;
                  pfVar9 = (float *)&local_278;
                  local_278 = CONCAT44(fVar19,fVar16);
                  local_270 = 0;
        LAB_180e04ad3:
                  FUN_181816b80(highlight,pfVar9);
                }
                else if (((int)local_290 <= iVar10) && (iVar10 < (int)start)) {
                  fVar16 = -fVar20;
                  local_1e0 = 0;
                  local_1e8 = fVar17;
                  local_1e4 = fVar16 - fVar21;
                  FUN_181816b80(highlight,&local_1e8,DAT_181dabc18);
                  local_1d0 = 0;
                  local_1d8 = fVar17;
                  local_1d4 = fVar16;
                  FUN_181816b80(highlight,&local_1d8,DAT_181dabc18);
                  local_1c0 = 0;
                  local_1c8 = fVar17 + 2.0;
                  local_1c4 = fVar16;
                  FUN_181816b80(highlight,&local_1c8,DAT_181dabc18);
                  pfVar9 = &local_2b8;
                  local_2b0 = 0;
                  local_2b8 = fVar17 + 2.0;
                  local_2b4 = fVar16 - fVar21;
                  goto LAB_180e04ad3;
                }
                if ((NGUIText.alignment != 1) &&
                   ((int)uVar13 < *(int *)(highlight + 24))) {
                  NGUIText.Align(highlight,uVar13,
                                  fVar17 - NGUIText.finalSpacingX,4,0);
                  uVar13 = *(uint32 *)(highlight + 24);
                }
              }
              fVar17 = 0.0;
              fVar20 = fVar20 + NGUIText.finalLineHeight;
              fVar16 = local_29c;
              fVar19 = local_2a0;
            }
            else if (uVar5 < 32) {
              uVar12 = 0;
            }
            else {
              if (NGUIText.encoding) {
                cVar4 = NGUIText.ParseSymbol
                                  (text,&local_298,
                                   NGUIText.mColors,
                                   NGUIText.premultiply,local_280,
                                   local_2a4,&local_2a5,&local_2a6,&local_2a7,&local_2a8,0);
                uVar8 = (uint64)local_298;
                if (cVar4) {
                  iVar10 = local_298 - 1;
                  goto LAB_180e04bb1;
                }
              }
              iVar10 = (int)uVar8;
              if (!NGUIText.useSymbols) {
        LAB_180e0446d:
                fVar14 = (float)NGUIText.GetGlyphWidth((uint32)uVar5,uVar12,fVar14);
              }
              else {
                lVar7 = NGUIText.GetSymbol(text,uVar8,local_284,0);
                if (lVar7 == null) goto LAB_180e0446d;
                fVar14 = (float)*(int *)(lVar7 + 64) * fVar14;
              }
              fVar19 = local_2a0;
              if (fVar14 != 0.0) {
                fVar15 = -fVar20;
                fVar16 = fVar14 + fVar17;
                fVar19 = fVar15 - fVar21;
                uVar8 = caret;
                fVar18 = fVar17;
                if ((float)NGUIText.regionWidth <
                    fVar16 + NGUIText.finalSpacingX) {
                  if (fVar17 == 0.0) {
                    return;
                  }
                  if ((bool)(bVar3 & caret != null)) {
                    uVar8 = 0;
                    if (NGUIText.alignment != 1) {
                      NGUIText.Align(caret,local_294,
                                      fVar17 - NGUIText.finalSpacingX,4,0)
                      ;
                    }
                  }
                  if (highlight != null) {
                    if (bVar2) {
                      bVar2 = false;
                      local_130 = 0;
                      local_188 = CONCAT44((float)local_28c,fVar22);
                      local_180 = 0;
                      FUN_181816b80(highlight,&local_188,DAT_181dabc18);
                      local_120 = 0;
                      pfVar9 = (float *)&local_178;
                      local_178 = CONCAT44(local_2a0,local_29c);
                      local_170 = 0;
        LAB_180e046d9:
                      FUN_181816b80(highlight,pfVar9);
                    }
                    else if (((int)local_290 <= iVar10) && (iVar10 < (int)start)) {
                      local_1a0 = 0;
                      local_1a8 = fVar17;
                      local_1a4 = fVar19;
                      FUN_181816b80(highlight,&local_1a8,DAT_181dabc18);
                      local_1b0 = 0;
                      local_1b8 = fVar17;
                      local_1b4 = fVar15;
                      FUN_181816b80(highlight,&local_1b8,DAT_181dabc18);
                      local_190 = 0;
                      local_198 = fVar17 + 2.0;
                      local_194 = fVar15;
                      FUN_181816b80(highlight,&local_198,DAT_181dabc18);
                      local_210 = 0;
                      pfVar9 = &local_218;
                      local_218 = fVar17 + 2.0;
                      local_214 = fVar19;
                      goto LAB_180e046d9;
                    }
                    if ((NGUIText.alignment != 1) &&
                       ((int)uVar13 < *(int *)(highlight + 24))) {
                      NGUIText.Align(highlight,uVar13,
                                      fVar17 - NGUIText.finalSpacingX,4,0)
                      ;
                      uVar13 = *(uint32 *)(highlight + 24);
                    }
                  }
                  fVar16 = fVar16 - fVar17;
                  fVar17 = fVar17 - fVar17;
                  fVar18 = 0.0;
                  fVar1 = NGUIText.finalLineHeight;
                  fVar19 = fVar19 - fVar1;
                  fVar15 = fVar15 - fVar1;
                  fVar20 = fVar20 + fVar1;
                }
                fVar1 = NGUIText.finalSpacingX;
                if (highlight != null) {
                  if ((iVar10 < (int)local_290) || ((int)start <= iVar10)) {
                    if (bVar2) {
                      bVar2 = false;
                      local_110 = 0;
                      local_168 = CONCAT44((float)local_28c,fVar22);
                      local_160 = 0;
                      FUN_181816b80(highlight,&local_168,DAT_181dabc18);
                      local_100 = 0;
                      pfVar9 = (float *)&local_158;
                      local_158 = CONCAT44(local_2a0,local_29c);
                      local_150 = 0;
                      goto LAB_180e048dd;
                    }
                  }
                  else if (!bVar2) {
                    bVar2 = true;
                    local_200 = 0;
                    local_208 = fVar17;
                    local_204 = fVar19;
                    FUN_181816b80(highlight,&local_208,DAT_181dabc18);
                    pfVar9 = &local_1f8;
                    local_1f0 = 0;
                    local_1f8 = fVar17;
                    local_1f4 = fVar15;
        LAB_180e048dd:
                    FUN_181816b80(highlight,pfVar9);
                  }
                }
                local_28c = CONCAT44(local_28c._4_4_,fVar15);
                uVar12 = (uint64)(uint32)uVar5;
                caret = uVar8;
                fVar17 = fVar18 + fVar14 + fVar1;
                fVar22 = fVar16;
                local_2a0 = fVar19;
                local_29c = fVar16;
              }
            }
        LAB_180e04bb1:
            uVar11 = iVar10 + 1;
            uVar8 = (uint64)uVar11;
            local_298 = uVar11;
          } while ((int)uVar11 < local_284);
        }
        if (caret != null) {
          if (!bVar3) {
            local_2b0 = 0;
            fVar16 = -fVar20;
            local_2b8 = fVar17 - 1.0;
            local_2b4 = fVar16 - fVar21;
            FUN_181816b80(caret,&local_2b8,DAT_181dabc18);
            local_2b0 = 0;
            local_2b8 = fVar17 - 1.0;
            local_2b4 = fVar16;
            FUN_181816b80(caret,&local_2b8,DAT_181dabc18);
            local_2b0 = 0;
            local_2b8 = fVar17 + 1.0;
            local_2b4 = fVar16;
            FUN_181816b80(caret,&local_2b8,DAT_181dabc18);
            local_2b0 = 0;
            local_2b8 = fVar17 + 1.0;
            local_2b4 = fVar16 - fVar21;
            FUN_181816b80(caret,&local_2b8,DAT_181dabc18);
          }
          if (NGUIText.alignment != 1) {
            NGUIText.Align(caret,local_294,
                            fVar17 - NGUIText.finalSpacingX,4,0);
          }
        }
        if (highlight != null) {
          if (bVar2) {
            local_260 = 0;
            local_278 = CONCAT44(fVar15,fVar22);
            local_270 = 0;
            FUN_181816b80(highlight,&local_278,DAT_181dabc18);
            local_260 = 0;
            pfVar9 = (float *)&local_278;
            local_278 = CONCAT44(local_2a0,local_29c);
            local_270 = 0;
        LAB_180e04e68:
            FUN_181816b80(highlight,pfVar9,DAT_181dabc18);
          }
          else if (((int)local_290 < (int)uVar11) && (start == uVar11)) {
            fVar20 = -fVar20;
            local_2b0 = 0;
            local_2b8 = fVar17;
            local_2b4 = fVar20 - fVar21;
            FUN_181816b80(highlight,&local_2b8,DAT_181dabc18);
            local_2b0 = 0;
            local_2b8 = fVar17;
            local_2b4 = fVar20;
            FUN_181816b80(highlight,&local_2b8,DAT_181dabc18);
            local_2b0 = 0;
            local_2b8 = fVar17 + 2.0;
            local_2b4 = fVar20;
            FUN_181816b80(highlight,&local_2b8,DAT_181dabc18);
            pfVar9 = &local_2b8;
            local_2b0 = 0;
            local_2b8 = fVar17 + 2.0;
            local_2b4 = fVar20 - fVar21;
            goto LAB_180e04e68;
          }
          if ((NGUIText.alignment != 1) &&
             ((int)uVar13 < *(int *)(highlight + 24))) {
            NGUIText.Align(highlight,uVar13,fVar17 - NGUIText.finalSpacingX
                            ,4,0);
          }
        }
        lVar7 = NGUIText.mColors;
        if (lVar7 != null) {
          BetterList_1.Clear(lVar7,DAT_181da6238);
          return;
        }
    }

    // Token : 0x60003C4
    // RVA   : 0xE07A50   Offset: 0xE06E50   Length: 0x6D6
    public static bool ReplaceLink(ref string text, ref int index, string type, string prefix, string suffix)
    {
        uint64
        NGUIText.ReplaceLink
                (int64 *text,int *index,int64 type,uint64 prefix,uint64 suffix)
        {
        char cVar1;
        short sVar2;
        int iVar3;
        int iVar4;
        uint64 uVar5;
        int64 lVar6;
        int64 lVar7;
        int64 lVar8;
        int64 *plVar9;
        int64 lVar10;
        int iVar11;
        if (*index == -1) {
          return false;
        }
        if (*text != null) {
          iVar3 = String.IndexOf(*text,type,*index,0);
          *index = iVar3;
          if (iVar3 == -1) {
            return false;
          }
          if (5 < iVar3) {
            iVar11 = iVar3 + -5;
            iVar3 = iVar3 + -3;
            do {
              if (*text == null) throw; // [null/range check failed]
              sVar2 = String.get_Chars(*text,iVar11,0);
              if (sVar2 == 91) {
                if (*text == null) throw; // [null/range check failed]
                sVar2 = String.get_Chars(*text,iVar3 + -1,0);
                if (sVar2 == 117) {
                  if (*text == null) throw; // [null/range check failed]
                  sVar2 = String.get_Chars(*text,iVar3,0);
                  if (sVar2 == 114) {
                    if (*text == null) throw; // [null/range check failed]
                    sVar2 = String.get_Chars(*text,iVar3 + 1,0);
                    if (sVar2 == 108) {
                      if (*text == null) throw; // [null/range check failed]
                      sVar2 = String.get_Chars(*text,iVar3 + 2,0);
                      if (sVar2 == 61) {
                        if (type != null) {
                          *index = *index + *(int *)(type + 16);
                          uVar5 = NGUIText.ReplaceLink(text,index,type,prefix,suffix,0);
                          return uVar5;
                        }
                        throw; // [null/range check failed]
                      }
                    }
                  }
                }
                if (*text == null) throw; // [null/range check failed]
                sVar2 = String.get_Chars(*text,iVar3 + -1,0);
                if (sVar2 == 47) {
                  if (*text == null) throw; // [null/range check failed]
                  sVar2 = String.get_Chars(*text,iVar3,0);
                  if (sVar2 == 117) {
                    if (*text == null) throw; // [null/range check failed]
                    sVar2 = String.get_Chars(*text,iVar3 + 1,0);
                    if (sVar2 == 114) {
                      if (*text == null) throw; // [null/range check failed]
                      sVar2 = String.get_Chars(*text,iVar3 + 2,0);
                      if (sVar2 == 108) break;
                    }
                  }
                }
              }
              iVar3 = iVar3 + -1;
              iVar11 = iVar11 + -1;
            } while (-1 < iVar11);
          }
          if (type != null) {
            iVar3 = *index + *(int *)(type + 16);
            lVar7 = *text;
            uVar5 = FUN_1800d60b0(DAT_181da1040,5);
            RuntimeHelpers.InitializeArray(uVar5,DAT_181dbafd8,0);
            if (lVar7 != null) {
              iVar11 = String.IndexOfAny(lVar7,uVar5,iVar3,0);
              if (iVar11 == -1) {
                if (*text == null) throw; // [null/range check failed]
                iVar11 = *(int *)(*text + 16);
              }
              lVar7 = *text;
              lVar6 = FUN_1800d60b0(DAT_181da1040,2);
              if (lVar6 != null) {
                if (*(uint32 *)(lVar6 + 24) == 0) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                *(uint16 *)(lVar6 + 32) = 47;
                if (*(uint32 *)(lVar6 + 24) < 2) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                *(uint16 *)(lVar6 + 34) = 32;
                if (lVar7 != null) {
                  iVar4 = String.IndexOfAny(lVar7,lVar6,iVar3,0);
                  if ((iVar4 == -1) || (iVar4 == iVar3)) {
                    *index = *index + *(int *)(type + 16);
                    return true;
                  }
                  if (*text != null) {
                    lVar7 = String.Substring(*text,0,*index,0);
                    if (*text != null) {
                      lVar6 = String.Substring(*text,*index,iVar11 - *index,0);
                      if (*text != null) {
                        uVar5 = String.Substring(*text,iVar11,0);
                        if (*text != null) {
                          lVar8 = String.Substring(*text,iVar3,iVar4 - iVar3,0);
                          cVar1 = FUN_180d755b0(prefix,0);
                          if (!cVar1) {
                            lVar7 = String.Concat(lVar7,prefix,0);
                          }
                          plVar9 = (int64 *)FUN_1800d60b0(DAT_181da5ce0,6);
                          if (plVar9 != (int64 *)0) {
                            if ((lVar7 != null) &&
                               (lVar10 = il2cpp_internal(lVar7,*(uint64 *)(*plVar9 + 64)),
                               lVar10 == null)) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            if ((int)plVar9[3] == 0) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            plVar9[4] = lVar7;
                            il2cpp_internal(plVar9 + 4,lVar7);
                            if (("[url=" != 0) &&
                               (lVar7 = il2cpp_internal("[url=",*(uint64 *)(*plVar9 + 64))
                               , lVar7 == null)) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            lVar7 = "[url=";
                            if (*(uint32 *)(plVar9 + 3) < 2) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            plVar9[5] = "[url=";
                            il2cpp_internal(plVar9 + 5,lVar7);
                            if ((lVar6 != null) &&
                               (lVar7 = il2cpp_internal(lVar6,*(uint64 *)(*plVar9 + 64)),
                               lVar7 == null)) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            if (*(uint32 *)(plVar9 + 3) < 3) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            plVar9[6] = lVar6;
                            il2cpp_internal(plVar9 + 6,lVar6);
                            if (("][u]" != 0) &&
                               (lVar7 = il2cpp_internal("][u]",*(uint64 *)(*plVar9 + 64))
                               , lVar7 == null)) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            lVar7 = "][u]";
                            if (*(uint32 *)(plVar9 + 3) < 4) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            plVar9[7] = "][u]";
                            il2cpp_internal(plVar9 + 7,lVar7);
                            if ((lVar8 != null) &&
                               (lVar7 = il2cpp_internal(lVar8,*(uint64 *)(*plVar9 + 64)),
                               lVar7 == null)) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            if (*(uint32 *)(plVar9 + 3) < 5) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            plVar9[8] = lVar8;
                            il2cpp_internal(plVar9 + 8,lVar8);
                            if (("[/u][/url]" != 0) &&
                               (lVar7 = il2cpp_internal("[/u][/url]",*(uint64 *)(*plVar9 + 64))
                               , lVar7 == null)) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            lVar7 = "[/u][/url]";
                            if (*(uint32 *)(plVar9 + 3) < 6) {
                              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar5,0);
                            }
                            plVar9[9] = "[/u][/url]";
                            il2cpp_internal(plVar9 + 9,lVar7);
                            lVar7 = String.Concat(plVar9,0);
                            *text = lVar7;
                            il2cpp_internal(text,lVar7);
                            if (*text != null) {
                              *index = *(int *)(*text + 16);
                              cVar1 = FUN_180d755b0(suffix,0);
                              if (!cVar1) {
                                lVar7 = String.Concat(*text,suffix,uVar5,0);
                              }
                              else {
                                lVar7 = String.Concat(*text,uVar5,0);
                              }
                              *text = lVar7;
                              il2cpp_internal(text,lVar7);
                              return true;
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

    // Token : 0x60003C5
    // RVA   : 0xE01EB0   Offset: 0xE012B0   Length: 0x384
    public static bool InsertHyperlink(ref string text, ref int index, string keyword, string link, string prefix, string suffix)
    {
        uint64
        NGUIText.InsertHyperlink
                (int64 *text,int *index,int64 keyword,uint64 link,uint64 prefix,
                uint64 suffix)
        {
        char cVar1;
        short sVar2;
        int iVar3;
        uint64 uVar4;
        uint64 uVar5;
        uint64 uVar6;
        uint64 uVar7;
        int64 lVar8;
        int iVar9;
        int iVar10;
        if (*text != null) {
          iVar3 = String.IndexOf(*text,keyword,*index,1,0);
          if (iVar3 == -1) {
            return false;
          }
          if (5 < iVar3) {
            iVar9 = iVar3 + -5;
            iVar10 = iVar3 + -3;
            do {
              if (*text == null) throw; // [null/range check failed]
              sVar2 = String.get_Chars(*text,iVar9,0);
              if (sVar2 == 91) {
                if (*text == null) throw; // [null/range check failed]
                sVar2 = String.get_Chars(*text,iVar10 + -1,0);
                if (sVar2 == 117) {
                  if (*text == null) throw; // [null/range check failed]
                  sVar2 = String.get_Chars(*text,iVar10,0);
                  if (sVar2 == 114) {
                    if (*text == null) throw; // [null/range check failed]
                    sVar2 = String.get_Chars(*text,iVar10 + 1,0);
                    if (sVar2 == 108) {
                      if (*text == null) throw; // [null/range check failed]
                      sVar2 = String.get_Chars(*text,iVar10 + 2,0);
                      if (sVar2 == 61) {
                        if (keyword != null) {
                          *index = *(int *)(keyword + 16) + iVar3;
                          uVar4 = NGUIText.InsertHyperlink
                                            (text,index,keyword,link,prefix,suffix,0);
                          return uVar4;
                        }
                        throw; // [null/range check failed]
                      }
                    }
                  }
                }
                if (*text == null) throw; // [null/range check failed]
                sVar2 = String.get_Chars(*text,iVar10 + -1,0);
                if (sVar2 == 47) {
                  if (*text == null) throw; // [null/range check failed]
                  sVar2 = String.get_Chars(*text,iVar10,0);
                  if (sVar2 == 117) {
                    if (*text == null) throw; // [null/range check failed]
                    sVar2 = String.get_Chars(*text,iVar10 + 1,0);
                    if (sVar2 == 114) {
                      if (*text == null) throw; // [null/range check failed]
                      sVar2 = String.get_Chars(*text,iVar10 + 2,0);
                      if (sVar2 == 108) break;
                    }
                  }
                }
              }
              iVar10 = iVar10 + -1;
              iVar9 = iVar9 + -1;
            } while (-1 < iVar9);
          }
          if (*text != null) {
            uVar4 = String.Substring(*text,0,iVar3,0);
            uVar5 = String.Concat("[url=",link,"][u]",0);
            if ((keyword != null) && (*text != null)) {
              uVar6 = String.Substring(*text,iVar3,*(uint32 *)(keyword + 16),0);
              cVar1 = FUN_180d755b0(prefix,0);
              if (!cVar1) {
                uVar6 = String.Concat(prefix,uVar6,0);
              }
              cVar1 = FUN_180d755b0(suffix,0);
              if (!cVar1) {
                uVar6 = String.Concat(uVar6,suffix,0);
              }
              if (*text != null) {
                uVar7 = String.Substring(*text,*(int *)(keyword + 16) + iVar3,0);
                lVar8 = String.Concat(uVar4,uVar5,uVar6,"[/u][/url]",0);
                *text = lVar8;
                il2cpp_internal(text,lVar8);
                if (*text != null) {
                  *index = *(int *)(*text + 16);
                  lVar8 = String.Concat(*text,uVar7,0);
                  *text = lVar8;
                  il2cpp_internal(text,lVar8);
                  return true;
                }
              }
            }
          }
        }
    }

    // Token : 0x60003C6
    // RVA   : 0xE08130   Offset: 0xE07530   Length: 0x13F
    public static void ReplaceLinks(ref string text, string prefix, string suffix)
    {
        long lVar1;
        int iVar2;
        bool cVar3;
        int[] local_res8 = new int[2];
        int[] local_18 = new int[4];
        lVar1 = *text;
        local_18[0] = 0;
        local_res8[0] = 0;
        while( true ) {
          if (lVar1 == null) throw; // [null/range check failed]
          if (*(int *)(lVar1 + 16) <= local_res8[0]) break;
          cVar3 = NGUIText.ReplaceLink(text,local_res8,"http://",prefix,suffix,0);
          if (!cVar3) break;
          lVar1 = *text;
        }
        lVar1 = *text;
        iVar2 = 0;
        while (lVar1 != null) {
          if (*(int *)(lVar1 + 16) <= iVar2) {
            return;
          }
          cVar3 = NGUIText.ReplaceLink(text,local_18,"https://",prefix,suffix,0);
          if (!cVar3) {
            return;
          }
          iVar2 = local_18[0];
          lVar1 = *text;
        }
    }

    // Token : 0x60003C7
    // RVA   : 0xE0A940   Offset: 0xE09D40   Length: 0x3B7
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        long lVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar5;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        uVar5 = new c.DisplayClass9_0(0);
        NGUIText.glyph = uVar5;
        NGUIText.fontSize = 16;
        NGUIText.fontScale = 0x3f800000;
        NGUIText.pixelDensity = 0x3f800000;
        NGUIText.fontStyle = 0;
        NGUIText.alignment = 1;
        puVar6 = (uint32 *)FUN_1810d3570(local_18,0);
        uVar2 = puVar6[1];
        uVar3 = puVar6[2];
        uVar4 = puVar6[3];
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 44) = *puVar6;
        *(uint32 *)(lVar1 + 48) = uVar2;
        *(uint32 *)(lVar1 + 52) = uVar3;
        *(uint32 *)(lVar1 + 56) = uVar4;
        NGUIText.rectWidth = 1000000;
        NGUIText.rectHeight = 1000000;
        NGUIText.regionWidth = 1000000;
        NGUIText.regionHeight = 1000000;
        NGUIText.maxLines = 0;
        NGUIText.gradient = 0;
        puVar6 = (uint32 *)FUN_1810d3570(local_18,0);
        uVar2 = puVar6[1];
        uVar3 = puVar6[2];
        uVar4 = puVar6[3];
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 84) = *puVar6;
        *(uint32 *)(lVar1 + 88) = uVar2;
        *(uint32 *)(lVar1 + 92) = uVar3;
        *(uint32 *)(lVar1 + 96) = uVar4;
        puVar7 = (uint64 *)FUN_1810d3570(local_18,0);
        uVar5 = puVar7[1];
        lVar1 = pStatics;
        *(uint64 *)(lVar1 + 100) = *puVar7;
        *(uint64 *)(lVar1 + 108) = uVar5;
        NGUIText.encoding = 0;
        NGUIText.spacingX = 0;
        NGUIText.spacingY = 0;
        NGUIText.premultiply = 0;
        NGUIText.finalSize = 0;
        NGUIText.finalSpacingX = 0;
        NGUIText.finalLineHeight = 0;
        NGUIText.baseline = 0;
        NGUIText.useSymbols = 0;
        local_28 = 0;
        uStack_20 = 0;
        FUN_1809dc910(&local_28,lVar1,0,0,0,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 156) = (uint32)local_28;
        *(uint32 *)(lVar1 + 160) = local_28._4_4_;
        *(uint32 *)(lVar1 + 164) = (uint32)uStack_20;
        *(uint32 *)(lVar1 + 168) = uStack_20._4_4_;
        uVar5 = new BetterList_1(DAT_181da6138);
        NGUIText.mColors = uVar5;
        NGUIText.mAlpha = 0x3f800000;
        uVar5 = new BetterList_1(DAT_181da6338);
        NGUIText.mSizes = uVar5;
        uVar5 = FUN_1800d60b0(DAT_181da5360,8);
        RuntimeHelpers.InitializeArray(uVar5,DAT_181dbaf50,0);
        NGUIText.mBoldOffset = uVar5;
    }

}
