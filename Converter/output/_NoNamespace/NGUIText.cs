// ============================================================
// Type  : NGUIText
// Token : 0x2000086
// ============================================================

public class NGUIText
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000313
    public static INGUIFont bitmapFont;

    // Token: 0x4000314
    public static Font dynamicFont;

    // Token: 0x4000315
    public static GlyphInfo glyph;

    // Token: 0x4000316
    public static int fontSize;

    // Token: 0x4000317
    public static float fontScale;

    // Token: 0x4000318
    public static float pixelDensity;

    // Token: 0x4000319
    public static FontStyle fontStyle;

    // Token: 0x400031A
    public static Alignment alignment;

    // Token: 0x400031B
    public static Color tint;

    // Token: 0x400031C
    public static int rectWidth;

    // Token: 0x400031D
    public static int rectHeight;

    // Token: 0x400031E
    public static int regionWidth;

    // Token: 0x400031F
    public static int regionHeight;

    // Token: 0x4000320
    public static int maxLines;

    // Token: 0x4000321
    public static bool gradient;

    // Token: 0x4000322
    public static Color gradientBottom;

    // Token: 0x4000323
    public static Color gradientTop;

    // Token: 0x4000324
    public static bool encoding;

    // Token: 0x4000325
    public static float spacingX;

    // Token: 0x4000326
    public static float spacingY;

    // Token: 0x4000327
    public static bool premultiply;

    // Token: 0x4000328
    public static SymbolStyle symbolStyle;

    // Token: 0x4000329
    public static int finalSize;

    // Token: 0x400032A
    public static float finalSpacingX;

    // Token: 0x400032B
    public static float finalLineHeight;

    // Token: 0x400032C
    public static float baseline;

    // Token: 0x400032D
    public static bool useSymbols;

    // Token: 0x400032E
    private static Color mInvisible;

    // Token: 0x400032F
    private static BetterList<Color> mColors;

    // Token: 0x4000330
    private static float mAlpha;

    // Token: 0x4000331
    private static CharacterInfo mTempChar;

    // Token: 0x4000332
    private static BetterList<float> mSizes;

    // Token: 0x4000333
    private static StringBuilder mSB;

    // Token: 0x4000334
    private static Color s_c0;

    // Token: 0x4000335
    private static Color s_c1;

    // Token: 0x4000336
    private const float sizeShrinkage;

    // Token: 0x4000337
    private static float[] mBoldOffset;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000389
    // RVA   : 0x1591DF0   Offset: 0x15905F0   Length: 0x5B
    public static bool get_isDynamic()
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        return CONCAT71((int7)((uint64)pStatics >> 8),
                        *pStatics == 0);
    }

    // Token : 0x600038A
    // RVA   : 0x158F4D0   Offset: 0x158DCD0   Length: 0x4B
    public static void Update()
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        uint uVar6;
        int iVar7;
        int iVar8;
        uVar6 = Mathf.RoundToInt((float)*(int *)(pStatics + 24) /
                                  *(float *)(pStatics + 32),0);
        *(uint32 *)(pStatics + 136) = uVar6;
        lVar1 = pStatics;
        *(float *)(lVar1 + 140) = *(float *)(lVar1 + 120) * *(float *)(lVar1 + 28);
        lVar1 = pStatics;
        *(float *)(lVar1 + 144) =
             ((float)*(int *)(lVar1 + 24) + *(float *)(lVar1 + 124)) * *(float *)(lVar1 + 28);
        uVar2 = *(uint64 *)(pStatics + 8);
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (!cVar4) {
          if (*pStatics != 0) goto LAB_18158f684;
        LAB_18158f6af:
          bVar9 = false;
        }
        else {
        LAB_18158f684:
          if (*(char *)(pStatics + 116) == false) goto LAB_18158f6af;
          bVar9 = *(int *)(pStatics + 132) != 0;
        }
        *(bool *)(pStatics + 152) = bVar9;
        lVar1 = *(int64 *)(pStatics + 8);
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
                  (lVar1,")_-",*(uint32 *)(pStatics + 136),
                   *(uint32 *)(pStatics + 36),0);
        lVar3 = pStatics;
        cVar4 = Font.GetCharacterInfo
                          (lVar1,41,lVar3 + 188,*(uint32 *)(lVar3 + 136),
                           CONCAT44(uVar6,*(uint32 *)(lVar3 + 36)),0);
        if (cVar4) {
          iVar7 = CharacterInfo.get_maxY(pStatics + 188,0);
          if ((float)iVar7 != 0.0) goto LAB_18158f8cd;
        }
        uVar6 = 0;
        Font.RequestCharactersInTexture
                  (lVar1,"A",*(uint32 *)(pStatics + 136),
                   *(uint32 *)(pStatics + 36),0);
        lVar3 = pStatics;
        cVar4 = Font.GetCharacterInfo
                          (lVar1,65,lVar3 + 188,*(uint32 *)(lVar3 + 136),
                           CONCAT44(uVar6,*(uint32 *)(lVar3 + 36)),0);
        if (!cVar4) {
          *(uint32 *)(pStatics + 148) = 0;
          return;
        }
        LAB_18158f8cd:
        iVar7 = CharacterInfo.get_maxY(pStatics + 188,0);
        iVar8 = CharacterInfo.get_minY(pStatics + 188,0);
        uVar6 = FUN_18000d7c0((((float)*(int *)(pStatics + 136) - (float)iVar7
                               ) + (float)iVar8) * 0.5 + (float)iVar7);
        *(uint32 *)(pStatics + 148) = uVar6;
    }

    // Token : 0x600038B
    // RVA   : 0x158F520   Offset: 0x158DD20   Length: 0x4B3
    public static void Update(bool request)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        uint uVar6;
        int iVar7;
        int iVar8;
        uVar6 = Mathf.RoundToInt((float)*(int *)(pStatics + 24) /
                                  *(float *)(pStatics + 32),0);
        *(uint32 *)(pStatics + 136) = uVar6;
        lVar1 = pStatics;
        *(float *)(lVar1 + 140) = *(float *)(lVar1 + 120) * *(float *)(lVar1 + 28);
        lVar1 = pStatics;
        *(float *)(lVar1 + 144) =
             ((float)*(int *)(lVar1 + 24) + *(float *)(lVar1 + 124)) * *(float *)(lVar1 + 28);
        uVar2 = *(uint64 *)(pStatics + 8);
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (!cVar4) {
          if (*pStatics != 0) goto LAB_18158f684;
        LAB_18158f6af:
          bVar9 = false;
        }
        else {
        LAB_18158f684:
          if (*(char *)(pStatics + 116) == false) goto LAB_18158f6af;
          bVar9 = *(int *)(pStatics + 132) != 0;
        }
        *(bool *)(pStatics + 152) = bVar9;
        lVar1 = *(int64 *)(pStatics + 8);
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
                  (lVar1,")_-",*(uint32 *)(pStatics + 136),
                   *(uint32 *)(pStatics + 36),0);
        lVar3 = pStatics;
        cVar4 = Font.GetCharacterInfo
                          (lVar1,41,lVar3 + 188,*(uint32 *)(lVar3 + 136),
                           CONCAT44(uVar6,*(uint32 *)(lVar3 + 36)),0);
        if (cVar4) {
          iVar7 = CharacterInfo.get_maxY(pStatics + 188,0);
          if ((float)iVar7 != 0.0) goto LAB_18158f8cd;
        }
        uVar6 = 0;
        Font.RequestCharactersInTexture
                  (lVar1,"A",*(uint32 *)(pStatics + 136),
                   *(uint32 *)(pStatics + 36),0);
        lVar3 = pStatics;
        cVar4 = Font.GetCharacterInfo
                          (lVar1,65,lVar3 + 188,*(uint32 *)(lVar3 + 136),
                           CONCAT44(uVar6,*(uint32 *)(lVar3 + 36)),0);
        if (!cVar4) {
          *(uint32 *)(pStatics + 148) = 0;
          return;
        }
        LAB_18158f8cd:
        iVar7 = CharacterInfo.get_maxY(pStatics + 188,0);
        iVar8 = CharacterInfo.get_minY(pStatics + 188,0);
        uVar6 = FUN_18000d7c0((((float)*(int *)(pStatics + 136) - (float)iVar7
                               ) + (float)iVar8) * 0.5 + (float)iVar7);
        *(uint32 *)(pStatics + 148) = uVar6;
    }

    // Token : 0x600038C
    // RVA   : 0x158A4E0   Offset: 0x1588CE0   Length: 0x132
    public static void Prepare(string text)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        long lVar1;
        ulong uVar2;
        bool cVar3;
        lVar1 = *(int64 *)(pStatics + 176);
        if (lVar1 != null) {
          BetterList_1.Clear(lVar1,DAT_181d80e98);
          uVar2 = *(uint64 *)(pStatics + 8);
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

    // Token : 0x600038D
    // RVA   : 0x1588DB0   Offset: 0x15875B0   Length: 0x150
    public static BMSymbol GetSymbol(string text, int index, int textLength)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        long lVar2;
        ulong uVar4;
        ushort uVar5;
        if (*pStatics == 0) {
          return 0;
        }
        plVar1 = (int64 *)*pStatics;
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar2 = *plVar1;
        uVar5 = 0;
        if (*(uint16 *)(lVar2 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar5 * 16) == DAT_181d556d0) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar5 * 16) *
                        16 + 0x378 + lVar2);
              goto LAB_181588eb8;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar2 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar1,DAT_181d556d0,36);
        LAB_181588eb8:
        uVar4 = (*(code *)*puVar3)(plVar1,text,index,textLength,puVar3[1]);
        return uVar4;
    }

    // Token : 0x600038E
    // RVA   : 0x1588120   Offset: 0x1586920   Length: 0x294
    public static float GetGlyphWidth(int ch, int prev, float fontScale)
    {
        ulong uVar1;
        int iVar2;
        long lVar4;
        uint uVar5;
        uint uVar6;
        if (((*(byte *)((int64)DAT_181d66a70 + 0x133) & 4) != 0) && ((int)DAT_181d66a70[28] == 0)) {
          il2cpp_runtime_class_init();
        }
        if (*(int64 *)DAT_181d66a70[23] == 0) {
          if (((*(byte *)((int64)DAT_181d66a70 + 0x133) & 4) != 0) && ((int)DAT_181d66a70[28] == 0))
          {
            il2cpp_runtime_class_init();
          }
          uVar1 = *(uint64 *)(DAT_181d66a70[23] + 8);
          plVar3 = (int64 *)Object.op_Inequality(uVar1,0,0);
          if ((char)plVar3) {
            if (((*(byte *)((int64)DAT_181d66a70 + 0x133) & 4) != 0) && ((int)DAT_181d66a70[28] == 0)
               ) {
              il2cpp_runtime_class_init(DAT_181d66a70);
            }
            lVar4 = DAT_181d66a70[23];
            if (*(int64 *)(lVar4 + 8) == 0) {
        LAB_1815883af:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            plVar3 = (int64 *)
                     Font.GetCharacterInfo
                               (*(int64 *)(lVar4 + 8),ch & 0xffff,lVar4 + 188,
                                *(uint32 *)(lVar4 + 136),*(uint32 *)(lVar4 + 36),0);
            if ((char)plVar3) {
              if (((*(byte *)((int64)DAT_181d66a70 + 0x133) & 4) != 0) &&
                 ((int)DAT_181d66a70[28] == 0)) {
                il2cpp_runtime_class_init();
              }
              CharacterInfo.get_advance(DAT_181d66a70[23] + 188,0);
              plVar3 = DAT_181d66a70;
            }
          }
        }
        else {
          uVar6 = 32;
          if (ch != 0x2009) {
            uVar6 = ch;
          }
          if (((*(byte *)((int64)DAT_181d66a70 + 0x133) & 4) != 0) && ((int)DAT_181d66a70[28] == 0))
          {
            il2cpp_runtime_class_init();
          }
          plVar3 = (int64 *)DAT_181d66a70[23];
          if (*plVar3 != 0) {
            if (((*(byte *)((int64)DAT_181d66a70 + 0x133) & 4) != 0) && ((int)DAT_181d66a70[28] == 0)
               ) {
              il2cpp_runtime_class_init();
            }
            if ((*(int64 *)DAT_181d66a70[23] == 0) ||
               (lVar4 = FUN_180002970(0,DAT_181d556d0)) == null) goto LAB_1815883af;
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

    // Token : 0x600038F
    // RVA   : 0x15883C0   Offset: 0x1586BC0   Length: 0x9E8
    public static GlyphInfo GetGlyph(int ch, int prev, float fontScale)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
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
        if (*pStatics == 0) {
          uVar5 = *(uint64 *)(pStatics + 8);
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
              lVar6 = *(int64 *)(pStatics + 16);
              if (lVar6 != null) {
                iVar3 = CharacterInfo.get_minX(pStatics + 188,0);
                *(float *)(lVar6 + 16) = (float)iVar3;
                lVar6 = *(int64 *)(pStatics + 16);
                if (lVar6 != null) {
                  iVar3 = CharacterInfo.get_maxX(pStatics + 188,0);
                  *(float *)(lVar6 + 24) = (float)iVar3;
                  lVar6 = *(int64 *)(pStatics + 16);
                  if (lVar6 != null) {
                    iVar3 = CharacterInfo.get_maxY(pStatics + 188,0);
                    *(float *)(lVar6 + 20) =
                         (float)iVar3 - *(float *)(pStatics + 148);
                    lVar6 = *(int64 *)(pStatics + 16);
                    if (lVar6 != null) {
                      iVar3 = CharacterInfo.get_minY(pStatics + 188,0);
                      *(float *)(lVar6 + 28) =
                           (float)iVar3 - *(float *)(pStatics + 148);
                      lVar6 = *(int64 *)(pStatics + 16);
                      uVar5 = CharacterInfo.get_uvTopLeft(pStatics + 188,0);
                      if (lVar6 != null) {
                        local_28 = (uint32)uVar5;
                        uStack_24 = (uint32)((uint64)uVar5 >> 32);
                        *(uint32 *)(lVar6 + 32) = local_28;
                        *(uint32 *)(lVar6 + 36) = uStack_24;
                        lVar6 = *(int64 *)(pStatics + 16);
                        uVar5 = FUN_180456fe0(pStatics + 188,0);
                        if (lVar6 != null) {
                          local_28 = (uint32)uVar5;
                          uStack_24 = (uint32)((uint64)uVar5 >> 32);
                          *(uint32 *)(lVar6 + 40) = local_28;
                          *(uint32 *)(lVar6 + 44) = uStack_24;
                          lVar6 = *(int64 *)(pStatics + 16);
                          uVar5 = CharacterInfo.get_uvBottomRight
                                            (pStatics + 188,0);
                          if (lVar6 != null) {
                            local_28 = (uint32)uVar5;
                            uStack_24 = (uint32)((uint64)uVar5 >> 32);
                            *(uint32 *)(lVar6 + 48) = local_28;
                            *(uint32 *)(lVar6 + 52) = uStack_24;
                            lVar6 = *(int64 *)(pStatics + 16);
                            uVar5 = CharacterInfo.get_uvTopRight
                                              (pStatics + 188,0);
                            if (lVar6 != null) {
                              local_28 = (uint32)uVar5;
                              uStack_24 = (uint32)((uint64)uVar5 >> 32);
                              *(uint32 *)(lVar6 + 56) = local_28;
                              *(uint32 *)(lVar6 + 60) = uStack_24;
                              lVar6 = *(int64 *)(pStatics + 16);
                              iVar3 = CharacterInfo.get_advance
                                                (pStatics + 188,0);
                              if (lVar6 != null) {
                                *(float *)(lVar6 + 64) = (float)iVar3;
                                lVar6 = *(int64 *)(pStatics + 16);
                                if (lVar6 != null) {
                                  *(uint32 *)(lVar6 + 68) = 0;
                                  lVar6 = *(int64 *)(pStatics + 16);
                                  if (lVar6 != null) {
                                    uVar8 = FUN_18000d7c0();
                                    *(uint32 *)(lVar6 + 16) = uVar8;
                                    lVar6 = *(int64 *)(pStatics + 16);
                                    if (lVar6 != null) {
                                      uVar8 = FUN_18000d7c0();
                                      *(uint32 *)(lVar6 + 20) = uVar8;
                                      lVar6 = *(int64 *)(pStatics + 16);
                                      if (lVar6 != null) {
                                        uVar8 = FUN_18000d7c0();
                                        *(uint32 *)(lVar6 + 24) = uVar8;
                                        lVar6 = *(int64 *)(pStatics + 16);
                                        if (lVar6 != null) {
                                          uVar8 = FUN_18000d7c0();
                                          *(uint32 *)(lVar6 + 28) = uVar8;
                                          fontScale = fontScale * *(float *)(*(int64 *)
                                                                          (DAT_181d66a70 + 184) + 32);
                                          if (fontScale == 1.0) {
        LAB_18158890c:
                                            return *(uint64 *)
                                                    (pStatics + 16);
                                          }
                                          lVar6 = *(int64 *)
                                                   (pStatics + 16);
                                          if (lVar6 != null) {
                                            *(float *)(lVar6 + 16) = *(float *)(lVar6 + 16) * fontScale;
                                            *(float *)(lVar6 + 20) = *(float *)(lVar6 + 20) * fontScale;
                                            lVar6 = *(int64 *)
                                                     (pStatics + 16);
                                            if (lVar6 != null) {
                                              *(float *)(lVar6 + 24) =
                                                   *(float *)(lVar6 + 24) * fontScale;
                                              *(float *)(lVar6 + 28) =
                                                   *(float *)(lVar6 + 28) * fontScale;
                                              lVar6 = *(int64 *)
                                                       (pStatics + 16);
                                              if (lVar6 != null) {
                                                *(float *)(lVar6 + 64) =
                                                     fontScale * *(float *)(lVar6 + 64);
                                                goto LAB_18158890c;
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
        LAB_181588da3:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        else {
          uVar7 = 32;
          if (ch != 0x2009) {
            uVar7 = ch;
          }
          if (*pStatics != 0) {
            if ((*pStatics != 0) &&
               (lVar6 = FUN_180002970(0,DAT_181d556d0)) != null) {
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
              lVar1 = *(int64 *)(pStatics + 16);
              if (lVar1 != null) {
                iVar4 = *(int *)(lVar6 + 36);
                if (prev != null) {
                  iVar4 = iVar4 + iVar3;
                }
                *(float *)(lVar1 + 16) = (float)iVar4;
                lVar1 = *(int64 *)(pStatics + 16);
                if (lVar1 != null) {
                  *(float *)(lVar1 + 28) = (float)-*(int *)(lVar6 + 40);
                  lVar1 = *(int64 *)(pStatics + 16);
                  if (lVar1 != null) {
                    *(float *)(lVar1 + 24) = (float)*(int *)(lVar6 + 28) + *(float *)(lVar1 + 16);
                    lVar1 = *(int64 *)(pStatics + 16);
                    if (lVar1 != null) {
                      *(float *)(lVar1 + 20) = *(float *)(lVar1 + 28) - (float)*(int *)(lVar6 + 32);
                      lVar1 = *(int64 *)(pStatics + 16);
                      if (lVar1 != null) {
                        *(float *)(lVar1 + 32) = (float)*(int *)(lVar6 + 20);
                        lVar1 = *(int64 *)(pStatics + 16);
                        if (lVar1 != null) {
                          *(float *)(lVar1 + 36) =
                               (float)(*(int *)(lVar6 + 32) + *(int *)(lVar6 + 24));
                          lVar1 = *(int64 *)(pStatics + 16);
                          if (lVar1 != null) {
                            *(float *)(lVar1 + 48) =
                                 (float)(*(int *)(lVar6 + 20) + *(int *)(lVar6 + 28));
                            lVar1 = *(int64 *)(pStatics + 16);
                            if (lVar1 != null) {
                              *(float *)(lVar1 + 52) = (float)*(int *)(lVar6 + 24);
                              lVar1 = *(int64 *)(pStatics + 16);
                              if (lVar1 != null) {
                                *(uint32 *)(lVar1 + 40) = *(uint32 *)(lVar1 + 32);
                                lVar1 = *(int64 *)(pStatics + 16);
                                if (lVar1 != null) {
                                  *(uint32 *)(lVar1 + 44) = *(uint32 *)(lVar1 + 52);
                                  lVar1 = *(int64 *)(pStatics + 16);
                                  if (lVar1 != null) {
                                    *(uint32 *)(lVar1 + 56) = *(uint32 *)(lVar1 + 48);
                                    lVar1 = *(int64 *)(pStatics + 16);
                                    if (lVar1 != null) {
                                      *(uint32 *)(lVar1 + 60) = *(uint32 *)(lVar1 + 36);
                                      iVar4 = *(int *)(lVar6 + 44) >> 1;
                                      if (ch != 0x2009) {
                                        iVar4 = *(int *)(lVar6 + 44);
                                      }
                                      lVar1 = *(int64 *)(pStatics + 16);
                                      if (lVar1 != null) {
                                        *(float *)(lVar1 + 64) = (float)(iVar4 + iVar3);
                                        lVar1 = *(int64 *)(pStatics + 16);
                                        if (lVar1 != null) {
                                          *(uint32 *)(lVar1 + 68) = *(uint32 *)(lVar6 + 48);
                                          if (fontScale == 1.0) {
        LAB_181588d52:
                                            return *(uint64 *)
                                                    (pStatics + 16);
                                          }
                                          lVar6 = *(int64 *)
                                                   (pStatics + 16);
                                          if (lVar6 != null) {
                                            *(float *)(lVar6 + 16) = *(float *)(lVar6 + 16) * fontScale;
                                            *(float *)(lVar6 + 20) = *(float *)(lVar6 + 20) * fontScale;
                                            lVar6 = *(int64 *)
                                                     (pStatics + 16);
                                            if (lVar6 != null) {
                                              *(float *)(lVar6 + 24) =
                                                   *(float *)(lVar6 + 24) * fontScale;
                                              *(float *)(lVar6 + 28) =
                                                   *(float *)(lVar6 + 28) * fontScale;
                                              lVar6 = *(int64 *)
                                                       (pStatics + 16);
                                              if (lVar6 != null) {
                                                *(float *)(lVar6 + 64) =
                                                     fontScale * *(float *)(lVar6 + 64);
                                                goto LAB_181588d52;
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
            goto LAB_181588da3;
          }
        }
        return 0;
    }

    // Token : 0x6000390
    // RVA   : 0x15892F0   Offset: 0x1587AF0   Length: 0x76
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

    // Token : 0x6000391
    // RVA   : 0x1589680   Offset: 0x1587E80   Length: 0x7E
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

    // Token : 0x6000392
    // RVA   : 0x1589370   Offset: 0x1587B70   Length: 0x155
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

    // Token : 0x6000393
    // RVA   : 0x15894D0   Offset: 0x1587CD0   Length: 0x1AE
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
          FUN_1809981e0(text,(float)(int)(iVar2 << 4 | uVar3) * 0.003921569,
                        (float)(int)(iVar4 << 4 | uVar5) * 0.003921569,
                        (float)(int)(iVar6 << 4 | uVar7) * 0.003921569,
                        (float)(int)(uVar9 | iVar8 << 4) * 0.003921569,0);
          return text;
        }
    }

    // Token : 0x6000394
    // RVA   : 0x1587C10   Offset: 0x1586410   Length: 0x6D
    public static string EncodeColor(Color c)
    {
        int iVar1;
        long lVar3;
        long lVar4;
        ulong uVar5;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
        if (plVar2 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (("[c][" != 0) &&
           (lVar3 = il2cpp_internal("[c][",*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        lVar3 = "[c][";
        if ((int)plVar2[3] == 0) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[4] = "[c][";
        il2cpp_internal(plVar2 + 4,lVar3);
        local_18 = *param_2;
        uStack_14 = param_2[1];
        uStack_10 = param_2[2];
        uStack_c = param_2[3];
        iVar1 = NGUIMath.ColorToInt(&local_18,0);
        lVar3 = NGUIMath.DecimalToHex24(iVar1 >> 8 & 0xffffff,0);
        if ((lVar3 != null) &&
           (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        if (*(uint32 *)(plVar2 + 3) < 2) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[5] = lVar3;
        il2cpp_internal(plVar2 + 5,lVar3);
        if (("]" != 0) &&
           (lVar3 = il2cpp_internal("]",*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        lVar3 = "]";
        if (*(uint32 *)(plVar2 + 3) < 3) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[6] = "]";
        il2cpp_internal(plVar2 + 6,lVar3);
        if ((c != null) &&
           (lVar3 = il2cpp_internal(c,*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        if (*(uint32 *)(plVar2 + 3) < 4) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[7] = c;
        il2cpp_internal(plVar2 + 7,c);
        if (("[-][/c]" != 0) &&
           (lVar3 = il2cpp_internal("[-][/c]",*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        lVar3 = "[-][/c]";
        if (*(uint32 *)(plVar2 + 3) < 5) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[8] = "[-][/c]";
        il2cpp_internal(plVar2 + 8,lVar3);
        String.Concat(plVar2,0);
    }

    // Token : 0x6000395
    // RVA   : 0x1587950   Offset: 0x1586150   Length: 0x2BA
    public static string EncodeColor(string text, Color c)
    {
        int iVar1;
        long lVar3;
        long lVar4;
        ulong uVar5;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
        if (plVar2 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (("[c][" != 0) &&
           (lVar3 = il2cpp_internal("[c][",*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        lVar3 = "[c][";
        if ((int)plVar2[3] == 0) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[4] = "[c][";
        il2cpp_internal(plVar2 + 4,lVar3);
        local_18 = *c;
        uStack_14 = c[1];
        uStack_10 = c[2];
        uStack_c = c[3];
        iVar1 = NGUIMath.ColorToInt(&local_18,0);
        lVar3 = NGUIMath.DecimalToHex24(iVar1 >> 8 & 0xffffff,0);
        if ((lVar3 != null) &&
           (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        if (*(uint32 *)(plVar2 + 3) < 2) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[5] = lVar3;
        il2cpp_internal(plVar2 + 5,lVar3);
        if (("]" != 0) &&
           (lVar3 = il2cpp_internal("]",*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        lVar3 = "]";
        if (*(uint32 *)(plVar2 + 3) < 3) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[6] = "]";
        il2cpp_internal(plVar2 + 6,lVar3);
        if ((text != null) &&
           (lVar3 = il2cpp_internal(text,*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        if (*(uint32 *)(plVar2 + 3) < 4) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[7] = text;
        il2cpp_internal(plVar2 + 7,text);
        if (("[-][/c]" != 0) &&
           (lVar3 = il2cpp_internal("[-][/c]",*(uint64 *)(*plVar2 + 64))) == null) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        lVar3 = "[-][/c]";
        if (*(uint32 *)(plVar2 + 3) < 5) {
          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar5,0);
        }
        plVar2[8] = "[-][/c]";
        il2cpp_internal(plVar2 + 8,lVar3);
        String.Concat(plVar2,0);
    }

    // Token : 0x6000396
    // RVA   : 0x15878B0   Offset: 0x15860B0   Length: 0x32
    public static string EncodeAlpha(float a)
    {
        uint uVar1;
        uVar1 = Mathf.RoundToInt(a * 255.0,0);
        uVar1 = Mathf.Clamp(uVar1,0,255,0);
        NGUIMath.DecimalToHex8(uVar1,0);
    }

    // Token : 0x6000397
    // RVA   : 0x15878F0   Offset: 0x15860F0   Length: 0x2D
    public static string EncodeColor24(Color c)
    {
        int iVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_18 = *c;
        uStack_14 = c[1];
        uStack_10 = c[2];
        uStack_c = c[3];
        iVar1 = NGUIMath.ColorToInt(&local_18,0);
        NGUIMath.DecimalToHex24(iVar1 >> 8 & 0xffffff,0);
    }

    // Token : 0x6000398
    // RVA   : 0x1587920   Offset: 0x1586120   Length: 0x25
    public static string EncodeColor32(Color c)
    {
        uint uVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_18 = *c;
        uStack_14 = c[1];
        uStack_10 = c[2];
        uStack_c = c[3];
        uVar1 = NGUIMath.ColorToInt(&local_18,0);
        NGUIMath.DecimalToHex32(uVar1,0);
    }

    // Token : 0x6000399
    // RVA   : 0x158A3F0   Offset: 0x1588BF0   Length: 0xE1
    public static bool ParseSymbol(string text, ref int index)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        uint64
        NGUIText.ParseSymbol
                (int64 text,int *index,int64 param_3,char param_4,uint32 *param_5,
                uint8 *param_6,uint8 *param_7,uint8 *param_8,uint8 *param_9,
                uint8 *param_10)
        {
        int iVar1;
        uint8 *puVar2;
        char cVar3;
        short sVar4;
        uint16 uVar5;
        uint16 uVar6;
        uint32 uVar7;
        int iVar8;
        uint32 uVar9;
        int64 lVar10;
        uint64 *puVar11;
        uint64 uVar12;
        uint64 uVar13;
        uint32 *puVar14;
        uint64 *puVar15;
        uint64 uVar16;
        uint64 uVar17;
        int64 lVar18;
        uint32 uVar19;
        uint32 uVar20;
        uint32 uVar21;
        float fVar22;
        uint64 local_78;
        uint64 uStack_70;
        uint64 local_68;
        uint64 uStack_60;
        uint8 local_58 [48];
        if (text == null) goto LAB_18158a3ce;
        iVar8 = *(int *)(text + 16);
        if (iVar8 < *index + 3) {
          return false;
        }
        sVar4 = String.get_Chars(text,*index,0);
        if (sVar4 != 91) {
          return false;
        }
        sVar4 = String.get_Chars(text,*index + 2,0);
        if (sVar4 == 93) {
          sVar4 = String.get_Chars(text,*index + 1,0);
          if (sVar4 == 45) {
            if ((param_3 != 0) && (1 < *(int *)(param_3 + 24))) {
              BetterList_1.RemoveAt(param_3,*(int *)(param_3 + 24) + -1,DAT_181d80f18);
            }
            goto LAB_181589c0f;
          }
          lVar10 = String.Substring(text,*index,3);
          if (lVar10 != null) {
            uVar7 = PrivateImplementationDetails.ComputeStringHash(lVar10,0);
            puVar2 = param_10;
            if (uVar7 < 0x7affcd23) {
              if (uVar7 < 0x76d678d0) {
                if (uVar7 == 0x76bf1f80) {
                  cVar3 = FUN_1816fd990(lVar10,"[u]",0);
                  puVar2 = param_8;
                }
                else {
                  if (uVar7 != 0x76d678cf) goto LAB_18158999e;
                  cVar3 = FUN_1816fd990(lVar10,"[b]",0);
                  puVar2 = param_6;
                }
              }
              else if (uVar7 == 0x77195ebc) {
                cVar3 = FUN_1816fd990(lVar10,"[I]",0);
                puVar2 = param_7;
              }
              else if (uVar7 == 0x7ad8bdb2) {
                cVar3 = FUN_1816fd990(lVar10,"[c]",0);
              }
              else {
                if (uVar7 != 0x7affcd22) goto LAB_18158999e;
                cVar3 = FUN_1816fd990(lVar10,"[S]",0);
                puVar2 = param_9;
              }
            }
            else if (uVar7 < 0xb70f3621) {
              if (uVar7 == 0xb6ca119c) {
                cVar3 = FUN_1816fd990(lVar10,"[i]",0);
                puVar2 = param_7;
              }
              else {
                if (uVar7 != 0xb70f3620) goto LAB_18158999e;
                cVar3 = FUN_1816fd990(lVar10,"[U]",0);
                puVar2 = param_8;
              }
            }
            else if (uVar7 == 0xb724fc6f) {
              cVar3 = FUN_1816fd990(lVar10,"[B]",0);
              puVar2 = param_6;
            }
            else if (uVar7 == 0xbab08002) {
              cVar3 = FUN_1816fd990(lVar10,"[s]",0);
              puVar2 = param_9;
            }
            else {
              if (uVar7 != 0xbb274152) goto LAB_18158999e;
              cVar3 = FUN_1816fd990(lVar10,"[C]",0);
            }
            if (cVar3) {
              *puVar2 = 1;
        LAB_181589c0f:
              *index = *index + 3;
              return true;
            }
          }
        }
        LAB_18158999e:
        if (iVar8 < *index + 4) {
          return false;
        }
        sVar4 = String.get_Chars(text,*index + 3,0);
        if (sVar4 == 93) {
          lVar10 = String.Substring(text,*index,4);
          if (lVar10 != null) {
            uVar7 = PrivateImplementationDetails.ComputeStringHash(lVar10,0);
            if (uVar7 < 0x258a062a) {
              if (uVar7 < 0x21676d9c) {
                if (uVar7 == 0x213ecb2b) {
                  cVar3 = FUN_1816fd990(lVar10,"[/S]",0);
        joined_r0x000181589e78:
                  if (cVar3) {
                    *param_9 = 0;
                    *index = *index + 4;
                    return true;
                  }
                }
                else if (uVar7 == 0x21676d9b) {
                  cVar3 = FUN_1816fd990(lVar10,"[/c]",0);
                  goto joined_r0x000181589eac;
                }
              }
              else {
                if (uVar7 == 0x2558695d) {
                  cVar3 = FUN_1816fd990(lVar10,"[/i]",0);
                  goto joined_r0x000181589de4;
                }
                if (uVar7 == 0x2569b27e) {
                  cVar3 = FUN_1816fd990(lVar10,"[/b]",0);
                  goto joined_r0x000181589e14;
                }
                if (uVar7 == 0x258a0629) {
                  cVar3 = FUN_1816fd990(lVar10,"[/u]",0);
                  goto joined_r0x000181589e48;
                }
              }
            }
            else if (uVar7 < 0x618ee1cc) {
              if (uVar7 == 0x6118207b) {
                cVar3 = FUN_1816fd990(lVar10,"[/C]",0);
        joined_r0x000181589eac:
                if (cVar3) {
                  *param_10 = 0;
                  *index = *index + 4;
                  return true;
                }
              }
              else if (uVar7 == 0x618ee1cb) {
                cVar3 = FUN_1816fd990(lVar10,"[/s]",0);
                goto joined_r0x000181589e78;
              }
            }
            else if (uVar7 == 0x65091c3d) {
              cVar3 = FUN_1816fd990(lVar10,"[/I]",0);
        joined_r0x000181589de4:
              if (cVar3) {
                *param_7 = 0;
                *index = *index + 4;
                return true;
              }
            }
            else if (uVar7 == 0x651a655e) {
              cVar3 = FUN_1816fd990(lVar10,"[/B]",0);
        joined_r0x000181589e14:
              if (cVar3) {
                *param_6 = 0;
                *index = *index + 4;
                return true;
              }
            }
            else if (uVar7 == 0x653ab909) {
              cVar3 = FUN_1816fd990(lVar10,"[/U]",0);
        joined_r0x000181589e48:
              if (cVar3) {
                *param_8 = 0;
                *index = *index + 4;
                return true;
              }
            }
          }
          uVar5 = String.get_Chars(text,*index + 1,0);
          uVar6 = String.get_Chars(text,*index + 2,0);
          if ((((uint16)(uVar5 - 48) < 10) || ((uint16)(uVar5 - 97) < 6)) ||
             ((64 < uVar5 && (uVar5 < 71)))) {
            if ((((uint16)(uVar6 - 48) < 10) || ((uint16)(uVar6 - 97) < 6)) ||
               ((64 < uVar6 && (uVar6 < 71)))) {
              iVar8 = NGUIMath.HexToDecimal(uVar5,0);
              uVar7 = NGUIMath.HexToDecimal(uVar6,0);
              *(float *)(pStatics + 184) =
                   (float)(int)(iVar8 << 4 | uVar7) / 255.0;
              *index = *index + 4;
              return true;
            }
          }
        }
        if (*index + 5 <= iVar8) {
          sVar4 = String.get_Chars(text,*index + 4,0);
          if ((sVar4 == 93) && (lVar10 = String.Substring(text,*index,5)) != null) {
            cVar3 = FUN_1816fd990(lVar10,"[sub]",0);
            if ((cVar3) || (cVar3 = FUN_1816fd990(lVar10,"[SUB]",0), cVar3)) {
              *param_5 = 1;
              *index = *index + 5;
              return true;
            }
            cVar3 = FUN_1816fd990(lVar10,"[sup]",0);
            if ((cVar3) || (cVar3 = FUN_1816fd990(lVar10,"[SUP]",0), cVar3)) {
              *param_5 = 2;
              *index = *index + 5;
              return true;
            }
          }
          if (iVar8 < *index + 6) {
            return false;
          }
          sVar4 = String.get_Chars(text,*index + 5,0);
          if ((sVar4 == 93) && (lVar10 = String.Substring(text,*index,6)) != null) {
            cVar3 = FUN_1816fd990(lVar10,"[/sub]",0);
            if ((cVar3) ||
               (((cVar3 = FUN_1816fd990(lVar10,"[/SUB]",0), cVar3 ||
                 (cVar3 = FUN_1816fd990(lVar10,"[/sup]",0), cVar3)) ||
                (cVar3 = FUN_1816fd990(lVar10,"[/SUP]",0), cVar3)))) {
              *param_5 = 0;
              *index = *index + 6;
              return true;
            }
            cVar3 = FUN_1816fd990(lVar10,"[/url]",0);
            if ((cVar3) || (cVar3 = FUN_1816fd990(lVar10,"[/URL]",0), cVar3)) {
              *index = *index + 6;
              return true;
            }
          }
          sVar4 = String.get_Chars(text,*index + 1,0);
          if (((sVar4 == 117) && (sVar4 = String.get_Chars(text,*index + 2,0), sVar4 == 114)) &&
             ((sVar4 = String.get_Chars(text,*index + 3,0), sVar4 == 108 &&
              (sVar4 = String.get_Chars(text,*index + 4,0), sVar4 == 61)))) {
            iVar8 = String.IndexOf(text,93,*index + 4,0);
            if (iVar8 == -1) {
              *index = *(int *)(text + 16);
            }
            else {
              *index = iVar8 + 1;
            }
            return true;
          }
          if (*index + 8 <= iVar8) {
            sVar4 = String.get_Chars(text,*index + 7,0);
            iVar1 = *index;
            if (sVar4 == 93) {
              puVar15 = (uint64 *)NGUIText.ParseColor24(local_58,text,iVar1 + 1,0);
              local_78 = *puVar15;
              uStack_70 = puVar15[1];
              local_68 = local_78;
              uStack_60 = uStack_70;
              iVar8 = NGUIMath.ColorToInt(&local_68,0);
              uVar16 = NGUIMath.DecimalToHex24(iVar8 >> 8 & 0xffffff,0);
              lVar10 = String.Substring(text,*index + 1,6);
              if (lVar10 == null) {
        LAB_18158a3ce:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar17 = String.ToUpper(lVar10,0);
              cVar3 = String.op_Inequality(uVar16,uVar17,0);
              if (!cVar3) {
                if ((param_3 != 0) && (0 < *(int *)(param_3 + 24))) {
                  lVar10 = *(int64 *)(param_3 + 16);
                  if (lVar10 == null) goto LAB_18158a3ce;
                  lVar18 = (int64)*(int *)(param_3 + 24) + -1;
                  if (*(uint32 *)(lVar10 + 24) <= (uint32)lVar18) {
                    uVar16 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar16,0);
                  }
                  fVar22 = *(float *)(lVar10 + 44 + lVar18 * 16);
                  uStack_70 = CONCAT44(fVar22,(uint32)uStack_70);
                  uVar16 = local_78;
                  uVar17 = uStack_70;
                  if ((param_4) && (fVar22 != 1.0)) {
                    local_68 = local_78;
                    uStack_60 = uStack_70;
                    local_78 = *(uint64 *)(pStatics + 156);
                    uStack_70 = *(uint64 *)(pStatics + 164);
                    puVar15 = (uint64 *)Color.Lerp(local_58,&local_78,&local_68,fVar22,0);
                    uVar16 = *puVar15;
                    uVar17 = puVar15[1];
                  }
                  local_68 = uVar16;
                  uStack_60 = uVar17;
                  BetterList_1.Add(param_3,&local_68,DAT_181d80e18);
                }
                *index = *index + 8;
                return true;
              }
            }
            else if ((iVar1 + 10 <= iVar8) &&
                    (sVar4 = String.get_Chars(text,iVar1 + 9,0), sVar4 == 93)) {
              iVar8 = *index;
              puVar11 = (uint64 *)NGUIText.ParseColor32(&local_68,text,iVar8 + 1,0);
              uVar19 = *(uint32 *)puVar11;
              uVar20 = *(uint32 *)((int64)puVar11 + 4);
              uVar16 = *puVar11;
              local_78 = *puVar11;
              puVar15 = puVar11 + 1;
              uVar21 = *(uint32 *)puVar15;
              fVar22 = *(float *)((int64)puVar11 + 12);
              uVar17 = *puVar15;
              uStack_70 = *puVar15;
              uVar9 = NGUIMath.ColorToInt(&local_78,0);
              uVar12 = NGUIMath.DecimalToHex32(uVar9,0);
              lVar10 = String.Substring(text,*index + 1,8);
              if (lVar10 == null) goto LAB_18158a3ce;
              uVar13 = String.ToUpper(lVar10,0);
              cVar3 = String.op_Inequality(uVar12,uVar13,0);
              if (!cVar3) {
                if (param_3 != 0) {
                  if ((param_4) && (fVar22 != 1.0)) {
                    local_68 = *(uint64 *)(pStatics + 156);
                    uStack_60 = *(uint64 *)(pStatics + 164);
                    local_78 = uVar16;
                    uStack_70 = uVar17;
                    puVar14 = (uint32 *)Color.Lerp(local_58,&local_68,&local_78,fVar22,0);
                    uVar19 = *puVar14;
                    uVar20 = puVar14[1];
                    uVar21 = puVar14[2];
                    fVar22 = (float)puVar14[3];
                  }
                  local_68 = CONCAT44(uVar20,uVar19);
                  uStack_60 = CONCAT44(fVar22,uVar21);
                  BetterList_1.Add(param_3,&local_68,DAT_181d80e18);
                }
                *index = *index + 10;
                return true;
              }
            }
          }
        }
        return false;
    }

    // Token : 0x600039A
    // RVA   : 0x15892A0   Offset: 0x1587AA0   Length: 0x26
    public static bool IsHex(char ch)
    {
        uint64 FUN_1815892a0(int ch)
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

    // Token : 0x600039B
    // RVA   : 0x1589700   Offset: 0x1587F00   Length: 0xCE3
    public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        uint64
        NGUIText.ParseSymbol
                (int64 text,int *index,int64 colors,char premultiply,uint32 *sub,
                uint8 *bold,uint8 *italic,uint8 *underline,uint8 *strike,
                uint8 *ignoreColor)
        {
        int iVar1;
        uint8 *puVar2;
        char cVar3;
        short sVar4;
        uint16 uVar5;
        uint16 uVar6;
        uint32 uVar7;
        int iVar8;
        uint32 uVar9;
        int64 lVar10;
        uint64 *puVar11;
        uint64 uVar12;
        uint64 uVar13;
        uint32 *puVar14;
        uint64 *puVar15;
        uint64 uVar16;
        uint64 uVar17;
        int64 lVar18;
        uint32 uVar19;
        uint32 uVar20;
        uint32 uVar21;
        float fVar22;
        uint64 local_78;
        uint64 uStack_70;
        uint64 local_68;
        uint64 uStack_60;
        uint8 local_58 [48];
        if (text == null) goto LAB_18158a3ce;
        iVar8 = *(int *)(text + 16);
        if (iVar8 < *index + 3) {
          return false;
        }
        sVar4 = String.get_Chars(text,*index,0);
        if (sVar4 != 91) {
          return false;
        }
        sVar4 = String.get_Chars(text,*index + 2,0);
        if (sVar4 == 93) {
          sVar4 = String.get_Chars(text,*index + 1,0);
          if (sVar4 == 45) {
            if ((colors != null) && (1 < *(int *)(colors + 24))) {
              BetterList_1.RemoveAt(colors,*(int *)(colors + 24) + -1,DAT_181d80f18);
            }
            goto LAB_181589c0f;
          }
          lVar10 = String.Substring(text,*index,3);
          if (lVar10 != null) {
            uVar7 = PrivateImplementationDetails.ComputeStringHash(lVar10,0);
            puVar2 = ignoreColor;
            if (uVar7 < 0x7affcd23) {
              if (uVar7 < 0x76d678d0) {
                if (uVar7 == 0x76bf1f80) {
                  cVar3 = FUN_1816fd990(lVar10,"[u]",0);
                  puVar2 = underline;
                }
                else {
                  if (uVar7 != 0x76d678cf) goto LAB_18158999e;
                  cVar3 = FUN_1816fd990(lVar10,"[b]",0);
                  puVar2 = bold;
                }
              }
              else if (uVar7 == 0x77195ebc) {
                cVar3 = FUN_1816fd990(lVar10,"[I]",0);
                puVar2 = italic;
              }
              else if (uVar7 == 0x7ad8bdb2) {
                cVar3 = FUN_1816fd990(lVar10,"[c]",0);
              }
              else {
                if (uVar7 != 0x7affcd22) goto LAB_18158999e;
                cVar3 = FUN_1816fd990(lVar10,"[S]",0);
                puVar2 = strike;
              }
            }
            else if (uVar7 < 0xb70f3621) {
              if (uVar7 == 0xb6ca119c) {
                cVar3 = FUN_1816fd990(lVar10,"[i]",0);
                puVar2 = italic;
              }
              else {
                if (uVar7 != 0xb70f3620) goto LAB_18158999e;
                cVar3 = FUN_1816fd990(lVar10,"[U]",0);
                puVar2 = underline;
              }
            }
            else if (uVar7 == 0xb724fc6f) {
              cVar3 = FUN_1816fd990(lVar10,"[B]",0);
              puVar2 = bold;
            }
            else if (uVar7 == 0xbab08002) {
              cVar3 = FUN_1816fd990(lVar10,"[s]",0);
              puVar2 = strike;
            }
            else {
              if (uVar7 != 0xbb274152) goto LAB_18158999e;
              cVar3 = FUN_1816fd990(lVar10,"[C]",0);
            }
            if (cVar3) {
              *puVar2 = 1;
        LAB_181589c0f:
              *index = *index + 3;
              return true;
            }
          }
        }
        LAB_18158999e:
        if (iVar8 < *index + 4) {
          return false;
        }
        sVar4 = String.get_Chars(text,*index + 3,0);
        if (sVar4 == 93) {
          lVar10 = String.Substring(text,*index,4);
          if (lVar10 != null) {
            uVar7 = PrivateImplementationDetails.ComputeStringHash(lVar10,0);
            if (uVar7 < 0x258a062a) {
              if (uVar7 < 0x21676d9c) {
                if (uVar7 == 0x213ecb2b) {
                  cVar3 = FUN_1816fd990(lVar10,"[/S]",0);
        joined_r0x000181589e78:
                  if (cVar3) {
                    *strike = 0;
                    *index = *index + 4;
                    return true;
                  }
                }
                else if (uVar7 == 0x21676d9b) {
                  cVar3 = FUN_1816fd990(lVar10,"[/c]",0);
                  goto joined_r0x000181589eac;
                }
              }
              else {
                if (uVar7 == 0x2558695d) {
                  cVar3 = FUN_1816fd990(lVar10,"[/i]",0);
                  goto joined_r0x000181589de4;
                }
                if (uVar7 == 0x2569b27e) {
                  cVar3 = FUN_1816fd990(lVar10,"[/b]",0);
                  goto joined_r0x000181589e14;
                }
                if (uVar7 == 0x258a0629) {
                  cVar3 = FUN_1816fd990(lVar10,"[/u]",0);
                  goto joined_r0x000181589e48;
                }
              }
            }
            else if (uVar7 < 0x618ee1cc) {
              if (uVar7 == 0x6118207b) {
                cVar3 = FUN_1816fd990(lVar10,"[/C]",0);
        joined_r0x000181589eac:
                if (cVar3) {
                  *ignoreColor = 0;
                  *index = *index + 4;
                  return true;
                }
              }
              else if (uVar7 == 0x618ee1cb) {
                cVar3 = FUN_1816fd990(lVar10,"[/s]",0);
                goto joined_r0x000181589e78;
              }
            }
            else if (uVar7 == 0x65091c3d) {
              cVar3 = FUN_1816fd990(lVar10,"[/I]",0);
        joined_r0x000181589de4:
              if (cVar3) {
                *italic = 0;
                *index = *index + 4;
                return true;
              }
            }
            else if (uVar7 == 0x651a655e) {
              cVar3 = FUN_1816fd990(lVar10,"[/B]",0);
        joined_r0x000181589e14:
              if (cVar3) {
                *bold = 0;
                *index = *index + 4;
                return true;
              }
            }
            else if (uVar7 == 0x653ab909) {
              cVar3 = FUN_1816fd990(lVar10,"[/U]",0);
        joined_r0x000181589e48:
              if (cVar3) {
                *underline = 0;
                *index = *index + 4;
                return true;
              }
            }
          }
          uVar5 = String.get_Chars(text,*index + 1,0);
          uVar6 = String.get_Chars(text,*index + 2,0);
          if ((((uint16)(uVar5 - 48) < 10) || ((uint16)(uVar5 - 97) < 6)) ||
             ((64 < uVar5 && (uVar5 < 71)))) {
            if ((((uint16)(uVar6 - 48) < 10) || ((uint16)(uVar6 - 97) < 6)) ||
               ((64 < uVar6 && (uVar6 < 71)))) {
              iVar8 = NGUIMath.HexToDecimal(uVar5,0);
              uVar7 = NGUIMath.HexToDecimal(uVar6,0);
              *(float *)(pStatics + 184) =
                   (float)(int)(iVar8 << 4 | uVar7) / 255.0;
              *index = *index + 4;
              return true;
            }
          }
        }
        if (*index + 5 <= iVar8) {
          sVar4 = String.get_Chars(text,*index + 4,0);
          if ((sVar4 == 93) && (lVar10 = String.Substring(text,*index,5)) != null) {
            cVar3 = FUN_1816fd990(lVar10,"[sub]",0);
            if ((cVar3) || (cVar3 = FUN_1816fd990(lVar10,"[SUB]",0), cVar3)) {
              *sub = 1;
              *index = *index + 5;
              return true;
            }
            cVar3 = FUN_1816fd990(lVar10,"[sup]",0);
            if ((cVar3) || (cVar3 = FUN_1816fd990(lVar10,"[SUP]",0), cVar3)) {
              *sub = 2;
              *index = *index + 5;
              return true;
            }
          }
          if (iVar8 < *index + 6) {
            return false;
          }
          sVar4 = String.get_Chars(text,*index + 5,0);
          if ((sVar4 == 93) && (lVar10 = String.Substring(text,*index,6)) != null) {
            cVar3 = FUN_1816fd990(lVar10,"[/sub]",0);
            if ((cVar3) ||
               (((cVar3 = FUN_1816fd990(lVar10,"[/SUB]",0), cVar3 ||
                 (cVar3 = FUN_1816fd990(lVar10,"[/sup]",0), cVar3)) ||
                (cVar3 = FUN_1816fd990(lVar10,"[/SUP]",0), cVar3)))) {
              *sub = 0;
              *index = *index + 6;
              return true;
            }
            cVar3 = FUN_1816fd990(lVar10,"[/url]",0);
            if ((cVar3) || (cVar3 = FUN_1816fd990(lVar10,"[/URL]",0), cVar3)) {
              *index = *index + 6;
              return true;
            }
          }
          sVar4 = String.get_Chars(text,*index + 1,0);
          if (((sVar4 == 117) && (sVar4 = String.get_Chars(text,*index + 2,0), sVar4 == 114)) &&
             ((sVar4 = String.get_Chars(text,*index + 3,0), sVar4 == 108 &&
              (sVar4 = String.get_Chars(text,*index + 4,0), sVar4 == 61)))) {
            iVar8 = String.IndexOf(text,93,*index + 4,0);
            if (iVar8 == -1) {
              *index = *(int *)(text + 16);
            }
            else {
              *index = iVar8 + 1;
            }
            return true;
          }
          if (*index + 8 <= iVar8) {
            sVar4 = String.get_Chars(text,*index + 7,0);
            iVar1 = *index;
            if (sVar4 == 93) {
              puVar15 = (uint64 *)NGUIText.ParseColor24(local_58,text,iVar1 + 1,0);
              local_78 = *puVar15;
              uStack_70 = puVar15[1];
              local_68 = local_78;
              uStack_60 = uStack_70;
              iVar8 = NGUIMath.ColorToInt(&local_68,0);
              uVar16 = NGUIMath.DecimalToHex24(iVar8 >> 8 & 0xffffff,0);
              lVar10 = String.Substring(text,*index + 1,6);
              if (lVar10 == null) {
        LAB_18158a3ce:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar17 = String.ToUpper(lVar10,0);
              cVar3 = String.op_Inequality(uVar16,uVar17,0);
              if (!cVar3) {
                if ((colors != null) && (0 < *(int *)(colors + 24))) {
                  lVar10 = *(int64 *)(colors + 16);
                  if (lVar10 == null) goto LAB_18158a3ce;
                  lVar18 = (int64)*(int *)(colors + 24) + -1;
                  if (*(uint32 *)(lVar10 + 24) <= (uint32)lVar18) {
                    uVar16 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar16,0);
                  }
                  fVar22 = *(float *)(lVar10 + 44 + lVar18 * 16);
                  uStack_70 = CONCAT44(fVar22,(uint32)uStack_70);
                  uVar16 = local_78;
                  uVar17 = uStack_70;
                  if ((premultiply) && (fVar22 != 1.0)) {
                    local_68 = local_78;
                    uStack_60 = uStack_70;
                    local_78 = *(uint64 *)(pStatics + 156);
                    uStack_70 = *(uint64 *)(pStatics + 164);
                    puVar15 = (uint64 *)Color.Lerp(local_58,&local_78,&local_68,fVar22,0);
                    uVar16 = *puVar15;
                    uVar17 = puVar15[1];
                  }
                  local_68 = uVar16;
                  uStack_60 = uVar17;
                  BetterList_1.Add(colors,&local_68,DAT_181d80e18);
                }
                *index = *index + 8;
                return true;
              }
            }
            else if ((iVar1 + 10 <= iVar8) &&
                    (sVar4 = String.get_Chars(text,iVar1 + 9,0), sVar4 == 93)) {
              iVar8 = *index;
              puVar11 = (uint64 *)NGUIText.ParseColor32(&local_68,text,iVar8 + 1,0);
              uVar19 = *(uint32 *)puVar11;
              uVar20 = *(uint32 *)((int64)puVar11 + 4);
              uVar16 = *puVar11;
              local_78 = *puVar11;
              puVar15 = puVar11 + 1;
              uVar21 = *(uint32 *)puVar15;
              fVar22 = *(float *)((int64)puVar11 + 12);
              uVar17 = *puVar15;
              uStack_70 = *puVar15;
              uVar9 = NGUIMath.ColorToInt(&local_78,0);
              uVar12 = NGUIMath.DecimalToHex32(uVar9,0);
              lVar10 = String.Substring(text,*index + 1,8);
              if (lVar10 == null) goto LAB_18158a3ce;
              uVar13 = String.ToUpper(lVar10,0);
              cVar3 = String.op_Inequality(uVar12,uVar13,0);
              if (!cVar3) {
                if (colors != null) {
                  if ((premultiply) && (fVar22 != 1.0)) {
                    local_68 = *(uint64 *)(pStatics + 156);
                    uStack_60 = *(uint64 *)(pStatics + 164);
                    local_78 = uVar16;
                    uStack_70 = uVar17;
                    puVar14 = (uint32 *)Color.Lerp(local_58,&local_68,&local_78,fVar22,0);
                    uVar19 = *puVar14;
                    uVar20 = puVar14[1];
                    uVar21 = puVar14[2];
                    fVar22 = (float)puVar14[3];
                  }
                  local_68 = CONCAT44(uVar20,uVar19);
                  uStack_60 = CONCAT44(fVar22,uVar21);
                  BetterList_1.Add(colors,&local_68,DAT_181d80e18);
                }
                *index = *index + 10;
                return true;
              }
            }
          }
        }
        return false;
    }

    // Token : 0x600039C
    // RVA   : 0x158F360   Offset: 0x158DB60   Length: 0x160
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

    // Token : 0x600039D
    // RVA   : 0x1586160   Offset: 0x1584960   Length: 0x983
    public static void Align(List<Vector3> verts, int indexOffset, float printedWidth, int elements)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
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
        iVar4 = *(int *)(pStatics + 40);
        if (iVar4 == 2) {
          fVar15 = ((float)*(int *)(pStatics + 60) - printedWidth) * 0.5;
          if (0.0 <= fVar15) {
            bVar2 = Mathf.RoundToInt((float)*(int *)(pStatics + 60) -
                                      printedWidth,0);
            bVar3 = Mathf.RoundToInt(DAT_181d66a70,0);
            if ((((bVar2 & 1) != 0) && ((bVar3 & 1) == 0)) || ((bVar3 & 1 & (bVar2 & 1 ^ 1)) != 0)) {
              fVar15 = fVar15 + *(float *)(pStatics + 28) * 0.5;
            }
            if (verts == null) {
        LAB_181586ade:
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
                FUN_181814c90(verts,uVar9 & 0xffffffff,&local_1d8,DAT_181d844f8);
                uVar9 = (uint64)((uint32)uVar9 + 1);
                lVar6 = lVar6 + 12;
                lVar5 = lVar5 + -1;
              } while (lVar5 != null);
            }
          }
        }
        else if (iVar4 == 3) {
          printedWidth = (float)*(int *)(pStatics + 60) - printedWidth;
          if (0.0 <= printedWidth) {
            if (verts == null) goto LAB_181586ade;
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
                FUN_181814c90(verts,uVar9 & 0xffffffff,&local_1d8,DAT_181d844f8,uVar16,uVar17);
                uVar9 = (uint64)((uint32)uVar9 + 1);
                lVar6 = lVar6 + 12;
                lVar5 = lVar5 + -1;
              } while (lVar5 != null);
            }
          }
        }
        else if (iVar4 == 4) {
          if ((float)*(int *)(pStatics + 60) * 0.65 <= printedWidth) {
            if (1.0 <= ((float)*(int *)(pStatics + 60) - printedWidth) * 0.5) {
              if (verts == null) goto LAB_181586ade;
              local_1e8 = *(int *)(verts + 24);
              iVar4 = (local_1e8 - indexOffset) / elements;
              if (0 < iVar4) {
                fVar15 = 1.0 / (float)(iVar4 + -1);
                local_1c4 = fVar15;
                if (((*(byte *)(DAT_181d66a70 + 0x133) & 4) != 0) && (*(int *)(DAT_181d66a70 + 224) == 0)
                   ) {
                  il2cpp_runtime_class_init
                            (DAT_181d66a70,
                             (int64)(local_1e8 - indexOffset) % (int64)elements & 0xffffffff);
                  local_1e8 = *(int *)(verts + 24);
                }
                uVar7 = indexOffset + elements;
                iVar4 = 1;
                local_1c8 = (float)*(int *)(pStatics + 60) / printedWidth;
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
                    dVar13 = (double)FUN_1801e52d8((double)fVar12,&local_1c0);
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
                    dVar13 = (double)FUN_1801e52d8((double)fVar15,local_1b8);
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
                      FUN_181814c90(verts,uVar7,&local_128,DAT_181d844f8,uVar16);
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
                      FUN_181814c90(verts,uVar7 + 1,&local_108,DAT_181d844f8,local_108);
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
                      FUN_181814c90(verts,uVar7 + 2,&local_e8,DAT_181d844f8,uVar16);
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
        LAB_181586811:
                      uVar7 = uVar8 + 1;
                      FUN_181814c90(verts,uVar8,puVar10,DAT_181d844f8,uVar16);
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
                        FUN_181814c90(verts,uVar7,&local_168,DAT_181d844f8);
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
                        goto LAB_181586811;
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
                        goto LAB_181586811;
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

    // Token : 0x600039E
    // RVA   : 0x1587F90   Offset: 0x1586790   Length: 0x182
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
        LAB_18158810d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        iVar2 = *(int *)(indices + 24);
        if (0 < iVar2) {
          fStack_74 = (float)((uint64)pos >> 32);
          local_78 = (float)pos;
          do {
            uVar3 = iVar6 * 2;
            if (verts == null) goto LAB_18158810d;
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
                    uVar4 = FUN_1800d6750(indices,iVar6,DAT_181d68270);
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

    // Token : 0x600039F
    // RVA   : 0x1587D70   Offset: 0x1586570   Length: 0x19A
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

    // Token : 0x60003A0
    // RVA   : 0x15892D0   Offset: 0x1587AD0   Length: 0x1D
    public static bool IsSpace(int ch)
    {
        bool FUN_1815892d0(int ch)
        {
        if (ch != 32) {
          if (1 < ch - 0x200aU) {
            return ch == 0x2009;
          }
        }
        return true;
    }

    // Token : 0x60003A1
    // RVA   : 0x1587C80   Offset: 0x1586480   Length: 0xE5
    public static void EndLine(ref StringBuilder s)
    {
        ushort uVar1;
        int iVar2;
        uint uVar3;
        if (*s == null) throw; // [null/range check failed]
        iVar2 = FUN_18123bdd0(*s,0);
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

    // Token : 0x60003A2
    // RVA   : 0x158F290   Offset: 0x158DA90   Length: 0xC3
    private static void ReplaceSpaceWithNewline(ref StringBuilder s)
    {
        ushort uVar1;
        int iVar2;
        uint uVar3;
        if (*s != null) {
          iVar2 = FUN_18123bdd0(*s,0);
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

    // Token : 0x60003A3
    // RVA   : 0x15870F0   Offset: 0x15858F0   Length: 0x7B3
    public static Vector2 CalculatePrintedSize(string text)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
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
        cVar2 = FUN_180d6ca90(text,0);
        if (!cVar2) {
          NGUIText.Prepare(text,0);
          uVar9 = 0;
          fVar12 = 0.0;
          fVar15 = 0.0;
          fVar14 = 0.0;
          fVar16 = (float)*(int *)(pStatics + 68) + 0.01;
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
                fVar15 = fVar15 + *(float *)(pStatics + 144);
        LAB_181587766:
                uVar10 = 0;
              }
              else {
                uVar10 = uVar3;
                if (31 < uVar3) {
                  uVar10 = uVar9;
                  if (*(char *)(pStatics + 116) != false) {
                    cVar2 = NGUIText.ParseSymbol
                                      (text,&local_e4,
                                       *(uint64 *)(pStatics + 176),
                                       *(uint8 *)(pStatics + 128),
                                       local_e0,local_e7,&local_e8,local_res20,local_res18,&local_res8,0);
                    iVar8 = local_e0[0];
                    iVar7 = local_e4;
                    if (cVar2) {
                      iVar7 = local_e4 + -1;
                      goto LAB_181587769;
                    }
                  }
                  if (*(char *)(pStatics + 152) == false) {
                    lVar6 = 0;
                  }
                  else {
                    lVar6 = NGUIText.GetSymbol(text,iVar7,iVar1,0);
                  }
                  if (iVar8 == 0) {
                    fVar13 = *(float *)(pStatics + 28);
                  }
                  else {
                    fVar13 = *(float *)(pStatics + 28) * 0.75;
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
                      fVar15 = fVar15 + *(float *)(pStatics + 144);
                    }
                    else if (fVar14 < fVar11) {
                      fVar14 = fVar11;
                    }
                    fVar12 = fVar12 + fVar13 + *(float *)(pStatics + 140);
                    iVar4 = BMSymbol.get_length(lVar6,0);
                    iVar7 = iVar7 + -1 + iVar4;
                    goto LAB_181587766;
                  }
                  lVar6 = NGUIText.GetGlyph(uVar3,uVar9);
                  if (lVar6 != null) {
                    fVar13 = *(float *)(lVar6 + 64);
                    if (iVar8 != 0) {
                      if (iVar8 == 1) {
                        fVar11 = (float)*(int *)(pStatics + 24) *
                                 *(float *)(pStatics + 28) * 0.4;
                        *(float *)(lVar6 + 20) = *(float *)(lVar6 + 20) - fVar11;
                        fVar11 = *(float *)(lVar6 + 28) - fVar11;
                      }
                      else {
                        fVar11 = (float)*(int *)(pStatics + 24) *
                                 *(float *)(pStatics + 28) * 0.05;
                        *(float *)(lVar6 + 20) = fVar11 + *(float *)(lVar6 + 20);
                        fVar11 = fVar11 + *(float *)(lVar6 + 28);
                      }
                      *(float *)(lVar6 + 28) = fVar11;
                    }
                    fVar13 = fVar13 + *(float *)(pStatics + 140) + fVar12;
                    if (fVar16 < fVar13) {
                      uVar10 = uVar3;
                      if (fVar12 == 0.0) goto LAB_181587769;
                      fVar15 = fVar15 + *(float *)(pStatics + 144);
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
        LAB_181587769:
              local_e4 = iVar7 + 1;
              uVar9 = uVar10;
            } while (local_e4 < iVar1);
            if (fVar14 < fVar12) {
              fVar14 = fVar12 - *(float *)(pStatics + 140);
            }
          }
          lVar6 = DAT_181d66a70;
          fVar12 = ceilf(fVar14);
          if (((*(byte *)(lVar6 + 0x133) & 4) != 0) && (*(int *)(lVar6 + 224) == 0)) {
            il2cpp_runtime_class_init(lVar6);
            lVar6 = DAT_181d66a70;
          }
          fVar14 = ceilf(fVar15 + *(float *)(*(int64 *)(lVar6 + 184) + 144));
        }
        return CONCAT44(fVar14,fVar12);
    }

    // Token : 0x60003A4
    // RVA   : 0x1586AF0   Offset: 0x15852F0   Length: 0x5F9
    public static int CalculateOffsetToFit(string text)
    {
        var plVar8 = *(int64*)(lVar8 + 184);
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
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
        cVar4 = FUN_180d6ca90(text,0);
        if (!cVar4) {
          if (0 < *(int *)(pStatics + 68)) {
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
                    fVar15 = *(float *)(pStatics + 28);
                  }
                  else {
                    fVar15 = *(float *)(pStatics + 28) * 0.75;
                  }
                  uVar6 = uVar14;
                  if (*(char *)(pStatics + 152) != false) {
                    uVar6 = NGUIText.GetSymbol(text,uVar13,iVar1,0);
                  }
                  if (*(char *)(pStatics + 116) == false) {
        LAB_181586ddd:
                    iVar12 = (int)uVar13;
                    if (uVar6 == 0) {
                      uVar5 = String.get_Chars(text,uVar13,0);
                      fVar15 = (float)NGUIText.GetGlyphWidth(uVar5,uVar10,fVar15);
                      if (fVar15 != 0.0) {
                        if (*(int64 *)(pStatics + 240) == 0)
                        goto LAB_1815870e4;
                        FUN_18154cad0();
                      }
                      uVar10 = (uint64)uVar5;
                    }
                    else {
                      lVar8 = *(int64 *)(pStatics + 240);
                      if (lVar8 == null) goto LAB_1815870e4;
                      FUN_18154cad0(lVar8,(float)*(int *)(uVar6 + 64) * fVar15 +
                                          *(float *)(pStatics + 140));
                      if (*(int64 *)(uVar6 + 16) == 0) goto LAB_1815870e4;
                      iVar11 = *(int *)(*(int64 *)(uVar6 + 16) + 16) + -1;
                      uVar10 = uVar14;
                      if (0 < iVar11) {
                        do {
                          if (*(int64 *)(pStatics + 240) == 0)
                          goto LAB_1815870e4;
                          FUN_18154cad0();
                          uVar9 = (int)uVar10 + 1;
                          uVar10 = (uint64)uVar9;
                        } while ((int)uVar9 < iVar11);
                      }
                      if (*(int64 *)(uVar6 + 16) == 0) goto LAB_1815870e4;
                      iVar12 = iVar12 + -1 + *(int *)(*(int64 *)(uVar6 + 16) + 16);
                      uVar10 = uVar14;
                    }
                  }
                  else {
                    cVar4 = NGUIText.ParseSymbol
                                      (text,&local_74,
                                       *(uint64 *)(pStatics + 176),
                                       *(uint8 *)(pStatics + 128),
                                       local_70,local_77,&local_78,local_res20,local_res18,local_res8,0);
                    uVar13 = (uint64)local_74;
                    if (!cVar4) goto LAB_181586ddd;
                    iVar12 = local_74 - 1;
                  }
                  local_74 = iVar12 + 1;
                  uVar13 = (uint64)local_74;
                } while ((int)local_74 < iVar1);
              }
              lVar8 = *(int64 *)(pStatics + 240);
              fVar15 = (float)*(int *)(pStatics + 68);
              if (lVar8 != null) {
                uVar9 = *(uint32 *)(lVar8 + 24);
                lVar8 = DAT_181d66a70;
                for (; (0 < (int)uVar9 && (uVar10 = (uint64)uVar9, 0.0 < fVar15));
                    fVar15 = fVar15 - *(float *)(lVar2 + 28 + uVar10 * 4)) {
                  if (((*(byte *)(lVar8 + 0x133) & 4) != 0) && (*(int *)(lVar8 + 224) == 0)) {
                    il2cpp_runtime_class_init();
                    lVar8 = DAT_181d66a70;
                  }
                  lVar2 = *(int64 *)(plVar8 + 240);
                  if (lVar2 == null) goto LAB_1815870e4;
                  lVar2 = *(int64 *)(lVar2 + 16);
                  uVar9 = uVar9 - 1;
                  if (lVar2 == null) goto LAB_1815870e4;
                  if (*(uint32 *)(lVar2 + 24) <= uVar9) {
                    uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar7,0);
                  }
                }
                if (((*(byte *)(lVar8 + 0x133) & 4) != 0) && (*(int *)(lVar8 + 224) == 0)) {
                  il2cpp_runtime_class_init();
                  lVar8 = DAT_181d66a70;
                }
                lVar8 = *(int64 *)(plVar8 + 240);
                if (lVar8 != null) {
                  BetterList_1.Clear(lVar8,DAT_181d81098);
                  uVar3 = uVar9 + 1;
                  if (0.0 <= fVar15) {
                    uVar3 = uVar9;
                  }
                  return uVar3;
                }
              }
            }
        LAB_1815870e4:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return 0;
    }

    // Token : 0x60003A5
    // RVA   : 0x1587F10   Offset: 0x1586710   Length: 0x7B
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

    // Token : 0x60003A6
    // RVA   : 0x158F9E0   Offset: 0x158E1E0   Length: 0x83
    public static bool WrapText(string text, ref string finalText, bool wrapLineColors)
    {
        var plVar15 = *(int64*)(lVar15 + 184);
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        int iVar2;
        long lVar3;
        long lVar4;
        int iVar8;
        int iVar9;
        bool cVar10;
        ushort uVar11;
        int iVar12;
        uint uVar13;
        ulong uVar14;
        long lVar15;
        uint uVar16;
        int iVar18;
        int iVar19;
        uint uVar20;
        float fVar24;
        byte[] auVar25 = new byte[16];
        byte[] auVar26 = new byte[16];
        float fVar27;
        float fVar28;
        float fVar29;
        float fVar30;
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
        if (0 < *(int *)(pStatics + 68)) {
          if (0 < *(int *)(pStatics + 72)) {
            pfVar1 = (float *)(pStatics + 144);
            if (1.0 < *pfVar1 || *pfVar1 == 1.0) {
              if (*(int *)(pStatics + 76) < 1) {
              }
              else {
                Mathf.Min(DAT_181d66a70,
                           (float)*(int *)(pStatics + 76) *
                           *(float *)(pStatics + 144),0);
              }
              if (((0 < *(int *)(pStatics + 76)) &&
                  ((*(byte *)(DAT_181d66a70 + 0x133) & 4) != 0)) && (*(int *)(DAT_181d66a70 + 224) == 0))
              {
                il2cpp_runtime_class_init();
              }
              auVar25._0_8_ = Mathf.Min();
              auVar25._8_8_ = extraout_XMM0_Qb;
              auVar26._4_12_ = auVar25._4_12_;
              auVar26._0_4_ = (float)auVar25._0_8_ + 0.01;
              local_104 = Mathf.FloorToInt(auVar26._0_8_);
              if (local_104 == 0) {
                *finalText = "";
                il2cpp_internal(finalText,"");
                return false;
              }
              cVar10 = FUN_180d6ca90(text);
              if (cVar10) {
                text = " ";
              }
              if (text != null) {
                iVar2 = *(int *)(text + 16);
                NGUIText.Prepare(text);
                if (*(int64 *)(pStatics + 248) == 0) {
                  uVar14 = new StringBuilder(0);
                  *(uint64 *)(pStatics + 248) = uVar14;
                }
                else {
                  lVar15 = *(int64 *)(pStatics + 248);
                  if (lVar15 == null) goto LAB_181591a26;
                  StringBuilder.set_Length(lVar15,0,0);
                }
                iVar19 = 0;
                iVar18 = 1;
                local_110 = 0;
                local_f0 = 0;
                fVar28 = 0.0;
                local_114 = 1;
                auVar25 = *(uint8 (*) [16])(pStatics + 44);
                local_f8 = 0;
                fVar29 = (float)*(int *)(pStatics + 68);
                bVar23 = true;
                local_e4 = CONCAT31(local_e4._1_3_,1);
                local_f4 = 0;
                local_e8 = 0;
                local_f9 = 0;
                local_fa = 0;
                local_fb = 0;
                local_fc = 0;
                local_108[0] = false;
                if (param_5 == 0) {
                  fVar30 = *(float *)(pStatics + 140);
                }
                else {
                  fVar30 = *(float *)(pStatics + 140);
                  fVar24 = (float)NGUIText.GetGlyphWidth
                                            (46,46,
                                             *(uint32 *)(pStatics + 28),0
                                            );
                  fVar30 = (fVar24 + fVar30) * 3.0;
                }
                local_100 = 0;
                lVar15 = *(int64 *)(pStatics + 176);
                if (lVar15 != null) {
                  local_c8 = auVar25;
                  BetterList_1.Add(lVar15,local_c8,DAT_181d80e18);
                  local_ec = 0;
                  if (*(char *)(pStatics + 152) != false) {
                    local_ec = param_4 & 255;
                  }
                  if ((char)local_ec) {
                    lVar15 = *(int64 *)(pStatics + 248);
                    if (lVar15 == null) goto LAB_181591a26;
                    StringBuilder.Append(lVar15,"[",0);
                    lVar15 = *(int64 *)(pStatics + 248);
                    local_c8 = auVar25;
                    iVar12 = NGUIMath.ColorToInt(local_c8,0);
                    uVar14 = NGUIMath.DecimalToHex24(iVar12 >> 8 & 0xffffff,0);
                    if (lVar15 == null) goto LAB_181591a26;
                    StringBuilder.Append(lVar15,uVar14,0);
                    lVar15 = *(int64 *)(pStatics + 248);
                    if (lVar15 == null) goto LAB_181591a26;
                    StringBuilder.Append(lVar15,"]",0);
                  }
                  bVar7 = false;
                  iVar12 = local_104;
                  if (0 < iVar2) {
                    do {
                      uVar11 = String.get_Chars(text,local_110,0);
                      uVar16 = (uint32)uVar11;
                      if ((uVar11 == 32) || (uVar11 - 0x200a < 2)) {
                        bVar21 = true;
                      }
                      else {
                        bVar21 = uVar16 == 0x2009;
                      }
                      if (uVar11 < 0x3000) {
                        if (uVar11 != 10) goto LAB_1815901c1;
                        if (local_114 == local_104) break;
                        if (iVar19 < local_110) {
                          lVar15 = *(int64 *)(pStatics + 248);
                          uVar14 = String.Substring(text,iVar19,(local_110 - iVar19) + 1,0);
                          if (lVar15 == null) goto LAB_181591a26;
                          StringBuilder.Append(lVar15,uVar14);
                        }
                        else {
                          lVar15 = *(int64 *)(pStatics + 248);
                          if (lVar15 == null) goto LAB_181591a26;
                          StringBuilder.Append(lVar15,10);
                        }
                        if ((char)local_ec) {
                          iVar19 = 0;
                          while( true ) {
                            lVar15 = *(int64 *)(pStatics + 176);
                            if (lVar15 == null) goto LAB_181591a26;
                            if (*(int *)(lVar15 + 24) <= iVar19) break;
                            lVar15 = *(int64 *)(pStatics + 248);
                            if (lVar15 == null) goto LAB_181591a26;
                            iVar18 = FUN_18123bdd0(lVar15,0);
                            StringBuilder.Insert(lVar15,iVar18 + -1);
                            iVar19 = iVar19 + 1;
                          }
                          uVar16 = 0;
                          while( true ) {
                            lVar15 = *(int64 *)(pStatics + 176);
                            if (lVar15 == null) goto LAB_181591a26;
                            if (*(int *)(lVar15 + 24) <= (int)uVar16) break;
                            lVar15 = *(int64 *)(pStatics + 248);
                            if (lVar15 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar15,"[");
                            lVar15 = *(int64 *)(pStatics + 176);
                            lVar3 = *(int64 *)(pStatics + 248);
                            if ((lVar15 == null) || (lVar15 = *(int64 *)(lVar15 + 16)) == null)
                            goto LAB_181591a26;
                            if (*(uint32 *)(lVar15 + 24) <= uVar16) {
                              uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar14,0);
                            }
                            auVar25 = *(uint8 (*) [16])(lVar15 + ((int64)(int)uVar16 + 2) * 16);
                            local_d8 = auVar25;
                            iVar19 = NGUIMath.ColorToInt(local_d8,0);
                            uVar14 = NGUIMath.DecimalToHex24(iVar19 >> 8 & 0xffffff,0);
                            if (lVar3 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar3,uVar14);
                            lVar15 = *(int64 *)(pStatics + 248);
                            if (lVar15 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar15,"]");
                            uVar16 = uVar16 + 1;
                          }
                        }
                        local_f8 = 0;
                        fVar28 = 0.0;
                        local_114 = local_114 + 1;
                        iVar19 = local_110 + 1;
                        bVar23 = true;
                      }
                      else {
                        bVar7 = true;
        LAB_1815901c1:
                        bVar22 = local_114 == local_104;
                        iVar18 = local_114;
                        if (*(char *)(pStatics + 116) != false) {
                          cVar10 = NGUIText.ParseSymbol
                                             (text,&local_f0,
                                              *(uint64 *)(pStatics + 176),
                                              *(uint8 *)(pStatics + 128),
                                              &local_e8,&local_f9,&local_fa,&local_fb,&local_fc,local_108,
                                              0);
                          iVar9 = local_f0;
                          iVar8 = local_100;
                          iVar12 = local_104;
                          if (cVar10) {
                            bVar17 = 0;
                            if (local_114 == local_104) {
                              bVar17 = param_5;
                            }
                            if ((bVar17 == 0) || (local_100 <= iVar19)) {
                              if (local_f0 < local_100 + 1) {
                                lVar15 = *(int64 *)(pStatics + 248);
                                uVar14 = String.Substring(text,iVar19,iVar9 - iVar19,0);
                                if (lVar15 == null) goto LAB_181591a26;
                                StringBuilder.Append(lVar15,uVar14);
                                iVar19 = iVar9;
                              }
                              uVar16 = 0;
                              lVar15 = DAT_181d66a70;
                              if ((char)local_ec) {
                                if (local_108[0] == false) {
                                  lVar15 = *(int64 *)(pStatics + 176);
                                  if ((lVar15 == null) || (lVar3 = *(int64 *)(lVar15 + 16)) == null)
                                  goto LAB_181591a26;
                                  if (*(uint32 *)(lVar3 + 24) <= *(int *)(lVar15 + 24) - 1U) {
                                    uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar14,0);
                                  }
                                  local_d8 = *(uint8 (*) [16])
                                              (pStatics + 44);
                                  local_c8 = *(uint8 (*) [16])
                                              (lVar3 + ((int64)*(int *)(lVar15 + 24) + 1) * 16);
                                  Color.op_Multiply(local_b8,local_d8);
                                }
                                else {
                                  lVar15 = *(int64 *)(pStatics + 176);
                                  if ((lVar15 == null) || (*(int64 *)(lVar15 + 16) == 0))
                                  goto LAB_181591a26;
                                  if (*(uint32 *)(*(int64 *)(lVar15 + 16) + 24) <=
                                      *(int *)(lVar15 + 24) - 1U) {
                                    uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar14,0);
                                  }
                                }
                                lVar15 = *(int64 *)(pStatics + 176);
                                if (lVar15 == null) goto LAB_181591a26;
                                iVar18 = *(int *)(lVar15 + 24) + -2;
                                lVar15 = DAT_181d66a70;
                                if (0 < iVar18) {
                                  do {
                                    if (((*(byte *)(lVar15 + 0x133) & 4) != 0) &&
                                       (*(int *)(lVar15 + 224) == 0)) {
                                      il2cpp_runtime_class_init();
                                      lVar15 = DAT_181d66a70;
                                    }
                                    lVar3 = *(int64 *)(plVar15 + 176);
                                    if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 16)) == null)
                                    goto LAB_181591a26;
                                    if (*(uint32 *)(lVar3 + 24) <= uVar16) {
                                      uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar14,0);
                                    }
                                    uVar16 = uVar16 + 1;
                                  } while ((int)uVar16 < iVar18);
                                }
                              }
                              if (iVar19 < iVar9) {
                                if (((*(byte *)(lVar15 + 0x133) & 4) != 0) &&
                                   (*(int *)(lVar15 + 224) == 0)) {
                                  il2cpp_runtime_class_init();
                                  lVar15 = DAT_181d66a70;
                                }
                                lVar15 = *(int64 *)(plVar15 + 248);
                                uVar14 = String.Substring(text,iVar19,iVar9 - iVar19,0);
                                if (lVar15 == null) goto LAB_181591a26;
                                StringBuilder.Append(lVar15,uVar14);
                              }
                              else {
                                if (((*(byte *)(lVar15 + 0x133) & 4) != 0) &&
                                   (*(int *)(lVar15 + 224) == 0)) {
                                  il2cpp_runtime_class_init();
                                  lVar15 = DAT_181d66a70;
                                }
                                lVar15 = *(int64 *)(plVar15 + 248);
                                if (lVar15 == null) goto LAB_181591a26;
                                StringBuilder.Append(lVar15,uVar11);
                              }
                              local_110 = iVar9 + -1;
                              local_100 = iVar9;
                              local_f4 = local_e8;
                              iVar19 = iVar9;
                              goto LAB_1815905a3;
                            }
                            lVar15 = *(int64 *)(pStatics + 248);
                            uVar14 = String.Substring(text,iVar19,(iVar8 - iVar19) + 1,0);
                            if (lVar15 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar15,uVar14,0);
                            if (local_f4 != 0) {
                              lVar15 = *(int64 *)(pStatics + 248);
                              if (lVar15 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar15,"[/sub]",0);
                            }
                            lVar15 = *(int64 *)(pStatics + 248);
                            if (lVar15 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar15,"...",0);
                            local_110 = local_f0;
                            goto LAB_181591515;
                          }
                          local_110 = local_f0;
                          local_f4 = local_e8;
                        }
                        iVar12 = local_f4;
                        if (*(char *)(pStatics + 152) == false) {
                          lVar15 = 0;
                        }
                        else {
                          lVar15 = NGUIText.GetSymbol(text,local_110);
                        }
                        if (iVar12 == 0) {
                          fVar24 = *(float *)(pStatics + 28);
                        }
                        else {
                          fVar24 = *(float *)(pStatics + 28) * 0.75;
                        }
                        if (lVar15 == null) {
                          fVar24 = (float)NGUIText.GetGlyphWidth(uVar11,local_f8,fVar24);
                          if ((fVar24 == 0.0) && (!bVar21)) goto LAB_1815905a3;
                        }
                        else {
                          fVar24 = (float)*(int *)(lVar15 + 64) * fVar24;
                        }
                        fVar24 = fVar24 + *(float *)(pStatics + 140);
                        if (iVar12 != 0) {
                          fVar24 = (float)FUN_18000d7c0();
                        }
                        fVar28 = fVar28 + fVar24;
                        bVar17 = (bVar23 || bVar22) & param_5;
                        fVar27 = fVar29;
                        if (bVar17 != 0) {
                          fVar27 = fVar29 - fVar30;
                        }
                        local_f8 = uVar16;
                        bVar6 = bVar23;
                        if (((bVar21) && (!bVar7)) && (iVar19 < local_110)) {
                          iVar12 = local_110 - iVar19;
                          if (((local_114 == local_104) && (fVar27 <= fVar28)) && (local_110 < iVar2)) {
                            uVar11 = String.get_Chars(text,local_110,0);
                            if (31 < uVar11) {
                              if (((uVar11 != 32) && (1 < uVar11 - 0x200a)) && (uVar11 != 0x2009))
                              goto LAB_18159082b;
                            }
                            iVar12 = iVar12 + -1;
                          }
        LAB_18159082b:
                          iVar8 = local_100;
                          if (((bVar17 == 0) || (local_100 <= iVar19)) ||
                             ((fVar29 <= fVar28 || (fVar28 <= fVar27)))) {
                            lVar3 = *(int64 *)(pStatics + 248);
                            uVar14 = String.Substring(text,iVar19,iVar12 + 1,0);
                            if (lVar3 != null) {
                              StringBuilder.Append(lVar3,uVar14);
                              iVar19 = local_110 + 1;
                              bVar6 = false;
                              goto LAB_1815908d0;
                            }
                            goto LAB_181591a26;
                          }
                          lVar15 = *(int64 *)(pStatics + 248);
                          uVar14 = String.Substring(text,iVar19,(iVar8 - iVar19) + 1,0);
                          if (lVar15 == null) goto LAB_181591a26;
                          StringBuilder.Append(lVar15,uVar14,0);
                          if (local_f4 != 0) {
                            lVar15 = *(int64 *)(pStatics + 248);
                            if (lVar15 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar15,"[/sub]",0);
                          }
                          lVar15 = pStatics;
        LAB_181591722:
                          if (*(int64 *)(lVar15 + 248) == 0) goto LAB_181591a26;
                          StringBuilder.Append(*(int64 *)(lVar15 + 248),"...",0);
                          iVar12 = local_104;
                          goto LAB_181591515;
                        }
        LAB_1815908d0:
                        if (((param_5 != 0) && (!bVar21)) && (fVar28 < fVar27)) {
                          local_100 = local_110;
                        }
                        iVar12 = local_100;
                        if (fVar27 < fVar28) {
                          if (!bVar23 && !bVar22) {
                            for (; iVar19 < iVar2; iVar19 = iVar19 + 1) {
                              uVar11 = String.get_Chars(text,iVar19);
                              if (((uVar11 != 32) && (1 < uVar11 - 0x200a)) && (uVar11 != 0x2009))
                              break;
                            }
                            local_110 = iVar19 + -1;
                            iVar18 = local_114 + 1;
                            local_f8 = 0;
                            fVar28 = 0.0;
                            bVar23 = local_114 != local_104;
                            local_114 = iVar18;
                            if (bVar23) {
                              if (!wrapLineColors) {
                                NGUIText.EndLine(pStatics + 248,0);
                              }
                              else {
                                NGUIText.ReplaceSpaceWithNewline
                                          (pStatics + 248,0);
                              }
                              bVar23 = true;
                              if ((char)local_ec) {
                                iVar18 = 0;
                                while( true ) {
                                  lVar15 = *(int64 *)(pStatics + 176);
                                  if (lVar15 == null) goto LAB_181591a26;
                                  if (*(int *)(lVar15 + 24) <= iVar18) break;
                                  lVar15 = *(int64 *)(pStatics + 248);
                                  if (lVar15 == null) goto LAB_181591a26;
                                  iVar12 = FUN_18123bdd0(lVar15,0);
                                  StringBuilder.Insert(lVar15,iVar12 + -1);
                                  iVar18 = iVar18 + 1;
                                }
                                uVar16 = 0;
                                while( true ) {
                                  lVar15 = *(int64 *)(pStatics + 176);
                                  if (lVar15 == null) goto LAB_181591a26;
                                  fVar28 = 0.0;
                                  if (*(int *)(lVar15 + 24) <= (int)uVar16) break;
                                  lVar15 = *(int64 *)(pStatics + 248);
                                  if (lVar15 == null) goto LAB_181591a26;
                                  StringBuilder.Append(lVar15,"[");
                                  lVar15 = *(int64 *)(pStatics + 176);
                                  lVar3 = *(int64 *)(pStatics + 248);
                                  if ((lVar15 == null) ||
                                     (lVar15 = *(int64 *)(lVar15 + 16)) == null)
                                  goto LAB_181591a26;
                                  if (*(uint32 *)(lVar15 + 24) <= uVar16) {
                                    uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar14,0);
                                  }
                                  auVar25 = *(uint8 (*) [16])
                                             (lVar15 + ((int64)(int)uVar16 + 2) * 16);
                                  local_d8 = auVar25;
                                  iVar18 = NGUIMath.ColorToInt(local_d8,0);
                                  uVar14 = NGUIMath.DecimalToHex24(iVar18 >> 8 & 0xffffff,0);
                                  if (lVar3 == null) goto LAB_181591a26;
                                  StringBuilder.Append(lVar3,uVar14);
                                  lVar15 = *(int64 *)(pStatics + 248);
                                  if (lVar15 == null) goto LAB_181591a26;
                                  StringBuilder.Append(lVar15,"]");
                                  uVar16 = uVar16 + 1;
                                }
                              }
                              goto LAB_1815905a3;
                            }
                            break;
                          }
                          if ((param_5 != 0) && (0 < local_110)) {
                            if (iVar19 < local_100) {
                              lVar15 = *(int64 *)(pStatics + 248);
                              uVar14 = String.Substring(text,iVar19,(iVar12 - iVar19) + 1,0);
                              if (lVar15 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar15,uVar14,0);
                            }
                            if (local_f4 != 0) {
                              lVar15 = *(int64 *)(pStatics + 248);
                              if (lVar15 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar15,"[/sub]",0);
                            }
                            lVar15 = pStatics;
                            goto LAB_181591722;
                          }
                          lVar3 = *(int64 *)(pStatics + 248);
                          uVar13 = Mathf.Max(0,local_110 - iVar19,0);
                          uVar14 = String.Substring(text,iVar19,uVar13,0);
                          if (lVar3 == null) goto LAB_181591a26;
                          StringBuilder.Append(lVar3,uVar14);
                          if ((!bVar21) && (local_e4 = local_e4 & 255, !bVar7)) {
                            local_e4 = 0;
                          }
                          cVar10 = (char)local_ec;
                          if (cVar10) {
                            lVar3 = *(int64 *)(pStatics + 176);
                            if (lVar3 == null) goto LAB_181591a26;
                            if (0 < *(int *)(lVar3 + 24)) {
                              lVar3 = *(int64 *)(pStatics + 248);
                              if (lVar3 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar3,"[-]");
                            }
                          }
                          iVar18 = local_114 + 1;
                          iVar12 = local_104;
                          if (local_114 == local_104) goto LAB_181591515;
                          if (!wrapLineColors) {
                            NGUIText.EndLine(pStatics + 248,0);
                          }
                          else {
                            NGUIText.ReplaceSpaceWithNewline
                                      (pStatics + 248,0);
                          }
                          uVar20 = 0;
                          uVar16 = uVar20;
                          if (cVar10) {
                            while( true ) {
                              lVar3 = *(int64 *)(pStatics + 176);
                              if (lVar3 == null) goto LAB_181591a26;
                              if (*(int *)(lVar3 + 24) <= (int)uVar16) break;
                              lVar3 = *(int64 *)(pStatics + 248);
                              if (lVar3 == null) goto LAB_181591a26;
                              iVar19 = FUN_18123bdd0(lVar3,0);
                              StringBuilder.Insert(lVar3,iVar19 + -1);
                              uVar16 = uVar16 + 1;
                            }
                            while( true ) {
                              lVar3 = *(int64 *)(pStatics + 176);
                              if (lVar3 == null) goto LAB_181591a26;
                              if (*(int *)(lVar3 + 24) <= (int)uVar20) break;
                              lVar3 = *(int64 *)(pStatics + 248);
                              if (lVar3 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar3,"[");
                              lVar3 = *(int64 *)(pStatics + 176);
                              lVar4 = *(int64 *)(pStatics + 248);
                              if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 16)) == null)
                              goto LAB_181591a26;
                              if (*(uint32 *)(lVar3 + 24) <= uVar20) {
                                uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar14,0);
                              }
                              auVar25 = *(uint8 (*) [16])(lVar3 + ((int64)(int)uVar20 + 2) * 16)
                              ;
                              local_d8 = auVar25;
                              iVar19 = NGUIMath.ColorToInt(local_d8,0);
                              uVar14 = NGUIMath.DecimalToHex24(iVar19 >> 8 & 0xffffff,0);
                              if (lVar4 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar4,uVar14);
                              lVar3 = *(int64 *)(pStatics + 248);
                              if (lVar3 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar3,"]");
                              uVar20 = uVar20 + 1;
                            }
                          }
                          bVar6 = true;
                          local_114 = iVar18;
                          if (bVar21) {
                            iVar19 = local_110 + 1;
                            fVar28 = 0.0;
                            local_100 = local_110;
                            local_f8 = 0;
                          }
                          else {
                            local_100 = local_110;
                            local_f8 = 0;
                            fVar28 = fVar24;
                            iVar19 = local_110;
                          }
                        }
                        bVar23 = bVar6;
                        if (lVar15 != null) {
                          iVar18 = BMSymbol.get_length(lVar15,0);
                          local_110 = local_110 + -1 + iVar18;
                          local_f8 = 0;
                        }
                      }
        LAB_1815905a3:
                      local_110 = local_110 + 1;
                      local_f0 = local_110;
                    } while (local_110 < iVar2);
                    iVar12 = local_104;
                    iVar18 = local_114;
                    if (iVar19 < local_110) {
                      lVar15 = *(int64 *)(pStatics + 248);
                      uVar14 = String.Substring(text,iVar19,local_110 - iVar19,0);
                      if (lVar15 == null) goto LAB_181591a26;
                      StringBuilder.Append(lVar15,uVar14,0);
                    }
                  }
        LAB_181591515:
                  if ((char)local_ec) {
                    lVar15 = *(int64 *)(pStatics + 176);
                    if (lVar15 == null) goto LAB_181591a26;
                    if (0 < *(int *)(lVar15 + 24)) {
                      lVar15 = *(int64 *)(pStatics + 248);
                      if (lVar15 == null) goto LAB_181591a26;
                      StringBuilder.Append(lVar15,"[-]",0);
                    }
                  }
                  plVar5 = *(int64 **)(pStatics + 248);
                  if (plVar5 != (int64 *)0) {
                    uVar14 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
                    *finalText = uVar14;
                    il2cpp_internal(finalText,uVar14);
                    lVar15 = *(int64 *)(pStatics + 176);
                    if (lVar15 != null) {
                      BetterList_1.Clear(lVar15,DAT_181d80e98);
                      if ((char)!local_e4) {
                        return false;
                      }
                      if (local_110 == iVar2) {
                        return true;
                      }
                      if (*(int *)(pStatics + 76) != 0) {
                        return iVar18 == iVar12;
                      }
                      return iVar18 == 0;
                    }
                  }
                }
              }
        LAB_181591a26:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
        *finalText = "";
        il2cpp_internal(finalText,"");
        return false;
    }

    // Token : 0x60003A7
    // RVA   : 0x158FA70   Offset: 0x158E270   Length: 0x1FBB
    public static bool WrapText(string text, ref string finalText, bool keepCharCount, bool wrapLineColors, bool useEllipsis)
    {
        var plVar15 = *(int64*)(lVar15 + 184);
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        int iVar2;
        long lVar3;
        long lVar4;
        int iVar8;
        int iVar9;
        bool cVar10;
        ushort uVar11;
        int iVar12;
        uint uVar13;
        ulong uVar14;
        long lVar15;
        uint uVar16;
        int iVar18;
        int iVar19;
        uint uVar20;
        float fVar24;
        byte[] auVar25 = new byte[16];
        byte[] auVar26 = new byte[16];
        float fVar27;
        float fVar28;
        float fVar29;
        float fVar30;
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
        if (0 < *(int *)(pStatics + 68)) {
          if (0 < *(int *)(pStatics + 72)) {
            pfVar1 = (float *)(pStatics + 144);
            if (1.0 < *pfVar1 || *pfVar1 == 1.0) {
              if (*(int *)(pStatics + 76) < 1) {
              }
              else {
                Mathf.Min(DAT_181d66a70,
                           (float)*(int *)(pStatics + 76) *
                           *(float *)(pStatics + 144),0);
              }
              if (((0 < *(int *)(pStatics + 76)) &&
                  ((*(byte *)(DAT_181d66a70 + 0x133) & 4) != 0)) && (*(int *)(DAT_181d66a70 + 224) == 0))
              {
                il2cpp_runtime_class_init();
              }
              auVar25._0_8_ = Mathf.Min();
              auVar25._8_8_ = extraout_XMM0_Qb;
              auVar26._4_12_ = auVar25._4_12_;
              auVar26._0_4_ = (float)auVar25._0_8_ + 0.01;
              local_104 = Mathf.FloorToInt(auVar26._0_8_);
              if (local_104 == 0) {
                *finalText = "";
                il2cpp_internal(finalText,"");
                return false;
              }
              cVar10 = FUN_180d6ca90(text);
              if (cVar10) {
                text = " ";
              }
              if (text != null) {
                iVar2 = *(int *)(text + 16);
                NGUIText.Prepare(text);
                if (*(int64 *)(pStatics + 248) == 0) {
                  uVar14 = new StringBuilder(0);
                  *(uint64 *)(pStatics + 248) = uVar14;
                }
                else {
                  lVar15 = *(int64 *)(pStatics + 248);
                  if (lVar15 == null) goto LAB_181591a26;
                  StringBuilder.set_Length(lVar15,0,0);
                }
                iVar19 = 0;
                iVar18 = 1;
                local_110 = 0;
                local_f0 = 0;
                fVar28 = 0.0;
                local_114 = 1;
                auVar25 = *(uint8 (*) [16])(pStatics + 44);
                local_f8 = 0;
                fVar29 = (float)*(int *)(pStatics + 68);
                bVar23 = true;
                local_e4 = CONCAT31(local_e4._1_3_,1);
                local_f4 = 0;
                local_e8 = 0;
                local_f9 = 0;
                local_fa = 0;
                local_fb = 0;
                local_fc = 0;
                local_108[0] = false;
                if (useEllipsis == null) {
                  fVar30 = *(float *)(pStatics + 140);
                }
                else {
                  fVar30 = *(float *)(pStatics + 140);
                  fVar24 = (float)NGUIText.GetGlyphWidth
                                            (46,46,
                                             *(uint32 *)(pStatics + 28),0
                                            );
                  fVar30 = (fVar24 + fVar30) * 3.0;
                }
                local_100 = 0;
                lVar15 = *(int64 *)(pStatics + 176);
                if (lVar15 != null) {
                  local_c8 = auVar25;
                  BetterList_1.Add(lVar15,local_c8,DAT_181d80e18);
                  local_ec = 0;
                  if (*(char *)(pStatics + 152) != false) {
                    local_ec = wrapLineColors & 255;
                  }
                  if ((char)local_ec) {
                    lVar15 = *(int64 *)(pStatics + 248);
                    if (lVar15 == null) goto LAB_181591a26;
                    StringBuilder.Append(lVar15,"[",0);
                    lVar15 = *(int64 *)(pStatics + 248);
                    local_c8 = auVar25;
                    iVar12 = NGUIMath.ColorToInt(local_c8,0);
                    uVar14 = NGUIMath.DecimalToHex24(iVar12 >> 8 & 0xffffff,0);
                    if (lVar15 == null) goto LAB_181591a26;
                    StringBuilder.Append(lVar15,uVar14,0);
                    lVar15 = *(int64 *)(pStatics + 248);
                    if (lVar15 == null) goto LAB_181591a26;
                    StringBuilder.Append(lVar15,"]",0);
                  }
                  bVar7 = false;
                  iVar12 = local_104;
                  if (0 < iVar2) {
                    do {
                      uVar11 = String.get_Chars(text,local_110,0);
                      uVar16 = (uint32)uVar11;
                      if ((uVar11 == 32) || (uVar11 - 0x200a < 2)) {
                        bVar21 = true;
                      }
                      else {
                        bVar21 = uVar16 == 0x2009;
                      }
                      if (uVar11 < 0x3000) {
                        if (uVar11 != 10) goto LAB_1815901c1;
                        if (local_114 == local_104) break;
                        if (iVar19 < local_110) {
                          lVar15 = *(int64 *)(pStatics + 248);
                          uVar14 = String.Substring(text,iVar19,(local_110 - iVar19) + 1,0);
                          if (lVar15 == null) goto LAB_181591a26;
                          StringBuilder.Append(lVar15,uVar14);
                        }
                        else {
                          lVar15 = *(int64 *)(pStatics + 248);
                          if (lVar15 == null) goto LAB_181591a26;
                          StringBuilder.Append(lVar15,10);
                        }
                        if ((char)local_ec) {
                          iVar19 = 0;
                          while( true ) {
                            lVar15 = *(int64 *)(pStatics + 176);
                            if (lVar15 == null) goto LAB_181591a26;
                            if (*(int *)(lVar15 + 24) <= iVar19) break;
                            lVar15 = *(int64 *)(pStatics + 248);
                            if (lVar15 == null) goto LAB_181591a26;
                            iVar18 = FUN_18123bdd0(lVar15,0);
                            StringBuilder.Insert(lVar15,iVar18 + -1);
                            iVar19 = iVar19 + 1;
                          }
                          uVar16 = 0;
                          while( true ) {
                            lVar15 = *(int64 *)(pStatics + 176);
                            if (lVar15 == null) goto LAB_181591a26;
                            if (*(int *)(lVar15 + 24) <= (int)uVar16) break;
                            lVar15 = *(int64 *)(pStatics + 248);
                            if (lVar15 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar15,"[");
                            lVar15 = *(int64 *)(pStatics + 176);
                            lVar3 = *(int64 *)(pStatics + 248);
                            if ((lVar15 == null) || (lVar15 = *(int64 *)(lVar15 + 16)) == null)
                            goto LAB_181591a26;
                            if (*(uint32 *)(lVar15 + 24) <= uVar16) {
                              uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar14,0);
                            }
                            auVar25 = *(uint8 (*) [16])(lVar15 + ((int64)(int)uVar16 + 2) * 16);
                            local_d8 = auVar25;
                            iVar19 = NGUIMath.ColorToInt(local_d8,0);
                            uVar14 = NGUIMath.DecimalToHex24(iVar19 >> 8 & 0xffffff,0);
                            if (lVar3 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar3,uVar14);
                            lVar15 = *(int64 *)(pStatics + 248);
                            if (lVar15 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar15,"]");
                            uVar16 = uVar16 + 1;
                          }
                        }
                        local_f8 = 0;
                        fVar28 = 0.0;
                        local_114 = local_114 + 1;
                        iVar19 = local_110 + 1;
                        bVar23 = true;
                      }
                      else {
                        bVar7 = true;
        LAB_1815901c1:
                        bVar22 = local_114 == local_104;
                        iVar18 = local_114;
                        if (*(char *)(pStatics + 116) != false) {
                          cVar10 = NGUIText.ParseSymbol
                                             (text,&local_f0,
                                              *(uint64 *)(pStatics + 176),
                                              *(uint8 *)(pStatics + 128),
                                              &local_e8,&local_f9,&local_fa,&local_fb,&local_fc,local_108,
                                              0);
                          iVar9 = local_f0;
                          iVar8 = local_100;
                          iVar12 = local_104;
                          if (cVar10) {
                            bVar17 = 0;
                            if (local_114 == local_104) {
                              bVar17 = useEllipsis;
                            }
                            if ((bVar17 == 0) || (local_100 <= iVar19)) {
                              if (local_f0 < local_100 + 1) {
                                lVar15 = *(int64 *)(pStatics + 248);
                                uVar14 = String.Substring(text,iVar19,iVar9 - iVar19,0);
                                if (lVar15 == null) goto LAB_181591a26;
                                StringBuilder.Append(lVar15,uVar14);
                                iVar19 = iVar9;
                              }
                              uVar16 = 0;
                              lVar15 = DAT_181d66a70;
                              if ((char)local_ec) {
                                if (local_108[0] == false) {
                                  lVar15 = *(int64 *)(pStatics + 176);
                                  if ((lVar15 == null) || (lVar3 = *(int64 *)(lVar15 + 16)) == null)
                                  goto LAB_181591a26;
                                  if (*(uint32 *)(lVar3 + 24) <= *(int *)(lVar15 + 24) - 1U) {
                                    uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar14,0);
                                  }
                                  local_d8 = *(uint8 (*) [16])
                                              (pStatics + 44);
                                  local_c8 = *(uint8 (*) [16])
                                              (lVar3 + ((int64)*(int *)(lVar15 + 24) + 1) * 16);
                                  Color.op_Multiply(local_b8,local_d8);
                                }
                                else {
                                  lVar15 = *(int64 *)(pStatics + 176);
                                  if ((lVar15 == null) || (*(int64 *)(lVar15 + 16) == 0))
                                  goto LAB_181591a26;
                                  if (*(uint32 *)(*(int64 *)(lVar15 + 16) + 24) <=
                                      *(int *)(lVar15 + 24) - 1U) {
                                    uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar14,0);
                                  }
                                }
                                lVar15 = *(int64 *)(pStatics + 176);
                                if (lVar15 == null) goto LAB_181591a26;
                                iVar18 = *(int *)(lVar15 + 24) + -2;
                                lVar15 = DAT_181d66a70;
                                if (0 < iVar18) {
                                  do {
                                    if (((*(byte *)(lVar15 + 0x133) & 4) != 0) &&
                                       (*(int *)(lVar15 + 224) == 0)) {
                                      il2cpp_runtime_class_init();
                                      lVar15 = DAT_181d66a70;
                                    }
                                    lVar3 = *(int64 *)(plVar15 + 176);
                                    if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 16)) == null)
                                    goto LAB_181591a26;
                                    if (*(uint32 *)(lVar3 + 24) <= uVar16) {
                                      uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar14,0);
                                    }
                                    uVar16 = uVar16 + 1;
                                  } while ((int)uVar16 < iVar18);
                                }
                              }
                              if (iVar19 < iVar9) {
                                if (((*(byte *)(lVar15 + 0x133) & 4) != 0) &&
                                   (*(int *)(lVar15 + 224) == 0)) {
                                  il2cpp_runtime_class_init();
                                  lVar15 = DAT_181d66a70;
                                }
                                lVar15 = *(int64 *)(plVar15 + 248);
                                uVar14 = String.Substring(text,iVar19,iVar9 - iVar19,0);
                                if (lVar15 == null) goto LAB_181591a26;
                                StringBuilder.Append(lVar15,uVar14);
                              }
                              else {
                                if (((*(byte *)(lVar15 + 0x133) & 4) != 0) &&
                                   (*(int *)(lVar15 + 224) == 0)) {
                                  il2cpp_runtime_class_init();
                                  lVar15 = DAT_181d66a70;
                                }
                                lVar15 = *(int64 *)(plVar15 + 248);
                                if (lVar15 == null) goto LAB_181591a26;
                                StringBuilder.Append(lVar15,uVar11);
                              }
                              local_110 = iVar9 + -1;
                              local_100 = iVar9;
                              local_f4 = local_e8;
                              iVar19 = iVar9;
                              goto LAB_1815905a3;
                            }
                            lVar15 = *(int64 *)(pStatics + 248);
                            uVar14 = String.Substring(text,iVar19,(iVar8 - iVar19) + 1,0);
                            if (lVar15 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar15,uVar14,0);
                            if (local_f4 != 0) {
                              lVar15 = *(int64 *)(pStatics + 248);
                              if (lVar15 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar15,"[/sub]",0);
                            }
                            lVar15 = *(int64 *)(pStatics + 248);
                            if (lVar15 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar15,"...",0);
                            local_110 = local_f0;
                            goto LAB_181591515;
                          }
                          local_110 = local_f0;
                          local_f4 = local_e8;
                        }
                        iVar12 = local_f4;
                        if (*(char *)(pStatics + 152) == false) {
                          lVar15 = 0;
                        }
                        else {
                          lVar15 = NGUIText.GetSymbol(text,local_110);
                        }
                        if (iVar12 == 0) {
                          fVar24 = *(float *)(pStatics + 28);
                        }
                        else {
                          fVar24 = *(float *)(pStatics + 28) * 0.75;
                        }
                        if (lVar15 == null) {
                          fVar24 = (float)NGUIText.GetGlyphWidth(uVar11,local_f8,fVar24);
                          if ((fVar24 == 0.0) && (!bVar21)) goto LAB_1815905a3;
                        }
                        else {
                          fVar24 = (float)*(int *)(lVar15 + 64) * fVar24;
                        }
                        fVar24 = fVar24 + *(float *)(pStatics + 140);
                        if (iVar12 != 0) {
                          fVar24 = (float)FUN_18000d7c0();
                        }
                        fVar28 = fVar28 + fVar24;
                        bVar17 = (bVar23 || bVar22) & useEllipsis;
                        fVar27 = fVar29;
                        if (bVar17 != 0) {
                          fVar27 = fVar29 - fVar30;
                        }
                        local_f8 = uVar16;
                        bVar6 = bVar23;
                        if (((bVar21) && (!bVar7)) && (iVar19 < local_110)) {
                          iVar12 = local_110 - iVar19;
                          if (((local_114 == local_104) && (fVar27 <= fVar28)) && (local_110 < iVar2)) {
                            uVar11 = String.get_Chars(text,local_110,0);
                            if (31 < uVar11) {
                              if (((uVar11 != 32) && (1 < uVar11 - 0x200a)) && (uVar11 != 0x2009))
                              goto LAB_18159082b;
                            }
                            iVar12 = iVar12 + -1;
                          }
        LAB_18159082b:
                          iVar8 = local_100;
                          if (((bVar17 == 0) || (local_100 <= iVar19)) ||
                             ((fVar29 <= fVar28 || (fVar28 <= fVar27)))) {
                            lVar3 = *(int64 *)(pStatics + 248);
                            uVar14 = String.Substring(text,iVar19,iVar12 + 1,0);
                            if (lVar3 != null) {
                              StringBuilder.Append(lVar3,uVar14);
                              iVar19 = local_110 + 1;
                              bVar6 = false;
                              goto LAB_1815908d0;
                            }
                            goto LAB_181591a26;
                          }
                          lVar15 = *(int64 *)(pStatics + 248);
                          uVar14 = String.Substring(text,iVar19,(iVar8 - iVar19) + 1,0);
                          if (lVar15 == null) goto LAB_181591a26;
                          StringBuilder.Append(lVar15,uVar14,0);
                          if (local_f4 != 0) {
                            lVar15 = *(int64 *)(pStatics + 248);
                            if (lVar15 == null) goto LAB_181591a26;
                            StringBuilder.Append(lVar15,"[/sub]",0);
                          }
                          lVar15 = pStatics;
        LAB_181591722:
                          if (*(int64 *)(lVar15 + 248) == 0) goto LAB_181591a26;
                          StringBuilder.Append(*(int64 *)(lVar15 + 248),"...",0);
                          iVar12 = local_104;
                          goto LAB_181591515;
                        }
        LAB_1815908d0:
                        if (((useEllipsis != null) && (!bVar21)) && (fVar28 < fVar27)) {
                          local_100 = local_110;
                        }
                        iVar12 = local_100;
                        if (fVar27 < fVar28) {
                          if (!bVar23 && !bVar22) {
                            for (; iVar19 < iVar2; iVar19 = iVar19 + 1) {
                              uVar11 = String.get_Chars(text,iVar19);
                              if (((uVar11 != 32) && (1 < uVar11 - 0x200a)) && (uVar11 != 0x2009))
                              break;
                            }
                            local_110 = iVar19 + -1;
                            iVar18 = local_114 + 1;
                            local_f8 = 0;
                            fVar28 = 0.0;
                            bVar23 = local_114 != local_104;
                            local_114 = iVar18;
                            if (bVar23) {
                              if (!keepCharCount) {
                                NGUIText.EndLine(pStatics + 248,0);
                              }
                              else {
                                NGUIText.ReplaceSpaceWithNewline
                                          (pStatics + 248,0);
                              }
                              bVar23 = true;
                              if ((char)local_ec) {
                                iVar18 = 0;
                                while( true ) {
                                  lVar15 = *(int64 *)(pStatics + 176);
                                  if (lVar15 == null) goto LAB_181591a26;
                                  if (*(int *)(lVar15 + 24) <= iVar18) break;
                                  lVar15 = *(int64 *)(pStatics + 248);
                                  if (lVar15 == null) goto LAB_181591a26;
                                  iVar12 = FUN_18123bdd0(lVar15,0);
                                  StringBuilder.Insert(lVar15,iVar12 + -1);
                                  iVar18 = iVar18 + 1;
                                }
                                uVar16 = 0;
                                while( true ) {
                                  lVar15 = *(int64 *)(pStatics + 176);
                                  if (lVar15 == null) goto LAB_181591a26;
                                  fVar28 = 0.0;
                                  if (*(int *)(lVar15 + 24) <= (int)uVar16) break;
                                  lVar15 = *(int64 *)(pStatics + 248);
                                  if (lVar15 == null) goto LAB_181591a26;
                                  StringBuilder.Append(lVar15,"[");
                                  lVar15 = *(int64 *)(pStatics + 176);
                                  lVar3 = *(int64 *)(pStatics + 248);
                                  if ((lVar15 == null) ||
                                     (lVar15 = *(int64 *)(lVar15 + 16)) == null)
                                  goto LAB_181591a26;
                                  if (*(uint32 *)(lVar15 + 24) <= uVar16) {
                                    uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar14,0);
                                  }
                                  auVar25 = *(uint8 (*) [16])
                                             (lVar15 + ((int64)(int)uVar16 + 2) * 16);
                                  local_d8 = auVar25;
                                  iVar18 = NGUIMath.ColorToInt(local_d8,0);
                                  uVar14 = NGUIMath.DecimalToHex24(iVar18 >> 8 & 0xffffff,0);
                                  if (lVar3 == null) goto LAB_181591a26;
                                  StringBuilder.Append(lVar3,uVar14);
                                  lVar15 = *(int64 *)(pStatics + 248);
                                  if (lVar15 == null) goto LAB_181591a26;
                                  StringBuilder.Append(lVar15,"]");
                                  uVar16 = uVar16 + 1;
                                }
                              }
                              goto LAB_1815905a3;
                            }
                            break;
                          }
                          if ((useEllipsis != null) && (0 < local_110)) {
                            if (iVar19 < local_100) {
                              lVar15 = *(int64 *)(pStatics + 248);
                              uVar14 = String.Substring(text,iVar19,(iVar12 - iVar19) + 1,0);
                              if (lVar15 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar15,uVar14,0);
                            }
                            if (local_f4 != 0) {
                              lVar15 = *(int64 *)(pStatics + 248);
                              if (lVar15 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar15,"[/sub]",0);
                            }
                            lVar15 = pStatics;
                            goto LAB_181591722;
                          }
                          lVar3 = *(int64 *)(pStatics + 248);
                          uVar13 = Mathf.Max(0,local_110 - iVar19,0);
                          uVar14 = String.Substring(text,iVar19,uVar13,0);
                          if (lVar3 == null) goto LAB_181591a26;
                          StringBuilder.Append(lVar3,uVar14);
                          if ((!bVar21) && (local_e4 = local_e4 & 255, !bVar7)) {
                            local_e4 = 0;
                          }
                          cVar10 = (char)local_ec;
                          if (cVar10) {
                            lVar3 = *(int64 *)(pStatics + 176);
                            if (lVar3 == null) goto LAB_181591a26;
                            if (0 < *(int *)(lVar3 + 24)) {
                              lVar3 = *(int64 *)(pStatics + 248);
                              if (lVar3 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar3,"[-]");
                            }
                          }
                          iVar18 = local_114 + 1;
                          iVar12 = local_104;
                          if (local_114 == local_104) goto LAB_181591515;
                          if (!keepCharCount) {
                            NGUIText.EndLine(pStatics + 248,0);
                          }
                          else {
                            NGUIText.ReplaceSpaceWithNewline
                                      (pStatics + 248,0);
                          }
                          uVar20 = 0;
                          uVar16 = uVar20;
                          if (cVar10) {
                            while( true ) {
                              lVar3 = *(int64 *)(pStatics + 176);
                              if (lVar3 == null) goto LAB_181591a26;
                              if (*(int *)(lVar3 + 24) <= (int)uVar16) break;
                              lVar3 = *(int64 *)(pStatics + 248);
                              if (lVar3 == null) goto LAB_181591a26;
                              iVar19 = FUN_18123bdd0(lVar3,0);
                              StringBuilder.Insert(lVar3,iVar19 + -1);
                              uVar16 = uVar16 + 1;
                            }
                            while( true ) {
                              lVar3 = *(int64 *)(pStatics + 176);
                              if (lVar3 == null) goto LAB_181591a26;
                              if (*(int *)(lVar3 + 24) <= (int)uVar20) break;
                              lVar3 = *(int64 *)(pStatics + 248);
                              if (lVar3 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar3,"[");
                              lVar3 = *(int64 *)(pStatics + 176);
                              lVar4 = *(int64 *)(pStatics + 248);
                              if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 16)) == null)
                              goto LAB_181591a26;
                              if (*(uint32 *)(lVar3 + 24) <= uVar20) {
                                uVar14 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar14,0);
                              }
                              auVar25 = *(uint8 (*) [16])(lVar3 + ((int64)(int)uVar20 + 2) * 16)
                              ;
                              local_d8 = auVar25;
                              iVar19 = NGUIMath.ColorToInt(local_d8,0);
                              uVar14 = NGUIMath.DecimalToHex24(iVar19 >> 8 & 0xffffff,0);
                              if (lVar4 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar4,uVar14);
                              lVar3 = *(int64 *)(pStatics + 248);
                              if (lVar3 == null) goto LAB_181591a26;
                              StringBuilder.Append(lVar3,"]");
                              uVar20 = uVar20 + 1;
                            }
                          }
                          bVar6 = true;
                          local_114 = iVar18;
                          if (bVar21) {
                            iVar19 = local_110 + 1;
                            fVar28 = 0.0;
                            local_100 = local_110;
                            local_f8 = 0;
                          }
                          else {
                            local_100 = local_110;
                            local_f8 = 0;
                            fVar28 = fVar24;
                            iVar19 = local_110;
                          }
                        }
                        bVar23 = bVar6;
                        if (lVar15 != null) {
                          iVar18 = BMSymbol.get_length(lVar15,0);
                          local_110 = local_110 + -1 + iVar18;
                          local_f8 = 0;
                        }
                      }
        LAB_1815905a3:
                      local_110 = local_110 + 1;
                      local_f0 = local_110;
                    } while (local_110 < iVar2);
                    iVar12 = local_104;
                    iVar18 = local_114;
                    if (iVar19 < local_110) {
                      lVar15 = *(int64 *)(pStatics + 248);
                      uVar14 = String.Substring(text,iVar19,local_110 - iVar19,0);
                      if (lVar15 == null) goto LAB_181591a26;
                      StringBuilder.Append(lVar15,uVar14,0);
                    }
                  }
        LAB_181591515:
                  if ((char)local_ec) {
                    lVar15 = *(int64 *)(pStatics + 176);
                    if (lVar15 == null) goto LAB_181591a26;
                    if (0 < *(int *)(lVar15 + 24)) {
                      lVar15 = *(int64 *)(pStatics + 248);
                      if (lVar15 == null) goto LAB_181591a26;
                      StringBuilder.Append(lVar15,"[-]",0);
                    }
                  }
                  plVar5 = *(int64 **)(pStatics + 248);
                  if (plVar5 != (int64 *)0) {
                    uVar14 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
                    *finalText = uVar14;
                    il2cpp_internal(finalText,uVar14);
                    lVar15 = *(int64 *)(pStatics + 176);
                    if (lVar15 != null) {
                      BetterList_1.Clear(lVar15,DAT_181d80e98);
                      if ((char)!local_e4) {
                        return false;
                      }
                      if (local_110 == iVar2) {
                        return true;
                      }
                      if (*(int *)(pStatics + 76) != 0) {
                        return iVar18 == iVar12;
                      }
                      return iVar18 == 0;
                    }
                  }
                }
              }
        LAB_181591a26:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
        *finalText = "";
        il2cpp_internal(finalText,"");
        return false;
    }

    // Token : 0x60003A8
    // RVA   : 0x158C790   Offset: 0x158AF90   Length: 0x22D3
    public static void Print(string text, List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        var plVar11 = *(int64*)(lVar11 + 184);
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        bool cVar5;
        bool cVar6;
        int iVar7;
        uint8 (*pauVar9) [16];
        int64 lVar10;
        int64 lVar11;
        int64 lVar12;
        uint64 uVar13;
        uint16 uVar14;
        float *pfVar15;
        uint32 uVar16;
        uint32 uVar17;
        int iVar18;
        int iVar19;
        uint32 uVar20;
        float fVar21;
        uint32 uVar22;
        uint32 uVar23;
        uint64 extraout_XMM0_Qb;
        uint8 auVar24 [16];
        uint8 auVar25 [16];
        float fVar26;
        float fVar27;
        uint8 auVar28 [4];
        uint8 auVar29 [4];
        float fVar30;
        uint32 uVar31;
        uint32 uVar32;
        uint32 uVar33;
        float fVar34;
        float fVar35;
        float fVar36;
        float fVar37;
        float fVar38;
        float fVar39;
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
        cVar5 = FUN_180d6ca90(text,0);
        if (cVar5) {
          return;
        }
        if (verts != null) {
          iVar19 = *(int *)(verts + 24);
          local_3b8 = iVar19;
          NGUIText.Prepare(text,0);
          lVar11 = *(int64 *)(pStatics + 176);
          puVar8 = (uint64 *)FUN_181098a50(local_3c8,0);
          if (lVar11 != null) {
            local_328 = *puVar8;
            uStack_320 = puVar8[1];
            BetterList_1.Add(lVar11,&local_328,DAT_181d80e18);
            fVar30 = 0.0;
            uVar31 = 0;
            uVar32 = 0;
            uVar33 = 0;
            local_3d4 = 0.0;
            local_3cc = 0.0;
            local_398 = 0;
            *(uint32 *)(pStatics + 184) = 0x3f800000;
            lVar11 = pStatics;
            local_328 = *(uint64 *)(lVar11 + 84);
            uStack_320 = *(uint64 *)(lVar11 + 92);
            iVar7 = *(int *)(lVar11 + 136);
            local_318 = *(uint64 *)(lVar11 + 44);
            uStack_310 = *(uint64 *)(lVar11 + 52);
            puVar8 = (uint64 *)Color.op_Multiply(local_3c8,&local_318,&local_328,0);
            local_328 = *puVar8;
            uStack_320 = puVar8[1];
            lVar11 = pStatics;
            local_318 = *(uint64 *)(lVar11 + 100);
            uStack_310 = *(uint64 *)(lVar11 + 108);
            local_338 = *(uint8 (*) [16])(lVar11 + 44);
            pauVar9 = (uint8 (*) [16])Color.op_Multiply(local_3c8,local_338,&local_318,0);
            local_338 = *pauVar9;
            lVar11 = pStatics;
            pauVar9 = (uint8 (*) [16])(lVar11 + 44);
            auVar28 = *(uint8 (*) [4])*pauVar9;
            auVar29 = *(uint8 (*) [4])(lVar11 + 48);
            local_348 = *(uint64 *)*pauVar9;
            uVar22 = *(uint32 *)(lVar11 + 52);
            uVar23 = *(uint32 *)(lVar11 + 56);
            _local_3a8 = *pauVar9;
            uStack_340 = *(uint64 *)(lVar11 + 52);
            if (text != null) {
              local_380 = *(int *)(text + 16);
              cVar5 = false;
              local_370 = 0;
              uStack_368 = 0;
              plVar1 = pStatics;
              local_394 = 0;
              local_3d8 = false;
              local_3d7 = false;
              local_3d5 = false;
              local_37c = (float)iVar7 * *(float *)(plVar1 + 4);
              local_3d6 = false;
              local_3d0[0] = false;
              local_38c = 0.0;
              fVar37 = (float)*(int *)((int64)plVar1 + 68) + 0.01;
              local_388 = 0.0;
              local_378 = fVar37;
              if (*plVar1 != 0) {
                plVar1 = (int64 *)*pStatics;
                if (plVar1 == (int64 *)0) throw; // [null/range check failed]
                lVar11 = *plVar1;
                uVar14 = 0;
                if (*(uint16 *)(lVar11 + 0x12a) != 0) {
                  do {
                    if (*(int64 *)(*(int64 *)(lVar11 + 176) + (uint64)uVar14 * 16) ==
                        DAT_181d556d0) {
                      puVar8 = (uint64 *)
                               ((int64)
                                *(int *)(*(int64 *)(lVar11 + 176) + 8 + (uint64)uVar14 * 16) *
                                16 + 0x248 + lVar11);
                      goto LAB_18158cafc;
                    }
                    uVar14 = uVar14 + 1;
                  } while (uVar14 < *(uint16 *)(lVar11 + 0x12a));
                }
                puVar8 = (uint64 *)FUN_1800914f0(plVar1,DAT_181d556d0,17);
        LAB_18158cafc:
                puVar8 = (uint64 *)(*(code *)*puVar8)(local_3c8,plVar1,puVar8[1]);
                local_370 = *puVar8;
                uStack_368 = puVar8[1];
                fVar21 = (float)FUN_180d90480(&local_370,0);
                if (*pStatics == 0) throw; // [null/range check failed]
                iVar7 = FUN_180002970(2,DAT_181d556d0);
                local_38c = fVar21 / (float)iVar7;
                fVar21 = (float)FUN_18044e2b0(&local_370,0);
                if (*pStatics == 0) throw; // [null/range check failed]
                iVar7 = FUN_180002970(4,DAT_181d556d0);
                local_388 = fVar21 / (float)iVar7;
              }
              local_390 = 0;
              lVar11 = DAT_181d66a70;
              if (0 < local_380) {
                _local_360 = ZEXT416((uint32)uStack_3a0._4_4_);
                fVar21 = 0.0;
                fVar35 = uStack_3a0._4_4_;
                do {
                  iVar19 = local_390;
                  uVar14 = String.get_Chars(text,local_390,0);
                  uVar17 = (uint32)uVar14;
                  local_384 = fVar30;
                  if (uVar14 == 10) {
                    if (*(int *)(pStatics + 40) != 1) {
                      NGUIText.Align(verts,local_3b8);
                      local_3b8 = *(int *)(verts + 24);
                    }
                    local_3d4 = 0.0;
                    local_3cc = fVar21 + *(float *)(pStatics + 144);
                    lVar11 = DAT_181d66a70;
                    fVar30 = 0.0;
                    uVar31 = 0;
                    uVar32 = 0;
                    uVar33 = 0;
                    fVar36 = local_3cc;
                    uVar16 = 0;
                  }
                  else {
                    lVar11 = DAT_181d66a70;
                    fVar36 = fVar21;
                    uVar16 = (uint32)uVar14;
                    if (31 < uVar14) {
                      if (*(char *)(pStatics + 116) != false) {
                        uVar16 = 0;
                        cVar6 = NGUIText.ParseSymbol
                                          (text,&local_390,
                                           *(uint64 *)(pStatics + 176),
                                           *(uint8 *)(pStatics + 128),
                                           &local_394,&local_3d8,&local_3d7,&local_3d5,&local_3d6,
                                           local_3d0,0);
                        cVar5 = local_3d8;
                        iVar19 = local_390;
                        if (cVar6) {
                          if (local_3d0[0] == false) {
                            lVar11 = *(int64 *)(pStatics + 176);
                            if ((lVar11 == null) || (lVar12 = *(int64 *)(lVar11 + 16)) == null)
                            throw; // [null/range check failed]
                            if (*(uint32 *)(lVar12 + 24) <= *(int *)(lVar11 + 24) - 1U) {
                              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar13,0);
                            }
                            _local_3a8 = *(uint8 (*) [16])
                                          (pStatics + 44);
                            puVar8 = (uint64 *)
                                     (lVar12 + ((int64)*(int *)(lVar11 + 24) + 1) * 16);
                            local_348 = *puVar8;
                            uStack_340 = puVar8[1];
                            pauVar9 = (uint8 (*) [16])Color.op_Multiply(local_158,local_3a8);
                            fVar37 = *(float *)(*pauVar9 + 12);
                            _local_3a8 = SUB1612(*pauVar9,0);
                            fVar35 = fVar37 * *(float *)(pStatics + 184);
                          }
                          else {
                            lVar11 = pStatics;
                            lVar12 = *(int64 *)(lVar11 + 176);
                            if ((lVar12 == null) || (lVar10 = *(int64 *)(lVar12 + 16)) == null)
                            throw; // [null/range check failed]
                            if (*(uint32 *)(lVar10 + 24) <= *(int *)(lVar12 + 24) - 1U) {
                              uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar13,0);
                            }
                            pauVar9 = (uint8 (*) [16])
                                      (lVar10 + ((int64)*(int *)(lVar12 + 24) + 1) * 16);
                            fVar37 = *(float *)(*pauVar9 + 12);
                            _local_3a8 = SUB1612(*pauVar9,0);
                            fVar35 = fVar37 * *(float *)(lVar11 + 184) * *(float *)(lVar11 + 56);
                          }
                          uStack_3a0._4_4_ = fVar35;
                          local_360._4_4_ = fVar37;
                          local_360._0_4_ = fVar35;
                          fStack_358 = fVar37;
                          fStack_354 = fVar37;
                          lVar11 = *(int64 *)(pStatics + 176);
                          if (lVar11 != null) {
                            iVar19 = *(int *)(lVar11 + 24) + -2;
                            lVar11 = DAT_181d66a70;
                            if (0 < iVar19) {
                              do {
                                if (((*(byte *)(lVar11 + 0x133) & 4) != 0) &&
                                   (*(int *)(lVar11 + 224) == 0)) {
                                  il2cpp_runtime_class_init();
                                  lVar11 = DAT_181d66a70;
                                }
                                lVar12 = *(int64 *)(plVar11 + 176);
                                if ((lVar12 == null) || (lVar12 = *(int64 *)(lVar12 + 16)) == null)
                                throw; // [null/range check failed]
                                if (*(uint32 *)(lVar12 + 24) <= uVar16) {
                                  uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar13,0);
                                }
                                lVar10 = (int64)(int)uVar16;
                                uVar16 = uVar16 + 1;
                                fVar35 = fVar35 * *(float *)(lVar12 + 44 + lVar10 * 16);
                                uStack_3a0._4_4_ = fVar35;
                                local_360._0_4_ = fVar35;
                              } while ((int)uVar16 < iVar19);
                            }
                            if (((*(byte *)(lVar11 + 0x133) & 4) != 0) && (*(int *)(lVar11 + 224) == 0))
                            {
                              il2cpp_runtime_class_init();
                              lVar11 = DAT_181d66a70;
                            }
                            auVar24 = _local_3a8;
                            auVar28 = local_3a8;
                            auVar29 = auStack_3a4;
                            uVar22 = (float)uStack_3a0;
                            uVar23 = uStack_3a0._4_4_;
                            local_348 = local_3a8._0_8_;
                            uVar13 = local_348;
                            uStack_340 = local_3a8._8_8_;
                            uVar3 = uStack_340;
                            if (*(char *)(plVar11 + 80) != false) {
                              if (((*(byte *)(lVar11 + 0x133) & 4) != 0) && (*(int *)(lVar11 + 224) == 0)
                                 ) {
                                il2cpp_runtime_class_init();
                                lVar11 = DAT_181d66a70;
                              }
                              local_338 = *(uint8 (*) [16])(plVar11 + 84);
                              local_328 = uVar13;
                              uStack_320 = uVar3;
                              puVar8 = (uint64 *)Color.op_Multiply(local_148,local_338,&local_328);
                              local_338 = auVar24;
                              local_328 = *puVar8;
                              uStack_320 = puVar8[1];
                              _local_3a8 = *(uint8 (*) [16])
                                            (pStatics + 100);
                              pauVar9 = (uint8 (*) [16])Color.op_Multiply(local_138,local_3a8);
                              local_338 = *pauVar9;
                              lVar11 = DAT_181d66a70;
                            }
                            iVar19 = local_390 + -1;
                            cVar5 = local_3d8;
                            uVar16 = local_398;
                            goto LAB_18158e0ea;
                          }
                          throw; // [null/range check failed]
                        }
                      }
                      if (*(char *)(pStatics + 152) == false) {
                        lVar11 = 0;
                      }
                      else {
                        lVar11 = NGUIText.GetSymbol(text,iVar19,local_380,0);
                      }
                      if (local_394 == 0) {
                        fVar34 = *(float *)(pStatics + 28);
                      }
                      else {
                        fVar34 = *(float *)(pStatics + 28) * 0.75;
                      }
                      if (lVar11 == null) {
                        uVar20 = (uint32)uVar14;
                        lVar12 = NGUIText.GetGlyph(uVar14,local_398);
                        lVar11 = DAT_181d66a70;
                        fVar36 = local_3cc;
                        uVar16 = local_398;
                        if (lVar12 != null) {
                          fVar37 = *(float *)(lVar12 + 64);
                          local_398 = uVar20;
                          if (local_394 != 0) {
                            if (local_394 == 1) {
                              fVar35 = (float)*(int *)(pStatics + 24) *
                                       *(float *)(pStatics + 28) * 0.4;
                              *(float *)(lVar12 + 20) = *(float *)(lVar12 + 20) - fVar35;
                              fVar35 = *(float *)(lVar12 + 28) - fVar35;
                            }
                            else {
                              fVar35 = (float)*(int *)(pStatics + 24) *
                                       *(float *)(pStatics + 28) * 0.05;
                              *(float *)(lVar12 + 20) = fVar35 + *(float *)(lVar12 + 20);
                              fVar35 = fVar35 + *(float *)(lVar12 + 28);
                            }
                            *(float *)(lVar12 + 28) = fVar35;
                          }
                          fVar35 = *(float *)(lVar12 + 20) - fVar21;
                          fVar39 = fVar30 + *(float *)(lVar12 + 16);
                          fVar37 = fVar37 + *(float *)(pStatics + 140);
                          fVar38 = fVar30 + *(float *)(lVar12 + 24);
                          fVar36 = *(float *)(lVar12 + 28) - fVar21;
                          if (local_378 < fVar37 + fVar30) {
                            if (fVar30 == 0.0) {
                              return;
                            }
                            if ((*(int *)(pStatics + 40) != 1) &&
                               (local_3b8 < *(int *)(verts + 24))) {
                              auVar24._4_4_ = uVar31;
                              auVar24._0_4_ = fVar30;
                              auVar24._8_4_ = uVar32;
                              auVar24._12_4_ = uVar33;
                              auVar25._4_12_ = auVar24._4_12_;
                              auVar25._0_4_ =
                                   fVar30 - *(float *)(pStatics + 140);
                              NGUIText.Align(verts,local_3b8,auVar25._0_8_,4,0);
                              local_3b8 = *(int *)(verts + 24);
                            }
                            fVar39 = fVar39 - fVar30;
                            fVar38 = fVar38 - fVar30;
                            local_384 = 0.0;
                            fVar30 = *(float *)(pStatics + 144);
                            fVar21 = fVar21 + fVar30;
                            fVar35 = fVar35 - fVar30;
                            fVar36 = fVar36 - fVar30;
                            fVar30 = 0.0;
                            uVar31 = 0;
                            uVar32 = 0;
                            uVar33 = 0;
                            local_3cc = fVar21;
                          }
                          if (((uVar20 == 32) || (uVar14 - 0x200a < 2)) || (uVar20 == 0x2009)) {
                            if (!local_3d5) {
                              if (local_3d6) {
                                uVar17 = 45;
                              }
                            }
                            else {
                              uVar17 = 95;
                            }
                          }
                          fVar30 = fVar30 + fVar37;
                          if (local_394 != 0) {
                            local_3d4 = fVar30;
                            uVar13 = FUN_18000d7c0();
                            fVar30 = (float)uVar13;
                            uVar31 = (uint32)((uint64)uVar13 >> 32);
                            uVar32 = (uint32)extraout_XMM0_Qb;
                            uVar33 = (uint32)((uint64)extraout_XMM0_Qb >> 32);
                          }
                          local_3d4 = fVar30;
                          if (((uVar17 != 32) && (1 < uVar17 - 0x200a)) && (uVar17 != 0x2009)) {
                            if (uvs != null) {
                              if (*pStatics != 0) {
                                fVar37 = (float)FUN_180d904a0(&local_370,0);
                                fVar30 = local_38c;
                                *(float *)(lVar12 + 32) = local_38c * *(float *)(lVar12 + 32) + fVar37
                                ;
                                fVar37 = (float)FUN_180d904a0(&local_370,0);
                                *(float *)(lVar12 + 48) = fVar30 * *(float *)(lVar12 + 48) + fVar37;
                                fVar37 = (float)Rect.get_yMax(&local_370,0);
                                fVar30 = local_388;
                                *(float *)(lVar12 + 36) = fVar37 - local_388 * *(float *)(lVar12 + 36)
                                ;
                                fVar37 = (float)Rect.get_yMax(&local_370,0);
                                fVar37 = fVar37 - fVar30 * *(float *)(lVar12 + 52);
                                *(float *)(lVar12 + 52) = fVar37;
                                *(uint32 *)(lVar12 + 40) = *(uint32 *)(lVar12 + 32);
                                *(float *)(lVar12 + 44) = fVar37;
                                *(uint32 *)(lVar12 + 56) = *(uint32 *)(lVar12 + 48);
                                *(uint32 *)(lVar12 + 60) = *(uint32 *)(lVar12 + 36);
                              }
                              lVar11 = 1;
                              if (cVar5) {
                                lVar11 = 4;
                              }
                              do {
                                FUN_181814e80(uvs,*(uint64 *)(lVar12 + 32),DAT_181d83f78);
                                FUN_181814e80(uvs,*(uint64 *)(lVar12 + 40),DAT_181d83f78);
                                FUN_181814e80(uvs,*(uint64 *)(lVar12 + 48),DAT_181d83f78);
                                FUN_181814e80(uvs,*(uint64 *)(lVar12 + 56),DAT_181d83f78);
                                lVar11 = lVar11 + -1;
                              } while (lVar11 != null);
                            }
                            if (cols != null) {
                              if ((*(int *)(lVar12 + 68) == 0) || (*(int *)(lVar12 + 68) == 15)) {
                                if (*(char *)(pStatics + 80) == false) {
                                  lVar11 = 4;
                                  if (cVar5) {
                                    lVar11 = 16;
                                  }
                                  do {
                                    local_3c8._4_4_ = auVar29;
                                    local_3c8._0_4_ = auVar28;
                                    local_3c8._8_4_ = uVar22;
                                    local_3c8._12_4_ = uVar23;
                                    FUN_1818059b0(cols,local_3c8,DAT_181d5b680);
                                    lVar11 = lVar11 + -1;
                                  } while (lVar11 != null);
                                }
                                else {
                                  fVar30 = *(float *)(lVar12 + 20);
                                  uVar3 = uStack_320;
                                  uVar13 = local_328;
                                  fVar27 = local_37c;
                                  fVar37 = *(float *)(lVar12 + 28);
                                  fVar26 = *(float *)(pStatics + 28);
                                  local_3c8 = local_338;
                                  _local_3a8 = local_328;
                                  uStack_3a0 = uStack_320;
                                  puVar8 = (uint64 *)
                                           Color.Lerp(local_118,local_3a8,local_3c8,
                                                       (fVar30 / *(float *)(*(int64 *)
                                                                             (DAT_181d66a70 + 184) + 28
                                                                           ) + local_37c) / local_37c,0);
                                  uStack_3a0 = uVar3;
                                  _local_3a8 = uVar13;
                                  uVar13 = puVar8[1];
                                  lVar11 = pStatics;
                                  *(uint64 *)(lVar11 + 0x100) = *puVar8;
                                  *(uint64 *)(lVar11 + 0x108) = uVar13;
                                  local_3c8 = local_338;
                                  puVar8 = (uint64 *)
                                           Color.Lerp(local_108,local_3a8,local_3c8,
                                                       (fVar37 / fVar26 + fVar27) / fVar27,0);
                                  uVar13 = puVar8[1];
                                  lVar11 = pStatics;
                                  lVar12 = 1;
                                  if (cVar5) {
                                    lVar12 = 4;
                                  }
                                  *(uint64 *)(lVar11 + 0x110) = *puVar8;
                                  *(uint64 *)(lVar11 + 0x118) = uVar13;
                                  do {
                                    local_3c8._0_8_ =
                                         *(uint64 *)(pStatics + 0x100);
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x108);
                                    FUN_1818059b0(cols,local_3c8,DAT_181d5b680);
                                    local_3c8._0_8_ =
                                         *(uint64 *)(pStatics + 0x110);
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x118);
                                    FUN_1818059b0(cols,local_3c8,DAT_181d5b680);
                                    local_3c8._0_8_ =
                                         *(uint64 *)(pStatics + 0x110);
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x118);
                                    FUN_1818059b0(cols,local_3c8,DAT_181d5b680);
                                    local_3c8 = *(uint8 (*) [16])
                                                 (pStatics + 0x100);
                                    FUN_1818059b0(cols,local_3c8,DAT_181d5b680);
                                    lVar12 = lVar12 + -1;
                                  } while (lVar12 != null);
                                }
                              }
                              else {
                                auStack_3a4 = auVar29;
                                local_3a8 = auVar28;
                                uStack_3a0._0_4_ = (float)uVar22;
                                uStack_3a0._4_4_ = (float)uVar23;
                                pauVar9 = (uint8 (*) [16])FUN_181098d60(local_128,local_3a8);
                                iVar7 = *(int *)(lVar12 + 68);
                                _local_3a8 = *pauVar9;
                                if (iVar7 == 1) {
                                  uStack_3a0._0_4_ = (float)*(uint64 *)(*pauVar9 + 8);
                                  uStack_3a0._0_4_ = (float)uStack_3a0 + 0.51;
                                  _local_3a8 = *(uint64 *)*pauVar9;
                                }
                                else if (iVar7 == 2) {
                                  auStack_3a4 = SUB84((uint64)*(uint64 *)*pauVar9 >> 32,0);
                                  auStack_3a4 = (uint8  [4])((float)auStack_3a4 + 0.51);
                                  uStack_3a0 = *(uint64 *)(*pauVar9 + 8);
                                }
                                else if (iVar7 != 3) {
                                  if (iVar7 == 4) {
                                    local_3a8 = (uint8  [4])((float)local_3a8 + 0.51);
                                  }
                                  else if (iVar7 == 8) {
                                    uStack_3a0._4_4_ = uStack_3a0._4_4_ + 0.51;
                                  }
                                }
                                lVar11 = 4;
                                if (cVar5) {
                                  lVar11 = 16;
                                }
                                do {
                                  local_3c8 = _local_3a8;
                                  FUN_1818059b0(cols,local_3c8,DAT_181d5b680);
                                  lVar11 = lVar11 + -1;
                                } while (lVar11 != null);
                              }
                            }
                            uVar17 = 0;
                            if (!cVar5) {
                              if (!local_3d7) {
                                local_160 = 0;
                                local_168 = fVar39;
                                local_164 = fVar35;
                                FUN_181805a40(verts,&local_168,DAT_181d84278);
                                local_2d0 = 0;
                                local_2d8 = fVar39;
                                local_2d4 = fVar36;
                                FUN_181805a40(verts,&local_2d8,DAT_181d84278);
                                local_2c0 = 0;
                                local_2c8 = fVar38;
                                local_2c4 = fVar36;
                                FUN_181805a40(verts,&local_2c8,DAT_181d84278);
                                pfVar15 = &local_2b8;
                                local_2b0 = 0;
                                local_2b8 = fVar38;
                                local_2b4 = fVar35;
                              }
                              else {
                                local_1a0 = 0;
                                fVar30 = (float)*(int *)(pStatics + 24);
                                fVar30 = ((fVar36 - fVar35) / fVar30) * fVar30 * 0.1;
                                local_1a8 = fVar39 - fVar30;
                                local_1a4 = fVar35;
                                FUN_181805a40(verts,&local_1a8,DAT_181d84278);
                                local_198 = fVar30 + fVar39;
                                local_190 = 0;
                                local_194 = fVar36;
                                FUN_181805a40(verts,&local_198,DAT_181d84278);
                                local_188 = fVar30 + fVar38;
                                local_180 = 0;
                                local_184 = fVar36;
                                FUN_181805a40(verts,&local_188,DAT_181d84278);
                                local_178 = fVar38 - fVar30;
                                local_170 = 0;
                                pfVar15 = &local_178;
                                local_174 = fVar35;
                              }
                              FUN_181805a40(verts,pfVar15);
                            }
                            else {
                              do {
                                lVar11 = *(int64 *)(pStatics + 0x120);
                                if (lVar11 == null) throw; // [null/range check failed]
                                if (*(uint32 *)(lVar11 + 24) <= uVar17) {
                                  uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar13,0);
                                }
                                fVar30 = lVar11[uVar17];
                                lVar12 = (int64)(int)uVar17 + 1;
                                if (*(uint32 *)(lVar11 + 24) <= (uint32)lVar12) {
                                  uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar13,0);
                                }
                                fVar37 = *(float *)(lVar11 + 32 + lVar12 * 4);
                                if (!local_3d7) {
                                  fVar21 = 0.0;
                                }
                                else {
                                  fVar21 = (float)*(int *)(pStatics + 24);
                                  fVar21 = ((fVar36 - fVar35) / fVar21) * fVar21 * 0.1;
                                }
                                local_1e0 = 0;
                                fVar26 = fVar30 + fVar39;
                                fVar27 = fVar37 + fVar35;
                                local_1e8 = fVar26 - fVar21;
                                local_1e4 = fVar27;
                                FUN_181805a40(verts,&local_1e8,DAT_181d84278);
                                fVar37 = fVar37 + fVar36;
                                local_1d8 = fVar26 + fVar21;
                                local_1d0 = 0;
                                local_1d4 = fVar37;
                                FUN_181805a40(verts,&local_1d8,DAT_181d84278);
                                fVar30 = fVar30 + fVar38;
                                local_1c0 = 0;
                                local_1c8 = fVar30 + fVar21;
                                local_1c4 = fVar37;
                                FUN_181805a40(verts,&local_1c8,DAT_181d84278);
                                local_1b8 = fVar30 - fVar21;
                                local_1b0 = 0;
                                local_1b4 = fVar27;
                                FUN_181805a40(verts,&local_1b8);
                                uVar17 = uVar17 + 2;
                                fVar21 = local_3cc;
                              } while ((int)uVar17 < 8);
                            }
                            if (local_3d6 || local_3d5) {
                              uVar22 = 95;
                              if (local_3d6) {
                                uVar22 = 45;
                              }
                              lVar11 = NGUIText.GetGlyph(uVar22,local_398);
                              if (lVar11 != null) {
                                if (uvs != null) {
                                  if (*pStatics != 0) {
                                    fVar37 = (float)FUN_180d904a0(&local_370,0);
                                    fVar30 = local_38c;
                                    *(float *)(lVar11 + 32) =
                                         local_38c * *(float *)(lVar11 + 32) + fVar37;
                                    fVar37 = (float)FUN_180d904a0(&local_370,0);
                                    *(float *)(lVar11 + 48) =
                                         fVar30 * *(float *)(lVar11 + 48) + fVar37;
                                    fVar37 = (float)Rect.get_yMax(&local_370,0);
                                    fVar30 = local_388;
                                    *(float *)(lVar11 + 36) =
                                         fVar37 - local_388 * *(float *)(lVar11 + 36);
                                    fVar37 = (float)Rect.get_yMax(&local_370,0);
                                    *(float *)(lVar11 + 52) =
                                         fVar37 - fVar30 * *(float *)(lVar11 + 52);
                                  }
                                  lVar12 = 1;
                                  if (cVar5) {
                                    lVar12 = 4;
                                  }
                                  local_308 = (*(float *)(lVar11 + 48) + *(float *)(lVar11 + 32)) *
                                              0.5;
                                  local_300 = local_308;
                                  local_2f8 = local_308;
                                  local_2f0 = local_308;
                                  do {
                                    uStack_304 = *(uint32 *)(lVar11 + 36);
                                    FUN_181814e80(uvs,CONCAT44(uStack_304,local_308),DAT_181d83f78);
                                    uStack_2fc = *(uint32 *)(lVar11 + 52);
                                    FUN_181814e80(uvs,CONCAT44(uStack_2fc,local_300),DAT_181d83f78);
                                    uStack_2f4 = *(uint32 *)(lVar11 + 52);
                                    FUN_181814e80(uvs,CONCAT44(uStack_2f4,local_2f8),DAT_181d83f78);
                                    uStack_2ec = *(uint32 *)(lVar11 + 36);
                                    FUN_181814e80(uvs,CONCAT44(uStack_2ec,local_2f0),DAT_181d83f78);
                                    lVar12 = lVar12 + -1;
                                  } while (lVar12 != null);
                                }
                                fVar35 = local_384;
                                fVar37 = local_3d4;
                                fVar36 = -fVar21 + *(float *)(lVar11 + 20);
                                fVar21 = -fVar21 + *(float *)(lVar11 + 28);
                                if (!cVar5) {
                                  local_2a8 = local_384;
                                  local_2a0 = 0;
                                  local_2a4 = fVar36;
                                  FUN_181805a40(verts,&local_2a8,DAT_181d84278);
                                  local_298 = fVar35;
                                  local_290 = 0;
                                  local_294 = fVar21;
                                  FUN_181805a40(verts,&local_298,DAT_181d84278);
                                  fVar30 = local_3d4;
                                  local_288 = local_3d4;
                                  local_280 = 0;
                                  local_284 = fVar21;
                                  FUN_181805a40(verts,&local_288,DAT_181d84278);
                                  local_278 = fVar30;
                                  local_270 = 0;
                                  local_274 = fVar36;
                                  FUN_181805a40(verts,&local_278,DAT_181d84278);
                                }
                                else {
                                  uVar17 = 0;
                                  do {
                                    lVar12 = *(int64 *)(pStatics + 0x120);
                                    if (lVar12 == null) throw; // [null/range check failed]
                                    if (*(uint32 *)(lVar12 + 24) <= uVar17) {
                                      uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar13,0);
                                    }
                                    fVar30 = lVar12[uVar17];
                                    lVar10 = (int64)(int)uVar17 + 1;
                                    if (*(uint32 *)(lVar12 + 24) <= (uint32)lVar10) {
                                      uVar13 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar13,0);
                                    }
                                    fVar38 = *(float *)(lVar12 + 32 + lVar10 * 4);
                                    local_260 = 0;
                                    fVar26 = fVar38 + fVar36;
                                    fVar39 = fVar30 + fVar35;
                                    local_268 = fVar39;
                                    local_264 = fVar26;
                                    FUN_181805a40(verts,&local_268,DAT_181d84278);
                                    fVar38 = fVar38 + fVar21;
                                    local_250 = 0;
                                    local_258 = fVar39;
                                    local_254 = fVar38;
                                    FUN_181805a40(verts,&local_258,DAT_181d84278);
                                    fVar30 = fVar30 + fVar37;
                                    local_240 = 0;
                                    local_248 = fVar30;
                                    local_244 = fVar38;
                                    FUN_181805a40(verts,&local_248,DAT_181d84278);
                                    local_230 = 0;
                                    local_238 = fVar30;
                                    local_234 = fVar26;
                                    FUN_181805a40(verts,&local_238,DAT_181d84278);
                                    uVar17 = uVar17 + 2;
                                    fVar30 = local_3d4;
                                  } while ((int)uVar17 < 8);
                                }
                                uVar33 = 0;
                                uVar32 = 0;
                                uVar31 = 0;
                                uVar4 = uStack_320;
                                uVar3 = local_328;
                                auVar24 = local_338;
                                uVar13 = local_348;
                                if (*(char *)(pStatics + 80) == false) {
                                  auVar28 = (uint8  [4])(uint32)local_348;
                                  auVar29 = (uint8  [4])local_348._4_4_;
                                  uVar22 = (uint32)uStack_340;
                                  uVar23 = uStack_340._4_4_;
                                  iVar7 = 4;
                                  iVar18 = 0;
                                  if (cVar5) {
                                    iVar7 = 16;
                                    iVar18 = 0;
                                  }
                                  do {
                                    if (cols == null) throw; // [null/range check failed]
                                    local_3c8._8_4_ = uVar22;
                                    local_3c8._0_8_ = uVar13;
                                    local_3c8._12_4_ = uVar23;
                                    FUN_1818059b0(cols,local_3c8);
                                    iVar18 = iVar18 + 1;
                                    fVar21 = local_3cc;
                                  } while (iVar18 < iVar7);
                                }
                                else {
                                  iVar7 = 0;
                                  local_3c8 = local_338;
                                  uStack_3a0 = uStack_320;
                                  _local_3a8 = local_328;
                                  fVar37 = (*(float *)(lVar11 + 28) / fVar34 + local_37c) / local_37c;
                                  puVar8 = (uint64 *)
                                           Color.Lerp(local_f8,local_3a8,local_3c8,
                                                       (*(float *)(lVar11 + 20) / fVar34 + local_37c) /
                                                       local_37c,0);
                                  uVar13 = *puVar8;
                                  uVar2 = puVar8[1];
                                  lVar11 = pStatics;
                                  local_3c8 = auVar24;
                                  uStack_3a0 = uVar4;
                                  _local_3a8 = uVar3;
                                  *(uint64 *)(lVar11 + 0x100) = uVar13;
                                  *(uint64 *)(lVar11 + 0x108) = uVar2;
                                  puVar8 = (uint64 *)
                                           Color.Lerp(local_e8,local_3a8,local_3c8,fVar37,0);
                                  uVar13 = puVar8[1];
                                  lVar11 = pStatics;
                                  iVar18 = 1;
                                  if (cVar5) {
                                    iVar18 = 4;
                                  }
                                  *(uint64 *)(lVar11 + 0x110) = *puVar8;
                                  *(uint64 *)(lVar11 + 0x118) = uVar13;
                                  do {
                                    if (cols == null) throw; // [null/range check failed]
                                    local_3c8._0_8_ =
                                         *(uint64 *)(pStatics + 0x100);
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x108);
                                    FUN_1818059b0(cols,local_3c8,DAT_181d5b680);
                                    local_3c8._0_8_ =
                                         *(uint64 *)(pStatics + 0x110);
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x118);
                                    FUN_1818059b0(cols,local_3c8,DAT_181d5b680);
                                    local_3c8._0_8_ =
                                         *(uint64 *)(pStatics + 0x110);
                                    local_3c8._8_8_ =
                                         *(uint64 *)(pStatics + 0x118);
                                    FUN_1818059b0(cols,local_3c8,DAT_181d5b680);
                                    local_3c8 = *(uint8 (*) [16])
                                                 (pStatics + 0x100);
                                    FUN_1818059b0(cols,local_3c8);
                                    iVar7 = iVar7 + 1;
                                  } while (iVar7 < iVar18);
                                  auVar28 = (uint8  [4])(uint32)local_348;
                                  auVar29 = (uint8  [4])local_348._4_4_;
                                  uVar22 = (uint32)uStack_340;
                                  uVar23 = uStack_340._4_4_;
                                  fVar21 = local_3cc;
                                }
                                goto LAB_18158e0de;
                              }
                            }
                            fVar30 = local_3d4;
                            fVar35 = (float)local_360._0_4_;
                            goto LAB_18158e7d4;
                          }
        LAB_18158e0de:
                          lVar11 = DAT_181d66a70;
                          fVar36 = fVar21;
                          fVar35 = (float)local_360._0_4_;
                          uVar16 = local_398;
                        }
                      }
                      else {
                        iVar7 = *(int *)(lVar11 + 48);
                        fVar38 = local_3d4;
                        fVar36 = *(float *)(pStatics + 28);
                        fVar21 = -((float)*(int *)(lVar11 + 52) * fVar36 + fVar21);
                        fVar34 = (float)*(int *)(lVar11 + 64) * fVar34;
                        fVar39 = fVar21 - (float)*(int *)(lVar11 + 60) * fVar36;
                        fVar30 = (float)iVar7 * fVar36 + fVar30;
                        fVar36 = (float)*(int *)(lVar11 + 56) * fVar36 + fVar30;
                        if (fVar37 < fVar34 + local_3d4) {
                          if (local_3d4 == 0.0) {
                            return;
                          }
                          iVar7 = local_3b8;
                          if ((*(int *)(pStatics + 40) != 1) &&
                             (local_3b8 < *(int *)(verts + 24))) {
                            NGUIText.Align(verts,iVar7,
                                            fVar38 - *(float *)(pStatics + 140
                                                               ),4,0);
                            local_3b8 = *(int *)(verts + 24);
                          }
                          fVar30 = fVar30 - fVar38;
                          fVar36 = fVar36 - fVar38;
                          local_3d4 = 0.0;
                          fVar37 = *(float *)(pStatics + 144);
                          local_3cc = local_3cc + fVar37;
                          fVar39 = fVar39 - fVar37;
                          fVar21 = fVar21 - fVar37;
                        }
                        local_220 = 0;
                        local_228 = fVar30;
                        local_224 = fVar39;
                        FUN_181805a40(verts,&local_228,DAT_181d84278);
                        local_210 = 0;
                        local_218 = fVar30;
                        local_214 = fVar21;
                        FUN_181805a40(verts,&local_218,DAT_181d84278);
                        local_200 = 0;
                        local_208 = fVar36;
                        local_204 = fVar21;
                        FUN_181805a40(verts,&local_208,DAT_181d84278);
                        local_1f0 = 0;
                        local_1f8 = fVar36;
                        local_1f4 = fVar39;
                        FUN_181805a40(verts,&local_1f8);
                        fVar30 = local_3d4 +
                                 fVar34 + *(float *)(pStatics + 140);
                        local_3d4 = fVar30;
                        iVar7 = BMSymbol.get_length(lVar11,0);
                        local_398 = 0;
                        iVar19 = iVar19 + -1 + iVar7;
                        if (uvs != null) {
                          local_2e8 = *(uint64 *)(lVar11 + 68);
                          uStack_2e0 = *(uint64 *)(lVar11 + 76);
                          uVar22 = FUN_180d904a0(&local_2e8,0);
                          uVar23 = FUN_18044df60(&local_2e8,0);
                          uVar31 = Rect.get_xMax(&local_2e8,0);
                          uVar32 = Rect.get_yMax(&local_2e8,0);
                          FUN_181814e80(uvs,CONCAT44(uVar23,uVar22),DAT_181d83f78);
                          FUN_181814e80(uvs,CONCAT44(uVar32,uVar22),DAT_181d83f78);
                          FUN_181814e80(uvs,CONCAT44(uVar32,uVar31),DAT_181d83f78);
                          FUN_181814e80(uvs,CONCAT44(uVar23,uVar31));
                          fVar30 = local_3d4;
                        }
                        uVar33 = 0;
                        uVar32 = 0;
                        uVar31 = 0;
                        if (cols == null) {
        LAB_18158e7d4:
                          uVar33 = 0;
                          uVar32 = 0;
                          uVar31 = 0;
                          lVar11 = DAT_181d66a70;
                          auVar28 = (uint8  [4])(uint32)local_348;
                          auVar29 = (uint8  [4])local_348._4_4_;
                          uVar22 = (uint32)uStack_340;
                          uVar23 = uStack_340._4_4_;
                          fVar36 = local_3cc;
                          uVar16 = local_398;
                        }
                        else {
                          uVar13 = local_348;
                          if (*(int *)(pStatics + 132) == 2) {
                            auVar28 = (uint8  [4])(uint32)local_348;
                            auVar29 = (uint8  [4])local_348._4_4_;
                            uVar22 = (uint32)uStack_340;
                            uVar23 = uStack_340._4_4_;
                            lVar12 = 4;
                            do {
                              local_3c8._8_4_ = uVar22;
                              local_3c8._0_8_ = uVar13;
                              local_3c8._12_4_ = uVar23;
                              FUN_1818059b0(cols,local_3c8);
                              lVar12 = lVar12 + -1;
                              lVar11 = DAT_181d66a70;
                              fVar36 = local_3cc;
                              uVar16 = local_398;
                            } while (lVar12 != null);
                          }
                          else {
                            pauVar9 = (uint8 (*) [16])FUN_181098a50(local_d8,0);
                            _local_3a8 = *pauVar9;
                            if (*(int *)(pStatics + 132) == 3) {
                              auVar28 = (uint8  [4])0xbf800000;
                              fVar37 = 0.0;
                            }
                            else {
                              auVar28 = local_3a8;
                              fVar37 = fVar35;
                            }
                            uVar22 = (float)uStack_3a0;
                            lVar11 = 4;
                            auVar29 = auStack_3a4;
                            local_318 = CONCAT44(auStack_3a4,auVar28);
                            uStack_310 = CONCAT44(fVar37,(float)uStack_3a0);
                            do {
                              local_3c8._4_4_ = auVar29;
                              local_3c8._0_4_ = auVar28;
                              local_3c8._8_4_ = uVar22;
                              local_3c8._12_4_ = fVar37;
                              FUN_1818059b0(cols,local_3c8);
                              lVar11 = lVar11 + -1;
                            } while (lVar11 != null);
                            lVar11 = DAT_181d66a70;
                            auVar28 = (uint8  [4])(uint32)local_348;
                            auVar29 = (uint8  [4])local_348._4_4_;
                            uVar22 = (uint32)uStack_340;
                            uVar23 = uStack_340._4_4_;
                            fVar36 = local_3cc;
                            uVar16 = local_398;
                          }
                        }
                      }
                    }
                  }
        LAB_18158e0ea:
                  local_398 = uVar16;
                  local_390 = iVar19 + 1;
                  fVar21 = fVar36;
                  iVar19 = local_3b8;
                  fVar37 = local_378;
                } while (local_390 < local_380);
              }
              if (((*(byte *)(lVar11 + 0x133) & 4) != 0) && (*(int *)(lVar11 + 224) == 0)) {
                il2cpp_runtime_class_init();
                lVar11 = DAT_181d66a70;
              }
              if ((*(int *)(plVar11 + 40) != 1) &&
                 (iVar19 < *(int *)(verts + 24))) {
                if (((*(byte *)(lVar11 + 0x133) & 4) != 0) && (*(int *)(lVar11 + 224) == 0)) {
                  il2cpp_runtime_class_init();
                }
                NGUIText.Align(verts,iVar19);
                lVar11 = DAT_181d66a70;
              }
              if (((*(byte *)(lVar11 + 0x133) & 4) != 0) && (*(int *)(lVar11 + 224) == 0)) {
                il2cpp_runtime_class_init();
                lVar11 = DAT_181d66a70;
              }
              lVar11 = *(int64 *)(plVar11 + 176);
              if (lVar11 != null) {
                BetterList_1.Clear(lVar11,DAT_181d80e98);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60003A9
    // RVA   : 0x158A620   Offset: 0x1588E20   Length: 0x8C8
    public static void PrintApproximateCharacterPositions(string text, List<Vector3> verts, List<int> indices)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
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
        cVar2 = FUN_180d6ca90(text,0);
        if (cVar2) {
          text = " ";
        }
        NGUIText.Prepare(text,0);
        fVar9 = 0.0;
        fVar11 = 0.0;
        fVar13 = (float)*(int *)(pStatics + 68) + 0.01;
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
                fVar10 = *(float *)(pStatics + 28);
              }
              else {
                fVar10 = *(float *)(pStatics + 28) * 0.75;
              }
              local_100 = 0;
              fVar12 = fVar10 * 0.5;
              local_104 = -fVar11 - fVar12;
              local_108 = fVar9;
              FUN_181805a40(verts,&local_108,DAT_181d84278);
              if (indices == null) throw; // [null/range check failed]
              FUN_181814fa0(indices,iVar5);
              if (uVar3 == 10) {
                if (*(int *)(pStatics + 40) != 1) {
                  NGUIText.Align(verts,iVar7,
                                  fVar9 - *(float *)(pStatics + 140),1,0);
                  iVar7 = *(int *)(verts + 24);
                }
                fVar8 = 0.0;
                fVar11 = fVar11 + *(float *)(pStatics + 144);
        LAB_18158add1:
                fVar9 = fVar8;
                uVar6 = 0;
              }
              else {
                fVar8 = fVar9;
                if (uVar3 < 32) goto LAB_18158add1;
                if (*(char *)(pStatics + 116) == false) {
        LAB_18158a992:
                  if (*(char *)(pStatics + 152) != false) {
                    lVar4 = NGUIText.GetSymbol(text,iVar5,local_10c,0);
                    if (lVar4 != null) {
                      iVar1 = *(int *)(lVar4 + 64);
                      fVar10 = (float)iVar1 * fVar10 +
                               *(float *)(pStatics + 140);
                      fVar8 = fVar10 + fVar9;
                      if (fVar13 < fVar8) {
                        if (fVar9 == 0.0) {
                          return;
                        }
                        if ((*(int *)(pStatics + 40) != 1) &&
                           (iVar7 < *(int *)(verts + 24))) {
                          NGUIText.Align(verts,iVar7,
                                          fVar9 - *(float *)(pStatics + 140),1
                                          ,0);
                          iVar7 = *(int *)(verts + 24);
                        }
                        fVar11 = fVar11 + *(float *)(pStatics + 144);
                        fVar8 = fVar10;
                      }
                      local_f0 = 0;
                      local_f4 = -fVar11 - fVar12;
                      local_f8 = fVar8;
                      FUN_181805a40(verts,&local_f8,DAT_181d84278);
                      FUN_181814fa0(indices,iVar5 + 1);
                      if (*(int64 *)(lVar4 + 16) != 0) {
                        iVar5 = iVar5 + *(int *)(*(int64 *)(lVar4 + 16) + 16) + -1;
                        goto LAB_18158add1;
                      }
                      throw; // [null/range check failed]
                    }
                  }
                  fVar10 = (float)NGUIText.GetGlyphWidth(uVar3,uVar6,fVar10);
                  if (fVar10 != 0.0) {
                    fVar10 = fVar10 + *(float *)(pStatics + 140);
                    fVar8 = fVar10 + fVar9;
                    if (fVar13 < fVar8) {
                      if (fVar9 == 0.0) {
                        return;
                      }
                      if ((*(int *)(pStatics + 40) != 1) &&
                         (iVar7 < *(int *)(verts + 24))) {
                        NGUIText.Align(verts,iVar7,
                                        fVar9 - *(float *)(pStatics + 140),1,0
                                       );
                        iVar7 = *(int *)(verts + 24);
                      }
                      fVar11 = fVar11 + *(float *)(pStatics + 144);
                      fVar8 = fVar10;
                    }
                    local_e0 = 0;
                    local_e4 = -fVar11 - fVar12;
                    local_e8 = fVar8;
                    FUN_181805a40(verts,&local_e8,DAT_181d84278);
                    FUN_181814fa0(indices,iVar5 + 1);
                    fVar9 = fVar8;
                    uVar6 = uVar3;
                  }
                }
                else {
                  cVar2 = NGUIText.ParseSymbol
                                    (text,&local_114,
                                     *(uint64 *)(pStatics + 176),
                                     *(uint8 *)(pStatics + 128),
                                     &local_110,&local_115,&local_116,&local_117,&local_118,local_res8,0);
                  iVar5 = local_114;
                  if (!cVar2) goto LAB_18158a992;
                  iVar5 = local_114 + -1;
                }
              }
              local_114 = iVar5 + 1;
            } while (local_114 < local_10c);
          }
          if ((*(int *)(pStatics + 40) != 1) &&
             (iVar7 < *(int *)(verts + 24))) {
            NGUIText.Align(verts,iVar7,fVar9 - *(float *)(pStatics + 140),1
                            ,0);
          }
          return;
        }
    }

    // Token : 0x60003AA
    // RVA   : 0x158BF90   Offset: 0x158A790   Length: 0x7FE
    public static void PrintExactCharacterPositions(string text, List<Vector3> verts, List<int> indices)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
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
        cVar2 = FUN_180d6ca90(text,0);
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
        LAB_18158c789:
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
              fVar8 = *(float *)(pStatics + 28);
            }
            else {
              fVar8 = *(float *)(pStatics + 28) * 0.75;
            }
            if (uVar3 == 10) {
              if (*(int *)(pStatics + 40) != 1) {
                NGUIText.Align(verts,iVar7,
                                fVar10 - *(float *)(pStatics + 140),2,0);
                iVar7 = *(int *)(verts + 24);
              }
              fVar9 = 0.0;
              fVar11 = fVar11 + *(float *)(pStatics + 144);
        LAB_18158c683:
              fVar10 = fVar9;
              uVar6 = 0;
            }
            else {
              fVar9 = fVar10;
              if (uVar3 < 32) goto LAB_18158c683;
              if (*(char *)(pStatics + 116) == false) {
        LAB_18158c29b:
                if (*(char *)(pStatics + 152) == false) {
        LAB_18158c3f9:
                  fVar8 = (float)NGUIText.GetGlyphWidth(uVar3,uVar6,fVar8);
                  if (fVar8 != 0.0) {
                    fVar8 = fVar8 + *(float *)(pStatics + 140) + fVar10;
                    if (fVar12 < fVar8) goto LAB_18158c500;
                    if (indices == null) goto LAB_18158c789;
                    FUN_181814fa0(indices,iVar5,DAT_181d67a78);
                    local_e0 = 0;
                    local_e4 = -fVar11 - fVar13;
                    local_e8 = fVar10;
                    FUN_181805a40(verts,&local_e8,DAT_181d84278);
                    local_d0 = 0;
                    local_d8 = fVar8;
                    local_d4 = -fVar11;
                    FUN_181805a40(verts,&local_d8);
                    fVar10 = fVar8;
                    uVar6 = uVar3;
                  }
                }
                else {
                  lVar4 = NGUIText.GetSymbol(text,iVar5,local_10c,0);
                  if (lVar4 == null) goto LAB_18158c3f9;
                  iVar1 = *(int *)(lVar4 + 64);
                  fVar9 = (float)iVar1 * fVar8 + *(float *)(pStatics + 140) +
                          fVar10;
                  if (fVar9 <= fVar12) {
                    if (indices != null) {
                      FUN_181814fa0(indices,iVar5,DAT_181d67a78);
                      local_100 = 0;
                      local_104 = -fVar11 - fVar13;
                      local_108 = fVar10;
                      FUN_181805a40(verts,&local_108,DAT_181d84278);
                      local_f0 = 0;
                      local_f8 = fVar9;
                      local_f4 = -fVar11;
                      FUN_181805a40(verts,&local_f8);
                      if (*(int64 *)(lVar4 + 16) != 0) {
                        iVar5 = iVar5 + *(int *)(*(int64 *)(lVar4 + 16) + 16) + -1;
                        goto LAB_18158c683;
                      }
                    }
                    goto LAB_18158c789;
                  }
        LAB_18158c500:
                  if (fVar10 == 0.0) {
                    return;
                  }
                  if ((*(int *)(pStatics + 40) != 1) &&
                     (iVar7 < *(int *)(verts + 24))) {
                    NGUIText.Align(verts,iVar7,
                                    fVar10 - *(float *)(pStatics + 140),2,0);
                    iVar7 = *(int *)(verts + 24);
                  }
                  iVar5 = iVar5 + -1;
                  fVar11 = fVar11 + *(float *)(pStatics + 144);
                  fVar10 = 0.0;
                  uVar6 = 0;
                }
              }
              else {
                cVar2 = NGUIText.ParseSymbol
                                  (text,&local_114,
                                   *(uint64 *)(pStatics + 176),
                                   *(uint8 *)(pStatics + 128),&local_110,
                                   &local_115,&local_116,&local_117,&local_118,local_res8,0);
                iVar5 = local_114;
                if (!cVar2) goto LAB_18158c29b;
                iVar5 = local_114 + -1;
              }
            }
            local_114 = iVar5 + 1;
          } while (local_114 < local_10c);
        }
        if ((*(int *)(pStatics + 40) != 1) &&
           (iVar7 < *(int *)(verts + 24))) {
          NGUIText.Align(verts,iVar7,fVar10 - *(float *)(pStatics + 140),2,
                          0);
        }
    }

    // Token : 0x60003AB
    // RVA   : 0x158AEF0   Offset: 0x15896F0   Length: 0x1090
    public static void PrintCaretAndSelection(string text, int start, int end, List<Vector3> caret, List<Vector3> highlight)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
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
        cVar4 = FUN_180d6ca90(text,0);
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
        fVar21 = (float)*(int *)(pStatics + 24) *
                 *(float *)(pStatics + 28);
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
              fVar14 = *(float *)(pStatics + 28);
            }
            else {
              fVar14 = *(float *)(pStatics + 28) * 0.75;
            }
            if (((caret != null) && (!bVar3)) && ((int)end <= iVar10)) {
              bVar3 = true;
              fVar16 = -fVar20;
              local_250 = 0;
              local_258 = fVar17 - 1.0;
              local_254 = fVar16 - fVar21;
              FUN_181805a40(caret,&local_258,DAT_181d84278);
              local_240 = 0;
              local_248 = fVar17 - 1.0;
              local_244 = fVar16;
              FUN_181805a40(caret,&local_248,DAT_181d84278);
              local_230 = 0;
              local_238 = fVar17 + 1.0;
              local_234 = fVar16;
              FUN_181805a40(caret,&local_238,DAT_181d84278);
              local_220 = 0;
              local_228 = fVar17 + 1.0;
              local_224 = fVar16 - fVar21;
              FUN_181805a40(caret,&local_228,DAT_181d84278);
              fVar16 = local_29c;
              fVar19 = local_2a0;
            }
            uVar5 = String.get_Chars(text,uVar8,0);
            if (uVar5 == 10) {
              uVar12 = 0;
              uVar8 = caret;
              if ((bool)(bVar3 & caret != null)) {
                uVar8 = uVar12;
                if (*(int *)(pStatics + 40) != 1) {
                  NGUIText.Align(caret,local_294,
                                  fVar17 - *(float *)(pStatics + 140),4,0);
                }
              }
              caret = uVar8;
              if (highlight != null) {
                if (bVar2) {
                  bVar2 = false;
                  local_f0 = 0;
                  local_148 = CONCAT44(fVar15,fVar22);
                  local_140 = 0;
                  FUN_181805a40(highlight,&local_148,DAT_181d84278);
                  local_260 = 0;
                  pfVar9 = (float *)&local_278;
                  local_278 = CONCAT44(fVar19,fVar16);
                  local_270 = 0;
        LAB_18158ba83:
                  FUN_181805a40(highlight,pfVar9);
                }
                else if (((int)local_290 <= iVar10) && (iVar10 < (int)start)) {
                  fVar16 = -fVar20;
                  local_1e0 = 0;
                  local_1e8 = fVar17;
                  local_1e4 = fVar16 - fVar21;
                  FUN_181805a40(highlight,&local_1e8,DAT_181d84278);
                  local_1d0 = 0;
                  local_1d8 = fVar17;
                  local_1d4 = fVar16;
                  FUN_181805a40(highlight,&local_1d8,DAT_181d84278);
                  local_1c0 = 0;
                  local_1c8 = fVar17 + 2.0;
                  local_1c4 = fVar16;
                  FUN_181805a40(highlight,&local_1c8,DAT_181d84278);
                  pfVar9 = &local_2b8;
                  local_2b0 = 0;
                  local_2b8 = fVar17 + 2.0;
                  local_2b4 = fVar16 - fVar21;
                  goto LAB_18158ba83;
                }
                if ((*(int *)(pStatics + 40) != 1) &&
                   ((int)uVar13 < *(int *)(highlight + 24))) {
                  NGUIText.Align(highlight,uVar13,
                                  fVar17 - *(float *)(pStatics + 140),4,0);
                  uVar13 = *(uint32 *)(highlight + 24);
                }
              }
              fVar17 = 0.0;
              fVar20 = fVar20 + *(float *)(pStatics + 144);
              fVar16 = local_29c;
              fVar19 = local_2a0;
            }
            else if (uVar5 < 32) {
              uVar12 = 0;
            }
            else {
              if (*(char *)(pStatics + 116) != false) {
                cVar4 = NGUIText.ParseSymbol
                                  (text,&local_298,
                                   *(uint64 *)(pStatics + 176),
                                   *(uint8 *)(pStatics + 128),local_280,
                                   local_2a4,&local_2a5,&local_2a6,&local_2a7,&local_2a8,0);
                uVar8 = (uint64)local_298;
                if (cVar4) {
                  iVar10 = local_298 - 1;
                  goto LAB_18158bb61;
                }
              }
              iVar10 = (int)uVar8;
              if (*(char *)(pStatics + 152) == false) {
        LAB_18158b41d:
                fVar14 = (float)NGUIText.GetGlyphWidth((uint32)uVar5,uVar12,fVar14);
              }
              else {
                lVar7 = NGUIText.GetSymbol(text,uVar8,local_284,0);
                if (lVar7 == null) goto LAB_18158b41d;
                fVar14 = (float)*(int *)(lVar7 + 64) * fVar14;
              }
              fVar19 = local_2a0;
              if (fVar14 != 0.0) {
                fVar15 = -fVar20;
                fVar16 = fVar14 + fVar17;
                fVar19 = fVar15 - fVar21;
                uVar8 = caret;
                fVar18 = fVar17;
                if ((float)*(int *)(pStatics + 68) <
                    fVar16 + *(float *)(pStatics + 140)) {
                  if (fVar17 == 0.0) {
                    return;
                  }
                  if ((bool)(bVar3 & caret != null)) {
                    uVar8 = 0;
                    if (*(int *)(pStatics + 40) != 1) {
                      NGUIText.Align(caret,local_294,
                                      fVar17 - *(float *)(pStatics + 140),4,0)
                      ;
                    }
                  }
                  if (highlight != null) {
                    if (bVar2) {
                      bVar2 = false;
                      local_130 = 0;
                      local_188 = CONCAT44((float)local_28c,fVar22);
                      local_180 = 0;
                      FUN_181805a40(highlight,&local_188,DAT_181d84278);
                      local_120 = 0;
                      pfVar9 = (float *)&local_178;
                      local_178 = CONCAT44(local_2a0,local_29c);
                      local_170 = 0;
        LAB_18158b689:
                      FUN_181805a40(highlight,pfVar9);
                    }
                    else if (((int)local_290 <= iVar10) && (iVar10 < (int)start)) {
                      local_1a0 = 0;
                      local_1a8 = fVar17;
                      local_1a4 = fVar19;
                      FUN_181805a40(highlight,&local_1a8,DAT_181d84278);
                      local_1b0 = 0;
                      local_1b8 = fVar17;
                      local_1b4 = fVar15;
                      FUN_181805a40(highlight,&local_1b8,DAT_181d84278);
                      local_190 = 0;
                      local_198 = fVar17 + 2.0;
                      local_194 = fVar15;
                      FUN_181805a40(highlight,&local_198,DAT_181d84278);
                      local_210 = 0;
                      pfVar9 = &local_218;
                      local_218 = fVar17 + 2.0;
                      local_214 = fVar19;
                      goto LAB_18158b689;
                    }
                    if ((*(int *)(pStatics + 40) != 1) &&
                       ((int)uVar13 < *(int *)(highlight + 24))) {
                      NGUIText.Align(highlight,uVar13,
                                      fVar17 - *(float *)(pStatics + 140),4,0)
                      ;
                      uVar13 = *(uint32 *)(highlight + 24);
                    }
                  }
                  fVar16 = fVar16 - fVar17;
                  fVar17 = fVar17 - fVar17;
                  fVar18 = 0.0;
                  fVar1 = *(float *)(pStatics + 144);
                  fVar19 = fVar19 - fVar1;
                  fVar15 = fVar15 - fVar1;
                  fVar20 = fVar20 + fVar1;
                }
                fVar1 = *(float *)(pStatics + 140);
                if (highlight != null) {
                  if ((iVar10 < (int)local_290) || ((int)start <= iVar10)) {
                    if (bVar2) {
                      bVar2 = false;
                      local_110 = 0;
                      local_168 = CONCAT44((float)local_28c,fVar22);
                      local_160 = 0;
                      FUN_181805a40(highlight,&local_168,DAT_181d84278);
                      local_100 = 0;
                      pfVar9 = (float *)&local_158;
                      local_158 = CONCAT44(local_2a0,local_29c);
                      local_150 = 0;
                      goto LAB_18158b88d;
                    }
                  }
                  else if (!bVar2) {
                    bVar2 = true;
                    local_200 = 0;
                    local_208 = fVar17;
                    local_204 = fVar19;
                    FUN_181805a40(highlight,&local_208,DAT_181d84278);
                    pfVar9 = &local_1f8;
                    local_1f0 = 0;
                    local_1f8 = fVar17;
                    local_1f4 = fVar15;
        LAB_18158b88d:
                    FUN_181805a40(highlight,pfVar9);
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
        LAB_18158bb61:
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
            FUN_181805a40(caret,&local_2b8,DAT_181d84278);
            local_2b0 = 0;
            local_2b8 = fVar17 - 1.0;
            local_2b4 = fVar16;
            FUN_181805a40(caret,&local_2b8,DAT_181d84278);
            local_2b0 = 0;
            local_2b8 = fVar17 + 1.0;
            local_2b4 = fVar16;
            FUN_181805a40(caret,&local_2b8,DAT_181d84278);
            local_2b0 = 0;
            local_2b8 = fVar17 + 1.0;
            local_2b4 = fVar16 - fVar21;
            FUN_181805a40(caret,&local_2b8,DAT_181d84278);
          }
          if (*(int *)(pStatics + 40) != 1) {
            NGUIText.Align(caret,local_294,
                            fVar17 - *(float *)(pStatics + 140),4,0);
          }
        }
        if (highlight != null) {
          if (bVar2) {
            local_260 = 0;
            local_278 = CONCAT44(fVar15,fVar22);
            local_270 = 0;
            FUN_181805a40(highlight,&local_278,DAT_181d84278);
            local_260 = 0;
            pfVar9 = (float *)&local_278;
            local_278 = CONCAT44(local_2a0,local_29c);
            local_270 = 0;
        LAB_18158be18:
            FUN_181805a40(highlight,pfVar9,DAT_181d84278);
          }
          else if (((int)local_290 < (int)uVar11) && (start == uVar11)) {
            fVar20 = -fVar20;
            local_2b0 = 0;
            local_2b8 = fVar17;
            local_2b4 = fVar20 - fVar21;
            FUN_181805a40(highlight,&local_2b8,DAT_181d84278);
            local_2b0 = 0;
            local_2b8 = fVar17;
            local_2b4 = fVar20;
            FUN_181805a40(highlight,&local_2b8,DAT_181d84278);
            local_2b0 = 0;
            local_2b8 = fVar17 + 2.0;
            local_2b4 = fVar20;
            FUN_181805a40(highlight,&local_2b8,DAT_181d84278);
            pfVar9 = &local_2b8;
            local_2b0 = 0;
            local_2b8 = fVar17 + 2.0;
            local_2b4 = fVar20 - fVar21;
            goto LAB_18158be18;
          }
          if ((*(int *)(pStatics + 40) != 1) &&
             ((int)uVar13 < *(int *)(highlight + 24))) {
            NGUIText.Align(highlight,uVar13,fVar17 - *(float *)(pStatics + 140)
                            ,4,0);
          }
        }
        lVar7 = *(int64 *)(pStatics + 176);
        if (lVar7 != null) {
          BetterList_1.Clear(lVar7,DAT_181d80e98);
          return;
        }
    }

    // Token : 0x60003AC
    // RVA   : 0x158EA70   Offset: 0x158D270   Length: 0x6D6
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
            uVar5 = FUN_1800d60b0(DAT_181d7c118,5);
            RuntimeHelpers.InitializeArray(uVar5,DAT_181d91c70,0);
            if (lVar7 != null) {
              iVar11 = String.IndexOfAny(lVar7,uVar5,iVar3,0);
              if (iVar11 == -1) {
                if (*text == null) throw; // [null/range check failed]
                iVar11 = *(int *)(*text + 16);
              }
              lVar7 = *text;
              lVar6 = FUN_1800d60b0(DAT_181d7c118,2);
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
                          cVar1 = FUN_180d6ca90(prefix,0);
                          if (!cVar1) {
                            lVar7 = String.Concat(lVar7,prefix,0);
                          }
                          plVar9 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,6);
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
                              cVar1 = FUN_180d6ca90(suffix,0);
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

    // Token : 0x60003AD
    // RVA   : 0x1588F10   Offset: 0x1587710   Length: 0x384
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
              cVar1 = FUN_180d6ca90(prefix,0);
              if (!cVar1) {
                uVar6 = String.Concat(prefix,uVar6,0);
              }
              cVar1 = FUN_180d6ca90(suffix,0);
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

    // Token : 0x60003AE
    // RVA   : 0x158F150   Offset: 0x158D950   Length: 0x13F
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

    // Token : 0x60003AF
    // RVA   : 0x1591A30   Offset: 0x1590230   Length: 0x3B7
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        long lVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar5;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        uVar5 = new c.DisplayClass9_0(0);
        puVar7 = (uint64 *)(pStatics + 16);
        *puVar7 = uVar5;
        il2cpp_internal(puVar7,uVar5);
        *(uint32 *)(pStatics + 24) = 16;
        *(uint32 *)(pStatics + 28) = 0x3f800000;
        *(uint32 *)(pStatics + 32) = 0x3f800000;
        *(uint32 *)(pStatics + 36) = 0;
        *(uint32 *)(pStatics + 40) = 1;
        puVar6 = (uint32 *)FUN_181098a50(local_18,0);
        uVar2 = puVar6[1];
        uVar3 = puVar6[2];
        uVar4 = puVar6[3];
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 44) = *puVar6;
        *(uint32 *)(lVar1 + 48) = uVar2;
        *(uint32 *)(lVar1 + 52) = uVar3;
        *(uint32 *)(lVar1 + 56) = uVar4;
        *(uint32 *)(pStatics + 60) = 1000000;
        *(uint32 *)(pStatics + 64) = 1000000;
        *(uint32 *)(pStatics + 68) = 1000000;
        *(uint32 *)(pStatics + 72) = 1000000;
        *(uint32 *)(pStatics + 76) = 0;
        *(uint8 *)(pStatics + 80) = 0;
        puVar6 = (uint32 *)FUN_181098a50(local_18,0);
        uVar2 = puVar6[1];
        uVar3 = puVar6[2];
        uVar4 = puVar6[3];
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 84) = *puVar6;
        *(uint32 *)(lVar1 + 88) = uVar2;
        *(uint32 *)(lVar1 + 92) = uVar3;
        *(uint32 *)(lVar1 + 96) = uVar4;
        puVar7 = (uint64 *)FUN_181098a50(local_18,0);
        uVar5 = puVar7[1];
        lVar1 = pStatics;
        *(uint64 *)(lVar1 + 100) = *puVar7;
        *(uint64 *)(lVar1 + 108) = uVar5;
        *(uint8 *)(pStatics + 116) = 0;
        *(uint32 *)(pStatics + 120) = 0;
        *(uint32 *)(pStatics + 124) = 0;
        *(uint8 *)(pStatics + 128) = 0;
        *(uint32 *)(pStatics + 136) = 0;
        *(uint32 *)(pStatics + 140) = 0;
        *(uint32 *)(pStatics + 144) = 0;
        *(uint32 *)(pStatics + 148) = 0;
        *(uint8 *)(pStatics + 152) = 0;
        local_28 = 0;
        uStack_20 = 0;
        FUN_1809981e0(&local_28,lVar1,0,0,0,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 156) = (uint32)local_28;
        *(uint32 *)(lVar1 + 160) = local_28._4_4_;
        *(uint32 *)(lVar1 + 164) = (uint32)uStack_20;
        *(uint32 *)(lVar1 + 168) = uStack_20._4_4_;
        uVar5 = new BetterList_1(DAT_181d80d98);
        puVar7 = (uint64 *)(pStatics + 176);
        *puVar7 = uVar5;
        il2cpp_internal(puVar7,uVar5);
        *(uint32 *)(pStatics + 184) = 0x3f800000;
        uVar5 = new BetterList_1(DAT_181d80f98);
        puVar7 = (uint64 *)(pStatics + 240);
        *puVar7 = uVar5;
        il2cpp_internal(puVar7,uVar5);
        uVar5 = FUN_1800d60b0(DAT_181d80340,8);
        RuntimeHelpers.InitializeArray(uVar5,DAT_181d91be8,0);
        puVar7 = (uint64 *)(pStatics + 0x120);
        *puVar7 = uVar5;
        il2cpp_internal(puVar7,uVar5);
    }

}
